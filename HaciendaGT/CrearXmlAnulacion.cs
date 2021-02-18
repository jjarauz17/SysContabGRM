using System.Data;
using static HaciendaGT.XmlFormatoAnulacion;

namespace HaciendaGT
{
    public class CrearXmlAnulacion
    {

        public GTAnulacionDocumento AnulacionXml(string Numero, string Motivo, DataTable Detalle)
        {

            DatosGenerales DatosGenerales = new DatosGenerales
            {
                FechaEmisionDocumentoAnular = Detalle.Rows[0]["FechaEmision"].ToString(),
                FechaHoraAnulacion = Detalle.Rows[0]["FechaAnulacion"].ToString(),
                ID = "DatosAnulacion",
                IDReceptor = Detalle.Rows[0]["IDReceptor"].ToString(),
                MotivoAnulacion = Motivo,
                NITEmisor = Detalle.Rows[0]["NITEmisor"].ToString(),
                NumeroDocumentoAAnular = Numero
            };

            AnulacionDTE AnulacionDTE = new AnulacionDTE
            {
                ID = "DatosCertificados",
                DatosGenerales = DatosGenerales
            };

            SAT sat = new SAT
            {
                AnulacionDTE = AnulacionDTE
            };

            return new GTAnulacionDocumento
            {
                SAT = sat
            };
        }
    }
}
