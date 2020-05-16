Public Class FrmFormulaList

    Dim obj As New Prod_CatMaestroFormula
    Dim db As New db_Prod_CatMaestroFormula

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        FormatoGrid(iVista)
        '
        iVista.Columns("IdSysFormula").Visible = False
        iVista.Columns("Descripción").Width = 300
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Prod_CatMaestroFormula.Listar(0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando Formula...")
        FrmFormula.Dispose()
        FrmFormula.MdiParent = Me.MdiParent
        FrmFormula.IdFormula = 0
        FrmFormula.Show()
        FrmFormula.Text = "Agregar Formula"
        FrmFormula.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash("Cargando Formula...")
        FrmFormula.Dispose()
        FrmFormula.MdiParent = Me.MdiParent
        FrmFormula.IdFormula = iVista.GetFocusedRowCellValue("IdSysFormula")
        FrmFormula.Show()
        FrmFormula.Text = "Editar Formula"
        FrmFormula.WindowState = FormWindowState.Maximized
        HideSplash()
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
        obj.IdSysFormula = iVista.GetFocusedRowCellValue("IdSysFormula")
        obj.msg = ""

        Dim msg As String = db.Borrar(obj)
        If msg = "OK" Then Cargar()
        If msg <> "OK" Then XtraMsg(msg, MessageBoxIcon.Error)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs)

    End Sub
End Class