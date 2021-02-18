Imports Microsoft.VisualBasic
Public Class Presupuesto
    Dim vIdPresupuesto As Integer

    Public Property IdPresupuesto() As Integer
        Get
            Return vIdPresupuesto
        End Get
        Set(ByVal value As Integer)
            vIdPresupuesto = value
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

    Dim vCodigo As String

    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal value As String)
            vCodigo = value
        End Set
    End Property

    Dim vPeriodo As Integer

    Public Property Periodo() As Integer
        Get
            Return vPeriodo
        End Get
        Set(ByVal value As Integer)
            vPeriodo = value
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

    Dim vFecha As String

    Public Property Fecha() As String
        Get
            Return vFecha
        End Get
        Set(ByVal value As String)
            vFecha = value
        End Set
    End Property

    Dim vIdSucursal As String

    Public Property IdSucursal() As String
        Get
            Return vIdSucursal
        End Get
        Set(ByVal value As String)
            vIdSucursal = value
        End Set
    End Property

    Dim vIdCultivo As Integer

    Public Property IdCultivo() As Integer
        Get
            Return vIdCultivo
        End Get
        Set(ByVal value As Integer)
            vIdCultivo = value
        End Set
    End Property

    Dim vIdCentroCosto As Integer

    Public Property IdCentroCosto() As Integer
        Get
            Return vIdCentroCosto
        End Get
        Set(ByVal value As Integer)
            vIdCentroCosto = value
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

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
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

    Dim vActivo As Integer

    Public Property Activo() As Integer
        Get
            Return vActivo
        End Get
        Set(ByVal value As Integer)
            vActivo = value
        End Set
    End Property

End Class
