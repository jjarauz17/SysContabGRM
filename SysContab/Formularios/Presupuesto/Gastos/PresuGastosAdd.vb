Imports System.ComponentModel
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class PresuGastosAdd
    'Public Sub New()

    '    InitializeComponent()
    '    'VB.SysContab.PeriodosDB.Actual()
    '    'VB.SysContab.PeriodosDB.Activo(Fecha:=DateTime.Now.ToString("dd/MM/yyyy"))
    '    loadcombo()

    '    TextEdit2.Properties.AllowFocused = False
    '    TextEdit3.Properties.AllowFocused = False
    '    'TextEdit16.Properties.AllowFocused = False

    'End Sub

    Public IdPresupuesto As Integer = 0

    Dim obj As New Presupuesto,
        db As New db_Presupuesto,
        objDetalle As New PresupuestoDetalleGastos,
        dbDetalle As New db_PresupuestoDetalleGastos,
        Catalogo As New db_CATALOGO

    Dim DT_DTL As DataTable = New DataTable("Presupuesto")

    Private Sub PresuGastosAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddValidation(Me, DxValidationProvider1)
        '
        CargaInicial()
        ArmarGrid()
        If IdPresupuesto > 0 Then bVer.Enabled = True
    End Sub

    Sub CargaInicial()
        Application.DoEvents()
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        '
        Application.DoEvents()
        MostrarDatos()
        '
        Application.DoEvents()
        Cargar()
    End Sub

    Sub ArmarGrid()
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 2, False, True, True)

        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        iVista.OptionsView.ColumnAutoWidth = False
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("TotalReal").Visible = False
        iVista.Columns("Editable").Visible = False

        iVista.Columns("Grupo").Width = 200
        iVista.Columns("Cuenta").Width = 250
        iVista.Columns("Nota").Width = 250

        iVista.Columns("Grupo").ColumnEdit = cbGrupos
        iVista.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVista.Columns("Enero").ColumnEdit = rMontos
        iVista.Columns("Febrero").ColumnEdit = rMontos
        iVista.Columns("Marzo").ColumnEdit = rMontos
        iVista.Columns("Abril").ColumnEdit = rMontos
        iVista.Columns("Mayo").ColumnEdit = rMontos
        iVista.Columns("Junio").ColumnEdit = rMontos
        iVista.Columns("Julio").ColumnEdit = rMontos
        iVista.Columns("Agosto").ColumnEdit = rMontos
        iVista.Columns("Septiembre").ColumnEdit = rMontos
        iVista.Columns("Octubre").ColumnEdit = rMontos
        iVista.Columns("Noviembre").ColumnEdit = rMontos
        iVista.Columns("Diciembre").ColumnEdit = rMontos
        iVista.Columns("Total").ColumnEdit = rMontos

        iVista.Columns("Grupo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Cuenta").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Activo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        iVista.Columns("Grupo").OptionsColumn.AllowEdit = False
        iVista.Columns("Grupo").OptionsColumn.AllowFocus = False

        iVista.Columns("Total").OptionsColumn.AllowEdit = False
        iVista.Columns("Total").OptionsColumn.AllowFocus = False
    End Sub

    Sub CargarCombos()

        Application.DoEvents()
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
        cbSucursal.ItemIndex = 0
        '
        GetCentrosCostosList(cbCentro, 1)
        cbCentro.ItemIndex = 0

        'If CInt(EmpresaActual) = 1 Then
        '    Application.DoEvents()
        '    Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
        '    cbSucursal.ItemIndex = 0
        'Else
        '    GetCentrosCostosList(cbSucursal, 1)
        '    cbSucursal.ItemIndex = 0
        '    lySucursal.Text = "Centro de Costo:"
        'End If
        '
        Application.DoEvents()
        Combo(cbPeriodo, VB.SysContab.PeriodosDB.GetList().Tables("Periodos"))
        cbPeriodo.ItemIndex = 0
        '
        Application.DoEvents()
        RepositorySearchLook(
         cbCatalogo,
         ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual, "R"),
         "Display",
         "Cuenta",
         2)
        '
        Application.DoEvents()
        RepositoryItemLookUpEdit(cbGrupos, ObtieneDatos("sp_sel_GRUPOS", "R", EmpresaActual), "Nombre", "Codigo", 0)

        'Application.DoEvents()
        'RepositoryGridLookup(cbItems, ObtieneDatos("sp_ArticulosPresupuestoList", EmpresaActual), "Nombre", "Codigo")
    End Sub

    Sub MostrarDatos()
        If IdPresupuesto = 0 Then
            Numero.Text =
                db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), 2, cbPeriodo.EditValue)

            txtUsuario.Text = VB.SysContab.SeguridadDB.GetLogin(Login).Rows.Item(0)("Usr_NombreCompleto")
            '
            bVer.Enabled = False
        Else
            obj = db_Presupuesto.Detalles(IdPresupuesto)

            Fecha.DateTime = obj.Fecha
            Numero.Text = obj.Codigo
            cbPeriodo.EditValue = obj.Periodo
            cbSucursal.EditValue = obj.IdSucursal   ' IIf(EmpresaActual.Equals("1"), obj.IdSucursal, obj.IdCentroCosto)
            cbCentro.EditValue = obj.IdCentroCosto
            mDescripcion.Text = obj.Descripcion
            txtUsuario.Text = VB.SysContab.SeguridadDB.GetLogin(obj.Usuario).Rows.Item(0)("Usr_NombreCompleto")

            cbSucursal.Properties.ReadOnly = True
            bVer.Enabled = True
        End If
    End Sub

    Sub Cargar()
        DT_DTL =
            dbDetalle.Listar(IdPresupuesto, EmpresaActual)
        iGrid.DataSource = DT_DTL
    End Sub


    'Public Function loadcombo()
    '    Dim index As Integer = 0
    '    'TextEdit16.Text = Globales.Usuario_ID

    '    txtUsuario.Text = Usr_Nombre

    '    '/////////////////////////////////////////EMPRESA////////////////////////////////////////////
    '    LookUpEdit11.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 2, Globales.Usuario_ID, "", 0, False, "", 0, 0)
    '    LookUpEdit11.Properties.DisplayMember = "NOMBRE"
    '    LookUpEdit11.Properties.ValueMember = "CODIGO"
    '    LookUpEdit11.Properties.PopulateColumns()

    '    LookUpEdit11.EditValue = Globales.EmpresaActual


    'End Function
    Function getdatacombo(dt As DataTable) As String

        Dim i As Integer
        Dim k As Integer
        For Each row As DataRow In dt.Rows
            i += 1
        Next
        Dim rowData(i) As String
        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                rowData(k) = rowData(k) & row(column)

                '& column.ColumnName & "=" 
            Next
            rowData(k) = rowData(k) & vbNewLine & vbNewLine
            k += 1
        Next
        Return (rowData(0))
    End Function


    Function validaestimado(opc As String) As Double


        If (IsNull(iVista.GetFocusedRowCellValue(opc).ToString) = "") Then
            Return 0
        Else
            Return Convert.ToInt32(iVista.GetFocusedRowCellValue(opc))

        End If


    End Function

    '    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs)


    '        cbPeriodo.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 1, LookUpEdit11.EditValue, "", 0, False, "", 0, 0)
    '        cbPeriodo.Properties.DisplayMember = "Nombre"
    '        cbPeriodo.Properties.ValueMember = "Codigo"
    '        cbPeriodo.Properties.PopulateColumns()
    '        cbPeriodo.EditValue = Convert.ToInt64(VB.SysContab.PeriodosDB.Actual())
    '        'VB.SysContab.PeriodosDB.Activo(Fecha:=DateTime.Now.ToString("dd/MM/yyyy"))


    '        ' LookUpEdit4.EditValue = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Actual).Descripcion.ToString()


    '        cbCentroCosto.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 5, LookUpEdit11.EditValue, "", 0, False, "", 0, 0)
    '        cbCentroCosto.Properties.DisplayMember = "Nombre"
    '        cbCentroCosto.Properties.ValueMember = "Codigo"

    '        'LookUpEdit3.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 7, LookUpEdit11.EditValue, "", 0, False, "", 0, 0)
    '        'LookUpEdit3.Properties.DisplayMember = "NOMBRE"
    '        'LookUpEdit3.Properties.ValueMember = "CUENTA"


    '    End Sub

    '    Private Sub LookUpEdit2_EditValueChanged(sender As Object, e As EventArgs)
    '        ShowSplash()

    '        If (fn.IsNull(cbCentroCosto.EditValue.ToString) = "") Then
    '            cbSucursal.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 0, LookUpEdit11.EditValue, "", 0, False, "", 0, 0)
    '            cbSucursal.Properties.DisplayMember = "SucursalNombre"
    '            cbSucursal.Properties.ValueMember = "CODIGO_BODEGA"
    '            cbSucursal.EditValue = Convert.ToInt64(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 0, LookUpEdit11.EditValue, "", 0, False, "", 0, 0)))
    '            Return
    '        End If

    '        Dim salida As String

    '        salida = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 10, cbCentroCosto.EditValue, "", cbPeriodo.EditValue, False, "", 0, LookUpEdit11.EditValue))
    '        If (salida = "") Then
    '            salida = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 11, 0, "", 0, False, "", 0, 0))
    '            If (salida = "") Then
    '                Numero.Text = 1
    '            Else
    '                Numero.Text = Convert.ToInt64(salida) + 1
    '            End If
    '        Else
    '            Numero.Text = Convert.ToInt64(salida)
    '        End If


    '        cbSucursal.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 0, LookUpEdit11.EditValue, "", cbCentroCosto.EditValue, False, "", 0, 0)
    '        cbSucursal.Properties.DisplayMember = "SucursalNombre"
    '        cbSucursal.Properties.ValueMember = "CODIGO_BODEGA"
    '        cbSucursal.EditValue = Convert.ToInt64(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 3, LookUpEdit11.EditValue, "", cbCentroCosto.EditValue, False, "", 0, 0)))


    '        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '        iGrid.DataSource =
    'fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", Convert.ToInt64(Numero.Text), 6)
    '        iVista.PopulateColumns()
    '        Utils.FormatoGrid(iVista, 2, 0)
    '        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
    '        iVista.OptionsView.ColumnAutoWidth = True


    '        lookupgrid()




    '        'GridView1.EditingValue = Convert.ToInt64(GridView1.GetFocusedRowCellValue("Centro de Costo"))
    '        iVista.AddNewRow()
    '        iVista.UpdateCurrentRow()
    '        iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("Centro de Costo"), cbCentroCosto.EditValue.ToString)



    '        If (validaanula(ObtieneDatos("sp_Presupuesto_return_combo", 26, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))) Then
    '            'fn.XtraMsg("Existe Un Registro Anulado Para El Centro de Costo " + LookUpEdit2.EditValue.ToString)
    '            ' fn.XtraMsg2("Existe Un Registro Anulado Para El Centro de Costo ")

    '            If (fn.XtraMsg2("Existe Un Registro Anulado Para El Centro de Costo" + Chr(13) + Chr(10) + "Desea restaurarlo?")) Then
    '                ShowSplash()
    '                fn.Guardar("sp_Presupuesto_return_combo", 24, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0)
    '                HideSplash()
    '            Else
    '                ShowSplash()
    '                If (IsNull(iVista.GetRowCellValue(0, iVista.Columns("ID Gasto")).ToString) <> "") Then

    '                    If (fn.IsNull(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 29, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))) <> "") Then
    '                        '    ObtieneDatos("sp_Presupuesto_return_combo", 10, LookUpEdit2.EditValue, "", LookUpEdit4.EditValue, False, "", 0, LookUpEdit11.EditValue)

    '                        '    (ObtieneDatos("sp_Presupuesto_return_combo", 23, 0, GridView1.GetFocusedRowCellValue("Cuenta Contable"), 0, False, GridView1.GetFocusedRowCellValue("Centro de Costo"), 0, 0)
    '                        'End If
    '                        fn.Guardar("sp_Presupuesto_return_combo", 28, Convert.ToInt64(iVista.GetRowCellValue(0, iVista.Columns("ID Gasto"))), "", 0, False, "", 0, 0)
    '                        fn.Guardar("sp_Presupuesto_return_combo", 30, Convert.ToInt64(iVista.GetRowCellValue(0, iVista.Columns("ID Gasto"))), "", 0, False, "", 0, 0)
    '                    End If
    '                End If
    '                iGrid.DataSource =
    'fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", Convert.ToInt64(Numero.Text), 1)
    '                iVista.PopulateColumns()
    '                Utils.FormatoGrid(iVista, 2, 0)
    '                iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
    '                iVista.OptionsView.ColumnAutoWidth = True



    '                lookupgrid()



    '                'GridView1.EditingValue = Convert.ToInt64(GridView1.GetFocusedRowCellValue("Centro de Costo"))
    '                iVista.AddNewRow()
    '                iVista.UpdateCurrentRow()
    '                iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("Centro de Costo"), cbCentroCosto.EditValue.ToString)

    '            End If
    '        End If

    '        HideSplash()

    '        'GridView1.Columns("# Presupuesto").Visible = False
    '        'GridView1.Columns("Periodo").Visible = False
    '        'GridView1.Columns("Empresa").Visible = False
    '        'GridView1.Columns("Sucursal").Visible = False
    '        'GridView1.Columns("Fecha de Registro").Visible = False

    '        'GridView1.Columns("ID GastoDetalle").Visible = False
    '        'GridView1.Columns("ID Gasto").Visible = False
    '        'GridView1.Columns("Centro de Costo").Visible = True

    '        iVista.Columns("ID GastoDetalle").Visible = False
    '        iVista.Columns("ID Gasto").Visible = False
    '        'GridView1.Columns("Fecha de Registro").Visible = False
    '        'GridView1.Columns("Anulado").OptionsColumn.AllowEdit = False


    '        iVista.Columns("Centro de Costo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

    '        iVista.Columns("Nota").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right




    '    End Sub

    Public Function validaanula(dt As DataTable) As Boolean
        Dim i As Integer
        Dim k As Integer
        For Each row As DataRow In dt.Rows
            i += 1
        Next
        Dim rowData(i) As String
        '///////////////////////////////////////////////////////////////////////////////////////////////////
        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                rowData(k) = rowData(k) & row(column)
                '& column.ColumnName & "=" 
            Next
            rowData(k) = rowData(k) & vbNewLine & vbNewLine
            k += 1
        Next
        Return (Convert.ToBoolean(rowData(0)))
    End Function

    'Function lookupgrid()
    '    Dim lookupCC As RepositoryItemGridLookUpEdit = New RepositoryItemGridLookUpEdit()
    '    Dim lookupCC2 As RepositoryItemGridLookUpEdit = New RepositoryItemGridLookUpEdit()

    '    lookupCC.DataSource = fn.ObtieneDatos("sp_Presupuesto_return_combo", 5, Convert.ToInt64(LookUpEdit11.EditValue), "", 0, False, "", 0, 0)
    '    lookupCC.DisplayMember = "Nombre"
    '    lookupCC.ValueMember = "Codigo"

    '    lookupCC2.DataSource = fn.ObtieneDatos("sp_Presupuesto_return_combo", 7, Convert.ToInt64(LookUpEdit11.EditValue), "", 0, False, "", 0, 0)
    '    lookupCC2.DisplayMember = "NOMBRE"
    '    lookupCC2.ValueMember = "CUENTA"

    '    iVista.Columns("Centro de Costo").ColumnEdit = lookupCC
    '    iVista.Columns("Cuenta Contable").ColumnEdit = lookupCC2

    '    iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '    iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False
    'End Function

    'Private Sub LookUpEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
    '    If (LookUpEdit11.EditValue <> 0) AndAlso (cbPeriodo.EditValue <> 0) AndAlso (cbCentroCosto.EditValue <> 0) AndAlso (fn.IsNull(cbSucursal.EditValue) <> "" And (LookUpEdit11.EditValue > 0) And (cbSucursal.EditValue > 0)) Then

    '        Dim salida As String
    '        salida = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 10, cbCentroCosto.EditValue, LookUpEdit11.EditValue, cbPeriodo.EditValue, False, "", 0, 0))
    '        If (salida = "") Then
    '            salida = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 11, 0, "", 0, False, "", 0, 0))
    '            If (salida = "") Then
    '                Numero.Text = 1
    '            Else
    '                Numero.Text = Convert.ToInt64(salida) + 1
    '            End If
    '        Else
    '            Numero.Text = Convert.ToInt64(salida)
    '        End If
    '    End If
    'End Sub

    'Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged

    '    ShowSplash()

    '    If (fn.IsNull(iVista.GetFocusedRowCellValue("ID GastoDetalle").ToString) <> "") Then

    '        If (fn.IsNull(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 23, 0, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, False, iVista.GetFocusedRowCellValue("Centro de Costo"), 0, 0))) <> "") AndAlso (e.Column.ToString = "Cuenta Contable") Then
    '            fn.XtraMsg("ya existe ese registro")

    '        Else
    '            Try

    '                fn.Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, LookUpEdit11.EditValue, False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), cbPeriodo.EditValue)
    '                'fn.XtraMsg((GridView1.GetFocusedRowCellValue(e.Column)))

    '                If (e.Column.ToString = "Centro de Costo") Then
    '                    For index As Integer = 1 To 12
    '                        fn.Guardar("sp_Presupuesto_return_combo", 31, Convert.ToInt64(LookUpEdit11.EditValue), iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", cbPeriodo.EditValue, cbCentroCosto.EditValue)
    '                    Next
    '                End If

    '            Catch ex As Exception
    '                If (e.Column.ToString = "Nota") Then
    '                    fn.Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, LookUpEdit11.EditValue, False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), cbPeriodo.EditValue)
    '                    'fn.XtraMsg("Dentro del catch" + e.Column.ToString)
    '                    ' fn.XtraMsg((GridView1.GetFocusedRowCellValue(e.Column)))
    '                Else
    '                    fn.Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, LookUpEdit11.EditValue, False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), cbPeriodo.EditValue)
    '                    If (e.Column.ToString = "Centro de Costo") Then
    '                        For index As Integer = 1 To 12
    '                            fn.Guardar("sp_Presupuesto_return_combo", 31, Convert.ToInt64(LookUpEdit11.EditValue), iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", cbPeriodo.EditValue, cbCentroCosto.EditValue)
    '                        Next
    '                    End If
    '                    'For index As Integer = 1 To 12
    '                    '    fn.Guardar("sp_Presupuesto_return_combo", 31, Convert.ToInt32(LookUpEdit11.EditValue), GridView1.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", LookUpEdit4.EditValue, LookUpEdit2.EditValue)
    '                    'Next

    '                    ' fn.Guardar("sp_Presupuesto_return_combo", 31, Convert.ToInt32(LookUpEdit11.EditValue), GridView1.GetFocusedRowCellValue("Cuenta Contable"), 1, False, "", LookUpEdit4.EditValue, LookUpEdit2.EditValue)
    '                    'fn.XtraMsg("Dentro del catch" + e.Column.ToString)
    '                    'fn.XtraMsg((GridView1.GetFocusedRowCellValue(e.Column)))
    '                End If
    '            End Try
    '        End If
    '    End If


    '    If (e.RowHandle + 1 = iVista.RowCount) AndAlso (fn.IsNull(iVista.GetFocusedRowCellValue("ID GastoDetalle").ToString) = "") AndAlso (fn.IsNull(iVista.GetFocusedRowCellValue("Cuenta Contable").ToString) <> "") Then

    '        If (fn.IsNull(iVista.GetFocusedRowCellValue("ID Gasto").ToString) = "") Then

    '            If (getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 20, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 18, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, 0)) <> "") Then
    '                fn.XtraMsg("ya existe ese registro")
    '            End If
    '        End If

    '        If (fn.IsNull(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 20, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 18, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, 0))) = "") Then

    '            If (fn.IsNull(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, "", 0, 0))) = "") Then
    '                fn.Guardar("sp_ins_PresupuestoGasto", Convert.ToInt64(Numero.Text), Convert.ToInt32(cbPeriodo.EditValue), Convert.ToInt32(LookUpEdit11.EditValue), iVista.GetFocusedRowCellValue("Centro de Costo"), False)
    '            End If

    '            fn.Guardar("sp_ins_PresupuestoGastoDetalle", validaestimado("Enero"), validaestimado("Febrero"), validaestimado("Marzo"), validaestimado("Abril"), validaestimado("Mayo"), validaestimado("Junio"), validaestimado("Julio"), validaestimado("Agosto"), validaestimado("Septiembre"), validaestimado("Octubre"), validaestimado("Noviembre"), validaestimado("Diciembre"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, iVista.GetFocusedRowCellValue("Nota").ToString, validasuc(), Globales.Usr_Nombre, 1, Globales.Usuario_ID, iVista.GetFocusedRowCellValue("Cuenta Contable"), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, "", 0, 0))))

    '            iVista.SetRowCellValue(e.RowHandle, iVista.Columns("ID Gasto"), getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, "", 0, 0)))

    '            iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("ID GastoDetalle"), getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 22, Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Convert.ToInt64(Numero.Text), "", 0, False, "", 0, 0))), False, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, 0)))
    '            For index As Integer = 1 To 12
    '                fn.Guardar("sp_Presupuesto_return_combo", 31, Convert.ToInt64(LookUpEdit11.EditValue), iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", cbPeriodo.EditValue, cbCentroCosto.EditValue)
    '            Next
    '            ' GridView1.SetRowCellValue(GridView1.RowCount, GridView1.Columns("# Cuenta Contable"), GridView1.GetFocusedRowCellValue("Cuenta Contable"))

    '            iVista.AddNewRow()
    '            iVista.UpdateCurrentRow()
    '            iVista.UpdateColumnsCustomization()
    '            iVista.RefreshRow(e.RowHandle + 1)
    '            iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("Centro de Costo"), cbCentroCosto.EditValue)

    '        End If

    '    End If
    '    HideSplash()

    'End Sub

    Public Function validames(mes As String) As Integer
        If (mes = "Enero") Then
            Return 1
        End If
        If (mes = "Febrero") Then
            Return 2
        End If
        If (mes = "Marzo") Then
            Return 3
        End If
        If (mes = "Abril") Then
            Return 4
        End If
        If (mes = "Mayo") Then
            Return 5
        End If
        If (mes = "Junio") Then
            Return 6
        End If
        If (mes = "Julio") Then
            Return 7
        End If
        If (mes = "Agosto") Then
            Return 8
        End If
        If (mes = "Septiembre") Then
            Return 9
        End If
        If (mes = "Octubre") Then
            Return 10
        End If
        If (mes = "Noviembre") Then
            Return 11
        End If
        If (mes = "Diciemmbre") Then
            Return 12
        End If
    End Function


    Public Function validasuc()
        If (IsNull(cbSucursal.EditValue) = "") Then
            Return ""
        Else
            Return cbSucursal.EditValue
        End If

    End Function

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'Validar que no se repita el Presupuesto por Cultivo y por Periodo.
        If IdPresupuesto = 0 Then
            If db_Presupuesto.ValidarPresupuesto(IsNull(cbPeriodo.EditValue, 0), 0, IsNull(cbSucursal.EditValue, "0"), 2, cbCentro.EditValue) Then
                XtraMsg("Ya existe un Presupuesto para los parametros seleccionados!", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '
        obj.IdPresupuesto = IdPresupuesto
        obj.Codigo = IIf(IdPresupuesto = 0, db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), 2, cbPeriodo.EditValue), Numero.Text)
        obj.Periodo = cbPeriodo.EditValue
        obj.Tipo = 2
        obj.Fecha = Fecha.DateTime.Date
        obj.IdSucursal = IsNull(cbSucursal.EditValue, "")
        obj.IdCentroCosto = cbCentro.EditValue  'IIf(EmpresaActual.Equals("1"), 0, IsNull(cbSucursal.EditValue, "0"))
        obj.IdCultivo = 0
        obj.Descripcion = mDescripcion.Text

        If IdPresupuesto = 0 Then
            ShowSplash("Guardando Presupuesto...")
            '
            IdPresupuesto = db.Insertar(obj)
            '******************************************************
            '*************** Gudar Detalle  ***********************
            '******************************************************
            Dim _DT_DTL As DataTable =
                DT_DTL.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

            If Not _DT_DTL Is Nothing Then
                objDetalle.IdPresupuesto = IdPresupuesto
                objDetalle.Empresa = EmpresaActual

                With _DT_DTL
                    For i As Integer = 0 To .Rows.Count - 1

                        objDetalle.Cuenta = .Rows.Item(i)("Cuenta")
                        objDetalle.Activo = IIf(.Rows.Item(i)("Activo") = True, 1, 0)
                        objDetalle.Estimado1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        objDetalle.Estimado2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        objDetalle.Estimado3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        objDetalle.Estimado4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        objDetalle.Estimado5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        objDetalle.Estimado6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        objDetalle.Estimado7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        objDetalle.Estimado8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        objDetalle.Estimado9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        objDetalle.Estimado10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        objDetalle.Estimado11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        objDetalle.Estimado12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)
                        objDetalle.Nota = IsNull(.Rows.Item(i)("Nota"), String.Empty)

                        dbDetalle.Insertar(objDetalle)
                    Next
                End With
            End If
            '
            HideSplash()
            XtraMsg("El Presupuesto se ha registrado con Exito!")

            ShowSplash("Cargando...")
            CargaInicial()
            HideSplash()
        Else
            ShowSplash("Actualizando Presupuesto...")
            db.Actualizar(obj)
            '******************************************************
            '*************** Gudar Detalle  ***********************
            '******************************************************
            Dim _DT_UPD As DataTable = DT_DTL.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                objDetalle.IdPresupuesto = IdPresupuesto
                objDetalle.Empresa = EmpresaActual

                With _DT_UPD
                    For i As Integer = 0 To .Rows.Count - 1

                        objDetalle.IdDetalle = .Rows.Item(i)("IdDetalle")
                        objDetalle.Cuenta = .Rows.Item(i)("Cuenta")
                        objDetalle.Activo = IIf(.Rows.Item(i)("Activo") = True, 1, 0)
                        objDetalle.Estimado1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        objDetalle.Estimado2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        objDetalle.Estimado3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        objDetalle.Estimado4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        objDetalle.Estimado5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        objDetalle.Estimado6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        objDetalle.Estimado7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        objDetalle.Estimado8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        objDetalle.Estimado9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        objDetalle.Estimado10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        objDetalle.Estimado11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        objDetalle.Estimado12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)
                        objDetalle.Nota = IsNull(.Rows.Item(i)("Nota"), String.Empty)

                        dbDetalle.Actualizar(objDetalle)
                    Next
                End With
            End If
            '
            'Agregar Registros Nuevo
            Dim _DT_NEW As DataTable = DT_DTL.GetChanges(DataRowState.Added)

            If Not _DT_NEW Is Nothing Then
                objDetalle.IdPresupuesto = IdPresupuesto
                objDetalle.Empresa = EmpresaActual

                With _DT_NEW
                    For i As Integer = 0 To .Rows.Count - 1

                        objDetalle.Cuenta = .Rows.Item(i)("Cuenta")
                        objDetalle.Activo = IIf(.Rows.Item(i)("Activo") = True, 1, 0)
                        objDetalle.Estimado1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        objDetalle.Estimado2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        objDetalle.Estimado3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        objDetalle.Estimado4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        objDetalle.Estimado5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        objDetalle.Estimado6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        objDetalle.Estimado7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        objDetalle.Estimado8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        objDetalle.Estimado9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        objDetalle.Estimado10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        objDetalle.Estimado11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        objDetalle.Estimado12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)
                        objDetalle.Nota = IsNull(.Rows.Item(i)("Nota"), String.Empty)

                        dbDetalle.Insertar(objDetalle)
                    Next
                End With
            End If
            '
            'Borrrar Lineas
            Dim _DT_DEL As DataTable = DT_DTL.GetChanges(DataRowState.Deleted)
            If Not _DT_DEL Is Nothing Then
                With _DT_DEL
                    For i As Integer = 0 To .Rows.Count - 1
                        objDetalle.IdDetalle = .Rows.Item(i)("IdDetalle", DataRowVersion.Original)
                        dbDetalle.Borrar(objDetalle)
                    Next
                End With
            End If
            '
            HideSplash()
            XtraMsg($"Los Cambios al Presupuesto No: {Numero.Text} han sido actualizado con Exitio!")
            '
            ShowSplash("Cargando...")
            CargaInicial()
            HideSplash()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        FormQuickField.Show()
    End Sub

    Private Sub TextEdit16_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        If IdPresupuesto = 0 Then Exit Sub

        ShowSplash()
        PresuGastosDetalle.Dispose()
        With PresuGastosDetalle
            .MdiParent = Me.MdiParent
            .Text = $"Ver Presupuesto No. {Numero.Text}"
            .Inicio(IdPresupuesto,
                    Numero.Text,
                    cbSucursal.Text,
                    cbSucursal.Text,
                    cbPeriodo.Text)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, $"Presupuesto de Gastos No. {Numero.Text}", cbPeriodo.Text)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged

    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If Inicio Then Exit Sub
        '
        If IdPresupuesto = 0 Then
            Numero.Text =
                db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), 2, cbPeriodo.EditValue)
        End If
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Cuenta" Then
            iVista.SetRowCellValue(e.RowHandle, "Grupo", Catalogo.Detalles(e.Value, EmpresaActual).GRUPO)
            iVista.SetRowCellValue(e.RowHandle, "Activo", True)
            iVista.SetRowCellValue(e.RowHandle, "Editable", True)
            iVista.SetRowCellValue(e.RowHandle, "Nota", String.Empty)
            '
            If DT_DTL.Compute("Count(Cuenta)", "Cuenta = '" & e.Value & "'") >= 1 Then
                XtraMsg($"Ya existe esta Cuenta {e.Value} en la lista", MessageBoxIcon.Error)
                iVista.DeleteRow(e.RowHandle)
            End If
        End If
        '
        If e.Column.FieldName = "Enero" Or
            e.Column.FieldName = "Febrero" Or
            e.Column.FieldName = "Marzo" Or
            e.Column.FieldName = "Abril" Or
            e.Column.FieldName = "Mayo" Or
            e.Column.FieldName = "Junio" Or
            e.Column.FieldName = "Julio" Or
            e.Column.FieldName = "Agosto" Or
            e.Column.FieldName = "Septiembre" Or
            e.Column.FieldName = "Octubre" Or
            e.Column.FieldName = "Noviembre" Or
            e.Column.FieldName = "Diciembre" Then

            iVista.SetRowCellValue(e.RowHandle, "Total", IsNull(iVista.GetRowCellValue(e.RowHandle, "Enero"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Febrero"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Marzo"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Abril"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Mayo"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Junio"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Julio"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Agosto"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Septiembre"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Octubre"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Noviembre"), 0.0) +
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Diciembre"), 0.0))
        End If
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.KeyCode = Keys.Delete Then
            If IdPresupuesto = 0 Then
                iVista.DeleteSelectedRows()
                iVista.RefreshData()
            Else
                If iVista.GetRowCellValue(iVista.FocusedRowHandle, "TotalReal") > 0.00 Then
                    XtraMsg($"La Cuenta {iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cuenta")} ya contiene movimientos, no se puede borrar", MessageBoxIcon.Error)
                Else
                    iVista.DeleteSelectedRows()
                    iVista.RefreshData()
                End If
            End If
        End If

    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
        If Not CBool(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Editable")) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub iVista_RowStyle(sender As Object, e As RowStyleEventArgs) Handles iVista.RowStyle
        If Not CBool(iVista.GetRowCellValue(e.RowHandle, "Editable")) Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.ForeColor = Color.Navy
        End If
    End Sub
End Class