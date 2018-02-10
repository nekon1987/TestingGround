﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClientApp.SourceServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SourceTestRequest", Namespace="http://schemas.datacontract.org/2004/07/SourceService")]
    [System.SerializableAttribute()]
    public partial class SourceTestRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AttemptsNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Common.Enums.EndpointName EndpointNameField;
        
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
        public int AttemptsNumber {
            get {
                return this.AttemptsNumberField;
            }
            set {
                if ((this.AttemptsNumberField.Equals(value) != true)) {
                    this.AttemptsNumberField = value;
                    this.RaisePropertyChanged("AttemptsNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Common.Enums.EndpointName EndpointName {
            get {
                return this.EndpointNameField;
            }
            set {
                if ((this.EndpointNameField.Equals(value) != true)) {
                    this.EndpointNameField = value;
                    this.RaisePropertyChanged("EndpointName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SourceTestResponse", Namespace="http://schemas.datacontract.org/2004/07/SourceService")]
    [System.SerializableAttribute()]
    public partial class SourceTestResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SourceServiceProxy.ISourceService")]
    public interface ISourceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISourceService/GetDataViaEndpoint", ReplyAction="http://tempuri.org/ISourceService/GetDataViaEndpointResponse")]
        TestClientApp.SourceServiceProxy.SourceTestResponse GetDataViaEndpoint(TestClientApp.SourceServiceProxy.SourceTestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISourceService/GetDataViaEndpoint", ReplyAction="http://tempuri.org/ISourceService/GetDataViaEndpointResponse")]
        System.Threading.Tasks.Task<TestClientApp.SourceServiceProxy.SourceTestResponse> GetDataViaEndpointAsync(TestClientApp.SourceServiceProxy.SourceTestRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISourceServiceChannel : TestClientApp.SourceServiceProxy.ISourceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SourceServiceClient : System.ServiceModel.ClientBase<TestClientApp.SourceServiceProxy.ISourceService>, TestClientApp.SourceServiceProxy.ISourceService {
        
        public SourceServiceClient() {
        }
        
        public SourceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SourceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SourceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestClientApp.SourceServiceProxy.SourceTestResponse GetDataViaEndpoint(TestClientApp.SourceServiceProxy.SourceTestRequest request) {
            return base.Channel.GetDataViaEndpoint(request);
        }
        
        public System.Threading.Tasks.Task<TestClientApp.SourceServiceProxy.SourceTestResponse> GetDataViaEndpointAsync(TestClientApp.SourceServiceProxy.SourceTestRequest request) {
            return base.Channel.GetDataViaEndpointAsync(request);
        }
    }
}