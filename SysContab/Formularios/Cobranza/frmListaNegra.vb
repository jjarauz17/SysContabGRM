Imports Entities
Public Class frmListaNegra

    Dim dbClientesLN As New db_ClientesListNegra

    Private Sub frmListaNegra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        '
        Cargar()
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 1, True, True, True, True, "Lista Negra de Clientes")
        '
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        iVista.Columns("IdLista").Visible = False
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("Contacto").Visible = False
        iVista.Columns("Tel.Contacto").Visible = False
        iVista.Columns("Gerente").Visible = False
        iVista.Columns("Tel.Gerente").Visible = False
        iVista.Columns("Representante").Visible = False
        iVista.Columns("Dirección").Visible = False
        iVista.Columns("Tel.Representante").Visible = False
        iVista.Columns("ComentarioExtra").Visible = False
        iVista.Columns("Registro").Visible = False
        '
        iVista.Columns("Cliente").Width = 200
        iVista.Columns("#1").OptionsColumn.AllowEdit = True
        iVista.Columns("#1").Caption = "#"
        iVista.Columns("#1").ColumnEdit = rLink1
        iVista.Columns("#1").Width = 40
        iVista.Columns("#2").OptionsColumn.AllowEdit = True
        iVista.Columns("#2").Caption = "#"
        iVista.Columns("#2").ColumnEdit = rLink2
        iVista.Columns("#2").Width = 40
        iVista.Columns("#3").OptionsColumn.AllowEdit = True
        iVista.Columns("#3").Caption = "#"
        iVista.Columns("#3").ColumnEdit = rLink3
        iVista.Columns("#3").Width = 40

        iVista.OptionsView.ShowPreview = True
        iVista.PreviewFieldName = "Comentario"
    End Sub

    Sub Cargar()
        iGrid.DataSource =
            dbClientesLN.Listar(0, EmpresaActual)
    End Sub

    Private Sub frmListaNegra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        With frmListaNegraAdd
            .Text = "LISTA NEGRA"
            .IdLista = 0
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro.")
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta seguro de Anular a este cliente: {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cliente")} de la Lista Negra?") Then
            Exit Sub
        End If
        '
        With frmListaNegraAdd
            .Text = "LISTA NEGRA"
            .IdLista = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdLista")
            .IsAnula = True
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub rLink1_Click(sender As Object, e As EventArgs) Handles rLink1.Click
        With frmListaNegraAdd
            .Text = "LISTA NEGRA"
            .IdLista = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdLista")
            .IsAnula = False
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub rLink2_Click(sender As Object, e As EventArgs) Handles rLink2.Click
        With frmListaNegraAdd
            .Text = "LISTA NEGRA"
            .IdLista = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdLista")
            .IsAnula = True
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub rLink3_Click(sender As Object, e As EventArgs) Handles rLink3.Click
        frmSeguimientoCobranza.Dispose()

        With frmSeguimientoCobranza
            .Text = $"Seguimiento a Cliente: {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cliente")}"
            .IdCliente = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdCliente")
            .ShowDialog()
        End With
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub


End Class