using EnigmaClass;
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
using System.IO;

namespace EnigmaADMSystem
{
    public partial class Form_CriarExercicio : Form
    {
        bool processar = true;
        List<Questao> Questoes = new List<Questao>();
        List<Alternativa> Alternativas = new List<Alternativa>();
        List<Imagem> Imagens = new List<Imagem>();
        Conteudo _Conteudo = new Conteudo();
        Exercicio exercicio = new Exercicio();
        bool cadastrar = true;
        public Form_CriarExercicio(Conteudo C)
        {
            InitializeComponent();
            _Conteudo = C;
            Lbl_Titulo.Text = "Criar Exercício - " + _Conteudo.Nome;
        }
        public Form_CriarExercicio(Exercicio E)
        {
            InitializeComponent();
            cadastrar = false;
            Lbl_Titulo.Text = "Editar Exercício - " + E.Descricao;
            Txt_DescricaoEx.Text = E.Descricao;
            Txt_DescricaoEx.Enabled = false;
            foreach (var item in E.Questao)
            {
                List_Questao.Items.Add(item.Pergunta);
            }
            List_Questao.Enabled = true;
            CB_QuestaoAleatoria.Enabled = false;
            this.exercicio = E;
        }

        private void Form_CriarExercicio_Load(object sender, EventArgs e)
        {
            RB_Alternativa.Checked = true;
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_ADDAlt.BackColor = cor;
            Btn_ADDQuse.BackColor = cor;
            Btn_Salvar.BackColor = cor;
        }

