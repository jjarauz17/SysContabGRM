Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ws_Zoho

    Public Function ws_Conexion() As DataTable

        Dim sURL As String = "http://97.74.229.192/cr/comprobar_test.php?clave_ver=50616041800310166317600100001010000000010100255039&cod_cliente=14"

        Dim wsGETURL As WebRequest
        wsGETURL = WebRequest.Create(sURL)


        Dim objStream As Stream = wsGETURL.GetResponse.GetResponseStream()
        Dim objReader As New StreamReader(objStream)

        Dim sLine As String = objReader.ReadToEnd()

        Dim DT As DataTable = ObtieneDatos("sp_facturaElectronica_request", sLine, EmpresaA)

        ' GetIcons(sLine)
        Dim Json As JObject = JObject.Parse(sLine)
        Dim data As List(Of JToken) = Json.Children().ToList
        Dim output As String = ""


        Dim myObject As JObject = JsonConvert.DeserializeObject(sLine)

        For Each Row In Json("Estado")

            Dim s1 As String = Row("Estado")
            Dim s2 As String = Row("Estado")
            Dim s3 As String = Row("Estado")
            Dim s4 As String = Row("Estado")
        Next



        'For Each Row In Json("")
        '    Dim s As String = Row("Estado")
        '    Dim m As String = Row("Mensaje")
        '    Dim x As String = Row("xml")
        '    Dim id As String = Row("id")
        '    ' //Row("messaging")
        'Next

        For Each item As JProperty In data

            item.CreateReader()

            output += "Estado:" + vbCrLf

            For Each comment As JValue In item.Values
                Dim e As String = comment.Item("Estado")
                Dim u As String = comment("Mensaje")
                Dim d As String = comment("xml")
                Dim c As String = comment("id")
                output += u + vbTab + d + vbTab + c + vbCrLf
            Next

            'Select Case item.Name
            '    Case "Estado"
            '        output += "Comments:" + vbCrLf
            '        For Each comment As JObject In item.Values
            '            Dim u As String = comment("Mensaje")
            '            Dim d As String = comment("xml")
            '            Dim c As String = comment("id")
            '            output += u + vbTab + d + vbTab + c + vbCrLf
            '        Next

            '    Case "messages"
            '        output += "Messages:" + vbCrLf
            '        For Each msg As JObject In item.Values
            '            Dim f As String = msg("from")
            '            Dim t As String = msg("to")
            '            Dim d As String = msg("date")
            '            Dim m As String = msg("message")
            '            Dim s As String = msg("status")
            '            output += f + vbTab + t + vbTab + d + vbTab + m + vbTab + s + vbCrLf
            '        Next

            'End Select

        Next

        Return DT



        'XtraMsg(sLine)
        'Dim i As Integer = 0
        'Do While Not sLine Is Nothing
        '    i += 1
        '    sLine = objReader.ReadLine
        '    If Not sLine Is Nothing Then
        '        XtraMsg("{0}:{1}", i, sLine)
        '    End If
        'Loop
        'Dim client = New System.Net.WebClient() )
        'Dim request = New System.Net.WebRequest("http://97.74.229.192/cr/comprobar_test.php?clave_ver=50616041800310166317600100001010000000010100255039&cod_cliente=14")
        'request.AddHeader("cache-control", "no-cache")
        'Dim response As IRestResponse = client.Execute(request)

    End Function

    Public Class clsIcons

        Public Name As String
        Public Surname As String
        Public Age As String
        Public Gender As String

    End Class


    Private Sub GetIcons(strJSON As String)

        Dim Icons = JsonConvert.DeserializeObject(Of List(Of
           clsIcons))(strJSON)

        For Each Legend In Icons

            'ListBox1.Items.Add(Legend.Name)
        Next
    End Sub


    'Public Shared Function ConvertToXElement(ByVal json As String, ByVal enc As Encoding) As XElement

    '    Dim data As Byte() = enc.GetBytes(json)

    '    Using ms As New MemoryStream(data)

    '        Using xmlReader As XmlDictionaryReader =
    '            JsonReaderWriterFactory.CreateJsonReader(ms, enc, New XmlDictionaryReaderQuotas, Nothing)

    '            Return XElement.Load(xmlReader)

    '        End Using

    '    End Using

    'End Function

    'Public Shared Function ConvertToXDocument(ByVal json As String, ByVal enc As Encoding) As XDocument

    '    Return New XDocument(ConvertToXElement(json, enc))

    'End Function


End Class
