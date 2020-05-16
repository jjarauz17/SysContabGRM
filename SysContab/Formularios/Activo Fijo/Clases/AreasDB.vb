Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class AreaDetails
        Public Departamento As String
        Public Codigo As String
        Public Descripcion As String
    End Class

    Public Class AreaDB

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListareasBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Departamento As String, ByVal Area As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet()
            Dim Details As New AreaDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListAreaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)

            pIdent.Value = Departamento
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            DBCommand.Fill(ds, "Areas")

            If ds.Tables("Areas").Rows.Count = 1 Then
                Details.Departamento = ds.Tables("Areas").Rows(0).Item("dep_codigo").ToString
                Details.Codigo = ds.Tables("Areas").Rows(0).Item("are_codigo").ToString
                Details.Descripcion = ds.Tables("Areas").Rows(0).Item("are_descripcion").ToString

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListArea", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListDepto(ByVal Departamento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListAreaDepto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo(ByVal Departamento As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListAreaNvoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha.Tables("Areas").Rows(0)("Codigo")

        End Function

        Public Sub Delete(ByVal Departamento As String, ByVal Area As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_Area_Delete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)

            pIdent.Value = Departamento
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Area
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
        End Sub

        Public Sub AddItem(ByVal Departamento As String, ByVal Area As String, ByVal Descripcion As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Area_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = Area
            pIdent4.Value = Descripcion

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Update(ByVal Departamento As String, ByVal Area As String, ByVal Descripcion As String)

            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Area_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = Area
            pIdent4.Value = Descripcion

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class
End Namespace