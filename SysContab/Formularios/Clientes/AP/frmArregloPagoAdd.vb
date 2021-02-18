Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class frmArregloPagoAdd

    Dim obj As New ArregloPago,
        db As New db_ArregloPago

    Dim obj_Detalle As New ArregloPagoDetalle,
        db_Detalle As New db_ArregloPagoDetalle

    Dim objFacturas As New ArregloPagoFacturas,
        dbFacturas As New db_ArregloPagoFacturas

    Dim objIntereses As New Clientes_Intereses
    Dim DT_DETALLE As DataTable

    Private _IdArreglo As Integer
    Private _Estado As String,
        IdEstado As String = "S",
        Aprobado As Boolean = False

    Public Property IdArreglo() As Integer
        Get
            Return _IdArreglo
        End Get
        Set(ByVal value As Integer)
            _IdArreglo = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Private Sub frmArregloPagoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Fecha.DateTime = f.Date
        FechaInicial.DateTime = f.Date

        CargarCombos()

        If IdArreglo = 0 Then
            lyEstado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            tNumero.EditValue = db_ArregloPago.GetNumero()

            objIntereses = db_Clientes_Intereses.Detalles()
            sInteres.EditValue = objIntereses.Corriente
            '
            BuscarFacturas(-1)
        Else
            lyEstado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lblEstado.Text = Estado.ToUpper
            bPrint.Enabled = True
            '
            cbCliente.Properties.ReadOnly = True
            obj = db_ArregloPago.Detalles(IdArreglo)
            '
            cbCliente.EditValue = obj.IdCliente
            tNumero.Text = obj.Numero
            Fecha.DateTime = obj.FechaSolicitud
            FechaInicial.DateTime = obj.FechaInicio
            sDiasGracia.EditValue = obj.DiasGracia
            sCuotas.EditValue = obj.NoCuotas
            sInteres.EditValue = obj.Interes
            tMonto.EditValue = obj.Monto
            mComentario.Text = obj.Comentario
            IdEstado = obj.Estado
            Aprobado = obj.Aprobado

            Select Case IdEstado
                Case "S"
                    lblEstado.BackColor = Color.Tomato
                    lblEstado.Text = $"{Estado.ToUpper} - {IIf(Aprobado, "APROBADO", "SIN AUTORIZAR")}"
                Case "P"
                    lblEstado.BackColor = Color.MediumBlue
                Case "M"
                    lblEstado.BackColor = Color.OrangeRed
                Case "A"
                    lblEstado.BackColor = Color.Red
                Case "F"
                    lblEstado.BackColor = Color.Green
            End Select
            '
            BuscarFacturas(obj.IdCliente)
            CalcularSaldoAP()
        End If

        DT_DETALLE = db_ArregloPagoDetalle.Listar(IdArreglo)
        iGridAP.DataSource = DT_DETALLE
        Grid()
        GridAP()
        '
        If Aprobado Then
            bGenerarTabla.Enabled = False
            bBuscar.Enabled = False
            'iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = False                
            iVista.Columns("Seleccionar").Visible = False
        End If
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        If Inicio Then Exit Sub
        If cbCliente.EditValue Is Nothing Then Exit Sub
        '
        If IdArreglo = 0 Then BuscarFacturas(cbCliente.EditValue)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione un Cliente", MessageBoxIcon.Warning)
            cbCliente.Focus()
            Exit Sub
        End If
        '
        BuscarFacturas(cbCliente.EditValue)
    End Sub

    Sub BuscarFacturas(IdCliente As Integer)

        If Not Inicio Then ShowSplash()

        If IdEstado = "S" And Not Aprobado Then
            iGrid.DataSource =
                dbFacturas.Listar(
                    IdCliente,
                    VB.SysContab.Rutinas.Fecha().Date,
                    IdArreglo,
                    EmpresaActual)
        Else
            iGrid.DataSource =
               dbFacturas.Listar(
                   IdArreglo,
                   EmpresaActual)
        End If


        If Not Inicio Then HideSplash()
    End Sub

    Sub GridAP()

        With iVistaAP

            .PopulateColumns()
            FormatoGrid(iVistaAP, 2, 0, False)

            .Columns("IdDetalle").Visible = False
            .Columns("Interes").Visible = False
            .Columns("Aplicada").Visible = False

            If IdArreglo = 0 Then .Columns("Saldo").Visible = False

            For i As Integer = 0 To .Columns.Count - 1
                .Columns(i).OptionsColumn.AllowEdit = False
            Next
            '
            .Columns("FechaPago").OptionsColumn.AllowEdit = True
            .Columns("Vencimiento").OptionsColumn.AllowEdit = True

        End With

    End Sub

    Sub Grid()

        With iVista

            .PopulateColumns()
            FormatoGrid(iVista, 2, 0, False)
            .Columns("IdDetalle").Visible = False

            For i As Integer = 0 To .Columns.Count - 1
                .Columns(i).OptionsColumn.AllowEdit = False
            Next

            .Columns("Seleccionar").OptionsColumn.AllowEdit = True
            .Columns("Seleccionar").ColumnEdit = rCheck

        End With

    End Sub

    Sub CargarCombos()
        SearchLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual),
                "Nombre", "Codigo", 0, 3)
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        CalcularSaldoAP()
    End Sub

    Sub CalcularSaldoAP()
        Dim Saldo As Double = 0.0
        With iVista
            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Seleccionar") Then
                    Saldo += .GetRowCellValue(i, "Saldo U$")
                End If
            Next
        End With

        lblSaldo.Text = "Saldo U$: " & Saldo.ToString("n2")
        tMonto.EditValue = Saldo
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs)
        If IdArreglo = 0 Then tNumero.EditValue = db_ArregloPago.GetNumero()
    End Sub

    Private Sub bPrint_Click(sender As Object, e As EventArgs) Handles bPrint.Click
        Imprimir()
    End Sub

    Sub Imprimir()
        db_ArregloPago.Imprimir(
            iGridAP,
            $"Arreglo de Pago No. {tNumero.Text}",
            $"A Partir de: {FechaInicial.DateTime.ToShortDateString()}")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Seleccionar", CheckEdit1.Checked)
        Next
        '
        CalcularSaldoAP()
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
                dr("Vencimiento") = FechaPago.AddDays(sDiasGracia.EditValue).Date
                dr("Cuota") = Math.Round(tMonto.EditValue / sCuotas.EditValue, 2)
                dr("Interes") = 0.00    'Math.Round((tMonto.EditValue / sCuotas.EditValue) * sInteres.EditValue, 2)
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

            iGridAP.DataSource = DT_DETALLE
            iGridAP.Refresh()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sCuotas_EditValueChanged(sender As Object, e As EventArgs) Handles sCuotas.EditValueChanged

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        'If cbSucursal.EditValue Is Nothing Then
        '    XtraMsg("Seleccione la Sucursal!")
        '    Exit Sub
        'End If
        '
        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            Exit Sub
        End If

        If tMonto.EditValue = 0.00 Then
            XtraMsg("El Monto del Arrego de Pago debe ser Mayor que Cero.", MessageBoxIcon.Error)
            tMonto.Focus()
            tMonto.SelectAll()
            Exit Sub
        End If

        Dim selec As Boolean = False

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then selec = True
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar una factura al menos!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        obj.IdArreglo = IdArreglo
        obj.Numero = IIf(IdArreglo = 0, db_ArregloPago.GetNumero(), tNumero.EditValue)
        obj.IdCliente = cbCliente.EditValue
        obj.FechaSolicitud = Fecha.DateTime.Date
        obj.FechaInicio = FechaInicial.DateTime.Date
        obj.FechaCorte = VB.SysContab.Rutinas.Fecha().Date
        obj.DiasGracia = sDiasGracia.EditValue
        obj.NoCuotas = sCuotas.EditValue
        obj.Interes = sInteres.EditValue
        obj.Monto = tMonto.EditValue
        obj.Comentario = mComentario.Text

        If IdArreglo = 0 Then
            tNumero.Text = obj.Numero
            IdArreglo = db.Insertar(obj)
            '
            With iVista
                'Guardar Facturas en Arreglo
                For i As Integer = 0 To .DataRowCount - 1
                    If CBool(.GetRowCellValue(i, "Seleccionar")) Then
                        objFacturas.IdArreglo = IdArreglo
                        objFacturas.Empresa = EmpresaActual
                        objFacturas.Factura = .GetRowCellValue(i, "Factura")
                        objFacturas.Fecha = .GetRowCellValue(i, "Fecha")
                        objFacturas.Vencimiento = .GetRowCellValue(i, "Vencimiento")
                        objFacturas.Saldo = .GetRowCellValue(i, "Saldo U$")

                        dbFacturas.Insertar(objFacturas)
                        '
                        ''Actulizar la fecha de vencimiento de la factura
                        'Guardar("sp_upd_FACTURAS_VENTASVencimiento",
                        '        .GetRowCellValue(i, "Factura"),
                        '        FechaInicial.DateTime.AddDays(sDiasGracia.EditValue).Date,
                        '        EmpresaActual)
                    End If
                Next
            End With
            '
            With iVistaAP
                'Guardar Tabla de Arreglo de Pago
                For i As Integer = 0 To .DataRowCount - 1
                    obj_Detalle.IdArreglo = IdArreglo
                    obj_Detalle.Empresa = EmpresaActual
                    obj_Detalle.Numero = .GetRowCellValue(i, "Numero")
                    obj_Detalle.FechaPago = .GetRowCellValue(i, "FechaPago")
                    obj_Detalle.Vencimiento = .GetRowCellValue(i, "Vencimiento")
                    obj_Detalle.Cuota = .GetRowCellValue(i, "Cuota")
                    obj_Detalle.Interes = .GetRowCellValue(i, "Interes")

                    db_Detalle.Insertar(obj_Detalle)
                Next
            End With

            XtraMsg($"El Arreglo de Pago No. {obj.Numero} se ha creado con éxito!")
            Imprimir()
            Close()
            If frmArregloPago.Created Then frmArregloPago.Cargar()
        Else
            db.Actualizar(obj)

            If IdEstado.Equals("S") And Not Aprobado Then
                'Borrar Detalle de Facturas
                objFacturas.IdArreglo = IdArreglo
                objFacturas.Empresa = EmpresaActual
                dbFacturas.Borrar(objFacturas)
                'Borrar Detalle del Arerglo de Pago
                obj_Detalle.IdArreglo = IdArreglo
                obj_Detalle.Empresa = EmpresaActual
                db_Detalle.Borrar(obj_Detalle)
                '
                With iVista
                    'Guardar Facturas en Arreglo
                    For i As Integer = 0 To .DataRowCount - 1
                        If CBool(.GetRowCellValue(i, "Seleccionar")) Then
                            objFacturas.IdArreglo = IdArreglo
                            objFacturas.Empresa = EmpresaActual
                            objFacturas.Factura = .GetRowCellValue(i, "Factura")
                            objFacturas.Fecha = .GetRowCellValue(i, "Fecha")
                            objFacturas.Vencimiento = .GetRowCellValue(i, "Vencimiento")
                            objFacturas.Saldo = .GetRowCellValue(i, "Saldo U$")

                            dbFacturas.Insertar(objFacturas)
                        End If
                    Next
                End With
                '
                With iVistaAP
                    'Guardar Tabla de Arreglo de Pago
                    For i As Integer = 0 To .DataRowCount - 1
                        obj_Detalle.IdArreglo = IdArreglo
                        obj_Detalle.Empresa = EmpresaActual
                        obj_Detalle.Numero = .GetRowCellValue(i, "Numero")
                        obj_Detalle.FechaPago = .GetRowCellValue(i, "FechaPago")
                        obj_Detalle.Vencimiento = .GetRowCellValue(i, "Vencimiento")
                        obj_Detalle.Cuota = .GetRowCellValue(i, "Cuota")
                        obj_Detalle.Interes = .GetRowCellValue(i, "Interes")

                        db_Detalle.Insertar(obj_Detalle)
                    Next
                End With
            Else
                With iVistaAP
                    'Guardar Tabla de Arreglo de Pago
                    For i As Integer = 0 To .DataRowCount - 1
                        obj_Detalle.IdDetalle = .GetRowCellValue(i, "IdDetalle")
                        obj_Detalle.IdArreglo = IdArreglo
                        obj_Detalle.Empresa = EmpresaActual
                        obj_Detalle.Numero = .GetRowCellValue(i, "Numero")
                        obj_Detalle.FechaPago = .GetRowCellValue(i, "FechaPago")
                        obj_Detalle.Vencimiento = .GetRowCellValue(i, "Vencimiento")
                        obj_Detalle.Cuota = .GetRowCellValue(i, "Cuota")
                        obj_Detalle.Interes = .GetRowCellValue(i, "Interes")

                        db_Detalle.Insertar(obj_Detalle)
                    Next
                End With
            End If
            '
            XtraMsg($"El Arreglo de Pago No. {obj.Numero} se ha modificado con éxito!")
            Close()
            If frmArregloPago.Created Then frmArregloPago.Cargar()
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
            If CBool(iVistaAP.GetRowCellValue(e.RowHandle, "Aplicada")) Then
                e.Appearance.BackColor = Color.LimeGreen
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub
End Class