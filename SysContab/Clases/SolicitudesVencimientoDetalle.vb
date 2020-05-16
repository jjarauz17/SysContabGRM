Imports Microsoft.VisualBasic
Public Class SolicitudesVencimientoDetalle
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

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

    Dim vFactura As String

    Public Property Factura() As String
        Get
            Return vFactura
        End Get
        Set(ByVal value As String)
            vFactura = value
        End Set
    End Property

    Dim vVencimiento As String

    Public Property Vencimiento() As String
        Get
            Return vVencimiento
        End Get
        Set(ByVal value As String)
            vVencimiento = value
        End Set
    End Property

    Dim vSolicitada As String

    Public Property Solicitada() As String
        Get
            Return vSolicitada
        End Get
        Set(ByVal value As String)
            vSolicitada = value
        End Set
    End Property

    Dim vAprobada As Integer

    Public Property Aprobada() As Integer
        Get
            Return vAprobada
        End Get
        Set(ByVal value As Integer)
            vAprobada = value
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

End Class
