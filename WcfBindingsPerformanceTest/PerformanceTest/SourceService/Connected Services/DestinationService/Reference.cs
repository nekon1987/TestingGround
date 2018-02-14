﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceService.DestinationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DestinationTestRequest", Namespace="http://schemas.datacontract.org/2004/07/DestinationService")]
    [System.SerializableAttribute()]
    public partial class DestinationTestRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PayloadBytesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SleepTimeMsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Common.Enums.TestingStrategy TestingStrategyField;
        
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
        public byte[] PayloadBytes {
            get {
                return this.PayloadBytesField;
            }
            set {
                if ((object.ReferenceEquals(this.PayloadBytesField, value) != true)) {
                    this.PayloadBytesField = value;
                    this.RaisePropertyChanged("PayloadBytes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SleepTimeMs {
            get {
                return this.SleepTimeMsField;
            }
            set {
                if ((this.SleepTimeMsField.Equals(value) != true)) {
                    this.SleepTimeMsField = value;
                    this.RaisePropertyChanged("SleepTimeMs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Common.Enums.TestingStrategy TestingStrategy {
            get {
                return this.TestingStrategyField;
            }
            set {
                if ((this.TestingStrategyField.Equals(value) != true)) {
                    this.TestingStrategyField = value;
                    this.RaisePropertyChanged("TestingStrategy");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DestinationTestResponse", Namespace="http://schemas.datacontract.org/2004/07/DestinationService")]
    [System.SerializableAttribute()]
    public partial class DestinationTestResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PayloadBytesField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] PayloadBytes {
            get {
                return this.PayloadBytesField;
            }
            set {
                if ((object.ReferenceEquals(this.PayloadBytesField, value) != true)) {
                    this.PayloadBytesField = value;
                    this.RaisePropertyChanged("PayloadBytes");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DestinationService.IDestinationService")]
    public interface IDestinationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDestinationService/GetData", ReplyAction="http://tempuri.org/IDestinationService/GetDataResponse")]
        SourceService.DestinationService.DestinationTestResponse GetData(SourceService.DestinationService.DestinationTestRequest composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDestinationService/GetData", ReplyAction="http://tempuri.org/IDestinationService/GetDataResponse")]
        System.Threading.Tasks.Task<SourceService.DestinationService.DestinationTestResponse> GetDataAsync(SourceService.DestinationService.DestinationTestRequest composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDestinationServiceChannel : SourceService.DestinationService.IDestinationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DestinationServiceClient : System.ServiceModel.ClientBase<SourceService.DestinationService.IDestinationService>, SourceService.DestinationService.IDestinationService {
        
        public DestinationServiceClient() {
        }
        
        public DestinationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DestinationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DestinationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DestinationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SourceService.DestinationService.DestinationTestResponse GetData(SourceService.DestinationService.DestinationTestRequest composite) {
            return base.Channel.GetData(composite);
        }
        
        public System.Threading.Tasks.Task<SourceService.DestinationService.DestinationTestResponse> GetDataAsync(SourceService.DestinationService.DestinationTestRequest composite) {
            return base.Channel.GetDataAsync(composite);
        }
    }
}
