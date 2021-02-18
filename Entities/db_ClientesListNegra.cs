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

    public class db_ClientesListNegra : ClComun
    {
        ClientesListNegra vClientesListNegraTabla = new ClientesListNegra();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ClientesListNegra ClientesListNegraTabla
        {
            get
            {
                return vClientesListNegraTabla;
            }
            set
            {
                vClientesListNegraTabla = value;
            }
        }

        //Fn fn = new Fn();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(ClientesListNegra ClientesListNegra, bool Tran = false)
        {
            object[] ObjParameter = new object[4];

            ObjParameter[0] = ClientesListNegra.IdCliente;
            ObjParameter[1] = ClientesListNegra.Empresa;
            ObjParameter[2] = ClientesListNegra.FechaInicio;
            //ObjParameter[3] = ClientesListNegra.FechaFin;
            ObjParameter[3] = ClientesListNegra.Comentario;
            //ObjParameter[5] = ClientesListNegra.Comentario2;
            //ObjParameter[6] = ClientesListNegra.Usuario;
            //ObjParameter[7] = ClientesListNegra.Registro;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ClientesListNegra", ObjParameter);
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
        public void Actualizar(ClientesListNegra ClientesListNegra, bool Tran = false)
        {
            object[] ObjParameter = new object[4];
            ObjParameter[0] = ClientesListNegra.IdLista;
            //ObjParameter[1] = ClientesListNegra.IdCliente;
            ObjParameter[1] = ClientesListNegra.Empresa;
            ObjParameter[2] = ClientesListNegra.FechaInicio;
           // ObjParameter[4] = ClientesListNegra.FechaFin;
            ObjParameter[3] = ClientesListNegra.Comentario;
            //ObjParameter[6] = ClientesListNegra.Comentario2;
            //ObjParameter[7] = ClientesListNegra.Usuario;
            //ObjParameter[8] = ClientesListNegra.Registro;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ClientesListNegra", ObjParameter);
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
        public DataTable Listar(int Id, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_ClientesListNegra", Id, Empresa);
        }

        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public DataTable Buscar(int IdCliente, int Empresa)
        //{
        //    return fn.ObtieneDatos("sp_sel_ClientesListNegraBuscar", IdCliente, Empresa);
        //}

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(ClientesListNegra ClientesListNegra, bool Tran = false)
        {
            object[] ObjParameter = new object[4];
            ObjParameter[0] = ClientesListNegra.IdLista;
            ObjParameter[1] = ClientesListNegra.Empresa;            
            ObjParameter[2] = ClientesListNegra.FechaFin;
            ObjParameter[3] = ClientesListNegra.Comentario2;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ClientesListNegra", ObjParameter);
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
        public ClientesListNegra Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesListNegra", Id, Empresa);
            ClientesListNegra det = new ClientesListNegra();

            if (dt.Rows.Count > 0)
            {

                det.IdLista = (int)dt.Rows[0]["IdLista"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.FechaInicio = dt.Rows[0]["FechaInicio"].ToString();
                det.FechaFin = dt.Rows[0]["FechaFin"].ToString();
                det.Comentario = dt.Rows[0]["Comentario"].ToString();
                det.Comentario2 = dt.Rows[0]["Comentario2"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Registro = dt.Rows[0]["Registro"].ToString();

            }
            return det;
        }

        public ClientesListNegra DetallesBuscar(int IdCliente, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesListNegraBuscar", IdCliente, Empresa);
            ClientesListNegra det = new ClientesListNegra();

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            if (dt.Rows.Count > 0)
            {

                det.IdLista = (int)dt.Rows[0]["IdLista"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.FechaInicio = dt.Rows[0]["FechaInicio"].ToString();
                det.FechaFin = dt.Rows[0]["FechaFin"].ToString();
                det.Comentario = dt.Rows[0]["Comentario"].ToString();
                det.Comentario2 = dt.Rows[0]["Comentario2"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Registro = dt.Rows[0]["Registro"].ToString();

            }
            return det;
        }
    }

}
