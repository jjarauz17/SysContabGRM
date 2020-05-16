<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEstadoResultadoGeneral
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
        Me.rNegritaTitulo = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Saldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        Me.rNegritaSubraya = New DevExpress.XtraReports.UI.FormattingRule()
        Me.PorcentajeSaldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Acumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.PorcentajeAcumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.QuitarNulos = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre, Me.Saldo, Me.PorcentajeSaldo, Me.Acumulado, Me.PorcentajeAcumulado})
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
        Me.Nombre.FormattingRules.Add(Me.rNegritaTitulo)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(313.5417!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Empresa"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rNegrita
        '
        Me.rNegrita.Condition = "[Negrita] = True"
        Me.rNegrita.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegrita.Name = "rNegrita"
        '
        'rNegritaTitulo
        '
        Me.rNegritaTitulo.Condition = "[Negrita] = True OR [Titulo] = True"
        Me.rNegritaTitulo.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegritaTitulo.Name = "rNegritaTitulo"
        '
        'Saldo
        '
        Me.Saldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Saldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Saldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo.FormattingRules.Add(Me.rSubraya)
        Me.Saldo.FormattingRules.Add(Me.rNegrita)
        Me.Saldo.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Saldo.LocationFloat = New DevExpress.Utils.PointFloat(313.5418!, 0!)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Saldo.SizeF = New System.Drawing.SizeF(130.0!, 18.0!)
        Me.Saldo.StylePriority.UseBorders = False
        Me.Saldo.StylePriority.UseFont = False
        Me.Saldo.StylePriority.UseTextAlignment = False
        Me.Saldo.Text = "Mes Actual"
        Me.Saldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rSubraya
        '
        Me.rSubraya.Condition = "[SubTitulo] = True"
        Me.rSubraya.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSubraya.Name = "rSubraya"
        '
        'rNegritaSubraya
        '
        Me.rNegritaSubraya.Condition = "[Titulo] = True"
        Me.rNegritaSubraya.Formatting.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.rNegritaSubraya.Formatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegritaSubraya.Name = "rNegritaSubraya"
        '
        'PorcentajeSaldo
        '
        Me.PorcentajeSaldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeSaldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PorcentajeSaldo", "{0:p2}")})
        Me.PorcentajeSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeSaldo.FormattingRules.Add(Me.rSubraya)
        Me.PorcentajeSaldo.FormattingRules.Add(Me.rNegrita)
        Me.PorcentajeSaldo.FormattingRules.Add(Me.rNegritaSubraya)
        Me.PorcentajeSaldo.LocationFloat = New DevExpress.Utils.PointFloat(472.9167!, 0!)
        Me.PorcentajeSaldo.Name = "PorcentajeSaldo"
        Me.PorcentajeSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeSaldo.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeSaldo.StylePriority.UseBorders = False
        Me.PorcentajeSaldo.StylePriority.UseFont = False
        Me.PorcentajeSaldo.StylePriority.UseTextAlignment = False
        Me.PorcentajeSaldo.Text = "Porcentaje %"
        Me.PorcentajeSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Acumulado
        '
        Me.Acumulado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Acumulado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Acumulado", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Acumulado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acumulado.FormattingRules.Add(Me.rSubraya)
        Me.Acumulado.FormattingRules.Add(Me.rNegrita)
        Me.Acumulado.FormattingRules.Add(Me.rNegritaSubraya)
        Me.Acumulado.LocationFloat = New DevExpress.Utils.PointFloat(569.7917!, 0!)
        Me.Acumulado.Multiline = True
        Me.Acumulado.Name = "Acumulado"
        Me.Acumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Acumulado.SizeF = New System.Drawing.SizeF(130.0!, 18.0!)
        Me.Acumulado.StylePriority.UseBorders = False
        Me.Acumulado.StylePriority.UseFont = False
        Me.Acumulado.StylePriority.UseTextAlignment = False
        Me.Acumulado.Text = "Acumulado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mes Actual"
        Me.Acumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PorcentajeAcumulado
        '
        Me.PorcentajeAcumulado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeAcumulado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PorcentajeAcumulado", "{0:p2}")})
        Me.PorcentajeAcumulado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeAcumulado.FormattingRules.Add(Me.rSubraya)
        Me.PorcentajeAcumulado.FormattingRules.Add(Me.rNegrita)
        Me.PorcentajeAcumulado.FormattingRules.Add(Me.rNegritaSubraya)
        Me.PorcentajeAcumulado.LocationFloat = New DevExpress.Utils.PointFloat(719.9999!, 0!)
        Me.PorcentajeAcumulado.Name = "PorcentajeAcumulado"
        Me.PorcentajeAcumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeAcumulado.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeAcumulado.StylePriority.UseBorders = False
        Me.PorcentajeAcumulado.StylePriority.UseFont = False
        Me.PorcentajeAcumulado.StylePriority.UseTextAlignment = False
        Me.PorcentajeAcumulado.Text = "Porcentaje %"
        Me.PorcentajeAcumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 40.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Usuario
        '
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(246.6667!, 20.0!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Empresa"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "Pag. {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(705.0001!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(95.0!, 20.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel1})
        Me.GroupHeader2.HeightF = 33.00001!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(719.9999!, 0!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(70.0!, 23.00001!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "%"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(569.7917!, 0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(129.9999!, 33.00001!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Acumulado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año Actual"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(472.9167!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(70.0!, 23.00001!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "%"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(313.5418!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(130.0!, 33.00001!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Este Mes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año Actual"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Nombre3
        '
        Me.Nombre3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre3")})
        Me.Nombre3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre3.LocationFloat = New DevExpress.Utils.PointFloat(310.2084!, 0!)
        Me.Nombre3.Name = "Nombre3"
        Me.Nombre3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre3.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
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
        Me.Cargo3.LocationFloat = New DevExpress.Utils.PointFloat(310.2084!, 14.99999!)
        Me.Cargo3.Name = "Cargo3"
        Me.Cargo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo3.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
        Me.Cargo3.StylePriority.UseFont = False
        Me.Cargo3.StylePriority.UseTextAlignment = False
        Me.Cargo3.Text = "Empresa"
        Me.Cargo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Nombre1
        '
        Me.Nombre1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre1")})
        Me.Nombre1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre1.LocationFloat = New DevExpress.Utils.PointFloat(46.66684!, 0!)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre1.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
        Me.Nombre1.StylePriority.UseBorders = False
        Me.Nombre1.StylePriority.UseFont = False
        Me.Nombre1.StylePriority.UseTextAlignment = False
        Me.Nombre1.Text = "Empresa"
        Me.Nombre1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cargo1
        '
        Me.Cargo1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo1")})
        Me.Cargo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo1.LocationFloat = New DevExpress.Utils.PointFloat(46.66684!, 14.99999!)
        Me.Cargo1.Name = "Cargo1"
        Me.Cargo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo1.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
        Me.Cargo1.StylePriority.UseFont = False
        Me.Cargo1.StylePriority.UseTextAlignment = False
        Me.Cargo1.Text = "Empresa"
        Me.Cargo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre2
        '
        Me.Nombre2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre2")})
        Me.Nombre2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre2.LocationFloat = New DevExpress.Utils.PointFloat(569.7917!, 0!)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre2.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
        Me.Nombre2.StylePriority.UseBorders = False
        Me.Nombre2.StylePriority.UseFont = False
        Me.Nombre2.StylePriority.UseTextAlignment = False
        Me.Nombre2.Text = "Empresa"
        Me.Nombre2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cargo2
        '
        Me.Cargo2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo2")})
        Me.Cargo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(569.7917!, 14.99999!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(200.0!, 15.0!)
        Me.Cargo2.StylePriority.UseFont = False
        Me.Cargo2.StylePriority.UseTextAlignment = False
        Me.Cargo2.Text = "Empresa"
        Me.Cargo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'FormattingRule2
        '
        Me.FormattingRule2.Condition = "(Saldo)   !=  0"
        Me.FormattingRule2.Name = "FormattingRule2"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "Abs(Saldo) > 0"
        Me.FormattingRule1.DataMember = "Saldo"
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'QuitarNulos
        '
        Me.QuitarNulos.Condition = "(Saldo)  = Abs(Saldo)"
        Me.QuitarNulos.Name = "QuitarNulos"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pLogo, Me.XrPageInfo3, Me.XrPageInfo4, Me.Empresa, Me.Titulo, Me.Moneda, Me.Fecha})
        Me.ReportHeader.HeightF = 108.3333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(726.04!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo4.Format = "{0:hh:mm tt}"
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(726.0398!, 18.0!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.StylePriority.UseTextAlignment = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(799.9999!, 18.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TituloReporte")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 18.0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(799.9999!, 18.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "Empresa"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Moneda")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 36.0!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(799.9999!, 18.0!)
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "Empresa"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 54.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(799.9999!, 18.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Empresa"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre2, Me.Cargo2, Me.Cargo1, Me.Nombre1, Me.Cargo3, Me.Nombre3})
        Me.PageFooter.HeightF = 39.70833!
        Me.PageFooter.Name = "PageFooter"
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(123.9583!, 68.99999!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'rptEstadoResultadoGeneral
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.ReportHeader, Me.PageFooter})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1, Me.FormattingRule2, Me.QuitarNulos, Me.rNegrita, Me.rSubraya, Me.rNegritaSubraya, Me.rNegritaTitulo})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 40)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Saldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PorcentajeSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Acumulado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PorcentajeAcumulado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents FormattingRule2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents QuitarNulos As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents rNegrita As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSubraya As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rNegritaSubraya As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rNegritaTitulo As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Nombre3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
End Class
