namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_BitacoraEnvioEC : ClComun
    {
        BitacoraEnvioEC vBitacoraEnvioECTabla = new BitacoraEnvioEC();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public BitacoraEnvioEC BitacoraEnvioECTabla
        {
            get
            {
                return vBitacoraEnvioECTabla;
            }
            set
            {
                vBitacoraEnvioECTabla = value;
            }
        }

       // fn fn = new Fn();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(BitacoraEnvioEC BitacoraEnvioEC, bool Tran = false)
        {
            object[] ObjParameter = new object[9];
            ObjParameter[0] = BitacoraEnvioEC.Empresa;
            ObjParameter[1] = BitacoraEnvioEC.MailTo;
            ObjParameter[2] = BitacoraEnvioEC.Asunto;
            ObjParameter[3] = BitacoraEnvioEC.Cliente;
            ObjParameter[4] = BitacoraEnvioEC.AlCorte;
            ObjParameter[5] = BitacoraEnvioEC.Sucursal;
            ObjParameter[6] = BitacoraEnvioEC.Adjunto;
            ObjParameter[7] = BitacoraEnvioEC.ErrorMsg;
            ObjParameter[8] = BitacoraEnvioEC.Enviado;            

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_BitacoraEnvioEC", ObjParameter);
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
        //public void Actualizar(BitacoraEnvioEC BitacoraEnvioEC, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[11];
        //    ObjParameter[0] = BitacoraEnvioEC.IdBitacora;
        //    ObjParameter[1] = BitacoraEnvioEC.Empresa;
        //    ObjParameter[2] = BitacoraEnvioEC.MailTo;
        //    ObjParameter[3] = BitacoraEnvioEC.Asunto;
        //    ObjParameter[4] = BitacoraEnvioEC.Cliente;
        //    ObjParameter[5] = BitacoraEnvioEC.AlCorte;
        //    ObjParameter[6] = BitacoraEnvioEC.Sucursal;
        //    ObjParameter[7] = BitacoraEnvioEC.Adjunto;
        //    ObjParameter[8] = BitacoraEnvioEC.ErrorMsg;
        //    ObjParameter[9] = BitacoraEnvioEC.Enviado;
        //    ObjParameter[10] = BitacoraEnvioEC.Usuario;
        //    ObjParameter[11] = BitacoraEnvioEC.Fecha_Envio;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_BitacoraEnvioEC", ObjParameter);
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
        public DataTable Listar(DateTime Desde, DateTime Hasta, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_BitacoraEnvioEC", Desde, Hasta, Empresa);
        }

        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Borrar(BitacoraEnvioEC BitacoraEnvioEC, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[2];
        //    ObjParameter[0] = BitacoraEnvioEC.IdBitacora;
        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_BitacoraEnvioEC", ObjParameter);
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
        public BitacoraEnvioEC Detalles(int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_BitacoraEnvioEC", DateTime.Now.Date , DateTime.Now.Date, Empresa);
            BitacoraEnvioEC det = new BitacoraEnvioEC();

            if (dt.Rows.Count > 0)
            {

                det.IdBitacora = (int)dt.Rows[0]["IdBitacora"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.MailTo = dt.Rows[0]["MailTo"].ToString();
                det.Asunto = dt.Rows[0]["Asunto"].ToString();
                det.Cliente = dt.Rows[0]["Cliente"].ToString();
                det.AlCorte = dt.Rows[0]["AlCorte"].ToString();
                det.Sucursal = dt.Rows[0]["Sucursal"].ToString();
                det.Adjunto = dt.Rows[0]["Adjunto"].ToString();
                det.ErrorMsg = dt.Rows[0]["ErrorMsg"].ToString();
                det.Enviado = (int)dt.Rows[0]["Enviado"];
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Fecha_Envio = dt.Rows[0]["Fecha_Envio"].ToString();

            }
            return det;
        }
    }

}
