using EnigmaClass;
using EnigmaClass.CRUD;
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

namespace EnigmaADMSystem
{
    public partial class Form_VisualizarPergunta : Form
    {
        int idpergunta;
        List<Imagem> Imagens = new List<Imagem>();
        bool cadastrar = false;
        bool processar = true;
        public Form_VisualizarPergunta(Pergunta pergunta)
        {
            InitializeComponent();
            Txt_Titulo.Text = pergunta.Titulo;
            Txt_PerguntaResposta.Text = pergunta.Texto;
            if (pergunta.Imagem!=null)
            {
                foreach (var item in pergunta.Imagem)
                {
                    Imagens.Add(item);
                }
            }
            CarregarImagens();
            label3.Text = "Pergunta";
            Ll_Responder.Visible = true;
            idpergunta = pergunta.ID;
        }

        public Form_VisualizarPergunta(Resposta resposta)
        {
            InitializeComponent();
            Txt_Titulo.Text = resposta.Titulo;
            Txt_PerguntaResposta.Text = resposta.Texto;
            if (resposta.Imagem != null)
            {
                foreach (var item in resposta.Imagem)
                {
                    Imagens.Add(item);
                }
            }
            CarregarImagens();
            label3.Text = "Resposta";
        }

        public Form_VisualizarPergunta(int idpergunta)
        {
            InitializeComponent();
            Txt_Titulo.ReadOnly = false;
            Txt_PerguntaResposta.ReadOnly = false;
            Lbl_PR.Text = "Resposta";
            Ll_Responder.Visible = false;
            Btn_Fechar.Text = "Salvar";
            Ll_AddImagem.Visible = true;
            cadastrar = true;
            this.idpergunta = idpergunta;
        }

        void Salvar()
        {
            if (Txt_Titulo.Text.Trim()=="")
            {
                MessageBox.Show("Digite o título da resposta","EnigmaADMSys",MessageBoxButtons.OK,MessageBoxIcon.Error);
                processar = false;
            }
            if (Txt_PerguntaResposta.Text.Trim()=="")
            {
                MessageBox.Show("Digite a resposta", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                try
                {
                    Resposta r = new Resposta
                    {
                        Imagem = Imagens,
                        Pergunta = new Pergunta { ID = idpergunta },
                        Texto = Txt_PerguntaResposta.Text.Trim(),
                        Titulo = Txt_Titulo.Text.Trim(),
                        Usuario = UsuarioAtual.ID,
                        Visibilidade = true
                    };
                    RespostaDAL dal = new RespostaDAL();
                    dal.Inserir(r);
                    MessageBox.Show("Resposta publicada com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
               catch
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                load.Close();
            }
            processar = true;
        }

        void CarregarImagens()
        {
            Grid_Imagens.Rows.Clear();
            int linha = 0;
            MemoryStream ms = new MemoryStream();
            foreach (var item in Imagens)
            {
                ms = new MemoryStream(item._Imagem);
                Grid_Imagens.Rows.Add();
                Grid_Imagens.Rows[linha].Cells[0].Value = linha + 1;
                Grid_Imagens.Rows[linha].Cells[1].Value = Image.FromStream(ms);
                linha += 1;
                ms = new MemoryStream();
            }
        }

        private void Form_VisualizarPergunta_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Fechar.BackColor = cor;
        }

        void Fechar()
        {
            this.Close();
        }
       

        private void Ll_Responder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_VisualizarPergunta Nova = new Form_VisualizarPergunta(idpergunta);
            Nova.MdiParent = this.MdiParent;
            Nova.Show();
        }

        private void Ll_AddImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Imagem imagem = new Imagem
                {
                    Extensao = Path.GetExtension(FileDialog.FileName),
                    Nome = Path.GetFileName(FileDialog.FileName),
                    Usuario = UsuarioAtual.ID,
                    _Imagem = File.ReadAllBytes(FileDialog.FileName)
                };
                Imagens.Add(imagem);
                CarregarImagens();
            }
        }

        private void Grid_Imagens_KeyUp(object sender, KeyEventArgs e)
        {
            if (cadastrar)
            {
                if (e.KeyCode==Keys.Delete)
                {
                    if (MessageBox.Show("Deseja realmente deletar esse item ?","EnigmaADMSys",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        Imagens.RemoveAt(Convert.ToInt32(Grid_Imagens.CurrentRow.Cells[0].Value) - 1);
                        CarregarImagens();
                    }
                }
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            if (cadastrar)
            {
                Salvar();
            }
            else
            {
                Fechar();
            }
        }
    }
}
