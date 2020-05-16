Public Class frmCostosProduccion

    Dim obj As New Prod_CatCostosProduccion
    Dim db As New db_Prod_CatCostosProduccion

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_CatCostosProduccion.Listar(0)
        FormatoGrid(iVista)
        iVista.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmCostosProduccionAdd.ID = 0
        frmCostosProduccionAdd.Text = "Agregar Costos"
        frmCostosProduccionAdd.ShowDialog()
        frmCostosProduccionAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmCostosProduccionAdd.ID = iVista.GetFocusedRowCellValue("CodConsecutCatCosto")
        frmCostosProduccionAdd.Text = "Editar Costos"
        frmCostosProduccionAdd.ShowDialog()
        frmCostosProduccionAdd.Dispose()
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
        obj.CodConsecutCatCosto = iVista.GetFocusedRowCellValue("CodConsecutCatCosto")

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