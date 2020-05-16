Public Class frmConfigurar_Fecha

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        'If DtFechaInicio.EditValue Is Nothing Then Exit Sub
        '
        CierresDB.Cierre_Guardar(Me.DtFechaInicio.EditValue.year.ToString & Me.DtFechaInicio.EditValue.month.ToString.PadLeft(2, "0"),
                                 VB.SysContab.Rutinas.Fecha().Date)
        Dispose()
    End Sub

    Private Sub frmConfigurar_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtFechaInicio.DateTime = VB.SysContab.Rutinas.Fecha().Date
    End Sub
End Class