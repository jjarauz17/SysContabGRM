namespace Entities
{   
    using System;
    using System.Data;
    using DevExpress.XtraEditors;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_CamposRequeridos : ClComun
    {
        CamposRequeridos vCamposRequeridosTabla = new CamposRequeridos();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public CamposRequeridos CamposRequeridosTabla
        {
            get
            {
                return vCamposRequeridosTabla;
            }
            set
            {
                vCamposRequeridosTabla = value;
            }
        }

        //fn fn = new Fn();        

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(CamposRequeridos CamposRequeridos, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = CamposRequeridos.Empresa;
            ObjParameter[1] = CamposRequeridos.Formulario;
            ObjParameter[2] = CamposRequeridos.Campo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CamposRequeridos", ObjParameter);
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
        public void Actualizar(CamposRequeridos CamposRequeridos, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = CamposRequeridos.IdRequerido;
            ObjParameter[1] = CamposRequeridos.Empresa;
            ObjParameter[2] = CamposRequeridos.Formulario;
            ObjParameter[3] = CamposRequeridos.Campo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CamposRequeridos", ObjParameter);
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
        public DataTable Listar(string Formulario, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_CamposRequeridos", 
                Formulario, 
                Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void SetCamposRequeridos(DevExpress.XtraLayout.LayoutControl ly,
            string Formulario, 
            int Empresa)
        {

            DataTable _dt = 
                Listar(Formulario, Empresa);

            if (_dt.Rows.Count > 0)
            {                
              for (int i = 0; i <= _dt.Rows.Count - 1; i++)
              {                    
                 foreach (object c in ly.Controls)
                 {
                        if (c is TextEdit)
                        {
                            TextEdit text = (TextEdit)c;
                            if (text.Name.ToString().Equals(_dt.Rows[i]["Campo"].ToString()))
                                text.Tag = "True";
                        }

                        if (c is MemoEdit)
                        {
                            MemoEdit memo = (MemoEdit)c;
                            if (memo.Name.ToString().Equals(_dt.Rows[i]["Campo"].ToString()))
                                memo.Tag = "True";
                        }                       
                  }                                     
               }
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(CamposRequeridos CamposRequeridos, bool Tran = false)
        {
            object[] ObjParameter = new string[2];
            ObjParameter[0] = CamposRequeridos.IdRequerido;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_CamposRequeridos", ObjParameter);
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
        public CamposRequeridos Detalles(string Formulario, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_CamposRequeridos", Formulario, Empresa);
            CamposRequeridos det = new CamposRequeridos();

            if (dt.Rows.Count > 0)
            {

                det.IdRequerido = (int)dt.Rows[0]["IdRequerido"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Formulario = dt.Rows[0]["Formulario"].ToString();
                det.Campo = dt.Rows[0]["Campo"].ToString();

            }
            return det;
        }
    }

}
