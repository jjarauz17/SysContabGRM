Imports Microsoft.VisualBasic
Public Class Prod_TipoCostoValores
    Dim vCodconsecutTipoCosto As Integer

    Public Property CodconsecutTipoCosto() As Integer
        Get
            Return vCodconsecutTipoCosto
        End Get
        Set(ByVal value As Integer)
            vCodconsecutTipoCosto = value
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

End Class
