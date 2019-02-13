using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados.validar = 1;
            Dados Terreo_Formulario = new Dados();
            Terreo_Formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dados.validar = 2;
            Dados Preferencial_Formulario = new Dados();
            Preferencial_Formulario.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Dados.validar = 3;
            Dados Primeiro_Andar_Formulario = new Dados();
            Primeiro_Andar_Formulario.Show();
        }
        public void Excecao(string Erro)
        {
            MessageBox.Show(Erro);
        }
    }
}
