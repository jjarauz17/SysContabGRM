Public Class ConeccionRecibos

    Function Conexion() As String
        Dim StrCnn As String = vbNullString
        Dim s As String() = LeeData()

        StrCnn = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", s(0), s(1), s(2), s(3))

        Return StrCnn
    End Function

    Sub EscribeData(ByVal Servidor As String, ByVal Base As String, _
                           ByVal Usuario_SQL As String, ByVal Password_SQL As String)

        Try
            SaveSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NServidor", Trim(Servidor))
            SaveSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NData", Trim(Base))
            SaveSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NUser", Trim(Usuario_SQL))
            SaveSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NClave", Trim(Password_SQL))
        Catch ex As Exception
            XtraMsg("Error al Guardar en el registro de windows, favor consultar con el area de Soporte Tecnico." & vbCrLf & _
                    "Detalle del Error: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Function LeeData() As String()

        Dim Cadena(4) As String
        '
        Try
            ''SQL
            Cadena(0) = GetSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NServidor")
            Cadena(1) = GetSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NData")
            Cadena(2) = GetSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NUser")
            Cadena(3) = GetSetting(My.Application.Info.ProductName.ToString, "sStrSQL", "NClave")

            '' No se Encuentra la Confiuración, se agrega la configuracion registrada por defecto
            If Cadena(0).Trim.Length = 0 Then
                Cadena(0) = ""
                Cadena(1) = ""
                Cadena(2) = ""
                Cadena(3) = ""
            End If
        Catch ex As Exception
            Cadena(0) = ""
            Cadena(1) = ""
            Cadena(2) = ""
            Cadena(3) = ""
        End Try

        Return Cadena
    End Function

End Class
