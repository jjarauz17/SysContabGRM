Imports ClasesBLL
Imports Entities
Imports Newtonsoft.Json
Imports SysContab.VB.SysContab

Public Class frmMotivoRechazo

    Public Consecutivo As String = String.Empty
    Public Factura As String = String.Empty
    Public Tipo As Integer = 1
    Public TipoDocumento As String = "01"
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

            _dt = Facturas_VentasDB.MensajeRechazo(
                    Consecutivo,
                    Factura,
                    TipoDocumento)

            If _dt.Rows.Count > 0 Then

                If Consecutivo.Equals("aceptado") Then
                    Dim api As HaciendaGT.ResponseApi = JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))
                    '
                    Dim alertas_infile As String = "Alertas InFile Descripción: "
                    If api.alertas_infile Then
                        If api.descripcion_alertas_infile.Count > 0 Then
                            alertas_infile = $"{alertas_infile}{api.descripcion_alertas_infile(0).ToString}"
                        End If
                    End If
                    '
                    mMotivo.Text = $"Resultado: {IIf(api.resultado = True, "ACEPTADO", "RECHAZADO")}" & vbCrLf &
                        $"Número: {api.numero}" & vbCrLf &
                        $"uuid: {api.uuid}" & vbCrLf &
                        $"Serie: {api.serie}" & vbCrLf &
                        $"Fecha: {api.fecha}" & vbCrLf &
                        $"Mensaje: {api.descripcion}" & vbCrLf &
                        $"Saldo: {api.control_emision.Saldo}" & vbCrLf &
                        $"Creditos: {api.control_emision.Creditos}" & vbCrLf &
                        $"{alertas_infile}" & vbCrLf &
                        $"Iformacion Adicional: {api.informacion_adicional}{vbCrLf}{vbCrLf}Link:{vbCrLf}" &
                        $"{_dt.Rows.Item(0)("Link")}{api.uuid}"

                    Me.Text = "MENSAJE DE HACIENDA"
                    Me.LayoutControlItem1.Text = "Mensaje de Hacienda"

                ElseIf Consecutivo.Equals("rechazado") Then
                    Dim api As HaciendaGT.ResponseApi = JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))
                    '
                    Dim sErrores As String = String.Empty

                    For i As Integer = 0 To api.descripcion_errores.Count - 1
                        sErrores = sErrores + $"Error No: {(i + 1).ToString()}" & vbCrLf &
                            $"Categoria: {api.descripcion_errores(i).categoria}" & vbCrLf &
                            $"Mensaje de Error: {api.descripcion_errores(i).mensaje_error}" & vbCrLf & vbCrLf
                    Next

                    mMotivo.Text = $"Resultado: {IIf(api.resultado = True, "ACEPTADO", "RECHAZADO")}" & vbCrLf &
                        $"Fecha: {api.fecha}" & vbCrLf &
                        $"Mensaje: {api.descripcion}" & vbCrLf &
                        $"Cantidad de Errores: {api.cantidad_errores.ToString()}" & vbCrLf &
                        "Descripción de Errores:" & vbCrLf & vbCrLf &
                        sErrores
                ElseIf Consecutivo.Equals("anulado") Then
                    Dim api As HaciendaGT.ResponseApi = JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))
                    '
                    Dim alertas_infile As String = "Alertas InFile Descripción: "
                    If api.alertas_infile Then
                        If api.descripcion_alertas_infile.Count > 0 Then
                            alertas_infile = $"{alertas_infile}{api.descripcion_alertas_infile(0).ToString}"
                        End If
                    End If
                    '
                    mMotivo.Text = $"Resultado: {IIf(api.resultado = True, "ACEPTADO", "RECHAZADO")}" & vbCrLf &
                        $"Número: {api.numero}" & vbCrLf &
                        $"uuid: {api.uuid}" & vbCrLf &
                        $"Serie: {api.serie}" & vbCrLf &
                        $"Fecha: {api.fecha}" & vbCrLf &
                        $"Mensaje: {api.descripcion}" & vbCrLf &
                        $"Saldo: {api.control_emision.Saldo}" & vbCrLf &
                        $"Creditos: {api.control_emision.Creditos}" & vbCrLf &
                        $"{alertas_infile}" & vbCrLf &
                        $"Iformacion Adicional: {api.informacion_adicional}{vbCrLf}{vbCrLf}Link:{vbCrLf}" &
                        $"{_dt.Rows.Item(0)("Link")}{api.uuid}"

                    Me.Text = "MENSAJE DE HACIENDA"
                    Me.LayoutControlItem1.Text = "Mensaje de Hacienda"
                Else
                    mMotivo.Text = _dt.Rows.Item(0)("MensajeHacienda")
                End If

                '$"No. Aprobado: {FE.responseApi.numero}" & vbCrLf &
                '            $"Mensaje: {FE.responseApi.descripcion}" & vbCrLf &
                '            $"Saldo: {FE.responseApi.control_emision.Saldo.ToString("n2")}" & vbCrLf &
                '            $"Creditos: {FE.responseApi.control_emision.Creditos.ToString("n2")}")

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