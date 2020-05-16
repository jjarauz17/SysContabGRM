Imports Microsoft.VisualBasic
Public Class Remisiones
    Dim vIdRemision As Double

    Public Property IdRemision() As Double
        Get
            Return vIdRemision
        End Get
        Set(ByVal value As Double)
            vIdRemision = value
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

    Dim vNoRemision As String

    Public Property NoRemision() As String
        Get
            Return vNoRemision
        End Get
        Set(ByVal value As String)
            vNoRemision = value
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

    Dim vReferencia As String

    Public Property Referencia() As String
        Get
            Return vReferencia
        End Get
        Set(ByVal value As String)
            vReferencia = value
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

    Dim vBodega As String

    Public Property Bodega() As String
        Get
            Return vBodega
        End Get
        Set(ByVal value As String)
            vBodega = value
        End Set
    End Property

    Dim vFecha As Date

    Public Property Fecha() As Date
        Get
            Return vFecha
        End Get
        Set(ByVal value As Date)
            vFecha = value
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

    Dim vIdProyecto As Integer

    Public Property IdProyecto() As Integer
        Get
            Return vIdProyecto
        End Get
        Set(ByVal value As Integer)
            vIdProyecto = value
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

    Dim vMoneda As String

    Public Property Moneda() As String
        Get
            Return vMoneda
        End Get
        Set(ByVal value As String)
            vMoneda = value
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

    Dim vConcepto As String

    Public Property Concepto() As String
        Get
            Return vConcepto
        End Get
        Set(ByVal value As String)
            vConcepto = value
        End Set
    End Property

    Dim vDireccion As String

    Public Property Direccion() As String
        Get
            Return vDireccion
        End Get
        Set(ByVal value As String)
            vDireccion = value
        End Set
    End Property

    Dim vTransporte As String

    Public Property Transporte() As String
        Get
            Return vTransporte
        End Get
        Set(ByVal value As String)
            vTransporte = value
        End Set
    End Property

    Dim vPlaca As String

    Public Property Placa() As String
        Get
            Return vPlaca
        End Get
        Set(ByVal value As String)
            vPlaca = value
        End Set
    End Property

    Dim vConductor As String

    Public Property Conductor() As String
        Get
            Return vConductor
        End Get
        Set(ByVal value As String)
            vConductor = value
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

    Dim vActivo As Integer

    Public Property Activo() As Integer
        Get
            Return vActivo
        End Get
        Set(ByVal value As Integer)
            vActivo = value
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

    Dim vFactura As String

    Public Property Factura() As String
        Get
            Return vFactura
        End Get
        Set(ByVal value As String)
            vFactura = value
        End Set
    End Property

    Dim vExento As Boolean

    Public Property Exento() As Boolean
        Get
            Return vExento
        End Get
        Set(ByVal value As Boolean)
            vExento = value
        End Set
    End Property

End Class
