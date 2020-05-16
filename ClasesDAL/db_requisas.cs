using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnect;
using ClasesBLL;
using System.Windows.Forms;

namespace ClasesDAL
{
   public class db_requisas
    {

        public int Add(int Empresa, string Tipo, DateTime Fecha, string Bodega, string Usuario,
                                    string Factura, int Movimiento, string Referencia, string Concepto, string Transporte,
                                    string Placa, string Conductor, string Remision, string OTMatriz, string OTSucursal,
                                    int Cliente, string Poliza, int Proyecto, int Orden, int Proveedor, int NoDevolucion, int Reg_referencia)
        {


            Connect Conn = new Connect(fn.Conexion());
            Conn.IniciarTransaccion();

            try
            {
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa);
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Output, 0);
                Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, Tipo);
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date);
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega);
                Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario);
                Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, false);
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, Factura) ;
                Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Movimiento);
                Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Referencia);
                Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, Concepto);
                Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, Transporte);
                Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, Placa);
                Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, Conductor);
                Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, Remision);
                Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTMatriz);
                Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTSucursal);
                Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, Cliente);
                Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, Poliza);
                Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, Proyecto);
                Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, Orden);
                Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, Proveedor);
                Conn.AddParameter("NoDevolucion", SqlDbType.Int, 5, ParameterDirection.Input, NoDevolucion);
                Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Reg_referencia);

                Conn.EjecutarComando("SP_Requisas_Add");

                return Convert.ToInt32( Conn.GetParameter("Requisa").Valor.ToString());
            }
            catch (Exception ex)
            {
                Conn.AnularTransaccion();
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);
                return 0;
            }
        }

        public  void Update(int Empresa, int Requisa, string Tipo, DateTime Fecha, string Bodega, string Usuario,
                                    string Factura, int Movimiento, string Referencia, string Concepto, string Transporte,
                                    string Placa, string Conductor, string Remision, string OTMatriz, string OTSucursal,
                                    int Cliente, string Poliza, int Proyecto, int Orden)
        {
            Connect Conn = new Connect(fn.Conexion());
            Conn.IniciarTransaccion();

            try
            {
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa);
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Output, Requisa);
                Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, Tipo);
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date);
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, Bodega);
                Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Usuario);
                Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, false);
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, Factura);
                Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Movimiento);
                Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Referencia);
                Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, Concepto);
                Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, Transporte);
                Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, Placa);
                Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, Conductor);
                Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, Remision);
                Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTMatriz);
                Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, OTSucursal);
                Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, Cliente);
                Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, Poliza);
                Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, Proyecto);
                Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, Orden);

                Conn.EjecutarComando("SP_Requisas_Add");                
            }
            catch (Exception ex)
            {
                Conn.AnularTransaccion();
                fn.XtraMsg(ex.Message, MessageBoxIcon.Error);                
            }
        }

        public void AddDetalle(int Empresa, int Requisa, string Codigo, string Tipo, Double Cantidad, Double Costo, string Cuenta)
        {

            Connect Conn = new Connect(fn.Conexion());

            try
            {
                Conn.RemoveParameters();
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa);
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa);
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo);
                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo);
                Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, Cantidad);
                Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, Costo);
                Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta);

                Conn.EjecutarComando("SP_Requisas_Detalle_Add");
            }
            catch (Exception ex)
            {
                fn.XtraMsg("Error al [Agregar/Actualizar] Codigo : " + Codigo + ". Motivo del Error: " + ex.Message, MessageBoxIcon.Error);
            }            
        }

        public void DeleteDetalle(int Empresa, int Requisa, string Codigo, string Tipo)
        {

            Connect Conn = new Connect(fn.Conexion());

            try
            {
                Conn.RemoveParameters();
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa);
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa);
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo);
                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, Tipo);

                Conn.EjecutarComando("SP_Requisas_Detalle_Add");
            }
            catch (Exception ex)
            {
                fn.XtraMsg("Error al Borrar Codigo : " + Codigo + ". Motivo del Error: " + ex.Message, MessageBoxIcon.Error);
            }
        }

    }
}
