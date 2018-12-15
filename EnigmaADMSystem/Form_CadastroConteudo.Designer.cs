namespace EnigmaADMSystem
{
    partial class Form_CadastroConteudo
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
            this.CB_Materia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_AddImagem = new System.Windows.Forms.Button();
            this.Lbl_Limpar = new System.Windows.Forms.LinkLabel();
            this.PB_Foto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AlterarConteudo = new System.Windows.Forms.Button();
            this.Grid_Conteudo = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Resumo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FD = new System.Windows.Forms.OpenFileDialog();
            this.Grid_Resumo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Resumo)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.Color.White;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(267, 87);
            this.Txt_Nome.MaxLength = 100;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(807, 22);
            this.Txt_Nome.TabIndex = 0;
            // 
            // CB_Materia
            // 
            this.CB_Materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CB_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Materia.FormattingEnabled = true;
            this.CB_Materia.Location = new System.Drawing.Point(268, 156);
            this.CB_Materia.Name = "CB_Materia";
            this.CB_Materia.Size = new System.Drawing.Size(360, 126);
            this.CB_Materia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Conteudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "_________________________________________________________________________________" +
    "\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matéria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_AddImagem);
            this.groupBox1.Controls.Add(this.Lbl_Limpar);
            this.groupBox1.Controls.Add(this.PB_Foto);
            this.groupBox1.Location = new System.Drawing.Point(267, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 225);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Btn_AddImagem
            // 
            this.Btn_AddImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddImagem.ForeColor = System.Drawing.Color.White;
            this.Btn_AddImagem.Location = new System.Drawing.Point(23, 79);
            this.Btn_AddImagem.Name = "Btn_AddImagem";
            this.Btn_AddImagem.Size = new System.Drawing.Size(122, 65);
            this.Btn_AddImagem.TabIndex = 20;
            this.Btn_AddImagem.Text = "Adic. Imagem";
            this.Btn_AddImagem.UseVisualStyleBackColor = true;
            this.Btn_AddImagem.Click += new System.EventHandler(this.Btn_AddImagem_Click);
            // 
            // Lbl_Limpar
            // 
            this.Lbl_Limpar.AutoSize = true;
            this.Lbl_Limpar.Location = new System.Drawing.Point(220, 193);
            this.Lbl_Limpar.Name = "Lbl_Limpar";
            this.Lbl_Limpar.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Limpar.TabIndex = 14;
            this.Lbl_Limpar.TabStop = true;
            this.Lbl_Limpar.Text = "Apagar Imagem";
            this.Lbl_Limpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_Limpar_LinkClicked);
            // 
            // PB_Foto
            // 
            this.PB_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Foto.Location = new System.Drawing.Point(165, 32);
            this.PB_Foto.Name = "PB_Foto";
            this.PB_Foto.Size = new System.Drawing.Size(185, 158);
            this.PB_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Foto.TabIndex = 2;
            this.PB_Foto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imagem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_AlterarConteudo);
            this.groupBox2.Controls.Add(this.Grid_Conteudo);
            this.groupBox2.Location = new System.Drawing.Point(648, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 170);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Btn_AlterarConteudo
            // 
            this.Btn_AlterarConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AlterarConteudo.ForeColor = System.Drawing.Color.White;
            this.Btn_AlterarConteudo.Location = new System.Drawing.Point(19, 58);
            this.Btn_AlterarConteudo.Name = "Btn_AlterarConteudo";
            this.Btn_AlterarConteudo.Size = new System.Drawing.Size(122, 65);
            this.Btn_AlterarConteudo.TabIndex = 22;
            this.Btn_AlterarConteudo.Text = "Alterar Cont.";
            this.Btn_AlterarConteudo.UseVisualStyleBackColor = true;
            this.Btn_AlterarConteudo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Grid_Conteudo
            // 
            this.Grid_Conteudo.AllowUserToAddRows = false;
            this.Grid_Conteudo.AllowUserToDeleteRows = false;
            this.Grid_Conteudo.AllowUserToResizeColumns = false;
            this.Grid_Conteudo.AllowUserToResizeRows = false;
            this.Grid_Conteudo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Grid_Conteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Conteudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tipo,
            this.Ordem});
            this.Grid_Conteudo.Location = new System.Drawing.Point(147, 19);
            this.Grid_Conteudo.Name = "Grid_Conteudo";
            this.Grid_Conteudo.ReadOnly = true;
            this.Grid_Conteudo.RowHeadersVisible = false;
            this.Grid_Conteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Conteudo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Conteudo.Size = new System.Drawing.Size(279, 140);
            this.Grid_Conteudo.TabIndex = 16;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 140;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 70;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Resumo);
            this.groupBox3.Location = new System.Drawing.Point(648, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 113);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Btn_Resumo
            // 
            this.Btn_Resumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Resumo.ForeColor = System.Drawing.Color.White;
            this.Btn_Resumo.Location = new System.Drawing.Point(19, 36);
            this.Btn_Resumo.Name = "Btn_Resumo";
            this.Btn_Resumo.Size = new System.Drawing.Size(97, 56);
            this.Btn_Resumo.TabIndex = 21;
            this.Btn_Resumo.Text = "Alt. Resumo";
            this.Btn_Resumo.UseVisualStyleBackColor = true;
            this.Btn_Resumo.Click += new System.EventHandler(this.Btn_Resumo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Conteudo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Resumo";
            // 
            // FD
            // 
            this.FD.FileName = "openFileDialog1";
            // 
            // Grid_Resumo
            // 
            this.Grid_Resumo.AllowUserToAddRows = false;
            this.Grid_Resumo.AllowUserToDeleteRows = false;
            this.Grid_Resumo.AllowUserToResizeColumns = false;
            this.Grid_Resumo.AllowUserToResizeRows = false;
            this.Grid_Resumo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Grid_Resumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Resumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Grid_Resumo.Location = new System.Drawing.Point(795, 374);
            this.Grid_Resumo.Name = "Grid_Resumo";
            this.Grid_Resumo.ReadOnly = true;
            this.Grid_Resumo.RowHeadersVisible = false;
            this.Grid_Resumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Resumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Resumo.Size = new System.Drawing.Size(279, 82);
            this.Grid_Resumo.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Arquivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(887, 485);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(197, 106);
            this.Btn_Salvar.TabIndex = 19;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_CadastroConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Grid_Resumo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Materia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CadastroConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CadastroConteudo";
            this.Load += new System.EventHandler(this.Form_CadastroConteudo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Resumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.ComboBox CB_Materia;
        private System.Windows.Forms.PictureBox PB_Foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog FD;
        private System.Windows.Forms.LinkLabel Lbl_Limpar;
        private System.Windows.Forms.DataGridView Grid_Conteudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridView Grid_Resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_AddImagem;
        private System.Windows.Forms.Button Btn_Resumo;
        private System.Windows.Forms.Button Btn_AlterarConteudo;
    }
}