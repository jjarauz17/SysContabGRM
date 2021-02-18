namespace Entities
{    
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ClientesComiteCredito : ClComun
    {
        ClientesComiteCredito vClientesComiteCreditoTabla = new ClientesComiteCredito();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ClientesComiteCredito ClientesComiteCreditoTabla
        {
            get
            {
                return vClientesComiteCreditoTabla;
            }
            set
            {
                vClientesComiteCreditoTabla = value;
            }
        }        

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ClientesComiteCredito ClientesComiteCredito, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ClientesComiteCredito.IdUsuario;
            ObjParameter[1] = ClientesComiteCredito.Empresa;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ClientesComiteCredito", ObjParameter);
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
        //public void Actualizar(ClientesComiteCredito ClientesComiteCredito, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[2];
        //    ObjParameter[0] = ClientesComiteCredito.IdComite;
        //    ObjParameter[1] = ClientesComiteCredito.IdUsuario;
        //    ObjParameter[2] = ClientesComiteCredito.Empresa;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ClientesComiteCredito", ObjParameter);
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
        public DataTable Listar(int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ClientesComiteCredito", 0, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ClientesComiteCredito ClientesComiteCredito, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ClientesComiteCredito.IdUsuario;
            ObjParameter[1] = ClientesComiteCredito.Empresa;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ClientesComiteCredito", ObjParameter);
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
        public ClientesComiteCredito Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesComiteCredito", Id, Empresa);
            ClientesComiteCredito det = new ClientesComiteCredito();

            if (dt.Rows.Count > 0)
            {

                det.IdComite = (int)dt.Rows[0]["IdComite"];
                det.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];

            }
            else {
                return null;
            }

            return det;
        }
    }


}
