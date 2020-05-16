Public Class frmResponsables

    Dim obj As New PNR_Responsables
    Dim db As New db_PNR_Responsables

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_PNR_Responsables.Listar(0)
        FormatoGrid(iVista)
        iVista.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmResponsablesAdd.IdResponsable = 0
        frmResponsablesAdd.Text = "Agregar Responsable de PNR"
        frmResponsablesAdd.ShowDialog()
        frmResponsablesAdd.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        frmResponsablesAdd.IdResponsable = iVista.GetFocusedRowCellValue("IdResponsable")
        frmResponsablesAdd.Text = "Editar Responsable de PNR"
        frmResponsablesAdd.ShowDialog()
        frmResponsablesAdd.Dispose()
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
        obj.IdResponsable = iVista.GetFocusedRowCellValue("IdResponsable")
        obj.Valor = 0

        Dim Valor As String = db.Borrar(obj)
        If IsNumeric(Valor) Then Cargar() Else XtraMsg(Valor, MessageBoxIcon.Error)

        'If db.Borrar(obj) Then Cargar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub
End Class