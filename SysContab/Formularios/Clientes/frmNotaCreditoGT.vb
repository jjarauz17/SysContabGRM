Imports HaciendaGT
Imports Newtonsoft.Json

Public Class frmNotaCreditoGT

    Private _IdNota As Integer
    Public Property IdNota() As Integer
        Get
            Return _IdNota
        End Get
        Set(ByVal value As Integer)
            _IdNota = value
        End Set
    End Property

    Private _NoNota As String
    Public Property NoNota() As String
        Get
            Return _NoNota
        End Get
        Set(ByVal value As String)
            _NoNota = value
        End Set
    End Property

    Private _RespuestaHacienda As String
    Public Property RespuestaHacienda() As String
        Get
            Return _RespuestaHacienda
        End Get
        Set(ByVal value As String)
            _RespuestaHacienda = value
        End Set
    End Property

    Public Ok As Boolean = False,
        Api As ResponseApi

    Private Sub frmFacturaAnulacionGT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        FechaNota.DateTime = VB.SysContab.Rutinas.Fecha().Date
        '
        Api = JsonConvert.DeserializeObject(Of HaciendaGT.ResponseApi)(RespuestaHacienda)
        '
        Fecha.DateTime = Api.fecha
        txtAutorizado.Text = Api.uuid
        txtDocumento.Text = Api.numero
        txtSerie.Text = Api.serie
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        Dim FE As Comunicacion = New Comunicacion()

        ShowSplash("Enviando Xml...")
        '
        FE.EnvioDatosNotas(
            IdNota,
            "03",
            Api,
            Motivo.Text,
            EmpresaActual)
        '
        HideSplash()
        '
        If Not FE.iError.Equals("Ok") Then
            XtraMsg(FE.iError, MessageBoxIcon.Error)
            Ok = False
            Close()
        Else
            If FE.responseApi.resultado Then
                Try
                    XtraMsg($"La N/C {NoNota} ha sido aceptada!" & vbCrLf &
                            $"No. Aprobado: {FE.responseApi.numero}" & vbCrLf &
                            $"Mensaje: {FE.responseApi.descripcion}" & vbCrLf &
                            $"Saldo: {FE.responseApi.control_emision.Saldo}" & vbCrLf &
                            $"Creditos: {FE.responseApi.control_emision}" & vbCrLf &
                             $"{IIf(FE.responseApi.alertas_infile, $"Descripción: {FE.responseApi.descripcion_alertas_infile(0).ToString}", String.Empty)}")
                Catch ex As Exception
                    XtraMsg($"La N/C {NoNota} ha sido aceptada!" & vbCrLf &
                            $"No. Aprobado: {FE.responseApi.numero}" & vbCrLf &
                            $"Mensaje: {FE.responseApi.descripcion}" & vbCrLf &
                            $"Saldo: {FE.responseApi.control_emision.Saldo}" & vbCrLf &
                            $"Creditos: {FE.responseApi.control_emision}")
                End Try

                Ok = True
                Close()
            Else
                With New frmMotivoRechazo
                    .Consecutivo = "rechazado"
                    .Factura = NoNota
                    .TipoDocumento = "03"
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