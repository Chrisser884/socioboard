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

namespace Socioboard.Api.AdminPackageDetails {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="AdminPackageDetailsSoap", Namespace="http://tempuri.org/")]
    public partial class AdminPackageDetails : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddPackageOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllPackageOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdatePackageOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPackageDetailsByIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AdminPackageDetails() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_AdminPackageDetails_AdminPackageDetails;
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
        public event AddPackageCompletedEventHandler AddPackageCompleted;
        
        /// <remarks/>
        public event GetAllPackageCompletedEventHandler GetAllPackageCompleted;
        
        /// <remarks/>
        public event UpdatePackageCompletedEventHandler UpdatePackageCompleted;
        
        /// <remarks/>
        public event GetPackageDetailsByIdCompletedEventHandler GetPackageDetailsByIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddPackage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddPackage(string ObjPackage) {
            object[] results = this.Invoke("AddPackage", new object[] {
                        ObjPackage});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddPackageAsync(string ObjPackage) {
            this.AddPackageAsync(ObjPackage, null);
        }
        
        /// <remarks/>
        public void AddPackageAsync(string ObjPackage, object userState) {
            if ((this.AddPackageOperationCompleted == null)) {
                this.AddPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddPackageOperationCompleted);
            }
            this.InvokeAsync("AddPackage", new object[] {
                        ObjPackage}, this.AddPackageOperationCompleted, userState);
        }
        
        private void OnAddPackageOperationCompleted(object arg) {
            if ((this.AddPackageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddPackageCompleted(this, new AddPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllPackage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllPackage() {
            object[] results = this.Invoke("GetAllPackage", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllPackageAsync() {
            this.GetAllPackageAsync(null);
        }
        
        /// <remarks/>
        public void GetAllPackageAsync(object userState) {
            if ((this.GetAllPackageOperationCompleted == null)) {
                this.GetAllPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllPackageOperationCompleted);
            }
            this.InvokeAsync("GetAllPackage", new object[0], this.GetAllPackageOperationCompleted, userState);
        }
        
        private void OnGetAllPackageOperationCompleted(object arg) {
            if ((this.GetAllPackageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllPackageCompleted(this, new GetAllPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdatePackage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdatePackage(string ObjPackage) {
            object[] results = this.Invoke("UpdatePackage", new object[] {
                        ObjPackage});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdatePackageAsync(string ObjPackage) {
            this.UpdatePackageAsync(ObjPackage, null);
        }
        
        /// <remarks/>
        public void UpdatePackageAsync(string ObjPackage, object userState) {
            if ((this.UpdatePackageOperationCompleted == null)) {
                this.UpdatePackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdatePackageOperationCompleted);
            }
            this.InvokeAsync("UpdatePackage", new object[] {
                        ObjPackage}, this.UpdatePackageOperationCompleted, userState);
        }
        
        private void OnUpdatePackageOperationCompleted(object arg) {
            if ((this.UpdatePackageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdatePackageCompleted(this, new UpdatePackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPackageDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPackageDetailsById(string PackageId) {
            object[] results = this.Invoke("GetPackageDetailsById", new object[] {
                        PackageId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPackageDetailsByIdAsync(string PackageId) {
            this.GetPackageDetailsByIdAsync(PackageId, null);
        }
        
        /// <remarks/>
        public void GetPackageDetailsByIdAsync(string PackageId, object userState) {
            if ((this.GetPackageDetailsByIdOperationCompleted == null)) {
                this.GetPackageDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPackageDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetPackageDetailsById", new object[] {
                        PackageId}, this.GetPackageDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetPackageDetailsByIdOperationCompleted(object arg) {
            if ((this.GetPackageDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPackageDetailsByIdCompleted(this, new GetPackageDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void AddPackageCompletedEventHandler(object sender, AddPackageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllPackageCompletedEventHandler(object sender, GetAllPackageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdatePackageCompletedEventHandler(object sender, UpdatePackageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdatePackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdatePackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetPackageDetailsByIdCompletedEventHandler(object sender, GetPackageDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPackageDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPackageDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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