namespace EnigmaADMSystem
{
    partial class Form_CadastroMateria
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
            this.Txt_Materia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.PB_Img = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_AddImagem = new System.Windows.Forms.Button();
            this.Lbl_Apagar = new System.Windows.Forms.LinkLabel();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LL_Conteudos = new System.Windows.Forms.LinkLabel();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Materia
            // 
            this.Txt_Materia.BackColor = System.Drawing.Color.White;
            this.Txt_Materia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Materia.Location = new System.Drawing.Point(263, 91);
            this.Txt_Materia.MaxLength = 100;
            this.Txt_Materia.Name = "Txt_Materia";
            this.Txt_Materia.Size = new System.Drawing.Size(788, 22);
            this.Txt_Materia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da matéria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da matéria";
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descricao.Location = new System.Drawing.Point(263, 168);
            this.Txt_Descricao.MaxLength = 200;
            this.Txt_Descricao.Multiline = true;
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(788, 88);
            this.Txt_Descricao.TabIndex = 2;
            // 
            // PB_Img
            // 
            this.PB_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Img.Location = new System.Drawing.Point(258, 19);
            this.PB_Img.Name = "PB_Img";
            this.PB_Img.Size = new System.Drawing.Size(205, 179);
            this.PB_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Img.TabIndex = 4;
            this.PB_Img.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Imagem da matéria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "_______________________________________________________________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_AddImagem);
            this.groupBox1.Controls.Add(this.Lbl_Apagar);
            this.groupBox1.Controls.Add(this.PB_Img);
            this.groupBox1.Location = new System.Drawing.Point(263, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(548, 233);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Btn_AddImagem
            // 
            this.Btn_AddImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddImagem.ForeColor = System.Drawing.Color.White;
            this.Btn_AddImagem.Location = new System.Drawing.Point(61, 94);
            this.Btn_AddImagem.Name = "Btn_AddImagem";
            this.Btn_AddImagem.Size = new System.Drawing.Size(121, 58);
            this.Btn_AddImagem.TabIndex = 11;
            this.Btn_AddImagem.Text = "Adic. Imagem";
            this.Btn_AddImagem.UseVisualStyleBackColor = true;
            this.Btn_AddImagem.Click += new System.EventHandler(this.Btn_AddImagem_Click);
            // 
            // Lbl_Apagar
            // 
            this.Lbl_Apagar.AutoSize = true;
            this.Lbl_Apagar.Location = new System.Drawing.Point(319, 201);
            this.Lbl_Apagar.Name = "Lbl_Apagar";
            this.Lbl_Apagar.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Apagar.TabIndex = 10;
            this.Lbl_Apagar.TabStop = true;
            this.Lbl_Apagar.Text = "Apagar Imagem";
            this.Lbl_Apagar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_Apagar_LinkClicked);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // LL_Conteudos
            // 
            this.LL_Conteudos.AutoSize = true;
            this.LL_Conteudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Conteudos.Location = new System.Drawing.Point(859, 444);
            this.LL_Conteudos.Name = "LL_Conteudos";
            this.LL_Conteudos.Size = new System.Drawing.Size(187, 24);
            this.LL_Conteudos.TabIndex = 13;
            this.LL_Conteudos.TabStop = true;
            this.LL_Conteudos.Text = "Visualizar Conteúdos";
            this.LL_Conteudos.Visible = false;
            this.LL_Conteudos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Conteudos_LinkClicked);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(845, 471);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(214, 120);
            this.Btn_Salvar.TabIndex = 12;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_CadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.LL_Conteudos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_Materia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CadastroMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CadastroMateria";
            this.Load += new System.EventHandler(this.Form_CadastroMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Materia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Descricao;
        private System.Windows.Forms.PictureBox PB_Img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.LinkLabel Lbl_Apagar;
        private System.Windows.Forms.LinkLabel LL_Conteudos;
        private System.Windows.Forms.Button Btn_AddImagem;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}