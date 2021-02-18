Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Imports SysContab.VB.SysContab

Public Class frmFacturasVentasEditar

    Public Factura As String = ""
    Private DT_Facturas As DataTable = New DataTable("Facturas")
    Private DT_Header As DataTable = New DataTable("Encabezado")
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Private TCambio As Double = 1
    Private Temp As Boolean = False
    Private DetallesBodega As VB.SysContab.BodegasDetails
    Private DetallesCliente As New VB.SysContab.ClientesDetails
    Private DT_DESCUENTO As DataTable
    Private Validar_Cotizacion As Boolean = False
    Private Validar_Orden As Boolean = False
    Private fp As New VB.SysContab.Forma_PagoDB

    Private Sub frmFacturasVentasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
        '
        GetBodegasList(cbBodega)

        SearchLookUp(
            cbCliente,
            ObtieneDatos("SP_GetClientes", EmpresaActual, 1, 1),
            "Nombre",
            "Codigo",
            3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)

        GetMonedasList(cmbmoneda)
        GetFormaPagoList(cmbformapago)
        GetTipoCultivo(Me.cbCultivos)
        cbCultivos.ItemIndex = 0
        TipoServicio.EditValue = "A"
        '
        RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 4, 5, 6, 7, 8)
        GetCentrosCostosList(cbCentroCosto, 1)
        GetVendedores(cmbvendedor)
        GetArticulos()
        '
        Cargar()
        CalcularTotales()
    End Sub

    Sub Cargar()

        DT_Header = ObtieneDatos("sp_sel_FACTURAS_VENTAS", Factura, EmpresaActual)

        If DT_Header.Rows.Count > 0 Then

            Dim Tipo As String = "A"

            If DT_Header.Rows.Item(0)("TIPO") = 0 Then Tipo = "P"
            If DT_Header.Rows.Item(0)("TIPO") = 1 Then Tipo = "S"
            If DT_Header.Rows.Item(0)("TIPO") = 2 Then Tipo = "A"

            txtfactura.Text = Factura
            cbCliente.EditValue = DT_Header.Rows.Item(0)("CLIENTE")
            txtNombreDe.Text = DT_Header.Rows.Item(0)("NOMBRE_CLIENTE")
            txtremision.Text = DT_Header.Rows.Item(0)("Remision")
            fecha.DateTime = DT_Header.Rows.Item(0)("FECHA")
            FechaPago.DateTime = DT_Header.Rows.Item(0)("FECHA_VENCIMIENTO")
            txtorden.Text = DT_Header.Rows.Item(0)("Orden")
            txtCondiciones.Text = DT_Header.Rows.Item(0)("Condiciones")
            cmbvendedor.EditValue = DT_Header.Rows.Item(0)("VENDEDOR")
            cbCentroCosto.EditValue = DT_Header.Rows.Item(0)("IdCentro")
            cmbformapago.EditValue = DT_Header.Rows.Item(0)("TIPO_FACTURA")
            cmbmoneda.EditValue = DT_Header.Rows.Item(0)("mon_mtto")
            cbCultivos.EditValue = DT_Header.Rows.Item(0)("Cultivo")
            txtNoEntrega.EditValue = DT_Header.Rows.Item(0)("OrdenEntrega")
            cbBodega.EditValue = DT_Header.Rows.Item(0)("Bodega")
            etTasa.EditValue = DT_Header.Rows.Item(0)("TCambio")
            chkImprimirUSD.Checked = IIf(DT_Header.Rows.Item(0)("MonedaImpresa") = MonedaBase, False, True)
            txtComentario.Text = DT_Header.Rows.Item(0)("Comentario")
            TipoServicio.EditValue = Tipo
            DetallesBodega = VB.SysContab.BodegasDB.GetDetails(cbBodega.EditValue)
            '
            'Detalle
            DT_Facturas = ObtieneDatos("SP_GetDetalleFactura", EmpresaActual, Factura)
            GridDetalle.DataSource = DT_Facturas
            '
            txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

            txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

            vFact.Columns("Precio").Caption = "Precio " & VB.SysContab.MonedaDB.GetDetails(MonedaBase).Simbolo     'cmbmoneda.GetColumnValue("Simbolo").ToString

            'Campos que solo ocupa RAMAC
            If EmpresaActual <> 1 Then
                vFact.Columns("Presentacion").Visible = False
                vFact.Columns("Cantidad").Visible = False
                vFact.Columns("Factor").Visible = False
            End If
        Else
            XtraMsg("No se encontró el Detalle de esta factura", MessageBoxIcon.Error)
            Dispose()
        End If
    End Sub

    Private Sub GetArticulos()
        Dim DT As DataTable =
            ObtieneDatos("SP_ArticulosGetAll",
                         TipoServicio.EditValue,
                         EmpresaActual,
                         cbBodega.EditValue)

        RepositorySearchLook(
            cbProducto,
            DT,
            "Display",
            "Codigo", 3, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31)
        cbProducto.View.Columns("PrecioU").Caption = "Precio U$"

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        '
        Dim ACredito As Integer = 0, Tipo As Integer = 2

        If TipoServicio.EditValue = "P" Then
            Tipo = 0
        ElseIf TipoServicio.EditValue = "S" Then
            Tipo = 1
        Else
            Tipo = 2
        End If
        '
        If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) > 0 Then
            If fp.FormaPagoDias(cmbformapago.EditValue) = 0 Then
                XtraMsg("La factura de Crédito no puede convertirse en Contado", MessageBoxIcon.Error)
                cmbformapago.Focus()
                Exit Sub
            End If
        Else
            If fp.FormaPagoDias(cmbformapago.EditValue) > 0 Then
                If Not XtraMsg2("Esta Seguro de Convertir esta Factura de Contado en Factura de Credito?") Then
                    cmbformapago.Focus()
                    Exit Sub
                Else
                    ACredito = 1
                End If
            End If
        End If
        '
        '*******************************************************************************************
        'Verificar Cierre del Día
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        '
        '*******************************************************************************************
        ' Validar Cierre de Inventario, si hay productos de inventario
        Dim dr() As DataRow = DT_Facturas.Select("Tipo = 'P'")
        '
        If dr.Length > 0 Then
            If Not VerificarCierre_Inventario(fecha.DateTime.Date) Then
                Exit Sub
            End If
        End If
        '*******************************************************************************************
        '
        If fecha.DateTime.Date > VB.SysContab.Rutinas.Fecha().Date Then
            If Not XtraMsg2("La Fecha de Facturación: " & fecha.DateTime.ToShortDateString & " es Mayor a la Fecha Actual: " & VB.SysContab.Rutinas.Fecha().Date.ToShortDateString & vbCrLf & "Confirmar Facturar de todos modos?") Then
                Exit Sub
            End If
        End If
        '
        If Not XtraMsg2("¿ ESTA SEGURO QUE LA INFORMACIÓN ES CORRECTA ?") Then
            Exit Sub
        End If

        'Guardar Encabezado
        If Guardar("sp_upd_FACTURAS_VENTAS", Factura,
                   fecha.DateTime.Date,
                   cbCliente.EditValue,
                   cmbvendedor.EditValue,
                   FechaPago.DateTime.Date,
                   Tipo,
                   cmbformapago.EditValue,
                   EmpresaActual,
                   txtNombreDe.Text,
                   cmbmoneda.EditValue,
                   txtremision.Text,
                   txtorden.Text,
                   cbCultivos.EditValue,
                   txtNoEntrega.Text,
                   txtCondiciones.Text,
                   etTasa.EditValue,
                   cbBodega.EditValue,
                   IIf(chkImprimirUSD.Checked, "02", MonedaBase),
                   txtComentario.Text,
                   cbCentroCosto.EditValue,
                   ACredito) Then

            'Guardar Detalle

            If GuardarDetalle() Then
                XtraMsg("Datos Actualizados con éxito!")
                Cargar()
                CalcularTotales()
            End If
        End If

    End Sub

    Function GuardarDetalle() As Boolean

        Dim result As Boolean = True

        'Agregar Nuevos Registros
        Dim _DT_NEW As DataTable = DT_Facturas.GetChanges(DataRowState.Added)
        '
        If Not _DT_NEW Is Nothing Then result = VB.SysContab.Facturas_VentasDB.SaveLineasDetalle(Factura, fecha.DateTime.Date, _DT_NEW)
        '
        'Actualizar Registro
        Dim _DT_UPD As DataTable = DT_Facturas.GetChanges(DataRowState.Modified)
        '
        If Not _DT_UPD Is Nothing Then result = VB.SysContab.Facturas_VentasDB.UpdateLineasDetalle(Factura, fecha.DateTime.Date, _DT_UPD)
        '
        'Eliminar registros
        Dim _DT_DEL As DataTable = DT_Facturas.GetChanges(DataRowState.Deleted)
        '
        If Not _DT_DEL Is Nothing Then
            For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                If IsNull(_DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)) > 0 Then

                    result = VB.SysContab.Facturas_VentasDB.DeleteLineasDetalle(_DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original),
                                                                       Factura)
                End If
            Next
        End If
        '
        'Actualizar Totales en Encabezado de la Factura.
        If (_DT_NEW Is Nothing And _DT_UPD Is Nothing And _DT_DEL Is Nothing) Then
            result = True
        Else
            result = VB.SysContab.Facturas_VentasDB.UpdateTotales(Factura)
        End If
        '
        Return result
    End Function

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        Dim fp As New Forma_PagoDB

        If DT_Header.Rows.Item(0)("Formato") = 0 Then Facturas_VentasDB.ImprimirFactura(Factura,
                                                                                        fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")))

        If DT_Header.Rows.Item(0)("Formato") <> 0 Then Facturas_VentasDB.ImprimirFactura2(Factura,
                                                                                          DT_Header.Rows.Item(0)("Formato"))

    End Sub

    'Private Sub ImprimirFactura()
    '    'Dim Cadena As String
    '    'Dim Temp As Boolean = False
    '    'Dim Data() As Byte

    '    ShowSplash("Imprimiendo...")

    '    'Try
    '    '    If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then  '' Factura de Contado
    '    '        Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 2 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '    '    Else    ' Factura de Credito
    '    '        Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 9 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '    '    End If

    '    '    Temp = True
    '    '    Dim Tamano As Integer
    '    '    Tamano = Data.GetUpperBound(0)

    '    '    If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then   '' Factura de Contado
    '    '        Cadena = Application.StartupPath & "\RptFactura.repx"
    '    '    Else    ' Factura de Credito
    '    '        Cadena = Application.StartupPath & "\RptFacturaCredito.repx"
    '    '    End If

    '    '    If File.Exists(Cadena) Then Kill(Cadena)
    '    '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '    '    Archivo.Write(Data, 0, Tamano)
    '    '    Archivo.Close()
    '    'Catch ex As Exception
    '    '    Temp = False
    '    'End Try

    '    Dim Temp As Boolean = False

    '    If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then  '' Factura de Contado
    '        Temp = db_Formatos.FormatoImpreso(2, "RptFactura")
    '    Else    ' Factura de Credito
    '        Temp = db_Formatos.FormatoImpreso(9, "RptFacturaCredito")
    '    End If

    '    Dim Rep As XtraReport

    '    If Temp = True Then
    '        If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then '' Factura de Contado
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFactura.repx", True)
    '        Else    ' Factura de Credito
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFacturaCredito.repx", True)
    '        End If
    '    Else
    '        If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then  '' Factura de Contado
    '            Rep = New RptFacturaNew
    '        Else
    '            Rep = New RptFacturaNewCredito
    '        End If
    '    End If
    '    '
    '    If fp.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then  '' Factura de Contado
    '        VistaPreviaDX(Rep,
    '                      ObtieneDatos("sp_GetRptFacturaContado", EmpresaActual, Factura, 0.00),
    '                      "Factura No. " & Factura)
    '        'Rep.DataSource = ObtieneDatos("sp_GetRptFacturaContado", EmpresaActual, Factura, 0.00)
    '    Else
    '        VistaPreviaDX(Rep,
    '                      ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00),
    '                      "Factura No. " & Factura)
    '        'Rep.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00)
    '    End If
    '    '
    '    HideSplash()

    '    'Rep.ShowPrintMarginsWarning = False
    '    'Rep.BringToFront()
    '    'Rep.ShowRibbonPreview()
    'End Sub

    'Sub ImprimirFactura2()
    '    ShowSplash("Imprimiendo...")

    '    Dim Temp As Boolean = False

    '    Try
    '        Dim Data() As Byte = CType(db_TipoFacturas.Listar(DT_Header.Rows.Item(0)("Formato")).Rows.Item(0)("Formato"), Byte())

    '        Temp = True
    '        Dim Tamano As Integer = 0
    '        Tamano = Data.GetUpperBound(0)

    '        Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()

    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim rpt As RptFacturaNew

    '    If Not Temp Then
    '        rpt = New RptFacturaNew
    '    Else
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
    '    End If
    '    '
    '    'rpt.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00)
    '    VistaPreviaDX(rpt,
    '                  ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00),
    '                  "Factura No. " & Factura)
    '    '
    '    HideSplash()
    '    'rpt.ShowPrintMarginsWarning = False
    '    'rpt.BringToFront()
    '    'rpt.ShowRibbonPreview()
    'End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub cmbvendedor_EditValueChanged(sender As Object, e As EventArgs) Handles cmbvendedor.EditValueChanged
        Try
            If IsNull(cmbvendedor.GetColumnValue("IdCentro"), 0) <> 0 Then _
                cbCentroCosto.EditValue = cmbvendedor.GetColumnValue("IdCentro")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fecha_EditValueChanged(sender As Object, e As EventArgs) Handles fecha.EditValueChanged
        Try
            etTasa.EditValue = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Me.fecha.DateTime.Date & "')").Rows.Item(0)(0)).ToString("n4")
            TCambio = etTasa.EditValue
        Catch ex As Exception
            etTasa.EditValue = 1.0
            TCambio = 1.0
        End Try
    End Sub

    Private Sub etTasa_EditValueChanged(sender As Object, e As EventArgs) Handles etTasa.EditValueChanged
        TCambio = etTasa.EditValue
    End Sub

    Private Sub vFact_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles vFact.CellValueChanged

        If e.Column.FieldName = "Item" Then
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(e.Value)

            If Not DR Is Nothing Then
                Temp = True
                'Try                    
                vFact.SetRowCellValue(e.RowHandle, "Presentacion", DR.Item("Presentacion"))
                vFact.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                vFact.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))
                vFact.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                vFact.SetRowCellValue(e.RowHandle, "Costo", DR.Item("Costo"))
                vFact.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))

                vFact.SetRowCellValue(e.RowHandle, "Existencia", IIf(DR.Item("Tipo") = "P",
                                                                     ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo.fn_CalcularExistenciaREAL('" & cbBodega.EditValue & "','" & e.Value & "'," & EmpresaActual & ") Existencia").
                                                                     Rows.Item(0)("Existencia"), 0))

                vFact.SetRowCellValue(e.RowHandle, "Despacho", 0)
                vFact.SetRowCellValue(e.RowHandle, "Cantidad", 0)
                vFact.SetRowCellValue(e.RowHandle, "Promocion", 0)
                vFact.SetRowCellValue(e.RowHandle, "Descuento", 0)
                vFact.SetRowCellValue(e.RowHandle, "Cuenta", DR.Item("Cuenta"))
                vFact.SetRowCellValue(e.RowHandle, "IvaP", DR.Item("IvaP"))
                vFact.SetRowCellValue(e.RowHandle, "Exento", DR.Item("Exento"))
                vFact.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
                vFact.SetRowCellValue(e.RowHandle, "Margen", DR.Item("Margen"))
                vFact.SetRowCellValue(e.RowHandle, "#", "")
                vFact.SetRowCellValue(e.RowHandle, "Agrupar", "")
                vFact.SetRowCellValue(e.RowHandle, "Visible", True)
                vFact.SetRowCellValue(e.RowHandle, "CABYS", DR.Item("CABYS"))
                vFact.SetRowCellValue(e.RowHandle, "NoSerie", IIf(EmpresaActual.Equals("20"), DR.Item("SAC"), String.Empty))
                '
                If DR.Item("IsProyecto") Then
                    vFact.Columns("IdProyecto").Visible = True
                    vFact.SetRowCellValue(e.RowHandle, "IdProyecto", DR.Item("IdProyecto"))
                Else
                    vFact.SetRowCellValue(e.RowHandle, "IdProyecto", 0)
                End If

                Temp = False
            End If
        End If
        '
        If e.Column.FieldName = "Despacho" And Not Temp Then
            Temp = True
            Try
                vFact.SetRowCellValue(e.RowHandle, "Cantidad", e.Value * Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))

                '*****  VALIDANDO FACTURACION CON MENOS EXITENCIA   ***********************
                If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" Then
                    'Verificar si la Cantidad a Despachar es Mayor que las existencias
                    If Me.vFact.GetRowCellValue(e.RowHandle, "Cantidad") > Me.vFact.GetRowCellValue(e.RowHandle, "Existencia") Then
                        'Verificar si la Bodega puede Facturar sin Existencia
                        If Not DetallesBodega.Fact_Sin_Existencia Then

                            If DetallesBodega.Advertencia Then  'Advertir Cuando hay menos existencia
                                If Not XtraMsg2("Esta Intentando Facturar más producto del que hay en Existencia en la bodega." & vbCrLf &
                                    "Esta Seguro que desea Continuar?") Then

                                    Try
                                        vFact.SetRowCellValue(e.RowHandle, "Despacho", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")) / Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))
                                        vFact.SetRowCellValue(e.RowHandle, "Cantidad", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")))
                                    Catch ex As Exception
                                    End Try
                                End If
                            Else    'Exigir facturar solo con existencia
                                XtraMsg("Esta Intentando Facturar más producto del que hay en Existencia en la bodega", MessageBoxIcon.Error)

                                Try
                                    vFact.SetRowCellValue(e.RowHandle, "Despacho", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")) / Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))
                                    vFact.SetRowCellValue(e.RowHandle, "Cantidad", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")))
                                Catch ex As Exception
                                End Try

                                Temp = False
                            End If
                        End If

                    End If
                End If
            Catch ex As Exception
            End Try
            Temp = False
        End If
        '
        If e.Column.FieldName = "Descuento" And Not Temp Then
            If e.Value <> 0 Then

                DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
                'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                Dim DR_PROD As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                Dim Descuento_VD As Double = 0,
                    Descuento_VH As Double = 0,
                    Descuento_GD As Double = 0,
                    Descuento_GH As Double = 0

                Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                If DT_DESCUENTO.Rows.Count > 0 Then

                    'Asignar los descuentos creados
                    Descuento_VH = DescuentoV
                    '
                    Descuento_GD = DescuentoV
                    Descuento_GH = DescuentoC

                    'Validar si existe clave creada en la tabla
                    If DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor").ToString.Trim.Length <> 0 Then

                        If Math.Round(e.Value / 100, 2) > Descuento_VH Then
                            'XtraMsg("Descuento No Autorizado!", MessageBoxIcon.Error)

                            If Math.Round(e.Value / 100, 2) > Descuento_GH Then

                                With frmAprobarPedido
                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                    .ShowDialog()

                                    If .Ok = "SI" Then
                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                        .Dispose()
                                        Exit Sub
                                    End If
                                    .Dispose()
                                End With

                            Else
                                With frmAprobarPedido
                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                    .ShowDialog()

                                    If .Ok = "SI" Then
                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                            .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                        .Dispose()
                                        Exit Sub
                                    End If
                                    .Dispose()
                                End With
                            End If
                            Exit Sub
                        End If

                    End If
                End If
Continuar:
                Temp = True
                vFact.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                Try
                    ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                    If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" And vFact.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                        'Validar si los datos se estan cargando de una Orden o Cotizacion
                        If Validar_Cotizacion Or Validar_Orden Then
                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                        Else

                            'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                            Dim DR_PROD As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                            Dim Descuento_VD As Double = 0,
                                Descuento_VH As Double = 0,
                                Descuento_GD As Double = 0,
                                Descuento_GH As Double = 0,
                                PrecioActual As Double = 0

                            PrecioActual = DR_PROD.Item("Precio")

                            'Validando que el precio en el maestro, sera mayor que cero.
                            If PrecioActual > 0 Then
                                'Validar que no se ingrese precio menor al del maestro, segun el margen
                                DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)

                                Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                                Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                                'Validar que no se ingrese precio menor al del maestro, segun el margen
                                If e.Value < PrecioActual Then

                                    If DT_DESCUENTO.Rows.Count > 0 Then
                                        'Asignar los descuentos creados
                                        Descuento_VH = DescuentoV
                                        '
                                        Descuento_GD = DescuentoV
                                        Descuento_GH = DescuentoC

                                        'Sacar la Diferencia de Precios
                                        Dim DIF As Double = Math.Round(CDbl(PrecioActual - e.Value), 2)
                                        Dim DESC As Double = Math.Round(CDbl(DIF / PrecioActual), 4)

                                        'Validar en que rango de descuento se encuentra el precio
                                        If DESC > Descuento_VH Then

                                            If DESC > Descuento_GH Then

                                                With frmAprobarPedido
                                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                                    .ShowDialog()

                                                    If .Ok = "SI" Then
                                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                            .Dispose()
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                            GoTo fin1
                                                        Else
                                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                            vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                            Temp = False
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                            .Dispose()
                                                            Exit Sub
                                                        End If
                                                    Else
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                    End If
                                                    .Dispose()
                                                End With
                                            Else
                                                With frmAprobarPedido
                                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                                    .ShowDialog()

                                                    If .Ok = "SI" Then
                                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                                            .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                            .Dispose()
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                            GoTo fin1
                                                        Else
                                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                            vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                            Temp = False
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                            .Dispose()
                                                            Exit Sub
                                                        End If
                                                    Else
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                    End If
                                                    .Dispose()
                                                End With
                                            End If
                                        Else
                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                            Temp = False
                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                    End If

                                    'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)
                                    'vFact.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                Else
                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                End If
                            Else
                                vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                            End If
                        End If
                    Else
                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                    End If

fin1:
                    Temp = False

                Catch ex As Exception
                    Temp = False
                End Try
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True

                ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" And vFact.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                    'Validar si los datos se estan cargando de una Orden o Cotizacion
                    If Validar_Cotizacion Or Validar_Orden Then
                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                    Else
                        'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                        Dim DR_PROD As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                        Dim Descuento_VD As Double = 0,
                               Descuento_VH As Double = 0,
                               Descuento_GD As Double = 0,
                               Descuento_GH As Double = 0,
                               PrecioActual As Double = 0

                        PrecioActual = DR_PROD.Item("PrecioU")

                        'Validando que el precio en el maestro, sera mayor que cero.
                        If PrecioActual > 0 Then

                            'Validar que no se ingrese precio menor al del maestro, segun el margen
                            DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
                            Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                            Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                            ''Validar que no se ingrese precio menor al del maestro, segun el margen
                            If e.Value < PrecioActual Then


                                If DT_DESCUENTO.Rows.Count > 0 Then
                                    'Asignar los descuentos creados
                                    Descuento_VH = DescuentoV
                                    '
                                    Descuento_GD = DescuentoV
                                    Descuento_GH = DescuentoC

                                    'Sacar la Diferencia de Precios
                                    Dim DIF As Double = Math.Round(CDbl(PrecioActual - e.Value), 2)
                                    Dim DESC As Double = Math.Round(CDbl(DIF / PrecioActual), 4)

                                    'Validar en que rango de descuento se encuentra el precio
                                    If DESC > Descuento_VH Then

                                        If DESC > Descuento_GH Then

                                            With frmAprobarPedido
                                                .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                                .ShowDialog()

                                                If .Ok = "SI" Then
                                                    If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                        .Dispose()
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                        GoTo Fin2
                                                    Else
                                                        XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                        .Dispose()
                                                        Exit Sub
                                                    End If
                                                Else
                                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                End If
                                                .Dispose()
                                            End With
                                        Else
                                            With frmAprobarPedido
                                                .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                                .ShowDialog()

                                                If .Ok = "SI" Then
                                                    If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                                        .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                        .Dispose()
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                        GoTo Fin2
                                                    Else
                                                        XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                        .Dispose()
                                                        Exit Sub
                                                    End If
                                                Else
                                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                End If
                                                .Dispose()
                                            End With
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                        Temp = False
                                    End If
                                Else
                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                End If
                            Else
                                vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                            End If
                        Else
                            vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                        End If

                    End If
                Else
                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                End If

Fin2:
                Temp = False
            End If
        End If

        If (e.Column.FieldName = "Precio" Or
       e.Column.FieldName = "PrecioU" Or
       e.Column.FieldName = "Cantidad" Or
       e.Column.FieldName = "Despacho" Or
       e.Column.FieldName = "IvaP" Or
       e.Column.FieldName = "Descuento") And Not Temp Then

            'e.Column.FieldName = "Exento" Or _
            'e.Column.FieldName = "Promocion") 

            vFact.SetRowCellValue(
                e.RowHandle,
                "Total",
                (IsNull(vFact.GetRowCellValue(e.RowHandle, "Cantidad"), 0)) *
                IsNull(vFact.GetRowCellValue(e.RowHandle, "Precio"), 0) -
                (IsNull(vFact.GetRowCellValue(e.RowHandle, "Cantidad"), 0) *
                IsNull(vFact.GetRowCellValue(e.RowHandle, "Precio"), 0) *
                IsNull(vFact.GetRowCellValue(e.RowHandle, "Descuento"), 0)))

            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
            Dim DR As DataRowView =
                cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

            'Dim Config As New VB.SysContab.ConfiguracionDB
            'Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            'ConfigDetalles = Config.GetConfigDetails
            'If DR.Item("Exento") = False And cmbclientes.GetColumnValue("Exento") = False Then      

            If Not DR Is Nothing Then
                'If CheckEdit2.Checked Then
                '    vFact.SetRowCellValue(e.RowHandle, "IVA", 0)
                '    vFact.SetRowCellValue(e.RowHandle, "Exento", False)
                'Else

                vFact.SetRowCellValue(
                    e.RowHandle,
                    "Exento",
                    IIf((ObtieneDatos("sp_sel_ProyectoCodigo", vFact.GetRowCellValue(e.RowHandle, "Item"), EmpresaActual).Rows.Item(0)("EsProyecto") = "SI" And
                    IsNull(vFact.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) <> 0 And
                    vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P"), False, DR.Item("Exento")))

                'vFact.SetRowCellValue(e.RowHandle, "Exento", IIf((IsNull(vFact.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) <> 0 And vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P"), False, DR.Item("Exento")))
                ' If DR.Item("Exento") = False And cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Exento") = False Then 'Me.cmbclientes.GetColumnValue("Exento") = False Then

                'If (vFact.GetRowCellValue(e.RowHandle, "IvaP") > 0 And EmpresaActual.Equals("20")) Then
                '    vFact.SetRowCellValue(e.RowHandle, "Exento", False)
                'Else
                '    vFact.SetRowCellValue(
                '        e.RowHandle,
                '        "Exento",
                '        IIf((ObtieneDatos("sp_sel_ProyectoCodigo", vFact.GetRowCellValue(e.RowHandle, "Item"), EmpresaActual).Rows.Item(0)("EsProyecto") = "SI" And IsNull(vFact.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) <> 0 And vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P"), False, DR.Item("Exento")))
                'End If

                If e.Column.FieldName = "IvaP" Then
                    If e.Value = 0.00 Then
                        vFact.SetRowCellValue(e.RowHandle, "Exento", True)
                    Else
                        vFact.SetRowCellValue(e.RowHandle, "Exento", False)
                    End If
                End If


                If vFact.GetRowCellValue(e.RowHandle, "Exento") = False And
                    cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Exento") = False Then 'Me.cmbclientes.GetColumnValue("Exento") = False Then

                    'vFact.SetRowCellValue(e.RowHandle, "IVA",
                    '                      IsNull(vFact.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0) +
                    '                      IsNull((IsNull(vFact.GetRowCellValue(e.RowHandle, "Promocion"), 0) *
                    '                      IsNull(vFact.GetRowCellValue(e.RowHandle, "Costo"), 0)) *
                    '                      (ConfigDetalles.IVA / 100.0), 0))

                    vFact.SetRowCellValue(
                         e.RowHandle,
                         "IVA",
                         IsNull(vFact.GetRowCellValue(e.RowHandle, "Total"), 0.00) *
                         (IsNull(vFact.GetRowCellValue(e.RowHandle, "IvaP"),
                                 (ConfigDetalles.IVA / 100.0)) / 100.0))

                Else
                    vFact.SetRowCellValue(e.RowHandle, "IVA", 0)
                End If
                ' End If

            End If
        End If

        vFact.UpdateTotalSummary()
    End Sub

    Private Sub cbBodega_EditValueChanged(sender As Object, e As EventArgs) Handles cbBodega.EditValueChanged
        DetallesBodega = VB.SysContab.BodegasDB.GetDetails(cbBodega.EditValue)
    End Sub

    Private Sub chkAgrupar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgrupar.CheckedChanged
        vFact.Columns("Agrupar").Visible = chkAgrupar.Checked
    End Sub

    Private Sub vFact_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles vFact.RowUpdated
        CalcularTotales()
        ValidarNumero_Item()
    End Sub
    Private Sub vFact_KeyDown(sender As Object, e As KeyEventArgs) Handles vFact.KeyDown
        If vFact.FocusedRowHandle < 0 Then Exit Sub
        ''
        If e.KeyCode = Keys.Delete Then
            vFact.DeleteRow(vFact.FocusedRowHandle)
            vFact.FocusedRowHandle = vFact.DataRowCount - 1

            'Validar si el detalle de la factura esta en Vacio
            If vFact.DataRowCount = 0 Then
                FacturarCotizacion = False
                LoadCotizacionCliente = False
                LoadOrden = False
            End If
        End If
        '
        CalcularTotales()
        ValidarNumero_Item()
    End Sub

    '
    Sub ValidarNumero_Item()
        If (LoadCotizacionCliente Or LoadOrden) Then
            Exit Sub
        Else
            Try
                Dim CantidadLineas As Double = CInt(ObtieneDatos("JAR_GetNumeroLineasFV", EmpresaActual).Rows.Item(0)(0))

                If CDbl(vFact.Columns("Item").SummaryItem.SummaryValue) >= CantidadLineas Then
                    XtraMsg("Solo se pueden Imprimir Máximo " & CantidadLineas.ToString & " Productos", MessageBoxIcon.Warning)
                    vFact.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                Else
                    vFact.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub CalcularTotales()
        lblsubtotal.Text = FormatNumber(vFact.Columns("Total").SummaryItem.SummaryValue, 2)
        lbliva.Text = FormatNumber(vFact.Columns("IVA").SummaryItem.SummaryValue, 2)
        lbltotal.Text = FormatNumber(CDbl(lblsubtotal.Text) + CDbl(lbliva.Text), 2)
        lbltotalU.Text = FormatNumber(CDbl(lbltotal.Text) / etTasa.EditValue, 2)
    End Sub

    Private Sub cbProducto_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbProducto.ButtonClick
        If vFact.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.Button.Index = 1 Then
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))

            With frmDetalleVentas_Lineas
                .Text = "Detalle de ITEM: " & DR.Item("Nombre")
                .txtModelo.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Modelo"), "")
                .txtNoSerie.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "NoSerie"), "")
                .txtComentario.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Comentario"), "")
                .ShowDialog()

                If .Ok Then
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Modelo", .txtModelo.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "NoSerie", .txtNoSerie.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Comentario", .txtComentario.Text)
                End If
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        MostrarDatosCliente()
    End Sub

    Sub MostrarDatosCliente()
        Try
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

            cmbformapago.EditValue = CInt(DetallesCliente.Cod_Forma_Pago)         'Me.cmbclientes.GetColumnValue("FormaPago")
            cmbvendedor.EditValue = CInt(DetallesCliente.Vendedor)               'Me.cmbclientes.GetColumnValue("Vendedor")

            If cmbformapago.GetColumnValue("Dias") > 0 Then txtNombreDe.Text = DetallesCliente.Nombre
            If cmbformapago.GetColumnValue("Dias") = 0 Then txtNombreDe.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmFacturasVentasEditar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then vFact.ShowCustomization()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(GridDetalle, $"Detalle de Factura {txtfactura.Text}")
    End Sub
End Class