using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass;
using EnigmaClass.CRUD;

namespace EnigmaADMSystem
{
    public partial class Form_CadastroConteudo : Form
    {
        private List<ConteudoTexto> Conteudos = new List<ConteudoTexto>();
        private List<Resumo> Resumos = new List<Resumo>();
        private Conteudo conteudo = new Conteudo();
        bool processar = true;
        bool cadastrar = true;
        public Form_CadastroConteudo()
        {
            InitializeComponent();
            CarregarMaterias();
            Program._contText.Clear();
            Program._resum.Clear();
            Program.Salvar = false;
        }
        public Form_CadastroConteudo(Materia m)
        {
            InitializeComponent();
            CarregarMaterias();
            Program._contText.Clear();
            Program._resum.Clear();
            Program.Salvar = false;
            CB_Materia.Text = m.Nome;
        }
        public Form_CadastroConteudo(Conteudo conteudo)
        {
            InitializeComponent();
            CarregarMaterias();
            Program._contText.Clear();
            Program._resum.Clear();
            Program.Salvar = false;
            Txt_Nome.Text = conteudo.Nome;
            try
            {
                MateriaDAL dal = new MateriaDAL();
                conteudo.Materia = dal.Consultar(conteudo.Materia.ID);
            }
            catch
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            CB_Materia.Text = conteudo.Materia.Nome;
            Conteudos = conteudo.ConteudoTexto;
            Resumos = conteudo.Resumo;
            Program._resum = Resumos;
            CarregarResumos();
            CarregarConteudoTexto();
            cadastrar = false;
            if (conteudo.Imagem != null)
            {
                MemoryStream ms = new MemoryStream(conteudo.Imagem);
                PB_Foto.Image = Image.FromStream(ms);
            }
            this.conteudo = conteudo;
            foreach (var item in conteudo.ConteudoTexto)
            {
                Texto texto = null;
                Imagem imagem = null;
                Video video = null;
                if (item.Texto != null)
                {
                    texto = new Texto
                    {
                        Conteudo = item.Texto.Conteudo,
                        Cor = item.Texto.Cor,
                        Italico = item.Texto.Italico,
                        Negrito = item.Texto.Negrito,
                        Tamanho = item.Texto.Tamanho,
                        Usuario = item.Texto.Usuario,
                        ID = item.Texto.ID
                    };
                }
                if (item.Imagem != null)
                {
                    imagem = new Imagem
                    {
                        ID = item.Imagem.ID,
                        Extensao = item.Imagem.Extensao,
                        Nome = item.Imagem.Nome,
                        _Imagem = item.Imagem._Imagem,
                        Usuario = item.Imagem.Usuario
                    };
                }
                if (item.Video != null)
                {
                    video = new Video
                    {
                        Duracao = item.Video.Duracao,
                        Usuario = item.Video.Usuario,
                        Fim = item.Video.Fim,
                        ID = item.Video.ID,
                        Link = item.Video.Link,
                        Inicio = item.Video.Inicio,
                        Nome = item.Video.Nome
                    };
                }
                ConteudoTexto conteudoTexto = new ConteudoTexto
                {
                    ID = item.ID,
                    Video = video,
                    Imagem = imagem,
                    Conteudo = item.Conteudo,
                    Ordem = item.Ordem,
                    Texto = texto,
                    Usuario = item.Usuario
                };
                Program._contText.Add(conteudoTexto);
            }

        }

        void CarregarMaterias()
        {
            try
            {
                MateriaDAL dal = new MateriaDAL();
                List<Materia> MM = dal.ConsultarTodos();
                foreach (var item in MM)
                {
                    CB_Materia.Items.Add(item.Nome);
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void Form_CadastroConteudo_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Salvar.BackColor = cor;
            Btn_AddImagem.BackColor = cor;
            Btn_AlterarConteudo.BackColor = cor;
            Btn_Resumo.BackColor = cor;
            
        }

        void AddImagem()
        {
            FD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                PB_Foto.ImageLocation = FD.FileName;
            }
        }

        private void Lbl_Limpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PB_Foto.Image = null;
        }

        void Conteudotexto()
        {
            int index = 0;
            int[] ordem = new int[Conteudos.Count];
            foreach (var item in Conteudos)
            {
                ordem[index] = item.Ordem;
                index += 1;
            }
            Form_ConteudoTexto ct = new Form_ConteudoTexto(Conteudos);
            ct.ShowDialog();
            Conteudos.Clear();
            index = 0;
            foreach (var item in Program._contText)
            {
                if (Program.Salvar == false)
                {
                    item.Ordem = ordem[index];
                    index += 1;
                }
                Conteudos.Add(item);
            }
            Program.Salvar = false;
            CarregarConteudoTexto();
        }
        
        void CarregarConteudoTexto()
        {
            int linha = 0;
            Grid_Conteudo.Rows.Clear();
            foreach (var item in Conteudos.OrderBy(n => n.Ordem))
            {
                Grid_Conteudo.Rows.Add();
                if (item.Texto != null)
                {
                    Grid_Conteudo.Rows[linha].Cells[0].Value = item.Texto.Conteudo;
                    Grid_Conteudo.Rows[linha].Cells[1].Value = "Texto";
                }
                if (item.Imagem != null)
                {
                    Grid_Conteudo.Rows[linha].Cells[0].Value = item.Imagem.Nome;
                    Grid_Conteudo.Rows[linha].Cells[1].Value = "Imagem";
                }
                if (item.Video != null)
                {
                    Grid_Conteudo.Rows[linha].Cells[0].Value = item.Video.Nome;
                    Grid_Conteudo.Rows[linha].Cells[1].Value = "Vídeo";
                }
                Grid_Conteudo.Rows[linha].Cells[2].Value = item.Ordem;
                linha += 1;
            }
        }

