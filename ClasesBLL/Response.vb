Public Class Response

    Dim vIsSuccess As Boolean

    Public Property IsSuccess() As Boolean
        Get
            Return vIsSuccess
        End Get
        Set(ByVal value As Boolean)
            vIsSuccess = value
        End Set
    End Property

    Dim vMensaje As String

    Public Property Mensaje() As String
        Get
            Return vMensaje
        End Get
        Set(ByVal value As String)
            vMensaje = value
        End Set
    End Property

    Dim vResult As Object

    Public Property Result() As Object
        Get
            Return vResult
        End Get
        Set(ByVal value As Object)
            vResult = value
        End Set
    End Property

End Class
