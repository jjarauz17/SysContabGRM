Imports Microsoft.VisualBasic
Public Class Depositos
    Dim vIdDeposito As Integer

    Public Property IdDeposito() As Integer
        Get
            Return vIdDeposito
        End Get
        Set(ByVal value As Integer)
            vIdDeposito = value
        End Set
    End Property

    Dim vDeposito_ID As String

    Public Property Deposito_ID() As String
        Get
            Return vDeposito_ID
        End Get
        Set(ByVal value As String)
            vDeposito_ID = value
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

    Dim vFecha As String

    Public Property Fecha() As String
        Get
            Return vFecha
        End Get
        Set(ByVal value As String)
            vFecha = value
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

    Dim vDocumento As String

    Public Property Documento() As String
        Get
            Return vDocumento
        End Get
        Set(ByVal value As String)
            vDocumento = value
        End Set
    End Property

    Dim vComentario As String

    Public Property Comentario() As String
        Get
            Return vComentario
        End Get
        Set(ByVal value As String)
            vComentario = value
        End Set
    End Property

    Dim vBanco As Integer

    Public Property Banco() As Integer
        Get
            Return vBanco
        End Get
        Set(ByVal value As Integer)
            vBanco = value
        End Set
    End Property

    Dim vNoCuenta As String

    Public Property NoCuenta() As String
        Get
            Return vNoCuenta
        End Get
        Set(ByVal value As String)
            vNoCuenta = value
        End Set
    End Property

    Dim vEstado As Integer

    Public Property Estado() As Integer
        Get
            Return vEstado
        End Get
        Set(ByVal value As Integer)
            vEstado = value
        End Set
    End Property

    Dim vContabilizado As Integer

    Public Property Contabilizado() As Integer
        Get
            Return vContabilizado
        End Get
        Set(ByVal value As Integer)
            vContabilizado = value
        End Set
    End Property

    Dim vFecha_Creacion As String

    Public Property Fecha_Creacion() As String
        Get
            Return vFecha_Creacion
        End Get
        Set(ByVal value As String)
            vFecha_Creacion = value
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

    Dim vFecha_Modificacion As String

    Public Property Fecha_Modificacion() As String
        Get
            Return vFecha_Modificacion
        End Get
        Set(ByVal value As String)
            vFecha_Modificacion = value
        End Set
    End Property

    Dim vUsuario_Modificacion As String

    Public Property Usuario_Modificacion() As String
        Get
            Return vUsuario_Modificacion
        End Get
        Set(ByVal value As String)
            vUsuario_Modificacion = value
        End Set
    End Property

End Class
