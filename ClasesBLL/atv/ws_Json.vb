Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ws_Json

    Private Class clsIcons

        Public Estado As String
        Public Mensaje As String
        Public xml As String
        Public id As String

    End Class


    Public Sub GetIcons(strJSON As String)

        Dim Icons = JsonConvert.DeserializeObject(Of List(Of clsIcons))(strJSON)

        For Each Legend In Icons

            XtraMsg(Legend.Estado)
            XtraMsg(Legend.Mensaje)
            XtraMsg(Legend.xml)
            XtraMsg(Legend.id)

            'XtraMsg(Legend.Name)
            'ListBox1.Items.Add(Legend.Name)
        Next

    End Sub

    Public Function GetDatosJson() As DataTable

        Dim _DT As New DataTable("JsonResult")

        Try

            Dim json As String = GetJsonResult()

            Dim ser As JObject = JObject.Parse(json)
            Dim data As List(Of JToken) = ser.Children().ToList

            Dim Datos As New ArrayList

            For Each item As JProperty In data

                Dim cl As New DataColumn(item.Name)
                _DT.Columns.Add(cl)

                Datos.Add(item.Value)
            Next

            Dim dr As DataRow = _DT.NewRow()

            For i As Integer = 0 To Datos.Count - 1
                dr(i) = Datos(i).ToString
            Next

            _DT.Rows.Add(dr)


            Return _DT
        Catch ex As Exception
            XtraMsg(ex.Message, Windows.Forms.MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Public Function GetJsonResult() As String

        Dim sURL As String = "http://97.74.229.192/cr/comprobar_test.php?clave_ver=50616041800310166317600100001010000000010100255039&cod_cliente=14"

        Dim request As WebRequest = WebRequest.Create(sURL)
        request.Method = "POST"

        Dim objStream As Stream = request.GetRequestStream()

        Dim response As WebResponse = request.GetResponse()
        objStream = response.GetResponseStream()
        Dim reader As New StreamReader(objStream)

        Dim responseFromServer As String = reader.ReadToEnd()

        reader.Close()
        objStream.Close()
        response.Close()

        'Dim postData As String = "username=" & user & "&password=" & pass
        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        'request.ContentType = "application/x-www-form-urlencoded"
        'request.ContentLength = byteArray.Length
        'Dim objStream As Stream = request.GetRequestStream()
        'objStream.Write(byteArray, 0, byteArray.Length)
        'objStream.Close()
        'Dim objStream As Stream = wsGETURL.GetResponse.GetResponseStream()
        'Dim objReader As New StreamReader(objStream)
        'Dim sJson As String = objReader.ReadToEnd()

        Return responseFromServer
    End Function



End Class
