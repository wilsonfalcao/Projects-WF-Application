﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atualizacao_Automatica.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Body_Cadastrar", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Controler")]
    [System.SerializableAttribute()]
    public partial class Body_Cadastrar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Adp_LocalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoordenadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ender_ipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_bootField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_enerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_fontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_osField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_redeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Hd_capField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Hd_livField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Id_teamviewField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Id_userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Local_gruField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LotacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Memo_capField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_clienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nome_maqField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nome_userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Pro_marcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Pro_modelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RamalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SerialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SerialsistemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SetorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SistemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Td_userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tel_peField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Temp_iniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ther_statField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tip_maqField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tip_redeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tip_sistemaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adp_Local {
            get {
                return this.Adp_LocalField;
            }
            set {
                if ((object.ReferenceEquals(this.Adp_LocalField, value) != true)) {
                    this.Adp_LocalField = value;
                    this.RaisePropertyChanged("Adp_Local");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Coordenador {
            get {
                return this.CoordenadorField;
            }
            set {
                if ((object.ReferenceEquals(this.CoordenadorField, value) != true)) {
                    this.CoordenadorField = value;
                    this.RaisePropertyChanged("Coordenador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ender_ip {
            get {
                return this.Ender_ipField;
            }
            set {
                if ((object.ReferenceEquals(this.Ender_ipField, value) != true)) {
                    this.Ender_ipField = value;
                    this.RaisePropertyChanged("Ender_ip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_boot {
            get {
                return this.Est_bootField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_bootField, value) != true)) {
                    this.Est_bootField = value;
                    this.RaisePropertyChanged("Est_boot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_ener {
            get {
                return this.Est_enerField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_enerField, value) != true)) {
                    this.Est_enerField = value;
                    this.RaisePropertyChanged("Est_ener");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_font {
            get {
                return this.Est_fontField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_fontField, value) != true)) {
                    this.Est_fontField = value;
                    this.RaisePropertyChanged("Est_font");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_os {
            get {
                return this.Est_osField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_osField, value) != true)) {
                    this.Est_osField = value;
                    this.RaisePropertyChanged("Est_os");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_rede {
            get {
                return this.Est_redeField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_redeField, value) != true)) {
                    this.Est_redeField = value;
                    this.RaisePropertyChanged("Est_rede");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hd_cap {
            get {
                return this.Hd_capField;
            }
            set {
                if ((object.ReferenceEquals(this.Hd_capField, value) != true)) {
                    this.Hd_capField = value;
                    this.RaisePropertyChanged("Hd_cap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hd_liv {
            get {
                return this.Hd_livField;
            }
            set {
                if ((object.ReferenceEquals(this.Hd_livField, value) != true)) {
                    this.Hd_livField = value;
                    this.RaisePropertyChanged("Hd_liv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_teamview {
            get {
                return this.Id_teamviewField;
            }
            set {
                if ((object.ReferenceEquals(this.Id_teamviewField, value) != true)) {
                    this.Id_teamviewField = value;
                    this.RaisePropertyChanged("Id_teamview");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_user {
            get {
                return this.Id_userField;
            }
            set {
                if ((object.ReferenceEquals(this.Id_userField, value) != true)) {
                    this.Id_userField = value;
                    this.RaisePropertyChanged("Id_user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Local_gru {
            get {
                return this.Local_gruField;
            }
            set {
                if ((object.ReferenceEquals(this.Local_gruField, value) != true)) {
                    this.Local_gruField = value;
                    this.RaisePropertyChanged("Local_gru");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lotacao {
            get {
                return this.LotacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.LotacaoField, value) != true)) {
                    this.LotacaoField = value;
                    this.RaisePropertyChanged("Lotacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Memo_cap {
            get {
                return this.Memo_capField;
            }
            set {
                if ((object.ReferenceEquals(this.Memo_capField, value) != true)) {
                    this.Memo_capField = value;
                    this.RaisePropertyChanged("Memo_cap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_cliente {
            get {
                return this.Nom_clienteField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_clienteField, value) != true)) {
                    this.Nom_clienteField = value;
                    this.RaisePropertyChanged("Nom_cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome_maq {
            get {
                return this.Nome_maqField;
            }
            set {
                if ((object.ReferenceEquals(this.Nome_maqField, value) != true)) {
                    this.Nome_maqField = value;
                    this.RaisePropertyChanged("Nome_maq");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome_user {
            get {
                return this.Nome_userField;
            }
            set {
                if ((object.ReferenceEquals(this.Nome_userField, value) != true)) {
                    this.Nome_userField = value;
                    this.RaisePropertyChanged("Nome_user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pro_marca {
            get {
                return this.Pro_marcaField;
            }
            set {
                if ((object.ReferenceEquals(this.Pro_marcaField, value) != true)) {
                    this.Pro_marcaField = value;
                    this.RaisePropertyChanged("Pro_marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pro_model {
            get {
                return this.Pro_modelField;
            }
            set {
                if ((object.ReferenceEquals(this.Pro_modelField, value) != true)) {
                    this.Pro_modelField = value;
                    this.RaisePropertyChanged("Pro_model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ramal {
            get {
                return this.RamalField;
            }
            set {
                if ((object.ReferenceEquals(this.RamalField, value) != true)) {
                    this.RamalField = value;
                    this.RaisePropertyChanged("Ramal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Serial {
            get {
                return this.SerialField;
            }
            set {
                if ((object.ReferenceEquals(this.SerialField, value) != true)) {
                    this.SerialField = value;
                    this.RaisePropertyChanged("Serial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Serialsistema {
            get {
                return this.SerialsistemaField;
            }
            set {
                if ((object.ReferenceEquals(this.SerialsistemaField, value) != true)) {
                    this.SerialsistemaField = value;
                    this.RaisePropertyChanged("Serialsistema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Setor {
            get {
                return this.SetorField;
            }
            set {
                if ((object.ReferenceEquals(this.SetorField, value) != true)) {
                    this.SetorField = value;
                    this.RaisePropertyChanged("Setor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sistema {
            get {
                return this.SistemaField;
            }
            set {
                if ((object.ReferenceEquals(this.SistemaField, value) != true)) {
                    this.SistemaField = value;
                    this.RaisePropertyChanged("Sistema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Td_user {
            get {
                return this.Td_userField;
            }
            set {
                if ((object.ReferenceEquals(this.Td_userField, value) != true)) {
                    this.Td_userField = value;
                    this.RaisePropertyChanged("Td_user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel_pe {
            get {
                return this.Tel_peField;
            }
            set {
                if ((object.ReferenceEquals(this.Tel_peField, value) != true)) {
                    this.Tel_peField = value;
                    this.RaisePropertyChanged("Tel_pe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Temp_ini {
            get {
                return this.Temp_iniField;
            }
            set {
                if ((object.ReferenceEquals(this.Temp_iniField, value) != true)) {
                    this.Temp_iniField = value;
                    this.RaisePropertyChanged("Temp_ini");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ther_stat {
            get {
                return this.Ther_statField;
            }
            set {
                if ((object.ReferenceEquals(this.Ther_statField, value) != true)) {
                    this.Ther_statField = value;
                    this.RaisePropertyChanged("Ther_stat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tip_maq {
            get {
                return this.Tip_maqField;
            }
            set {
                if ((object.ReferenceEquals(this.Tip_maqField, value) != true)) {
                    this.Tip_maqField = value;
                    this.RaisePropertyChanged("Tip_maq");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tip_rede {
            get {
                return this.Tip_redeField;
            }
            set {
                if ((object.ReferenceEquals(this.Tip_redeField, value) != true)) {
                    this.Tip_redeField = value;
                    this.RaisePropertyChanged("Tip_rede");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tip_sistema {
            get {
                return this.Tip_sistemaField;
            }
            set {
                if ((object.ReferenceEquals(this.Tip_sistemaField, value) != true)) {
                    this.Tip_sistemaField = value;
                    this.RaisePropertyChanged("Tip_sistema");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Atualizacao", ReplyAction="http://tempuri.org/IService1/AtualizacaoResponse")]
        bool Atualizacao(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Atualizacao", ReplyAction="http://tempuri.org/IService1/AtualizacaoResponse")]
        System.Threading.Tasks.Task<bool> AtualizacaoAsync(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Maq_Setor", ReplyAction="http://tempuri.org/IService1/Registrar_Maq_SetorResponse")]
        bool Registrar_Maq_Setor(string serial, string tomb, string lugar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Maq_Setor", ReplyAction="http://tempuri.org/IService1/Registrar_Maq_SetorResponse")]
        System.Threading.Tasks.Task<bool> Registrar_Maq_SetorAsync(string serial, string tomb, string lugar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Pessoais", ReplyAction="http://tempuri.org/IService1/Registrar_PessoaisResponse")]
        bool Registrar_Pessoais(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Dados_Controle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Pessoais", ReplyAction="http://tempuri.org/IService1/Registrar_PessoaisResponse")]
        System.Threading.Tasks.Task<bool> Registrar_PessoaisAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Dados_Controle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Maquina", ReplyAction="http://tempuri.org/IService1/Registrar_MaquinaResponse")]
        bool Registrar_Maquina(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Reg_Maq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Maquina", ReplyAction="http://tempuri.org/IService1/Registrar_MaquinaResponse")]
        System.Threading.Tasks.Task<bool> Registrar_MaquinaAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Reg_Maq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Atualizados", ReplyAction="http://tempuri.org/IService1/Registrar_AtualizadosResponse")]
        bool Registrar_Atualizados(string id_user, string tombamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registrar_Atualizados", ReplyAction="http://tempuri.org/IService1/Registrar_AtualizadosResponse")]
        System.Threading.Tasks.Task<bool> Registrar_AtualizadosAsync(string id_user, string tombamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_Maquina", ReplyAction="http://tempuri.org/IService1/Update_MaquinaResponse")]
        bool Update_Maquina(string serial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_Maquina", ReplyAction="http://tempuri.org/IService1/Update_MaquinaResponse")]
        System.Threading.Tasks.Task<bool> Update_MaquinaAsync(string serial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Hardware", ReplyAction="http://tempuri.org/IService1/Auto_HardwareResponse")]
        string Auto_Hardware(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_har);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Hardware", ReplyAction="http://tempuri.org/IService1/Auto_HardwareResponse")]
        System.Threading.Tasks.Task<string> Auto_HardwareAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_har);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Software", ReplyAction="http://tempuri.org/IService1/Auto_SoftwareResponse")]
        string Auto_Software(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_soft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Software", ReplyAction="http://tempuri.org/IService1/Auto_SoftwareResponse")]
        System.Threading.Tasks.Task<string> Auto_SoftwareAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_soft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Soft_diags", ReplyAction="http://tempuri.org/IService1/Auto_Soft_diagsResponse")]
        string Auto_Soft_diags(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_Diags);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Auto_Soft_diags", ReplyAction="http://tempuri.org/IService1/Auto_Soft_diagsResponse")]
        System.Threading.Tasks.Task<string> Auto_Soft_diagsAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_Diags);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consult_", ReplyAction="http://tempuri.org/IService1/Consult_Response")]
        string[] Consult_();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consult_", ReplyAction="http://tempuri.org/IService1/Consult_Response")]
        System.Threading.Tasks.Task<string[]> Consult_Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulting_AT", ReplyAction="http://tempuri.org/IService1/Consulting_ATResponse")]
        string Consulting_AT(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulting_AT", ReplyAction="http://tempuri.org/IService1/Consulting_ATResponse")]
        System.Threading.Tasks.Task<string> Consulting_ATAsync(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulting_Tomb", ReplyAction="http://tempuri.org/IService1/Consulting_TombResponse")]
        string Consulting_Tomb(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulting_Tomb", ReplyAction="http://tempuri.org/IService1/Consulting_TombResponse")]
        System.Threading.Tasks.Task<string> Consulting_TombAsync(string serial_return);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consultin_Program_AT", ReplyAction="http://tempuri.org/IService1/Consultin_Program_ATResponse")]
        string Consultin_Program_AT(string versao, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consultin_Program_AT", ReplyAction="http://tempuri.org/IService1/Consultin_Program_ATResponse")]
        System.Threading.Tasks.Task<string> Consultin_Program_ATAsync(string versao, string tipo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Atualizacao_Automatica.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Atualizacao_Automatica.ServiceReference1.IService1>, Atualizacao_Automatica.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Atualizacao(string serial_return) {
            return base.Channel.Atualizacao(serial_return);
        }
        
        public System.Threading.Tasks.Task<bool> AtualizacaoAsync(string serial_return) {
            return base.Channel.AtualizacaoAsync(serial_return);
        }
        
        public bool Registrar_Maq_Setor(string serial, string tomb, string lugar) {
            return base.Channel.Registrar_Maq_Setor(serial, tomb, lugar);
        }
        
        public System.Threading.Tasks.Task<bool> Registrar_Maq_SetorAsync(string serial, string tomb, string lugar) {
            return base.Channel.Registrar_Maq_SetorAsync(serial, tomb, lugar);
        }
        
        public bool Registrar_Pessoais(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Dados_Controle) {
            return base.Channel.Registrar_Pessoais(Dados_Controle);
        }
        
        public System.Threading.Tasks.Task<bool> Registrar_PessoaisAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Dados_Controle) {
            return base.Channel.Registrar_PessoaisAsync(Dados_Controle);
        }
        
        public bool Registrar_Maquina(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Reg_Maq) {
            return base.Channel.Registrar_Maquina(Reg_Maq);
        }
        
        public System.Threading.Tasks.Task<bool> Registrar_MaquinaAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Reg_Maq) {
            return base.Channel.Registrar_MaquinaAsync(Reg_Maq);
        }
        
        public bool Registrar_Atualizados(string id_user, string tombamento) {
            return base.Channel.Registrar_Atualizados(id_user, tombamento);
        }
        
        public System.Threading.Tasks.Task<bool> Registrar_AtualizadosAsync(string id_user, string tombamento) {
            return base.Channel.Registrar_AtualizadosAsync(id_user, tombamento);
        }
        
        public bool Update_Maquina(string serial) {
            return base.Channel.Update_Maquina(serial);
        }
        
        public System.Threading.Tasks.Task<bool> Update_MaquinaAsync(string serial) {
            return base.Channel.Update_MaquinaAsync(serial);
        }
        
        public string Auto_Hardware(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_har) {
            return base.Channel.Auto_Hardware(Auto_har);
        }
        
        public System.Threading.Tasks.Task<string> Auto_HardwareAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_har) {
            return base.Channel.Auto_HardwareAsync(Auto_har);
        }
        
        public string Auto_Software(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_soft) {
            return base.Channel.Auto_Software(Auto_soft);
        }
        
        public System.Threading.Tasks.Task<string> Auto_SoftwareAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_soft) {
            return base.Channel.Auto_SoftwareAsync(Auto_soft);
        }
        
        public string Auto_Soft_diags(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_Diags) {
            return base.Channel.Auto_Soft_diags(Auto_Diags);
        }
        
        public System.Threading.Tasks.Task<string> Auto_Soft_diagsAsync(Atualizacao_Automatica.ServiceReference1.Body_Cadastrar Auto_Diags) {
            return base.Channel.Auto_Soft_diagsAsync(Auto_Diags);
        }
        
        public string[] Consult_() {
            return base.Channel.Consult_();
        }
        
        public System.Threading.Tasks.Task<string[]> Consult_Async() {
            return base.Channel.Consult_Async();
        }
        
        public string Consulting_AT(string serial_return) {
            return base.Channel.Consulting_AT(serial_return);
        }
        
        public System.Threading.Tasks.Task<string> Consulting_ATAsync(string serial_return) {
            return base.Channel.Consulting_ATAsync(serial_return);
        }
        
        public string Consulting_Tomb(string serial_return) {
            return base.Channel.Consulting_Tomb(serial_return);
        }
        
        public System.Threading.Tasks.Task<string> Consulting_TombAsync(string serial_return) {
            return base.Channel.Consulting_TombAsync(serial_return);
        }
        
        public string Consultin_Program_AT(string versao, string tipo) {
            return base.Channel.Consultin_Program_AT(versao, tipo);
        }
        
        public System.Threading.Tasks.Task<string> Consultin_Program_ATAsync(string versao, string tipo) {
            return base.Channel.Consultin_Program_ATAsync(versao, tipo);
        }
    }
}
