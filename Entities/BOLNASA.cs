namespace Entities
{    
    using System.Xml.Serialization;
    using System.Collections.Generic;
    public class BOLNASA
    {
        [XmlRoot(ElementName = "TRANSACCIONES")]
        public class TRANSACCIONES
        {
            [XmlElement(ElementName = "TIPOU")]
            public string TIPOU { get; set; }
            [XmlElement(ElementName = "TIPO_TRA")]
            public string TIPO_TRA { get; set; }
            [XmlElement(ElementName = "FECHA")]
            public string FECHA { get; set; }
            [XmlElement(ElementName = "MES")]
            public string MES { get; set; }
            [XmlElement(ElementName = "ANO")]
            public string ANO { get; set; }
            [XmlElement(ElementName = "COD_PTOCLI_A")]
            public string COD_PTOCLI_A { get; set; }
            [XmlElement(ElementName = "NOMBRE")]
            public string NOMBRE { get; set; }
            [XmlElement(ElementName = "CEDULA")]
            public string CEDULA { get; set; }
            [XmlElement(ElementName = "CODPRO")]
            public string CODPRO { get; set; }
            [XmlElement(ElementName = "DESPRO")]
            public string DESPRO { get; set; }
            [XmlElement(ElementName = "TASA_RETENCION")]
            public string TASA_RETENCION { get; set; }
            [XmlElement(ElementName = "CODMED")]
            public string CODMED { get; set; }
            [XmlElement(ElementName = "DESMED")]
            public string DESMED { get; set; }
            [XmlElement(ElementName = "PRECIO")]
            public string PRECIO { get; set; }
            [XmlElement(ElementName = "CANTIDAD")]
            public string CANTIDAD { get; set; }
            [XmlElement(ElementName = "TOTAL")]
            public string TOTAL { get; set; }
            [XmlElement(ElementName = "COMISION")]
            public string COMISION { get; set; }
            [XmlElement(ElementName = "MONTO_RETENCION")]
            public string MONTO_RETENCION { get; set; }
            [XmlElement(ElementName = "NO_FACTURA_LOTE")]
            public string NO_FACTURA_LOTE { get; set; }
            [XmlElement(ElementName = "NO_RECIBO_FISCAL")]
            public string NO_RECIBO_FISCAL { get; set; }
            [XmlElement(ElementName = "NO_CONS_RET")]
            public string NO_CONS_RET { get; set; }
            [XmlElement(ElementName = "CODRENTA")]
            public string CODRENTA { get; set; }
            [XmlElement(ElementName = "DESRENTA")]
            public string DESRENTA { get; set; }
            [XmlElement(ElementName = "CODPTO")]
            public string CODPTO { get; set; }
            [XmlElement(ElementName = "CODPTOCLI")]
            public string CODPTOCLI { get; set; }
            [XmlElement(ElementName = "DESPTO")]
            public string DESPTO { get; set; }
            [XmlElement(ElementName = "DESPTOCLI")]
            public string DESPTOCLI { get; set; }
        }

        [XmlRoot(ElementName = "DBTEMPXML")]
        public class DBTEMPXML
        {
            [XmlElement(ElementName = "TRANSACCIONES")]
            public List<TRANSACCIONES> TRANSACCIONES { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
        }
    }
}
