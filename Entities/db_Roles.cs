namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_Roles : ClComun
    {
        Roles vREST_RolesTabla = new Roles();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public Roles REST_RolesTabla
        {
            get
            {
                return vREST_RolesTabla;
            }
            set
            {
                vREST_RolesTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public object Insertar(Roles REST_Roles, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = REST_Roles.ID;
            ObjParameter[1] = REST_Roles.Nombre;
            ObjParameter[2] = REST_Roles.Descripcion;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_REST_Roles", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return cmd.Parameters[1].Value;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return 0;
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
        public bool Actualizar(Roles REST_Roles, bool Tran = false)
        {
            object[] ObjParameter = new object[3];
            ObjParameter[0] = REST_Roles.ID;
            ObjParameter[1] = REST_Roles.Nombre;
            ObjParameter[2] = REST_Roles.Descripcion;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_REST_Roles", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return false;
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
        public DataTable Listar(int Id)
        {
            return fn.ObtieneDatos("sp_sel_REST_Roles", Id);
        }


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable Arbol(int Id)
        {
            return fn.ObtieneDatos("_REST_ArbolRoles", Id);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable ArbolFiltrado(int Id)
        {
            return fn.ObtieneDatos("JAR_ArbolRolesFiltrado", Id);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public DataTable UsuariosRoles(int Id)
        {
            return fn.ObtieneDatos("sp_sel_UsuariosRoles", Id);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public bool Borrar(Roles REST_Roles, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = REST_Roles.ID;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_REST_Roles", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return false;
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
        public bool Clonar(Roles REST_Roles, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = REST_Roles.ID;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "JAR_ClonarRol", ObjParameter);
                cmd.ExecuteNonQuery();

                if (Tran == false)
                {
                    Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                this.CodigoError = -1;
                if (Tran == false)
                {
                    Rollback();
                }
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return false;
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
        public Roles Detalles(int Id)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_REST_Roles", Id);
            Roles det = new Roles();

            if (dt.Rows.Count > 0)
            {

                det.ID = (int)dt.Rows[0]["ID"];
                det.Nombre = dt.Rows[0]["Nombre"].ToString();
                det.Descripcion = dt.Rows[0]["Descripcion"].ToString();

            }
            return det;
        }
    }

}
