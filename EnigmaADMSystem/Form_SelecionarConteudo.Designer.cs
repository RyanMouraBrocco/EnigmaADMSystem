namespace EnigmaADMSystem
{
    partial class Form_SelecionarConteudo
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
            this.LB_Materia = new System.Windows.Forms.ListBox();
            this.LB_Conteudo = new System.Windows.Forms.ListBox();
            this.LB_Exercicio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Criar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Materia
            // 
            this.LB_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Materia.FormattingEnabled = true;
            this.LB_Materia.ItemHeight = 20;
            this.LB_Materia.Location = new System.Drawing.Point(10, 42);
            this.LB_Materia.Name = "LB_Materia";
            this.LB_Materia.Size = new System.Drawing.Size(177, 444);
            this.LB_Materia.TabIndex = 0;
            this.LB_Materia.SelectedIndexChanged += new System.EventHandler(this.LB_Materia_SelectedIndexChanged);
            // 
            // LB_Conteudo
            // 
            this.LB_Conteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Conteudo.FormattingEnabled = true;
            this.LB_Conteudo.ItemHeight = 20;
            this.LB_Conteudo.Location = new System.Drawing.Point(219, 42);
            this.LB_Conteudo.Name = "LB_Conteudo";
            this.LB_Conteudo.Size = new System.Drawing.Size(177, 444);
            this.LB_Conteudo.TabIndex = 1;
            this.LB_Conteudo.SelectedIndexChanged += new System.EventHandler(this.LB_Conteudo_SelectedIndexChanged);
            // 
            // LB_Exercicio
            // 
            this.LB_Exercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Exercicio.FormattingEnabled = true;
            this.LB_Exercicio.ItemHeight = 20;
            this.LB_Exercicio.Location = new System.Drawing.Point(425, 42);
            this.LB_Exercicio.Name = "LB_Exercicio";
            this.LB_Exercicio.Size = new System.Drawing.Size(177, 444);
            this.LB_Exercicio.TabIndex = 2;
            this.LB_Exercicio.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matérias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conteudos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercícios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastrar Exercícios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LB_Materia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LB_Conteudo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LB_Exercicio);
            this.groupBox1.Location = new System.Drawing.Point(280, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 503);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Criar
            // 
            this.Btn_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Criar.ForeColor = System.Drawing.Color.White;
            this.Btn_Criar.Location = new System.Drawing.Point(931, 502);
            this.Btn_Criar.Name = "Btn_Criar";
            this.Btn_Criar.Size = new System.Drawing.Size(158, 89);
            this.Btn_Criar.TabIndex = 10;
            this.Btn_Criar.Text = "Criar";
            this.Btn_Criar.UseVisualStyleBackColor = true;
            this.Btn_Criar.Click += new System.EventHandler(this.Btn_Criar_Click);
            // 
            // Form_SelecionarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Criar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SelecionarConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SelecionarConteudo";
            this.Load += new System.EventHandler(this.Form_SelecionarConteudo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Materia;
        private System.Windows.Forms.ListBox LB_Conteudo;
        private System.Windows.Forms.ListBox LB_Exercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Criar;
    }
}