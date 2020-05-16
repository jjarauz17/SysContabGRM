Imports Microsoft.VisualBasic
Public Class BancosCK
    Dim vIdBanco As Integer

    Public Property IdBanco() As Integer
        Get
            Return vIdBanco
        End Get
        Set(ByVal value As Integer)
            vIdBanco = value
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
    
End Class
