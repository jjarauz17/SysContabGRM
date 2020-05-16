Imports Microsoft.VisualBasic
Public Class PNR_ClientesAdicionales
    Dim vIdDetalle As Integer

    Public Property IdDetalle() As Integer
        Get
            Return vIdDetalle
        End Get
        Set(ByVal value As Integer)
            vIdDetalle = value
        End Set
    End Property

    Dim vIdCliente As Integer

    Public Property IdCliente() As Integer
        Get
            Return vIdCliente
        End Get
        Set(ByVal value As Integer)
            vIdCliente = value
        End Set
    End Property

    Dim vIdPlanNegocio As Integer

    Public Property IdPlanNegocio() As Integer
        Get
            Return vIdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            vIdPlanNegocio = value
        End Set
    End Property

End Class
