using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using lib.dto;

namespace lib.dal
{
    class dal_conexao
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd;
        private MySqlDataReader reader;

        //private static MySqlDataReader datareader;
        public string query { get; set; }
        //Constructor
        private bool dal_Val_String()
        {
            if (query == null || query == string.Empty)
                return false;
            else
                return true;
        }

        public dal_conexao()
        {
            Initialize();
        }

        //Initialize values
        public MySqlConnection Initialize()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["StringConnection"].ToString());
            connection.Open();
            return connection;
        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }

        }
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public MySqlCommand CreateCommand()
        {
            dal_Val_String();
            return cmd = new MySqlCommand(query, connection);
        }

        public bool ExecSql()
        {
            cmd.ExecuteNonQuery();
            return true;
        }
       
        public MySqlDataReader Reader()
        {
            if (query == null || query == string.Empty)
                return null;

            cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader;
        }

        public bool AddParameters(string parametro, string replace)
        {
            if (connection != null)
            {
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = parametro;
                param.Value = replace;
                cmd.Parameters.AddWithValue(parametro, replace);
                return true;
            }
            else
                return false;
        }
            
        public MySqlDataReader ExecReader()
        {
            /* datareader = cmd.ExecuteReader();
             if (datareader.HasRows)
             {
                 while (datareader.Read())
                 {

                 }
             }*/
            return null;
        }

        public void ExecuteReader()
        {
            reader = cmd.ExecuteReader();
        }

        public int Getint()
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader?.GetInt32(0) == null)
                        return 0;
                    else
                        return reader.GetInt32(0);
                }
                reader.Close();
            }
            else
            {
                reader.Close();
                return 0;
            }
            return 0;
        }

        public List<dto_produtos> GetListProdutos()
        {
            List<dto_produtos> produtos = new List<dto_produtos>();
            produtos.Clear();

            if (reader == null)
                return produtos;

            if (reader.HasRows)
            {
                 while (reader.Read())
                 {
                        dto_produtos f = new dto_produtos();
                        f.id = System.Convert.ToInt32(reader["id"]);
                        f.quantidade = System.Convert.ToInt32(reader["quantidade"]);
                        f.nome = (string)reader["nome"];
                        f.marca = (string)reader["marca"];
                        f.ativo = System.Convert.ToChar(reader["ativo"]);
                        f.modelo = (string)reader["modelo"];
                        f.cor = (string)reader["cor"];
                        f.tipo = (string)reader["tipo"];
                        produtos.Add(f);
                 }
                reader.Close();
                return produtos;
            }
            else
            {
                reader.Close();
                return produtos;
            }
            
        }

        public dto_produtos GetSingleProduct()
        {
            dto_produtos produtos = new dto_produtos();

            if (reader == null)
                return produtos;

            if (reader.HasRows)
            {

                if (reader.Read())
                {
                    produtos.id = System.Convert.ToInt32(reader["id"]);
                    produtos.quantidade = System.Convert.ToInt32(reader["quantidade"]);
                    produtos.nome = (string)reader["nome"];
                    produtos.marca = (string)reader["marca"];
                    produtos.ativo = System.Convert.ToChar(reader["ativo"]);
                    produtos.modelo = (string)reader["modelo"];
                    produtos.cor = (string)reader["cor"];
                    produtos.tipo = (string)reader["tipo"];
                }
                reader.Close();
                return produtos;
            }
            else
            {
                reader.Close();
                return produtos;
            }

        }

        public MySqlCommand get_cur_cmd()
        {
            return cmd;
        }
    }

}
