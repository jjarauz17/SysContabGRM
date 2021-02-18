namespace Entities
{    
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_PNR_PlanNegocio_Detalle : ClComun
    {
        PNR_PlanNegocio_Detalle vPNR_PlanNegocio_DetalleTabla = new PNR_PlanNegocio_Detalle();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public PNR_PlanNegocio_Detalle PNR_PlanNegocio_DetalleTabla
        {
            get
            {
                return vPNR_PlanNegocio_DetalleTabla;
            }
            set
            {
                vPNR_PlanNegocio_DetalleTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(PNR_PlanNegocio_Detalle PNR_PlanNegocio_Detalle, bool Tran = false)
        {
            object[] ObjParameter = new object[19];
            ObjParameter[0] = PNR_PlanNegocio_Detalle.IdPlanNegocio;
            ObjParameter[1] = PNR_PlanNegocio_Detalle.Empresa;
            ObjParameter[2] = PNR_PlanNegocio_Detalle.Producto;
            ObjParameter[3] = PNR_PlanNegocio_Detalle.Unidad;
            ObjParameter[4] = PNR_PlanNegocio_Detalle.Presentacion;
            ObjParameter[5] = PNR_PlanNegocio_Detalle.Tipo;            
            ObjParameter[6] = PNR_PlanNegocio_Detalle.Precio;
            ObjParameter[7] = PNR_PlanNegocio_Detalle.Cantidad1;            
            ObjParameter[8] = PNR_PlanNegocio_Detalle.Cantidad2;
            ObjParameter[9] = PNR_PlanNegocio_Detalle.Cantidad3;
            ObjParameter[10] = PNR_PlanNegocio_Detalle.Cantidad4;
            ObjParameter[11] = PNR_PlanNegocio_Detalle.Cantidad5;
            ObjParameter[12] = PNR_PlanNegocio_Detalle.Cantidad6;
            ObjParameter[13] = PNR_PlanNegocio_Detalle.Cantidad7;
            ObjParameter[14] = PNR_PlanNegocio_Detalle.Cantidad8;
            ObjParameter[15] = PNR_PlanNegocio_Detalle.Cantidad9;
            ObjParameter[16] = PNR_PlanNegocio_Detalle.Cantidad10;
            ObjParameter[17] = PNR_PlanNegocio_Detalle.Cantidad11;
            ObjParameter[18] = PNR_PlanNegocio_Detalle.Cantidad12;
            
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_PlanNegocio_Detalle", ObjParameter);
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
        public void Actualizar(PNR_PlanNegocio_Detalle PNR_PlanNegocio_Detalle, bool Tran = false)
        {
            object[] ObjParameter = new object[20];
            ObjParameter[0] = PNR_PlanNegocio_Detalle.IdDetalle;
            ObjParameter[1] = PNR_PlanNegocio_Detalle.IdPlanNegocio;
            ObjParameter[2] = PNR_PlanNegocio_Detalle.Empresa;
            ObjParameter[3] = PNR_PlanNegocio_Detalle.Producto;
            ObjParameter[4] = PNR_PlanNegocio_Detalle.Unidad;
            ObjParameter[5] = PNR_PlanNegocio_Detalle.Presentacion;
            ObjParameter[6] = PNR_PlanNegocio_Detalle.Tipo;
            ObjParameter[7] = PNR_PlanNegocio_Detalle.Precio;
            ObjParameter[8] = PNR_PlanNegocio_Detalle.Cantidad1;
            ObjParameter[9] = PNR_PlanNegocio_Detalle.Cantidad2;
            ObjParameter[10] = PNR_PlanNegocio_Detalle.Cantidad3;
            ObjParameter[11] = PNR_PlanNegocio_Detalle.Cantidad4;
            ObjParameter[12] = PNR_PlanNegocio_Detalle.Cantidad5;
            ObjParameter[13] = PNR_PlanNegocio_Detalle.Cantidad6;
            ObjParameter[14] = PNR_PlanNegocio_Detalle.Cantidad7;
            ObjParameter[15] = PNR_PlanNegocio_Detalle.Cantidad8;
            ObjParameter[16] = PNR_PlanNegocio_Detalle.Cantidad9;
            ObjParameter[17] = PNR_PlanNegocio_Detalle.Cantidad10;
            ObjParameter[18] = PNR_PlanNegocio_Detalle.Cantidad11;
            ObjParameter[19] = PNR_PlanNegocio_Detalle.Cantidad12;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_PlanNegocio_Detalle", ObjParameter);
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
        public DataTable Listar(string Id,string Sucursal, int Periodo, string Cultivo, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_PNR_PlanNegocio_Detalle", Id, Sucursal, Periodo, Cultivo, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(PNR_PlanNegocio_Detalle PNR_PlanNegocio_Detalle, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = PNR_PlanNegocio_Detalle.IdDetalle;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_PlanNegocio_Detalle", ObjParameter);
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
        //public PNR_PlanNegocio_Detalle Detalles(string Id)
        //{
        //    DataTable dt = fn.ObtieneDatos("sp_sel_PNR_PlanNegocio_Detalle", Id);
        //    PNR_PlanNegocio_Detalle det = new PNR_PlanNegocio_Detalle();

        //    if (dt.Rows.Count > 0)
        //    {

        //        det.IdDetalle = dt.Rows[0]["IdDetalle"].ToString();
        //        det.IdPlanNegocio = dt.Rows[0]["IdPlanNegocio"].ToString();
        //        det.Empresa = dt.Rows[0]["Empresa"].ToString();
        //        det.Producto = dt.Rows[0]["Producto"].ToString();
        //        det.Unidad = dt.Rows[0]["Unidad"].ToString();
        //        det.Tipo = dt.Rows[0]["Tipo"].ToString();
        //        det.Cantidad_Anterior = dt.Rows[0]["Cantidad_Anterior"].ToString();
        //        det.Venta_Anterior = dt.Rows[0]["Venta_Anterior"].ToString();
        //        det.Precio = dt.Rows[0]["Precio"].ToString();
        //        det.Cantidad1 = dt.Rows[0]["Cantidad1"].ToString();
        //        det.CantidadReal1 = dt.Rows[0]["CantidadReal1"].ToString();
        //        det.Venta1 = dt.Rows[0]["Venta1"].ToString();
        //        det.Cantidad2 = dt.Rows[0]["Cantidad2"].ToString();
        //        det.CantidadReal2 = dt.Rows[0]["CantidadReal2"].ToString();
        //        det.Venta2 = dt.Rows[0]["Venta2"].ToString();
        //        det.Cantidad3 = dt.Rows[0]["Cantidad3"].ToString();
        //        det.CantidadReal3 = dt.Rows[0]["CantidadReal3"].ToString();
        //        det.Venta3 = dt.Rows[0]["Venta3"].ToString();
        //        det.Cantidad4 = dt.Rows[0]["Cantidad4"].ToString();
        //        det.CantidadReal4 = dt.Rows[0]["CantidadReal4"].ToString();
        //        det.Venta4 = dt.Rows[0]["Venta4"].ToString();
        //        det.Cantidad5 = dt.Rows[0]["Cantidad5"].ToString();
        //        det.CantidadReal5 = dt.Rows[0]["CantidadReal5"].ToString();
        //        det.Venta5 = dt.Rows[0]["Venta5"].ToString();
        //        det.Cantidad6 = dt.Rows[0]["Cantidad6"].ToString();
        //        det.CantidadReal6 = dt.Rows[0]["CantidadReal6"].ToString();
        //        det.Venta6 = dt.Rows[0]["Venta6"].ToString();
        //        det.Cantidad7 = dt.Rows[0]["Cantidad7"].ToString();
        //        det.CantidadReal7 = dt.Rows[0]["CantidadReal7"].ToString();
        //        det.Venta7 = dt.Rows[0]["Venta7"].ToString();
        //        det.Cantidad8 = dt.Rows[0]["Cantidad8"].ToString();
        //        det.CantidadReal8 = dt.Rows[0]["CantidadReal8"].ToString();
        //        det.Venta8 = dt.Rows[0]["Venta8"].ToString();
        //        det.Cantidad9 = dt.Rows[0]["Cantidad9"].ToString();
        //        det.CantidadReal9 = dt.Rows[0]["CantidadReal9"].ToString();
        //        det.Venta9 = dt.Rows[0]["Venta9"].ToString();
        //        det.Cantidad10 = dt.Rows[0]["Cantidad10"].ToString();
        //        det.CantidadReal10 = dt.Rows[0]["CantidadReal10"].ToString();
        //        det.Venta10 = dt.Rows[0]["Venta10"].ToString();
        //        det.Cantidad11 = dt.Rows[0]["Cantidad11"].ToString();
        //        det.CantidadReal11 = dt.Rows[0]["CantidadReal11"].ToString();
        //        det.Venta11 = dt.Rows[0]["Venta11"].ToString();
        //        det.Cantidad12 = dt.Rows[0]["Cantidad12"].ToString();
        //        det.CantidadReal12 = dt.Rows[0]["CantidadReal12"].ToString();
        //        det.Venta12 = dt.Rows[0]["Venta12"].ToString();

        //    }
        //    return det;
        //}
    }

}
