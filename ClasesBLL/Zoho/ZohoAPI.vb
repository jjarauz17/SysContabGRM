Imports System
Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text

Public Class ZohoCRMAPI

    Public Shared zohocrmurl As String = "https://crm.zoho.com/crm/private/xml/"
    'Private UrlBase As String = "https://accounts.zoho.com/oauth/v2/auth"

    Public Shared Sub Main(args As String())
        'Change the id,method name, and module name here
        Dim result As String = APIMethod("Leads", "getRecords", "508020000000332001")
        Console.Write(result)
    End Sub

    Public Shared Function APIMethod(modulename As String, methodname As String, recordId As String) As String
        Dim uri As String = zohocrmurl + modulename & "/" & methodname & "?"
        'Append your parameters here
        Dim postContent As String = "scope=crmapi"
        'Give your authtoken
        postContent = postContent & "&authtoken=b1a1c8aedea06a5e1e093c6bda9f7e85"

        If (methodname.Equals("insertRecords") OrElse methodname.Equals("updateRecords")) Then
            postContent = postContent & "&xmlData=" & HttpUtility.UrlEncode("Your CompanyHannahSmithtesting@testing.com")
        End If

        If (methodname.Equals("updateRecords") OrElse methodname.Equals("deleteRecords") OrElse methodname.Equals("getRecordById")) Then
            postContent = postContent & "&id=" & recordId
        End If

        Dim result As String = AccessCRM(uri, postContent)
        Return result

    End Function

    Public Shared Function AccessCRM(url As String, postcontent As String) As String
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postcontent)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = ByteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()
        Return responseFromServer

    End Function

End Class
