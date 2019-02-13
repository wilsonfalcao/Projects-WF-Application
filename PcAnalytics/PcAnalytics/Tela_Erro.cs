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
    public partial class Tela_Erro : Form
    {
        public static string Erro_Mesagem;
        public Tela_Erro()
        {
            InitializeComponent();
        }

        private void Tela_Erro_Load(object sender, EventArgs e)
        {
            Text_Erro.Text = Erro_Mesagem;
        }
    }
}
