Public Class frmExoneraIVA

    Dim obj As New Clientes_Exoneraciones
    Dim db As New db_Clientes_Exoneraciones

    Public IdExonera As Integer = 0
    Public IdCliente As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmExoneraIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        If IdExonera <> 0 Then
            obj = db_Clientes_Exoneraciones.Detalles(IdExonera)

            If Not obj Is Nothing Then
                Dim ClienteDetalle As New VB.SysContab.ClientesDetails
                ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(obj.IdCliente)

                IdCliente = ClienteDetalle.Codigo
                txtCliente.Text = ClienteDetalle.Nombre
                txtFactura.Text = obj.Factura
                txtReferencia.Text = obj.Referencia
                mComentario.Text = obj.Comentarios
            End If
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        If db_Clientes_Exoneraciones.Validar(txtFactura.Text).Rows.Count > 0 Then
            XtraMsg($"El Número de Factura: {txtFactura.Text} Ya se le aplicó Exoneración de IVA, Favor consultar informe de Exoneración", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        obj.IdExonera = IdExonera
        obj.Empresa = EmpresaActual
        obj.IdCliente = IdCliente
        obj.Factura = txtFactura.Text
        obj.Referencia = txtReferencia.Text
        obj.Comentarios = mComentario.Text

        If IdExonera = 0 Then
            db.Insertar(obj)           
        Else
            db.Actualizar(obj)            
        End If

        Ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class