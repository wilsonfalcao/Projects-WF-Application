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
    public partial class Dados : Form
    {
        public static byte validar;
        public Dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle_Dados Controler = new Controle_Dados();
            Controler.Nome = Box_Nome.Text; Controler.Bairro = Box_Bairro.Text;
            Controler.Nis = Box_Nis.Text;
            Principal Cadastrar_Lugar = new Principal();
            switch (validar)
            {
                case (1): Cadastrar_Lugar.Inserir_Terreo(Controler); break;
                case (2): Cadastrar_Lugar.Inserir_Especial(Controler); break;
                case (3): Cadastrar_Lugar.Inserir_Primeiro_Andar(Controler); break;
                case (4): Cadastrar_Lugar.Inserir_Idoso(Controler); break;
                case (5): Cadastrar_Lugar.Inserir_Documento(Controler); break;
                case (6): Cadastrar_Lugar.Inserir_Preferencial(Controler); break;
            }
            this.Dispose();
        }

        private void Box_Nis_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Box_Nis.Text, @"[0-9]"))
            {
                MessageBox.Show("Apenas Número!");
            }
        }
    }
}
