Public Class frmPlanDeAccionxCultivoAdd

    Dim obj As New PNR_PlanAccion
    Dim db As New db_PNR_PlanAccion

    Dim IdPlanAccion As Integer = 0
    Dim IdPlanNegocio As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmPlanDeAccionAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' frmPlanDeAccion.Cargar()
    End Sub

    Private Sub frmPlanDeAccionAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        FechaLimite.DateTime = f.Date
        FechaEjecucion.DateTime = f.Date
        '
        CargarCombos()
    End Sub

    Sub CargarCombos()
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        Application.DoEvents()
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario " & EmpresaActual & "," & Usuario_ID & ""))
        Application.DoEvents()
        Combo(cbCultivo, GetCultivo())
        Application.DoEvents()
        Combo(cbResponsable, db_PNR_Responsables.Listar(0))
    End Sub


    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.IdPlanAccion = IdPlanAccion
        obj.IdPlanNegocio = IdPlanNegocio
        obj.Empresa = EmpresaActual
        obj.Nombre = txtNombre.Text
        obj.IdResponsable = cbResponsable.EditValue
        obj.Fecha_Limite = FechaLimite.DateTime.Date
        obj.Recursos = txtRecurso.EditValue
        obj.Avance = sAvance.EditValue
        obj.Fecha_Ejecucion = FechaEjecucion.DateTime.Date
        obj.Gasto_Real = txtGastoReal.EditValue
        obj.Sucursal = cbSucursal.EditValue
        obj.Cultivo = cbCultivo.EditValue
        obj.Periodo = cbPeriodo.EditValue

        If IdPlanAccion = 0 Then
            db.InsertarxCultivo(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
        End If

        Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class