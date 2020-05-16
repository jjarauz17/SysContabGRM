Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DevolucionesClienteBodegaDB

        Public Function Numero() As String
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteBodegaNumero", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim pNumero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            pNumero.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pNumero)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            If pNumero.Value.ToString() <> "" Then
                Return CType(pNumero.Value, String)
            Else
                Return 1
            End If

        End Function

        Public Function AddItem(ByVal DevolucionBodega As String, ByVal Devolucion As String)
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteBodegaAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _DevolucionBodega As SqlParameter = New SqlParameter("@DevolucionBodega", SqlDbType.NVarChar)
            Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _DevolucionBodega.Value = DevolucionBodega
            _Devolucion.Value = Devolucion
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_DevolucionBodega)
            cmd.Parameters.Add(_Devolucion)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddItemDetalle(ByVal DevolucionBodega As String, ByVal Item As String, ByVal Cantidad As String)
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteBodegaDetalleAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _DevolucionBodega As SqlParameter = New SqlParameter("@DevolucionBodega", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _DevolucionBodega.Value = DevolucionBodega
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_DevolucionBodega)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function UpdateItem(ByVal Factura As String, ByVal Item As String, ByVal Tipo As String, ByVal Devuelto As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionUpdateItem", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Devuelto As SqlParameter = New SqlParameter("@Devuelto", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Devuelto.Value = Devuelto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Devuelto)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function GetList(ByVal Factura As String, ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesClienteList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Decimal)

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


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DevolucionesCliente")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DevolucionDetalle(ByVal Devolucion As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionClienteDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDevolucion.Value = Devolucion
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDevolucion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DevolucionDetalleNew(ByVal Devolucion As String, ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionClienteBodegaDetalleNew", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDevolucion.Value = Devolucion
            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDevolucion)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DevolucionBodegaDetalle(ByVal Devolucion As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionClienteBodegaDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDevolucion.Value = Devolucion
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDevolucion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
