Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab
    Public Class DepartamentosCDB

        Public Function DepartamentosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepartamentosCList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "DepartamentosC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function List() As DataTable
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT '0' AS Codigo, NULL AS Nombre UNION SELECT Codigo_Departamento AS Codigo, Nombre_Departamento AS Nombre FROM DepartamentosC ", DBConn)
            'DBCommand.Fill(dsFicha, "DepartamentosC")

            'DBConn.Close()

            'Return dsFicha


            Return ObtieneDatos("JAR_DepartamentosList", EmpresaActual)

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT 0 AS Codigo, '--Todos--' AS Nombre UNION SELECT Codigo_Departamento AS Codigo, Nombre_Departamento AS Nombre FROM DepartamentosC WHERE Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "DepartamentosC")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace

