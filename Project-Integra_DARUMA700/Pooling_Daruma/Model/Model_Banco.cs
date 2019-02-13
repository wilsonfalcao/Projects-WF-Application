using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pooling_Daruma
{
    class Model_Banco : Endereco_Banco
    {
        public Model_Banco()
        {
            body dados = new body();
            if (Consulta_Banco_Linha_Atual(dados) == true)
            {
                Chamando_Dados(dados);
            }
        }
        private void Chamando_Dados(body Banco)
        {
            string Query = null;
            byte p = 0;
            while (p < 6)
            {
                switch (Banco.validar)
                {
                    case (1): Query = "select senha, nome from cadastramento_normal where linha=" + Banco.Linha_normal + ";"; p = 6; break;
                    case (2): Query = "select senha, nome from cadastramento_especial where linha=" + Banco.Linha_especial + ";"; p = 6; break;
                    case (4): Query = "select senha, nome from cadastramento_normal_s where linha=" + Banco.Linha_normal_s + ";"; p = 6; break;
                    case (8): Query = "select senha, nome from cadastramento_documento where linha=" + Banco.Linha_documento + ";"; p = 6; break;
                    case (9): Query = "select senha, nome from cadastramento_idoso where linha=" + Banco.Linha_idoso + ";"; p = 6; break;
                    case (10): Query = "select senha, nome from cadastramento_prioridade where linha=" + Banco.Linha_prioridade + ";"; p = 6; break;

                    case (5): Query = "select senha, nome from cadastramento_normal where linha=" + Banco.Linha_normal + ";"; p = 5; Banco.validar = 4; break;
                    case (6): Query = "select senha, nome from cadastramento_especial where linha=" + Banco.Linha_especial + ";"; p = 5; Banco.validar = 4; break;
                    case (3): Query = "select senha, nome from cadastramento_normal where linha=" + Banco.Linha_normal + ";"; p = 5; Banco.validar = 2; break;
                    case (7): Query = "select senha, nome from cadastramento_especial where linha=" + Banco.Linha_especial + ";"; p = 4; Banco.validar = 5; break;
                    case (15): Query = "select senha, nome from cadastramento_documento where linha=" + Banco.Linha_documento + ";"; p = 3; Banco.validar = 7; break;
                    case (24): Query = "select senha, nome from cadastramento_idoso where linha=" + Banco.Linha_idoso + ";"; p = 2; Banco.validar = 15; break;
                    case (34): Query = "select senha, nome from cadastramento_prioridade where linha=" + Banco.Linha_prioridade + ";"; p = 1; Banco.validar = 24; break;
                }
                if (Banco.validar != 0)
                {
                    MySqlConnection Conexao = new MySqlConnection(Myconection);
                    MySqlCommand Comando = new MySqlCommand(Query, Conexao);
                    try
                    {
                        Conexao.Open();
                        MySqlDataReader Reader = Comando.ExecuteReader(); ;
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                            {
                                Daruma Imprimir = new Daruma();
                                Imprimir.Imprimir_Impressora(Reader["senha"].ToString());
                            }
                        }
                    }
                    catch (MySqlException ex) { }
                    finally { Conexao.Close(); }
                }
                else { p = 6; }
            }
        }
        private bool Consulta_Banco_Linha_Atual(body Linha_Banco)
        {
            byte _P = 0;
            bool _PP= true;
            string Query = "select max(linha) from cadastramento_normal;" +
                           "select max(linha) from cadastramento_normal_s;" +
                           "select max(linha) from cadastramento_especial;"+
                           "select max(linha) from cadastramento_documento;"+
                           "select max(linha) from cadastramento_idoso;"+
                           "select max(linha) from cadastramento_prioridade;";
            MySqlConnection Conexao = new MySqlConnection(Myconection);
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            try
            {
                int cont = 0;
                Conexao.Open();
                MySqlDataReader Reader = Comando.ExecuteReader(); ;
                while (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        if (cont == 0)
                        {
                            if (Reader.IsDBNull(0)) {
                                Linha_Banco.Linha_normal = 0; 
                                _P += 1; 
                            }
                            else if (Reader.GetInt64(0) !=Linha_Banco.Linha_normal)
                            { 
                                Linha_Banco.Linha_normal = Reader.GetInt64(0);
                            }
                            else { 
                                Linha_Banco.Linha_normal = 0;
                                _P += 1; 
                            }
                            cont++;
                        }
                        else if (cont == 1)
                        {
                            if (Reader.IsDBNull(0)) { Linha_Banco.Linha_normal_s = 0;_P += 1; }
                            else if (Reader.GetInt64(0) != Linha_Banco.Linha_normal_s)
                            { Linha_Banco.Linha_normal_s = Reader.GetInt64(0); }
                            else { Linha_Banco.Linha_normal_s = 0; _P += 1; }
                            cont++;
                        }
                        else if (cont == 2)
                        {
                            if (Reader.IsDBNull(0)) { Linha_Banco.Linha_especial = 0;_P += 1; }
                            else if (Reader.GetInt64(0) != Linha_Banco.Linha_especial)
                            { Linha_Banco.Linha_especial = Reader.GetInt64(0); }
                            else { Linha_Banco.Linha_especial = 0; _P += 1; };
                            cont++;
                        }
                        else if (cont == 3)
                        {
                            if (Reader.IsDBNull(0)) { Linha_Banco.Linha_documento = 0; _P += 1; }
                            else if (Reader.GetInt64(0) != Linha_Banco.Linha_documento)
                            { Linha_Banco.Linha_documento = Reader.GetInt64(0); }
                            else { Linha_Banco.Linha_documento = 0; _P += 1; };
                            cont++;
                        }
                        else if (cont == 4)
                        {
                            if (Reader.IsDBNull(0)) { Linha_Banco.Linha_idoso = 0; _P += 1; }
                            else if (Reader.GetInt64(0) != Linha_Banco.Linha_idoso)
                            { Linha_Banco.Linha_idoso = Reader.GetInt64(0); }
                            else { Linha_Banco.Linha_idoso = 0; _P += 1; };
                            cont++;
                        }
                        else if (cont == 5)
                        {
                            if (Reader.IsDBNull(0)) { Linha_Banco.Linha_prioridade = 0; _P += 1; }
                            else if (Reader.GetInt64(0) != Linha_Banco.Linha_prioridade)
                            { Linha_Banco.Linha_prioridade = Reader.GetInt64(0); }
                            else { Linha_Banco.Linha_prioridade = 0; _P += 1; };
                            cont = 0;
                        }
                    }
                    Reader.NextResult();
                }
                if (_P == 3) { _PP = false; }
            }
            catch (MySqlException ex) { MSG erro = new MSG(ex.Message); } 
            finally{Conexao.Close();}
            return _PP;
        }
    }
}
