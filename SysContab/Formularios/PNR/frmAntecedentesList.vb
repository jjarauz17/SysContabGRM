Public Class frmAntecedentesList

    Dim obj As New PNR_Antecedentes
    Dim db As New db_PNR_Antecedentes

    Private Sub frmPlanDeAccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year        
    End Sub

    Public Sub Cargar()
        Dim DT As DataTable = db_PNR_Antecedentes.Listar(0, 0, cbPeriodo.EditValue)
        iGrid.DataSource = DT
        FormatoGrid(iVista)

        iVista.Columns("IdAntecedente").Visible = False
        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("Registro").Visible = False

        If DT.Rows.Count > 0 Then
            iVista.Columns("MZ Atenrior").Caption = "MZ " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iVista.Columns("MZ Actual").Caption = "MZ " & DT.Rows.Item(0)("Periodo").ToString
            iVista.Columns("PBS Anterior").Caption = "PBR " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iVista.Columns("PBS Actual").Caption = "PBR " & DT.Rows.Item(0)("Periodo").ToString
        End If

    End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    '    frmAntecedentesAdd.IdAntecedente = 0
    '    frmAntecedentesAdd.IdPlanNegocio = IdPlanNegocio
    '    frmAntecedentesAdd.lblCliente.Text = CuentaCliente
    '    frmAntecedentesAdd.Text = "Agregar Antecedentes..."
    '    frmAntecedentesAdd.ShowDialog()
    '    frmAntecedentesAdd.Dispose()
    'End Sub

    'Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
    '    If iVista.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un registro!")
    '        Exit Sub
    '    End If

    '    frmAntecedentesAdd.IdAntecedente = iVista.GetFocusedRowCellValue("IdPlanAccion")
    '    frmAntecedentesAdd.IdPlanNegocio = IdPlanNegocio
    '    frmAntecedentesAdd.lblCliente.Text = iVista.GetFocusedRowCellValue("Cuenta")
    '    frmAntecedentesAdd.Text = "Modificar Antecedentes..."
    '    frmAntecedentesAdd.ShowDialog()
    '    frmAntecedentesAdd.Dispose()
    'End Sub

    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
    '    If iVista.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un registro!")
    '        Exit Sub
    '    End If
    '    '
    '    If Not XtraMsg2("Esta Seguro de la Acción Solicitada?") Then
    '        Exit Sub
    '    End If
    '    '
    '    obj.IdAntecedente = iVista.GetFocusedRowCellValue("IdPlanAccion")
    '    db.Borrar(obj)
    '    Cargar()
    'End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        Editar
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Editar()
    End Sub

    Sub Editar()
        'If iVista.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione un registro!")
        '    Exit Sub
        'End If

        'frmAntecedentesAdd.IdAntecedente = iVista.GetFocusedRowCellValue("IdAntecedente")
        'frmAntecedentesAdd.IdPlanNegocio = iVista.GetFocusedRowCellValue("IdPlanNegocio")
        'frmAntecedentesAdd.lblCliente.Text = iVista.GetFocusedRowCellValue("Cuenta")
        'frmAntecedentesAdd.Text = "Modificar Antecedentes..."
        'frmAntecedentesAdd.ShowDialog()
        'frmAntecedentesAdd.Dispose()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Cargar()
    End Sub
End Class