Imports Microsoft.VisualBasic
Public Class PNR_PlanNegocioDetalle
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdPlanNegocio As Integer

    Public Property IdPlanNegocio() As Integer
        Get
            Return vIdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            vIdPlanNegocio = value
        End Set
    End Property

    Dim vPresentacion As Integer

    Public Property Presentacion() As Integer
        Get
            Return vPresentacion
        End Get
        Set(ByVal value As Integer)
            vPresentacion = value
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

    Dim vTipo As String

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal value As String)
            vTipo = value
        End Set
    End Property

    Dim vCantidad_Anterior As Double

    Public Property Cantidad_Anterior() As Double
        Get
            Return vCantidad_Anterior
        End Get
        Set(ByVal value As Double)
            vCantidad_Anterior = value
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

    Dim vCantidadQ1 As Double

    Public Property CantidadQ1() As Double
        Get
            Return vCantidadQ1
        End Get
        Set(ByVal value As Double)
            vCantidadQ1 = value
        End Set
    End Property

    Dim vVentasQ1 As Double

    Public Property VentasQ1() As Double
        Get
            Return vVentasQ1
        End Get
        Set(ByVal value As Double)
            vVentasQ1 = value
        End Set
    End Property

    Dim vCantidadQ2 As Double

    Public Property CantidadQ2() As Double
        Get
            Return vCantidadQ2
        End Get
        Set(ByVal value As Double)
            vCantidadQ2 = value
        End Set
    End Property

    Dim vVentasQ2 As Double

    Public Property VentasQ2() As Double
        Get
            Return vVentasQ2
        End Get
        Set(ByVal value As Double)
            vVentasQ2 = value
        End Set
    End Property

    Dim vCantidadQ3 As Double

    Public Property CantidadQ3() As Double
        Get
            Return vCantidadQ3
        End Get
        Set(ByVal value As Double)
            vCantidadQ3 = value
        End Set
    End Property

    Dim vVentasQ3 As Double

    Public Property VentasQ3() As Double
        Get
            Return vVentasQ3
        End Get
        Set(ByVal value As Double)
            vVentasQ3 = value
        End Set
    End Property

    Dim vCantidadQ4 As Double

    Public Property CantidadQ4() As Double
        Get
            Return vCantidadQ4
        End Get
        Set(ByVal value As Double)
            vCantidadQ4 = value
        End Set
    End Property

    Dim vVentasQ4 As Double

    Public Property VentasQ4() As Double
        Get
            Return vVentasQ4
        End Get
        Set(ByVal value As Double)
            vVentasQ4 = value
        End Set
    End Property

    Dim vEnero As Double

    Public Property Enero() As Double
        Get
            Return vEnero
        End Get
        Set(ByVal value As Double)
            vEnero = value
        End Set
    End Property

    Dim vFebrero As Double

    Public Property Febrero() As Double
        Get
            Return vFebrero
        End Get
        Set(ByVal value As Double)
            vFebrero = value
        End Set
    End Property

    Dim vMarzo As Double

    Public Property Marzo() As Double
        Get
            Return vMarzo
        End Get
        Set(ByVal value As Double)
            vMarzo = value
        End Set
    End Property

    Dim vAbril As Double

    Public Property Abril() As Double
        Get
            Return vAbril
        End Get
        Set(ByVal value As Double)
            vAbril = value
        End Set
    End Property

    Dim vMayo As Double

    Public Property Mayo() As Double
        Get
            Return vMayo
        End Get
        Set(ByVal value As Double)
            vMayo = value
        End Set
    End Property

    Dim vJunio As Double

    Public Property Junio() As Double
        Get
            Return vJunio
        End Get
        Set(ByVal value As Double)
            vJunio = value
        End Set
    End Property

    Dim vJulio As Double

    Public Property Julio() As Double
        Get
            Return vJulio
        End Get
        Set(ByVal value As Double)
            vJulio = value
        End Set
    End Property

    Dim vAgosto As Double

    Public Property Agosto() As Double
        Get
            Return vAgosto
        End Get
        Set(ByVal value As Double)
            vAgosto = value
        End Set
    End Property

    Dim vSeptiembre As Double

    Public Property Septiembre() As Double
        Get
            Return vSeptiembre
        End Get
        Set(ByVal value As Double)
            vSeptiembre = value
        End Set
    End Property

    Dim vOctubre As Double

    Public Property Octubre() As Double
        Get
            Return vOctubre
        End Get
        Set(ByVal value As Double)
            vOctubre = value
        End Set
    End Property

    Dim vNoviembre As Double

    Public Property Noviembre() As Double
        Get
            Return vNoviembre
        End Get
        Set(ByVal value As Double)
            vNoviembre = value
        End Set
    End Property

    Dim vDiciembre As Double

    Public Property Diciembre() As Double
        Get
            Return vDiciembre
        End Get
        Set(ByVal value As Double)
            vDiciembre = value
        End Set
    End Property

    Dim vVenta_Anterior As Double

    Public Property Venta_Anterior() As Double
        Get
            Return vVenta_Anterior
        End Get
        Set(ByVal value As Double)
            vVenta_Anterior = value
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

    Dim vProyeccionQ1 As Double

    Public Property ProyeccionQ1() As Double
        Get
            Return vProyeccionQ1
        End Get
        Set(ByVal value As Double)
            vProyeccionQ1 = value
        End Set
    End Property

    Dim vProyeccionQ2 As Double

    Public Property ProyeccionQ2() As Double
        Get
            Return vProyeccionQ2
        End Get
        Set(ByVal value As Double)
            vProyeccionQ2 = value
        End Set
    End Property

    Dim vProyeccionQ3 As Double

    Public Property ProyeccionQ3() As Double
        Get
            Return vProyeccionQ3
        End Get
        Set(ByVal value As Double)
            vProyeccionQ3 = value
        End Set
    End Property

    Dim vProyeccionQ4 As Double

    Public Property ProyeccionQ4() As Double
        Get
            Return vProyeccionQ4
        End Get
        Set(ByVal value As Double)
            vProyeccionQ4 = value
        End Set
    End Property



End Class
