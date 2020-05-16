Public Class frmProformaEstados

    Public _Codigo As Integer = 0
    'Public Pages As New DevExpress.XtraTab.XtraTabPage
    'Public ObjFormularioBusqueda As New Object
    'Public NombreMetodoFuncionBusqueda As String

    ' Private ObjEtiqueta As New EtiquetasCLS
    Private ObjEstados As New ProformaEstadoCLS

    Private Sub frmProformaEstados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '  RefrescarBusqueda()
        frmEstadosCotizacionesList.Cargar()
    End Sub

    Private Sub frmProformaEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
        '        
        If _Codigo > 0 Then
            ObjEstados.Load(_Codigo)

            txtNombre.Text = ObjEstados.Nombre
            chkFactura.Checked = ObjEstados.Facturada
            chkCaducada.Checked = ObjEstados.Caducada
            'cbEtiquetas.EditValue = ObjEstados.IdEtiqueta
        End If
    End Sub

    Sub CargarCombo()
        'ObjEtiqueta.FillCombo(cbEtiquetas, cbColor)
    End Sub

    'Public Sub RefrescarBusqueda()
    '    On Error Resume Next
    '    If Not NombreMetodoFuncionBusqueda = vbNullString Then CallByName(ObjFormularioBusqueda, NombreMetodoFuncionBusqueda, CallType.Method)
    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        ObjEstados.CodConsecutEstadoProforma = _Codigo
        ObjEstados.Nombre = txtNombre.Text
        ObjEstados.Facturada = chkFactura.Checked
        ObjEstados.Caducada = chkCaducada.Checked
        ' ObjEstados.IdEtiqueta = cbEtiquetas.EditValue

        If ObjEstados.Save() Then
            ObjEstados.Dispose()
            Close()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class