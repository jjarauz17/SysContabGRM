Public Class frmAntecedentesAdd

    Dim obj As New PNR_Antecedentes
    Dim db As New db_PNR_Antecedentes

    Public IdAntecedente As Integer = 0
    Public IdPlanNegocio As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmPlanDeAccionAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'frmAntecedentes.Cargar()
    End Sub

    Private Sub frmPlanDeAccionAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year     'If(DT_PNR.Rows.Count = 0, VB.SysContab.Rutinas.Fecha().Year, DT_PNR.Rows.Item(0)("Peridodo"))

        'Dim DT_PNR As DataTable = db_PNR_PlanNegocio.Listar(IdPlanNegocio, cbPeriodo.EditValue)

        If IdAntecedente <> 0 Then
            obj = db_PNR_Antecedentes.Detalles(IdAntecedente)

            If Not obj Is Nothing Then
                txtMz_Aterior.EditValue = obj.Mz_Anterior
                txtMz_Actual.EditValue = obj.Mz_Actual
                txtPbs_Aterior.EditValue = obj.PBS_Anterior
                txtPbs_Actual.EditValue = obj.PBS_Actual
            End If
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.IdAntecedente = IdAntecedente
        obj.IdPlanNegocio = IdPlanNegocio
        obj.Empresa = EmpresaActual
        obj.Periodo = cbPeriodo.EditValue
        obj.Mz_Anterior = txtMz_Aterior.EditValue
        obj.Mz_Actual = txtMz_Actual.EditValue
        obj.PBS_Anterior = txtPbs_Aterior.EditValue
        obj.PBS_Actual = txtPbs_Actual.EditValue

        If IdAntecedente = 0 Then
            db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
        End If
        '
        frmAntecedentesList.Cargar()
        Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Try
            lyMZ_Ant.Text = "No. de Mz " & (cbPeriodo.EditValue - 1).ToString
            lyMZ_Act.Text = "No. de Mz " & (cbPeriodo.EditValue).ToString

            lyPBS_Ant.Text = "PBS/ Mz en U$ " & (cbPeriodo.EditValue - 1).ToString
            lyPBS_Act.Text = "PBS/ Mz en U$ " & (cbPeriodo.EditValue).ToString
        Catch ex As Exception

        End Try
    End Sub
End Class