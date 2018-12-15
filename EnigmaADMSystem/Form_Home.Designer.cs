namespace EnigmaADMSystem
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.Txt_TextoIntro = new System.Windows.Forms.TextBox();
            this.Lbl_BemVindo = new System.Windows.Forms.Label();
            this.Pb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_TextoIntro
            // 
            this.Txt_TextoIntro.BackColor = System.Drawing.Color.White;
            this.Txt_TextoIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_TextoIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TextoIntro.Location = new System.Drawing.Point(417, 460);
            this.Txt_TextoIntro.Multiline = true;
            this.Txt_TextoIntro.Name = "Txt_TextoIntro";
            this.Txt_TextoIntro.ReadOnly = true;
            this.Txt_TextoIntro.Size = new System.Drawing.Size(499, 166);
            this.Txt_TextoIntro.TabIndex = 8;
            this.Txt_TextoIntro.TabStop = false;
            this.Txt_TextoIntro.Text = resources.GetString("Txt_TextoIntro.Text");
            this.Txt_TextoIntro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_BemVindo
            // 
            this.Lbl_BemVindo.AutoSize = true;
            this.Lbl_BemVindo.BackColor = System.Drawing.Color.White;
            this.Lbl_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BemVindo.Location = new System.Drawing.Point(413, 402);
            this.Lbl_BemVindo.Name = "Lbl_BemVindo";
            this.Lbl_BemVindo.Size = new System.Drawing.Size(515, 55);
            this.Lbl_BemVindo.TabIndex = 7;
            this.Lbl_BemVindo.Text = "Bem Vindo ao Enigma ";
            // 
            // Pb_Logo
            // 
            this.Pb_Logo.BackColor = System.Drawing.Color.White;
            this.Pb_Logo.Image = global::EnigmaADMSystem.Properties.Resources.Enigma_Logo_V5_Justo;
            this.Pb_Logo.Location = new System.Drawing.Point(351, 55);
            this.Pb_Logo.Name = "Pb_Logo";
            this.Pb_Logo.Size = new System.Drawing.Size(622, 344);
            this.Pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Logo.TabIndex = 6;
            this.Pb_Logo.TabStop = false;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Txt_TextoIntro);
            this.Controls.Add(this.Lbl_BemVindo);
            this.Controls.Add(this.Pb_Logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_TextoIntro;
        private System.Windows.Forms.Label Lbl_BemVindo;
        private System.Windows.Forms.PictureBox Pb_Logo;
    }
}