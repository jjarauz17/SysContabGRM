Imports Microsoft.VisualBasic
Public Class Prod_TipoCostos
    Dim vCodConsecutTipoCosto As Integer

    Public Property CodConsecutTipoCosto() As Integer
        Get
            Return vCodConsecutTipoCosto
        End Get
        Set(ByVal value As Integer)
            vCodConsecutTipoCosto = value
        End Set
    End Property

    Dim vTipoCosto As String

    Public Property TipoCosto() As String
        Get
            Return vTipoCosto
        End Get
        Set(ByVal value As String)
            vTipoCosto = value
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
