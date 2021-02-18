namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FacturaElectronicaGT
    {
        public int Id { get; set; }
        //Generales
        public string CodigoMoneda { get; set; }
        public string FechaHoraEmision { get; set; }
        public string Tipo { get; set; }
        public string Exp { get; set; }

        //Emisor
        public string AfiliacionIVA { get; set; }        
        public string CodigoEstablecimiento { get; set; }        
        public string CorreoEmisor { get; set; }        
        public string NITEmisor { get; set; }        
        public string NombreComercial { get; set; }        
        public string NombreEmisor { get; set; }        
        public string DireccionEmisor { get; set; }        
        public string CodigoPostalEmisor { get; set; }
        public string MunicipioEmisor { get; set; }
        public string DepartamentoEmisor { get; set; }
        public string PaisEmisor { get; set; }

        //Receptor
        public string CorreoReceptor { get; set; }
        public string IDReceptor { get; set; }
        public string NombreReceptor { get; set; }
        public string DireccionReceptor { get; set; }
        public string CodigoPostalReceptor { get; set; }
        public string MunicipioReceptor { get; set; }
        public string DepartamentoReceptor { get; set; }
        public string PaisReceptor { get; set; }

        //Frases
        public string CodigoEscenario { get; set; }
        public string TipoFrase { get; set; }

        //Items
        public string BienOServicio { get; set; }
        public int NumeroLinea { get; set; }
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public string NombreCorto { get; set; }
        public string CodigoUnidadGravable { get; set; }
        public double MontoGravable { get; set; }
        public double MontoImpuesto { get; set; }
        public double Total { get; set; }

        //Totales
        public double TotalMontoImpuesto { get; set; }
        public double GranTotal { get; set; }

        //Adenda
        public string Codigo_cliente { get; set; }
        public string Observaciones { get; set; }
        public string Lugar { get; set; }
        public string Vendedor { get; set; }
        public string Forma_pago { get; set; }
        public string Vencimiento { get; set; }
        public double TCambio { get; set; }

        //Exportacion
        public string NombreConsignatarioODestinatario { get; set; }
        public string DireccionConsignatarioODestinatario { get; set; }
        public string CodigoConsignatarioODestinatario { get; set; }
        public string NombreComprador { get; set; }
        public string DireccionComprador { get; set; }
        public string CodigoComprador { get; set; }
        public string OtraReferencia { get; set; }
        public string INCOTERM { get; set; }
        public string NombreExportador { get; set; }
        public string CodigoExportador { get; set; }

        //Otros
        public string EncabezadoFE { get; set; }
        public string Consecutivo { get; set; }
        public string SchemaLocation { get; set; }

        public string Autorizado { get; set; }
        public string Documento { get; set; }
        public string Serie { get; set; }
        public string Motivo { get; set; }
    }
}
