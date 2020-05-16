Imports Microsoft.VisualBasic
Public Class AmortizacionesPlantilla
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
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

    Dim vCodigo As Integer

    Public Property Codigo() As Integer
        Get
            Return vCodigo
        End Get
        Set(ByVal value As Integer)
            vCodigo = value
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

    Dim vTipo As Integer

    Public Property Tipo() As Integer
        Get
            Return vTipo
        End Get
        Set(ByVal value As Integer)
            vTipo = value
        End Set
    End Property

    Dim vCentroCosto As Integer

    Public Property CentroCosto() As Integer
        Get
            Return vCentroCosto
        End Get
        Set(ByVal value As Integer)
            vCentroCosto = value
        End Set
    End Property

End Class
