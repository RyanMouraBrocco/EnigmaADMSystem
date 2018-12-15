using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass;
using EnigmaClass.CRUD;

namespace EnigmaADMSystem
{
    public partial class Form_ControleForum : Form
    {
        List<Pergunta> perguntas = new List<Pergunta>();
        List<Resposta> respostas = new List<Resposta>();
        public Form_ControleForum()
        {
            InitializeComponent();
            Carregar();
        }

        void Carregar()
        {
            try
            {
                PerguntaDAL dalpergunta = new PerguntaDAL();
                dalpergunta.RemoverDenunciadas();
                RespostaDAL dalresp = new RespostaDAL();
                dalresp.RemoverDenunciadas();
                CarregarPerguntas();
            }
            catch
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Form_ControleForum_Load(object sender, EventArgs e)
        {
        }

        void CarregarPerguntas()
        {
            try
            {
                perguntas.Clear();
                respostas.Clear();
                Grid_Respostas.Rows.Clear();
                Grid_Perguntas.Rows.Clear();
                int linha = 0;
                PerguntaDAL dalpergunta = new PerguntaDAL();
                perguntas = dalpergunta.ConsultarTodos();
                foreach (var item in perguntas)
                {
                    Grid_Perguntas.Rows.Add();
                    Grid_Perguntas.Rows[linha].Cells[0].Value = item.Titulo;
                    UsuarioDAL dalus = new UsuarioDAL();
                    Usuario u = new Usuario();
                    u = dalus.Consultar(item.Usuario);
                    Grid_Perguntas.Rows[linha].Cells[1].Value = u.Nome;
                    AvaliacaoDAL dalaval = new AvaliacaoDAL();
                    Grid_Perguntas.Rows[linha].Cells[2].Value = dalaval.Denuncias(item.ID, 0);
                    Grid_Perguntas.Rows[linha].Cells[3].Value = item.ID;
                    linha += 1;
                }
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Grid_Perguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Perguntas.RowCount>0)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                foreach (var item in perguntas.Where(x=>x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[3].Value)))
                {
                    CarregarRespostas(item);
                }
                load.Close();
            }
        }

        void CarregarRespostas(Pergunta pergunta)
        {
            try
            {
                respostas.Clear();
                Grid_Respostas.Rows.Clear();
                int linha = 0;
                PerguntaDAL dal = new PerguntaDAL();
                pergunta = dal.Consultar(pergunta.ID);
                foreach (var item in pergunta.Resposta)
                {
                    respostas.Add(item);
                    Grid_Respostas.Rows.Add();
                    Grid_Respostas.Rows[linha].Cells[0].Value = item.Titulo;
                    UsuarioDAL dalus = new UsuarioDAL();
                    Usuario u = new Usuario();
                    u = dalus.Consultar(item.Usuario);
                    Grid_Respostas.Rows[linha].Cells[1].Value = u.Nome;
                    AvaliacaoDAL dalaval = new AvaliacaoDAL();
                    Grid_Respostas.Rows[linha].Cells[2].Value = dalaval.Denuncias(item.ID, 0);
                    Grid_Respostas.Rows[linha].Cells[3].Value = item.ID;
                    linha += 1;
                }
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Perguntas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Grid_Perguntas.SelectedRows!=null)
                {
                    if (MessageBox.Show("Realmente deseja banir essa PERGUNTA ?","EnigmaADMSys",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.Yes)
                    {
                        try
                        {
                            PerguntaDAL dal = new PerguntaDAL();
                            foreach (var item in perguntas.Where(x => x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[3].Value)))
                            {
                                item.Usuario = UsuarioAtual.ID;
                                dal.RemoverDenunciadas(item);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        CarregarPerguntas();
                    }
                }
            }
        }

        private void Grid_Respostas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Grid_Respostas.SelectedRows!=null)
                {
                    if (MessageBox.Show("Realmente deseja banir essa RESPOSTA ?", "EnigmaADMSys", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (var item in respostas.Where(x=>x.ID==Convert.ToInt32(Grid_Respostas.CurrentRow.Cells[3].Value)))
                        {
                            try
                            {
                                item.Usuario = UsuarioAtual.ID;
                                RespostaDAL dal = new RespostaDAL();
                                dal.RemoverDenunciadas(item);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            foreach (var i in perguntas.Where(x=>x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[3].Value)))
                            {
                                CarregarRespostas(i);
                            }
                        }
                    }
                }
            }
        }

        private void Grid_Perguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (perguntas.Count>0)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                foreach (var item in perguntas.Where(x => x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[3].Value)))
                {
                    try
                    {
                        PerguntaDAL dal = new PerguntaDAL();
                        Form frm = new Form_VisualizarPergunta(dal.Consultar(item.ID));
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                load.Close();
            }
        }

        private void Grid_Respostas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (respostas.Count>0)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                foreach (var item in respostas.Where(x => x.ID == Convert.ToInt32(Grid_Respostas.CurrentRow.Cells[3].Value)))
                {
                    try
                    {
                        RespostaDAL dal = new RespostaDAL();
                        Form frm = new Form_VisualizarPergunta(dal.Consultar(item.ID));
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                load.Close();
            }
        }
    }
}
