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

    public class db_FacturasCuotasDetalle : ClComun
    {
        FacturasCuotasDetalle vFacturasCuotasDetalleTabla = new FacturasCuotasDetalle();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public FacturasCuotasDetalle FacturasCuotasDetalleTabla
        {
            get
            {
                return vFacturasCuotasDetalleTabla;
            }
            set
            {
                vFacturasCuotasDetalleTabla = value;
            }
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Insertar(FacturasCuotasDetalle FacturasCuotasDetalle, bool Tran = false)
        {
            object[] ObjParameter = new object[7];
            ObjParameter[0] = FacturasCuotasDetalle.Id;
            ObjParameter[1] = FacturasCuotasDetalle.Empresa;
            ObjParameter[2] = FacturasCuotasDetalle.Numero;
            ObjParameter[3] = FacturasCuotasDetalle.FechaPago;
            ObjParameter[4] = FacturasCuotasDetalle.Vencimiento;
            ObjParameter[5] = FacturasCuotasDetalle.Cuota;
            ObjParameter[6] = FacturasCuotasDetalle.Interes;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FacturasCuotasDetalle", ObjParameter);
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
        public void Actualizar(FacturasCuotasDetalle FacturasCuotasDetalle, bool Tran = false)
        {
            object[] ObjParameter = new object[8];
            ObjParameter[0] = FacturasCuotasDetalle.IdDetalle;
            ObjParameter[1] = FacturasCuotasDetalle.Id;
            ObjParameter[2] = FacturasCuotasDetalle.Empresa;
            ObjParameter[3] = FacturasCuotasDetalle.Numero;
            ObjParameter[4] = FacturasCuotasDetalle.FechaPago;
            ObjParameter[5] = FacturasCuotasDetalle.Vencimiento;
            ObjParameter[6] = FacturasCuotasDetalle.Cuota;
            ObjParameter[7] = FacturasCuotasDetalle.Interes;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FacturasCuotasDetalle", ObjParameter);
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
            return fn.ObtieneDatos("sp_sel_FacturasCuotasDetalle", 0, Id, Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(FacturasCuotasDetalle FacturasCuotasDetalle, bool Tran = false)
        {
            object[] ObjParameter = new object[1];
            ObjParameter[0] = FacturasCuotasDetalle.IdDetalle;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_FacturasCuotasDetalle", ObjParameter);
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
        public FacturasCuotasDetalle Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_FacturasCuotasDetalle", Id, 0, Empresa);
            FacturasCuotasDetalle det = new FacturasCuotasDetalle();

            if (dt.Rows.Count > 0)
            {

                det.IdDetalle = (int)dt.Rows[0]["IdDetalle"];
                det.Id = (int)dt.Rows[0]["Id"];
                det.Empresa = (int)dt.Rows[0]["Empresa"];
                det.Numero = (int)dt.Rows[0]["Numero"];
                det.FechaPago = dt.Rows[0]["FechaPago"].ToString();
                det.Vencimiento = dt.Rows[0]["Vencimiento"].ToString();
                det.Cuota = Convert.ToDouble(dt.Rows[0]["Cuota"]);
                det.Interes = Convert.ToDouble(dt.Rows[0]["Interes"]);
                det.Comp_No = (int)dt.Rows[0]["Comp_No"];
                det.Per_Id = (int)dt.Rows[0]["Per_Id"];
                det.Mes = (int)dt.Rows[0]["Mes"];
                det.Aplicada = (bool)dt.Rows[0]["Aplicada"] ? 1 : 0;

            }
            return det;
        }
    }

}
