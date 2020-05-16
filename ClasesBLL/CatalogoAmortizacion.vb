Imports Microsoft.VisualBasic
Public Class CatalogoAmortizacion
    Dim vCodigo As Integer

    Public Property Codigo() As Integer
        Get
            Return vCodigo
        End Get
        Set(ByVal value As Integer)
            vCodigo = value
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

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
        End Set
    End Property

    Dim vDebito As String

    Public Property Debito() As String
        Get
            Return vDebito
        End Get
        Set(ByVal value As String)
            vDebito = value
        End Set
    End Property

    Dim vCredito As String

    Public Property Credito() As String
        Get
            Return vCredito
        End Get
        Set(ByVal value As String)
            vCredito = value
        End Set
    End Property

    Dim vTipoCompr As Integer

    Public Property TipoCompr() As Integer
        Get
            Return vTipoCompr
        End Get
        Set(ByVal value As Integer)
            vTipoCompr = value
        End Set
    End Property

End Class
