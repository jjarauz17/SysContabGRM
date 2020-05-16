Imports Microsoft.VisualBasic
Public Class Clientes_Exoneraciones
    Dim vIdExonera As Integer

    Public Property IdExonera() As Integer
        Get
            Return vIdExonera
        End Get
        Set(ByVal value As Integer)
            vIdExonera = value
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

    Dim vFactura As String

    Public Property Factura() As String
        Get
            Return vFactura
        End Get
        Set(ByVal value As String)
            vFactura = value
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

    Dim vReferencia As String

    Public Property Referencia() As String
        Get
            Return vReferencia
        End Get
        Set(ByVal value As String)
            vReferencia = value
        End Set
    End Property

    Dim vComentarios As String

    Public Property Comentarios() As String
        Get
            Return vComentarios
        End Get
        Set(ByVal value As String)
            vComentarios = value
        End Set
    End Property

    Dim vUsuario As String


End Class
