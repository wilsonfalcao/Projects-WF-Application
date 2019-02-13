using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace PcAnalytics
{
    //consultar dados com banco tombxserial
    public class Consulting
    {
        public bool AT = true;
        public static string serial_return;

        public Consulting()
        {
            Form1.Status_Label.Text = "Coletando Dados Primários...";
            serial();
            Atualizar();
        }
        private void Atualizar()
        {
            Model_Banco_Registrar Procurar_Atualizacao = new Model_Banco_Registrar();
            AT = Procurar_Atualizacao.Consulting_AT();
            //Controler_Cadastrar.ID_tomb = Procurar_Atualizacao.Tomb(serial);
        }
        private void serial()
        {
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\CIMV2");

            //create object query
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_SystemEnclosure");

            //create object searcher
            ManagementObjectSearcher searcher =
                                    new ManagementObjectSearcher(scope, query);

            //get collection of WMI objects
            ManagementObjectCollection queryCollection = searcher.Get();
            //enumerate the collection.
            foreach (ManagementObject m in queryCollection)
            {
                serial_return = m["SerialNumber"].ToString();
            }
        }
    }
}
