Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class TipoDeduccionDetails
        Public Empresa As String
        Public Codigo As String
        Public Descripcion As String
    End Class

    Public Class TipoDeduccionDB

        Public Function GetList(ByVal Filtro As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pFiltro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            DBCommand.Fill(dsFicha, "TipoDeduccion")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New TipoDeduccionDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccionDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsHorario, "TipoDeduccion")

            If dsHorario.Tables("TipoDeduccion").Rows.Count = 1 Then

                Details.Empresa = dsHorario.Tables("TipoDeduccion").Rows(0).Item("empr_codigo")
                Details.Codigo = dsHorario.Tables("TipoDeduccion").Rows(0).Item("tde_codigo")
                Details.Descripcion = dsHorario.Tables("TipoDeduccion").Rows(0).Item("tde_descripcion")

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "TipoDeduccion")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet

            'Revisar los datos de busqueda y donde se utilizan.
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccionBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Tipodeduccion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccionCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoDeduccion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoDeduccionCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Tipodeduccion")

            DBConn.Close()

            If dsFicha.Tables("TipoDeduccion").Rows(0).Item("CODIGO") Is DBNull.Value Then
                Return "1"
            Else
                Return Trim(Str(Val(dsFicha.Tables("TipoDeduccion").Rows(0).Item("CODIGO")) + 1))
            End If


        End Function


        Public Function Delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoDeduccionDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Descripcion As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoDeduccionAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Descripcion

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function UpdateCuenta(ByVal Codigo As String, ByVal Cta As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("[_TipoDeduccionUpdateCuenta]", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@CtaContable", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Cta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

    End Class

End Namespace
