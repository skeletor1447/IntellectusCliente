﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteIntellectus.UsuarioServicios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UnicaRespuestaOfUsuarioqYdlCAL1", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class UnicaRespuestaOfUsuarioqYdlCAL1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.UsuarioServicios.Usuario EntidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> ErroresField;
        
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
        public ClienteIntellectus.UsuarioServicios.Usuario Entidad {
            get {
                return this.EntidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EntidadField, value) != true)) {
                    this.EntidadField = value;
                    this.RaisePropertyChanged("Entidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((this.ErrorField.Equals(value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Errores {
            get {
                return this.ErroresField;
            }
            set {
                if ((object.ReferenceEquals(this.ErroresField, value) != true)) {
                    this.ErroresField = value;
                    this.RaisePropertyChanged("Errores");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Entidades")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nick {
            get {
                return this.NickField;
            }
            set {
                if ((object.ReferenceEquals(this.NickField, value) != true)) {
                    this.NickField = value;
                    this.RaisePropertyChanged("Nick");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertarRespuesta", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class InsertarRespuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> ErroresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
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
        public bool Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((this.ErrorField.Equals(value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Errores {
            get {
                return this.ErroresField;
            }
            set {
                if ((object.ReferenceEquals(this.ErroresField, value) != true)) {
                    this.ErroresField = value;
                    this.RaisePropertyChanged("Errores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MultipleRespuestaOfUsuarioAmistadqYdlCAL1", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class MultipleRespuestaOfUsuarioAmistadqYdlCAL1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.UsuarioServicios.UsuarioAmistad[] EntidadesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> ErroresField;
        
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
        public ClienteIntellectus.UsuarioServicios.UsuarioAmistad[] Entidades {
            get {
                return this.EntidadesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntidadesField, value) != true)) {
                    this.EntidadesField = value;
                    this.RaisePropertyChanged("Entidades");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((this.ErrorField.Equals(value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Errores {
            get {
                return this.ErroresField;
            }
            set {
                if ((object.ReferenceEquals(this.ErroresField, value) != true)) {
                    this.ErroresField = value;
                    this.RaisePropertyChanged("Errores");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioAmistad", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Entidades")]
    [System.SerializableAttribute()]
    public partial class UsuarioAmistad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> EsSolicitanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.UsuarioServicios.SolicitudAmistad SolicitudAmistadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.UsuarioServicios.Usuario UsuarioField;
        
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
        public System.Nullable<bool> EsSolicitante {
            get {
                return this.EsSolicitanteField;
            }
            set {
                if ((this.EsSolicitanteField.Equals(value) != true)) {
                    this.EsSolicitanteField = value;
                    this.RaisePropertyChanged("EsSolicitante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClienteIntellectus.UsuarioServicios.SolicitudAmistad SolicitudAmistad {
            get {
                return this.SolicitudAmistadField;
            }
            set {
                if ((object.ReferenceEquals(this.SolicitudAmistadField, value) != true)) {
                    this.SolicitudAmistadField = value;
                    this.RaisePropertyChanged("SolicitudAmistad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClienteIntellectus.UsuarioServicios.Usuario Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SolicitudAmistad", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Entidades")]
    [System.SerializableAttribute()]
    public partial class SolicitudAmistad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdSolicitadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdSolicitanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdSolicitudAmistadField;
        
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
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdSolicitado {
            get {
                return this.IdSolicitadoField;
            }
            set {
                if ((this.IdSolicitadoField.Equals(value) != true)) {
                    this.IdSolicitadoField = value;
                    this.RaisePropertyChanged("IdSolicitado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdSolicitante {
            get {
                return this.IdSolicitanteField;
            }
            set {
                if ((this.IdSolicitanteField.Equals(value) != true)) {
                    this.IdSolicitanteField = value;
                    this.RaisePropertyChanged("IdSolicitante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdSolicitudAmistad {
            get {
                return this.IdSolicitudAmistadField;
            }
            set {
                if ((this.IdSolicitudAmistadField.Equals(value) != true)) {
                    this.IdSolicitudAmistadField = value;
                    this.RaisePropertyChanged("IdSolicitudAmistad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuarioServicios.IUsuarioServices")]
    public interface IUsuarioServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/LoguearPorCorreoYPassword", ReplyAction="http://tempuri.org/IUsuarioServices/LoguearPorCorreoYPasswordResponse")]
        ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 LoguearPorCorreoYPassword(string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/LoguearPorCorreoYPassword", ReplyAction="http://tempuri.org/IUsuarioServices/LoguearPorCorreoYPasswordResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1> LoguearPorCorreoYPasswordAsync(string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/Registrar", ReplyAction="http://tempuri.org/IUsuarioServices/RegistrarResponse")]
        ClienteIntellectus.UsuarioServicios.InsertarRespuesta Registrar(ClienteIntellectus.UsuarioServicios.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/Registrar", ReplyAction="http://tempuri.org/IUsuarioServices/RegistrarResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.InsertarRespuesta> RegistrarAsync(ClienteIntellectus.UsuarioServicios.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/Consultar", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarResponse")]
        ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 Consultar(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/Consultar", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1> ConsultarAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarPorBusqueda", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarPorBusquedaResponse")]
        ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarPorBusqueda(long idCliente, string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarPorBusqueda", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarPorBusquedaResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarPorBusquedaAsync(long idCliente, string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarSolicitudesPorCliente", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarSolicitudesPorClienteResponse")]
        ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarSolicitudesPorCliente(int idcliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarSolicitudesPorCliente", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarSolicitudesPorClienteResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarSolicitudesPorClienteAsync(int idcliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarAmigos", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarAmigosResponse")]
        ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarAmigos(int idcliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioServices/ConsultarAmigos", ReplyAction="http://tempuri.org/IUsuarioServices/ConsultarAmigosResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarAmigosAsync(int idcliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServicesChannel : ClienteIntellectus.UsuarioServicios.IUsuarioServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServicesClient : System.ServiceModel.ClientBase<ClienteIntellectus.UsuarioServicios.IUsuarioServices>, ClienteIntellectus.UsuarioServicios.IUsuarioServices {
        
        public UsuarioServicesClient() {
        }
        
        public UsuarioServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 LoguearPorCorreoYPassword(string correo, string password) {
            return base.Channel.LoguearPorCorreoYPassword(correo, password);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1> LoguearPorCorreoYPasswordAsync(string correo, string password) {
            return base.Channel.LoguearPorCorreoYPasswordAsync(correo, password);
        }
        
        public ClienteIntellectus.UsuarioServicios.InsertarRespuesta Registrar(ClienteIntellectus.UsuarioServicios.Usuario usuario) {
            return base.Channel.Registrar(usuario);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.InsertarRespuesta> RegistrarAsync(ClienteIntellectus.UsuarioServicios.Usuario usuario) {
            return base.Channel.RegistrarAsync(usuario);
        }
        
        public ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 Consultar(long id) {
            return base.Channel.Consultar(id);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1> ConsultarAsync(long id) {
            return base.Channel.ConsultarAsync(id);
        }
        
        public ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarPorBusqueda(long idCliente, string busqueda) {
            return base.Channel.ConsultarPorBusqueda(idCliente, busqueda);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarPorBusquedaAsync(long idCliente, string busqueda) {
            return base.Channel.ConsultarPorBusquedaAsync(idCliente, busqueda);
        }
        
        public ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarSolicitudesPorCliente(int idcliente) {
            return base.Channel.ConsultarSolicitudesPorCliente(idcliente);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarSolicitudesPorClienteAsync(int idcliente) {
            return base.Channel.ConsultarSolicitudesPorClienteAsync(idcliente);
        }
        
        public ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 ConsultarAmigos(int idcliente) {
            return base.Channel.ConsultarAmigos(idcliente);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1> ConsultarAmigosAsync(int idcliente) {
            return base.Channel.ConsultarAmigosAsync(idcliente);
        }
    }
}
