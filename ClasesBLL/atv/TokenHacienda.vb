Imports System.Net.Http

Public Class TokenHacienda

    Public Property accessToken As String
    Public Property refreshToken As String

    Public Sub GetTokenHacienda(usuario As String, password As String, IDP_URI As String, IDP_CLIENT_ID As String)
        Try
            accessToken = ""
            refreshToken = ""

            Dim http As HttpClient = New HttpClient
            Dim param = New List(Of KeyValuePair(Of String, String))()
            param.Add(New KeyValuePair(Of String, String)("client_id", IDP_CLIENT_ID))
            param.Add(New KeyValuePair(Of String, String)("grant_type", "password"))
            param.Add(New KeyValuePair(Of String, String)("username", usuario))
            param.Add(New KeyValuePair(Of String, String)("password", password))
            Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(param)

            Dim response As HttpResponseMessage = http.PostAsync(IDP_URI, content).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result
            Dim tk As Token = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Token)(res)
            If response.StatusCode <> Net.HttpStatusCode.OK Then
                Throw New Exception("Error: " + response.GetHashCode)
            End If

            accessToken = tk.access_token
            refreshToken = tk.refresh_token

        Catch ex As Exception
            XtraMsg("Error de Token: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

End Class
