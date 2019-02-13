using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcAnalytics
{
    public class Registrar
    {
        public Registrar()
        {
        Form1.Status_Label.Text = "Carregando Tela de Cadastro...";
        Tela_Cadastro Show_Tela_Cadastro = new Tela_Cadastro();
        Show_Tela_Cadastro.Show();
        }
        
    }

    public class Registrado
    {
        public Registrado()
        {
        Form1.Status_Label.Text = "Carregando Modulo Automatico...";
        Controler_Autodados Obter_Autos = new Controler_Autodados();
        Form1.Status_Label.Text = "Ações Concluídas do Modo Automático";
        }
    }
}
