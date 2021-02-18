Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class frmFacturacionCuotas

    Dim obj As New FacturasCuotas,
        db As New db_FacturasCuotas

    Private Sub frmArregloPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)

        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 1)

        iVista.Columns("Id").Visible = False
        iVista.Columns("FechaCorte").Visible = False
        iVista.Columns("DiasGracia").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Interes").Visible = False
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = db.Listar(EmpresaActual)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With New frmFacturasCuotasAdd
            .Text = "Nuevo Factura en Cuota"
            .Id = 0
            .FromFactur = False
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        With New frmFacturasCuotasAdd
            .Text = "Ver Factura en Cuota"
            .FromFactur = False
            .Id = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Id")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado") = "Anulado" Then
            XtraMsg($"La Factura en Cuotas No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Factura")} ya se encuentra Anulada", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta Seguro de Anular la Factura en Cuotas No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")} ?") Then
            Exit Sub
        End If
        '
        obj.Id = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Id")
        obj.Empresa = EmpresaActual

        Dim msg As String = db.Borrar(obj)

        If msg.Equals("Ok") Then
            ShowSplash()
            Cargar()
            HideSplash()
        Else
            XtraMsg(msg, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, "Facturación en Cuota")
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim dbDetalle As New db_FacturasCuotasDetalle

        GridControl1.DataSource = dbDetalle.Listar(
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "Id"),
            EmpresaActual)

        GridView1.PopulateColumns()
        FormatoGrid(GridView1, 2, 0, False)
        GridView1.Columns("IdDetalle").Visible = False
        GridView1.Columns("Interes").Visible = False
        '
        db_ArregloPago.Imprimir(
            GridControl1,
            $"Factura {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Factura")} en {iVista.GetRowCellValue(iVista.FocusedRowHandle, "NoCuotas").ToString()} Cuotas",
            $"A partir de: {CDate(iVista.GetRowCellValue(iVista.FocusedRowHandle, "FechaInicio")).ToShortDateString}")
    End Sub

    Private Sub frmFacturacionCuotas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.ForeColor = Color.White
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Inicial" Then
                e.Appearance.BackColor = Color.Tomato
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "En Proceso" Then
                e.Appearance.BackColor = Color.MediumBlue
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Vencido" Then
                e.Appearance.BackColor = Color.OrangeRed
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulado" Then
                e.Appearance.BackColor = Color.Red
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Finalizado" Then
                e.Appearance.BackColor = Color.Green
            End If
        End If
    End Sub
End Class