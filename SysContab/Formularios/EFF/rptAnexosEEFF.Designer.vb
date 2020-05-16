<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptAnexosEEFF
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.rNegrita = New DevExpress.XtraReports.UI.FormattingRule()
        Me.SaldoMes = New DevExpress.XtraReports.UI.XRLabel()
        Me.Acumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tipo = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Grupo = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xSumarAuxiliares = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalMes = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalAcumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.rSumAuxiliares = New DevExpress.XtraReports.UI.FormattingRule()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.SumarAuxiliares = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SumarSaldoMes = New DevExpress.XtraReports.UI.CalculatedField()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Cuenta, Me.SaldoMes, Me.Acumulado, Me.Nombre})
        Me.Detail.HeightF = 18.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta")})
        Me.Cuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.FormattingRules.Add(Me.rNegrita)
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(119.7916!, 18.0!)
        Me.Cuenta.StylePriority.UseFont = False
        Me.Cuenta.StylePriority.UseTextAlignment = False
        Me.Cuenta.Text = "Empresa"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rNegrita
        '
        Me.rNegrita.Condition = "[Tipo] <> 'A'"
        Me.rNegrita.Formatting.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNegrita.Name = "rNegrita"
        '
        'SaldoMes
        '
        Me.SaldoMes.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoMes", "{0:n2}")})
        Me.SaldoMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoMes.FormattingRules.Add(Me.rNegrita)
        Me.SaldoMes.LocationFloat = New DevExpress.Utils.PointFloat(483.3335!, 0!)
        Me.SaldoMes.Name = "SaldoMes"
        Me.SaldoMes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoMes.SizeF = New System.Drawing.SizeF(150.0!, 18.0!)
        Me.SaldoMes.StylePriority.UseFont = False
        Me.SaldoMes.StylePriority.UseTextAlignment = False
        Me.SaldoMes.Text = "Empresa"
        Me.SaldoMes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Acumulado
        '
        Me.Acumulado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Acumulado", "{0:n2}")})
        Me.Acumulado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acumulado.FormattingRules.Add(Me.rNegrita)
        Me.Acumulado.LocationFloat = New DevExpress.Utils.PointFloat(650.0001!, 0!)
        Me.Acumulado.Name = "Acumulado"
        Me.Acumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Acumulado.SizeF = New System.Drawing.SizeF(150.0!, 18.0!)
        Me.Acumulado.StylePriority.UseFont = False
        Me.Acumulado.StylePriority.UseTextAlignment = False
        Me.Acumulado.Text = "Empresa"
        Me.Acumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.FormattingRules.Add(Me.rNegrita)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(119.7916!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(363.5417!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Empresa"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tipo
        '
        Me.Tipo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tipo", "{0}")})
        Me.Tipo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.FormattingRules.Add(Me.rNegrita)
        Me.Tipo.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 25.0!)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tipo.SizeF = New System.Drawing.SizeF(37.49994!, 18.0!)
        Me.Tipo.StylePriority.UseFont = False
        Me.Tipo.StylePriority.UseTextAlignment = False
        Me.Tipo.Text = "Empresa"
        Me.Tipo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tipo.Visible = False
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo3, Me.Usuario})
        Me.BottomMargin.HeightF = 35.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "Pag. {0} / {1}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(100.0!, 15.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Usuario
        '
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(250.0!, 15.0!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Empresa"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(650.0001!, 108.3333!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Año a Fecha"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(483.3335!, 108.3333!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Periodo Actual"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Grupo})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Codigo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.HeightF = 31.87501!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'Grupo
        '
        Me.Grupo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Grupo")})
        Me.Grupo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grupo.SizeF = New System.Drawing.SizeF(483.33!, 25.0!)
        Me.Grupo.StylePriority.UseFont = False
        Me.Grupo.StylePriority.UseTextAlignment = False
        Me.Grupo.Text = "Empresa"
        Me.Grupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.xSumarAuxiliares, Me.XrLabel6, Me.TotalMes, Me.TotalAcumulado, Me.Tipo})
        Me.GroupFooter1.HeightF = 100.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SumarSaldoMes")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(483.3335!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(149.9998!, 25.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel1.Summary = XrSummary1
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xSumarAuxiliares
        '
        Me.xSumarAuxiliares.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xSumarAuxiliares.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SumarAuxiliares")})
        Me.xSumarAuxiliares.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSumarAuxiliares.LocationFloat = New DevExpress.Utils.PointFloat(650.0001!, 0!)
        Me.xSumarAuxiliares.Name = "xSumarAuxiliares"
        Me.xSumarAuxiliares.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xSumarAuxiliares.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.xSumarAuxiliares.StylePriority.UseBorders = False
        Me.xSumarAuxiliares.StylePriority.UseFont = False
        Me.xSumarAuxiliares.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xSumarAuxiliares.Summary = XrSummary2
        Me.xSumarAuxiliares.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(483.33!, 25.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "TOTAL"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TotalMes
        '
        Me.TotalMes.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalMes.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalMes", "{0:n2}")})
        Me.TotalMes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMes.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.TotalMes.Name = "TotalMes"
        Me.TotalMes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalMes.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.TotalMes.StylePriority.UseBorders = False
        Me.TotalMes.StylePriority.UseFont = False
        Me.TotalMes.StylePriority.UseTextAlignment = False
        Me.TotalMes.Text = "Empresa"
        Me.TotalMes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalMes.Visible = False
        '
        'TotalAcumulado
        '
        Me.TotalAcumulado.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalAcumulado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalAcumulado", "{0:n2}")})
        Me.TotalAcumulado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAcumulado.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 25.0!)
        Me.TotalAcumulado.Name = "TotalAcumulado"
        Me.TotalAcumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalAcumulado.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.TotalAcumulado.StylePriority.UseBorders = False
        Me.TotalAcumulado.StylePriority.UseFont = False
        Me.TotalAcumulado.StylePriority.UseTextAlignment = False
        Me.TotalAcumulado.Text = "Empresa"
        Me.TotalAcumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalAcumulado.Visible = False
        '
        'rSumAuxiliares
        '
        Me.rSumAuxiliares.Condition = "[Tipo]  =  'A'"
        Me.rSumAuxiliares.Name = "rSumAuxiliares"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pLogo, Me.Empresa, Me.Moneda, Me.Titulo, Me.Fecha, Me.XrPageInfo1, Me.XrPageInfo2, Me.XrLabel2, Me.XrLabel3})
        Me.PageHeader.HeightF = 133.3333!
        Me.PageHeader.Name = "PageHeader"
        '
        'SumarAuxiliares
        '
        Me.SumarAuxiliares.DataMember = Me.DataMember
        Me.SumarAuxiliares.Expression = "Iif([Tipo] = 'A',[Acumulado]  ,0.00 )"
        Me.SumarAuxiliares.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
        Me.SumarAuxiliares.Name = "SumarAuxiliares"
        '
        'SumarSaldoMes
        '
        Me.SumarSaldoMes.DataMember = Me.DataMember
        Me.SumarSaldoMes.Expression = "Iif([Tipo] = 'A', [SaldoMes]  , 0.00 )"
        Me.SumarSaldoMes.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
        Me.SumarSaldoMes.Name = "SumarSaldoMes"
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(123.9583!, 68.99999!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'rptAnexosEEFF
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SumarAuxiliares, Me.SumarSaldoMes})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.rNegrita, Me.rSumAuxiliares})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 35)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        Me.XmlDataPath = "D:\Grupo McGregor\SysContab\SysContab\bin\xml\REQUISAS_DETALLE.xml"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Grupo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoMes As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Acumulado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalMes As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalAcumulado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents rNegrita As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rSumAuxiliares As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Tipo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xSumarAuxiliares As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SumarAuxiliares As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SumarSaldoMes As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
End Class
