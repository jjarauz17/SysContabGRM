Imports SysContab.VB.SysContab
Public Class frmSaldoInventarios

    Dim ArticulosCC As New VB.SysContab.GruposCCDB
    Dim Articulos As New VB.SysContab.ArticulosDB
    Dim Codigo_Bodega As String

    'Dim Cierre As Integer = 0, Fecha_Cierre As Object = vbNullString

    Private Sub frmSaldoInventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        'VerificarCierre()
        Dim UltimoCierre As Date = UltimoCierreInventario().Date
        '
        Desde.EditValue = New DateTime(UltimoCierre.AddDays(1).Date.Year, UltimoCierre.AddDays(1).Date.Month, 1).Date
        Hasta.EditValue = UltimoDiaDelMes(UltimoCierre.AddDays(1).Date).Date
        '
        'Desde.EditValue = New DateTime(f.Year, f.Month, 1)
        'Hasta.EditValue = f.Date
        ''
        GetBodegasxUsuario(cbBodegas)
        'GetMonedasList(cbMoneda)
        'GetBodegasList(cbBodegas)
        ' GetBodegasList_Inventario(cbBodega)
        GeMovimientos_Clases(cbMovimientos)
        CargarProductos()

        iGrid.DataSource = ObtieneDatos("SP_GeneralSaldosInventarioxBodega",
                                           Desde.DateTime.Date,
                                           Hasta.DateTime.Date,
                                           rgInventario.EditValue,
                                           rgTipo.EditValue,
                                           "XXX",
                                           cbMovimientos.EditValue,
                                           "XXXXX",
                                           EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(Me.iVista)
        '
        FormatoColumnasGrid()

        LeerEsquemaInicial(Me.Name,
                           Me.Text,
                           iVista)
        '
        'cbBodega.ItemIndex = 1
    End Sub

    Sub CargarProductos()
        If Me.rgTipo.EditValue = "P" Then
            'cbProductos.Properties.DataSource = Articulos.ProductosGetLista("P").Tables("Articulos").DefaultView
            'cbProductos.Properties.DisplayMember = "Nombre"
            'cbProductos.Properties.ValueMember = "Codigo"
            'cbProductos.Properties.PopulateColumns()

            GridLookUp(cbItemProductos, Articulos.ProductosGetLista("P").Tables("Articulos"))
        Else
            GridLookUp(cbItemProductos, ArticulosCC.ArticulosCCInvent().Tables("GruposCC"))

            'Me.cbProductos.Properties.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbProductos.Properties.DisplayMember = "Nombre"
            'Me.cbProductos.Properties.ValueMember = "Codigo"
            'Me.cbProductos.Properties.PopulateColumns()
        End If
        '
        'For i As Integer = 0 To Me.cbProductos.Properties.Columns.Count - 1
        '    Me.cbProductos.Properties.Columns(i).Visible = False
        'Next
        ''
        'Me.cbProductos.Properties.Columns("Codigo").Visible = True
        'Me.cbProductos.Properties.Columns("Nombre").Visible = True
        'Me.cbProductos.EditValue = Nothing
    End Sub

    'Sub VerificarCierre()

    '    Try
    '        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

    '        Conn.RemoveParameters()
    '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Desde.DateTime.Date)
    '        Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

    '        Conn.EjecutarComando("JAR_GetUltimoCierre")

    '        Cierre = Conn.GetParameter("Cierre").Valor
    '        Fecha_Cierre = IsNull(Conn.GetParameter("Fecha").Valor, VB.SysContab.Rutinas.Fecha().Date)

    '        'If Cierre = 0 Then
    '        '    XtraMsg("No se ha Realizado el Cierre de Inventario", MessageBoxIcon.Error)
    '        '    Exit Sub
    '        'Else
    '        '    Dim Fecha_Cierre As Object = IsNull(Conn.GetParameter("Fecha").Valor, "")
    '        '    '
    '        '    If Desde.DateTime.Date < CDate(Fecha_Cierre) Then
    '        '        XtraMsg("La Fecha Solicitada es Menor al Ultimo Cierre de Inventario..." & vbCrLf &
    '        '                "Ultimo Cierre de Inventario: " & Fecha_Cierre.Date.ToShortDateString)
    '        '        Exit Sub
    '        '    End If
    '        'End If
    '    Catch ex As Exception
    '        Cierre = 0
    '        Fecha_Cierre = VB.SysContab.Rutinas.Fecha().Date
    '    End Try

    'End Sub

    'Sub LeerEsquemaInicial()
    '    ''Borrar Archivo, para evitar cache
    '    If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
    '        Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    End If
    '    '
    '    ''Guardar Configuracion Inicial
    '    vInvent.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    db_Esquemas.GuardarInicial(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    '
    '    ValidarGridSchema(vInvent, Me.Name)
    'End Sub

    Private Sub rgTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipo.SelectedIndexChanged
        CargarProductos()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If cbBodegas.EditValue Is Nothing Or cbBodegas.EditValue = "" Then
            XtraMsg("Seleccione Bodega!")
            cbBodegas.Focus()
            Exit Sub
        End If
        '
        Dim variables As New ArrayList, datos As New ArrayList
        '
        variables.Add("Desde")
        variables.Add("Hasta")
        variables.Add("Tipo")
        variables.Add("TipoInvent")
        variables.Add("Bodega")
        variables.Add("TMov")
        variables.Add("Item")
        variables.Add("Empresa")
        '
        datos.Add(Desde.DateTime.Date)
        datos.Add(Hasta.DateTime.Date)
        datos.Add(rgInventario.EditValue)
        datos.Add(rgTipo.EditValue)
        datos.Add(cbBodegas.EditValue)
        datos.Add(cbMovimientos.EditValue)
        datos.Add(IIf(CheckEdit1.Checked, IIf(Me.cbItemProductos.EditValue Is Nothing, "%", Me.cbItemProductos.EditValue), "%"))
        datos.Add(EmpresaActual)

        ShowSplash("Calculando Saldos...")
        'Dim dt As DataTable = ProcedureParameters(datos, variables, "SP_GeneralSaldosInventario")

        Dim DT As DataTable = ProcedureParameters(datos, variables, "SP_GeneralSaldosInventarioxBodega")
        Me.iGrid.DataSource = DT
        'vInvent.PopulateColumns()
        'FormatoGrid(Me.vInvent)
        ''
        'FormatoColumnasGrid()

        HideSplash()
    End Sub

    Sub FormatoColumnasGrid()

        Dim rUrl As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rUrl.Caption = "Url"

        Dim rVer As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rVer.Caption = "Ver"

        Me.iVista.Columns("SALDO INI").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.iVista.Columns("SALDO INI").DisplayFormat.FormatString = "{0:n4}"
        Me.iVista.Columns("SALDO INI").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.iVista.Columns("SALDO INI").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.iVista.Columns("COMPRAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.iVista.Columns("COMPRAS").DisplayFormat.FormatString = "{0:n4}"
        Me.iVista.Columns("COMPRAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.iVista.Columns("COMPRAS").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.iVista.Columns("SALDO FIN").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.iVista.Columns("SALDO FIN").DisplayFormat.FormatString = "{0:n4}"
        Me.iVista.Columns("SALDO FIN").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.iVista.Columns("SALDO FIN").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.iVista.Columns(" ").ColumnEdit = rUrl
        Me.iVista.Columns(" ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Columns("  ").ColumnEdit = rVer
        Me.iVista.Columns("  ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Me.iVista.Columns("CODIGO_BODEGA").Visible = False
        Me.iVista.Columns("URL").Visible = False
        Me.iVista.Columns("VENTAS CONT").Visible = False
        Me.iVista.Columns("VENTAS CR").Visible = False
        Me.iVista.Columns("CODIGO_PARTE").Visible = False
        Me.iVista.Columns("DESCRIPCION_PROVEEDOR").Visible = False
        Me.iVista.Columns("MODELO").Visible = False
        Me.iVista.Columns("FABRICANTE").Visible = False
        Me.iVista.Columns("SUBGRUPO").Visible = False
        Me.iVista.Columns("AJUSTES").Visible = False
        Me.iVista.Columns("UNITARIO U$").Visible = False
        Me.iVista.Columns("COSTO PROMEDIO").Visible = False
        Me.iVista.Columns("OBSOLETO").Visible = False

        If rgInventario.EditValue = 1 Or rgInventario.EditValue = 3 Then  ''Inventario Pendiente de Procesar
            '
            Me.iVista.Columns("VENTAS CONT").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("VENTAS CONT").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("VENTAS CONT").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("VENTAS CONT").SummaryItem.DisplayFormat = "{0:n4}"
            '
            Me.iVista.Columns("VENTAS CR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("VENTAS CR").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("VENTAS CR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("VENTAS CR").SummaryItem.DisplayFormat = "{0:n4}"
            '
            Me.iVista.Columns("VENTAS TOTALES").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("VENTAS TOTALES").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("VENTAS TOTALES").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("VENTAS TOTALES").SummaryItem.DisplayFormat = "{0:n4}"
            '            
            '
            Me.iVista.Columns("TRASLADOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("TRASLADOS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("TRASLADOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("TRASLADOS").SummaryItem.DisplayFormat = "{0:n4}"
            '
            Me.iVista.Columns("CREDITOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("CREDITOS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("CREDITOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("CREDITOS").SummaryItem.DisplayFormat = "{0:n4}"
            '
            Me.iVista.Columns("DEBITOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("DEBITOS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("DEBITOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("DEBITOS").SummaryItem.DisplayFormat = "{0:n4}"
            '
            Me.iVista.Columns("AJUSTES").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("AJUSTES").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("AJUSTES").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("AJUSTES").SummaryItem.DisplayFormat = "{0:n4}"
            '
        ElseIf rgInventario.EditValue = 2 Then   ''Inventario Procesado
            Me.iVista.Columns("ENTRADAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("ENTRADAS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("ENTRADAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("ENTRADAS").SummaryItem.DisplayFormat = "{0:n4}"
            ''
            Me.iVista.Columns("SALIDAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("SALIDAS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("SALIDAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("SALIDAS").SummaryItem.DisplayFormat = "{0:n4}"
            ''
            Me.iVista.Columns("VENTAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("VENTAS").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("VENTAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("VENTAS").SummaryItem.DisplayFormat = "{0:n4}"
            ''
            Me.iVista.Columns("PRECIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("PRECIO").DisplayFormat.FormatString = "{0:n4}"
            Me.iVista.Columns("PRECIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("PRECIO").SummaryItem.DisplayFormat = "{0:n4}"
            ''
            Me.iVista.Columns("COSTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("COSTO").DisplayFormat.FormatString = "{0:n6}"
            Me.iVista.Columns("COSTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("COSTO").SummaryItem.DisplayFormat = "{0:n6}"
            ''
            Me.iVista.Columns("COSTO_PROMEDIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.iVista.Columns("COSTO_PROMEDIO").DisplayFormat.FormatString = "{0:n6}"
            Me.iVista.Columns("COSTO_PROMEDIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.iVista.Columns("COSTO_PROMEDIO").SummaryItem.DisplayFormat = "{0:n6}"

            Me.iVista.Columns("PRECIO").Visible = False
            Me.iVista.Columns("COSTO").Visible = False
            Me.iVista.Columns("COSTO_PROMEDIO").Visible = False
        End If

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.iGrid)

        'Dim xl As New DevExpress.XtraPrinting.XlsxExportOptions
        'xl.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value
        'xl.ShowGridLines = False
        'dgInvent.ExportToPdf("C:\xls\prueba1.xlsx")
        'vInvent.ExportToXlsx("C:\xls\prueba2.xlsx")        

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub vInvent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles iVista.DoubleClick
        If Me.iVista.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        '       
        With frmOpcionesInventarioDetalle
            .frm = "SALDOS"
            .Saldo = iVista.GetFocusedRowCellValue("SALDO FIN")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        cbItemProductos.Enabled = CheckEdit1.Checked
    End Sub

    Private Sub bGuardaEsquema_Click(sender As Object, e As EventArgs) Handles bGuardaEsquema.Click
        Try
            ''Borrar Archivo, para evitar cache
            If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
                Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
            End If

            ''Verificar Configuracion Inicial
            If db_Esquemas.GetEsquema(Me.Name, 1).Rows.Count = 0 Then
                ''Guardar Configuracion Inicial
                iVista.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 1)
            Else
                iVista.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 0)
            End If

            XtraMsg("Esquema Guardado!")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bRestauraEsquema_Click(sender As Object, e As EventArgs) Handles bRestauraEsquema.Click
        db_Esquemas.Borrar(Me.Name, 0)
        ValidarGridSchema(iVista, Me.Name)
        ' ValidarAccesos()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked Then iVista.ShowCustomization()
        If Not CheckEdit2.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub vInvent_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit2.Checked = False
    End Sub

    Private Sub vInvent_Click(sender As Object, e As EventArgs) Handles iVista.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If iVista.FocusedColumn.FieldName = " " Then
            If iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL").ToString().Length > 0 Then
                Try
                    Process.Start(iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL"))
                Catch ex As Exception
                    XtraMsg("URL inv�lida: " + ex.Message, MessageBoxIcon.Error)
                End Try
            End If
        End If

        If iVista.FocusedColumn.FieldName = "  " Then
            With frmProductoDetalle
                .Text = "Producto: " + iVista.GetFocusedRowCellValue("ITEM") + "  " + iVista.GetFocusedRowCellValue("DESCRIPCION")
                .Codigo = iVista.GetFocusedRowCellValue("ITEM")
                .Tipo = "P"
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub
End Class

