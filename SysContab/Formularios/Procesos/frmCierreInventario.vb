Public Class frmCierreInventario

    Dim obj As New CierresInventario
    Dim db As New db_CierresInventario

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        frmCierresInventarioAdd.Dispose()
        frmCierresInventarioAdd.ShowDialog()
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        frmCierreInventarioVer.Dispose()
        frmCierreInventarioVer.Numero = iVista.GetFocusedRowCellValue("Numero")
        frmCierreInventarioVer.vPrevia = 0
        frmCierreInventarioVer.Fecha_Cierre = iVista.GetFocusedRowCellValue("Fecha Cierre")
        frmCierreInventarioVer.Text = "Cierre de Inventario al: " + CDate(iVista.GetFocusedRowCellValue("Fecha Cierre")).ToShortDateString()
        frmCierreInventarioVer.Show()
        frmCierreInventarioVer.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If Not XtraMsg2("Esta Seguro que desea Borrar el cierre de Mes, esta acción no se puede revertir?") Then
            Exit Sub
        End If

        obj.Numero = iVista.GetFocusedRowCellValue("Numero")

        db.Borrar(obj)
        Cargar()        
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub frmCierreInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        Cargar()
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = db_CierresInventario.Listar(0, 0)
        FormatoGrid(iVista)
        ''
        iVista.Columns("Numero").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        iVista.Columns("Numero").SummaryItem.DisplayFormat = "{0:n0}"

        iVista.Columns("Registro").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        iVista.Columns("Registro").DisplayFormat.FormatString = "{0:dd/MM/yyy hh:mm tt}"
    End Sub
End Class