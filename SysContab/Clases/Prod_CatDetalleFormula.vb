Imports Microsoft.VisualBasic
Public Class Prod_CatDetalleFormula
    Dim vIdSysArticulosFormulaDetalle As Integer

    Public Property IdSysArticulosFormulaDetalle() As Integer
        Get
            Return vIdSysArticulosFormulaDetalle
        End Get
        Set(ByVal value As Integer)
            vIdSysArticulosFormulaDetalle = value
        End Set
    End Property

    Dim vIdSysArticulosFormula As Integer

    Public Property IdSysArticulosFormula() As Integer
        Get
            Return vIdSysArticulosFormula
        End Get
        Set(ByVal value As Integer)
            vIdSysArticulosFormula = value
        End Set
    End Property

    Dim vEMPRESA As Integer

    Public Property EMPRESA() As Integer
        Get
            Return vEMPRESA
        End Get
        Set(ByVal value As Integer)
            vEMPRESA = value
        End Set
    End Property

    Dim vTIPO As String

    Public Property TIPO() As String
        Get
            Return vTIPO
        End Get
        Set(ByVal value As String)
            vTIPO = value
        End Set
    End Property

    Dim vCODIGO_ARTICULO As String

    Public Property CODIGO_ARTICULO() As String
        Get
            Return vCODIGO_ARTICULO
        End Get
        Set(ByVal value As String)
            vCODIGO_ARTICULO = value
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

    Dim vCantidad As Double

    Public Property Cantidad() As Double
        Get
            Return vCantidad
        End Get
        Set(ByVal value As Double)
            vCantidad = value
        End Set
    End Property

    Dim vCodTipoProd As Integer

    Public Property CodTipoProd() As Integer
        Get
            Return vCodTipoProd
        End Get
        Set(ByVal value As Integer)
            vCodTipoProd = value
        End Set
    End Property

    Dim vCODIGO_BODEGA As String

    Public Property CODIGO_BODEGA() As String
        Get
            Return vCODIGO_BODEGA
        End Get
        Set(ByVal value As String)
            vCODIGO_BODEGA = value
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

    Dim vFactor As Double

    Public Property Factor() As Double
        Get
            Return vFactor
        End Get
        Set(ByVal value As Double)
            vFactor = value
        End Set
    End Property

    Dim vCantidad_Unidad As Double

    Public Property Cantidad_Unidad() As Double
        Get
            Return vCantidad_Unidad
        End Get
        Set(ByVal value As Double)
            vCantidad_Unidad = value
        End Set
    End Property

    Dim vUnidad_Factor As String

    Public Property Unidad_Factor() As String
        Get
            Return vUnidad_Factor
        End Get
        Set(ByVal value As String)
            vUnidad_Factor = value
        End Set
    End Property

End Class
