Imports Microsoft.VisualBasic
Public Class Prod_CatMaestroFormula
    Dim vIdSysFormula As Integer

    Public Property IdSysFormula() As Integer
        Get
            Return vIdSysFormula
        End Get
        Set(ByVal value As Integer)
            vIdSysFormula = value
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

    Dim vEMPRESA As Integer

    Public Property EMPRESA() As Integer
        Get
            Return vEMPRESA
        End Get
        Set(ByVal value As Integer)
            vEMPRESA = value
        End Set
    End Property

    Dim vTIPO As String

    Public Property TIPO() As String
        Get
            Return vTIPO
        End Get
        Set(ByVal value As String)
            vTIPO = value
        End Set
    End Property

    Dim vCODIGO_ARTICULO As String

    Public Property CODIGO_ARTICULO() As String
        Get
            Return vCODIGO_ARTICULO
        End Get
        Set(ByVal value As String)
            vCODIGO_ARTICULO = value
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

    Dim vmsg As String

    Public Property msg() As String
        Get
            Return vmsg
        End Get
        Set(ByVal value As String)
            vmsg = value
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

End Class
