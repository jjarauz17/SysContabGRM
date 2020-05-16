Imports Microsoft.VisualBasic

Public Class Taller_Remisiones
    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
        End Set
    End Property

    Dim vCodigo As Integer

    Public Property Codigo() As Integer
        Get
            Return vCodigo
        End Get
        Set(ByVal value As Integer)
            vCodigo = value
        End Set
    End Property

    Dim vIdRemision As Integer

    Public Property IdRemision() As Integer
        Get
            Return vIdRemision
        End Get
        Set(ByVal value As Integer)
            vIdRemision = value
        End Set
    End Property

    Dim vTipo As String

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal value As String)
            vTipo = value
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

    Dim vCliente As Integer

    Public Property Cliente() As Integer
        Get
            Return vCliente
        End Get
        Set(ByVal value As Integer)
            vCliente = value
        End Set
    End Property

    Dim vOrdenTrabajo As String

    Public Property OrdenTrabajo() As String
        Get
            Return vOrdenTrabajo
        End Get
        Set(ByVal value As String)
            vOrdenTrabajo = value
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

    Dim vRealizadopor As String

    Public Property Realizadopor() As String
        Get
            Return vRealizadopor
        End Get
        Set(ByVal value As String)
            vRealizadopor = value
        End Set
    End Property

    Dim vAutorizadopor As String

    Public Property Autorizadopor() As String
        Get
            Return vAutorizadopor
        End Get
        Set(ByVal value As String)
            vAutorizadopor = value
        End Set
    End Property

    Dim vContabilizada As Integer

    Public Property Contabilizada() As Integer
        Get
            Return vContabilizada
        End Get
        Set(ByVal value As Integer)
            vContabilizada = value
        End Set
    End Property

    Dim vComp_No As Double

    Public Property Comp_No() As Double
        Get
            Return vComp_No
        End Get
        Set(ByVal value As Double)
            vComp_No = value
        End Set
    End Property

    Dim vPer_Id As Integer

    Public Property Per_Id() As Integer
        Get
            Return vPer_Id
        End Get
        Set(ByVal value As Integer)
            vPer_Id = value
        End Set
    End Property

    Dim vMes As Integer

    Public Property Mes() As Integer
        Get
            Return vMes
        End Get
        Set(ByVal value As Integer)
            vMes = value
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

    Dim vReferencia As String

    Public Property Referencia() As String
        Get
            Return vReferencia
        End Get
        Set(ByVal value As String)
            vReferencia = value
        End Set
    End Property

    Dim vProcesado As Integer

    Public Property Procesado() As Integer
        Get
            Return vProcesado
        End Get
        Set(ByVal value As Integer)
            vProcesado = value
        End Set
    End Property

End Class
