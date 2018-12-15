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

namespace EnigmaADMSystem
{
    public partial class Form_AddAlternativa : Form
    {
        Questao questao = new Questao();
        public Form_AddAlternativa(Questao questao)
        {
            InitializeComponent();
            this.questao = questao;
            Program._qu = questao;
        }
        private void Form_AddAlternativa_Load(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#000449");
            Panel_Superior.BackColor = color;
            Btn_Adicionar.BackColor = color;
        }

        Point Ponto = new Point();
        int x, y;
        
        private void Panel_Superior_MouseMove(object sender, MouseEventArgs e)
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

        
        void Adicionar()
        {
            if (Txt_Alternativa.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o valor da alternativa", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Alternativa a = new Alternativa
                {
                    Conteudo = Txt_Alternativa.Text.Trim(),
                    Ordem = questao.Alternativa.Count + 1,
                    Questao = questao,
                    Usuario = UsuarioAtual.ID
                };
                if (questao.Tipo == "C")
                {
                    a.Tipo = "C";
                }
                else
                {
                    a.Tipo = "E";
                }
                questao.Alternativa.Add(a);
                Close();
            }
        }

        private void Form_AddAlternativa_FormClosing(object sender, FormClosingEventArgs e)
        {
           Program._qu = questao;
        }

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void Panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
        

    }
}
