Imports Microsoft.VisualBasic
Public Class PNR_Propiedades_Detalle
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdPropiedad As Integer

    Public Property IdPropiedad() As Integer
        Get
            Return vIdPropiedad
        End Get
        Set(ByVal value As Integer)
            vIdPropiedad = value
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

    Dim vManzanas As Double

    Public Property Manzanas() As Double
        Get
            Return vManzanas
        End Get
        Set(ByVal value As Double)
            vManzanas = value
        End Set
    End Property

End Class
