﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WinformWorld.localhost1 {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCityByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCitiesByCountryOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllCountriesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCountryByCodeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::WinformWorld.Properties.Settings.Default.WinformWorld_localhost1_WebService1;
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
        public event GetCityByNameCompletedEventHandler GetCityByNameCompleted;
        
        /// <remarks/>
        public event GetCitiesByCountryCompletedEventHandler GetCitiesByCountryCompleted;
        
        /// <remarks/>
        public event GetAllCountriesCompletedEventHandler GetAllCountriesCompleted;
        
        /// <remarks/>
        public event GetCountryByCodeCompletedEventHandler GetCountryByCodeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCityByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public City GetCityByName(string cityName) {
            object[] results = this.Invoke("GetCityByName", new object[] {
                        cityName});
            return ((City)(results[0]));
        }
        
        /// <remarks/>
        public void GetCityByNameAsync(string cityName) {
            this.GetCityByNameAsync(cityName, null);
        }
        
        /// <remarks/>
        public void GetCityByNameAsync(string cityName, object userState) {
            if ((this.GetCityByNameOperationCompleted == null)) {
                this.GetCityByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCityByNameOperationCompleted);
            }
            this.InvokeAsync("GetCityByName", new object[] {
                        cityName}, this.GetCityByNameOperationCompleted, userState);
        }
        
        private void OnGetCityByNameOperationCompleted(object arg) {
            if ((this.GetCityByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCityByNameCompleted(this, new GetCityByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCitiesByCountry", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public City[] GetCitiesByCountry(string countryCode) {
            object[] results = this.Invoke("GetCitiesByCountry", new object[] {
                        countryCode});
            return ((City[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCitiesByCountryAsync(string countryCode) {
            this.GetCitiesByCountryAsync(countryCode, null);
        }
        
        /// <remarks/>
        public void GetCitiesByCountryAsync(string countryCode, object userState) {
            if ((this.GetCitiesByCountryOperationCompleted == null)) {
                this.GetCitiesByCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCitiesByCountryOperationCompleted);
            }
            this.InvokeAsync("GetCitiesByCountry", new object[] {
                        countryCode}, this.GetCitiesByCountryOperationCompleted, userState);
        }
        
        private void OnGetCitiesByCountryOperationCompleted(object arg) {
            if ((this.GetCitiesByCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCitiesByCountryCompleted(this, new GetCitiesByCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllCountries", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Country[] GetAllCountries() {
            object[] results = this.Invoke("GetAllCountries", new object[0]);
            return ((Country[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllCountriesAsync() {
            this.GetAllCountriesAsync(null);
        }
        
        /// <remarks/>
        public void GetAllCountriesAsync(object userState) {
            if ((this.GetAllCountriesOperationCompleted == null)) {
                this.GetAllCountriesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllCountriesOperationCompleted);
            }
            this.InvokeAsync("GetAllCountries", new object[0], this.GetAllCountriesOperationCompleted, userState);
        }
        
        private void OnGetAllCountriesOperationCompleted(object arg) {
            if ((this.GetAllCountriesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllCountriesCompleted(this, new GetAllCountriesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCountryByCode", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Country GetCountryByCode(string countryCode) {
            object[] results = this.Invoke("GetCountryByCode", new object[] {
                        countryCode});
            return ((Country)(results[0]));
        }
        
        /// <remarks/>
        public void GetCountryByCodeAsync(string countryCode) {
            this.GetCountryByCodeAsync(countryCode, null);
        }
        
        /// <remarks/>
        public void GetCountryByCodeAsync(string countryCode, object userState) {
            if ((this.GetCountryByCodeOperationCompleted == null)) {
                this.GetCountryByCodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCountryByCodeOperationCompleted);
            }
            this.InvokeAsync("GetCountryByCode", new object[] {
                        countryCode}, this.GetCountryByCodeOperationCompleted, userState);
        }
        
        private void OnGetCountryByCodeOperationCompleted(object arg) {
            if ((this.GetCountryByCodeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCountryByCodeCompleted(this, new GetCountryByCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class City {
        
        private int idField;
        
        private string nameField;
        
        private string countryCodeField;
        
        private string districtField;
        
        private int populationField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string CountryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }
        
        /// <remarks/>
        public string District {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
            }
        }
        
        /// <remarks/>
        public int Population {
            get {
                return this.populationField;
            }
            set {
                this.populationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Country {
        
        private string codeField;
        
        private string nameField;
        
        private string continentField;
        
        private string regionField;
        
        private decimal surfaceAreaField;
        
        private System.Nullable<short> indepYearField;
        
        private int populationField;
        
        private System.Nullable<decimal> lifeExpectancyField;
        
        private System.Nullable<decimal> gNPField;
        
        private System.Nullable<decimal> gNPOldField;
        
        private string localNameField;
        
        private string governmentFormField;
        
        private string headOfStateField;
        
        private System.Nullable<int> capitalField;
        
        private string code2Field;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Continent {
            get {
                return this.continentField;
            }
            set {
                this.continentField = value;
            }
        }
        
        /// <remarks/>
        public string Region {
            get {
                return this.regionField;
            }
            set {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        public decimal SurfaceArea {
            get {
                return this.surfaceAreaField;
            }
            set {
                this.surfaceAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<short> IndepYear {
            get {
                return this.indepYearField;
            }
            set {
                this.indepYearField = value;
            }
        }
        
        /// <remarks/>
        public int Population {
            get {
                return this.populationField;
            }
            set {
                this.populationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> LifeExpectancy {
            get {
                return this.lifeExpectancyField;
            }
            set {
                this.lifeExpectancyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> GNP {
            get {
                return this.gNPField;
            }
            set {
                this.gNPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> GNPOld {
            get {
                return this.gNPOldField;
            }
            set {
                this.gNPOldField = value;
            }
        }
        
        /// <remarks/>
        public string LocalName {
            get {
                return this.localNameField;
            }
            set {
                this.localNameField = value;
            }
        }
        
        /// <remarks/>
        public string GovernmentForm {
            get {
                return this.governmentFormField;
            }
            set {
                this.governmentFormField = value;
            }
        }
        
        /// <remarks/>
        public string HeadOfState {
            get {
                return this.headOfStateField;
            }
            set {
                this.headOfStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Capital {
            get {
                return this.capitalField;
            }
            set {
                this.capitalField = value;
            }
        }
        
        /// <remarks/>
        public string Code2 {
            get {
                return this.code2Field;
            }
            set {
                this.code2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetCityByNameCompletedEventHandler(object sender, GetCityByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCityByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCityByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public City Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((City)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetCitiesByCountryCompletedEventHandler(object sender, GetCitiesByCountryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCitiesByCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCitiesByCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public City[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((City[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetAllCountriesCompletedEventHandler(object sender, GetAllCountriesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllCountriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllCountriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Country[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Country[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetCountryByCodeCompletedEventHandler(object sender, GetCountryByCodeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCountryByCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCountryByCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Country Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Country)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591