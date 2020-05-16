Public Class IDP_FacturaElectronicaToken

    Inherits ClComun
    Dim vFacturaElectronicaTabla As New IDP_FacturaElectronica

    Public Property FacturaElectronicaTabla() As IDP_FacturaElectronica
        Get
            Return vFacturaElectronicaTabla
        End Get
        Set(ByVal value As IDP_FacturaElectronica)
            vFacturaElectronicaTabla = value
        End Set
    End Property

    Public Shared Function Detalles() As IDP_FacturaElectronica

        Dim _dt As DataTable = ObtieneDatos("sp_ATV_accesos", EmpresaA)
        Dim detalle As New IDP_FacturaElectronica

        If _dt.Rows.Count > 0 Then
            With _dt.Rows(0)
                detalle.IDP_URI = .Item("TokenUrl")
                detalle.APIUrl = .Item("ApiUrl")
                detalle.FirmaUrl = .Item("FirmaUrl")
                detalle.UrlFacturaElectronica = .Item("UrlFacturaElectronica")
                detalle.IDP_CLIENT_ID = .Item("Cliente_ID")
                detalle.Usuario = .Item("Usuario")
                detalle.Password = .Item("Password")
                detalle.PIN = .Item("PIN")
                detalle.DirectorioATV = .Item("Directorio")
                detalle.RutaCertificado = .Item("RutaCertificado")
            End With
        End If

        Return detalle

    End Function

End Class
