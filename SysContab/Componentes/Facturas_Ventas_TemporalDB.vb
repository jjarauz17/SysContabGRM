Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class FacturasTemporalDetails
        Public Numero As String
        Public Factura As String
        Public Fecha As String
        Public CodigoCliente As String
        Public Ruc As String

        Public Monto As String
        Public SubTotal As String
        Public DescuentoP As String
        Public DescuentoC As String
        Public IvaP As String
        Public IvaC As String
        Public RecargoP As String
        Public RecargoC As String
        Public OtrosP As String
        Public OtrosC As String
        Public Total As String

        Public Saldo As String
        Public FormaPago As String
        Public Vendedor As String
        Public ComisionP As String
        Public ComisionC As String
        Public FechaCancelar As String
        Public FechaVencimiento As String
        Public Tipo As String

    End Class

    Public Class Facturas_Ventas_TemporalDB

        Public Function Numero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_FacturaTemporalNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


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


        Public Function FacturaDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaTemporalDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaDelete(ByVal Factura As String)
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturaDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function FacturaNumero() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaNumero", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasPrint(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasPrint", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            'Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pFactura.Value = Factura
            'pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            'DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddFacturaLineasTemporal(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String, _
                                         ByVal Precio As String, ByVal Descuento As String, ByVal Total As String, _
                                         ByVal Comision As String, ByVal Tipo As String)


            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasLineasTemporalAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Precio As SqlParameter = New SqlParameter("@Precio", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Comision As SqlParameter = New SqlParameter("@Comision", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Precio.Value = Precio
            _Descuento.Value = Descuento
            _Total.Value = Total
            _Comision.Value = Comision
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Precio)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Comision)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            'fdsfsfd()

            ' Open the connection and execute the Command

            'MsgBox(DBConnFacturasLineas.ConnectionTimeout)
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ''''DBConn.Open()
            ''''cmd.ExecuteNonQuery()
            ''''DBConn.Close()

        End Function

        Public Function ListFacturasXFactura(ByVal Factura As String, ByVal Cliente As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasXFactura", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pFactura.Value = Factura
            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListFacturasXCliente(ByVal Cliente As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasXCliente", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListFacturas(ByVal Filtro As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasTemporalList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Ventas_Temporal")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddFacturaTemporal(ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String, _
                                   ByVal Ruc As String, ByVal Monto As String, ByVal SubTotal As String, _
                                   ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String, _
                                   ByVal Otros As String, ByVal Total As String, ByVal Saldo As String, _
                                   ByVal Vendedor As String, ByVal Fecha_Pago As String, _
                                   ByVal Fecha_Vencimiento As String, ByVal Tipo As String, _
                                   ByVal Tipo_Factura As String, ByVal PvCodigo As String, ByVal NombreCliente As String)


            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasTemporalAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _FechaPago As SqlParameter = New SqlParameter("@Fecha_Pago", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Tipo_Factura As SqlParameter = New SqlParameter("@Tipo_Factura", SqlDbType.Int, 4)
            Dim _PvCodigo As SqlParameter = New SqlParameter("@PvCodigo", SqlDbType.Int, 4)
            Dim _NombreCliente As SqlParameter = New SqlParameter("@NombreCliente", SqlDbType.NVarChar, 100)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _Saldo.Value = Saldo
            _Vendedor.Value = Vendedor
            _FechaPago.Value = Fecha_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Tipo_Factura.Value = Tipo_Factura
            _PvCodigo.Value = PvCodigo
            _NombreCliente.Value = NombreCliente
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Tipo_Factura)
            cmd.Parameters.Add(_PvCodigo)
            cmd.Parameters.Add(_NombreCliente)
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

        Public Function UpdateEstado(ByVal Factura As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturaUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

    End Class

End Namespace
