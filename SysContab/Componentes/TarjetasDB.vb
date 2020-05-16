Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class TarjetasDetails
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

    Public Class TarjetasDB

        Public Function GetList2(ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TarjetasList2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tarjetas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddItem(ByVal Nombre As String)

            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_TarjetasAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Nombre.Value = Nombre
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Sub

        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TarjetasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tarjetas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TarjetasGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tarjetas")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
