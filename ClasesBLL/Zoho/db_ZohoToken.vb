
Imports System.Data.SqlClient

Public Class db_ZohoToken
    Inherits ClComun
    Dim vZohoTokenTabla As New ZohoToken
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ZohoTokenTabla() As ZohoToken
        Get
            Return vZohoTokenTabla
        End Get
        Set(ByVal value As ZohoToken)
            vZohoTokenTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Nombre As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_ZohoToken",
                            Nombre,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Nombre As String) As ZohoToken
        Dim dt As DataTable = ObtieneDatos("sp_sel_ZohoToken",
                                           Nombre,
                                           EmpresaA)
        Dim det As New ZohoToken

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.ID = .Item("ID")
                det.Empresa = .Item("Empresa")
                det.Nombre = .Item("Nombre")
                det.Client_ID = .Item("Client_ID")
                det.Client_Secret = .Item("Client_Secret")
                det.Redirect_Uri = .Item("Redirect_Uri")
                det.Mail = .Item("Mail")
                det.Modulos = .Item("Modulos")
                det.Url_AuthToken = .Item("Url_AuthToken")
            End With
        End If
        Return det
    End Function
End Class
