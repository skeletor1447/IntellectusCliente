﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteIntellectus.AmigosServicios {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MultipleRespuestaOfSolicitudAmistadqYdlCAL1", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class MultipleRespuestaOfSolicitudAmistadqYdlCAL1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.AmigosServicios.SolicitudAmistad[] EntidadesField;
        
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
        public ClienteIntellectus.AmigosServicios.SolicitudAmistad[] Entidades {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EliminarRespuestaOfSolicitudAmistadqYdlCAL1", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class EliminarRespuestaOfSolicitudAmistadqYdlCAL1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.AmigosServicios.SolicitudAmistad EntidadField;
        
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
        public ClienteIntellectus.AmigosServicios.SolicitudAmistad Entidad {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ActualizarRespuestaOfSolicitudAmistadqYdlCAL1", Namespace="http://schemas.datacontract.org/2004/07/WCFIntellectus.Utileria")]
    [System.SerializableAttribute()]
    public partial class ActualizarRespuestaOfSolicitudAmistadqYdlCAL1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClienteIntellectus.AmigosServicios.SolicitudAmistad EntidadField;
        
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
        public ClienteIntellectus.AmigosServicios.SolicitudAmistad Entidad {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AmigosServicios.IAmigosServices")]
    public interface IAmigosServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/SolicitudDeAmistad", ReplyAction="http://tempuri.org/IAmigosServices/SolicitudDeAmistadResponse")]
        ClienteIntellectus.AmigosServicios.InsertarRespuesta SolicitudDeAmistad(int solicitante, int solicitado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/SolicitudDeAmistad", ReplyAction="http://tempuri.org/IAmigosServices/SolicitudDeAmistadResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.InsertarRespuesta> SolicitudDeAmistadAsync(int solicitante, int solicitado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarSolicitudesEnviadas", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarSolicitudesEnviadasResponse")]
        ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarSolicitudesEnviadas(int soliciante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarSolicitudesEnviadas", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarSolicitudesEnviadasResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarSolicitudesEnviadasAsync(int soliciante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarSolicitudesRecibidas", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarSolicitudesRecibidasResponse")]
        ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarSolicitudesRecibidas(int soliciante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarSolicitudesRecibidas", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarSolicitudesRecibidasResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarSolicitudesRecibidasAsync(int soliciante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/EliminarSolicitud", ReplyAction="http://tempuri.org/IAmigosServices/EliminarSolicitudResponse")]
        ClienteIntellectus.AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1 EliminarSolicitud(int idsolicitudamistad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/EliminarSolicitud", ReplyAction="http://tempuri.org/IAmigosServices/EliminarSolicitudResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1> EliminarSolicitudAsync(int idsolicitudamistad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/AceptarSolicitud", ReplyAction="http://tempuri.org/IAmigosServices/AceptarSolicitudResponse")]
        ClienteIntellectus.AmigosServicios.ActualizarRespuestaOfSolicitudAmistadqYdlCAL1 AceptarSolicitud(int idsolicitudamistad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/AceptarSolicitud", ReplyAction="http://tempuri.org/IAmigosServices/AceptarSolicitudResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.ActualizarRespuestaOfSolicitudAmistadqYdlCAL1> AceptarSolicitudAsync(int idsolicitudamistad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarAmigos", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarAmigosResponse")]
        ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarAmigos(int solicitante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAmigosServices/ConsultarAmigos", ReplyAction="http://tempuri.org/IAmigosServices/ConsultarAmigosResponse")]
        System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarAmigosAsync(int solicitante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAmigosServicesChannel : ClienteIntellectus.AmigosServicios.IAmigosServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AmigosServicesClient : System.ServiceModel.ClientBase<ClienteIntellectus.AmigosServicios.IAmigosServices>, ClienteIntellectus.AmigosServicios.IAmigosServices {
        
        public AmigosServicesClient() {
        }
        
        public AmigosServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AmigosServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmigosServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AmigosServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteIntellectus.AmigosServicios.InsertarRespuesta SolicitudDeAmistad(int solicitante, int solicitado) {
            return base.Channel.SolicitudDeAmistad(solicitante, solicitado);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.InsertarRespuesta> SolicitudDeAmistadAsync(int solicitante, int solicitado) {
            return base.Channel.SolicitudDeAmistadAsync(solicitante, solicitado);
        }
        
        public ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarSolicitudesEnviadas(int soliciante) {
            return base.Channel.ConsultarSolicitudesEnviadas(soliciante);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarSolicitudesEnviadasAsync(int soliciante) {
            return base.Channel.ConsultarSolicitudesEnviadasAsync(soliciante);
        }
        
        public ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarSolicitudesRecibidas(int soliciante) {
            return base.Channel.ConsultarSolicitudesRecibidas(soliciante);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarSolicitudesRecibidasAsync(int soliciante) {
            return base.Channel.ConsultarSolicitudesRecibidasAsync(soliciante);
        }
        
        public ClienteIntellectus.AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1 EliminarSolicitud(int idsolicitudamistad) {
            return base.Channel.EliminarSolicitud(idsolicitudamistad);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1> EliminarSolicitudAsync(int idsolicitudamistad) {
            return base.Channel.EliminarSolicitudAsync(idsolicitudamistad);
        }
        
        public ClienteIntellectus.AmigosServicios.ActualizarRespuestaOfSolicitudAmistadqYdlCAL1 AceptarSolicitud(int idsolicitudamistad) {
            return base.Channel.AceptarSolicitud(idsolicitudamistad);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.ActualizarRespuestaOfSolicitudAmistadqYdlCAL1> AceptarSolicitudAsync(int idsolicitudamistad) {
            return base.Channel.AceptarSolicitudAsync(idsolicitudamistad);
        }
        
        public ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 ConsultarAmigos(int solicitante) {
            return base.Channel.ConsultarAmigos(solicitante);
        }
        
        public System.Threading.Tasks.Task<ClienteIntellectus.AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1> ConsultarAmigosAsync(int solicitante) {
            return base.Channel.ConsultarAmigosAsync(solicitante);
        }
    }
}
