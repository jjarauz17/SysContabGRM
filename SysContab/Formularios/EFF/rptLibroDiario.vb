Public Class rptLibroDiario

    Private Sub ghsc01_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghsc01.BeforePrint

        Dim Fila As DataRowView = GetCurrentRow()
        If Fila.Item("sc02") = " " Then
            Me.ghSC02.Visible = False
        Else
            Me.ghSC02.Visible = True
        End If
    End Sub

    Private Sub ghMayor_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghMayor.BeforePrint
        Dim Fila As DataRowView = GetCurrentRow()
        If Fila.Item("sc01") = " " Then
            Me.ghsc01.Visible = False
        Else
            Me.ghsc01.Visible = True
        End If
    End Sub
End Class