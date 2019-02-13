using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pooling_Daruma.Model;

namespace Pooling_Daruma
{
    public class Endereco_Banco
    {
        public Endereco_Banco()
        {
            Conf_Banco_Ip Consult = new Conf_Banco_Ip();
            string server = Consult.Conf_Server();
            string formatar = "Server="+server+ ";Database=bancobolsa;" + "UID=bolsa;" + "PWD=wilsonfalcao;";
            myconection = formatar;
        }
        public Endereco_Banco(string ip, string data, string username, string pwd)
        {
            string formatar = "Server=" + ip + ";" +
            "Database=" + data + ";" +
            "UID=" + username + ";" +
            "PWD=" + pwd + ";";
            myconection = formatar;

        }
        private string myconection;
        public string Myconection
        {
            get { return myconection; }
        }
    }
}