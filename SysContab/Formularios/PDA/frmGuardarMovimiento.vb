Imports ClasesBLL

Public Class frmGuardarMovimiento
    Public IdRequisa_Importar As Integer = 0,
        IdRemision As Integer = 0,
        NoRemision As String = "",
        IdOrden As Integer = 0

    Public Tipo As Integer = 1
    Dim DT As New DataTable

    Private Sub frmGuardarMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        tTasa.EditValue = GetTasaCambioDia(fecha.DateTime.Date)

        GetBodegasxUsuario(cmbbodega, 0)
        cmbbodega.ItemIndex = 0
        '
        Combo(cbBodegaDestino, ObtieneDatos("JAR_GetBodegasList", EmpresaActual))
        cbBodegaDestino.Properties.NullText = "[Bodega Destino]"

        GetTipoMovimientos(cbMovimientos, 1)
        cbMovimientos.ItemIndex = 0
        '
        Combo(cmbrequisa, ObtieneDatos("SELECT 1 AS Codigo, 'Entrada' AS Nombre UNION ALL SELECT 2 AS Codigo, 'Salida' AS Nombre"))
        cmbrequisa.ItemIndex = 0

        ListaArticulos()
        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)

        SearchLookUp(cbCliente, ObtieneDatos("JAR_GetClientes", EmpresaActual), "Nombre", "Codigo")
        cbCliente.EditValue = 0

        SearchLookUp(cbProyectos, db_Proyectos.Fill(1), "Nombre", "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0
        '
        If TipoServicio.EditValue <> 2 Then
            lyRequisa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            txtRequisa.Text = VB.SysContab.RequisasDB.GetCodigoNuevo()
        Else
            lyRequisa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        If IdRequisa_Importar > 0 Then MostrarDatos()

        If Tipo = 3 Then
            lyTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyOrigen.Text = "Bodega Origen:"
            cbBodegaDestino.Enabled = True
            LookUp(cbMovimientos, ObtieneDatos("sp_Get_TipoMovimientos_Traslados", EmpresaActual), "Nombre", "Codigo", "[Seleccione Movimiento]", 0, 2)
            cbMovimientos.ItemIndex = 0
        End If

        If Tipo = 4 Then
            lyOrigen.Text = "Bodega:"
            lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            cmbrequisa.EditValue = 2
            MostrarRemision()
        End If

        If Tipo = 5 Then
            lyOrigen.Text = "Bodega:"
            lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            cmbrequisa.EditValue = 2
            MostrarRemisionOT()
        End If
    End Sub

    Sub MostrarDatos()
        DT = ObtieneDatos("JAR_GetRequisasEditar", IdRequisa_Importar, EmpresaActual, Tipo)
        '
        cmbbodega.EditValue = DT.Rows(0)("codigo_bodega")
        fecha.EditValue = DT.Rows(0)("req_fecha")
        txtReferencia.Text = DT.Rows(0)("Referencia")
        NoFactura.Text = DT.Rows(0)("Factura")
        cbCliente.EditValue = DT.Rows(0)("IdCliente")
        NoPoliza.Text = DT.Rows(0)("NoPoliza")

        iGrid.DataSource = DT
        iVista.Columns("Item_Nombre").Visible = False

        If Tipo = 2 Then iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom

    End Sub

    Sub MostrarRemision()

        Dim obj As New Remisiones
        obj = db_Remisiones.Detalles(IdRemision)

        fecha.DateTime = obj.Fecha
        cmbbodega.EditValue = obj.Bodega
        txtComentario.Text = obj.Concepto
        cbProyectos.EditValue = obj.IdProyecto
        cbCliente.EditValue = obj.IdCliente

        If cbProyectos.EditValue <> 0 Then txtReferencia.Text = db_Proyectos.Detalles(cbProyectos.EditValue).Codigo

        iGrid.DataSource = db_RemisionesDetalle.Listar2(IdRemision)
        iVista.Columns("Item_Nombre").Visible = False

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Costo").OptionsColumn.AllowEdit = True
        iVista.Columns("Agrupar").OptionsColumn.AllowEdit = True

        'cbProyectos_EditValueChanged(Nothing, Nothing)
    End Sub

    Sub MostrarRemisionOT()

        Dim obj As New OrdenesTrabajo
        obj = db_OrdenesTrabajo.Detalles(IdRemision)

        fecha.DateTime = obj.Fecha
        cmbbodega.EditValue = obj.Bodega
        txtComentario.Text = obj.Observaciones
        txtReferencia.Text = obj.Documento
        cbCliente.EditValue = obj.IdCliente

        iGrid.DataSource =
            db_OrdenesTrabajoDetalle.Detalle_Movimiento(IdRemision)
        iVista.Columns("Item_Nombre").Visible = False

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Costo").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub ListaArticulos()
        Dim DTP As DataTable
        DTP = ObtieneDatos("JAR_GetArticulo " & EmpresaActual & ",'P'")
        ItemProducto.DataSource = DTP
        ItemProducto.DisplayMember = "Codigo"
        ItemProducto.ValueMember = "Codigo"
        ItemProducto.PopulateColumns()
        ItemProductoD.DataSource = DTP
        ItemProductoD.DisplayMember = "Nombre"
        ItemProductoD.ValueMember = "Codigo"
        ItemProductoD.PopulateColumns()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If cbProyectos.EditValue = 0 Then
            If TipoServicio.EditValue = 1 Then
                If cbMovimientos.ItemIndex = 0 Then
                    XtraMsg("Seleccione Tipo de Movimiento")
                    cbMovimientos.Focus()
                    Exit Sub
                End If
            End If
        End If
        '
        If txtComentario.Text.Trim.Length = 0 Then
            XtraMsg("Describa un comentario para este movimiento")
            txtComentario.Focus()
            Exit Sub
        End If

        If TipoServicio.EditValue = 3 Then
            If cmbbodega.EditValue = cbBodegaDestino.EditValue Then
                XtraMsg("Las bodegas deben ser diferentes para realizar un traslado", MessageBoxIcon.Warning)
                cbBodegaDestino.Focus()
                Exit Sub
            End If
            '
            If cbBodegaDestino.EditValue Is Nothing Then
                XtraMsg("Seleccione la Bodega Destino", MessageBoxIcon.Warning)
                cbBodegaDestino.Focus()
                Exit Sub
            End If
        End If
        '
        If cmbrequisa.EditValue = 2 Then
            If cbProyectos.EditValue <> 0 Then
                If Not XtraMsg2("Estos productos se Cargarán al Proyecto : " & cbProyectos.Text & vbCrLf &
                                "Está Seguro que la información es Correcta?") Then
                    Exit Sub
                End If
            End If
        End If

        If TipoServicio.EditValue = 1 Then          'Remision
            If Tipo = 4 Then
                GuardarRequisaRemision()
            ElseIf Tipo = 5 Then
                GuardarRequisaRemisionOT()
            Else
                GuardarRequisa()
            End If
        ElseIf TipoServicio.EditValue = 2 Then      'Inventario Fisico
            GuardarFisico()
        ElseIf TipoServicio.EditValue = 3 Then      'Traslado
            GuardarTraslado()
        End If
    End Sub

    Sub GuardarRequisa()
        Dim Requisa As Integer = 0

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            ShowSplash("Guardando Movimiento...")
            '
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")
            Requisa = Conn.GetParameter("Codigo").Valor
            '
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, cmbrequisa.Text.ToString.Substring(0, 1))
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cmbbodega.EditValue)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura.Text)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, cbMovimientos.EditValue)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtReferencia.Text)
            Conn.AddParameter("Movil", SqlDbType.Int, 5, ParameterDirection.Input, IIf(Tipo = 1, 1, 0))
            Conn.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, IIf(Tipo = 1, IdRequisa_Importar, 0))
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, txtComentario.Text)
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)

            Conn.EjecutarComando("SP_Requisas_Add")

            If Tipo = 1 Then
                Conn.RemoveParameters()
                Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa_Importar)
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.EjecutarComando("JAR_ActualizarEstadoRequisaMovil")
            End If

            For i As Integer = 0 To iVista.DataRowCount - 1
                'Agregar el detalle de la requisa
                If iVista.GetRowCellValue(i, "Cantidad") > 0 Then
                    Conn.RemoveParameters()
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Cantidad"))
                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Costo"))
                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbMovimientos.GetColumnValue("Cuenta"))
                    Conn.AddParameter("Ubicacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Ubicacion"), ""))
                    '
                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                End If
            Next
            '
            Conn.CompletarTransaccion()

            HideSplash()
            XtraMsg("Movimiento Guardado Satisfactoriamente!", MessageBoxIcon.Information)

            If Tipo = 1 Then frmImportarPDA.GetData()
            Close()

        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & ". Guardar Remision", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Sub GuardarFisico()

        Dim Numero As String = "", IdInventario As Integer = 0

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            ShowSplash("Guardando Inventario...")

            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Numero", SqlDbType.NVarChar, 50, ParameterDirection.Output, "")

            Conn.EjecutarComando("JAR_GetNumeroInventarioFisicoMovil")
            Numero = Conn.GetParameter("Numero").Valor
            '
            Conn.RemoveParameters()
            Conn.AddParameter("IdInventario", SqlDbType.Int, 4, ParameterDirection.Input, 0)
            Conn.AddParameter("empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, fecha.DateTime.Date)
            Conn.AddParameter("codigo_bodega", SqlDbType.NVarChar, 50, ParameterDirection.Input, cmbbodega.EditValue)
            Conn.AddParameter("realizadopor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("documento", SqlDbType.NVarChar, 50, ParameterDirection.Input, Numero)
            Conn.AddParameter("origen", SqlDbType.NVarChar, 1, ParameterDirection.Input, "P")
            Conn.AddParameter("Comentario", SqlDbType.NVarChar, -1, ParameterDirection.Input, txtComentario.Text)
            Conn.AddParameter("Id", SqlDbType.Int, 4, ParameterDirection.Output, 0)
            Conn.AddParameter("IdMovil", SqlDbType.Int, 4, ParameterDirection.Input, IdRequisa_Importar)
            Conn.AddParameter("Movil", SqlDbType.Bit, 0, ParameterDirection.Input, 1)

            Conn.EjecutarComando("RCT_GuardaInventarioFisico")
            IdInventario = Conn.GetParameter("Id").Valor

            For i As Integer = 0 To iVista.DataRowCount - 1
                Conn.RemoveParameters()
                If Not iVista.GetRowCellValue(i, "Codigo") Is DBNull.Value Then
                    'Calcular Existencia Real por producto para sacar diferencias contra el Fisico
                    Dim ExistenciaReal As Double = 0.0

                    Conn.RemoveParameters()
                    Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, cmbbodega.EditValue)
                    Conn.AddParameter("Codigo", SqlDbType.NVarChar, 100, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, fecha.DateTime.Date)
                    Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Output, 0)

                    Conn.EjecutarComando("JAR_GetExistenciaReal")
                    ExistenciaReal = Conn.GetParameter("Existencia").Valor

                    'Guardar Detalle del Inventario
                    Conn.RemoveParameters()
                    Conn.AddParameter("empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                    Conn.AddParameter("fecha", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, fecha.DateTime.Date)
                    Conn.AddParameter("codigo_bodega", SqlDbType.NVarChar, 50, ParameterDirection.Input, cmbbodega.EditValue)
                    Conn.AddParameter("codigo_articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                    Conn.AddParameter("articulo_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, "P")
                    Conn.AddParameter("existencias", SqlDbType.Float, 8, ParameterDirection.Input, ExistenciaReal)
                    Conn.AddParameter("fisico", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Cantidad"))
                    Conn.AddParameter("diferencias", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Cantidad") + IIf(ExistenciaReal < 0, ExistenciaReal * -1, ExistenciaReal * -1))
                    Conn.AddParameter("justificar", SqlDbType.Int, 4, ParameterDirection.Input, 0)
                    Conn.AddParameter("comentarios", SqlDbType.Text, 16, ParameterDirection.Input, "")
                    Conn.AddParameter("comentarios_justificar", SqlDbType.Text, 16, ParameterDirection.Input, "")
                    Conn.AddParameter("IdDetalle", SqlDbType.Int, 4, ParameterDirection.Input, 0)
                    Conn.AddParameter("IdFisico", SqlDbType.Int, 4, ParameterDirection.Input, IdInventario)
                    Conn.AddParameter("costo", SqlDbType.Float, 8, ParameterDirection.Input, iVista.GetRowCellValue(i, "Costo"))
                    Conn.AddParameter("Unidad", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                    Conn.AddParameter("Modelo", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                    Conn.AddParameter("Ubicacion", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Ubicacion"), ""))
                    Conn.AddParameter("Item_Nombre", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(iVista.GetRowCellValue(i, "Item_Nombre"), ""))

                    Conn.EjecutarComando("RCT_SPGuardaInventarioFisicoDetalle")
                End If
            Next

            Conn.RemoveParameters()
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, IdRequisa_Importar)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.EjecutarComando("JAR_ActualizarEstadoRequisaMovil")

            Conn.CompletarTransaccion()

            HideSplash()
            XtraMsg("Inventario Físico Guardado Satisfactoriamente!", MessageBoxIcon.Information)

            frmImportarPDA.GetData()
            Close()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & ". Guardar Fisico", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Sub GuardarTraslado()

        Dim Requisa As Integer = 0, Entrada As Integer = 0, Salida As Integer = 0
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try

            ShowSplash("Guardando Traslado...")

            Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()
            Entrada = Requisa
            'Registrando Entrada
            'Encabezado
            'Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbBodegaDestino.EditValue)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura.Text)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, cbMovimientos.EditValue)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtReferencia.Text)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, txtComentario.Text)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)

            Conn.EjecutarComando("SP_Requisas_Add")

            For i As Integer = 0 To iVista.DataRowCount - 1
                'Agregar el detalle de la requisa
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Cantidad"))
                Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Costo"))
                Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbMovimientos.Properties.GetDataSourceValue("Cuenta", cbMovimientos.ItemIndex).ToString)
                Conn.AddParameter("Presentacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")

                Conn.EjecutarComando("SP_Requisas_Detalle_Add")
            Next
            '******************************************************************
            ' Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()

            'Registrando Salida
            Salida = Requisa + 1
            'Encabezado
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "S")
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cmbbodega.EditValue)
            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura.Text)
            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, cbMovimientos.EditValue)
            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtReferencia.Text)
            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, txtComentario.Text)
            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)

            Conn.EjecutarComando("SP_Requisas_Add")

            For i As Integer = 0 To Me.iVista.DataRowCount - 1
                'Agregar el detalle de la requisa
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
                Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, iVista.GetRowCellValue(i, "Codigo"))
                Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Cantidad"))
                Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, iVista.GetRowCellValue(i, "Costo"))
                Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, cbMovimientos.Properties.GetDataSourceValue("Cuenta", cbMovimientos.ItemIndex).ToString)
                Conn.AddParameter("Presentacion", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")

                Conn.EjecutarComando("SP_Requisas_Detalle_Add")
            Next

            Conn.CompletarTransaccion()
            HideSplash()
            XtraMsg("Traslado Realizado Exitosamente !!!", MessageBoxIcon.Information)
            '
            If frmTrasladosBodegasList.Created Then frmTrasladosBodegasList.Cargar()

            Close()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & ". Guardar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Sub GuardarRequisaRemision()

        If cbProyectos.EditValue <> 0 Then
            If GuardarTraslado_Proyecto() Then
                'Actualizar el Proyecto en la Remision.
                db_Remisiones.RemisionesActualizarProyecto(IdRemision, cbProyectos.EditValue)
                XtraMsg("El Movimiento de Traslado al Proyecto " & cbProyectos.Text & " se realizó Satisfactoriamente!")
                If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
                Close()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
        '
        ShowSplash("Guardando Movimiento...")

        'Si no es proyecto se guarda el Movimiento Normal
        Dim Requisa As Integer = db_requisas.Add(EmpresaActual, cmbrequisa.Text.ToString.Substring(0, 1), fecha.DateTime.Date, cmbbodega.EditValue,
                                         Login, NoFactura.Text, cbMovimientos.EditValue, txtReferencia.Text, txtComentario.Text,
                                         "", "", "", NoRemision, "", "", cbCliente.EditValue, NoPoliza.Text)

        If Requisa = 0 Then Exit Sub
        '
        For i As Integer = 0 To iVista.DataRowCount - 1
            'Agregar el detalle de la requisa
            If iVista.GetRowCellValue(i, "Cantidad") > 0 Then
                db_requisas.AddDetalle(EmpresaActual, Requisa, iVista.GetRowCellValue(i, "Codigo"), "P",
                                            IIf(iVista.GetRowCellValue(i, "Cantidad") < 0, iVista.GetRowCellValue(i, "Cantidad") * -1,
                                            iVista.GetRowCellValue(i, "Cantidad")),
                                            iVista.GetRowCellValue(i, "Costo"), iVista.GetRowCellValue(i, "Cuenta"), "", "", "")
            End If
        Next
        '
        db_Remisiones.Remisiones_Parcelas(IdRemision, EmpresaActual)

        HideSplash()
        XtraMsg("Movimiento Guardado Satisfactoriamente!", MessageBoxIcon.Information)

        If Tipo = 4 Then If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
        Close()

    End Sub

    Function GuardarTraslado_Proyecto() As Boolean

        Dim DT_MOV As DataTable = ObtieneDatos("sp_Get_MovimientoProyecto", EmpresaActual)

        If DT_MOV.Rows.Count = 0 Then
            XtraMsg("No existe Movimiento Creado para este tipo de transacción.")
            Return False
        End If

        Dim Id_Mov As Integer =
            DT_MOV.Rows.Item(0)("Movimiento")

        Dim Entrada As Integer = 0,
            Salida As Integer = 0

        Try
            ShowSplash("Guardando Movimiento...")

            'Guardar Entrada
            Entrada = db_requisas.Add(EmpresaActual, "E", fecha.DateTime.Date, db_Proyectos.Detalles(cbProyectos.EditValue).Bodega,
                                          Login, NoFactura.Text, Id_Mov, txtReferencia.Text, txtComentario.Text,
                                          "", "", "", NoRemision, "", "", cbCliente.EditValue, NoPoliza.Text,
                                          cbProyectos.EditValue, IIf(Tipo = 5, IdRemision, 0))

            If Entrada > 0 Then
                For i As Integer = 0 To iVista.DataRowCount - 1
                    db_requisas.AddDetalle(EmpresaActual, Entrada, iVista.GetRowCellValue(i, "Codigo"), "P",
                                                    iVista.GetRowCellValue(i, "Cantidad"), iVista.GetRowCellValue(i, "Costo"),
                                                    iVista.GetRowCellValue(i, "Cuenta"), "", "",
                                                    IsNull(iVista.GetRowCellValue(i, "Agrupar"), ""),
                                                    Math.Round(CDbl(iVista.GetRowCellValue(i, "Precio U$") * tTasa.EditValue), 2),
                                                    tTasa.EditValue)
                Next
                '
                'Guardar Salida
                Salida = db_requisas.Add(EmpresaActual, "S", fecha.DateTime.Date, cmbbodega.EditValue,
                                          Login, NoFactura.Text, Id_Mov, txtReferencia.Text, txtComentario.Text,
                                          "", "", "", NoRemision, "", "", cbCliente.EditValue, NoPoliza.Text,
                                          cbProyectos.EditValue, IIf(Tipo = 5, IdRemision, 0), 0, 0, Entrada)

                For i As Integer = 0 To iVista.DataRowCount - 1
                    db_requisas.AddDetalle(EmpresaActual, Salida, iVista.GetRowCellValue(i, "Codigo"), "P",
                                                    iVista.GetRowCellValue(i, "Cantidad"), iVista.GetRowCellValue(i, "Costo"),
                                                    iVista.GetRowCellValue(i, "Cuenta"), "", "",
                                                    IsNull(iVista.GetRowCellValue(i, "Agrupar"), ""),
                                                    Math.Round(CDbl(iVista.GetRowCellValue(i, "Precio U$") * tTasa.EditValue), 2),
                                                    tTasa.EditValue)
                Next
            End If

            HideSplash()

            Return True
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Sub GuardarRequisaRemisionOT()

        If cbProyectos.EditValue <> 0 Then
            If GuardarTraslado_Proyecto() Then
                'Actualizar el Proyecto en la Orden de Trabajo.
                db_OrdenesTrabajo.UpdateRemisiones(
                    IdRemision,
                    "N",
                    cbProyectos.EditValue)

                XtraMsg("El Movimiento de Traslado al Proyecto " & cbProyectos.Text & " se realizó Satisfactoriamente!")

                frmRemisionesTaller.Cargar()
                Close()
                Exit Sub
            Else
                Exit Sub
            End If
        End If


        ShowSplash("Guardando Movimiento...")

        Dim Requisa As Integer =
            db_requisas.Add(
            EmpresaActual,
            cmbrequisa.Text.ToString.Substring(0, 1),
            fecha.DateTime.Date,
            cmbbodega.EditValue,
            Login,
            NoFactura.Text,
            cbMovimientos.EditValue,
            txtReferencia.Text,
            txtComentario.Text,
            "",
            "",
            "",
            NoRemision,
            "",
            "",
            cbCliente.EditValue,
            NoPoliza.Text,
            0,
            IdRemision)

        If Requisa = 0 Then Exit Sub
        '
        For i As Integer = 0 To iVista.DataRowCount - 1
            'Agregar el detalle de la requisa
            If iVista.GetRowCellValue(i, "Cantidad") > 0 Then
                db_requisas.AddDetalle(
                    EmpresaActual,
                    Requisa,
                    iVista.GetRowCellValue(i, "Codigo"),
                    "P",
                    IIf(iVista.GetRowCellValue(i, "Cantidad") < 0, iVista.GetRowCellValue(i, "Cantidad") * -1, iVista.GetRowCellValue(i, "Cantidad")),
                    iVista.GetRowCellValue(i, "Costo"), iVista.GetRowCellValue(i, "Cuenta"),
                    "",
                    "",
                    "")
            End If
        Next
        '
        db_OrdenesTrabajo.UpdateRemisiones(IdRemision, "N")
        '
        HideSplash()
        XtraMsg("Movimiento Guardado Satisfactoriamente!", MessageBoxIcon.Information)

        If Tipo = 5 Then frmRemisionesTaller.Cargar()
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Codigo" Then
            Try
                If DT.Compute("Count(Codigo)", "Codigo = '" & e.Value & "'") >= 1 Then 'And cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then
                    XtraMsg("Ya existe este articulo en la lista", MessageBoxIcon.Warning)
                    iVista.DeleteRow(iVista.FocusedRowHandle)
                End If
                '
                Dim DT_PROD As DataTable = ObtieneDatos("JAR_GetProductoExistencia", e.Value, cmbbodega.EditValue, EmpresaActual)

                If DT_PROD.Rows.Count > 0 Then
                    iVista.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
                    iVista.SetRowCellValue(e.RowHandle, "Costo", DT_PROD.Rows.Item(0)("Costo"))
                    iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                    iVista.SetRowCellValue(e.RowHandle, "Activo", True)
                End If

                iVista.SetRowCellValue(e.RowHandle, "Cuenta", cbMovimientos.GetColumnValue("Cuenta"))
            Catch ex As Exception
                iVista.SetRowCellValue(e.RowHandle, "Existencia", 0.0)
                iVista.SetRowCellValue(e.RowHandle, "Costo", 0.0)
                iVista.SetRowCellValue(e.RowHandle, "Cuenta", "")
                iVista.SetRowCellValue(e.RowHandle, "Activo", False)
            End Try
        End If
    End Sub

    Private Sub vDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        If Tipo = 4 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
        End If
    End Sub

    Private Sub cbMovimientos_EditValueChanged(sender As Object, e As EventArgs) Handles cbMovimientos.EditValueChanged
        If cbMovimientos.ItemIndex <> 0 Then
            For i As Integer = 0 To iVista.DataRowCount - 1
                iVista.SetRowCellValue(i, "Cuenta", cbMovimientos.GetColumnValue("Cuenta"))
            Next
            iVista.RefreshData()
        End If
    End Sub

    Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs) Handles cbProyectos.EditValueChanged
        If cbProyectos.EditValue <> 0 Then
            cbCliente.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "IdCliente")
            cbCliente.ReadOnly = True
            '
            txtReferencia.Text = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Codigo")
        Else
            cbCliente.EditValue = 0
            cbCliente.ReadOnly = False
            '
            txtReferencia.Text = ""
        End If
    End Sub

    Private Sub fecha_EditValueChanged(sender As Object, e As EventArgs) Handles fecha.EditValueChanged
        tTasa.EditValue = GetTasaCambioDia(fecha.DateTime.Date)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, "Inventario Importado de PDA")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        iVista.Columns("Cuenta").Visible = False
        VistaPrevia(iGrid, "Inventario Importado al: " & fecha.DateTime.ToShortDateString, "Tipo: " & cmbrequisa.Text)
        iVista.Columns("Cuenta").Visible = True
    End Sub

    Private Sub TipoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoServicio.SelectedIndexChanged

        If TipoServicio.EditValue = 3 Then
            lyOrigen.Text = "Bodega Origen:"
            cbBodegaDestino.Enabled = True
            LookUp(cbMovimientos, ObtieneDatos("sp_Get_TipoMovimientos_Traslados", EmpresaActual), "Nombre", "Codigo", "[Seleccione Movimiento]", 0, 2)
            cbMovimientos.ItemIndex = 0

            'lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lyOrigen.Text = "Bodega:"
            cbBodegaDestino.Enabled = False
            GetTipoMovimientos(cbMovimientos, 1)
            cbMovimientos.ItemIndex = 0
            'lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        '
        If TipoServicio.EditValue <> 2 Then
            lyRequisa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            txtRequisa.Text = VB.SysContab.RequisasDB.GetCodigoNuevo()
        Else
            lyRequisa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

    End Sub
End Class