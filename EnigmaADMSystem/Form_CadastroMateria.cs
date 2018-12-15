using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass.CRUD;
using EnigmaClass;
using System.IO;

namespace EnigmaADMSystem
{
    public partial class Form_CadastroMateria : Form
    {
        bool processar = true;
        bool cadastrar = true;
        Materia materia;
        public Form_CadastroMateria()
        {
            InitializeComponent();
        }

        public Form_CadastroMateria(Materia materia)
        {
            InitializeComponent();
            this.cadastrar=false;
            this.materia = new Materia();
            this.materia = materia;
            Txt_Materia.Text = materia.Nome;
            Txt_Descricao.Text = materia.Descricao;
            if (materia.Imagem!=null)
            {
                MemoryStream ms = new MemoryStream(materia.Imagem);
                PB_Img.Image = Image.FromStream(ms);
            }
            LL_Conteudos.Visible = true;
        }
        

        void Salvar()
        {
            if (Txt_Materia.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome da matéria", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                try
                {
                    MateriaDAL dal = new MateriaDAL();
                    Materia m = new Materia();
                    m = dal.Consultar(Txt_Materia.Text.Trim());
                    if (cadastrar)
                    {
                        if (m.ID != 0)
                        {
                            MessageBox.Show("Matéria já existente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                    }
                    else
                    {
                        if (m.ID != 0 && m.ID != materia.ID)
                        {
                            MessageBox.Show("Matéria já existente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
            }
            if (Txt_Descricao.Text.Trim() == "")
            {
                MessageBox.Show("Digite a descrição da matéria", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                try
                {
                    MateriaDAL dal = new MateriaDAL();
                    if (cadastrar)
                    {
                        Materia m = new Materia
                        {
                            Nome = Txt_Materia.Text.Trim(),
                            Descricao = Txt_Descricao.Text.Trim(),
                            Usuario = UsuarioAtual.ID,
                            Imagem = null
                        };
                        if (PB_Img.Image != null)
                        {
                            m.Imagem = File.ReadAllBytes(PB_Img.ImageLocation);
                        }
                        dal.Inserir(m);
                        MessageBox.Show("Nova matéria inserida com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        materia.Nome = Txt_Materia.Text.Trim();
                        materia.Descricao = Txt_Descricao.Text.Trim();
                        materia.Usuario = UsuarioAtual.ID;
                        if (PB_Img.Image != null)
                        {
                            try
                            {
                                materia.Imagem = File.ReadAllBytes(PB_Img.ImageLocation);
                            }
                            catch
                            {

                            }
                        }
                        else
                        {
                            materia.Imagem = null;
                        }
                        dal.Alterar(materia);
                        MessageBox.Show("Matéria atualizada com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load.Close();
                        this.Close();
                    }
                    LimparCampos();
                }
                catch 
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                load.Close();
            }
            processar = true;
        }
        

        void AddImagem()
        {
            FileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_Img.ImageLocation = FileDialog.FileName;
            }
        }
        
        public void LimparCampos()
        {
            Txt_Descricao.Clear();
            Txt_Materia.Clear();
            PB_Img.Image = null;
        }

        private void Form_CadastroMateria_Load(object sender, EventArgs e)
        {
            //Materia m = new Materia();
            //MateriaDAL dal = new MateriaDAL();
            //m = dal.Consultar("Física");
            //MemoryStream ms = new MemoryStream(m.Imagem);
            //PB_Img.Image = Image.FromStream(ms);
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_AddImagem.BackColor = cor;
            Btn_Salvar.BackColor = cor;
        }

        private void Lbl_Apagar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PB_Img.Image = null;
        }

        private void LL_Conteudos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                ConteudoDAL dal = new ConteudoDAL();
                List<Conteudo> conteudos = new List<Conteudo>();
                conteudos = dal.ConsultarPorMateria(this.materia.ID);
                if (conteudos.Count > 0)
                {
                    Form frm = new Form_Selecionar(conteudos);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    if (MessageBox.Show("Não há conteúdos relacionados a essa matérias. Gostaria de Adicionar ?", "EnigmaADMSys", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form frm = new Form_CadastroConteudo();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }
        
        private void Btn_AddImagem_Click(object sender, EventArgs e)
        {
            AddImagem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
