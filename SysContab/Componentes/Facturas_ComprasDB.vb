Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Facturas_ComprasDB
        Public Shared Function GetFacturaCompraDetalle(ByVal Factura As String, ByVal Proveedor As String, ByVal Destino As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetFacturasComprasDetalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function VerifyExistencia(ByVal Factura As String, ByVal Proveedor As Integer) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas

            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_FacturasComprasComprobanteValidarExistencia", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pOrden As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int)
            pOrden.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(pOrden)

            Dim pFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            pFactura.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(pFactura)

            Dim pValue As SqlParameter = New SqlParameter("@Existe", SqlDbType.Bit)
            pValue.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pValue)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pValue.Value

        End Function

        Public Function VerifyOrder(ByVal Orden As Integer) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas

            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_FacturasComprasVerify", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pOrden As SqlParameter = New SqlParameter("@Orden", SqlDbType.Int)
            pOrden.Value = Orden
            DBCommand.SelectCommand.Parameters.Add(pOrden)

            Dim pValue As SqlParameter = New SqlParameter("@Value", SqlDbType.Char, 2)
            pValue.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pValue)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pValue.Value.Trim

        End Function

        Public Function IRComprasMes(ByVal Mes As String, _
                                    ByVal ServBas As Integer, _
                                    ByVal MontoIR As String, ByVal IRProd As String, _
                                    ByVal IRServ As String, ByVal Year As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasIRMes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _MontoIR As SqlParameter = New SqlParameter("@MontoIR", SqlDbType.Float)
            _MontoIR.Value = MontoIR
            DBCommand.SelectCommand.Parameters.Add(_MontoIR)

            Dim _IRProd As SqlParameter = New SqlParameter("@IRProd", SqlDbType.Float)
            _IRProd.Value = IRProd
            DBCommand.SelectCommand.Parameters.Add(_IRProd)

            Dim _IRServ As SqlParameter = New SqlParameter("@IRServ", SqlDbType.Float)
            _IRServ.Value = IRServ
            DBCommand.SelectCommand.Parameters.Add(_IRServ)

            Dim _ServBas As SqlParameter = New SqlParameter("@ServBas", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _ServBas.Value = ServBas
            DBCommand.SelectCommand.Parameters.Add(_ServBas)

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _Year As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            DBCommand.SelectCommand.Parameters.Add(_Year)

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasComprasPendientes() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasPendientes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ServiciosProfesionales(ByVal Mes As String, ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosProfesionales", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim _PerID As SqlParameter = New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = VB.SysContab.PeriodosDB.Actual
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            'Dim _IR As SqlParameter = New SqlParameter("@IR", SqlDbType.Float)
            '_IR.Value = IR
            'DBCommand.SelectCommand.Parameters.Add(_IR)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasComprasContado(ByVal TipoProducto As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasContado", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _TipoProducto As SqlParameter = New SqlParameter("@TipoProducto", SqlDbType.NVarChar)
            _TipoProducto.Value = TipoProducto
            DBCommand.SelectCommand.Parameters.Add(_TipoProducto)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasCompraAlmacen(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String, ByVal TipoFactura As String, ByVal Origen As String, ByVal Destino As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasAlmacen", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pOrigen.Value = Origen
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateFechaAlmacen(ByVal Numero As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Bodega As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateFechaAlmacen", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar)

            _Numero.Value = Numero
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor
            _Bodega.Value = Bodega

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Bodega)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function DevolucionesProveedorFacturas(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Tipo As String, ByVal Origen As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesProveedorFacturas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pTipo.Value = Tipo
            pOrigen.Value = Origen
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateFacturaAnulado(ByVal Factura As String, ByVal Estado As Boolean, ByVal Proveedor As String)

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateAnulado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Estado.Value = Estado
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function FacturaCompraDetalleDevolucion(ByVal Factura As String, ByVal Proveedor As String, ByVal Tipo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaCompraDetalleDevolucion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function EntradaAlmacenDetalle(ByVal Factura As String, ByVal Proveedor As String, ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EntradaAlmacenDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateNumero(ByVal Factura As String, ByVal OrdenCompra As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateNumero", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _OrdenCompra.Value = OrdenCompra
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function NumeroTemporal() As Integer
            'Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_FacturaNumeroTemporal", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            ' Return the Total
            If parameterFactura.Value.ToString() <> "" Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function UpdateCantidadAlmacen(ByVal Numero As String, ByVal Item As String, ByVal Tipo As String, ByVal Cantidad As String, ByVal IvaAlmacen As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateCantidadAlmacen", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim _IvaAlmacen As SqlParameter = New SqlParameter("@IvaAlmacen", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Cantidad.Value = Cantidad
            _IvaAlmacen.Value = IvaAlmacen
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_IvaAlmacen)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 8/Marzo/2006
        'Objetivo: Regresa IR de las Facturas Compras
        '*******************************************************

        Public Function GetIRCompras(ByVal FechaINI As String, ByVal FechaFIN As String, ByVal Mes As String, _
                                    ByVal TipoProd As Integer, ByVal ServBas As Integer, _
                                    ByVal MontoIR As String, ByVal IRProd As String, _
                                    ByVal IRServ As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasIR", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim _MontoIR As SqlParameter = New SqlParameter("@MontoIR", SqlDbType.Float)
            _MontoIR.Value = MontoIR
            DBCommand.SelectCommand.Parameters.Add(_MontoIR)

            Dim _IRProd As SqlParameter = New SqlParameter("@IRProd", SqlDbType.Float)
            _IRProd.Value = IRProd
            DBCommand.SelectCommand.Parameters.Add(_IRProd)

            Dim _IRServ As SqlParameter = New SqlParameter("@IRServ", SqlDbType.Float)
            _IRServ.Value = IRServ
            DBCommand.SelectCommand.Parameters.Add(_IRServ)

            Dim _ServBas As SqlParameter = New SqlParameter("@ServBas", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _ServBas.Value = ServBas
            DBCommand.SelectCommand.Parameters.Add(_ServBas)

            Dim _TipoProd As SqlParameter = New SqlParameter("@TipoProd", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _TipoProd.Value = TipoProd
            DBCommand.SelectCommand.Parameters.Add(_TipoProd)

            If FechaINI <> "" And FechaFIN <> "" Then

                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 3/Marzo/2006
        'Objetivo: Regresa la lista de Facturas de Compras
        '*******************************************************

        Public Function GetFacturasDetalles(ByVal FechaINI As String, ByVal FechaFIN As String, ByVal Mes As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasListxFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            If FechaINI <> "" And FechaFIN <> "" Then

                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 3/Marzo/2006
        'Objetivo: Regresa IVA de las Facturas Compras
        '*******************************************************

        Public Function GetIVAxTipo(ByVal FechaINI As String, ByVal FechaFIN As String, ByVal Mes As String, ByVal TipoProd As Integer, ByVal ServBas As Integer, ByVal Year As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasIVA", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim _ServBas As SqlParameter = New SqlParameter("@ServBas", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _ServBas.Value = ServBas
            DBCommand.SelectCommand.Parameters.Add(_ServBas)

            Dim _TipoProd As SqlParameter = New SqlParameter("@TipoProd", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _TipoProd.Value = TipoProd
            DBCommand.SelectCommand.Parameters.Add(_TipoProd)


            If FechaINI <> "" And FechaFIN <> "" Then

                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _Year As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            DBCommand.SelectCommand.Parameters.Add(_Year)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasServiciosBasicos(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String, ByVal TipoFactura As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As Integer

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasServiciosBasicos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            If Estado = 0 Then
                EstadoLocal = -1
            ElseIf Estado = 1 Then
                EstadoLocal = 0
            ElseIf Estado = 2 Then
                EstadoLocal = 1
            End If

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Inventario(ByVal Tipo As Integer, ByVal Mes As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Proveedor As String, ByVal CodArticulo As String, ByVal Articulo As String, ByVal FacRango1 As Integer, ByVal FacRango2 As Integer, ByVal ArtMin As Integer, ByVal ArtMax As Integer, ByVal ArtTipo As String, ByVal NoOrden As String, ByVal NoAlmacen As String, ByVal NoFactura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InventarioReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipoInfo As New SqlParameter("@TipoInfo", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pCodigoArt As New SqlParameter("@CodArticulo", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Int)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Int)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMax As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pArtTipo As New SqlParameter("@ArtTipo", SqlDbType.NVarChar)
            Dim pNoOrden As New SqlParameter("@NoOrden", SqlDbType.NVarChar)
            Dim pNoAlmacen As New SqlParameter("@NoAlmacen", SqlDbType.NVarChar)
            Dim pNoFactura As New SqlParameter("@NoFactura", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pTipoInfo.Value = Tipo
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pProveedor.Value = Proveedor
            pCodigoArt.Value = CodArticulo
            pArticulo.Value = Articulo
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMax.Value = ArtMax
            pArtTipo.Value = ArtTipo
            pNoOrden.Value = NoOrden
            pNoAlmacen.Value = NoAlmacen
            pNoFactura.Value = NoFactura

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipoInfo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pCodigoArt)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMax)
            DBCommand.SelectCommand.Parameters.Add(pNoOrden)
            DBCommand.SelectCommand.Parameters.Add(pArtTipo)
            DBCommand.SelectCommand.Parameters.Add(pNoAlmacen)
            DBCommand.SelectCommand.Parameters.Add(pNoFactura)

            Try

                DBCommand.Fill(dsFicha, "Ordenes_Compras")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function Inventario2(ByVal TipoInfo As String, ByVal Proveedor As String, ByVal CodArticulo As String, ByVal Articulo As String, ByVal ArtTipo As String, ByVal ArtMin As String, ByVal ArtMax As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InventarioReporte2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipoInfo As New SqlParameter("@TipoInfo", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pCodigoArt As New SqlParameter("@CodigoArt", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pArtTipo As New SqlParameter("@ArtTipo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pTipoInfo.Value = TipoInfo
            pProveedor.Value = Proveedor
            pCodigoArt.Value = CodArticulo
            pArticulo.Value = Articulo
            pArtTipo.Value = ArtTipo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipoInfo)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pCodigoArt)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArtTipo)

            Try

                DBCommand.Fill(dsFicha, "Articulos")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function FacturasList(ByVal Proveedor As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasCompras", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pTipo.Value = Tipo
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub DeleteDetalle(ByVal Factura As String, ByVal Proveedor As String)

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasLineasDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            ' Open the connection and execute the Command
            'DBConn.Open()
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Sub

        Public Shared Function FacturaSBDetalle(ByVal Factura As String, ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasSBDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function FacturaDetalle(ByVal Factura As String, ByVal Proveedor As String, ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function UpdateEstado(ByVal Numero As String,
                                            ByVal Estado As String,
                                            ByVal Fecha As String,
                                            ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function


        Public Shared Function UpdateEstado(ByVal Numero As String, ByVal Estado As String, ByVal Proveedor As Integer) As Boolean
            Try
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                '
                Conn.RemoveParameters()
                Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, Numero)
                Conn.AddParameter("Estado", SqlDbType.NVarChar, 5, ParameterDirection.Input, Estado)
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Now.Date)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, Proveedor)
                Conn.EjecutarComando("_FacturasComprasUpdateEstado")

                Return True
            Catch ex As Exception
                XtraMsg("Error al Actualizar Estado en Factura No. " & Numero & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function UpdateEstadoAlmacen(ByVal Numero As String, Fecha As Date, ByVal Proveedor As Integer,
                                                   Bodega As String) As Boolean

            Try
                Dim Conn As New DbConnect.Connect(Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Input, Numero)
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Proveedor", SqlDbType.Int, 4, ParameterDirection.Input, Proveedor)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, Bodega)
                Conn.EjecutarComando("_FacturasComprasUpdateFechaAlmacen")

                Return True
            Catch ex As Exception
                XtraMsg("Error al Actualizar Estado en Almacen, Factura No. " & Numero & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try

        End Function


        Public Function GetListxTipoProductoCredito(ByVal TipoProducto As String, ByVal Fecha As Date, _
                                                    ByVal TCambio As Double) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasGetListxTipoProductoCredito", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _TipoProducto As SqlParameter = New SqlParameter("@TipoProducto", SqlDbType.NVarChar)
            _TipoProducto.Value = TipoProducto
            DBCommand.SelectCommand.Parameters.Add(_TipoProducto)

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _TCambio As SqlParameter = New SqlParameter("@Tasa", SqlDbType.Float)
            _TCambio.Value = TCambio
            DBCommand.SelectCommand.Parameters.Add(_TCambio)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetMntoCompras(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Abono As Double, _
                                               ByVal MonedaCambio As String) As Double

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dt As DataTable

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("sp_CalcularMntoCompras", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha1 As SqlParameter = New SqlParameter("@Fecha1", SqlDbType.SmallDateTime)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Fecha2 As SqlParameter = New SqlParameter("@Fecha2", SqlDbType.SmallDateTime)
            _Fecha2.Value = Fecha2
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)

            Dim _Abono As SqlParameter = New SqlParameter("@AbonoU", SqlDbType.Float)
            _Abono.Value = Abono
            DBCommand.SelectCommand.Parameters.Add(_Abono)

            Dim _Moneda As SqlParameter = New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            _Moneda.Value = MonedaCambio
            DBCommand.SelectCommand.Parameters.Add(_Moneda)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pMnto As SqlParameter = New SqlParameter("@Mnto", SqlDbType.Float)
            pMnto.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pMnto)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            Return pMnto.Value
        End Function





        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 14/Febrero/2006
        'Objetivo: Regresa la lista de Facturas de un tipo de Proveedor
        '  0 - Productos  1 - Servicios 2 - Ambos - 3 Servicios
        '*******************************************************

        Public Function GetListxTipoProducto(ByVal TipoProducto As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasGetListxTipoProducto", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _TipoProducto As SqlParameter = New SqlParameter("@TipoProducto", SqlDbType.NVarChar)
            _TipoProducto.Value = TipoProducto
            DBCommand.SelectCommand.Parameters.Add(_TipoProducto)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasComprasPagar(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String, ByVal TipoFactura As String, ByVal Origen As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasPagar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pOrigen.Value = Origen
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function FacturasCompraLista(ByVal Proveedor As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String, ByVal TipoFactura As String, ByVal Origen As String, ByVal Destino As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasLista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pOrigen.Value = Origen
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function FacturasCompraLista_V2(ByVal Estado As String, ByVal Tipo As String, _
                                                      ByVal TipoFactura As String, ByVal Origen As String, _
                                                      ByVal Destino As String, ByVal Desde As Date, ByVal Hasta As Date) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasLista_V2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDesde As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pHasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If

            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pOrigen.Value = Origen
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual
            pDesde.Value = Desde
            pHasta.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pDesde)
            DBCommand.SelectCommand.Parameters.Add(pHasta)

            'Try
            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasCompras(ByVal Tipo As String, ByVal Mes As String, _
            ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Proveedor As String, _
            ByVal CodArticulo As String, ByVal Articulo As String, ByVal FacRango1 As String, _
            ByVal FacRango2 As String, ByVal TipoFac2 As String, ByVal TipoArt As String, _
            ByVal ArtMin As String, ByVal ArtMax As String, ByVal FormaPago As String, _
            ByVal Orden As Integer, ByVal TipoProducto As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasList", DBConn)

            'If Orden = 1 Or Orden = 3 Then
            '    DBCommand = New SqlDataAdapter("_FacturasComprasList", DBConn)
            'ElseIf Orden = 2 Then
            '    DBCommand = New SqlDataAdapter("_FacturasComprasList1", DBConn)
            'End If

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@TipoFac", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.SmallDateTime)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.SmallDateTime)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pCodArticulo As New SqlParameter("@CodArticulo", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pTipoArt As New SqlParameter("@TipoArt", SqlDbType.NVarChar)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Float)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Float)
            Dim pTipoFac2 As New SqlParameter("@TipoFac2", SqlDbType.NVarChar)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMAx As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim _TipoProducto As New SqlParameter("@Tipo", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo
            pTipoFac2.Value = TipoFac2
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pProveedor.Value = Proveedor
            pCodArticulo.Value = CodArticulo
            pArticulo.Value = Articulo
            pTipoArt.Value = TipoArt
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMAx.Value = ArtMax
            pFormaPago.Value = FormaPago
            pOrden.Value = Orden
            _TipoProducto.Value = TipoProducto

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFac2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pCodArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMAx)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(_TipoProducto)

            'Try

            DBCommand.Fill(dsFicha, "Facturas_Compras")
            'Catch e As Exception
            '    MsgBox(e.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function MaxTotalFacturaCompras() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalFacturaCompras", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function MaxTotalFacturaComprasLinea() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalFacturaComprasLinea", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras_Lineas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 10/Febrero/2006
        'Objetivo: Regresa la lista de Facturas de Un Proveedor
        '*******************************************************

        Public Function GetList(ByVal ProvID As String, ByVal EsqID As String, ByVal FormaPago As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _ProvID As SqlParameter = New SqlParameter("@ProvID", SqlDbType.NVarChar)
            _ProvID.Value = ProvID
            DBCommand.SelectCommand.Parameters.Add(_ProvID)

            Dim _EsqID As SqlParameter = New SqlParameter("@EsqID", SqlDbType.NVarChar)
            _EsqID.Value = EsqID
            DBCommand.SelectCommand.Parameters.Add(_EsqID)

            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function
        '*******************************************************
        'Elaborada por: RMPR
        'Fecha: 22/JUNIO/2006
        'Objetivo: Regresa la lista de Facturas de Un Proveedor (SB)
        '*******************************************************

        Public Shared Function GetList(ByVal ProvID As Integer, ByVal Basico_ID As Integer, _
                ByVal Consecutivo_ID As Integer, ByVal FormaPago As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasSBGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _ProvID As SqlParameter = New SqlParameter("@ProvID", SqlDbType.Int)
            _ProvID.Value = ProvID
            DBCommand.SelectCommand.Parameters.Add(_ProvID)

            Dim _Basico_ID As SqlParameter = New SqlParameter("@Basico_ID", SqlDbType.Int)
            _Basico_ID.Value = Basico_ID
            DBCommand.SelectCommand.Parameters.Add(_Basico_ID)

            Dim _EsqID As SqlParameter = New SqlParameter("@Consecutivo_ID", SqlDbType.Int)
            _EsqID.Value = Consecutivo_ID
            DBCommand.SelectCommand.Parameters.Add(_EsqID)

            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasXFactProv(ByVal Proveedor As String, ByVal Factura As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasCompraXFactProv", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compra")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasXProveedor(ByVal Proveedor As String, ByVal Fecha As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasCompraXProveedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compra")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero(ByVal Proveedor As String) As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pProveedor.Value = Proveedor

            cmd.Parameters.Add(pEmpresa)
            cmd.Parameters.Add(pProveedor)

            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterFactura.Value.ToString() <> "" Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function Update(ByVal Factura As String, ByVal Fecha As String,
                                ByVal FechaPago As String, ByVal Proveedor As String,
                                ByVal Saldo As String, ByVal FormaPago As String,
                                ByVal Tipo As String, ByVal Esquema As String,
                                ByVal Id As String, ByVal OrdenCompra As String,
                                ByVal Origen As String, ByVal IDTemporal As String,
                                ByVal Observaciones As String, ByVal Estado As String,
                                ByVal ProveedorAnterior As String,
                                ByVal IRpagado As Boolean, ByVal IVAasumido As Boolean, ByVal IRServ As Boolean,
                                ByVal IRProd As Boolean, ByVal IRPagadoAlcaldia As Boolean,
                                ByVal SubTotalIR As Double,
                                ByVal TCambio As Double, _
                                ByVal Paralelo As Boolean, _
                                ByVal Moneda As String, ByVal NoOrdenP As String, _
                                ByVal IRPorcentaje As Double, ByVal Bodega As String) As Boolean

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            'Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Esquema As SqlParameter = New SqlParameter("@Esquema", SqlDbType.Int, 4)
            Dim _Id As SqlParameter = New SqlParameter("@ID", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim _ProveedorAnterior As SqlParameter = New SqlParameter("@ProveedorAnterior", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Esquema.Value = Esquema
            _Id.Value = Id
            _OrdenCompra.Value = OrdenCompra
            _Origen.Value = Origen
            _Temporal.Value = IDTemporal
            _Observaciones.Value = Observaciones
            _Empresa.Value = EmpresaActual
            _Estado.Value = Estado
            ' _ProveedorAnterior.Value = ProveedorAnterior

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Esquema)
            cmd.Parameters.Add(_Id)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Estado)
            ' cmd.Parameters.Add(_ProveedorAnterior)


            cmd.Parameters.AddWithValue("@IRPagado", IRpagado)
            cmd.Parameters.AddWithValue("@IVAasumido", IVAasumido)
            cmd.Parameters.AddWithValue("@IRServ", IRServ)
            cmd.Parameters.AddWithValue("@IRProd", IRProd)
            cmd.Parameters.AddWithValue("@IRPagadoAlcaldia", IRPagadoAlcaldia)
            cmd.Parameters.AddWithValue("@Moneda", Moneda)
            cmd.Parameters.AddWithValue("@NoOrdenP", NoOrdenP)
            cmd.Parameters.AddWithValue("@ir", IRPorcentaje)
            cmd.Parameters.AddWithValue("@SubTotalIR", SubTotalIR)
            cmd.Parameters.AddWithValue("@TCambio", TCambio)
            cmd.Parameters.AddWithValue("@Paralelo", Paralelo)
            cmd.Parameters.AddWithValue("@Bodega", Bodega)


            Try
                cmd.Connection = DBConnFacturas
                cmd.Transaction = transaccionFacturas
                cmd.ExecuteNonQuery()

                Return True
            Catch ex As Exception
                XtraMsg("ERROR: SP _FacturasComprasUpdate" & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try


        End Function

        'Public Function AddItem(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, ByVal Esquema As Integer, ByVal Id As String, ByVal OrdenCompra As String, ByVal Origen As Integer, ByVal IDTemporal As String, ByVal Observaciones As String, ByVal Estado As String, ByVal IRpagado As Boolean, ByVal Nada As Integer)

        '    Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasAdd", DBConnFacturas)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
        '    Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
        '    Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
        '    'Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
        '    'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
        '    Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
        '    Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
        '    Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
        '    Dim _Esquema As SqlParameter = New SqlParameter("@Esquema", SqlDbType.Int, 4)
        '    Dim _Id As SqlParameter = New SqlParameter("@ID", SqlDbType.NVarChar)
        '    Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
        '    Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
        '    Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
        '    Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
        '    Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)

        '    Dim _IRPagado As SqlParameter = New SqlParameter("@IRPagado", SqlDbType.Bit)

        '    _Factura.Value = Factura
        '    _Fecha.Value = Fecha
        '    _FechaPago.Value = FechaPago
        '    _Proveedor.Value = Proveedor
        '    '_SubTotal.Value = SubTotal
        '    '_Iva.Value = Iva
        '    _Saldo.Value = Saldo
        '    _FormaPago.Value = FormaPago
        '    _Tipo.Value = Tipo
        '    _Esquema.Value = Esquema
        '    _Id.Value = Id
        '    _OrdenCompra.Value = OrdenCompra
        '    _Origen.Value = Origen
        '    _Temporal.Value = IDTemporal
        '    _Observaciones.Value = Observaciones
        '    _Empresa.Value = EmpresaActual
        '    _Estado.Value = Estado
        '    _IRPagado.Value = IRPagado

        '    cmd.Parameters.Add(_Factura)
        '    cmd.Parameters.Add(_Fecha)
        '    cmd.Parameters.Add(_FechaPago)
        '    cmd.Parameters.Add(_Proveedor)
        '    'cmd.Parameters.Add(_SubTotal)
        '    'cmd.Parameters.Add(_Iva)
        '    cmd.Parameters.Add(_Saldo)
        '    cmd.Parameters.Add(_FormaPago)
        '    cmd.Parameters.Add(_Tipo)
        '    cmd.Parameters.Add(_Esquema)
        '    cmd.Parameters.Add(_Id)
        '    cmd.Parameters.Add(_OrdenCompra)
        '    cmd.Parameters.Add(_Origen)
        '    cmd.Parameters.Add(_Temporal)
        '    cmd.Parameters.Add(_Observaciones)
        '    cmd.Parameters.Add(_Empresa)
        '    cmd.Parameters.Add(_Estado)
        '    cmd.Parameters.Add(_IRPagado)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()

        'End Function

        'Public Sub ActualizarSubTotalIR(ByVal Factura As String, ByVal Proveedor As Integer, ByVal Monto As Double)
        '    GuardaDatosTrans("UPDATE Facturas_Compras SET SubTotalIR = " & Monto & " WHERE Factura_ID = '" & Factura & "'" _
        '                + " AND Proveedor_ID = " & Proveedor & " AND Empresa_ID = " & EmpresaActual)
        'End Sub

        Public Function AddItem(ByVal Factura As String, ByVal Fecha As String,
                                ByVal FechaPago As String, ByVal Proveedor As String, ByVal Saldo As String,
                                ByVal FormaPago As String, ByVal Tipo As String, ByVal Esquema As Integer,
                                ByVal Id As String, ByVal OrdenCompra As String, ByVal Origen As Integer,
                                ByVal IDTemporal As String, ByVal Observaciones As String, ByVal Estado As String,
                                ByVal IRpagado As Boolean, ByVal IVAasumido As Boolean, ByVal IRServ As Boolean,
                                ByVal IRProd As Boolean, ByVal IRPagadoAlcaldia As Boolean,
                                ByVal Empleado As Integer, ByVal Cliente As Integer, ByVal TCambio As Double,
                                ByVal Paralelo As Boolean,
                                ByVal Moneda As String, ByVal NoOrdenP As String,
                                ByVal IRPorcentaje As Double, ByVal Bodega As String,
                                ByVal SubTotalIR As Double, ALiquidar As Integer) As Integer

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _NoOrdenP As SqlParameter = New SqlParameter("@NoOrdenP", SqlDbType.NVarChar, 20)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            'Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Esquema As SqlParameter = New SqlParameter("@Esquema", SqlDbType.Int, 4)
            Dim _Id As SqlParameter = New SqlParameter("@ID", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _IRPagado As SqlParameter = New SqlParameter("@IRPagado", SqlDbType.Bit)
            Dim _IVAasumido As SqlParameter = New SqlParameter("@IVAasumido", SqlDbType.Bit)
            Dim _IRServ As SqlParameter = New SqlParameter("@IRServ", SqlDbType.Bit)
            Dim _IRProd As SqlParameter = New SqlParameter("@IRPRod", SqlDbType.Bit)
            Dim _IRPagadoAlcaldia As SqlParameter = New SqlParameter("@IRPagadoAlcaldia", SqlDbType.Bit)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim _Empleado As SqlParameter = New SqlParameter("@Empleado", SqlDbType.Bit)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Bit)
            Dim _ir As SqlParameter = New SqlParameter("@ir", SqlDbType.Float)
            Dim _TCambio As SqlParameter = New SqlParameter("@TCambio", SqlDbType.Float)
            Dim _Paralelo As SqlParameter = New SqlParameter("@Parelolo", SqlDbType.Bit)
            Dim _FacturaID As SqlParameter = New SqlParameter("@FacturaID", SqlDbType.Int)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar)

            _NoOrdenP.Value = NoOrdenP
            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            '_SubTotal.Value = SubTotal
            '_Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Esquema.Value = Esquema
            _Id.Value = Id
            _OrdenCompra.Value = OrdenCompra
            _Origen.Value = Origen
            _Temporal.Value = IDTemporal
            _Observaciones.Value = Observaciones
            _Empresa.Value = EmpresaActual
            _Estado.Value = Estado
            _IRPagado.Value = IRpagado
            _IVAasumido.Value = IVAasumido
            _IRServ.Value = IRServ
            _IRProd.Value = IRProd
            _IRPagadoAlcaldia.Value = IRPagadoAlcaldia
            _Moneda.Value = Moneda
            _Empleado.Value = Empleado
            _Cliente.Value = Cliente
            _ir.Value = IRPorcentaje
            _TCambio.Value = TCambio
            _Paralelo.Value = Paralelo
            _FacturaID.Direction = ParameterDirection.Output
            _Bodega.Value = Bodega

            cmd.Parameters.Add(_NoOrdenP)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            'cmd.Parameters.Add(_SubTotal)
            'cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Esquema)
            cmd.Parameters.Add(_Id)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_IRPagado)
            cmd.Parameters.Add(_IVAasumido)
            cmd.Parameters.Add(_IRServ)
            cmd.Parameters.Add(_IRProd)
            cmd.Parameters.Add(_IRPagadoAlcaldia)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_Empleado)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_ir)
            cmd.Parameters.Add(_TCambio)
            cmd.Parameters.Add(_Paralelo)
            cmd.Parameters.Add(_FacturaID)
            cmd.Parameters.Add(_Bodega)

            cmd.Parameters.AddWithValue("@SubTotalIR", SubTotalIR)
            cmd.Parameters.AddWithValue("@Aliquidar", ALiquidar)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _FacturaID.Value
        End Function

        Public Function AddItem(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, _
                ByVal Proveedor As String, ByVal Saldo As String, ByVal FormaPago As String, _
                ByVal Tipo As String, ByVal Basico_ID As Integer, ByVal Consecutivo_ID As Integer, _
                ByVal Id As String, ByVal OrdenCompra As String, ByVal Origen As String, _
                ByVal IDTemporal As String, ByVal Observaciones As String, ByVal Estado As String)

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasSBAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            'Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Basico_ID As SqlParameter = New SqlParameter("@Basico_ID", SqlDbType.Int, 4)
            Dim _Consecutivo_ID As SqlParameter = New SqlParameter("@Consecutivo_ID", SqlDbType.Int, 4)
            Dim _Id As SqlParameter = New SqlParameter("@ID", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            '_SubTotal.Value = SubTotal
            '_Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Basico_ID.Value = Basico_ID
            _Consecutivo_ID.Value = Consecutivo_ID
            _Id.Value = Id
            _OrdenCompra.Value = OrdenCompra
            _Origen.Value = Origen
            _Temporal.Value = IDTemporal
            _Observaciones.Value = Observaciones
            _Empresa.Value = EmpresaActual
            _Estado.Value = Estado

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            'cmd.Parameters.Add(_SubTotal)
            'cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Basico_ID)
            cmd.Parameters.Add(_Consecutivo_ID)
            cmd.Parameters.Add(_Id)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Estado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddFacturaLineas(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String,
                                         ByVal Costo As String, ByVal Descuento As String, ByVal Iva As String,
                                         ByVal Tipo As String, ByVal CantidadAlmacen As String, ByVal IvaAlmacen As String,
                                         ByVal IvaPorcentaje As String, ByVal Proveedor As String,
                                         Optional ByVal Comentarios As String = "", Optional ByVal Cuenta As String = "",
                                         Optional ByVal Empleado As String = "", Optional ByVal Cliente As Integer = 0,
                                         Optional ByVal IRPorcentaje As Double = 0, Optional IdProyecto As Integer = 0,
                                         Optional IdOrdenCompra As Integer = 0,
                                         Optional TipoImpuesto As Integer = 0,
                                         Optional IdDetalle As Integer = 0) As Integer

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasLineasAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _CantidadAlmacen As SqlParameter = New SqlParameter("@CantidadAlmacen", SqlDbType.Float, 8)
            Dim _IvaAlmacen As SqlParameter = New SqlParameter("@IvaAlmacen", SqlDbType.Float, 8)
            Dim _IvaPorcentaje As SqlParameter = New SqlParameter("@IvaPorcentaje", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _Coment As SqlParameter = New SqlParameter("@Comentarios", SqlDbType.NVarChar)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empleado As SqlParameter = New SqlParameter("@Emp_Codigo", SqlDbType.NVarChar)
            Dim _Cliente As SqlParameter = New SqlParameter("@ClieteID", SqlDbType.Int)
            Dim _ir As SqlParameter = New SqlParameter("@ir", SqlDbType.Float)
            Dim _LineaID As SqlParameter = New SqlParameter("@LineaID", SqlDbType.Int, 6)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Tipo.Value = Tipo
            _CantidadAlmacen.Value = CantidadAlmacen
            _IvaAlmacen.Value = IvaAlmacen
            _IvaPorcentaje.Value = IvaPorcentaje
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor
            _Coment.Value = Comentarios
            _Cuenta.Value = Cuenta
            _Empleado.Value = Empleado
            _Cliente.Value = Cliente
            _ir.Value = IRPorcentaje
            _LineaID.Direction = ParameterDirection.Output

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_CantidadAlmacen)
            cmd.Parameters.Add(_IvaAlmacen)
            cmd.Parameters.Add(_IvaPorcentaje)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Coment)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Empleado)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_ir)
            cmd.Parameters.Add(_LineaID)

            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@IdOrdenCompra", IdOrdenCompra)
            cmd.Parameters.AddWithValue("@TipoImpuesto", TipoImpuesto)
            cmd.Parameters.AddWithValue("@IdDetalle", IdDetalle)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _LineaID.Value
        End Function

        Public Sub OrdenesComprasLineaUpdateEntregado(IdDetalle As String, Cantidad As Double)

            Dim cmd As SqlCommand = New SqlCommand("sp_upd_ORDENES_COMPRA_LINEA", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure
            '
            cmd.Parameters.AddWithValue("@IdDetalle", IdDetalle)
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)
            '
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Function OrdenesComprasUpdateEstado(ByVal Numero As String, ByVal Estado As String, Factura As String)
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function OrdenesComprasCCUpdateEstado(ByVal Numero As String, ByVal Estado As String)
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasCCUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            '_Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            'cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

    End Class

End Namespace

