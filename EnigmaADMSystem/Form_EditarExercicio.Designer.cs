namespace EnigmaADMSystem
{
    partial class Form_EditarExercicio
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
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt = new System.Windows.Forms.TextBox();
            this.Pb_Subir_Alternativa = new System.Windows.Forms.PictureBox();
            this.Pb_Alternativa_Descer = new System.Windows.Forms.PictureBox();
            this.Pb_Descer_Pergunta = new System.Windows.Forms.PictureBox();
            this.Pb_Subir_Pergunta = new System.Windows.Forms.PictureBox();
            this.CB_Aleatorio = new System.Windows.Forms.CheckBox();
            this.CB_Correta = new System.Windows.Forms.CheckBox();
            this.Grid_Perguntas = new System.Windows.Forms.DataGridView();
            this.Pergunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Alternativas = new System.Windows.Forms.DataGridView();
            this.Alternativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Imagens = new System.Windows.Forms.DataGridView();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.CB_AleatorioQuestao = new System.Windows.Forms.CheckBox();
            this.Btn_ADDAlt = new System.Windows.Forms.Button();
            this.Btn_ADDQuestao = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir_Alternativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Alternativa_Descer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Descer_Pergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir_Pergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alternativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.Color.White;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(247, 97);
            this.Txt_Nome.MaxLength = 40;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(831, 22);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(550, 47);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(204, 31);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "Editar-Exercício";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Perguntas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alternativas";
            // 
            // Txt
            // 
            this.Txt.Enabled = false;
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.Location = new System.Drawing.Point(698, 161);
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(380, 171);
            this.Txt.TabIndex = 8;
            // 
            // Pb_Subir_Alternativa
            // 
            this.Pb_Subir_Alternativa.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Subir_Alternativa.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Cima;
            this.Pb_Subir_Alternativa.Location = new System.Drawing.Point(589, 338);
            this.Pb_Subir_Alternativa.Name = "Pb_Subir_Alternativa";
            this.Pb_Subir_Alternativa.Size = new System.Drawing.Size(49, 35);
            this.Pb_Subir_Alternativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Subir_Alternativa.TabIndex = 10;
            this.Pb_Subir_Alternativa.TabStop = false;
            this.Pb_Subir_Alternativa.Click += new System.EventHandler(this.Pb_Subir_Alternativa_Click);
            // 
            // Pb_Alternativa_Descer
            // 
            this.Pb_Alternativa_Descer.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Alternativa_Descer.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Baixo;
            this.Pb_Alternativa_Descer.Location = new System.Drawing.Point(589, 379);
            this.Pb_Alternativa_Descer.Name = "Pb_Alternativa_Descer";
            this.Pb_Alternativa_Descer.Size = new System.Drawing.Size(49, 35);
            this.Pb_Alternativa_Descer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Alternativa_Descer.TabIndex = 11;
            this.Pb_Alternativa_Descer.TabStop = false;
            this.Pb_Alternativa_Descer.Click += new System.EventHandler(this.Pb_Alternativa_Descer_Click);
            // 
            // Pb_Descer_Pergunta
            // 
            this.Pb_Descer_Pergunta.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Descer_Pergunta.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Baixo;
            this.Pb_Descer_Pergunta.Location = new System.Drawing.Point(589, 202);
            this.Pb_Descer_Pergunta.Name = "Pb_Descer_Pergunta";
            this.Pb_Descer_Pergunta.Size = new System.Drawing.Size(49, 35);
            this.Pb_Descer_Pergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Descer_Pergunta.TabIndex = 13;
            this.Pb_Descer_Pergunta.TabStop = false;
            this.Pb_Descer_Pergunta.Click += new System.EventHandler(this.Pb_Descer_Pergunta_Click);
            // 
            // Pb_Subir_Pergunta
            // 
            this.Pb_Subir_Pergunta.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Subir_Pergunta.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Cima;
            this.Pb_Subir_Pergunta.Location = new System.Drawing.Point(589, 161);
            this.Pb_Subir_Pergunta.Name = "Pb_Subir_Pergunta";
            this.Pb_Subir_Pergunta.Size = new System.Drawing.Size(49, 35);
            this.Pb_Subir_Pergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Subir_Pergunta.TabIndex = 12;
            this.Pb_Subir_Pergunta.TabStop = false;
            this.Pb_Subir_Pergunta.Click += new System.EventHandler(this.Pb_Subir_Pergunta_Click);
            // 
            // CB_Aleatorio
            // 
            this.CB_Aleatorio.AutoSize = true;
            this.CB_Aleatorio.Enabled = false;
            this.CB_Aleatorio.Location = new System.Drawing.Point(698, 338);
            this.CB_Aleatorio.Name = "CB_Aleatorio";
            this.CB_Aleatorio.Size = new System.Drawing.Size(67, 17);
            this.CB_Aleatorio.TabIndex = 14;
            this.CB_Aleatorio.Text = "Aleatório";
            this.CB_Aleatorio.UseVisualStyleBackColor = true;
            // 
            // CB_Correta
            // 
            this.CB_Correta.AutoSize = true;
            this.CB_Correta.Location = new System.Drawing.Point(901, 338);
            this.CB_Correta.Name = "CB_Correta";
            this.CB_Correta.Size = new System.Drawing.Size(60, 17);
            this.CB_Correta.TabIndex = 15;
            this.CB_Correta.Text = "Correta";
            this.CB_Correta.UseVisualStyleBackColor = true;
            this.CB_Correta.Visible = false;
            // 
            // Grid_Perguntas
            // 
            this.Grid_Perguntas.AllowUserToAddRows = false;
            this.Grid_Perguntas.AllowUserToDeleteRows = false;
            this.Grid_Perguntas.AllowUserToResizeColumns = false;
            this.Grid_Perguntas.AllowUserToResizeRows = false;
            this.Grid_Perguntas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Perguntas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Perguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Perguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pergunta,
            this.Ordem,
            this.ID});
            this.Grid_Perguntas.Location = new System.Drawing.Point(247, 161);
            this.Grid_Perguntas.MultiSelect = false;
            this.Grid_Perguntas.Name = "Grid_Perguntas";
            this.Grid_Perguntas.ReadOnly = true;
            this.Grid_Perguntas.RowHeadersVisible = false;
            this.Grid_Perguntas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Perguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Perguntas.Size = new System.Drawing.Size(336, 150);
            this.Grid_Perguntas.TabIndex = 16;
            this.Grid_Perguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellClick);
            this.Grid_Perguntas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellDoubleClick);
            this.Grid_Perguntas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellEnter);
            this.Grid_Perguntas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Perguntas_KeyUp);
            // 
            // Pergunta
            // 
            this.Pergunta.HeaderText = "Pergunta";
            this.Pergunta.MinimumWidth = 280;
            this.Pergunta.Name = "Pergunta";
            this.Pergunta.ReadOnly = true;
            this.Pergunta.Width = 280;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Grid_Alternativas
            // 
            this.Grid_Alternativas.AllowUserToAddRows = false;
            this.Grid_Alternativas.AllowUserToDeleteRows = false;
            this.Grid_Alternativas.AllowUserToResizeColumns = false;
            this.Grid_Alternativas.AllowUserToResizeRows = false;
            this.Grid_Alternativas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Alternativas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Alternativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Alternativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alternativa,
            this.Column1,
            this.Column2});
            this.Grid_Alternativas.Location = new System.Drawing.Point(247, 338);
            this.Grid_Alternativas.MultiSelect = false;
            this.Grid_Alternativas.Name = "Grid_Alternativas";
            this.Grid_Alternativas.ReadOnly = true;
            this.Grid_Alternativas.RowHeadersVisible = false;
            this.Grid_Alternativas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Alternativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Alternativas.Size = new System.Drawing.Size(336, 150);
            this.Grid_Alternativas.TabIndex = 17;
            this.Grid_Alternativas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Alternativas_CellDoubleClick);
            this.Grid_Alternativas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Alternativas_KeyUp);
            // 
            // Alternativa
            // 
            this.Alternativa.HeaderText = "Alternativa";
            this.Alternativa.MinimumWidth = 280;
            this.Alternativa.Name = "Alternativa";
            this.Alternativa.ReadOnly = true;
            this.Alternativa.Width = 280;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ordem";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Grid_Imagens
            // 
            this.Grid_Imagens.AllowUserToAddRows = false;
            this.Grid_Imagens.AllowUserToDeleteRows = false;
            this.Grid_Imagens.AllowUserToResizeColumns = false;
            this.Grid_Imagens.AllowUserToResizeRows = false;
            this.Grid_Imagens.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Imagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Imagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Column3});
            this.Grid_Imagens.Location = new System.Drawing.Point(698, 379);
            this.Grid_Imagens.MultiSelect = false;
            this.Grid_Imagens.Name = "Grid_Imagens";
            this.Grid_Imagens.ReadOnly = true;
            this.Grid_Imagens.RowHeadersVisible = false;
            this.Grid_Imagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Imagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Imagens.Size = new System.Drawing.Size(133, 103);
            this.Grid_Imagens.TabIndex = 18;
            this.Grid_Imagens.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Imagens_KeyUp);
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 128;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Imagens";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(717, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Adiconar Imagem";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(999, 403);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cancelar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // CB_AleatorioQuestao
            // 
            this.CB_AleatorioQuestao.AutoSize = true;
            this.CB_AleatorioQuestao.Location = new System.Drawing.Point(753, 533);
            this.CB_AleatorioQuestao.Name = "CB_AleatorioQuestao";
            this.CB_AleatorioQuestao.Size = new System.Drawing.Size(120, 17);
            this.CB_AleatorioQuestao.TabIndex = 24;
            this.CB_AleatorioQuestao.Text = "Questões Aleatórias";
            this.CB_AleatorioQuestao.UseVisualStyleBackColor = true;
            // 
            // Btn_ADDAlt
            // 
            this.Btn_ADDAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADDAlt.ForeColor = System.Drawing.Color.White;
            this.Btn_ADDAlt.Location = new System.Drawing.Point(589, 447);
            this.Btn_ADDAlt.Name = "Btn_ADDAlt";
            this.Btn_ADDAlt.Size = new System.Drawing.Size(72, 41);
            this.Btn_ADDAlt.TabIndex = 31;
            this.Btn_ADDAlt.Text = "ADD";
            this.Btn_ADDAlt.UseVisualStyleBackColor = true;
            this.Btn_ADDAlt.Click += new System.EventHandler(this.Btn_ADDAlt_Click);
            // 
            // Btn_ADDQuestao
            // 
            this.Btn_ADDQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADDQuestao.ForeColor = System.Drawing.Color.White;
            this.Btn_ADDQuestao.Location = new System.Drawing.Point(589, 270);
            this.Btn_ADDQuestao.Name = "Btn_ADDQuestao";
            this.Btn_ADDQuestao.Size = new System.Drawing.Size(72, 41);
            this.Btn_ADDQuestao.TabIndex = 32;
            this.Btn_ADDQuestao.Text = "ADD";
            this.Btn_ADDQuestao.UseVisualStyleBackColor = true;
            this.Btn_ADDQuestao.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.Btn_Alterar.Location = new System.Drawing.Point(967, 336);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(111, 62);
            this.Btn_Alterar.TabIndex = 33;
            this.Btn_Alterar.Text = "Salvar";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(883, 477);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(210, 114);
            this.Btn_Salvar.TabIndex = 34;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form_EditarExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_ADDQuestao);
            this.Controls.Add(this.Btn_ADDAlt);
            this.Controls.Add(this.CB_AleatorioQuestao);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid_Imagens);
            this.Controls.Add(this.Grid_Alternativas);
            this.Controls.Add(this.Grid_Perguntas);
            this.Controls.Add(this.CB_Correta);
            this.Controls.Add(this.CB_Aleatorio);
            this.Controls.Add(this.Pb_Descer_Pergunta);
            this.Controls.Add(this.Pb_Subir_Pergunta);
            this.Controls.Add(this.Pb_Alternativa_Descer);
            this.Controls.Add(this.Pb_Subir_Alternativa);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditarExercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditarExercicio";
            this.Activated += new System.EventHandler(this.Form_EditarExercicio_Activated);
            this.Load += new System.EventHandler(this.Form_EditarExercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir_Alternativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Alternativa_Descer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Descer_Pergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir_Pergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alternativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Imagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.PictureBox Pb_Subir_Alternativa;
        private System.Windows.Forms.PictureBox Pb_Alternativa_Descer;
        private System.Windows.Forms.PictureBox Pb_Descer_Pergunta;
        private System.Windows.Forms.PictureBox Pb_Subir_Pergunta;
        private System.Windows.Forms.CheckBox CB_Aleatorio;
        private System.Windows.Forms.CheckBox CB_Correta;
        private System.Windows.Forms.DataGridView Grid_Perguntas;
        private System.Windows.Forms.DataGridView Grid_Alternativas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pergunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView Grid_Imagens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox CB_AleatorioQuestao;
        private System.Windows.Forms.Button Btn_ADDAlt;
        private System.Windows.Forms.Button Btn_ADDQuestao;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}