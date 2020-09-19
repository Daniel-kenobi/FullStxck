using lib.dal;
using lib.dto;
using System;

namespace lib.bll
{
    class bll_usuarios
    {
       private dal_usuarios prod = new dal_usuarios();

       private bool bll_val_user(dto_usuarios user)
       {
            if (user == null)
                return false;

            if (user.login == string.Empty || user.senha == string.Empty)
                return false;

            if (user.login == string.Empty && user.senha == string.Empty)
                return false;

            return true;
       }

       public bool bll_inc_usuarios(dto_usuarios user, dal_conexao acn = null)
       {
            try
            {
                if (!bll_val_user(user))
                    return false;

                if (prod.dal_inc_usuarios(user))
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
       }

        public bool bll_upd_usuarios(dto_usuarios user, dal_conexao acn = null)
        {
            if (!bll_val_user(user))
                return false;

            if (prod.dal_update_usuarios(user))
                return true;
            else
                return false;
        }

        public bool bll_ver_users(dto_usuarios user, dal_conexao acn = null)
        {
            return prod.dal_confirm_user(user, acn);
        }
    }
}
