namespace HaciendaGT
{
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    public class XmlFormatoAnulacion
    {

        [XmlRoot(ElementName = "GTAnulacionDocumento", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
        public class GTAnulacionDocumento
        {
            [XmlElement(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
            public SAT SAT { get; set; }
            [XmlAttribute(AttributeName = "ds", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Ds { get; set; }
            [XmlAttribute(AttributeName = "dte", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Dte { get; set; }
            [XmlAttribute(AttributeName = "n1", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string N1 { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string SchemaLocation { get; set; }
        }

        [XmlRoot(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
        public class DatosGenerales
        {
            [XmlAttribute(AttributeName = "FechaEmisionDocumentoAnular")]
            public string FechaEmisionDocumentoAnular { get; set; }
            [XmlAttribute(AttributeName = "FechaHoraAnulacion")]
            public string FechaHoraAnulacion { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
            [XmlAttribute(AttributeName = "IDReceptor")]
            public string IDReceptor { get; set; }
            [XmlAttribute(AttributeName = "MotivoAnulacion")]
            public string MotivoAnulacion { get; set; }
            [XmlAttribute(AttributeName = "NITEmisor")]
            public string NITEmisor { get; set; }
            [XmlAttribute(AttributeName = "NumeroDocumentoAAnular")]
            public string NumeroDocumentoAAnular { get; set; }
        }

        [XmlRoot(ElementName = "AnulacionDTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
        public class AnulacionDTE
        {
            [XmlElement(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
            public DatosGenerales DatosGenerales { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
        }

        [XmlRoot(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
        public class SAT
        {
            [XmlElement(ElementName = "AnulacionDTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.1.0")]
            public AnulacionDTE AnulacionDTE { get; set; }
        }       

    }
}
