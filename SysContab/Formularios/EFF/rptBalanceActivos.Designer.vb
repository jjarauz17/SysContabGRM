<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBalanceActivos
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
        Me.rNegrita = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rNegritaSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        Me.rColumna1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rColumna2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rColumna3 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rColumna4 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.rNegritaSinSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre, Me.Columna1, Me.Columna2, Me.Columna3, Me.Columna4})
        Me.Detail.HeightF = 18.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.FormattingRules.Add(Me.rNegrita)
        Me.Nombre.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(320.0!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Empresa"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rNegrita
        '
        Me.rNegrita.Condition = "[Negrita] = True OR [Titulo] = True"
        '
        '
        '
        Me.rNegrita.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegrita.Name = "rNegrita"
        '
        'Columna1
        '
        Me.Columna1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna1", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna1.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna1.FormattingRules.Add(Me.rColumna1)
        Me.Columna1.FormattingRules.Add(Me.rNegrita)
        Me.Columna1.LocationFloat = New DevExpress.Utils.PointFloat(320.0!, 0.0!)
        Me.Columna1.Name = "Columna1"
        Me.Columna1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna1.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna1.StylePriority.UseFont = False
        Me.Columna1.StylePriority.UseTextAlignment = False
        Me.Columna1.Text = "Empresa"
        Me.Columna1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rNegritaSubraya
        '
        Me.rNegritaSubraya.Condition = "[Titulo] = True"
        '
        '
        '
        Me.rNegritaSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rNegritaSubraya.Name = "rNegritaSubraya"
        '
        'rColumna1
        '
        Me.rColumna1.Condition = "[SubTitulo] = True And [Columna1]  !=  NULL"
        '
        '
        '
        Me.rColumna1.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rColumna1.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rColumna1.Name = "rColumna1"
        '
        'Columna2
        '
        Me.Columna2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna2", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna2.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna2.FormattingRules.Add(Me.rColumna2)
        Me.Columna2.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Columna2.LocationFloat = New DevExpress.Utils.PointFloat(440.0!, 0.0!)
        Me.Columna2.Name = "Columna2"
        Me.Columna2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna2.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna2.StylePriority.UseFont = False
        Me.Columna2.StylePriority.UseTextAlignment = False
        Me.Columna2.Text = "Empresa"
        Me.Columna2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rColumna2
        '
        Me.rColumna2.Condition = "[SubTitulo] = True And [Columna2]  !=  NULL"
        '
        '
        '
        Me.rColumna2.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rColumna2.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rColumna2.Name = "rColumna2"
        '
        'Columna3
        '
        Me.Columna3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna3", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna3.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna3.FormattingRules.Add(Me.rColumna3)
        Me.Columna3.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Columna3.LocationFloat = New DevExpress.Utils.PointFloat(560.0!, 0.0!)
        Me.Columna3.Name = "Columna3"
        Me.Columna3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna3.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna3.StylePriority.UseFont = False
        Me.Columna3.StylePriority.UseTextAlignment = False
        Me.Columna3.Text = "Empresa"
        Me.Columna3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rColumna3
        '
        Me.rColumna3.Condition = "[SubTitulo] = True And [Columna3]  !=  NULL"
        '
        '
        '
        Me.rColumna3.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rColumna3.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rColumna3.Name = "rColumna3"
        '
        'Columna4
        '
        Me.Columna4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna4", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna4.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna4.FormattingRules.Add(Me.rColumna4)
        Me.Columna4.LocationFloat = New DevExpress.Utils.PointFloat(680.0!, 0.0!)
        Me.Columna4.Name = "Columna4"
        Me.Columna4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna4.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna4.StylePriority.UseFont = False
        Me.Columna4.StylePriority.UseTextAlignment = False
        Me.Columna4.Text = "Empresa"
        Me.Columna4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rColumna4
        '
        Me.rColumna4.Condition = "([SubTitulo] = True OR [Titulo] = True) And [Columna4]  !=  NULL"
        '
        '
        '
        Me.rColumna4.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rColumna4.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rColumna4.Name = "rColumna4"
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
        'rNegritaSinSubraya
        '
        Me.rNegritaSinSubraya.Condition = "[Negrita] = True AND [Titulo] = False"
        '
        '
        '
        Me.rNegritaSinSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegritaSinSubraya.Name = "rNegritaSinSubraya"
        '
        'rptBalanceActivos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.rNegrita, Me.rNegritaSubraya, Me.rColumna1, Me.rColumna2, Me.rColumna3, Me.rColumna4, Me.rNegritaSinSubraya})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rNegrita As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rNegritaSubraya As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rColumna1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rColumna2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rColumna3 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rColumna4 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rNegritaSinSubraya As DevExpress.XtraReports.UI.FormattingRule
End Class
