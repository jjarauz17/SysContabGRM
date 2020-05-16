Imports Microsoft.VisualBasic
Public Class PNR_PlanAccion
    Dim vIdPlanAccion As Integer

    Public Property IdPlanAccion() As Integer
        Get
            Return vIdPlanAccion
        End Get
        Set(ByVal value As Integer)
            vIdPlanAccion = value
        End Set
    End Property

    Dim vIdPlanNegocio As Integer

    Public Property IdPlanNegocio() As Integer
        Get
            Return vIdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            vIdPlanNegocio = value
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

    Dim vNombre As String

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
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

    Dim vFecha_Limite As String

    Public Property Fecha_Limite() As String
        Get
            Return vFecha_Limite
        End Get
        Set(ByVal value As String)
            vFecha_Limite = value
        End Set
    End Property

    Dim vRecursos As Double

    Public Property Recursos() As Double
        Get
            Return vRecursos
        End Get
        Set(ByVal value As Double)
            vRecursos = value
        End Set
    End Property

    Dim vAvance As Double

    Public Property Avance() As Double
        Get
            Return vAvance
        End Get
        Set(ByVal value As Double)
            vAvance = value
        End Set
    End Property

    Dim vFecha_Ejecucion As String

    Public Property Fecha_Ejecucion() As String
        Get
            Return vFecha_Ejecucion
        End Get
        Set(ByVal value As String)
            vFecha_Ejecucion = value
        End Set
    End Property

    Dim vGasto_Real As Double

    Public Property Gasto_Real() As Double
        Get
            Return vGasto_Real
        End Get
        Set(ByVal value As Double)
            vGasto_Real = value
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

    Dim vSucursal As String

    Public Property Sucursal() As String
        Get
            Return vSucursal
        End Get
        Set(ByVal value As String)
            vSucursal = value
        End Set
    End Property

    Dim vCultivo As String

    Public Property Cultivo() As String
        Get
            Return vCultivo
        End Get
        Set(ByVal value As String)
            vCultivo = value
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

End Class
