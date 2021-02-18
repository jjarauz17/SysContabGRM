Imports System.Data.SqlClient
'Imports ClasesBLL
Imports Entities
Imports ApiHacienda
Imports DevExpress.XtraGrid.Views.Base
Imports SysContab.VB.SysContab
Imports Newtonsoft.Json

Public Class frmFacturaElectronicaCompra

    Dim fp As New Forma_PagoDB
    Dim fc As New Facturas_ComprasDB
    Dim Articulos As New ArticulosDB
    Dim ArticulosCC As New GruposCCDB
    Dim DetalleEmpresa As New EmpresasDetails
    Dim ConfigDetalle As New ConfiguracionDetails
    Dim OrdenesCompra As New Ordenes_ComprasDB
    'Dim Plantilla As New PlantillaDB
    'Dim plan As String = Plantilla.GetTipoPlantilla(1, 9)
    'Dim PlantillaDetalle As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
    Dim Temp As Boolean = False
    Dim TCambio As Double = 1
    Dim DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim Comp_No As Integer = 0
    Dim Per_Id As Integer = 0

    Dim LoadOrden As Boolean = False
    Public IdOrden As Integer = 0,
            IdFactura As Integer = 0

    Public Ok As Boolean = False
    Dim _DT As New DataTable("FC")

    Dim obj As New FacturasElectronicasCompras
    Dim db As New db_FacturasElectronicasCompras

    Dim objDetalle As New FacturasElectronicasComprasDetalle
    Dim db_Detalle As New db_FacturasElectronicasComprasDetalle
    Dim rTImpuesto As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim cbOrdenCompra As New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                tmp = True
                Exit For
            End If
        Next

        Return tmp
    End Function

    Private Sub frmOrdenPagoNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowSplash()
        '
        AddValidation(Me, DxValidationProvider1)
        FormatoRibbonVB(Me.RibbonControl)
        '
        Dim f As Date = Rutinas.Fecha().Date
        Fecha.DateTime = f.Date
        FechaPago.DateTime = f.Date
        '
        DetalleEmpresa = EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalle = ConfiguracionDB.GetConfigDetails()
        '
        CargarCombos()
        Cargar()
        Grid()
        '
        TCambio = GetTasaCambioDia(Fecha.DateTime.Date)
        etTasa.Text = TCambio
        '
        txtFactura.Text = db.Consecutivo(EmpresaActual)
        Distribucion()

        'Dim _DT As DataTable =
        '    db_FacturasElectronicasAceptadas.Listar(
        '    IdFactura,
        '    Now.Date,
        '    Now.Date)

        'If _DT.Rows.Count > 0 Then
        '    txtFactura.Text = _DT.Rows.Item(0)("ConsecutivoProveedor")
        '    txtOrden.Text = _DT.Rows.Item(0)("ConsecutivoProveedor")
        'End If
        '        
        HideSplash()
    End Sub

    Sub Grid()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 6, 0, False, True, False)
        '
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).Visible = False
        Next

        iVista.Columns("TipoImpuesto").Visible = True
        iVista.Columns("IdOrdenCompra").Visible = True
        iVista.Columns("IdOrdenCompra").Caption = "Pedido"
        iVista.Columns("IdProyecto").Visible = True
        iVista.Columns("IdProyecto").Caption = "Proyecto"
        iVista.Columns("Comentarios").Visible = True
        iVista.Columns("SubTotal").Visible = True
        iVista.Columns("SubTotal").OptionsColumn.AllowEdit = False
        iVista.Columns("descuento").Visible = True
        iVista.Columns("descuento").Caption = "Descuento"
        iVista.Columns("PrecioU").Visible = True
        iVista.Columns("PrecioU").Caption = "Precio U$"
        iVista.Columns("Precio").Visible = True
        iVista.Columns("Cantidad").Visible = True
        iVista.Columns("Cuenta").Visible = True
        iVista.Columns("Codigo").Visible = True
        iVista.Columns("Codigo").Caption = "Descripción"
        iVista.Columns("Codigo").Width = 250
        '
        iVista.Columns("Codigo").ColumnEdit = cbItems
        iVista.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVista.Columns("IdProyecto").ColumnEdit = cbProyectos
        iVista.Columns("descuento").ColumnEdit = rDescuento
        iVista.Columns("Cantidad").ColumnEdit = rMonto
        iVista.Columns("Precio").ColumnEdit = rMonto
        iVista.Columns("PrecioU").ColumnEdit = rMonto
        iVista.Columns("SubTotal").ColumnEdit = rMonto
        iVista.Columns("TipoImpuesto").ColumnEdit = rTImpuesto
        iVista.Columns("IdOrdenCompra").ColumnEdit = cbOrdenCompra

        iVista.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVista.Columns("Precio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVista.Columns("PrecioU").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVista.Columns("PrecioU").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVista.Columns("descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
    End Sub

    Private Sub frmOrdenPagoNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Sub Cargar()
        _DT = OrdenesCompra.OrdenComprasDetalle(IdOrden, 99).Tables(0)
        iGrid.DataSource = _DT
    End Sub

    Sub CargarCombos()
        SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
        SearchLookUp(cbCatalogoIVA, ObtieneDatos("sp_GetCatalogoCuentaIVA", EmpresaActual), "Nombre", "Codigo", 3, 4)
        LookUp(cbTipoCedula, ObtieneDatos("sp_sel_CR_TipoCliente", 0), "Nombre", "Codigo", "[Seleccione Tipo]", 0)
        LookUp(cbCondiciones, ObtieneDatos("sp_sel_CR_CondicionVenta", 0), "Nombre", "Codigo", "[Condicion de Venta]", 0)
        LookUp(cbMedioPago, ObtieneDatos("sp_sel_CR_FormaPago", 0), "Nombre", "Codigo", "[Medio de Pago]", 0)
        GetFormaPagoList(cbFormaPago)
        cbFormaPago.ItemIndex = 0
        cbTipoCedula.ItemIndex = 1
        cbCondiciones.ItemIndex = 0
        cbMedioPago.ItemIndex = 0
        '
        RepositoryItemLookUpEdit(
            rTImpuesto,
            ObtieneDatos("sp_sel_GetTipoImpuesto", EmpresaActual),
            "Nombre",
            "Codigo",
            0)

        RepositorySearchLook(
            cbCatalogo,
            ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual),
            "Display",
            "Cuenta",
            2)

        RepositorySearchLook(
            cbProyectos,
            db_Proyectos.Fill(),
            "Nombre",
            "IdProyecto",
            0, 4, 5, 6, 7, 8)

        RepositorySearchLook(cbOrdenCompra,
                             VB.SysContab.Ordenes_ComprasDB.FillComboLiquidacion(),
                             "Orden Compra",
                             "IdOrden",
                             0)

        GetMonedasList(cbMoneda)
        GetBodegasList(cbBodega)
        cbBodega.EditValue = ConfigDetalle.Bodega
        '
        LoadItems()
    End Sub

    Private Sub bBuscarOC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        With frmBuscarOrdenCompra
            .ShowDialog()
            ShowSplash("Cargando O/C...")
            If .Ok Then

                LoadOrden = True
                IdOrden = .iVista.GetRowCellValue(.iVista.FocusedRowHandle, "Consecutivo")
                Cargar()

                If _DT.Rows.Count > 0 Then

                    txtOC.Text = _DT.Rows.Item(0)("NoOrden")
                    cbProveedor.EditValue = _DT.Rows.Item(0)("Proveedor_ID")
                    Fecha.DateTime = _DT.Rows.Item(0)("Factura_Fecha")
                    FechaPago.DateTime = _DT.Rows.Item(0)("Factura_FechaPago")
                    cbFormaPago.EditValue = _DT.Rows.Item(0)("FormaPago_ID")
                    cbMoneda.EditValue = _DT.Rows.Item(0)("Moneda")
                    txtComentario.Text = _DT.Rows.Item(0)("Comentario")
                    gbTipo.EditValue = _DT.Rows.Item(0)("TipoOC")
                    ' chkLiquidar.Checked = CBool(_DT.Rows.Item(0)("Liquidacion"))
                    '
                    LoadItems()
                    CalcularTotales()
                End If
            End If
            .Dispose()
            HideSplash()
            '
            If iVista.DataRowCount = 0 Then LoadOrden = False
        End With
        '        
    End Sub

    Function FacturaElectronicaCompra() As Boolean

        Dim _Firma As New Firma
        Dim iToken As New TokenHacienda
        Dim EnviaFactura As New Comunicacion
        Dim XmlFirma As String = String.Empty,
            XmlRespuesta As String = String.Empty

        txtFactura.Text =
            db.Consecutivo(EmpresaActual)

        obj.Empresa = EmpresaActual
        obj.Numero = CInt(Mid(txtFactura.Text, 11, 10))
        obj.IdProveedor = cbProveedor.EditValue
        obj.Factura = txtFactura.Text
        obj.Referencia = txtOrden.Text
        obj.Clave = String.Empty
        obj.Fecha = Fecha.DateTime.Date
        obj.FechaEmision = String.Empty
        obj.TotalImpuesto = txtIva.EditValue
        obj.TotalFactura = txtSubTotal.EditValue
        obj.Receptor = cbProveedor.Text
        obj.CedulaReceptor = txtCedula.Text
        obj.Consecutivo = txtFactura.Text

        Dim IdFactura As Integer =
            db.Insertar(obj)

        If IdFactura = 0 Then Return False

        Dim IVA As Double = 0
        Dim DetalleProveedor As ProveedoresDetails =
            ProveedoresDB.GetDetails(cbProveedor.EditValue)

        With iVista
            objDetalle.IdFactura = IdFactura
            objDetalle.Empresa = EmpresaActual

            For i As Integer = 0 To .DataRowCount - 1

                If IsNull(.GetRowCellValue(i, "Codigo"), "").ToString.Trim.Length > 0 Then

                    Dim Exento As Boolean = .GetRowCellValue(i, "Exento")

                    If Not DetalleProveedor.Retenedor Then
                        IVA = 0
                    Else
                        If Exento Then
                            IVA = 0
                        Else
                            IVA = Math.Round(CDbl(.GetRowCellValue(i, "SubTotal") * (ConfigDetalle.IVA / 100)), 2)
                        End If
                    End If

                    objDetalle.Codigo = .GetRowCellValue(i, "Codigo")
                    objDetalle.Cantidad = .GetRowCellValue(i, "Cantidad")
                    objDetalle.Costo = .GetRowCellValue(i, "Precio")
                    objDetalle.Descuento = .GetRowCellValue(i, "descuento")
                    objDetalle.Impuesto = IVA
                    objDetalle.Tipo = .GetRowCellValue(i, "Tipo")

                    db_Detalle.Insertar(objDetalle)
                End If
            Next
        End With
        '
        'Preparando la Entidad del Emisor
        Dim myEmisor As New Emisor With
            {.numeroIdentificacion = txtCedula.Text, .TipoIdentificacion = cbTipoCedula.EditValue}

        'Preparando la Entidad Receptor        
        Dim myReceptor As New Receptor With
            {.numeroIdentificacion = DetalleEmpresa.Ruc, .TipoIdentificacion = "02"}

        Dim _DT_FEC As DataTable =
            db.Listar(IdFactura, Now.Date, Now.Date, EmpresaActual)

        If _DT_FEC.Rows.Count = 0 Then
            XtraMsg("No se ha encontrado el detalle del Compra Electronica",
                    MessageBoxIcon.Error)
            Return False
        End If
        '
        Dim Clave As String = _DT_FEC.Rows.Item(0)("Clave").ToString()
        Dim Consecutivo As String = _DT_FEC.Rows.Item(0)("Consecutivo").ToString()
        Dim FechaEmision As String = _DT_FEC.Rows.Item(0)("FechaEmision").ToString()

        Dim ReceptorNombre As String = cbProveedor.Text
        Dim ReceptorCedula As String = txtCedula.Text
        '
        Dim Etiqueta As String = "FacturaElectronicaCompra"

        db.GetJsonEnviar(
            IdFactura,
            cbTipoCedula.EditValue,
            cbCondiciones.EditValue,
            cbMedioPago.EditValue,
            EmpresaActual)

        If Not db._error.Equals("Ok") Then
            Return False
        End If

        Dim _DT_ACCESOS As DataTable =
            ObtieneDatos("sp_ATV_accesos", EmpresaActual)

        Dim xDoc As XDocument =
            JsonConvert.DeserializeXNode(db.JsonEnviar, Etiqueta, True)
        Dim XmlEnviar As String =
            xDoc.ToString.Replace("<" + Etiqueta + ">", db.EncabezadoFE)
        XmlEnviar = XmlEnviar.Replace("</MedioPago>", "</MedioPago><DetalleServicio>")
        XmlEnviar = XmlEnviar.Replace("<ResumenFactura>", "</DetalleServicio><ResumenFactura>")
        XmlEnviar = XmlEnviar.Replace(_DT_ACCESOS.Rows.Item(0)("LineaDetalleBorrar1"), "<LineaDetalle>")
        XmlEnviar = XmlEnviar.Replace(_DT_ACCESOS.Rows.Item(0)("LineaDetalleBorrar2"), "<LineaDetalle>")

        Dim directorio As String = _DT_ACCESOS.Rows.Item(0)("Directorio")
        Dim nombreArchivo As String = Consecutivo

        Dim xmlDocSF As New Xml.XmlDocument
        xmlDocSF.LoadXml(XmlEnviar)
        '        
        'Guardar XML sin Firmato
        xmlDocSF.Save($"{directorio}FECompra\{nombreArchivo}_XML_SinFirma.xml")

        Try
            ShowSplash("Firma XML...")

            _Firma.FirmaXML_Xades($"{directorio}FECompra\{nombreArchivo}",
                              _DT_ACCESOS.Rows.Item(0)("RutaCertificado"),
                              False,
                              _DT_ACCESOS.Rows.Item(0)("PIN"),
                              _DT_ACCESOS.Rows.Item(0)("FirmaUrl"))

            If Not _Firma.iError.Equals("Ok") Then
                HideSplash()
                XtraMsg(_Firma.iError, MessageBoxIcon.Error)
                Return False
            End If
            '
            Dim xmlElectronica As New Xml.XmlDocument
            xmlElectronica.Load($"{directorio}FECompra\{nombreArchivo}_XML_Firmado.xml")

            Dim XMLFirmado As String = xmlElectronica.OuterXml
            XmlFirma = XMLFirmado
            '
            Dim fn As New ApiHacienda.Funciones
            'Preparando la Entidad Recepcion
            Dim myRecepcion As New Recepcion
            myRecepcion.emisor = myEmisor
            myRecepcion.receptor = myReceptor
            '
            myRecepcion.clave = Clave
            myRecepcion.fecha = FechaEmision
            myRecepcion.comprobanteXml =
                fn.EncodeStrToBase64(xmlElectronica.OuterXml)
            '
            HideSplash()
            '
            ShowSplash("Solicitando Token...")
            'Genear Token, para enviar XML a Hacienda
            iToken.GetTokenHacienda(_DT_ACCESOS.Rows.Item(0)("Usuario"),
                                    _DT_ACCESOS.Rows.Item(0)("Password"),
                                    _DT_ACCESOS.Rows.Item(0)("Cliente_ID"),
                                    _DT_ACCESOS.Rows.Item(0)("TokenUrl"))
            HideSplash()
            '
            If Not iToken.iError.Equals("Ok") Then
                XtraMsg(iToken.iError, MessageBoxIcon.Error)
                Return False
            End If
            '
            ShowSplash("Enviando...")
            'Enviar Json a Hacienda
            EnviaFactura.EnvioDatos(iToken.accessToken,
                                 myRecepcion,
                                 _DT_ACCESOS.Rows.Item(0)("ApiUrl"))

            If IsNothing(enviaFactura.xmlRespuesta) Then
                XmlRespuesta = String.Empty
            Else
                XmlRespuesta = enviaFactura.xmlRespuesta.OuterXml
                enviaFactura.xmlRespuesta.Save(directorio & "\" & nombreArchivo & "_05_RESP.xml")
            End If
            '
            'Actualizar estado de la transaccion y XML de Respuesta
            obj.IdFactura = IdFactura
            obj.Empresa = EmpresaActual
            obj.StatusCode = IIf(EnviaFactura.statusCode Is Nothing, "", EnviaFactura.statusCode)
            obj.Estado = IIf(EnviaFactura.estadoFactura Is Nothing, "sin-respuesta", EnviaFactura.estadoFactura)
            obj.Respuesta = IIf(EnviaFactura.mensajeRespuesta Is Nothing, "", EnviaFactura.mensajeRespuesta)
            obj.XmlFirmado = XmlFirma
            obj.XmlRespuesta = XmlRespuesta
            db.Actualizar(obj)
            '
            If Not EnviaFactura.iError.Equals("Ok") Then
                HideSplash()
                XtraMsg(EnviaFactura.iError & ". Favor revise su conexion a Internet y vuelva a intentar.", MessageBoxIcon.Error)
                Return False
            End If
            '
            If EnviaFactura.estadoFactura Is Nothing Then
                HideSplash()
                XtraMsg("La Solicitud no obtuvo respuesta de Hacienda, Favor intentar nuevamente y revise su conexión a Internet." & vbCrLf &
                    EnviaFactura.mensajeRespuesta, MessageBoxIcon.Error)
                Return False
            End If

            HideSplash()
            XtraMsg(EnviaFactura.mensajeRespuesta)

            If EnviaFactura.estadoFactura.Equals("rechazado") Then Return False

            Return True
        Catch ex As Exception
            HideSplash()
            XtraMsg("Error al procesar XML: " & vbCrLf &
                    ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub bGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bGuardar.ItemClick

        If Not DxValidationProvider1.Validate Then Exit Sub

        If iVista.DataRowCount = 0 Then
            XtraMsg("Favor introduzca el detalle del a O/P",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '
        If txtIva.EditValue > 0 Then
            If cbCatalogoIVA.EditValue Is Nothing Then
                XtraMsg("Ingresa la Cuenta del IVA", MessageBoxIcon.Warning)
                cbCatalogoIVA.Focus()
                Exit Sub
            End If
        End If

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To iVista.DataRowCount - 1

            Dim DT_RG As DataTable =
                ObtieneDatos("sp_sel_RubroGastos",
                                  iVista.GetRowCellValue(i, "Cuenta"),
                                  EmpresaActual)

            If DT_RG.Rows.Count > 0 Then
                If Not VerificaDistribucion(DT_RG.Rows.Item(0)("CuentaContable")) Then
                    XtraMsg("La Cuenta " & iVista.GetRowCellValue(i, "Cuenta").ToString &
                            " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.",
                            MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************

        Dim Plantilla As New PlantillaDB
        Dim plan As String =
            Plantilla.GetTipoPlantilla(1, 9)

        'Validar si existe la Plantilla Contable
        If plan = "" Or plan Is DBNull.Value Then
            XtraMsg("No hay Plantilla Disponible para realizar Esta Transacción",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim PlantillaDetalle As PlantillaDetails =
            Plantilla.GetPlantillasDetails(plan)

        Dim TipoCompr As Integer = PlantillaDetalle.TipoCompr
        Dim TCambio As Double = GetTasaCambioDia(Fecha.DateTime)
        Dim Dias As Integer = fp.FormaPagoDias(cbFormaPago.EditValue)
        Dim Per_Id As Integer = PeriodosDB.Activo(Fecha.DateTime.Date)
        Dim DetalleProveedor As ProveedoresDetails = ProveedoresDB.GetDetails(cbProveedor.EditValue)
        Dim Estado As String = "F"
        Dim CuentaMntoD As String = String.Empty,
            CuentaMntoC = String.Empty

        Dim Cuentas(iVista.DataRowCount) As String
        Dim Montos(iVista.DataRowCount) As Double
        '
        If _DT.Select("Tipo='P'").Length > 0 And
                _DT.Select("Tipo='S'").Length > 0 Then
            Estado = "P"
        End If
        '
        If gbTipo.EditValue = 0 Then
            Estado = "P"
        ElseIf gbTipo.EditValue = 1 Then
            Estado = "F"
        ElseIf gbTipo.EditValue = 4 Then
            Estado = "P"
        End If
        '
        Try
            'Buscar las Cuentas de Matto Valor
            Dim DetalleMnto As PlantillaDetails =
               PlantillaDB.GetPlantillasDetails(7, 1)

            CuentaMntoD = DetalleMnto.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            CuentaMntoC = DetalleMnto.Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        Catch ex As Exception
            XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor",
                    MessageBoxIcon.Error)
            Exit Sub
        End Try

        If Not FacturaElectronicaCompra() Then
            Exit Sub
        End If

        '/********* INICAR TRANSACCION PARA GUARDAR FACTURA DE COMPRA *********
        '**********************************************************************/
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            ShowSplash("Guardando O/P...")
            'Guardar Encabezado de Factura de Compra
            fc.AddItem(
                txtFactura.Text,
                Fecha.DateTime.Date,
                FechaPago.DateTime.Date,
                cbProveedor.EditValue,
                txtTotal.EditValue,
                cbFormaPago.EditValue,
                gbTipo.EditValue,
                1,
                0,
                txtOC.Text,
                1,
                0,
                txtComentario.Text,
                Estado, 0, 0, 0, 1, 0, 0, 0,
                TCambio, 0,
                cbMoneda.EditValue,
                txtOrden.Text, 0,
                cbBodega.EditValue,
                txtSubTotal.EditValue,
                0)

            'Guardar Fechas de Recepcion de Factura
            ComprobanteDB.AddFacturaFecha(
                cbProveedor.EditValue,
                txtFactura.Text.Trim,
                Fecha.DateTime.Date)

            Dim IVA As Double = 0

            'Guardando detalle de la OP
            For i As Integer = 0 To iVista.DataRowCount - 1
                With iVista
                    Dim Exento As Boolean = .GetRowCellValue(i, "Exento")

                    If Not DetalleProveedor.Retenedor Then
                        IVA = 0
                    Else
                        If Exento Then
                            IVA = 0
                        Else
                            IVA = Math.Round(CDbl(.GetRowCellValue(i, "SubTotal") * (ConfigDetalle.IVA / 100)), 2)
                        End If
                    End If
                    '
                    fc.AddFacturaLineas(
                        txtFactura.Text,
                        .GetRowCellValue(i, "Codigo"),
                        .GetRowCellValue(i, "Cantidad"),
                        .GetRowCellValue(i, "Precio"),
                        .GetRowCellValue(i, "descuento"),
                        IVA,
                        .GetRowCellValue(i, "Tipo"),
                        IIf(Estado = "F", .GetRowCellValue(i, "Cantidad"), 0),
                        IVA,
                        ConfigDetalle.IVA,
                        cbProveedor.EditValue,
                        IsNull(.GetRowCellValue(i, "Comentarios"), ""),
                        .GetRowCellValue(i, "Cuenta"), "", 0, 0,
                        IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                        IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0),
                        IsNull(.GetRowCellValue(i, "TipoImpuesto"), 0))
                End With
            Next
            '
            '/********* INICAR GUARDAR COMPROBANTE *********
            '***********************************************/
            'Guardar Encabezado del Comprobante
            Dim Comp_No As Integer = ComprobanteDB.AddComprobante(
                TipoCompr,
                TCambio,
                txtComentario.Text,
                cbMoneda.EditValue,
                Per_Id,
                Fecha.DateTime.Date,
                0,
                "",
                False,
                cbProveedor.EditValue,
                "",
                1,
                txtFactura.Text,
                FechaPago.DateTime.Date,
                cbFormaPago.EditValue,
                OrigenComprobantes.ORDEN_DE_PAGO)

            Dim x As Integer = 0,
                Debito As Double = 0,
                Credito As Double = 0

            'Guardar Detalle del Comprobante
            For i As Integer = 0 To iVista.DataRowCount - 1
                With iVista
                    'Validar Cuenta
                    If IsNull(.GetRowCellValue(i, "Cuenta"), "").ToString().Length <= 3 Then
                        XtraMsg($"Hace falta la cuenta contable para el Item: {IsNull(.GetRowCellValue(i, "Codigo"), "")}",
                                MessageBoxIcon.Error)
                        Rutinas.ErrorTransaccion()
                        HideSplash()
                        Exit Sub
                    End If

                    Dim SubTotal As Double = .GetRowCellValue(i, "SubTotal")

                    'Si son Servicios se graban por Linea
                    If .GetRowCellValue(i, "Tipo").ToString().Equals("S") Then
                        ComprobanteDB.AddComprobanteDetalles(
                            Comp_No,
                            .GetRowCellValue(i, "Cuenta"),
                            IsNull(.GetRowCellValue(i, "Comentarios"), ""),
                            Math.Round(Math.Abs(SubTotal), 2),
                            0,
                            TipoCompr,
                            IIf(SubTotal < 0, "C", "D"),
                            txtFactura.Text,
                            0,
                            Fecha.DateTime.Date,
                            1, 0, "",
                            IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                            IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0))

                        If SubTotal < 0 Then Credito += Math.Round(Math.Abs(SubTotal), 2)
                        If SubTotal > 0 Then Debito += Math.Round(SubTotal, 2)

                    Else    'si no son servicios, se agrupan por cuenta.
                        Dim j As Integer = Cuentas.IndexOf(Cuentas, .GetRowCellValue(i, "Cuenta"))

                        'Sino encuentra coindidencia
                        If j = -1 Then
                            Cuentas(x) = .GetRowCellValue(i, "Cuenta")
                            Montos(x) = SubTotal
                            x += 1
                        Else
                            Montos(j) += SubTotal
                        End If

                    End If

                End With
            Next
            '
            'Guardar Detalle de productos / Inventario
            For i As Integer = 0 To Cuentas.GetUpperBound(0)
                If Not Cuentas(i) Is Nothing Then
                    If Cuentas(i).Length > 1 Then
                        ComprobanteDB.AddComprobanteDetalles(
                                Comp_No,
                                Cuentas(i),
                                "",
                                Math.Round(CDbl(Montos(i)), 2),
                                0,
                                TipoCompr,
                                "D",
                                txtFactura.Text,
                                0,
                                Fecha.DateTime.Date,
                                1, 0)

                        Debito += Math.Round(CDbl(Montos(i)), 2)
                    End If
                End If
            Next
            '
            'Guardar Impuesto
            If txtIva.EditValue > 0 Then
                ComprobanteDB.AddComprobanteDetalles(
                Comp_No,
                cbCatalogoIVA.EditValue,
                "I.V.A",
                txtIva.EditValue,
                0,
                TipoCompr,
                "D",
                txtFactura.Text,
                0,
                Fecha.DateTime.Date,
                1)
                Debito += txtIva.EditValue
            End If
            '
            'Guardar Pasivo al Proveedor
            ComprobanteDB.AddComprobanteDetalles(
                Comp_No,
                DetalleProveedor.Cuenta,
                cbProveedor.Text,
                txtTotal.EditValue,
                0,
                TipoCompr,
                "C",
                txtFactura.Text,
                0,
                Fecha.DateTime.Date,
                0)

            Credito += txtTotal.EditValue

            Dim Ajuste As Double = Math.Round(Credito - Debito, 2)
            '
            'Si al diferencia es Positiva, se crea ajuste al Debito 
            'y si es negativo se crea ajuste al Credito.
            If Ajuste <> 0 Then
                ComprobanteDB.AddComprobanteDetalles(
                    Comp_No,
                    IIf(Ajuste < 0, CuentaMntoC, CuentaMntoD),
                    "Ajuste redondeo, " & txtFactura.Text,
                    Math.Abs(Ajuste),
                    0,
                    TipoCompr,
                    IIf(Ajuste < 0, "C", "D"),
                    txtFactura.Text,
                    0,
                    Fecha.DateTime.Date,
                    1)
            End If
            '         
            ''Actualizar el Estado de la Orden
            'If IdOrden > 0 Then
            '    fc.OrdenesComprasUpdateEstado(
            '        IdOrden,
            '        "F",
            '        txtFactura.Text)
            'End If

            Rutinas.okTransaccion()

            '----------------------
            'Guarda la Distribucion
            '----------------------
            GuardaDistribucion(
                DT_Distribucion,
                Fecha.DateTime.Date,
                Comp_No)
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            ''Actualizar el registro de la Factura Electronica del Proveedor.
            'Dim obj As New ClasesBLL.FacturasElectronicasAceptadas
            'Dim db As New ClasesBLL.db_FacturasElectronicasAceptadas
            'obj.IdFactura = IdFactura
            'obj.IdProveedor = cbProveedor.EditValue
            'obj.Factura = txtFactura.Text
            'db.ActualizarProveedor(obj)

            HideSplash()

            Ok = True
            Close()
        Catch ex As Exception
            Rutinas.ErrorTransaccion()
            HideSplash()

            XtraMsg("_Error al Guardar la O/P: " & vbCrLf & ex.Message,
                    MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSalir.ItemClick
        Ok = False
        Close()
    End Sub
    Sub LoadItems()
        Dim Tipo As String = "P"

        If gbTipo.EditValue = 4 Then
            Tipo = "I"
        ElseIf gbTipo.EditValue = 0 Then
            Tipo = "P"
        ElseIf gbTipo.EditValue = 1 Then
            Tipo = "S"
        ElseIf gbTipo.EditValue = 3 Then
            Tipo = "A"
        End If

        If Tipo = "I" Then
            RepositorySearchLook(
                cbItems,
                ArticulosCC.ArticulosCCInvent().Tables("GruposCC"),
                "Display",
                "Codigo",
                3, 4, 5, 6, 7, 8, 9)
        Else
            RepositorySearchLook(
                cbItems,
                Articulos.ProductosGetLista(Tipo).Tables("Articulos"),
                "Display",
                "Codigo",
                3, 4, 5, 6, 7, 8, 9, 10)
        End If
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        If Not cbFormaPago.EditValue Is Nothing Then
            Dim Dias As Integer = fp.FormaPagoDias(cbFormaPago.EditValue)
            FechaPago.DateTime = Fecha.DateTime.AddDays(Dias)
        End If
        '
        TCambio = GetTasaCambioDia(Fecha.DateTime.Date)
        etTasa.EditValue = TCambio
    End Sub

    Private Sub cbFormaPago_EditValueChanged(sender As Object, e As EventArgs) Handles cbFormaPago.EditValueChanged
        If Not cbFormaPago.EditValue Is Nothing Then
            Dim Dias As Integer = fp.FormaPagoDias(cbFormaPago.EditValue)
            FechaPago.DateTime = Fecha.DateTime.AddDays(Dias)
        End If
    End Sub

    Private Sub etTasa_EditValueChanged(sender As Object, e As EventArgs) Handles etTasa.EditValueChanged
        TCambio = etTasa.EditValue
        UpdateTotales()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Codigo" Then   'Productos ó Inventario
            Dim DR As DataRowView = Me.cbItems.GetRowByKeyValue(e.Value)

            Temp = True
            If DR("Tipo") = "S" Then
                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(0.0).ToString(RoundP))
                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(0.0).ToString(RoundP))
                '
                iVista.SetRowCellValue(e.RowHandle, "IdProyecto", 0)
                iVista.SetRowCellValue(e.RowHandle, "ir", 0)
            Else
                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(Math.Round(DR("Precio") / TCambio, ConfigDetalle.Decimales)).ToString(RoundP))
                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(Math.Round(DR("Precio"), ConfigDetalle.Decimales)).ToString(RoundP))
                iVista.SetRowCellValue(e.RowHandle, "IdProyecto", DR("IdProyecto"))
                '
                iVista.SetRowCellValue(e.RowHandle, "ir", 0)
            End If
            '
            Temp = False
            iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
            iVista.SetRowCellValue(e.RowHandle, "descuento", 0.0)
            iVista.SetRowCellValue(e.RowHandle, "SubTotal", Math.Round(DR("Precio"), ConfigDetalle.Decimales))

            iVista.SetRowCellValue(e.RowHandle, "Cuenta", DR("Cuenta"))
            iVista.SetRowCellValue(e.RowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, DR("Exento")))

            iVista.SetRowCellValue(e.RowHandle, "Temp", e.RowHandle + 1)
            iVista.SetRowCellValue(e.RowHandle, "Tipo", DR("Tipo"))
        End If
        '        
        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                iVista.SetRowCellValue(e.RowHandle, "PrecioU", Math.Round(CDbl(e.Value / TCambio), 4))
                Temp = False
            End If
        End If
        '
        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                iVista.SetRowCellValue(e.RowHandle, "Precio", Math.Round(CDbl(e.Value * TCambio), 4))
                Temp = False
            End If
        End If
        '
        If e.Column.FieldName = "descuento" Or
            e.Column.FieldName = "Cantidad" Or
            e.Column.FieldName = "Precio" Or
            e.Column.FieldName = "PrecioU" Then
            If e.Value <> 0 Then
                Temp = True
                iVista.SetRowCellValue(
                    e.RowHandle,
                    "SubTotal",
                    Math.Round(CDbl((IsNull(iVista.GetFocusedRowCellValue("Cantidad"), 0.00) * IsNull(iVista.GetFocusedRowCellValue("Precio"), 0.00)) -
                    (IsNull(iVista.GetFocusedRowCellValue("Cantidad"), 0.00) * IsNull(iVista.GetFocusedRowCellValue("Precio"), 0.00)) * (IsNull(iVista.GetFocusedRowCellValue("descuento"), 0.00) / 100.0)), 2))
                Temp = False
            End If
        End If
        '
        iVista.RefreshData()
    End Sub

    Private Sub gbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gbTipo.SelectedIndexChanged
        LoadItems()
        Cargar()
    End Sub

    Sub UpdateTotales()
        If iVista.DataRowCount = 0 Then Exit Sub

        With iVista
            For i As Integer = 0 To .DataRowCount - 1
                If cbMoneda.EditValue = DetalleEmpresa.MonedaBase Then
                    .SetRowCellValue(i, "PrecioU", Math.Round(CDbl(.GetRowCellValue(i, "Precio") / etTasa.EditValue), 4))
                Else
                    .SetRowCellValue(i, "Precio", Math.Round(CDbl(.GetRowCellValue(i, "PrecioU") * etTasa.EditValue), 4))
                End If
                .SetRowCellValue(i, "SubTotal", Math.Round(CDbl(.GetRowCellValue(i, "Precio") * .GetRowCellValue(i, "Cantidad")), 2))
            Next
            '
            .RefreshData()
        End With
        '
        CalcularTotales()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '        
        Dim SubTotal As Double = 0.00

        With FrmDetalleRequisas
            If cbMoneda.EditValue <> DetalleEmpresa.MonedaBase Then
                SubTotal = Math.Round(CDbl(iVista.GetRowCellValue(iVista.FocusedRowHandle, "SubTotal") / TCambio), 2)
            Else
                SubTotal = Math.Round(CDbl(iVista.GetRowCellValue(iVista.FocusedRowHandle, "SubTotal")), 2)
            End If
            '
            .Cuenta = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cuenta")
            .Monto = Math.Abs(SubTotal)
            .Tipo = IIf(SubTotal < 0, "C", "D")
            .Periodo = PeriodosDB.Activo(Fecha.DateTime.Date)
            .CompNo = 0
            .Mes = Fecha.DateTime.Month

            .Mostrar(DT_Distribucion)
            DT_Distribucion.DefaultView.RowFilter = ""
        End With

    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVista.RowUpdated
        CalcularTotales()
    End Sub

    Sub CalcularTotales()
        If iVista.DataRowCount = 0 Then
            txtSubTotal.EditValue = 0.00
            txtIva.EditValue = 0.00
            txtTotal.EditValue = 0.00
            txtTotalU.EditValue = 0.00
            Exit Sub
        End If
        '
        Dim SubTotal As Double = 0,
            IVA As Double = 0,
            Total As Double = 0

        With iVista
            For i As Integer = 0 To .DataRowCount - 1

                SubTotal += (.GetRowCellValue(i, "Cantidad") * .GetRowCellValue(i, "Precio")) -
                        (.GetRowCellValue(i, "Cantidad") * .GetRowCellValue(i, "Precio")) * (.GetRowCellValue(i, "descuento") / 100.0)

                If Not CBool(.GetRowCellValue(i, "Exento")) Then
                    IVA += ((.GetRowCellValue(i, "Cantidad") * .GetRowCellValue(i, "Precio")) -
                        (.GetRowCellValue(i, "Cantidad") * .GetRowCellValue(i, "Precio")) * (.GetRowCellValue(i, "descuento") / 100.0)) * (ConfigDetalle.IVA / 100)
                Else
                    IVA = 0.00
                End If
            Next
            '
            .RefreshData()
        End With
        '
        txtSubTotal.EditValue = Math.Round(SubTotal, 2)
        txtIva.EditValue = Math.Round(IVA, 2)
        txtTotal.EditValue = Math.Round(SubTotal + IVA, 2)
        txtTotalU.EditValue = Math.Round((SubTotal + IVA) / TCambio, 2)
    End Sub

    Private Sub cbProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged
        If cbProveedor.EditValue Is Nothing Then Exit Sub
        '
        Dim DetalleProveedor As ProveedoresDetails = ProveedoresDB.GetDetails(cbProveedor.EditValue)
        txtCedula.Text = IIf(DetalleProveedor.Ruc.Trim.Length < 5, DetalleProveedor.Cedula.Trim, DetalleProveedor.Ruc.Trim)
        cbFormaPago.EditValue = DetalleProveedor.Cod_Forma_Pago
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        With frmBuscarOrdenCompra
            .ShowDialog()
            ShowSplash("Cargando O/C...")
            If .Ok Then

                LoadOrden = True
                IdOrden = .iVista.GetRowCellValue(.iVista.FocusedRowHandle, "Consecutivo")
                Cargar()

                If _DT.Rows.Count > 0 Then

                    txtOC.Text = _DT.Rows.Item(0)("NoOrden")
                    cbProveedor.EditValue = _DT.Rows.Item(0)("Proveedor_ID")
                    Fecha.DateTime = _DT.Rows.Item(0)("Factura_Fecha")
                    FechaPago.DateTime = _DT.Rows.Item(0)("Factura_FechaPago")
                    cbFormaPago.EditValue = _DT.Rows.Item(0)("FormaPago_ID")
                    cbMoneda.EditValue = _DT.Rows.Item(0)("Moneda")
                    txtComentario.Text = _DT.Rows.Item(0)("Comentario")
                    gbTipo.EditValue = _DT.Rows.Item(0)("TipoOC")
                    '
                    LoadItems()
                    CalcularTotales()
                End If
            End If
            .Dispose()
            HideSplash()
            '
            If iVista.DataRowCount = 0 Then LoadOrden = False
        End With
    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub txtIva_EditValueChanged(sender As Object, e As EventArgs) Handles txtIva.EditValueChanged
        txtTotal.EditValue = txtSubTotal.EditValue + txtIva.EditValue
        txtTotalU.EditValue = Math.Round(CDbl(txtSubTotal.EditValue + txtIva.EditValue) / TCambio, 2)
    End Sub
End Class