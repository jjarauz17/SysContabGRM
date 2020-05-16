Imports Microsoft.VisualBasic
Public Class TipoFacturas
    Dim vIdTipo As Integer

    Public Property IdTipo() As Integer
        Get
            Return vIdTipo
        End Get
        Set(ByVal value As Integer)
            vIdTipo = value
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

    Dim vFormato As Byte

    Public Property Formato() As Byte
        Get
            Return vFormato
        End Get
        Set(ByVal value As Byte)
            vFormato = value
        End Set
    End Property

End Class
