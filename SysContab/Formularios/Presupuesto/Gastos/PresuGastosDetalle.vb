Imports ClasesBLL
Imports DevExpress.XtraEditors.Repository
Imports Entities

Public Class PresuGastosDetalle

    'Dim codpresu As Integer
    'Dim anulado As Boolean
    'Dim opc As Integer
    'Dim centcost As String
    'Dim Empresa As Integer
    'Dim Periodo As Integer
    'Dim Cuenta As String

    Dim IdPresupuesto As Integer = 0,
        Reporte As Integer = 1
    Dim dbDetalle As New db_PresupuestoDetalleGastos

    Public Sub Inicio(ID As Integer,
                      Numero As String,
                      Sucursal As String,
                      CentroCosto As String,
                      Periodo As String)

        IdPresupuesto = ID
        txtNumero.Text = Numero
        txtPeriodo.Text = Periodo

        If Not EmpresaActual.Equals("1") Then
            lySucursal.Text = "Centro de Costo:"
            txtSucursal.Text = CentroCosto
        Else
            lySucursal.Text = "Sucursal:"
            txtSucursal.Text = Sucursal
        End If
        '        
        RepositorySearchLook(
         cbCatalogo,
         ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual, "R"),
         "Display",
         "Cuenta",
         2)
        '        
        RepositoryItemLookUpEdit(cbGrupos, ObtieneDatos("sp_sel_GRUPOS", "R", EmpresaActual), "Nombre", "Codigo", 0)
    End Sub

    Private Sub PresuGastosDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
        ArmarGrid()
    End Sub

    Sub Cargar()
        Dim _dt As DataTable = New DataTable("Presupuesto")

        If Reporte = 1 Then
            _dt = dbDetalle.Listar(IdPresupuesto, EmpresaActual)
            iGrid.DataSource = _dt
        ElseIf Reporte = 2 Then
            _dt = dbDetalle.ListarReal(IdPresupuesto, EmpresaActual)
            iGrid.DataSource = _dt
        ElseIf Reporte = 3 Then
            _dt = dbDetalle.ListarVariacion(IdPresupuesto, EmpresaActual)
            iGrid.DataSource = _dt
        End If

    End Sub

    Sub ArmarGrid()
        iVista.PopulateColumns()
        FormatoGridNew(iVista, 2, 2, False, False, True)
        '
        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        iVista.OptionsView.ColumnAutoWidth = False
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("TotalReal").Visible = False
        iVista.Columns("Editable").Visible = False
        '
        iVista.Columns("Grupo").Width = 200
        iVista.Columns("Cuenta").Width = 250
        iVista.Columns("Nota").Width = 200
        '
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
        '
        iVista.Columns("Grupo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Cuenta").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Activo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    End Sub


    'Public Function mostrar(codpresu As Integer, opc As Integer, centcost As String, Empresa As Integer, Periodo As Integer)
    '    Me.Empresa = Empresa
    '    Me.Periodo = Periodo

    '    If (opc = 0) Then
    '        iGrid.DataSource =
    'ObtieneDatos("sp_sel_PresupuestoGastoDetalle", codpresu, 1)
    '        'GridControl1.ForceInitialize()
    '        iVista.PopulateColumns()
    '        Utils.FormatoGrid(iVista, 2, 0)
    '        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
    '        iVista.OptionsView.ColumnAutoWidth = False
    '        iVista.BestFitColumns()

    '        lookupgrid()

    '        Me.codpresu = codpresu
    '        Me.opc = opc
    '        Me.centcost = centcost

    '        iVista.AddNewRow()
    '        iVista.UpdateCurrentRow()
    '        iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("Centro de Costo"), Me.centcost)



    '        iVista.Columns("# Presupuesto").Visible = False
    '        iVista.Columns("Periodo").Visible = False
    '        iVista.Columns("Empresa").Visible = False
    '        iVista.Columns("Sucursal").Visible = False
    '        iVista.Columns("Anulado").Visible = False
    '        iVista.Columns("Fecha de Registro").Visible = False

    '        iVista.Columns("ID GastoDetalle").Visible = False
    '        iVista.Columns("ID Gasto").Visible = False

    '        'GridView1.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Centro de Costo").OptionsColumn.AllowFocus = False


    '        'GridView1.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Anulado").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Anulado").OptionsColumn.AllowFocus = False


    '        iVista.Columns("# Presupuesto").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("Centro de Costo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Visible = False
    '        iVista.Columns("Nota").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right

    '        iVista.Columns("Cuenta Contable").Width = 250



    '        iVista.Columns("Enero").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

    '        If (getestado(ObtieneDatos("sp_Presupuesto_return_combo", 13, codpresu, "", 0, False, "", 0, 0))) Then

    '            '   Guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    '            iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Enero").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Enero").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Febrero").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Febrero").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Marzo").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Marzo").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Abril").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Abril").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Mayo").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Mayo").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Junio").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Junio").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Julio").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Julio").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Agosto").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Agosto").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Septiembre").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Septiembre").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Octubre").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Octubre").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Noviembre").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Noviembre").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Diciembre").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Diciembre").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Nota").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Nota").OptionsColumn.AllowFocus = False

    '            iVista.Columns("Total").OptionsColumn.AllowEdit = False
    '            iVista.Columns("Total").OptionsColumn.AllowFocus = False



    '        End If

    '    End If

    '    If (opc = 1) Then
    '        iGrid.DataSource =
    'ObtieneDatos("sp_sel_PresupuestoGastoDetalle", codpresu, 2)
    '        'GridControl1.ForceInitialize()
    '        iVista.PopulateColumns()
    '        Utils.FormatoGrid(iVista, 2, 0)
    '        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
    '        iVista.OptionsView.ColumnAutoWidth = False

    '        iVista.BestFitColumns()


    '        lookupgrid()

    '        Me.codpresu = codpresu
    '        Me.opc = opc

    '        iVista.Columns("# Presupuesto").Visible = False
    '        iVista.Columns("Periodo").Visible = False
    '        iVista.Columns("Empresa").Visible = False
    '        iVista.Columns("Sucursal").Visible = False
    '        iVista.Columns("Anulado").Visible = False
    '        iVista.Columns("Fecha de Registro").Visible = False

    '        iVista.Columns("ID GastoDetalle").Visible = False
    '        iVista.Columns("ID Gasto").Visible = False

    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False


    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Anulado").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Anulado").OptionsColumn.AllowFocus = False


    '        iVista.Columns("# Presupuesto").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

    '        iVista.Columns("Centro de Costo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Visible = False
    '        iVista.Columns("Nota").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right

    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False
    '        iVista.Columns("Cuenta Contable").Width = 250

    '        iVista.Columns("Enero").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Enero").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Febrero").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Febrero").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Marzo").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Marzo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Abril").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Abril").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Mayo").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Mayo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Junio").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Junio").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Julio").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Julio").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Agosto").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Agosto").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Septiembre").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Septiembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Octubre").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Octubre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Noviembre").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Noviembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Diciembre").OptionsColumn.AllowEdit = False
    '        'GridView1.Columns("Diciembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Nota").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Nota").OptionsColumn.AllowFocus = False


    '        iVista.Columns("Total").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Total").OptionsColumn.AllowFocus = False




    '    End If

    '    If (opc = 2) Then
    '        iGrid.DataSource =
    'ObtieneDatos("sp_sel_PresupuestoGastoDetalle", codpresu, 3)
    '        'GridControl1.ForceInitialize()
    '        iVista.PopulateColumns()
    '        Utils.FormatoGrid(iVista, 2, 0)
    '        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
    '        iVista.OptionsView.ColumnAutoWidth = False
    '        iVista.BestFitColumns()
    '        lookupgrid()

    '        Me.codpresu = codpresu
    '        Me.opc = opc


    '        iVista.Columns("# Presupuesto").Visible = False
    '        iVista.Columns("Periodo").Visible = False
    '        iVista.Columns("Empresa").Visible = False
    '        iVista.Columns("Sucursal").Visible = False
    '        iVista.Columns("Anulado").Visible = False
    '        iVista.Columns("Fecha de Registro").Visible = False

    '        iVista.Columns("ID GastoDetalle").Visible = False
    '        iVista.Columns("ID Gasto").Visible = False

    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False


    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("# Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Anulado").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Anulado").OptionsColumn.AllowFocus = False



    '        iVista.Columns("# Presupuesto").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

    '        iVista.Columns("Centro de Costo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("Cuenta Contable").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        iVista.Columns("# Cuenta Contable").Visible = False
    '        iVista.Columns("Cuenta Contable").Width = 250


    '        'GridView1.Columns("Enero").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Febrero").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Marzo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Abril").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Mayo").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Junio").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Julio").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Agosto").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Septiembre").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Octubre").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Noviembre").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    '        'GridView1.Columns("Diciembre").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

    '        iVista.Columns("Nota").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
    '        iVista.Columns("Total").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right


    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Centro de Costo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Cuenta Contable").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Enero").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Enero").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Febrero").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Febrero").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Marzo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Marzo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Abril").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Abril").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Mayo").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Mayo").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Junio").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Junio").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Julio").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Julio").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Agosto").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Agosto").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Septiembre").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Septiembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Octubre").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Octubre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Noviembre").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Noviembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Diciembre").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Diciembre").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Total").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Total").OptionsColumn.AllowFocus = False

    '        iVista.Columns("Nota").OptionsColumn.AllowEdit = False
    '        iVista.Columns("Nota").OptionsColumn.AllowFocus = False



    '    End If

    'End Function

    'Function lookupgrid()

    '    Dim lookupCC As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit()
    '    Dim lookupCC2 As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit()


    '    RepositorySearchLook(
    '        lookupCC,
    '        ObtieneDatos("sp_Presupuesto_return_combo", 5, Me.Empresa, "", 0, False, "", 0, 0),
    '        "Nombre",
    '        "Codigo", 0, 1)

    '    RepositorySearchLook(
    '        lookupCC2,
    '        ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual),
    '        "Display",
    '        "Cuenta",
    '        2)

    '    'lookupCC.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 5, Me.Empresa, "", 0, False, "", 0, 0)
    '    'lookupCC.DisplayMember = "Nombre"
    '    'lookupCC.ValueMember = "Codigo"

    '    'lookupCC2.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 7, Me.Empresa, "", 0, False, "", 0, 0)
    '    'lookupCC2.DisplayMember = "NOMBRE"
    '    'lookupCC2.ValueMember = "CUENTA"

    '    iVista.Columns("Centro de Costo").ColumnEdit = lookupCC
    '    iVista.Columns("Cuenta Contable").ColumnEdit = lookupCC2

    'End Function

    'Function getestado(dt As DataTable) As Boolean

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
    '    Return (Convert.ToBoolean(rowData(0)))
    'End Function


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


    'Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
    '    Dim salida0 As String
    '    Dim salida1 As String
    '    Dim salida2 As String
    '    Dim salida3 As String
    '    Dim salida4 As String
    '    Dim salida5 As String

    '    ShowSplash()

    '    If (IsNull(iVista.GetFocusedRowCellValue("ID GastoDetalle").ToString) <> "") Then

    '        If (IsNull(getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 23, 0, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, False, iVista.GetFocusedRowCellValue("Centro de Costo"), 0, 0))) <> "") AndAlso (e.Column.ToString = "Cuenta Contable") Then
    '            XtraMsg("ya existe ese registro del id null")

    '        Else
    '            Try
    '                If (Me.opc = 0) Then

    '                    Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, Convert.ToInt64(iVista.GetFocusedRowCellValue("Empresa")), False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), Convert.ToInt64(iVista.GetFocusedRowCellValue("Periodo")))

    '                    If (e.Column.ToString = "Centro de Costo") Then
    '                        For index As Integer = 1 To 12
    '                            Guardar("sp_Presupuesto_return_combo", 31, Me.Empresa, iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", Me.Periodo, Convert.ToInt64(iVista.GetRowCellValue(1, iVista.Columns("Centro de Costo"))))
    '                        Next

    '                    End If
    '                ElseIf (Me.opc = 1) Then

    '                    Guardar("sp_Presupuesto_return_combo", 27, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, Convert.ToInt64(iVista.GetFocusedRowCellValue("Empresa")), False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), Convert.ToInt64(iVista.GetFocusedRowCellValue("Periodo")))

    '                End If
    '            Catch ex As Exception
    '                If (e.Column.ToString = "Nota") Then
    '                    Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, 0, False, iVista.GetFocusedRowCellValue(e.Column).ToString, 0, validaestimado("Periodo"))

    '                Else
    '                    If (Me.opc = 0) Then

    '                        Guardar("sp_Presupuesto_return_combo", 14, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, 0, False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), validaestimado("Periodo"))

    '                        If (e.Column.ToString = "Centro de Costo") Then
    '                            For index As Integer = 1 To 12
    '                                Guardar("sp_Presupuesto_return_combo", 31, Me.Empresa, iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", Me.Periodo, Convert.ToInt64(iVista.GetRowCellValue(1, iVista.Columns("Centro de Costo"))))
    '                            Next
    '                        End If
    '                    End If
    '                    If (Me.opc = 1) Then

    '                        Guardar("sp_Presupuesto_return_combo", 27, Convert.ToInt64(iVista.GetFocusedRowCellValue("ID GastoDetalle")), e.Column.ToString, 0, False, iVista.GetFocusedRowCellValue(e.Column).ToString, Convert.ToDouble(iVista.GetFocusedRowCellValue(e.Column)), validaestimado("Periodo"))

    '                    End If

    '                End If


    '            End Try
    '        End If

    '    End If



    '    If (e.RowHandle + 1 = iVista.RowCount) AndAlso (IsNull(iVista.GetFocusedRowCellValue("ID GastoDetalle").ToString) = "") AndAlso (IsNull(iVista.GetFocusedRowCellValue("Cuenta Contable").ToString) <> "") Then

    '        salida0 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 16, Me.codpresu, "", 0, False, "", 0, 0))
    '        salida1 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 17, Me.codpresu, "", 0, False, "", 0, 0))
    '        salida2 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 18, Me.codpresu, "", 0, False, "", 0, 0))

    '        salida3 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(salida0), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(salida1), False, "", 0, 0))

    '        salida5 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 20, Convert.ToInt32(salida0), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(salida1), False, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, 0))

    '        ' XtraMsg("periodo " + salida0 + " empresa " + salida1 + " Centro de Costo " + salida2 + " Cuenta contable " + GridView1.GetFocusedRowCellValue("Cuenta Contable").ToString + " idpresugast " + salida5)

    '        If (IsNull(salida5) <> "") Then
    '            XtraMsg("ya existe ese registro del id no null")
    '        End If
    '        If (IsNull(salida5) = "") Then
    '            XtraMsg("registro nuevo")
    '            If (IsNull(salida3) = "") Then
    '                Guardar("sp_ins_PresupuestoGasto", Me.codpresu, Convert.ToInt32(salida0), Convert.ToInt32(salida1), iVista.GetFocusedRowCellValue("Centro de Costo"), False)
    '            End If

    '            salida3 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(salida0), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(salida1), False, "", 0, 0))
    '            salida4 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 19, Me.codpresu, "", 0, False, "", 0, 0))
    '            Guardar("sp_ins_PresupuestoGastoDetalle", validaestimado("Enero"), validaestimado("Febrero"), validaestimado("Marzo"), validaestimado("Abril"), validaestimado("Mayo"), validaestimado("Junio"), validaestimado("Julio"), validaestimado("Agosto"), validaestimado("Septiembre"), validaestimado("Octubre"), validaestimado("Noviembre"), validaestimado("Diciembre"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, iVista.GetFocusedRowCellValue("Nota").ToString, salida4, Globales.Usr_Nombre, 1, Globales.Usuario_ID, iVista.GetFocusedRowCellValue("Cuenta Contable"), Convert.ToInt32(salida3))

    '            'XtraMsg("celda actual con -1: " + (GridView1.RowCount - 1).ToString + "Celda sin -1" + GridView1.RowCount.ToString + " Celda e.RowHanlde" + e.RowHandle)
    '            'salida3 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 8, Convert.ToInt32(salida0), GridView1.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(salida1), False, "", 0))
    '            'GridView1.SetRowCellValue(GridView1.RowCount - 1, GridView1.Columns("ID Gasto"), salida3)
    '            'Dim prueba As String = Convert.ToInt64(GridView1.GetFocusedRowCellValue("Centro de Costo"))

    '            salida3 = getdatacombo(ObtieneDatos("sp_Presupuesto_return_combo", 22, Convert.ToInt32(salida0), iVista.GetFocusedRowCellValue("Centro de Costo"), Convert.ToInt32(salida1), False, iVista.GetFocusedRowCellValue("Cuenta Contable"), 0, 0))
    '            If (opc = 0) Then

    '                For index As Integer = 1 To 12
    '                    Guardar("sp_Presupuesto_return_combo", 31, Me.Empresa, iVista.GetFocusedRowCellValue("Cuenta Contable"), index, False, "", Me.Periodo, Convert.ToInt64(iVista.GetRowCellValue(1, iVista.Columns("Centro de Costo"))))
    '                Next


    '                iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("ID GastoDetalle"), salida3)
    '                iVista.AddNewRow()
    '                iVista.UpdateCurrentRow()
    '                'GridView1.UpdateColumnsCustomization()
    '                'GridView1.RefreshRow(e.RowHandle + 1)
    '                iVista.SetRowCellValue(iVista.RowCount - 1, iVista.Columns("Centro de Costo"), Me.centcost)
    '            End If
    '            Return
    '        End If
    '    End If
    '    HideSplash()

    '    ' Guardar("sp_ins_PresupuestoGastoDetalle", validaestimado("Enero"), validaestimado("Febrero"), validaestimado("Marzo"), validaestimado("Abril"), validaestimado("Mayo"), validaestimado("Junio"), validaestimado("Julio"), validaestimado("Agosto"), validaestimado("Septiembre"), validaestimado("Octubre"), validaestimado("Noviembre"), validaestimado("Diciembre"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, GridView1.GetFocusedRowCellValue("Nota"), GridView1.GetFocusedRowCellValue("Sucursal"), "Usuario", 1, 1, GridView1.GetFocusedRowCellValue("Cuenta Contable"), GridView1.GetFocusedRowCellValue("ID Gasto"))
    'End Sub

    'Function validaestimado(opc As String) As Double


    '    If (IsNull(iVista.GetFocusedRowCellValue(opc).ToString) = "") Then
    '        Return 0
    '    Else
    '        Return Convert.ToInt32(iVista.GetFocusedRowCellValue(opc))

    '    End If


    'End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        lblTipo.Text = "Presupuesto Estimado"
        Reporte = 1
        ShowSplash("Presupuesto...")
        Cargar()
        iVista.Columns("Nota").Visible = True
        HideSplash()

        'Me.Text = "Presupuesto Detallado"
        'ShowSplash()
        'mostrar(Me.codpresu, 0, Me.centcost, Me.Empresa, Me.Periodo)
        'HideSplash()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        lblTipo.Text = "Ingresos y Gastos Reales"
        Reporte = 2
        ShowSplash("Gastos Reales...")
        Cargar()
        iVista.Columns("Nota").Visible = False
        HideSplash()

        'Me.Text = "Gastos Reales Detallado"
        'ShowSplash()
        'mostrar(Me.codpresu, 1, Me.centcost, Me.Empresa, Me.Periodo)
        'HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        lblTipo.Text = "Variación del Presupuesto"
        Reporte = 3
        ShowSplash("Variacion...")
        Cargar()
        iVista.Columns("Nota").Visible = False
        HideSplash()

        'Me.Text = "Variacion en Gastos"
        'ShowSplash()
        'mostrar(Me.codpresu, 2, Me.centcost, Me.Empresa, Me.Periodo)
        'HideSplash()

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If (Reporte = 3) Then
            If (e.Column.ToString = "Enero" Or e.Column.ToString = "Febrero" Or e.Column.ToString = "Marzo" Or e.Column.ToString = "Abril" Or e.Column.ToString = "Mayo" Or e.Column.ToString = "Junio" Or e.Column.ToString = "Julio" Or e.Column.ToString = "Agosto" Or e.Column.ToString = "Septiembre" Or e.Column.ToString = "Octubre" Or e.Column.ToString = "Noviembre" Or e.Column.ToString = "Diciembre" Or e.Column.ToString = "Total") Then

                If (IsNothing(e.CellValue)) Then
                Else
                    If (e.CellValue < 0) Then
                        e.Appearance.ForeColor = Color.Red
                    End If
                    If (e.CellValue > 0) Then
                        e.Appearance.ForeColor = Color.Green
                    End If
                    If (e.CellValue = 0) Then
                        e.Appearance.ForeColor = Color.Navy
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick

        'If (opc = 1) Then
        'XtraMsg(GridView1.GetFocusedRowCellValue("Enero") + "" + GridView1.GetFocusedRowCellValue(Convert.ToInt64(GridView1.FocusedRowHandle)).ToString)
        FormDetalleCuenta.cargargrid(iVista.FocusedColumn.ToString, iVista.GetFocusedRowCellValue("Cuenta"), EmpresaActual, iVista.GetFocusedRowCellValue("Periodo"), iVista.GetFocusedRowCellValue("Centro de Costo"))
        'FormDetalleCuenta.MdiParent = frmPrincipalRibbon            
        FormDetalleCuenta.Show()
        'FormDetalleCuenta.WindowState = FormWindowState.Maximized
        'End If


    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ShowSplash("Cargando Presupuesto...")
        frmPresupuestoVer.Dispose()
        '
        With frmPresupuestoGastoVer
            .Text = "Reporte Presupuesto"
            .Mostrar(
                    IdPresupuesto,
                    txtSucursal.Text,
                    txtSucursal.Text,
                    txtPeriodo.Text)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()

        'ShowSplash()
        'FrmReportDiferente.Dispose()
        'FrmReportDiferente.cargargridreport(Me.codpresu, 1)
        'FrmReportDiferente.Show()
        'FrmReportDiferente.WindowState = FormWindowState.Maximized
        'HideSplash()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Close()
    End Sub


End Class