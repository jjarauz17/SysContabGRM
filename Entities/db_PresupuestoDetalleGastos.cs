namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_PresupuestoDetalleGastos : ClComun
    {
        PresupuestoDetalleGastos vPresupuestoDetalleGastosTabla = new PresupuestoDetalleGastos();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public PresupuestoDetalleGastos PresupuestoDetalleGastosTabla
        {
            get
            {
                return vPresupuestoDetalleGastosTabla;
            }
            set
            {
                vPresupuestoDetalleGastosTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(PresupuestoDetalleGastos PresupuestoDetalleGastos, bool Tran = false)
        {
            object[] ObjParameter = new object[17];
            ObjParameter[0] = PresupuestoDetalleGastos.IdPresupuesto;
            ObjParameter[1] = PresupuestoDetalleGastos.Empresa;
            ObjParameter[2] = PresupuestoDetalleGastos.Cuenta;
            ObjParameter[3] = PresupuestoDetalleGastos.Activo;
            ObjParameter[4] = PresupuestoDetalleGastos.Estimado1;            
            ObjParameter[5] = PresupuestoDetalleGastos.Estimado2;            
            ObjParameter[6] = PresupuestoDetalleGastos.Estimado3;            
            ObjParameter[7] = PresupuestoDetalleGastos.Estimado4;            
            ObjParameter[8] = PresupuestoDetalleGastos.Estimado5;            
            ObjParameter[9] = PresupuestoDetalleGastos.Estimado6;            
            ObjParameter[10] = PresupuestoDetalleGastos.Estimado7;            
            ObjParameter[11] = PresupuestoDetalleGastos.Estimado8;            
            ObjParameter[12] = PresupuestoDetalleGastos.Estimado9;            
            ObjParameter[13] = PresupuestoDetalleGastos.Estimado10;            
            ObjParameter[14] = PresupuestoDetalleGastos.Estimado11;            
            ObjParameter[15] = PresupuestoDetalleGastos.Estimado12;            
            ObjParameter[16] = PresupuestoDetalleGastos.Nota;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PresupuestoDetalleGastos", ObjParameter);
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
        public void Actualizar(PresupuestoDetalleGastos PresupuestoDetalleGastos, bool Tran = false)
        {
            object[] ObjParameter = new object[18];
            ObjParameter[0] = PresupuestoDetalleGastos.IdDetalle;
            ObjParameter[1] = PresupuestoDetalleGastos.IdPresupuesto;
            ObjParameter[2] = PresupuestoDetalleGastos.Empresa;
            ObjParameter[3] = PresupuestoDetalleGastos.Cuenta;
            ObjParameter[4] = PresupuestoDetalleGastos.Activo;
            ObjParameter[5] = PresupuestoDetalleGastos.Estimado1;
            ObjParameter[6] = PresupuestoDetalleGastos.Estimado2;
            ObjParameter[7] = PresupuestoDetalleGastos.Estimado3;
            ObjParameter[8] = PresupuestoDetalleGastos.Estimado4;
            ObjParameter[9] = PresupuestoDetalleGastos.Estimado5;
            ObjParameter[10] = PresupuestoDetalleGastos.Estimado6;
            ObjParameter[11] = PresupuestoDetalleGastos.Estimado7;
            ObjParameter[12] = PresupuestoDetalleGastos.Estimado8;
            ObjParameter[13] = PresupuestoDetalleGastos.Estimado9;
            ObjParameter[14] = PresupuestoDetalleGastos.Estimado10;
            ObjParameter[15] = PresupuestoDetalleGastos.Estimado11;
            ObjParameter[16] = PresupuestoDetalleGastos.Estimado12;
            ObjParameter[17] = PresupuestoDetalleGastos.Nota;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PresupuestoDetalleGastos", ObjParameter);
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
            return fn.ObtieneDatos("sp_sel_PresupuestoDetalleGastos", Id, Empresa);
        }

        public DataTable ListarReal(int Id, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_PresupuestoDetalleGastosReal", Id, Empresa);
        }

        public DataTable ListarVariacion(int Id, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_PresupuestoDetalleGastosVariacion", Id, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(PresupuestoDetalleGastos PresupuestoDetalleGastos, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = PresupuestoDetalleGastos.IdDetalle;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_PresupuestoDetalleGastos", ObjParameter);
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
        //public PresupuestoDetalleGastos Detalles(string Id)
        //{
        //    DataTable dt = fn.ObtieneDatos("sp_sel_PresupuestoDetalleGastos", Id);
        //    PresupuestoDetalleGastos det = new PresupuestoDetalleGastos();

        //    if (dt.Rows.Count > 0)
        //    {

        //        det.IdDetalle = dt.Rows[0]["IdDetalle"].ToString();
        //        det.IdPresupuesto = dt.Rows[0]["IdPresupuesto"].ToString();
        //        det.Empresa = dt.Rows[0]["Empresa"].ToString();
        //        det.Cuenta = dt.Rows[0]["Cuenta"].ToString();
        //        det.Activo = dt.Rows[0]["Activo"].ToString();
        //        det.Estimado1 = dt.Rows[0]["Estimado1"].ToString();
        //        det.Real1 = dt.Rows[0]["Real1"].ToString();
        //        det.Estimado2 = dt.Rows[0]["Estimado2"].ToString();
        //        det.Real2 = dt.Rows[0]["Real2"].ToString();
        //        det.Estimado3 = dt.Rows[0]["Estimado3"].ToString();
        //        det.Real3 = dt.Rows[0]["Real3"].ToString();
        //        det.Estimado4 = dt.Rows[0]["Estimado4"].ToString();
        //        det.Real4 = dt.Rows[0]["Real4"].ToString();
        //        det.Estimado5 = dt.Rows[0]["Estimado5"].ToString();
        //        det.Real5 = dt.Rows[0]["Real5"].ToString();
        //        det.Estimado6 = dt.Rows[0]["Estimado6"].ToString();
        //        det.Real6 = dt.Rows[0]["Real6"].ToString();
        //        det.Estimado7 = dt.Rows[0]["Estimado7"].ToString();
        //        det.Real7 = dt.Rows[0]["Real7"].ToString();
        //        det.Estimado8 = dt.Rows[0]["Estimado8"].ToString();
        //        det.Real8 = dt.Rows[0]["Real8"].ToString();
        //        det.Estimado9 = dt.Rows[0]["Estimado9"].ToString();
        //        det.Real9 = dt.Rows[0]["Real9"].ToString();
        //        det.Estimado10 = dt.Rows[0]["Estimado10"].ToString();
        //        det.Real10 = dt.Rows[0]["Real10"].ToString();
        //        det.Estimado11 = dt.Rows[0]["Estimado11"].ToString();
        //        det.Real11 = dt.Rows[0]["Real11"].ToString();
        //        det.Estimado12 = dt.Rows[0]["Estimado12"].ToString();
        //        det.Real12 = dt.Rows[0]["Real12"].ToString();
        //        det.Nota = dt.Rows[0]["Nota"].ToString();

        //    }
        //    return det;
        //}
    }

}
