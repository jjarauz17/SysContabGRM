Public Class frmBolsaDetalle

    Public Desde As Date,
        Hasta As Date,
        IdBolsa As Integer = 0

    Private Sub frmBolsaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = $"Reporte de Bolsa del Periodo: {Desde.ToShortDateString} Al: {Hasta.ToShortDateString}"
        '

    End Sub
End Class