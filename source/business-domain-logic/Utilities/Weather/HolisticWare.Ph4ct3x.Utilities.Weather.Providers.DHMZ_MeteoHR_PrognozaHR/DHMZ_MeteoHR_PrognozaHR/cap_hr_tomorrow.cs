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
//This source code was auto-generated by MonoXSD
//
namespace HolisticWare.Ph4ct3x.Utilities.Weather.Providers.DHMZ_MeteoHR_PrognozaHR.WeatherData.Current.Warnings.CAP.Tomorrow {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:emergency:cap:1.2", IsNullable=false)]
    public partial class alert {
        
        private string identifierField;
        
        private string senderField;
        
        private string sentField;
        
        private string statusField;
        
        private string msgTypeField;
        
        private string scopeField;
        
        private alertInfo[] infoField;
        
        /// <remarks/>
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        public string sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        public string sent {
            get {
                return this.sentField;
            }
            set {
                this.sentField = value;
            }
        }
        
        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string msgType {
            get {
                return this.msgTypeField;
            }
            set {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        public string scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("info")]
        public alertInfo[] info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    public partial class alertInfo {
        
        private string languageField;
        
        private string categoryField;
        
        private string eventField;
        
        private string responseTypeField;
        
        private string urgencyField;
        
        private string severityField;
        
        private string certaintyField;
        
        private string onsetField;
        
        private string expiresField;
        
        private string senderNameField;
        
        private string descriptionField;
        
        private string instructionField;
        
        private alertInfoParameter[] parameterField;
        
        private alertInfoArea[] areaField;
        
        /// <remarks/>
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public string @event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }
        
        /// <remarks/>
        public string responseType {
            get {
                return this.responseTypeField;
            }
            set {
                this.responseTypeField = value;
            }
        }
        
        /// <remarks/>
        public string urgency {
            get {
                return this.urgencyField;
            }
            set {
                this.urgencyField = value;
            }
        }
        
        /// <remarks/>
        public string severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }
        
        /// <remarks/>
        public string certainty {
            get {
                return this.certaintyField;
            }
            set {
                this.certaintyField = value;
            }
        }
        
        /// <remarks/>
        public string onset {
            get {
                return this.onsetField;
            }
            set {
                this.onsetField = value;
            }
        }
        
        /// <remarks/>
        public string expires {
            get {
                return this.expiresField;
            }
            set {
                this.expiresField = value;
            }
        }
        
        /// <remarks/>
        public string senderName {
            get {
                return this.senderNameField;
            }
            set {
                this.senderNameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string instruction {
            get {
                return this.instructionField;
            }
            set {
                this.instructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public alertInfoParameter[] parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("area")]
        public alertInfoArea[] area {
            get {
                return this.areaField;
            }
            set {
                this.areaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    public partial class alertInfoParameter {
        
        private string valueNameField;
        
        private string valueField;
        
        /// <remarks/>
        public string valueName {
            get {
                return this.valueNameField;
            }
            set {
                this.valueNameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    public partial class alertInfoArea {
        
        private string areaDescField;
        
        private alertInfoAreaGeocode[] geocodeField;
        
        /// <remarks/>
        public string areaDesc {
            get {
                return this.areaDescField;
            }
            set {
                this.areaDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geocode")]
        public alertInfoAreaGeocode[] geocode {
            get {
                return this.geocodeField;
            }
            set {
                this.geocodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    public partial class alertInfoAreaGeocode {
        
        private string valueNameField;
        
        private string valueField;
        
        /// <remarks/>
        public string valueName {
            get {
                return this.valueNameField;
            }
            set {
                this.valueNameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:emergency:cap:1.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:emergency:cap:1.2", IsNullable=false)]
    public partial class NewDataSet {
        
        private alert[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alert")]
        public alert[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
