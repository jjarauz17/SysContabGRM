namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class db_FacturaElectronicaGT : ClComun
    {
        FacturaElectronicaGT vFacturaElectronicaGTTabla = new FacturaElectronicaGT();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public FacturaElectronicaGT FacturaElectronicaGTTabla
        {
            get
            {
                return vFacturaElectronicaGTTabla;
            }
            set
            {
                vFacturaElectronicaGTTabla = value;
            }
        }

        public string iError { get; set; }

        public DataTable Detalle(string Factura,int Empresa)
        {
            return fn.ObtieneDatos("sp_FacturaElectronicaDetalleGT", Factura, Empresa);
        }

        public DataTable DetalleNC(int IdNota, int Empresa)
        {
            return fn.ObtieneDatos("sp_NotaElectronicaDetalleGT", IdNota, Empresa);
        }

        public FacturaElectronicaGT Header(string Factura, string Tipo, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_FacturaElectronicaGTDatos", Factura, Tipo, Empresa);
            FacturaElectronicaGT det = new FacturaElectronicaGT();

            if (dt.Rows.Count > 0)
            {
                det.Id = (int)dt.Rows[0]["Id"];

                det.CodigoMoneda = dt.Rows[0]["CodigoMoneda"].ToString();
                det.FechaHoraEmision = dt.Rows[0]["FechaHoraEmision"].ToString();
                det.Tipo = dt.Rows[0]["Tipo"].ToString();
                det.Exp = dt.Rows[0]["Exp"].ToString();

                det.AfiliacionIVA = dt.Rows[0]["AfiliacionIVA"].ToString();
                det.CodigoEstablecimiento = dt.Rows[0]["CodigoEstablecimiento"].ToString();
                det.CorreoEmisor = dt.Rows[0]["CorreoEmisor"].ToString();
                det.NITEmisor = dt.Rows[0]["NITEmisor"].ToString();
                det.NombreComercial = dt.Rows[0]["NombreComercial"].ToString();
                det.NombreEmisor = dt.Rows[0]["NombreEmisor"].ToString();
                det.DireccionEmisor = dt.Rows[0]["DireccionEmisor"].ToString();
                det.CodigoPostalEmisor = dt.Rows[0]["CodigoPostalEmisor"].ToString();
                det.MunicipioEmisor = dt.Rows[0]["MunicipioEmisor"].ToString();
                det.DepartamentoEmisor = dt.Rows[0]["DepartamentoEmisor"].ToString();
                det.PaisEmisor = dt.Rows[0]["PaisEmisor"].ToString();

                det.CorreoReceptor = dt.Rows[0]["CorreoReceptor"].ToString();
                det.IDReceptor = dt.Rows[0]["IDReceptor"].ToString();
                det.NombreReceptor = dt.Rows[0]["NombreReceptor"].ToString();
                det.DireccionReceptor = dt.Rows[0]["DireccionReceptor"].ToString();
                det.CodigoPostalReceptor = dt.Rows[0]["CodigoPostalReceptor"].ToString();
                det.MunicipioReceptor = dt.Rows[0]["MunicipioReceptor"].ToString();
                det.DepartamentoReceptor = dt.Rows[0]["DepartamentoReceptor"].ToString();
                det.PaisReceptor = dt.Rows[0]["PaisReceptor"].ToString();

                det.CodigoEscenario = dt.Rows[0]["CodigoEscenario"].ToString();
                det.TipoFrase = dt.Rows[0]["TipoFrase"].ToString();

                det.TotalMontoImpuesto = Convert.ToDouble(dt.Rows[0]["TotalMontoImpuesto"]);
                det.GranTotal = Convert.ToDouble(dt.Rows[0]["GranTotal"]);
                //ADENDA
                det.Codigo_cliente = dt.Rows[0]["Codigo_cliente"].ToString();
                det.Observaciones = dt.Rows[0]["Observaciones"].ToString();
                det.Lugar = dt.Rows[0]["Lugar"].ToString();
                det.Vendedor = dt.Rows[0]["Vendedor"].ToString();
                det.Forma_pago = dt.Rows[0]["FormaPago"].ToString();
                det.Vencimiento = dt.Rows[0]["Vencimiento"].ToString();
                det.TCambio = Convert.ToDouble(dt.Rows[0]["TCambio"]);

                //FACTURA DE EXPORTACION
                det.NombreConsignatarioODestinatario = dt.Rows[0]["NombreConsignatarioODestinatario"].ToString();
                det.DireccionConsignatarioODestinatario = dt.Rows[0]["DireccionConsignatarioODestinatario"].ToString();
                det.CodigoConsignatarioODestinatario = dt.Rows[0]["CodigoConsignatarioODestinatario"].ToString();
                det.NombreComprador = dt.Rows[0]["NombreComprador"].ToString();
                det.DireccionComprador = dt.Rows[0]["DireccionComprador"].ToString();
                det.CodigoComprador = dt.Rows[0]["CodigoComprador"].ToString();
                det.OtraReferencia = dt.Rows[0]["OtraReferencia"].ToString();
                det.INCOTERM = dt.Rows[0]["INCOTERM"].ToString();
                det.NombreExportador = dt.Rows[0]["NombreExportador"].ToString();
                det.CodigoExportador = dt.Rows[0]["CodigoExportador"].ToString();

                det.EncabezadoFE = dt.Rows[0]["EncabezadoFE"].ToString();
                det.Consecutivo = dt.Rows[0]["Consecutivo"].ToString();
                det.SchemaLocation = dt.Rows[0]["SchemaLocation"].ToString();

                return det;
            }
            else {
                return null;
            }
        }

        public FacturaElectronicaGT HeaderNCD(
            int IdNota, 
            string Tipo,              
            int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_NotaElectronicaGTDatos", IdNota, Tipo, Empresa);
            FacturaElectronicaGT det = new FacturaElectronicaGT();

            if (dt.Rows.Count > 0)
            {
                det.Id = (int)dt.Rows[0]["Id"];

                det.CodigoMoneda = dt.Rows[0]["CodigoMoneda"].ToString();
                det.FechaHoraEmision = dt.Rows[0]["FechaHoraEmision"].ToString();
                det.Tipo = dt.Rows[0]["Tipo"].ToString();

                det.AfiliacionIVA = dt.Rows[0]["AfiliacionIVA"].ToString();
                det.CodigoEstablecimiento = dt.Rows[0]["CodigoEstablecimiento"].ToString();
                det.CorreoEmisor = dt.Rows[0]["CorreoEmisor"].ToString();
                det.NITEmisor = dt.Rows[0]["NITEmisor"].ToString();
                det.NombreComercial = dt.Rows[0]["NombreComercial"].ToString();
                det.NombreEmisor = dt.Rows[0]["NombreEmisor"].ToString();
                det.DireccionEmisor = dt.Rows[0]["DireccionEmisor"].ToString();
                det.CodigoPostalEmisor = dt.Rows[0]["CodigoPostalEmisor"].ToString();
                det.MunicipioEmisor = dt.Rows[0]["MunicipioEmisor"].ToString();
                det.DepartamentoEmisor = dt.Rows[0]["DepartamentoEmisor"].ToString();
                det.PaisEmisor = dt.Rows[0]["PaisEmisor"].ToString();

                det.CorreoReceptor = dt.Rows[0]["CorreoReceptor"].ToString();
                det.IDReceptor = dt.Rows[0]["IDReceptor"].ToString();
                det.NombreReceptor = dt.Rows[0]["NombreReceptor"].ToString();
                det.DireccionReceptor = dt.Rows[0]["DireccionReceptor"].ToString();
                det.CodigoPostalReceptor = dt.Rows[0]["CodigoPostalReceptor"].ToString();
                det.MunicipioReceptor = dt.Rows[0]["MunicipioReceptor"].ToString();
                det.DepartamentoReceptor = dt.Rows[0]["DepartamentoReceptor"].ToString();
                det.PaisReceptor = dt.Rows[0]["PaisReceptor"].ToString();

                det.CodigoEscenario = dt.Rows[0]["CodigoEscenario"].ToString();
                det.TipoFrase = dt.Rows[0]["TipoFrase"].ToString();

                det.TotalMontoImpuesto = Convert.ToDouble(dt.Rows[0]["TotalMontoImpuesto"]);
                det.GranTotal = Convert.ToDouble(dt.Rows[0]["GranTotal"]);
                //ADENDA
                det.Codigo_cliente = dt.Rows[0]["Codigo_cliente"].ToString();
                det.Observaciones = dt.Rows[0]["Observaciones"].ToString();
                det.Lugar = dt.Rows[0]["Lugar"].ToString();
                det.Vendedor = dt.Rows[0]["Vendedor"].ToString();
                det.Forma_pago = dt.Rows[0]["FormaPago"].ToString();
                det.Vencimiento = dt.Rows[0]["Vencimiento"].ToString();

                det.EncabezadoFE = dt.Rows[0]["EncabezadoFE"].ToString();
                det.Consecutivo = dt.Rows[0]["Consecutivo"].ToString();
                det.SchemaLocation = dt.Rows[0]["SchemaLocation"].ToString();

                //det.Autorizado = dt.Rows[0]["Autorizado"].ToString();
                //det.Documento = dt.Rows[0]["Documento"].ToString();
                //det.Serie = dt.Rows[0]["Serie"].ToString();
                //det.Motivo = dt.Rows[0]["Motivo"].ToString();

                return det;
            }
            else
            {
                return null;
            }
        }

        public void Actualizar(int ID, 
            string FacturaXML,
            string ClaveNumerica,
            string Estado,
            string Mensaje,
            string XMLFirmado,
            int Empresa)
        {
            try
            {

                SqlConnection cnn = new SqlConnection(ClasesBLL.fn.Conexion());
                SqlCommand cmd = new SqlCommand("sp_upd_FACTURAS_VENTAS_XML_GT");
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@FacturaXML", FacturaXML);
                cmd.Parameters.AddWithValue("@ClaveNumerica", ClaveNumerica);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@MensajeHacienda", Mensaje);
                cmd.Parameters.AddWithValue("@XmlFirmado", XMLFirmado);
                cmd.Parameters.AddWithValue("@Empresa", Empresa);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = ex.Message;                
            }
        }
    }
}
