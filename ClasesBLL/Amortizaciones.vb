Imports Microsoft.VisualBasic
Public Class Amortizaciones
    Dim vCod_amortizacion As Integer

    Public Property Cod_amortizacion() As Integer
        Get
            Return vCod_amortizacion
        End Get
        Set(ByVal value As Integer)
            vCod_amortizacion = value
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

    Dim vFecha_Inicial As String

    Public Property Fecha_Inicial() As String
        Get
            Return vFecha_Inicial
        End Get
        Set(ByVal value As String)
            vFecha_Inicial = value
        End Set
    End Property

    Dim vFecha_Limite As String

    Public Property Fecha_Limite() As String
        Get
            Return vFecha_Limite
        End Get
        Set(ByVal value As String)
            vFecha_Limite = value
        End Set
    End Property

    Dim vPlazo As Integer

    Public Property Plazo() As Integer
        Get
            Return vPlazo
        End Get
        Set(ByVal value As Integer)
            vPlazo = value
        End Set
    End Property

    Dim vNombre As Integer

    Public Property Nombre() As Integer
        Get
            Return vNombre
        End Get
        Set(ByVal value As Integer)
            vNombre = value
        End Set
    End Property

    Dim vMoneda As String

    Public Property Moneda() As String
        Get
            Return vMoneda
        End Get
        Set(ByVal value As String)
            vMoneda = value
        End Set
    End Property

    Dim vMonto_total As Double

    Public Property Monto_total() As Double
        Get
            Return vMonto_total
        End Get
        Set(ByVal value As Double)
            vMonto_total = value
        End Set
    End Property

    Dim vMonto_amortizado As Double

    Public Property Monto_amortizado() As Double
        Get
            Return vMonto_amortizado
        End Get
        Set(ByVal value As Double)
            vMonto_amortizado = value
        End Set
    End Property

    Dim vestado As Integer

    Public Property estado() As Integer
        Get
            Return vestado
        End Get
        Set(ByVal value As Integer)
            vestado = value
        End Set
    End Property

    Dim vTipoCompr As Integer

    Public Property TipoCompr() As Integer
        Get
            Return vTipoCompr
        End Get
        Set(ByVal value As Integer)
            vTipoCompr = value
        End Set
    End Property

End Class
