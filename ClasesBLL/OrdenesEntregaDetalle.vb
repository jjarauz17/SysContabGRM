Imports Microsoft.VisualBasic
Public Class OrdenesEntregaDetalle
    Dim vIdDetalle As Double

    Public Property IdDetalle() As Double
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Double)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdOrden As Double

    Public Property IdOrden() As Double
        Get
            Return vIdOrden
        End Get
        Set(ByVal value As Double)
            vIdOrden = value
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

    Dim vNombre As String

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Dim vAgrupar As String

    Public Property Agrupar() As String
        Get
            Return vAgrupar
        End Get
        Set(ByVal value As String)
            vAgrupar = value
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

    Dim vFisico As Double

    Public Property Fisico() As Double
        Get
            Return vFisico
        End Get
        Set(ByVal value As Double)
            vFisico = value
        End Set
    End Property

    Dim vAutorizado As Double

    Public Property Autorizado() As Double
        Get
            Return vAutorizado
        End Get
        Set(ByVal value As Double)
            vAutorizado = value
        End Set
    End Property

    Dim vEntregado As Double

    Public Property Entregado() As Double
        Get
            Return vEntregado
        End Get
        Set(ByVal value As Double)
            vEntregado = value
        End Set
    End Property

    Dim vPrecio As Double

    Public Property Precio() As Double
        Get
            Return vPrecio
        End Get
        Set(ByVal value As Double)
            vPrecio = value
        End Set
    End Property

    Dim vIVA As Double

    Public Property IVA() As Double
        Get
            Return vIVA
        End Get
        Set(ByVal value As Double)
            vIVA = value
        End Set
    End Property

    Dim vDescuento As Double

    Public Property Descuento() As Double
        Get
            Return vDescuento
        End Get
        Set(ByVal value As Double)
            vDescuento = value
        End Set
    End Property

    Dim vTotal As Double

    Public Property Total() As Double
        Get
            Return vTotal
        End Get
        Set(ByVal value As Double)
            vTotal = value
        End Set
    End Property

End Class
