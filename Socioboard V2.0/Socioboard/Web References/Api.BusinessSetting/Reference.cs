﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
<<<<<<< HEAD
//     Runtime Version:4.0.30319.18408
=======
//     Runtime Version:4.0.30319.18063
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
<<<<<<< HEAD
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
=======
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18063.
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
// 
#pragma warning disable 1591

namespace Socioboard.Api.BusinessSetting {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BusinessSettingSoap", Namespace="http://tempuri.org/")]
    public partial class BusinessSetting : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsNotificationTaskEnableOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddBusinessByUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDetailsofBusinessOwnerOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateBuisnessSettingOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BusinessSetting() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_BusinessSetting_BusinessSetting;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event IsNotificationTaskEnableCompletedEventHandler IsNotificationTaskEnableCompleted;
        
        /// <remarks/>
        public event AddBusinessByUserCompletedEventHandler AddBusinessByUserCompleted;
        
        /// <remarks/>
        public event GetDetailsofBusinessOwnerCompletedEventHandler GetDetailsofBusinessOwnerCompleted;
        
        /// <remarks/>
        public event UpdateBuisnessSettingCompletedEventHandler UpdateBuisnessSettingCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IsNotificationTaskEnable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IsNotificationTaskEnable(System.Guid groupsId) {
            object[] results = this.Invoke("IsNotificationTaskEnable", new object[] {
                        groupsId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void IsNotificationTaskEnableAsync(System.Guid groupsId) {
            this.IsNotificationTaskEnableAsync(groupsId, null);
        }
        
        /// <remarks/>
        public void IsNotificationTaskEnableAsync(System.Guid groupsId, object userState) {
            if ((this.IsNotificationTaskEnableOperationCompleted == null)) {
                this.IsNotificationTaskEnableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsNotificationTaskEnableOperationCompleted);
            }
            this.InvokeAsync("IsNotificationTaskEnable", new object[] {
                        groupsId}, this.IsNotificationTaskEnableOperationCompleted, userState);
        }
        
        private void OnIsNotificationTaskEnableOperationCompleted(object arg) {
            if ((this.IsNotificationTaskEnableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsNotificationTaskEnableCompleted(this, new IsNotificationTaskEnableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddBusinessByUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddBusinessByUser(string ObjBusinessSetting) {
            object[] results = this.Invoke("AddBusinessByUser", new object[] {
                        ObjBusinessSetting});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddBusinessByUserAsync(string ObjBusinessSetting) {
            this.AddBusinessByUserAsync(ObjBusinessSetting, null);
        }
        
        /// <remarks/>
        public void AddBusinessByUserAsync(string ObjBusinessSetting, object userState) {
            if ((this.AddBusinessByUserOperationCompleted == null)) {
                this.AddBusinessByUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddBusinessByUserOperationCompleted);
            }
            this.InvokeAsync("AddBusinessByUser", new object[] {
                        ObjBusinessSetting}, this.AddBusinessByUserOperationCompleted, userState);
        }
        
        private void OnAddBusinessByUserOperationCompleted(object arg) {
            if ((this.AddBusinessByUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddBusinessByUserCompleted(this, new AddBusinessByUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDetailsofBusinessOwner", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDetailsofBusinessOwner(string GroupId) {
            object[] results = this.Invoke("GetDetailsofBusinessOwner", new object[] {
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDetailsofBusinessOwnerAsync(string GroupId) {
            this.GetDetailsofBusinessOwnerAsync(GroupId, null);
        }
        
        /// <remarks/>
        public void GetDetailsofBusinessOwnerAsync(string GroupId, object userState) {
            if ((this.GetDetailsofBusinessOwnerOperationCompleted == null)) {
                this.GetDetailsofBusinessOwnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDetailsofBusinessOwnerOperationCompleted);
            }
            this.InvokeAsync("GetDetailsofBusinessOwner", new object[] {
                        GroupId}, this.GetDetailsofBusinessOwnerOperationCompleted, userState);
        }
        
        private void OnGetDetailsofBusinessOwnerOperationCompleted(object arg) {
            if ((this.GetDetailsofBusinessOwnerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDetailsofBusinessOwnerCompleted(this, new GetDetailsofBusinessOwnerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateBuisnessSetting", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateBuisnessSetting(string ObjBusiNessSetting) {
            object[] results = this.Invoke("UpdateBuisnessSetting", new object[] {
                        ObjBusiNessSetting});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateBuisnessSettingAsync(string ObjBusiNessSetting) {
            this.UpdateBuisnessSettingAsync(ObjBusiNessSetting, null);
        }
        
        /// <remarks/>
        public void UpdateBuisnessSettingAsync(string ObjBusiNessSetting, object userState) {
            if ((this.UpdateBuisnessSettingOperationCompleted == null)) {
                this.UpdateBuisnessSettingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateBuisnessSettingOperationCompleted);
            }
            this.InvokeAsync("UpdateBuisnessSetting", new object[] {
                        ObjBusiNessSetting}, this.UpdateBuisnessSettingOperationCompleted, userState);
        }
        
        private void OnUpdateBuisnessSettingOperationCompleted(object arg) {
            if ((this.UpdateBuisnessSettingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateBuisnessSettingCompleted(this, new UpdateBuisnessSettingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void IsNotificationTaskEnableCompletedEventHandler(object sender, IsNotificationTaskEnableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsNotificationTaskEnableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsNotificationTaskEnableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
<<<<<<< HEAD
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AddBusinessByUserCompletedEventHandler(object sender, AddBusinessByUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddBusinessByUserCompletedEventHandler(object sender, AddBusinessByUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddBusinessByUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddBusinessByUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
<<<<<<< HEAD
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetDetailsofBusinessOwnerCompletedEventHandler(object sender, GetDetailsofBusinessOwnerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetDetailsofBusinessOwnerCompletedEventHandler(object sender, GetDetailsofBusinessOwnerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDetailsofBusinessOwnerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDetailsofBusinessOwnerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
<<<<<<< HEAD
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void UpdateBuisnessSettingCompletedEventHandler(object sender, UpdateBuisnessSettingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
=======
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void UpdateBuisnessSettingCompletedEventHandler(object sender, UpdateBuisnessSettingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateBuisnessSettingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateBuisnessSettingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591