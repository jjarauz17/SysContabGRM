Imports DevExpress.XtraEditors.Controls
Imports Entities

Public Class frmPlanNegocioNewAdd

    'Dim obj As New Presupuesto
    'Dim db As New db_Presupuesto

    'Dim obj_dtl As New PresupuestoDetalle
    'Dim db_dtl As New db_PresupuestoDetalle

    Dim obj As New PNR_PlanNegocio
    Dim db As New db_PNR_PlanNegocio

    Dim obj_dtl As New PNR_PlanNegocio_Detalle
    Dim db_dtl As New db_PNR_PlanNegocio_Detalle

    Dim Articulos As New VB.SysContab.ArticulosDB

    'Public IdPresupuesto As Integer = 0
    Dim DT_DTL As DataTable = New DataTable("PNR")
    Public DT_ROL As DataTable = New DataTable("Rol")

    Private _IdPlanNegocio As Integer
    Public Property IdPlanNegocio() As Integer
        Get
            Return _IdPlanNegocio
        End Get
        Set(ByVal value As Integer)
            _IdPlanNegocio = value
        End Set
    End Property

    Private Sub frmPresupuestoAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmPresupuestoNew.Created Then frmPresupuestoNew.Cargar()
    End Sub

    Private Sub frmPresupuestoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        CargaInicial()
        ArmarGrid()
        '        
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'bImprimir'")
            If dr.Length > 0 Then bImprimir.Enabled = True

            Dim dr2() As DataRow = DT_ROL.Select("Control = 'bExportar'")
            If dr2.Length > 0 Then bExportar.Enabled = True
        End If

    End Sub

    Sub CargaInicial()
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        '
        MostrarDatos()
        '        
        Cargar()
    End Sub

    Sub Cargar()

        DT_DTL = db_dtl.Listar(
            IdPlanNegocio,
            IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue),
            cbPeriodo.EditValue - 1,
            IIf(cbCultivo.EditValue Is Nothing, "", cbCultivo.Properties.View.GetRowCellValue(cbCultivo.Properties.View.FocusedRowHandle, "Codigo")),
            EmpresaActual)

        iGrid.DataSource = DT_DTL

        'Dim Anio As Integer = VB.SysContab.Rutinas.Fecha.Year

        'If Not cbPeriodo.EditValue Is Nothing Then
        '    Anio = VB.SysContab.PeriodosDB.GetDetails(cbPeriodo.EditValue).Final.Year - 1
        'End If

        'DT_DTL =
        '    db_PresupuestoDetalle.Listar(
        '    IdPresupuesto,
        '    IIf(EmpresaActual.Equals("1"), cbSucursal.EditValue, ""),
        '    Anio)

        'iGrid.DataSource = DT_DTL
    End Sub

    Sub ArmarGrid()
        iVista.PopulateColumns()
        'FormatoGrid(iVista, 2, 0, False)
        FormatoGridNew(iVista, 2, 2, False, True, True)

        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        iVista.OptionsView.ColumnAutoWidth = False

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("Producto").Width = 200
        iVista.Columns("Presentacion").Width = 120
        iVista.Columns("Unidad").Width = 80
        iVista.Columns("Clase").Width = 150
        iVista.Columns("Precio U$").Width = 80

        iVista.Columns("Producto").ColumnEdit = cbProductos
        iVista.Columns("Precio U$").ColumnEdit = rMontos
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
        iVista.Columns("Total U$").ColumnEdit = rMontos

        iVista.Columns("Producto").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Presentacion").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Unidad").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Clase").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        iVista.Columns("Precio U$").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        iVista.Columns("Total U$").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        iVista.Columns("Total").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right

        iVista.Columns("Clase").OptionsColumn.AllowEdit = False
        iVista.Columns("Clase").OptionsColumn.AllowFocus = False

        iVista.Columns("Total").OptionsColumn.AllowEdit = False
        iVista.Columns("Total").OptionsColumn.AllowFocus = False

        iVista.Columns("Total U$").OptionsColumn.AllowEdit = False
        iVista.Columns("Total U$").OptionsColumn.AllowFocus = False
    End Sub

    Sub CargarCombos()

        Application.DoEvents()
        Combo(cbTipo, ObtieneDatos("sp_sel_PNR_Tipo", EmpresaActual), "Tipo de PNR")
        cbTipo.ItemIndex = 0

        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year

        Application.DoEvents()
        SearchLookUp(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "Nombre", "Codigo", 0)

        Application.DoEvents()
        SearchLookUp(
            cbClientes,
            ObtieneDatos("PNR_GetClientes", EmpresaActual, IIf(cbSucursal.EditValue Is Nothing, "X", cbSucursal.EditValue)),
            "Nombre",
            "Codigo", 0)

        Application.DoEvents()
        SearchLookUp(cbCultivo, ObtieneDatos("sp_sel_Cultivos", EmpresaActual, 1), "Nombre", "IdCultivo", 0)
        cbCultivo.EditValue = "0"

        Application.DoEvents()
        RepositorySearchLook(cbProductos, ObtieneDatos("sp_ArticulosPresupuestoList", EmpresaActual), "Nombre", "Codigo")

        'Application.DoEvents()
        'RepositoryGridLookup(cbItems, ObtieneDatos("JAR_ArticulosList " & EmpresaActual), "NOMBRE", "CODIGO_ARTICULO")

        'If CInt(EmpresaActual) = 1 Then
        '    Application.DoEvents()
        '    Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
        '    cbSucursal.ItemIndex = 0
        '    '
        '    Application.DoEvents()
        '    SearchLookUp(cbCultivo, GetCultivo(), "Nombre", "Codigo", 0)

        '    Combo(cbTipo, ObtieneDatos("sp_sel_PNR_Tipo", EmpresaActual))

        '    'Combo(cbCultivo, GetCultivo())
        '    'cbCultivo.ItemIndex = 0
        'Else
        '    lySucursal.Text = "Centro Costo:"
        '    lyCultivo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        '    GetCentrosCostosList(cbSucursal, 1)
        '    cbSucursal.ItemIndex = 0
        'End If
        ''
        'Application.DoEvents()
        'Combo(cbPeriodo, VB.SysContab.PeriodosDB.GetList().Tables("Periodos"))
        'cbPeriodo.ItemIndex = 0

        'Application.DoEvents()
        'RepositoryGridLookup(cbItems, ObtieneDatos("sp_ArticulosPresupuestoList", EmpresaActual), "Nombre", "Codigo")

    End Sub

    Sub MostrarDatos()

        If IdPlanNegocio = 0 Then
            Numero.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)
            txtUsuario.Text = VB.SysContab.SeguridadDB.GetLogin(Login).Rows.Item(0)("Usr_NombreCompleto")
        Else
            obj = db_PNR_PlanNegocio.Detalles(IdPlanNegocio)

            Fecha.DateTime = obj.Fecha
            Numero.Text = obj.Codigo
            cbTipo.EditValue = obj.Tipo
            cbSucursal.EditValue = obj.IdSucursal
            cbPeriodo.EditValue = obj.Peridodo
            cbClientes.EditValue = obj.IdCliente
            cbPropiedades.EditValue = obj.IdPropiedad
            cbCultivo.EditValue = obj.IdCultivo
            txtUsuario.Text = obj.Usuario
            '
            txtMz.EditValue = obj.Total_Mz
            txtPotencial.EditValue = obj.Potencial_Biologico
            mObservaciones.Text = obj.Observaciones
        End If


        'If IdPresupuesto = 0 Then
        '    Numero.Text =
        '        db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), 1)

        '    txtUsuario.Text = VB.SysContab.SeguridadDB.GetLogin(Login).Rows.Item(0)("Usr_NombreCompleto")
        '    '
        '    bVer.Enabled = False
        '    bImprimir.Enabled = False
        'Else
        '    obj = db_Presupuesto.Detalles(IdPresupuesto)

        '    Fecha.DateTime = obj.Fecha
        '    Numero.Text = obj.Codigo
        '    cbPeriodo.EditValue = obj.Periodo
        '    cbCultivo.EditValue = obj.IdCultivo
        '    cbSucursal.EditValue = IIf(EmpresaActual.Equals("1"), obj.IdSucursal, obj.IdCentroCosto)
        '    mObservaciones.Text = obj.Descripcion
        '    txtUsuario.Text = VB.SysContab.SeguridadDB.GetLogin(obj.Usuario).Rows.Item(0)("Usr_NombreCompleto")

        '    cbSucursal.Properties.ReadOnly = True
        '    bVer.Enabled = True
        '    bImprimir.Enabled = True
        'End If
    End Sub

    'Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs)
    '    If IdPresupuesto = 0 Then
    '        Numero.Text =
    '            db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), 1)

    '        Cargar()
    '    End If
    'End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged

        If e.Column.FieldName = "Producto" Then
            Dim dr As DataRowView = cbProductos.GetRowByKeyValue(e.Value)

            iVista.SetRowCellValue(e.RowHandle, "Unidad", dr.Item("Unidad"))
            iVista.SetRowCellValue(e.RowHandle, "Presentacion", dr.Item("Presentacion"))
            iVista.SetRowCellValue(e.RowHandle, "Clase", dr.Item("Clase"))
            iVista.SetRowCellValue(e.RowHandle, "Tipo", dr.Item("Tipo"))
            iVista.SetRowCellValue(e.RowHandle, "Precio U$",
                                   CDbl(ObtieneDatos("SELECT dbo.fn_GetPrecioPromedio(" & cbPeriodo.EditValue - 1 & ",'" & e.Value & "','" & cbSucursal.EditValue & "'," & EmpresaActual & ") Precio;").Rows.Item(0)(0)))


            If DT_DTL.Compute("Count(Producto)", "Producto = '" & e.Value & "'") >= 1 Then
                XtraMsg("Ya existe este ITEM en la lista", MessageBoxIcon.Error)
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
            e.Column.FieldName = "Diciembre" Or
            e.Column.FieldName = "Precio U$" Then

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

            iVista.SetRowCellValue(e.RowHandle, "Total U$", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "Total"), 0.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio U$"), 0.0), 2))
        End If
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        ''Validar que no se repita el Presupuesto por Cultivo y por Periodo.
        'If IdPresupuesto = 0 Then
        '    If db_Presupuesto.ValidarPresupuesto(IsNull(cbPeriodo.EditValue, 0), IsNull(cbCultivo.EditValue, 0), IsNull(cbSucursal.EditValue, ""), 1) Then
        '        XtraMsg("Ya existe un Presupuesto para los parametros seleccionados!", MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'End If
        '
        'Validar que no se repita el PNR por Cliente y por Cultivo
        If IdPlanNegocio = 0 Then
            If db_PNR_PlanNegocio.ValidarPNR(cbClientes.EditValue, cbPeriodo.EditValue, cbCultivo.EditValue, cbSucursal.EditValue) Then
                XtraMsg("El PNR que esta intentando Ingresar ya Existe!")
                Exit Sub
            End If
        End If

        If cbCultivo.EditValue.ToString().Equals("0") Then
            XtraMsg("Seleccione Cultivo para este PNR!")
            cbCultivo.Focus()
            cbCultivo.SelectAll()
            Exit Sub
        End If

        'If EmpresaActual.Equals("1") Then
        '    XtraMsg("Seleccione el Tipo de Cultivo para este Presupuesto!", MessageBoxIcon.Warning)
        '    cbCultivo.Focus()
        '    Exit Sub
        'End If
        '
        If iVista.DataRowCount = 0 Then
            XtraMsg("No se han registrado los Productos para este PNR!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        obj.IdPlanNegocio = IdPlanNegocio
        obj.Fecha = Fecha.DateTime.Date
        obj.Codigo = IIf(IdPlanNegocio = 0, db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue), Numero.Text)
        obj.Peridodo = cbPeriodo.EditValue
        obj.IdCliente = cbClientes.EditValue
        obj.IdResponsable = 0
        obj.IdPropiedad = cbPropiedades.EditValue
        obj.Total_Mz = txtMz.EditValue
        obj.Mz_Atendidas = 0.00 'txtMzAtendidas.EditValue
        obj.Mz_Cultivo = 0.00 'txtMzCultivo.EditValue
        obj.IdSucursal = cbSucursal.EditValue
        obj.Potencial_Biologico = txtPotencial.EditValue
        obj.IdCultivo = cbCultivo.EditValue
        obj.Presentacion = 1
        obj.Observaciones = mObservaciones.Text
        obj.Tipo = cbTipo.EditValue

        If IdPlanNegocio = 0 Then
            ShowSplash("Guardando PNR...")
            '
            IdPlanNegocio = db.Insertar(obj)
            '******************************************************
            '*************** Gudar Detalle  ***********************
            '******************************************************
            Dim _DT_DTL As DataTable =
                DT_DTL.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

            If Not _DT_DTL Is Nothing Then
                obj_dtl.IdPlanNegocio = IdPlanNegocio
                obj_dtl.Empresa = EmpresaActual

                With _DT_DTL
                    For i As Integer = 0 To .Rows.Count - 1
                        obj_dtl.Producto = .Rows.Item(i)("Producto")
                        obj_dtl.Presentacion = IsNull(.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Unidad = IsNull(.Rows.Item(i)("Unidad"), "")
                        obj_dtl.Tipo = IsNull(.Rows.Item(i)("Tipo"), "P")
                        obj_dtl.Precio = IsNull(.Rows.Item(i)("Precio U$"), 0.0)
                        '
                        obj_dtl.Cantidad1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Cantidad2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Cantidad3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Cantidad4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Cantidad5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Cantidad6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Cantidad7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Cantidad8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Cantidad9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Cantidad10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Cantidad11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Cantidad12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)

                        db_dtl.Insertar(obj_dtl)
                    Next
                End With

            End If
            '
            HideSplash()
            XtraMsg("El PNR se ha registrado con Exito!")

            ShowSplash("Cargando...")
            CargaInicial()
            HideSplash()
        Else
            ShowSplash("Actualizando Presupuesto...")
            db.Actualizar(obj)
            '******************************************************
            '*************** Gudar Detalle  ***********************
            '******************************************************
            'Actualizar registros modificados
            Dim _DT_UPD As DataTable =
                DT_DTL.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then

                obj_dtl.IdPlanNegocio = IdPlanNegocio
                obj_dtl.Empresa = EmpresaActual

                With _DT_UPD
                    For i As Integer = 0 To .Rows.Count - 1
                        obj_dtl.IdDetalle = .Rows.Item(i)("IdDetalle")
                        obj_dtl.Producto = .Rows.Item(i)("Producto")
                        obj_dtl.Presentacion = IsNull(.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Unidad = IsNull(.Rows.Item(i)("Unidad"), "")
                        obj_dtl.Tipo = IsNull(.Rows.Item(i)("Tipo"), "P")
                        obj_dtl.Precio = IsNull(.Rows.Item(i)("Precio U$"), 0.0)
                        '
                        obj_dtl.Cantidad1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Cantidad2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Cantidad3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Cantidad4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Cantidad5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Cantidad6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Cantidad7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Cantidad8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Cantidad9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Cantidad10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Cantidad11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Cantidad12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)

                        db_dtl.Actualizar(obj_dtl)
                    Next
                End With
            End If
            '
            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable =
                DT_DTL.GetChanges(DataRowState.Added)

            If Not _DT_NEW Is Nothing Then
                obj_dtl.IdPlanNegocio = IdPlanNegocio
                obj_dtl.Empresa = EmpresaActual

                With _DT_NEW
                    For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                        obj_dtl.Producto = .Rows.Item(i)("Producto")
                        obj_dtl.Presentacion = IsNull(.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Unidad = IsNull(.Rows.Item(i)("Unidad"), "")
                        obj_dtl.Tipo = IsNull(.Rows.Item(i)("Tipo"), "P")
                        obj_dtl.Precio = IsNull(.Rows.Item(i)("Precio U$"), 0.0)
                        '
                        obj_dtl.Cantidad1 = IsNull(.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Cantidad2 = IsNull(.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Cantidad3 = IsNull(.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Cantidad4 = IsNull(.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Cantidad5 = IsNull(.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Cantidad6 = IsNull(.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Cantidad7 = IsNull(.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Cantidad8 = IsNull(.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Cantidad9 = IsNull(.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Cantidad10 = IsNull(.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Cantidad11 = IsNull(.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Cantidad12 = IsNull(.Rows.Item(i)("Diciembre"), 0.0)

                        db_dtl.Insertar(obj_dtl)
                    Next
                End With

            End If
            '
            'Borrrar Lineas
            Dim _DT_DEL As DataTable = DT_DTL.GetChanges(DataRowState.Deleted)
            If Not _DT_DEL Is Nothing Then
                For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                    obj_dtl.IdDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)
                    db_dtl.Borrar(obj_dtl)
                Next
            End If '
            HideSplash()
            XtraMsg("Los Cambios al PNR han sido actualizado con Exitio!")
            '
            ShowSplash("Cargando...")
            CargaInicial()
            HideSplash()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If IdPlanNegocio <> 0 Then

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Detalle de Presupuesto")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles bVer.Click
        If IdPlanNegocio <> 0 Then

            ShowSplash("Cargando Presupuesto...")
            frmPresupuestoVer.Dispose()
            '
            With frmPlanNegocioNewVer
                .MdiParent = Me.MdiParent
                .Text = $"Ver PNR No. {Numero.Text}"
                .Mostrar(
                    IdPlanNegocio,
                    cbSucursal.Text,
                    cbSucursal.Text,
                    cbPeriodo.Text,
                    cbCultivo.Text,
                    cbClientes.EditValue)
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
            HideSplash()
        End If
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If Inicio Then Exit Sub
        '
        If IdPlanNegocio = 0 Then
            Numero.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub cbCultivo_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbSucursal_EditValueChanged_1(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        If cbSucursal.EditValue Is Nothing Then Exit Sub
        '
        SearchLookUp(
            cbClientes,
            ObtieneDatos("PNR_GetClientes",
                                              EmpresaActual,
                                              IIf(cbSucursal.EditValue Is Nothing, "%", cbSucursal.EditValue)),
            "Nombre",
            "Codigo", 0)


        If IdPlanNegocio = 0 Then
            Numero.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)

            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub cbClientes_EditValueChanged(sender As Object, e As EventArgs) Handles cbClientes.EditValueChanged
        If cbClientes.EditValue Is Nothing Then Exit Sub
        '
        SearchLookUp(
            cbPropiedades, db_PNR_Propiedades.Listar(-1, IIf(cbClientes.EditValue Is Nothing, 0, cbClientes.EditValue), cbPeriodo.EditValue),
            "Nombre",
            "IdPropiedad",
            0)

        If Inicio = True Then Exit Sub

        If cbClientes.Properties.View.GetRowCellValue(cbClientes.Properties.View.FocusedRowHandle, "AgroServicio") Then
            If cbTipo.EditValue <> 2 Then
                XtraMsg("El Cliente seleccionado es un Agro Servicio, el tipo de PNR debe ser de Distribuidor", MessageBoxIcon.Warning)
                cbTipo.EditValue = 2
                cbTipo.Focus()
                cbTipo.SelectAll()
            End If
        End If
    End Sub

    Private Sub cbPropiedades_EditValueChanged(sender As Object, e As EventArgs) Handles cbPropiedades.EditValueChanged
        If Inicio = True Then Exit Sub
        '
        txtPotencial.EditValue = cbPropiedades.Properties.View.GetRowCellValue(cbPropiedades.Properties.View.FocusedRowHandle, "Pot. Biologico U$")
        txtMz.EditValue = cbPropiedades.Properties.View.GetRowCellValue(cbPropiedades.Properties.View.FocusedRowHandle, "Total Mz")
    End Sub

    Private Sub cbTipo_EditValueChanged(sender As Object, e As EventArgs) Handles cbTipo.EditValueChanged
        If Inicio Then Exit Sub
        '
        If cbClientes.EditValue Is Nothing Then Exit Sub

        If cbClientes.EditValue = 2 Then
            If Not CBool(cbClientes.Properties.View.GetRowCellValue(cbClientes.Properties.View.FocusedRowHandle, "AgroServicio")) Then
                XtraMsg("El Cliente seleccionado debe ser un Agro Servicio para este tipo de PNR", MessageBoxIcon.Warning)
                cbTipo.EditValue = 1
                cbTipo.Focus()
                cbTipo.SelectAll()
            End If
        End If

    End Sub

    Private Sub bAdicional_Click(sender As Object, e As EventArgs) Handles bAdicional.Click
        If IdPlanNegocio = 0 Then
            XtraMsg("Deber Guardar Primero este PNR para poder agregar Clientes Adicionales", MessageBoxIcon.Warning)
        Else
            With frmClientesAdicionales
                .IdPlanNegocio = IdPlanNegocio
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbPropiedades_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbPropiedades.ButtonClick
        If cbClientes.EditValue Is Nothing Then Exit Sub
        '        
        If e.Button.Index = 1 Then

            With frmPropiedadesAdd
                .IdPropiedad = 0

                .Text = "Agregar Propiedades"
                .cbCliente.Enabled = False
                .cbCliente.EditValue = cbClientes.EditValue
                .IdPeriodo = cbPeriodo.EditValue
                .cbCultivo.EditValue = cbCultivo.EditValue
                .ShowDialog()

                If .Ok = "SI" Then

                    SearchLookUp(
                           cbPropiedades, db_PNR_Propiedades.Listar(-1, IIf(cbClientes.EditValue Is Nothing, 0, cbClientes.EditValue), cbPeriodo.EditValue),
                            "Nombre",
                            "IdPropiedad",
                            0)
                End If
                .Dispose()
            End With

        End If
    End Sub

    Private Sub cbCultivo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cbCultivo.EditValueChanged
        If Inicio Then Exit Sub
        '
        If IdPlanNegocio = 0 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub
End Class