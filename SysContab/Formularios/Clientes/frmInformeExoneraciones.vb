Public Class frmInformeExoneraciones 

    Private Sub frmInformeExoneraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        fDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        fHasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Cargar()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Clientes_Exoneraciones.Listar(0, fDesde.DateTime.Date, fHasta.DateTime.Date)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        iVista.Columns("IdExonera").Visible = False
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        With New frmExoneraIVA
            .IdExonera = iVista.GetFocusedRowCellValue("IdExonera")
            .bGuardar.Enabled = False
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class