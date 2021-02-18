Imports Microsoft.VisualBasic
Public Class ArregloPago
    Dim vIdArreglo As Integer

    Public Property IdArreglo() As Integer
        Get
            Return vIdArreglo
        End Get
        Set(ByVal value As Integer)
            vIdArreglo = value
        End Set
    End Property

    Dim vNumero As String

    Public Property Numero() As String
        Get
            Return vNumero
        End Get
        Set(ByVal value As String)
            vNumero = value
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

    Dim vIdCliente As Integer

    Public Property IdCliente() As Integer
        Get
            Return vIdCliente
        End Get
        Set(ByVal value As Integer)
            vIdCliente = value
        End Set
    End Property

    Dim vFechaSolicitud As String

    Public Property FechaSolicitud() As String
        Get
            Return vFechaSolicitud
        End Get
        Set(ByVal value As String)
            vFechaSolicitud = value
        End Set
    End Property

    Dim vFechaInicio As String

    Public Property FechaInicio() As String
        Get
            Return vFechaInicio
        End Get
        Set(ByVal value As String)
            vFechaInicio = value
        End Set
    End Property

    Dim vFechaCorte As String

    Public Property FechaCorte() As String
        Get
            Return vFechaCorte
        End Get
        Set(ByVal value As String)
            vFechaCorte = value
        End Set
    End Property

    Dim vDiasGracia As Integer

    Public Property DiasGracia() As Integer
        Get
            Return vDiasGracia
        End Get
        Set(ByVal value As Integer)
            vDiasGracia = value
        End Set
    End Property

    Dim vNoCuotas As Integer

    Public Property NoCuotas() As Integer
        Get
            Return vNoCuotas
        End Get
        Set(ByVal value As Integer)
            vNoCuotas = value
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

    Dim vMonto As Double

    Public Property Monto() As Double
        Get
            Return vMonto
        End Get
        Set(ByVal value As Double)
            vMonto = value
        End Set
    End Property

    Dim vEstado As String

    Public Property Estado() As String
        Get
            Return vEstado
        End Get
        Set(ByVal value As String)
            vEstado = value
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

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
        End Set
    End Property

    Private vComentario As String
    Public Property Comentario() As String
        Get
            Return vComentario
        End Get
        Set(ByVal value As String)
            vComentario = value
        End Set
    End Property

    Private vAprobado As Integer
    Public Property Aprobado() As Integer
        Get
            Return vAprobado
        End Get
        Set(ByVal value As Integer)
            vAprobado = value
        End Set
    End Property

End Class
