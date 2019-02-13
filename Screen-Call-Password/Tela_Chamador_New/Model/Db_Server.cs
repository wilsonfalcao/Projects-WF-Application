using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Tela_Chamador_New.Model
{
    public class Db_Server : End_Banco
    {
        public Db_Server()
        {
            if (Verifica_Novo() != 0)
            { Status_At = true; }
            else { Status_At = false; }
        }
        public bool Start()
        {
            Linha_At = Verifica_Novo();
            if (Linha_At !=0)
            {
                Obter_Dados();
                Obter_Nome();
                Insert_Update();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Guiche_Atendimento;
        public static string Senha_Atendimento;
        public static string Nome_Atendimento;
        private Int64 Linha_At;
        public bool Status_At;

        private Int64 Verifica_Novo()
        {
            Int64 Retorna_Valor = 0;
            string Query = null;
            Query = "select *  from atendimento where data=curdate() and status is null and senha not like 'C%'";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                Conexao.Open();
                Comando.CommandText = Query;
                //Comando.ExecuteNonQuery();
                Retorna_Valor = Convert.ToInt64(Comando.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            return Retorna_Valor;
        }
        private Int64 Linha_Atual()
        {
            Int64 Retorna_String = 0;
            string Query = "select * from atendimento where data=curdate() and status is null order by linha asc;";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                Conexao.Open();
                Comando.ExecuteNonQuery();
                Retorna_String = Convert.ToInt64(Comando.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            return Retorna_String;
        }
        private void Obter_Dados()
        {
            string Query = "select senha from atendimento where linha='" + Linha_At + "';" +
                            "select guiche from atendimento where linha='" + Linha_At + "';";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader Reader = Comando.ExecuteReader(); ;
                byte troca_result = 0;
                while (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        if (troca_result == 0)
                        {
                            Senha_Atendimento = Reader.GetString(0).ToString();
                            troca_result++;
                        }
                        else if (troca_result == 1)
                        {
                            Guiche_Atendimento = String.Format("{0:00}",Convert.ToInt16(Reader.GetString(0).ToString()));
                            troca_result++;
                        }
                    }
                    Reader.NextResult();
                }

            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void Obter_Nome()
        {
            string Query = null;
            if (Senha_Atendimento.Substring(0, 1) == "A")
            {
                Query = "select nome from cadastramento_normal where senha='" + Senha_Atendimento + "';"; ;
            }
            else if (Senha_Atendimento.Substring(0, 1) == "B")
            {
                Query = "select nome from cadastramento_especial where senha='" + Senha_Atendimento + "';";
            }
            else if (Senha_Atendimento.Substring(0, 1) == "C")
            {
                Query = "select nome from cadastramento_normal_s where senha='" + Senha_Atendimento + "';";
            }
            else if (Senha_Atendimento.Substring(0, 1) == "a")
            {
                Nome_Atendimento = "Repetindo senhas já chamadas...";
            }
            else if (Senha_Atendimento.Substring(0, 1) == "D")
            {
                Query = "select nome from cadastramento_documento where senha='" + Senha_Atendimento + "';";
            }
            else if (Senha_Atendimento.Substring(0, 1) == "E")
            {
                Query = "select nome from cadastramento_prioridade where senha='" + Senha_Atendimento + "';";
            }
            else if (Senha_Atendimento.Substring(0, 1) == "T")
            {
                Query = "select nome from cadastramento_idoso where senha='" + Senha_Atendimento + "';";
            }
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                if (Senha_Atendimento.Substring(0, 1) != "a")
                {
                    Conexao.Open();
                    MySqlDataReader Reader = Comando.ExecuteReader(); ;
                    while (Reader.Read())
                    {
                        Nome_Atendimento = Reader.GetString(0).ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
        public string Obter_Tempo()
        {
            string Temp_string = null;
            string Query = "select curtime(); ";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader Reader = Comando.ExecuteReader(); ;
                while (Reader.Read())
                {
                    Temp_string = Reader.GetString(0).ToString();
                }
            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            return Temp_string;
        }
        private void Insert_Update()
        {
            string Query = "UPDATE atendimento set status='1' where linha=" + Linha_At + ";";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                Conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Form1 MSG_Erro_ = new Form1();
                MSG_Erro_.exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
