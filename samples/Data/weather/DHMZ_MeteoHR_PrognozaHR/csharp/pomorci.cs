//------------------------------------------------------------------------------
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
namespace HolisticWare.Ph4ct3x.Utilities.Weather.Providers.DHMZ_MeteoHR_PrognozaHR.Forecasts.Croatia.Seamen {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Prognoza_pomorci {
        
        private string copyrightField;
        
        private string naslovField;
        
        private string upozorenjeField;
        
        private string stanjeField;
        
        private string prognoza_zaglavljeField;
        
        private Prognoza_pomorciPrognoza_naslov[] prognoza_naslovField;
        
        private Prognoza_pomorciPrognoza_tekst[] prognoza_tekstField;
        
        private Prognoza_pomorciTablica[] tablicaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Copyright {
            get {
                return this.copyrightField;
            }
            set {
                this.copyrightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Naslov {
            get {
                return this.naslovField;
            }
            set {
                this.naslovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Upozorenje {
            get {
                return this.upozorenjeField;
            }
            set {
                this.upozorenjeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stanje {
            get {
                return this.stanjeField;
            }
            set {
                this.stanjeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Prognoza_zaglavlje {
            get {
                return this.prognoza_zaglavljeField;
            }
            set {
                this.prognoza_zaglavljeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_naslov", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Prognoza_pomorciPrognoza_naslov[] Prognoza_naslov {
            get {
                return this.prognoza_naslovField;
            }
            set {
                this.prognoza_naslovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_tekst", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Prognoza_pomorciPrognoza_tekst[] Prognoza_tekst {
            get {
                return this.prognoza_tekstField;
            }
            set {
                this.prognoza_tekstField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tablica", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Prognoza_pomorciTablica[] Tablica {
            get {
                return this.tablicaField;
            }
            set {
                this.tablicaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_pomorciPrognoza_naslov {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_pomorciPrognoza_tekst {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_pomorciTablica {
        
        private string tablica_zaglavljeField;
        
        private Prognoza_pomorciTablicaPodaci[] podaciField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Tablica_zaglavlje {
            get {
                return this.tablica_zaglavljeField;
            }
            set {
                this.tablica_zaglavljeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Podaci", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Prognoza_pomorciTablicaPodaci[] Podaci {
            get {
                return this.podaciField;
            }
            set {
                this.podaciField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_pomorciTablicaPodaci {
        
        private string postajaField;
        
        private Prognoza_pomorciTablicaPodaciTermin[] terminField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Postaja {
            get {
                return this.postajaField;
            }
            set {
                this.postajaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Termin", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Prognoza_pomorciTablicaPodaciTermin[] Termin {
            get {
                return this.terminField;
            }
            set {
                this.terminField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_pomorciTablicaPodaciTermin {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class NewDataSet {
        
        private Prognoza_pomorci[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_pomorci")]
        public Prognoza_pomorci[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
