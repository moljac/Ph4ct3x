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
namespace HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR.Forecasts.Croatia.Nautical {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Prognoza_jadran {
        
        private string copyrightField;
        
        private string naslovField;
        
        private Prognoza_jadranUpozorenje[] upozorenjeField;
        
        private Prognoza_jadranStanje[] stanjeField;
        
        private Prognoza_jadranPrognoza_naslov[] prognoza_naslovField;
        
        private Prognoza_jadranPrognoza_tekst[] prognoza_tekstField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("Upozorenje", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Prognoza_jadranUpozorenje[] Upozorenje {
            get {
                return this.upozorenjeField;
            }
            set {
                this.upozorenjeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Stanje", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Prognoza_jadranStanje[] Stanje {
            get {
                return this.stanjeField;
            }
            set {
                this.stanjeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_naslov", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Prognoza_jadranPrognoza_naslov[] Prognoza_naslov {
            get {
                return this.prognoza_naslovField;
            }
            set {
                this.prognoza_naslovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_tekst", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Prognoza_jadranPrognoza_tekst[] Prognoza_tekst {
            get {
                return this.prognoza_tekstField;
            }
            set {
                this.prognoza_tekstField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_jadranUpozorenje {
        
        private string upozorenje_naslovField;
        
        private string upozorenje_tekstField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Upozorenje_naslov {
            get {
                return this.upozorenje_naslovField;
            }
            set {
                this.upozorenje_naslovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Upozorenje_tekst {
            get {
                return this.upozorenje_tekstField;
            }
            set {
                this.upozorenje_tekstField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_jadranStanje {
        
        private string stanje_naslovField;
        
        private string stanje_tekstField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stanje_naslov {
            get {
                return this.stanje_naslovField;
            }
            set {
                this.stanje_naslovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Stanje_tekst {
            get {
                return this.stanje_tekstField;
            }
            set {
                this.stanje_tekstField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class Prognoza_jadranPrognoza_naslov {
        
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
    public partial class Prognoza_jadranPrognoza_tekst {
        
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
        
        private Prognoza_jadran[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prognoza_jadran")]
        public Prognoza_jadran[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
