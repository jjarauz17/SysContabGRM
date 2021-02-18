Imports DevExpress.XtraLayout
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraTab.ViewInfo

Public Class frmReportesClientes

    Dim Reporte As Integer = 1

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Select Case tcgReporte.SelectedTabPageIndex
            Case 0
                frmExportarImprimir.Mostrar(iPivotGrid, lblTitulo1.Text)
            Case 1
                frmExportarImprimir.Mostrar(iPivotGrid2, lblTitulo2.Text)
            Case 2
                frmExportarImprimir.Mostrar(iGrid, lblTitulo3.Text)
            Case 3
                frmExportarImprimir.Mostrar(iPivotVenta, lblTitulo4.Text)
        End Select
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub frmReportesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Fecha As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(Fecha.Year, Fecha.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(Fecha).Date

        Combo(
            cbCheckSucursal,
            ObtieneDatos("JAR_GetSucursalesxUsuario",
                         EmpresaActual))

        cbCheckSucursal.CheckAll()

        LookUp(
            cbRubro,
            ObtieneDatos("JAR_GetRubrosClientesxUsuario",
                         EmpresaActual),
            "Display",
            "Cuenta",
            "[Seleccione Rubro]",
            2)

        cbRubro.ItemIndex = 0
        GetMonedasList(cbMoneda)
        cbMoneda.ItemIndex = 1
        '
        'iGrid.DataSource =
        '        ObtieneDatos("sp_ReporteCartera1",
        '                     Desde.DateTime.Date,
        '                     Hasta.DateTime.Date,
        '                     cbCheckSucursal.EditValue,
        '                     cbRubro.EditValue,
        '                     cbMoneda.EditValue,
        '                     EmpresaActual)
        'iVista.PopulateColumns()
        'FormatoGrid(iVista, 2, 0, False)
        '
        LlenarPivot1(0)
        LlenarPivot2(0)
        LlenarPivot3(0)
        LlenarGrid(0)

        lblTitulo1.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        tcgReporte.SelectedTabPageIndex = 0
    End Sub

    Private Sub LlenarPivot1(IdEmpresa As Integer)
        Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera1",
                             Desde.DateTime.Date,
                             Hasta.DateTime.Date,
                             IIf(IdEmpresa = 0, "XXX", cbCheckSucursal.EditValue),
                             IIf(IdEmpresa = 0, "XXX", cbRubro.EditValue),
                             cbMoneda.EditValue,
                             IdEmpresa)

        iPivotGrid.DataSource = DT
        iPivotGrid.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '   
        With iPivotGrid
            For i As Integer = 0 To .Fields.Count - 1
                If .Fields(i).DataType.FullName = "System.Double" Or
                    .Fields(i).DataType.FullName = "System.Decimal" Then
                    .Fields(i).CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Fields(i).CellFormat.FormatString = "{0:#,##.0#;(#,##.0#);\0.00}"
                End If
            Next
        End With
        '
        iPivotGrid.Fields("Sucursal").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '                        
        iPivotGrid.Fields("Monto").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Estado").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Sucursal").Width = 250

        iPivotGrid.OptionsView.ShowColumnTotals = False
        iPivotGrid.OptionsView.ShowColumnGrandTotals = False

        iPivotGrid.OptionsSelection.MultiSelect = True
        'iPivotGrid.OptionsView.ShowRowTotals = False
        'iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub LlenarPivot2(IdEmpresa As Integer)
        Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera2",
                             Desde.DateTime.Date,
                             Hasta.DateTime.Date,
                             IIf(IdEmpresa = 0, "XXX", cbCheckSucursal.EditValue),
                             IIf(IdEmpresa = 0, "XXX", cbRubro.EditValue),
                             cbMoneda.EditValue,
                             IdEmpresa)

        iPivotGrid2.DataSource = DT
        iPivotGrid2.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '   
        With iPivotGrid2
            For i As Integer = 0 To .Fields.Count - 1
                If .Fields(i).DataType.FullName = "System.Double" Or
                    .Fields(i).DataType.FullName = "System.Decimal" Then
                    .Fields(i).CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Fields(i).CellFormat.FormatString = "{0:#,##.0#;(#,##.0#);\0.00}"
                End If
            Next
        End With
        '
        'iPivotGrid2.Fields("Sucursal").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid2.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid2.Fields("Celular").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid2.Fields("Factura").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid2.Fields("Vencimiento").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid2.Fields("Dias").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '
        iPivotGrid2.Fields("Saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid2.Fields("Periodo").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid2.Fields("Cliente").Width = 250
        iPivotGrid2.Fields("Sucursal").Width = 250

        iPivotGrid2.OptionsView.ShowColumnTotals = True
        iPivotGrid2.OptionsView.ShowColumnGrandTotals = True
        '
        iPivotGrid2.OptionsSelection.MultiSelect = True
    End Sub

    Private Sub LlenarPivot3(IdEmpresa As Integer)
        Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera4",
                             Desde.DateTime.Date,
                             Hasta.DateTime.Date,
                             IIf(IdEmpresa = 0, "XXX", cbCheckSucursal.EditValue),
                             IIf(IdEmpresa = 0, "XXX", cbRubro.EditValue),
                             cbMoneda.EditValue,
                             IdEmpresa)

        iPivotVenta.DataSource = DT
        iPivotVenta.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotVenta.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '   
        With iPivotVenta
            For i As Integer = 0 To .Fields.Count - 1
                If .Fields(i).DataType.FullName = "System.Double" Or
                    .Fields(i).DataType.FullName = "System.Decimal" Then
                    .Fields(i).CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Fields(i).CellFormat.FormatString = "{0:#,##.0#;(#,##.0#);\0.00}"
                End If
            Next
        End With
        '
        iPivotVenta.Fields("Sucursal").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '
        iPivotVenta.Fields("Sub Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotVenta.Fields("Impuesto").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotVenta.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotVenta.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotVenta.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotVenta.Fields("Cliente").Width = 250
        iPivotVenta.Fields("Sucursal").Width = 250

        iPivotVenta.OptionsView.ShowColumnTotals = True
        iPivotVenta.OptionsView.ShowColumnGrandTotals = True
        '
        iPivotVenta.OptionsSelection.MultiSelect = True
        'iPivotVenta.OptionsView.ShowRowTotals = False
        'iPivotVenta.OptionsView.ShowRowGrandTotals = True
    End Sub

    Sub LlenarGrid(IdEmpresa As Integer)
        iGrid.DataSource =
              ObtieneDatos("sp_ReporteCartera3",
                           Desde.DateTime.Date,
                           Hasta.DateTime.Date,
                           IIf(IdEmpresa = 0, "XXX", cbCheckSucursal.EditValue),
                           IIf(IdEmpresa = 0, "XXX", cbRubro.EditValue),
                           cbMoneda.EditValue,
                           IIf(IdEmpresa = 0, 1, IIf(CheckEdit1.Checked, 1, 0)),
                           IdEmpresa)

        iVista.Columns("Factura").Visible = CheckEdit1.Checked
        iVista.Columns("Fecha").Visible = CheckEdit1.Checked
        iVista.Columns("Vencimiento").Visible = CheckEdit1.Checked

        If IdEmpresa = 0 Then
            iVista.PopulateColumns()
            FormatoGrid(iVista, 2, 0, False)

            iVista.Columns("Factura").Visible = False
            iVista.Columns("Fecha").Visible = False
            iVista.Columns("Vencimiento").Visible = False
            iVista.Columns("Telefono").Visible = False
            iVista.Columns("Celular").Visible = False
            iVista.Columns("Correo").Visible = False
            iVista.Columns("Dirección").Visible = False
            iVista.Columns("Tipo Cliente").Visible = False
            iVista.Columns("Cedula").Visible = False
            iVista.Columns("RUC").Visible = False
            iVista.Columns("Categoria").Visible = False
            iVista.Columns("Clasificación").Visible = False
            iVista.Columns("Limite Crédito").Visible = False
            iVista.Columns("Contacto").Visible = False
            iVista.Columns("Correo Contacto").Visible = False
            iVista.Columns("Ced. Contacto").Visible = False
            iVista.Columns("Tel. Contacto").Visible = False
            iVista.Columns("Cel. Contacto").Visible = False
            iVista.Columns("Representante").Visible = False
            iVista.Columns("Correo Representante").Visible = False
            iVista.Columns("Ced. Representante").Visible = False
            iVista.Columns("Tel. Representante").Visible = False
            iVista.Columns("Cel. Representante").Visible = False
            iVista.Columns("Gerente").Visible = False
            iVista.Columns("Correo Gerente").Visible = False
            iVista.Columns("Ced. Gerente").Visible = False
            iVista.Columns("Tel. Gerente").Visible = False
            iVista.Columns("Cel. Gerente").Visible = False
            iVista.Columns("Contador").Visible = False
            iVista.Columns("Correo Contador").Visible = False
            iVista.Columns("Ced. Contador").Visible = False
            iVista.Columns("Tel. Contador").Visible = False
            iVista.Columns("Cel. Contador").Visible = False
            iVista.Columns("Observaciones").Visible = False
            iVista.Columns("Cultivo").Visible = False
            iVista.Columns("AgroServicio").Visible = False
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        ShowSplash("Generando Reporte...")
        '
        Select Case tcgReporte.SelectedTabPageIndex
            Case 0
                Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera1",
                            Desde.DateTime.Date,
                            Hasta.DateTime.Date,
                            cbCheckSucursal.EditValue,
                            cbRubro.EditValue,
                            cbMoneda.EditValue,
                            EmpresaActual)

                iPivotGrid.DataSource = DT
            Case 1
                Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera2",
                            Desde.DateTime.Date,
                            Hasta.DateTime.Date,
                            cbCheckSucursal.EditValue,
                            cbRubro.EditValue,
                            cbMoneda.EditValue,
                            EmpresaActual)

                iPivotGrid2.DataSource = DT
            Case 2
                LlenarGrid(EmpresaActual)
            Case 3
                Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera4",
                        Desde.DateTime.Date,
                        Hasta.DateTime.Date,
                        cbCheckSucursal.EditValue,
                        cbRubro.EditValue,
                        cbMoneda.EditValue,
                        EmpresaActual)

                iPivotVenta.DataSource = DT
        End Select

        HideSplash()
        'Cargar()
    End Sub

    Sub Cargar()
        ShowSplash("Generando...")
        If Reporte = 1 Then

            ' LlenarPivot1(EmpresaActual)

            'iGrid.DataSource =
            '    ObtieneDatos("sp_ReporteCartera1",
            '                 Desde.DateTime.Date,
            '                 Hasta.DateTime.Date,
            '                 cbCheckSucursal.EditValue,
            '                 cbRubro.EditValue,
            '                 cbMoneda.EditValue,
            '                 EmpresaActual)
            'iVista.PopulateColumns()
            'FormatoGrid(iVista, 2, 0, False)

            'Venta vs Recuperacion
            'iPivotGrid.DataSource =
            '    ObtieneDatos("sp_ReporteCartera1",
            '                 Desde.DateTime.Date,
            '                 Hasta.DateTime.Date,
            '                 cbCheckSucursal.EditValue,
            '                 cbRubro.EditValue,
            '                 cbMoneda.EditValue,
            '                 EmpresaActual)
            'ElseIf Reporte = 2 Then
            '    'Proximas a Vencer
            '    iPivotGrid.DataSource =
            '        ObtieneDatos("sp_ReporteCartera2",
            '                     Desde.DateTime.Date,
            '                     Hasta.DateTime.Date,
            '                     cbRubro.EditValue,
            '                     cbMoneda.EditValue,
            '                     EmpresaActual)
            Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera1",
                            Desde.DateTime.Date,
                            Hasta.DateTime.Date,
                            cbCheckSucursal.EditValue,
                            cbRubro.EditValue,
                            cbMoneda.EditValue,
                            EmpresaActual)

            iPivotGrid.DataSource = DT
        ElseIf Reporte = 2 Then
            Dim DT As DataTable = ObtieneDatos("sp_ReporteCartera2",
                            Desde.DateTime.Date,
                            Hasta.DateTime.Date,
                            cbCheckSucursal.EditValue,
                            cbRubro.EditValue,
                            cbMoneda.EditValue,
                            EmpresaActual)

            iPivotGrid2.DataSource = DT
        ElseIf Reporte = 3 Then
            'Saldos de Clientes
            iGrid.DataSource =
                ObtieneDatos("sp_ReporteCartera3",
                             Desde.DateTime.Date,
                             Hasta.DateTime.Date,
                             cbCheckSucursal.EditValue,
                             cbRubro.EditValue,
                             cbMoneda.EditValue,
                             IIf(CheckEdit1.Checked, 1, 0),
                             EmpresaActual)
            iVista.PopulateColumns()
            FormatoGrid(iVista, 2, 0, False)
        End If
        HideSplash()
    End Sub

    Private Sub nReporte1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nReporte1.LinkClicked
        Reporte = 1
        'lblTitulo1.Text = sender.Caption + " del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        lblTitulo1.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString



        lyPivot1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        lyDetalle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lyPivot2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'Cargar()
    End Sub

    Private Sub nReporte2_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nReporte2.LinkClicked
        Reporte = 2
        'lblTitulo1.Text = sender.Caption + " del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        lblTitulo2.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString

        lyPivot2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        lyDetalle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lyPivot1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'Cargar()
    End Sub

    Private Sub nReporte3_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nReporte3.LinkClicked
        Reporte = 3
        'lblTitulo1.Text = sender.Caption + " del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        lblTitulo3.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString

        lyDetalle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        lyPivot1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lyPivot2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        If iVista.DataRowCount = 0 Then
            iGrid.DataSource =
               ObtieneDatos("sp_ReporteCartera3",
                            Desde.DateTime.Date,
                            Hasta.DateTime.Date,
                            cbCheckSucursal.EditValue,
                            cbRubro.EditValue,
                            cbMoneda.EditValue,
                            0,
                            0)
            iVista.PopulateColumns()
            FormatoGrid(iVista, 2, 0, False)
        End If

        'Cargar()
    End Sub

    Private Sub nReporte4_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nReporte4.LinkClicked
        Reporte = 4
        lblTitulo4.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyPivot1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'Cargar()
    End Sub

    Private Sub iPivotGrid_Click(sender As Object, e As EventArgs) Handles iPivotGrid.Click

    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle de Movimientos"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance
        If e.DataField.FieldName = "Monto" Then
            If e.Value < 0.00 Then
                e.Appearance.ForeColor = Color.OrangeRed
            End If
        End If
    End Sub

    Private Sub iPivotGrid2_CustomAppearance(sender As Object, e As PivotCustomAppearanceEventArgs) Handles iPivotGrid2.CustomAppearance
        If e.DataField.FieldName = "Saldo" Then
            If e.Value < 0.00 Then
                e.Appearance.ForeColor = Color.OrangeRed
            End If
        End If
    End Sub

    Private Sub iPivotGrid2_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid2.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle de Movimientos"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub tcgReporte_SelectedPageChanged(sender As Object, e As LayoutTabPageChangedEventArgs) Handles tcgReporte.SelectedPageChanged

        TitulosReportes()

    End Sub

    Sub TitulosReportes()
        Select Case tcgReporte.SelectedTabPageIndex
            Case 0
                lblTitulo1.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
            Case 1
                lblTitulo2.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
            Case 2
                lblTitulo3.Text = "Al Corte " + Hasta.DateTime.ToShortDateString
            Case 3
                lblTitulo4.Text = "Del Periodo " + Desde.DateTime.ToShortDateString + " Al " + Hasta.DateTime.ToShortDateString
        End Select
    End Sub

    Private Sub tcgReporte_CustomHeaderButtonClick(sender As Object, e As CustomHeaderButtonEventArgs) Handles tcgReporte.CustomHeaderButtonClick

    End Sub

    Private Sub tcgReporte_Click(sender As Object, e As EventArgs) Handles tcgReporte.Click
        'If tcgReporte.SelectedTabPageIndex = 0 Then

        'End If

    End Sub

    Private Sub CheckEdit4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit4.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit4.Checked
        '
        If CheckEdit4.Checked Then
            CheckEdit4.Text = "Mostrar Sub Totales"
        Else
            CheckEdit4.Text = "Quitar Sub Totales"
        End If
    End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit3.Checked
        '
        If CheckEdit3.Checked Then
            CheckEdit3.Text = "Mostrar Gran Total"
        Else
            CheckEdit3.Text = "Quitar Gran Total"
        End If
    End Sub

    Private Sub CheckEdit5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit5.CheckedChanged
        iPivotGrid2.OptionsView.ShowRowTotals = Not CheckEdit5.Checked
        '
        If CheckEdit5.Checked Then
            CheckEdit5.Text = "Mostrar Sub Totales"
        Else
            CheckEdit5.Text = "Quitar Sub Totales"
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        iPivotGrid2.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
        '
        If CheckEdit2.Checked Then
            CheckEdit2.Text = "Mostrar Gran Total"
        Else
            CheckEdit2.Text = "Quitar Gran Total"
        End If
    End Sub

    Private Sub CheckEdit6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit6.CheckedChanged
        iPivotVenta.OptionsView.ShowRowTotals = Not CheckEdit6.Checked
        '
        If CheckEdit6.Checked Then
            CheckEdit6.Text = "Mostrar Sub Totales"
        Else
            CheckEdit6.Text = "Quitar Sub Totales"
        End If
    End Sub

    Private Sub CheckEdit7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit7.CheckedChanged
        iPivotVenta.OptionsView.ShowRowGrandTotals = Not CheckEdit7.Checked
        '
        If CheckEdit7.Checked Then
            CheckEdit7.Text = "Mostrar Gran Total"
        Else
            CheckEdit7.Text = "Quitar Gran Total"
        End If
    End Sub

    Private Sub CheckEdit8_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasDatos.CheckedChanged
        If chkMasDatos.Checked Then iVista.ShowCustomization()
        If Not chkMasDatos.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        chkMasDatos.Checked = False
    End Sub

    Private Sub Desde_EditValueChanged(sender As Object, e As EventArgs) Handles Desde.EditValueChanged, Hasta.EditValueChanged
        TitulosReportes()
    End Sub

End Class