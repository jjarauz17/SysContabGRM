namespace HaciendaGT
{
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using static XmlFormatoComun;
    public class XmlFormatoFExportacion
    {
        [XmlRoot(ElementName = "DatosGenerales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DatosGenerales
        {
            [XmlAttribute(AttributeName = "CodigoMoneda")]
            public string CodigoMoneda { get; set; }
            [XmlAttribute(AttributeName = "Exp")]
            public string Exp { get; set; }
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

        //[XmlRoot(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Impuesto
        //{
        //    [XmlElement(ElementName = "NombreCorto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string NombreCorto { get; set; }
        //    [XmlElement(ElementName = "CodigoUnidadGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string CodigoUnidadGravable { get; set; }
        //    [XmlElement(ElementName = "MontoGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string MontoGravable { get; set; }
        //    [XmlElement(ElementName = "MontoImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string MontoImpuesto { get; set; }
        //}

        //[XmlRoot(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Impuestos
        //{
        //    [XmlElement(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public Impuesto Impuesto { get; set; }
        //}

        //[XmlRoot(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Item
        //{
        //    [XmlElement(ElementName = "Cantidad", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string Cantidad { get; set; }
        //    [XmlElement(ElementName = "UnidadMedida", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string UnidadMedida { get; set; }
        //    [XmlElement(ElementName = "Descripcion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string Descripcion { get; set; }
        //    [XmlElement(ElementName = "PrecioUnitario", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string PrecioUnitario { get; set; }
        //    [XmlElement(ElementName = "Precio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string Precio { get; set; }
        //    [XmlElement(ElementName = "Descuento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string Descuento { get; set; }
        //    [XmlElement(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public Impuestos Impuestos { get; set; }
        //    [XmlElement(ElementName = "Total", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string Total { get; set; }
        //    [XmlAttribute(AttributeName = "BienOServicio")]
        //    public string BienOServicio { get; set; }
        //    [XmlAttribute(AttributeName = "NumeroLinea")]
        //    public string NumeroLinea { get; set; }
        //}

        //[XmlRoot(ElementName = "Items", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Items
        //{
        //    [XmlElement(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public Item Item { get; set; }
        //}

        //[XmlRoot(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class TotalImpuesto
        //{
        //    [XmlAttribute(AttributeName = "NombreCorto")]
        //    public string NombreCorto { get; set; }
        //    [XmlAttribute(AttributeName = "TotalMontoImpuesto")]
        //    public string TotalMontoImpuesto { get; set; }
        //}

        //[XmlRoot(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class TotalImpuestos
        //{
        //    [XmlElement(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public TotalImpuesto TotalImpuesto { get; set; }
        //}

        //[XmlRoot(ElementName = "Totales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //public class Totales
        //{
        //    [XmlElement(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public TotalImpuestos TotalImpuestos { get; set; }
        //    [XmlElement(ElementName = "GranTotal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        //    public string GranTotal { get; set; }
        //}

        [XmlRoot(ElementName = "Exportacion", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
        public class Exportacion
        {
            [XmlElement(ElementName = "NombreConsignatarioODestinatario", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string NombreConsignatarioODestinatario { get; set; }
            [XmlElement(ElementName = "DireccionConsignatarioODestinatario", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string DireccionConsignatarioODestinatario { get; set; }
            [XmlElement(ElementName = "CodigoConsignatarioODestinatario", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string CodigoConsignatarioODestinatario { get; set; }
            [XmlElement(ElementName = "NombreComprador", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string NombreComprador { get; set; }
            [XmlElement(ElementName = "DireccionComprador", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string DireccionComprador { get; set; }
            [XmlElement(ElementName = "CodigoComprador", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string CodigoComprador { get; set; }
            [XmlElement(ElementName = "OtraReferencia", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string OtraReferencia { get; set; }
            [XmlElement(ElementName = "INCOTERM", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string INCOTERM { get; set; }
            [XmlElement(ElementName = "NombreExportador", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string NombreExportador { get; set; }
            [XmlElement(ElementName = "CodigoExportador", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public string CodigoExportador { get; set; }
            [XmlAttribute(AttributeName = "cex", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Cex { get; set; }
            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string SchemaLocation { get; set; }
        }

        [XmlRoot(ElementName = "Complemento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Complemento
        {
            [XmlElement(ElementName = "Exportacion", Namespace = "http://www.sat.gob.gt/face2/ComplementoExportaciones/0.1.0")]
            public Exportacion Exportacion { get; set; }
            [XmlElement(ElementName = "AbonosFacturaCambiaria", Namespace = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0")]
            public XmlFormatoFactura.AbonosFacturaCambiaria AbonosFacturaCambiaria { get; set; }
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
            public List<Complemento> Complemento { get; set; }            
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

        [XmlRoot(ElementName = "SAT", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class SAT
        {
            [XmlElement(ElementName = "DTE", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DTE DTE { get; set; }
            [XmlAttribute(AttributeName = "ClaseDocumento")]
            public string ClaseDocumento { get; set; }
        }

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
    }
}
