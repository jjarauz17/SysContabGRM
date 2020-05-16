Imports ClasesBLL
Imports Entities
Imports SysContab.VB.SysContab

Public Class frmMotivoRechazo

    Public Consecutivo As String = String.Empty
    Public Factura As String = String.Empty
    Public Tipo As Integer = 1
    Public ID As Integer = 0
    Dim _dt As New DataTable("Rechazado")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
    End Sub

    Private Sub frmMotivoRechazo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Dispose()
    End Sub

    Private Sub frmMotivoRechazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            _dt = VB.SysContab.Facturas_VentasDB.MensajeRechazo(
            Consecutivo,
            Factura)

            If _dt.Rows.Count > 0 Then
                mMotivo.Text = _dt.Rows.Item(0)("MensajeHacienda")
            End If
        ElseIf Tipo = 2 Then
            _dt = db_FacturasElectronicasAceptadas.Listar(
                ID,
                Now.Date,
                Now.Date)

            If _dt.Rows.Count > 0 Then
                mMotivo.Text = _dt.Rows.Item(0)("Respuesta")
            End If

        ElseIf Tipo = 3 Then
            _dt = ClientesDB.GetNotaDetalle(ID)

            If _dt.Rows.Count > 0 Then
                mMotivo.Text = _dt.Rows.Item(0)("MensajeHacienda")
            End If

        ElseIf Tipo = 4 Then
            Dim db As New db_FacturasElectronicasCompras()
            _dt = db.Listar(
                ID,
                Now.Date,
                Now.Date,
                EmpresaActual)

            If _dt.Rows.Count > 0 Then
                mMotivo.Text = _dt.Rows.Item(0)("Respuesta")
            End If
        End If



    End Sub
End Class