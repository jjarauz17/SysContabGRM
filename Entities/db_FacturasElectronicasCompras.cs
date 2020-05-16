namespace Entities
{
    using Microsoft.VisualBasic;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_FacturasElectronicasCompras : ClComun
    {
        FacturasElectronicasCompras vFacturasElectronicasComprasTabla = new FacturasElectronicasCompras();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public FacturasElectronicasCompras FacturasElectronicasComprasTabla
        {
            get
            {
                return vFacturasElectronicasComprasTabla;
            }
            set
            {
                vFacturasElectronicasComprasTabla = value;
            }
        }

        public string _error { get; set; }
        public string EncabezadoFE { get; set; }
        public string JsonEnviar { get; set; }

        //fn fn = new Fn();
        Credenciales credenciales = new Credenciales();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public int Insertar(FacturasElectronicasCompras FacturasElectronicasCompras, bool Tran = false)
        {
            object[] ObjParameter = new object[14];

            ObjParameter[0] = FacturasElectronicasCompras.IdFactura;
            ObjParameter[1] = FacturasElectronicasCompras.Empresa;
            ObjParameter[2] = FacturasElectronicasCompras.Numero;
            ObjParameter[3] = FacturasElectronicasCompras.IdProveedor;
            ObjParameter[4] = FacturasElectronicasCompras.Factura;
            ObjParameter[5] = FacturasElectronicasCompras.Referencia;
            ObjParameter[6] = FacturasElectronicasCompras.Clave;
            ObjParameter[7] = FacturasElectronicasCompras.Fecha;
            ObjParameter[8] = FacturasElectronicasCompras.FechaEmision;
            ObjParameter[9] = FacturasElectronicasCompras.TotalImpuesto;
            ObjParameter[10] = FacturasElectronicasCompras.TotalFactura;
            ObjParameter[11] = FacturasElectronicasCompras.Receptor;
            ObjParameter[12] = FacturasElectronicasCompras.CedulaReceptor;
            ObjParameter[13] = FacturasElectronicasCompras.Consecutivo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FacturasElectronicasCompras", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return (int)cmd.Parameters[1].Value;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg("Error al Guardar, SP: sp_ins_FacturasElectronicasCompras." + Constants.vbCrLf +
                      ex.Message, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (Tran == false)
                {
                    CloseSqlBD();
                }
            }
        }


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Actualizar(FacturasElectronicasCompras FacturasElectronicasCompras, bool Tran = false)
        {
            object[] ObjParameter = new object[7];

            ObjParameter[0] = FacturasElectronicasCompras.IdFactura;
            ObjParameter[1] = FacturasElectronicasCompras.Empresa;            
            ObjParameter[2] = FacturasElectronicasCompras.StatusCode;
            ObjParameter[3] = FacturasElectronicasCompras.Estado;
            ObjParameter[4] = FacturasElectronicasCompras.Respuesta;
            ObjParameter[5] = FacturasElectronicasCompras.XmlFirmado;
            ObjParameter[6] = FacturasElectronicasCompras.XmlRespuesta;            

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FacturasElectronicasCompras", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (Tran == false)
                {
                    CloseSqlBD();
                }
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable Listar(int Id,
            DateTime Desde,
            DateTime Hasta,
            int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_FacturasElectronicasCompras", 
                Id,
                Desde,
                Hasta,
                Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public string Consecutivo(int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_FacturasElectronicasComprasConsecutivo",
                Empresa)
                .Rows[0]["Consecutivo"].ToString();
        }

        public void GetJsonEnviar(int Id, 
            string TipoCedula,
            string Condicion,
            string MedioPago,
            int Empresa)
        {
            DataTable _DT = fn.ObtieneDatos("sp_sel_FacturasElectronicasComprasJson",
                Id,
                TipoCedula,
                Condicion,
                MedioPago,
                Empresa);

            if (_DT == null)
            {
                EncabezadoFE = string.Empty;
                JsonEnviar = string.Empty;
                _error = fn.iError;
                return;
            } 
            
            if (_DT.Rows.Count > 0)
            {
                EncabezadoFE = _DT.Rows[0]["EncabezadoFE"].ToString();
                JsonEnviar = _DT.Rows[0]["JsonEnviar"].ToString();
                _error = "Ok";
            }
                              
        }



        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(FacturasElectronicasCompras FacturasElectronicasCompras, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = FacturasElectronicasCompras.IdFactura;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                if (Tran == false)
                {
                    CloseSqlBD();
                }
            }
        }


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public FacturasElectronicasCompras Detalles(string Id)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_FacturasElectronicasCompras", Id);
            FacturasElectronicasCompras det = new FacturasElectronicasCompras();

            if (dt.Rows.Count > 0)
            {

                det.IdFactura = (int)dt.Rows[0]["IdFactura"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Numero = (int)dt.Rows[0]["Numero"];
                det.IdProveedor = (int)dt.Rows[0]["IdProveedor"];
                det.Factura = dt.Rows[0]["Factura"].ToString();
                det.Referencia = dt.Rows[0]["Referencia"].ToString();
                det.Clave = dt.Rows[0]["Clave"].ToString();
                det.Fecha = dt.Rows[0]["Fecha"].ToString();
                det.FechaEmision = dt.Rows[0]["FechaEmision"].ToString();
                det.TotalImpuesto = Convert.ToDecimal(dt.Rows[0]["TotalImpuesto"]);
                det.TotalFactura = Convert.ToDecimal(dt.Rows[0]["TotalFactura"]);
                det.Receptor = dt.Rows[0]["Receptor"].ToString();
                det.CedulaReceptor = dt.Rows[0]["CedulaReceptor"].ToString();
                det.Consecutivo = dt.Rows[0]["Consecutivo"].ToString();
                det.StatusCode = dt.Rows[0]["StatusCode"].ToString();
                det.Estado = dt.Rows[0]["Estado"].ToString();
                det.Respuesta = dt.Rows[0]["Respuesta"].ToString();
                det.XmlFirmado = dt.Rows[0]["XmlFirmado"].ToString();
                det.XmlRespuesta = dt.Rows[0]["XmlRespuesta"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Fecha_Registro = dt.Rows[0]["Fecha_Registro"].ToString();

            }
            return det;
        }
    }
}