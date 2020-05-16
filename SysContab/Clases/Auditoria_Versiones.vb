Imports Microsoft.VisualBasic
Public Class Auditoria_Versiones
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vUsr_Id As Integer

    Public Property Usr_Id() As Integer
        Get
            Return vUsr_Id
        End Get
        Set(ByVal value As Integer)
            vUsr_Id = value
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

    Dim vVersion As String

    Public Property Version() As String
        Get
            Return vVersion
        End Get
        Set(ByVal value As String)
            vVersion = value
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

    Dim vUltimo_Login As String

    Public Property Ultimo_Login() As String
        Get
            Return vUltimo_Login
        End Get
        Set(ByVal value As String)
            vUltimo_Login = value
        End Set
    End Property

End Class
