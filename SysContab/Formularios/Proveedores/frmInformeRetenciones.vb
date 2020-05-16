Public Class frmInformeRetenciones

    Private Sub frmTipoMovimientosInvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        dDesde.DateTime = New DateTime(f.Year, f.Month, 1)
        dHasta.DateTime = f.Date
    End Sub

    Public Sub Cargar()
        dgDatos.DataSource = ObtieneDatos("JAR_GetInformeRetenciones",
                                          Desde.DateTime.Date,
                                          Hasta.DateTime.Date,
                                          EmpresaActual)
        vDatos.PopulateColumns()
        FormatoGrid(vDatos, 2, 0, False, True, True)
        '
        For i As Integer = 0 To vDatos.Columns.Count - 1
            vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        vDatos.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        '
        vDatos.Columns("Mes").Visible = False
        vDatos.Columns("Per_Id").Visible = False
        vDatos.Columns("Tipo").Visible = False
        vDatos.Columns("IdComprobante").Visible = False
        vDatos.Columns("Proveedor_ID").Visible = False
        vDatos.Columns("CDet_Id").Visible = False

        'vDatos.Columns("SubTotal IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("SubTotal IR").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("SubTotal IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("SubTotal IR").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'vDatos.Columns("Total Factura").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("Total Factura").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("Total Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("Total Factura").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'vDatos.Columns("Pago").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("Pago").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("Pago").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("Pago").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'vDatos.Columns("Total IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("Total IR").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("Total IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("Total IR").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'vDatos.Columns("Porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("Porcentaje").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("Porcentaje").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("Porcentaje").SummaryItem.DisplayFormat = "{0:n2}"

        'vDatos.Columns("IR Pagado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vDatos.Columns("IR Pagado").DisplayFormat.FormatString = "{0:n2}"
        'vDatos.Columns("IR Pagado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'vDatos.Columns("IR Pagado").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos, "Informe de Retenciones", "Al " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then vDatos.ShowCustomization()
        If Not CheckEdit1.Checked Then vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Marcar()
    End Sub

    Sub Marcar()
        For i As Integer = 0 To vDatos.DataRowCount - 1
            vDatos.SetRowCellValue(i, "Seleccionar", CheckEdit2.Checked)
        Next
        vDatos.RefreshData()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If Not XtraMsg2("Esta Seguro que Desea reportar este Informe de Retenciones?") Then
            Exit Sub
        End If

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            ShowSplash("Guardando...")

            For i As Integer = 0 To vDatos.DataRowCount - 1

                If vDatos.GetRowCellValue(i, "Seleccionar") Then
                    Conn.RemoveParameters()

                    Conn.AddParameter("IdDocumento",
                                      SqlDbType.Int,
                                      5,
                                      ParameterDirection.Input,
                                      vDatos.GetRowCellValue(i, "IdComprobante"))

                    Conn.AddParameter("Tipo",
                                      SqlDbType.Int,
                                      5,
                                      ParameterDirection.Input,
                                      vDatos.GetRowCellValue(i, "Tipo"))

                    Conn.AddParameter("Empresa",
                                      SqlDbType.Int,
                                      5,
                                      ParameterDirection.Input,
                                      EmpresaActual)
                    '
                    Conn.EjecutarComando("JAR_GuardarRetencionesReportadas")
                End If
            Next

            Conn.CompletarTransaccion()
            HideSplash()
            '
            Buscar()
            Marcar()
        Catch ex As Exception
            Conn.AnularTransaccion()
            HideSplash()
        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, "Informe de Retenciones Reportadas", "Del " & dDesde.DateTime.ToShortDateString & "Al " & dHasta.DateTime.ToShortDateString)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        BuscarReportadas()
    End Sub

    Private Sub BuscarReportadas()
        ShowSplash()
        Cargar2()
        HideSplash()
    End Sub

    Public Sub Cargar2()
        iGrid.DataSource =
            ObtieneDatos("JAR_GetInformeRetencionesReportadas",
                         dDesde.DateTime.Date,
                         dHasta.DateTime.Date,
                         EmpresaActual)

        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, True, True)
        '
        iVista.Columns("Mes").Visible = False
        iVista.Columns("Per_Id").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("IdComprobante").Visible = False

        iVista.Columns("SubTotal IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("SubTotal IR").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("SubTotal IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("SubTotal IR").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Total Factura").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Total Factura").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("Total Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Total Factura").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Pago").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Pago").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("Pago").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Pago").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Total IR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Total IR").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("Total IR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Total IR").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Porcentaje").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Porcentaje").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("Porcentaje").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Porcentaje").SummaryItem.DisplayFormat = "{0:n2}"

        iVista.Columns("IR Pagado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("IR Pagado").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("IR Pagado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("IR Pagado").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub bFormato_Click(sender As Object, e As EventArgs) Handles bFormato.Click

    End Sub
End Class