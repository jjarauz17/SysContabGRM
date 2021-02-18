namespace Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class db_CLIENTES : ClComun
    {
        CLIENTES vCLIENTESTabla = new CLIENTES();
        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
        public CLIENTES CLIENTESTabla
        {
            get
            {
                return vCLIENTESTabla;
            }
            set
            {
                vCLIENTESTabla = value;
            }
        }

       // fn fn = new Fn();

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public bool Insertar(CLIENTES CLIENTES, bool Tran = false)
        {
            object[] ObjParameter = new object[67];
            ObjParameter[0] = CLIENTES.CODIGO;
            ObjParameter[1] = CLIENTES.NOMBRE;
            ObjParameter[2] = CLIENTES.CONTACTO;
            ObjParameter[3] = CLIENTES.CARGO;
            ObjParameter[4] = CLIENTES.TELEFONO_CONTACTO;
            ObjParameter[5] = CLIENTES.CELULAR_CONTACTO;
            ObjParameter[6] = CLIENTES.EMAIL_CONTACTO;
            ObjParameter[7] = CLIENTES.GERENTE;
            ObjParameter[8] = CLIENTES.TELEFONO_GERENTE;
            ObjParameter[9] = CLIENTES.CELULAR_GERENTE;
            ObjParameter[10] = CLIENTES.EMAIL_GERENTE;
            ObjParameter[11] = CLIENTES.CONTADOR;
            ObjParameter[12] = CLIENTES.TELEFONO_CONTADOR;
            ObjParameter[13] = CLIENTES.CELULAR_CONTADOR;
            ObjParameter[14] = CLIENTES.EMAIL_CONTADOR;
            ObjParameter[15] = CLIENTES.DIRECCION;
            ObjParameter[16] = CLIENTES.Pais_Id;
            ObjParameter[17] = CLIENTES.DEPARTAMENTO;
            ObjParameter[18] = CLIENTES.MUNICIPIO;
            ObjParameter[19] = CLIENTES.CIUDAD;
            ObjParameter[20] = CLIENTES.TELEFONO;
            ObjParameter[21] = CLIENTES.FAX;
            ObjParameter[22] = CLIENTES.CORREO;
            ObjParameter[23] = CLIENTES.RUC;
            ObjParameter[24] = CLIENTES.TIPO;
            ObjParameter[25] = CLIENTES.COD_ZONA;
            ObjParameter[26] = CLIENTES.COD_FORMA_PAGO;
            ObjParameter[27] = CLIENTES.DESC_PROD;
            ObjParameter[28] = CLIENTES.DESC_SERV;
            ObjParameter[29] = CLIENTES.DESC_ADICIONAL;
            ObjParameter[30] = CLIENTES.LIMITE_CREDITO;
            ObjParameter[31] = CLIENTES.VENDEDOR;
            ObjParameter[32] = CLIENTES.CUENTA;
            ObjParameter[33] = CLIENTES.Excento;
            ObjParameter[34] = CLIENTES.TipoCliente;
            ObjParameter[35] = CLIENTES.Retenedor;
            ObjParameter[36] = CLIENTES.Fecha_Creacion;
            ObjParameter[37] = CLIENTES.EMPRESA;
            ObjParameter[38] = CLIENTES.TipoIVA_ID;
            ObjParameter[39] = CLIENTES.Retenedor_Alcaldia;
            ObjParameter[40] = CLIENTES.Cedula;
            ObjParameter[41] = CLIENTES.CodigoLetra;
            ObjParameter[42] = CLIENTES.Empleado;
            ObjParameter[43] = CLIENTES.Garantia;
            ObjParameter[44] = CLIENTES.CodConsecutPorcentaje;
            ObjParameter[45] = CLIENTES.Categoria;
            ObjParameter[46] = CLIENTES.Moneda;
            ObjParameter[47] = CLIENTES.ValidarLimite;
            ObjParameter[48] = CLIENTES.SucursalCliente;
            ObjParameter[49] = CLIENTES.Varios;
            ObjParameter[50] = CLIENTES.Comentarios;
            ObjParameter[51] = CLIENTES.Registro;
            ObjParameter[52] = CLIENTES.Usuario;
            ObjParameter[53] = CLIENTES.ACTIVO;
            ObjParameter[54] = CLIENTES.AgroServicio;
            ObjParameter[55] = CLIENTES.Nombre_Comercial;
            ObjParameter[56] = CLIENTES.CELULAR;
            ObjParameter[57] = CLIENTES.Clasificacion;
            ObjParameter[58] = CLIENTES.CEDULA_GERENTE;
            ObjParameter[59] = CLIENTES.CEDULA_GONTACTO;
            ObjParameter[60] = CLIENTES.CEDULA_CONTADOR;
            ObjParameter[61] = CLIENTES.REPRESENTANTE;
            ObjParameter[62] = CLIENTES.CEDULA_REPRESENTANTE;
            ObjParameter[63] = CLIENTES.EMAIL_REPRESENTANTE;
            ObjParameter[64] = CLIENTES.TELEFONO_REPRESENTANTE;
            ObjParameter[65] = CLIENTES.CELULAR_REPRESENTANTE;
            ObjParameter[66] = CLIENTES.ValidarVencidas;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CLIENTES", ObjParameter);
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
        public bool Actualizar(CLIENTES CLIENTES, bool Tran = false)
        {
            object[] ObjParameter = new object[67];
            ObjParameter[0] = CLIENTES.CODIGO;
            ObjParameter[1] = CLIENTES.NOMBRE;
            ObjParameter[2] = CLIENTES.CONTACTO;
            ObjParameter[3] = CLIENTES.CARGO;
            ObjParameter[4] = CLIENTES.TELEFONO_CONTACTO;
            ObjParameter[5] = CLIENTES.CELULAR_CONTACTO;
            ObjParameter[6] = CLIENTES.EMAIL_CONTACTO;
            ObjParameter[7] = CLIENTES.GERENTE;
            ObjParameter[8] = CLIENTES.TELEFONO_GERENTE;
            ObjParameter[9] = CLIENTES.CELULAR_GERENTE;
            ObjParameter[10] = CLIENTES.EMAIL_GERENTE;
            ObjParameter[11] = CLIENTES.CONTADOR;
            ObjParameter[12] = CLIENTES.TELEFONO_CONTADOR;
            ObjParameter[13] = CLIENTES.CELULAR_CONTADOR;
            ObjParameter[14] = CLIENTES.EMAIL_CONTADOR;
            ObjParameter[15] = CLIENTES.DIRECCION;
            ObjParameter[16] = CLIENTES.Pais_Id;
            ObjParameter[17] = CLIENTES.DEPARTAMENTO;
            ObjParameter[18] = CLIENTES.MUNICIPIO;
            ObjParameter[19] = CLIENTES.CIUDAD;
            ObjParameter[20] = CLIENTES.TELEFONO;
            ObjParameter[21] = CLIENTES.FAX;
            ObjParameter[22] = CLIENTES.CORREO;
            ObjParameter[23] = CLIENTES.RUC;
            ObjParameter[24] = CLIENTES.TIPO;
            ObjParameter[25] = CLIENTES.COD_ZONA;
            ObjParameter[26] = CLIENTES.COD_FORMA_PAGO;
            ObjParameter[27] = CLIENTES.DESC_PROD;
            ObjParameter[28] = CLIENTES.DESC_SERV;
            ObjParameter[29] = CLIENTES.DESC_ADICIONAL;
            ObjParameter[30] = CLIENTES.LIMITE_CREDITO;
            ObjParameter[31] = CLIENTES.VENDEDOR;
            ObjParameter[32] = CLIENTES.CUENTA;
            ObjParameter[33] = CLIENTES.Excento;
            ObjParameter[34] = CLIENTES.TipoCliente;
            ObjParameter[35] = CLIENTES.Retenedor;
            ObjParameter[36] = CLIENTES.Fecha_Creacion;
            ObjParameter[37] = CLIENTES.EMPRESA;
            ObjParameter[38] = CLIENTES.TipoIVA_ID;
            ObjParameter[39] = CLIENTES.Retenedor_Alcaldia;
            ObjParameter[40] = CLIENTES.Cedula;
            ObjParameter[41] = CLIENTES.CodigoLetra;
            ObjParameter[42] = CLIENTES.Empleado;
            ObjParameter[43] = CLIENTES.Garantia;
            ObjParameter[44] = CLIENTES.CodConsecutPorcentaje;
            ObjParameter[45] = CLIENTES.Categoria;
            ObjParameter[46] = CLIENTES.Moneda;
            ObjParameter[47] = CLIENTES.ValidarLimite;
            ObjParameter[48] = CLIENTES.SucursalCliente;
            ObjParameter[49] = CLIENTES.Varios;
            ObjParameter[50] = CLIENTES.Comentarios;
            ObjParameter[51] = CLIENTES.Registro;
            ObjParameter[52] = CLIENTES.Usuario;
            ObjParameter[53] = CLIENTES.ACTIVO;
            ObjParameter[54] = CLIENTES.AgroServicio;
            ObjParameter[55] = CLIENTES.Nombre_Comercial;
            ObjParameter[56] = CLIENTES.CELULAR;
            ObjParameter[57] = CLIENTES.Clasificacion;
            ObjParameter[58] = CLIENTES.CEDULA_GERENTE;
            ObjParameter[59] = CLIENTES.CEDULA_GONTACTO;
            ObjParameter[60] = CLIENTES.CEDULA_CONTADOR;
            ObjParameter[61] = CLIENTES.REPRESENTANTE;
            ObjParameter[62] = CLIENTES.CEDULA_REPRESENTANTE;
            ObjParameter[63] = CLIENTES.EMAIL_REPRESENTANTE;
            ObjParameter[64] = CLIENTES.TELEFONO_REPRESENTANTE;
            ObjParameter[65] = CLIENTES.CELULAR_REPRESENTANTE;
            ObjParameter[66] = CLIENTES.ValidarVencidas;

            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CLIENTES", ObjParameter);
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
        public DataTable Listar(int Id, int Empresa)
        {
            return fn.ObtieneDatos("sp_sel_CLIENTES", 
                Id, 
                Empresa);
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public int GetCodigo(int Empresa)
        {
            return (int)fn.ObtieneDatos("sp_sel_CLIENTESGetCodigo",                
                Empresa).Rows[0]["Codigo"];
        }

        //-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        public void Borrar(CLIENTES CLIENTES, bool Tran = false)
        {
            object[] ObjParameter = new object[2];
            ObjParameter[0] = (int)CLIENTES.CODIGO;
            ObjParameter[1] = (int)CLIENTES.EMPRESA;
            try
            {
                this.InicializarMensajeError();
                this.OpenSqlBD();

                SqlCommand cmd = new SqlCommand();
                cmd = this.ConfigurarComando(TieneTransaccion.Si, "sp_del_CLIENTES", ObjParameter);
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
                fn.XtraMsg(ex.Message,
                    MessageBoxIcon.Error);
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
        public CLIENTES Detalles(int Id, int Empresa)
        {
            DataTable dt = fn.ObtieneDatos("sp_sel_CLIENTES", Id, Empresa);
            CLIENTES det = new CLIENTES();

            if (dt.Rows.Count > 0)
            {

                det.IdSisCliente = (int)dt.Rows[0]["IdSisCliente"];
                det.CODIGO = (int)dt.Rows[0]["CODIGO"];
                det.NOMBRE = dt.Rows[0]["NOMBRE"].ToString();
                det.CONTACTO = dt.Rows[0]["CONTACTO"].ToString();
                det.CARGO = dt.Rows[0]["CARGO"].ToString();
                det.TELEFONO_CONTACTO = dt.Rows[0]["TELEFONO_CONTACTO"].ToString();
                det.CELULAR_CONTACTO = dt.Rows[0]["CELULAR_CONTACTO"].ToString();
                det.EMAIL_CONTACTO = dt.Rows[0]["EMAIL_CONTACTO"].ToString();
                det.GERENTE = dt.Rows[0]["GERENTE"].ToString();
                det.TELEFONO_GERENTE = dt.Rows[0]["TELEFONO_GERENTE"].ToString();
                det.CELULAR_GERENTE = dt.Rows[0]["CELULAR_GERENTE"].ToString();
                det.EMAIL_GERENTE = dt.Rows[0]["EMAIL_GERENTE"].ToString();
                det.CONTADOR = dt.Rows[0]["CONTADOR"].ToString();
                det.TELEFONO_CONTADOR = dt.Rows[0]["TELEFONO_CONTADOR"].ToString();
                det.CELULAR_CONTADOR = dt.Rows[0]["CELULAR_CONTADOR"].ToString();
                det.EMAIL_CONTADOR = dt.Rows[0]["EMAIL_CONTADOR"].ToString();
                det.DIRECCION = dt.Rows[0]["DIRECCION"].ToString();
                det.Pais_Id = (int)dt.Rows[0]["Pais_Id"];
                det.DEPARTAMENTO = (int)dt.Rows[0]["DEPARTAMENTO"];
                det.MUNICIPIO = (int)dt.Rows[0]["MUNICIPIO"];
                det.CIUDAD = dt.Rows[0]["CIUDAD"].ToString();
                det.TELEFONO = dt.Rows[0]["TELEFONO"].ToString();
                det.FAX = dt.Rows[0]["FAX"].ToString();
                det.CORREO = dt.Rows[0]["CORREO"].ToString();
                det.RUC = dt.Rows[0]["RUC"].ToString();
                det.TIPO = dt.Rows[0]["TIPO"].ToString();
                det.COD_ZONA = (int)dt.Rows[0]["COD_ZONA"];
                det.COD_FORMA_PAGO = (int)dt.Rows[0]["COD_FORMA_PAGO"];
                det.DESC_PROD = dt.Rows[0]["DESC_PROD"].ToString();
                det.DESC_SERV = dt.Rows[0]["DESC_SERV"].ToString();
                det.DESC_ADICIONAL = (double)dt.Rows[0]["DESC_ADICIONAL"];
                det.LIMITE_CREDITO = (double)dt.Rows[0]["LIMITE_CREDITO"];
                det.VENDEDOR = (int)dt.Rows[0]["VENDEDOR"];
                det.CUENTA = dt.Rows[0]["CUENTA"].ToString();
                det.Excento = (bool)dt.Rows[0]["Excento"] ? 1 : 0;
                det.TipoCliente = (int)dt.Rows[0]["TipoCliente"];
                det.Retenedor = (bool)dt.Rows[0]["Retenedor"] ? 1: 0;
                //det.Fecha_Creacion = dt.Rows[0]["Fecha_Creacion"].ToString();
                //det.EMPRESA = dt.Rows[0]["EMPRESA"].ToString();
                //det.TipoIVA_ID = (int)dt.Rows[0]["TipoIVA_ID"];
                det.Retenedor_Alcaldia = (bool)dt.Rows[0]["Retenedor_Alcaldia"] ? 1: 0;
                det.Cedula = dt.Rows[0]["Cedula"].ToString();
                det.CodigoLetra = dt.Rows[0]["CodigoLetra"].ToString();
                det.Empleado = (bool)dt.Rows[0]["Empleado"] ? 1 : 0;
                det.Garantia = (bool)dt.Rows[0]["Garantia"] ? 1 : 0;
                //det.CodConsecutPorcentaje = (int)dt.Rows[0]["CodConsecutPorcentaje"];
                det.Categoria = (int)dt.Rows[0]["Categoria"];
                det.Moneda = dt.Rows[0]["Moneda"].ToString();
                det.ValidarLimite = (bool)dt.Rows[0]["ValidarLimite"] ? 1 : 0;
                det.ValidarVencidas = (bool)dt.Rows[0]["ValidarVencidas"] ? 1 : 0;
                // det.SucursalCliente = dt.Rows[0]["SucursalCliente"].ToString();
                det.Varios = (bool)dt.Rows[0]["Varios"] ? 1 : 0;
                det.Comentarios = dt.Rows[0]["Comentarios"].ToString();
                det.Registro = dt.Rows[0]["Registro"].ToString();
                det.Usuario = dt.Rows[0]["Usuario"].ToString();
                det.ACTIVO = (bool)dt.Rows[0]["ACTIVO"] ? 1 : 0;
                det.AgroServicio = (bool)dt.Rows[0]["AgroServicio"] ? 1 : 0;
                det.Nombre_Comercial = dt.Rows[0]["Nombre_Comercial"].ToString();
                det.CELULAR = dt.Rows[0]["CELULAR"].ToString();
                det.Clasificacion = (int)dt.Rows[0]["Clasificacion"];
                det.CEDULA_GERENTE = dt.Rows[0]["CEDULA_GERENTE"].ToString();
                det.CEDULA_GONTACTO = dt.Rows[0]["CEDULA_GONTACTO"].ToString();
                det.CEDULA_CONTADOR = dt.Rows[0]["CEDULA_CONTADOR"].ToString();
                det.REPRESENTANTE = dt.Rows[0]["REPRESENTANTE"].ToString();
                det.CEDULA_REPRESENTANTE = dt.Rows[0]["CEDULA_REPRESENTANTE"].ToString();
                det.EMAIL_REPRESENTANTE = dt.Rows[0]["EMAIL_REPRESENTANTE"].ToString();
                det.TELEFONO_REPRESENTANTE = dt.Rows[0]["TELEFONO_REPRESENTANTE"].ToString();
                det.CELULAR_REPRESENTANTE = dt.Rows[0]["CELULAR_REPRESENTANTE"].ToString();

            }
            return det;
        }
    }


}
