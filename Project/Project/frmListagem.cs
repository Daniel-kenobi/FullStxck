using System;
using System.Windows.Forms;
using lib.bll;
using lib.dto;
using System.Diagnostics;

namespace Project
{
    public partial class frmListagem : Form
    {
        private dto_usuarios usuario { get; set; }

        private bll_produto produto = new bll_produto();
        private dto_produtos _produto { get; set; }

        public frmListagem(dto_usuarios user)
        {
            InitializeComponent();
            usuario = user;
            radioNome.Checked = true;
        }

        private void isAtivo()
        {

        }

        private void clearParameter()
        {
            textboxPesquisa.Text = string.Empty;

            if (_produto != null)
            {
                if (radioNome.Checked)
                {
                    _produto.id = 0;
                }
                else
                {
                    _produto.nome = string.Empty;
                }
            }
        }

        private void AdjustGrid()
        {
            this.gridProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridProdutos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //this.gridProdutos.Columns[0].Width = 1;
            this.gridProdutos.Columns.RemoveAt(gridProdutos.Columns.Count - 1);
        }

        private void frmListagem_Load(object sender, EventArgs e)
        {
            gridProdutos.DataSource = produto.bll_get_Table(usuario, null, false);
            AdjustGrid();
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _produto = new dto_produtos();
            foreach (DataGridViewRow row in gridProdutos.SelectedRows)
            {
                _produto.id = Convert.ToInt32(row.Cells[0].Value.ToString());
                _produto = produto.bll_get_Single(_produto, usuario);
            }
        }

        private void textboxPesquisa_TextChanged(object sender, EventArgs e)
        {
            _produto = new dto_produtos();

            if (textboxPesquisa.Text.Length > 0)
            {
                if (checkboxAtivos.Checked)
                    _produto.ativo = 'N';
                else
                    _produto.ativo = 'S';

                if (radioCod.Checked)
                {
                    _produto.id = Convert.ToInt32(textboxPesquisa.Text);
                    _produto.nome = string.Empty;
                }
                else
                {
                    _produto.id = null;
                    _produto.nome = textboxPesquisa.Text;
                }

                gridProdutos.DataSource = produto.bll_get_Table(usuario, _produto, checkboxPalavraInt.Checked);
            }
            else
            {
                _produto.id = 0;
                _produto.nome = string.Empty;
                gridProdutos.DataSource = produto.bll_get_Table(usuario, null, false);
            }

            AdjustGrid();
        }

        private void radioNome_CheckedChanged(object sender, EventArgs e)
        {
            clearParameter();
        }

        private void radioCod_CheckedChanged(object sender, EventArgs e)
        {
            clearParameter();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form form = new frmCadastroProdutos(usuario);
            form.ShowDialog();

            gridProdutos.DataSource = null;
            gridProdutos.DataSource = produto.bll_get_Table(usuario);
            AdjustGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (_produto == null)
            {
                MessageBox.Show("Selecione um produto para poder excluir!!!");
                return;
            }
            else
            {
                _produto.ativo = 'N';
                produto.bll_upd_prod(_produto, usuario);
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = produto.bll_get_Table(usuario);
                AdjustGrid();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_produto == null)
            {
                MessageBox.Show("Selecione um produto para editar!");
            }
            else
            {
                Form form = new frmCadastroProdutos(usuario, _produto);
                form.ShowDialog();
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = produto.bll_get_Table(usuario, null, false);
                AdjustGrid();
            }
        }

        private void frmListagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process processToKill = Process.GetCurrentProcess();
            processToKill.Kill();
        }

        private void textboxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioCod.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/daniel-kenobi/");
            Process.Start(sInfo);
        }

        private void gridProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new frmCadastroProdutos(usuario, _produto);
            form.ShowDialog();
            gridProdutos.DataSource = produto.bll_get_Table(usuario, null, false);
            AdjustGrid();
        }
    }
}
