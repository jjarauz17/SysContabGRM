Imports Microsoft.VisualBasic
Public Class ORDENES_COMPRAS_ESTADOS
    Dim vIdEstado As Integer

    Public Property IdEstado() As Integer
        Get
            Return vIdEstado
        End Get
        Set(ByVal value As Integer)
            vIdEstado = value
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

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
        End Set
    End Property

    Dim vFacturada As Integer

    Public Property Facturada() As Integer
        Get
            Return vFacturada
        End Get
        Set(ByVal value As Integer)
            vFacturada = value
        End Set
    End Property

    Dim vPendiente As Integer

    Public Property Pendiente() As Integer
        Get
            Return vPendiente
        End Get
        Set(ByVal value As Integer)
            vPendiente = value
        End Set
    End Property


End Class
