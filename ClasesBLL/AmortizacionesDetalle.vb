Imports Microsoft.VisualBasic
Public Class AmortizacionesDetalle
    Dim vCod_amortizacion As Integer

    Public Property Cod_amortizacion() As Integer
        Get
            Return vCod_amortizacion
        End Get
        Set(ByVal value As Integer)
            vCod_amortizacion = value
        End Set
    End Property

    Dim vnum_amortizacion As Integer

    Public Property num_amortizacion() As Integer
        Get
            Return vnum_amortizacion
        End Get
        Set(ByVal value As Integer)
            vnum_amortizacion = value
        End Set
    End Property

    Dim vFecha As String

    Public Property Fecha() As String
        Get
            Return vFecha
        End Get
        Set(ByVal value As String)
            vFecha = value
        End Set
    End Property

    Dim vMes As String

    Public Property Mes() As String
        Get
            Return vMes
        End Get
        Set(ByVal value As String)
            vMes = value
        End Set
    End Property

    Dim vMonto_Inicial As Double

    Public Property Monto_Inicial() As Double
        Get
            Return vMonto_Inicial
        End Get
        Set(ByVal value As Double)
            vMonto_Inicial = value
        End Set
    End Property

    Dim vMonto_Amortizado As Double

    Public Property Monto_Amortizado() As Double
        Get
            Return vMonto_Amortizado
        End Get
        Set(ByVal value As Double)
            vMonto_Amortizado = value
        End Set
    End Property

    Dim vcontabilizar As Integer

    Public Property contabilizar() As Integer
        Get
            Return vcontabilizar
        End Get
        Set(ByVal value As Integer)
            vcontabilizar = value
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


    Dim vComp_No As Integer

    Public Property Comp_No() As Integer
        Get
            Return vComp_No
        End Get
        Set(ByVal value As Integer)
            vComp_No = value
        End Set
    End Property


    Dim vPer_Id As Integer

    Public Property Per_Id() As Integer
        Get
            Return vPer_Id
        End Get
        Set(ByVal value As Integer)
            vPer_Id = value
        End Set
    End Property

    Dim vMes_Id As Integer

    Public Property Mes_Id() As Integer
        Get
            Return vMes_Id
        End Get
        Set(ByVal value As Integer)
            vMes_Id = value
        End Set
    End Property

End Class
