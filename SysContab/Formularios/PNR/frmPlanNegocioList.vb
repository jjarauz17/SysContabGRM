Imports DevExpress.XtraReports.UI
Public Class frmPlanNegocioList

    Dim obj As New PNR_PlanNegocio
    Dim db As New db_PNR_PlanNegocio
    Dim DT_ROL As DataTable

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year        
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_PlanNegocio.Listar(0, cbPeriodo.EditValue)
        SimpleFormatGrid(iVista, False, DevExpress.Utils.HorzAlignment.Center, 1, 2, 14, 0, 13)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        ShowSplash("Cargando Datos...")
        frmPlanNegocio.Dispose()
        frmPlanNegocio.MdiParent = Me.MdiParent
        frmPlanNegocio.IdPlanNegocio = 0
        frmPlanNegocio.Text = "Plan de Negocio"
        frmPlanNegocio.DT_ROL = DT_ROL
        frmPlanNegocio.Show()
        frmPlanNegocio.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash("Cargando Datos...")
        frmPlanNegocio.Dispose()
        frmPlanNegocio.MdiParent = Me.MdiParent
        frmPlanNegocio.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        frmPlanNegocio.Text = "Plan de Negocio"
        frmPlanNegocio.DT_ROL = DT_ROL
        frmPlanNegocio.Show()
        frmPlanNegocio.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        If db.Borrar(obj) Then Cargar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Planes de Negocio Ramac", "Periodo " & cbPeriodo.EditValue.ToString)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash("Imprimiendo Reporte...")
        '
        Dim rpt As New rptReportePNR
        Dim rprSub1 As New rptPlanDeAccion
        Dim rprSub2 As New rptAntecedentes

        ' rpt.iGrid.DataSource = db_PNR_PlanNegocioDetalle.ReporteImpreso(iVista.GetFocusedRowCellValue("IdPlanNegocio"))
        rprSub1.DataSource = db_PNR_Reportes.ReportePlanDeAccion(iVista.GetFocusedRowCellValue("IdPlanNegocio"))
        rprSub2.DataSource = db_PNR_Reportes.ReporteAntecedentes(iVista.GetFocusedRowCellValue("IdPlanNegocio"))

        rpt.DataSource = db_PNR_Reportes.ReporteImpreso(iVista.GetFocusedRowCellValue("IdPlanNegocio"))

        rpt.Periodo = iVista.GetFocusedRowCellValue("Periodo")
        rpt.xSubPlanAccion.ReportSource = rprSub1
        rpt.xSubAntecedentes.ReportSource = rprSub2

        rpt.CreateDocument()

        frmReportViewer.Dispose()

        With frmReportViewer
            .DocumentViewer1.DocumentSource = rpt
            .Show()
            .Text = "Vista Previa Plan de Negocio"
            .WindowState = FormWindowState.Maximized

            'Verificar si el Usuario tiene permiso de Imprimir y Exportar el reporte        
            If DT_ROL.Rows.Count > 0 Then
                Dim dr() As DataRow = DT_ROL.Select("Control = 'Imprimir'")
                If dr.Length > 0 Then .BarraImprimir.Enabled = True
            End If
        End With
        '
        HideSplash()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles bDinamico.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash("Cargando PNR...")

        frmPlanNegocioPivot.Dispose()

        With frmPlanNegocioPivot
            .IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
            .Show()
            .Text = "Plan de Negocio - Reporte"
            .WindowState = FormWindowState.Maximized
        End With

        HideSplash()
    End Sub

    Private Sub bObjetivos_Click(sender As Object, e As EventArgs) Handles bObjetivos.Click

    End Sub

    Private Sub bPlan_Click(sender As Object, e As EventArgs) Handles bPlan.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        frmPlanDeAccion.Dispose()
        frmPlanDeAccion.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        frmPlanDeAccion.CuentaCliente = iVista.GetFocusedRowCellValue("Cliente")
        frmPlanDeAccion.Periodo = iVista.GetFocusedRowCellValue("Periodo")
        frmPlanDeAccion.WindowState = FormWindowState.Maximized
        frmPlanDeAccion.ShowDialog()
    End Sub

    Private Sub bAntecedentes_Click(sender As Object, e As EventArgs) Handles bAntecedentes.Click
        'If iVista.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione un registro!")
        '    Exit Sub
        'End If
        ''l
        'frmAntecedentes.Dispose()
        'frmAntecedentes.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        'frmAntecedentes.CuentaCliente = iVista.GetFocusedRowCellValue("Cliente")
        'frmAntecedentes.WindowState = FormWindowState.Maximized
        'frmAntecedentes.ShowDialog()
    End Sub

    Private Sub bEstacionalidad_Click(sender As Object, e As EventArgs) Handles bEstacionalidad.Click

    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Cargar()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub
End Class