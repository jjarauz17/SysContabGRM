Imports Newtonsoft.Json

Public Class frmFacturaAnulacionGT

    Public Ok As Boolean = False
    Private Sub frmFacturaAnulacionGT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        FechaAnula.DateTime = VB.SysContab.Rutinas.Fecha().Date
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        Dim FE As HaciendaGT.Comunicacion = New HaciendaGT.Comunicacion()

        Dim _dt As DataTable =
            VB.SysContab.Facturas_VentasDB.MensajeRechazo(
            "aceptado",
            Factura.Text)

        Dim api As HaciendaGT.ResponseApi =
            JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(_dt.Rows.Item(0)("MensajeHacienda"))

        ShowSplash("Enviando Xml...")
        FE.EnvioDatosAnula(
            Factura.Text,
            "02",
            api.uuid,
            Motivo.Text,
            ObtieneDatos("sp_sel_FacturaElectronicaAnulacion", Factura.Text, FechaAnula.DateTime.Date, EmpresaActual),
            EmpresaActual)
        HideSplash()
        '
        If Not FE.iError.Equals("Ok") Then
            XtraMsg(FE.iError, MessageBoxIcon.Error)
            Ok = False
            Close()
        Else
            If FE.responseApi.resultado Then

                XtraMsg($"La Factura {Factura.Text} ha sido aceptada!" & vbCrLf &
                            $"No. Aprobado: {FE.responseApi.numero}" & vbCrLf &
                            $"Mensaje: {FE.responseApi.descripcion}" & vbCrLf &
                            $"Saldo: {FE.responseApi.control_emision.Saldo.ToString("n2")}" & vbCrLf &
                            $"Creditos: {FE.responseApi.control_emision.Creditos.ToString("n2")}" & vbCrLf &
                            $"{IIf(FE.responseApi.alertas_infile, $"Descripción: {FE.responseApi.descripcion_alertas_infile(0).ToString}", String.Empty)}")
                Ok = True
                Close()
            Else
                With New frmMotivoRechazo
                    .Consecutivo = "rechazado"
                    .Factura = Factura.Text
                    .ShowDialog()
                    .Dispose()
                End With
            End If

        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles Cliente.EditValueChanged

    End Sub
End Class