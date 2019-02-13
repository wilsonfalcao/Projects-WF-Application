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
    public partial class Tela_Cadastro : Form
    {
        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controler_Cadastrar Setar_Dados = new Controler_Cadastrar();
            Setar_Dados.Nom_cliente = textBox_Nome.Text; Setar_Dados.Lotacao = textBox_Dp.Text;
            Setar_Dados.Coordenador = textBox_Coor.Text; Setar_Dados.Email = textBox_Email.Text;
            Setar_Dados.Ramal = textBox_Tel.Text;Setar_Dados.Inserir_Dados();
            this.Dispose();
        }
    }
}
