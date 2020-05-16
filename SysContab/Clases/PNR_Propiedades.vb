Imports Microsoft.VisualBasic
Public Class PNR_Propiedades
    Dim vIdPropiedad As Integer

    Public Property IdPropiedad() As Integer
        Get
            Return vIdPropiedad
        End Get
        Set(ByVal value As Integer)
            vIdPropiedad = value
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

    Dim vIdCliente As Integer

    Public Property IdCliente() As Integer
        Get
            Return vIdCliente
        End Get
        Set(ByVal value As Integer)
            vIdCliente = value
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

    Dim vIdCultivo As Integer

    Public Property IdCultivo() As Integer
        Get
            Return vIdCultivo
        End Get
        Set(ByVal value As Integer)
            vIdCultivo = value
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

    Dim vRegristro As String

    Public Property Regristro() As String
        Get
            Return vRegristro
        End Get
        Set(ByVal value As String)
            vRegristro = value
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

    Dim vValor As String

    Public Property Valor() As String
        Get
            Return vValor
        End Get
        Set(ByVal value As String)
            vValor = value
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
