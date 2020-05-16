Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class SalidaBodegaDB

        Public Function Numero() As String
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_SalidaBodegaNumero", DBConn)

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

        Public Function AddItem(ByVal Salida As String, ByVal Factura As String)
            Dim cmd As SqlCommand = New SqlCommand("_SalidaBodegaAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Salida As SqlParameter = New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Salida.Value = Salida
            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Salida)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddItemDetalle(ByVal SalidaNo As String, ByVal Item As String, ByVal Cantidad As String)
            Dim cmd As SqlCommand = New SqlCommand("_SalidaBodegaDetalleAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _SalidaNo As SqlParameter = New SqlParameter("@Salida", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _SalidaNo.Value = SalidaNo
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_SalidaNo)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Empresa)

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

            DBCommand = New SqlDataAdapter("_SalidaBodegaList", DBConn)

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

            DBCommand.Fill(dsFicha, "SalidaBodega")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function SalidaBodegaDetalle(ByVal Salida As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SalidaBodegaDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pSalida As New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pSalida.Value = Salida
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pSalida)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function


    End Class

End Namespace
