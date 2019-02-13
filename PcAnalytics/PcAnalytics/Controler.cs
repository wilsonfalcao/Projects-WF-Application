using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcAnalytics
{
    //Chamada de primeiro registro
    class Controler_Cadastrar : Model_Banco_Registrar
    {
        //Propriedades Estaticas
        public static string ID_user;
        public static string ID_tomb = null;

        //Construtor
        public Controler_Cadastrar()
        { Criar_Id_User(); Form1.Status_Label.Text = "Executando Ações de Cadastramento..."; }

        //Metodos
        public void Inserir_Dados()
        {
            Consulting_Tomb();
            Registrar_Pessoais(this);
            Atualizacao_Cadastral(this);
            Get_Data_Hardware_WMI();
            Registrar_Maquina(this);
            Atualizacao();
        }
        private void Get_Data_Hardware_WMI()
        {
            string[] Query_Select = new string[5];
            Query_Select[1] = "Win32_SystemEnclosure";
            Query_Select[2] = "Win32_ComputerSystem";
            Query_Select[3] = "Win32_SystemEnclosure";
            Query_Select[4] = "Win32_ComputerSystem";
            string[] Colum_Name = new string[5];
            Colum_Name[1] = "Manufacturer";
            Colum_Name[2] = "Model";
            Colum_Name[3] = "SerialNumber";
            Colum_Name[4] = "PCSystemType";
            WMI_Management Metedo_WMI = new WMI_Management(Query_Select, Colum_Name, 'A');
            this.marca = Metedo_WMI.Dados_Setar_WMI[1];
            this.modelo = Metedo_WMI.Dados_Setar_WMI[2];
            this.serial = Metedo_WMI.Dados_Setar_WMI[3];
            this.tip_maq = Convert.ToInt16(Metedo_WMI.Dados_Setar_WMI[4]);
        }

        //Propriedades da classe

        private string nom_cliente;
        public string Nom_cliente
        {
            get { return nom_cliente; }
            set
            {
                if (value == "") { throw new Tratar_Erros("Campo Nome em branco"); }
                    else { nom_cliente = value; } }
        }

        private string lotacao;
        public string Lotacao
        {
            get { return lotacao; }
            set { if (value == "") { throw new Tratar_Erros("Campo Departamento em branco");}
            else { lotacao = value; } }
        }

        private string ramal;
        public string Ramal
        {
            get { return ramal; }
            set { if (value == "") { throw new Tratar_Erros("Campo Telefone Nulo"); }
            else { ramal = value; } }
        }

        private string coordenador;
        public string Coordenador
        {
            get { return coordenador; }
            set { if (value == "") { throw new Tratar_Erros("Campo Coordenador em branco"); }
            else { coordenador = value; } }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { if (value == "") { throw new Tratar_Erros("Campo E-mail em branco"); }
            else { email = value; } }
        }

        //Propriedades de Reg_Maq
        private string marca;
        public string Marca
        {
            get { return marca; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
        }

        private string serial = Consulting.serial_return;
        public string Serial
        {
            get { return serial; }
        }
        
        private int tip_maq;
        public int Tip_maq
        {
            get { return tip_maq; }
        }

        private void Criar_Id_User()
        {
            string Retorna_Texto = null;
            Retorna_Texto = DateTime.Now.Date.ToString("yyMMdd") +
            DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            ID_user = Retorna_Texto;
        }
    }

    class Controler_Autodados : Model_Banco_Registrado
    {
        //Construtor
        public Controler_Autodados()
        {
            Informacao_Add Atribuindo_Informacao_add = new Informacao_Add();
            Consulting Obter_Serial = new Consulting();
            Form1.Status_Label.Text = "Executando Ações de Coleta de Dados..."; 
            Get_Data_Hardware_WMI(); 
            this.Auto_Hardware(this);
            this.Auto_Software(this);
            this.Auto_Soft_diags(this);
        }

        //Metodos
        private void Get_Data_Hardware_WMI()
        {

            string[] Query_Select = new string[17];
            Query_Select[1] = "Win32_Processor";
            Query_Select[2] = "Win32_Processor";
            Query_Select[3] = "Win32_PhysicalMemory";
            Query_Select[4] = "Win32_LogicalDisk";
            Query_Select[5] = "Win32_NetworkAdapter where PhysicalAdapter=true";
            Query_Select[6] = "Win32_NetworkAdapter where PhysicalAdapter=true";
            Query_Select[7] = "Win32_NetworkAdapter where PhysicalAdapter=true";
            Query_Select[8] = "Win32_LogicalDisk where DeviceID='C:'";
            Query_Select[9] = "Win32_LogicalDisk where DeviceID='D:'";
            Query_Select[10] = "Win32_ComputerSystem";
            Query_Select[11] = "Win32_ComputerSystem";
            Query_Select[12] = "Win32_ComputerSystem";
            Query_Select[13] = "Win32_ComputerSystem";
            Query_Select[14] = "Win32_OperatingSystem";
            Query_Select[15] = "Win32_OperatingSystem";
            Query_Select[16] = "Win32_OperatingSystem";
            string[] Colum_Name = new string[17];
            Colum_Name[1] = "Manufacturer";
            Colum_Name[2] = "Name";
            Colum_Name[3] = "Capacity";
            Colum_Name[4] = "Size";
            Colum_Name[5] = "AdapterType";
            Colum_Name[6] = "Name";
            Colum_Name[7] = "ConfigManagerErrorCode";
            Colum_Name[8] = "FreeSpace";
            Colum_Name[9] = "FreeSpace";
            Colum_Name[10] = "BootupState";
            Colum_Name[11] = "PowerSupplyState";
            Colum_Name[12] = "PowerState";
            Colum_Name[13] = "ThermalState";
            Colum_Name[14] = "Caption";
            Colum_Name[15] = "SerialNumber";
            Colum_Name[16] = "Status";
            WMI_Management Metedo_WMI = new WMI_Management(Query_Select,Colum_Name,'B');
            this.pro_marca = Metedo_WMI.Dados_Setar_WMI[1];
            this.pro_model = Metedo_WMI.Dados_Setar_WMI[2];
            this.memo_cap = Metedo_WMI.Dados_Setar_WMI[3];
            this.hd_cap = Metedo_WMI.Dados_Setar_WMI[4];
            this.tip_rede = Metedo_WMI.Dados_Setar_WMI[5];
            this.adp_Local = Metedo_WMI.Dados_Setar_WMI[6];
            this.est_rede = Metedo_WMI.Dados_Setar_WMI[7];
            
            if(Metedo_WMI.Dados_Setar_WMI[9] == "Não Atribuido."){this.hd_liv = Convert.ToInt64(Metedo_WMI.Dados_Setar_WMI[8]).ToString();}
            else{this.hd_liv =Convert.ToString(Convert.ToInt64(Metedo_WMI.Dados_Setar_WMI[8])+Convert.ToInt64(Metedo_WMI.Dados_Setar_WMI[9]));}

            this.est_boot = Metedo_WMI.Dados_Setar_WMI[10];
            this.est_font= Metedo_WMI.Dados_Setar_WMI[11];
            this.est_ener= Metedo_WMI.Dados_Setar_WMI[12];
            this.ther_stat = Metedo_WMI.Dados_Setar_WMI[13];
            this.sistema = Metedo_WMI.Dados_Setar_WMI[14];
            this.serialsistema = Metedo_WMI.Dados_Setar_WMI[15];
            this.est_os = Metedo_WMI.Dados_Setar_WMI[16];
        }

        //Propriedades do Hardware

        private string pro_marca;
        public string Pro_marca
        {
            get { return pro_marca; }
        }

        private string pro_model;
        public string Pro_model
        {
            get { return pro_model; }
        }

        private string memo_cap;
        public string Memo_cap
        {
            get { return memo_cap; }
        }

        private string hd_cap;
        public string Hd_cap
        {
            get { return hd_cap; }
        }
        
        // Propriedades Soft_Banco

        private string nome_maq= Environment.MachineName.ToString();
        public string Nome_maq()
        {
            return nome_maq;
        }

        private string ender_ip = Informacao_Add.ip_Subrede();
        public string Ender_ip
        {
            get { return ender_ip; }
        }

        private string nome_user = Environment.UserName.ToString();
        public string Nome_user
        {
            get { return nome_user; }
        }

        private string td_user = Informacao_Add.td_User();
        public string Td_user
        {
            get { return td_user; }
            set { td_user = value; }
        }

        private string sistema;
        public string Sistema
        {
            get { return sistema; }
        }

        private string est_os;
        public string Est_os
        {
            get { return est_os; }
        }

        private string serialsistema;
        public string Serialsistema
        {
            get { return serialsistema; }
        }

        private string tip_sistema = Environment.Is64BitOperatingSystem.ToString();
        public string Tip_sistema
        {
            get { return tip_sistema; }
        }

        private string local_gru = Environment.UserDomainName.ToString();
        public string Local_gru
        {
            get { return local_gru; }
        }

        private string id_teamview = Informacao_Add.obter_Team_View();
        public string Id_teamview { get { return id_teamview; } }

        //Propiedades Diags Banco

        private string hd_liv;
        public string Hd_liv
        {
            get { return hd_liv; }
        }
        private string tip_rede;

        public string Tip_rede
        {
            get { return tip_rede; }
        }
        private string adp_Local;

        public string Adp_Local
        {
            get { return adp_Local; }
        }
        private string est_rede;

        public string Est_rede
        {
            get { return est_rede; }
        }
        private string est_boot;

        public string Est_boot
        {
            get { return est_boot; }
        }
        private string est_font;

        public string Est_font
        {
            get { return est_font; }
        }
        private string est_ener;

        public string Est_ener
        {
            get { return est_ener; }
        }
        private string ther_stat;

        public string Ther_stat
        {
            get { return ther_stat; }
        }
        private string temp_ini = TimeSpan.FromMilliseconds(Environment.TickCount).ToString();

        public string Temp_ini
        {
            get { return temp_ini; }
        }
    }

    class Tratar_Erros : Exception
    {
        public Tratar_Erros(string mensagem)
        {
            Tela_Erro.Erro_Mesagem = mensagem;
            Tela_Erro tela1 = new Tela_Erro();
            tela1.Show();
        }
    }
}
