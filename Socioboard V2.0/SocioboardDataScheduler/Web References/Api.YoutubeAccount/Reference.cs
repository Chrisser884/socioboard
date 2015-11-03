﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace SocioboardDataScheduler.Api.YoutubeAccount {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="YoutubeAccountSoap", Namespace="http://tempuri.org/")]
    public partial class YoutubeAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetYoutubeAccountDetailsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllYoutubeAccountDetailsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteYoutubeAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public YoutubeAccount() {
            this.Url = global::SocioboardDataScheduler.Properties.Settings.Default.SocioboardDataScheduler_Api_YoutubeAccount_YoutubeAccount;
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
        public event GetYoutubeAccountDetailsByIdCompletedEventHandler GetYoutubeAccountDetailsByIdCompleted;
        
        /// <remarks/>
        public event GetAllYoutubeAccountDetailsByIdCompletedEventHandler GetAllYoutubeAccountDetailsByIdCompleted;
        
        /// <remarks/>
        public event DeleteYoutubeAccountCompletedEventHandler DeleteYoutubeAccountCompleted;
        
        /// <remarks/>
        public event GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventHandler GetAllYoutubeAccountsByUserIdAndGroupIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetYoutubeAccountDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetYoutubeAccountDetailsById(string UserId, string ProfileId) {
            object[] results = this.Invoke("GetYoutubeAccountDetailsById", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetYoutubeAccountDetailsByIdAsync(string UserId, string ProfileId) {
            this.GetYoutubeAccountDetailsByIdAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void GetYoutubeAccountDetailsByIdAsync(string UserId, string ProfileId, object userState) {
            if ((this.GetYoutubeAccountDetailsByIdOperationCompleted == null)) {
                this.GetYoutubeAccountDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetYoutubeAccountDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetYoutubeAccountDetailsById", new object[] {
                        UserId,
                        ProfileId}, this.GetYoutubeAccountDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetYoutubeAccountDetailsByIdOperationCompleted(object arg) {
            if ((this.GetYoutubeAccountDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetYoutubeAccountDetailsByIdCompleted(this, new GetYoutubeAccountDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllYoutubeAccountDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllYoutubeAccountDetailsById(string UserId) {
            object[] results = this.Invoke("GetAllYoutubeAccountDetailsById", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllYoutubeAccountDetailsByIdAsync(string UserId) {
            this.GetAllYoutubeAccountDetailsByIdAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetAllYoutubeAccountDetailsByIdAsync(string UserId, object userState) {
            if ((this.GetAllYoutubeAccountDetailsByIdOperationCompleted == null)) {
                this.GetAllYoutubeAccountDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllYoutubeAccountDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetAllYoutubeAccountDetailsById", new object[] {
                        UserId}, this.GetAllYoutubeAccountDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetAllYoutubeAccountDetailsByIdOperationCompleted(object arg) {
            if ((this.GetAllYoutubeAccountDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllYoutubeAccountDetailsByIdCompleted(this, new GetAllYoutubeAccountDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteYoutubeAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteYoutubeAccount(string UserId, string ProfileId, string GroupId) {
            object[] results = this.Invoke("DeleteYoutubeAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteYoutubeAccountAsync(string UserId, string ProfileId, string GroupId) {
            this.DeleteYoutubeAccountAsync(UserId, ProfileId, GroupId, null);
        }
        
        /// <remarks/>
        public void DeleteYoutubeAccountAsync(string UserId, string ProfileId, string GroupId, object userState) {
            if ((this.DeleteYoutubeAccountOperationCompleted == null)) {
                this.DeleteYoutubeAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteYoutubeAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteYoutubeAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId}, this.DeleteYoutubeAccountOperationCompleted, userState);
        }
        
        private void OnDeleteYoutubeAccountOperationCompleted(object arg) {
            if ((this.DeleteYoutubeAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteYoutubeAccountCompleted(this, new DeleteYoutubeAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllYoutubeAccountsByUserIdAndGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllYoutubeAccountsByUserIdAndGroupId(string userid, string groupid) {
            object[] results = this.Invoke("GetAllYoutubeAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllYoutubeAccountsByUserIdAndGroupIdAsync(string userid, string groupid) {
            this.GetAllYoutubeAccountsByUserIdAndGroupIdAsync(userid, groupid, null);
        }
        
        /// <remarks/>
        public void GetAllYoutubeAccountsByUserIdAndGroupIdAsync(string userid, string groupid, object userState) {
            if ((this.GetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted == null)) {
                this.GetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetAllYoutubeAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid}, this.GetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted, userState);
        }
        
        private void OnGetAllYoutubeAccountsByUserIdAndGroupIdOperationCompleted(object arg) {
            if ((this.GetAllYoutubeAccountsByUserIdAndGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllYoutubeAccountsByUserIdAndGroupIdCompleted(this, new GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetYoutubeAccountDetailsByIdCompletedEventHandler(object sender, GetYoutubeAccountDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetYoutubeAccountDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetYoutubeAccountDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllYoutubeAccountDetailsByIdCompletedEventHandler(object sender, GetAllYoutubeAccountDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllYoutubeAccountDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllYoutubeAccountDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteYoutubeAccountCompletedEventHandler(object sender, DeleteYoutubeAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteYoutubeAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteYoutubeAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventHandler(object sender, GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllYoutubeAccountsByUserIdAndGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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