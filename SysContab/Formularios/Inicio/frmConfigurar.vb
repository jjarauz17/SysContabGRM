Imports System.Data
Imports System.Data.SqlClient

Public Class frmConfigurar

    Public Inicio As Integer = 0

    Private Sub btnProbarConexion1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProbarConexion1.Click
        Dim msg As String = Test()

        If msg = "OK" Then
            XtraMsg("Prueba de Conexión Exitosa !!!")
        Else
            XtraMsg("Prueba de Conexión Fallida !!!" & vbCrLf & msg, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim msg1 As String = Test()

        If msg1 <> "OK" Then
            If Not XtraMsg2("Desea Guardar La Configuración Con Errores en la conexión a SQL?") Then
                Exit Sub
            End If
        End If
        ''
        EscribeData(Servidor.Text, Base.Text, UsrSQL.Text, PassSQL.Text)
        LeeData()
        ''
        XtraMsg("Configuración Guardada con Exito!!!")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Inicio = 0 Then
            End
        Else
            Close()
        End If
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

            Return "OK"
        Catch ex As Exception
            HideSplash()
            Return ex.Message
        End Try
    End Function

    Private Sub frmConfigurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim s As String() = LeeData()

            Servidor.Text = s(0).ToString
            Base.Text = s(1).ToString

            UsrSQL.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class