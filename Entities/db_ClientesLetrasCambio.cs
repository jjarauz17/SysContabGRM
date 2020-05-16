namespace Entities
{
    using System;    
    using DevExpress.XtraReports.UI;    
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_ClientesLetrasCambio : ClComun
    {
        ClientesLetrasCambio vClientesLetrasCambioTabla = new ClientesLetrasCambio();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ClientesLetrasCambio ClientesLetrasCambioTabla
        {
            get
            {
                return vClientesLetrasCambioTabla;
            }
            set
            {
                vClientesLetrasCambioTabla = value;
            }
        }

       // Fn fn = new Fn();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public bool Insertar(ClientesLetrasCambio ClientesLetrasCambio, bool Tran = false)
        {
            object[] ObjParameter = new object[11];
            ObjParameter[0] = ClientesLetrasCambio.Empresa;
            ObjParameter[1] = ClientesLetrasCambio.IdCliente;
            ObjParameter[2] = ClientesLetrasCambio.ANombre;
            ObjParameter[3] = ClientesLetrasCambio.NEmpresa;
            ObjParameter[4] = ClientesLetrasCambio.Fecha;
            ObjParameter[5] = ClientesLetrasCambio.Vencimiento;
            ObjParameter[6] = ClientesLetrasCambio.Moneda;
            ObjParameter[7] = ClientesLetrasCambio.Monto;
            ObjParameter[8] = ClientesLetrasCambio.EnLetras;
            ObjParameter[9] = ClientesLetrasCambio.TCambio;
            ObjParameter[10] = ClientesLetrasCambio.Comentarios;
                        
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ClientesLetrasCambio", ObjParameter);
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
        public bool Actualizar(ClientesLetrasCambio ClientesLetrasCambio, bool Tran = false)
        {
            object[] ObjParameter = new object[12];
            ObjParameter[0] = ClientesLetrasCambio.Id;
            ObjParameter[1] = ClientesLetrasCambio.Empresa;
            ObjParameter[2] = ClientesLetrasCambio.IdCliente;
            ObjParameter[3] = ClientesLetrasCambio.ANombre;
            ObjParameter[4] = ClientesLetrasCambio.NEmpresa;
            ObjParameter[5] = ClientesLetrasCambio.Fecha;
            ObjParameter[6] = ClientesLetrasCambio.Vencimiento;
            ObjParameter[7] = ClientesLetrasCambio.Moneda;
            ObjParameter[8] = ClientesLetrasCambio.Monto;
            ObjParameter[9] = ClientesLetrasCambio.EnLetras;
            ObjParameter[10] = ClientesLetrasCambio.TCambio;
            ObjParameter[11] = ClientesLetrasCambio.Comentarios;
            

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ClientesLetrasCambio", ObjParameter);
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
        public DataTable Listar(string Id, int Empresa, DateTime Desde, DateTime Hasta)
        {
            return fn.ObtieneDatos("sp_sel_ClientesLetrasCambio", Id, Desde.Date, Hasta.Date, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Imprimir(int Id, int Empresa)
        {
            bool Temp = fn.FormatoImpreso(29, "rptLetraCambio", Empresa);

            XtraReport rpt;

            if (Temp)
            {
                rpt = XtraReport.FromFile($"{Application.StartupPath}\\rptLetraCambio.repx",true);
            } else {
                rpt = new rptLetraCambio();
            }

            rpt.DataSource = fn.ObtieneDatos("sp_sel_ClientesLetraCambioImprimir",Id, Empresa);
            rpt.ShowRibbonPreview();
        }


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public bool Borrar(ClientesLetrasCambio ClientesLetrasCambio, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = ClientesLetrasCambio.Id;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_ClientesLetrasCambio", ObjParameter);
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
        public ClientesLetrasCambio Detalles(string Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_ClientesLetrasCambio", Id, DateTime.Now.Date, DateTime.Now.Date, Empresa);
            ClientesLetrasCambio det = new ClientesLetrasCambio();

            if (dt.Rows.Count > 0)
            {

                det.Id = (int)dt.Rows[0]["Id"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.IdCliente = (int)dt.Rows[0]["IdCliente"];
                det.ANombre = dt.Rows[0]["ANombre"].ToString();
                det.NEmpresa = dt.Rows[0]["NEmpresa"].ToString();
                det.Fecha = dt.Rows[0]["Fecha"].ToString();
                det.Vencimiento = dt.Rows[0]["Vencimiento"].ToString();
                det.Moneda = dt.Rows[0]["Moneda"].ToString();
                det.Monto = Convert.ToDouble(dt.Rows[0]["Monto"]);
                det.EnLetras = dt.Rows[0]["EnLetras"].ToString();
                det.TCambio = Convert.ToDouble(dt.Rows[0]["TCambio"]);
                det.Comentarios = dt.Rows[0]["Comentarios"].ToString();
                det.Estado = dt.Rows[0]["Estado"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Fecha_Creacion = dt.Rows[0]["Fecha_Creacion"].ToString();

            }
            return det;
        }
    }

}
