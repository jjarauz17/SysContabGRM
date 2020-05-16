Imports Microsoft.VisualBasic
Public Class PNR_Antecedentes
    Dim vIdAntecedente As Integer

    Public Property IdAntecedente() As Integer
        Get
            Return vIdAntecedente
        End Get
        Set(ByVal value As Integer)
            vIdAntecedente = value
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

    Dim vPeriodo As Integer

    Public Property Periodo() As Integer
        Get
            Return vPeriodo
        End Get
        Set(ByVal value As Integer)
            vPeriodo = value
        End Set
    End Property

    Dim vMz_Anterior As Double

    Public Property Mz_Anterior() As Double
        Get
            Return vMz_Anterior
        End Get
        Set(ByVal value As Double)
            vMz_Anterior = value
        End Set
    End Property

    Dim vMz_Actual As Double

    Public Property Mz_Actual() As Double
        Get
            Return vMz_Actual
        End Get
        Set(ByVal value As Double)
            vMz_Actual = value
        End Set
    End Property

    Dim vPBS_Anterior As Double

    Public Property PBS_Anterior() As Double
        Get
            Return vPBS_Anterior
        End Get
        Set(ByVal value As Double)
            vPBS_Anterior = value
        End Set
    End Property

    Dim vPBS_Actual As Double

    Public Property PBS_Actual() As Double
        Get
            Return vPBS_Actual
        End Get
        Set(ByVal value As Double)
            vPBS_Actual = value
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

End Class
