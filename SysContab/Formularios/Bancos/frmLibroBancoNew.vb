Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.Templates
Imports DevExpress.XtraReports.UI
Public Class frmLibroBancoNew

    Dim Libros As New VB.SysContab.LibrosDB
    Dim DT_LB As New DataTable

    Private Sub frmLibroBancoNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchLookUp(cbBancos, ObtieneDatos("SP_GetCatalogoBancos", EmpresaActual), "Nombre", "Cuenta", 0, 4, 5)

        LookUp(cbMoneda, VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio"), "Nombre", "MonedaCambio", "[Seleccione Moneda]", 0, 1, 2)
        cbMoneda.EditValue = MonedaBase

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        dtpHasta.DateTime = UltimoDiaDelMes(f).Date

        DT_LB = VB.SysContab.LibrosDB.LibroBancoAuxiliar(
            dtpDesde.DateTime.Date,
            dtpHasta.DateTime.Date,
            "XXXX",
            cbMoneda.EditValue)

        iGrid.DataSource = DT_LB
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)

        iVista.Columns("Empresa").Visible = False
        iVista.Columns("Titulo").Visible = False
        iVista.Columns("Rango").Visible = False
        iVista.Columns("Moneda").Visible = False
        iVista.Columns("Cuenta").Visible = False
        iVista.Columns("Nombre").Visible = False
        iVista.Columns("Usuario").Visible = False
        iVista.Columns("SaldoAnterior").Visible = False
        iVista.Columns("Usuario").Visible = False
        iVista.Columns("CompID").Visible = False
        iVista.Columns("Per_Id").Visible = False

        iVista.Columns("Saldo Actual").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVista.Columns("T/C").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click


        If cbBancos.EditValue Is Nothing Then
            XtraMsg("Seleccione Banco")
            cbBancos.Focus()
            Exit Sub
        End If
        '
        ShowSplash()

        DT_LB = VB.SysContab.LibrosDB.LibroBancoAuxiliar(dtpDesde.DateTime.Date,
                                                                    dtpHasta.DateTime.Date,
                                                                    cbBancos.EditValue,
                                                                    cbMoneda.EditValue)
        iGrid.DataSource = DT_LB

        If DT_LB.Rows.Count = 0 Then
            etSaldoAnterior.Text = "0.00"
            etSaldoActual.Text = "0.00"
        Else
            etSaldoAnterior.Text = CDbl(DT_LB.Rows.Item(0)("SaldoAnterior")).ToString("n2")
            etSaldoActual.Text = CDbl(DT_LB.Rows.Item(DT_LB.Rows.Count - 1)("Saldo Actual")).ToString("n2")
        End If

        HideSplash()
    End Sub

    Private Sub cbBancos_EditValueChanged(sender As Object, e As EventArgs) Handles cbBancos.EditValueChanged
        If Inicio Then Exit Sub

        Dim dsCB As DataSet = VB.SysContab.Catalogo_BancosDB.CatalogoBancosXCuenta(cbBancos.EditValue)
        cbMoneda.EditValue = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        ShowSplash("Imprimiendo...")
        '
        Dim rpt As New rptLibroBanco
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

        VistaPreviaDX(rpt, DT_LB, "Reporte de " & Me.Text)
        '
        HideSplash()
        'ShowSplash()
        ''
        'Dim rpt As New rptLibroBanco

        'Dim Contenedor As New frmManejadorReporte

        'With Contenedor
        '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        '    rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
        '    rpt.DataSource = DT_LB
        '    rpt.ShowPrintMarginsWarning = False
        '    rpt.CreateDocument()
        '    .Show()
        '    .Text = "Reporte " & Me.Text
        '    .WindowState = FormWindowState.Maximized
        'End With
        ''
        'HideSplash()


        '
        'frmManejadorReporte.Dispose()
        ''
        'With frmManejadorReporte
        '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        '    rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
        '    rpt.DataSource = DT_LB
        '    rpt.ShowPrintMarginsWarning = False
        '    rpt.CreateDocument()
        '    .Show()
        '    .Text = "Reporte " & Me.Text
        '    .WindowState = FormWindowState.Maximized
        'End With


        'Dim lyControl As New DevExpress.XtraLayout.LayoutControl
        'lyControl.

        'Dim dv As New DevExpress.XtraPrinting.Preview.DocumentViewer
        'dv.Dock = DockStyle.Fill
        ''dv.InitiateDocumentCreation()

        'Dim DocumentViewerRibbonController1 As New DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController

        'Dim rb As New DevExpress.XtraBars.Ribbon.RibbonControl
        'rb.CreateControl()
        'rb.Dock = DockStyle.Top

        'DocumentViewerRibbonController1.DocumentViewer = dv
        'DocumentViewerRibbonController1.RibbonControl = rb

        ''rb.Controls.Add(dvR)

        'dv.PrintingSystem = rpt.PrintingSystem
        'rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
        'rpt.DataSource = DT_LB
        'rpt.ShowPrintMarginsWarning = False
        'rpt.CreateDocument()

        'Dim frm As New DevExpress.XtraEditors.XtraForm
        ''
        'With frm
        '    .Controls.Add(rb)
        '    .Controls.Add(dv)
        '    .Show()
        '    .Text = "Reporte " & Me.Text
        '    .WindowState = FormWindowState.Maximized

        'End With

        'HideSplash()

    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        lySaldoAnterior.Text = "Saldo Anterior " & cbMoneda.GetColumnValue("Simbolo") & ": "
        lySaldoActual.Text = "Saldo Actual " & cbMoneda.GetColumnValue("Simbolo") & ": "
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Conciliado" Then
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Conciliado") Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                e.Appearance.BackColor = Color.LightPink
            End If
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub
End Class