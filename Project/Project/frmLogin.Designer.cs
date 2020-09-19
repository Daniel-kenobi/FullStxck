namespace Project
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCadatro = new System.Windows.Forms.Label();
            this.labelEsqueceu = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textboxUsuario = new System.Windows.Forms.TextBox();
            this.maskedSenha = new System.Windows.Forms.MaskedTextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.linkNerd = new System.Windows.Forms.LinkLabel();
            this.panelFolder = new System.Windows.Forms.Panel();
            this.labelSubSlogan = new System.Windows.Forms.Label();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(70)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelCadatro);
            this.panel1.Controls.Add(this.labelEsqueceu);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textboxUsuario);
            this.panel1.Controls.Add(this.maskedSenha);
            this.panel1.Location = new System.Drawing.Point(515, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 294);
            this.panel1.TabIndex = 1;
            // 
            // labelCadatro
            // 
            this.labelCadatro.AutoSize = true;
            this.labelCadatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadatro.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCadatro.Location = new System.Drawing.Point(21, 265);
            this.labelCadatro.Name = "labelCadatro";
            this.labelCadatro.Size = new System.Drawing.Size(190, 15);
            this.labelCadatro.TabIndex = 0;
            this.labelCadatro.Text = "Não tem login ? Cadastre-se";
            this.labelCadatro.Click += new System.EventHandler(this.labelCadatro_Click);
            // 
            // labelEsqueceu
            // 
            this.labelEsqueceu.AutoSize = true;
            this.labelEsqueceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsqueceu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEsqueceu.Location = new System.Drawing.Point(41, 225);
            this.labelEsqueceu.Name = "labelEsqueceu";
            this.labelEsqueceu.Size = new System.Drawing.Size(148, 16);
            this.labelEsqueceu.TabIndex = 0;
            this.labelEsqueceu.Text = "Esqueceu a senha ?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 179);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(195, 43);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSenha.Location = new System.Drawing.Point(81, 116);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(61, 20);
            this.labelSenha.TabIndex = 0;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsuario.Location = new System.Drawing.Point(76, 70);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(71, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuário";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelLogin);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 45);
            this.panel2.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Location = new System.Drawing.Point(85, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // textboxUsuario
            // 
            this.textboxUsuario.Location = new System.Drawing.Point(16, 93);
            this.textboxUsuario.Name = "textboxUsuario";
            this.textboxUsuario.Size = new System.Drawing.Size(195, 20);
            this.textboxUsuario.TabIndex = 1;
            // 
            // maskedSenha
            // 
            this.maskedSenha.Location = new System.Drawing.Point(16, 139);
            this.maskedSenha.Name = "maskedSenha";
            this.maskedSenha.PasswordChar = '*';
            this.maskedSenha.Size = new System.Drawing.Size(195, 20);
            this.maskedSenha.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitulo.Location = new System.Drawing.Point(553, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(150, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nerd Tech";
            // 
            // linkNerd
            // 
            this.linkNerd.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.linkNerd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNerd.AutoSize = true;
            this.linkNerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNerd.LinkColor = System.Drawing.SystemColors.Control;
            this.linkNerd.Location = new System.Drawing.Point(555, 411);
            this.linkNerd.Name = "linkNerd";
            this.linkNerd.Size = new System.Drawing.Size(160, 20);
            this.linkNerd.TabIndex = 3;
            this.linkNerd.TabStop = true;
            this.linkNerd.Text = "Nerd Technologies  ©";
            this.linkNerd.VisitedLinkColor = System.Drawing.SystemColors.Control;
            // 
            // panelFolder
            // 
            this.panelFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFolder.BackgroundImage")));
            this.panelFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFolder.Controls.Add(this.labelSubSlogan);
            this.panelFolder.Controls.Add(this.labelSlogan);
            this.panelFolder.Location = new System.Drawing.Point(-3, 1);
            this.panelFolder.Name = "panelFolder";
            this.panelFolder.Size = new System.Drawing.Size(468, 438);
            this.panelFolder.TabIndex = 0;
            // 
            // labelSubSlogan
            // 
            this.labelSubSlogan.AutoSize = true;
            this.labelSubSlogan.BackColor = System.Drawing.Color.Transparent;
            this.labelSubSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubSlogan.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSubSlogan.Location = new System.Drawing.Point(13, 174);
            this.labelSubSlogan.Name = "labelSubSlogan";
            this.labelSubSlogan.Size = new System.Drawing.Size(318, 18);
            this.labelSubSlogan.TabIndex = 1;
            this.labelSubSlogan.Text = "Fácil de usar, gratuito e de código aberto";
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.BackColor = System.Drawing.Color.Transparent;
            this.labelSlogan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSlogan.Location = new System.Drawing.Point(3, 151);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(458, 23);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.Text = "Organize a sua empresa de modo fácil e grátis!";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(776, 440);
            this.Controls.Add(this.linkNerd);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFolder);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nerd Technologies Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFolder.ResumeLayout(false);
            this.panelFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFolder;
        private System.Windows.Forms.Label labelSubSlogan;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCadatro;
        private System.Windows.Forms.Label labelEsqueceu;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textboxUsuario;
        private System.Windows.Forms.MaskedTextBox maskedSenha;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.LinkLabel linkNerd;
    }
}