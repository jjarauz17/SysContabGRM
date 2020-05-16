<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProduccionDevoluciones
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Presentacion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Unidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cantidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Costo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lbltitulo = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre, Me.Presentacion, Me.Unidad, Me.Cantidad, Me.Costo, Me.Total})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.Black
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(1.765106!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(291.8697!, 20.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseForeColor = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Presentacion
        '
        Me.Presentacion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Presentacion")})
        Me.Presentacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Presentacion.ForeColor = System.Drawing.Color.Black
        Me.Presentacion.LocationFloat = New DevExpress.Utils.PointFloat(392.811!, 0!)
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Presentacion.SizeF = New System.Drawing.SizeF(128.829!, 20.0!)
        Me.Presentacion.StylePriority.UseFont = False
        Me.Presentacion.StylePriority.UseForeColor = False
        Me.Presentacion.StylePriority.UseTextAlignment = False
        Me.Presentacion.Text = "Presentacion"
        Me.Presentacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Unidad
        '
        Me.Unidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unidad")})
        Me.Unidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad.ForeColor = System.Drawing.Color.Black
        Me.Unidad.LocationFloat = New DevExpress.Utils.PointFloat(293.6348!, 0!)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Unidad.SizeF = New System.Drawing.SizeF(99.17621!, 20.0!)
        Me.Unidad.StylePriority.UseFont = False
        Me.Unidad.StylePriority.UseForeColor = False
        Me.Unidad.StylePriority.UseTextAlignment = False
        Me.Unidad.Text = "Unidad"
        Me.Unidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cantidad
        '
        Me.Cantidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad", "{0:n4}")})
        Me.Cantidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.LocationFloat = New DevExpress.Utils.PointFloat(521.6401!, 0!)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cantidad.SizeF = New System.Drawing.SizeF(83.52338!, 20.0!)
        Me.Cantidad.StylePriority.UseFont = False
        Me.Cantidad.StylePriority.UseForeColor = False
        Me.Cantidad.StylePriority.UseTextAlignment = False
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Costo
        '
        Me.Costo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Costo", "{0:n4}")})
        Me.Costo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costo.ForeColor = System.Drawing.Color.Black
        Me.Costo.LocationFloat = New DevExpress.Utils.PointFloat(605.1635!, 0!)
        Me.Costo.Name = "Costo"
        Me.Costo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Costo.SizeF = New System.Drawing.SizeF(93.17621!, 20.0!)
        Me.Costo.StylePriority.UseFont = False
        Me.Costo.StylePriority.UseForeColor = False
        Me.Costo.StylePriority.UseTextAlignment = False
        Me.Costo.Text = "Cantidad"
        Me.Costo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Total
        '
        Me.Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n4}")})
        Me.Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Black
        Me.Total.LocationFloat = New DevExpress.Utils.PointFloat(698.5889!, 0!)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.SizeF = New System.Drawing.SizeF(99.64606!, 20.0!)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseForeColor = False
        Me.Total.StylePriority.UseTextAlignment = False
        Me.Total.Text = "Cantidad"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbltitulo})
        Me.PageHeader.HeightF = 17.25!
        Me.PageHeader.Name = "PageHeader"
        '
        'lbltitulo
        '
        Me.lbltitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Black
        Me.lbltitulo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbltitulo.SizeF = New System.Drawing.SizeF(293.6348!, 17.25!)
        Me.lbltitulo.StylePriority.UseFont = False
        Me.lbltitulo.StylePriority.UseForeColor = False
        Me.lbltitulo.Text = "Detalle de Devoluciones/Averias"
        '
        'rptProduccionDevoluciones
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Presentacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Unidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cantidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Costo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbltitulo As DevExpress.XtraReports.UI.XRLabel
End Class
