Imports Microsoft.VisualBasic
Public Class UnidadesMedida
    Dim vIdUnidad As Integer

    Public Property IdUnidad() As Integer
        Get
            Return vIdUnidad
        End Get
        Set(ByVal value As Integer)
            vIdUnidad = value
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

    Dim vUnidad As String

    Public Property Unidad() As String
        Get
            Return vUnidad
        End Get
        Set(ByVal value As String)
            vUnidad = value
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
