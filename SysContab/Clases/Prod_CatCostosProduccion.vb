Imports Microsoft.VisualBasic
Public Class Prod_CatCostosProduccion
    Dim vCodConsecutCatCosto As Integer

    Public Property CodConsecutCatCosto() As Integer
        Get
            Return vCodConsecutCatCosto
        End Get
        Set(ByVal value As Integer)
            vCodConsecutCatCosto = value
        End Set
    End Property

    Dim vCodConsecutTipoCosto As Integer

    Public Property CodConsecutTipoCosto() As Integer
        Get
            Return vCodConsecutTipoCosto
        End Get
        Set(ByVal value As Integer)
            vCodConsecutTipoCosto = value
        End Set
    End Property

    Dim vNombreCosto As String

    Public Property NombreCosto() As String
        Get
            Return vNombreCosto
        End Get
        Set(ByVal value As String)
            vNombreCosto = value
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
