Imports Plugin.Connectivity
Imports System.Threading.Tasks

Public Class CheckConexion

    Public Async Function CheckConnection() As Task(Of Response)
        Dim response As New Response

        'Verificar configuracion a Internet
        If Not CrossConnectivity.Current.IsConnected Then
            response.IsSuccess = False
            response.Mensaje = "Verificar configuración de Internet..."

            Return response
        End If
        'Verificar Conexion a Internet
        Dim isReachable As Object = Await CrossConnectivity.Current.IsRemoteReachable("google.com")

        If Not isReachable Then
            response.IsSuccess = False
            response.Mensaje = "Verificar la Conexión a Internet..."

            Return response
        End If
        '
        response.IsSuccess = True
        response.Mensaje = "Ok"

        Return response

    End Function



End Class
