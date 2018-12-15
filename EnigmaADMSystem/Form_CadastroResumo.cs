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
using EnigmaClass;

namespace EnigmaADMSystem
{
    public partial class Form_CadastroResumo : Form
    {
        List<Resumo> _resumos = new List<Resumo>();
        int linha = 0;
        public Form_CadastroResumo(List<Resumo> resum)
        {
            InitializeComponent();
            foreach (var item in resum)
            {
                Resumo resumo = new Resumo
                {
                    Arquivo = item.Arquivo,
                    Conteudo = item.Conteudo,
                    Extensao = item.Extensao,
                    ID = item.ID,
                    NomeArquivo = item.NomeArquivo,
                    Usuario = item.Usuario
                };
                _resumos.Add(resumo);
            }
            linha = resum.Count;
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            Grid.Rows.Clear();
            int linhaatual = 0;
            foreach (var item in _resumos)
            {
                Grid.Rows.Add();
                Grid.Rows[linhaatual].Cells[0].Value = item.NomeArquivo;
                Grid.Rows[linhaatual].Cells[1].Value = linhaatual;
                linhaatual += 1;
            }
        }

        private void Form_CadastroResumo_Load(object sender, EventArgs e)
        {
            Color corpainel = ColorTranslator.FromHtml("#000449");
            PainelSuperior.BackColor = corpainel;
            Btn_Salvar.BackColor = corpainel;
            Btn_ADD.BackColor = corpainel;
        }

        int x, y;
        Point Ponto = new Point();
        private void PainelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        void Add()
        {
            Dialog.Filter = "Pdf Files|*.pdf";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Resumo r = new Resumo
                {
                    NomeArquivo = Path.GetFileName(Dialog.FileName),
                    Arquivo = File.ReadAllBytes(Dialog.FileName),
                    Extensao = Path.GetExtension(Dialog.FileName),
                    Usuario = UsuarioAtual.ID
                };
                Grid.Rows.Add();
                Grid.Rows[linha].Cells[0].Value = r.NomeArquivo;
                linha += 1;
                _resumos.Add(r);
            }
        }
        
        void Salvar()
        {
            Program._resum.Clear();
            foreach (var item in _resumos)
            {
                Resumo resumo = new Resumo
                {
                    Arquivo = item.Arquivo,
                    Conteudo = item.Conteudo,
                    Extensao = item.Extensao,
                    ID = item.ID,
                    NomeArquivo = item.NomeArquivo,
                    Usuario = item.Usuario
                };
                Program._resum.Add(resumo);
            }
            this.Close();
        }
        

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Grid.SelectedRows!=null)
                {
                    if (MessageBox.Show("Deseja relamete deletar esse item ?","EnigmaADMSys",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        _resumos.RemoveAt(Convert.ToInt32(Grid.CurrentRow.Cells[1].Value));
                        linha -= 1;
                        CarregarGrid();
                    }
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void PainelSuperior_MouseMove(object sender, MouseEventArgs e)
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
