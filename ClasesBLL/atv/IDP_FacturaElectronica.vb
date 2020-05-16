Public Class IDP_FacturaElectronica

    Dim vIDP_URI As String

    Public Property IDP_URI() As String
        Get
            Return vIDP_URI
        End Get
        Set(ByVal value As String)
            vIDP_URI = value
        End Set
    End Property

    Dim vAPIUrl As String

    Public Property APIUrl() As String
        Get
            Return vAPIUrl
        End Get
        Set(ByVal value As String)
            vAPIUrl = value
        End Set
    End Property


    Dim vIDP_CLIENT_ID As String

    Public Property IDP_CLIENT_ID() As String
        Get
            Return vIDP_CLIENT_ID
        End Get
        Set(ByVal value As String)
            vIDP_CLIENT_ID = value
        End Set
    End Property

    Dim vUsuario As String

    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal value As String)
            vUsuario = value
        End Set
    End Property

    Dim vPassword As String

    Public Property Password() As String
        Get
            Return vPassword
        End Get
        Set(ByVal value As String)
            vPassword = value
        End Set
    End Property

    Dim vFirmaUrl As String

    Public Property FirmaUrl() As String
        Get
            Return vFirmaUrl
        End Get
        Set(ByVal value As String)
            vFirmaUrl = value
        End Set
    End Property

    Dim vPIN As String

    Public Property PIN() As String
        Get
            Return vPIN
        End Get
        Set(ByVal value As String)
            vPIN = value
        End Set
    End Property

    Dim vDirectorioATV As String

    Public Property DirectorioATV() As String
        Get
            Return vDirectorioATV
        End Get
        Set(ByVal value As String)
            vDirectorioATV = value
        End Set
    End Property


    Dim vRutaCertificado As String

    Public Property RutaCertificado() As String
        Get
            Return vRutaCertificado
        End Get
        Set(ByVal value As String)
            vRutaCertificado = value
        End Set
    End Property

    Dim vUrlFacturaElectronica As String

    Public Property UrlFacturaElectronica() As String
        Get
            Return vUrlFacturaElectronica
        End Get
        Set(ByVal value As String)
            vUrlFacturaElectronica = value
        End Set
    End Property


End Class
