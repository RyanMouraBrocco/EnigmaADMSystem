namespace EnigmaADMSystem
{
    partial class Form_AddAlternativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddAlternativa));
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.Txt_Alternativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Pb_Fechar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(487, 44);
            this.Panel_Superior.TabIndex = 0;
            this.Panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseDown);
            this.Panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseMove);
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaADMSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(440, 3);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(44, 38);
            this.Pb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Fechar.TabIndex = 0;
            this.Pb_Fechar.TabStop = false;
            this.Pb_Fechar.Click += new System.EventHandler(this.Pb_Fechar_Click);
            // 
            // Txt_Alternativa
            // 
            this.Txt_Alternativa.Location = new System.Drawing.Point(12, 70);
            this.Txt_Alternativa.MaxLength = 400;
            this.Txt_Alternativa.Multiline = true;
            this.Txt_Alternativa.Name = "Txt_Alternativa";
            this.Txt_Alternativa.Size = new System.Drawing.Size(463, 107);
            this.Txt_Alternativa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alternativa";
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.Btn_Adicionar.Location = new System.Drawing.Point(351, 183);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(124, 70);
            this.Btn_Adicionar.TabIndex = 5;
            this.Btn_Adicionar.Text = "ADD";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Form_AddAlternativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(487, 265);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Alternativa);
            this.Controls.Add(this.Panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AddAlternativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddAlternativa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddAlternativa_FormClosing);
            this.Load += new System.EventHandler(this.Form_AddAlternativa_Load);
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.TextBox Txt_Alternativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pb_Fechar;
        private System.Windows.Forms.Button Btn_Adicionar;
    }
}