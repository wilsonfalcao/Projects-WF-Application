using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace PcAnalytics
{
    class WMI_Management
    {
        public string[] Dados_Setar_WMI = new string[17];
        public WMI_Management(string[] Tabela, string[] Coluna, char tipo)
        {
            Form1.Status_Label.Text = "Obtendo informações do Computador...";
            for (int cont = 1; cont < Convert.ToInt16(Tabela.Length); cont++)
            {
                ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\CIMV2");

                //create object query
                ObjectQuery query = new ObjectQuery("SELECT * FROM " + Tabela[cont]);

                //create object searcher
                ManagementObjectSearcher searcher =
                                        new ManagementObjectSearcher(scope, query);

                //get collection of WMI objects
                ManagementObjectCollection queryCollection = searcher.Get();
                //enumerate the collection.
                Int64 memoria = 0;
                foreach (ManagementObject m in queryCollection)
                {
                    // access properties of the WMI object
                    if (m[Coluna[cont]] != null)
                    {
                        switch(tipo)
                        {
                            case ('B'): if (cont == 3){ memoria += Convert.ToInt64(m[Coluna[cont]]);
                            this.Dados_Setar_WMI[cont] = memoria.ToString();}
                            else if (cont == 4){memoria += Convert.ToInt64(m[Coluna[cont]]);
                            this.Dados_Setar_WMI[cont] = memoria.ToString();}
                            else if (cont == 7) { this.Dados_Setar_WMI[cont] += m[Coluna[cont]].ToString(); }
                            else { this.Dados_Setar_WMI[cont] = m[Coluna[cont]].ToString(); }
                            break;

                            case ('A'): this.Dados_Setar_WMI[cont] = m[Coluna[cont]].ToString(); break;
                        }
                    }
                    else { if (cont != 4 & tipo != 'B') { this.Dados_Setar_WMI[cont] = "Não Atribuido."; } }
                }
                memoria = 0;
            }
        }
    }
}
