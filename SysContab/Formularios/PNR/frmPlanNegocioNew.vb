Imports DevExpress.XtraReports.UI
Public Class frmPlanNegocioNew

    Dim obj As New PNR_PlanNegocio
    Dim db As New db_PNR_PlanNegocio
    Dim DT_ROL As DataTable

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        '
        FormatoGridNew(iVista, 2, 1)
        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("PB Total U$").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Observaciones").Visible = False
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_PlanNegocio.Listar(cbPeriodo.EditValue, 1)
        'SimpleFormatGrid(iVista, False, DevExpress.Utils.HorzAlignment.Center, 1, 2, 14, 0, 13)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Inicio = True
        ShowSplash()
        frmPlanNegocioNewAdd.Dispose()
        frmPlanNegocioNewAdd.MdiParent = Me.MdiParent
        frmPlanNegocioNewAdd.IdPlanNegocio = 0
        frmPlanNegocioNewAdd.Text = "Plan de Negocio"
        frmPlanNegocioNewAdd.DT_ROL = DT_ROL
        frmPlanNegocioNewAdd.Show()
        frmPlanNegocioNewAdd.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Inicio = True
        ShowSplash("Cargando Datos...")
        frmPlanNegocioNewAdd.Dispose()
        frmPlanNegocioNewAdd.MdiParent = Me.MdiParent
        frmPlanNegocioNewAdd.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        frmPlanNegocioNewAdd.Text = "Plan de Negocio"
        frmPlanNegocioNewAdd.DT_ROL = DT_ROL
        frmPlanNegocioNewAdd.Show()
        frmPlanNegocioNewAdd.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
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
        If db.Borrar(obj) Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
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

        ShowSplash("Cargando Presupuesto...")
        frmPresupuestoVer.Dispose()
        '
        With frmPlanNegocioNewVer
            .MdiParent = Me.MdiParent
            .Text = $"Ver PNR No. {iVista.GetFocusedRowCellValue("Codigo")}"
            .Mostrar(
                    iVista.GetFocusedRowCellValue("IdPlanNegocio"),
                    iVista.GetFocusedRowCellValue("Sucursal"),
                    iVista.GetFocusedRowCellValue("Sucursal"),
                    iVista.GetFocusedRowCellValue("Periodo"),
                    iVista.GetFocusedRowCellValue("Cultivo"),
                    iVista.GetFocusedRowCellValue("Cliente"))
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

        'frmPresupuestoVer.MdiParent = Me.MdiParent
        'frmPresupuestoVer.IdPresupuesto = iVista.GetFocusedRowCellValue("IdPresupuesto")
        'frmPresupuestoVer.Text = "Ver Presupuesto"
        'frmPresupuestoVer.Show()
        'frmPresupuestoVer.WindowState = FormWindowState.Maximized
        HideSplash()

        'If iVista.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione un registro!")
        '    Exit Sub
        'End If

        'ShowSplash("Cargando PNR...")

        'frmPlanNegocioPivot.Dispose()

        'With frmPlanNegocioPivot
        '    .IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        '    .Show()
        '    .Text = "Plan de Negocio - Reporte"
        '    .WindowState = FormWindowState.Maximized
        'End With

        'HideSplash()
    End Sub

    Private Sub bObjetivos_Click(sender As Object, e As EventArgs)

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

    Private Sub bAntecedentes_Click(sender As Object, e As EventArgs)
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

    Private Sub bEstacionalidad_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub frmPlanNegocioNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub
End Class