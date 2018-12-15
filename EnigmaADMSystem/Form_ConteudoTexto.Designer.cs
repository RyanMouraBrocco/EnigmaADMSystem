namespace EnigmaADMSystem
{
    partial class Form_ConteudoTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConteudoTexto));
            this.PainelSuperior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_AddTexto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pb_Azul = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rb_Verde = new System.Windows.Forms.RadioButton();
            this.Rb_Azul = new System.Windows.Forms.RadioButton();
            this.Rb_Vermelho = new System.Windows.Forms.RadioButton();
            this.Rb_Preto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DUP_Tamanho = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Italico = new System.Windows.Forms.CheckBox();
            this.CB_Negrito = new System.Windows.Forms.CheckBox();
            this.Txt_Texto = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MTxt_Fim = new System.Windows.Forms.MaskedTextBox();
            this.MTxt_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.MTxt_Duracao = new System.Windows.Forms.MaskedTextBox();
            this.Btn_AddVideo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Link = new System.Windows.Forms.TextBox();
            this.Txt_NomeVideo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_AddImagem = new System.Windows.Forms.Button();
            this.Btn_Selecionar = new System.Windows.Forms.Button();
            this.PB_Img = new System.Windows.Forms.PictureBox();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Subir = new System.Windows.Forms.PictureBox();
            this.Btn_Descer = new System.Windows.Forms.PictureBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Azul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Subir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Descer)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PainelSuperior.Controls.Add(this.Pb_Fechar);
            this.PainelSuperior.Location = new System.Drawing.Point(-6, -6);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(735, 56);
            this.PainelSuperior.TabIndex = 0;
            this.PainelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelSuperior_Paint);
            this.PainelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseDown);
            this.PainelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseMove);
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaADMSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(663, 8);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(47, 47);
            this.Pb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Fechar.TabIndex = 0;
            this.Pb_Fechar.TabStop = false;
            this.Pb_Fechar.Click += new System.EventHandler(this.Pb_Fechar_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.LightGray;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tipo,
            this.Ordem});
            this.Grid.GridColor = System.Drawing.Color.LightGray;
            this.Grid.Location = new System.Drawing.Point(348, 56);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(356, 337);
            this.Grid.TabIndex = 1;
            this.Grid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyUp);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Width = 60;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 337);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.Btn_AddTexto);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.Pb_Azul);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.Rb_Verde);
            this.tabPage1.Controls.Add(this.Rb_Azul);
            this.tabPage1.Controls.Add(this.Rb_Vermelho);
            this.tabPage1.Controls.Add(this.Rb_Preto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DUP_Tamanho);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CB_Italico);
            this.tabPage1.Controls.Add(this.CB_Negrito);
            this.tabPage1.Controls.Add(this.Txt_Texto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texto";
            // 
            // Btn_AddTexto
            // 
            this.Btn_AddTexto.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddTexto.ForeColor = System.Drawing.Color.White;
            this.Btn_AddTexto.Location = new System.Drawing.Point(190, 257);
            this.Btn_AddTexto.Name = "Btn_AddTexto";
            this.Btn_AddTexto.Size = new System.Drawing.Size(100, 51);
            this.Btn_AddTexto.TabIndex = 13;
            this.Btn_AddTexto.Text = "ADD";
            this.Btn_AddTexto.UseVisualStyleBackColor = false;
            this.Btn_AddTexto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cor";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Green;
            this.pictureBox5.Location = new System.Drawing.Point(91, 270);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(30, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // Pb_Azul
            // 
            this.Pb_Azul.BackColor = System.Drawing.Color.White;
            this.Pb_Azul.Location = new System.Drawing.Point(91, 237);
            this.Pb_Azul.Name = "Pb_Azul";
            this.Pb_Azul.Size = new System.Drawing.Size(28, 28);
            this.Pb_Azul.TabIndex = 14;
            this.Pb_Azul.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(30, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Rb_Verde
            // 
            this.Rb_Verde.AutoSize = true;
            this.Rb_Verde.Location = new System.Drawing.Point(71, 279);
            this.Rb_Verde.Name = "Rb_Verde";
            this.Rb_Verde.Size = new System.Drawing.Size(14, 13);
            this.Rb_Verde.TabIndex = 11;
            this.Rb_Verde.TabStop = true;
            this.Rb_Verde.UseVisualStyleBackColor = true;
            this.Rb_Verde.CheckedChanged += new System.EventHandler(this.Rb_Verde_CheckedChanged);
            // 
            // Rb_Azul
            // 
            this.Rb_Azul.AutoSize = true;
            this.Rb_Azul.Location = new System.Drawing.Point(71, 245);
            this.Rb_Azul.Name = "Rb_Azul";
            this.Rb_Azul.Size = new System.Drawing.Size(14, 13);
            this.Rb_Azul.TabIndex = 10;
            this.Rb_Azul.TabStop = true;
            this.Rb_Azul.UseVisualStyleBackColor = true;
            this.Rb_Azul.CheckedChanged += new System.EventHandler(this.Rb_Azul_CheckedChanged);
            // 
            // Rb_Vermelho
            // 
            this.Rb_Vermelho.AutoSize = true;
            this.Rb_Vermelho.Location = new System.Drawing.Point(11, 279);
            this.Rb_Vermelho.Name = "Rb_Vermelho";
            this.Rb_Vermelho.Size = new System.Drawing.Size(14, 13);
            this.Rb_Vermelho.TabIndex = 9;
            this.Rb_Vermelho.TabStop = true;
            this.Rb_Vermelho.UseVisualStyleBackColor = true;
            this.Rb_Vermelho.CheckedChanged += new System.EventHandler(this.Rb_Vermelho_CheckedChanged);
            // 
            // Rb_Preto
            // 
            this.Rb_Preto.AutoSize = true;
            this.Rb_Preto.Location = new System.Drawing.Point(11, 245);
            this.Rb_Preto.Name = "Rb_Preto";
            this.Rb_Preto.Size = new System.Drawing.Size(14, 13);
            this.Rb_Preto.TabIndex = 8;
            this.Rb_Preto.TabStop = true;
            this.Rb_Preto.UseVisualStyleBackColor = true;
            this.Rb_Preto.CheckedChanged += new System.EventHandler(this.Rb_Preto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tamanho";
            // 
            // DUP_Tamanho
            // 
            this.DUP_Tamanho.BackColor = System.Drawing.Color.White;
            this.DUP_Tamanho.Location = new System.Drawing.Point(11, 188);
            this.DUP_Tamanho.Name = "DUP_Tamanho";
            this.DUP_Tamanho.Size = new System.Drawing.Size(47, 20);
            this.DUP_Tamanho.TabIndex = 4;
            this.DUP_Tamanho.Text = "14";
            this.DUP_Tamanho.SelectedItemChanged += new System.EventHandler(this.DUP_Tamanho_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto";
            // 
            // CB_Italico
            // 
            this.CB_Italico.AutoSize = true;
            this.CB_Italico.BackColor = System.Drawing.Color.LightGray;
            this.CB_Italico.Location = new System.Drawing.Point(187, 188);
            this.CB_Italico.Name = "CB_Italico";
            this.CB_Italico.Size = new System.Drawing.Size(55, 17);
            this.CB_Italico.TabIndex = 2;
            this.CB_Italico.Text = "Itático";
            this.CB_Italico.UseVisualStyleBackColor = false;
            // 
            // CB_Negrito
            // 
            this.CB_Negrito.AutoSize = true;
            this.CB_Negrito.BackColor = System.Drawing.Color.LightGray;
            this.CB_Negrito.Location = new System.Drawing.Point(95, 188);
            this.CB_Negrito.Name = "CB_Negrito";
            this.CB_Negrito.Size = new System.Drawing.Size(60, 17);
            this.CB_Negrito.TabIndex = 1;
            this.CB_Negrito.Text = "Negrito";
            this.CB_Negrito.UseVisualStyleBackColor = false;
            // 
            // Txt_Texto
            // 
            this.Txt_Texto.BackColor = System.Drawing.Color.White;
            this.Txt_Texto.Location = new System.Drawing.Point(2, 22);
            this.Txt_Texto.Multiline = true;
            this.Txt_Texto.Name = "Txt_Texto";
            this.Txt_Texto.Size = new System.Drawing.Size(287, 145);
            this.Txt_Texto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.MTxt_Fim);
            this.tabPage2.Controls.Add(this.MTxt_Inicio);
            this.tabPage2.Controls.Add(this.MTxt_Duracao);
            this.tabPage2.Controls.Add(this.Btn_AddVideo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Txt_Link);
            this.tabPage2.Controls.Add(this.Txt_NomeVideo);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vídeo";
            // 
            // MTxt_Fim
            // 
            this.MTxt_Fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxt_Fim.Location = new System.Drawing.Point(169, 113);
            this.MTxt_Fim.Mask = "00:00:00";
            this.MTxt_Fim.Name = "MTxt_Fim";
            this.MTxt_Fim.Size = new System.Drawing.Size(63, 22);
            this.MTxt_Fim.TabIndex = 18;
            this.MTxt_Fim.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MTxt_Inicio
            // 
            this.MTxt_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxt_Inicio.Location = new System.Drawing.Point(87, 113);
            this.MTxt_Inicio.Mask = "00:00:00";
            this.MTxt_Inicio.Name = "MTxt_Inicio";
            this.MTxt_Inicio.Size = new System.Drawing.Size(61, 22);
            this.MTxt_Inicio.TabIndex = 17;
            this.MTxt_Inicio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MTxt_Duracao
            // 
            this.MTxt_Duracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxt_Duracao.Location = new System.Drawing.Point(3, 113);
            this.MTxt_Duracao.Mask = "00:00:00";
            this.MTxt_Duracao.Name = "MTxt_Duracao";
            this.MTxt_Duracao.Size = new System.Drawing.Size(61, 22);
            this.MTxt_Duracao.TabIndex = 16;
            this.MTxt_Duracao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Btn_AddVideo
            // 
            this.Btn_AddVideo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddVideo.ForeColor = System.Drawing.Color.White;
            this.Btn_AddVideo.Location = new System.Drawing.Point(193, 257);
            this.Btn_AddVideo.Name = "Btn_AddVideo";
            this.Btn_AddVideo.Size = new System.Drawing.Size(100, 51);
            this.Btn_AddVideo.TabIndex = 15;
            this.Btn_AddVideo.Text = "ADD";
            this.Btn_AddVideo.UseVisualStyleBackColor = false;
            this.Btn_AddVideo.Click += new System.EventHandler(this.Btn_AddVideo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duração";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // Txt_Link
            // 
            this.Txt_Link.Location = new System.Drawing.Point(3, 67);
            this.Txt_Link.Name = "Txt_Link";
            this.Txt_Link.Size = new System.Drawing.Size(287, 20);
            this.Txt_Link.TabIndex = 1;
            // 
            // Txt_NomeVideo
            // 
            this.Txt_NomeVideo.Location = new System.Drawing.Point(3, 28);
            this.Txt_NomeVideo.MaxLength = 100;
            this.Txt_NomeVideo.Name = "Txt_NomeVideo";
            this.Txt_NomeVideo.Size = new System.Drawing.Size(287, 20);
            this.Txt_NomeVideo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.Btn_AddImagem);
            this.tabPage3.Controls.Add(this.Btn_Selecionar);
            this.tabPage3.Controls.Add(this.PB_Img);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(296, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imagem";
            // 
            // Btn_AddImagem
            // 
            this.Btn_AddImagem.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddImagem.ForeColor = System.Drawing.Color.White;
            this.Btn_AddImagem.Location = new System.Drawing.Point(190, 256);
            this.Btn_AddImagem.Name = "Btn_AddImagem";
            this.Btn_AddImagem.Size = new System.Drawing.Size(100, 52);
            this.Btn_AddImagem.TabIndex = 17;
            this.Btn_AddImagem.Text = "ADD";
            this.Btn_AddImagem.UseVisualStyleBackColor = false;
            this.Btn_AddImagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Selecionar
            // 
            this.Btn_Selecionar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Selecionar.ForeColor = System.Drawing.Color.White;
            this.Btn_Selecionar.Location = new System.Drawing.Point(6, 101);
            this.Btn_Selecionar.Name = "Btn_Selecionar";
            this.Btn_Selecionar.Size = new System.Drawing.Size(69, 45);
            this.Btn_Selecionar.TabIndex = 16;
            this.Btn_Selecionar.Text = "Buscar";
            this.Btn_Selecionar.UseVisualStyleBackColor = false;
            this.Btn_Selecionar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PB_Img
            // 
            this.PB_Img.Location = new System.Drawing.Point(81, 57);
            this.PB_Img.Name = "PB_Img";
            this.PB_Img.Size = new System.Drawing.Size(209, 140);
            this.PB_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Img.TabIndex = 0;
            this.PB_Img.TabStop = false;
            // 
            // Dialog
            // 
            this.Dialog.FileName = "openFileDialog1";
            // 
            // Btn_Subir
            // 
            this.Btn_Subir.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Cima;
            this.Btn_Subir.Location = new System.Drawing.Point(311, 100);
            this.Btn_Subir.Name = "Btn_Subir";
            this.Btn_Subir.Size = new System.Drawing.Size(43, 33);
            this.Btn_Subir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Subir.TabIndex = 10;
            this.Btn_Subir.TabStop = false;
            this.Btn_Subir.Click += new System.EventHandler(this.Btn_Subir_Click);
            // 
            // Btn_Descer
            // 
            this.Btn_Descer.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Baixo;
            this.Btn_Descer.Location = new System.Drawing.Point(311, 332);
            this.Btn_Descer.Name = "Btn_Descer";
            this.Btn_Descer.Size = new System.Drawing.Size(43, 33);
            this.Btn_Descer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Descer.TabIndex = 11;
            this.Btn_Descer.TabStop = false;
            this.Btn_Descer.Click += new System.EventHandler(this.Btn_Descer_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(543, 399);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(161, 76);
            this.Btn_Salvar.TabIndex = 12;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ConteudoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(706, 478);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.PainelSuperior);
            this.Controls.Add(this.Btn_Subir);
            this.Controls.Add(this.Btn_Descer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ConteudoTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ConteudoTexto";
            this.Load += new System.EventHandler(this.Form_ConteudoTexto_Load);
            this.PainelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Azul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Subir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Descer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelSuperior;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown DUP_Tamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Italico;
        private System.Windows.Forms.CheckBox CB_Negrito;
        private System.Windows.Forms.TextBox Txt_Texto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Link;
        private System.Windows.Forms.TextBox Txt_NomeVideo;
        private System.Windows.Forms.PictureBox PB_Img;
        private System.Windows.Forms.OpenFileDialog Dialog;
        private System.Windows.Forms.PictureBox Btn_Subir;
        private System.Windows.Forms.PictureBox Btn_Descer;
        private System.Windows.Forms.PictureBox Pb_Fechar;
        private System.Windows.Forms.RadioButton Rb_Verde;
        private System.Windows.Forms.RadioButton Rb_Azul;
        private System.Windows.Forms.RadioButton Rb_Vermelho;
        private System.Windows.Forms.RadioButton Rb_Preto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Pb_Azul;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_AddTexto;
        private System.Windows.Forms.Button Btn_AddVideo;
        private System.Windows.Forms.Button Btn_Selecionar;
        private System.Windows.Forms.Button Btn_AddImagem;
        private System.Windows.Forms.MaskedTextBox MTxt_Fim;
        private System.Windows.Forms.MaskedTextBox MTxt_Inicio;
        private System.Windows.Forms.MaskedTextBox MTxt_Duracao;
    }
}