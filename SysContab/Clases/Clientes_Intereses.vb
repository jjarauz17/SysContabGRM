Imports Microsoft.VisualBasic
Public Class Clientes_Intereses
    Dim vIdInteres As Integer

    Public Property IdInteres() As Integer
        Get
            Return vIdInteres
        End Get
        Set(ByVal value As Integer)
            vIdInteres = value
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

    Dim vCorriente As Double

    Public Property Corriente() As Double
        Get
            Return vCorriente
        End Get
        Set(ByVal value As Double)
            vCorriente = value
        End Set
    End Property

    Dim vMoratorio As Double

    Public Property Moratorio() As Double
        Get
            Return vMoratorio
        End Get
        Set(ByVal value As Double)
            vMoratorio = value
        End Set
    End Property

    Dim vCuenta_Corriente As String

    Public Property Cuenta_Corriente() As String
        Get
            Return vCuenta_Corriente
        End Get
        Set(ByVal value As String)
            vCuenta_Corriente = value
        End Set
    End Property

    Dim vCuenta_Morosidad As String

    Public Property Cuenta_Morosidad() As String
        Get
            Return vCuenta_Morosidad
        End Get
        Set(ByVal value As String)
            vCuenta_Morosidad = value
        End Set
    End Property

End Class