        void Salvar()
        {
            if (Txt_Nome.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do conteudo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (CB_Materia.Text.Trim() == "")
            {
                MessageBox.Show("Selecione a matéria do conteudo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                try
                {
                    Materia m = new Materia();
                    MateriaDAL dal = new MateriaDAL();
                    m = dal.Consultar(CB_Materia.Text.Trim());
                    if (m.ID == 0)
                    {
                        MessageBox.Show("Selecione uma matéria válida", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
            }
            if (Grid_Conteudo.RowCount == 0)
            {
                MessageBox.Show("Insira os valores desse conteudo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                try
                {
                    Materia m = new Materia();
                    MateriaDAL dal = new MateriaDAL();
                    m = dal.Consultar(CB_Materia.Text.Trim());
                    ConteudoDAL dalcont = new ConteudoDAL();
                    if (cadastrar)
                    {
                        Conteudo cont = new Conteudo
                        {
                            Materia = m,
                            Nome = Txt_Nome.Text.Trim(),
                            Usuario = UsuarioAtual.ID,
                            Ordem = m.Conteudo.Count + 1,
                            Imagem = null
                        };
                        if (PB_Foto.Image != null)
                        {
                            cont.Imagem = File.ReadAllBytes(PB_Foto.ImageLocation);
                        }
                        cont.ID = dalcont.Inserir(cont);
                        m = dal.Consultar(m.ID);

                        foreach (var item in Conteudos.OrderBy(x => x.Ordem))
                        {
                            item.Conteudo = cont;
                            if (item.Texto != null)
                            {
                                TextoDAL daltex = new TextoDAL();
                                item.Texto.ID = daltex.Inserir(item.Texto);

                            }
                            if (item.Imagem != null)
                            {
                                ImagemDAL dalimg = new ImagemDAL();
                                item.Imagem.ID = dalimg.Inserir(item.Imagem);
                            }
                            if (item.Video != null)
                            {
                                VideoDAL dalvid = new VideoDAL();
                                item.Video.ID = dalvid.Inserir(item.Video);
                            }
                            ConteudoTextoDAL dalct = new ConteudoTextoDAL();
                            dalct.Inserir(item);
                        }
                        foreach (var item in Resumos)
                        {
                            item.Conteudo = cont;
                            ResumoDAL dalresum = new ResumoDAL();
                            dalresum.Inserir(item);
                        }
                        MessageBox.Show("Conteúdo cadastrado com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        conteudo.Materia = m;
                        conteudo.Nome = Txt_Nome.Text.Trim();
                        conteudo.Usuario = UsuarioAtual.ID;
                        if (PB_Foto.Image != null)
                        {
                            try
                            {
                                conteudo.Imagem = File.ReadAllBytes(PB_Foto.ImageLocation);
                            }
                            catch
                            {
                            }

                        }
                        else
                        {
                            conteudo.Imagem = null;
                        }
                        dalcont.Alterar(conteudo);

                        foreach (var item in Conteudos.OrderBy(x => x.Ordem))
                        {
                            item.Conteudo = conteudo;
                            if (item.Texto != null)
                            {
                                TextoDAL daltex = new TextoDAL();
                                item.Texto.ID = daltex.Inserir(item.Texto);

                            }
                            if (item.Imagem != null)
                            {
                                ImagemDAL dalimg = new ImagemDAL();
                                item.Imagem.ID = dalimg.Inserir(item.Imagem);
                            }
                            if (item.Video != null)
                            {
                                VideoDAL dalvid = new VideoDAL();
                                item.Video.ID = dalvid.Inserir(item.Video);
                            }
                            ConteudoTextoDAL dalct = new ConteudoTextoDAL();
                            dalct.Inserir(item);
                        }
                        foreach (var item in Resumos)
                        {
                            item.Conteudo = conteudo;
                            ResumoDAL dalresum = new ResumoDAL();
                            dalresum.Inserir(item);
                        }
                        MessageBox.Show("Conteúdo atualizado com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load.Close();
                        Close();
                    }
                }
                catch 
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                load.Close();
            }
            processar = true;
        }
       
        public void LimparCampos()
        {
            Txt_Nome.Clear();
            PB_Foto.Image = null;
            Grid_Conteudo.Rows.Clear();
            Grid_Resumo.Rows.Clear();
            Resumos.Clear();
            Conteudos.Clear();
            CB_Materia.Text = "";
        }
        void AddResumo()
        {
            Form_CadastroResumo frmresum = new Form_CadastroResumo(Resumos);
            frmresum.ShowDialog();
            Resumos = Program._resum;
            CarregarResumos();
        }
        void CarregarResumos()
        {
            Grid_Resumo.Rows.Clear();
            int linha = 0;
            foreach (var item in Resumos)
            {
                Grid_Resumo.Rows.Add();
                Grid_Resumo.Rows[linha].Cells[0].Value = item.NomeArquivo;
                linha += 1;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Btn_AddImagem_Click(object sender, EventArgs e)
        {
            AddImagem();
        }

        private void Btn_Resumo_Click(object sender, EventArgs e)
        {
            AddResumo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conteudotexto();
        }
    }
}
