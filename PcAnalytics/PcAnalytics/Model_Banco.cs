using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace PcAnalytics
{
    
    class Model_Banco_Registrar
    {
        public Model_Banco_Registrar() { Form1.Status_Label.Text = "Comunicação com a Nuvem¹..."; }
        public void Registrar_Pessoais(Controler_Cadastrar Dados_Controle)
        {
            string Query = "INSERT INTO dados_pessoais (id_usuario,nome_cliente,lotacao,ramal,coordenador,email,data)" +
            "VALUES (?,?,?,?,?,?,curdate());";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@id_usuario", Convert.ToInt64(Controler_Cadastrar.ID_user));
                command.Parameters.AddWithValue("@nome_cliente", Dados_Controle.Nom_cliente.ToUpper());
                command.Parameters.AddWithValue("@lotacao", Dados_Controle.Lotacao.ToUpper());
                command.Parameters.AddWithValue("@ramal", Dados_Controle.Ramal.ToUpper());
                command.Parameters.AddWithValue("@coordenador", Dados_Controle.Coordenador.ToUpper());
                command.Parameters.AddWithValue("@email", Dados_Controle.Email.ToUpper());
                command.ExecuteNonQuery();
            }
            catch (OdbcException Erro)
            {
                Form1.Status_Label.Text = "Erro Tabela Dados Pessoais...";
                Tratar_Erro_Banco Erro_Banco = new Tratar_Erro_Banco(Erro.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public void Registrar_Maquina(Controler_Cadastrar Reg_Maq)
        {
            string Query = "INSERT INTO reg_maquinas (serial,marca,modelo,tip_maq,data)"+
                            "VALUES(?,?,?,?,curdate());";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.Parameters.AddWithValue("@marca", Reg_Maq.Marca);
                command.Parameters.AddWithValue("@modelo", Reg_Maq.Modelo);
                command.Parameters.AddWithValue("@tip_maq", Reg_Maq.Tip_maq);
                command.ExecuteNonQuery();
            }
            catch (OdbcException Erro)
            {
                Form1.Status_Label.Text = "Erro Tabela Reg Maquina";
                Tratar_Erro_Banco Erro_Banco = new Tratar_Erro_Banco(Erro.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public void Atualizacao_Cadastral(Controler_Cadastrar Dados_Controle)
        {
            string Query = "INSERT INTO atualizados (id_user,id_tomb,data)" +
            "VALUES (?,?,curdate());"; 
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@id_usuario", Convert.ToInt64(Controler_Cadastrar.ID_user));
                command.Parameters.AddWithValue("@id_tomb", Controler_Cadastrar.ID_tomb);
                command.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Form1.Status_Label.Text = "Erro Tabela Atualizados";
                Tratar_Erro_Banco Erro = new Tratar_Erro_Banco(ex.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public bool Consulting_AT()
        {
            string return_string = "true";
            string Query = "select if(cadastrar, 'true', 'false') from ca_lugar_maq where serial = ?";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.ExecuteNonQuery();
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return_string = reader.GetString(0);
                }
            }
            catch(OdbcException ex)
            {
                Form1.Status_Label.Text = "Erro Tabela Cadastro Lugar Maquina";
                Tratar_Erro_Banco Erro = new Tratar_Erro_Banco(ex.Message);
            }
            return Convert.ToBoolean(return_string);
        }
        public void Consulting_Tomb() 
        {
            string Query = "select tomb from ca_lugar_maq where serial= ?";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.ExecuteNonQuery();
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Controler_Cadastrar.ID_tomb = reader.GetString(0);
                }
            }
            catch(OdbcException ex)
            {
                Form1.Status_Label.Text = "Erro Tabela Cadastro Lugar Maquina²";
                Tratar_Erro_Banco Erro = new Tratar_Erro_Banco(ex.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public void Atualizacao()
        {
            string Query = "update ca_lugar_maq set cadastrar=1 where serial=?;";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Form1.Status_Label.Text = "Erro Tabela Cadastro Lugar Maquina³ ";
                Tratar_Erro_Banco Erro = new Tratar_Erro_Banco(ex.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
    }
    class Model_Banco_Registrado
    {
        public Model_Banco_Registrado() { Form1.Status_Label.Text = "Comunicação com a Nuvem²..."; }
        public void Auto_Hardware(Controler_Autodados Auto_har)
        {
            string Query = "INSERT INTO dados_hardware (serial,pro_marca,pro_model,memo_cap,hd_cap,date)" +
            "VALUES (?,?,?,?,?,curdate());";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.Parameters.AddWithValue("@pro_marca", Auto_har.Pro_marca);
                command.Parameters.AddWithValue("@pro_model", Auto_har.Pro_model);
                command.Parameters.AddWithValue("@memo_cap", Convert.ToInt64(Auto_har.Memo_cap) / 1000000000);
                command.Parameters.AddWithValue("@hd_cap", Convert.ToInt64(Auto_har.Hd_cap) / 1000000000);
                command.ExecuteNonQuery();
            }
            catch (OdbcException Erro)
            {
                Form1.Status_Label.Text = "Erro Tabela Auto Hardware...";
                Tratar_Erro_Banco Erro_Banco = new Tratar_Erro_Banco(Erro.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public void Auto_Software(Controler_Autodados Auto_soft)
        {
            string Query = "INSERT INTO dados_software (serial,nome_maq,ender_ip,nome_user,td_user,sistema,est_os,serial_os,tip_system," +
                            "local_gru,id_teamview,vs_teamview,data)" + " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,curdate());";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial",Consulting.serial_return);
                command.Parameters.AddWithValue("@nome_maq", Auto_soft.Nome_maq().ToString());
                command.Parameters.AddWithValue("@ender_ip", Auto_soft.Ender_ip.ToString());
                command.Parameters.AddWithValue("@nome_user", Auto_soft.Nome_user.ToString());
                command.Parameters.AddWithValue("@td_user", Auto_soft.Td_user.ToString());
                command.Parameters.AddWithValue("@sistema", Auto_soft.Sistema);
                command.Parameters.AddWithValue("@est_os", Auto_soft.Est_os);
                command.Parameters.AddWithValue("@serial_os", Auto_soft.Serialsistema);
                command.Parameters.AddWithValue("@tip_system", Auto_soft.Tip_sistema.ToString());
                command.Parameters.AddWithValue("@local_gru", Auto_soft.Local_gru.ToString());
                command.Parameters.AddWithValue("@id_teamview", Auto_soft.Id_teamview.Substring(9,9));
                command.Parameters.AddWithValue("@vs_team",  Auto_soft.Id_teamview.Substring(0,9));
                command.ExecuteNonQuery();
            }
            catch (OdbcException Erro)
            {
                Form1.Status_Label.Text = "Erro Tabela Auto Software...";
                Tratar_Erro_Banco Erro_Banco = new Tratar_Erro_Banco(Erro.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
        public void Auto_Soft_diags(Controler_Autodados Auto_Diags)
        {
            string Query = "INSERT INTO diagns_soft (serial,hd_liv,tip_rede,adp_Local,est_rede_all,est_boot,est_font,est_ener,ther_stat,temp_ini,data)"+
                           "VALUES (?,?,?,?,?,?,?,?,?,?,curdate());";
            OdbcConnection Data_Conection = new OdbcConnection(Corpo_Banco.Conexao_Banco);
            OdbcCommand command = new OdbcCommand(Query, Data_Conection);
            try
            {
                Data_Conection.Open();
                command.CommandText = Query;
                command.Parameters.AddWithValue("@serial", Consulting.serial_return);
                command.Parameters.AddWithValue("@hd_liv", (Convert.ToInt64(Auto_Diags.Hd_liv) / 1073741824));
                command.Parameters.AddWithValue("@tip_rede", Auto_Diags.Tip_rede.ToString());
                command.Parameters.AddWithValue("@adp_Local", Auto_Diags.Adp_Local);
                command.Parameters.AddWithValue("@est_rede_all",Auto_Diags.Est_rede);
                command.Parameters.AddWithValue("@est_boot",Auto_Diags.Est_boot);
                command.Parameters.AddWithValue("@est_font",Auto_Diags.Est_font);
                command.Parameters.AddWithValue("@est_ener",Auto_Diags.Est_ener);
                command.Parameters.AddWithValue("@ther_stat",Auto_Diags.Ther_stat);
                command.Parameters.AddWithValue("@temp_init", Auto_Diags.Temp_ini.Substring(0,7));
                command.ExecuteNonQuery();
            }
            catch (OdbcException Erro)
            {
                Form1.Status_Label.Text = "Erro Tabela Auto SoftDiags...";
                Tratar_Erro_Banco Erro_Banco = new Tratar_Erro_Banco(Erro.Message);
            }
            finally
            {
                Data_Conection.Close();
            }
        }
    }
    class Tratar_Erro_Banco
    {
        public Tratar_Erro_Banco(string erro)
        {

            Tela_Erro.Erro_Mesagem = erro;
            Tela_Erro Tela2 = new Tela_Erro();
            Tela2.Show();
        }
    }
}
