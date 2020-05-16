Imports DevExpress.XtraReports.UI
Public Class frmPlanNegocio

    Dim obj As New PNR_PlanNegocio
    Dim db As New db_PNR_PlanNegocio

    Dim obj_dtl As New PNR_PlanNegocioDetalle
    Dim db_dtl As New db_PNR_PlanNegocioDetalle

    Dim Articulos As New VB.SysContab.ArticulosDB

    Public IdPlanNegocio As Integer = 0
    Dim DT_DTL As DataTable = New DataTable("PNR_Detalle")
    Public DT_ROL As DataTable

    Private Sub frmPlanNegocio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmPlanNegocioList.Created Then frmPlanNegocioList.Cargar()
    End Sub

    Private Sub frmPlanNegocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        '
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        Application.DoEvents()
        MostrarDatos()
        '
        Application.DoEvents()
        Cargar()

        Application.DoEvents()
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'bImprimir'")
            If dr.Length > 0 Then bImprimir.Enabled = True

            Dim dr2() As DataRow = DT_ROL.Select("Control = 'bExportar'")
            If dr2.Length > 0 Then bExportar.Enabled = True
        End If
    End Sub

    Sub Cargar()
        DT_DTL = db_PNR_PlanNegocioDetalle.Listar(0, IdPlanNegocio, rgTipo.EditValue)
        iGrid.DataSource = DT_DTL

        'iVista.PopulateColumns()
        ' SimpleFormatGrid(iVista, True, DevExpress.Utils.HorzAlignment.Center, 0, 4, False, 0, 1, 2, 5)

        iVista.Columns("Producto").ColumnEdit = cbItems

        iVista.Columns("Cantidad_Aterior").Caption = "Cantidad KG/L " & (cbPeriodo.EditValue - 1).ToString
        iVista.Columns("Venta_Anterior").Caption = "Venta U$ " & (cbPeriodo.EditValue - 1).ToString

        iVista.Columns("Cantidad").Caption = "Proyección KG/L " & cbPeriodo.EditValue.ToString
        iVista.Columns("Venta_Actual").Caption = "Proyección U$ " & cbPeriodo.EditValue.ToString

        iVista.OptionsView.ShowAutoFilterRow = False

        For i As Integer = 0 To iVista.Columns.Count - 1

            If iVista.Columns(i).ColumnType.FullName = "System.Double" Or iVista.Columns(i).ColumnType.FullName = "System.Decimal" Then
                If iVista.Columns(i).FieldName <> "Porcentaje" Then
                    iVista.Columns(i).ColumnEdit = rMonto

                    iVista.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    iVista.Columns(i).SummaryItem.DisplayFormat = "{0:n2}"
                End If                
            End If
        Next
        ' 
        If iVista.DataRowCount > 0 Then rgTipo.Enabled = False
    End Sub

    Sub CargarCombos()
        Application.DoEvents()
        GridLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual), _
                   "Nombre", "Codigo", 0, 1, 2)
        cbCliente.Properties.PopupFormSize = New Point(900, 0)

        Application.DoEvents()
        'GetCentrosCostosList(cbSucursal)
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario " & EmpresaActual & "," & Usuario_ID & ""))
        'bSucursal.EditValue = Nothing

        Application.DoEvents()
        Combo(cbResponsable, db_PNR_Responsables.Listar(0))

        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())

        Application.DoEvents()
        Combo(cbCultivo, GetCultivo())

        Application.DoEvents()
        RepositoryGridLookup(cbItems, ObtieneDatos("JAR_ArticulosList " & EmpresaActual), "NOMBRE", "CODIGO_ARTICULO")
    End Sub

    Sub MostrarDatos()

        If IdPlanNegocio = 0 Then
            NumeroPNR.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)
        Else
            obj = db_PNR_PlanNegocio.Detalles(IdPlanNegocio)

            Fecha.DateTime = obj.Fecha
            NumeroPNR.Text = obj.Codigo
            cbPeriodo.EditValue = obj.Peridodo
            cbCliente.EditValue = obj.IdCliente
            cbResponsable.EditValue = obj.IdResponsable
            cbPropiedad.EditValue = obj.IdPropiedad
            txtTotalMz.EditValue = obj.Total_Mz
            txtMzAtendidas.EditValue = obj.Mz_Atendidas
            txtMzCultivo.EditValue = obj.Mz_Cultivo
            cbSucursal.EditValue = obj.IdSucursal
            txtPotencialBiologico.EditValue = obj.Potencial_Biologico
            cbCultivo.EditValue = obj.IdCultivo
            rgTipo.EditValue = obj.Presentacion
            mObservaciones.Text = obj.Observaciones
        End If
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        Try
            Application.DoEvents()

            GridLookUp(cbPropiedad, db_PNR_Propiedades.Listar(-1, cbCliente.EditValue, cbPeriodo.EditValue), _
                       "Nombre", "IdPropiedad", 5, 4, 3, 2, 1)
            cbPropiedad.Properties.PopupFormSize = New Point(900, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbResponsable_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbResponsable.ButtonClick
        If e.Button.Index = 1 Then
            With frmResponsablesAdd
                .IdResponsable = 0
                .Text = "Agregar Responsable de PNR"
                .ShowDialog()
                If .Ok = "SI" Then
                    Combo(cbResponsable, db_PNR_Responsables.Listar(0))
                End If

                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbPropiedad_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbPropiedad.ButtonClick
        If cbCliente.EditValue Is Nothing Then Exit Sub
        '
        If e.Button.Index = 1 Then
            With frmPropiedadesAdd
                .IdPropiedad = 0
                .Text = "Agregar Propiedad al Cliente"
                .cbCliente.Enabled = False
                .cbCliente.EditValue = cbCliente.EditValue
                .ShowDialog()
                If .Ok = "SI" Then
                    Application.DoEvents()
                    GridLookUp(cbPropiedad, db_PNR_Propiedades.Listar(-1, cbCliente.EditValue, cbPeriodo.EditValue), _
                               "Nombre", "IdPropiedad", 5, 4, 3, 2, 1)
                    cbPropiedad.Properties.PopupFormSize = New Point(900, 0)
                End If
                'GridLookUp(cbPropiedad, db_PNR_Propiedades.Listar(1, cbCliente.EditValue), _
                '       "Nombre", "IdPropiedad", 4, 3, 2, 1)
                .Dispose()
            End With
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'Validar que no se repita el PNR por Cliente y por Cultivo
        If IdPlanNegocio = 0 Then
            If db_PNR_PlanNegocio.ValidarPNR(cbCliente.EditValue, cbPeriodo.EditValue, cbCultivo.EditValue, cbSucursal.EditValue) Then
                XtraMsg("El PNR que esta intentando Ingresar ya Existe!")
                Exit Sub
            End If
        End If

        If iVista.DataRowCount = 0 Then
            XtraMsg("No se han registrado los Productos para este PNR!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        obj.IdPlanNegocio = IdPlanNegocio
        obj.Fecha = Fecha.DateTime.Date
        obj.Codigo = IIf(IdPlanNegocio = 0, db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue), NumeroPNR.Text)
        obj.Peridodo = cbPeriodo.EditValue
        obj.IdCliente = cbCliente.EditValue
        obj.IdResponsable = cbResponsable.EditValue
        obj.IdPropiedad = cbPropiedad.EditValue
        obj.Total_Mz = txtTotalMz.EditValue
        obj.Mz_Atendidas = txtMzAtendidas.EditValue
        obj.Mz_Cultivo = txtMzCultivo.EditValue
        obj.IdSucursal = cbSucursal.EditValue
        obj.Potencial_Biologico = txtPotencialBiologico.EditValue
        obj.IdCultivo = cbCultivo.EditValue
        obj.Presentacion = rgTipo.EditValue
        obj.Observaciones = mObservaciones.Text

        If IdPlanNegocio = 0 Then
            ShowSplash("Guardando PNR...")
            '
            IdPlanNegocio = db.Insertar(obj)

            ''********** Guardar Detalle    *****************************
            Dim _DT_DTL As DataTable = DT_DTL.GetChanges(DataRowState.Added Or DataRowState.Modified)

            If Not _DT_DTL Is Nothing Then
                For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                    obj_dtl.IdPlanNegocio = IdPlanNegocio
                    obj_dtl.Presentacion = rgTipo.EditValue
                    obj_dtl.Producto = _DT_DTL.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT_DTL.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Tipo = IsNull(_DT_DTL.Rows.Item(i)("Tipo"), "")

                    If rgTipo.EditValue = 4 Or rgTipo.EditValue = 3 Or rgTipo.EditValue = 2 Then
                        obj_dtl.Cantidad_Anterior = IsNull(_DT_DTL.Rows.Item(i)("Cantidad_Aterior"), 0.0)
                        obj_dtl.Venta_Anterior = IsNull(_DT_DTL.Rows.Item(i)("Venta_Anterior"), 0.0)
                        obj_dtl.Precio = IsNull(_DT_DTL.Rows.Item(i)("Precios"), 0.0)

                        obj_dtl.Cantidad = IsNull(_DT_DTL.Rows.Item(i)("Cantidad"), 0.0)
                        obj_dtl.CantidadQ1 = IsNull(_DT_DTL.Rows.Item(i)("1er Trimestre"), 0.0)
                        obj_dtl.VentasQ1 = IsNull(_DT_DTL.Rows.Item(i)("VentasQ1"), 0.0)
                        obj_dtl.CantidadQ2 = IsNull(_DT_DTL.Rows.Item(i)("2do Trimestre"), 0.0)
                        obj_dtl.VentasQ2 = IsNull(_DT_DTL.Rows.Item(i)("VentasQ2"), 0.0)
                        obj_dtl.CantidadQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_DTL.Rows.Item(i)("3er Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_DTL.Rows.Item(i)("VentasQ3"), 0.0), 0.0)
                        obj_dtl.CantidadQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_DTL.Rows.Item(i)("4to Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_DTL.Rows.Item(i)("VentasQ4"), 0.0), 0.0)
                        obj_dtl.ProyeccionQ1 = IsNull(_DT_DTL.Rows.Item(i)("ProyeccionQ1"), 0.0)
                        obj_dtl.ProyeccionQ2 = IsNull(_DT_DTL.Rows.Item(i)("ProyeccionQ2"), 0.0)
                        obj_dtl.ProyeccionQ3 = IsNull(_DT_DTL.Rows.Item(i)("ProyeccionQ3"), 0.0)
                        obj_dtl.ProyeccionQ4 = IsNull(_DT_DTL.Rows.Item(i)("ProyeccionQ4"), 0.0)
                    Else
                        obj_dtl.CantidadQ1 = 0.0
                        obj_dtl.CantidadQ2 = 0.0
                        obj_dtl.CantidadQ3 = 0.0
                        obj_dtl.CantidadQ4 = 0.0
                    End If

                    If rgTipo.EditValue = 1 Then
                        obj_dtl.Enero = IsNull(_DT_DTL.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Febrero = IsNull(_DT_DTL.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Marzo = IsNull(_DT_DTL.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Abril = IsNull(_DT_DTL.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Mayo = IsNull(_DT_DTL.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Junio = IsNull(_DT_DTL.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Julio = IsNull(_DT_DTL.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Agosto = IsNull(_DT_DTL.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Septiembre = IsNull(_DT_DTL.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Octubre = IsNull(_DT_DTL.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Noviembre = IsNull(_DT_DTL.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Diciembre = IsNull(_DT_DTL.Rows.Item(i)("Diciembre"), 0.0)
                    Else
                        obj_dtl.Enero = 0.0
                        obj_dtl.Febrero = 0.0
                        obj_dtl.Marzo = 0.0
                        obj_dtl.Abril = 0.0
                        obj_dtl.Mayo = 0.0
                        obj_dtl.Junio = 0.0
                        obj_dtl.Julio = 0.0
                        obj_dtl.Agosto = 0.0
                        obj_dtl.Septiembre = 0.0
                        obj_dtl.Octubre = 0.0
                        obj_dtl.Noviembre = 0.0
                        obj_dtl.Diciembre = 0.0
                    End If

                    db_dtl.Insertar(obj_dtl)
                Next
            End If

            HideSplash()

            If XtraMsg2("La Información se registro con éxito." & vbCrLf & _
                        "Desea registrar un Nuevo Plan de Negocio?") Then

                db_PNR_Reportes.Actualizar_Ventas_PNR(IdPlanNegocio)
                IdPlanNegocio = 0
                LimpiarControles(LayoutControl1)
            End If
            '
            ShowSplash("Cargando...")
            Application.DoEvents()
            CargarCombos()
            Application.DoEvents()
            MostrarDatos()
            Application.DoEvents()
            Cargar()

            db_PNR_Reportes.Actualizar_Ventas_PNR(IdPlanNegocio)
            HideSplash()
        Else
            ShowSplash("Actualizando PNR...")

            db.Actualizar(obj)  'Actualizar Encabezado del PNR

            ''********** Actualizar Detalle    **********************************************

            'Actualizar registros modificados
            Dim _DT_UPD As DataTable = DT_DTL.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj_dtl.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj_dtl.IdPlanNegocio = IdPlanNegocio
                    obj_dtl.Presentacion = rgTipo.EditValue
                    obj_dtl.Producto = _DT_UPD.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT_UPD.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Tipo = IsNull(_DT_UPD.Rows.Item(i)("Tipo"), "")

                    If rgTipo.EditValue = 4 Or rgTipo.EditValue = 3 Or rgTipo.EditValue = 2 Then
                        obj_dtl.Cantidad_Anterior = IsNull(_DT_UPD.Rows.Item(i)("Cantidad_Aterior"), 0.0)
                        obj_dtl.Venta_Anterior = IsNull(_DT_UPD.Rows.Item(i)("Venta_Anterior"), 0.0)
                        obj_dtl.Precio = IsNull(_DT_UPD.Rows.Item(i)("Precios"), 0.0)
                        obj_dtl.Cantidad = IsNull(_DT_UPD.Rows.Item(i)("Cantidad"), 0.0)
                        obj_dtl.CantidadQ1 = IsNull(_DT_UPD.Rows.Item(i)("1er Trimestre"), 0.0)
                        obj_dtl.VentasQ1 = IsNull(_DT_UPD.Rows.Item(i)("VentasQ1"), 0.0)
                        obj_dtl.CantidadQ2 = IsNull(_DT_UPD.Rows.Item(i)("2do Trimestre"), 0.0)
                        obj_dtl.VentasQ2 = IsNull(_DT_UPD.Rows.Item(i)("VentasQ2"), 0.0)
                        obj_dtl.CantidadQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_UPD.Rows.Item(i)("3er Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_UPD.Rows.Item(i)("VentasQ3"), 0.0), 0.0)
                        obj_dtl.CantidadQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_UPD.Rows.Item(i)("4to Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_UPD.Rows.Item(i)("VentasQ4"), 0.0), 0.0)
                        obj_dtl.ProyeccionQ1 = IsNull(_DT_UPD.Rows.Item(i)("ProyeccionQ1"), 0.0)
                        obj_dtl.ProyeccionQ2 = IsNull(_DT_UPD.Rows.Item(i)("ProyeccionQ2"), 0.0)
                        obj_dtl.ProyeccionQ3 = IsNull(_DT_UPD.Rows.Item(i)("ProyeccionQ3"), 0.0)
                        obj_dtl.ProyeccionQ4 = IsNull(_DT_UPD.Rows.Item(i)("ProyeccionQ4"), 0.0)
                    Else
                        obj_dtl.CantidadQ1 = 0.0
                        obj_dtl.CantidadQ2 = 0.0
                        obj_dtl.CantidadQ3 = 0.0
                        obj_dtl.CantidadQ4 = 0.0
                    End If

                    If rgTipo.EditValue = 1 Then
                        obj_dtl.Enero = IsNull(_DT_UPD.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Febrero = IsNull(_DT_UPD.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Marzo = IsNull(_DT_UPD.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Abril = IsNull(_DT_UPD.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Mayo = IsNull(_DT_UPD.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Junio = IsNull(_DT_UPD.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Julio = IsNull(_DT_UPD.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Agosto = IsNull(_DT_UPD.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Septiembre = IsNull(_DT_UPD.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Octubre = IsNull(_DT_UPD.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Noviembre = IsNull(_DT_UPD.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Diciembre = IsNull(_DT_UPD.Rows.Item(i)("Diciembre"), 0.0)
                    Else
                        obj_dtl.Enero = 0.0
                        obj_dtl.Febrero = 0.0
                        obj_dtl.Marzo = 0.0
                        obj_dtl.Abril = 0.0
                        obj_dtl.Mayo = 0.0
                        obj_dtl.Junio = 0.0
                        obj_dtl.Julio = 0.0
                        obj_dtl.Agosto = 0.0
                        obj_dtl.Septiembre = 0.0
                        obj_dtl.Octubre = 0.0
                        obj_dtl.Noviembre = 0.0
                        obj_dtl.Diciembre = 0.0
                    End If

                    db_dtl.Actualizar(obj_dtl)
                Next
            End If

            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable = DT_DTL.GetChanges(DataRowState.Added)

            If Not _DT_NEW Is Nothing Then
                For i As Integer = 0 To _DT_NEW.Rows.Count - 1

                    obj_dtl.IdPlanNegocio = IdPlanNegocio
                    obj_dtl.Presentacion = rgTipo.EditValue
                    obj_dtl.Producto = _DT_NEW.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT_NEW.Rows.Item(i)("Unidad"), "")
                    obj_dtl.Tipo = IsNull(_DT_NEW.Rows.Item(i)("Tipo"), "")

                    If rgTipo.EditValue = 4 Or rgTipo.EditValue = 3 Or rgTipo.EditValue = 2 Then
                        obj_dtl.Cantidad_Anterior = IsNull(_DT_NEW.Rows.Item(i)("Cantidad_Aterior"), 0.0)
                        obj_dtl.Venta_Anterior = IsNull(_DT_NEW.Rows.Item(i)("Venta_Anterior"), 0.0)
                        obj_dtl.Precio = IsNull(_DT_NEW.Rows.Item(i)("Precios"), 0.0)
                        obj_dtl.Cantidad = IsNull(_DT_NEW.Rows.Item(i)("Cantidad"), 0.0)
                        obj_dtl.CantidadQ1 = IsNull(_DT_NEW.Rows.Item(i)("1er Trimestre"), 0.0)
                        obj_dtl.VentasQ1 = IsNull(_DT_NEW.Rows.Item(i)("VentasQ1"), 0.0)
                        obj_dtl.CantidadQ2 = IsNull(_DT_NEW.Rows.Item(i)("2do Trimestre"), 0.0)
                        obj_dtl.VentasQ2 = IsNull(_DT_NEW.Rows.Item(i)("VentasQ2"), 0.0)
                        obj_dtl.CantidadQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_NEW.Rows.Item(i)("3er Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ3 = IIf(rgTipo.EditValue = 4 Or rgTipo.EditValue = 3, IsNull(_DT_NEW.Rows.Item(i)("VentasQ3"), 0.0), 0.0)
                        obj_dtl.CantidadQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_NEW.Rows.Item(i)("4to Trimestre"), 0.0), 0.0)
                        obj_dtl.VentasQ4 = IIf(rgTipo.EditValue = 4, IsNull(_DT_NEW.Rows.Item(i)("VentasQ4"), 0.0), 0.0)
                        obj_dtl.ProyeccionQ1 = IsNull(_DT_NEW.Rows.Item(i)("ProyeccionQ1"), 0.0)
                        obj_dtl.ProyeccionQ2 = IsNull(_DT_NEW.Rows.Item(i)("ProyeccionQ2"), 0.0)
                        obj_dtl.ProyeccionQ3 = IsNull(_DT_NEW.Rows.Item(i)("ProyeccionQ3"), 0.0)
                        obj_dtl.ProyeccionQ4 = IsNull(_DT_NEW.Rows.Item(i)("ProyeccionQ4"), 0.0)
                    Else
                        obj_dtl.CantidadQ1 = 0.0
                        obj_dtl.CantidadQ2 = 0.0
                        obj_dtl.CantidadQ3 = 0.0
                        obj_dtl.CantidadQ4 = 0.0
                    End If

                    If rgTipo.EditValue = 1 Then
                        obj_dtl.Enero = IsNull(_DT_NEW.Rows.Item(i)("Enero"), 0.0)
                        obj_dtl.Febrero = IsNull(_DT_NEW.Rows.Item(i)("Febrero"), 0.0)
                        obj_dtl.Marzo = IsNull(_DT_NEW.Rows.Item(i)("Marzo"), 0.0)
                        obj_dtl.Abril = IsNull(_DT_NEW.Rows.Item(i)("Abril"), 0.0)
                        obj_dtl.Mayo = IsNull(_DT_NEW.Rows.Item(i)("Mayo"), 0.0)
                        obj_dtl.Junio = IsNull(_DT_NEW.Rows.Item(i)("Junio"), 0.0)
                        obj_dtl.Julio = IsNull(_DT_NEW.Rows.Item(i)("Julio"), 0.0)
                        obj_dtl.Agosto = IsNull(_DT_NEW.Rows.Item(i)("Agosto"), 0.0)
                        obj_dtl.Septiembre = IsNull(_DT_NEW.Rows.Item(i)("Septiembre"), 0.0)
                        obj_dtl.Octubre = IsNull(_DT_NEW.Rows.Item(i)("Octubre"), 0.0)
                        obj_dtl.Noviembre = IsNull(_DT_NEW.Rows.Item(i)("Noviembre"), 0.0)
                        obj_dtl.Diciembre = IsNull(_DT_NEW.Rows.Item(i)("Diciembre"), 0.0)
                    Else
                        obj_dtl.Enero = 0.0
                        obj_dtl.Febrero = 0.0
                        obj_dtl.Marzo = 0.0
                        obj_dtl.Abril = 0.0
                        obj_dtl.Mayo = 0.0
                        obj_dtl.Junio = 0.0
                        obj_dtl.Julio = 0.0
                        obj_dtl.Agosto = 0.0
                        obj_dtl.Septiembre = 0.0
                        obj_dtl.Octubre = 0.0
                        obj_dtl.Noviembre = 0.0
                        obj_dtl.Diciembre = 0.0
                    End If

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
            End If

            HideSplash()
            '
            ShowSplash("Cargando...")
            Application.DoEvents()
            CargarCombos()
            Application.DoEvents()
            MostrarDatos()
            Application.DoEvents()
            Cargar()
            '
            HideSplash()
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'DxValidationProvider1.Dispose()
        'AddValidation(Me, DxValidationProvider1)
        'If IdPlanNegocio = 0 Then XtraMsg("Debe Guardar Primero el PNR Actual...")

        If cbCliente.EditValue Is Nothing Then Exit Sub

        With frmSituacionFinanciera
            .IdCliente = cbCliente.EditValue
            .txtCliente.Text = cbCliente.Text
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub cbPropiedad_EditValueChanged(sender As Object, e As EventArgs) Handles cbPropiedad.EditValueChanged
        Try
            Dim objPropiedades As New PNR_Propiedades
            objPropiedades = db_PNR_Propiedades.Detalles(cbPropiedad.EditValue, cbCliente.EditValue, cbPeriodo.EditValue)

            If Not objPropiedades Is Nothing Then
                cbCultivo.EditValue = objPropiedades.IdCultivo
                txtTotalMz.EditValue = objPropiedades.Total_Mz
                txtMzAtendidas.EditValue = objPropiedades.Mz_Atendidas
                txtMzCultivo.EditValue = objPropiedades.Mz_Cultivo
                txtPotencialBiologico.EditValue = objPropiedades.Potencial_Biologico
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rgTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgTipo.SelectedIndexChanged
        Cargar()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        Try
            If e.Column.FieldName = "Producto" Then
                Dim dr As DataRowView = cbItems.GetRowByKeyValue(e.Value)

                iVista.SetRowCellValue(e.RowHandle, "Unidad", dr.Item(2))
                iVista.SetRowCellValue(e.RowHandle, "Tipo", dr.Item(3))
                iVista.SetRowCellValue(e.RowHandle, "Precios", _
                                       CDbl(ObtieneDatos("SELECT dbo.fn_GetPrecioPromedioPNRxSucursal('" & cbSucursal.EditValue & "'," & cbPeriodo.EditValue & ",'" & e.Value & "','" & iVista.GetRowCellValue(e.RowHandle, "Tipo") & "'," & EmpresaActual & ") Precio;").Rows.Item(0)(0)))


                If DT_DTL.Compute("Count(Producto)", "Producto = '" & e.Value & "'") >= 1 Then
                    XtraMsg("Ya existe este ITEM en la lista", MessageBoxIcon.Error)
                    iVista.DeleteRow(e.RowHandle)
                End If

            End If

            If e.Column.FieldName = "Cantidad" Or e.Column.FieldName = "Precios" Then
                iVista.SetRowCellValue(e.RowHandle, "Venta_Actual", _
                                       Math.Round(CDbl(IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 0.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Precios"), 0.0)), 2))

                iVista.SetRowCellValue(e.RowHandle, "VariacionKL", _
                                       Math.Round(CDbl(IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 0.0) - IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad_Aterior"), 0.0)), 2))

                iVista.SetRowCellValue(e.RowHandle, "VariacionU", _
                                       Math.Round(CDbl(IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 0.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Precios"), 0.0)) - _
                                                  IsNull(iVista.GetRowCellValue(e.RowHandle, "Venta_Anterior"), 0.0), 2))
            End If

            If e.Column.FieldName = "ProyeccionQ1" Or _
                e.Column.FieldName = "ProyeccionQ2" Or _
                e.Column.FieldName = "ProyeccionQ3" Or _
                e.Column.FieldName = "ProyeccionQ4" Then

                iVista.SetRowCellValue(e.RowHandle, "Cantidad", IsNull(iVista.GetRowCellValue(e.RowHandle, "ProyeccionQ1"), 0.0) + _
                                       IsNull(iVista.GetRowCellValue(e.RowHandle, "ProyeccionQ2"), 0.0) + _
                                       IsNull(iVista.GetRowCellValue(e.RowHandle, "ProyeccionQ3"), 0.0) + _
                                       IsNull(iVista.GetRowCellValue(e.RowHandle, "ProyeccionQ4"), 0.0))

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub bClienteAdicional_Click(sender As Object, e As EventArgs) Handles bClienteAdicional.Click
        If IdPlanNegocio = 0 Then
            XtraMsg("Deber Guardar Primero este PNR para poder agregar Clientes Adicionales", MessageBoxIcon.Warning)
        Else
            frmClientesAdicionales.IdPlanNegocio = IdPlanNegocio
            frmClientesAdicionales.ShowDialog()
            frmClientesAdicionales.Dispose()
        End If
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        If IdPlanNegocio = 0 Then NumeroPNR.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If IdPlanNegocio = 0 Then XtraMsg("Debe Guardar Primero el PNR Actual...")

        If IdPlanNegocio > 0 Then
            ShowSplash("Imprimiendo Reporte...")
            '

            Dim rpt As New rptReportePNR
            Dim rprSub1 As New rptPlanDeAccion
            Dim rprSub2 As New rptAntecedentes

            'rpt.iGrid.DataSource = db_PNR_PlanNegocioDetalle.ReporteImpreso(IdPlanNegocio)
            rprSub1.DataSource = db_PNR_Reportes.ReportePlanDeAccion(IdPlanNegocio)
            rprSub2.DataSource = db_PNR_Reportes.ReporteAntecedentes(IdPlanNegocio)
            rpt.DataSource = db_PNR_Reportes.ReporteImpreso(IdPlanNegocio)

            'Dim rpt As New rptReportePNR
            'rpt.Periodo = cbPeriodo.EditValue
            'rpt.iGrid.DataSource = db_PNR_PlanNegocioDetalle.ReporteImpreso(IdPlanNegocio)      

            rpt.Periodo = cbPeriodo.EditValue
            rpt.xSubPlanAccion.ReportSource = rprSub1
            rpt.xSubAntecedentes.ReportSource = rprSub2
            ' rpt.ShowRibbonPreview()
            ' rpt.ShowRibbonPreview()

            rpt.CreateDocument()

            frmReportViewer.Dispose()

            With frmReportViewer
                .DocumentViewer1.DocumentSource = rpt
                .Show()
                .Text = "Vista Previa Plan de Negocio"
                .WindowState = FormWindowState.Maximized

                'Verificar si el Usuario tiene permiso de Imprimir y Exportar el reporte        
                If DT_ROL.Rows.Count > 0 Then
                    Dim dr() As DataRow = DT_ROL.Select("Control = 'Imprimir'")
                    If dr.Length > 0 Then .BarraImprimir.Enabled = True
                End If
            End With
            '
            HideSplash()
        End If
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        Try
            iVista.Columns("Cantidad_Aterior").Caption = "Cantidad " & (cbPeriodo.EditValue - 1).ToString
            iVista.Columns("Cantidad").Caption = "Cantidad " & cbPeriodo.EditValue.ToString

            If IdPlanNegocio = 0 Then NumeroPNR.Text = db_PNR_PlanNegocio.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue), cbPeriodo.EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub iVista_KeyDown1(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Plan de Negocio de " & cbCultivo.Text & vbCrLf & "Sucursal: " & cbSucursal.Text, "Cliente: " & cbCliente.Text, False)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If IdPlanNegocio <> 0 Then
            If XtraMsg2("El Proceso de Actualizacion de Venta en los PNR puede demorar algunos minutos " & vbCrLf _
                        & "ya que actualiza todas las ventas del periodo actual y anterior de cada uno de los productos contenidos en este PNR." & vbCrLf _
                        & "Desea Actulizarlo ?") Then

                ShowSplash()
                If db_PNR_Reportes.Actualizar_Ventas_PNR(IdPlanNegocio) Then Cargar()            
                HideSplash()
            End If
        End If
        
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If IdPlanNegocio = 0 Then
            XtraMsg("Debe Guardar Primero el PNR Actual...")
            Exit Sub
        End If
        '
        With frmDocumentos
            .Tipo = "CLIENTES"
            .Codigo = cbCliente.EditValue
            .NDocumento = cbCliente.Text
            .Text = "Soporte Digital del Cliente: " & cbCliente.Text
            .txtNombre.Text = cbCliente.Text
            .ShowDialog()
            .Dispose()
        End With

    End Sub
End Class