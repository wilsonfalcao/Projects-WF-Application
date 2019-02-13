using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_senha
{
    public class Endereco_Banco
    {
        public Endereco_Banco()
        {
            string formatar = "DRIVER={MySQL ODBC 3.51 Driver};" +
            "Server=localhost;" +
            "Database=bancobolsa;"+
            "UID=root;"+
            "PWD=gpoz33;";
            myconection = formatar;
        }
        public Endereco_Banco(string ip, string data, string username, string pwd)
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
