Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBolsa
    Private Sub frmBolsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        '
        iVista.Columns("IdBolsa").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Anulado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Anulado] = 'False'")
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_FACTURAS_BOLSA.Listar(0)
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        ShowSplash()
        frmBolsaAdd.Dispose()
        frmBolsaAdd.MdiParent = Me.MdiParent
        frmBolsaAdd.IdBolsa = 0
        frmBolsaAdd.Text = "Bolsa Agropecuaria Reporte"
        frmBolsaAdd.Show()
        frmBolsaAdd.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash()
        frmBolsaAdd.Dispose()
        frmBolsaAdd.MdiParent = Me.MdiParent
        frmBolsaAdd.IdBolsa = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdBolsa")
        frmBolsaAdd.Text = "Bolsa Agropecuaria Reporte"
        frmBolsaAdd.Show()
        frmBolsaAdd.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bAplicar_Click(sender As Object, e As EventArgs) Handles bAplicar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Aplicado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Aplicado") Then e.Appearance.BackColor = Color.YellowGreen
        End If
        '
        If e.Column.FieldName = "Anulado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Anulado") Then e.Appearance.BackColor = Color.DarkSalmon
        End If
    End Sub

    Private Sub bGenear_Click(sender As Object, e As EventArgs) Handles bGenear.Click

    End Sub
End Class