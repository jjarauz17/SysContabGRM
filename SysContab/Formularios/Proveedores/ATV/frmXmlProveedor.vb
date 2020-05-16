Imports System.Xml
Imports System.IO
Imports Newtonsoft.Json
Imports ClasesBLL
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmXmlProveedor

    Public Ok As String = "NO"

    Dim IDP As New IDP_FacturaElectronica
    Dim EmisorTipo As String, ReceptorTipo As String
    Dim obj As New FacturasElectronicasAceptadas
    Dim db As New db_FacturasElectronicasAceptadas
    Dim ConsecutivoProveedor As String = String.Empty

    Private Sub frmXmlProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Combo(
            cbMensaje, ObtieneDatos("sp_MensajeReceptorEstados",
                                    EmpresaActual),
            "[Seleccione Estado]")
        cbMensaje.ItemIndex = 0

        FechaEnvio.DateTime = VB.SysContab.Rutinas.Fecha().Date

        'SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
        'SearchLookUp(cbServicio, ObtieneDatos("sp_sel_ServiciosRubros", EmpresaActual), "Nombre", "Codigo", 4, 5, 6)
        'SearchLookUp(cbCatalogo, ObtieneDatos("sp_GetCatalogoCuentaIVA", EmpresaActual), "Nombre", "Codigo", 3, 4)
        'GetFormaPagoList(cbFormaPago)
        'cbFormaPago.ItemIndex = 0
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try

            Me.OpenFileDialog1.DefaultExt = "*.xml"
            Me.OpenFileDialog1.Filter = "Archivo XML (*.xml)|*.xml"

            If Not Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
            '
            Dim objReader As StreamReader
            objReader = File.OpenText(OpenFileDialog1.FileName)

            txtXML.Text = objReader.ReadToEnd
            objReader.Close()

            lblXml.Text = "Archivo XML: " & OpenFileDialog1.FileName
        Catch ex As Exception
            XtraMsg("Error al Leer Archivo XML: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If txtXML.Text.Length = 0 Then
            XtraMsg("Debe Cargar Primero el XML enviado por su proveedor", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        Dim _DT As DataTable =
            db_FacturasElectronicasAceptadas.Buscar(txtXML.Text)

        If _DT.Rows.Count > 0 Then
            XtraMsg("El " & lblXml.Text & " ya fue procesado y se encuentra en estado: " & _DT.Rows.Item(0)("Estado").ToString, MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim sNodo As String = String.Empty

        Try
            Dim xmlEnvia As New Xml.XmlDocument
            xmlEnvia.LoadXml(txtXML.Text)

            If TypeOf xmlEnvia.FirstChild Is System.Xml.XmlDeclaration Then
                xmlEnvia.RemoveChild(xmlEnvia.FirstChild)
            End If

            xmlEnvia.PreserveWhitespace = False

            sNodo = "Clave"
            txtClave.Text = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
            sNodo = "FechaEmision"
            txtFecha.Text = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText
            If txtFecha.Text.Length >= 33 Then txtFecha.Text = Mid(txtFecha.Text, 1, 19) + "-06:00"
            'Emisor
            sNodo = "Nombre del Emisor"
            txtEmisorNombre.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText
            sNodo = "Identificacion del Emisor"
            txtEmisorNumero.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
            sNodo = "Tipo Identificacion del Emisor"
            EmisorTipo = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Tipo").InnerText
            Try
                sNodo = "Correo del Emisor"
                txtCorreoEmisor.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("CorreoElectronico").InnerText
            Catch ex As Exception
                XtraMsg("El " & lblXml.Text & vbCrLf &
                        "no contiene el Nodo de " & sNodo & vbCrLf &
                        "Error: " & ex.Message,
                        MessageBoxIcon.Warning)
                txtCorreoEmisor.EditValue = String.Empty
            End Try
            '
            'Receptor
            sNodo = "Nombre del Receptor"
            txtReceptor.Text = xmlEnvia.GetElementsByTagName("Receptor")(0)("Nombre").InnerText
            sNodo = "Identificacion del Receptor"
            txtCedulaReceptor.Text = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText
            sNodo = "Tipo Identificacion del Receptor"
            ReceptorTipo = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Tipo").InnerText
            '
            Try
                sNodo = "Correo del Receptor"
                txtCorreoReceptor.Text = xmlEnvia.GetElementsByTagName("Receptor")(0)("CorreoElectronico").InnerText
            Catch ex As Exception
                XtraMsg("El " & lblXml.Text & vbCrLf &
                        "no contiene el Nodo de " & sNodo & vbCrLf &
                        "Error: " & ex.Message,
                        MessageBoxIcon.Warning)
                txtCorreoReceptor.EditValue = String.Empty
            End Try
            '
            Try
                sNodo = "Codigo de la Moneda"
                txtMoneda.Text = xmlEnvia.GetElementsByTagName("ResumenFactura")(0)("CodigoMoneda").InnerText
                sNodo = "Tasa de Cambio"
                txtTasa.EditValue = CDbl(xmlEnvia.GetElementsByTagName("ResumenFactura")(0)("TipoCambio").InnerText)
            Catch ex As Exception
                XtraMsg("El " & lblXml.Text & vbCrLf &
                        "no contiene el Nodo de " & sNodo & vbCrLf &
                        "Error: " & ex.Message,
                        MessageBoxIcon.Warning)
                txtMoneda.Text = "CRC"
                txtTasa.EditValue = 1.0
            End Try
            '
            Try
                sNodo = "Total Impuesto"
                txtTotalImpuesto.EditValue = CDbl(xmlEnvia.GetElementsByTagName("ResumenFactura")(0)("TotalImpuesto").InnerText)
            Catch ex As Exception
                XtraMsg("El " & lblXml.Text & vbCrLf &
                        "no contiene el Nodo de " & sNodo & vbCrLf &
                        "Error: " & ex.Message,
                        MessageBoxIcon.Warning)
                txtTotalImpuesto.EditValue = 0.00
            End Try
            '
            sNodo = "Total Comprobante"
            txttotalFactura.EditValue = CDbl(xmlEnvia.GetElementsByTagName("ResumenFactura")(0)("TotalComprobante").InnerText)

            'sNodo = "NumeroConsecutivo"
            'txtFactura.Text = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText
            'ConsecutivoProveedor = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText

            txtConsecutivo.Text =
                db_FacturasElectronicasAceptadas _
                .GetConsecutivo(
                cbMensaje.EditValue)

        Catch ex As Exception
            XtraMsg("El " & lblXml.Text & vbCrLf &
                        "no contiene el Nodo de " & sNodo & vbCrLf &
                        "Error: " & ex.Message,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub cbMensaje_EditValueChanged(sender As Object, e As EventArgs) Handles cbMensaje.EditValueChanged
        txtConsecutivo.Text = db_FacturasElectronicasAceptadas.GetConsecutivo(cbMensaje.EditValue)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If txttotalFactura.EditValue = 0.00 Then
            XtraMsg("El Total de la Factura debe ser Mayor que Cero (0.00)", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If cbMensaje.EditValue <> 1 Then
            If txtMensajeRechazo.Text.Trim.Length = 0 Then
                XtraMsg("Debe indicar el motivo del rechazo de esta factura Electrónica y tambien informar al Proveedor del mismo.", MessageBoxIcon.Error)
                txtMensajeRechazo.Focus()
                Exit Sub
            End If
        End If
        '
        'If txtTotalImpuesto.EditValue > 0 Then
        '    If cbCatalogo.EditValue Is Nothing Then
        '        XtraMsg("Seleccione la Cuenta de IVA", MessageBoxIcon.Warning)
        '        cbCatalogo.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If Not ContabilizarOP() Then
        '    Exit Sub
        'End If

        Dim _DT As DataTable =
            db_FacturasElectronicasAceptadas.Buscar(
            txtXML.Text)

        If _DT.Rows.Count > 0 Then
            XtraMsg("El " & lblXml.Text & " ya fue procesado y se encuentra en estado: " &
                    _DT.Rows.Item(0)("Estado").ToString,
                    MessageBoxIcon.Error)
            Exit Sub
        End If

        ShowSplash("Procesando XML...")
        '
        Dim _DT_JSON As DataTable = ObtieneDatos("sp_MensajeReceptorJson",
                                                 txtClave.Text,
                                                 txtEmisorNumero.Text,
                                                 FechaEnvio.DateTime,
                                                 cbMensaje.EditValue,
                                                 txtMensajeRechazo.Text,
                                                 txtTotalImpuesto.EditValue,
                                                 txttotalFactura.EditValue,
                                                 txtCedulaReceptor.Text,
                                                 txtConsecutivo.Text,
                                                 EmpresaActual)

        If _DT_JSON.Rows.Count = 0 Then
            XtraMsg("Hubo un Problema al cargar los datos a Enviar, Consulte a IT Desarrollo.", MessageBoxIcon.Warning)
            HideSplash()
            Exit Sub
        End If
        '
        IDP = IDP_FacturaElectronicaToken.Detalles()
        'Deserializar el Json que trae los Datos a Enviar a Hacienda.
        Dim xDoc As XDocument = JsonConvert.DeserializeXNode(_DT_JSON.Rows.Item(0)("JsonEnviar"), "MensajeReceptor", True)
        'Preparar XML, Reemplazar Encabezado.
        Dim XmlEnviar As String = xDoc.ToString.Replace("<MensajeReceptor>", _DT_JSON.Rows.Item(0)("Encabezado"))
        'Establecer Directorio, donde se guardaran de Respaldo los XML Enviados
        Dim directorio As String = _DT_JSON.Rows.Item(0)("Directorio")
        Dim nombreArchivo As String = txtConsecutivo.Text
        Dim certificado As String = _DT_JSON.Rows.Item(0)("RutaCertificado")
        'Convertir archivo a Formato XmlDocument
        Dim xmlDocSF As New Xml.XmlDocument
        xmlDocSF.LoadXml(XmlEnviar)
        '
        'Guardar XML sin Firma
        xmlDocSF.Save(directorio & nombreArchivo & "_XML_SinFirma.xml")
        '        
        'Firmar XML
        Dim _firma As New ApiHacienda.Firma
        _firma.FirmaXML_Xades(directorio & nombreArchivo, certificado, False, IDP.PIN, IDP.FirmaUrl)

        If Not _firma.iError.Equals("Ok") Then
            XtraMsg(_firma.iError, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Guardar XML Firmado
        Dim xmlElectronica As New Xml.XmlDocument
        xmlElectronica.Load(directorio & nombreArchivo & "_XML_Firmado.xml")

        Dim txtXMLFirmado As String = xmlElectronica.OuterXml
        'Datos del Emisor
        Dim myEmisor As New Emisor With {.numeroIdentificacion = txtEmisorNumero.Text, .TipoIdentificacion = EmisorTipo}

        Dim myReceptor As New Receptor With {.numeroIdentificacion = txtCedulaReceptor.Text, .TipoIdentificacion = ReceptorTipo}
        '
        'Preparando la Entidad Recepcion
        Dim myRecepcion As New Recepcion
        myRecepcion.emisor = myEmisor
        myRecepcion.receptor = myReceptor

        myRecepcion.clave = txtClave.Text
        myRecepcion.fecha = txtFecha.Text '_DT_JSON.Rows.Item(0)("FechaEmision")
        myRecepcion.ConsecutivoReceptor = txtConsecutivo.Text
        myRecepcion.comprobanteXml = ClasesBLL.Funciones.EncodeStrToBase64(xmlElectronica.OuterXml)
        '
        HideSplash()
        'Generar el Token
        ShowSplash("Generando Token...")
        Dim iToken As New ApiHacienda.TokenHacienda
        iToken.GetTokenHacienda(
            IDP.Usuario,
            IDP.Password,
            IDP.IDP_CLIENT_ID,
            IDP.IDP_URI)
        HideSplash()
        '
        If Not iToken.iError.Equals("Ok") Then
            XtraMsg(iToken.iError, MessageBoxIcon.Error)
            Exit Sub
        End If

        ShowSplash("Enviando Respuesta...")
        '
        Dim enviaFactura As New Comunicacion
        enviaFactura.EnvioDatosReceptor(
            iToken.accessToken,
            myRecepcion,
            IDP.APIUrl)
        HideSplash()

        If enviaFactura.statusCodeFirma.Equals("400") Or
            enviaFactura.statusCodeFirma.Equals("404") Then
            XtraMsg(enviaFactura.mensajeRespuesta, MessageBoxIcon.Error)
            Exit Sub
        Else
            XtraMsg(enviaFactura.mensajeRespuesta)
        End If
        '
        If Not enviaFactura.xmlRespuesta Is Nothing Then
            'Guardar XML sin Firma
            enviaFactura.xmlRespuesta.Save(directorio & nombreArchivo & "_XML_Respuesta.xml")
        End If
        '
        If enviaFactura.estadoFactura Is Nothing Then
            Exit Sub
        End If

        'Guardar Datos en Tabla.
        obj.Numero = CInt(Mid(txtConsecutivo.Text, 11, 10))
        obj.Clave = txtClave.Text
        obj.Emisor = txtEmisorNombre.Text
        obj.CedulaEmisor = txtEmisorNumero.Text
        obj.FechaEmision = txtFecha.Text
        obj.FechaEnvio = FechaEnvio.DateTime.Date
        obj.Mensaje = cbMensaje.EditValue
        obj.MensajeDetalle = txtMensajeRechazo.Text
        obj.TotalImpuesto = txtTotalImpuesto.EditValue
        obj.TotalFactura = txttotalFactura.EditValue
        obj.Receptor = txtReceptor.Text
        obj.CedulaReceptor = txtCedulaReceptor.Text
        obj.Consecutivo = txtConsecutivo.Text
        obj.StatusCode = enviaFactura.statusCode
        obj.Estado = enviaFactura.estadoFactura
        obj.Respuesta = enviaFactura.mensajeRespuesta
        obj.XmlOriginal = txtXML.Text
        obj.XmlEnviado = xmlDocSF.OuterXml
        obj.XmlFirmado = txtXMLFirmado
        'obj.ConsecutivoProveedor = ConsecutivoProveedor

        If enviaFactura.xmlRespuesta Is Nothing Then
            obj.XmlRespuesta = String.Empty
        Else
            obj.XmlRespuesta = enviaFactura.xmlRespuesta.OuterXml
        End If

        If db.Insertar(obj) Then

            ''/********* GRABAR ORDEN DE PAGO *********
            ''*****************************************/
            'If Not ContabilizarOP() Then
            '    Exit Sub
            'End If

            Dim XmlO As New Xml.XmlDocument
            XmlO.LoadXml(txtXML.Text)

            Dim CorreoEmisor As String = String.Empty
            Dim CorreoReceptor As String = String.Empty

            Try
                CorreoEmisor = XmlO.GetElementsByTagName("Emisor")(0)("CorreoElectronico").InnerText
            Catch ex As Exception
                XtraMsg("El Emisor de la Factura Electronica no tiene correo electronico definido", MessageBoxIcon.Warning)
                Exit Sub
            End Try
            '
            If CorreoEmisor.Trim.Length = 0 Then
                XtraMsg("El Emisor de la Factua Electrónica no tiene correo electrónico válido!", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                CorreoReceptor = XmlO.GetElementsByTagName("Receptor")(0)("CorreoElectronico").InnerText
            Catch ex As Exception
            End Try

            If enviaFactura.estadoFactura.Equals("aceptado") Then
                ShowSplash("Enviando Correo....")
                '
                db.SendMail(CorreoEmisor,
                            CorreoReceptor,
                            "Recepción No. " & txtClave.Text & ". Estado: " & cbMensaje.Text,
                            txtEmisorNombre.Text,
                            txtClave.Text,
                            txtConsecutivo.Text,
                            cbMensaje.Text,
                            txtMoneda.Text,
                            txtTotalImpuesto.EditValue,
                            txttotalFactura.EditValue,
                            NombreEmpresaActual,
                            directorio & "\" & txtConsecutivo.Text & "_XML_Firmado.xml",
                            directorio & "\" & txtConsecutivo.Text & "_XML_Respuesta.xml")

                HideSplash()
            End If

            Ok = "SI"
        End If

        Close()
    End Sub

    'Function ContabilizarOP() As Boolean

    '    ShowSplash("Guardando O/P...")

    '    Dim fp As New VB.SysContab.Forma_PagoDB
    '    Dim fc As New VB.SysContab.Facturas_ComprasDB
    '    Dim DetalleEmpresa As New VB.SysContab.EmpresasDetails
    '    Dim ConfigDetalle As New VB.SysContab.ConfiguracionDetails
    '    Dim Plantilla As New VB.SysContab.PlantillaDB
    '    Dim plan As String = Plantilla.GetTipoPlantilla(1, 9)
    '    Dim PlantillaDetalle As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)

    '    DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
    '    ConfigDetalle = VB.SysContab.ConfiguracionDB.GetConfigDetails()

    '    Dim TipoCompr As Integer = PlantillaDetalle.TipoCompr
    '    Dim TCambio As Double = GetTasaCambioDia(FechaEnvio.DateTime)
    '    Dim Dias As Integer = fp.FormaPagoDias(cbFormaPago.EditValue)
    '    Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(FechaEnvio.DateTime.Date)
    '    Dim CuentaProveedor As String = ProveedoresDB.GetDetails(cbProveedor.EditValue).Cuenta

    '    Dim TotalFactura As Double = 0.00,
    '        TotalImpuesto As Double = 0.00

    '    If txtMoneda.Text.Equals("CRC") Then
    '        TotalFactura = txttotalFactura.EditValue
    '        TotalImpuesto = txtTotalImpuesto.EditValue
    '    Else
    '        TotalFactura = Math.Round(txttotalFactura.EditValue * TCambio, 2)
    '        TotalImpuesto = Math.Round(txtTotalImpuesto.EditValue * TCambio, 2)
    '    End If

    '    '/********* INICAR TRANSACCION PARA GUARDAR FACTURA DE COMPRA *********
    '    '**********************************************************************/
    '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
    '    DBConnFacturas.Open()
    '    transaccionFacturas = DBConnFacturas.BeginTransaction

    '    Try
    '        'Guardar Encabezado de Factura de Compra
    '        fc.AddItem(
    '            txtFactura.Text,
    '            FechaEnvio.DateTime.Date,
    '            FechaEnvio.DateTime.AddDays(Dias).Date,
    '            cbProveedor.EditValue,
    '            TotalFactura,
    '            cbFormaPago.EditValue,
    '            1,
    '            1,
    '            0,
    '            "",
    '            1,
    '            0,
    '            txtComentario.Text,
    '            "F", 0, 0, 0, 1, 0, 0, 0,
    '            TCambio, 0,
    '            DetalleEmpresa.MonedaBase,
    '            txtFactura.Text, 0,
    '            ConfigDetalle.Bodega,
    '            (TotalFactura - TotalImpuesto),
    '            0)

    '        'Guardar Fechas de Recepcion de Factura
    '        VB.SysContab.ComprobanteDB.AddFacturaFecha(
    '            cbProveedor.EditValue,
    '            txtFactura.Text.Trim,
    '            FechaEnvio.DateTime.AddDays(Dias).Date)

    '        'Guardar Linea de Gasto
    '        fc.AddFacturaLineas(
    '            txtFactura.Text,
    '            cbServicio.EditValue,
    '            1.0,
    '            (TotalFactura - TotalImpuesto),
    '            0.00,
    '            0.00,
    '            cbServicio.Properties.View.GetRowCellValue(cbServicio.Properties.View.FocusedRowHandle, "Tipo"),
    '            1.0,
    '            0.00,
    '            ConfigDetalle.IVA,
    '            cbProveedor.EditValue,
    '            cbServicio.Text,
    '            cbServicio.Properties.View.GetRowCellValue(cbServicio.Properties.View.FocusedRowHandle, "Cuenta"),
    '            "", 0, 0,
    '            cbServicio.Properties.View.GetRowCellValue(cbServicio.Properties.View.FocusedRowHandle, "IdProyecto"))

    '        'Guardar Impuesto
    '        If txtTotalImpuesto.EditValue > 0 Then
    '            fc.AddFacturaLineas(
    '            txtFactura.Text,
    '            cbCatalogo.EditValue,
    '            1.0,
    '            TotalImpuesto,
    '            0.00,
    '            0.00,
    '            cbCatalogo.Properties.View.GetRowCellValue(cbCatalogo.Properties.View.FocusedRowHandle, "Tipo"),
    '            1.0,
    '            0.00,
    '            ConfigDetalle.IVA,
    '            cbProveedor.EditValue,
    '            cbCatalogo.Text,
    '            cbCatalogo.Properties.View.GetRowCellValue(cbCatalogo.Properties.View.FocusedRowHandle, "Cuenta"))
    '        End If

    '        '/********* INICAR GUARDAR COMPROBANTE *********
    '        '***********************************************/

    '        'Guardar Encabezado del Comprobante
    '        Dim Comp_No As Integer = VB.SysContab.ComprobanteDB.AddComprobante(
    '            TipoCompr,
    '            TCambio,
    '            txtComentario.Text,
    '            DetalleEmpresa.MonedaBase,
    '            Per_Id,
    '            FechaEnvio.DateTime.Date,
    '            0,
    '            "",
    '            False,
    '            cbProveedor.EditValue,
    '            "",
    '            1,
    '            txtFactura.Text,
    '            FechaEnvio.DateTime.AddDays(Dias).Date,
    '            cbFormaPago.EditValue,
    '            OrigenComprobantes.ORDEN_DE_PAGO)

    '        'Guardar Detalle del Servicio/Producto
    '        ComprobanteDB.AddComprobanteDetalles(
    '            Comp_No,
    '            cbServicio.Properties.View.GetRowCellValue(cbServicio.Properties.View.FocusedRowHandle, "Cuenta"),
    '            cbServicio.Text,
    '            (TotalFactura - TotalImpuesto),
    '            0,
    '            TipoCompr,
    '            "D",
    '            txtFactura.Text,
    '            0,
    '            FechaEnvio.DateTime.Date,
    '            1, 0, "",
    '            cbServicio.Properties.View.GetRowCellValue(cbServicio.Properties.View.FocusedRowHandle, "IdProyecto"))

    '        If txtTotalImpuesto.EditValue > 0 Then
    '            'Guardar Impuesto
    '            ComprobanteDB.AddComprobanteDetalles(
    '            Comp_No,
    '            cbCatalogo.Properties.View.GetRowCellValue(cbCatalogo.Properties.View.FocusedRowHandle, "Cuenta"),
    '            cbCatalogo.Text,
    '            TotalImpuesto,
    '            0,
    '            TipoCompr,
    '            "D",
    '            txtFactura.Text,
    '            0,
    '            FechaEnvio.DateTime.Date,
    '            1)
    '        End If

    '        'Guardar Pasivo al Proveedor
    '        ComprobanteDB.AddComprobanteDetalles(
    '            Comp_No,
    '            CuentaProveedor,
    '            cbProveedor.Text,
    '            TotalFactura,
    '            0,
    '            TipoCompr,
    '            "C",
    '            txtFactura.Text,
    '            0,
    '            FechaEnvio.DateTime.Date,
    '            0)

    '        Rutinas.okTransaccion()
    '        HideSplash()
    '        Return True
    '    Catch ex As Exception
    '        Rutinas.ErrorTransaccion()
    '        HideSplash()

    '        XtraMsg("_Error al Guardar la O/P: " & vbCrLf & ex.Message,
    '                MessageBoxIcon.Error)

    '        Return False
    '    End Try
    'End Function

End Class