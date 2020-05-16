Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class VariablesDB

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VariablesGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Variables")

            DBConn.Close()

            Return dsFicha

        End Function


    End Class


End Namespace