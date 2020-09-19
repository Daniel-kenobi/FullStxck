using System;
using System.Windows.Forms;
using lib.dto;
using lib.bll;
using lib.util;
using System.Text;

namespace Project
{
    public partial class frmCadastroUsuario : Form
    {
        dto_usuarios user = new dto_usuarios();
        bll_usuarios bll_user = new bll_usuarios();
        util_func func = new util_func();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textboxUser.Text.Length > 0 && textboxUser.Text.Length < 25)
            {
                if (maskedSenha.Text.Length > 0 && maskedConfirm.Text.Length > 0 && maskedSenha.Text.Length > 5)
                {
                    if (maskedConfirm.Text.CompareTo(maskedSenha.Text) == 0)
                    {
                        try
                        {
                            user.login = textboxUser.Text.Trim().ToUpper();
                            user.senha = func.Encryptor(maskedSenha.Text);

                            if (bll_user.bll_inc_usuarios(user))
                            {
                                MessageBox.Show("Usuário criado com sucesso!!!");
                                this.Close();
                            }
                            else
                            {
                                throw new Exception("erro ao incluir usuario");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("não foi possível cadastrar usuário erro: " + ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("Senha deve conter mais que 5 caracteres.");
            }
        }
    }
}
