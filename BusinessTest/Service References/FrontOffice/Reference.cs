﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessTest.FrontOffice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
    [System.SerializableAttribute()]
    public partial class ProcessExecutionFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://serena-yeoh//LayerSample/Expense/2007/08", ConfigurationName="FrontOffice.IFrontOfficeService")]
    public interface IFrontOfficeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarUsuari" +
            "o", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarUsuari" +
            "oResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarUsuari" +
            "oProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.EspecificacionUsuarioProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.MovimientoProjection))]
        IndignadoFramework.Entities.EspecificacionUsuario AgregarUsuario(IndignadoFramework.Entities.EspecificacionUsuario espus, string nomMov, string[] categs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXId", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXIdProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.EspecificacionUsuarioProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.MovimientoProjection))]
        IndignadoFramework.Entities.EspecificacionUsuario ObtenerEspecificacionUsuarioXId(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXMembership", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXMembershipResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerEspeci" +
            "ficacionUsuarioXMembershipProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.EspecificacionUsuarioProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.MovimientoProjection))]
        IndignadoFramework.Entities.EspecificacionUsuario ObtenerEspecificacionUsuarioXMembership(string membership);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/GetFuentesDat" +
            "osMovimiento", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/GetFuentesDat" +
            "osMovimientoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/GetFuentesDat" +
            "osMovimientoProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        IndignadoFramework.Entities.FuenteWEB[] GetFuentesDatosMovimiento(int idMov);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriaXId", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriaXIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriaXIdProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.ConvocatoriaProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.CategoriaTematicaProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.MovimientoProjection))]
        IndignadoFramework.Entities.Convocatoria ObtenerConvocatoriaXId(int idConvocatoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarConvoc" +
            "atoria", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarConvoc" +
            "atoriaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/AgregarConvoc" +
            "atoriaProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.ConvocatoriaProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.CategoriaTematicaProjection))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IndignadoFramework.Entities.MovimientoProjection))]
        IndignadoFramework.Entities.Convocatoria AgregarConvocatoria(IndignadoFramework.Entities.Convocatoria convocatoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ConfirmarAsis" +
            "tenciaConvocatoria", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ConfirmarAsis" +
            "tenciaConvocatoriaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ConfirmarAsis" +
            "tenciaConvocatoriaProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        void ConfirmarAsistenciaConvocatoria(int idConvocatoria, int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasMovimiento", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasMovimientoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasMovimientoProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        IndignadoFramework.Entities.Convocatoria[] ObtenerConvocatoriasMovimiento(int idMovimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasPaginando", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasPaginandoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerConvoc" +
            "atoriasPaginandoProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        IndignadoFramework.Entities.Convocatoria[] ObtenerConvocatoriasPaginando(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerCatego" +
            "riasTematicas", ReplyAction="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerCatego" +
            "riasTematicasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BusinessTest.FrontOffice.ProcessExecutionFault), Action="http://serena-yeoh//LayerSample/Expense/2007/08/IFrontOfficeService/ObtenerCatego" +
            "riasTematicasProcessExecutionFaultFault", Name="ProcessExecutionFault", Namespace="http://schemas.datacontract.org/2004/07/IndignadoFramework.Services.Contracts")]
        IndignadoFramework.Entities.CategoriaTematica[] ObtenerCategoriasTematicas();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFrontOfficeServiceChannel : BusinessTest.FrontOffice.IFrontOfficeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FrontOfficeServiceClient : System.ServiceModel.ClientBase<BusinessTest.FrontOffice.IFrontOfficeService>, BusinessTest.FrontOffice.IFrontOfficeService {
        
        public FrontOfficeServiceClient() {
        }
        
        public FrontOfficeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FrontOfficeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FrontOfficeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FrontOfficeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IndignadoFramework.Entities.EspecificacionUsuario AgregarUsuario(IndignadoFramework.Entities.EspecificacionUsuario espus, string nomMov, string[] categs) {
            return base.Channel.AgregarUsuario(espus, nomMov, categs);
        }
        
        public IndignadoFramework.Entities.EspecificacionUsuario ObtenerEspecificacionUsuarioXId(int idUsuario) {
            return base.Channel.ObtenerEspecificacionUsuarioXId(idUsuario);
        }
        
        public IndignadoFramework.Entities.EspecificacionUsuario ObtenerEspecificacionUsuarioXMembership(string membership) {
            return base.Channel.ObtenerEspecificacionUsuarioXMembership(membership);
        }
        
        public IndignadoFramework.Entities.FuenteWEB[] GetFuentesDatosMovimiento(int idMov) {
            return base.Channel.GetFuentesDatosMovimiento(idMov);
        }
        
        public IndignadoFramework.Entities.Convocatoria ObtenerConvocatoriaXId(int idConvocatoria) {
            return base.Channel.ObtenerConvocatoriaXId(idConvocatoria);
        }
        
        public IndignadoFramework.Entities.Convocatoria AgregarConvocatoria(IndignadoFramework.Entities.Convocatoria convocatoria) {
            return base.Channel.AgregarConvocatoria(convocatoria);
        }
        
        public void ConfirmarAsistenciaConvocatoria(int idConvocatoria, int idUsuario) {
            base.Channel.ConfirmarAsistenciaConvocatoria(idConvocatoria, idUsuario);
        }
        
        public IndignadoFramework.Entities.Convocatoria[] ObtenerConvocatoriasMovimiento(int idMovimiento) {
            return base.Channel.ObtenerConvocatoriasMovimiento(idMovimiento);
        }
        
        public IndignadoFramework.Entities.Convocatoria[] ObtenerConvocatoriasPaginando(int pageNumber, int pageSize) {
            return base.Channel.ObtenerConvocatoriasPaginando(pageNumber, pageSize);
        }
        
        public IndignadoFramework.Entities.CategoriaTematica[] ObtenerCategoriasTematicas() {
            return base.Channel.ObtenerCategoriasTematicas();
        }
    }
}