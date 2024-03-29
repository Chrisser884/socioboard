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

namespace Socioboard.Api.SocialProfile {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SocialProfileSoap", Namespace="http://tempuri.org/")]
    public partial class SocialProfile : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddSocialProfileOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteProfileByProfileIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteProfileByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSocialProfileByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback SocialProfileByProfilTypeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllSocialProfilesOfUserCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllSocialProfilesOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllSocialProfilesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SocialProfile() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_SocialProfile_SocialProfile;
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
        public event AddSocialProfileCompletedEventHandler AddSocialProfileCompleted;
        
        /// <remarks/>
        public event DeleteProfileByProfileIdCompletedEventHandler DeleteProfileByProfileIdCompleted;
        
        /// <remarks/>
        public event DeleteProfileByUserIdCompletedEventHandler DeleteProfileByUserIdCompleted;
        
        /// <remarks/>
        public event GetSocialProfileByUserIdCompletedEventHandler GetSocialProfileByUserIdCompleted;
        
        /// <remarks/>
        public event SocialProfileByProfilTypeCompletedEventHandler SocialProfileByProfilTypeCompleted;
        
        /// <remarks/>
        public event GetAllSocialProfilesOfUserCountCompletedEventHandler GetAllSocialProfilesOfUserCountCompleted;
        
        /// <remarks/>
        public event GetAllSocialProfilesOfUserCompletedEventHandler GetAllSocialProfilesOfUserCompleted;
        
        /// <remarks/>
        public event GetAllSocialProfilesCompletedEventHandler GetAllSocialProfilesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddSocialProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddSocialProfile(string UserId, string ProfileId, string ProfileType, string ProfileStatus) {
            object[] results = this.Invoke("AddSocialProfile", new object[] {
                        UserId,
                        ProfileId,
                        ProfileType,
                        ProfileStatus});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddSocialProfileAsync(string UserId, string ProfileId, string ProfileType, string ProfileStatus) {
            this.AddSocialProfileAsync(UserId, ProfileId, ProfileType, ProfileStatus, null);
        }
        
        /// <remarks/>
        public void AddSocialProfileAsync(string UserId, string ProfileId, string ProfileType, string ProfileStatus, object userState) {
            if ((this.AddSocialProfileOperationCompleted == null)) {
                this.AddSocialProfileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSocialProfileOperationCompleted);
            }
            this.InvokeAsync("AddSocialProfile", new object[] {
                        UserId,
                        ProfileId,
                        ProfileType,
                        ProfileStatus}, this.AddSocialProfileOperationCompleted, userState);
        }
        
