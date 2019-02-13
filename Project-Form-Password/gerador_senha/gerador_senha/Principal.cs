using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_senha
{
    class Principal: Model_Banco
    {
        public void Inserir_Terreo(Controle_Dados Dados)
        {
            Inserir_Tabela_Normal_P(Dados);
        }
        public void Inserir_Primeiro_Andar(Controle_Dados Dados)
        {
            Inserir_Tabela_Normal_S(Dados);
        }
        public void Inserir_Especial(Controle_Dados Dados)
        {
            Inserir_Tabela_Preferencial(Dados);
        }
    }
}
