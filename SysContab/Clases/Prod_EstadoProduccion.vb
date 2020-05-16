Imports Microsoft.VisualBasic
Public Class Prod_EstadoProduccion
    Dim vIdSysEstadoPRoduccion As Integer

    Public Property IdSysEstadoPRoduccion() As Integer
        Get
            Return vIdSysEstadoPRoduccion
        End Get
        Set(ByVal value As Integer)
            vIdSysEstadoPRoduccion = value
        End Set
    End Property

    Dim vEstado As String

    Public Property Estado() As String
        Get
            Return vEstado
        End Get
        Set(ByVal value As String)
            vEstado = value
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
