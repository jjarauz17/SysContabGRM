Public Class frmTipoValores

    Dim obj As New Prod_TipoCostoValores
    Dim db As New db_Prod_TipoCostoValores

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_TipoCostoValores.Listar(0)
        FormatoGrid(iVista)
        iVista.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmTipoValoresAdd.ID = 0
        frmTipoValoresAdd.Text = "Agregar Tipo Valor de Costo"
        frmTipoValoresAdd.ShowDialog()
        frmTipoValoresAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmTipoValoresAdd.ID = iVista.GetFocusedRowCellValue("CodconsecutTipoCosto")
        frmTipoValoresAdd.Text = "Editar Tipo Valor de Costo"
        frmTipoValoresAdd.ShowDialog()
        frmTipoValoresAdd.Dispose()
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
        obj.CodconsecutTipoCosto = iVista.GetFocusedRowCellValue("CodconsecutTipoCosto")

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