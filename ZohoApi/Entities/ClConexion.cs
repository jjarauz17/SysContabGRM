namespace ZohoApi.Entities
{
    using System.Data;
    using System.Data.SqlClient;

    public abstract class ClConexion
    {
        SqlConnection vconsql = new SqlConnection();
        SqlTransaction vtran;
        bool VUsaTransaccion;
        oFn fn = new oFn();

        protected SqlTransaction BeginTranSql()
        {
            OpenSqlBD();

            if (VUsaTransaccion == false)
            {
                vtran = vconsql.BeginTransaction(IsolationLevel.ReadUncommitted);
                VUsaTransaccion = true;
            }
            return vtran;
        }

        protected SqlTransaction TransaccionSql
        {
            get
            {
                return vtran;
            }
        }

        protected SqlConnection ConeccionSql
        {
            get
            {
                return vconsql;
            }
        }

        public ClConexion()
        {
            vconsql.ConnectionString = 
                fn.Conexion();
        }

        protected void OpenSqlBD()
        {
            if (vconsql.State == ConnectionState.Closed)
            {
                vconsql.Open();
            }
        }

        protected void CloseSqlBD()
        {
            if (vconsql.State == ConnectionState.Open)
            {
                vconsql.Close();
            }
        }

        protected void Commit()
        {
            if (VUsaTransaccion)
            {
                vtran.Commit();
                VUsaTransaccion = false;
            }
        }

        protected void Rollback()
        {
            if (VUsaTransaccion)
            {
                vtran.Rollback();
                VUsaTransaccion = false;
            }
        }

    }

}
