Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text

Public Class TokenZoho

    Public Property accessToken As String
    Public Property refreshToken As String

    Public Sub GetTokenZoho(Client_ID As String,
                            Client_Secret As String,
                            Redirect_Uri As String,
                            Code As String,
                            IDP_URI As String)

        accessToken = String.Empty
        refreshToken = String.Empty

        Try

            IDP_URI = "https://accounts.zoho.com/oauth/v2/token"
            Dim http As HttpClient = New HttpClient
            Dim param = New List(Of KeyValuePair(Of String, String))()
            param.Add(New KeyValuePair(Of String, String)("grant_type", "authorization_code"))
            param.Add(New KeyValuePair(Of String, String)("client_id", Client_ID))
            param.Add(New KeyValuePair(Of String, String)("client_secret", Client_Secret))
            ' param.Add(New KeyValuePair(Of String, String)("redirect_uri", Redirect_Uri))
            param.Add(New KeyValuePair(Of String, String)("code", Code))

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
            XtraMsg("Error de Token: " & vbCrLf &
                    ex.Message,
                    Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub GetToken()
        Dim Http As HttpClient = New HttpClient()

        Dim param = New List(Of KeyValuePair(Of String, String))()
        param.Add(New KeyValuePair(Of String, String)("grant_type", "authorization_code"))
        param.Add(New KeyValuePair(Of String, String)("client_id", "1000.BT8QS94IIA8278417LUKT1DE7XXBFH"))
        param.Add(New KeyValuePair(Of String, String)("client_secret", "e319f52223bc374d77c65ab410587593cf3ae7e20c"))
        ' param.Add(New KeyValuePair(Of String, String)("redirect_uri", "https://accounts.zoho.com/"))
        param.Add(New KeyValuePair(Of String, String)("redirect_uri", "https://zohoapis.zoho.com/"))
        param.Add(New KeyValuePair(Of String, String)("code", "1000.a1d089da47ebf86cec711b3a366334a4.7a896c155a662db56196688399751627"))

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(param)
        Dim response As HttpResponseMessage = Http.PostAsync("https://accounts.zoho.com/oauth/v2/token", content).Result
        Dim res As String = response.Content.ReadAsStringAsync.Result
        Dim tk As Token = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Token)(res)

        'If response.StatusCode <> Net.HttpStatusCode.OK Then
        '    Throw New Exception("Error: " + response.GetHashCode)
        'End If

        accessToken = tk.access_token
        refreshToken = tk.refresh_token

        GetLeads()
    End Sub

    Public Sub GetLeads()

        'Dim restClient As Library.Setup.RestClient.ZCRMRestClient = Library.Setup.RestClient.ZCRMRestClient.GetInstance
        'Dim response As BulkAPIResponse(Of Library.CRUD.ZCRMModule) = restClient.GetAllModules()
        'Dim modules As List(Of Library.CRUD.ZCRMModule) = response.BulkData






        'Dim Http As HttpClient = New HttpClient()
        'Http.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken)

        'Dim response As HttpResponseMessage = Http.GetAsync("https://www.zohoapis.com/crm/v2/Leads/" & "getRecords").Result
        'Dim res As String = response.Content.ReadAsStringAsync.Result
    End Sub


    'Private Function HTTP(URL As String,
    '                      data As String,
    '                      POST_GET As String) As String

    '    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12
    '    Dim myReq As HttpWebRequest
    '    Dim myResp As HttpWebResponse

    '    myReq = HttpWebRequest.Create(URL)
    '    myReq.Method = POST_GET
    '    myReq.ContentType = "application/json"
    '    myReq.Headers.Add("authorization", AuthToken)

    '    If data <> "" Then myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(data), 0, System.Text.Encoding.UTF8.GetBytes(data).Count)
    '    myResp = myReq.GetResponse
    '    Dim myreader As New System.IO.StreamReader(myResp.GetResponseStream)

    '    Dim Response As String = myreader.ReadToEnd

    '    Return Response

    'End Function


    Public Sub GetTokenConcecion(scope As String,
                                 Cliente_ID As String)

        Dim Http As HttpClient = New HttpClient()

        Dim param = New List(Of KeyValuePair(Of String, String))()
        param.Add(New KeyValuePair(Of String, String)("scope", scope))
        param.Add(New KeyValuePair(Of String, String)("client_id", Cliente_ID))
        param.Add(New KeyValuePair(Of String, String)("response_type", "code"))
        param.Add(New KeyValuePair(Of String, String)("access_type", "offline"))
        param.Add(New KeyValuePair(Of String, String)("redirect_uri", "https://www.getpostman.com/oauth2/callback"))

        Dim content As FormUrlEncodedContent = New FormUrlEncodedContent(param)
        Dim response As HttpResponseMessage = Http.PostAsync("https://accounts.zoho.com/oauth/v2/auth", content).Result
        Dim res As String = response.Content.ReadAsStringAsync.Result

        If response.StatusCode <> Net.HttpStatusCode.OK Then
            XtraMsg("Error: " + response.Headers.GetValues("X-Error-Cause")(0).ToString,
                    Windows.Forms.MessageBoxIcon.Error)
        End If

        'Dim PostContent As String = "scope=" + scope +
        '                     "&client_id=" + Cliente_ID +
        '                     "&response_type=code" +
        '                     "&access_type=offline" +
        '                     "&redirect_uri=https://www.getpostman.com/oauth2/callback"

        'Dim Url As String = "https://accounts.zoho.com/oauth/v2/auth?" + PostContent

        'Dim request As WebRequest = WebRequest.Create(Url)
        'request.Method = "POST"
        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(PostContent)
        'request.ContentType = "application/x-www-form-urlencoded"
        'request.ContentLength = byteArray.Length
        'Dim dataStream As Stream = request.GetRequestStream()
        'dataStream.Write(byteArray, 0, byteArray.Length)
        'dataStream.Close()
        'Dim response As WebResponse = request.GetResponse()
        'dataStream = response.GetResponseStream()
        'Dim reader As New StreamReader(dataStream)
        'Dim responseFromServer As String = reader.ReadToEnd()
        'reader.Close()
        'dataStream.Close()
        'response.Close()

        'XtraMsg(responseFromServer)


    End Sub

End Class
