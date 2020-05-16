Imports Microsoft.VisualBasic
Public Class CierresInventario
    Dim vIdDetalle As Double


    Public Property IdDetalle() As Double
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Double)
            vIdDetalle = value
        End Set
    End Property

    Dim vNumero As String

    Public Property Numero() As String
        Get
            Return vNumero
        End Get
        Set(ByVal value As String)
            vNumero = value
        End Set
    End Property

    Dim vFecha_Llave As String

    Public Property Fecha_Llave() As String
        Get
            Return vFecha_Llave
        End Get
        Set(ByVal value As String)
            vFecha_Llave = value
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

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
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

    Dim vCodigo As String

    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal value As String)
            vCodigo = value
        End Set
    End Property

    Dim vInicial As Double

    Public Property Inicial() As Double
        Get
            Return vInicial
        End Get
        Set(ByVal value As Double)
            vInicial = value
        End Set
    End Property

    Dim vEntradas As Double

    Public Property Entradas() As Double
        Get
            Return vEntradas
        End Get
        Set(ByVal value As Double)
            vEntradas = value
        End Set
    End Property

    Dim vSalidas As Double

    Public Property Salidas() As Double
        Get
            Return vSalidas
        End Get
        Set(ByVal value As Double)
            vSalidas = value
        End Set
    End Property

    Dim vFinal As Double

    Public Property Final() As Double
        Get
            Return vFinal
        End Get
        Set(ByVal value As Double)
            vFinal = value
        End Set
    End Property

    Dim vPromedio As Double

    Public Property Promedio() As Double
        Get
            Return vPromedio
        End Get
        Set(ByVal value As Double)
            vPromedio = value
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

    Dim vEstado As Integer

    Public Property Estado() As Integer
        Get
            Return vEstado
        End Get
        Set(ByVal value As Integer)
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

End Class
