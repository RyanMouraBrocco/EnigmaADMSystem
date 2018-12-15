namespace EnigmaADMSystem
{
    partial class Form_ControleUsuario
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
            this.Grid_Usuario = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Ll_Cancelar = new System.Windows.Forms.LinkLabel();
            this.Check_Senha = new System.Windows.Forms.CheckBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Usuario
            // 
            this.Grid_Usuario.AllowUserToAddRows = false;
            this.Grid_Usuario.AllowUserToDeleteRows = false;
            this.Grid_Usuario.AllowUserToResizeColumns = false;
            this.Grid_Usuario.AllowUserToResizeRows = false;
            this.Grid_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Tipo,
            this.ID});
            this.Grid_Usuario.Location = new System.Drawing.Point(251, 298);
            this.Grid_Usuario.MultiSelect = false;
            this.Grid_Usuario.Name = "Grid_Usuario";
            this.Grid_Usuario.ReadOnly = true;
            this.Grid_Usuario.RowHeadersVisible = false;
            this.Grid_Usuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Usuario.Size = new System.Drawing.Size(811, 182);
            this.Grid_Usuario.TabIndex = 0;
            this.Grid_Usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Usuario_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 300;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 350;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 350;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 150;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.Color.White;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(251, 112);
            this.Txt_Nome.MaxLength = 100;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(811, 22);
            this.Txt_Nome.TabIndex = 1;
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "Estudante",
            "Adiministrador",
            "Chefe",
            "Banido"});
            this.CB_Tipo.Location = new System.Drawing.Point(251, 261);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(318, 32);
            this.CB_Tipo.TabIndex = 2;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.White;
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(251, 161);
            this.Txt_Email.MaxLength = 150;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(811, 22);
            this.Txt_Email.TabIndex = 3;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BackColor = System.Drawing.Color.White;
            this.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Senha.Location = new System.Drawing.Point(250, 211);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(372, 22);
            this.Txt_Senha.TabIndex = 4;
            // 
            // Txt_ConfirmarSenha
            // 
            this.Txt_ConfirmarSenha.BackColor = System.Drawing.Color.White;
            this.Txt_ConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfirmarSenha.Location = new System.Drawing.Point(678, 211);
            this.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha";
            this.Txt_ConfirmarSenha.PasswordChar = '*';
            this.Txt_ConfirmarSenha.Size = new System.Drawing.Size(384, 22);
            this.Txt_ConfirmarSenha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(830, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(673, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirmar Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "______________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(673, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "_______________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo de Conta";
            // 
            // Txt_Pesquisar
            // 
            this.Txt_Pesquisar.BackColor = System.Drawing.Color.White;
            this.Txt_Pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pesquisar.Location = new System.Drawing.Point(251, 507);
            this.Txt_Pesquisar.Name = "Txt_Pesquisar";
            this.Txt_Pesquisar.Size = new System.Drawing.Size(621, 22);
            this.Txt_Pesquisar.TabIndex = 16;
            this.Txt_Pesquisar.TextChanged += new System.EventHandler(this.Txt_Pesquisar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(640, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "_______________________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Pesquisar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(508, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 31);
            this.label12.TabIndex = 19;
            this.label12.Text = "Controle de Usuário";
            // 
            // Ll_Cancelar
            // 
            this.Ll_Cancelar.AutoSize = true;
            this.Ll_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ll_Cancelar.Location = new System.Drawing.Point(1000, 279);
            this.Ll_Cancelar.Name = "Ll_Cancelar";
            this.Ll_Cancelar.Size = new System.Drawing.Size(62, 16);
            this.Ll_Cancelar.TabIndex = 20;
            this.Ll_Cancelar.TabStop = true;
            this.Ll_Cancelar.Text = "Cancelar";
            this.Ll_Cancelar.Visible = false;
            this.Ll_Cancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_Cancelar_LinkClicked);
            // 
            // Check_Senha
            // 
            this.Check_Senha.AutoSize = true;
            this.Check_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Senha.Location = new System.Drawing.Point(575, 266);
            this.Check_Senha.Name = "Check_Senha";
            this.Check_Senha.Size = new System.Drawing.Size(126, 24);
            this.Check_Senha.TabIndex = 23;
            this.Check_Senha.Text = "Alterar Senha";
            this.Check_Senha.UseVisualStyleBackColor = true;
            this.Check_Senha.Visible = false;
            this.Check_Senha.CheckedChanged += new System.EventHandler(this.Check_Senha_CheckedChanged);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Atualizar.Location = new System.Drawing.Point(898, 486);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(191, 105);
            this.Btn_Atualizar.TabIndex = 24;
            this.Btn_Atualizar.Text = "Inserir";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Form_ControleUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Check_Senha);
            this.Controls.Add(this.Ll_Cancelar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Pesquisar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_ConfirmarSenha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.CB_Tipo);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Grid_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ControleUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ControleUsuario";
            this.Load += new System.EventHandler(this.Form_ControleUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Usuario;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.ComboBox CB_Tipo;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_ConfirmarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Pesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.LinkLabel Ll_Cancelar;
        private System.Windows.Forms.CheckBox Check_Senha;
        private System.Windows.Forms.Button Btn_Atualizar;
    }
}