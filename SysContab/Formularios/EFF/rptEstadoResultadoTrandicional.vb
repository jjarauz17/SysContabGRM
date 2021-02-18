Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraBars
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI
Imports SysContab.VB.SysContab

Public Class rptEstadoResultadoTrandicional
    Private Sub rptEstadoResultadoTrandicional_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()
        '
        If Fila.Item("Nombre3") = "" Then
            Nombre3.Visible = False
            Cargo3.Visible = False
        End If
    End Sub

    Private Sub Movimiento_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Movimiento.BeforePrint, SaldoActual.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()
    End Sub

    'Private Sub Movimiento_PreviewClick(sender As Object, e As PreviewMouseEventArgs) Handles Movimiento.PreviewClick
    '    ' Create a new Detail Report instance. 
    '    ' Dim rpt As New rptDetalle

    '    ' Obtain the current category's ID and Name from the e.Brick.Value property, 
    '    ' which stores an object assigned the label's Tag property. 
    '    'detailReport.catId.Value = CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("CategoryID")))
    '    'detailReport.catName.Value = (CType(e.Brick.Value, DataRowView)).Row("CategoryName").ToString()

    '    'rpt.Cuenta = (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString()
    '    'rpt.Desde = CDate((CType(e.Brick.Value, DataRowView)).Row("Desde").ToString())
    '    'rpt.Hasta = CDate((CType(e.Brick.Value, DataRowView)).Row("Hasta").ToString())

    '    ' Show the detail report in a new modal window. 
    '    'Dim pt As New ReportPrintTool(rpt)
    '    'pt.ShowPreviewDialog()

    '    'ShowSplash("Cargando Auxiliar...")
    '    ''
    '    ''Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
    '    'Dim Libros As New VB.SysContab.LibrosDB()

    '    'Dim rpt As New rptLibroAuxiliar2
    '    'rpt.Nivel = Libros.Niveles().Tables("Niveles").Rows.Count - 1
    '    'rpt.pLogo.Image = pLogo.Image

    '    'Dim DT As DataTable = VB.SysContab.LibrosDB.Libro_Auxiliar_DX2(CDate((CType(e.Brick.Value, DataRowView)).Row("Desde").ToString()),
    '    '                                                               CDate((CType(e.Brick.Value, DataRowView)).Row("Hasta").ToString()),
    '    '                                                               (CType(e.Brick.Value, DataRowView)).Row("Mon_Codigo").ToString(),
    '    '                                                               (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString())


    '    'For i As Integer = 0 To DT.Rows.Count - 1
    '    '    Try
    '    '        If DT.Rows.Item(i)("Concepto") <> "Saldo Anterior" Then DT.Rows.Item(i)("Acumulado") = DT.Rows.Item(i - 1)("Acumulado") +
    '    '            IIf(DT.Rows.Item(i)("Clase") = 1, (DT.Rows.Item(i)("debe") - DT.Rows.Item(i)("haber")), (DT.Rows.Item(i)("haber") - DT.Rows.Item(i)("debe")))
    '    '    Catch ex As Exception
    '    '    End Try
    '    'Next

    '    'rpt.DataSource = DT
    '    'HideSplash()
    '    'rpt.ShowPrintMarginsWarning = False

    '    ''Dim pt As New ReportPrintTool(rpt)
    '    ''pt.ShowRibbonPreviewDialog()


    '    'rpt.BringToFront()
    '    'rpt.ShowRibbonPreview()
    'End Sub

    Private Sub Movimiento_PreviewMouseMove(sender As Object, e As PreviewMouseEventArgs) Handles Movimiento.PreviewMouseMove, SaldoActual.PreviewMouseMove
        e.PreviewControl.Cursor = Cursors.Hand
    End Sub

    Private Sub Movimiento_PreviewDoubleClick(sender As Object, e As PreviewMouseEventArgs) Handles Movimiento.PreviewClick, SaldoActual.PreviewClick
        ShowSplash("Imprimiendo Auxiliar...")
        '
        Dim Libros As New VB.SysContab.LibrosDB()

        Dim rpt As New rptLibroAuxiliar2
        rpt.Nivel = Libros.Niveles().Tables("Niveles").Rows.Count - 1
        rpt.pLogo.Image = pLogo.Image

        Dim DT As DataTable =
            LibrosDB.Libro_Auxiliar_DX2(CDate((CType(e.Brick.Value, DataRowView)).Row("Desde").ToString()),
                                                                       CDate((CType(e.Brick.Value, DataRowView)).Row("Hasta").ToString()),
                                                                       (CType(e.Brick.Value, DataRowView)).Row("Mon_Codigo").ToString(),
                                                                       (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString())

        For i As Integer = 0 To DT.Rows.Count - 1
            Try
                If DT.Rows.Item(i)("Concepto") <> "Saldo Anterior" Then DT.Rows.Item(i)("Acumulado") = DT.Rows.Item(i - 1)("Acumulado") +
                    IIf(DT.Rows.Item(i)("Clase") = 1, (DT.Rows.Item(i)("debe") - DT.Rows.Item(i)("haber")), (DT.Rows.Item(i)("haber") - DT.Rows.Item(i)("debe")))
            Catch ex As Exception
            End Try
        Next

        VistaPreviaDX(rpt,
                      DT,
                      "Mayor Auxiliar " & (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString())

        'With frmManejadorReporte2
        '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        '    rpt.DataSource = DT
        '    rpt.CreateDocument()
        '    .MdiParent = frmMDIReporte
        '    .Show()
        '    .Text = "Mayor Auxiliar " & (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString()
        '    .WindowState = FormWindowState.Maximized
        'End With
        '
        HideSplash()



        'rpt.DataSource = DT
        'HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'Dim pt As New ReportPrintTool(rpt)
        'rpt.DataSource = DT
        'rpt.ShowPrintMarginsWarning = False
        'pt.ShowRibbonPreviewDialog()

        'Dim dv As New DevExpress.XtraPrinting.Preview.DocumentViewer()
        ''dv.PrintingSystem = rpt.PrintingSystem
        'dv.Dock = DockStyle.Fill
        'dv.InitiateDocumentCreation()


        'Dim myItem As BarItem = New BarButtonItem() With {.Caption = "MyButton"}
        'Dim pt As New ReportPrintTool(rpt)
        'Dim manager As BarManager = TryCast((TryCast(pt.PreviewForm, PrintPreviewFormEx)).PrintBarManager, BarManager)
        'manager.Bars("Toolbar").AddItem(myItem)

        'Dim frm As New DevExpress.XtraEditors.XtraForm

        'frm.Controls.Add(dv)

        'dv.PrintingSystem = pt.PrintingSystem
        'rpt.DataSource = DT
        'rpt.ShowPrintMarginsWarning = False
        ''pt.ShowRibbonPreview()

        'rpt.CreateDocument()
        'frm.MdiParent = frmMDIReporte
        'frm.Show()
        'frm.Text = "Mayor Auxiliar " & (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString()
        'frm.WindowState = FormWindowState.Maximized


        'With frmManejadorReporte
        '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem

        '    Dim frm As DevExpress.XtraEditors.XtraForm = frmManejadorReporte

        '    rpt.DataSource = DT
        '    rpt.ShowPrintMarginsWarning = False
        '    rpt.CreateDocument()
        '    ' .MdiParent = frmMDIReporte
        '    frm.Show()
        '    frm.Text = "Mayor Auxiliar " & (CType(e.Brick.Value, DataRowView)).Row("Cuenta").ToString()
        '    frm.WindowState = FormWindowState.Maximized
        'End With


        'With frmManejadorReporte
        '    .DocumentViewer1.PrintingSystem = pt.PrintingSystem
        '    rpt.DataSource = DT
        '    rpt.ShowPrintMarginsWarning = False
        '    rpt.CreateDocument()
        'End With
        '
        'HideSplash()

        'pt.ShowRibbonPreviewDialog()
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub
End Class