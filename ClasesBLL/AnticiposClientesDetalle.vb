Imports Microsoft.VisualBasic
Public Class AnticiposClientesDetalle
    Dim vIdDetalle As Double

    Public Property IdDetalle() As Double
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Double)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdAnticipo As Integer

    Public Property IdAnticipo() As Integer
        Get
            Return vIdAnticipo
        End Get
        Set(ByVal value As Integer)
            vIdAnticipo = value
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

    Dim vCuenta As String

    Public Property Cuenta() As String
        Get
            Return vCuenta
        End Get
        Set(ByVal value As String)
            vCuenta = value
        End Set
    End Property

    Dim vDebito As Double

    Public Property Debito() As Double
        Get
            Return vDebito
        End Get
        Set(ByVal value As Double)
            vDebito = value
        End Set
    End Property

    Dim vCredito As Double

    Public Property Credito() As Double
        Get
            Return vCredito
        End Get
        Set(ByVal value As Double)
            vCredito = value
        End Set
    End Property

    Dim vConcepto As String

    Public Property Concepto() As String
        Get
            Return vConcepto
        End Get
        Set(ByVal value As String)
            vConcepto = value
        End Set
    End Property

End Class
