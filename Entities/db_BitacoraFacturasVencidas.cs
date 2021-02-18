namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_BitacoraFacturasVencidas : ClComun
    {
        BitacoraFacturasVencidas vBitacoraFacturasVencidasTabla = new BitacoraFacturasVencidas();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public BitacoraFacturasVencidas BitacoraFacturasVencidasTabla
        {
            get
            {
                return vBitacoraFacturasVencidasTabla;
            }
            set
            {
                vBitacoraFacturasVencidasTabla = value;
            }
        }        

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(BitacoraFacturasVencidas BitacoraFacturasVencidas, bool Tran = false)
        {
            object[] ObjParameter = new object[6];

            ObjParameter[0] = BitacoraFacturasVencidas.IdCliente;
            ObjParameter[1] = BitacoraFacturasVencidas.Empresa;
            ObjParameter[2] = BitacoraFacturasVencidas.Descripcion;
            ObjParameter[3] = BitacoraFacturasVencidas.Facturas;
            ObjParameter[4] = BitacoraFacturasVencidas.Moneda;
            ObjParameter[5] = BitacoraFacturasVencidas.Saldo;            

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_BitacoraFacturasVencidas", ObjParameter);
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
        public void Actualizar(BitacoraFacturasVencidas BitacoraFacturasVencidas, bool Tran = false)
        {
            object[] ObjParameter = new object[8];
            ObjParameter[0] = BitacoraFacturasVencidas.IdBitacora;
            ObjParameter[1] = BitacoraFacturasVencidas.IdCliente;
            ObjParameter[2] = BitacoraFacturasVencidas.Empresa;
            ObjParameter[3] = BitacoraFacturasVencidas.Descripcion;
            ObjParameter[4] = BitacoraFacturasVencidas.Facturas;
            ObjParameter[5] = BitacoraFacturasVencidas.Moneda;
            ObjParameter[6] = BitacoraFacturasVencidas.Saldo;
            ObjParameter[7] = BitacoraFacturasVencidas.Fecha_Creacion;
            ObjParameter[8] = BitacoraFacturasVencidas.Usuario;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_BitacoraFacturasVencidas", ObjParameter);
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
        public DataTable Listar(string Id)
        {
            return fn.ObtieneDatos("sp_sel_BitacoraFacturasVencidas", Id);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(BitacoraFacturasVencidas BitacoraFacturasVencidas, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = BitacoraFacturasVencidas.IdBitacora;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_BitacoraFacturasVencidas", ObjParameter);
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
        public BitacoraFacturasVencidas Detalles(string Id)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_BitacoraFacturasVencidas", Id);
            BitacoraFacturasVencidas det = new BitacoraFacturasVencidas();

            if (dt.Rows.Count > 0)
            {

                det.IdBitacora = (int)dt.Rows[0]["IdBitacora"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                det.Facturas = dt.Rows[0]["Facturas"].ToString();
                det.Moneda = dt.Rows[0]["Moneda"].ToString();
                det.Saldo = Convert.ToDouble(dt.Rows[0]["Saldo"]);
                det.Fecha_Creacion = Convert.ToDateTime(dt.Rows[0]["Fecha_Creacion"]);
                det.Usuario = dt.Rows[0]["Usuario"].ToString();

            }
            return det;
        }
    }


}
