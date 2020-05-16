Public Class frmCierresInventarioAdd

    Private Sub frmCierres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha.DateTime = Now.Date
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not XtraMsg2("Esta Seguro de Cerrar Operaciones de Inventario a la Fecha: " & Fecha.DateTime.ToShortDateString & " ?") Then
            Exit Sub
        End If
        '
        'Verificar si ya hay cierre de Mes
        If db_CierresInventario.Verificar(Fecha.DateTime.Date) Then
            Exit Sub
        End If

        ShowSplash("Cerrando Inventario...")
        '
        If db_CierresInventario.Guardar(
            New DateTime(Fecha.DateTime.Year, Fecha.DateTime.Month, 1),
            Fecha.DateTime.Date) Then
            HideSplash()

            XtraMsg("El Cierre de Inventario a la Fecha: " & Fecha.DateTime.ToShortDateString & " se realizo con Exito!")
            frmCierreInventario.Cargar()
            Close()
        Else
            HideSplash()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'Verificar si ya hay cierre de Mes
        If Not db_CierresInventario.Verificar(Fecha.DateTime.Date) Then
            frmCierreInventarioVer.Numero = 0
            frmCierreInventarioVer.vPrevia = 1
            frmCierreInventarioVer.Fecha_Cierre = Fecha.DateTime.Date
            frmCierreInventarioVer.ShowDialog()
            frmCierreInventarioVer.Dispose()
        End If
    End Sub
End Class