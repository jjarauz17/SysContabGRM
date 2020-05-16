<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLetraCambio
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
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EmpresaN = New DevExpress.XtraReports.UI.XRLabel()
        Me.FechaNombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.VencimientoNombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.ANombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
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
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.EmpresaN, Me.FechaNombre, Me.Fecha, Me.Vencimiento, Me.VencimientoNombre, Me.ANombre, Me.xrLabel2, Me.xrLabel3, Me.xrLabel5, Me.xrLabel4, Me.xrLabel6, Me.xrLabel7})
        Me.GroupHeader1.HeightF = 508.3333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrLabel1
        '
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "{0:n2}")})
        Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(741.6667!, 18.75!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(234.3751!, 31.33328!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "ANombre"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'EmpresaN
        '
        Me.EmpresaN.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NEmpresa")})
        Me.EmpresaN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaN.LocationFloat = New DevExpress.Utils.PointFloat(324.9999!, 139.5834!)
        Me.EmpresaN.Name = "EmpresaN"
        Me.EmpresaN.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EmpresaN.SizeF = New System.Drawing.SizeF(526.04!, 25.0!)
        Me.EmpresaN.StylePriority.UseFont = False
        Me.EmpresaN.StylePriority.UseTextAlignment = False
        Me.EmpresaN.Text = "ANombre"
        Me.EmpresaN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FechaNombre
        '
        Me.FechaNombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FechaNombre")})
        Me.FechaNombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNombre.LocationFloat = New DevExpress.Utils.PointFloat(31.25!, 85.4167!)
        Me.FechaNombre.Name = "FechaNombre"
        Me.FechaNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FechaNombre.SizeF = New System.Drawing.SizeF(88.53998!, 25.0!)
        Me.FechaNombre.StylePriority.UseFont = False
        Me.FechaNombre.StylePriority.UseTextAlignment = False
        Me.FechaNombre.Text = "ANombre"
        Me.FechaNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(128.125!, 85.4167!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(155.2066!, 25.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "ANombre"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Vencimiento
        '
        Me.Vencimiento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento")})
        Me.Vencimiento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vencimiento.LocationFloat = New DevExpress.Utils.PointFloat(294.7917!, 325.0!)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vencimiento.SizeF = New System.Drawing.SizeF(105.2066!, 25.0!)
        Me.Vencimiento.StylePriority.UseFont = False
        Me.Vencimiento.StylePriority.UseTextAlignment = False
        Me.Vencimiento.Text = "ANombre"
        Me.Vencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'VencimientoNombre
        '
        Me.VencimientoNombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VencimientoNombre")})
        Me.VencimientoNombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VencimientoNombre.LocationFloat = New DevExpress.Utils.PointFloat(176.0417!, 325.0!)
        Me.VencimientoNombre.Name = "VencimientoNombre"
        Me.VencimientoNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.VencimientoNombre.SizeF = New System.Drawing.SizeF(89.58159!, 25.0!)
        Me.VencimientoNombre.StylePriority.UseFont = False
        Me.VencimientoNombre.StylePriority.UseTextAlignment = False
        Me.VencimientoNombre.Text = "ANombre"
        Me.VencimientoNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ANombre
        '
        Me.ANombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ANombre")})
        Me.ANombre.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANombre.LocationFloat = New DevExpress.Utils.PointFloat(324.9999!, 85.4167!)
        Me.ANombre.Name = "ANombre"
        Me.ANombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ANombre.SizeF = New System.Drawing.SizeF(526.04!, 25.0!)
        Me.ANombre.StylePriority.UseFont = False
        Me.ANombre.StylePriority.UseTextAlignment = False
        Me.ANombre.Text = "ANombre"
        Me.ANombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EnLetras")})
        Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(128.125!, 187.5!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(792.7065!, 25.0!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "ANombre"
        Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel3
        '
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TCambio", "{0:n4}")})
        Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(720.8266!, 268.75!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(130.2133!, 25.0!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UseTextAlignment = False
        Me.xrLabel3.Text = "ANombre"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrLabel5
        '
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento")})
        Me.xrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(294.7917!, 363.5417!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(105.2066!, 25.0!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.StylePriority.UseTextAlignment = False
        Me.xrLabel5.Text = "ANombre"
        Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel4
        '
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VencimientoNombre")})
        Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(176.0417!, 363.5417!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(89.58159!, 25.0!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "ANombre"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel6
        '
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NEmpresa")})
        Me.xrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(450.0018!, 325.0!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(401.0382!, 25.0!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.StylePriority.UseTextAlignment = False
        Me.xrLabel6.Text = "ANombre"
        Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLabel7
        '
        Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NEmpresa")})
        Me.xrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(450.0018!, 363.5417!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(401.0382!, 25.0!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.StylePriority.UseTextAlignment = False
        Me.xrLabel7.Text = "ANombre"
        Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptLetraCambio
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents EmpresaN As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents FechaNombre As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Vencimiento As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents VencimientoNombre As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents ANombre As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
End Class
