Imports Microsoft.VisualBasic
Public Class SolicitudesVencimiento
    Dim vIdSolicitud As Integer

    Public Property IdSolicitud() As Integer
        Get
            Return vIdSolicitud
        End Get
        Set(ByVal value As Integer)
            vIdSolicitud = value
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

    Dim vCliente As Integer

    Public Property Cliente() As Integer
        Get
            Return vCliente
        End Get
        Set(ByVal value As Integer)
            vCliente = value
        End Set
    End Property

    Dim vSolicitado_por As String

    Public Property Solicitado_por() As String
        Get
            Return vSolicitado_por
        End Get
        Set(ByVal value As String)
            vSolicitado_por = value
        End Set
    End Property

    Dim vCorreo As String

    Public Property Correo() As String
        Get
            Return vCorreo
        End Get
        Set(ByVal value As String)
            vCorreo = value
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

    Dim vFecha_Aprobada As String

    Public Property Fecha_Aprobada() As String
        Get
            Return vFecha_Aprobada
        End Get
        Set(ByVal value As String)
            vFecha_Aprobada = value
        End Set
    End Property

    Dim vFecha_Denegada As String

    Public Property Fecha_Denegada() As String
        Get
            Return vFecha_Denegada
        End Get
        Set(ByVal value As String)
            vFecha_Denegada = value
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

    Dim vUsuario_Aprueba As String

    Public Property Usuario_Aprueba() As String
        Get
            Return vUsuario_Aprueba
        End Get
        Set(ByVal value As String)
            vUsuario_Aprueba = value
        End Set
    End Property

    Dim vUsuario_Deniega As String

    Public Property Usuario_Deniega() As String
        Get
            Return vUsuario_Deniega
        End Get
        Set(ByVal value As String)
            vUsuario_Deniega = value
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

End Class
