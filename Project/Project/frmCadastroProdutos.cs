using System;
using System.Windows.Forms;
using lib.dto;
using lib.bll;

namespace Project
{
    
    public partial class frmCadastroProdutos : Form
    {
        dto_produtos produto = new dto_produtos();
        bll_produto bll_prod = new bll_produto();
        dto_usuarios usuario { get; set; }
        dto_produtos _produtos { get; set; }

        public frmCadastroProdutos(dto_usuarios user, dto_produtos produtos = null)
        {
            InitializeComponent();
            usuario = user;
            _produtos = produtos;
            radioSim.Checked = true;
            textboxID.ReadOnly = true;

            if (_produtos == null)
            {
                textboxID.Text = Convert.ToString(bll_prod.bll_max_cod(user) + 1);
            }
            else
            {
                textboxMarca.Text = _produtos.marca;
                textboxModelo.Text = _produtos.modelo;
                textboxQuantidade.Text = _produtos.quantidade.ToString();
                textboxTipo.Text = _produtos.tipo;
                textboxCor.Text = _produtos.cor;
                textboxID.Text = _produtos.id.ToString();
                textboxNome.Text = _produtos.nome;
                setAtivo(_produtos);
            }
            
        }

        private char verificarAtivo()
        {
            if(radioSim.Checked)
            {
                return 'S';
            }
            else if (radioNao.Checked)
            {
                return 'N';
            }
            return 'A';
        }

        private void setAtivo(dto_produtos prod)
        {
            if(prod.ativo == 'S')
            {
                radioSim.Checked = true;
            }
            else if (prod.ativo == 'N')
            {
                radioNao.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_produtos == null)
            {
                produto.id = Convert.ToInt32(textboxID.Text);
                produto.nome = textboxNome.Text;
                if (verificarAtivo() == 'A')
                {
                    MessageBox.Show("Selecione se o produto está ativo ou não!!!");
                    return;
                }

                produto.ativo = verificarAtivo();
                produto.marca = textboxMarca.Text;
                produto.modelo = textboxModelo.Text;
                produto.quantidade = Convert.ToInt32(textboxQuantidade.Text);
                produto.tipo = textboxTipo.Text;
                produto.cor = textboxCor.Text;

                try
                {
                    if (bll_prod.bll_cad_produto(produto, usuario))
                    {
                        MessageBox.Show("Produto Cadastrado com sucesso!!!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. Não foi possível cadastrar o produto, Mensagem do erro: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    _produtos.id = Convert.ToInt32(textboxID.Text);
                    _produtos.nome = textboxNome.Text;
                    if (verificarAtivo() == 'A')
                    {
                        MessageBox.Show("Selecione se o produto está ativo ou não!!!");
                        return;
                    }

                    _produtos.ativo = verificarAtivo();
                    _produtos.marca = textboxMarca.Text;
                    _produtos.modelo = textboxModelo.Text;
                    _produtos.quantidade = Convert.ToInt32(textboxQuantidade.Text);
                    _produtos.tipo = textboxTipo.Text;
                    _produtos.cor = textboxCor.Text;

                    bll_prod.bll_upd_prod(_produtos, usuario);
                    MessageBox.Show("Produto Editado com sucesso!!! ");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. Não foi possível cadastrar o produto, Mensagem do erro: " + ex.Message);
                }
            }
           
        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista = new frmListagem(usuario);
            lista.ShowDialog();
        }

        private void textboxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void textboxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
