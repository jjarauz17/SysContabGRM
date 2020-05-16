Public Class frmCondicionesVenta

    Dim obj As New ProformaCondicionesCLS

    Private Sub frmEstadosCotizacionesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()
    End Sub

    Public Sub Cargar()
        gridDatos.DataSource = obj.List()
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        frmProformaCondicionesAdd._Codigo = 0
        frmProformaCondicionesAdd.ShowDialog()
        frmProformaCondicionesAdd.Dispose()
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        If vDatos.FocusedRowHandle < 0 Then Exit Sub

        frmProformaCondicionesAdd._Codigo = vDatos.GetFocusedRowCellValue("IdCondicion")
        frmProformaCondicionesAdd.ShowDialog()
        frmProformaCondicionesAdd.Dispose()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If vDatos.FocusedRowHandle < 0 Then Exit Sub

        If Not XtraMsg2("Esta Seguro de la acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.Borrar(vDatos.GetFocusedRowCellValue("IdCondicion"))
        Cargar()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(gridDatos)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class