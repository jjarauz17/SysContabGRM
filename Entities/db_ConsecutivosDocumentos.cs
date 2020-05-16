using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ConsecutivosDocumentos : ClComun
    {
        ConsecutivosDocumentos vConsecutivosDocumentosTabla = new ConsecutivosDocumentos();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ConsecutivosDocumentos ConsecutivosDocumentosTabla
        {
            get
            {
                return vConsecutivosDocumentosTabla;
            }
            set
            {
                vConsecutivosDocumentosTabla = value;
            }
        }

        //Fn fn = new Fn();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ConsecutivosDocumentos ConsecutivosDocumentos, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = ConsecutivosDocumentos.Empresa;
            ObjParameter[1] = ConsecutivosDocumentos.Documento;
            ObjParameter[2] = ConsecutivosDocumentos.Consecutivo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ConsecutivosDocumentos", ObjParameter);
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
        public void Actualizar(ConsecutivosDocumentos ConsecutivosDocumentos, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = ConsecutivosDocumentos.Id;
            ObjParameter[1] = ConsecutivosDocumentos.Empresa;
            ObjParameter[2] = ConsecutivosDocumentos.Documento;
            ObjParameter[3] = ConsecutivosDocumentos.Consecutivo;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ConsecutivosDocumentos", ObjParameter);
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
        public DataTable Listar(int Empresa, string Documento)
        {
            return fn.ObtieneDatos("sp_sel_ConsecutivosDocumentos", Documento, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public int Ultimo(int Empresa, string Documento)
        {
            return (int)fn.ObtieneDatos("sp_sel_GetConsecutivosUltimos", Documento, Empresa).Rows[0]["Consecutivo"];
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ConsecutivosDocumentos ConsecutivosDocumentos, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = ConsecutivosDocumentos.Id;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ConsecutivosDocumentos", ObjParameter);
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
        public ConsecutivosDocumentos Detalles(int Empresa, string Documento)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ConsecutivosDocumentos",Documento, Empresa);
            ConsecutivosDocumentos det = new ConsecutivosDocumentos();

            if (dt.Rows.Count > 0)
            {
                det.Id = (int)dt.Rows[0]["Id"];
               // det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Documento = dt.Rows[0]["Documento"].ToString();
                det.Consecutivo = (int)dt.Rows[0]["Consecutivo"];

            }
            else {
                return null;
            }
            return det;
        }
    }


}
