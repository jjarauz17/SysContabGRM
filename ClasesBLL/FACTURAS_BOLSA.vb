Imports Microsoft.VisualBasic
Public Class FACTURAS_BOLSA
    Dim vIdBolsa As Integer

    Public Property IdBolsa() As Integer
        Get
            Return vIdBolsa
        End Get
        Set(ByVal value As Integer)
            vIdBolsa = value
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

    Dim vEmpresa As Integer

    Public Property Empresa() As Integer
        Get
            Return vEmpresa
        End Get
        Set(ByVal value As Integer)
            vEmpresa = value
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


    Dim vDesde As String

    Public Property Desde() As String
        Get
            Return vDesde
        End Get
        Set(ByVal value As String)
            vDesde = value
        End Set
    End Property


    Dim vHasta As String

    Public Property Hasta() As String
        Get
            Return vHasta
        End Get
        Set(ByVal value As String)
            vHasta = value
        End Set
    End Property

    Dim vDescripcion As String

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Dim vAplicado As Integer

    Public Property Aplicado() As Integer
        Get
            Return vAplicado
        End Get
        Set(ByVal value As Integer)
            vAplicado = value
        End Set
    End Property

    Dim vAnulado As Integer

    Public Property Anulado() As Integer
        Get
            Return vAnulado
        End Get
        Set(ByVal value As Integer)
            vAnulado = value
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

End Class
