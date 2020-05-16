Public Class cl_Red

    Public Function EstadoTarjetaRed() As Boolean
        Return My.Computer.Network.IsAvailable
    End Function

    Public Function BuscarEquipoenRed(ByVal NombreEquipo As String) As Boolean
        Dim RetVal As Boolean = False
        Try

            If My.Computer.Network.Ping(NombreEquipo) Then
                RetVal = True
            End If

            Return RetVal
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub EstadoTarjeta()
        'With frmMDIMain
        '    If EstadoTarjetaRed() Then
        '        .bConnect.Appearance.ForeColor = Color.Black
        '        .bConnect.Caption = "Conectado a la Red"
        '        ' .bConnect.Glyph = My.Resources.connect_established
        '    Else
        '        .bConnect.Appearance.ForeColor = Color.Red
        '        .bConnect.Caption = "Sin Conexion de Red"
        '        ' .bConnect.Glyph = My.Resources.connect_no
        '    End If
        'End With
    End Sub

    Public Sub EstadoTarjetaLogin()
        'With FrmLogin2008
        '    If EstadoTarjetaRed() Then
        '        .bConnect.Caption = "Conectado a la Red"
        '        .bConnect.ImageIndex = 1
        '        .bConnect.Appearance.ForeColor = Color.Black
        '    Else
        '        .bConnect.Caption = "Sin Conexion de Red"
        '        .bConnect.ImageIndex = 0
        '        .bConnect.Appearance.ForeColor = Color.Red
        '    End If
        'End With
    End Sub
End Class
