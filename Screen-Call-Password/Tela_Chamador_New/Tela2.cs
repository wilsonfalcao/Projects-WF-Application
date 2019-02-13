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

namespace Tela_Chamador_New
{
    public partial class Tela2 : Form
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private void Tela2_Load(object sender, EventArgs e)
        {
            textnome.Text = Db_Server.Nome_Atendimento; 
            textsenha.Text = Db_Server.Senha_Atendimento;
            textguiche.Text = Db_Server.Guiche_Atendimento;
            if (Db_Server.Senha_Atendimento.Substring(0, 1) == "A" || 
                Db_Server.Senha_Atendimento.Substring(0, 1) == "B" || 
                Db_Server.Senha_Atendimento.Substring(0, 1) == "C")
            {
                titulotext.Text = "   Cadastro Único";
                Music_Class Music = new Music_Class(1);
            }
            if (Db_Server.Senha_Atendimento.Substring(0, 1) == "D"||
                Db_Server.Senha_Atendimento.Substring(0, 1) == "T"||
                Db_Server.Senha_Atendimento.Substring(0, 1) == "E")
            {
                titulotext.Text = "Serviço de Documentos";
                Music_Class Music = new Music_Class(2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
