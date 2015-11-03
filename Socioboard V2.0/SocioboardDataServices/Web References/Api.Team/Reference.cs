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

namespace SocioboardDataServices.Api.Team {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TeamSoap", Namespace="http://tempuri.org/")]
    public partial class Team : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddTeamOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamByGroupIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamByStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateTeamOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateTeambyteamidOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllTeamsOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllGroupMembersofTeamOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Team() {
            this.Url = global::SocioboardDataServices.Properties.Settings.Default.SocioboardDataServices_Api_Team_Team;
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
        public event AddTeamCompletedEventHandler AddTeamCompleted;
        
        /// <remarks/>
        public event GetTeamByIdCompletedEventHandler GetTeamByIdCompleted;
        
        /// <remarks/>
        public event GetTeamByGroupIdCompletedEventHandler GetTeamByGroupIdCompleted;
        
        /// <remarks/>
        public event GetTeamByStatusCompletedEventHandler GetTeamByStatusCompleted;
        
        /// <remarks/>
        public event UpdateTeamCompletedEventHandler UpdateTeamCompleted;
        
        /// <remarks/>
        public event UpdateTeambyteamidCompletedEventHandler UpdateTeambyteamidCompleted;
        
        /// <remarks/>
        public event GetTeamByUserIdCompletedEventHandler GetTeamByUserIdCompleted;
        
        /// <remarks/>
        public event getAllTeamsOfUserCompletedEventHandler getAllTeamsOfUserCompleted;
        
        /// <remarks/>
        public event getAllGroupMembersofTeamCompletedEventHandler getAllGroupMembersofTeamCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTeam", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddTeam(string UserId, string InviteStatus, string FirstName, string LastName, string EmailId, string AccessLevel, string GroupId, string useremail, string username) {
            object[] results = this.Invoke("AddTeam", new object[] {
                        UserId,
                        InviteStatus,
                        FirstName,
                        LastName,
                        EmailId,
                        AccessLevel,
                        GroupId,
                        useremail,
                        username});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddTeamAsync(string UserId, string InviteStatus, string FirstName, string LastName, string EmailId, string AccessLevel, string GroupId, string useremail, string username) {
            this.AddTeamAsync(UserId, InviteStatus, FirstName, LastName, EmailId, AccessLevel, GroupId, useremail, username, null);
        }
        
        /// <remarks/>
        public void AddTeamAsync(string UserId, string InviteStatus, string FirstName, string LastName, string EmailId, string AccessLevel, string GroupId, string useremail, string username, object userState) {
            if ((this.AddTeamOperationCompleted == null)) {
                this.AddTeamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTeamOperationCompleted);
            }
            this.InvokeAsync("AddTeam", new object[] {
                        UserId,
                        InviteStatus,
                        FirstName,
                        LastName,
                        EmailId,
                        AccessLevel,
                        GroupId,
                        useremail,
                        username}, this.AddTeamOperationCompleted, userState);
        }
        
