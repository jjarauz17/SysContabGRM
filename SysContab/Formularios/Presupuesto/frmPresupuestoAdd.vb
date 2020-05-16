Public Class frmPresupuestoAdd 

    Dim obj As New Presupuesto
    Dim db As New db_Presupuesto

    Dim obj_dtl As New PresupuestoDetalle
    Dim db_dtl As New db_PresupuestoDetalle

    Dim Articulos As New VB.SysContab.ArticulosDB

    Public IdPresupuesto As Integer = 0
    Dim DT_DTL As DataTable = New DataTable("Presupuesto")

    Private Sub frmPresupuestoAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmPresupuestoNew.Created Then frmPresupuestoNew.Cargar()
    End Sub

    Private Sub frmPresupuestoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        CargaInicial()
        ArmarGrid()       
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

    Sub Cargar()
        DT_DTL =
            db_PresupuestoDetalle.Listar(IdPresupuesto, cbSucursal.EditValue)
        iGrid.DataSource = DT_DTL
    End Sub

    Sub ArmarGrid()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)

        iVista.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        iVista.OptionsView.ColumnAutoWidth = False

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Producto").Width = 150
        iVista.Columns("Presentacion").Width = 120
        iVista.Columns("Unidad").Width = 80
        iVista.Columns("Clase").Width = 150
        iVista.Columns("Precio U$").Width = 80

        iVista.Columns("Producto").ColumnEdit = cbItems
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
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
        cbSucursal.ItemIndex = 0
        '
        Application.DoEvents()
        Combo(cbPeriodo, VB.SysContab.PeriodosDB.GetList().Tables("Periodos"))
        cbPeriodo.ItemIndex = 0

        Application.DoEvents()
        Combo(cbCultivo, GetCultivo())
        cbCultivo.ItemIndex = 0

        Application.DoEvents()
        RepositoryGridLookup(cbItems, ObtieneDatos("sp_ArticulosPresupuestoList " & EmpresaActual), "Nombre", "Codigo")
    End Sub

    Sub MostrarDatos()
        If IdPresupuesto = 0 Then
            Numero.Text =
                db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue))
        Else
            obj = db_Presupuesto.Detalles(IdPresupuesto)

            Fecha.DateTime = obj.Fecha
            Numero.Text = obj.Codigo
            cbPeriodo.EditValue = obj.Periodo
            cbCultivo.EditValue = obj.IdCultivo
            cbSucursal.EditValue = obj.IdSucursal
            mObservaciones.Text = obj.Descripcion

            cbSucursal.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        If IdPresupuesto = 0 Then
            Numero.Text =
                db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue))

            Cargar()
        End If
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged

        If e.Column.FieldName = "Producto" Then
            Dim dr As DataRowView = cbItems.GetRowByKeyValue(e.Value)

            iVista.SetRowCellValue(e.RowHandle, "Unidad", dr.Item("Unidad"))
            iVista.SetRowCellValue(e.RowHandle, "Presentacion", dr.Item("Presentacion"))
            iVista.SetRowCellValue(e.RowHandle, "Clase", dr.Item("Clase"))
            iVista.SetRowCellValue(e.RowHandle, "Precio U$",
                                   CDbl(ObtieneDatos("SELECT dbo.fn_GetPrecioPromedio(" & cbPeriodo.GetColumnValue("Año") - 1 & ",'" & e.Value & "','" & cbSucursal.EditValue & "'," & EmpresaActual & ") Precio;").Rows.Item(0)(0)))


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

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'Validar que no se repita el Presupuesto por Cultivo y por Periodo.
        If IdPresupuesto = 0 Then
            If db_Presupuesto.ValidarPresupuesto(IsNull(cbPeriodo.EditValue, 0), IsNull(cbCultivo.EditValue, 0), IsNull(cbSucursal.EditValue, "")) Then
                XtraMsg("El Presupuesto que intenta ingresar para el Cultivo " & cbCultivo.Text & " Ya Exite!", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '
        If iVista.DataRowCount = 0 Then
            XtraMsg("No se han registrado los Productos para este Presupuesto!", MessageBoxIcon.Error)
            Exit Sub
        End If

        obj.IdPresupuesto = IdPresupuesto
        obj.Codigo = IIf(IdPresupuesto = 0, db_Presupuesto.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue)), Numero.Text)
        obj.Periodo = cbPeriodo.EditValue
        obj.Fecha = Fecha.DateTime.Date
        obj.IdSucursal = IsNull(cbSucursal.EditValue, "")
        obj.IdCultivo = IsNull(cbCultivo.EditValue, 0)
        obj.Descripcion = mObservaciones.Text

        If IdPresupuesto = 0 Then
            ShowSplash("Guardando Presupuesto...")
            '
            IdPresupuesto = db.Insertar(obj)
            '******************************************************
            '*************** Gudar Detalle  ***********************
            '******************************************************
            Dim _DT_DTL As DataTable =
                DT_DTL.GetChanges(DataRowState.Added Or DataRowState.Modified)

            If Not _DT_DTL Is Nothing Then
                For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                    obj_dtl.IdPresupuesto = IdPresupuesto
                    obj_dtl.Producto = _DT_DTL.Rows.Item(i)("Producto")
                    obj_dtl.Presentacion = IsNull(_DT_DTL.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Unidad = IsNull(_DT_DTL.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Precio = IsNull(_DT_DTL.Rows.Item(i)("Precio U$"), 0.0)
                    '
                    obj_dtl.Cantidad1 = IsNull(_DT_DTL.Rows.Item(i)("Enero"), 0.0)
                    obj_dtl.Cantidad2 = IsNull(_DT_DTL.Rows.Item(i)("Febrero"), 0.0)
                    obj_dtl.Cantidad3 = IsNull(_DT_DTL.Rows.Item(i)("Marzo"), 0.0)
                    obj_dtl.Cantidad4 = IsNull(_DT_DTL.Rows.Item(i)("Abril"), 0.0)
                    obj_dtl.Cantidad5 = IsNull(_DT_DTL.Rows.Item(i)("Mayo"), 0.0)
                    obj_dtl.Cantidad6 = IsNull(_DT_DTL.Rows.Item(i)("Junio"), 0.0)
                    obj_dtl.Cantidad7 = IsNull(_DT_DTL.Rows.Item(i)("Julio"), 0.0)
                    obj_dtl.Cantidad8 = IsNull(_DT_DTL.Rows.Item(i)("Agosto"), 0.0)
                    obj_dtl.Cantidad9 = IsNull(_DT_DTL.Rows.Item(i)("Septiembre"), 0.0)
                    obj_dtl.Cantidad10 = IsNull(_DT_DTL.Rows.Item(i)("Octubre"), 0.0)
                    obj_dtl.Cantidad11 = IsNull(_DT_DTL.Rows.Item(i)("Noviembre"), 0.0)
                    obj_dtl.Cantidad12 = IsNull(_DT_DTL.Rows.Item(i)("Diciembre"), 0.0)

                    db_dtl.Insertar(obj_dtl)
                Next
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
            'Actualizar registros modificados
            Dim _DT_UPD As DataTable = DT_DTL.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj_dtl.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj_dtl.IdPresupuesto = IdPresupuesto
                    obj_dtl.Producto = _DT_UPD.Rows.Item(i)("Producto")
                    obj_dtl.Presentacion = IsNull(_DT_UPD.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Unidad = IsNull(_DT_UPD.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Precio = IsNull(_DT_UPD.Rows.Item(i)("Precio U$"), 0.0)
                    '
                    obj_dtl.Cantidad1 = IsNull(_DT_UPD.Rows.Item(i)("Enero"), 0.0)
                    obj_dtl.Cantidad2 = IsNull(_DT_UPD.Rows.Item(i)("Febrero"), 0.0)
                    obj_dtl.Cantidad3 = IsNull(_DT_UPD.Rows.Item(i)("Marzo"), 0.0)
                    obj_dtl.Cantidad4 = IsNull(_DT_UPD.Rows.Item(i)("Abril"), 0.0)
                    obj_dtl.Cantidad5 = IsNull(_DT_UPD.Rows.Item(i)("Mayo"), 0.0)
                    obj_dtl.Cantidad6 = IsNull(_DT_UPD.Rows.Item(i)("Junio"), 0.0)
                    obj_dtl.Cantidad7 = IsNull(_DT_UPD.Rows.Item(i)("Julio"), 0.0)
                    obj_dtl.Cantidad8 = IsNull(_DT_UPD.Rows.Item(i)("Agosto"), 0.0)
                    obj_dtl.Cantidad9 = IsNull(_DT_UPD.Rows.Item(i)("Septiembre"), 0.0)
                    obj_dtl.Cantidad10 = IsNull(_DT_UPD.Rows.Item(i)("Octubre"), 0.0)
                    obj_dtl.Cantidad11 = IsNull(_DT_UPD.Rows.Item(i)("Noviembre"), 0.0)
                    obj_dtl.Cantidad12 = IsNull(_DT_UPD.Rows.Item(i)("Diciembre"), 0.0)

                    db_dtl.Actualizar(obj_dtl)
                Next
            End If
            '
            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable = DT_DTL.GetChanges(DataRowState.Added)

            If Not _DT_NEW Is Nothing Then
                For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                    obj_dtl.IdPresupuesto = IdPresupuesto
                    obj_dtl.Producto = _DT_NEW.Rows.Item(i)("Producto")
                    obj_dtl.Presentacion = IsNull(_DT_NEW.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Unidad = IsNull(_DT_NEW.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Precio = IsNull(_DT_NEW.Rows.Item(i)("Precio U$"), 0.0)
                    '
                    obj_dtl.Cantidad1 = IsNull(_DT_NEW.Rows.Item(i)("Enero"), 0.0)
                    obj_dtl.Cantidad2 = IsNull(_DT_NEW.Rows.Item(i)("Febrero"), 0.0)
                    obj_dtl.Cantidad3 = IsNull(_DT_NEW.Rows.Item(i)("Marzo"), 0.0)
                    obj_dtl.Cantidad4 = IsNull(_DT_NEW.Rows.Item(i)("Abril"), 0.0)
                    obj_dtl.Cantidad5 = IsNull(_DT_NEW.Rows.Item(i)("Mayo"), 0.0)
                    obj_dtl.Cantidad6 = IsNull(_DT_NEW.Rows.Item(i)("Junio"), 0.0)
                    obj_dtl.Cantidad7 = IsNull(_DT_NEW.Rows.Item(i)("Julio"), 0.0)
                    obj_dtl.Cantidad8 = IsNull(_DT_NEW.Rows.Item(i)("Agosto"), 0.0)
                    obj_dtl.Cantidad9 = IsNull(_DT_NEW.Rows.Item(i)("Septiembre"), 0.0)
                    obj_dtl.Cantidad10 = IsNull(_DT_NEW.Rows.Item(i)("Octubre"), 0.0)
                    obj_dtl.Cantidad11 = IsNull(_DT_NEW.Rows.Item(i)("Noviembre"), 0.0)
                    obj_dtl.Cantidad12 = IsNull(_DT_NEW.Rows.Item(i)("Diciembre"), 0.0)

                    db_dtl.Insertar(obj_dtl)
                Next
            End If
            '
            'Borrrar Lineas
            Dim _DT_DEL As DataTable = DT_DTL.GetChanges(DataRowState.Deleted)
            If Not _DT_DEL Is Nothing Then
                For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                    obj_dtl.IdDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)
                    db_dtl.Borrar(obj_dtl)
                Next
            End If'
            HideSplash()
            XtraMsg("Los Cambios al Presupuesto han sido actualizado con Exitio!")
            '
            ShowSplash("Cargando...")
            CargaInicial()
            HideSplash()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IdPresupuesto <> 0 Then

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, "Detalle de Presupuesto")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If IdPresupuesto <> 0 Then
            ShowSplash("Cargando Datos...")
            frmPresupuestoVer.Dispose()
            frmPresupuestoVer.MdiParent = Me.MdiParent
            frmPresupuestoVer.IdPresupuesto = iVista.GetFocusedRowCellValue("IdPresupuesto")
            frmPresupuestoVer.Text = "Ver Presupuesto"
            frmPresupuestoVer.Show()
            frmPresupuestoVer.WindowState = FormWindowState.Maximized
            HideSplash()
        End If
    End Sub
End Class