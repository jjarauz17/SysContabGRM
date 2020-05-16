Public Class frmPlanDeAccion

    Dim obj As New PNR_PlanAccion
    Dim db As New db_PNR_PlanAccion

    Public IdPlanNegocio As Integer = 0
    Public CuentaCliente As String = vbNullString
    Public Periodo As Integer = VB.SysContab.Rutinas.Fecha.Year

    Private Sub frmPlanDeAccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_PlanAccion.Listar(0, IdPlanNegocio, Periodo)
        FormatoGrid(iVista)
        iVista.Columns("IdPlanAccion").Visible = False
        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("Registro").Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmPlanDeAccionAdd.IdPlanAccion = 0
        frmPlanDeAccionAdd.IdPlanNegocio = IdPlanNegocio
        frmPlanDeAccionAdd.lblCliente.Text = CuentaCliente
        frmPlanDeAccionAdd.Text = "Agregar Plan de Acción..."
        frmPlanDeAccionAdd.ShowDialog()
        frmPlanDeAccionAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmPlanDeAccionAdd.IdPlanAccion = iVista.GetFocusedRowCellValue("IdPlanAccion")
        frmPlanDeAccionAdd.IdPlanNegocio = IdPlanNegocio
        frmPlanDeAccionAdd.lblCliente.Text = iVista.GetFocusedRowCellValue("Cuenta")
        frmPlanDeAccionAdd.Text = "Modificar Plan de Acción..."
        frmPlanDeAccionAdd.ShowDialog()
        frmPlanDeAccionAdd.Dispose()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.IdPlanAccion = iVista.GetFocusedRowCellValue("IdPlanAccion")
        db.Borrar(obj)
        Cargar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        SimpleButton2_Click(Nothing, Nothing)
    End Sub
End Class