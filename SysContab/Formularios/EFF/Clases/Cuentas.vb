Imports Microsoft.VisualBasic
Public Class Cuentas
    Dim vCuenta As String

    Public Property Cuenta() As String
        Get
            Return vCuenta
        End Get
        Set(ByVal value As String)
            vCuenta = value
        End Set
    End Property

    Dim vClasificacion As String

    Public Property Clasificacion() As String
        Get
            Return vClasificacion
        End Get
        Set(ByVal value As String)
            vClasificacion = value
        End Set
    End Property

    Dim vIdTipoCuenta As String

    Public Property IdTipoCuenta() As String
        Get
            Return vIdTipoCuenta
        End Get
        Set(ByVal value As String)
            vIdTipoCuenta = value
        End Set
    End Property

    Dim vNombreCuenta As String

    Public Property NombreCuenta() As String
        Get
            Return vNombreCuenta
        End Get
        Set(ByVal value As String)
            vNombreCuenta = value
        End Set
    End Property

    Dim vDescripcion As String

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Dim vCuentaEnlace As String

    Public Property CuentaEnlace() As String
        Get
            Return vCuentaEnlace
        End Get
        Set(ByVal value As String)
            vCuentaEnlace = value
        End Set
    End Property

    Dim vTipoCosto As String

    Public Property TipoCosto() As String
        Get
            Return vTipoCosto
        End Get
        Set(ByVal value As String)
            vTipoCosto = value
        End Set
    End Property

    Dim vAfectacion As String

    Public Property Afectacion() As String
        Get
            Return vAfectacion
        End Get
        Set(ByVal value As String)
            vAfectacion = value
        End Set
    End Property

    Dim vBalanza As Integer

    Public Property Balanza() As Integer
        Get
            Return vBalanza
        End Get
        Set(ByVal value As Integer)
            vBalanza = value
        End Set
    End Property

    Dim vCuentaCierre As String
    Public Property CuentaCierre() As String
        Get
            Return vCuentaCierre
        End Get
        Set(ByVal value As String)
            vCuentaCierre = value
        End Set
    End Property

End Class
