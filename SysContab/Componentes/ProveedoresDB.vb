Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class FacturasComprasDetails
        Public Factura As String
        Public Fecha As String
        Public Proveedor As String
        Public Ruc As String
        Public Concepto As String
        Public Monto As String
        Public SubTotal As String
        Public IvaP As String
        Public IvaC As String
        Public RecargoP As String
        Public RecargoC As String
        Public RetencionP As String
        Public RetencionC As String
        Public Total As String
        Public Saldo As String
        Public Fecha_Cancelar As String
        Public Forma_Pago As String
        Public Fecha_Vencimiento As String
        Public Tipo As String

    End Class

    Public Class ProveedoresDetails
        Public Codigo As String
        Public Nombre As String
        Public Direccion As String
        Public Encargado As String
        Public Cargo As String
        Public Telefono_Contacto As String
        Public Email_Contacto As String
        Public Gerente As String
        Public Telefono_Gerente As String
        Public Celular_Gerente As String
        Public Email_Gerente As String
        Public Contador As String
        Public Telefono_Contador As String
        Public Celular_Contador As String
        Public Email_Contador As String
        Public Departamento As Integer
        Public Municipio As Integer
        Public Ciudad As String
        Public Telefono As String
        Public Fax As String
        Public Correo As String
        Public Ruc As String
        Public Cedula As String
        Public Tipo As String
        Public Cod_Zona As String
        Public Cod_Forma_Pago As Integer
        Public Nombre_Zona As String
        Public Cuenta As String
        Public TipoProveedor As String
        Public Retenedor As Boolean
        Public Varios As Boolean
        Public Exento As Boolean

        Public nNombre As String
        Public pApellido As String
        Public sApellido As String
        Public Origen As String
        Public CodigoLetra As String
        Public CuentaTransito As String
        Public Prefijo As String

        Public DepartamentoN As String
        Public MunicipioN As String
    End Class

    Public Class ProveedoresDB

        Public Shared Function GetFacturasVentasPendientes(ByVal Fecha As Date, ByVal Moneda As String, _
            ByVal TC As String, ByVal Memoria As Boolean, ByVal NEmpresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasPendientesGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            _Moneda.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(_Moneda)

            Dim _TC As SqlParameter = New SqlParameter("@TC", SqlDbType.NVarChar)
            _TC.Value = TC
            DBCommand.SelectCommand.Parameters.Add(_TC)

            Dim _Memoria As SqlParameter = New SqlParameter("@Memoria", SqlDbType.Bit)
            _Memoria.Value = Memoria
            DBCommand.SelectCommand.Parameters.Add(_Memoria)

            Dim _NEmpresa As SqlParameter = New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            _NEmpresa.Value = NEmpresa
            DBCommand.SelectCommand.Parameters.Add(_NEmpresa)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Function Pagos(ByVal Proveedor As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PagosProveedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Periodo As VB.SysContab.PeriodosDB

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Proveedor.Value = Proveedor
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasComprobantes(ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprobantes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Proveedor.Value = Proveedor
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Facturas")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function FacturasPagar(ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Proveedor As Integer) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_FacturasPagar", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
        '    Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
        '    Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
        '    Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

        '    _Fecha1.Value = Fecha1
        '    _Fecha2.Value = Fecha2
        '    _Proveedor.Value = Proveedor
        '    _Empresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(_Fecha1)
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha2)
        '    DBCommand.SelectCommand.Parameters.Add(_Proveedor)
        '    DBCommand.SelectCommand.Parameters.Add(_Empresa)

        '    DBCommand.Fill(dsFicha, "Facturas")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function
        Public Function FacturasPagar(ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Proveedor As Integer, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasPagar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Estado As New SqlParameter("@Estado", SqlDbType.NVarChar)

            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Proveedor.Value = Proveedor
            _Empresa.Value = EmpresaActual
            _Estado.Value = Estado

            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Estado)

            DBCommand.Fill(dsFicha, "Facturas")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Function AcumuladosComprobantes(ByVal Proveedor As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresAcumuladosComp", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function PagarList1() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PagarLista1", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function PagarList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PagarLista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasDirectaLista(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasProveedoresD", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim _Fecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Estado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Proveedor.Value = Proveedor
            _Fecha.Value = Fecha
            _Fecha1.Value = Fecha1
            _Mes.Value = Mes
            _Estado.Value = Estado
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Fecha)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Mes)
            DBCommand.SelectCommand.Parameters.Add(_Estado)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            'Try
            DBCommand.Fill(dsFicha, "Tabla")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddFacturaDirecta(ByVal Factura As String, ByVal Fecha As String, ByVal FechaVencimiento As String, ByVal Proveedor As String, _
                                   ByVal Tipo As String, ByVal FormaPago As String, ByVal SubTotal As String, _
                                   ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String, _
                                   ByVal Otros As String, ByVal Total As String, ByVal MontoProductos As String, ByVal MontoServicios As String)


            Dim cmd As SqlCommand = New SqlCommand("_FacturasProveedoresAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _FechaVecimiento As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 9)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 50)
            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _MontoProductos As SqlParameter = New SqlParameter("@MontoProducto", SqlDbType.Float, 8)
            Dim _MontoServicios As SqlParameter = New SqlParameter("@MontoServicio", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaVecimiento.Value = FechaVencimiento
            _Proveedor.Value = Proveedor
            _Tipo.Value = Tipo
            _FormaPago.Value = FormaPago
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _MontoProductos.Value = MontoProductos
            _MontoServicios.Value = MontoServicios
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaVecimiento)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_MontoProductos)
            cmd.Parameters.Add(_MontoServicios)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '''DBConn.Open()
            'DBConnFacturas.Open()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            ''''DBConn.Close()
            '''DBConnFacturas.Close()

        End Function

        Public Function ListAll() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresListAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CatalogoProveedores() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoProveedores", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Catalogo")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ProveedoresCatalogo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresCatalogo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function NotasCreditoXProveedor(ByVal Proveedor As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_NotasCreditoXProveedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function NotasCreditoAdd(ByVal Proveedor As String, ByVal Fecha As String, ByVal Factura As String, ByVal Monto As String)
            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_NotasCreditoAdd", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pMonto As New SqlParameter("@Monto", SqlDbType.Float)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFactura.Value = Factura
            pMonto.Value = Monto
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pProveedor)
            cmd.Parameters.Add(pFecha)
            cmd.Parameters.Add(pFactura)
            cmd.Parameters.Add(pMonto)
            cmd.Parameters.Add(pEmpresa)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function NotasCredito(ByVal Mes As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_NotasCreditoList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pMes.Value = Mes
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function ListaProveedores(ByVal Filtro As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            If ChkProveedores Then  'Para EPPA
                DBCommand = New SqlDataAdapter("_ProveedoresLista2", DBConn)
            Else
                DBCommand = New SqlDataAdapter("_ProveedoresLista", DBConn)
            End If

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ProveedoresAdicionalesList(ByVal Proveedor As String, ByVal Articulo As String, ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresAdicionalesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Float)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pArticulo.Value = Articulo
            pFiltro.Value = Filtro
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function EstadoCuenta(ByVal Proveedor As String, Moneda As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EstadoCuentaProveedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Periodo As VB.SysContab.PeriodosDB

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            'Dim pCuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            'pCuenta.Value = Cuenta
            pPeriodo.Value = Periodo.Actual
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            'DBCommand.SelectCommand.Parameters.Add(pCuenta)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.SelectCommand.Parameters.AddWithValue("@Moneda", Moneda)
            DBCommand.SelectCommand.CommandTimeout = 0

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ProveedoresServiciosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresServiciosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Acumulados(ByVal Proveedor As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AcumuladosDevoluciones(ByVal Proveedor As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresAcumuladosDevoluciones", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 14/Nov/2005
        'Objetivo: Regresa la lista Proveedores dado un tipo
        '*******************************************************

        Public Function GetTiposProveedores() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TiposProveedoresGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "TipoProveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 14/Nov/2005
        'Objetivo: Regresa la lista Proveedores dado un tipo
        '*******************************************************

        Public Function GetProveedores(ByVal TipoProv As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim pTipoProv As New SqlParameter("@TipoProv", SqlDbType.NVarChar)
            pTipoProv.Value = TipoProv
            DBCommand.SelectCommand.Parameters.Add(pTipoProv)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ProveedoresListCombo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresListCombo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ProveedoresBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function ProveedoresList(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedoresList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListFacturas() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasCompras", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateFactura(ByVal Factura As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Ruc As String, _
                                   ByVal Concepto As String, ByVal Monto As String, ByVal SubTotal As String, ByVal IvaP As String, _
                                   ByVal IvaC As String, ByVal RecargoP As String, ByVal RecargoC As String, _
                                   ByVal RetencionP As String, ByVal RetencionC As String, ByVal Total As String, ByVal Saldo As String, _
                                   ByVal Fecha_Cancelar As String, ByVal Forma_Pago As String, _
                                   ByVal Fecha_Vencimiento As String, ByVal Tipo As String)

            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Concepto As SqlParameter = New SqlParameter("@Concepto", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _IvaP As SqlParameter = New SqlParameter("@IvaP", SqlDbType.Float, 8)
            Dim _IvaC As SqlParameter = New SqlParameter("@IvaC", SqlDbType.Float, 8)
            Dim _RecargoP As SqlParameter = New SqlParameter("@RecargoP", SqlDbType.Float, 8)
            Dim _RecargoC As SqlParameter = New SqlParameter("@RecargoC", SqlDbType.Float, 8)
            Dim _RetencionP As SqlParameter = New SqlParameter("@RetencionP", SqlDbType.Float, 8)
            Dim _RetencionC As SqlParameter = New SqlParameter("@RetencionC", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FechaCancelar As SqlParameter = New SqlParameter("@Fecha_Cancelar", SqlDbType.DateTime, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Proveedor.Value = Proveedor
            _Ruc.Value = Ruc
            _Concepto.Value = Concepto
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _IvaP.Value = IvaP
            _IvaC.Value = IvaC
            _RecargoP.Value = RecargoP
            _RecargoC.Value = RecargoC
            _RetencionP.Value = RetencionP
            _RetencionC.Value = RetencionC
            _Total.Value = Total
            _Saldo.Value = Saldo
            _FechaCancelar.Value = Fecha_Cancelar
            _FormaPago.Value = Forma_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Concepto)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_IvaP)
            cmd.Parameters.Add(_IvaC)
            cmd.Parameters.Add(_RecargoP)
            cmd.Parameters.Add(_RecargoC)
            cmd.Parameters.Add(_RetencionP)
            cmd.Parameters.Add(_RetencionC)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FechaCancelar)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddFactura(ByVal Factura As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Ruc As String, _
                                   ByVal Concepto As String, ByVal Monto As String, ByVal SubTotal As String, ByVal IvaP As String, _
                                   ByVal IvaC As String, ByVal RecargoP As String, ByVal RecargoC As String, _
                                   ByVal RetencionP As String, ByVal RetencionC As String, ByVal Total As String, ByVal Saldo As String, _
                                   ByVal Fecha_Cancelar As String, ByVal Forma_Pago As String, _
                                   ByVal Fecha_Vencimiento As String, ByVal Tipo As String)

            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Concepto As SqlParameter = New SqlParameter("@Concepto", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _IvaP As SqlParameter = New SqlParameter("@IvaP", SqlDbType.Float, 8)
            Dim _IvaC As SqlParameter = New SqlParameter("@IvaC", SqlDbType.Float, 8)
            Dim _RecargoP As SqlParameter = New SqlParameter("@RecargoP", SqlDbType.Float, 8)
            Dim _RecargoC As SqlParameter = New SqlParameter("@RecargoC", SqlDbType.Float, 8)
            Dim _RetencionP As SqlParameter = New SqlParameter("@RetencionP", SqlDbType.Float, 8)
            Dim _RetencionC As SqlParameter = New SqlParameter("@RetencionC", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FechaCancelar As SqlParameter = New SqlParameter("@Fecha_Cancelar", SqlDbType.DateTime, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Proveedor.Value = Proveedor
            _Ruc.Value = Ruc
            _Concepto.Value = Concepto
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _IvaP.Value = IvaP
            _IvaC.Value = IvaC
            _RecargoP.Value = RecargoP
            _RecargoC.Value = RecargoC
            _RetencionP.Value = RetencionP
            _RetencionC.Value = RetencionC
            _Total.Value = Total
            _Saldo.Value = Saldo
            _FechaCancelar.Value = Fecha_Cancelar
            _FormaPago.Value = Forma_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Concepto)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_IvaP)
            cmd.Parameters.Add(_IvaC)
            cmd.Parameters.Add(_RecargoP)
            cmd.Parameters.Add(_RecargoC)
            cmd.Parameters.Add(_RetencionP)
            cmd.Parameters.Add(_RetencionC)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FechaCancelar)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            Try
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        'Public Function AddFactura(ByVal Factura As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Concepto As String, ByVal Monto As String, _
        '                ByVal IvaP As String, ByVal IvaC As String, ByVal RecargoP As String, _
        '                ByVal RecargoC As String, ByVal RetencionP As String, ByVal RetencionC As String, ByVal Saldo As String, _
        '                ByVal Fecha_Cancelar As String, ByVal Forma_Pago As String, ByVal Fecha_Vencimiento As String)

        '    ' Crea una instancia de conexion y un comando SQL
        '    Dim cmd As New SqlCommand()
        '    Dim DBConn As SqlConnection

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    ' Se define el tipo de comando
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "INSERT INTO Facturas_Compras(Numero_Factura, Fecha, Proveedor, Concepto, Monto, IvaP, IvaC, RecargoP, RecargoC, RetencionP, RetencionC, Saldo, Fecha_Cancelar, Forma_Pago, Fecha_Vencimiento, Empresa) " & _
        '                "Values(" & "'" & Factura & "','" & Fecha & "','" & Proveedor & "','" & Concepto & "','" & Monto & "','" & IvaP & "','" & IvaC & "','" & RecargoP & "','" & RecargoC & "','" & RetencionP & "','" & RetencionC & "','" & Saldo & "','" & Fecha_Cancelar & "','" & Forma_Pago & "','" & Fecha_Vencimiento & "','" & EmpresaActual & "')"

        '    'Se asigna conexion al comando y se abre conexion 
        '    Try
        '        cmd.Connection = DBConn
        '        DBConn.Open()
        '        cmd.ExecuteNonQuery()
        '        DBConn.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        Public Function GetFacturasDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFacturas_Ventas As New DataSet
            Dim Details As New FacturasComprasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Facturas_Compras WHERE Factura = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsFacturas_Ventas, "Facturas_Compras")

            If dsFacturas_Ventas.Tables("Facturas_Compras").Rows.Count = 1 Then
                Details.Factura = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Factura").ToString
                Details.Fecha = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Fecha").ToString
                Details.Proveedor = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Proveedor").ToString
                Details.Ruc = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Ruc").ToString
                Details.Concepto = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Concepto").ToString
                Details.Monto = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Monto").ToString
                Details.SubTotal = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("SubTotal").ToString
                Details.IvaP = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("IvaP").ToString
                Details.IvaC = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("IvaC").ToString
                Details.RecargoP = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("RecargoP").ToString
                Details.RecargoC = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("RecargoC").ToString
                Details.RetencionP = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("RetencionP").ToString
                Details.RetencionC = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("RetencionC").ToString
                Details.Total = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Total").ToString
                Details.Saldo = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Saldo").ToString
                Details.Forma_Pago = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Forma_Pago").ToString
                Details.Fecha_Cancelar = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Fecha_Cancelar").ToString
                Details.Fecha_Vencimiento = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Fecha_Vencimiento").ToString
                Details.Tipo = dsFacturas_Ventas.Tables("Facturas_Compras").Rows(0).Item("Tipo").ToString

            End If

            Return Details

        End Function

        Public Function GeneradorReportes(ByVal Ciudad As String, ByVal Zona As String, ByVal FormaPago As String, ByVal Orden As String, ByVal TipoReporte As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesProveedores", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCiudad As New SqlParameter("@Ciudad", SqlDbType.NVarChar)
            Dim pZona As New SqlParameter("@Zona", SqlDbType.Int)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pTipoReporte As New SqlParameter("@TipoReporte", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pCiudad.Value = Ciudad
            pZona.Value = Zona
            pFormaPago.Value = FormaPago
            pOrden.Value = Orden
            pTipoReporte.Value = TipoReporte

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCiudad)
            DBCommand.SelectCommand.Parameters.Add(pZona)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pTipoReporte)

            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GenerarCodigo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo FROM Proveedores WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListProveedoresReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "PROVEEDORES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListAll(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO, Cuenta, NOMBRE, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM PROVEEDORES WHERE Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY NOMBRE", DBConn)
            DBCommand.Fill(dsFicha, "PROVEEDORES")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function GetDetails(ByVal Codigo As String) As ProveedoresDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsProveedores As New DataSet
            Dim dsZona As New DataSet
            Dim Details As New ProveedoresDetails
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            If Codigo = "" Then
                Details.Nombre = ""
            Else

                Try
                    'DBCommand = New SqlDataAdapter("SELECT * FROM Proveedores WHERE Codigo = " & Codigo & " AND Empresa = '" & EmpresaActual & "' AND Codigo <> 0", DBConn)
                    'DBCommand.Fill(dsProveedores, "Proveedores")

                    DBCommand = New SqlDataAdapter("sp_GetProveedoresDetails", DBConn)
                    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

                    DBCommand.SelectCommand.Parameters.AddWithValue("@Codigo", Codigo)
                    DBCommand.SelectCommand.Parameters.AddWithValue("@Empresa", EmpresaActual)

                    DBCommand.Fill(dsProveedores, "Proveedores")
                Catch ex As Exception
                    XtraMsg(ex.Message, MessageBoxIcon.Error)
                End Try

                If dsProveedores.Tables("Proveedores").Rows.Count = 1 Then
                    Details.Codigo = dsProveedores.Tables("Proveedores").Rows(0).Item("Codigo").ToString
                    Details.Nombre = dsProveedores.Tables("Proveedores").Rows(0).Item("Nombre").ToString
                    Details.Encargado = dsProveedores.Tables("Proveedores").Rows(0).Item("Encargado").ToString
                    Details.Cargo = dsProveedores.Tables("Proveedores").Rows(0).Item("Cargo").ToString
                    Details.Telefono_Contacto = dsProveedores.Tables("Proveedores").Rows(0).Item("Telefono_Contacto").ToString
                    Details.Email_Contacto = dsProveedores.Tables("Proveedores").Rows(0).Item("Email_Contacto").ToString
                    Details.Gerente = dsProveedores.Tables("Proveedores").Rows(0).Item("Gerente").ToString
                    Details.Telefono_Gerente = dsProveedores.Tables("Proveedores").Rows(0).Item("Telefono_Gerente").ToString
                    Details.Celular_Gerente = dsProveedores.Tables("Proveedores").Rows(0).Item("Celular_Gerente").ToString
                    Details.Email_Gerente = dsProveedores.Tables("Proveedores").Rows(0).Item("Email_Gerente").ToString
                    Details.Contador = dsProveedores.Tables("Proveedores").Rows(0).Item("Contador").ToString
                    Details.Telefono_Contador = dsProveedores.Tables("Proveedores").Rows(0).Item("Telefono_Contador").ToString
                    Details.Celular_Contador = dsProveedores.Tables("Proveedores").Rows(0).Item("Celular_Contador").ToString
                    Details.Email_Contador = dsProveedores.Tables("Proveedores").Rows(0).Item("Email_Contador").ToString
                    Details.Direccion = dsProveedores.Tables("Proveedores").Rows(0).Item("Direccion").ToString
                    Details.Departamento = dsProveedores.Tables("Proveedores").Rows(0).Item("Departamento").ToString
                    Details.Municipio = dsProveedores.Tables("Proveedores").Rows(0).Item("Municipio").ToString
                    Details.Ciudad = dsProveedores.Tables("Proveedores").Rows(0).Item("Ciudad").ToString
                    Details.Telefono = dsProveedores.Tables("Proveedores").Rows(0).Item("Telefono").ToString
                    Details.Fax = dsProveedores.Tables("Proveedores").Rows(0).Item("Fax").ToString
                    Details.Correo = dsProveedores.Tables("Proveedores").Rows(0).Item("Correo").ToString
                    Details.Ruc = dsProveedores.Tables("Proveedores").Rows(0).Item("Ruc").ToString
                    Details.Cedula = dsProveedores.Tables("Proveedores").Rows(0).Item("Cedula").ToString
                    Details.Tipo = dsProveedores.Tables("Proveedores").Rows(0).Item("Tipo").ToString
                    Details.Cod_Zona = dsProveedores.Tables("Proveedores").Rows(0).Item("Cod_Zona").ToString
                    Details.Cod_Forma_Pago = IsNull(dsProveedores.Tables("Proveedores").Rows(0).Item("Cod_Forma_Pago"), 0)
                    Details.Cuenta = dsProveedores.Tables("Proveedores").Rows(0).Item("Cuenta").ToString
                    Details.TipoProveedor = dsProveedores.Tables("Proveedores").Rows(0).Item("TipoProveedor").ToString
                    Details.Retenedor = dsProveedores.Tables("Proveedores").Rows(0).Item("Retenedor")
                    Details.Varios = dsProveedores.Tables("Proveedores").Rows(0).Item("Varios")
                    Details.Exento = dsProveedores.Tables("Proveedores").Rows(0).Item("exento")

                    Details.nNombre = dsProveedores.Tables("Proveedores").Rows(0).Item("nNombre")
                    Details.pApellido = dsProveedores.Tables("Proveedores").Rows(0).Item("papellido")
                    Details.sApellido = dsProveedores.Tables("Proveedores").Rows(0).Item("sapellido")
                    Details.Origen = dsProveedores.Tables("Proveedores").Rows(0).Item("origen")
                    Details.CodigoLetra = dsProveedores.Tables("Proveedores").Rows(0).Item("CodigoLetra")
                    Details.CuentaTransito = dsProveedores.Tables("Proveedores").Rows(0).Item("CuentaTransito")
                    Details.Prefijo = dsProveedores.Tables("Proveedores").Rows(0).Item("Prefijo")

                    Details.DepartamentoN = dsProveedores.Tables("Proveedores").Rows(0).Item("DepartamentoN")
                    Details.MunicipioN = dsProveedores.Tables("Proveedores").Rows(0).Item("MunicipioN")
                End If
            End If
            Return Details

        End Function

        Public Function GetListFiltro() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT '0' as CODIGO, '' as Cuenta, '' as Nombre, '' as Encargado, '' as Direccion, '' as Ciudad, '' as Telefono, '' as Fax, '' as Ruc UNION  SELECT convert(varchar, CODIGO) as CODIGO, Cuenta, Nombre, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM Proveedores WHERE Empresa = '" & EmpresaActual & "' AND Codigo <> 0", DBConn)
            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO, Cuenta, Nombre, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM Proveedores WHERE Empresa = '" & EmpresaActual & "' AND Codigo <> 0", DBConn)
            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Proveedores WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM Proveedores WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Proveedores")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal PC As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            If PC = "P" Then
                DBCommand = New SqlDataAdapter("SELECT CODIGO, Cuenta, NOMBRE, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM PROVEEDORES WHERE Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' AND Codigo <> 0 ORDER BY NOMBRE", DBConn)
            End If

            If PC = "C" Then
                DBCommand = New SqlDataAdapter("SELECT CODIGO, Cuenta, NOMBRE, Contacto, Direccion, Ciudad, Telefono, Fax, Ruc FROM CLIENTES WHERE Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' AND Codigo <> 0 ORDER BY NOMBRE", DBConn)
            End If

            DBCommand.Fill(dsFicha, "PROVEEDORES")
            DBConn.Close()

            Return dsFicha
        End Function
        'Public Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet
        '    Dim cd As String

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("SELECT CODIGO, Cuenta, NOMBRE, Encargado, Direccion, Ciudad, Telefono, Fax, Ruc FROM PROVEEDORES WHERE Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' AND Codigo <> 0 ORDER BY NOMBRE", DBConn)
        '    DBCommand.Fill(dsFicha, "PROVEEDORES")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Encargado As String, ByVal Cargo As String, ByVal Telefono_Contacto As String, ByVal Email_Contacto As String, _
                 ByVal Gerente As String, ByVal Telefono_Gerente As String, ByVal Celular_Gerente As String, ByVal Email_Gerente As String, _
                 ByVal Contador As String, ByVal Telefono_Contador As String, ByVal Celular_Contador As String, ByVal Email_Contador As String, _
                 ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, ByVal Fax As String, ByVal Correo As String, _
                 ByVal Ruc As String, ByVal Tipo As String, ByVal Forma_Pago As String, _
                 ByVal Cod_Zona As String, ByVal Cuenta As String, ByVal TipoProveedor As String, _
                 ByVal Retenedor As String, ByVal Departamento As String, _
                 ByVal Municipio As String, ByVal Varios As Integer, ByVal Exento As Integer, ByVal Cedula As String, _
                 ByVal nNombre As String, ByVal pApellido As String, ByVal sApellido As String, ByVal Origen As Integer, Optional ByVal CodigoLetra As String = "", _
                 Optional ByVal CuentaTransito As String = "", Optional Prefijo As String = "")

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Proveedores(Codigo, Nombre, nnombre, papellido, sapellido, Encargado, Cargo, Telefono_Contacto," & _
                        "Email_Contacto, Gerente, Telefono_Gerente, Celular_Gerente, Email_Gerente, Contador, Telefono_Contador, Celular_Contador, " & _
                        "Email_Contador, Direccion, Ciudad, Telefono, Fax, Correo, Ruc, Tipo, Cod_Forma_Pago, Cod_Zona, Cuenta, TipoProveedor, Retenedor," & _
                        "Departamento, Municipio, Varios, Empresa, Exento, Cedula, Origen,CodigoLetra,CuentaTransito, Prefijo) " & _
                        "Values(" & "'" & Codigo & "','" & Nombre & "','" & nNombre & "','" & pApellido & "','" & sApellido & "','" & Encargado & "','" & _
                        Cargo & "','" & Telefono_Contacto & "','" & Email_Contacto & "','" & Gerente & "','" & Telefono_Gerente & "','" & Celular_Gerente & _
                        "','" & Email_Gerente & "','" & Contador & "','" & Telefono_Contador & "','" & Celular_Contador & "','" & Email_Contador & "','" & _
                        Direccion & "','" & Ciudad & "','" & Telefono & "','" & Fax & "','" & Correo & "','" & Ruc & "','" & Tipo & "','" & Forma_Pago & _
                        "','" & Cod_Zona & "','" & Cuenta & "','" & TipoProveedor & "','" & Retenedor & "','" & Departamento & "','" & Municipio & "'," & _
                        Varios & ",'" & EmpresaActual & "','" & Exento & "','" & Cedula & "'," & Origen & ",'" & CodigoLetra & "','" & CuentaTransito & "','" & Prefijo & "')"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Encargado As String, ByVal Cargo As String, ByVal Telefono_Contacto As String, ByVal Email_Contacto As String, _
                ByVal Gerente As String, ByVal Telefono_Gerente As String, ByVal Celular_Gerente As String, ByVal Email_Gerente As String, _
                ByVal Contador As String, ByVal Telefono_Contador As String, ByVal Celular_Contador As String, ByVal Email_Contador As String, _
                ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, _
                ByVal Fax As String, ByVal Correo As String, ByVal Ruc As String, _
                ByVal Tipo As String, ByVal Forma_Pago As String, ByVal Cod_Zona As String, _
                ByVal Cuenta As String, ByVal TipoProveedor As String, _
                ByVal Retenedor As String, ByVal Departamento As String, _
                ByVal Municipio As String, ByVal Varios As Integer, ByVal Exento As Integer, ByVal Cedula As String, _
                ByVal nNombre As String, ByVal pApellido As String, ByVal sApellido As String, ByVal Origen As Integer, _
                Optional ByVal CodigoLetra As String = "", Optional ByVal CuentaTransito As String = "", Optional Prefijo As String = "")

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Proveedores SET Nombre = '" & Nombre & "', " & _
                              "Encargado = '" & Encargado & "', " & _
                              "nNombre = '" & nNombre & "', " & _
                              "pApellido = '" & pApellido & "', " & _
                              "sApellido = '" & sApellido & "', " & _
                              "Cargo = '" & Cargo & "', " & _
                              "Telefono_Contacto = '" & Telefono_Contacto & "', " & _
                              "Email_Contacto = '" & Email_Contacto & "', " & _
                              "Gerente = '" & Gerente & "', " & _
                              "Telefono_Gerente = '" & Telefono_Gerente & "', " & _
                              "Celular_Gerente = '" & Celular_Gerente & "', " & _
                              "Email_Gerente = '" & Email_Gerente & "', " & _
                              "Contador = '" & Contador & "', " & _
                              "Telefono_Contador = '" & Telefono_Contador & "', " & _
                              "Celular_Contador = '" & Celular_Contador & "', " & _
                              "email_Contador = '" & Email_Contador & "', " & _
                              "Direccion = '" & Direccion & "', " & _
                              "Ciudad = '" & Ciudad & "', " & _
                              "Telefono = '" & Telefono & "', " & _
                              "Fax = '" & Fax & "', " & _
                              "Correo = '" & Correo & "', " & _
                              "Ruc = '" & Ruc & "', " & _
                              "Cedula = '" & Cedula & "', " & _
                              "Tipo = '" & Tipo & "', " & _
                              "Cod_Forma_Pago = '" & Forma_Pago & "', " & _
                              "Cod_Zona = '" & Cod_Zona & "', " & _
                              "Cuenta = '" & Cuenta & "', " & _
                              "TipoProveedor = '" & TipoProveedor & "', " & _
                              "Retenedor = '" & Retenedor & "', " & _
                              "Exento = '" & Exento & "', " & _
                              "Departamento = '" & Departamento & "', " & _
                              "Municipio = '" & Municipio & "', " & _
                              "Varios = '" & Varios & "', " & _
                              "Origen = " & Origen & ", " & _
                              "CodigoLetra = '" & CodigoLetra & "'," & _
                              "Prefijo = '" & Prefijo & "'," & _
                              "CuentaTransito='" & CuentaTransito & "'" & _
                              " WHERE Codigo = " & Codigo & " AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function


        Public Shared Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Proveedores WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

            DBConn.Close()

        End Function
        Public Shared Function BuscarxRuc(ByVal Ruc As String) As Integer
            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_Proveedor_Ruc_Buscar", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pRuc As New SqlParameter("@Ruc", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pProveedor.Direction = ParameterDirection.Output
            pRuc.Value = Ruc

            cmd.Parameters.Add(pEmpresa)
            cmd.Parameters.Add(pProveedor)
            cmd.Parameters.Add(pRuc)

            Try
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pProveedor.Value
        End Function
        Public Shared Function BuscarxCedula(ByVal Cedula As String) As Integer
            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_Proveedor_Cedula_Buscar", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pRuc As New SqlParameter("@Cedula", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pProveedor.Direction = ParameterDirection.Output
            pRuc.Value = Cedula

            cmd.Parameters.Add(pEmpresa)
            cmd.Parameters.Add(pProveedor)
            cmd.Parameters.Add(pRuc)

            Try
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pProveedor.Value
        End Function

        Public Shared Function BuscarxNombre(ByVal Nombre As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Proveedor_Nombre_Buscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            DBCommand.SelectCommand.Parameters.Add(_Nombre)

            Try
                DBCommand.Fill(dsFicha, "nombres")
                DBConn.Close()

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try

            Return dsFicha

        End Function


        Public Shared Function NotasProveedoresList() As DataTable

            Dim dt As New DataTable
            Dim sConn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            Dim DBCommand As New SqlDataAdapter("_NotasProveedoresList", sConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Try
                sConn.Open()

                DBCommand.SelectCommand.ExecuteNonQuery()
                DBCommand.Fill(dt)

                sConn.Close()

                Return dt
            Catch ex As Exception
                MsgBox("ERROR al Imprimr Nota. " & ex.Message)
                Return Nothing
            End Try
        End Function



        Public Shared Function NotaProveedorImprimir(ByVal Nota As String, ByVal Proveedor As Integer, ByVal DC As String, ByVal Letras As String) As DataTable

            Return ObtieneDatos("_NotaProveedorImprimir",
                                Nota,
                                Proveedor,
                                DC,
                                EmpresaActual,
                                Letras)


            'Dim dt As New DataTable

            'Dim sConn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            'Dim DBCommand As New SqlDataAdapter("_NotaProveedorImprimir", sConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim _Nota As New SqlParameter("@Referencia", SqlDbType.NVarChar)
            'Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            'Dim _DC As New SqlParameter("@DC", SqlDbType.NVarChar)
            'Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim _Letras As New SqlParameter("@Letras", SqlDbType.NVarChar)

            '_Nota.Value = Nota
            '_Proveedor.Value = Proveedor
            '_DC.Value = DC
            '_Empresa.Value = EmpresaActual
            '_Letras.Value = Letras

            'DBCommand.SelectCommand.Parameters.Add(_Nota)
            'DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            'DBCommand.SelectCommand.Parameters.Add(_DC)
            'DBCommand.SelectCommand.Parameters.Add(_Empresa)
            'DBCommand.SelectCommand.Parameters.Add(_Letras)

            'Try
            '    sConn.Open()

            '    DBCommand.SelectCommand.CommandTimeout = 0
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBCommand.Fill(dt)

            '    sConn.Close()

            '    Return dt
            'Catch ex As Exception
            '    XtraMsg("ERROR al Imprimr Nota.", ex.Message)
            '    Return Nothing
            'End Try

        End Function

        Public Shared Function NotasUpdateEstado(ByVal Numero As Integer)

            Dim DBCommand As New SqlCommand("_NotasProveedoresEstado", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Numero As New SqlParameter("@Numero", SqlDbType.Int)

            _Empresa.Value = EmpresaActual
            _Numero.Value = Numero

            DBCommand.Parameters.Add(_Empresa)
            DBCommand.Parameters.Add(_Numero)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()
        End Function


        Public Shared Function RegistrarTransaccion(ByVal NotaDC As String, ByVal Proveedor As Integer, ByVal Tipo As Integer, ByVal TipoTrans As Integer, _
                ByVal CompNo As Integer, ByVal Concepto As String, ByVal Fecha As Date, ByVal Monto As Double, ByVal TasaCambio As Decimal, ByVal Moneda As String, _
                Diferencial As Integer) As Boolean

            Dim DBCommand As New SqlCommand("_TransaccionesProveedoresADD", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa_ID", SqlDbType.Int)
            Dim pNota As New SqlParameter("@Factura_ID", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor_ID", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoTrans As New SqlParameter("@TipoTransaccion", SqlDbType.Int)
            Dim pCompNo As New SqlParameter("@Comp_No", SqlDbType.Int)
            Dim pPer_Id As New SqlParameter("@Per_ID", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pConcepto As New SqlParameter("@Concepto", SqlDbType.NVarChar)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pMoto As New SqlParameter("@Monto", SqlDbType.Float)
            Dim pTC As New SqlParameter("@TasaCambio", SqlDbType.Decimal)
            Dim pMoneda As New SqlParameter("@mon_codigo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pNota.Value = NotaDC
            pProveedor.Value = Proveedor
            pTipo.Value = Tipo
            pTipoTrans.Value = TipoTrans
            pCompNo.Value = CompNo
            pPer_Id.Value = VB.SysContab.PeriodosDB.Activo(Fecha)
            pMes.Value = Fecha.Month
            pConcepto.Value = Concepto
            pFecha.Value = Fecha
            pMoto.Value = Monto
            pTC.Value = TasaCambio
            pMoneda.Value = Moneda

            DBCommand.Parameters.Add(pEmpresa)
            DBCommand.Parameters.Add(pNota)
            DBCommand.Parameters.Add(pProveedor)
            DBCommand.Parameters.Add(pTipo)
            DBCommand.Parameters.Add(pTipoTrans)
            DBCommand.Parameters.Add(pCompNo)
            DBCommand.Parameters.Add(pPer_Id)
            DBCommand.Parameters.Add(pMes)
            DBCommand.Parameters.Add(pConcepto)
            DBCommand.Parameters.Add(pFecha)
            DBCommand.Parameters.Add(pMoto)
            DBCommand.Parameters.Add(pTC)
            DBCommand.Parameters.Add(pMoneda)

            DBCommand.Parameters.AddWithValue("@Diferencial", Diferencial)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()
        End Function

        Public Shared Function DinamicoClientesAntiguedadProxima(Corte As Date, Rubro As String, Moneda As String) As DataTable
            Return ObtieneDatos("SPRptAnalisisAntiguedad_CxP_Proximas", Corte, Rubro, EmpresaActual, Moneda)
        End Function

        Public Shared Function RelacionDeSaldos(Desde As Date, Hasta As String, Cuenta As String, Moneda As String) As DataTable
            Return ObtieneDatos("JAR_RelacionDeSaldosProveedores", Desde, Hasta, Cuenta, Moneda, EmpresaActual)
        End Function


    End Class

End Namespace
