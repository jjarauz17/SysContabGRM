Imports Microsoft.VisualBasic
Public Class ProyectosCostos
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
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

    Dim vNoFactura As String

    Public Property NoFactura() As String
        Get
            Return vNoFactura
        End Get
        Set(ByVal value As String)
            vNoFactura = value
        End Set
    End Property

    Dim vProveedor As Integer

    Public Property Proveedor() As Integer
        Get
            Return vProveedor
        End Get
        Set(ByVal value As Integer)
            vProveedor = value
        End Set
    End Property

    Dim vComp_No As Integer

    Public Property Comp_No() As Integer
        Get
            Return vComp_No
        End Get
        Set(ByVal value As Integer)
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

    Dim vIdRequisa As Integer

    Public Property IdRequisa() As Integer
        Get
            Return vIdRequisa
        End Get
        Set(ByVal value As Integer)
            vIdRequisa = value
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

    Dim vCosto As Double

    Public Property Costo() As Double
        Get
            Return vCosto
        End Get
        Set(ByVal value As Double)
            vCosto = value
        End Set
    End Property

    Dim vFacturado As Double

    Public Property Facturado() As Double
        Get
            Return vFacturado
        End Get
        Set(ByVal value As Double)
            vFacturado = value
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

    Dim vRegistro As String

    Public Property Registro() As String
        Get
            Return vRegistro
        End Get
        Set(ByVal value As String)
            vRegistro = value
        End Set
    End Property

End Class
