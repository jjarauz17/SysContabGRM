namespace Entities
{    
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_EMPRESAS : ClComun
    {
        EMPRESAS vEMPRESASTabla = new EMPRESAS();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public EMPRESAS EMPRESASTabla
        {
            get
            {
                return vEMPRESASTabla;
            }
            set
            {
                vEMPRESASTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Insertar(EMPRESAS EMPRESAS, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[52];
        //    ObjParameter[0] = EMPRESAS.CODIGO;
        //    ObjParameter[1] = EMPRESAS.NOMBRE;
        //    ObjParameter[2] = EMPRESAS.CIUDAD;
        //    ObjParameter[3] = EMPRESAS.PAIS;
        //    ObjParameter[4] = EMPRESAS.TELEFONO;
        //    ObjParameter[5] = EMPRESAS.CONTADOR;
        //    ObjParameter[6] = EMPRESAS.MES;
        //    ObjParameter[7] = EMPRESAS.ANIO;
        //    ObjParameter[8] = EMPRESAS.FECHA_INICIOAF;
        //    ObjParameter[9] = EMPRESAS.FECHA_CIERREAF;
        //    ObjParameter[10] = EMPRESAS.DECIMALES;
        //    ObjParameter[11] = EMPRESAS.MAYOR;
        //    ObjParameter[12] = EMPRESAS.SC01;
        //    ObjParameter[13] = EMPRESAS.SC02;
        //    ObjParameter[14] = EMPRESAS.SC03;
        //    ObjParameter[15] = EMPRESAS.SC04;
        //    ObjParameter[16] = EMPRESAS.SC05;
        //    ObjParameter[17] = EMPRESAS.SC06;
        //    ObjParameter[18] = EMPRESAS.SC07;
        //    ObjParameter[19] = EMPRESAS.SC08;
        //    ObjParameter[20] = EMPRESAS.SC09;
        //    ObjParameter[21] = EMPRESAS.emp_monedabase;
        //    ObjParameter[22] = EMPRESAS.emp_monedasalario;
        //    ObjParameter[23] = EMPRESAS.empr_umpv;
        //    ObjParameter[24] = EMPRESAS.EMPR_UMPA;
        //    ObjParameter[25] = EMPRESAS.empr_MPA;
        //    ObjParameter[26] = EMPRESAS.empr_logo;
        //    ObjParameter[27] = EMPRESAS.REPRESENTANTE;
        //    ObjParameter[28] = EMPRESAS.REP_CEDULA;
        //    ObjParameter[29] = EMPRESAS.Espacio;
        //    ObjParameter[30] = EMPRESAS.cant_marca_reloj;
        //    ObjParameter[31] = EMPRESAS.emp_UMCD;
        //    ObjParameter[32] = EMPRESAS.emp_MCS;
        //    ObjParameter[33] = EMPRESAS.empr_GMT;
        //    ObjParameter[34] = EMPRESAS.Pais_ID;
        //    ObjParameter[35] = EMPRESAS.Cot_Editable;
        //    ObjParameter[36] = EMPRESAS.IdGMT;
        //    ObjParameter[37] = EMPRESAS.Region;
        //    ObjParameter[38] = EMPRESAS.OC_Exento;
        //    ObjParameter[39] = EMPRESAS.Grupo;
        //    ObjParameter[40] = EMPRESAS.Alias;
        //    ObjParameter[41] = EMPRESAS.Ruc;
        //    ObjParameter[42] = EMPRESAS.Correo;
        //    ObjParameter[43] = EMPRESAS.CodigoPais;
        //    ObjParameter[44] = EMPRESAS.Fax;
        //    ObjParameter[45] = EMPRESAS.Direccion;
        //    ObjParameter[46] = EMPRESAS.NombreComercial;
        //    ObjParameter[47] = EMPRESAS.ValidarTCambio;
        //    ObjParameter[48] = EMPRESAS.ValidarFacturasVencidas;
        //    ObjParameter[49] = EMPRESAS.CodigoActividad;
        //    ObjParameter[50] = EMPRESAS.ValidarLimiteCredito;
        //    ObjParameter[51] = EMPRESAS.CobrosEditable;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_EMPRESAS", ObjParameter);
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


        ////-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Actualizar(EMPRESAS EMPRESAS, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[52];
        //    ObjParameter[1] = EMPRESAS.CODIGO;
        //    ObjParameter[2] = EMPRESAS.NOMBRE;
        //    ObjParameter[3] = EMPRESAS.CIUDAD;
        //    ObjParameter[4] = EMPRESAS.PAIS;
        //    ObjParameter[5] = EMPRESAS.TELEFONO;
        //    ObjParameter[6] = EMPRESAS.CONTADOR;
        //    ObjParameter[7] = EMPRESAS.MES;
        //    ObjParameter[8] = EMPRESAS.ANIO;
        //    ObjParameter[9] = EMPRESAS.FECHA_INICIOAF;
        //    ObjParameter[10] = EMPRESAS.FECHA_CIERREAF;
        //    ObjParameter[11] = EMPRESAS.DECIMALES;
        //    ObjParameter[12] = EMPRESAS.MAYOR;
        //    ObjParameter[13] = EMPRESAS.SC01;
        //    ObjParameter[14] = EMPRESAS.SC02;
        //    ObjParameter[15] = EMPRESAS.SC03;
        //    ObjParameter[16] = EMPRESAS.SC04;
        //    ObjParameter[17] = EMPRESAS.SC05;
        //    ObjParameter[18] = EMPRESAS.SC06;
        //    ObjParameter[19] = EMPRESAS.SC07;
        //    ObjParameter[20] = EMPRESAS.SC08;
        //    ObjParameter[21] = EMPRESAS.SC09;
        //    ObjParameter[22] = EMPRESAS.emp_monedabase;
        //    ObjParameter[23] = EMPRESAS.emp_monedasalario;
        //    ObjParameter[24] = EMPRESAS.empr_umpv;
        //    ObjParameter[25] = EMPRESAS.EMPR_UMPA;
        //    ObjParameter[26] = EMPRESAS.empr_MPA;
        //    ObjParameter[27] = EMPRESAS.empr_logo;
        //    ObjParameter[28] = EMPRESAS.REPRESENTANTE;
        //    ObjParameter[29] = EMPRESAS.REP_CEDULA;
        //    ObjParameter[30] = EMPRESAS.Espacio;
        //    ObjParameter[31] = EMPRESAS.cant_marca_reloj;
        //    ObjParameter[32] = EMPRESAS.emp_UMCD;
        //    ObjParameter[33] = EMPRESAS.emp_MCS;
        //    ObjParameter[34] = EMPRESAS.empr_GMT;
        //    ObjParameter[35] = EMPRESAS.Pais_ID;
        //    ObjParameter[36] = EMPRESAS.Cot_Editable;
        //    ObjParameter[37] = EMPRESAS.IdGMT;
        //    ObjParameter[38] = EMPRESAS.Region;
        //    ObjParameter[39] = EMPRESAS.OC_Exento;
        //    ObjParameter[40] = EMPRESAS.Grupo;
        //    ObjParameter[41] = EMPRESAS.Alias;
        //    ObjParameter[42] = EMPRESAS.Ruc;
        //    ObjParameter[43] = EMPRESAS.Correo;
        //    ObjParameter[44] = EMPRESAS.CodigoPais;
        //    ObjParameter[45] = EMPRESAS.Fax;
        //    ObjParameter[46] = EMPRESAS.Direccion;
        //    ObjParameter[47] = EMPRESAS.NombreComercial;
        //    ObjParameter[48] = EMPRESAS.ValidarTCambio;
        //    ObjParameter[49] = EMPRESAS.ValidarFacturasVencidas;
        //    ObjParameter[50] = EMPRESAS.CodigoActividad;
        //    ObjParameter[51] = EMPRESAS.ValidarLimiteCredito;
        //    ObjParameter[52] = EMPRESAS.CobrosEditable;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_EMPRESAS", ObjParameter);
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
        public DataTable Listar()
        {
            return fn.ObtieneDatos("sp_sel_EMPRESAS", 0);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Borrar(EMPRESAS EMPRESAS, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[2];
        //    ObjParameter[0] = EMPRESAS.;
        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_EMPRESAS", ObjParameter);
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
        public EMPRESAS Detalles(int Id)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_EMPRESAS", Id);
            EMPRESAS det = new EMPRESAS();

            if (dt.Rows.Count > 0)
            {

                det.CODIGO = (int)dt.Rows[0]["CODIGO"];
                det.NOMBRE = dt.Rows[0]["NOMBRE"].ToString();
                det.CIUDAD = dt.Rows[0]["CIUDAD"].ToString();
                det.PAIS = dt.Rows[0]["PAIS"].ToString();
                det.TELEFONO = dt.Rows[0]["TELEFONO"].ToString();
                det.CONTADOR = dt.Rows[0]["CONTADOR"].ToString();
                det.MES = (int)dt.Rows[0]["MES"];
                det.ANIO = (int)dt.Rows[0]["ANIO"];
                det.FECHA_INICIOAF = dt.Rows[0]["FECHA_INICIOAF"].ToString();
                det.FECHA_CIERREAF = dt.Rows[0]["FECHA_CIERREAF"].ToString();
                det.DECIMALES = (int)dt.Rows[0]["DECIMALES"];
                det.MAYOR = (int)dt.Rows[0]["MAYOR"];
                det.SC01 = (int)dt.Rows[0]["SC01"];
                det.SC02 = (int)dt.Rows[0]["SC02"];
                det.SC03 = (int)dt.Rows[0]["SC03"];
                det.SC04 = (int)dt.Rows[0]["SC04"];
                det.SC05 = (int)dt.Rows[0]["SC05"];
                det.SC06 = (int)dt.Rows[0]["SC06"];
                det.SC07 = (int)dt.Rows[0]["SC07"];
                det.SC08 = (int)dt.Rows[0]["SC08"];
                det.SC09 = (int)dt.Rows[0]["SC09"];
                det.emp_monedabase = dt.Rows[0]["emp_monedabase"].ToString();
                det.emp_monedasalario = dt.Rows[0]["emp_monedasalario"].ToString();
                det.empr_umpv = dt.Rows[0]["empr_umpv"].ToString();
                det.EMPR_UMPA = dt.Rows[0]["EMPR_UMPA"].ToString();
                det.empr_MPA = dt.Rows[0]["empr_MPA"].ToString();
                det.empr_logo = dt.Rows[0]["empr_logo"].ToString();
                det.REPRESENTANTE = dt.Rows[0]["REPRESENTANTE"].ToString();
                det.REP_CEDULA = dt.Rows[0]["REP_CEDULA"].ToString();
                //det.Espacio = dt.Rows[0]["Espacio"].ToString();
                //det.cant_marca_reloj = dt.Rows[0]["cant_marca_reloj"].ToString();
                det.emp_UMCD = dt.Rows[0]["emp_UMCD"].ToString();
                //det.emp_MCS = dt.Rows[0]["emp_MCS"].ToString();
                //det.empr_GMT = dt.Rows[0]["empr_GMT"].ToString();
                //det.Pais_ID = dt.Rows[0]["Pais_ID"].ToString();
                //det.Cot_Editable = dt.Rows[0]["Cot_Editable"].ToString();
                det.IdGMT = dt.Rows[0]["IdGMT"].ToString();
                det.Region = dt.Rows[0]["Region"].ToString();
                //det.OC_Exento = dt.Rows[0]["OC_Exento"].ToString();
                det.Grupo = dt.Rows[0]["Grupo"].ToString();
                det.Alias = dt.Rows[0]["Alias"].ToString();
                det.Ruc = dt.Rows[0]["Ruc"].ToString();
                det.Correo = dt.Rows[0]["Correo"].ToString();
                det.CodigoPais = dt.Rows[0]["CodigoPais"].ToString();
                det.Fax = dt.Rows[0]["Fax"].ToString();
                det.Direccion = dt.Rows[0]["Direccion"].ToString();
                det.NombreComercial = dt.Rows[0]["NombreComercial"].ToString();
                //det.ValidarTCambio = dt.Rows[0]["ValidarTCambio"].ToString();
                //det.ValidarFacturasVencidas = dt.Rows[0]["ValidarFacturasVencidas"].ToString();
                det.CodigoActividad = dt.Rows[0]["CodigoActividad"].ToString();
                //det.ValidarLimiteCredito = dt.Rows[0]["ValidarLimiteCredito"].ToString();
                //det.CobrosEditable = dt.Rows[0]["CobrosEditable"].ToString();

            }
            return det;
        }
    }

}
