Public Class rptLibroAuxiliarDetallado

    Public Nivel As Integer = 1

    Private Sub ghsc01_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghsc01.BeforePrint
        'Dim Fila As DataRowView = GetCurrentRow()
        'If Fila.Item("sc02") = " " Then
        '    Me.ghSC02.Visible = False
        'Else
        '    Me.ghSC02.Visible = True
        'End If
    End Sub

    Private Sub ghMayor_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghMayor.BeforePrint

        'Dim DT As DataTable = Me.get
        '  Dim Fila As DataRowView = GetCurrentRow()
        'XtraMsg(Fila.Item("SaldoAnterior").ToString)
        'XtraMsg(Fila.Item("debe").ToString)
        'XtraMsg(Fila.Item("haber").ToString)        
        'Dim Fila As DataRowView = GetCurrentRow()
        'If Fila.Item("sc01") = " " Then
        '    Me.ghsc01.Visible = False
        'Else
        '    Me.ghsc01.Visible = True
        'End If
    End Sub

    Private Sub rptLibroAuxiliar_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        ''Validar los Niveles que seran visibles
        'If Nivel = 1 Then           'Solo Las Mayores
        '    ghsc01.Visible = False
        '    ghSC02.Visible = False
        '    ghSC03.Visible = False
        '    ghCuenta.Visible = False
        '    Detalle.Visible = False
        'ElseIf Nivel = 2 Then       'Primer Nivel
        '    ghsc01.Visible = True
        '    ghSC02.Visible = False
        '    ghSC03.Visible = False
        '    ghCuenta.Visible = False
        '    Detalle.Visible = False
        'ElseIf Nivel = 3 Then       'Segundo Nivel
        '    ghsc01.Visible = True
        '    ghSC02.Visible = True
        '    ghSC03.Visible = False
        '    ghCuenta.Visible = False
        '    Detalle.Visible = False
        'ElseIf Nivel = 4 Then       'Tercer Nivel
        '    ghsc01.Visible = True
        '    ghSC02.Visible = True
        '    ghSC03.Visible = True
        '    ghCuenta.Visible = False
        '    Detalle.Visible = False
        'ElseIf Nivel = 5 Then       'Cuarto Nivel
        '    ghsc01.Visible = True
        '    ghSC02.Visible = True
        '    ghSC03.Visible = True
        '    ghCuenta.Visible = True
        '    Detalle.Visible = True
        'Else                        'Todos los Niveles
        '    ghsc01.Visible = True
        '    ghSC02.Visible = True
        '    ghSC03.Visible = True
        '    ghCuenta.Visible = True
        '    Detalle.Visible = True
        'End If
    End Sub
End Class