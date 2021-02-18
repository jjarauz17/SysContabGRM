namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ClientesSeguimiento : ClComun
    {
        ClientesSeguimiento vClientesSeguimientoTabla = new ClientesSeguimiento();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ClientesSeguimiento ClientesSeguimientoTabla
        {
            get
            {
                return vClientesSeguimientoTabla;
            }
            set
            {
                vClientesSeguimientoTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ClientesSeguimiento ClientesSeguimiento, bool Tran = false)
        {
            object[] ObjParameter = new object[8];
            ObjParameter[0] = ClientesSeguimiento.IdCliente;
            ObjParameter[1] = ClientesSeguimiento.Empresa;
            ObjParameter[2] = ClientesSeguimiento.FechaLlamada;
            ObjParameter[3] = ClientesSeguimiento.FechaPago;
            ObjParameter[4] = ClientesSeguimiento.Acuerdo;
            ObjParameter[5] = ClientesSeguimiento.Descripcion;
            ObjParameter[6] = ClientesSeguimiento.Saldo;
            ObjParameter[7] = ClientesSeguimiento.HoraPago;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ClientesSeguimiento", ObjParameter);
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
        public void Actualizar(ClientesSeguimiento ClientesSeguimiento, bool Tran = false)
        {
            object[] ObjParameter = new object[9];
            ObjParameter[0] = ClientesSeguimiento.IdSeguimiento;
            ObjParameter[1] = ClientesSeguimiento.IdCliente;
            ObjParameter[2] = ClientesSeguimiento.Empresa;
            ObjParameter[3] = ClientesSeguimiento.FechaLlamada;
            ObjParameter[4] = ClientesSeguimiento.FechaPago;
            ObjParameter[5] = ClientesSeguimiento.Acuerdo;
            ObjParameter[6] = ClientesSeguimiento.Descripcion;
            ObjParameter[7] = ClientesSeguimiento.Saldo;
            ObjParameter[8] = ClientesSeguimiento.HoraPago;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ClientesSeguimiento", ObjParameter);
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
        public DataTable Listar(int Id, int IdCliente, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ClientesSeguimiento", Id, IdCliente, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public string Saldo(int IdCliente, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ClienteSeguimientoSaldoUSD", IdCliente, Empresa).Rows[0]["Saldo"].ToString();
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ClientesSeguimiento ClientesSeguimiento, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ClientesSeguimiento.IdSeguimiento;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ClientesSeguimiento", ObjParameter);
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
        public ClientesSeguimiento Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesSeguimiento", Id, 0, Empresa);
            ClientesSeguimiento det = new ClientesSeguimiento();

            if (dt.Rows.Count > 0)
            {
                det.IdSeguimiento = (int)dt.Rows[0]["IdSeguimiento"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.FechaLlamada = dt.Rows[0]["FechaLlamada"].ToString();
                det.FechaPago = dt.Rows[0]["FechaPago"].ToString();
                det.HoraPago = dt.Rows[0]["HoraPago"].ToString();
                det.Acuerdo = dt.Rows[0]["Acuerdo"].ToString();
                det.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                det.Saldo = Convert.ToDouble(dt.Rows[0]["Saldo"]);
                det.Fecha_Creacion = dt.Rows[0]["Fecha_Creacion"].ToString();
                det.Fecha_Modificacion = dt.Rows[0]["Fecha_Modificacion"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Usuario_Modifica = dt.Rows[0]["Usuario_Modifica"].ToString();
                det.Activo = (bool)dt.Rows[0]["Activo"] == true ? 1 : 0;
            }
            return det;
        }
    }

}
