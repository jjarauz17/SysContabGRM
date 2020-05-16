Imports ApiHacienda
Imports Common
Imports DevExpress.XtraGrid.Views.Base
Imports Entities
Public Class frmFacturaManualAdd

    Public Ok As String = "NO"
    Dim _error As New ControlErrores
    Dim fn As New oFn
    Private Temp As Boolean = False

    Dim obj As New FacturasEnviadasManual,
        db As New db_FacturasEnviadasManual

    Dim objDetalle As New FacturasEnviadasManualDetalle,
        dbDetalle As New db_FacturasEnviadasManualDetalle

    Dim objCliente As New Clients,
        dbCliente As New db_Clients

    Dim objUrlApis As New UrlAPIs,
        db_ApiPrueba As New db_UrlAPIPruebas,
        db_ApiProd As New db_UrlAPIProduccions

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckEdit1.Checked Then
            lyGrupoReceptor.Expanded = False
            RadioGroup1.Properties.Items(1).Enabled = False
            RadioGroup1.EditValue = "01"
        End If
        '
        If Not CheckEdit1.Checked Then
            lyGrupoReceptor.Expanded = True
            RadioGroup1.Properties.Items(1).Enabled = True
        End If
    End Sub

    Private Sub frmFacturaManualAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(
            Me,
            DxValidationProvider1)
        '
        dFecha.DateTime = Fecha().Date
        CargarCombos()
        '
        Cargar()
        FormatoGrid(iVista, 5, 0, False, True, False)
        txtFactura.Text = db.GetNumeroFactura("FacturaElectronica",
                                              _IdCliente)
    End Sub

    Sub CargarCombos()
        SearchLookUp(
            cbReceptores,
            fn.ObtieneDatos("sp_sel_Receptores",
                            _IdCliente),
            "Receptor",
            "Cedula")
        '
        LookUp(
            cbProvincia,
            fn.ObtieneDatos("sp_sel_Provincia", 0),
            "Nombre",
            "IdProvincia",
            "[Seleccione]", 0)
        cbProvincia.ItemIndex = 0
        '
        SearchLookUp(
            cbFormaPago,
            fn.ObtieneDatos("sp_sel_FormaPago", 0),
            "Nombre",
            "IdTender")
        cbFormaPago.EditValue = 1
        '
        RepositorySearchLook(
            cbItemD,
            fn.ObtieneDatos("sp_sel_ItemDetalleCombo",
                            _IdCliente),
            "Descripcion",
            "Id", 2, 3)
    End Sub

    Sub Cargar()
        iGrid.DataSource =
            dbDetalle.Listar(
            0,
            _IdCliente)
    End Sub

    Private Sub bEnviar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEnviar.ItemClick
        If Not DxValidationProvider1.Validate Then Exit Sub

        If Not CheckEdit1.Checked Then

            If txtReceptor.Text.Trim.Length = 0 Then
                XtraMsg("Falta el Receptor de la Factura",
                        MessageBoxIcon.Error)
                txtReceptor.Focus()
                Exit Sub
            End If

            If txtCedula.Text.Trim.Length < 9 Then
                XtraMsg("La Cédula del Receptor es inválida!",
                        MessageBoxIcon.Error)
                txtCedula.Focus()
                Exit Sub
            End If
            '
            If txtCorreo.Text.Trim.Length > 0 Then
                If Not fn.IsEmail(txtCorreo.Text) Then
                    XtraMsg("El correo digitado es inválido!",
                        MessageBoxIcon.Error)
                    txtCorreo.Focus()
                    Exit Sub
                End If
            End If
        End If
        '        
        If iVista.DataRowCount = 0 Then
            XtraMsg("La Factura no  contiene detalle de venta.",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim objUrlApis As New UrlAPIs
        objCliente = dbCliente.Detalles(_IdCliente)

        If objCliente.ATV = 1 Then objUrlApis = db_ApiPrueba.Detalles(1)
        If objCliente.ATV = 2 Then objUrlApis = db_ApiProd.Detalles(1)
        '
        If objUrlApis Is Nothing Then
            XtraMsg(db_ApiProd.iError,
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Guardar Registro
        obj.IdFactura = 0
        obj.Tipo = IIf(CheckEdit1.Checked, "TiqueteElectronico", "FacturaElectronica")
        obj.Factura = txtReferencia.Text.Trim
        obj.Fecha = dFecha.DateTime
        obj.IdCliente = _IdCliente
        obj.Receptor = IIf(CheckEdit1.Checked, "Cliente Anonimo", txtReceptor.Text.Trim).ToString()
        obj.Cedula = IIf(CheckEdit1.Checked, "0", txtCedula.Text.Trim).ToString()
        obj.Correo = IIf(CheckEdit1.Checked, "", txtCorreo.Text.Trim).ToString()
        obj.Telefono = IIf(CheckEdit1.Checked, "0", txtTelefono.Text.Trim).ToString()
        obj.Direccion = IIf(CheckEdit1.Checked, "0", mDireccion.Text.Trim).ToString()
        obj.Autorizacion = txtAutorizacion.Text.Trim
        obj.Cliente = txtCliente.Text.Trim
        obj.Odometro = txtOdometro.Text.Trim
        obj.Placa = txtPlaca.Text.Trim
        obj.OrdenCompra = txtOrdenCompra.Text.Trim
        obj.Comentario = txtComentario.Text.Trim
        obj.IdTender = cbFormaPago.EditValue
        obj.NoInterno = txtFactura.Text

        Dim IdFactura As Integer =
            db.Insertar(obj)

        If IdFactura = 0 Then Exit Sub

        objDetalle.IdFactura = IdFactura
        objDetalle.IdCliente = _IdCliente
        '
        For i As Integer = 0 To iVista.DataRowCount - 1

            Dim Id As String = iVista.GetRowCellValue(i, "Id").ToString()
            Dim DR As DataRowView = cbItemD.GetRowByKeyValue(Id)

            objDetalle.Id = Id
            objDetalle.Descripcion = DR.Item("Descripcion").ToString()
            objDetalle.seq_number = i + 1
            objDetalle.Cantidad = CDbl(iVista.GetRowCellValue(i, "Cantidad"))
            objDetalle.Precio = CDbl(iVista.GetRowCellValue(i, "Precio"))
            objDetalle.total_tax = CDbl(iVista.GetRowCellValue(i, "total_tax"))
            objDetalle.Neto = CDbl(iVista.GetRowCellValue(i, "Neto"))
            objDetalle.Descuento = 0.000
            objDetalle.Linea_Monto = CDbl(iVista.GetRowCellValue(i, "Linea_Monto"))
            objDetalle.Total_Exento = CDbl(iVista.GetRowCellValue(i, "Total_Exento"))
            objDetalle.Total_Grabado = CDbl(iVista.GetRowCellValue(i, "Total_Grabado"))

            dbDetalle.Insertar(objDetalle)
        Next

        ''Preparando la Entidad del Emisor
        Dim myEmisor As New Emisor With {.numeroIdentificacion = objCliente.Cedula, .TipoIdentificacion = objCliente.TipoIdentificacion}
        'Preparando la Entidad Receptor        
        Dim myReceptor As New Receptor
        Dim ReceptorTipo As String = IIf(txtCedula.Text.Trim.Length = 9, "01", IIf(txtCedula.Text.Trim.Length = 10, "02", "03")).ToString()

        If CheckEdit1.Checked Then
            myReceptor.sinReceptor = True
        Else
            myReceptor = New Receptor With {.numeroIdentificacion = txtCedula.Text.Trim, .TipoIdentificacion = ReceptorTipo}
        End If
        '
        Dim FE As New FacturaElectronicaEnviar

        FE.ProcesarManual(
            IdFactura,
            IIf(CheckEdit1.Checked, "04", "01"),
            RadioGroup1.EditValue.ToString(),
            CInt(cbFormaPago.EditValue),
            objCliente,
            objUrlApis,
            myEmisor,
            myReceptor,
            CInt(cbProvincia.EditValue),
            CInt(cbCanton.EditValue),
            CInt(cbDistrito.EditValue),
            CInt(cbBarrio.EditValue))

        If Not FE.iMensaje.Equals("_error") Then
            XtraMsg(FE.iMensaje, MessageBoxIcon.Information)
        Else
            XtraMsg(FE.iMensaje, MessageBoxIcon.Error)
        End If

        Ok = "SI"
        Close()
    End Sub

    Private Sub bSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSalir.ItemClick
        Ok = "NO"
        Close()
    End Sub

    Private Sub frmFacturaManualAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = "NO"
            Close()
        End If
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Id" Then

            Dim DR As DataRowView = cbItemD.GetRowByKeyValue(e.Value)

            If Not IsNothing(DR) Then
                Temp = True

                iVista.SetRowCellValue(e.RowHandle, "Cantidad", 0.000)
                iVista.SetRowCellValue(e.RowHandle, "Precio", 0.00000)
                iVista.SetRowCellValue(e.RowHandle, "Exento", DR.Item("Exento"))
                iVista.SetRowCellValue(e.RowHandle, "Porcentaje", DR.Item("Porcentaje"))

                Temp = False
            End If
        End If
        '
        If (e.Column.FieldName = "Cantidad" Or
            e.Column.FieldName = "Precio") And
            Not Temp Then
            '  If e.Value <> 0 Then
            Temp = True
            Dim SubTotal As Double =
                    Math.Round(CDbl(iVista.GetRowCellValue(e.RowHandle, "Cantidad")) *
                    CDbl(iVista.GetRowCellValue(e.RowHandle, "Precio")), 2)

            If CBool(iVista.GetRowCellValue(e.RowHandle, "Exento")) Then
                iVista.SetRowCellValue(e.RowHandle, "Neto", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "total_tax", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Total_Grabado", 0.00)

                iVista.SetRowCellValue(e.RowHandle, "Linea_Monto", SubTotal)
                iVista.SetRowCellValue(e.RowHandle, "Total_Exento", SubTotal)
            Else
                Dim PrecioNeto As Double =
                    CDbl(iVista.GetRowCellValue(e.RowHandle, "Precio")) / (1 + CDbl(iVista.GetRowCellValue(e.RowHandle, "Porcentaje")))
                Dim Iva As Double = Math.Round(CDbl(iVista.GetRowCellValue(e.RowHandle, "Precio")) - PrecioNeto, 5)

                iVista.SetRowCellValue(e.RowHandle, "Total_Exento", 0.00)

                iVista.SetRowCellValue(e.RowHandle, "Neto",
                                       Math.Round(CDbl(iVista.GetRowCellValue(e.RowHandle, "Cantidad")) * PrecioNeto, 5))
                iVista.SetRowCellValue(e.RowHandle, "total_tax", Iva)
                iVista.SetRowCellValue(e.RowHandle, "Linea_Monto", SubTotal)
                iVista.SetRowCellValue(e.RowHandle, "Total_Grabado",
                                       Math.Round(CDbl(iVista.GetRowCellValue(e.RowHandle, "Cantidad")) * Iva, 5))
            End If

            Temp = False
            ' End If
        End If
        '
        'If e.Column.FieldName = "Linea_Monto" And
        '    Not Temp Then

        '    ' Temp = True

        '    Dim Cantidad = Math.Round(CDbl(e.Value) / CDbl(iVista.GetRowCellValue(e.RowHandle, "Precio")), 5)
        '    iVista.SetRowCellValue(e.RowHandle, "Cantidad", Cantidad)

        '    ' Temp = False

        'End If
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            '
            iVista.UpdateTotalSummary()
            iVista.RefreshData()
        End If
    End Sub

    Private Sub cbReceptores_EditValueChanged(sender As Object, e As EventArgs) Handles cbReceptores.EditValueChanged
        If cbReceptores.EditValue Is Nothing Then Exit Sub
        '
        txtCedula.Text = cbReceptores.EditValue.ToString()
        txtReceptor.Text = cbReceptores.Text.ToString()
        txtCorreo.Text = cbReceptores.Properties.View.GetRowCellValue(cbReceptores.Properties.View.FocusedRowHandle, "Correo").ToString()
    End Sub

    Private Sub iGrid_Click(sender As Object, e As EventArgs) Handles iGrid.Click

    End Sub

    Private Sub cbProvincia_EditValueChanged(sender As Object, e As EventArgs) Handles cbProvincia.EditValueChanged
        LookUp(cbCanton, fn.ObtieneDatos("sp_sel_Canton", cbProvincia.EditValue), "Nombre", "IdCanton", "[Seleccione]", 0, 1)
        cbCanton.ItemIndex = 0
    End Sub

    Private Sub cbCanton_EditValueChanged(sender As Object, e As EventArgs) Handles cbCanton.EditValueChanged
        LookUp(cbDistrito, fn.ObtieneDatos("sp_sel_Distrito", cbProvincia.EditValue, cbCanton.EditValue), "Nombre", "IdDistrito", "[Seleccione]", 0, 1, 2)
        cbDistrito.ItemIndex = 0
    End Sub

    Private Sub cbDistrito_EditValueChanged(sender As Object, e As EventArgs) Handles cbDistrito.EditValueChanged
        LookUp(cbBarrio, fn.ObtieneDatos("sp_sel_Barrio", cbProvincia.EditValue, cbCanton.EditValue, cbDistrito.EditValue), "Nombre", "IdBarrio", "[Seleccione]", 0, 1, 2, 3)
        cbBarrio.ItemIndex = 0
    End Sub
End Class