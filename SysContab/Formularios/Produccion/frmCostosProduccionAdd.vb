Public Class frmCostosProduccionAdd

    Dim obj As New Prod_CatCostosProduccion
    Dim db As New db_Prod_CatCostosProduccion

    Public ID As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmResponsablesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmCostosProduccion.Cargar()
    End Sub

    Private Sub frmResponsablesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Combo(cbTipoCosto, db_Prod_TipoCostos.Listar(0))

        If ID <> 0 Then
            obj = db_Prod_CatCostosProduccion.Detalles(ID)

            If Not obj Is Nothing Then
                cbTipoCosto.EditValue = obj.CodConsecutTipoCosto
                txtNombre.Text = obj.NombreCosto
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '

        obj.CodConsecutCatCosto = ID
        obj.CodConsecutTipoCosto = cbTipoCosto.EditValue
        obj.Empresa = EmpresaActual
        obj.NombreCosto = txtNombre.Text

        If ID = 0 Then
            db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
        End If

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class