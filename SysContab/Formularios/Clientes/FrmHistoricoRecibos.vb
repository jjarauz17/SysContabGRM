Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Public Class FrmHistoricoRecibos

    Private Recibo As New db_RecibosImportar
    Dim Cadena As New ConeccionRecibos

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        frmExportarImprimir.Mostrar(GridControl1, "Recibos de Caja")
    End Sub

    Private Sub FrmHistoricoRecibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String() = Cadena.LeeData()
        If s(0).ToString <> "" Then

            tServidor.Text = s(0)
            tBase.Text = s(1)
            tUsuario.Text = s(2)
            tClave.Text = s(3)

            GetData()
        End If
    End Sub

    Public Sub GetData()
        GridControl1.DataSource = Recibo.List
        FormatoGrid(GridView1)
    End Sub

    Private Sub Contabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contabilizar.Click
        If XtraMsg2("Este proceso contabilizara los recibos seleccionados, Desea continuar?") Then
            ShowSplash("Contabilizando Recibos...")

            For i As Integer = 0 To GridView1.DataRowCount - 1
                If GridView1.GetRowCellValue(i, "Seleccionar") Then
                    Dim DT As DataTable = Recibo.GetDetalle(GridView1.GetRowCellValue(i, "IdRecibo"))

                    If DT.Rows.Count > 0 Then
                        If Recibo.Contabilizar(DT.Rows.Item(0)("IdRecibo"), _
                                               DT.Rows.Item(0)("IdEstudiante"), _
                                               DT.Rows.Item(0)("Numero"), _
                                               DT.Rows.Item(0)("Fecha"), _
                                               DT.Rows.Item(0)("Retencion"), _
                                               DT.Rows.Item(0)("Monto"), _
                                               DT.Rows.Item(0)("Factura")) Then

                            Recibo.ActualizarEstado(GridView1.GetRowCellValue(i, "IdRecibo"))
                        End If

                    End If

                End If
            Next
            '
            HideSplash()
            GetData()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim msg As String = Test()

        If msg = "OK" Then
            XtraMsg("Prueba de Conexión Exitosa !!!")
        Else
            XtraMsg("Prueba de Conexión Fallida !!!" & vbCrLf & msg, MessageBoxIcon.Warning)
        End If
    End Sub

    Function Test() As String
        ShowSplash()

        Dim Cnn As New SqlConnection(sStrSQL)

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("USE " + tBase.Text + ";", Cnn)
            da.Fill(dt)

            HideSplash()

            Return "OK"
        Catch ex As Exception
            HideSplash()
            Return ex.Message
        End Try
    End Function

    Function sStrSQL() As String
        Dim StrConn As String = vbNullString

        'Autenticacion de SQL
        StrConn = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", tServidor.Text, "Master", tUsuario.Text, tClave.Text)

        Return StrConn
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cadena.EscribeData(tServidor.Text, tBase.Text, tUsuario.Text, tClave.Text)

        GetData()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GetData()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub
End Class