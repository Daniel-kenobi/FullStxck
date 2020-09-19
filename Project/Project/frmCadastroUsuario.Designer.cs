namespace Project
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.maskedSenha = new System.Windows.Forms.MaskedTextBox();
            this.maskedConfirm = new System.Windows.Forms.MaskedTextBox();
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelCadastrar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.labelConfirm);
            this.panel1.Controls.Add(this.maskedSenha);
            this.panel1.Controls.Add(this.maskedConfirm);
            this.panel1.Controls.Add(this.textboxUser);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.labelCadastrar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 219);
            this.panel1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(143, 176);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(137, 30);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Cadastrar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConfirm.Location = new System.Drawing.Point(139, 127);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(141, 20);
            this.labelConfirm.TabIndex = 0;
            this.labelConfirm.Text = "Confirmar senha";
            // 
            // maskedSenha
            // 
            this.maskedSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedSenha.Location = new System.Drawing.Point(68, 104);
            this.maskedSenha.Name = "maskedSenha";
            this.maskedSenha.PasswordChar = '*';
            this.maskedSenha.Size = new System.Drawing.Size(289, 20);
            this.maskedSenha.TabIndex = 2;
            // 
            // maskedConfirm
            // 
            this.maskedConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedConfirm.Location = new System.Drawing.Point(68, 150);
            this.maskedConfirm.Name = "maskedConfirm";
            this.maskedConfirm.PasswordChar = '*';
            this.maskedConfirm.Size = new System.Drawing.Size(289, 20);
            this.maskedConfirm.TabIndex = 3;
            // 
            // textboxUser
            // 
            this.textboxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUser.Location = new System.Drawing.Point(68, 58);
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(289, 20);
            this.textboxUser.TabIndex = 1;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSenha.Location = new System.Drawing.Point(180, 81);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(61, 20);
            this.labelSenha.TabIndex = 0;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUsuario.Location = new System.Drawing.Point(173, 35);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(87, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Nickname";
            // 
            // labelCadastrar
            // 
            this.labelCadastrar.AutoSize = true;
            this.labelCadastrar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCadastrar.Location = new System.Drawing.Point(170, 0);
            this.labelCadastrar.Name = "labelCadastrar";
            this.labelCadastrar.Size = new System.Drawing.Size(90, 23);
            this.labelCadastrar.TabIndex = 0;
            this.labelCadastrar.Text = "Cadastrar";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(459, 243);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastrar usuário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.MaskedTextBox maskedSenha;
        private System.Windows.Forms.MaskedTextBox maskedConfirm;
        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelCadastrar;
    }
}