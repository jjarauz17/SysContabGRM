namespace Entities
{    
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_CATALOGO : ClComun
    {
        CATALOGO vCATALOGOTabla = new CATALOGO();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public CATALOGO CATALOGOTabla
        {
            get
            {
                return vCATALOGOTabla;
            }
            set
            {
                vCATALOGOTabla = value;
            }
        }

        public DataTable Listar(int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_CATALOGO", 0, "%", Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public CATALOGO Detalles(string Cuenta, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_CATALOGO", 1, Cuenta, Empresa);
            CATALOGO det = new CATALOGO();

            if (dt.Rows.Count > 0)
            {

                det.EMPRESA = (int)dt.Rows[0]["EMPRESA"];
                det.CUENTA = dt.Rows[0]["CUENTA"].ToString();
                det.NOMBRE = dt.Rows[0]["NOMBRE"].ToString();
                det.Cuenta_De = dt.Rows[0]["Cuenta_De"].ToString();
                det.TIPO = dt.Rows[0]["TIPO"].ToString();
                //det.SALDO_INICIAL = dt.Rows[0]["SALDO_INICIAL"].ToString();
                //det.PRESUPUESTO_ANUAL = dt.Rows[0]["PRESUPUESTO_ANUAL"].ToString();
                //det.DEBCREINI = dt.Rows[0]["DEBCREINI"].ToString();
                det.BALRES = dt.Rows[0]["BALRES"].ToString();
                det.GRUPO = Convert.ToDouble(dt.Rows[0]["GRUPO"]);
                //det.INFORM = dt.Rows[0]["INFORM"].ToString();
                det.CLASE = (int)dt.Rows[0]["CLASE"];
                det.SUBCUENTA = dt.Rows[0]["SUBCUENTA"].ToString();
                //det.AGRUPACION = dt.Rows[0]["AGRUPACION"].ToString();
                //det.Mon_Id = dt.Rows[0]["Mon_Id"].ToString();
                //det.DEBITO = dt.Rows[0]["DEBITO"].ToString();
                //det.CREDITO = dt.Rows[0]["CREDITO"].ToString();
                //det.grupo_presupuesto = dt.Rows[0]["grupo_presupuesto"].ToString();
                det.CajaBanco = Convert.ToBoolean(dt.Rows[0]["CajaBanco"]) == true ? 1 : 0;
                //det.tfl_codigo = dt.Rows[0]["tfl_codigo"].ToString();
                det.UtilidadPerdida = Convert.ToBoolean(dt.Rows[0]["UtilidadPerdida"])==true ? 1 : 0;
                det.UtilidadAcumulada = Convert.ToBoolean(dt.Rows[0]["UtilidadAcumulada"]) == true ? 1:0;
                det.Caja = Convert.ToBoolean(dt.Rows[0]["Caja"]) == true ? 1 : 0;
                det.Proveedor = Convert.ToBoolean(dt.Rows[0]["Proveedor"]) == true ? 1 : 0;
                det.Inventario = Convert.ToBoolean(dt.Rows[0]["Inventario"]) == true ? 1 : 0;
                det.Distribucion = Convert.ToBoolean(dt.Rows[0]["Distribucion"]) == true ? 1 : 0;
                det.DeOrden = Convert.ToBoolean(dt.Rows[0]["DeOrden"]) == true ? 1 : 0;
                det.CChica = Convert.ToBoolean(dt.Rows[0]["CChica"]) == true ? 1 : 0;
                det.Retencion = Convert.ToBoolean(dt.Rows[0]["Retencion"]) == true ? 1 : 0;
                det.Ingresos = Convert.ToBoolean(dt.Rows[0]["Ingresos"]) == true ? 1 : 0;
                det.Devolucion = Convert.ToBoolean(dt.Rows[0]["Devolucion"]) == true ? 1 : 0;
                det.Rebajas = Convert.ToBoolean(dt.Rows[0]["Rebajas"]) == true ? 1 : 0;
                det.Registro = dt.Rows[0]["Registro"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.Mnto_Valor = Convert.ToBoolean(dt.Rows[0]["Mnto_Valor"]) == true ? 1 : 0;
                det.Rendicion = Convert.ToBoolean(dt.Rows[0]["Rendicion"]) == true ? 1 : 0;
                det.CODIGO_GRUPO = dt.Rows[0]["CODIGO_GRUPO"].ToString();
                det.CODIGO_UNIDAD = dt.Rows[0]["CODIGO_UNIDAD"].ToString();
                det.NOMBRE_UNIDAD = dt.Rows[0]["NOMBRE_UNIDAD"].ToString();
                det.Activo = Convert.ToBoolean(dt.Rows[0]["Activo"]) == true ? 1 : 0;
                det.EsProyecto = Convert.ToBoolean(dt.Rows[0]["EsProyecto"]) == true ? 1 : 0;
                det.EsTransito = Convert.ToBoolean(dt.Rows[0]["EsTransito"]) == true ? 1 : 0;

            }
            return det;
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Insertar(CATALOGO CATALOGO, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[42];
        //    ObjParameter[0] = CATALOGO.EMPRESA;
        //    ObjParameter[1] = CATALOGO.CUENTA;
        //    ObjParameter[2] = CATALOGO.NOMBRE;
        //    ObjParameter[3] = CATALOGO.Cuenta_De;
        //    ObjParameter[4] = CATALOGO.TIPO;
        //    ObjParameter[5] = CATALOGO.SALDO_INICIAL;
        //    ObjParameter[6] = CATALOGO.PRESUPUESTO_ANUAL;
        //    ObjParameter[7] = CATALOGO.DEBCREINI;
        //    ObjParameter[8] = CATALOGO.BALRES;
        //    ObjParameter[9] = CATALOGO.GRUPO;
        //    ObjParameter[10] = CATALOGO.INFORM;
        //    ObjParameter[11] = CATALOGO.CLASE;
        //    ObjParameter[12] = CATALOGO.SUBCUENTA;
        //    ObjParameter[13] = CATALOGO.AGRUPACION;
        //    ObjParameter[14] = CATALOGO.Mon_Id;
        //    ObjParameter[15] = CATALOGO.DEBITO;
        //    ObjParameter[16] = CATALOGO.CREDITO;
        //    ObjParameter[17] = CATALOGO.grupo_presupuesto;
        //    ObjParameter[18] = CATALOGO.CajaBanco;
        //    ObjParameter[19] = CATALOGO.tfl_codigo;
        //    ObjParameter[20] = CATALOGO.UtilidadPerdida;
        //    ObjParameter[21] = CATALOGO.UtilidadAcumulada;
        //    ObjParameter[22] = CATALOGO.Caja;
        //    ObjParameter[23] = CATALOGO.Proveedor;
        //    ObjParameter[24] = CATALOGO.Inventario;
        //    ObjParameter[25] = CATALOGO.Distribucion;
        //    ObjParameter[26] = CATALOGO.DeOrden;
        //    ObjParameter[27] = CATALOGO.CChica;
        //    ObjParameter[28] = CATALOGO.Retencion;
        //    ObjParameter[29] = CATALOGO.Ingresos;
        //    ObjParameter[30] = CATALOGO.Devolucion;
        //    ObjParameter[31] = CATALOGO.Rebajas;
        //    ObjParameter[32] = CATALOGO.Registro;
        //    ObjParameter[33] = CATALOGO.Usuario;
        //    ObjParameter[34] = CATALOGO.Mnto_Valor;
        //    ObjParameter[35] = CATALOGO.Rendicion;
        //    ObjParameter[36] = CATALOGO.CODIGO_GRUPO;
        //    ObjParameter[37] = CATALOGO.CODIGO_UNIDAD;
        //    ObjParameter[38] = CATALOGO.NOMBRE_UNIDAD;
        //    ObjParameter[39] = CATALOGO.Activo;
        //    ObjParameter[40] = CATALOGO.EsProyecto;
        //    ObjParameter[41] = CATALOGO.EsTransito;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CATALOGO", ObjParameter);
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
        //public void Actualizar(CATALOGO CATALOGO, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[42];
        //    ObjParameter[1] = CATALOGO.EMPRESA;
        //    ObjParameter[2] = CATALOGO.CUENTA;
        //    ObjParameter[3] = CATALOGO.NOMBRE;
        //    ObjParameter[4] = CATALOGO.Cuenta_De;
        //    ObjParameter[5] = CATALOGO.TIPO;
        //    ObjParameter[6] = CATALOGO.SALDO_INICIAL;
        //    ObjParameter[7] = CATALOGO.PRESUPUESTO_ANUAL;
        //    ObjParameter[8] = CATALOGO.DEBCREINI;
        //    ObjParameter[9] = CATALOGO.BALRES;
        //    ObjParameter[10] = CATALOGO.GRUPO;
        //    ObjParameter[11] = CATALOGO.INFORM;
        //    ObjParameter[12] = CATALOGO.CLASE;
        //    ObjParameter[13] = CATALOGO.SUBCUENTA;
        //    ObjParameter[14] = CATALOGO.AGRUPACION;
        //    ObjParameter[15] = CATALOGO.Mon_Id;
        //    ObjParameter[16] = CATALOGO.DEBITO;
        //    ObjParameter[17] = CATALOGO.CREDITO;
        //    ObjParameter[18] = CATALOGO.grupo_presupuesto;
        //    ObjParameter[19] = CATALOGO.CajaBanco;
        //    ObjParameter[20] = CATALOGO.tfl_codigo;
        //    ObjParameter[21] = CATALOGO.UtilidadPerdida;
        //    ObjParameter[22] = CATALOGO.UtilidadAcumulada;
        //    ObjParameter[23] = CATALOGO.Caja;
        //    ObjParameter[24] = CATALOGO.Proveedor;
        //    ObjParameter[25] = CATALOGO.Inventario;
        //    ObjParameter[26] = CATALOGO.Distribucion;
        //    ObjParameter[27] = CATALOGO.DeOrden;
        //    ObjParameter[28] = CATALOGO.CChica;
        //    ObjParameter[29] = CATALOGO.Retencion;
        //    ObjParameter[30] = CATALOGO.Ingresos;
        //    ObjParameter[31] = CATALOGO.Devolucion;
        //    ObjParameter[32] = CATALOGO.Rebajas;
        //    ObjParameter[33] = CATALOGO.Registro;
        //    ObjParameter[34] = CATALOGO.Usuario;
        //    ObjParameter[35] = CATALOGO.Mnto_Valor;
        //    ObjParameter[36] = CATALOGO.Rendicion;
        //    ObjParameter[37] = CATALOGO.CODIGO_GRUPO;
        //    ObjParameter[38] = CATALOGO.CODIGO_UNIDAD;
        //    ObjParameter[39] = CATALOGO.NOMBRE_UNIDAD;
        //    ObjParameter[40] = CATALOGO.Activo;
        //    ObjParameter[41] = CATALOGO.EsProyecto;
        //    ObjParameter[42] = CATALOGO.EsTransito;

        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CATALOGO", ObjParameter);
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


        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        //public void Borrar(CATALOGO CATALOGO, bool Tran = false)
        //{
        //    object[] ObjParameter = new object[2];
        //    ObjParameter[0] = CATALOGO.;
        //    try
        //    {
        //        this.InicializarMensajeError();
        //        this.OpenSqlBD();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_CATALOGO", ObjParameter);
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
    }

}
