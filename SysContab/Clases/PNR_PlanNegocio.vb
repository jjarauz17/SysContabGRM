Imports Microsoft.VisualBasic
Public Class PNR_PlanNegocio
    Dim vIdPlanNegocio As Integer

    Public Property IdPlanNegocio() As Integer
        Get
            Return vIdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            vIdPlanNegocio = value
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

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
        End Set
    End Property

    Dim vPeridodo As Integer

    Public Property Peridodo() As Integer
        Get
            Return vPeridodo
        End Get
        Set(ByVal value As Integer)
            vPeridodo = value
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

    Dim vIdCliente As Integer

    Public Property IdCliente() As Integer
        Get
            Return vIdCliente
        End Get
        Set(ByVal value As Integer)
            vIdCliente = value
        End Set
    End Property

    Dim vIdResponsable As Integer

    Public Property IdResponsable() As Integer
        Get
            Return vIdResponsable
        End Get
        Set(ByVal value As Integer)
            vIdResponsable = value
        End Set
    End Property

    Dim vIdPropiedad As Integer

    Public Property IdPropiedad() As Integer
        Get
            Return vIdPropiedad
        End Get
        Set(ByVal value As Integer)
            vIdPropiedad = value
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

    Dim vIdSucursal As String

    Public Property IdSucursal() As String
        Get
            Return vIdSucursal
        End Get
        Set(ByVal value As String)
            vIdSucursal = value
        End Set
    End Property

    Dim vTotal_Mz As Double

    Public Property Total_Mz() As Double
        Get
            Return vTotal_Mz
        End Get
        Set(ByVal value As Double)
            vTotal_Mz = value
        End Set
    End Property

    Dim vMz_Atendidas As Double

    Public Property Mz_Atendidas() As Double
        Get
            Return vMz_Atendidas
        End Get
        Set(ByVal value As Double)
            vMz_Atendidas = value
        End Set
    End Property

    Dim vMz_Cultivo As Double

    Public Property Mz_Cultivo() As Double
        Get
            Return vMz_Cultivo
        End Get
        Set(ByVal value As Double)
            vMz_Cultivo = value
        End Set
    End Property

    Dim vPotencial_Biologico As Double

    Public Property Potencial_Biologico() As Double
        Get
            Return vPotencial_Biologico
        End Get
        Set(ByVal value As Double)
            vPotencial_Biologico = value
        End Set
    End Property

    Dim vPresentacion As Integer

    Public Property Presentacion() As Integer
        Get
            Return vPresentacion
        End Get
        Set(ByVal value As Integer)
            vPresentacion = value
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

    Dim vObservaciones As String

    Public Property Observaciones() As String
        Get
            Return vObservaciones
        End Get
        Set(ByVal value As String)
            vObservaciones = value
        End Set
    End Property

End Class
