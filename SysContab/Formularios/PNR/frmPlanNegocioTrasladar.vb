Public Class frmPlanNegocioTrasladar

    Dim DT As DataTable

    Private Sub frmPlanNegocioTrasladar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        '
        Application.DoEvents()
        Combo(cbDestino, db_PNR_PlanNegocio.GetPeriodos())
        cbDestino.EditValue = VB.SysContab.Rutinas.Fecha().Year + 1
    End Sub

    Sub Cargar()
        DT = db_PNR_PlanNegocio.Listar2(cbPeriodo.EditValue)
        iGrid.DataSource = DT
        FormatoGrid(iVista)
        iVista.OptionsBehavior.Editable = True
        'SimpleFormatGrid(iVista, True, DevExpress.Utils.HorzAlignment.Center, 1, 2, 14, 0, 13)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Seleccinar").OptionsColumn.AllowEdit = True
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("IdCultivo").Visible = False
        iVista.Columns("IdPlanNegocio").Visible = False
        iVista.Columns("IdSucursal").Visible = False        
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Cargar()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbPeriodo.EditValue = cbDestino.EditValue Then
            XtraMsg("No se puede trasladar el PNR en el mismo perido.", MessageBoxIcon.Error)
            cbDestino.Focus()
            Exit Sub
        End If
        '
        Dim CantidadPNR As Integer = 0, DT_SELECT As DataTable = Nothing

        Try
            DT_SELECT = DT.Select("Seleccinar = 1").CopyToDataTable
            CantidadPNR = DT_SELECT.Rows.Count

        Catch ex As Exception
            XtraMsg("Favor Seleccionar al menos 1 PNR", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        For i As Integer = 4 To DT_SELECT.Columns.Count - 1

            Try
                DT_SELECT.Columns.Remove(DT_SELECT.Columns(4).ColumnName)
            Catch ex As Exception
            End Try

        Next

        If Not XtraMsg2("Esta por trasladar " & DT_SELECT.Rows.Count.ToString & " PNR al periodo " & cbDestino.EditValue.ToString & vbCrLf & _
                    "Esta seguro de la acción solicitada?") Then
            Exit Sub

        End If

        ShowSplash("Guardando...")
        If db_PNR_PlanNegocio.GuardarPNR_Trasladar(cbPeriodo.EditValue, cbDestino.EditValue, DT_SELECT) Then
            HideSplash()
            XtraMsg("El Traslado de los PNR seleccionados se realizo con éxito!")
            Cargar()
        Else
            HideSplash()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Seleccinar", CheckEdit1.Checked)
        Next
        iVista.RefreshData()
    End Sub
End Class