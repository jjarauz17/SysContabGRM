Imports ApiHacienda
Imports Entities
Imports System.Xml
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class frmComprobantesElectonicosProveedores

    Dim db As New db_FacturasElectronicasCompras

    Private Sub frmComprobantesElectonicosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date
        '
        Desde2.DateTime = Desde.DateTime
        Hasta2.DateTime = Hasta.DateTime
        '
        Cargar()
        CargarCompras()

        iVista.PopulateColumns()
        FormatoGrid2(iVista, 2, 2)
        '
        iVista.Columns("IdFactura").Visible = False
        iVista.Columns("Numero").Visible = False
        iVista.Columns("Mensaje Rechazo").Visible = False
        iVista.Columns("Respuesta").Visible = False
        iVista.Columns("XmlOriginal").Visible = False
        iVista.Columns("XmlEnviado").Visible = False
        iVista.Columns("XmlFirmado").Visible = False
        iVista.Columns("XmlRespuesta").Visible = False
        iVista.Columns("Registro").Visible = False

        GridCompras()

        TabbedControlGroup1.SelectedTabPageIndex = 0
    End Sub

    Sub GridCompras()
        iVistaCompra.PopulateColumns()
        FormatoGrid2(iVistaCompra, 2, 2)
        '
        iVistaCompra.Columns("IdFactura").Visible = False
        iVistaCompra.Columns("IdProveedor").Visible = False
        iVistaCompra.Columns("FechaEmision").Visible = False
        iVistaCompra.Columns("Respuesta").Visible = False
        iVistaCompra.Columns("Registro").Visible = False
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = ClasesBLL.db_FacturasElectronicasAceptadas.Listar(
            0,
            Desde.DateTime.Date,
            Hasta.DateTime.Date)
    End Sub

    Sub CargarCompras()
        iGridCompra.DataSource = db.Listar(
            0,
            Desde2.DateTime.Date,
            Hasta2.DateTime.Date,
            EmpresaActual)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()

        'Dim fn As New ClasesBLL.Funciones()
        'XtraMsg(fn.CreaCodigoSeguridad("01", "001", "00001", VB.SysContab.Rutinas.Fecha(), "0000001507"))
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        With frmXmlProveedor
            .ShowDialog()
            If .Ok = "SI" Then ShowSplash() : Cargar() : HideSplash()
            .Dispose()
        End With

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(
            iGrid,
            "Comprobantes Electrónicos de Proveedores")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        Dim Estado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado").ToString
        Dim Mensaje As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Mensaje").ToString
        Dim Consecutivo As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Consecutivo").ToString
        Dim IDP As ClasesBLL.IDP_FacturaElectronica = ClasesBLL.IDP_FacturaElectronicaToken.Detalles()

        'Generar el Token
        ShowSplash("Generando Token...")
        Dim iToken As New TokenHacienda
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

        ShowSplash("Consultando Estado...")
        '
        Dim enviaFactura As New ClasesBLL.Comunicacion
        enviaFactura.ConsultaEstatusReceptor(
            iToken.accessToken,
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "Clave").ToString & "-" & iVista.GetRowCellValue(iVista.FocusedRowHandle, "Consecutivo").ToString,
            IDP.APIUrl)
        HideSplash()
        '
        If enviaFactura.statusCodeFirma.Equals("400") Or
            enviaFactura.statusCodeFirma.Equals("404") Then
            XtraMsg(enviaFactura.mensajeRespuesta,
                    MessageBoxIcon.Error)
        Else
            XtraMsg(enviaFactura.mensajeRespuesta)
        End If
        '
        Dim directorio As String = IDP.DirectorioATV + "Proveedores\"


        If Not enviaFactura.xmlRespuesta Is Nothing Then _
            enviaFactura.xmlRespuesta.Save(directorio & iVista.GetRowCellValue(iVista.FocusedRowHandle, "Consecutivo").ToString & "_XML_Respuesta.xml")

        If Not enviaFactura.estadoFactura Is Nothing Then
            Dim obj As New ClasesBLL.FacturasElectronicasAceptadas
            Dim db As New ClasesBLL.db_FacturasElectronicasAceptadas

            obj.IdFactura = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdFactura")
            obj.StatusCode = enviaFactura.statusCode
            obj.Estado = enviaFactura.estadoFactura
            obj.Respuesta = enviaFactura.mensajeRespuesta
            If enviaFactura.xmlRespuesta Is Nothing Then
                obj.XmlRespuesta = String.Empty
            Else
                obj.XmlRespuesta = enviaFactura.xmlRespuesta.OuterXml
            End If
            '
            If db.Actualizar(obj) Then
                If Not Estado.Equals("aceptado") And
                   enviaFactura.estadoFactura.Equals("aceptado") Then

                    Dim _DT_Resp As DataTable = ClasesBLL.db_FacturasElectronicasAceptadas.Listar(
                        iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdFactura"),
                        Now.Date,
                        Now.Date)

                    If _DT_Resp.Rows.Count = 0 Then
                        XtraMsg("No se han encontrado datos del XML", MessageBoxIcon.Error)
                        Cargar()
                        Exit Sub
                    End If

                    Dim XmlOriginal As String = _DT_Resp.Rows.Item(0)("XmlOriginal")

                    'Enviar Correo de confirmacion de recibido
                    Dim XmlO As New Xml.XmlDocument
                    XmlO.LoadXml(XmlOriginal)
                    '
                    If TypeOf XmlO.FirstChild Is System.Xml.XmlDeclaration Then
                        XmlO.RemoveChild(XmlO.FirstChild)
                    End If
                    XmlO.PreserveWhitespace = False

                    Dim CorreoEmisor As String = String.Empty
                    Dim CorreoReceptor As String = String.Empty
                    Dim Moneda As String = "CRC"

                    Try
                        Moneda = XmlO.GetElementsByTagName("ResumenFactura")(0)("CodigoMoneda").InnerText
                    Catch ex As Exception
                    End Try

                    Dim ClaveEmisor As String = XmlO.GetElementsByTagName("Clave")(0).InnerText

                    Try
                        CorreoEmisor = XmlO.GetElementsByTagName("Emisor")(0)("CorreoElectronico").InnerText
                    Catch ex As Exception
                        XtraMsg("El Emisor de la Factura Electrónica no tiene correo electrónico definido",
                                MessageBoxIcon.Warning)
                        Cargar()
                        Exit Sub
                    End Try
                    '
                    If CorreoEmisor.Trim.Length = 0 Then
                        XtraMsg("El Emisor de la Factua Electrónica no tiene correo electrónico definido!", MessageBoxIcon.Warning)
                        Cargar()
                        Exit Sub
                    End If

                    Try
                        CorreoReceptor = XmlO.GetElementsByTagName("Receptor")(0)("CorreoElectronico").InnerText
                    Catch ex As Exception
                    End Try

                    '
                    If IO.File.Exists(directorio & Consecutivo & "_XML_Firmado.xml") Then
                        IO.File.Delete(directorio & Consecutivo & "_XML_Firmado.xml")
                    End If
                    '
                    If IO.File.Exists(directorio & Consecutivo & "_XML_Respuesta.xml") Then
                        IO.File.Delete(directorio & Consecutivo & "_XML_Respuesta.xml")
                    End If
                    '
                    Dim XmlFirma As New Xml.XmlDocument
                    XmlFirma.LoadXml(_DT_Resp.Rows.Item(0)("XmlFirmado"))
                    XmlFirma.Save(directorio & Consecutivo & "_XML_Firmado.xml")
                    '
                    Dim XmlRest As New Xml.XmlDocument
                    XmlRest.LoadXml(_DT_Resp.Rows.Item(0)("XmlRespuesta"))
                    XmlRest.Save(directorio & Consecutivo & "_XML_Respuesta.xml")

                    ShowSplash("Enviando Correo....")
                    '
                    db.SendMail(CorreoEmisor.ToLower,
                                CorreoReceptor.ToLower,
                                "Recepción No. " & Consecutivo & ". Estado: " & Mensaje,
                                iVista.GetRowCellValue(iVista.FocusedRowHandle, "Emisor").ToString,
                                ClaveEmisor,
                                Consecutivo,
                                Mensaje,
                                Moneda,
                                 iVista.GetRowCellValue(iVista.FocusedRowHandle, "Impuesto"),
                                iVista.GetRowCellValue(iVista.FocusedRowHandle, "Total"),
                                NombreEmpresaActual,
                                directorio & Consecutivo & "_XML_Firmado.xml",
                                directorio & Consecutivo & "_XML_Respuesta.xml")
                    HideSplash()
                End If
            End If

            Cargar()

        End If

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        Dim Estado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado").ToString
        ' Dim ClaveReceptor As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Clave").ToString
        Dim Mensaje As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Mensaje").ToString
        'Dim XmlOriginal As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlOriginal").ToString
        'Dim XmlFirmado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlFirmado").ToString
        'Dim XmlRespuesta As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlRespuesta").ToString
        Dim Consecutivo As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Consecutivo").ToString

        If Not Estado.Equals("aceptado") Then
            XtraMsg("El Comprobante no ha sido aceptado aún.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        Dim _DT_Resp As DataTable = ClasesBLL.db_FacturasElectronicasAceptadas.Listar(
                        iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdFactura"),
                        Now.Date,
                        Now.Date)

        If _DT_Resp.Rows.Count = 0 Then
            XtraMsg("No se han encontrado datos del XML", MessageBoxIcon.Error)
            Cargar()
            Exit Sub
        End If

        Dim XmlOriginal As String = _DT_Resp.Rows.Item(0)("XmlOriginal")

        Dim IDP As ClasesBLL.IDP_FacturaElectronica = ClasesBLL.IDP_FacturaElectronicaToken.Detalles()
        Dim db As New ClasesBLL.db_FacturasElectronicasAceptadas

        Dim directorio As String = IDP.DirectorioATV + "Proveedores\"

        'Enviar Correo de confirmacion de recibido
        Dim XmlO As New Xml.XmlDocument
        XmlO.LoadXml(XmlOriginal)
        '
        If TypeOf XmlO.FirstChild Is System.Xml.XmlDeclaration Then
            XmlO.RemoveChild(XmlO.FirstChild)
        End If

        XmlO.PreserveWhitespace = False
        '
        Dim CorreoEmisor As String = String.Empty
        Dim CorreoReceptor As String = String.Empty
        Dim Moneda As String = String.Empty

        Try
            Moneda = XmlO.GetElementsByTagName("ResumenFactura")(0)("CodigoMoneda").InnerText
        Catch ex As Exception
            Moneda = "CRC"
        End Try

        Dim ClaveEmisor As String = XmlO.GetElementsByTagName("Clave")(0).InnerText
        '
        Try
            CorreoEmisor = XmlO.GetElementsByTagName("Emisor")(0)("CorreoElectronico").InnerText
        Catch ex As Exception
            XtraMsg("El Emisor de la Factura Electrónica no tiene correo electrónico definido", MessageBoxIcon.Warning)
            Cargar()
            Exit Sub
        End Try
        '
        If CorreoEmisor.Trim.Length = 0 Then
            XtraMsg("El Emisor de la Factua Electrónica no tiene correo electrónico definido!", MessageBoxIcon.Warning)
            Cargar()
            Exit Sub
        End If
        '
        Try
            CorreoReceptor = XmlO.GetElementsByTagName("Receptor")(0)("CorreoElectronico").InnerText
        Catch ex As Exception
        End Try

        'Dim CorreoEmisor As String = XmlO.GetElementsByTagName("Emisor")(0)("CorreoElectronico").InnerText
        'Dim CorreoReceptor As String = XmlO.GetElementsByTagName("Receptor")(0)("CorreoElectronico").InnerText
        'Dim Moneda As String = XmlO.GetElementsByTagName("ResumenFactura")(0)("CodigoMoneda").InnerText
        'Dim ClaveEmisor As String = XmlO.GetElementsByTagName("Clave")(0).InnerText

        'If CorreoEmisor.Trim.Length = 0 Then
        '    XtraMsg("El Emisor de la Factua Electrónica no tiene correo electrónico válido!", MessageBoxIcon.Warning)
        '    Cargar()
        '    Exit Sub
        'End If
        '
        If IO.File.Exists(directorio & Consecutivo & "_XML_Firmado.xml") Then
            IO.File.Delete(directorio & "\" & Consecutivo & "_XML_Firmado.xml")
        End If
        '
        If IO.File.Exists(directorio & "\" & Consecutivo & "_XML_Respuesta.xml") Then
            IO.File.Delete(directorio & "\" & Consecutivo & "_XML_Respuesta.xml")
        End If
        '        
        'If _DT_Resp.Rows.Count > 0 Then
        Dim XmlFirma As New Xml.XmlDocument
        XmlFirma.LoadXml(_DT_Resp.Rows.Item(0)("XmlFirmado"))
        XmlFirma.Save(directorio & "\" & Consecutivo & "_XML_Firmado.xml")

        Dim XmlRest As New Xml.XmlDocument
        XmlRest.LoadXml(_DT_Resp.Rows.Item(0)("XmlRespuesta"))
        XmlRest.Save(directorio & "\" & Consecutivo & "_XML_Respuesta.xml")
        ' End If

        ShowSplash("Enviando Correo....")
        '
        Dim msg As String = db.SendMail(CorreoEmisor,
                    CorreoReceptor,
                    "Recepción No. " & Consecutivo & ". Estado: " & Mensaje,
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Emisor").ToString,
                    ClaveEmisor,
                    Consecutivo,
                    Mensaje,
                    Moneda,
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Impuesto"),
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Total"),
                    NombreEmpresaActual,
                    directorio & "\" & Consecutivo & "_XML_Firmado.xml",
                    directorio & "\" & Consecutivo & "_XML_Respuesta.xml")
        HideSplash()
        If msg.Equals("Ok") Then
            XtraMsg("Correo Enviado con éxito")
            Cargar()
        End If

    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.RowHandle < 0 Then Exit Sub

        If e.Column.FieldName = "Estado" Then

            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.Gray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("aceptado") Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("rechazado") Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("procesando") Then
                e.Appearance.ForeColor = Color.Navy
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("recibido") Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.LightGray
            End If

        End If

        ' RolesDB.UsuarioAcciones()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim Estado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado").ToString

        If Estado.Equals("rechazado") Then
            With frmMotivoRechazo
                .Tipo = 2
                .ID = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdFactura")
                .ShowDialog()
                .Dispose()
            End With
            Exit Sub
        End If
    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bCompraElectronica_Click(sender As Object, e As EventArgs) Handles bCompraElectronica.Click
        With frmFacturaElectronicaCompra
            .ShowDialog()

            If .Ok Then CargarCompras()
            .Dispose()
        End With
    End Sub

    Private Sub bConsultar_Click(sender As Object, e As EventArgs) Handles bConsultar.Click
        If iVistaCompra.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        'Dim Estado As String = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "Estado").ToString()
        ' Dim ClaveReceptor As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Clave").ToString
        'Dim Mensaje As String = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "Mensaje").ToString
        'Dim XmlOriginal As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlOriginal").ToString
        'Dim XmlFirmado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlFirmado").ToString
        'Dim XmlRespuesta As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "XmlRespuesta").ToString
        Dim Consecutivo As String = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "O/P").ToString()
        Dim Clave As String = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "Clave").ToString()

        Dim IDP As ClasesBLL.IDP_FacturaElectronica = ClasesBLL.IDP_FacturaElectronicaToken.Detalles()

        'Generar el Token
        ShowSplash("Generando Token...")
        Dim iToken As New TokenHacienda
        iToken.GetTokenHacienda(
            IDP.Usuario,
            IDP.Password,
            IDP.IDP_CLIENT_ID,
            IDP.IDP_URI
            )
        HideSplash()
        '
        If Not iToken.iError.Equals("Ok") Then
            XtraMsg(iToken.iError, MessageBoxIcon.Error)
            Exit Sub
        End If

        ShowSplash("Consultando Estado...")
        '
        Dim enviaFactura As New Comunicacion
        enviaFactura.ConsultaEstatus(
            iToken.accessToken,
            Clave,
            IDP.APIUrl)
        HideSplash()
        '
        'If enviaFactura.statusCode.Equals("400") Or
        '    enviaFactura.statusCode.Equals("404") Then
        '    XtraMsg(enviaFactura.mensajeRespuesta,
        '            MessageBoxIcon.Error)
        'Else
        '    XtraMsg(enviaFactura.mensajeRespuesta)
        'End If
        ''
        XtraMsg(enviaFactura.mensajeRespuesta)

        Dim directorio As String = IDP.DirectorioATV + "FECompra\"

        If Not enviaFactura.xmlRespuesta Is Nothing Then _
            enviaFactura.xmlRespuesta.Save($"{directorio}{Consecutivo}_XML_Respuesta.xml")

        If Not enviaFactura.estadoFactura Is Nothing Then
            Dim obj As New FacturasElectronicasCompras
            Dim db As New db_FacturasElectronicasCompras

            If enviaFactura.xmlRespuesta Is Nothing Then
                obj.XmlRespuesta = String.Empty
            Else
                obj.XmlRespuesta = enviaFactura.xmlRespuesta.OuterXml
            End If

            'Actualizar estado de la transaccion y XML de Respuesta
            obj.IdFactura = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "IdFactura")
            obj.Empresa = EmpresaActual
            obj.StatusCode = IIf(enviaFactura.statusCode Is Nothing, "", enviaFactura.statusCode)
            obj.Estado = IIf(enviaFactura.estadoFactura Is Nothing, "sin-respuesta", enviaFactura.estadoFactura)
            obj.Respuesta = IIf(enviaFactura.mensajeRespuesta Is Nothing, "", enviaFactura.mensajeRespuesta)

            db.Actualizar(obj)

            If enviaFactura.estadoFactura.Equals("rechazado") Then
                AnularFC()
            End If

            CargarCompras()
        End If
    End Sub

    Sub AnularFC()

        Dim _DT As DataTable =
            ObtieneDatos("sp_sel_Comprobantes",
                         iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "O/P"),
                         iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "IdProveedor"),
                         EmpresaActual)

        ''*************  INICIAR TRANSACCION    *****************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        ''**********************************************************************

        Try
            ShowSplash("Anulando O/P...")

            If _DT.Rows.Count > 0 Then
                With _DT.Rows(0)
                    VB.SysContab.ComprobanteDB.ComprobanteAnular(.Item("Comp_No"),
                                                            .Item("Per_Id"),
                                                            .Item("Comp_Fecha"))

                    'EliminaDistribucionTrans(.Item("Comp_No"),
                    '                         .Item("Per_Id"),
                    '                         .Item("Comp_Fecha").Month)

                    VB.SysContab.ComprobanteDB.CancelarFactura(.Item("Factura"),
                                                               .Item("Proveedor"),
                                                               0)
                    VB.SysContab.ComprobanteDB.PagosFacturasBorrar(.Item("Comp_No"),
                                                                   .Item("Mes"),
                                                                   .Item("Per_Id"))
                End With
            End If
            '
            VB.SysContab.Facturas_ComprasDB.UpdateEstado(
                iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "O/P"),
                "A",
                Now.Date,
                iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "IdProveedor"))

            VB.SysContab.Rutinas.okTransaccion()
            '
            HideSplash()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGridCompra, "Facturas de Compra Electrónica")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        Dim Estado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado").ToString

        If Not Estado.Equals("aceptado") Then
            XtraMsg("El XML no ha sido aceptado por Hacienda!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "O/P").ToString().Trim.Length > 0 Then
            XtraMsg("La Factura Electrónica ya contiene una Orden de Pago Asociada",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        With frmOrdenPagoNew
            .IdFactura = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdFactura")
            .ShowDialog()
            If .Ok Then Cargar()
            .Dispose()
        End With

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        CargarCompras()
    End Sub

    Private Sub iVistaCompra_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVistaCompra.RowCellStyle
        If e.RowHandle < 0 Then Exit Sub

        If e.Column.FieldName = "Estado" Then

            e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.Gray
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVistaCompra.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("aceptado") Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVistaCompra.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("rechazado") Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf iVistaCompra.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("procesando") Then
                e.Appearance.ForeColor = Color.Navy
            ElseIf iVistaCompra.GetRowCellValue(e.RowHandle, "Estado").ToString().Equals("recibido") Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.LightGray
            End If

        End If
    End Sub

    Private Sub iVistaCompra_DoubleClick(sender As Object, e As EventArgs) Handles iVistaCompra.DoubleClick
        If iVistaCompra.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim Estado As String = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "Estado").ToString

        If Estado.Equals("rechazado") Then
            With frmMotivoRechazo
                .Tipo = 4
                .ID = iVistaCompra.GetRowCellValue(iVistaCompra.FocusedRowHandle, "IdFactura")
                .ShowDialog()
                .Dispose()
            End With
            Exit Sub
        End If
    End Sub
End Class