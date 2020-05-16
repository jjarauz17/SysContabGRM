Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration



Namespace VB.SysContab

Public Class TipoRubroDB


        Public Function Update(ByVal Codigo As String, ByVal Cuenta As String, ByVal CuentaCred As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoRubroUpdateCuenta", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@CtaContable", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CtaContableCred", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent7.Value = Cuenta
            pIdent8.Value = CuentaCred

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoRubroCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoRubro")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoRubro", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha

        End Function



End Class


End Namespace