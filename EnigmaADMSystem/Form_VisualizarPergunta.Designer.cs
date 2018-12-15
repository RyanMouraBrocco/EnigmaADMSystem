namespace EnigmaADMSystem
{
    partial class Form_VisualizarPergunta
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
            this.Txt_Titulo = new System.Windows.Forms.TextBox();
            this.Txt_PerguntaResposta = new System.Windows.Forms.TextBox();
            this.Grid_Imagens = new System.Windows.Forms.DataGridView();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_PR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ll_Responder = new System.Windows.Forms.LinkLabel();
            this.Ll_AddImagem = new System.Windows.Forms.LinkLabel();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.BackColor = System.Drawing.Color.White;
            this.Txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(268, 75);
            this.Txt_Titulo.MaxLength = 50;
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.ReadOnly = true;
            this.Txt_Titulo.Size = new System.Drawing.Size(792, 22);
            this.Txt_Titulo.TabIndex = 0;
            // 
            // Txt_PerguntaResposta
            // 
            this.Txt_PerguntaResposta.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_PerguntaResposta.Location = new System.Drawing.Point(268, 145);
            this.Txt_PerguntaResposta.Multiline = true;
            this.Txt_PerguntaResposta.Name = "Txt_PerguntaResposta";
            this.Txt_PerguntaResposta.ReadOnly = true;
            this.Txt_PerguntaResposta.Size = new System.Drawing.Size(792, 188);
            this.Txt_PerguntaResposta.TabIndex = 1;
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
            this.Ordem,
            this.Imagem});
            this.Grid_Imagens.Location = new System.Drawing.Point(268, 361);
            this.Grid_Imagens.Name = "Grid_Imagens";
            this.Grid_Imagens.ReadOnly = true;
            this.Grid_Imagens.RowHeadersVisible = false;
            this.Grid_Imagens.RowTemplate.Height = 220;
            this.Grid_Imagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Imagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Imagens.Size = new System.Drawing.Size(474, 230);
            this.Grid_Imagens.TabIndex = 2;
            this.Grid_Imagens.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Imagens_KeyUp);
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Width = 45;
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 426;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "________________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título";
            // 
            // Lbl_PR
            // 
            this.Lbl_PR.AutoSize = true;
            this.Lbl_PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PR.Location = new System.Drawing.Point(264, 118);
            this.Lbl_PR.Name = "Lbl_PR";
            this.Lbl_PR.Size = new System.Drawing.Size(0, 24);
            this.Lbl_PR.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Imagens";
            // 
            // Ll_Responder
            // 
            this.Ll_Responder.AutoSize = true;
            this.Ll_Responder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ll_Responder.Location = new System.Drawing.Point(765, 523);
            this.Ll_Responder.Name = "Ll_Responder";
            this.Ll_Responder.Size = new System.Drawing.Size(104, 24);
            this.Ll_Responder.TabIndex = 9;
            this.Ll_Responder.TabStop = true;
            this.Ll_Responder.Text = "Responder";
            this.Ll_Responder.Visible = false;
            this.Ll_Responder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_Responder_LinkClicked);
            // 
            // Ll_AddImagem
            // 
            this.Ll_AddImagem.AutoSize = true;
            this.Ll_AddImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ll_AddImagem.Location = new System.Drawing.Point(748, 361);
            this.Ll_AddImagem.Name = "Ll_AddImagem";
            this.Ll_AddImagem.Size = new System.Drawing.Size(114, 16);
            this.Ll_AddImagem.TabIndex = 10;
            this.Ll_AddImagem.TabStop = true;
            this.Ll_AddImagem.Text = "Adiconar Imagem";
            this.Ll_AddImagem.Visible = false;
            this.Ll_AddImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_AddImagem_LinkClicked);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.Btn_Fechar.Location = new System.Drawing.Point(875, 472);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(214, 119);
            this.Btn_Fechar.TabIndex = 11;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Form_VisualizarPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Ll_AddImagem);
            this.Controls.Add(this.Ll_Responder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_PR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Imagens);
            this.Controls.Add(this.Txt_PerguntaResposta);
            this.Controls.Add(this.Txt_Titulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VisualizarPergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VisualizarPergunta";
            this.Load += new System.EventHandler(this.Form_VisualizarPergunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Imagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Titulo;
        private System.Windows.Forms.TextBox Txt_PerguntaResposta;
        private System.Windows.Forms.DataGridView Grid_Imagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_PR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Ll_Responder;
        private System.Windows.Forms.LinkLabel Ll_AddImagem;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}