namespace EnigmaADMSystem
{
    partial class Form_CadastroResumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroResumo));
            this.PainelSuperior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Arquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ADD = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.BackColor = System.Drawing.Color.MidnightBlue;
            this.PainelSuperior.Controls.Add(this.Pb_Fechar);
            this.PainelSuperior.Location = new System.Drawing.Point(-5, -11);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(368, 61);
            this.PainelSuperior.TabIndex = 0;
            this.PainelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseDown);
            this.PainelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseMove);
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaADMSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(308, 17);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(37, 37);
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
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arquivo,
            this.Ordem});
            this.Grid.Location = new System.Drawing.Point(112, 20);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(198, 154);
            this.Grid.TabIndex = 1;
            this.Grid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyUp);
            // 
            // Arquivo
            // 
            this.Arquivo.HeaderText = "Arquivo";
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.ReadOnly = true;
            this.Arquivo.Width = 200;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            // 
            // Dialog
            // 
            this.Dialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_ADD);
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Btn_ADD
            // 
            this.Btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ADD.ForeColor = System.Drawing.Color.White;
            this.Btn_ADD.Location = new System.Drawing.Point(6, 20);
            this.Btn_ADD.Name = "Btn_ADD";
            this.Btn_ADD.Size = new System.Drawing.Size(100, 51);
            this.Btn_ADD.TabIndex = 4;
            this.Btn_ADD.Text = "ADD";
            this.Btn_ADD.UseVisualStyleBackColor = true;
            this.Btn_ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(238, 244);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(96, 50);
            this.Btn_Salvar.TabIndex = 5;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Form_CadastroResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(346, 305);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PainelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CadastroResumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CadastroResumo";
            this.Load += new System.EventHandler(this.Form_CadastroResumo_Load);
            this.PainelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelSuperior;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.OpenFileDialog Dialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Pb_Fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.Button Btn_ADD;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}