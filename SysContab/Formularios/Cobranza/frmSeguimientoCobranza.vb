Imports Entities

Public Class frmSeguimientoCobranza

    Dim objSeguimiento As New ClientesSeguimiento
    Dim dbSeguimiento As New db_ClientesSeguimiento
    Public IdCliente As Integer = 0

    Private Sub frmSeguimientoCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        '
        Cargar()
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 1, True, True, True, True, "Seguimiento y Acuerdos de Clientes")

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("#").OptionsColumn.AllowEdit = True
        iVista.Columns("#").ColumnEdit = rLink
        '
        iVista.Columns("IdSeguimiento").Visible = False
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("Fecha_Creacion").Visible = False
        iVista.Columns("Fecha_Modificacion").Visible = False
        iVista.Columns("Usuario_Modifica").Visible = False

        If IdCliente > 0 Then
            iVista.Columns("Codigo").Visible = False
            iVista.Columns("Cliente").Visible = False
            lyEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyAnular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        iVista.OptionsView.ShowPreview = True
        iVista.PreviewFieldName = "Acuerdo"
    End Sub

    Sub Cargar()
        iGrid.DataSource =
            dbSeguimiento.Listar(0, IdCliente, EmpresaActual)
    End Sub

    Private Sub frmSeguimientoCobranza_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        With frmDocumentos
            .Tipo = "CLIENTES"
            .Codigo = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdCliente")
            .NDocumento = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cliente")
            .Text = $"Soporte Digital del Cliente: {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cliente")}"
            .txtNombre.Text = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cliente")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        With frmSeguimientoAdd
            .Text = "Grabar Seguimiento de Cliente..."
            .ID = 0
            .IdCliente = IdCliente
            .ShowDialog()
            If .Ok Then
                ShowSplash()
                Cargar()
                HideSplash()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        With frmSeguimientoAdd
            .Text = "Modificar Acuerdo y Seguimiento..."
            .ID = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdSeguimiento")
            .IdCliente = IdCliente
            .ShowDialog()
            If .Ok Then
                ShowSplash()
                Cargar()
                HideSplash()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class