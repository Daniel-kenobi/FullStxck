using System;
using lib.dto;
using System.Data;
using MySql.Data.MySqlClient;

namespace lib.dal
{
    class dal_usuarios
    {
        private int get_cod(dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "SELECT MAX(id) FROM login;";

                acn.CreateCommand();
                acn.ExecuteReader();

                return acn.Getint();
            }
            finally
            {
                acn.CloseConnection();
            }
        }

        private void Ins_default(dto_usuarios user, dal_conexao acn = null)
        {
            if (acn == null)
                acn = new dal_conexao();

            acn.query = "insert into produtos VALUES (1, 1, 'default', 'default', 'N', 'default', 'default', 'default', @dono);";

            acn.CreateCommand();
            acn.AddParameters("@dono", user.login);

            acn.ExecSql();
        }

        public bool dal_inc_usuarios(dto_usuarios user, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "INSERT INTO login VALUES (@id, @nick, @senha);";
               
                acn.CreateCommand();

                acn.AddParameters("@id", Convert.ToString(user.id));
                acn.AddParameters("@nick", user.login.ToUpper());
                acn.AddParameters("@senha", user.senha);

                acn.ExecSql();

                Ins_default(user, acn);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acn.CloseConnection();
            }
        }

        public bool dal_update_usuarios(dto_usuarios user, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "UPDATE login SET nickname = @nick, password = @senha WHERE nickname = @nick";

                acn.CreateCommand();

                acn.AddParameters("@nick", user.login);
                acn.AddParameters("@nick", user.senha);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex.InnerException;
            }
        }

        public bool dal_confirm_user(dto_usuarios user, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "select count(*) as cnt from login where nickname = @nick and password = @password";

                acn.CreateCommand();

                acn.AddParameters("@nick", user.login);
                acn.AddParameters("@password", user.senha);

                string returnValue = Convert.ToString(acn.get_cur_cmd().ExecuteScalar());
                returnValue = returnValue.Trim();

                if (acn.get_cur_cmd().ExecuteScalar().ToString() == "1")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acn.CloseConnection();
            }
        }
    }
}
