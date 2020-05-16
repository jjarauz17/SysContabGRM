Imports System.Net.Http
Imports System.Xml
Imports ClasesBLL
Imports Newtonsoft.Json.Linq
Imports Connectivity
Imports System.Net
Imports System.Text
Imports System.IO

Public Class frmZohoConeccion

    Dim obj As New ZohoToken
    Dim db As New db_ZohoToken

    Private Sub frmZohoConeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        'Dim sRequest As String = ws_Zoho.ws_Conexion()
        'XtraMsg(sRequest)

        Dim ws As New ws_Zoho()

        iGrid.DataSource = ws.ws_Conexion()
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        Dim sXml As String = iVista.GetRowCellValue(2, "Data")
        'sXml = Replace(sXml, "xml": "","")

        Dim objElement As XmlDocument = New XmlDocument()
        objElement.LoadXml(sXml)

        Dim xmlNodLista As XmlNodeList
        Dim dt As New DataTable

        'CONSUMIMOS EL SERVICIO
        xmlNodLista = objElement.GetElementsByTagName("FacturaElectronica")

        'AGREGAMOS LAS COLUMNAS AL DATATABLE 
        For Each Node As XmlNode In xmlNodLista.Item(0).ChildNodes
            Dim Col As New DataColumn(Node.Name, System.Type.GetType("System.String"))
            Try
                dt.Columns.Add(Col)
            Catch ex As Exception
            End Try

        Next

        'AGREGAR LA INFORMACION AL DATATABLE 
        For IntVal As Integer = 0 To xmlNodLista.Count - 1
            Dim dr As DataRow = dt.NewRow
            For Col As Integer = 0 To dt.Columns.Count - 1
                Try
                    If Not IsDBNull(xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText) Then
                        dr(Col) = xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText
                    Else
                        dr(Col) = Nothing
                    End If
                Catch ex As Exception
                End Try

            Next
            dt.Rows.Add(dr)
        Next
        '
        GridControl1.DataSource = dt
        GridView1.PopulateColumns()
        FormatoGrid(GridView1)

        'Split(sRequest, ",",)

        'Dim postContent As String = "scope=crmapi"
        'postContent = "&authtoken=b1a1c8aedea06a5e1e093c6bda9f7e85&" + postContent

        ''Dim msg As String = ZohoCRMAPI.AccessCRM("https://crm.zoho.com/crm/private/xml/Leads/getRecords?", postContent)
        ''XtraMsg(msg)

        'Dim url As String = "https://crm.zoho.com/crm/private/json/Accounts/getRecords?newFormat=1&authtoken=b1a1c8aedea06a5e1e093c6bda9f7e85&scope=crmapi&fromIndex=20&toIndex=200&sortColumnString=AccountName&sortOrderString=desc"

        ''Dim msg As String = ZohoCRMAPI.AccessCRM("https://crm.zoho.com/crm/private/xml/Leads/getRecords?" + postContent + "&selectColumns=Leads(First Name,Last Name,Email,Company,Campaign Source)&version=1", postContent)
        ''XtraMsg(msg)

        'Dim msg As String = ZohoCRMAPI.AccessCRM(url, postContent)
        'XtraMsg(msg)



        ''Dim result As String = ZohoCRMAPI.APIMethod("Leads", "getRecords", "636392978")
        ''XtraMsg(result)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Dim ws As New ws_Json

        Try
            Dim DT As DataTable = ws.GetDatosJson()

            iGrid.DataSource = DT
            iVista.PopulateColumns()
            FormatoGrid(iVista)
            '
            MostrarXML()
        Catch ex As Exception
            XtraMsg("Error: " & ex.ToString(), MessageBoxIcon.Error)
        End Try

    End Sub

    Sub MostrarXML()

        Dim sXml As String = iVista.GetRowCellValue(0, "xml")

        Dim objElement As XmlDocument = New XmlDocument()
        objElement.LoadXml(sXml)

        Dim xmlNodLista As XmlNodeList
        Dim dt As New DataTable

        'CONSUMIMOS EL SERVICIO
        xmlNodLista = objElement.GetElementsByTagName("FacturaElectronica")

        'AGREGAMOS LAS COLUMNAS AL DATATABLE 
        For Each Node As XmlNode In xmlNodLista.Item(0).ChildNodes

            Dim Col As New DataColumn(Node.Name, System.Type.GetType("System.String"))
            Try
                dt.Columns.Add(Col)
            Catch ex As Exception
            End Try

        Next

        'AGREGAR LA INFORMACION AL DATATABLE 
        For IntVal As Integer = 0 To xmlNodLista.Count - 1
            Dim dr As DataRow = dt.NewRow
            For Col As Integer = 0 To dt.Columns.Count - 1
                Try
                    If Not IsDBNull(xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText) Then
                        dr(Col) = xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText
                    Else
                        dr(Col) = Nothing
                    End If
                Catch ex As Exception
                End Try

            Next
            dt.Rows.Add(dr)
        Next
        '
        GridControl1.DataSource = dt
        GridView1.PopulateColumns()
        FormatoGrid(GridView1)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        'obj = db_ZohoToken.Detalles("api-modules")

        'Dim iToken As New ZohoApi.Token
        'iToken.GetToken()

        'Dim zApi As New ApiDatos
        ''zApi.GetModulos()
        ''zApi.GetLeads()


        ''Dim iToken As New TokenZoho
        ''iToken.GetLeads()

        ''iToken.GetTokenConcecion("ZohoCRM.modules.all",
        ''                         obj.Client_ID)


        'ZohoOAuthClient.Initialize()
        ''ZCRMRestClient.Initialize(Dictionary.config)
        'ZCRMRestClient.Initialize(Nothing)
        'Dim client As ZohoOAuthClient = ZohoOAuthClient.GetInstance()

        ''Dim param As ZohoOAuthParams = New ZohoOAuthParams()
        ''param.ClientId = "1000.BT8QS94IIA8278417LUKT1DE7XXBFH"
        ''param.ClientSecret = "e319f52223bc374d77c65ab410587593cf3ae7e20c"
        ''param.RedirectURL = "https://zohoapis.zoho.com/"
        ''param.AccessType = "code"
        ''param.Scopes = "ZohoCRM.modules.all"

        'Dim grantToken As String = "1000.a25f043b256bcdcab5804a0cec61c684.ba747fb495a81327a9d78b0e2a1d052f"

        'Try
        '    Dim conn As Object = client.GetZohoConnector(ZohoOAuth.GetTokenURL())
        '    conn.AddParam("grant_type", "authorization_code")
        '    conn.AddParam("code", grantToken)
        '    Dim Response As String = conn.Post()

        '    Dim responseJSON As JObject = JObject.Parse(Response)
        '    Dim oString As StringContent = New StringContent(responseJSON.ToString)


        '    Dim na = Nothing

        '    'If (responseJSON.ContainsKey("access_token")) Then


        '    'End If

        '    'If (responseJSON.ContainsKey(ZohoOAuthConstants.ACCESS_TOKEN)) Then
        '    '                    {
        '    '        ZohoOAuthTokens Tokens = client.GetTokensFromJSON(responseJSON);
        '    '        Tokens.UserMaiilId = client.GetUserMailId(Tokens.AccessToken);
        '    '        ZohoOAuth.GetPersistenceHandlerInstance().SaveOAuthTokens(Tokens);

        '    '        String accessToken = Tokens.AccessToken;
        '    '        String refreshToken = Tokens.RefreshToken;
        '    '        //return tokens;
        '    '    }


        'Catch ex As Exception

        'End Try




    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        'ZCRMRestClient.Initialize(Dictionary.config)
        'Dim client As ZohoOAuthClient = ZohoOAuthClient.GetInstance()
        'Dim grantToken As String = "1000.831f7743f0dbb78a9c8efb4e88d4589c.a39c591d6a53a81a09cf349ed500d5b3"

        'Dim iToken As New ZohoOAuthTokens
        'iToken = client.GenerateAccessToken(grantToken)

        'XtraMsg("Acces Token: " & iToken.AccessToken & vbCrLf &
        '        '"Refress Token: " & iToken.RefreshToken)

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        'ZCRMRestClient.Initialize(Dictionary.config)
        'Dim client As ZohoOAuthClient = ZohoOAuthClient.GetInstance()

        'Dim iToken As New ZohoOAuthTokens
        'Dim grantoken As String = client.GenerarGranToken()

        Dim Urlgrantoken As String = "https://accounts.zoho.com/oauth/v2/auth?" +
                "scope=ZohoCRM.modules.all&" +
                   "client_id=1000.BT8QS94IIA8278417LUKT1DE7XXBFH&" +
                   "response_type=code&" +
                   "access_type=offline&" +
                   "redirect_uri=https://www.google.com/"

        Process.Start(Urlgrantoken)

        'Exit Sub

        Dim http As HttpClient = New HttpClient
        Dim msgHacienda As String = ""

        http.DefaultRequestHeaders.Add("authorization", "Basic Auth")
        http.DefaultRequestHeaders.Add("Username", "axel.irias@grupoequipsa.net")
        http.DefaultRequestHeaders.Add("Passw0rd", "magi0602")

        Dim response As HttpResponseMessage = http.GetAsync(Urlgrantoken).Result
        Dim res As String = response.Content.ReadAsStringAsync.Result



        Try
            Dim Url As String = "https://accounts.zoho.com/oauth/v2/auth?" +
                "scope=ZohoCRM.modules.all&" +
                   "client_id=1000.BT8QS94IIA8278417LUKT1DE7XXBFH&" +
                   "response_type=code&" +
                   "access_type=offline&" +
                   "redirect_uri=https://www.google.com/"

            Dim postData As String = "scope=ZohoCRM.modules.all&" +
                   "client_id=1000.BT8QS94IIA8278417LUKT1DE7XXBFH&" +
                   "response_type=code&" +
                   "access_type=offline&" +
                   "redirect_uri=https://www.google.com/"


            Dim request As HttpWebRequest = CType(WebRequest.Create(Url), HttpWebRequest)
            request.UserAgent = "Mozilla/5.0"
            'request.Headers("bEAR") = Headers.HttpRequestHeaders
            'Dim data = Encoding.UTF8.GetBytes(postData)

            'request.ContentType = "application/x-www-form-urlencoded"
            'request.ContentLength = data.Length
            'request.Method = "GET"

            'Dim dataStream As Stream = request.GetRequestStream()
            'dataStream.Write(data, 0, data.Length)

            'Dim response = CType(request.GetResponse(), HttpWebResponse)
            'Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()

            'XtraMsg(responseString)



            ''ServicePointManager.ServerCertificateValidationCallback = ValidateRemoteCertificate;
            'Dim request As WebRequest = WebRequest.Create(Uri)
            'request.Method = "POST"
            'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postContent)
            'request.ContentType = "application/x-www-form-urlencoded"
            'request.ContentLength = byteArray.Length
            'Dim dataStream As Stream = request.GetRequestStream()
            'dataStream.Write(byteArray, 0, byteArray.Length)
            'dataStream.Close()
            'Dim Response As WebResponse = request.GetResponse()
            'dataStream = Response.GetResponseStream()
            'Dim reader As StreamReader = New StreamReader(dataStream)
            'Dim responseFromServer As String = reader.ReadToEnd()
            'reader.Close()
            'dataStream.Close()
            'Response.Close()

            'XtraMsg(responseFromServer)
        Catch ex As Exception
            XtraMsg(ex.Message,
                    MessageBoxIcon.Error)
        End Try

    End Sub
End Class