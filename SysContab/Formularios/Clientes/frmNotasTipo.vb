Imports ClasesBLL
Public Class frmNotasTipo

    Private Sub frmNotasTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        iVistas.PopulateColumns()
        FormatoGridNew(iVistas, 2, 0)
        iVistas.Columns("IdTipo").Visible = False
    End Sub


    Sub Cargar()
        iGrid.DataSource =
            db_TipoNotasCD.Listar(0)
    End Sub

    Private Sub cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        With frmNotasTipoAdd
            .Text = "Agregar Tipo de Notas"
            .IdTipo = 0
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub cmdver_Click(sender As Object, e As EventArgs) Handles cmdver.Click
        Editar()
    End Sub

    Sub Editar()
        If iVistas.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        With frmNotasTipoAdd
            .Text = "Editar Tipo de Notas"
            .IdTipo = iVistas.GetRowCellValue(iVistas.FocusedRowHandle, "IdTipo")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub iVistas_DoubleClick(sender As Object, e As EventArgs) Handles iVistas.DoubleClick
        If iVistas.FocusedRowHandle < 0 Then Exit Sub
        '
        Editar()
    End Sub

    Private Sub cmdanular_Click(sender As Object, e As EventArgs) Handles cmdanular.Click

    End Sub

    Private Sub frmNotasTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class