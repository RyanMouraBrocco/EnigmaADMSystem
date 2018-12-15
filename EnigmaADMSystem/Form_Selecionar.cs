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
    public partial class Form_Selecionar : Form
    {
        List<Materia> materias = null;
        List<Conteudo> conteudos = null;
        public Form_Selecionar()
        {
            InitializeComponent();
        }

        public Form_Selecionar(List<Conteudo> conteudos)
        {
            InitializeComponent();
            Lbl_Titulo.Text = "Selecionar-Conteúdo";
            this.conteudos = new List<Conteudo>();
            this.conteudos = conteudos;
            CarregarGridConteudo("");
            LL_NovaMateria.Text = "Novo Conteúdo";
            Pb_Subir.Visible = true;
        }

        public Form_Selecionar(List<Materia> materias)
        {
            InitializeComponent();
            this.materias = new List<Materia>();
            this.materias = materias;
            Lbl_Titulo.Text = "Selecionar-Matéria";
            CarregarGridMateria("");
        }

        void CarregarGridMateria(string pesquisa)
        {
            Grid.Rows.Clear();
            if (pesquisa=="")
            {
                int linha = 0;
                foreach (var item in materias)
                {
                    Grid.Rows.Add();
                    Grid.Rows[linha].Cells[0].Value = item.Nome;
                    Grid.Rows[linha].Cells[1].Value = item.Descricao;
                    Grid.Rows[linha].Cells[2].Value = linha+1;
                    Grid.Rows[linha].Cells[3].Value = item.ID.ToString();
                    linha += 1;
                }
            }
            else
            {
                int linha = 0;
                foreach (var item in materias.Where(x=>x.Nome.ToUpper().Contains(pesquisa.ToUpper())))
                {
                    Grid.Rows.Add();
                    Grid.Rows[linha].Cells[0].Value = item.Nome;
                    Grid.Rows[linha].Cells[1].Value = item.Descricao;
                    Grid.Rows[linha].Cells[2].Value = linha + 1;
                    Grid.Rows[linha].Cells[3].Value = item.ID.ToString();
                    linha += 1;
                }
            }
        }
        void CarregarGridConteudo(string pesquisa)
        {
            Grid.Rows.Clear();
            if (pesquisa == "")
            {
                int linha = 0;
                foreach (var item in conteudos.OrderBy(x=>x.Ordem))
                {
                    Grid.Rows.Add();
                    Grid.Rows[linha].Cells[0].Value = item.Nome;
                    Grid.Rows[linha].Cells[1].Value = item.Materia.Nome;
                    Grid.Rows[linha].Cells[2].Value = item.Ordem.ToString();
                    Grid.Rows[linha].Cells[3].Value = item.ID.ToString();
                    linha += 1;
                }
            }
            else
            {
                int linha = 0;
                foreach (var item in conteudos.Where(x => x.Nome.ToUpper().Contains(pesquisa.ToUpper())).OrderBy(x=>x.Ordem))
                {
                    Grid.Rows.Add();
                    Grid.Rows[linha].Cells[0].Value = item.Nome;
                    Grid.Rows[linha].Cells[1].Value = item.Materia.Nome;
                    Grid.Rows[linha].Cells[2].Value = item.Ordem.ToString();
                    Grid.Rows[linha].Cells[3].Value = item.ID.ToString();
                    linha += 1;
                }
            }
        }

        private void Form_Selecionar_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Editar.BackColor = cor;
        }

        void Editar()
        {
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                if (materias != null)
                {
                    if (Grid.Rows.Count != 0)
                    {
                        MateriaDAL dal = new MateriaDAL();
                        Form alterar = new Form_CadastroMateria(dal.Consultar(Convert.ToInt32(Grid.CurrentRow.Cells[3].Value)));
                        alterar.MdiParent = this.MdiParent;
                        alterar.Show();
                        load.Close();
                        this.Close();
                    }
                    else
                    {
                        load.Close();
                        MessageBox.Show("Não há matérias", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Grid.Rows.Count != 0)
                    {
                        ConteudoDAL dal = new ConteudoDAL();
                        Form alterar = new Form_CadastroConteudo(dal.Consultar(Convert.ToInt32(Grid.CurrentRow.Cells[3].Value)));
                        alterar.MdiParent = this.MdiParent;
                        alterar.Show();
                        load.Close();
                        this.Close();
                    }
                    else
                    {
                        load.Close();
                        MessageBox.Show("Não há conteúdos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                load.Close();
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (materias!=null)
            {
                CarregarGridMateria(Txt_Pesquisa.Text.Trim());
            }
            else
            {
                CarregarGridConteudo(Txt_Pesquisa.Text.Trim());
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Txt_Pesquisa.Clear();
        }
        
        private void LL_NovaMateria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (materias!=null)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                Form_CadastroMateria frm = new Form_CadastroMateria();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                load.Close();
            }
            else
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                try
                {
                    Materia esta = new Materia();
                    MateriaDAL dal = new MateriaDAL();
                    foreach (var item in conteudos)
                    {
                        esta = dal.Consultar(item.Materia.ID);
                        break;
                    }
                    Form_CadastroConteudo frm = new Form_CadastroConteudo(esta);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                catch 
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                load.Close();
            }
            
        }
        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Pb_Subir_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count>0)
            {
                int id = 0;
                int ordem = 0;
                foreach (var item in conteudos.Where(x=>x.Ordem == Convert.ToInt32(Grid.CurrentRow.Cells[2].Value)))
                {
                    item.Ordem -= 1;
                    ordem = item.Ordem;
                    id = item.ID;
                    ConteudoDAL dal = new ConteudoDAL();
                    dal.AlterarOrdem(item);
                }
                foreach (var item in conteudos.Where(x => x.Ordem == ordem))
                {
                    if (item.ID != id)
                    {
                        item.Ordem += 1;
                        ConteudoDAL dal = new ConteudoDAL();
                        dal.AlterarOrdem(item);
                    }
                }
                CarregarGridConteudo("");
            }
        }
    }
}
