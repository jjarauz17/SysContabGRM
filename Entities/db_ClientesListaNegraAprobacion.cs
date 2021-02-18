namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ClientesListaNegraAprobacion : ClComun
    {
        ClientesListaNegraAprobacion vClientesListaNegraAprobacionTabla = new ClientesListaNegraAprobacion();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ClientesListaNegraAprobacion ClientesListaNegraAprobacionTabla
        {
            get
            {
                return vClientesListaNegraAprobacionTabla;
            }
            set
            {
                vClientesListaNegraAprobacionTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ClientesListaNegraAprobacion ClientesListaNegraAprobacion, bool Tran = false)
        {
            object[] ObjParameter = new object[8];

            ObjParameter[0] = ClientesListaNegraAprobacion.IdCliente;
            ObjParameter[1] = ClientesListaNegraAprobacion.Empresa;
            ObjParameter[2] = ClientesListaNegraAprobacion.Factura;
            ObjParameter[3] = ClientesListaNegraAprobacion.Codigo;
            ObjParameter[4] = ClientesListaNegraAprobacion.CorreoEnviado;
            ObjParameter[5] = ClientesListaNegraAprobacion.ErrorEnvio;
            ObjParameter[6] = ClientesListaNegraAprobacion.MailTo;
            ObjParameter[7] = ClientesListaNegraAprobacion.Tipo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ClientesListaNegraAprobacion", ObjParameter);
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
        public void Actualizar(ClientesListaNegraAprobacion ClientesListaNegraAprobacion, bool Tran = false)
        {
            object[] ObjParameter = new object[8];
            ObjParameter[0] = ClientesListaNegraAprobacion.Id;
            ObjParameter[1] = ClientesListaNegraAprobacion.IdCliente;
            ObjParameter[2] = ClientesListaNegraAprobacion.Empresa;
            ObjParameter[3] = ClientesListaNegraAprobacion.Factura;
            ObjParameter[4] = ClientesListaNegraAprobacion.Codigo;
            ObjParameter[5] = ClientesListaNegraAprobacion.CorreoEnviado;
            ObjParameter[6] = ClientesListaNegraAprobacion.ErrorEnvio;
            ObjParameter[7] = ClientesListaNegraAprobacion.Fecha_Envio;            

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ClientesListaNegraAprobacion", ObjParameter);
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
        public DataTable Listar(DateTime Desde, DateTime Hasta, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ClientesListaNegraAprobacion", 0, Desde.Date, Hasta.Date, Empresa);
        }     

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ClientesListaNegraAprobacion ClientesListaNegraAprobacion, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ClientesListaNegraAprobacion.Id;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ClientesListaNegraAprobacion", ObjParameter);
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
        public ClientesListaNegraAprobacion Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesListaNegraAprobacion", Id, DateTime.Now.Date, DateTime.Now.Date, Empresa);
            ClientesListaNegraAprobacion det = new ClientesListaNegraAprobacion();

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            if (dt.Rows.Count > 0)
            {

                det.Id = (int)dt.Rows[0]["Id"];
                det.Tipo = dt.Rows[0]["Tipo"].ToString();
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Factura = dt.Rows[0]["Factura"].ToString();
                det.Codigo = dt.Rows[0]["Codigo"].ToString();
                det.CorreoEnviado = (bool)dt.Rows[0]["CorreoEnviado"] ? 1 : 0;
                det.ErrorEnvio = dt.Rows[0]["ErrorEnvio"].ToString();
                det.Fecha_Envio = Convert.ToDateTime(dt.Rows[0]["Fecha_Envio"]);
                det.Usado = (bool)dt.Rows[0]["Usado"] ? 1 : 0;
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.MailTo = dt.Rows[0]["MailTo"].ToString();

            }
            return det;
        }

        public ClientesListaNegraAprobacion Detalles(int IdCliente, string Factura, string Tipo, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesListaNegraValidar", IdCliente, Factura, Tipo, Empresa);
            ClientesListaNegraAprobacion det = new ClientesListaNegraAprobacion();

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            if (dt.Rows.Count > 0)
            {
                det.Id = (int)dt.Rows[0]["Id"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Factura = dt.Rows[0]["Factura"].ToString();
                det.Codigo = dt.Rows[0]["Codigo"].ToString();
                det.CorreoEnviado = (bool)dt.Rows[0]["CorreoEnviado"] ? 1: 0;
                det.ErrorEnvio = dt.Rows[0]["ErrorEnvio"].ToString();
                det.Fecha_Envio = Convert.ToDateTime( dt.Rows[0]["Fecha_Envio"]);
                det.Usado = (bool)dt.Rows[0]["Usado"] ? 1 : 0;
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.MailTo = dt.Rows[0]["MailTo"].ToString();
                det.Tipo = dt.Rows[0]["Tipo"].ToString();
            }

            return det;


        }
    }

}
