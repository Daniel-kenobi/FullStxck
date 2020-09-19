using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using lib.dto;

namespace lib.dal
{
    class dal_produtos
    {
        public void dal_inc_produto(dto_produtos produto, dto_usuarios user, dal_conexao conect = null)
        {
            try
            {
                conect = null;

                if (conect == null)
                    conect = new dal_conexao();

                conect.query = "INSERT INTO produtos VALUES (@id, @quantidade, @nome, @marca, @ativo, @modelo, @cor, @tipo, @usuario);";

                conect.CreateCommand();

                char ativo = Convert.ToChar(produto.ativo);
                Int32 qtd = Convert.ToInt32(produto.quantidade);
                Int32 Id = Convert.ToInt32(produto.id);

                conect.AddParameters("@id", Convert.ToString(Id));
                conect.AddParameters("@quantidade", Convert.ToString(qtd));
                conect.AddParameters("@nome", produto.nome);
                conect.AddParameters("@marca", produto.marca);
                conect.AddParameters("@ativo", Convert.ToString(ativo));
                conect.AddParameters("@modelo", produto.modelo);
                conect.AddParameters("@cor", produto.cor);
                conect.AddParameters("@tipo", produto.tipo);
                conect.AddParameters("@usuario", user.login);


                conect.ExecSql();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conect.CloseConnection();
            }
        }

        public int dal_getmaxcod(dto_usuarios user, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "SELECT MAX(id) FROM produtos WHERE dono = @dono;";

                acn.CreateCommand();

                acn.AddParameters("@dono", user.login);

                acn.ExecuteReader();

                return acn.Getint();
            }
            finally
            {
                acn.CloseConnection();
            }
        }

        //Update statement
        public void dal_upd_prod(dto_produtos produto, dto_usuarios dono, dal_conexao conect = null)
        {
            try
            {
                if (produto == null)
                    throw new Exception("Erro");

                if (dono == null)
                    throw new Exception("Erro");

                if (conect == null)
                    conect = new dal_conexao();

                conect.query = "UPDATE produtos.produtos SET quantidade = @quantidade, nome = @nome, marca = @marca, ativo = @ativo," +
                    " modelo = @modelo, cor = @cor, tipo = @tipo" +
                   " WHERE id = @id AND dono = @dono";

               /* conect.query = "UPDATE produtos.produtos SET quantidade = " + produto.quantidade.ToString() +
                    ", nome ='" + produto.nome + "', marca = '" + produto.marca + "', ativo = 'S'," + "modelo ='" + produto.modelo + "'," +
                    "cor = '" + produto.cor + "', tipo = '" + produto.tipo + "' WHERE id = " + produto.id + " AND dono = '" + dono.login + "';";*/

                conect.CreateCommand();


                conect.AddParameters("@quantidade", produto.quantidade.ToString());
                conect.AddParameters("@nome", produto.nome);
                conect.AddParameters("@marca", produto.marca);
                conect.AddParameters("@ativo", Convert.ToChar(produto.ativo).ToString());
                conect.AddParameters("@modelo", produto.modelo);
                conect.AddParameters("@cor", produto.cor);
                conect.AddParameters("@tipo", produto.tipo);
                conect.AddParameters("@dono", dono.login.ToUpper());
                conect.AddParameters("@id", Convert.ToInt32(produto.id).ToString());


                conect.ExecSql();

                conect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void dal_del_produtos(dto_produtos produto, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "DELETE FROM produtos WHERE id = @id AND id > 1;";

                acn.CreateCommand();

                acn.AddParameters("@id", Convert.ToString(produto.id));

                acn.ExecSql();
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

        public List<dto_produtos> dal_Select(dto_usuarios user, bool PalavraInteira = false, dto_produtos produto = null, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "SELECT id, quantidade, nome, marca, ativo, modelo, cor, tipo FROM produtos WHERE 1=1 AND dono = @dono";

                if (produto != null)
                {
                    if (PalavraInteira)
                    {
                        if (produto.ativo == 'S')
                        {
                            acn.query += " AND ativo = 'S'";
                            acn.CreateCommand();
                        }
                        if (produto.nome != string.Empty)
                        {
                            acn.query += " AND nome = @nome";
                            acn.CreateCommand();
                            acn.AddParameters("@nome", produto.nome);
                        }
                        if (produto.id > 0)
                        {
                            acn.query += " AND id = @id";
                            acn.CreateCommand();
                            acn.AddParameters("@id", Convert.ToString(produto.id));
                        }
                        acn.AddParameters("@dono", user.login);
                    }
                    else
                    {
                        if (produto.ativo == 'S')
                        {
                            acn.query += " AND ativo = 'S'";
                            acn.CreateCommand();
                        }
                       
                        if (produto.nome != string.Empty)
                        {
                            acn.query += " AND nome LIKE @nome";
                            acn.CreateCommand();
                            acn.AddParameters("@nome", "%" + produto.nome + "%");
                        }

                        if (produto.id > 0)
                        {
                            acn.query += " AND id LIKE @id";
                            acn.CreateCommand();
                            acn.AddParameters("@id", "%" + produto.id + "%");
                        }
                        acn.AddParameters("@dono", user.login);
                    }
                }
                else
                {
                    acn.query += " AND ativo = 'S'";
                    acn.CreateCommand();
                    acn.AddParameters("@dono", user.login);
                }

                acn.ExecuteReader();

                return acn.GetListProdutos();
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

        public dto_produtos dal_select_single(dto_produtos produto, dto_usuarios dono, dal_conexao acn = null)
        {
            try
            {
                if (acn == null)
                    acn = new dal_conexao();

                acn.query = "SELECT id, quantidade, nome, marca, ativo, modelo, cor, tipo FROM produtos WHERE dono = @dono AND id = @id;";

                acn.CreateCommand();

                acn.AddParameters("@dono", dono.login);
                acn.AddParameters("@id", Convert.ToString(produto.id));

                acn.ExecuteReader();

                return acn.GetSingleProduct();
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
