
using System.Data.SqlClient;

public class db_ZohoToken : ClComun
{
    ZohoToken vZohoTokenTabla = New ZohoToken;
//-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public ZohoToken ZohoTokenTabla
    {
        get
        {
            return vZohoTokenTabla
            }
        set
        {
            vZohoTokenTabla = value
            }
    }

    //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    public void Insertar(ZohoToken ZohoToken, bool Tran = false)
    {
        string[] ObjParameter = new string[6];
        ObjParameter[0] = ZohoToken.Empresa;
        ObjParameter[1] = ZohoToken.Nombre;
        ObjParameter[2] = ZohoToken.Client_ID;
        ObjParameter[3] = ZohoToken.Client_Secret;
        ObjParameter[4] = ZohoToken.Redirect_Uri;
        ObjParameter[5] = ZohoToken.Code;

        try
        {
            this.InicializarMensajeError();
            this.OpenSqlBD();

            SqlCommand cmd = new SqlCommand();
            cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ZohoToken", ObjParameter);
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
            XtraMsg(ex.Message, MessageBoxIcon.Error);
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
    public void Actualizar(ZohoToken ZohoToken, bool Tran = false)
    {
        string[] ObjParameter = new string[6];
        ObjParameter[0] = ZohoToken.ID;
        ObjParameter[1] = ZohoToken.Empresa;
        ObjParameter[2] = ZohoToken.Nombre;
        ObjParameter[3] = ZohoToken.Client_ID;
        ObjParameter[4] = ZohoToken.Client_Secret;
        ObjParameter[5] = ZohoToken.Redirect_Uri;
        ObjParameter[6] = ZohoToken.Code;

        try
        {
            this.InicializarMensajeError();
            this.OpenSqlBD();

            SqlCommand cmd = new SqlCommand();
            cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ZohoToken", ObjParameter);
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
            XtraMsg(ex.Message, MessageBoxIcon.Error);
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
    public static DataTable Listar(string Id)
    {
        return ObtieneDatos("sp_sel_ZohoToken", Id);
    }

    //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    public void Borrar(ZohoToken ZohoToken, bool Tran = false)
    {
        string[] ObjParameter = new string[2];
        ObjParameter[0] = ZohoToken.ID;
        try
        {
            this.InicializarMensajeError();
            this.OpenSqlBD();

            SqlCommand cmd = new SqlCommand();
            cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones", ObjParameter);
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
            XtraMsg(ex.Message, MessageBoxIcon.Error);
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
    public static ZohoToken Detalles(string Id)
    {
        DataTable dt = ObtieneDatos("sp_sel_ZohoToken", Id);
        ZohoToken det = new ZohoToken();

        if (dt.Rows.Count > 0)
        {

            det.ID = dt.Rows[0]["ID"].ToString();
            det.Empresa = dt.Rows[0]["Empresa"].ToString();
            det.Nombre = dt.Rows[0]["Nombre"].ToString();
            det.Client_ID = dt.Rows[0]["Client_ID"].ToString();
            det.Client_Secret = dt.Rows[0]["Client_Secret"].ToString();
            det.Redirect_Uri = dt.Rows[0]["Redirect_Uri"].ToString();
            det.Code = dt.Rows[0]["Code"].ToString();

        }
        return det;
    }
}
