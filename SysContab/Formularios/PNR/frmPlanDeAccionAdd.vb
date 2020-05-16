Public Class frmPlanDeAccionAdd

    Dim obj As New PNR_PlanAccion
    Dim db As New db_PNR_PlanAccion

    Public IdPlanAccion As Integer = 0
    Public IdPlanNegocio As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmPlanDeAccionAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPlanDeAccion.Cargar()
    End Sub

    Private Sub frmPlanDeAccionAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        FechaLimite.DateTime = f.Date
        FechaEjecucion.DateTime = f.Date
        '
        Combo(cbResponsable, db_PNR_Responsables.Listar(0))

        GridLookUp(cbCliente, ObtieneDatos("JAR_GetPlanNegocioList", EmpresaActual), "Nombre", "IdPlanNegocio", 5, 4, 2, 1)
        If IdPlanNegocio <> 0 Then cbCliente.EditValue = IdPlanNegocio

        If IdPlanAccion <> 0 Then
            obj = db_PNR_PlanAccion.Detalles(IdPlanAccion)

            If Not obj Is Nothing Then
                txtNombre.Text = obj.Nombre
                cbResponsable.EditValue = obj.IdResponsable
                FechaLimite.DateTime = obj.Fecha_Limite
                FechaEjecucion.DateTime = obj.Fecha_Ejecucion
                txtRecurso.EditValue = obj.Recursos
                sAvance.EditValue = obj.Avance
                txtGastoReal.EditValue = obj.Gasto_Real
                cbCliente.EditValue = obj.IdPlanNegocio
            End If
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.IdPlanAccion = IdPlanAccion
        obj.IdPlanNegocio = cbCliente.EditValue
        obj.Empresa = EmpresaActual
        obj.Nombre = txtNombre.Text
        obj.IdResponsable = cbResponsable.EditValue
        obj.Fecha_Limite = FechaLimite.DateTime.Date
        obj.Recursos = txtRecurso.EditValue
        obj.Avance = sAvance.EditValue
        obj.Fecha_Ejecucion = FechaEjecucion.DateTime.Date
        obj.Gasto_Real = txtGastoReal.EditValue

        If IdPlanAccion = 0 Then
            db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
            Ok = "SI"
        End If

        Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class