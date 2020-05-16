Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class rptLibroBanco

    Private Sub Comp_No_BeforePrint(sender As Object, e As PrintEventArgs) Handles Comp_No.BeforePrint, Documento.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()
    End Sub

    Private Sub Comp_No_PreviewMouseMove(sender As Object, e As PreviewMouseEventArgs) Handles Comp_No.PreviewMouseMove, Documento.PreviewMouseMove
        e.PreviewControl.Cursor = Cursors.Arrow
    End Sub

    Private Sub Comp_No_PreviewClick(sender As Object, e As PreviewMouseEventArgs) Handles Comp_No.PreviewClick, Documento.PreviewClick
        If (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString() = "" Then Exit Sub

        ShowSplash("Imprimiendo Comprobante...")

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")

        Dim DTDistrubucion As DataTable = ObtieneDatos("JAR_GetComprobanteDistribucion", (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString(),
                                                      CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("Per_Id"))),
                                                      CDate((CType(e.Brick.Value, DataRowView)).Row("Fecha").ToString()).Month,
                                                      EmpresaActual)

        Dim rptDistribucin As New rptComprobanteDistribucion
        rptDistribucin.DataSource = DTDistrubucion

        Dim rpt As rptComprobantesALL

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
        Else
            rpt = New rptComprobantesALL
        End If

        rpt.ver = True
        rpt.XrSubreport1.ReportSource = rptDistribucin
        rpt.gfDistribucion.Visible = IIf(DTDistrubucion.Rows.Count > 0, True, False)
        rpt.XrPictureBox1.Image = pLogo.Image

        Dim DT As DataTable = ObtieneDatos("_ComprobantesImpresoALL", (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString(),
                                      EmpresaActual,
                                      CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("Per_Id"))),
                                      CDate((CType(e.Brick.Value, DataRowView)).Row("Fecha").ToString()))

        VistaPreviaDX(rpt, DT, "Comprobante No. " & (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString())
        '
        HideSplash()
    End Sub


End Class