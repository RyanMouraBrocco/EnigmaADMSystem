using EnigmaClass;
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
    public partial class Form_ConteudoTexto : Form
    {
        bool processar = true;
        List<ConteudoTexto> _ConteudoTexto = new List<EnigmaClass.ConteudoTexto>();
        string nomearquivo,extensaoarquivo;
        string cortexto = "";
        public Form_ConteudoTexto(List<ConteudoTexto> ct)
        {
            InitializeComponent();
            foreach (var item in ct)
            {
                _ConteudoTexto.Add(item);
            }
            AtualizarGrid();
        }

        private void LimparTexto()
        {
            Txt_Texto.Clear();
            CB_Italico.Checked = false;
            CB_Negrito.Checked = false;
            DUP_Tamanho.Text = "14";
        }
        private void LimparVideo()
        {
            Txt_NomeVideo.Clear();
            MTxt_Duracao.Clear();
            MTxt_Fim.Clear();
            MTxt_Inicio.Clear();
            Txt_Link.Clear();
        }
        private void LimparImagem()
        {
            PB_Img.Image = null;
            nomearquivo = string.Empty;
            extensaoarquivo = string.Empty;
        }

        private void Form_ConteudoTexto_Load(object sender, EventArgs e)
        {
            Color corpainel = ColorTranslator.FromHtml("#000446");
            PainelSuperior.BackColor = corpainel;
            Pb_Azul.BackColor = corpainel;
            Rb_Preto.Checked = true;
            for (int i = 60; i > 0; i--)
            {
                DUP_Tamanho.Items.Add(i);
            }
            Btn_AddTexto.BackColor = corpainel;
            Btn_AddVideo.BackColor = corpainel;
            Btn_AddImagem.BackColor = corpainel;
            Btn_Salvar.BackColor = corpainel;
            Btn_Selecionar.BackColor = corpainel;
            
        }
        int x, y;
        Point Ponto = new Point();

        private void PainelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
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

        void AddTexto()
        {
            if (Txt_Texto.Text.Trim() == "")
            {
                MessageBox.Show("Digite o texto", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            decimal valor = 0;
            if (DUP_Tamanho.Text.Trim() == "")
            {
                MessageBox.Show("Escolha um tamanho para o texto", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                try
                {
                    valor = Convert.ToDecimal(DUP_Tamanho.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Escolha um tamanho válido para o texto", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
            }
            if (processar)
            {
                Texto T = new Texto
                {
                    Tamanho = valor,
                    Conteudo = Txt_Texto.Text.Trim(),
                    Cor = cortexto,
                    Usuario = UsuarioAtual.ID,
                    Italico = false,
                    Negrito = false
                };
                if (CB_Italico.Checked)
                {
                    T.Italico = true;
                }
                if (CB_Negrito.Checked)
                {
                    T.Negrito = true;
                }
                ConteudoTexto ct = new ConteudoTexto
                {
                    Imagem = null,
                    Texto = T,
                    Usuario = UsuarioAtual.ID,
                    Video = null,
                    Ordem = (_ConteudoTexto.Count + 1)
                };
                _ConteudoTexto.Add(ct);
                AtualizarGrid();
                LimparTexto();
            }
            processar = true;
        }
        
        private void AtualizarGrid()
        {
            Grid.Rows.Clear();
            int linha = 0;
            foreach (var item in _ConteudoTexto.OrderBy(n => n.Ordem))
            {
                Grid.Rows.Add();
                if (item.Texto != null)
                {
                    Grid.Rows[linha].Cells[0].Value =item.Texto.Conteudo;
                    Grid.Rows[linha].Cells[1].Value = "Texto";
                }
                if (item.Imagem != null)
                {
                    Grid.Rows[linha].Cells[0].Value =item.Imagem.Nome;
                    Grid.Rows[linha].Cells[1].Value = "Imagem";
                }
                if (item.Video != null)
                {
                    Grid.Rows[linha].Cells[0].Value =item.Video.Nome;
                    Grid.Rows[linha].Cells[1].Value ="Vídeo";
                }
                item.Ordem = linha + 1;
                Grid.Rows[linha].Cells[2].Value = item.Ordem;
                linha += 1;
            }
        }

        void AddVideo()
        {
            if (Txt_NomeVideo.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do Video", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (Txt_Link.Text.Trim() == "")
            {
                MessageBox.Show("Digite o link de download do Video", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (MTxt_Duracao.Text.Trim() == "")
            {
                MessageBox.Show("Digite a duracao  do Video", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                if (MTxt_Duracao.Text.Trim().Length<6)
                {
                    MessageBox.Show("Digite a duracao completa do Video, preenchendo todos os espaços", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                else
                {
                    bool validar = true;
                    for (int i = 0; i < MTxt_Duracao.Text.Trim().Length; i++)
                    {
                        if (MTxt_Duracao.Text.Trim().Substring(i,1)=="")
                        {
                            validar = false;   
                        }
                    }
                    if (validar==false)
                    {
                        MessageBox.Show("Digite todos os campos da duração do vídeo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(MTxt_Duracao.Text.Trim().Substring(2, 2)) > 59)
                        {
                            MessageBox.Show("Os minutos da duração não podem ser superiores a 59 minutos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                        else
                        {
                            if (Convert.ToInt32(MTxt_Duracao.Text.Trim().Substring(4, 2)) > 59)
                            {
                                MessageBox.Show("Os segundos da duração não podem ser superiores a 59 segundos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                processar = false;
                            }
                            else
                            {
                                if (Convert.ToInt32(MTxt_Duracao.Text.Trim()) == 0)
                                {
                                    MessageBox.Show("A duração do vídeo não pode ser 0", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    processar = false;
                                }
                            }
                        }
                    }
                }
            }
            if (MTxt_Inicio.Text.Trim() == "")
            {
                MessageBox.Show("Digite o início do Video", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                if (MTxt_Inicio.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Digite o início completa do Video, preenchendo todos os espaços", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                else
                {
                    bool validar = true;
                    for (int i = 0; i < MTxt_Inicio.Text.Trim().Length; i++)
                    {
                        if (MTxt_Inicio.Text.Trim().Substring(i, 1) == "")
                        {
                            validar = false;
                        }
                    }
                    if (validar == false)
                    {
                        MessageBox.Show("Digite todos os campos do início do vídeo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(MTxt_Inicio.Text.Trim().Substring(2, 2)) > 59)
                        {
                            MessageBox.Show("Os minutos do início do vídeo não podem ser superiores a 59 minutos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                        else
                        {
                            if (Convert.ToInt32(MTxt_Inicio.Text.Trim().Substring(4, 2)) > 59)
                            {
                                MessageBox.Show("Os segundos do início do vídeo não podem ser superiores a 59 segundos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                processar = false;
                            }
                        }
                    }
                }
            }
            if (MTxt_Fim.Text.Trim() == "")
            {
                MessageBox.Show("Digite o fim  do Video", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                if (MTxt_Fim.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Digite o início completa do Video, preenchendo todos os espaços", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    processar = false;
                }
                else
                {
                    bool validar = true;
                    for (int i = 0; i < MTxt_Fim.Text.Trim().Length; i++)
                    {
                        if (MTxt_Fim.Text.Trim().Substring(i, 1) == "")
                        {
                            validar = false;
                        }
                    }
                    if (validar == false)
                    {
                        MessageBox.Show("Digite todos os campos do fim do vídeo", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(MTxt_Fim.Text.Trim().Substring(2, 2)) > 59)
                        {
                            MessageBox.Show("Os minutos do fim do vídeo não podem ser superiores a 59 minutos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                        else
                        {
                            if (Convert.ToInt32(MTxt_Fim.Text.Trim().Substring(4, 2)) > 59)
                            {
                                MessageBox.Show("Os segundos do fim do vídeo não podem ser superiores a 59 segundos", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                processar = false;
                            }
                        }
                    }
                }
            }
            if (processar)
            {
                decimal duracao = (Convert.ToDecimal(MTxt_Duracao.Text.Trim().Substring(0, 2)) * 60) + Convert.ToDecimal(MTxt_Duracao.Text.Trim().Substring(2, 2)) + (Convert.ToDecimal(MTxt_Duracao.Text.Trim().Substring(4, 2)) / 60);
                decimal inicio = (Convert.ToDecimal(MTxt_Inicio.Text.Trim().Substring(0, 2)) * 60) + Convert.ToDecimal(MTxt_Inicio.Text.Trim().Substring(2, 2)) + (Convert.ToDecimal(MTxt_Inicio.Text.Trim().Substring(4, 2)) / 60);
                decimal fim = (Convert.ToDecimal(MTxt_Fim.Text.Trim().Substring(0, 2)) * 60) + Convert.ToDecimal(MTxt_Fim.Text.Trim().Substring(2, 2)) + (Convert.ToDecimal(MTxt_Fim.Text.Trim().Substring(4, 2)) / 60);
                Video V = new Video
                {
                    Nome = Txt_NomeVideo.Text.Trim(),
                    Duracao = duracao,
                    Inicio = inicio,
                    Fim = fim,
                    Link = Txt_Link.Text.Trim(),
                    Usuario = UsuarioAtual.ID
                };
                ConteudoTexto ct = new ConteudoTexto
                {
                    Usuario = UsuarioAtual.ID,
                    Imagem = null,
                    Video = V,
                    Texto = null,
                    Ordem = _ConteudoTexto.Count + 1
                };
                _ConteudoTexto.Add(ct);
                AtualizarGrid();
                LimparVideo();
            }
            processar = true;
        }

       
        void SelecionarImagem()
        {
            Dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                PB_Img.ImageLocation = Dialog.FileName;
                nomearquivo = Path.GetFileName(Dialog.FileName);
                extensaoarquivo = Path.GetExtension(Dialog.FileName);
            }
        }


        void Salvar()
        {
            Program._contText.Clear();
            foreach (var item in _ConteudoTexto)
            {
                Program._contText.Add(item);
            }
            Program.Salvar = true;
            this.Close();
        }
        
        private void Btn_Subir_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0)
            {
                int select = 0;
                if (Convert.ToInt32(Grid.CurrentRow.Cells[2].Value) > 1)
                {
                    foreach (var item in _ConteudoTexto.OrderBy(n => n.Ordem))
                    {
                        if (item.Ordem == Convert.ToInt32(Grid.CurrentRow.Cells[2].Value) - 1)
                        {
                            item.Ordem += 1;
                        }
                        else
                        {

                            if (item.Ordem == Convert.ToInt32(Grid.CurrentRow.Cells[2].Value))
                            {
                                item.Ordem -= 1;
                                select = item.Ordem - 1;
                                break;
                            }
                        }
                    }
                }
                AtualizarGrid();
                Grid.CurrentCell = Grid.Rows[select].Cells[0];
                Grid.Rows[select].Selected = true;
            }
        }

        private void Btn_Descer_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0)
            {
                int select = 0;
                if (Convert.ToInt32(Grid.CurrentRow.Cells[2].Value) < Convert.ToInt32(Grid.RowCount))
                {
                    foreach (var item in _ConteudoTexto.OrderBy(n => n.Ordem))
                    {
                        if (item.Ordem == Convert.ToInt32(Grid.CurrentRow.Cells[2].Value))
                        {
                            item.Ordem += 1;
                            select = item.Ordem - 1;
                            
                        }
                        else
                        {
                            if (item.Ordem == Convert.ToInt32(Grid.CurrentRow.Cells[2].Value) + 1)
                            {
                                item.Ordem -= 1;
                                break;
                            }
                        }
                    }
                }
                AtualizarGrid();
                if (select==0)
                {
                    Grid.CurrentCell = Grid.Rows[Convert.ToInt32(Grid.RowCount)-1].Cells[0];
                    Grid.Rows[Convert.ToInt32(Grid.RowCount)-1].Selected = true;
                }
                else
                {
                    Grid.CurrentCell = Grid.Rows[select].Cells[0];
                    Grid.Rows[select].Selected = true;
                }
            }
        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (Grid.SelectedRows!=null)
                {
                    if (MessageBox.Show("Deseja mesmo deleter esse registro ?","EnigmaADMSys",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        ConteudoTexto ct = new ConteudoTexto();
                        foreach (var item in _ConteudoTexto.Where(x=>x.Ordem== Convert.ToInt32(Grid.CurrentRow.Cells[2].Value)))
                        {
                            ct = item;
                        }
                        _ConteudoTexto.Remove(ct);
                        AtualizarGrid();
                    }
                }
            }
        }

        void AddImagem()
        {
            if (PB_Img.Image == null)
            {
                MessageBox.Show("Selecione uma Imagem", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (processar)
            {
                Imagem I = new Imagem
                {
                    Nome = nomearquivo,
                    Extensao = extensaoarquivo,
                    Usuario = UsuarioAtual.ID,
                    _Imagem = File.ReadAllBytes(PB_Img.ImageLocation)
                };
                ConteudoTexto ct = new ConteudoTexto
                {
                    Imagem = I,
                    Ordem = _ConteudoTexto.Count + 1,
                    Texto = null,
                    Video = null,
                    Usuario = UsuarioAtual.ID
                };
                _ConteudoTexto.Add(ct);
                AtualizarGrid();
                LimparImagem();
            }
            processar = true;
        }
        

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rb_Preto_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Preto.Checked)
            {
                cortexto = "#000000";
            }
        }

        private void Rb_Azul_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Azul.Checked)
            {
                cortexto = "#000449";
            }
        }

        private void Rb_Vermelho_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Vermelho.Checked)
            {
                cortexto = "#FF0000";
            }
        }

        private void Rb_Verde_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Verde.Checked)
            {
                cortexto = "#298A08";
            }
        }
        
        private void DUP_Tamanho_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTexto();
        }

        private void Btn_AddVideo_Click(object sender, EventArgs e)
        {
            AddVideo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddImagem();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SelecionarImagem();
        }
        

        private void PainelSuperior_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
