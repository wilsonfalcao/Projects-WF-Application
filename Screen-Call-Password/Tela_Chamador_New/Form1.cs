using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Chamador_New.Model;
using Tela_Chamador_New.Body;

namespace Tela_Chamador_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela2 tela = new Tela2();
            tela.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void exception(string erro)
        {
            MessageBox.Show(erro);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //Instanciando Classe Serve_Banco
            Tela2 Chamar_Senha_Tela = new Tela2();
            Db_Server Server = new Db_Server();
            if (Server.Status_At)
            {
                Server.Start();
                Chamar_Senha_Tela.Show();
                if (Db_Server.Senha_Atendimento != senha1u.Text)
                {
                    senha1u.Text = Db_Server.Senha_Atendimento;
                    g1u.Text = Db_Server.Guiche_Atendimento;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tela2 tela = new Tela2();
            tela.Show();
        }
    }
}
