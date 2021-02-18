namespace HaciendaGT
{
    using System.Xml.Serialization;
    using System.Collections.Generic;
    public class XmlFormatoComun
    {

        [XmlRoot(ElementName = "DireccionEmisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DireccionEmisor
        {
            [XmlElement(ElementName = "Direccion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Direccion { get; set; }
            [XmlElement(ElementName = "CodigoPostal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string CodigoPostal { get; set; }
            [XmlElement(ElementName = "Municipio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Municipio { get; set; }
            [XmlElement(ElementName = "Departamento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Departamento { get; set; }
            [XmlElement(ElementName = "Pais", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Pais { get; set; }
        }

        [XmlRoot(ElementName = "Emisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Emisor
        {
            [XmlElement(ElementName = "DireccionEmisor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DireccionEmisor DireccionEmisor { get; set; }
            [XmlAttribute(AttributeName = "AfiliacionIVA")]
            public string AfiliacionIVA { get; set; }
            [XmlAttribute(AttributeName = "CodigoEstablecimiento")]
            public string CodigoEstablecimiento { get; set; }
            [XmlAttribute(AttributeName = "CorreoEmisor")]
            public string CorreoEmisor { get; set; }
            [XmlAttribute(AttributeName = "NITEmisor")]
            public string NITEmisor { get; set; }
            [XmlAttribute(AttributeName = "NombreComercial")]
            public string NombreComercial { get; set; }
            [XmlAttribute(AttributeName = "NombreEmisor")]
            public string NombreEmisor { get; set; }
        }

        [XmlRoot(ElementName = "DireccionReceptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class DireccionReceptor
        {
            [XmlElement(ElementName = "Direccion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Direccion { get; set; }
            [XmlElement(ElementName = "CodigoPostal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string CodigoPostal { get; set; }
            [XmlElement(ElementName = "Municipio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Municipio { get; set; }
            [XmlElement(ElementName = "Departamento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Departamento { get; set; }
            [XmlElement(ElementName = "Pais", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Pais { get; set; }
        }

        [XmlRoot(ElementName = "Receptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Receptor
        {
            [XmlElement(ElementName = "DireccionReceptor", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public DireccionReceptor DireccionReceptor { get; set; }
            [XmlAttribute(AttributeName = "CorreoReceptor")]
            public string CorreoReceptor { get; set; }
            [XmlAttribute(AttributeName = "IDReceptor")]
            public string IDReceptor { get; set; }
            [XmlAttribute(AttributeName = "NombreReceptor")]
            public string NombreReceptor { get; set; }
        }

        [XmlRoot(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Frase
        {
            [XmlAttribute(AttributeName = "CodigoEscenario")]
            public string CodigoEscenario { get; set; }
            [XmlAttribute(AttributeName = "TipoFrase")]
            public string TipoFrase { get; set; }
        }

        [XmlRoot(ElementName = "Frases", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Frases
        {
            [XmlElement(ElementName = "Frase", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public List<Frase> Frase { get; set; }
        }

        [XmlRoot(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Impuesto
        {
            [XmlElement(ElementName = "NombreCorto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string NombreCorto { get; set; }
            [XmlElement(ElementName = "CodigoUnidadGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string CodigoUnidadGravable { get; set; }
            [XmlElement(ElementName = "MontoGravable", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string MontoGravable { get; set; }
            [XmlElement(ElementName = "MontoImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string MontoImpuesto { get; set; }
        }

        [XmlRoot(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Impuestos
        {
            [XmlElement(ElementName = "Impuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Impuesto Impuesto { get; set; }
        }

        [XmlRoot(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Item
        {
            [XmlElement(ElementName = "Cantidad", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Cantidad { get; set; }
            [XmlElement(ElementName = "UnidadMedida", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string UnidadMedida { get; set; }
            [XmlElement(ElementName = "Descripcion", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Descripcion { get; set; }
            [XmlElement(ElementName = "PrecioUnitario", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string PrecioUnitario { get; set; }
            [XmlElement(ElementName = "Precio", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Precio { get; set; }
            [XmlElement(ElementName = "Descuento", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Descuento { get; set; }
            [XmlElement(ElementName = "Impuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public Impuestos Impuesto { get; set; }
            [XmlElement(ElementName = "Total", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string Total { get; set; }
            [XmlAttribute(AttributeName = "BienOServicio")]
            public string BienOServicio { get; set; }
            [XmlAttribute(AttributeName = "NumeroLinea")]
            public string NumeroLinea { get; set; }
        }

        [XmlRoot(ElementName = "Items", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Items
        {
            [XmlElement(ElementName = "Item", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public List<Item> Item { get; set; }
        }

        [XmlRoot(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class TotalImpuesto
        {
            [XmlAttribute(AttributeName = "NombreCorto")]
            public string NombreCorto { get; set; }
            [XmlAttribute(AttributeName = "TotalMontoImpuesto")]
            public string TotalMontoImpuesto { get; set; }
        }

        [XmlRoot(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class TotalImpuestos
        {
            [XmlElement(ElementName = "TotalImpuesto", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public TotalImpuesto TotalImpuesto { get; set; }
        }

        [XmlRoot(ElementName = "Totales", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
        public class Totales
        {
            [XmlElement(ElementName = "TotalImpuestos", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public TotalImpuestos TotalImpuestos { get; set; }
            [XmlElement(ElementName = "GranTotal", Namespace = "http://www.sat.gob.gt/dte/fel/0.2.0")]
            public string GranTotal { get; set; }
        }
    }
}
