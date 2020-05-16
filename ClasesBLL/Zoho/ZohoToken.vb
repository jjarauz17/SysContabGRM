Imports Microsoft.VisualBasic
Public Class ZohoToken
    Dim vID As Integer

    Public Property ID() As Integer
        Get
            Return vID
        End Get
        Set(ByVal value As Integer)
            vID = value
        End Set
    End Property

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
        End Set
    End Property

    Dim vNombre As String

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Dim vClient_ID As String

    Public Property Client_ID() As String
        Get
            Return vClient_ID
        End Get
        Set(ByVal value As String)
            vClient_ID = value
        End Set
    End Property

    Dim vClient_Secret As String

    Public Property Client_Secret() As String
        Get
            Return vClient_Secret
        End Get
        Set(ByVal value As String)
            vClient_Secret = value
        End Set
    End Property

    Dim vRedirect_Uri As String

    Public Property Redirect_Uri() As String
        Get
            Return vRedirect_Uri
        End Get
        Set(ByVal value As String)
            vRedirect_Uri = value
        End Set
    End Property

    Dim vMail As String

    Public Property Mail() As String
        Get
            Return vMail
        End Get
        Set(ByVal value As String)
            vMail = value
        End Set
    End Property

    Dim vModulos As String

    Public Property Modulos() As String
        Get
            Return vModulos
        End Get
        Set(ByVal value As String)
            vModulos = value
        End Set
    End Property

    Dim vUrl_AuthToken As String

    Public Property Url_AuthToken() As String
        Get
            Return vUrl_AuthToken
        End Get
        Set(ByVal value As String)
            vUrl_AuthToken = value
        End Set
    End Property

End Class
