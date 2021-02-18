Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class frmFacturasCuotasAdd

    Public FromFactur As Boolean,
        Ok As Boolean = False

    Private _Id As Integer = 0,
        _IdCliente As Integer = 0,
        _Factura As String = String.Empty,
        _Moneda As String,
        _Monto As Double = 0.00

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property


    Public Property IdCliente() As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Public Property Factura() As String
        Get
            Return _Factura
        End Get
        Set(ByVal value As String)
            _Factura = value
        End Set
    End Property


    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return _Monto
        End Get
        Set(ByVal value As Double)
            _Monto = value
        End Set
    End Property

    Dim DT_DETALLE As DataTable,
        obj As New FacturasCuotas,
        db As New db_FacturasCuotas,
        objDetalle As New FacturasCuotasDetalle,
        dbDetalle As New db_FacturasCuotasDetalle

    Private Sub frmFacturasCuotasAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormatoRibbonVB(Me.RibbonControl)
        AddValidation(Me, DxValidationProvider1)

        SearchLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual),
                "Nombre", "Codigo", 0, 3)

        If IdCliente > 0 Then
            cbCliente.EditValue = IdCliente
            cbCliente.Properties.ReadOnly = True
        End If
        '
        GetMonedas(cbMoneda)
        '
        MostrarDatos()

        With iVistaAP
            .PopulateColumns()
            FormatoGridNew(iVistaAP, 2, 2, False, True, False)
            '
            .Columns("IdDetalle").Visible = False
            .Columns("Vencimiento").Visible = False
            .Columns("Interes").Visible = False
            .Columns("Saldo").Visible = False
            '
            For i As Integer = 0 To .Columns.Count - 1
                .Columns(i).OptionsColumn.AllowEdit = False
            Next
            '
            .Columns("FechaPago").OptionsColumn.AllowEdit = True
        End With
        '
        If FromFactur Then
            cbMoneda.EditValue = Moneda
            tMonto.EditValue = Monto
        End If
    End Sub

    Sub MostrarDatos()
        If Id > 0 Then
            obj = db.Detalles(Id, EmpresaActual)

            cbCliente.EditValue = obj.IdCliente
            cbFactura.EditValue = obj.Factura
            Fecha.DateTime = obj.FechaSolicitud
            tMonto.EditValue = obj.Monto
            cbMoneda.EditValue = obj.Moneda
            FechaInicial.DateTime = obj.FechaInicio
            sCuotas.EditValue = obj.NoCuotas
        Else
            FechaInicial.DateTime = Now.Date
        End If
        '
        DT_DETALLE = dbDetalle.Listar(Id, EmpresaActual)
        iGridAP.DataSource = DT_DETALLE

        If DT_DETALLE.Rows.Count > 0 Then
            If DT_DETALLE.Select("Aplicada").Length > 0 Then bGenerarTabla.Enabled = False
        End If
    End Sub

    Private Sub bGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardar.ItemClick
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If iVistaAP.DataRowCount = 0 Then
            XtraMsg("No se ha generado el Calendario de pago", MessageBoxIcon.Error)
            Exit Sub
        End If
        '

        obj.Id = Id
        obj.IdCliente = cbCliente.EditValue
        obj.Empresa = EmpresaActual
        obj.Factura = cbFactura.EditValue
        obj.Moneda = cbMoneda.EditValue
        obj.FechaSolicitud = Fecha.DateTime.Date
        obj.FechaCorte = Fecha.DateTime.Date
        obj.FechaInicio = FechaInicial.DateTime.Date
        obj.DiasGracia = 1
        obj.NoCuotas = sCuotas.EditValue
        obj.Interes = 0.00
        obj.Monto = tMonto.EditValue

        Dim Vencimiento As Date =
            iVistaAP.GetRowCellValue(iVistaAP.DataRowCount - 1, "FechaPago")

        If Id = 0 Then
            ShowSplash("Guardando...")
            Id = db.Insertar(obj)

            Dim _dtNew As DataTable =
                DT_DETALLE.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

            If Not _dtNew Is Nothing Then
                With _dtNew
                    objDetalle.Id = Id
                    objDetalle.Empresa = EmpresaActual

                    For i As Integer = 0 To .Rows.Count - 1
                        objDetalle.Numero = .Rows.Item(i)("Numero")
                        objDetalle.FechaPago = .Rows.Item(i)("FechaPago")
                        objDetalle.Vencimiento = .Rows.Item(i)("Vencimiento")
                        objDetalle.Interes = .Rows.Item(i)("Interes")
                        objDetalle.Cuota = .Rows.Item(i)("Cuota")

                        dbDetalle.Insertar(objDetalle)
                    Next
                End With
            End If
            '
            HideSplash()
            'Actulizar la fecha de vencimiento de la factura
            Guardar("sp_upd_FACTURAS_VENTASVencimiento",
                    cbFactura.EditValue,
                    FechaInicial.DateTime.Date,
                    EmpresaActual)

            XtraMsg($"Factura {cbFactura.Text} se ha modificado en {sCuotas.EditValue.ToString} Cuotas.")
            Imprimir()
            Ok = True

            Close()
        Else
            ShowSplash("Actualizando...")

            db.Actualizar(obj)
            '
            Dim _dtUpd As DataTable =
                DT_DETALLE.GetChanges(DataRowState.Modified)

            'Actualizar
            If Not _dtUpd Is Nothing Then
                With _dtUpd
                    objDetalle.Id = Id
                    objDetalle.Empresa = EmpresaActual

                    For i As Integer = 0 To .Rows.Count - 1
                        objDetalle.IdDetalle = .Rows.Item(i)("IdDetalle")
                        objDetalle.Numero = .Rows.Item(i)("Numero")
                        objDetalle.FechaPago = .Rows.Item(i)("FechaPago")
                        objDetalle.Vencimiento = .Rows.Item(i)("Vencimiento")
                        objDetalle.Interes = .Rows.Item(i)("Interes")
                        objDetalle.Cuota = .Rows.Item(i)("Cuota")

                        dbDetalle.Actualizar(objDetalle)
                    Next
                End With
            End If
            '
            'Agregar Nuevos Registros
            Dim _dtNew As DataTable =
                DT_DETALLE.GetChanges(DataRowState.Added)

            If Not _dtNew Is Nothing Then
                With _dtNew
                    objDetalle.Id = Id
                    objDetalle.Empresa = EmpresaActual

                    For i As Integer = 0 To .Rows.Count - 1
                        objDetalle.Numero = .Rows.Item(i)("Numero")
                        objDetalle.FechaPago = .Rows.Item(i)("FechaPago")
                        objDetalle.Vencimiento = .Rows.Item(i)("Vencimiento")
                        objDetalle.Interes = .Rows.Item(i)("Interes")
                        objDetalle.Cuota = .Rows.Item(i)("Cuota")

                        dbDetalle.Insertar(objDetalle)
                    Next
                End With
            End If
            '
            HideSplash()
            Guardar("sp_upd_FACTURAS_VENTASVencimiento", cbFactura.EditValue, Vencimiento, EmpresaActual)

            XtraMsg("Los Cambios Solicitados han sido actualizados con exito!")
            '
            Ok = True
            Close()
        End If
        '
    End Sub

    Private Sub bImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bImprimir.ItemClick
        Imprimir()
    End Sub

    Sub Imprimir()
        VistaPrevia(
          iGridAP,
          $"Factura {cbFactura.Text} en {sCuotas.EditValue.ToString} Cuotas",
          $"A partir de: {FechaInicial.DateTime.ToShortDateString}")
    End Sub

    Private Sub bSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSalir.ItemClick
        Ok = False
        Close()
        '
        'If FromFactur Then
        '    If XtraMsg2($"Esta Seguro que desea salir sin guardar los cambios para la factura {cbFactura.EditValue} ?") Then
        '        Close()
        '    End If
        'Else
        '    Close()
        'End If

    End Sub

    Private Sub bGenerarTabla_Click(sender As Object, e As EventArgs) Handles bGenerarTabla.Click
        Try
            Dim FechaPago As Date = FechaInicial.DateTime.Date,
                Ban As Boolean = False

            DT_DETALLE.Clear()
            '
            For i As Integer = 0 To CInt(sCuotas.EditValue) - 1
                Dim dr As DataRow = DT_DETALLE.NewRow

                dr("Numero") = i + 1
                dr("FechaPago") = FechaPago
                dr("Vencimiento") = FechaPago                   'FechaPago.AddDays(sDiasGracia.EditValue).Date
                dr("Cuota") = Math.Round(tMonto.EditValue / sCuotas.EditValue, 2)
                dr("Interes") = 0.00                            'Math.Round((tMonto.EditValue / sCuotas.EditValue) * sInteres.EditValue, 2)
                dr("Aplicada") = False
                dr("Status") = "CORRIENTE"

                DT_DETALLE.Rows.Add(dr)

                'Validar si es febrero 28
                If FechaPago.Month = 2 Then
                    If FechaPago.Day = 28 Or FechaPago.Day = 29 Then
                        FechaPago = UltimoDiaDelMes(FechaPago.AddMonths(1).Date)
                        Ban = True
                    End If
                Else
                    If Ban Then
                        FechaPago = UltimoDiaDelMes(FechaPago.AddMonths(1).Date)
                    Else
                        FechaPago = FechaPago.AddMonths(1).Date
                    End If

                End If
            Next
            '
            iGridAP.DataSource = DT_DETALLE
            iGridAP.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bSolicitar_Click(sender As Object, e As EventArgs) Handles bSolicitar.Click
        Dim DetalleCliente As VB.SysContab.ClientesDetails
        DetalleCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

        With New frmListaNegraValidar
            .Text = $"Cliente: {cbCliente.Text}"
            .IdCliente = cbCliente.EditValue
            .ClienteN = cbCliente.Text
            .Factura = String.Empty
            .IdSucursal = DetalleCliente.CodigoLetra.Substring(0, 2)
            'cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "CodigoLetra").ToString().Substring(0, 2)
            .TipoAprobacion = "Cuotas Factura"
            .ShowDialog()

            If .Ok Then
                sCuotas.Properties.MaxValue = 12
            End If
        End With

    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        SearchLookUp(
            cbFactura,
            ObtieneDatos("sp_sel_FACTURAS_VENTASPendientes",
                         IIf(cbCliente.EditValue Is Nothing, 0, cbCliente.EditValue),
                         EmpresaActual),
            "NoFactura",
            "NoFactura",
            5)
        '
        If Factura.Length > 0 Then
            cbFactura.EditValue = Factura
            cbFactura.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub cbFactura_EditValueChanged(sender As Object, e As EventArgs) Handles cbFactura.EditValueChanged

        If Not cbFactura.EditValue Is Nothing Then
            tMonto.EditValue = cbFactura.Properties.View.GetRowCellValue(cbFactura.Properties.View.FocusedRowHandle, "Saldo")
            Fecha.DateTime = cbFactura.Properties.View.GetRowCellValue(cbFactura.Properties.View.FocusedRowHandle, "Fecha")
            cbMoneda.EditValue = cbFactura.Properties.View.GetRowCellValue(cbFactura.Properties.View.FocusedRowHandle, "mon_codigo")
        Else
            tMonto.EditValue = 0.00
            Fecha.DateTime = Now.Date
            cbMoneda.EditValue = MonedaBase
        End If
        '
    End Sub

    Private Sub frmFacturasCuotasAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Private Sub frmFacturasCuotasAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FromFactur Then
            If Ok = False Then
                If Not XtraMsg2($"Esta Seguro que desea salir sin guardar los cambios para la factura {cbFactura.EditValue} ?") Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub iVistaAP_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVistaAP.RowCellStyle
        If e.Column.FieldName = "Status" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVistaAP.GetRowCellValue(e.RowHandle, "Status") = "CORRIENTE" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVistaAP.GetRowCellValue(e.RowHandle, "Status") = "VENCIDO" Then
                e.Appearance.ForeColor = Color.OrangeRed
            End If
        End If

        If e.Column.FieldName = "Aplicada" Then
            If iVistaAP.GetRowCellValue(e.RowHandle, "Aplicada") Then
                e.Appearance.BackColor = Color.LimeGreen
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub
End Class