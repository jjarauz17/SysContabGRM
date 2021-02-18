namespace Entities
{    
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.XtraGrid;

    public class db_FacturasCuotas : ClComun
    {
        FacturasCuotas vFacturasCuotasTabla = new FacturasCuotas();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public FacturasCuotas FacturasCuotasTabla
        {
            get
            {
                return vFacturasCuotasTabla;
            }
            set
            {
                vFacturasCuotasTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public int Insertar(FacturasCuotas FacturasCuotas, bool Tran = false)
        {
            object[] ObjParameter = new object[12];
            ObjParameter[0] = FacturasCuotas.Id;
            ObjParameter[1] = FacturasCuotas.Empresa;
            ObjParameter[2] = FacturasCuotas.Factura;
            ObjParameter[3] = FacturasCuotas.IdCliente;
            ObjParameter[4] = FacturasCuotas.Moneda;
            ObjParameter[5] = FacturasCuotas.FechaSolicitud;
            ObjParameter[6] = FacturasCuotas.FechaInicio;
            ObjParameter[7] = FacturasCuotas.FechaCorte;
            ObjParameter[8] = FacturasCuotas.DiasGracia;
            ObjParameter[9] = FacturasCuotas.NoCuotas;
            ObjParameter[10] = FacturasCuotas.Interes;
            ObjParameter[11] = FacturasCuotas.Monto;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FacturasCuotas", ObjParameter);
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
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
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
        public bool Actualizar(FacturasCuotas FacturasCuotas, bool Tran = false)
        {
            object[] ObjParameter = new object[11];
            ObjParameter[0] = FacturasCuotas.Id;
            ObjParameter[1] = FacturasCuotas.Empresa;
            ObjParameter[2] = FacturasCuotas.Factura;
            ObjParameter[3] = FacturasCuotas.IdCliente;
            ObjParameter[4] = FacturasCuotas.Moneda;
            ObjParameter[5] = FacturasCuotas.FechaSolicitud;
            ObjParameter[6] = FacturasCuotas.FechaInicio;
            ObjParameter[7] = FacturasCuotas.FechaCorte;
            ObjParameter[8] = FacturasCuotas.DiasGracia;
            ObjParameter[9] = FacturasCuotas.NoCuotas;
            ObjParameter[10] = FacturasCuotas.Interes;
            ObjParameter[11] = FacturasCuotas.Monto;
            //ObjParameter[11] = FacturasCuotas.Estado;
            //ObjParameter[12] = FacturasCuotas.Usuario;
            //ObjParameter[13] = FacturasCuotas.Registro;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FacturasCuotas", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return false;
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
        public DataTable Listar(int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_FacturasCuotas", 0, Empresa);
        }

        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Imprimir(
        //    GridControl iGrid,
        //    string Titulo, 
        //    string Periodo, 
        //    Image Logo)
        //{
        //    fn.VistaPrevia(
        //        iGrid,)

        //    VistaPrevia(
        //            iGrid,
        //            $"{NombreEmpresaActual}{vbCrLf}{Titulo}",
        //            Periodo)
        //}

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public string Borrar(FacturasCuotas FacturasCuotas, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = string.Empty;
            ObjParameter[1] = FacturasCuotas.Id;
            ObjParameter[2] = FacturasCuotas.Empresa;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_FacturasCuotas", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return cmd.Parameters[1].Value.ToString();
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return ex.Message;
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
        public FacturasCuotas Detalles(int Id, int Empresa )
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_FacturasCuotas", Id, Empresa);
            FacturasCuotas det = new FacturasCuotas();

            if (dt.Rows.Count > 0)
            {

                det.Id = (int)dt.Rows[0]["Id"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Factura = dt.Rows[0]["Factura"].ToString();
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Moneda = dt.Rows[0]["Moneda"].ToString();
                det.FechaSolicitud = dt.Rows[0]["FechaSolicitud"].ToString();
                det.FechaInicio = dt.Rows[0]["FechaInicio"].ToString();
                det.FechaCorte = dt.Rows[0]["FechaCorte"].ToString();
                det.DiasGracia = (int)dt.Rows[0]["DiasGracia"];
                det.NoCuotas = (int)dt.Rows[0]["NoCuotas"];
                det.Interes = Convert.ToDouble(dt.Rows[0]["Interes"]);
                det.Monto = Convert.ToDouble(dt.Rows[0]["Monto"]);
                det.Estado = dt.Rows[0]["Estado"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Registro = dt.Rows[0]["Registro"].ToString();

            }
            return det;
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public FacturasCuotas Detalles2(string Factura, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_FacturasCuotasxFactura", Factura, Empresa);
            FacturasCuotas det = new FacturasCuotas();

            if (dt.Rows.Count > 0)
            {

                det.Id = (int)dt.Rows[0]["Id"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Factura = dt.Rows[0]["Factura"].ToString();
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Moneda = dt.Rows[0]["Moneda"].ToString();
                det.FechaSolicitud = dt.Rows[0]["FechaSolicitud"].ToString();
                det.FechaInicio = dt.Rows[0]["FechaInicio"].ToString();
                det.FechaCorte = dt.Rows[0]["FechaCorte"].ToString();
                det.DiasGracia = (int)dt.Rows[0]["DiasGracia"];
                det.NoCuotas = (int)dt.Rows[0]["NoCuotas"];
                det.Interes = Convert.ToDouble(dt.Rows[0]["Interes"]);
                det.Monto = Convert.ToDouble(dt.Rows[0]["Monto"]);
                det.Estado = dt.Rows[0]["Estado"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Registro = dt.Rows[0]["Registro"].ToString();

            }
            return det;
        }

    }

}
