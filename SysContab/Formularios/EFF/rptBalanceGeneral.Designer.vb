<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBalanceGeneral
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
        Me.fNegrita = New DevExpress.XtraReports.UI.FormattingRule()
        Me.rNegritaSinSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSubRaya1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.rNegritaSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSubRaya2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSubRaya3 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Columna4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSubRaya4 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Nombre3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
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
        Me.Nombre.FormattingRules.Add(Me.fNegrita)
        Me.Nombre.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(319.9998!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Empresa"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'fNegrita
        '
        Me.fNegrita.Condition = "[Negrita] = True OR [Titulo] = True"
        Me.fNegrita.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNegrita.Name = "fNegrita"
        '
        'rNegritaSinSubraya
        '
        Me.rNegritaSinSubraya.Condition = "[Negrita] = True AND [Titulo] = False"
        Me.rNegritaSinSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rNegritaSinSubraya.Name = "rNegritaSinSubraya"
        '
        'Columna1
        '
        Me.Columna1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna1", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna1.FormattingRules.Add(Me.rSubRaya1)
        Me.Columna1.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna1.FormattingRules.Add(Me.fNegrita)
        Me.Columna1.LocationFloat = New DevExpress.Utils.PointFloat(320.0!, 0!)
        Me.Columna1.Name = "Columna1"
        Me.Columna1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna1.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna1.StylePriority.UseFont = False
        Me.Columna1.StylePriority.UseTextAlignment = False
        Me.Columna1.Text = "Empresa"
        Me.Columna1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rSubRaya1
        '
        Me.rSubRaya1.Condition = "[SubTitulo] = True And [Columna1]  !=  NULL"
        Me.rSubRaya1.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rSubRaya1.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSubRaya1.Name = "rSubRaya1"
        '
        'rNegritaSubraya
        '
        Me.rNegritaSubraya.Condition = "[Titulo] = True"
        Me.rNegritaSubraya.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.rNegritaSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegritaSubraya.Name = "rNegritaSubraya"
        '
        'Columna2
        '
        Me.Columna2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna2", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna2.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna2.FormattingRules.Add(Me.rSubRaya2)
        Me.Columna2.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Columna2.LocationFloat = New DevExpress.Utils.PointFloat(440.0!, 0!)
        Me.Columna2.Name = "Columna2"
        Me.Columna2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna2.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna2.StylePriority.UseFont = False
        Me.Columna2.StylePriority.UseTextAlignment = False
        Me.Columna2.Text = "Empresa"
        Me.Columna2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rSubRaya2
        '
        Me.rSubRaya2.Condition = "[SubTitulo] = True And [Columna2]  !=  NULL"
        Me.rSubRaya2.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rSubRaya2.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSubRaya2.Name = "rSubRaya2"
        '
        'Columna3
        '
        Me.Columna3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna3", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna3.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna3.FormattingRules.Add(Me.rSubRaya3)
        Me.Columna3.FormattingRules.Add(Me.rNegritaSinSubraya)
        Me.Columna3.LocationFloat = New DevExpress.Utils.PointFloat(560.0!, 0!)
        Me.Columna3.Name = "Columna3"
        Me.Columna3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna3.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna3.StylePriority.UseFont = False
        Me.Columna3.StylePriority.UseTextAlignment = False
        Me.Columna3.Text = "Empresa"
        Me.Columna3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rSubRaya3
        '
        Me.rSubRaya3.Condition = "[SubTitulo] = True And [Columna3]  !=  NULL"
        Me.rSubRaya3.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rSubRaya3.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSubRaya3.Name = "rSubRaya3"
        '
        'Columna4
        '
        Me.Columna4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Columna4", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Columna4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Columna4.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Columna4.FormattingRules.Add(Me.rSubRaya4)
        Me.Columna4.LocationFloat = New DevExpress.Utils.PointFloat(680.0!, 0!)
        Me.Columna4.Name = "Columna4"
        Me.Columna4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Columna4.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Columna4.StylePriority.UseFont = False
        Me.Columna4.StylePriority.UseTextAlignment = False
        Me.Columna4.Text = "Empresa"
        Me.Columna4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rSubRaya4
        '
        Me.rSubRaya4.Condition = "([SubTitulo] = True OR [Titulo] = True) And [Columna4]  !=  NULL"
        Me.rSubRaya4.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rSubRaya4.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSubRaya4.Name = "rSubRaya4"
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.XrPageInfo3})
        Me.BottomMargin.HeightF = 35.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Usuario
        '
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(250.0!, 15.0!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Empresa"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "Pag. {0} / {1}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(700.0001!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(100.0!, 15.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pLogo, Me.XrPageInfo2, Me.Fecha, Me.Moneda, Me.Titulo, Me.Empresa, Me.XrPageInfo1})
        Me.ReportHeader.HeightF = 80.2084!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Format = "{0:hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(726.0401!, 18.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0!, 54.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(800.0!, 18.0!)
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
        Me.Moneda.SizeF = New System.Drawing.SizeF(800.0!, 18.0!)
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "Empresa"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TituloReporte")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 18.0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(800.0!, 18.0!)
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
        Me.Empresa.SizeF = New System.Drawing.SizeF(800.0!, 18.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(726.04!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre3, Me.Cargo3, Me.Cargo2, Me.Nombre2, Me.Cargo1, Me.Nombre1})
        Me.PageFooter.HeightF = 49.08333!
        Me.PageFooter.Name = "PageFooter"
        '
        'Nombre3
        '
        Me.Nombre3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre3")})
        Me.Nombre3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre3.LocationFloat = New DevExpress.Utils.PointFloat(275.0001!, 10.43751!)
        Me.Nombre3.Name = "Nombre3"
        Me.Nombre3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre3.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Nombre3.StylePriority.UseBorders = False
        Me.Nombre3.StylePriority.UseFont = False
        Me.Nombre3.StylePriority.UseTextAlignment = False
        Me.Nombre3.Text = "Empresa"
        Me.Nombre3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cargo3
        '
        Me.Cargo3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo3")})
        Me.Cargo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo3.LocationFloat = New DevExpress.Utils.PointFloat(275.0001!, 25.43751!)
        Me.Cargo3.Name = "Cargo3"
        Me.Cargo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo3.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo3.StylePriority.UseFont = False
        Me.Cargo3.StylePriority.UseTextAlignment = False
        Me.Cargo3.Text = "Empresa"
        Me.Cargo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cargo2
        '
        Me.Cargo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo2")})
        Me.Cargo2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(550.0001!, 25.43751!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo2.StylePriority.UseFont = False
        Me.Cargo2.StylePriority.UseTextAlignment = False
        Me.Cargo2.Text = "Empresa"
        Me.Cargo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre2
        '
        Me.Nombre2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre2")})
        Me.Nombre2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Nombre2.LocationFloat = New DevExpress.Utils.PointFloat(550.0001!, 10.0!)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre2.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Nombre2.StylePriority.UseBorders = False
        Me.Nombre2.StylePriority.UseFont = False
        Me.Nombre2.StylePriority.UseTextAlignment = False
        Me.Nombre2.Text = "Empresa"
        Me.Nombre2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cargo1
        '
        Me.Cargo1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo1")})
        Me.Cargo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Cargo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 25.43751!)
        Me.Cargo1.Name = "Cargo1"
        Me.Cargo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo1.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo1.StylePriority.UseFont = False
        Me.Cargo1.StylePriority.UseTextAlignment = False
        Me.Cargo1.Text = "Empresa"
        Me.Cargo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre1
        '
        Me.Nombre1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre1")})
        Me.Nombre1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Nombre1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 10.0!)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre1.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Nombre1.StylePriority.UseBorders = False
        Me.Nombre1.StylePriority.UseFont = False
        Me.Nombre1.StylePriority.UseTextAlignment = False
        Me.Nombre1.Text = "Empresa"
        Me.Nombre1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.BorderWidth = 2.0!
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(800.0!, 16.66667!)
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrSubreport1})
        Me.GroupFooter2.HeightF = 39.66667!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLine2
        '
        Me.XrLine2.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine2.BorderWidth = 2.0!
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(800.0!, 16.66667!)
        Me.XrLine2.StylePriority.UseBorders = False
        Me.XrLine2.StylePriority.UseBorderWidth = False
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(799.9999!, 23.0!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.GroupFooter1.HeightF = 16.66667!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(123.9583!, 68.99999!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'rptBalanceGeneral
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.GroupFooter2, Me.GroupFooter1})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.fNegrita, Me.rSubRaya1, Me.rNegritaSubraya, Me.rSubRaya2, Me.rSubRaya3, Me.rSubRaya4, Me.rNegritaSinSubraya})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 35)
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Columna1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Cargo1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents fNegrita As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSubRaya1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rNegritaSubraya As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSubRaya4 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSubRaya3 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSubRaya2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents rNegritaSinSubraya As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Nombre3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
End Class
