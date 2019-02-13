using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pooling_Daruma.Model
{
    public class Conf_Banco_Ip
    {
        private string Path = @"C:\APP DR700\conf.txt";

        public string Conf_Server()
        {
            string Return_string = null;
            string[] Value_Id_User = System.IO.File.ReadAllLines(Path);
            Return_string = Value_Id_User[0];
            return Return_string;
        }
    }
}
