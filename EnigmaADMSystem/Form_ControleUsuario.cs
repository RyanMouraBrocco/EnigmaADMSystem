using EnigmaClass;
using EnigmaClass.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaADMSystem
{
    public partial class Form_ControleUsuario : Form
    {
        bool processar = true;
        bool cadastrar = true;
        List<Usuario> Usuarios = new List<Usuario>();
        int id_este = 0;
        bool alterarsenha = true;
        public Form_ControleUsuario()
        {
            InitializeComponent();
            try
            {
                CarregarUsuarios();
            }
            catch 
            {
                this.Close();  
            }
            CarregarGrid();
        }

        void CarregarUsuarios()
        {
            UsuarioDAL dal = new UsuarioDAL();
            Usuarios = dal.ConsultarTodos();
        }

        void CarregarGrid()
        {
            Grid_Usuario.Rows.Clear();
            int linha = 0;
            foreach (var item in Usuarios)
            {
                Grid_Usuario.Rows.Add();
                Grid_Usuario.Rows[linha].Cells[0].Value = item.Nome;
                Grid_Usuario.Rows[linha].Cells[1].Value = item.Email;
                Grid_Usuario.Rows[linha].Cells[2].Value = item.TipoConta;
                Grid_Usuario.Rows[linha].Cells[3].Value = item.ID;
                linha += 1;
            }
        }
        void CarregarGrid(string busca)
        {
            Grid_Usuario.Rows.Clear();
            int linha = 0;
            foreach (var item in Usuarios.Where(x=>x.Nome.ToUpper().Contains(busca.ToUpper())|| x.Email.ToUpper().Contains(busca.ToUpper())))
            {
                Grid_Usuario.Rows.Add();
                Grid_Usuario.Rows[linha].Cells[0].Value = item.Nome;
                Grid_Usuario.Rows[linha].Cells[1].Value = item.Email;
                Grid_Usuario.Rows[linha].Cells[2].Value = item.TipoConta;
                Grid_Usuario.Rows[linha].Cells[3].Value = item.ID;
                linha += 1;
            }
        }

        void Salvar()
        {
            if (Txt_Nome.Text.Trim()=="")
            {
                processar = false;
                MessageBox.Show("Digite o Nome","EnigmaADMSys",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (Txt_Email.Text.Trim() == "")
            {
                processar = false;
                MessageBox.Show("Digite o Email", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Txt_Email.Text.Trim().Contains("@") || !Txt_Email.Text.Trim().Contains(".com"))
                {
                    processar = false;
                    MessageBox.Show("Email inválido", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UsuarioDAL dal = new UsuarioDAL();
                    Usuario u = new Usuario();
                    u = dal.Consultar(Txt_Email.Text.Trim());
                    if (cadastrar)
                    {
                        if (u.ID != 0)
                        {
                            processar = false;
                            MessageBox.Show("Email já cadastrado", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (u.ID!= 0 && u.ID != id_este)
                        {
                            processar = false;
                            MessageBox.Show("Email já cadastrado", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (alterarsenha)
            {
                if (Txt_Senha.Text.Trim() == "")
                {
                    processar = false;
                    MessageBox.Show("Digite a senha", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Txt_Senha.Text.Trim().Length != 8)
                    {
                        processar = false;
                        MessageBox.Show("A senha deve ter 8 digitos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Txt_Senha.Text.Trim() != Txt_ConfirmarSenha.Text.Trim())
                        {
                            processar = false;
                            MessageBox.Show("As senhas devem ser iguais", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (CB_Tipo.Text.Trim()=="")
            {
                processar = false;
                MessageBox.Show("Selecione um tipo de conta", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool correto = false;
                for (int i = 0; i < CB_Tipo.Items.Count; i++)
                {
                    if (CB_Tipo.Items[i].ToString() == CB_Tipo.Text.Trim())
                    {
                        correto = true;
                        break;
                    }
                }
                if (correto==false)
                {
                    processar = false;
                    MessageBox.Show("Selecione um tipo de conta válido", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                UsuarioDAL dal = new UsuarioDAL();
                if (cadastrar)
                {
                    try
                    {
                        Usuario novo = new Usuario
                        {
                            Nome = Txt_Nome.Text.Trim(),
                            Email = Txt_Email.Text.Trim().ToLower(),
                            Foto = null,
                            Senha = Txt_Senha.Text.Trim(),
                            TipoConta = CB_Tipo.Text.Substring(0, 1)
                        };
                        dal.Inserir(novo);
                        MessageBox.Show("Usuário inserido com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load.Close();
                        Cancelar();
                        LimparCampos();
                        CarregarUsuarios();
                        CarregarGrid();
                    }
                    catch 
                    {

                        load.Close();
                        MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Usuario este = dal.Consultar(id_este);
                        este.Nome = Txt_Nome.Text.Trim();
                        este.Email = Txt_Email.Text.Trim().ToLower();
                        este.TipoConta = CB_Tipo.Text.Trim().Substring(0, 1);
                        este.Senha = Txt_Senha.Text.Trim();
                        if (alterarsenha)
                        {
                            dal.Alterar(este);
                        }
                        else
                        {
                            dal.AlterarSemSenha(este);
                        }
                        MessageBox.Show("Usuário atualizado com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load.Close();
                        Cancelar();
                        LimparCampos();
                        CarregarUsuarios();
                        CarregarGrid();
                    }
                    catch (Exception)
                    {
                        load.Close();
                        MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            processar = true;
        }

        private void Form_ControleUsuario_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Atualizar.BackColor = cor;
        }
        

        private void Txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Pesquisar.Text.Trim()=="")
            {
                CarregarGrid();
            }
            else
            {
                CarregarGrid(Txt_Pesquisar.Text.Trim());
            }
        }
        
        private void Grid_Usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Usuario.Rows.Count>0)
            {
                foreach (var item in Usuarios.Where(x => x.ID == Convert.ToInt32(Grid_Usuario.CurrentRow.Cells[3].Value)))
                {
                    id_este = item.ID;
                    LimparCampos();
                    Txt_Email.Text = item.Email;
                    Txt_Nome.Text = item.Nome;
                    Txt_Senha.Text = "aaaaaaaa";
                    Txt_Senha.ReadOnly = true;
                    Txt_ConfirmarSenha.ReadOnly = true;
                    switch (item.TipoConta.Trim())
                    {
                        case "E":
                            CB_Tipo.Text = "Estudante";
                            break;
                        case "A":
                            CB_Tipo.Text = "Adiministrador";
                            break;
                        case "C":
                            CB_Tipo.Text = "Chefe";
                            break;
                        case "B":
                            CB_Tipo.Text = "Banido";
                            break;
                    }
                    cadastrar = false;
                    Ll_Cancelar.Visible = true;
                    Btn_Atualizar.Text = "Atualizar";
                    Check_Senha.Visible = true;
                    alterarsenha = false;
                }
            }
        }

        void LimparCampos()
        {
            Txt_Email.Clear();
            Txt_Nome.Clear();
            Txt_Senha.Clear();
            Txt_ConfirmarSenha.Clear();
            CB_Tipo.Text = "";
            Check_Senha.Checked = false;
        }
        void Cancelar()
        {
            cadastrar = true;
            Txt_Senha.ReadOnly = false;
            Txt_ConfirmarSenha.ReadOnly = false;
            Ll_Cancelar.Visible = false;
            id_este = 0;
            Btn_Atualizar.Text = "Inserir";
            Check_Senha.Visible = false;
            Check_Senha.Checked = false;
            alterarsenha = true;
        }

        private void Ll_Cancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparCampos();
            Cancelar();
        }
        
        private void Check_Senha_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Senha.Checked == true)
            {
                Txt_ConfirmarSenha.ReadOnly = false;
                Txt_Senha.ReadOnly = false;
                Txt_Senha.Clear();
                Txt_ConfirmarSenha.Clear();
                alterarsenha = true;
            }
            else
            {
                Txt_ConfirmarSenha.ReadOnly = true;
                Txt_Senha.ReadOnly = true;
                Txt_Senha.Text = "aaaaaaaa";
                Txt_ConfirmarSenha.Clear();
                alterarsenha = false;
            }
        }
        

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
