Imports Microsoft.VisualBasic
Public Class RemisionesDetalle
    Dim vIdDetalle As Double

    Public Property IdDetalle() As Double
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Double)
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

    Dim vIdRemision As Double

    Public Property IdRemision() As Double
        Get
            Return vIdRemision
        End Get
        Set(ByVal value As Double)
            vIdRemision = value
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
