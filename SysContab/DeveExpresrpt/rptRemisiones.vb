Imports System.Drawing.Printing

Public Class rptRemisiones

    Public IdSucursal As String = ""
    Public DT_ROL As DataTable

    Private Sub rptRemisiones_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'VerPrecios'")
            If dr.Length = 0 Then GroupFooter1.Visible = False
            If dr.Length > 0 Then GroupFooter1.Visible = True
        End If
        '

        'If IdSucursal = "JI" Or IdSucursal = "ES" Or IdSucursal = "SE" Then
        '    GroupFooter1.Visible = True
        'Else
        '    GroupFooter1.Visible = False
        'End If

    End Sub
End Class