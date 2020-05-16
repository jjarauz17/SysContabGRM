Imports DevExpress.XtraReports.UI
Public Class frmInventarioFisicoLineas

    Dim Grupos As New VB.SysContab.Grupos_InventarioDB
    Public Tipo As String = "P"

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim DT As DataTable = ObtieneDatos("RCT_SPFormatoInventario", cbBodega.EditValue, Tipo, _
                                           IIf(CbLinea.EditValue Is Nothing, "%", CbLinea.EditValue), _
                                           IIf(cbGrupo.EditValue Is Nothing, "%", cbGrupo.EditValue), _
                                           EmpresaActual)

        If DT.Rows.Count = 0 Then
            XtraMsg("No Hay Datos Para Mostrar")
            Exit Sub
        End If

        Dim rpt As New rptFormatoCargaInvent
        If Not CheckEdit1.Checked Then
            rpt.etLinea.Text = CbLinea.Text + vbCrLf + cbGrupo.Text
        Else
            rpt.etLinea.Text = "TODAS LAS LINEAS"
        End If

        rpt.DataSource = DT

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub CbLinea_EditValueChanged(sender As Object, e As EventArgs) Handles CbLinea.EditValueChanged
        Try
            Combo(cbGrupo, Grupos.Grupos(CbLinea.EditValue, "P").Tables("GruposCC"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmInventarioFisicoLineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo(CbLinea, Grupos.Lineas("P").Tables("GruposCC"))
        GetBodegasList(cbBodega)
    End Sub
End Class