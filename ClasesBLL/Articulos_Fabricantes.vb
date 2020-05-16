Imports Microsoft.VisualBasic
Public Class Articulos_Fabricantes
    Dim vIdFabricante As Integer

    Public Property IdFabricante() As Integer
        Get
            Return vIdFabricante
        End Get
        Set(ByVal value As Integer)
            vIdFabricante = value
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

    Dim vDescripcion As String

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
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

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
        End Set
    End Property

End Class
