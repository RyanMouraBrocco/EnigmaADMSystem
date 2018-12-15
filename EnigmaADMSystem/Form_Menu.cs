using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass.CRUD;
using EnigmaClass;

namespace EnigmaADMSystem
{
    public partial class Form_Menu : Form
    {
        Form home = new Form_Home();
        public Form_Menu()
        {
            InitializeComponent();
            foreach(Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    MdiClient ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.White;
                    break;
                }
            }
        }
        private void FecharFormulariosFilhos()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    if (Application.OpenForms[i]!=home)
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Color corpainel = ColorTranslator.FromHtml("#000449");
            Btn_Materia.BackColor = corpainel;
            PainelLateral.BackColor = corpainel;
            Txt_Nome.BackColor = corpainel;
            Txt_Nome.Text = UsuarioAtual.Nome;
            if (UsuarioAtual.Foto!=null)
            {
                MemoryStream ms = new MemoryStream(UsuarioAtual.Foto);
                PB_Foto.Image = Image.FromStream(ms);

            }
            home.MdiParent = this;
            home.Show();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(20, 20, PB_Foto.Width - 10, PB_Foto.Height - 10);
            gp.AddEllipse(new Rectangle(40, 5, PB_Foto.Width - 80, PB_Foto.Height - 8));
            Region rg = new Region(gp);
            PB_Foto.Region = rg;
            gp.AddEllipse(new Rectangle(37,2, PB_Foto.Width - 74, PB_Foto.Height - 2 ));
            rg = new Region(gp);
            PanelFundoImg.Region = rg;
            if (UsuarioAtual.TipoConta.Trim()=="C")
            {
                Lbl_Usuario.Visible = true;
                Pb_Usuario.Visible = true;
            }
            Program.Logoff = false;
        }
        Point Ponto = new Point();
        int x, y;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        


        void Materias()
        {
            FecharFormulariosFilhos();
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                MateriaDAL dal = new MateriaDAL();
                Form frm = new Form_Selecionar(dal.ConsultarTodos());
                frm.MdiParent = this;
                frm.Show();
                frm.Refresh();
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }

        private void Pb_Materia_Click(object sender, EventArgs e)
        {
            Materias();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Materias();
        }

        void Exercicios()
        {
            FecharFormulariosFilhos();
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                Form frm = new Form_SelecionarConteudo();
                frm.MdiParent = this;
                frm.Show();
                frm.Refresh();
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Exercicios();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Exercicios();
        }

        void Forum()
        {
            FecharFormulariosFilhos();
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                Form frm = new Form_ControleForum();
                frm.MdiParent = this;
                frm.Show();
                frm.Refresh();
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }
        private void Pb_Forum_Click(object sender, EventArgs e)
        {
            Forum();
        }

        private void Lbl_Forum_Click(object sender, EventArgs e)
        {
            Forum();
        }

        void Conteudos()
        {
            FecharFormulariosFilhos();
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                Form frm = new Form_CadastroConteudo();
                frm.MdiParent = this;
                frm.Show();
                frm.Refresh();
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Conteudos();
        }

        private void Pb_Conteudo_Click(object sender, EventArgs e)
        {
            Conteudos();
        }

        void Home()
        {
            FecharFormulariosFilhos();
        }

        private void Lbl_Home_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void Pb_Home_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PB_Foto_Click(object sender, EventArgs e)
        {

        }

        void Usuario()
        {
            FecharFormulariosFilhos();
            Form load = new Form_Load();
            load.Show();
            load.Refresh();
            try
            {
                Form frm = new Form_ControleUsuario();
                frm.MdiParent = this;
                frm.Show();
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load.Close();
        }
        private void Lbl_Usuario_Click(object sender, EventArgs e)
        {
            Usuario();
        }

        private void Pb_Usuario_Click(object sender, EventArgs e)
        {
            Usuario();
        }

        private void Pb_Sair_Click(object sender, EventArgs e)
        {
            Program.Logoff = true;
            this.Close();
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.Logoff)
            {
                UsuarioAtual.Email = "";
                UsuarioAtual.ID = 0;
                UsuarioAtual.Nome = "";
                UsuarioAtual.Senha = "";
                UsuarioAtual.TipoConta = "";
                Program.Login.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Ponto = MousePosition;
                Ponto.X -= x;
                Ponto.Y -= y;
                this.Location = Ponto;
                Application.DoEvents();
            }
        }
        

    }
}
