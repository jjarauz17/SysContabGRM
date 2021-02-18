namespace HaciendaGT
{
    
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using static XmlFormatoComun;

    public class XmlFormatoFactura
    {
        [XmlRoot(ElementName = "GTDocumento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]        
        public class GTDocumento
        {
            [XmlElement(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]            
            public SAT SAT { get; set; }
            [XmlAttribute(AttributeName = "ds", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ds { get; set; }
            [XmlAttribute(AttributeName = "dte", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Dte { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string SchemaLocation { get; set; }
        }

        [XmlRoot(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DatosGenerales
        {
            [XmlAttribute(AttributeName = "CodigoMoneda")]
            public string CodigoMoneda { get; set; }
            [XmlAttribute(AttributeName = "FechaHoraEmision")]
            public string FechaHoraEmision { get; set; }
            [XmlAttribute(AttributeName = "Tipo")]
            public string Tipo { get; set; }
        }        

        //[XmlRoot(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Frase
        //{
        //    [XmlAttribute(AttributeName = "CodigoEscenario")]
        //    public string CodigoEscenario { get; set; }
        //    [XmlAttribute(AttributeName = "TipoFrase")]
        //    public string TipoFrase { get; set; }
        //}

        //[XmlRoot(ElementName = "Frases", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Frases
        //{
        //    [XmlElement(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public List<Frase> Frase { get; set; }
        //}       

        [XmlRoot(ElementName = "Abono", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
        public class Abono
        {
            [XmlElement(ElementName = "NumeroAbono", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public string NumeroAbono { get; set; }
            [XmlElement(ElementName = "FechaVencimiento", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public string FechaVencimiento { get; set; }
            [XmlElement(ElementName = "MontoAbono", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public string MontoAbono { get; set; }
        }

        [XmlRoot(ElementName = "AbonosFacturaCambiaria", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
        public class AbonosFacturaCambiaria
        {
            [XmlElement(ElementName = "Abono", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public Abono Abono { get; set; }
            [XmlAttribute(AttributeName = "cfc", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Cfc { get; set; }
            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string SchemaLocation { get; set; }
        }

        [XmlRoot(ElementName = "Complemento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Complemento
        {
            [XmlElement(ElementName = "AbonosFacturaCambiaria", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public AbonosFacturaCambiaria AbonosFacturaCambiaria { get; set; }
            [XmlAttribute(AttributeName = "IDComplemento")]
            public string IDComplemento { get; set; }
            [XmlAttribute(AttributeName = "NombreComplemento")]
            public string NombreComplemento { get; set; }
            [XmlAttribute(AttributeName = "URIComplemento")]
            public string URIComplemento { get; set; }
        }

        [XmlRoot(ElementName = "Complementos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Complementos
        {
            [XmlElement(ElementName = "Complemento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Complemento Complemento { get; set; }
        }

        [XmlRoot(ElementName = "DatosEmision", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DatosEmision
        {
            [XmlElement(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DatosGenerales DatosGenerales { get; set; }
            [XmlElement(ElementName = "Emisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Emisor Emisor { get; set; }
            [XmlElement(ElementName = "Receptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Receptor Receptor { get; set; }
            [XmlElement(ElementName = "Frases", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Frases Frases { get; set; }
            [XmlElement(ElementName = "Items", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Items Items { get; set; }
            [XmlElement(ElementName = "Totales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Totales Totales { get; set; }
            [XmlElement(ElementName = "Complementos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Complementos Complementos { get; set; }            
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
        }

        [XmlRoot(ElementName = "DTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DTE
        {
            [XmlElement(ElementName = "DatosEmision", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DatosEmision DatosEmision { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
        }

        [XmlRoot(ElementName = "Adenda", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Adenda
        {
            [XmlElement(ElementName = "Codigo_cliente")]
            public string Codigo_cliente { get; set; }
            [XmlElement(ElementName = "Observaciones")]
            public string Observaciones { get; set; }
            [XmlElement(ElementName = "Lugar")]
            public string Lugar { get; set; }
            [XmlElement(ElementName = "Vendedor")]
            public string Vendedor { get; set; }
            [XmlElement(ElementName = "Forma_pago")]
            public string Forma_pago { get; set; }
            [XmlElement(ElementName = "Vencimiento")]
            public string Vencimiento { get; set; }
            [XmlElement(ElementName = "TCambio")]
            public double TCambio { get; set; }
        }

        [XmlRoot(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class SAT
        {
            [XmlElement(ElementName = "DTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DTE DTE { get; set; }
            [XmlElement(ElementName = "Adenda", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Adenda Adenda { get; set; }
            [XmlAttribute(AttributeName = "ClaseDocumento")]
            public string ClaseDocumento { get; set; }
        }
    }
}
