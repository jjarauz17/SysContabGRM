<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEstadoResultadoPorLinea
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.iPivotMes = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.pivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.pivotGridField2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.pivotGridField3 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Fecha, Me.Moneda, Me.XrPageInfo4, Me.XrPageInfo3, Me.Titulo, Me.Empresa})
        Me.ReportHeader.HeightF = 100.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.0001192093!, 54.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Empresa"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Moneda")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0!, 36.0!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "Empresa"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo4.Format = "{0:hh:mm tt}"
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(976.0398!, 18.0!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.StylePriority.UseTextAlignment = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(976.04!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TituloReporte")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001192093!, 18.0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "Empresa"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.iPivotMes})
        Me.GroupHeader1.HeightF = 182.2917!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'iPivotMes
        '
        Me.iPivotMes.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3})
        Me.iPivotMes.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0!)
        Me.iPivotMes.Name = "iPivotMes"
        Me.iPivotMes.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.iPivotMes.SizeF = New System.Drawing.SizeF(1050.0!, 122.9167!)
        '
        'pivotGridField1
        '
        Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pivotGridField1.AreaIndex = 0
        Me.pivotGridField1.Caption = "Tipo"
        Me.pivotGridField1.FieldName = "Tipo"
        Me.pivotGridField1.Name = "pivotGridField1"
        '
        'pivotGridField2
        '
        Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.pivotGridField2.AreaIndex = 0
        Me.pivotGridField2.Caption = "Linea"
        Me.pivotGridField2.FieldName = "Nombre"
        Me.pivotGridField2.Name = "pivotGridField2"
        '
        'pivotGridField3
        '
        Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.pivotGridField3.AreaIndex = 0
        Me.pivotGridField3.Caption = "Saldo Mes"
        Me.pivotGridField3.FieldName = "Saldo"
        Me.pivotGridField3.Name = "pivotGridField3"
        Me.pivotGridField3.TotalValueFormat.FormatString = "{0:n2}"
        Me.pivotGridField3.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rptEstadoResultadoPorLinea
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents iPivotMes As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents pivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents pivotGridField2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents pivotGridField3 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
End Class
