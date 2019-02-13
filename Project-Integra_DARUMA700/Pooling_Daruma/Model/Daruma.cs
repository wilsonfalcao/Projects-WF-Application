using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Pooling_Daruma
{
    public class Daruma
    {
        public Daruma()
        {
            eDefinirProduto_Daruma("DUAL");
            regPortaComunicacao_DUAL_DarumaFramework("COM4");
            regVelocidade_DUAL_DarumaFramework("115200");
            regTermica_DUAL_DarumaFramework("1");
        }
        public Daruma(string tip_imp, string port, string velocidade, string tip_impress)
        {
            eDefinirProduto_Daruma(tip_imp);
            regPortaComunicacao_DUAL_DarumaFramework(port);
            regVelocidade_DUAL_DarumaFramework(velocidade);
            regTermica_DUAL_DarumaFramework(tip_impress);
        }

        public void Imprimir_Impressora(string senha)
        {
            string local = senha.Substring(0,1), lugar = null;
            switch(local)
            {
                case ("A"): lugar = "Terreo"; break;
                case ("B"): lugar = "Terreo"; break;
                case ("C"): lugar = "1ª Andar"; break;
                case ("T"): lugar = "Terreo"; break;
                case ("D"): lugar = "Terreo"; break;
                case ("P"): lugar = "Terreo"; break;
                case ("E"): lugar = "Terreo"; break;
            }
            string txt = "<tc>#</tc><b><ce><e>Sistema de Chamado<l></l>Expresso Recife" +
                         "</e></ce><l></l><tc>#</tc><dt></dt><sp>30</sp><hr></hr><sl>2</sl><ce><e>" +
                         "SENHA:</ce></e><l></l><xl>" + senha + "</xl><l></l>(<b><e>"+lugar+"</b></e>)</e><sl>2</sl><e>"+
                         "PREFEITURA DO RECIFE</e><l></l>Por Você, Trabalhando sem Parar.<l></l>"+
                         "SETOR DE INFORMÁTICA 2017<sl>4</sl>";
            iImprimirTexto_DUAL_DarumaFramework(txt, 0);
        }
        #region Métodos DUAL

        //*************Métodos para Impressoras Dual*************
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirProduto_Daruma(System.String sProduto);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eCarregarBitmapPromocional_ECF_Daruma(string pszPath, string pszIndice, string pszOrient);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave_DarumaFramework(string sProduto, string sChave, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEnviarBMP_DUAL_DarumaFramework(string stArqOrigem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirArquivo_DUAL_DarumaFramework(string stPath);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAcionarGaveta_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusGaveta_DUAL_DarumaFramework(ref int iStatusGaveta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusDocumento_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regVelocidade_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTermica_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTabulacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPortaComunicacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regModoGaveta_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLinhasGuilhotina_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regEnterFinal_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAguardarProcesso_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirTexto_DUAL_DarumaFramework(string stTexto, int iTam);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirBMP_DUAL_DarumaFramework(System.String stArqOrigem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAutenticarDocumento_DUAL_DarumaFramework(string stTexto, string stLocal, string stTimeOut);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCodePageAutomatico_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regZeroCortado_DUAL_DarumaFramework(System.String stParametro);
        #endregion
    }
}