        private void OnAddTeamOperationCompleted(object arg) {
            if ((this.AddTeamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTeamCompleted(this, new AddTeamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamById(string Id) {
            object[] results = this.Invoke("GetTeamById", new object[] {
                        Id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamByIdAsync(string Id) {
            this.GetTeamByIdAsync(Id, null);
        }
        
        /// <remarks/>
        public void GetTeamByIdAsync(string Id, object userState) {
            if ((this.GetTeamByIdOperationCompleted == null)) {
                this.GetTeamByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamByIdOperationCompleted);
            }
            this.InvokeAsync("GetTeamById", new object[] {
                        Id}, this.GetTeamByIdOperationCompleted, userState);
        }
        
        private void OnGetTeamByIdOperationCompleted(object arg) {
            if ((this.GetTeamByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamByIdCompleted(this, new GetTeamByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamByGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamByGroupId(string GroupId) {
            object[] results = this.Invoke("GetTeamByGroupId", new object[] {
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamByGroupIdAsync(string GroupId) {
            this.GetTeamByGroupIdAsync(GroupId, null);
        }
        
        /// <remarks/>
        public void GetTeamByGroupIdAsync(string GroupId, object userState) {
            if ((this.GetTeamByGroupIdOperationCompleted == null)) {
                this.GetTeamByGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamByGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetTeamByGroupId", new object[] {
                        GroupId}, this.GetTeamByGroupIdOperationCompleted, userState);
        }
        
        private void OnGetTeamByGroupIdOperationCompleted(object arg) {
            if ((this.GetTeamByGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamByGroupIdCompleted(this, new GetTeamByGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamByStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamByStatus(string GroupId, string userid, string status) {
            object[] results = this.Invoke("GetTeamByStatus", new object[] {
                        GroupId,
                        userid,
                        status});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamByStatusAsync(string GroupId, string userid, string status) {
            this.GetTeamByStatusAsync(GroupId, userid, status, null);
        }
        
        /// <remarks/>
        public void GetTeamByStatusAsync(string GroupId, string userid, string status, object userState) {
            if ((this.GetTeamByStatusOperationCompleted == null)) {
                this.GetTeamByStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamByStatusOperationCompleted);
            }
            this.InvokeAsync("GetTeamByStatus", new object[] {
                        GroupId,
                        userid,
                        status}, this.GetTeamByStatusOperationCompleted, userState);
        }
        
        private void OnGetTeamByStatusOperationCompleted(object arg) {
            if ((this.GetTeamByStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamByStatusCompleted(this, new GetTeamByStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateTeam", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateTeam(string userid, string teamid, string UserName) {
            object[] results = this.Invoke("UpdateTeam", new object[] {
                        userid,
                        teamid,
                        UserName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateTeamAsync(string userid, string teamid, string UserName) {
            this.UpdateTeamAsync(userid, teamid, UserName, null);
        }
        
        /// <remarks/>
        public void UpdateTeamAsync(string userid, string teamid, string UserName, object userState) {
            if ((this.UpdateTeamOperationCompleted == null)) {
                this.UpdateTeamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTeamOperationCompleted);
            }
            this.InvokeAsync("UpdateTeam", new object[] {
                        userid,
                        teamid,
                        UserName}, this.UpdateTeamOperationCompleted, userState);
        }
        
        private void OnUpdateTeamOperationCompleted(object arg) {
            if ((this.UpdateTeamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTeamCompleted(this, new UpdateTeamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateTeambyteamid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateTeambyteamid(string teamid) {
            object[] results = this.Invoke("UpdateTeambyteamid", new object[] {
                        teamid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateTeambyteamidAsync(string teamid) {
            this.UpdateTeambyteamidAsync(teamid, null);
        }
        
        /// <remarks/>
        public void UpdateTeambyteamidAsync(string teamid, object userState) {
            if ((this.UpdateTeambyteamidOperationCompleted == null)) {
                this.UpdateTeambyteamidOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTeambyteamidOperationCompleted);
            }
            this.InvokeAsync("UpdateTeambyteamid", new object[] {
                        teamid}, this.UpdateTeambyteamidOperationCompleted, userState);
        }
        
        private void OnUpdateTeambyteamidOperationCompleted(object arg) {
            if ((this.UpdateTeambyteamidCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTeambyteamidCompleted(this, new UpdateTeambyteamidCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamByUserId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamByUserId(string userid) {
            object[] results = this.Invoke("GetTeamByUserId", new object[] {
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamByUserIdAsync(string userid) {
            this.GetTeamByUserIdAsync(userid, null);
        }
        
        /// <remarks/>
        public void GetTeamByUserIdAsync(string userid, object userState) {
            if ((this.GetTeamByUserIdOperationCompleted == null)) {
                this.GetTeamByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamByUserIdOperationCompleted);
            }
            this.InvokeAsync("GetTeamByUserId", new object[] {
                        userid}, this.GetTeamByUserIdOperationCompleted, userState);
        }
        
        private void OnGetTeamByUserIdOperationCompleted(object arg) {
            if ((this.GetTeamByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamByUserIdCompleted(this, new GetTeamByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllTeamsOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllTeamsOfUser(string UserId, string groupId, string emailId) {
            object[] results = this.Invoke("getAllTeamsOfUser", new object[] {
                        UserId,
                        groupId,
                        emailId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllTeamsOfUserAsync(string UserId, string groupId, string emailId) {
            this.getAllTeamsOfUserAsync(UserId, groupId, emailId, null);
        }
        
        /// <remarks/>
        public void getAllTeamsOfUserAsync(string UserId, string groupId, string emailId, object userState) {
            if ((this.getAllTeamsOfUserOperationCompleted == null)) {
                this.getAllTeamsOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllTeamsOfUserOperationCompleted);
            }
            this.InvokeAsync("getAllTeamsOfUser", new object[] {
                        UserId,
                        groupId,
                        emailId}, this.getAllTeamsOfUserOperationCompleted, userState);
        }
        
        private void OngetAllTeamsOfUserOperationCompleted(object arg) {
            if ((this.getAllTeamsOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllTeamsOfUserCompleted(this, new getAllTeamsOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllGroupMembersofTeam", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllGroupMembersofTeam() {
            object[] results = this.Invoke("getAllGroupMembersofTeam", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllGroupMembersofTeamAsync() {
            this.getAllGroupMembersofTeamAsync(null);
        }
        
        /// <remarks/>
        public void getAllGroupMembersofTeamAsync(object userState) {
            if ((this.getAllGroupMembersofTeamOperationCompleted == null)) {
                this.getAllGroupMembersofTeamOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllGroupMembersofTeamOperationCompleted);
            }
            this.InvokeAsync("getAllGroupMembersofTeam", new object[0], this.getAllGroupMembersofTeamOperationCompleted, userState);
        }
        
        private void OngetAllGroupMembersofTeamOperationCompleted(object arg) {
            if ((this.getAllGroupMembersofTeamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllGroupMembersofTeamCompleted(this, new getAllGroupMembersofTeamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void AddTeamCompletedEventHandler(object sender, AddTeamCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTeamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTeamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamByIdCompletedEventHandler(object sender, GetTeamByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamByGroupIdCompletedEventHandler(object sender, GetTeamByGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamByGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamByGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamByStatusCompletedEventHandler(object sender, GetTeamByStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamByStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamByStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateTeamCompletedEventHandler(object sender, UpdateTeamCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateTeamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateTeamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateTeambyteamidCompletedEventHandler(object sender, UpdateTeambyteamidCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateTeambyteamidCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateTeambyteamidCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamByUserIdCompletedEventHandler(object sender, GetTeamByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getAllTeamsOfUserCompletedEventHandler(object sender, getAllTeamsOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllTeamsOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllTeamsOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getAllGroupMembersofTeamCompletedEventHandler(object sender, getAllGroupMembersofTeamCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllGroupMembersofTeamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllGroupMembersofTeamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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