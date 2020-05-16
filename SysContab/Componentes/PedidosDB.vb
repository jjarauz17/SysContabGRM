Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Namespace VB.SysContab
    Public Class PedidosDB

        Public Sub ImprimirOrden(ByVal Pedido As Long)
            'If MsgBox("¿Desea imprimir la Cotización?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then            
            'Dim rPedido As New rptProveedoresPedido()

            Dim rPedido As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rPedido.Load(Application.StartupPath & "\Reportes\rptProveedoresPedido.rpt", OpenReportMethod.OpenReportByDefault)

            Dim tblLogOnInfo As New TableLogOnInfo()
            Dim tblName As Table

            For Each tblName In rPedido.Database.Tables
                tblLogOnInfo = tblName.LogOnInfo
                'set connection parameters
                tblLogOnInfo.ConnectionInfo.DatabaseName = DBName
                tblLogOnInfo.ConnectionInfo.ServerName = Server
                tblLogOnInfo.ConnectionInfo.UserID = Usuario
                tblLogOnInfo.ConnectionInfo.Password = UPassword

                'apply the connection information to the table
                Try
                    tblName.ApplyLogOnInfo(tblLogOnInfo)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            Next

            rPedido.SetParameterValue("@Empresa", EmpresaActual)
            rPedido.SetParameterValue("@Pedido", Pedido)
            '
            Dim f As New frmReportes
            f.crvReportes.ReportSource = rPedido
            f.Show()
            'End If
        End Sub

        Public Function PedidoCCNumero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_PedidoCCNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim parameterPedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal)
            parameterPedido.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterPedido)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterPedido.Value.ToString() <> "" Then
                Return CType(parameterPedido.Value, Long)
            Else
                Return 1
            End If

        End Function

        Public Function PedidosCCAdd(ByVal Pedido As String, ByVal Fecha As String, ByVal FechaEntrega As String, ByVal Proveedor As String)

            Dim cmd As SqlCommand = New SqlCommand("_PedidosCCAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _FechaEntrega As SqlParameter = New SqlParameter("@FechaEntrega", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Decimal, 10)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Pedido.Value = Pedido
            _Fecha.Value = Fecha
            _FechaEntrega.Value = FechaEntrega
            _Proveedor.Value = Proveedor
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaEntrega)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function PedidosCCLineasAdd(ByVal Pedido As String, ByVal Item As String, ByVal Cantidad As String, _
                                                ByVal Costo As String)


            Dim cmd As SqlCommand = New SqlCommand("_PedidosCCLineasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Pedido.Value = Pedido
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function SugerirPedido(ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_StockBajoMinimo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function PedidosListXFecha(ByVal Proveedor As String, ByVal Estado As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PedidosListXFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            Dim EstadoLocal As String

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If


            pProveedor.Value = IIf(IsNumeric(Proveedor), Proveedor, 0)
            pEstado.Value = EstadoLocal
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Pedidos")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Update(ByVal Pedido As String, ByVal Fecha As String, ByVal FechaEntrega As String, _
                               ByVal Proveedor As String, ByVal Tipo As String, _
                                ByVal FormaPago As Integer, ByVal Usuario As Integer, ByVal Centro As Integer, _
                                ByVal Termino As String, ByVal Observaciones As String, ByVal Seguimiento As String, _
                                ByVal Consignatario As Integer, ByVal MetodoEnvio As Integer, ByVal Agencia As Integer, _
                                ByVal NoPedidoAlterno As String)

            Dim cmd As SqlCommand = New SqlCommand("_PedidosUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _FechaEntrega As SqlParameter = New SqlParameter("@FechaEntrega", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Decimal, 10)
            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Usuario As SqlParameter = New SqlParameter("@Usuario", SqlDbType.Int, 4)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int, 4)
            Dim _Terminos As SqlParameter = New SqlParameter("@Terminos", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Seguimiento As SqlParameter = New SqlParameter("@Seguimiento", SqlDbType.NVarChar)
            Dim _Consignatario As SqlParameter = New SqlParameter("@Consignatario", SqlDbType.Int, 4)
            Dim _Metodo_Envio As SqlParameter = New SqlParameter("@Metodo_Envio", SqlDbType.Int, 4)
            Dim _Agencia As SqlParameter = New SqlParameter("@Agencia", SqlDbType.Int, 4)
            Dim _NoPedidoAlterno As SqlParameter = New SqlParameter("@NoPedidoAlterno", SqlDbType.NVarChar)

            _Pedido.Value = Pedido
            _Fecha.Value = Fecha
            _FechaEntrega.Value = FechaEntrega
            _Proveedor.Value = Proveedor
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual
            _Usuario.Value = Usuario
            _Centro.Value = Centro
            _Terminos.Value = Termino
            _Observaciones.Value = Observaciones
            _Seguimiento.Value = Seguimiento
            _Consignatario.Value = Consignatario
            _Metodo_Envio.Value = MetodoEnvio
            _Agencia.Value = Agencia
            _NoPedidoAlterno.Value = NoPedidoAlterno

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaEntrega)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Usuario)
            cmd.Parameters.Add(_Centro)

            cmd.Parameters.Add(_Terminos)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Seguimiento)
            cmd.Parameters.Add(_Consignatario)
            cmd.Parameters.Add(_Metodo_Envio)
            cmd.Parameters.Add(_Agencia)
            cmd.Parameters.Add(_NoPedidoAlterno)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddItem(ByVal Pedido As String, ByVal Fecha As String, ByVal FechaEntrega As String, _
                                ByVal Proveedor As String, ByVal Tipo As String, _
                                ByVal FormaPago As Integer, ByVal Usuario As Integer, ByVal Centro As Integer, _
                                ByVal Termino As String, ByVal Observaciones As String, ByVal Seguimiento As String, _
                                ByVal Consignatario As Integer, ByVal MetodoEnvio As Integer, ByVal Agencia As Integer, _
                                ByVal NoPedidoAlterno As String)

            Dim cmd As SqlCommand = New SqlCommand("_PedidosAdd", DBConnFacturas)
            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _FechaEntrega As SqlParameter = New SqlParameter("@FechaEntrega", SqlDbType.DateTime, 8)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Decimal, 10)
            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Usuario As SqlParameter = New SqlParameter("@Usuario", SqlDbType.Int, 4)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int, 4)
            Dim _Terminos As SqlParameter = New SqlParameter("@Terminos", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Seguimiento As SqlParameter = New SqlParameter("@Seguimiento", SqlDbType.NVarChar)
            Dim _Consignatario As SqlParameter = New SqlParameter("@Consignatario", SqlDbType.Int, 4)
            Dim _Metodo_Envio As SqlParameter = New SqlParameter("@Metodo_Envio", SqlDbType.Int, 4)
            Dim _Agencia As SqlParameter = New SqlParameter("@Agencia", SqlDbType.Int, 4)
            Dim _NoPedidoAlterno As SqlParameter = New SqlParameter("@NoPedidoAlterno", SqlDbType.NVarChar)


            _Pedido.Value = Pedido
            _Fecha.Value = Fecha
            _FechaEntrega.Value = FechaEntrega
            _Proveedor.Value = Proveedor
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual
            _Usuario.Value = Usuario
            _Centro.Value = Centro
            _Terminos.Value = Termino
            _Observaciones.Value = Observaciones
            _Seguimiento.Value = Seguimiento
            _Consignatario.Value = Consignatario
            _Metodo_Envio.Value = MetodoEnvio
            _Agencia.Value = Agencia
            _NoPedidoAlterno.Value = NoPedidoAlterno

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaEntrega)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Usuario)
            cmd.Parameters.Add(_Centro)

            cmd.Parameters.Add(_Terminos)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Seguimiento)
            cmd.Parameters.Add(_Consignatario)
            cmd.Parameters.Add(_Metodo_Envio)
            cmd.Parameters.Add(_Agencia)
            cmd.Parameters.Add(_NoPedidoAlterno)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function DeletePedidos(ByVal Pedido As String)

            Dim cmd As SqlCommand = New SqlCommand("_PedidosDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Pedido.Value = Pedido
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

        End Function

        Public Function DeletePedidosLineas(ByVal Pedido As String)


            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_PedidosLineasDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Pedido.Value = Pedido
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ''''DBConn.Open()
            ''''cmd.ExecuteNonQuery()
            ''''DBConn.Close()

        End Function

        Public Function AddPedidosLineas(ByVal Pedido As String, ByVal Item As String, ByVal Cantidad As String, _
                                         ByVal Costo As String, ByVal Tipo As String)


            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_PedidosLineasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Pedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Pedido.Value = Pedido
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Pedido)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ''''DBConn.Open()
            ''''cmd.ExecuteNonQuery()
            ''''DBConn.Close()

        End Function

        Public Function PedidosList(ByVal Proveedor As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PedidosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            Dim EstadoLocal As String

            If Estado = 0 Then
                EstadoLocal = "T"
            ElseIf Estado = 1 Then
                EstadoLocal = "P"
            ElseIf Estado = 2 Then
                EstadoLocal = "F"
            ElseIf Estado = 3 Then
                EstadoLocal = "A"
            End If


            pProveedor.Value = IIf(IsNumeric(Proveedor), Proveedor, 0)
            pEstado.Value = EstadoLocal
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)
            'Try
            DBCommand.Fill(dsFicha, "Pedidos")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try


            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Pedidos WHERE Empresa_ID = " & EmpresaActual, DBConn)
            DBCommand.Fill(dsFicha, "Pedidos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function PedidoNumero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_PedidoNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim parameterPedido As SqlParameter = New SqlParameter("@Pedido", SqlDbType.Decimal, 10)
            parameterPedido.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterPedido)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterPedido.Value.ToString() <> "" Then
                Return CType(parameterPedido.Value, Long)
            Else
                Return 1
            End If

        End Function

        Public Function PedidoDetalle(ByVal Pedido As String, ByVal Tipo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PedidoDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pPedido As New SqlParameter("@Pedido", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            pPedido.Value = Pedido
            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pPedido)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Pedidos")

            DBConn.Close()

            Return dsFicha

        End Function


    End Class

End Namespace
