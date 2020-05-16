Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class FrmConfiguracionServer

    Private Tested As Boolean = False
    Public Inicio As Integer = 0

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        If Inicio = 0 Then
            End
        Else
            Close()
        End If
        'Close()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        Dim msg1 As String = Test()

        If msg1 <> "OK" Then
            If Not XtraMsg2("Desea Guardar La Configuración Con Errores en la conexión a SQL?") Then
                Exit Sub
            End If
        End If
        ''
        EscribeData(Servidor.Text, Base.Text, UsrSQL.Text, PassSQL.Text)    ', cbRegion.EditValue)
        LeeData()
        ''
        'My.Application.ChangeCulture(cbRegion.EditValue)
        XtraMsg("Configuración Guardada con Exito!!!")


        'If Not Tested Then
        '    XtraMessageBox.Show("La prueba de conexion no ha sido verificada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        'SaveSetting("Simtesis", "SysNomina2014", "BaseDatos", Base.Text)
        'SaveSetting("Simtesis", "SysNomina2014", "Server", Servidor.Text)
        'Close()
    End Sub

    Private Sub FrmConfiguracionServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' CargarConfiguracionRegional(cbRegion)

        Try
            Dim s As String() = LeeData()

            Servidor.Text = s(0).ToString
            Base.Text = s(1).ToString

            '  cbRegion.EditValue = s(4).ToString

            UsrSQL.Focus()
        Catch ex As Exception
        End Try

        'Base.Text = GetSetting("Simtesis", "SysNomina2014", "BaseDatos")
        'Servidor.Text = GetSetting("Simtesis", "SysNomina2014", "Server")
    End Sub

    Function Cadena() As String
        Dim StrConn As String = vbNullString

        'Autenticacion de SQL
        StrConn = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", Servidor.Text, "Master", UsrSQL.Text, PassSQL.Text)

        Return StrConn
    End Function

    Function Test() As String
        ShowSplash()

        Dim Cnn As New SqlConnection(Cadena)

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("USE " + Base.Text + ";", Cnn)
            da.Fill(dt)

            HideSplash()

            LeeData()

            Return "OK"
        Catch ex As Exception
            HideSplash()
            Return ex.Message
        End Try
    End Function

    Private Sub Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bProbarConexion.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        Dim msg As String = Test()

        If msg = "OK" Then
            XtraMsg("Prueba de Conexión Exitosa !!!")
        Else
            XtraMsg("Prueba de Conexión Fallida !!!" & vbCrLf & msg, MessageBoxIcon.Warning)
        End If

        'Dim Con As New SqlConnection
        'Con.ConnectionString = "Server = " & Servidor.Text & ";User Id=" & UsrSQL.Text & ";Password = " & PassSQL.Text & ";Initial Catalog = " & Base.Text
        'Try
        '    Con.Open()
        '    Tested = True
        '    XtraMessageBox.Show("La prueba de conexion ha sido satisfactoria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Con.Close()
        'Catch ex As Exception
        '    Tested = False
        '    XtraMessageBox.Show("La prueba de conexion no ha sido satisfactoria", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class