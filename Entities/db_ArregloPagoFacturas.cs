namespace Entities
{  
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ArregloPagoFacturas : ClComun
    {
        ArregloPagoFacturas vArregloPagoFacturasTabla = new ArregloPagoFacturas();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ArregloPagoFacturas ArregloPagoFacturasTabla
        {
            get
            {
                return vArregloPagoFacturasTabla;
            }
            set
            {
                vArregloPagoFacturasTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ArregloPagoFacturas ArregloPagoFacturas, bool Tran = false)
        {
            object[] ObjParameter = new object[6];
            ObjParameter[0] = ArregloPagoFacturas.IdArreglo;
            ObjParameter[1] = ArregloPagoFacturas.Empresa;
            ObjParameter[2] = ArregloPagoFacturas.Factura;
            ObjParameter[3] = ArregloPagoFacturas.Fecha;
            ObjParameter[4] = ArregloPagoFacturas.Vencimiento;
            ObjParameter[5] = ArregloPagoFacturas.Saldo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ArregloPagoFacturas", ObjParameter);
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
        public void Actualizar(ArregloPagoFacturas ArregloPagoFacturas, bool Tran = false)
        {
            object[] ObjParameter = new object[6];
            ObjParameter[0] = ArregloPagoFacturas.IdDetalle;
            ObjParameter[1] = ArregloPagoFacturas.IdArreglo;
            ObjParameter[2] = ArregloPagoFacturas.Empresa;
            ObjParameter[3] = ArregloPagoFacturas.Factura;
            ObjParameter[4] = ArregloPagoFacturas.Fecha;
            ObjParameter[5] = ArregloPagoFacturas.Vencimiento;
            ObjParameter[6] = ArregloPagoFacturas.Saldo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ArregloPagoFacturas", ObjParameter);
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
        public DataTable Listar(int Id, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ArregloPagoFacturas", 0, Id, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable Listar(int IdCliente, DateTime Corte, int IdArreglo, int Empresa)
        {
            return fn.ObtieneDatos("JAR_GetFacturasSaldosAP", IdCliente, Corte.Date, IdArreglo, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ArregloPagoFacturas ArregloPagoFacturas, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ArregloPagoFacturas.IdArreglo;
            ObjParameter[1] = ArregloPagoFacturas.Empresa;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ArregloPagoFacturas", ObjParameter);
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

        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public ArregloPagoFacturas Detalles(string Id)
        //{
        //    DataTable dt = fn.ObtieneDatos("sp_sel_ArregloPagoFacturas", Id);
        //    ArregloPagoFacturas det = new ArregloPagoFacturas();

        //    if (dt.Rows.Count > 0)
        //    {

        //        det.IdDetalle = dt.Rows[0]["IdDetalle"].ToString();
        //        det.IdArreglo = dt.Rows[0]["IdArreglo"].ToString();
        //        det.Empresa = dt.Rows[0]["Empresa"].ToString();
        //        det.Factura = dt.Rows[0]["Factura"].ToString();
        //        det.Fecha = dt.Rows[0]["Fecha"].ToString();
        //        det.Vencimiento = dt.Rows[0]["Vencimiento"].ToString();
        //        det.Saldo = dt.Rows[0]["Saldo"].ToString();

        //    }
        //    return det;
        //}
    }


}
