Imports ClasesBLL
Imports ZohoApi
Imports ZohoApi.DictionaryData

Public Class frmZohoConnect

    Dim obj As New ZohoToken

    Private Sub frmZohoConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj = db_ZohoToken.Detalles("api-modules")

        txtClientID.Text = obj.Client_ID
        txtClientSecret.Text = obj.Client_Secret

        LookUp(
            cbModulos,
            ObtieneDatos("sp_ZohoModules", 0),
            "Nombre",
            "Codigo",
            "[Seleccione Modulo]",
            1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbModulos.EditValue Is Nothing Then
            XtraMsg("Seleccione el modulo al que desa tener acceso")
            cbModulos.Focus()
            Exit Sub
        End If
        '
        Dim Urlgrantoken As String = obj.Url_AuthToken + "?" +
                "scope=ZohoCRM." + cbModulos.EditValue + "&" +
                   "client_id=" + obj.Client_ID + "&" +
                   "response_type=code&" +
                   "access_type=offline&" +
                   "redirect_uri=" + obj.Redirect_Uri

        Process.Start(Urlgrantoken)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txtGranToken.ForeColor = Color.DeepSkyBlue Then
            XtraMsg("Debe copiar el codigo generado en su navegador de internet para continuar...")
            txtGranToken.Focus()
            Exit Sub
        End If
        '
        If txtGranToken.Text.Trim.Length = 0 Then
            XtraMsg("Seleccione Gran Token!")
            txtGranToken.Focus()
            Exit Sub
        End If
        '
        ZCRMRestClient.Initialize(Dictionary.config)
        Dim client As ZohoOAuthClient = ZohoOAuthClient.GetInstance()

        Dim iToken As ZohoOAuthTokens = client.GenerateAccessToken(txtGranToken.Text)
        XtraMsg("Access Token: " + iToken.AccessToken + vbCrLf +
                "Refress Token: " + IsNull(iToken.RefreshToken, "null"))







        'Dim modulo As ZCRMModule = ZCRMModule.GetInstance("Leads")
        'Dim response As BulkAPIResponse(Of ZCRMRecord) =
        '    modulo.SearchByCriteria("((Last_Name:starts_with:B) or (Email:equals:burns.mary@xyz.com))")
        'Dim records As List(Of ZCRMRecord) = response.BulkData  'To get response List of ZCRMRecord.

        'records.Item(0).Participants

    End Sub

    Private Sub txtGranToken_EditValueChanged(sender As Object, e As EventArgs) Handles txtGranToken.EditValueChanged

    End Sub

    Private Sub txtGranToken_Enter(sender As Object, e As EventArgs) Handles txtGranToken.Enter
        txtGranToken.Text = String.Empty
        txtGranToken.ForeColor = Color.OrangeRed
    End Sub
    Private Sub txtGranToken_LostFocus(sender As Object, e As EventArgs) Handles txtGranToken.LostFocus
        If txtGranToken.Text.Trim.Length = 0 Then
            txtGranToken.Text = "Copie el codigo de su navegador y peguelo aqui..."
            txtGranToken.ForeColor = Color.DeepSkyBlue
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim GetDatos As New ApiDatos()
        Dim lista As List(Of ZCRMUser) = GetDatos.GetUser()
    End Sub
End Class