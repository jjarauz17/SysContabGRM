Imports Microsoft.VisualBasic
Public Class Prod_TipoProductos
    Dim vCodTipoProd As Integer

    Public Property CodTipoProd() As Integer
        Get
            Return vCodTipoProd
        End Get
        Set(ByVal value As Integer)
            vCodTipoProd = value
        End Set
    End Property

    Dim vNombreTipoProd As String

    Public Property NombreTipoProd() As String
        Get
            Return vNombreTipoProd
        End Get
        Set(ByVal value As String)
            vNombreTipoProd = value
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

End Class
