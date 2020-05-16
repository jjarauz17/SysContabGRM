Imports Microsoft.VisualBasic
Public Class Prod_ProduccionDevoluciones
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdProduccion As Integer

    Public Property IdProduccion() As Integer
        Get
            Return vIdProduccion
        End Get
        Set(ByVal value As Integer)
            vIdProduccion = value
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

    Dim vTipo As String

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal value As String)
            vTipo = value
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

    Dim vIdTipoProducto As Integer

    Public Property IdTipoProducto() As Integer
        Get
            Return vIdTipoProducto
        End Get
        Set(ByVal value As Integer)
            vIdTipoProducto = value
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

    Dim vPresentacion As String

    Public Property Presentacion() As String
        Get
            Return vPresentacion
        End Get
        Set(ByVal value As String)
            vPresentacion = value
        End Set
    End Property

    Dim vBodega As String

    Public Property Bodega() As String
        Get
            Return vBodega
        End Get
        Set(ByVal value As String)
            vBodega = value
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

End Class
