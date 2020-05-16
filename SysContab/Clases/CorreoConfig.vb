Imports Microsoft.VisualBasic
Public Class CorreoConfig
    Dim vIdCorreo As Integer

    Public Property IdCorreo() As Integer
        Get
            Return vIdCorreo
        End Get
        Set(ByVal value As Integer)
            vIdCorreo = value
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

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
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

    Dim vClave As String

    Public Property Clave() As String
        Get
            Return vClave
        End Get
        Set(ByVal value As String)
            vClave = value
        End Set
    End Property

    Dim vSmtp As String

    Public Property Smtp() As String
        Get
            Return vSmtp
        End Get
        Set(ByVal value As String)
            vSmtp = value
        End Set
    End Property

    Dim vSSL As Integer

    Public Property SSL() As Integer
        Get
            Return vSSL
        End Get
        Set(ByVal value As Integer)
            vSSL = value
        End Set
    End Property

    Dim vPuerto As Integer

    Public Property Puerto() As Integer
        Get
            Return vPuerto
        End Get
        Set(ByVal value As Integer)
            vPuerto = value
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

    Dim vPerfil As String

    Public Property Perfil() As String
        Get
            Return vPerfil
        End Get
        Set(ByVal value As String)
            vPerfil = value
        End Set
    End Property


    Dim vCopia As String

    Public Property Copia() As String
        Get
            Return vCopia
        End Get
        Set(ByVal value As String)
            vCopia = value
        End Set
    End Property

    Dim vAsunto As String

    Public Property Asunto() As String
        Get
            Return vAsunto
        End Get
        Set(ByVal value As String)
            vAsunto = value
        End Set
    End Property

    Dim vANombre As String

    Public Property ANombre() As String
        Get
            Return vANombre
        End Get
        Set(ByVal value As String)
            vANombre = value
        End Set
    End Property

End Class
