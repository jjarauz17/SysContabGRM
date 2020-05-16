Public Class frmDetalleMovimiento 

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub frmDetalleMovimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub frmDetalleMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormatoGrid(vDatos, 4, 0, False, False, True)
        'FormatoGrid(vDatos)
        Me.vDatos.Columns("BODEGA").Visible = False
        ' Me.vDatos.BestFitColumns()
    End Sub

    Public Sub GridVentas()
        Me.vDatos.Columns("CONTADO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CONTADO").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("CONTADO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("CONTADO").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.vDatos.Columns("CREDITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("CREDITO").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("CREDITO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("CREDITO").SummaryItem.DisplayFormat = "{0:n4}"
        ''
        Me.vDatos.Columns("VENTA TOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("VENTA TOTAL").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("VENTA TOTAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("VENTA TOTAL").SummaryItem.DisplayFormat = "{0:n4}"
    End Sub

    Public Sub GridCompras()
        Me.vDatos.Columns("COMPRAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COMPRAS").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("COMPRAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("COMPRAS").SummaryItem.DisplayFormat = "{0:n4}"
        ''        
    End Sub

    Public Sub GridMovimientos()

        Me.vDatos.Columns("COMPRAS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COMPRAS").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("COMPRAS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("COMPRAS").SummaryItem.DisplayFormat = "{0:n4}"
        ''        
        Me.vDatos.Columns("TRASLADOS").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("TRASLADOS").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("TRASLADOS").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("TRASLADOS").SummaryItem.DisplayFormat = "{0:n4}"
        ''        
        Me.vDatos.Columns("NOTA DE CREDITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("NOTA DE CREDITO").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("NOTA DE CREDITO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("NOTA DE CREDITO").SummaryItem.DisplayFormat = "{0:n4}"
        ''        
        Me.vDatos.Columns("NOTA DE DEBITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("NOTA DE DEBITO").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("NOTA DE DEBITO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("NOTA DE DEBITO").SummaryItem.DisplayFormat = "{0:n4}"
        ''        
        Me.vDatos.Columns("AJUSTES").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("AJUSTES").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("AJUSTES").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("AJUSTES").SummaryItem.DisplayFormat = "{0:n4}"
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked Then Me.vDatos.ColumnsCustomization()
        If Not Me.CheckEdit1.Checked Then Me.vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        Me.CheckEdit1.Checked = False
    End Sub
End Class