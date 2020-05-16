Public Class frmEstadosOCAdd

    Public IdEstado As Integer = 0

    Dim obj As New ORDENES_COMPRAS_ESTADOS
    Dim db As New db_ORDENES_COMPRAS_ESTADOS

    Private Sub frmProformaEstados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmEstadosOCList.Cargar()
    End Sub

    Private Sub frmProformaEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        
        If IdEstado <> 0 Then
            obj = db_ORDENES_COMPRAS_ESTADOS.Detalles(IdEstado)

            txtNombre.Text = obj.Nombre
            chkFactura.Checked = IIf(obj.Facturada = 1, True, False)
            chkPendiente.Checked = IIf(obj.Pendiente = 1, True, False)
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        obj.IdEstado = IdEstado
        obj.Empresa = EmpresaActual
        obj.Nombre = txtNombre.Text
        obj.Facturada = IIf(chkFactura.Checked, 1, 0)
        obj.Pendiente = IIf(chkPendiente.Checked, 1, 0)

        If IdEstado = 0 Then db.Insertar(obj)
        If IdEstado <> 0 Then db.Actualizar(obj)

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class