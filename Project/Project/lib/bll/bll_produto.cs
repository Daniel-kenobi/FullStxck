using System.Data;
using lib.dal;
using System.Collections.Generic;
using System.Reflection;
using System;
using lib.dto;

namespace lib.bll
{
    class bll_produto
    {
        dal_produtos produto = new dal_produtos();

        private static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private bool bll_val_produto(dto_produtos produto)
        {
            if (produto == null)
                return false;

            if (produto.id == null)
                return false;

            if (produto.nome == string.Empty)
                return false;

            return true;
        }

        public int bll_max_cod(dto_usuarios user)
        {
            return produto.dal_getmaxcod(user);
        }

        public void bll_upd_prod(dto_produtos prod, dto_usuarios usuario)
        {
            if(!bll_val_produto(prod))
            {
                throw new Exception("Produto inválido!");
            }
            else
            {
                produto.dal_upd_prod(prod, usuario);
            }
        }

        public dto_produtos bll_get_Single(dto_produtos prod, dto_usuarios user, dal_conexao conect = null)
        {
            if (!bll_val_produto(prod))
            {
                throw new Exception("Produto inválido!");
            }
            else
            {
                return produto.dal_select_single(prod, user);
            }
        }

        public bool bll_cad_produto(dto_produtos prod, dto_usuarios user)
        {

            if (!bll_val_produto(prod))
                return false;
            else
                produto.dal_inc_produto(prod, user);
                return true;
        }

        public bool bll_del_produto(dto_produtos prod)
        {
            produto.dal_del_produtos(prod);
            return true;
        }

        public DataTable bll_get_Table(dto_usuarios user, dto_produtos prod = null, bool PalavraInteira = false)
        {
            return ToDataTable(produto.dal_Select(user, PalavraInteira, prod));
        }

    }
}
