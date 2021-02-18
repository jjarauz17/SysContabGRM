Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.Web

Module DAL

    'Inherits ClComun
    'Function Excel(Archivo As String, Hoja As String, Consulta As String) As DataTable

    '    Dim Conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Archivo & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
    '    Dim da As New OleDbDataAdapter(String.Format(Consulta, "[" & Hoja & "]"), Conn)
    '    Dim dtExcel As New DataTable
    '    da.Fill(dtExcel)
    '    Return dtExcel
    'End Function

    'Public Function ObtieneDatos(ByVal StrSQL As String) As DataTable
    '    Dim DC As New SqlConnection(cl_CadenaConexion.CadenaConexion)
    '    Dim DA As New SqlDataAdapter(StrSQL, DC)
    '    Dim DT As New DataTable
    '    DA.SelectCommand.CommandTimeout = 0
    '    DA.Fill(DT)
    '    Return DT
    'End Function

    'Function Cargar(ByVal Comando As String, Optional ByVal Tran As Boolean = False) As DataTable
    '    Dim dt As New DataTable

    '    If Tran Then
    '        Try
    '            Dim da As New SqlDataAdapter(Comando, ClConexion.vconsql)
    '            da.SelectCommand.Connection = ClConexion.vconsql
    '            da.SelectCommand.Transaction = ClConexion.vtran
    '            da.SelectCommand.CommandTimeout = 0
    '            da.Fill(dt)
    '        Catch ex As Exception
    '            Try
    '                Dim da As New SqlDataAdapter("SET DATEFORMAT DMY; EXEC " & Comando, ClConexion.vconsql)
    '                da.SelectCommand.Connection = ClConexion.vconsql
    '                da.SelectCommand.Transaction = ClConexion.vtran
    '                da.SelectCommand.CommandTimeout = 0
    '                da.Fill(dt)
    '            Catch exa As Exception
    '                XtraMsg(exa.Message, MessageBoxIcon.Error)
    '            End Try

    '        End Try

    '    Else
    '        Try
    '            Dim da As New SqlDataAdapter(Comando, cl_CadenaConexion.CadenaConexion)
    '            da.SelectCommand.CommandTimeout = 0
    '            da.Fill(dt)
    '        Catch ex As Exception
    '            Try
    '                Dim da As New SqlDataAdapter("SET DATEFORMAT DMY; EXEC " & Comando, cl_CadenaConexion.CadenaConexion)
    '                da.SelectCommand.CommandTimeout = 0
    '                da.Fill(dt)
    '            Catch exa As Exception
    '                XtraMsg(exa.Message, MessageBoxIcon.Error)
    '            End Try
    '        End Try
    '    End If
    '    Return dt
    'End Function

    'Sub Guardar(ByVal Comando As String, Optional ByVal Tran As Boolean = False)


    '    If Tran = True Then
    '        Try
    '            Dim cmd As New SqlCommand(Comando)
    '            cmd.Connection = ClConexion.vconsql
    '            cmd.Transaction = ClConexion.vtran
    '            cmd.CommandTimeout = 0
    '            cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            Dim cmd As New SqlCommand("SET DATEFORMAT DMY; EXEC " & Comando)
    '            cmd.Connection = ClConexion.vconsql
    '            cmd.Transaction = ClConexion.vtran
    '            cmd.CommandTimeout = 0
    '            cmd.ExecuteNonQuery()
    '        End Try

    '    Else
    '        Try
    '            Dim cmd As New SqlCommand(Comando)
    '            Dim conn As New SqlConnection(cl_CadenaConexion.CadenaConexion)
    '            cmd.Connection = conn
    '            cmd.CommandTimeout = 0
    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '            conn.Close()
    '        Catch ex As Exception
    '            Try
    '                Dim cmd As New SqlCommand("SET DATEFORMAT DMY; EXEC " & Comando)
    '                Dim conn As New SqlConnection(cl_CadenaConexion.CadenaConexion)
    '                cmd.Connection = conn
    '                cmd.CommandTimeout = 0
    '                conn.Open()
    '                cmd.CommandTimeout = 0
    '                cmd.ExecuteNonQuery()

    '                conn.Close()
    '            Catch exa As Exception
    '                XtraMsg(ex.Message, MessageBoxIcon.Error)
    '            End Try

    '        End Try
    '    End If

    'End Sub

    Function CargarConexion(ByVal Procedimiento As String, ByVal cn As SqlConnection,
                            ByVal ParamArray Parametros() As Object) As DataTable

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn
        da.SelectCommand = cmd
        SqlCommandBuilder.DeriveParameters(cmd)

        If Not Parametros Is Nothing Then
            For i = 1 To Parametros.Length
                cmd.Parameters(i).Value = Parametros(i - 1)
            Next
        End If

        da.Fill(dt)
        da = Nothing
        cmd = Nothing
        Return dt
    End Function

    Function Cargar(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataTable

        Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cn.Open()
        cmd.Connection = cn
        da.SelectCommand = cmd
        SqlCommandBuilder.DeriveParameters(cmd)

        Try
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If
        Catch ex As Exception

        End Try


        Try
            da.Fill(dt)

        Catch ex As Exception

            XtraMsg(ex.Message, MessageBoxIcon.Error)

        End Try
        da = Nothing
        cmd = Nothing
        cn.Close()

        Return dt
    End Function

    Function Cargar(ByVal Procedimiento As String, ByVal Parametros() As String) As DataTable
        Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cmd.CommandText = Procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cn.Open()
        cmd.Connection = cn
        da.SelectCommand = cmd
        SqlCommandBuilder.DeriveParameters(cmd)

        If Not Parametros Is Nothing Then
            For i = 1 To Parametros.Length
                cmd.Parameters(i).Value = Parametros(i - 1)
            Next
        End If

        da.Fill(dt)
        da = Nothing
        cmd = Nothing
        cn.Close()

        Return dt
    End Function


    'Function Guardar(ByVal Procedimiento As String, ByVal Parametros() As String, Optional ByVal Tran As Boolean = False) As SqlCommand
    '    Dim cmd As New SqlCommand
    '    With cmd
    '        If Tran = True Then
    '            .Connection = ClConexion.vconsql
    '            .Transaction = ClConexion.vtran
    '        Else
    '            .Connection = New SqlConnection(cl_CadenaConexion.CadenaConexion)
    '            .Connection.Open()
    '        End If

    '        .CommandType = Data.CommandType.StoredProcedure
    '        .CommandText = Procedimiento
    '        Data.SqlClient.SqlCommandBuilder.DeriveParameters(cmd)
    '        .CommandTimeout = 0
    '    End With
    '    AsignarParametros(cmd, Parametros, Tran)
    '    Return cmd
    'End Function


    Function Guardar(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Boolean
        Try
            Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            Dim cmd As New SqlCommand

            cmd.CommandText = Procedimiento
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0
            cn.Open()
            cmd.Connection = cn
            SqlCommandBuilder.DeriveParameters(cmd)
            If Not Parametros Is Nothing Then
                For i = 1 To Parametros.Length
                    cmd.Parameters(i).Value = Parametros(i - 1)
                Next
            End If

            Dim valor As Object = cmd.ExecuteNonQuery()
            cmd = Nothing
            cn.Close()

            Return True
        Catch ex As Exception
            XtraMsg("SP: " & Procedimiento & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub AsignarParametros(ByRef cmd As SqlCommand, ByVal Parametros() As String, ByVal Tran As Boolean)
        SqlCommandBuilder.DeriveParameters(cmd)

        For i = 1 To Parametros.Length
            cmd.Parameters(i).Value = Parametros(i - 1)
        Next

        cmd.ExecuteNonQuery()
        If Tran = False Then
            cmd.Connection.Close()
        End If

    End Sub


End Module

