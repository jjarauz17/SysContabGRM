Imports DevExpress.XtraGrid.Views.Grid

Public Class frmArregloPago

    Dim obj As New ArregloPago,
        db As New db_ArregloPago

    Private Sub frmArregloPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        '
        Cargar()
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 1)
        '
        iVista.Columns("IdArreglo").Visible = False
        iVista.Columns("Interes").Visible = False
        iVista.Columns("Comentario").Visible = False
        iVista.Columns("Registro").Visible = False
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = db_ArregloPago.Listar()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        ShowSplash()
        Inicio = True
        frmArregloPagoAdd.Dispose()
        frmArregloPagoAdd.MdiParent = Me.MdiParent
        frmArregloPagoAdd.Text = "Nuevo Arreglo"
        frmArregloPagoAdd.IdArreglo = 0
        frmArregloPagoAdd.Show()
        frmArregloPagoAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Arreglos de Pagos")
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash()
        Inicio = True
        frmArregloPagoAdd.Dispose()
        frmArregloPagoAdd.MdiParent = Me.MdiParent
        frmArregloPagoAdd.Text = "Editar Arreglo"
        frmArregloPagoAdd.IdArreglo = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdArreglo")
        frmArregloPagoAdd.Estado = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado")
        frmArregloPagoAdd.Show()
        frmArregloPagoAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        iGridAP.DataSource = db_ArregloPagoDetalle.Listar(iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdArreglo"))
        GridView1.PopulateColumns()
        FormatoGrid(GridView1, 2, 0, False)

        GridView1.Columns("IdDetalle").Visible = False
        GridView1.Columns("Interes").Visible = False
        GridView1.Columns("Aplicada").Visible = False
        '
        db_ArregloPago.Imprimir(
            iGridAP,
            $"Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")}",
            $"A Partir de: {CDate(iVista.GetRowCellValue(iVista.FocusedRowHandle, "FechaInicio")).ToShortDateString()}")
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado") = "Anulado" Then
            XtraMsg($"El Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} ya se encuentra Anulado", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta Seguro de Anular el Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} ?") Then
            Exit Sub
        End If
        '
        '
        obj.IdArreglo = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdArreglo")
        Dim msg As String = db.Borrar(obj)

        If msg.Equals("Ok") Then
            ShowSplash()
            Cargar()
            HideSplash()
        Else
            XtraMsg(msg, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub frmArregloPago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub bAprobar_Click(sender As Object, e As EventArgs) Handles bAprobar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado") = "Anulado" Then
            XtraMsg($"El Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} se encuentra Anulado", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If CBool(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Aprobado")) Then
            XtraMsg($"El Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} ya fue Aprobado", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta Seguro de Aprobar el Arreglo de Pago No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} ?") Then
            Exit Sub
        End If
        '
        If db_ArregloPago.Aprobar(
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdArreglo")) Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.ForeColor = Color.White
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "En Solicitud" Then
                e.Appearance.BackColor = Color.Tomato
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "En Proceso" Then
                e.Appearance.BackColor = Color.MediumBlue
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "En Mora" Then
                e.Appearance.BackColor = Color.OrangeRed
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulado" Then
                e.Appearance.BackColor = Color.Red
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Finalizado" Then
                e.Appearance.BackColor = Color.Green
            End If
        End If

        If e.Column.FieldName = "Aprobado" Then
            If CBool(iVista.GetRowCellValue(e.RowHandle, "Aprobado")) Then
                e.Appearance.BackColor = Color.Green
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub
End Class