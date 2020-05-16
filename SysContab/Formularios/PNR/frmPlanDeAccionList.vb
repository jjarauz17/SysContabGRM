Public Class frmPlanDeAccionList 

    Dim obj As New PNR_PlanAccion
    Dim db As New db_PNR_PlanAccion

    Private Sub frmPlanDeAccionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year

        'Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        iVista.Columns("IdPlanAccion").Visible = False
        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("Registro").Visible = False
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_PlanAccion.Listar(0, 0, cbPeriodo.EditValue)
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Editar()
    End Sub

    Sub Editar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmPlanDeAccionAdd.IdPlanAccion = iVista.GetFocusedRowCellValue("IdPlanAccion")
        frmPlanDeAccionAdd.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        frmPlanDeAccionAdd.lblCliente.Text = iVista.GetFocusedRowCellValue("Cuenta")
        frmPlanDeAccionAdd.Text = "Modificar Plan de Acción..."
        frmPlanDeAccionAdd.ShowDialog()
        If frmPlanDeAccionAdd.Ok = "SI" Then Cargar()
        frmPlanDeAccionAdd.Dispose()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click        
        frmPlanDeAccionxCultivoAdd.Text = "Agregar Plan de Acción por Cultivo..."
        frmPlanDeAccionxCultivoAdd.ShowDialog()
        If frmPlanDeAccionxCultivoAdd.Ok = "SI" Then Cargar()
        frmPlanDeAccionxCultivoAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Editar()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Borrar()
    End Sub

    Sub Borrar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Borrar el Plan de Acción?") Then
            Exit Sub
        End If

        obj.IdPlanAccion = iVista.GetFocusedRowCellValue("IdPlanAccion")
        db.Borrar(obj)
        Cargar()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If e.KeyCode = Keys.Delete Then Borrar()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        frmPlanDeAccionAdd.IdPlanAccion = iVista.GetFocusedRowCellValue("IdPlanAccion")
        frmPlanDeAccionAdd.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        frmPlanDeAccionAdd.lblCliente.Text = iVista.GetFocusedRowCellValue("Cuenta")
        frmPlanDeAccionAdd.Text = "Modificar Plan de Acción..."
        frmPlanDeAccionAdd.ShowDialog()
        If frmPlanDeAccionAdd.Ok = "SI" Then Cargar()
        frmPlanDeAccionAdd.Dispose()
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Cargar()
    End Sub
End Class