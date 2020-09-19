namespace Project
{
    partial class frmCadastroProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.buttonAction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAtivo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioNao = new System.Windows.Forms.RadioButton();
            this.radioSim = new System.Windows.Forms.RadioButton();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.textboxTipo = new System.Windows.Forms.TextBox();
            this.textboxCor = new System.Windows.Forms.TextBox();
            this.textboxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textboxMarca = new System.Windows.Forms.TextBox();
            this.textboxQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(185, 3);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(216, 31);
            this.buttonAction.TabIndex = 2;
            this.buttonAction.Text = "Cadastrar";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarProdutosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarProdutosToolStripMenuItem
            // 
            this.listarProdutosToolStripMenuItem.Name = "listarProdutosToolStripMenuItem";
            this.listarProdutosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.listarProdutosToolStripMenuItem.Text = "Listar produtos";
            this.listarProdutosToolStripMenuItem.Click += new System.EventHandler(this.listarProdutosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonAction);
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 41);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelAtivo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textboxNome);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.labelTipo);
            this.panel2.Controls.Add(this.labelCor);
            this.panel2.Controls.Add(this.textboxTipo);
            this.panel2.Controls.Add(this.textboxCor);
            this.panel2.Controls.Add(this.textboxModelo);
            this.panel2.Controls.Add(this.labelModelo);
            this.panel2.Controls.Add(this.labelMarca);
            this.panel2.Controls.Add(this.textboxMarca);
            this.panel2.Controls.Add(this.textboxQuantidade);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textboxID);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.labelCadastro);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 180);
            this.panel2.TabIndex = 7;
            // 
            // labelAtivo
            // 
            this.labelAtivo.AutoSize = true;
            this.labelAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtivo.Location = new System.Drawing.Point(220, 122);
            this.labelAtivo.Name = "labelAtivo";
            this.labelAtivo.Size = new System.Drawing.Size(47, 13);
            this.labelAtivo.TabIndex = 9;
            this.labelAtivo.Text = "Ativo ?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioNao);
            this.panel3.Controls.Add(this.radioSim);
            this.panel3.Location = new System.Drawing.Point(217, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 35);
            this.panel3.TabIndex = 8;
            this.panel3.Tag = "Ativo ?";
            // 
            // radioNao
            // 
            this.radioNao.AutoSize = true;
            this.radioNao.Location = new System.Drawing.Point(51, 10);
            this.radioNao.Name = "radioNao";
            this.radioNao.Size = new System.Drawing.Size(45, 17);
            this.radioNao.TabIndex = 1;
            this.radioNao.TabStop = true;
            this.radioNao.Text = "Não";
            this.radioNao.UseVisualStyleBackColor = true;
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.Location = new System.Drawing.Point(3, 8);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(42, 17);
            this.radioSim.TabIndex = 0;
            this.radioSim.TabStop = true;
            this.radioSim.Text = "Sim";
            this.radioSim.UseVisualStyleBackColor = true;
            // 
            // textboxNome
            // 
            this.textboxNome.Location = new System.Drawing.Point(408, 47);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(123, 20);
            this.textboxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(342, 47);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(60, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(370, 91);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(48, 20);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCor.Location = new System.Drawing.Point(213, 91);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(42, 20);
            this.labelCor.TabIndex = 0;
            this.labelCor.Text = "Cor:";
            // 
            // textboxTipo
            // 
            this.textboxTipo.Location = new System.Drawing.Point(419, 91);
            this.textboxTipo.Name = "textboxTipo";
            this.textboxTipo.Size = new System.Drawing.Size(103, 20);
            this.textboxTipo.TabIndex = 6;
            // 
            // textboxCor
            // 
            this.textboxCor.Location = new System.Drawing.Point(264, 91);
            this.textboxCor.Name = "textboxCor";
            this.textboxCor.Size = new System.Drawing.Size(100, 20);
            this.textboxCor.TabIndex = 5;
            // 
            // textboxModelo
            // 
            this.textboxModelo.Location = new System.Drawing.Point(94, 91);
            this.textboxModelo.Name = "textboxModelo";
            this.textboxModelo.Size = new System.Drawing.Size(114, 20);
            this.textboxModelo.TabIndex = 4;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(23, 91);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(72, 20);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(23, 135);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(63, 20);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca:";
            // 
            // textboxMarca
            // 
            this.textboxMarca.Location = new System.Drawing.Point(94, 135);
            this.textboxMarca.Name = "textboxMarca";
            this.textboxMarca.Size = new System.Drawing.Size(114, 20);
            this.textboxMarca.TabIndex = 7;
            // 
            // textboxQuantidade
            // 
            this.textboxQuantidade.Location = new System.Drawing.Point(253, 46);
            this.textboxQuantidade.Name = "textboxQuantidade";
            this.textboxQuantidade.Size = new System.Drawing.Size(83, 20);
            this.textboxQuantidade.TabIndex = 2;
            this.textboxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxQuantidade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(59, 47);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(65, 20);
            this.textboxID.TabIndex = 1;
            this.textboxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxID_KeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(23, 47);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.labelCadastro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.Black;
            this.labelCadastro.Location = new System.Drawing.Point(164, 0);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(263, 29);
            this.labelCadastro.TabIndex = 0;
            this.labelCadastro.Text = "Cadastro de produtos";
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(601, 263);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProdutos";
            this.Text = "Cadastrar produto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarProdutosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.TextBox textboxTipo;
        private System.Windows.Forms.TextBox textboxCor;
        private System.Windows.Forms.TextBox textboxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textboxMarca;
        private System.Windows.Forms.TextBox textboxQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.TextBox textboxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelAtivo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioNao;
        private System.Windows.Forms.RadioButton radioSim;
    }
}

