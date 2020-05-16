Imports Microsoft.VisualBasic
Public Class PNR_Responsables
    Dim vIdResponsable As Integer

    Public Property IdResponsable() As Integer
        Get
            Return vIdResponsable
        End Get
        Set(ByVal value As Integer)
            vIdResponsable = value
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

    Dim vCargo As String

    Public Property Cargo() As String
        Get
            Return vCargo
        End Get
        Set(ByVal value As String)
            vCargo = value
        End Set
    End Property

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
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

    Dim vValor As String

    Public Property Valor() As String
        Get
            Return vValor
        End Get
        Set(ByVal value As String)
            vValor = value
        End Set
    End Property

End Class
