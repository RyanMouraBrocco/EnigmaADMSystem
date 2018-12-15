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
    public partial class Form_SelecionarConteudo : Form
    {
        bool processar = true;
        public Form_SelecionarConteudo()
        {
            InitializeComponent();
            CarregarMateria();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Criar.Text = "Editar";
        }

        void CarregarMateria()
        {
            try
            {
                List<Materia> m = new List<Materia>();
                MateriaDAL dal = new MateriaDAL();
                m = dal.ConsultarTodos();
                foreach (var item in m)
                {
                    LB_Materia.Items.Add(item.Nome);
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void Form_SelecionarConteudo_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Criar.BackColor = cor;
        }

        private void LB_Materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                Btn_Criar.Text = "Criar";
                LB_Conteudo.Items.Clear();
                LB_Exercicio.Items.Clear();
                MateriaDAL dal = new MateriaDAL();
                Materia m = new Materia();
                m = dal.Consultar(LB_Materia.SelectedItem.ToString());
                foreach (var item in m.Conteudo)
                {
                    LB_Conteudo.Items.Add(item.ID + " - " + item.Nome);
                }
            }
            catch
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }

        private void LB_Conteudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                LB_Exercicio.Items.Clear();
                LB_Exercicio.SelectedItem = null;
                Btn_Criar.Text = "Criar";
                ConteudoDAL dal = new ConteudoDAL();
                Conteudo C = new Conteudo();
                int tamanhoid = 0;
                for (int i = 0; i < LB_Conteudo.SelectedItem.ToString().Length; i++)
                {
                    if (LB_Conteudo.SelectedItem.ToString().Substring(i, 1) == "-")
                    {
                        tamanhoid = i;
                        break;
                    }
                }
                C = dal.Consultar(Convert.ToInt32(LB_Conteudo.SelectedItem.ToString().Substring(0, tamanhoid)));
                foreach (var item in C.Exercicio)
                {
                    LB_Exercicio.Items.Add(item.ID + " - " + item.Descricao);
                }
            }
            catch
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }

        void CriarEditar()
        {
            if (LB_Materia.SelectedItem == null)
            {
                MessageBox.Show("Selecione a matéria", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                if (LB_Conteudo.Items.Count == 0)
                {
                    MessageBox.Show("Crie um conteúdo para essa matéria antes de criar um exercício", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                else
                {
                    if (LB_Conteudo.SelectedItem == null)
                    {
                        MessageBox.Show("Selecione um conteúdo para criar um exercício", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                    }
                }
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                try
                {
                    if (Btn_Criar.Text == "Criar")
                    {
                        Conteudo c = new Conteudo();
                        ConteudoDAL dal = new ConteudoDAL();
                        int tamanhoid = 0;
                        for (int i = 0; i < LB_Conteudo.SelectedItem.ToString().Length; i++)
                        {
                            if (LB_Conteudo.SelectedItem.ToString().Substring(i, 1) == "-")
                            {
                                tamanhoid = i;
                                break;
                            }
                        }
                        c = dal.Consultar(Convert.ToInt32(LB_Conteudo.SelectedItem.ToString().Substring(0, tamanhoid)));
                        Form_CriarExercicio frm = new Form_CriarExercicio(c);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        load.Close();
                    }
                    else
                    {
                        Exercicio exercicio = new Exercicio();
                        ExercicioDAL dal = new ExercicioDAL();
                        int tamanhoid = 0;
                        for (int i = 0; i < LB_Exercicio.SelectedItem.ToString().Length; i++)
                        {
                            if (LB_Exercicio.SelectedItem.ToString().Substring(i, 1) == "-")
                            {
                                tamanhoid = i;
                                break;
                            }
                        }
                        exercicio = dal.Consultar(Convert.ToInt32(LB_Exercicio.SelectedItem.ToString().Substring(0, tamanhoid)));
                        Form frm = new Form_EditarExercicio(exercicio);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        load.Close();
                    }
                }
                catch
                {
                    load.Close();
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            processar = true;
        }

        private void Btn_Criar_Click(object sender, EventArgs e)
        {
            CriarEditar();
        }
    }
}
