Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab
    Public Class AuditoriaDB

        Public Function UsuariosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AuditoriaUsuariosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.Fill(dsFicha, "Auditoria")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function AuditoriaList(ByVal Usuario As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Evento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AuditoriaList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Evento As New SqlParameter("@Evento", SqlDbType.VarChar)

            _Empresa.Value = EmpresaActual
            _Usuario.Value = Usuario
            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Evento.Value = Evento

            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Usuario)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Evento)

            'Try
            DBCommand.Fill(dsFicha, "Auditoria")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            DBConn.Close()
            Return dsFicha

        End Function

        Public Sub AuditoriaSelEmpresa(ByVal Modulo As String, ByVal Tipo As Integer)
            Dim r As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()

            Dim cmd As SqlCommand = New SqlCommand("_AuditoriaEmpresa", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.NVarChar)
            pModulo.Value = Modulo
            cmd.Parameters.Add(pModulo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            pTipo.Value = Tipo
            cmd.Parameters.Add(pTipo)

            Dim p1 As New SqlParameter("@EmpresaNombre", SqlDbType.NVarChar)
            p1.Value = ""
            cmd.Parameters.Add(p1)

            Dim p2 As New SqlParameter("@Selection", SqlDbType.NVarChar)
            p2.Value = ""
            cmd.Parameters.Add(p2)

            cmd.Connection = DBConnFacturas
            cmd.ExecuteNonQuery()
            DBConnFacturas.Close()
            DBConnFacturas.Dispose()
        End Sub
    End Class
End Namespace
