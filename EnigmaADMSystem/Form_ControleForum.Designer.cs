namespace EnigmaADMSystem
{
    partial class Form_ControleForum
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
            this.Grid_Perguntas = new System.Windows.Forms.DataGridView();
            this.Pergunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denuncias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Respostas = new System.Windows.Forms.DataGridView();
            this.Respostas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Respostas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Perguntas
            // 
            this.Grid_Perguntas.AllowUserToAddRows = false;
            this.Grid_Perguntas.AllowUserToDeleteRows = false;
            this.Grid_Perguntas.AllowUserToResizeColumns = false;
            this.Grid_Perguntas.AllowUserToResizeRows = false;
            this.Grid_Perguntas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Perguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Perguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pergunta,
            this.Usuario,
            this.Denuncias,
            this.Column3});
            this.Grid_Perguntas.Location = new System.Drawing.Point(248, 97);
            this.Grid_Perguntas.MultiSelect = false;
            this.Grid_Perguntas.Name = "Grid_Perguntas";
            this.Grid_Perguntas.ReadOnly = true;
            this.Grid_Perguntas.RowHeadersVisible = false;
            this.Grid_Perguntas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Perguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Perguntas.Size = new System.Drawing.Size(442, 478);
            this.Grid_Perguntas.TabIndex = 0;
            this.Grid_Perguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellClick);
            this.Grid_Perguntas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellDoubleClick);
            this.Grid_Perguntas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Perguntas_KeyUp);
            // 
            // Pergunta
            // 
            this.Pergunta.HeaderText = "Pergunta";
            this.Pergunta.MinimumWidth = 250;
            this.Pergunta.Name = "Pergunta";
            this.Pergunta.ReadOnly = true;
            this.Pergunta.Width = 250;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 120;
            // 
            // Denuncias
            // 
            this.Denuncias.HeaderText = "Denuncias";
            this.Denuncias.Name = "Denuncias";
            this.Denuncias.ReadOnly = true;
            this.Denuncias.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Grid_Respostas
            // 
            this.Grid_Respostas.AllowUserToAddRows = false;
            this.Grid_Respostas.AllowUserToDeleteRows = false;
            this.Grid_Respostas.AllowUserToResizeColumns = false;
            this.Grid_Respostas.AllowUserToResizeRows = false;
            this.Grid_Respostas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Respostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Respostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Respostas,
            this.Column1,
            this.Column2,
            this.Column4});
            this.Grid_Respostas.Location = new System.Drawing.Point(719, 207);
            this.Grid_Respostas.MultiSelect = false;
            this.Grid_Respostas.Name = "Grid_Respostas";
            this.Grid_Respostas.ReadOnly = true;
            this.Grid_Respostas.RowHeadersVisible = false;
            this.Grid_Respostas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Respostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Respostas.Size = new System.Drawing.Size(370, 368);
            this.Grid_Respostas.TabIndex = 3;
            this.Grid_Respostas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Respostas_CellDoubleClick);
            this.Grid_Respostas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Respostas_KeyUp);
            // 
            // Respostas
            // 
            this.Respostas.HeaderText = "Respostas";
            this.Respostas.Name = "Respostas";
            this.Respostas.ReadOnly = true;
            this.Respostas.Width = 217;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Denuncias";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Respostas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Perguntas";
            // 
            // Form_ControleForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Respostas);
            this.Controls.Add(this.Grid_Perguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ControleForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ControleForum";
            this.Load += new System.EventHandler(this.Form_ControleForum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Respostas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Perguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pergunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denuncias;
        private System.Windows.Forms.DataGridView Grid_Respostas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respostas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}