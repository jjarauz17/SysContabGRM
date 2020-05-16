<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rtpCodigoBarra
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Compra = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ubicacion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.Codigo = New DevExpress.XtraReports.UI.XRLabel()
        Me.CodigoBarra = New DevExpress.XtraReports.UI.XRBarCode()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Empresa, Me.Compra, Me.Ubicacion, Me.Nombre, Me.XrLine2, Me.Codigo, Me.CodigoBarra})
        Me.Detail.HeightF = 134.0!
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnCount = 4
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 8.0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(192.0!, 18.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Codigo"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Compra
        '
        Me.Compra.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Compra")})
        Me.Compra.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compra.LocationFloat = New DevExpress.Utils.PointFloat(103.125!, 60.0!)
        Me.Compra.Name = "Compra"
        Me.Compra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Compra.SizeF = New System.Drawing.SizeF(96.875!, 18.0!)
        Me.Compra.StylePriority.UseFont = False
        Me.Compra.StylePriority.UseTextAlignment = False
        Me.Compra.Text = "Nombre"
        Me.Compra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ubicacion
        '
        Me.Ubicacion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ubicacion")})
        Me.Ubicacion.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ubicacion.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 60.0!)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ubicacion.SizeF = New System.Drawing.SizeF(95.12501!, 18.0!)
        Me.Ubicacion.StylePriority.UseFont = False
        Me.Ubicacion.StylePriority.UseTextAlignment = False
        Me.Ubicacion.Text = "Nombre"
        Me.Ubicacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 42.0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(192.0!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(200.0!, 8.0!)
        '
        'Codigo
        '
        Me.Codigo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Codigo")})
        Me.Codigo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 25.0!)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Codigo.SizeF = New System.Drawing.SizeF(192.0!, 18.0!)
        Me.Codigo.StylePriority.UseFont = False
        Me.Codigo.StylePriority.UseTextAlignment = False
        Me.Codigo.Text = "Codigo"
        Me.Codigo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoModule = True
        Me.CodigoBarra.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.CodigoBarra.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.CodigoBarra.BorderWidth = 1
        Me.CodigoBarra.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CodigoBarra")})
        Me.CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 92.0!)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.CodigoBarra.ShowText = False
        Me.CodigoBarra.SizeF = New System.Drawing.SizeF(192.0!, 42.0!)
        Me.CodigoBarra.StylePriority.UseBorderColor = False
        Me.CodigoBarra.StylePriority.UseBorders = False
        Me.CodigoBarra.StylePriority.UseBorderWidth = False
        Me.CodigoBarra.StylePriority.UseFont = False
        Me.CodigoBarra.StylePriority.UseTextAlignment = False
        Me.CodigoBarra.Symbology = Code128Generator1
        Me.CodigoBarra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 15.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 10.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 10.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'rtpCodigoBarra
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.Version = "13.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents CodigoBarra As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Codigo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Ubicacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Compra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
