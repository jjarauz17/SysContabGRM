Imports ClasesBLL
Public Class frmProduccionEstado
    Dim obj As New Prod_Produccion
    Dim db As New db_Prod_Produccion

    Public IdProduccion As Integer = 0, Ok As String = "NO"
    Private Sub frmProduccionEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        CargarCombos()
        obj = db_Prod_Produccion.Detalles(IdProduccion)

        Dim DT_DEV As DataTable = db_Prod_ProduccionDevoluciones.Listar(IdProduccion)

        If Not obj Is Nothing Then
            Numero.Text = obj.NumeroProduccion
            dFecha.DateTime = obj.FechaProduccion
            cbFormula.EditValue = obj.IdSysFormula
            TxtAProducir.EditValue = obj.CantidadProducir
            txtNoDocumento.Text = obj.NoDocumento
            '
            'Cargar Devoluciones y Averias
            If DT_DEV.Rows.Count > 0 Then
                Dim dr() As DataRow = DT_DEV.Select("[Tipo Producto] = 1")
                If dr.Length > 0 Then
                    txtDevolucion.EditValue = CDbl(DT_DEV.Compute("SUM(Cantidad)", "[Tipo Producto] = 1"))
                End If
            End If
            '
            txtTotal.EditValue = TxtAProducir.EditValue + txtDevolucion.EditValue
        End If
    End Sub
    '
    Sub CargarCombos()
        SearchLookUp(cbFormula, db_Prod_CatMaestroFormula.Listar(0), "Descripción", "IdSysFormula", 0, 6, 7)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub

        obj.IdSysProduccion = IdProduccion
        obj.Empresa = EmpresaActual
        obj.FechaGeneraProduccion = dFecha.DateTime.Date
        obj.Observaciones2 = txtObservaciones.Text

        db.GenerarProduccion(obj)

        Ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class