Imports Microsoft.VisualBasic
Public Class Combos
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
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

    Dim vCodigo_Combo As String

    Public Property Codigo_Combo() As String
        Get
            Return vCodigo_Combo
        End Get
        Set(ByVal value As String)
            vCodigo_Combo = value
        End Set
    End Property

    Dim vProducto As String

    Public Property Producto() As String
        Get
            Return vProducto
        End Get
        Set(ByVal value As String)
            vProducto = value
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

    Dim vCantidad As Double

    Public Property Cantidad() As Double
        Get
            Return vCantidad
        End Get
        Set(ByVal value As Double)
            vCantidad = value
        End Set
    End Property

    Dim vCosto As Double

    Public Property Costo() As Double
        Get
            Return vCosto
        End Get
        Set(ByVal value As Double)
            vCosto = value
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
