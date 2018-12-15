namespace EnigmaADMSystem
{
    partial class Form_CriarExercicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_DescricaoEx = new System.Windows.Forms.TextBox();
            this.Txt_PerguntaQu = new System.Windows.Forms.TextBox();
            this.Txt_ConteudoAlt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check_Correta = new System.Windows.Forms.CheckBox();
            this.RB_Alternativa = new System.Windows.Forms.RadioButton();
            this.RB_Completar = new System.Windows.Forms.RadioButton();
            this.LLBL_AddImagem = new System.Windows.Forms.LinkLabel();
            this.CB_AleatorioAlternativa = new System.Windows.Forms.CheckBox();
            this.List_Questao = new System.Windows.Forms.ListBox();
            this.List_Alternativa = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.CB_QuestaoAleatoria = new System.Windows.Forms.CheckBox();
            this.List_Imagem = new System.Windows.Forms.ListBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ADDQuse = new System.Windows.Forms.Button();
            this.Btn_ADDAlt = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_DescricaoEx
            // 
            this.Txt_DescricaoEx.BackColor = System.Drawing.Color.White;
            this.Txt_DescricaoEx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DescricaoEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DescricaoEx.Location = new System.Drawing.Point(261, 68);
            this.Txt_DescricaoEx.MaxLength = 40;
            this.Txt_DescricaoEx.Name = "Txt_DescricaoEx";
            this.Txt_DescricaoEx.Size = new System.Drawing.Size(819, 22);
            this.Txt_DescricaoEx.TabIndex = 0;
            // 
            // Txt_PerguntaQu
            // 
            this.Txt_PerguntaQu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PerguntaQu.Location = new System.Drawing.Point(259, 122);
            this.Txt_PerguntaQu.Multiline = true;
            this.Txt_PerguntaQu.Name = "Txt_PerguntaQu";
            this.Txt_PerguntaQu.Size = new System.Drawing.Size(405, 190);
            this.Txt_PerguntaQu.TabIndex = 1;
            // 
            // Txt_ConteudoAlt
            // 
            this.Txt_ConteudoAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConteudoAlt.Location = new System.Drawing.Point(673, 122);
            this.Txt_ConteudoAlt.MaxLength = 400;
            this.Txt_ConteudoAlt.Multiline = true;
            this.Txt_ConteudoAlt.Name = "Txt_ConteudoAlt";
            this.Txt_ConteudoAlt.Size = new System.Drawing.Size(407, 128);
            this.Txt_ConteudoAlt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "_________________________________________________________________________________" +
    "_\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Check_Correta
            // 
            this.Check_Correta.AutoSize = true;
            this.Check_Correta.Location = new System.Drawing.Point(673, 256);
            this.Check_Correta.Name = "Check_Correta";
            this.Check_Correta.Size = new System.Drawing.Size(108, 17);
            this.Check_Correta.TabIndex = 10;
            this.Check_Correta.Text = "Resposta Correta";
            this.Check_Correta.UseVisualStyleBackColor = true;
            this.Check_Correta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RB_Alternativa
            // 
            this.RB_Alternativa.AutoSize = true;
            this.RB_Alternativa.Location = new System.Drawing.Point(260, 317);
            this.RB_Alternativa.Name = "RB_Alternativa";
            this.RB_Alternativa.Size = new System.Drawing.Size(75, 17);
            this.RB_Alternativa.TabIndex = 11;
            this.RB_Alternativa.TabStop = true;
            this.RB_Alternativa.Text = "Alternativa";
            this.RB_Alternativa.UseVisualStyleBackColor = true;
            // 
            // RB_Completar
            // 
            this.RB_Completar.AutoSize = true;
            this.RB_Completar.Location = new System.Drawing.Point(351, 316);
            this.RB_Completar.Name = "RB_Completar";
            this.RB_Completar.Size = new System.Drawing.Size(116, 17);
            this.RB_Completar.TabIndex = 12;
            this.RB_Completar.TabStop = true;
            this.RB_Completar.Text = "Completar Lacunas";
            this.RB_Completar.UseVisualStyleBackColor = true;
            this.RB_Completar.CheckedChanged += new System.EventHandler(this.RB_Completar_CheckedChanged);
            // 
            // LLBL_AddImagem
            // 
            this.LLBL_AddImagem.AutoSize = true;
            this.LLBL_AddImagem.Location = new System.Drawing.Point(275, 425);
            this.LLBL_AddImagem.Name = "LLBL_AddImagem";
            this.LLBL_AddImagem.Size = new System.Drawing.Size(70, 13);
            this.LLBL_AddImagem.TabIndex = 14;
            this.LLBL_AddImagem.TabStop = true;
            this.LLBL_AddImagem.Text = "ADD Imagem";
            this.LLBL_AddImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLBL_AddImagem_LinkClicked);
            // 
            // CB_AleatorioAlternativa
            // 
            this.CB_AleatorioAlternativa.AutoSize = true;
            this.CB_AleatorioAlternativa.Location = new System.Drawing.Point(375, 340);
            this.CB_AleatorioAlternativa.Name = "CB_AleatorioAlternativa";
            this.CB_AleatorioAlternativa.Size = new System.Drawing.Size(129, 17);
            this.CB_AleatorioAlternativa.TabIndex = 15;
            this.CB_AleatorioAlternativa.Text = "Alternativas aleatórias";
            this.CB_AleatorioAlternativa.UseVisualStyleBackColor = true;
            // 
            // List_Questao
            // 
            this.List_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Questao.FormattingEnabled = true;
            this.List_Questao.ItemHeight = 16;
            this.List_Questao.Location = new System.Drawing.Point(259, 475);
            this.List_Questao.Name = "List_Questao";
            this.List_Questao.Size = new System.Drawing.Size(376, 116);
            this.List_Questao.TabIndex = 16;
            this.List_Questao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.List_Questao_KeyUp);
            // 
            // List_Alternativa
            // 
            this.List_Alternativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Alternativa.FormattingEnabled = true;
            this.List_Alternativa.ItemHeight = 16;
            this.List_Alternativa.Location = new System.Drawing.Point(787, 256);
            this.List_Alternativa.Name = "List_Alternativa";
            this.List_Alternativa.Size = new System.Drawing.Size(152, 100);
            this.List_Alternativa.TabIndex = 17;
            this.List_Alternativa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.List_Alternativa_KeyUp);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // CB_QuestaoAleatoria
            // 
            this.CB_QuestaoAleatoria.AutoSize = true;
            this.CB_QuestaoAleatoria.Location = new System.Drawing.Point(777, 534);
            this.CB_QuestaoAleatoria.Name = "CB_QuestaoAleatoria";
            this.CB_QuestaoAleatoria.Size = new System.Drawing.Size(119, 17);
            this.CB_QuestaoAleatoria.TabIndex = 18;
            this.CB_QuestaoAleatoria.Text = "Questões aleatórias";
            this.CB_QuestaoAleatoria.UseVisualStyleBackColor = true;
            // 
            // List_Imagem
            // 
            this.List_Imagem.FormattingEnabled = true;
            this.List_Imagem.Location = new System.Drawing.Point(259, 340);
            this.List_Imagem.Name = "List_Imagem";
            this.List_Imagem.Size = new System.Drawing.Size(105, 82);
            this.List_Imagem.TabIndex = 19;
            this.List_Imagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.List_Imagem_KeyUp);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(260, 47);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(0, 24);
            this.Lbl_Titulo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Questões";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pergunta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(670, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Resposta";
            // 
            // Btn_ADDQuse
            // 
            this.Btn_ADDQuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADDQuse.ForeColor = System.Drawing.Color.White;
            this.Btn_ADDQuse.Location = new System.Drawing.Point(539, 318);
            this.Btn_ADDQuse.Name = "Btn_ADDQuse";
            this.Btn_ADDQuse.Size = new System.Drawing.Size(125, 67);
            this.Btn_ADDQuse.TabIndex = 27;
            this.Btn_ADDQuse.Text = "ADD";
            this.Btn_ADDQuse.UseVisualStyleBackColor = true;
            this.Btn_ADDQuse.Click += new System.EventHandler(this.Btn_ADDQuse_Click);
            // 
            // Btn_ADDAlt
            // 
            this.Btn_ADDAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADDAlt.ForeColor = System.Drawing.Color.White;
            this.Btn_ADDAlt.Location = new System.Drawing.Point(983, 256);
            this.Btn_ADDAlt.Name = "Btn_ADDAlt";
            this.Btn_ADDAlt.Size = new System.Drawing.Size(97, 56);
            this.Btn_ADDAlt.TabIndex = 28;
            this.Btn_ADDAlt.Text = "ADD";
            this.Btn_ADDAlt.UseVisualStyleBackColor = true;
            this.Btn_ADDAlt.Click += new System.EventHandler(this.Btn_ADDAlt_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(912, 494);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(177, 97);
            this.Btn_Salvar.TabIndex = 29;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Form_CriarExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_ADDAlt);
            this.Controls.Add(this.Btn_ADDQuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.List_Imagem);
            this.Controls.Add(this.CB_QuestaoAleatoria);
            this.Controls.Add(this.List_Alternativa);
            this.Controls.Add(this.List_Questao);
            this.Controls.Add(this.CB_AleatorioAlternativa);
            this.Controls.Add(this.LLBL_AddImagem);
            this.Controls.Add(this.RB_Completar);
            this.Controls.Add(this.RB_Alternativa);
            this.Controls.Add(this.Check_Correta);
            this.Controls.Add(this.Txt_ConteudoAlt);
            this.Controls.Add(this.Txt_PerguntaQu);
            this.Controls.Add(this.Txt_DescricaoEx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CriarExercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_CriarExercicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_DescricaoEx;
        private System.Windows.Forms.TextBox Txt_PerguntaQu;
        private System.Windows.Forms.TextBox Txt_ConteudoAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Check_Correta;
        private System.Windows.Forms.RadioButton RB_Alternativa;
        private System.Windows.Forms.RadioButton RB_Completar;
        private System.Windows.Forms.LinkLabel LLBL_AddImagem;
        private System.Windows.Forms.CheckBox CB_AleatorioAlternativa;
        private System.Windows.Forms.ListBox List_Questao;
        private System.Windows.Forms.ListBox List_Alternativa;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.CheckBox CB_QuestaoAleatoria;
        private System.Windows.Forms.ListBox List_Imagem;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_ADDQuse;
        private System.Windows.Forms.Button Btn_ADDAlt;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}