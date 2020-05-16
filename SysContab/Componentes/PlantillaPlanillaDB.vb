Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Namespace VB.SysContab
    Public Class PlantillaPlanillaDB


        Public Shared Sub Add(ByVal Departamento As String, _
            ByVal mov_codigo As String, ByVal mov_tipo As String, _
            ByVal DC As String, ByVal Cuenta As String)

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaPlanilla_Departamento_Add", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@mov_codigo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@mov_tipo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@DC", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = mov_codigo
            pIdent4.Value = mov_tipo
            pIdent5.Value = DC
            pIdent6.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)



            'Se asigna conexion al comando y se abre conexion 
            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.SelectCommand.ExecuteNonQuery()


        End Sub

        Public Shared Sub Update(ByVal Departamento As String, _
            ByVal mov_codigo As String, ByVal mov_tipo As String, _
            ByVal DC As String, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaPlanilla_Departamento_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@mov_codigo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@mov_tipo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@DC", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = mov_codigo
            pIdent4.Value = mov_tipo
            pIdent5.Value = DC
            pIdent6.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


        End Sub

        Public Shared Sub Delete(ByVal Departamento As String, _
            ByVal mov_codigo As String, ByVal mov_tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaPlanilla_Departamento_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@mov_codigo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@mov_tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = mov_codigo
            pIdent4.Value = mov_tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
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

        Public Shared Function GetList(ByVal Departamento As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaPlanilla_GetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.Fill(ds, "PlantillaPlanilla_Departamento")
                DBConn.Close()
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function Buscar(ByVal Departamento As String, ByVal mov_codigo As String, _
            ByVal mov_tipo As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaPlanilla_Departamento_Buscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@mov_codigo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@mov_tipo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Existe", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = mov_codigo
            pIdent4.Value = mov_tipo
            pIdent5.Direction = ParameterDirection.Output


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                If pIdent5.Value = True Then
                    Return 1
                Else
                    Return 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try


        End Function
    End Class
End Namespace

