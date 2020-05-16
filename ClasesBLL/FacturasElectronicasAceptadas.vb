Imports Microsoft.VisualBasic
Public Class FacturasElectronicasAceptadas
    Dim vIdFactura As Integer

    Public Property IdFactura() As Integer
        Get
            Return vIdFactura
        End Get
        Set(ByVal value As Integer)
            vIdFactura = value
        End Set
    End Property

    Dim vIdProveedor As Integer

    Public Property IdProveedor() As Integer
        Get
            Return vIdProveedor
        End Get
        Set(ByVal value As Integer)
            vIdProveedor = value
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

    Dim vNumero As Integer

    Public Property Numero() As Integer
        Get
            Return vNumero
        End Get
        Set(ByVal value As Integer)
            vNumero = value
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

    Dim vFactura As String

    Public Property Factura() As String
        Get
            Return vFactura
        End Get
        Set(ByVal value As String)
            vFactura = value
        End Set
    End Property

    Dim vEmisor As String

    Public Property Emisor() As String
        Get
            Return vEmisor
        End Get
        Set(ByVal value As String)
            vEmisor = value
        End Set
    End Property

    Dim vCedulaEmisor As String

    Public Property CedulaEmisor() As String
        Get
            Return vCedulaEmisor
        End Get
        Set(ByVal value As String)
            vCedulaEmisor = value
        End Set
    End Property

    Dim vFechaEmision As String

    Public Property FechaEmision() As String
        Get
            Return vFechaEmision
        End Get
        Set(ByVal value As String)
            vFechaEmision = value
        End Set
    End Property

    Dim vFechaEnvio As String

    Public Property FechaEnvio() As String
        Get
            Return vFechaEnvio
        End Get
        Set(ByVal value As String)
            vFechaEnvio = value
        End Set
    End Property

    Dim vMensaje As Integer

    Public Property Mensaje() As Integer
        Get
            Return vMensaje
        End Get
        Set(ByVal value As Integer)
            vMensaje = value
        End Set
    End Property

    Dim vMensajeDetalle As String

    Public Property MensajeDetalle() As String
        Get
            Return vMensajeDetalle
        End Get
        Set(ByVal value As String)
            vMensajeDetalle = value
        End Set
    End Property

    Dim vTotalImpuesto As Double

    Public Property TotalImpuesto() As Double
        Get
            Return vTotalImpuesto
        End Get
        Set(ByVal value As Double)
            vTotalImpuesto = value
        End Set
    End Property

    Dim vTotalFactura As Double

    Public Property TotalFactura() As Double
        Get
            Return vTotalFactura
        End Get
        Set(ByVal value As Double)
            vTotalFactura = value
        End Set
    End Property

    Dim vReceptor As String

    Public Property Receptor() As String
        Get
            Return vReceptor
        End Get
        Set(ByVal value As String)
            vReceptor = value
        End Set
    End Property

    Dim vCedulaReceptor As String

    Public Property CedulaReceptor() As String
        Get
            Return vCedulaReceptor
        End Get
        Set(ByVal value As String)
            vCedulaReceptor = value
        End Set
    End Property

    Dim vConsecutivo As String

    Public Property Consecutivo() As String
        Get
            Return vConsecutivo
        End Get
        Set(ByVal value As String)
            vConsecutivo = value
        End Set
    End Property

    Dim vStatusCode As String

    Public Property StatusCode() As String
        Get
            Return vStatusCode
        End Get
        Set(ByVal value As String)
            vStatusCode = value
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

    Dim vRespuesta As String

    Public Property Respuesta() As String
        Get
            Return vRespuesta
        End Get
        Set(ByVal value As String)
            vRespuesta = value
        End Set
    End Property

    Dim vXmlOriginal As String

    Public Property XmlOriginal() As String
        Get
            Return vXmlOriginal
        End Get
        Set(ByVal value As String)
            vXmlOriginal = value
        End Set
    End Property

    Dim vXmlEnviado As String

    Public Property XmlEnviado() As String
        Get
            Return vXmlEnviado
        End Get
        Set(ByVal value As String)
            vXmlEnviado = value
        End Set
    End Property

    Dim vXmlFirmado As String

    Public Property XmlFirmado() As String
        Get
            Return vXmlFirmado
        End Get
        Set(ByVal value As String)
            vXmlFirmado = value
        End Set
    End Property

    Dim vXmlRespuesta As String

    Public Property XmlRespuesta() As String
        Get
            Return vXmlRespuesta
        End Get
        Set(ByVal value As String)
            vXmlRespuesta = value
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

    Dim vFecha_Registro As String

    Public Property Fecha_Registro() As String
        Get
            Return vFecha_Registro
        End Get
        Set(ByVal value As String)
            vFecha_Registro = value
        End Set
    End Property

    Dim vConsecutivoProveedor As String

    Public Property ConsecutivoProveedor() As String
        Get
            Return vConsecutivoProveedor
        End Get
        Set(ByVal value As String)
            vConsecutivoProveedor = value
        End Set
    End Property

End Class
