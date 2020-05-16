Public Class frmEstadosOCList

    Dim obj As New ORDENES_COMPRAS_ESTADOS
    Dim db As New db_ORDENES_COMPRAS_ESTADOS

    Private Sub frmEstadosCotizacionesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()
    End Sub

    Public Sub Cargar()

        gridDatos.DataSource = db_ORDENES_COMPRAS_ESTADOS.Listar(0)
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        vDatos.Columns("IdEstado").Visible = False
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        frmEstadosOCAdd.IdEstado = 0
        frmEstadosOCAdd.ShowDialog()
        frmEstadosOCAdd.Dispose()
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        If vDatos.FocusedRowHandle < 0 Then Exit Sub

        frmEstadosOCAdd.IdEstado = vDatos.GetFocusedRowCellValue("IdEstado")
        frmEstadosOCAdd.ShowDialog()
        frmEstadosOCAdd.Dispose()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If vDatos.FocusedRowHandle < 0 Then Exit Sub

        If Not XtraMsg2("Esta Seguro de la acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.IdEstado = vDatos.GetFocusedRowCellValue("IdEstado")
        db.Borrar(obj)
        Cargar()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(gridDatos)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class