Imports Microsoft.VisualBasic
Public Class OrdenesTrabajo
    Dim vIdOrden As Double

    Public Property IdOrden() As Double
        Get
            Return vIdOrden
        End Get
        Set(ByVal value As Double)
            vIdOrden = value
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

    Dim vTipo As Integer

    Public Property Tipo() As Integer
        Get
            Return vTipo
        End Get
        Set(ByVal value As Integer)
            vTipo = value
        End Set
    End Property

    Dim vNoOrden As String

    Public Property NoOrden() As String
        Get
            Return vNoOrden
        End Get
        Set(ByVal value As String)
            vNoOrden = value
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

    Dim vFecha As String

    Public Property Fecha() As String
        Get
            Return vFecha
        End Get
        Set(ByVal value As String)
            vFecha = value
        End Set
    End Property

    Dim vTipo_Mantenimiento As Integer

    Public Property Tipo_Mantenimiento() As Integer
        Get
            Return vTipo_Mantenimiento
        End Get
        Set(ByVal value As Integer)
            vTipo_Mantenimiento = value
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

    Dim vIdVendedor As Integer

    Public Property IdVendedor() As Integer
        Get
            Return vIdVendedor
        End Get
        Set(ByVal value As Integer)
            vIdVendedor = value
        End Set
    End Property

    Dim vBodega As String

    Public Property Bodega() As String
        Get
            Return vBodega
        End Get
        Set(ByVal value As String)
            vBodega = value
        End Set
    End Property

    Dim vFallas_Equipo As String

    Public Property Fallas_Equipo() As String
        Get
            Return vFallas_Equipo
        End Get
        Set(ByVal value As String)
            vFallas_Equipo = value
        End Set
    End Property

    Dim vTrabajo_Realizado As String

    Public Property Trabajo_Realizado() As String
        Get
            Return vTrabajo_Realizado
        End Get
        Set(ByVal value As String)
            vTrabajo_Realizado = value
        End Set
    End Property

    Dim vObservaciones As String

    Public Property Observaciones() As String
        Get
            Return vObservaciones
        End Get
        Set(ByVal value As String)
            vObservaciones = value
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

    Dim vSubTotal As Double

    Public Property SubTotal() As Double
        Get
            Return vSubTotal
        End Get
        Set(ByVal value As Double)
            vSubTotal = value
        End Set
    End Property

    Dim vIVA As Double

    Public Property IVA() As Double
        Get
            Return vIVA
        End Get
        Set(ByVal value As Double)
            vIVA = value
        End Set
    End Property

    Dim vTotal As Double

    Public Property Total() As Double
        Get
            Return vTotal
        End Get
        Set(ByVal value As Double)
            vTotal = value
        End Set
    End Property

    Dim vTCambio As Double

    Public Property TCambio() As Double
        Get
            Return vTCambio
        End Get
        Set(ByVal value As Double)
            vTCambio = value
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

    Dim vFecha_Creacion As String

    Public Property Fecha_Creacion() As String
        Get
            Return vFecha_Creacion
        End Get
        Set(ByVal value As String)
            vFecha_Creacion = value
        End Set
    End Property

    Dim vUsuario_Modifica As String

    Public Property Usuario_Modifica() As String
        Get
            Return vUsuario_Modifica
        End Get
        Set(ByVal value As String)
            vUsuario_Modifica = value
        End Set
    End Property

    Dim vFecha_Modifica As String

    Public Property Fecha_Modifica() As String
        Get
            Return vFecha_Modifica
        End Get
        Set(ByVal value As String)
            vFecha_Modifica = value
        End Set
    End Property


    Dim vIdRemision As Double

    Public Property IdRemision() As Double
        Get
            Return vIdRemision
        End Get
        Set(ByVal value As Double)
            vIdRemision = value
        End Set
    End Property

End Class
