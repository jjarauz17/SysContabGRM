Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect
Namespace VB.SysContab

    Public Class Grupos_DepreciacionDetails
        Public Codigo As String
        Public Descripcion As String
        Public Vida_Util As String
        Public Porcentaje As String
        Public Porcentaje_Revaloracion As String
        Public Activo As String
        Public Depreciacion As String
        Public Gastos As String
        Public Periodo As String 
    End Class

    Public Class Grupos_DepreciacionDB

        Public Shared Function GetDetails(ByVal Codigo As String) As Grupos_DepreciacionDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsGrupos_Depreciacion As New DataSet()
            Dim Details As New Grupos_DepreciacionDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Grupos_Depreciacion WHERE CODIGO_GRUPO_DEPRECIACION = " & Codigo & " AND Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsGrupos_Depreciacion, "Grupos_Depreciacion")

            If dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows.Count = 1 Then
                Details.Codigo = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Codigo_Grupo_Depreciacion")
                Details.Descripcion = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Descripcion")
                Details.Vida_Util = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Vida_Util")
                Details.Porcentaje = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Porcentaje_Depreciacion")
                Details.Porcentaje_Revaloracion = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Porcentaje_Revaloracion")
                Details.Activo = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Activo")
                Details.Depreciacion = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Depreciacion")
                Details.Gastos = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Gasto")
                Details.Periodo = dsGrupos_Depreciacion.Tables("Grupos_Depreciacion").Rows(0).Item("Periodo")
            End If

            Return Details

        End Function

        Public Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DA As SqlDataAdapter
            Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As New SqlCommand()

            cmd.CommandText = "sp_sel_Grupos_Depreciacion"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)
            cmd.Connection = DBConn
            cmd.CommandTimeout = 0

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Grupo_Depreciacion AS [CODIGO], DESCRIPCION, VIDA_UTIL, PORCENTAJE_DEPRECIACION FROM Grupos_Depreciacion WHERE Empresa ='" & EmpresaActual & "'", DBConn)
            DA = New SqlDataAdapter(cmd)
            DA.Fill(dsFicha, "Grupos_Depreciacion")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Grupos_Depreciacion ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Depreciacion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT SELECT Codigo_Grupo_Depreciacion AS [CODIGO ], DESCRIPCION, VIDA_UTIL, PORCENTAJE_DEPRECIACION FROM Grupos_Depreciacion WHERE DESCRIPCION Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Depreciacion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_GRUPO_DEPRECIACION as CODIGO, DESCRIPCION as NOMBRE FROM Grupos_Depreciacion WHERE DESCRIPCION Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY DESCRIPCION", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Depreciacion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_GRUPO_DEPRECIACION, DESCRIPCION FROM Grupos_Depreciacion WHERE Nombre = '" & Filtro & "' AND Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Depreciacion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetCodigo() As String

            Return ObtieneDatos("sp_GetCodigoGrupoDepreciacion", EmpresaActual).Rows.Item(0)("Codigo").ToString()

        End Function

        Public Shared Sub AddItem(ByVal Codigo As String, _
            ByVal Descripcion As String, _
            ByVal Vida_Util As String, _
            ByVal Porcentaje_Depreciacion As String, _
            ByVal Periodo As String, _
            ByVal Activo As String, ByVal Depreciacion As String, _
            ByVal Gastos As String)

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            v.AddParameter("VidaUtil", SqlDbType.Float, 10, ParameterDirection.Input, Vida_Util)
            v.AddParameter("PorcDepreciacion", SqlDbType.Float, 10, ParameterDirection.Input, Porcentaje_Depreciacion)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Periodo)
            v.AddParameter("Activo", SqlDbType.NVarChar, 64, ParameterDirection.Input, Activo)
            v.AddParameter("Depreciacion", SqlDbType.NVarChar, 64, ParameterDirection.Input, Depreciacion)
            v.AddParameter("Gastos", SqlDbType.NVarChar, 64, ParameterDirection.Input, Gastos)
            'v.AddParameter("Periodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Periodo)
            Try
                v.EjecutarComando("_AF_GrupoDepreciacionAdd")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal Descripcion As String, _
                                ByVal Vida_Util As String, ByVal Porcentaje_Depreciacion As String, _
                                ByVal Periodo As String, _
                                ByVal Activo As String, ByVal Depreciacion As String, _
                                ByVal Gastos As String)

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            v.AddParameter("VidaUtil", SqlDbType.Float, 10, ParameterDirection.Input, Vida_Util)
            v.AddParameter("PorcDepreciacion", SqlDbType.Float, 10, ParameterDirection.Input, Porcentaje_Depreciacion)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Periodo)
            v.AddParameter("Activo", SqlDbType.NVarChar, 64, ParameterDirection.Input, Activo)
            v.AddParameter("Depreciacion", SqlDbType.NVarChar, 64, ParameterDirection.Input, Depreciacion)
            v.AddParameter("Gastos", SqlDbType.NVarChar, 64, ParameterDirection.Input, Gastos)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
            Try
                v.EjecutarComando("_AF_GrupoDepreciacionUpdate")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Grupos_Depreciacion WHERE Codigo_Depreciacion = '" & Codigo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Sub

    End Class

End Namespace