        private void OnAddSocialProfileOperationCompleted(object arg) {
            if ((this.AddSocialProfileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSocialProfileCompleted(this, new AddSocialProfileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteProfileByProfileId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteProfileByProfileId(string UserId, string ProfileId) {
            object[] results = this.Invoke("DeleteProfileByProfileId", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteProfileByProfileIdAsync(string UserId, string ProfileId) {
            this.DeleteProfileByProfileIdAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void DeleteProfileByProfileIdAsync(string UserId, string ProfileId, object userState) {
            if ((this.DeleteProfileByProfileIdOperationCompleted == null)) {
                this.DeleteProfileByProfileIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteProfileByProfileIdOperationCompleted);
            }
            this.InvokeAsync("DeleteProfileByProfileId", new object[] {
                        UserId,
                        ProfileId}, this.DeleteProfileByProfileIdOperationCompleted, userState);
        }
        
        private void OnDeleteProfileByProfileIdOperationCompleted(object arg) {
            if ((this.DeleteProfileByProfileIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteProfileByProfileIdCompleted(this, new DeleteProfileByProfileIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteProfileByUserId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteProfileByUserId(string UserId) {
            object[] results = this.Invoke("DeleteProfileByUserId", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteProfileByUserIdAsync(string UserId) {
            this.DeleteProfileByUserIdAsync(UserId, null);
        }
        
        /// <remarks/>
        public void DeleteProfileByUserIdAsync(string UserId, object userState) {
            if ((this.DeleteProfileByUserIdOperationCompleted == null)) {
                this.DeleteProfileByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteProfileByUserIdOperationCompleted);
            }
            this.InvokeAsync("DeleteProfileByUserId", new object[] {
                        UserId}, this.DeleteProfileByUserIdOperationCompleted, userState);
        }
        
        private void OnDeleteProfileByUserIdOperationCompleted(object arg) {
            if ((this.DeleteProfileByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteProfileByUserIdCompleted(this, new DeleteProfileByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSocialProfileByUserId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSocialProfileByUserId(string UserId) {
            object[] results = this.Invoke("GetSocialProfileByUserId", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSocialProfileByUserIdAsync(string UserId) {
            this.GetSocialProfileByUserIdAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetSocialProfileByUserIdAsync(string UserId, object userState) {
            if ((this.GetSocialProfileByUserIdOperationCompleted == null)) {
                this.GetSocialProfileByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSocialProfileByUserIdOperationCompleted);
            }
            this.InvokeAsync("GetSocialProfileByUserId", new object[] {
                        UserId}, this.GetSocialProfileByUserIdOperationCompleted, userState);
        }
        
        private void OnGetSocialProfileByUserIdOperationCompleted(object arg) {
            if ((this.GetSocialProfileByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSocialProfileByUserIdCompleted(this, new GetSocialProfileByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SocialProfileByProfilType", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SocialProfileByProfilType(string Profiletype) {
            object[] results = this.Invoke("SocialProfileByProfilType", new object[] {
                        Profiletype});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SocialProfileByProfilTypeAsync(string Profiletype) {
            this.SocialProfileByProfilTypeAsync(Profiletype, null);
        }
        
        /// <remarks/>
        public void SocialProfileByProfilTypeAsync(string Profiletype, object userState) {
            if ((this.SocialProfileByProfilTypeOperationCompleted == null)) {
                this.SocialProfileByProfilTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSocialProfileByProfilTypeOperationCompleted);
            }
            this.InvokeAsync("SocialProfileByProfilType", new object[] {
                        Profiletype}, this.SocialProfileByProfilTypeOperationCompleted, userState);
        }
        
        private void OnSocialProfileByProfilTypeOperationCompleted(object arg) {
            if ((this.SocialProfileByProfilTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SocialProfileByProfilTypeCompleted(this, new SocialProfileByProfilTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllSocialProfilesOfUserCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllSocialProfilesOfUserCount(string UserId) {
            object[] results = this.Invoke("GetAllSocialProfilesOfUserCount", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesOfUserCountAsync(string UserId) {
            this.GetAllSocialProfilesOfUserCountAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesOfUserCountAsync(string UserId, object userState) {
            if ((this.GetAllSocialProfilesOfUserCountOperationCompleted == null)) {
                this.GetAllSocialProfilesOfUserCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllSocialProfilesOfUserCountOperationCompleted);
            }
            this.InvokeAsync("GetAllSocialProfilesOfUserCount", new object[] {
                        UserId}, this.GetAllSocialProfilesOfUserCountOperationCompleted, userState);
        }
        
        private void OnGetAllSocialProfilesOfUserCountOperationCompleted(object arg) {
            if ((this.GetAllSocialProfilesOfUserCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllSocialProfilesOfUserCountCompleted(this, new GetAllSocialProfilesOfUserCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllSocialProfilesOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllSocialProfilesOfUser(string UserId) {
            object[] results = this.Invoke("GetAllSocialProfilesOfUser", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesOfUserAsync(string UserId) {
            this.GetAllSocialProfilesOfUserAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesOfUserAsync(string UserId, object userState) {
            if ((this.GetAllSocialProfilesOfUserOperationCompleted == null)) {
                this.GetAllSocialProfilesOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllSocialProfilesOfUserOperationCompleted);
            }
            this.InvokeAsync("GetAllSocialProfilesOfUser", new object[] {
                        UserId}, this.GetAllSocialProfilesOfUserOperationCompleted, userState);
        }
        
        private void OnGetAllSocialProfilesOfUserOperationCompleted(object arg) {
            if ((this.GetAllSocialProfilesOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllSocialProfilesOfUserCompleted(this, new GetAllSocialProfilesOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllSocialProfiles", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllSocialProfiles() {
            object[] results = this.Invoke("GetAllSocialProfiles", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesAsync() {
            this.GetAllSocialProfilesAsync(null);
        }
        
        /// <remarks/>
        public void GetAllSocialProfilesAsync(object userState) {
            if ((this.GetAllSocialProfilesOperationCompleted == null)) {
                this.GetAllSocialProfilesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllSocialProfilesOperationCompleted);
            }
            this.InvokeAsync("GetAllSocialProfiles", new object[0], this.GetAllSocialProfilesOperationCompleted, userState);
        }
        
        private void OnGetAllSocialProfilesOperationCompleted(object arg) {
            if ((this.GetAllSocialProfilesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllSocialProfilesCompleted(this, new GetAllSocialProfilesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void AddSocialProfileCompletedEventHandler(object sender, AddSocialProfileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddSocialProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddSocialProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteProfileByProfileIdCompletedEventHandler(object sender, DeleteProfileByProfileIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteProfileByProfileIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteProfileByProfileIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteProfileByUserIdCompletedEventHandler(object sender, DeleteProfileByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteProfileByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteProfileByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetSocialProfileByUserIdCompletedEventHandler(object sender, GetSocialProfileByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSocialProfileByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSocialProfileByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SocialProfileByProfilTypeCompletedEventHandler(object sender, SocialProfileByProfilTypeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SocialProfileByProfilTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SocialProfileByProfilTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllSocialProfilesOfUserCountCompletedEventHandler(object sender, GetAllSocialProfilesOfUserCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllSocialProfilesOfUserCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllSocialProfilesOfUserCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllSocialProfilesOfUserCompletedEventHandler(object sender, GetAllSocialProfilesOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllSocialProfilesOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllSocialProfilesOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetAllSocialProfilesCompletedEventHandler(object sender, GetAllSocialProfilesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllSocialProfilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllSocialProfilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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