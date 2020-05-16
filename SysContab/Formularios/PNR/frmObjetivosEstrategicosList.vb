Public Class frmObjetivosEstrategicosList

    Private Sub frmPlanDeAccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year        
    End Sub

    Sub Cargar()
        Dim DT As DataTable = db_PNR_PlanNegocio.GetObjetivosEstrategicos(cbPeriodo.EditValue)
        iGrid.DataSource = DT
        FormatoGrid(iVista)

        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("Periodo").Visible = False

        If DT.Rows.Count > 0 Then
            iVista.Columns("PBS_Anterior").Caption = "PBS " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iVista.Columns("PBS_Actual").Caption = "PBS " & DT.Rows.Item(0)("Periodo").ToString

            iVista.Columns("Ventas_Anterior").Caption = "Ventas " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iVista.Columns("Ventas_Actuales").Caption = "Ventas " & DT.Rows.Item(0)("Periodo").ToString

            iVista.Columns("Participacion_Anterior").Caption = "Participacion " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iVista.Columns("Participacion_Actual").Caption = "Participacion " & DT.Rows.Item(0)("Periodo").ToString
        End If

        iVista.Columns("Participacion_Anterior").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Participacion_Anterior").DisplayFormat.FormatString = "{0:p2}"

        iVista.Columns("Participacion_Anterior").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Participacion_Actual").DisplayFormat.FormatString = "{0:p2}"
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Cargar()
    End Sub
End Class