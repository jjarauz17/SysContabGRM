namespace Entities
{

    using ClasesBLL;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_FacturasElectronicasComprasDetalle : ClComun
    {
        FacturasElectronicasComprasDetalle vFacturasElectronicasComprasDetalleTabla = new FacturasElectronicasComprasDetalle();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public FacturasElectronicasComprasDetalle FacturasElectronicasComprasDetalleTabla
        {
            get
            {
                return vFacturasElectronicasComprasDetalleTabla;
            }
            set
            {
                vFacturasElectronicasComprasDetalleTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(FacturasElectronicasComprasDetalle FacturasElectronicasComprasDetalle, bool Tran = false)
        {
            object[] ObjParameter = new object[8];
            ObjParameter[0] = FacturasElectronicasComprasDetalle.IdFactura;
            ObjParameter[1] = FacturasElectronicasComprasDetalle.Empresa;
            ObjParameter[2] = FacturasElectronicasComprasDetalle.Codigo;
            ObjParameter[3] = FacturasElectronicasComprasDetalle.Cantidad;
            ObjParameter[4] = FacturasElectronicasComprasDetalle.Costo;
            ObjParameter[5] = FacturasElectronicasComprasDetalle.Descuento;
            ObjParameter[6] = FacturasElectronicasComprasDetalle.Impuesto;
            ObjParameter[7] = FacturasElectronicasComprasDetalle.Tipo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FacturasElectronicasComprasDetalle", ObjParameter);
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
                ClasesBLL.fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
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
        //public void Actualizar(FacturasElectronicasComprasDetalle FacturasElectronicasComprasDetalle, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[8];
        //    ObjParameter[0] = FacturasElectronicasComprasDetalle.IdDetalle;
        //    ObjParameter[1] = FacturasElectronicasComprasDetalle.IdFactura;
        //    ObjParameter[2] = FacturasElectronicasComprasDetalle.Empresa;
        //    ObjParameter[3] = FacturasElectronicasComprasDetalle.Codigo;
        //    ObjParameter[4] = FacturasElectronicasComprasDetalle.Cantidad;
        //    ObjParameter[5] = FacturasElectronicasComprasDetalle.Costo;
        //    ObjParameter[6] = FacturasElectronicasComprasDetalle.Descuento;
        //    ObjParameter[7] = FacturasElectronicasComprasDetalle.Impuesto;
        //    ObjParameter[8] = FacturasElectronicasComprasDetalle.Tipo;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FacturasElectronicasComprasDetalle", ObjParameter);
        //        cmd.ExecuteNonQuery();

        //        if (Tran == false)
        //        {
        //            Commit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.CodigoError = -1;
        //        if (Tran == false)
        //        {
        //            Rollback();
        //        }
        //        fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (Tran == false)
        //        {
        //            CloseSqlBD();
        //        }
        //    }
        //}


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable Listar(string Id)
        {
            return ClasesBLL.fn.ObtieneDatos("sp_sel_FacturasElectronicasComprasDetalle", Id);
        }

        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Borrar(FacturasElectronicasComprasDetalle FacturasElectronicasComprasDetalle, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[2];
        //    ObjParameter[0] = FacturasElectronicasComprasDetalle.IdDetalle;
        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones", ObjParameter);
        //        cmd.ExecuteNonQuery();

        //        if (Tran == false)
        //        {
        //            Commit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.CodigoError = -1;
        //        if (Tran == false)
        //        {
        //            Rollback();
        //        }
        //        fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (Tran == false)
        //        {
        //            CloseSqlBD();
        //        }
        //    }
        //}


        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public FacturasElectronicasComprasDetalle Detalles(string Id)
        //{
        //    DataTable dt = fn.ObtieneDatos("sp_sel_FacturasElectronicasComprasDetalle", Id);
        //    FacturasElectronicasComprasDetalle det = new FacturasElectronicasComprasDetalle();

        //    if (dt.Rows.Count > 0)
        //    {

        //        det.IdDetalle = dt.Rows[0]["IdDetalle"].ToString();
        //        det.IdFactura = dt.Rows[0]["IdFactura"].ToString();
        //        det.Empresa = dt.Rows[0]["Empresa"].ToString();
        //        det.Codigo = dt.Rows[0]["Codigo"].ToString();
        //        det.Cantidad = dt.Rows[0]["Cantidad"].ToString();
        //        det.Costo = dt.Rows[0]["Costo"].ToString();
        //        det.Descuento = dt.Rows[0]["Descuento"].ToString();
        //        det.Impuesto = dt.Rows[0]["Impuesto"].ToString();
        //        det.Tipo = dt.Rows[0]["Tipo"].ToString();

        //    }
        //    return det;
        //}
    }


}
