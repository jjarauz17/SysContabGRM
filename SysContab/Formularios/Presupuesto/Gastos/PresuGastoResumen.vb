Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns

Public Class PresuGastoResumen

    'Shared Sub New()
    '    DevExpress.UserSkins.BonusSkins.Register()
    '    DevExpress.Skins.SkinManager.EnableFormSkins()
    'End Sub

    'Public Sub New()
    '    InitializeComponent()

    '    cargargrid()
    'End Sub

    'Function prueba()
    '    'PresuGastoResumen.Size = New System.Drawing.Size(894, 600)
    'End Function

    Dim obj As New Presupuesto
    Dim db As New db_Presupuesto
    Dim DT_ROL As DataTable

    Private Sub PresuGastoResumen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl3)

        Application.DoEvents()
        Combo(cbPeriodo, VB.SysContab.PeriodosDB.GetList().Tables("Periodos"))
        cbPeriodo.ItemIndex = 0
        '
        Application.DoEvents()
        Cargar()
        '
        iVista.PopulateColumns()
        SimpleFormatGrid(iVista, False, DevExpress.Utils.HorzAlignment.Center, 1, 2, True, 0, 8)

        'iVista.Columns("IdPresupuesto").Visible = False
        'iVista.Columns("Registro").Visible = False
        '
        iVista.Columns("TipoCultivo").Visible = False

        'If EmpresaActual = 1 Then
        '    iVista.Columns("CentroCosto").Visible = False
        'Else
        '    iVista.Columns("Sucursal").Visible = False
        'End If


        'LookUp(
        '    cbPeriodo,
        '    ObtieneDatos("sp_sel_PeriodosPresupuestosActivos", EmpresaActual),
        '    "Nombre",
        '    "Per_Id",
        '    "[Periodo Contable]",
        '    0)

        'Inicio = True
        'cbPeriodo.EditValue = VB.SysContab.PeriodosDB.Activo(VB.SysContab.Rutinas.Fecha())
        'Inicio = False

        'LookUpEdit2.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 1, LookUpEdit1.EditValue, "", 0, False, "", 0, 0)
        'LookUpEdit2.Properties.DisplayMember = "Nombre"
        'LookUpEdit2.Properties.ValueMember = "Codigo"
        'LookUpEdit2.Properties.PopulateColumns()

        'Cargargrid()

        'Cargar()
        ''
        'iVista.PopulateColumns()
        'FormatoGridNew(iVista, 2, 1, False)
        'iVista.BestFitColumns()

        'iVista.Columns("# Empresa").Visible = False
        'iVista.Columns("Empresa").Visible = False
        'iVista.Columns("Periodo").Visible = False
        'iVista.Columns("# Cent. Cost.").Visible = False

        'iVista.Columns("# Presupuesto").OptionsColumn.AllowEdit = False
        'iVista.Columns("# Presupuesto").OptionsColumn.AllowFocus = False

        'iVista.Columns("# Empresa").OptionsColumn.AllowEdit = False
        'iVista.Columns("# Empresa").OptionsColumn.AllowFocus = False

        'iVista.Columns("Empresa").OptionsColumn.AllowEdit = False
        'iVista.Columns("Empresa").OptionsColumn.AllowFocus = False

        'iVista.Columns("# Cent. Cost.").OptionsColumn.AllowEdit = False
        'iVista.Columns("# Cent. Cost.").OptionsColumn.AllowFocus = False

        'iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
        'iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

        'iVista.Columns("Periodo").OptionsColumn.AllowEdit = False
        'iVista.Columns("Periodo").OptionsColumn.AllowFocus = False

        'iVista.Columns("Nomb_Periodo").OptionsColumn.AllowEdit = False
        'iVista.Columns("Nomb_Periodo").OptionsColumn.AllowFocus = False

        ''GridView1.Columns("Estado").OptionsColumn.AllowEdit = False
        ''GridView1.Columns("Estado").OptionsColumn.AllowFocus = False

        ''GridView1.Columns("Anulado").Visible = False

        ''If (Globales.Usr_Rol = 1) Then
        ''    GridView1.Columns("Verificado").OptionsColumn.AllowEdit = True
        ''    GridView1.Columns("Verificado").OptionsColumn.AllowFocus = True
        ''Else
        ''    GridView1.Columns("Verificado").OptionsColumn.AllowEdit = False
        ''    GridView1.Columns("Verificado").OptionsColumn.AllowFocus = False

        ''End If
    End Sub

    Sub Cargar()
        'iGrid.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 1, EmpresaActual, cbPeriodo.EditValue)
        iGrid.DataSource = db_Presupuesto.Listar(cbPeriodo.EditValue, 2)
    End Sub

    'Function Cargargrid() As Boolean

    '    mostrartodo(True)

    '    'LookUpEdit1.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 2, Globales.Usuario_ID, "", 0, False, "", 0, 0)
    '    'LookUpEdit1.Properties.DisplayMember = "NOMBRE"
    '    'LookUpEdit1.Properties.ValueMember = "CODIGO"
    '    'LookUpEdit1.Properties.PopulateColumns()

    'End Function


    'Sub mostrartodo(opc As Boolean)

    '    If (opc) Then

    '        iGrid.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 0, 0, 0)
    '        iGrid.ForceInitialize()


    '        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        FormatoGrid(iVista, 2, 0)
    '        iVista.BestFitColumns()

    '        iVista.Columns("# Presupuesto").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Presupuesto").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Empresa").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Empresa").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Empresa").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Empresa").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Cent. Cost.").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Cent. Cost.").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Periodo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Periodo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Nomb_Periodo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Nomb_Periodo").OptionsColumn.AllowFocus = False



    '        'GridView1.Columns("Estado").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Estado").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Anulado").Visible = False



    '        If (Convert.ToInt64(getdatacombo(fn.ObtieneDatos("sp_Presupuesto_return_combo", 32, Globales.Usuario_ID, "", 0, False, "", 0, 0))) = 1) Then
    '            iVista.Columns("Verificado").OptionsColumn.AllowEdit = True
    '            iVista.Columns("Verificado").OptionsColumn.AllowFocus = True
    '        Else
    '            iVista.Columns("Verificado").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Verificado").OptionsColumn.AllowFocus = False

    '        End If

    '    Else
    '        iGrid.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 2, 0, 0)
    '        iGrid.ForceInitialize()

    '        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        Utils.FormatoGrid(iVista, 2, 0)
    '        iVista.BestFitColumns()

    '        iVista.Columns("# Presupuesto").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Presupuesto").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Empresa").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Empresa").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Empresa").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Empresa").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Cent. Cost.").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Cent. Cost.").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Periodo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Periodo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Nomb_Periodo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Nomb_Periodo").OptionsColumn.AllowFocus = False

    '        'GridView1.Columns("Estado").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Estado").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Anulado").Visible = False

    '        If (Globales.Usr_Rol = 1) Then
    '            iVista.Columns("Verificado").OptionsColumn.AllowEdit = True
    '            iVista.Columns("Verificado").OptionsColumn.AllowFocus = True
    '        Else
    '            iVista.Columns("Verificado").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Verificado").OptionsColumn.AllowFocus = False

    '        End If

    '    End If






    'End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    '    '  Form2.Show()

    'End Sub

    'Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

    '    mostrartodo()
    'End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If bEditar.Enabled Then Editar()
    End Sub

    Sub Editar()
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        ShowSplash()
        PresuGastosAdd.Dispose()
        PresuGastosAdd.MdiParent = Me.MdiParent
        PresuGastosAdd.IdPresupuesto = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdPresupuesto")
        PresuGastosAdd.Show()
        PresuGastosAdd.Text = "Editar Presupuesto"
        PresuGastosAdd.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    'Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs)
    '    LookUpEdit2.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 1, LookUpEdit1.EditValue, "", 0, False, "", 0, 0)
    '    LookUpEdit2.Properties.DisplayMember = "Nombre"
    '    LookUpEdit2.Properties.ValueMember = "Codigo"
    '    LookUpEdit2.Properties.PopulateColumns()

    '    ShowSplash()
    '    If (IsNothing(LookUpEdit2.EditValue)) Then

    '        GridControl1.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 3, LookUpEdit1.EditValue, 0)
    '    Else
    '        GridControl1.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 1, LookUpEdit1.EditValue, LookUpEdit2.EditValue)
    '    End If


    '    GridView1.PopulateColumns()
    '    Utils.FormatoGrid(GridView1, 2, 0)
    '    GridView1.BestFitColumns()

    '    GridView1.Columns("# Presupuesto").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("# Presupuesto").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("# Empresa").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("# Empresa").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("Empresa").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("Empresa").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("# Cent. Cost.").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("# Cent. Cost.").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("Periodo").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("Periodo").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("Nomb_Periodo").OptionsColumn.AllowEdit = False
    '    GridView1.Columns("Nomb_Periodo").OptionsColumn.AllowFocus = False

    '    'GridView1.Columns("Estado").OptionsColumn.AllowEdit = False
    '    'GridView1.Columns("Estado").OptionsColumn.AllowFocus = False

    '    GridView1.Columns("Anulado").Visible = False

    '    If (Globales.Usr_Rol = 1) Then
    '        GridView1.Columns("Verificado").OptionsColumn.AllowEdit = True
    '        GridView1.Columns("Verificado").OptionsColumn.AllowFocus = True
    '    Else
    '        GridView1.Columns("Verificado").OptionsColumn.AllowEdit = False
    '        GridView1.Columns("Verificado").OptionsColumn.AllowFocus = False

    '    End If

    '    HideSplash()
    'End Sub



    Private Sub LookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If Inicio Then Exit Sub
        '
        ShowSplash()
        Cargar()
        HideSplash()

        'ShowSplash()
        'GridControl1.DataSource = fn.ObtieneDatos("sp_sel_PresupuestoGasto", 1, LookUpEdit1.EditValue, LookUpEdit2.EditValue)

        'GridView1.PopulateColumns()
        'Utils.FormatoGrid(GridView1, 2, 0)
        'GridView1.BestFitColumns()

        'GridView1.Columns("# Presupuesto").OptionsColumn.AllowEdit = False
        'GridView1.Columns("# Presupuesto").OptionsColumn.AllowFocus = False

        'GridView1.Columns("# Empresa").OptionsColumn.AllowEdit = False
        'GridView1.Columns("# Empresa").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Empresa").OptionsColumn.AllowEdit = False
        'GridView1.Columns("Empresa").OptionsColumn.AllowFocus = False

        'GridView1.Columns("# Cent. Cost.").OptionsColumn.AllowEdit = False
        'GridView1.Columns("# Cent. Cost.").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
        'GridView1.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Periodo").OptionsColumn.AllowEdit = False
        'GridView1.Columns("Periodo").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Nomb_Periodo").OptionsColumn.AllowEdit = False
        'GridView1.Columns("Nomb_Periodo").OptionsColumn.AllowFocus = False

        ''GridView1.Columns("Estado").OptionsColumn.AllowEdit = False
        ''GridView1.Columns("Estado").OptionsColumn.AllowFocus = False

        'GridView1.Columns("Anulado").Visible = False

        'If (Globales.Usr_Rol = 1) Then
        '    GridView1.Columns("Verificado").OptionsColumn.AllowEdit = True
        '    GridView1.Columns("Verificado").OptionsColumn.AllowFocus = True
        'Else
        '    GridView1.Columns("Verificado").OptionsColumn.AllowEdit = False
        '    GridView1.Columns("Verificado").OptionsColumn.AllowFocus = False

        'End If

        'HideSplash()
    End Sub

    'Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged

    '    If (e.Column.ToString = "Anulado") Then
    '        fn.Guardar("sp_Presupuesto_return_combo", 24, Convert.ToInt64(iVista.GetFocusedRowCellValue("# Presupuesto")), "", 0, iVista.GetFocusedRowCellValue("Anulado"), "", 0, 0)
    '    End If

    '    If (e.Column.ToString = "Verificado") Then
    '        fn.Guardar("sp_Presupuesto_return_combo", 25, Convert.ToInt64(iVista.GetFocusedRowCellValue("# Presupuesto")), "", 0, iVista.GetFocusedRowCellValue("Verificado"), "", 0, 0)
    '    End If

    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        ShowSplash()
        PresuGastosAdd.Dispose()
        PresuGastosAdd.MdiParent = Me.MdiParent
        PresuGastosAdd.IdPresupuesto = 0
        PresuGastosAdd.Show()
        PresuGastosAdd.Text = "Nuevo Presupuesto"
        PresuGastosAdd.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bAnular.Click

        'If (iVista.Columns("Anulado").Visible Like False) Then
        '    mostrartodo(False)
        '    iVista.Columns("Anulado").Visible = True
        'Else
        '    mostrartodo(True)
        '    iVista.Columns("Anulado").Visible = False
        'End If

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta Seguro de Anular este Presupuesto {iVista.GetFocusedRowCellValue("Numero")} ?") Then
            Exit Sub
        End If
        '
        obj.IdPresupuesto = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdPresupuesto")
        db.Borrar(obj)
        Cargar()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bActualizarReal.Click

        ' FormActualizarGastosReales.Show()

        If Not XtraMsg2("Este proceso actualiza el gasto Real por cuenta y Centro de Centro, " + vbCrLf +
                    "Esta Seguro de Continuar ?") Then
            Exit Sub
        End If
        '


    End Sub

    'Function getdatacombo(dt As DataTable) As String

    '    Dim i As Integer
    '    Dim k As Integer

    '    For Each row As DataRow In dt.Rows
    '        i += 1
    '    Next
    '    Dim rowData(i) As String
    '    '///////////////////////////////////////////////////////////////////////////////////////////////////
    '    For Each row As DataRow In dt.Rows
    '        For Each column As DataColumn In dt.Columns
    '            rowData(k) = rowData(k) & row(column)

    '            '& column.ColumnName & "=" 
    '        Next
    '        rowData(k) = rowData(k) & vbNewLine & vbNewLine
    '        k += 1
    '    Next
    '    Return (rowData(0))
    'End Function

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles bReporteGasto.Click

        ShowSplash("Cargando Datos...")
        frmPresupuestoVer.Dispose()
        '
        With frmPresupuestoGastoVer
            '.MdiParent = Me.MdiParent
            .Text = "Reporte Presupuesto"
            .Mostrar(
                    iVista.GetFocusedRowCellValue("IdPresupuesto"),
                    iVista.GetFocusedRowCellValue("Sucursal"),
                    iVista.GetFocusedRowCellValue("CentroCosto"),
                    iVista.GetFocusedRowCellValue("Periodo"))
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()


        'ShowSplash()
        'FrmReportDiferente.Dispose()
        'FrmReportDiferente.cargargridreport(0, 2)

        'FrmReportDiferente.Show()
        'FrmReportDiferente.WindowState = FormWindowState.Maximized
        'HideSplash()

    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        Editar()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bVerPresupuesto_Click(sender As Object, e As EventArgs) Handles bVerPresupuesto.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        ShowSplash()
        PresuGastosDetalle.Dispose()
        With New PresuGastosDetalle
            .MdiParent = Me.MdiParent
            .Text = $"Ver Presupuesto No. {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero")}"
            .Inicio(iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdPresupuesto"),
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Numero"),
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Sucursal"),
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "CentroCosto"),
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Periodo"))
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()



        'PresuGastosDetalle.mostrar(Convert.ToInt64(iVista.GetFocusedRowCellValue("# Presupuesto")), 0, iVista.GetFocusedRowCellValue("# Cent. Cost."), iVista.GetFocusedRowCellValue("# Empresa"), iVista.GetFocusedRowCellValue("Periodo"))
        'PresuGastosDetalle.MdiParent = frmPrincipalRibbon
        'PresuGastosDetalle.Show()
        'PresuGastosDetalle.Text = "Presupuesto Detallado"
        'PresuGastosDetalle.WindowState = FormWindowState.Maximized
        'HideSplash()
    End Sub
End Class