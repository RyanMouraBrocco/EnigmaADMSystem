namespace EnigmaADMSystem
{
    partial class Form_Selecionar
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LL_NovaMateria = new System.Windows.Forms.LinkLabel();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Pb_Subir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Sobre,
            this.Ordem,
            this.ID});
            this.Grid.Location = new System.Drawing.Point(238, 89);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(840, 275);
            this.Grid.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 370;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 370;
            // 
            // Sobre
            // 
            this.Sobre.HeaderText = "Sobre";
            this.Sobre.MinimumWidth = 370;
            this.Sobre.Name = "Sobre";
            this.Sobre.ReadOnly = true;
            this.Sobre.Width = 370;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(524, 55);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(142, 31);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Selecionar";
            // 
            // Txt_Pesquisa
            // 
            this.Txt_Pesquisa.BackColor = System.Drawing.Color.White;
            this.Txt_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pesquisa.Location = new System.Drawing.Point(249, 406);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.Size = new System.Drawing.Size(772, 22);
            this.Txt_Pesquisa.TabIndex = 3;
            this.Txt_Pesquisa.TextChanged += new System.EventHandler(this.Txt_Pesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "______________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquisar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1040, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LL_NovaMateria
            // 
            this.LL_NovaMateria.AutoSize = true;
            this.LL_NovaMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_NovaMateria.Location = new System.Drawing.Point(234, 519);
            this.LL_NovaMateria.Name = "LL_NovaMateria";
            this.LL_NovaMateria.Size = new System.Drawing.Size(120, 24);
            this.LL_NovaMateria.TabIndex = 8;
            this.LL_NovaMateria.TabStop = true;
            this.LL_NovaMateria.Text = "Nova Matéria";
            this.LL_NovaMateria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_NovaMateria_LinkClicked);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Location = new System.Drawing.Point(893, 479);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(196, 112);
            this.Btn_Editar.TabIndex = 9;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Pb_Subir
            // 
            this.Pb_Subir.Image = global::EnigmaADMSystem.Properties.Resources.Seta_Cima;
            this.Pb_Subir.Location = new System.Drawing.Point(1019, 370);
            this.Pb_Subir.Name = "Pb_Subir";
            this.Pb_Subir.Size = new System.Drawing.Size(59, 33);
            this.Pb_Subir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Subir.TabIndex = 10;
            this.Pb_Subir.TabStop = false;
            this.Pb_Subir.Visible = false;
            this.Pb_Subir.Click += new System.EventHandler(this.Pb_Subir_Click);
            // 
            // Form_Selecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Pb_Subir);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.LL_NovaMateria);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Pesquisa);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Selecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Materias";
            this.Load += new System.EventHandler(this.Form_Selecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Subir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_Pesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.LinkLabel LL_NovaMateria;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.PictureBox Pb_Subir;
    }
}