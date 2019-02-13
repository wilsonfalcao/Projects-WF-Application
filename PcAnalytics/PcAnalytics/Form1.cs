using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcAnalytics
{
    public partial class Form1 : Form
    {
        private byte validar = 0;
        private bool V_Cadastramento = true;
        public static Label Status_Label;
        public Form1()
        {
            InitializeComponent();
            Status_Label.Text = "Inicializando Aplicação...";
        }
        private void Principal()
        {
            Consulting consultar = new Consulting();
            V_Cadastramento = Convert.ToBoolean(consultar.AT);
            if (V_Cadastramento == false & validar != 1 || DateTime.Now.Day % 30 == 0)
            {
               Status_Label.Text ="Atualizando dados do Usuário...";
                Registrar Registrar_Dados = new Registrar();
                validar = 1;
            }
            //Cadastrando Maquina Automaticamente
            else if (V_Cadastramento == true)
            {
               Status_Label.Text ="Atualizando dados do Computador...";
                Registrado Atualizar_Dados = new Registrado();
                validar = 1;
            }
        }
        private byte valid = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (valid == 0)
            {
                Principal();
                valid = 1;
            }
        }
    }
}
