using System.IO;

namespace PcAnalytics
{
    class Gerador_Txt
    {
        private string Path = @"C:\Analitics\Dados.html";
        public void G_User_Tomb(Controler_Cadastrar Dado)
        { 
            string Texto_Formato ="<html><title>Banco TXT</title><body background ='red'><table border='1'><tr><td colspan = '7'><center>Cadastro de Custódia</center></td>"+
                                       "</tr><tr><td>id_user</td><td>nome_cliente</td><td>lotacao</td><td>ramal</td><td>coordenador</td><td>email</td><td>id_tomb</td></tr>";
            string formatando_texto = null;
            formatando_texto += "<tr><td>" + "\n" + Controler_Cadastrar.ID_user + "\n" + "</td><td>" + "\n" + Dado.Nom_cliente + "\n" + "</td><td>" + "\n" + Dado.Lotacao + "\n" + "</td><td>" + "\n" + Dado.Ramal + "\n" +
                                          "</td><td>" + "\n" + Dado.Coordenador + "\n" + "</td><td>" + "\n" + Dado.Email + "\n" + "</td><td>" + "\n" + Controler_Cadastrar.ID_tomb + "\n" + "</td></tr></table></body></html>";
            Registrar.Status_Label = "Armazenando TXT Localmente¹...";
            Texto_Formato += formatando_texto;
            if (!System.IO.File.Exists(Path))
            { System.IO.File.Create(Path).Close(); }
            else { System.IO.File.Delete(Path); }
            System.IO.TextWriter arquivo = System.IO.File.AppendText(Path);
            arquivo.WriteLine(Texto_Formato);
            arquivo.Close();
        }
        public void Auto_Soft_Regist(Controler_Autodados Dado)
        {
            string Texto_Formato = "<table border='1'><tr><td colspan = '8'><center>Dados_Software</center></td>"+
                "</tr><tr><td>id_tomb</td><td>nome_maq</td><td>ender_ip</td><td>nome_user</td>"+
                "<td>td_user</td><td>sistema</td><td>tip_sistem</td><td>local_gru</td></tr>";
            string formatando_texto = null;
            formatando_texto += "<tr><td>" + Controler_Autodados.ID_maquina + "</td><td>" + Dado.Nome_maq() + "</td><td>" + Dado.Ender_ip + "</td><td>" + Dado.Nome_user + "</td>" +
                              "<td>" + Dado.Td_user + "</td><td>" + Dado.Sistema.Substring(18, 11) + "</td><td>" + Dado.Tip_sistema + "</td><td>" + Dado.Local_gru + "</td></tr>";
            Registrar.Status_Label = "Armazenando TXT Localmente³...";
            Texto_Formato += formatando_texto;
            if (!System.IO.File.Exists(Path))
            { System.IO.File.Create(Path).Close(); }
            System.IO.TextWriter arquivo = System.IO.File.AppendText(Path);
            arquivo.WriteLine(Texto_Formato);
            arquivo.Close();
        }
    }
}
