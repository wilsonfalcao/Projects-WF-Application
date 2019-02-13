using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace gerador_senha
{
   public class Model_Banco: Endereco_Banco
    {
            //Validações de codigo
            private char tipo = 'a';
            //Model banco

            //Bolsa
            public void Inserir_Tabela_Normal_P(Controle_Dados Pass_Var_3n)
            {
            tipo = 'a';
            string Query = "insert into cadastramento_normal (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
            OdbcConnection Conexao = new OdbcConnection(Myconection);
            OdbcCommand comando = new OdbcCommand(Query, Conexao);
            try
            {
                int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                Conexao.Open();
                string Senha = string.Format("A" + "{0:000}", contar);
                comando.CommandText = Query;
                comando.Parameters.AddWithValue("@senha", Senha);
                comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                comando.Parameters.AddWithValue("@rg", "000000");
                comando.Parameters.AddWithValue("@nis", "");
                comando.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Form1 Exception = new Form1();
                Exception.Excecao(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            }    //Inserção na tabela Normal
            public void Inserir_Tabela_Normal_S(Controle_Dados Pass_Var_3n)
            {
                tipo = 'c';
                string Query = "insert into cadastramento_normal_s (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand comando = new OdbcCommand(Query, Conexao);
                try
                {
                    int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                    Conexao.Open();
                    string Senha = string.Format("C" + "{0:000}", contar);
                    comando.CommandText = Query;
                    comando.Parameters.AddWithValue("@senha", Senha);
                    comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                    comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                    comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                    comando.Parameters.AddWithValue("@rg", "00000");
                    comando.Parameters.AddWithValue("@nis", Pass_Var_3n.Nis);
                    comando.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            public void Inserir_Tabela_Preferencial(Controle_Dados Pass_Var_3n)
            {
                tipo = 'b';
                string Query = "insert into cadastramento_especial (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand comando = new OdbcCommand(Query, Conexao);
                try
                {
                    int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                    Conexao.Open();
                    string Senha = string.Format("B" + "{0:000}", contar);
                    comando.CommandText = Query;
                    comando.Parameters.AddWithValue("@senha", Senha);
                    comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                    comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                    comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                    comando.Parameters.AddWithValue("@rg", "00000000");
                    comando.Parameters.AddWithValue("@nis", Pass_Var_3n.Nis);
                    comando.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }

            }  //Inserção na tabela preferencial

            //Expresso Recife
            public void Inserir_Tabela_Carteira_Idoso(Controle_Dados Pass_Var_3n)
            {
                tipo = 't';
                string Query = "insert into cadastramento_idoso (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand comando = new OdbcCommand(Query, Conexao);
                try
                {
                    int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                    Conexao.Open();
                    string Senha = string.Format("T" + "{0:000}", contar);
                    comando.CommandText = Query;
                    comando.Parameters.AddWithValue("@senha", Senha);
                    comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                    comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                    comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                    comando.Parameters.AddWithValue("@rg", "000000");
                    comando.Parameters.AddWithValue("@nis", "");
                    comando.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            public void Inserir_Tabela_Carteira_Documento(Controle_Dados Pass_Var_3n)
            {
                tipo = 'd';
                string Query = "insert into cadastramento_documento (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand comando = new OdbcCommand(Query, Conexao);
                try
                {
                    int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                    Conexao.Open();
                    string Senha = string.Format("D" + "{0:000}", contar);
                    comando.CommandText = Query;
                    comando.Parameters.AddWithValue("@senha", Senha);
                    comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                    comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                    comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                    comando.Parameters.AddWithValue("@rg", "000000");
                    comando.Parameters.AddWithValue("@nis", "");
                    comando.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            public void Inserir_Tabela_Carteira_Prioridade(Controle_Dados Pass_Var_3n)
            {
                tipo = 'e';
                string Query = "insert into cadastramento_prioridade (senha,data,hora,nome,bairro,rg,nis) values (?,curdate(),?,?,?,?,?)";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand comando = new OdbcCommand(Query, Conexao);
                try
                {
                    int contar = Convert.ToInt16(Select_Tabela_Normal() + 1);
                    Conexao.Open();
                    string Senha = string.Format("E" + "{0:000}", contar);
                    comando.CommandText = Query;
                    comando.Parameters.AddWithValue("@senha", Senha);
                    comando.Parameters.AddWithValue("@hora", Convert.ToDateTime(DateTime.Now.ToLongTimeString()));
                    comando.Parameters.AddWithValue("@nome", Pass_Var_3n.Nome);
                    comando.Parameters.AddWithValue("@bairro", Pass_Var_3n.Bairro);
                    comando.Parameters.AddWithValue("@rg", "000000");
                    comando.Parameters.AddWithValue("@nis", "");
                    comando.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            } 

            //Select Bolsa
            public int Select_Tabela_Normal()
            {
                int Retorna_Valor = 0;
                string Query = null;
                if(tipo == 'a')
                {
                Query = "select count(*) from cadastramento_normal where data=curdate();";
                }
                else if(tipo =='b')
                {
                    Query = "select count(*) from cadastramento_especial where data=curdate();";
                }
                else if (tipo == 'c')
                {
                    Query = "select count(*) from cadastramento_normal_s where data=curdate();";
                }
                else if (tipo == 't')
                {
                    Query = "select count(*) from cadastramento_idoso where data=curdate();";
                }
                else if (tipo == 'd')
                {
                    Query = "select count(*) from cadastramento_documento where data=curdate();";
                }
                else if (tipo == 'e')
                {
                    Query = "select count(*) from cadastramento_prioridade where data=curdate();";
                }
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand Comando = new OdbcCommand(Query, Conexao);
                try
                {
                    Conexao.Open();
                    Comando.CommandText = Query;
                    Comando.ExecuteNonQuery();
                    Retorna_Valor = Convert.ToInt16(Comando.ExecuteScalar());
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
                return Retorna_Valor;
            }
            public int Select_Tabela_Normal_S()
            {
                int Retorna_Valor = 0;
                string Query = null;
                Query = "select count(*) from cadastramento_normal_s where data=curdate();";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand Comando = new OdbcCommand(Query, Conexao);
                try
                {
                    Conexao.Open();
                    Comando.CommandText = Query;
                    Comando.ExecuteNonQuery();
                    Retorna_Valor = Convert.ToInt16(Comando.ExecuteScalar());
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
                return Retorna_Valor;
            }
            public int Select_Tabela_Aten()
            {
                int Retorna_Intiger = 0;
                string Query = "select count(*) from atendimento where data=curdate();";
                OdbcConnection Conexao = new OdbcConnection(Myconection);
                OdbcCommand Comando = new OdbcCommand(Query, Conexao);
                try
                {
                    Conexao.Open();
                    Comando.CommandText = Query;
                    Comando.ExecuteNonQuery();
                    Retorna_Intiger = Convert.ToInt16(Comando.ExecuteScalar());
                }
                catch (OdbcException ex)
                {
                    Form1 Exception = new Form1();
                    Exception.Excecao(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                    
                }
                return Retorna_Intiger;
            }
     }
}