        void AddQuestao()
        {
            if (RB_Alternativa.Checked == false && RB_Completar.Checked == false)
            {
                MessageBox.Show("Selecione o estilo da questão", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (List_Alternativa.Items.Count == 0)
            {
                MessageBox.Show("Coloque as alternativas", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            bool Correta = false;
            foreach (var item in Alternativas)
            {
                if (item.Tipo == "C")
                {
                    Correta = true;
                    break;
                }
            }
            if (Correta == false)
            {
                MessageBox.Show("Coloque uma alternativa correta", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (processar)
            {
                //Questao q = new Questao(null, List_Alternativa.Items.Count + 1, false, Txt_PerguntaQu.Text.Trim(), "", Imagens, Alternativas, UsuarioAtual.ID);
                Questao q = new Questao
                {
                    Imagem = new List<Imagem>(),
                    AleatorioAlternativa = false,
                    Usuario = UsuarioAtual.ID,
                    Pergunta = Txt_PerguntaQu.Text.Trim(),
                    Ordem = List_Questao.Items.Count + 1,
                    Alternativa = new List<Alternativa>(),
                    Tipo = "",
                    ID = 0,
                    Exercicio = null
                };
                foreach (var item in Alternativas)
                {
                    q.Alternativa.Add(item);
                }
                foreach (var item in Imagens)
                {
                    q.Imagem.Add(item);
                }
                if (RB_Alternativa.Checked == true)
                {
                    q.Tipo = "A";
                }
                else
                {
                    q.Tipo = "C";
                }
                if (CB_AleatorioAlternativa.Checked == true)
                {
                    q.AleatorioAlternativa = true;
                }
                List_Questao.Items.Add(Txt_PerguntaQu.Text.Trim());
                if (cadastrar)
                {
                    Questoes.Add(q);
                }
                else
                {
                    exercicio.Questao.Add(q);
                }
                Alternativas.Clear();
                List_Alternativa.Items.Clear();
                Imagens.Clear();
                List_Imagem.Items.Clear();
                Txt_PerguntaQu.Clear();
                RB_Completar.Enabled = true;
                RB_Alternativa.Enabled = true;
            }

            processar = true;
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void Salvar()
        {
            if (cadastrar)
            {
                if (Txt_DescricaoEx.Text.Trim() == "")
                {
                    MessageBox.Show("Digite a descrição ", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                if (List_Questao.Items.Count == 0)
                {
                    MessageBox.Show("Crie Questoes", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                if (processar)
                {
                    Form load = new Form_Load();
                    load.Show();
                    load.Refresh();
                    try
                    {
                        Exercicio E = new Exercicio
                        {
                            Descricao = Txt_DescricaoEx.Text.Trim(),
                            Conteudo = _Conteudo,
                            Questao = Questoes,
                            Usuario = UsuarioAtual.ID,
                            Tipo = "E",
                            AleatorioQuestao = false
                        };
                        if (CB_QuestaoAleatoria.Checked == true)
                        {
                            E.AleatorioQuestao = true;
                        }
                        ExercicioDAL dal = new ExercicioDAL();
                        E.ID = dal.Criar(E);
                        foreach (var item in E.Questao.OrderBy(x => x.Ordem))
                        {
                            item.Exercicio = E;
                            QuestaoDAL dalq = new QuestaoDAL();
                            foreach (var itemimg in item.Imagem)
                            {
                                ImagemDAL dalimg = new ImagemDAL();
                                itemimg.ID = dalimg.Inserir(itemimg);
                            }
                            item.ID = dalq.Criar(item);
                            foreach (var itemalt in item.Alternativa)
                            {
                                itemalt.Questao = item;
                                AlternativaDAL dalalt = new AlternativaDAL();
                                dalalt.Criar(itemalt);
                            }
                        }
                        MessageBox.Show("Exercício criado com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load.Close();
                        Close();
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    load.Close();
                }
            }
            else
            {
                Program._ex = exercicio;
                Close();
            }
            processar = true;
        }
        

        void AddAlternativa()
        {
            if (Txt_ConteudoAlt.Text.Trim() == "")
            {
                MessageBox.Show("Digite o conteudo  da alternativa", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (Check_Correta.Checked == true && RB_Alternativa.Checked == true)
            {
                bool Possui = false;
                foreach (var item in Alternativas)
                {
                    if (item.Tipo == "C")
                    {
                        Possui = true;
                        break;
                    }
                }
                if (Possui)
                {
                    MessageBox.Show("digite apenas uma resposta certa", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
            }
            if (processar)
            {
                Alternativa a = new Alternativa
                {
                    Conteudo = Txt_ConteudoAlt.Text.Trim(),
                    Ordem = List_Alternativa.Items.Count + 1,
                    Usuario = UsuarioAtual.ID,
                    Tipo = "E",
                    ID = 0,
                    Questao = null
                };
                if (Check_Correta.Checked == true)
                {
                    a.Tipo = "C";
                }
                Alternativas.Add(a);
                List_Alternativa.Items.Add(Txt_ConteudoAlt.Text.Trim());
                Txt_ConteudoAlt.Clear();
                if (RB_Alternativa.Checked)
                {
                    Check_Correta.Checked = false;
                }
                RB_Completar.Enabled = false;
                RB_Alternativa.Enabled = false;
            }
            processar = true;
        }

        private void RB_Completar_CheckedChanged(object sender, EventArgs e)
        {

            if (RB_Completar.Checked == true)
            {
                Check_Correta.Checked = true;
                Check_Correta.Enabled = false;
                CB_AleatorioAlternativa.Enabled = false;
                CB_AleatorioAlternativa.Checked = false;
            }
            else
            {
                Check_Correta.Checked = false;
                Check_Correta.Enabled = true;
                CB_AleatorioAlternativa.Enabled = true;
                CB_AleatorioAlternativa.Checked = false;
            }
        }

        private void LLBL_AddImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (OpenFile.ShowDialog()==DialogResult.OK)
            {
                Imagem i = new Imagem
                {
                    Nome = Path.GetFileName(OpenFile.FileName),
                    Extensao = Path.GetExtension(OpenFile.FileName),
                    Usuario = UsuarioAtual.ID,
                    _Imagem = File.ReadAllBytes(OpenFile.FileName),
                    ID =0
                };
                Imagens.Add(i);
                List_Imagem.Items.Add(Path.GetFileName(OpenFile.FileName));
            }
        }

     

        private void List_Imagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (List_Imagem.SelectedItem != null)
                {
                    Imagens.RemoveAt(List_Imagem.SelectedIndex);
                    List_Imagem.Items.RemoveAt(List_Imagem.SelectedIndex);
                }
            }
        }

        private void List_Questao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (cadastrar)
                {
                    if (List_Questao.SelectedItem!=null)
                    {
                        Questoes.RemoveAt(List_Questao.SelectedIndex);
                        List_Questao.Items.RemoveAt(List_Questao.SelectedIndex);
                    }
                    int ordem = 1;
                    foreach (var item in Questoes)
                    {
                        item.Ordem = ordem;
                        ordem += 1;
                    }
                }
            }
        }

        private void List_Alternativa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (List_Alternativa.SelectedItem != null)
                {
                    Alternativas.RemoveAt(List_Alternativa.SelectedIndex);
                    List_Alternativa.Items.RemoveAt(List_Alternativa.SelectedIndex);
                }
                int ordem = 1;
                foreach (var item in Alternativas)
                {
                    item.Ordem = ordem;
                    ordem += 1;
                }
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ADDQuse_Click(object sender, EventArgs e)
        {
            AddQuestao();
        }

        private void Btn_ADDAlt_Click(object sender, EventArgs e)
        {
            AddAlternativa();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
