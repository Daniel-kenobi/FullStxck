using System;
using System.Windows.Forms;
using lib.bll;
using lib.dto;
using lib.util;

namespace Project
{
    public partial class frmLogin : Form
    {
        bll_usuarios bll_user = new bll_usuarios();
        dto_usuarios dto_user = new dto_usuarios();
        util_func func = new util_func();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textboxUsuario.Text.Length > 0 && maskedSenha.Text.Length > 0)
            {
                dto_user.login = textboxUsuario.Text.Trim().ToUpper();
                dto_user.senha = func.Encryptor(maskedSenha.Text.Trim());

                if(bll_user.bll_ver_users(dto_user))
                {
                    MessageBox.Show("Seja bem-vindo(a) " + dto_user.login);
                    this.Hide();
                    Form produtos = new frmListagem(dto_user);
                    produtos.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!!!");
                }
            }
            else
            {
                if (textboxUsuario.Text.Length == 0)
                    MessageBox.Show("Campo de usuário não preenchido!!!");
                else if (maskedSenha.Text.Length == 0)
                    MessageBox.Show("Campo de senha não preenchido!!!");

                return;
            }
        }

        private void labelCadatro_Click(object sender, EventArgs e)
        {
            Form cad = new frmCadastroUsuario();
            cad.ShowDialog();
        }
    }
}
