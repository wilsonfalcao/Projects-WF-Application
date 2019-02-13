using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pooling_Daruma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Model_Banco Chamar_Banco = new Model_Banco();
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.WindowState = FormWindowState.Maximized;
            this.Visible = false;
            this.Opacity = 0;
            
        }
    }
    public class MSG
   {
        public MSG(string erro)
        {
            MessageBox.Show(erro);
        }
   }
}
