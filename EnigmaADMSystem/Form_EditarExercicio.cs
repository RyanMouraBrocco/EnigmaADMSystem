using EnigmaClass;
using EnigmaClass.CRUD;
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
    public partial class Form_EditarExercicio: Form
    {
        int ordem = 0, ordemquestao = 0;
        Exercicio exercicio = new Exercicio();
        List<Imagem> Imagens = new List<Imagem>();
        bool pergunta = true;
        bool processar = true;
        bool carregar = false;
        public Form_EditarExercicio(Exercicio exercicio)
        {
            InitializeComponent();
            this.exercicio = exercicio;
            CarregarExercicio();
            
        }
        void CarregarExercicio()
        {
            Txt_Nome.Text = exercicio.Descricao;
            CarregarPerguntas();
            CB_AleatorioQuestao.Checked = exercicio.AleatorioQuestao;
        }

        void CarregarPerguntas()
        {
            Grid_Perguntas.Rows.Clear();
            int linha = 0;
            foreach (var item in exercicio.Questao.OrderBy(x => x.Ordem))
            {
                Grid_Perguntas.Rows.Add();
                Grid_Perguntas.Rows[linha].Cells[0].Value = item.Pergunta;
                Grid_Perguntas.Rows[linha].Cells[1].Value = item.Ordem.ToString();
                Grid_Perguntas.Rows[linha].Cells[2].Value = item.ID.ToString();
                linha += 1;
            }
        }
    

        private void Form_EditarExercicio_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_ADDAlt.BackColor = cor;
            Btn_ADDQuestao.BackColor = cor;
            Btn_Alterar.BackColor = cor;
            Btn_Salvar.BackColor = cor;
        }

        private void Grid_Perguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarAlternativas();
        }
        void CarregarAlternativas()
        {
            Grid_Alternativas.Rows.Clear();
            int linha = 0;
            foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
            {
                foreach (var i in item.Alternativa.OrderBy(x => x.Ordem))
                {
                    Grid_Alternativas.Rows.Add();
                    Grid_Alternativas.Rows[linha].Cells[0].Value = i.Conteudo;
                    Grid_Alternativas.Rows[linha].Cells[1].Value = i.Ordem.ToString();
                    Grid_Alternativas.Rows[linha].Cells[2].Value = i.ID.ToString();
                    linha += 1;
                }
            }
        }

        private void Grid_Perguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt.MaxLength = 32767;
            pergunta = true;
            Cancelar();
            Txt.Enabled = true;
            Grid_Imagens.Enabled = true;
            Imagens.Clear();
            foreach (var item in exercicio.Questao.Where(x=>x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
            {
                Txt.Text = item.Pergunta;
                foreach (var it in item.Imagem)
                {
                    Imagens.Add(it);
                }
                CarregarImagens(Imagens);
                if (item.Tipo == "A")
                {
                    CB_Aleatorio.Enabled = true;
                    if (item.AleatorioAlternativa==true)
                    {
                        CB_Aleatorio.Checked = true;
                    }
                }
                ordem = item.Ordem;
            }
            
        }

        void CarregarImagens(List<Imagem> imgs)
        {
            Grid_Imagens.Rows.Clear();
            int linha = 0;
            foreach (var it in imgs)
            {
                Grid_Imagens.Rows.Add();
                Grid_Imagens.Rows[linha].Cells[0].Value = it.Nome;
                Grid_Imagens.Rows[linha].Cells[1].Value = it.ID;
                linha += 1;
            }
        }

        private void Grid_Imagens_KeyUp(object sender, KeyEventArgs e)
        {
            if (Grid_Imagens.SelectedRows != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja deletar essa imagem ?", "EnigmaADMSys", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (var item in exercicio.Questao.Where(x => x.Ordem == ordem))
                        {
                            Imagens.RemoveAt(Convert.ToInt32(Grid_Imagens.CurrentRow.Cells[1].RowIndex));
                            CarregarImagens(Imagens);
                        }
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Grid_Imagens.Enabled)
            {
                OpenFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    Imagem i = new Imagem
                    {
                        Nome = Path.GetFileName(OpenFile.FileName),
                        Extensao = Path.GetExtension(OpenFile.FileName),
                        Usuario = UsuarioAtual.ID,
                        _Imagem = File.ReadAllBytes(OpenFile.FileName),
                        ID = 0
                    };
                    foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                    {
                        Imagens.Add(i);
                        CarregarImagens(Imagens);
                    }
                }
            }
            
        }


        void Alterar()
        {
            if (Txt.Text == "")
            {
                if (pergunta)
                {
                    MessageBox.Show("Digite uma pergunta", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Digite uma alternativa", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (pergunta)
                {
                    foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                    {
                        item.Pergunta = Txt.Text.Trim();
                        item.Imagem.Clear();
                        foreach (var it in Imagens)
                        {
                            item.Imagem.Add(it);
                        }
                        if (CB_Aleatorio.Checked == true)
                        {
                            item.AleatorioAlternativa = true;
                        }
                        else
                        {
                            item.AleatorioAlternativa = false;
                        }
                        item.Usuario = UsuarioAtual.ID;
                        CarregarPerguntas();
                        Grid_Perguntas.CurrentCell = Grid_Perguntas.Rows[ordem - 1].Cells[0];
                        Grid_Perguntas.Rows[ordem - 1].Selected = true;

                    }
                }
                else
                {
                    foreach (var item in exercicio.Questao.Where(x => x.Ordem == ordemquestao))
                    {
                        foreach (var it in item.Alternativa.Where(x => x.Ordem == ordem))
                        {
                            it.Conteudo = Txt.Text.Trim();
                            if (CB_Correta.Checked)
                            {
                                foreach (var i in item.Alternativa)
                                {
                                    i.Tipo = "E";
                                }
                                it.Tipo = "C";
                            }
                        }
                    }
                    CarregarAlternativas();
                    Grid_Alternativas.CurrentCell = Grid_Alternativas.Rows[ordem - 1].Cells[0];
                    Grid_Alternativas.Rows[ordem - 1].Selected = true;
                    Grid_Perguntas.CurrentCell = Grid_Perguntas.Rows[ordemquestao - 1].Cells[0];
                    Grid_Perguntas.Rows[ordemquestao - 1].Selected = true;
                }
                Cancelar();

            }
        }
        
        void Cancelar()
        {
            Txt.Clear();
            Txt.Enabled = false;
            CB_Aleatorio.Checked = false;
            CB_Aleatorio.Enabled = false;
            CB_Correta.Checked = false;
            CB_Correta.Visible = false;
            Grid_Imagens.Rows.Clear();
            Imagens.Clear();
            Grid_Imagens.Enabled = false;
            CB_Correta.Enabled = true;
            Txt.MaxLength = 32767;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cancelar();
        }

        private void Pb_Subir_Pergunta_Click(object sender, EventArgs e)
        {
            if (Grid_Perguntas.Rows.Count > 0)
            {
                if (Grid_Perguntas.SelectedRows != null)
                {
                    if (Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value) > 1)
                    {
                        bool proximo = false;
                        foreach (var item in exercicio.Questao.OrderBy(x => x.Ordem))
                        {
                            if (proximo)
                            {
                                item.Ordem -= 1;
                                CarregarPerguntas();
                                Grid_Perguntas.CurrentCell = Grid_Perguntas.Rows[item.Ordem - 1].Cells[0];
                                Grid_Perguntas.Rows[item.Ordem - 1].Selected = true;
                                break;
                            }
                            if (item.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value) - 1)
                            {
                                item.Ordem += 1;
                                proximo = true;
                            }
                           
                        }
                    }
                }
            }
        }

        private void Pb_Descer_Pergunta_Click(object sender, EventArgs e)
        {
            if (Grid_Perguntas.Rows.Count > 0)
            {
                if (Grid_Perguntas.SelectedRows != null)
                {
                    if (Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value) < Grid_Perguntas.RowCount)
                    {
                        bool proximo = false;
                        foreach (var item in exercicio.Questao.OrderBy(x=>x.Ordem))
                        {
                            if (proximo)
                            {
                                item.Ordem -= 1;
                                CarregarPerguntas();
                                Grid_Perguntas.CurrentCell = Grid_Perguntas.Rows[item.Ordem].Cells[0];
                                Grid_Perguntas.Rows[item.Ordem].Selected = true;
                                break;
                            }
                            if (item.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value))
                            {
                                item.Ordem += 1;
                                proximo = true;
                            }
                           
                        }
                    }
                }
            }
        }

        private void Pb_Subir_Alternativa_Click(object sender, EventArgs e)
        {
            if (Grid_Alternativas.Rows.Count > 0)
            {
                if (Grid_Alternativas.SelectedRows != null)
                {
                    if (Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value) > 1)
                    {
                        bool proximo = false;
                        foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                        {
                            foreach (var it in item.Alternativa.OrderBy(x=>x.Ordem))
                            {
                                if (proximo)
                                {
                                    it.Ordem -= 1;
                                    CarregarAlternativas();
                                    Grid_Alternativas.CurrentCell = Grid_Alternativas.Rows[it.Ordem - 1].Cells[0];
                                    Grid_Alternativas.Rows[it.Ordem - 1].Selected = true;
                                    break;
                                }
                                if (it.Ordem == Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value) - 1)
                                {
                                    it.Ordem += 1;
                                    proximo = true;
                                }
                                
                                
                            }

                        }

                    }
                }
            }
        }

        private void Pb_Alternativa_Descer_Click(object sender, EventArgs e)
        {
            if (Grid_Alternativas.Rows.Count > 0)
            {
                if (Grid_Alternativas.SelectedRows != null)
                {
                    if (Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value) < Grid_Alternativas.RowCount)
                    {
                        bool proximo = false;
                        foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                        {
                            foreach (var it in item.Alternativa.OrderBy(x => x.Ordem))
                            {
                                if (proximo)
                                {
                                    it.Ordem -= 1;
                                    CarregarAlternativas();
                                    Grid_Alternativas.CurrentCell = Grid_Alternativas.Rows[it.Ordem].Cells[0];
                                    Grid_Alternativas.Rows[it.Ordem].Selected = true;
                                    break;
                                }
                                if (it.Ordem== Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value))
                                {
                                    it.Ordem += 1;
                                    proximo = true;
                                }
                            }
                            

                        }

                    }
                }
            }
        }

        private void Grid_Perguntas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Grid_Perguntas.RowCount>0)
                {
                    if (MessageBox.Show("Deseja realmente deletar essa pergunta ?", "EnigmaADMSys", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Questao q = new Questao();
                        foreach (var item in exercicio.Questao.Where(x=>x.Ordem== Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                        {
                            q = item;
                        }
                        exercicio.Questao.Remove(q);
                        int ordem = 1;
                        foreach (var item in exercicio.Questao.OrderBy(x => x.Ordem))
                        {
                            item.Ordem = ordem;
                            ordem += 1;
                        }
                        CarregarPerguntas();
                        Cancelar();
                        Grid_Alternativas.Rows. Clear();
                    }
                }
                
            }
        }

        private void Grid_Alternativas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Grid_Alternativas.RowCount > 0)
                {
                    if (MessageBox.Show("Deseja realmente deletar essa alternativa ?", "EnigmaADMSys", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (var item in exercicio.Questao.Where(x=>x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                        {
                            foreach (var i in item.Alternativa.Where(x=>x.Ordem == Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value)))
                            {
                                if (item.Tipo=="A")
                                {
                                    if (i.Tipo=="C")
                                    {
                                        MessageBox.Show("Altere a Resposta Correta antes de deleta-la", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            Alternativa a = new Alternativa();
                            foreach (var i in item.Alternativa.Where(x=>x.Ordem== Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value)))
                            {
                                a = i;
                            }
                            item.Alternativa.Remove(a);
                            int ordem = 1;
                            foreach (var it in item.Alternativa.OrderBy(x => x.Ordem))
                            {
                                it.Ordem = ordem;
                                ordem += 1;
                            }
                        }
                        Cancelar();
                        CarregarAlternativas();
                    }
                }

            }
        }

        void Salvar()
        {
            if (Txt_Nome.Text.Trim() == "")
            {
                MessageBox.Show("Digite a descrição ", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            if (Grid_Perguntas.Rows.Count == 0)
            {
                MessageBox.Show("Crie Questoes", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar = false;
            }
            else
            {
                foreach (var item in exercicio.Questao)
                {
                    if (item.Alternativa.Count == 0)
                    {
                        MessageBox.Show("Crie alternativas para a Questão de ordem: " + item.Ordem, "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        processar = false;
                        break;
                    }
                }
            }
            if (processar)
            {
                Form load = new Form_Load();
                load.Show();
                load.Refresh();
                exercicio.AleatorioQuestao = CB_AleatorioQuestao.Checked;
                exercicio.Descricao = Txt_Nome.Text.Trim();
                exercicio.Usuario = UsuarioAtual.ID;
                foreach (var item in exercicio.Questao)
                {
                    item.Exercicio = new Exercicio { ID = exercicio.ID };
                    item.Usuario = UsuarioAtual.ID;
                    foreach (var i in item.Alternativa)
                    {
                        i.Usuario = UsuarioAtual.ID;
                    }
                }
                try
                {
                    ExercicioDAL dal = new ExercicioDAL();
                    dal.Alterar(exercicio);
                    MessageBox.Show("Exercício atualizado com sucesso", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load.Close();
                    this.Close();
                }
                catch 
                {
                    MessageBox.Show("Erro de Conexão. Tente novamente", "EnigmaADMSys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                load.Close();
            }
            processar = true;
        }

        void AddQuestao()
        {
            Form frm = new Form_CriarExercicio(this.exercicio);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            carregar = true;
        }


        private void Form_EditarExercicio_Activated(object sender, EventArgs e)
        {
            if (carregar)
            {
                this.exercicio = Program._ex;
                CarregarExercicio();
                carregar = false;
            }
            
        }

        void AddAlternativa()
        {
            foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
            {
                Form frm = new Form_AddAlternativa(item);
                frm.ShowDialog();
                CarregarAlternativas();
            }
        }
        

        private void Grid_Perguntas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CarregarAlternativas();
        }
        
        

        private void Btn_ADDAlt_Click(object sender, EventArgs e)
        {
            AddAlternativa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuestao();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Grid_Alternativas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt.MaxLength = 400;
            pergunta = false;
            Cancelar();
            Txt.Enabled = true;
            Imagens.Clear();
            foreach (var item in exercicio.Questao.Where(x => x.Ordem == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
            {
                foreach (var it in item.Alternativa.Where(x=>x.Ordem == Convert.ToInt32(Grid_Alternativas.CurrentRow.Cells[1].Value)))
                {
                    Txt.Text = it.Conteudo;
                    CarregarImagens(Imagens);
                    CB_Correta.Visible = true;
                    if (it.Tipo == "C")
                    {
                        CB_Correta.Checked = true;
                        CB_Correta.Enabled = false;
                    }
                    ordem = it.Ordem;
                    ordemquestao = item.Ordem;
                }
                
            }
        }

        
    }
}
