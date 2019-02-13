using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.Win32;

namespace PcAnalytics
{
    public class Informacao_Add
    {
        public static string ip_Subrede()
        {
            string String_Return = null;
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            byte valid = 0;
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork" & valid == 0)
                {
                    String_Return = ip.ToString();
                    valid = 1;
                }
            }
            return String_Return;
        }
        public static string td_User()
        {
            string String_Return = null;
            DirectoryInfo dir = new DirectoryInfo("C:\\Users");
            DirectoryInfo[] diretorios = dir.GetDirectories();
            foreach (DirectoryInfo diretorio in diretorios)
            String_Return += diretorio.Name+";";
            return String_Return;
        }
        public static string obter_Team_View()
        {
            string Return_String = null;
            string[] TeamView = new string[3];
            TeamView[1] = "ClientID";
            TeamView[2] = "Version";
            try
            {
                string regPath = Environment.Is64BitOperatingSystem ? @"SOFTWARE\Wow6432Node\TeamViewer" : @"SOFTWARE\TeamViewer";
                RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath);
                if (key == null)
                {
                    Return_String = "Chave Erro";
                }
                else
                {
                    int cont = 1;
                    while (cont <= 2)
                    {
                        object clientId = key.GetValue(TeamView[cont]);
                        if (clientId != null)
                        {
                            Return_String += clientId.ToString();
                        }
                        cont++;
                    }
                    return Return_String;
                }
            }
            catch (Exception e)
            {
                Tela_Erro.Erro_Mesagem = e.Message;
                Tela_Erro tela1 = new Tela_Erro();
                tela1.Show();
            }
            return Return_String;
        }
    }
}
