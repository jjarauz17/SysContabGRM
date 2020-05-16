Public Class frmTipoProductos

    Dim obj As New Prod_TipoProductos
    Dim db As New db_Prod_TipoProductos

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_TipoProductos.Listar(0)
        FormatoGrid(iVista)
        iVista.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmTipoProductosAdd.ID = 0
        frmTipoProductosAdd.Text = "Agregar Tipo de Producto"
        frmTipoProductosAdd.ShowDialog()
        frmTipoProductosAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmTipoProductosAdd.ID = iVista.GetFocusedRowCellValue("CodTipoProd")
        frmTipoProductosAdd.Text = "Editar Tipo de Producto"
        frmTipoProductosAdd.ShowDialog()
        frmTipoProductosAdd.Dispose()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
            Exit Sub
        End If
        '
        obj.CodTipoProd = iVista.GetFocusedRowCellValue("CodTipoProd")

        db.Borrar(obj)
        Cargar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub
End Class