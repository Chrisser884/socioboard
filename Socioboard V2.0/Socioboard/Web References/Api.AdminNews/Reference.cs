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

namespace Socioboard.Api.AdminNews {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="AdminNewsSoap", Namespace="http://tempuri.org/")]
    public partial class AdminNews : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllNewsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateNewsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetNewsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AdminNews() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_AdminNews_AdminNews;
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
        public event GetAllNewsCompletedEventHandler GetAllNewsCompleted;
        
        /// <remarks/>
        public event UpdateNewsCompletedEventHandler UpdateNewsCompleted;
        
        /// <remarks/>
        public event GetNewsByIdCompletedEventHandler GetNewsByIdCompleted;
        
        /// <remarks/>
        public event AddNewsCompletedEventHandler AddNewsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllNews", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllNews() {
            object[] results = this.Invoke("GetAllNews", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllNewsAsync() {
            this.GetAllNewsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllNewsAsync(object userState) {
            if ((this.GetAllNewsOperationCompleted == null)) {
                this.GetAllNewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllNewsOperationCompleted);
            }
            this.InvokeAsync("GetAllNews", new object[0], this.GetAllNewsOperationCompleted, userState);
        }
        
        private void OnGetAllNewsOperationCompleted(object arg) {
            if ((this.GetAllNewsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllNewsCompleted(this, new GetAllNewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateNews", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateNews(string ObjPackage) {
            object[] results = this.Invoke("UpdateNews", new object[] {
                        ObjPackage});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateNewsAsync(string ObjPackage) {
            this.UpdateNewsAsync(ObjPackage, null);
        }
        
        /// <remarks/>
        public void UpdateNewsAsync(string ObjPackage, object userState) {
            if ((this.UpdateNewsOperationCompleted == null)) {
                this.UpdateNewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateNewsOperationCompleted);
            }
            this.InvokeAsync("UpdateNews", new object[] {
                        ObjPackage}, this.UpdateNewsOperationCompleted, userState);
        }
        
        private void OnUpdateNewsOperationCompleted(object arg) {
            if ((this.UpdateNewsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateNewsCompleted(this, new UpdateNewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNewsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetNewsById(string NewsId) {
            object[] results = this.Invoke("GetNewsById", new object[] {
                        NewsId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetNewsByIdAsync(string NewsId) {
            this.GetNewsByIdAsync(NewsId, null);
        }
        
        /// <remarks/>
        public void GetNewsByIdAsync(string NewsId, object userState) {
            if ((this.GetNewsByIdOperationCompleted == null)) {
                this.GetNewsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetNewsByIdOperationCompleted);
            }
            this.InvokeAsync("GetNewsById", new object[] {
                        NewsId}, this.GetNewsByIdOperationCompleted, userState);
        }
        
        private void OnGetNewsByIdOperationCompleted(object arg) {
            if ((this.GetNewsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetNewsByIdCompleted(this, new GetNewsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNews", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddNews(string ObjPackage, string News) {
            object[] results = this.Invoke("AddNews", new object[] {
                        ObjPackage,
                        News});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewsAsync(string ObjPackage, string News) {
            this.AddNewsAsync(ObjPackage, News, null);
        }
        
        /// <remarks/>
        public void AddNewsAsync(string ObjPackage, string News, object userState) {
            if ((this.AddNewsOperationCompleted == null)) {
                this.AddNewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewsOperationCompleted);
            }
            this.InvokeAsync("AddNews", new object[] {
                        ObjPackage,
                        News}, this.AddNewsOperationCompleted, userState);
        }
        
        private void OnAddNewsOperationCompleted(object arg) {
            if ((this.AddNewsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewsCompleted(this, new AddNewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetAllNewsCompletedEventHandler(object sender, GetAllNewsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateNewsCompletedEventHandler(object sender, UpdateNewsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetNewsByIdCompletedEventHandler(object sender, GetNewsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetNewsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetNewsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void AddNewsCompletedEventHandler(object sender, AddNewsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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