using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pooling_Daruma
{
    public class body
    {
        public byte validar = 0;
        private static Int64 linha_normal;
        private static Int64 linha_especial;
        private static Int64 linha_normal_s;
        private static Int64 linha_documento;
        private static Int64 linha_idoso;
        private static Int64 linha_prioridade;

        public string senha;
        public string nome;
  
        public Int64 Linha_normal
        {
            get { return linha_normal; }
            set { if (value==0) {  } else { linha_normal = value; validar += 1; } }
        }
        public Int64 Linha_especial
        {
            get { return linha_especial; }
            set { if (value==0) { } else { linha_especial = value; validar += 2; } }
        }
        public Int64 Linha_normal_s
        {
            get { return linha_normal_s; }
            set { if (value== 0) {  } else { linha_normal_s = value; validar += 4; } }
        }
        public Int64 Linha_documento
        {
            get { return linha_documento; }
            set { if (value == 0) { } else { linha_documento = value; validar += 8; } }
        }
        public Int64 Linha_idoso
        {
            get { return linha_idoso; }
            set { if (value == 0) { } else { linha_idoso = value; validar += 9; } }
        }
        public Int64 Linha_prioridade
        {
            get { return linha_prioridade; }
            set { if (value == 0) { } else { linha_prioridade = value; validar += 10; } }
        }
    }
}
