namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_Distribucion : ClComun
    {
        Distribucion vDistribucionTabla = new Distribucion();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public Distribucion DistribucionTabla
        {
            get
            {
                return vDistribucionTabla;
            }
            set
            {
                vDistribucionTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(Distribucion Distribucion, 
            bool Tran = false,
            SqlConnection DBConnection = null,
            SqlTransaction DBTransaction = null)
        {
            object[] ObjParameter = new object[9];
            ObjParameter[0] = Distribucion.IdEmpresa;
            ObjParameter[1] = Distribucion.NoComp;
            ObjParameter[2] = Distribucion.Mes;
            ObjParameter[3] = Distribucion.Per_Id;
            ObjParameter[4] = Distribucion.IdRubroGasto;
            ObjParameter[5] = Distribucion.IdCentroCosto;
            ObjParameter[6] = Distribucion.Valor;
            ObjParameter[7] = Distribucion.Tipo;
            ObjParameter[8] = Distribucion.Cuenta;

            //ObjParameter[9] = Distribucion.IdSubCentro;
            //ObjParameter[10] = Distribucion.Usuario;
            //ObjParameter[11] = Distribucion.Fecha_Creacion;

            try
            {
                this.InicializarMensajeError();            
                SqlCommand cmd = new SqlCommand();

                if (Tran == false)
                {
                    this.OpenSqlBD();

                    cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Distribucion", ObjParameter);
                    cmd.ExecuteNonQuery();
                    Commit();
                }
                else
                {
                    cmd = this.ConfigurarComando("sp_ins_Distribucion", DBConnection, DBTransaction, ObjParameter);
                    cmd.ExecuteNonQuery();
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
        public void Actualizar(Distribucion Distribucion, 
            bool Tran = false,
            SqlConnection DBConnection = null,
            SqlTransaction DBTransaction = null)
        {
            object[] ObjParameter = new object[10];
            ObjParameter[1] = Distribucion.IdEmpresa;
            ObjParameter[2] = Distribucion.NoComp;
            ObjParameter[3] = Distribucion.Mes;
            ObjParameter[4] = Distribucion.Per_Id;
            ObjParameter[5] = Distribucion.IdRubroGasto;
            ObjParameter[6] = Distribucion.IdCentroCosto;
            ObjParameter[7] = Distribucion.Valor;
            ObjParameter[8] = Distribucion.Tipo;
            ObjParameter[9] = Distribucion.Cuenta;
            ObjParameter[10] = Distribucion.IdDetalle;

            //ObjParameter[10] = Distribucion.IdSubCentro;
            //ObjParameter[11] = Distribucion.Usuario;
            //ObjParameter[12] = Distribucion.Fecha_Creacion;

            try
            {
                this.InicializarMensajeError();
                SqlCommand cmd = new SqlCommand();

                if (Tran == false)
                {
                    this.OpenSqlBD();

                    cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Distribucion", ObjParameter);
                    cmd.ExecuteNonQuery();
                    Commit();
                }
                else
                {
                    cmd = this.ConfigurarComando("sp_upd_Distribucion", DBConnection, DBTransaction, ObjParameter);
                    cmd.ExecuteNonQuery();
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
        public void Actualizar2(Distribucion Distribucion,
            bool Tran = false,
            SqlConnection DBConnection = null,
            SqlTransaction DBTransaction = null)

        {
            object[] ObjParameter = new object[7];
            
            ObjParameter[0] = Distribucion.NoComp;
            ObjParameter[1] = Distribucion.Mes;
            ObjParameter[2] = Distribucion.Per_Id;
            ObjParameter[3] = Distribucion.NoCompO;
            ObjParameter[4] = Distribucion.MesO;
            ObjParameter[5] = Distribucion.Per_IdO;
            ObjParameter[6] = Distribucion.IdEmpresa;
            
            try
            {
                this.InicializarMensajeError();
                SqlCommand cmd = new SqlCommand();

                if (Tran == false)
                {
                    this.OpenSqlBD();

                    cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Distribucion2", ObjParameter);
                    cmd.ExecuteNonQuery();
                    Commit();
                }
                else
                {
                    cmd = this.ConfigurarComando("sp_upd_Distribucion2", DBConnection, DBTransaction, ObjParameter);
                    cmd.ExecuteNonQuery();
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
        public DataTable CargaDistribucion(int Comp_No, 
            int Per_Id, 
            int Mes, 
            int Empresa,
            string Cuenta = "")
        {
            return fn.ObtieneDatos("sp_sel_Distribucion", 0, Comp_No, Per_Id, Mes, Empresa, Cuenta);            
        }

        public DataTable CargaDistribucionTrans(SqlConnection DBConnection,
            SqlTransaction DBTransaction,
            int Comp_No,
            int Per_Id,
            int Mes,
            int Empresa,
            string Cuenta = "")
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_sel_Distribucion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID",0);
            cmd.Parameters.AddWithValue("@Comp_No",Comp_No);
            cmd.Parameters.AddWithValue("@Per_Id", Per_Id);
            cmd.Parameters.AddWithValue("@Mes", Mes);
            cmd.Parameters.AddWithValue("@Empresa", Empresa);

            try
            {
                cmd.Connection = DBConnection;
                cmd.Transaction = DBTransaction;
                cmd.CommandTimeout = 0;
                da.SelectCommand = cmd;
                //SqlCommandBuilder.DeriveParameters(cmd);

                da.Fill(dt);                
            }
            catch (Exception ex)
            {
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                dt = null;
                da = null;
                cmd = null;
            }

            return dt;

            //return fn.ObtieneDatos("sp_sel_Distribucion", Comp_No, Per_Id, Mes, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(Distribucion Distribucion, 
            bool Tran = false, 
            SqlConnection DBConnection = null,
            SqlTransaction DBTransaction = null)
        {
            object[] ObjParameter = new object[5];
            ObjParameter[0] = Distribucion.IdDetalle;
            ObjParameter[1] = Distribucion.IdEmpresa;
            ObjParameter[2] = Distribucion.NoComp;
            ObjParameter[3] = Distribucion.Mes;
            ObjParameter[4] = Distribucion.Per_Id;

            try
            {
                this.InicializarMensajeError();                
                SqlCommand cmd = new SqlCommand();

                if (Tran == false)
                {
                    this.OpenSqlBD();

                    cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_Distribucion", ObjParameter);                    
                    cmd.ExecuteNonQuery();
                    Commit();
                }
                else {
                    cmd = this.ConfigurarComando("sp_del_Distribucion", DBConnection, DBTransaction, ObjParameter);                    
                    cmd.ExecuteNonQuery();
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
        public Distribucion Detalles(int Id)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_Distribucion", Id,0,0,0,0);
            Distribucion det = new Distribucion();

            if (dt.Rows.Count > 0)
            {

                det.IdEmpresa = (int)dt.Rows[0]["IdEmpresa"];
                det.NoComp = (int)dt.Rows[0]["NoComp"];
                det.Mes = (int)dt.Rows[0]["Mes"];
                det.Per_Id = (int)dt.Rows[0]["Per_Id"];
                det.IdRubroGasto = (int)dt.Rows[0]["IdRubroGasto"];
                det.IdCentroCosto = (int)dt.Rows[0]["IdCentroCosto"];
                det.Valor = Convert.ToDouble( dt.Rows[0]["Valor"]);
                det.Tipo = dt.Rows[0]["Tipo"].ToString();
                det.Cuenta = dt.Rows[0]["Cuenta"].ToString();
                det.IdDetalle = (int)dt.Rows[0]["IdDetalle"];
                //det.IdSubCentro = dt.Rows[0]["IdSubCentro"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Fecha_Creacion = dt.Rows[0]["Fecha_Creacion"].ToString();

            }
            return det;
        }
    }

}
