Public Class frmKardexProducto

    Public Producto As String = ""
    Public Bodega As String = ""

    Private Sub frmKardexProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = ObtieneDatos("JAR_KardexInventarioxProducto", Producto, "P", Bodega, EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        iVista.Columns("Tipo_Doc").Visible = False
        iVista.Columns("Costo").Visible = False
        iVista.Columns("Total").Visible = False

        iVista.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If iVista.GetFocusedRowCellValue("Tipo_Doc") = "V" Then
            Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = DataGridTextBoxCombo.frmFacturacionClienteVer.Instance()

            Registro = iVista.GetFocusedRowCellValue("Factura")

            f.Text = "Ver Factura"
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
            f.Dispose()            
        ElseIf iVista.GetFocusedRowCellValue("Tipo_Doc") = "R" Then
            Dim f As FrmRequisasnew = FrmRequisasnew.Instance()
            Nuevo = "SI"
            f.Text = "Editar Movimiento"
            f.StartPosition = FormStartPosition.CenterScreen
            f.IdRequisa = iVista.GetFocusedRowCellValue("#Movimiento")
            f.lyGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            f.lyImportar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            f.lyRefrescar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            f.ShowDialog()
            f.Dispose()
        End If

        
    End Sub
End Class