using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Chamador_New.Model
{
    public class End_Banco
    {
        public End_Banco()
        {
            string formatar = "Server=192.168.25.15;" +"Database=bancobolsa;" +"UID=bolsac;" +"PWD=bolsacbolsa;";
            myconection = formatar;
        }
        public End_Banco(string ip, string data, string username, string pwd)
        {
            string formatar = "DRIVER={MySQL ODBC 3.51 Driver};" +
            "SERVER=" + ip + ";" +
            "DATABASE=" + data + ";" +
            "UID=" + username + ";" +
            "PASSWORD=" + pwd + ";" +
            "OPTION=3;";
            myconection = formatar;

        }
        private string myconection;
        public string Myconection
        {
            get { return myconection; }
        }
    }
}
