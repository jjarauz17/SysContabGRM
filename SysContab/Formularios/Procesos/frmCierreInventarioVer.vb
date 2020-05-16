Public Class frmCierreInventarioVer

#Region "Movimientos"

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub
    Private Sub iGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown

        If e.Control = True Then
            If e.KeyCode = Keys.Up Then
                iVista.FocusedRowHandle = 1
            End If

            If e.KeyCode = Keys.Down Then
                iVista.FocusedRowHandle = iVista.RowCount - 1
            End If

            If e.KeyCode = Keys.Left Then
                iVista.FocusedColumn = iVista.VisibleColumns(1)
            End If

            If e.KeyCode = Keys.Right Then
                iVista.FocusedColumn = iVista.VisibleColumns(iVista.VisibleColumns.Count - 2)
            End If
        End If

        If e.Control AndAlso e.KeyCode = Keys.C Then
            Clipboard.SetText(iVista.GetFocusedDisplayText())
            e.Handled = True
        End If

    End Sub
#End Region

    Public Fecha_Cierre As Date
    Public Numero As Integer = 0
    Public vPrevia As Integer = 0

    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails


    Private Sub frmCierreVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowSplash("Cargando Cierre...")
        '
        'iGrid.DataSource = ObtieneDatos("sp_proc_temp_Igor", EmpresaActual)

        'iGrid.DataSource = ObtieneDatos("sp_clientes_ramac_crm_jorge_padilla", EmpresaActual)
        'iGrid.DataSource = ObtieneDatos("JAR_FacturasVentasCrossTab_ZOHO", EmpresaActual)
        'iVista.PopulateColumns()
        'FormatoGrid(iVista, 4)

        'HideSplash()
        '' iGrid.DataSource = ObtieneDatos("SELECT * FROM BODEGAS_ARTICULOS_006")
        'iGrid.DataSource = ObtieneDatos("SELECT CODIGO, NOMBRE, CONTACTO, CARGO, TELEFONO_CONTACTO, CELULAR_CONTACTO, EMAIL_CONTACTO, GERENTE, TELEFONO_GERENTE, CELULAR_GERENTE, EMAIL_GERENTE, " & _
        '"CONTADOR, TELEFONO_CONTADOR, CELULAR_CONTADOR, EMAIL_CONTADOR, DIRECCION, Pais_Id, DEPARTAMENTO, MUNICIPIO, CIUDAD, TELEFONO, FAX, CORREO, RUC, TIPO, COD_ZONA," & _
        '"COD_FORMA_PAGO, DESC_PROD, DESC_SERV, DESC_ADICIONAL, LIMITE_CREDITO, VENDEDOR, CUENTA, Excento, TipoCliente, Retenedor, Fecha_Creacion, EMPRESA, TipoIVA_ID, Retenedor_Alcaldia," & _
        '"Cedula, CodigoLetra, Empleado, Garantia, CodConsecutPorcentaje, Categoria, Moneda, ValidarLimite, SucursalCliente, Varios, Comentarios, Registro, Usuario, ACTIVO " & _
        '"FROM            dbo.CLIENTES AS c WHERE EMPRESA = 7 ORDER BY CODIGO")
        'iVista.PopulateColumns()
        'FormatoGrid(iVista, 4)
        '
        'iGrid.DataSource = ObtieneDatos("sp_antiguedad_por_periodo", EmpresaActual, "01/01/2016", "31/12/2016", "31/03/2017", "02", 1, "%", "LE, ES, JE, MT, MA, CH, MY, RI, JI, SE, OC, JP, ML")
        'iVista.PopulateColumns()
        'FormatoGrid(iVista, 4)

        ' Exit Sub

        If vPrevia = 0 Then iGrid.DataSource = db_CierresInventario.Listar(Numero, vPrevia)
        If vPrevia <> 0 Then iGrid.DataSource = db_CierresInventario.ListarPrevio(New DateTime(Fecha_Cierre.Year, Fecha_Cierre.Month, 1), Fecha_Cierre)

        iVista.PopulateColumns()
        FormatoGrid(iVista, 6, 0, False)

        Dim rUrl As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rUrl.Caption = "Url"

        Dim rVer As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rVer.Caption = "Ver"

        If vPrevia = 0 Then
            iVista.Columns("URL").Visible = False
            '
            iVista.Columns(" ").ColumnEdit = rUrl
            iVista.Columns(" ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            iVista.Columns("  ").ColumnEdit = rVer
            iVista.Columns("  ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End If

        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
        iVista.Columns("SubGrupo").Visible = False
        iVista.Columns("Ultima Entrada").Visible = False
        iVista.Columns("Ultima Salida").Visible = False
        iVista.Columns("U/M").Visible = False
        iVista.Columns("Cuenta").Visible = False

        iVista.Columns("Inicial").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Inicial").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        iVista.Columns("Inicial").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Inicial").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        ''
        iVista.Columns("Entradas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Entradas").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        iVista.Columns("Entradas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Entradas").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        ''
        iVista.Columns("Salidas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Salidas").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        iVista.Columns("Salidas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Salidas").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        ''
        iVista.Columns("Final").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Final").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        iVista.Columns("Final").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Final").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

        iVista.Columns("Costo Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Costo Promedio").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        ''
        iVista.Columns("Costo Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Costo Total").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        iVista.Columns("Costo Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Costo Total").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
        ''
        HideSplash()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_Click(sender As Object, e As EventArgs) Handles iVista.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If iVista.FocusedColumn.FieldName = " " Then
            If iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL").ToString().Length > 0 Then
                Try
                    Process.Start(iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL"))
                Catch ex As Exception
                    XtraMsg("URL inválida: " + ex.Message, MessageBoxIcon.Error)
                End Try
            End If
        End If
        '
        If iVista.FocusedColumn.FieldName = "  " Then
            With frmProductoDetalle
                .Text = "Producto: " + iVista.GetFocusedRowCellValue("Codigo") + "  " + iVista.GetFocusedRowCellValue("Descripcion")
                .Codigo = iVista.GetFocusedRowCellValue("Codigo")
                .Tipo = "P"
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub
End Class