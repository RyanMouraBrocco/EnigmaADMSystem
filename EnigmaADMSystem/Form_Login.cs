using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using EnigmaClass;
using EnigmaClass.CRUD;

namespace EnigmaADMSystem
{
    public partial class Form_Login : Form
    {
        bool processar = true;
        public Form_Login()
        {
            InitializeComponent();
            Program.Login = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string colorcode = "#000449";
            Color c = System.Drawing.ColorTranslator.FromHtml(colorcode);
            panel1.BackColor = c;
            //Usuario u = new Usuario
            //{
            //    Email = "ryan@email.com",
            //    Foto = null,
            //    Nome = "RyanBrocco",
            //    Senha = "1234",
            //    TipoConta = "C"
            //};
            //UsuarioDAL dal = new UsuarioDAL();
            //dal.Inserir(u);
        }
        
        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if (Txt_Email.Text.Trim()=="")
            {
                processar = false;
                MessageBox.Show("Preencha o Login", "Enigma ADM System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Txt_Senha.Text.Trim()=="")
            {
                processar = false;
                MessageBox.Show("Preencha a Senha", "Enigma ADM System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (processar)
            {
                Form_Load frm = new Form_Load();
                frm.Show();
                frm.Refresh();
                try
                {
                    Usuario u = new Usuario();
                    UsuarioDAL dal = new UsuarioDAL();
                    u = dal.Consultar(Txt_Email.Text.Trim().Replace(",", "."));
                    u.Senha = Txt_Senha.Text.Trim();
                    if (u.ID == 0)
                    {
                        frm.Close();
                        MessageBox.Show("Usuário inexistente", "Enigma ADM System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (u.TipoConta.Trim() == "C" || u.TipoConta.Trim() == "A")
                        {
                            if (dal.Logar(u.Email, u.Senha))
                            {
                                Form_Menu frmmenu = new Form_Menu();
                                UsuarioAtual.ID = u.ID;
                                UsuarioAtual.Email = u.Email;
                                UsuarioAtual.Nome = u.Nome;
                                UsuarioAtual.Senha = null;
                                UsuarioAtual.TipoConta = u.TipoConta;
                                UsuarioAtual.Foto = u.Foto;
                                this.Visible = false;
                                frmmenu.Show();
                                Txt_Email.Clear();
                                Txt_Senha.Clear();
                            }
                            else
                            {
                                frm.Close();
                                MessageBox.Show("Login ou Senha incorreto", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            frm.Close();
                            MessageBox.Show("Seu usuário não tem permissão para acessar !", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch 
                {
                    frm.Close();
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frm.Close();
            }
            processar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
