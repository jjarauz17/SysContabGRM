Imports Microsoft.VisualBasic
Public Class CorreoCopia
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdCorreo As Integer

    Public Property IdCorreo() As Integer
        Get
            Return vIdCorreo
        End Get
        Set(ByVal value As Integer)
            vIdCorreo = value
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

    Dim vCorreo As String

    Public Property Correo() As String
        Get
            Return vCorreo
        End Get
        Set(ByVal value As String)
            vCorreo = value
        End Set
    End Property

End Class
