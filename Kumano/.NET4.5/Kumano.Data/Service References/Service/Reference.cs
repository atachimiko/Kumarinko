﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kumano.Data.Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="REQUEST_FINDARTIFACT", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Request")]
    [System.SerializableAttribute()]
    public partial class REQUEST_FINDARTIFACT : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.FindExpression ExpressionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.FINDTARGET_SELECTOR TargetTypeField;
        
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
        public Kumano.Data.Service.FindExpression Expression {
            get {
                return this.ExpressionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExpressionField, value) != true)) {
                    this.ExpressionField = value;
                    this.RaisePropertyChanged("Expression");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kumano.Data.Service.FINDTARGET_SELECTOR TargetType {
            get {
                return this.TargetTypeField;
            }
            set {
                if ((this.TargetTypeField.Equals(value) != true)) {
                    this.TargetTypeField = value;
                    this.RaisePropertyChanged("TargetType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FindExpression", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Core.Expression")]
    [System.SerializableAttribute()]
    public partial class FindExpression : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.ExpKeyValue LeftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.RelationalType RelationalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.ExpKeyValue RightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.LogicalType SubConnectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kumano.Data.Service.FindExpression[] SubExpressionField;
        
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
        public Kumano.Data.Service.ExpKeyValue Left {
            get {
                return this.LeftField;
            }
            set {
                if ((object.ReferenceEquals(this.LeftField, value) != true)) {
                    this.LeftField = value;
                    this.RaisePropertyChanged("Left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kumano.Data.Service.RelationalType Relational {
            get {
                return this.RelationalField;
            }
            set {
                if ((this.RelationalField.Equals(value) != true)) {
                    this.RelationalField = value;
                    this.RaisePropertyChanged("Relational");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kumano.Data.Service.ExpKeyValue Right {
            get {
                return this.RightField;
            }
            set {
                if ((object.ReferenceEquals(this.RightField, value) != true)) {
                    this.RightField = value;
                    this.RaisePropertyChanged("Right");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kumano.Data.Service.LogicalType SubConnection {
            get {
                return this.SubConnectionField;
            }
            set {
                if ((this.SubConnectionField.Equals(value) != true)) {
                    this.SubConnectionField = value;
                    this.RaisePropertyChanged("SubConnection");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kumano.Data.Service.FindExpression[] SubExpression {
            get {
                return this.SubExpressionField;
            }
            set {
                if ((object.ReferenceEquals(this.SubExpressionField, value) != true)) {
                    this.SubExpressionField = value;
                    this.RaisePropertyChanged("SubExpression");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FINDTARGET_SELECTOR", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Construction")]
    public enum FINDTARGET_SELECTOR : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CATEGORY = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExpKeyValue", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Core.Expression")]
    [System.SerializableAttribute()]
    public partial class ExpKeyValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RelationalType", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Core.Expression")]
    public enum RelationalType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EQUAL = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UNEQUAL = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GREATER = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GREATER_EQUAL = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LESS = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LESS_EQUAL = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogicalType", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Core.Expression")]
    public enum LogicalType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AND = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OR = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RESPONSEAPI_BASE", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Response")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Kumano.Data.Service.RESPONSE_GETSERVERVERSION))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Kumano.Data.Service.RESPONSE_FINDARTIFACT))]
    public partial class RESPONSEAPI_BASE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RESPONSE_GETSERVERVERSION", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Response")]
    [System.SerializableAttribute()]
    public partial class RESPONSE_GETSERVERVERSION : Kumano.Data.Service.RESPONSEAPI_BASE {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionTextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VersionText {
            get {
                return this.VersionTextField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionTextField, value) != true)) {
                    this.VersionTextField = value;
                    this.RaisePropertyChanged("VersionText");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RESPONSE_FINDARTIFACT", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Response")]
    [System.SerializableAttribute()]
    public partial class RESPONSE_FINDARTIFACT : Kumano.Data.Service.RESPONSEAPI_BASE {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VERSION_SELECTOR", Namespace="http://schemas.datacontract.org/2004/07/Mogami.Service.Construction")]
    public enum VERSION_SELECTOR : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SERVICE_VERSION = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DATABASE_VERSION = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        API_VERSION = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IMogamiApiService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMogamiApiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/FindArtifact", ReplyAction="http://tempuri.org/IMogamiApiService/FindArtifactResponse")]
        Kumano.Data.Service.RESPONSE_FINDARTIFACT FindArtifact(Kumano.Data.Service.REQUEST_FINDARTIFACT reqparam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/FindArtifact", ReplyAction="http://tempuri.org/IMogamiApiService/FindArtifactResponse")]
        System.Threading.Tasks.Task<Kumano.Data.Service.RESPONSE_FINDARTIFACT> FindArtifactAsync(Kumano.Data.Service.REQUEST_FINDARTIFACT reqparam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/GetServerVersion", ReplyAction="http://tempuri.org/IMogamiApiService/GetServerVersionResponse")]
        Kumano.Data.Service.RESPONSE_GETSERVERVERSION GetServerVersion(Kumano.Data.Service.VERSION_SELECTOR versionType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/GetServerVersion", ReplyAction="http://tempuri.org/IMogamiApiService/GetServerVersionResponse")]
        System.Threading.Tasks.Task<Kumano.Data.Service.RESPONSE_GETSERVERVERSION> GetServerVersionAsync(Kumano.Data.Service.VERSION_SELECTOR versionType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/Login", ReplyAction="http://tempuri.org/IMogamiApiService/LoginResponse")]
        void Login();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMogamiApiService/Login", ReplyAction="http://tempuri.org/IMogamiApiService/LoginResponse")]
        System.Threading.Tasks.Task LoginAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMogamiApiService/Logout", ReplyAction="http://tempuri.org/IMogamiApiService/LogoutResponse")]
        void Logout();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMogamiApiService/Logout", ReplyAction="http://tempuri.org/IMogamiApiService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMogamiApiServiceChannel : Kumano.Data.Service.IMogamiApiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MogamiApiServiceClient : System.ServiceModel.ClientBase<Kumano.Data.Service.IMogamiApiService>, Kumano.Data.Service.IMogamiApiService {
        
        public MogamiApiServiceClient() {
        }
        
        public MogamiApiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MogamiApiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MogamiApiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MogamiApiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Kumano.Data.Service.RESPONSE_FINDARTIFACT FindArtifact(Kumano.Data.Service.REQUEST_FINDARTIFACT reqparam) {
            return base.Channel.FindArtifact(reqparam);
        }
        
        public System.Threading.Tasks.Task<Kumano.Data.Service.RESPONSE_FINDARTIFACT> FindArtifactAsync(Kumano.Data.Service.REQUEST_FINDARTIFACT reqparam) {
            return base.Channel.FindArtifactAsync(reqparam);
        }
        
        public Kumano.Data.Service.RESPONSE_GETSERVERVERSION GetServerVersion(Kumano.Data.Service.VERSION_SELECTOR versionType) {
            return base.Channel.GetServerVersion(versionType);
        }
        
        public System.Threading.Tasks.Task<Kumano.Data.Service.RESPONSE_GETSERVERVERSION> GetServerVersionAsync(Kumano.Data.Service.VERSION_SELECTOR versionType) {
            return base.Channel.GetServerVersionAsync(versionType);
        }
        
        public void Login() {
            base.Channel.Login();
        }
        
        public System.Threading.Tasks.Task LoginAsync() {
            return base.Channel.LoginAsync();
        }
        
        public void Logout() {
            base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
    }
}
