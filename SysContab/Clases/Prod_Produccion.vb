Imports Microsoft.VisualBasic
Public Class Prod_Produccion
    Dim vIdSysProduccion As Integer

    Public Property IdSysProduccion() As Integer
        Get
            Return vIdSysProduccion
        End Get
        Set(ByVal value As Integer)
            vIdSysProduccion = value
        End Set
    End Property


    Dim vIdProduccion As String
    Public Property IdProduccion() As String
        Get
            Return vIdProduccion
        End Get
        Set(ByVal value As String)
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

    Dim vIdSysEstadoPRoduccion As Integer

    Public Property IdSysEstadoPRoduccion() As Integer
        Get
            Return vIdSysEstadoPRoduccion
        End Get
        Set(ByVal value As Integer)
            vIdSysEstadoPRoduccion = value
        End Set
    End Property

    Dim vFechaProduccion As String

    Public Property FechaProduccion() As String
        Get
            Return vFechaProduccion
        End Get
        Set(ByVal value As String)
            vFechaProduccion = value
        End Set
    End Property

    Dim vFechaGeneraProduccion As String

    Public Property FechaGeneraProduccion() As String
        Get
            Return vFechaGeneraProduccion
        End Get
        Set(ByVal value As String)
            vFechaGeneraProduccion = value
        End Set
    End Property

    Dim vFechaFinalizaProduccion As String

    Public Property FechaFinalizaProduccion() As String
        Get
            Return vFechaFinalizaProduccion
        End Get
        Set(ByVal value As String)
            vFechaFinalizaProduccion = value
        End Set
    End Property

    Dim vFechaAutorizaProduccion As String

    Public Property FechaAutorizaProduccion() As String
        Get
            Return vFechaAutorizaProduccion
        End Get
        Set(ByVal value As String)
            vFechaAutorizaProduccion = value
        End Set
    End Property

    Dim vNumeroProduccion As String

    Public Property NumeroProduccion() As String
        Get
            Return vNumeroProduccion
        End Get
        Set(ByVal value As String)
            vNumeroProduccion = value
        End Set
    End Property

    Dim vIdSysFormula As Integer

    Public Property IdSysFormula() As Integer
        Get
            Return vIdSysFormula
        End Get
        Set(ByVal value As Integer)
            vIdSysFormula = value
        End Set
    End Property

    Dim vCantidadProducir As Double

    Public Property CantidadProducir() As Double
        Get
            Return vCantidadProducir
        End Get
        Set(ByVal value As Double)
            vCantidadProducir = value
        End Set
    End Property

    Dim vCantidadRealProducida As Double

    Public Property CantidadRealProducida() As Double
        Get
            Return vCantidadRealProducida
        End Get
        Set(ByVal value As Double)
            vCantidadRealProducida = value
        End Set
    End Property

    Dim vCostoProduccion As Double

    Public Property CostoProduccion() As Double
        Get
            Return vCostoProduccion
        End Get
        Set(ByVal value As Double)
            vCostoProduccion = value
        End Set
    End Property

    Dim vObservaciones As String

    Public Property Observaciones() As String
        Get
            Return vObservaciones
        End Get
        Set(ByVal value As String)
            vObservaciones = value
        End Set
    End Property

    Dim vObservaciones2 As String

    Public Property Observaciones2() As String
        Get
            Return vObservaciones2
        End Get
        Set(ByVal value As String)
            vObservaciones2 = value
        End Set
    End Property

    Dim vObservaciones3 As String

    Public Property Observaciones3() As String
        Get
            Return vObservaciones3
        End Get
        Set(ByVal value As String)
            vObservaciones3 = value
        End Set
    End Property

    Dim vNoDocumento As String

    Public Property NoDocumento() As String
        Get
            Return vNoDocumento
        End Get
        Set(ByVal value As String)
            vNoDocumento = value
        End Set
    End Property

    Dim vDesperdicio As Double

    Public Property Desperdicio() As Double
        Get
            Return vDesperdicio
        End Get
        Set(ByVal value As Double)
            vDesperdicio = value
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

    Dim vBodega As String

    Public Property Bodega() As String
        Get
            Return vBodega
        End Get
        Set(ByVal value As String)
            vBodega = value
        End Set
    End Property

    Dim vND As Integer

    Public Property ND() As Integer
        Get
            Return vND
        End Get
        Set(ByVal value As Integer)
            vND = value
        End Set
    End Property

    Dim vNC As Integer

    Public Property NC() As Integer
        Get
            Return vNC
        End Get
        Set(ByVal value As Integer)
            vNC = value
        End Set
    End Property

End Class
