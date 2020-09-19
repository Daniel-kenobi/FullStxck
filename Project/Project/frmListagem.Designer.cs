namespace Project
{
    partial class frmListagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagem));
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.labelMain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.checkboxPalavraInt = new System.Windows.Forms.CheckBox();
            this.radioCod = new System.Windows.Forms.RadioButton();
            this.checkboxAtivos = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textboxPesquisa = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToOrderColumns = true;
            this.gridProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProdutos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProdutos.Location = new System.Drawing.Point(137, 82);
            this.gridProdutos.MultiSelect = false;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(714, 434);
            this.gridProdutos.TabIndex = 1;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            this.gridProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellContentDoubleClick);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMain.Location = new System.Drawing.Point(322, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(238, 29);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Produtos disponíveis";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.checkboxAtivos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridProdutos);
            this.panel1.Controls.Add(this.labelMain);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.linkAbout);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.labelRefresh);
            this.panel5.Location = new System.Drawing.Point(530, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 38);
            this.panel5.TabIndex = 7;
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.LinkColor = System.Drawing.Color.White;
            this.linkAbout.Location = new System.Drawing.Point(115, 20);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(93, 13);
            this.linkAbout.TabIndex = 2;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "[F2] Author Github";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(233, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "[ESC] Fechar";
            // 
            // labelRefresh
            // 
            this.labelRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRefresh.Location = new System.Drawing.Point(115, 5);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(115, 13);
            this.labelRefresh.TabIndex = 0;
            this.labelRefresh.Text = "[F1] Recarregar Dados";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioNome);
            this.panel4.Controls.Add(this.checkboxPalavraInt);
            this.panel4.Controls.Add(this.radioCod);
            this.panel4.Location = new System.Drawing.Point(266, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 38);
            this.panel4.TabIndex = 6;
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioNome.Location = new System.Drawing.Point(3, 3);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(107, 17);
            this.radioNome.TabIndex = 4;
            this.radioNome.TabStop = true;
            this.radioNome.Text = "Nome do produto";
            this.radioNome.UseVisualStyleBackColor = true;
            this.radioNome.CheckedChanged += new System.EventHandler(this.radioNome_CheckedChanged);
            // 
            // checkboxPalavraInt
            // 
            this.checkboxPalavraInt.AutoSize = true;
            this.checkboxPalavraInt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkboxPalavraInt.Location = new System.Drawing.Point(120, 11);
            this.checkboxPalavraInt.Name = "checkboxPalavraInt";
            this.checkboxPalavraInt.Size = new System.Drawing.Size(135, 17);
            this.checkboxPalavraInt.TabIndex = 5;
            this.checkboxPalavraInt.Text = "Coincidir palavra inteira";
            this.checkboxPalavraInt.UseVisualStyleBackColor = true;
            // 
            // radioCod
            // 
            this.radioCod.AutoSize = true;
            this.radioCod.ForeColor = System.Drawing.SystemColors.Control;
            this.radioCod.Location = new System.Drawing.Point(3, 18);
            this.radioCod.Name = "radioCod";
            this.radioCod.Size = new System.Drawing.Size(112, 17);
            this.radioCod.TabIndex = 3;
            this.radioCod.TabStop = true;
            this.radioCod.Text = "Código do produto";
            this.radioCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCod.UseVisualStyleBackColor = true;
            this.radioCod.CheckedChanged += new System.EventHandler(this.radioCod_CheckedChanged);
            // 
            // checkboxAtivos
            // 
            this.checkboxAtivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxAtivos.AutoSize = true;
            this.checkboxAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAtivos.ForeColor = System.Drawing.SystemColors.Control;
            this.checkboxAtivos.Location = new System.Drawing.Point(137, 522);
            this.checkboxAtivos.Name = "checkboxAtivos";
            this.checkboxAtivos.Size = new System.Drawing.Size(141, 20);
            this.checkboxAtivos.TabIndex = 4;
            this.checkboxAtivos.Text = "Listar não ativos";
            this.checkboxAtivos.UseVisualStyleBackColor = true;
            this.checkboxAtivos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.textboxPesquisa);
            this.panel3.Controls.Add(this.labelPesquisar);
            this.panel3.Location = new System.Drawing.Point(9, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 37);
            this.panel3.TabIndex = 3;
            // 
            // textboxPesquisa
            // 
            this.textboxPesquisa.Location = new System.Drawing.Point(92, 9);
            this.textboxPesquisa.Name = "textboxPesquisa";
            this.textboxPesquisa.Size = new System.Drawing.Size(144, 20);
            this.textboxPesquisa.TabIndex = 2;
            this.textboxPesquisa.TextChanged += new System.EventHandler(this.textboxPesquisa_TextChanged);
            this.textboxPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxPesquisa_KeyPress);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPesquisar.Location = new System.Drawing.Point(3, 9);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(83, 20);
            this.labelPesquisar.TabIndex = 1;
            this.labelPesquisar.Text = "Pesquisar:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelDelete);
            this.panel2.Controls.Add(this.labelEdit);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.labelAdd);
            this.panel2.Controls.Add(this.buttonCreate);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Location = new System.Drawing.Point(9, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 460);
            this.panel2.TabIndex = 2;
            // 
            // labelDelete
            // 
            this.labelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(25, 349);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(62, 20);
            this.labelDelete.TabIndex = 5;
            this.labelDelete.Text = "Delete";
            // 
            // labelEdit
            // 
            this.labelEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(30, 173);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(57, 20);
            this.labelEdit.TabIndex = 4;
            this.labelEdit.Text = "Editar";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Location = new System.Drawing.Point(21, 372);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 69);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(17, 5);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(84, 20);
            this.labelAdd.TabIndex = 1;
            this.labelAdd.Text = "Adicionar";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreate.BackgroundImage")));
            this.buttonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreate.Location = new System.Drawing.Point(21, 28);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(71, 69);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEdit.BackgroundImage = global::Project.Properties.Resources.icons8_edit_64;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(21, 196);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(71, 69);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // frmListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 550);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListagem";
            this.Text = "Listagem de produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListagem_FormClosing);
            this.Load += new System.EventHandler(this.frmListagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkboxAtivos;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.CheckBox checkboxPalavraInt;
        private System.Windows.Forms.RadioButton radioCod;
        private System.Windows.Forms.TextBox textboxPesquisa;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.Label label1;
    }
}