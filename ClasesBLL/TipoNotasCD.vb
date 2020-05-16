Imports Microsoft.VisualBasic
Public Class TipoNotasCD
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

    Dim vDescripcion As String

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

End Class
