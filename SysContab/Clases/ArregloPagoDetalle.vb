Imports Microsoft.VisualBasic
Public Class ArregloPagoDetalle
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdArreglo As Integer

    Public Property IdArreglo() As Integer
        Get
            Return vIdArreglo
        End Get
        Set(ByVal value As Integer)
            vIdArreglo = value
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

    Dim vNumero As Integer

    Public Property Numero() As Integer
        Get
            Return vNumero
        End Get
        Set(ByVal value As Integer)
            vNumero = value
        End Set
    End Property

    Dim vFechaPago As String

    Public Property FechaPago() As String
        Get
            Return vFechaPago
        End Get
        Set(ByVal value As String)
            vFechaPago = value
        End Set
    End Property

    Dim vVencimiento As String

    Public Property Vencimiento() As String
        Get
            Return vVencimiento
        End Get
        Set(ByVal value As String)
            vVencimiento = value
        End Set
    End Property

    Dim vCuota As Double

    Public Property Cuota() As Double
        Get
            Return vCuota
        End Get
        Set(ByVal value As Double)
            vCuota = value
        End Set
    End Property

    Dim vInteres As Double

    Public Property Interes() As Double
        Get
            Return vInteres
        End Get
        Set(ByVal value As Double)
            vInteres = value
        End Set
    End Property

    Dim vAplicada As Integer

    Public Property Aplicada() As Integer
        Get
            Return vAplicada
        End Get
        Set(ByVal value As Integer)
            vAplicada = value
        End Set
    End Property

End Class
