<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLibroBanco
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
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Comp_No = New DevExpress.XtraReports.UI.XRLabel()
        Me.Documento = New DevExpress.XtraReports.UI.XRLabel()
        Me.Concepto = New DevExpress.XtraReports.UI.XRLabel()
        Me.Salidas = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoActual = New DevExpress.XtraReports.UI.XRLabel()
        Me.Entradas = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Rango = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.rReglaEntradas = New DevExpress.XtraReports.UI.FormattingRule()
        Me.rReglaSalidas = New DevExpress.XtraReports.UI.FormattingRule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Fecha, Me.Comp_No, Me.Documento, Me.Concepto, Me.Salidas, Me.SaldoActual, Me.Entradas})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Fecha
        '
        Me.Fecha.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd/MM/yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(65.62!, 20.0!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Comp_No
        '
        Me.Comp_No.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Comp_No.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comp_No")})
        Me.Comp_No.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_No.LocationFloat = New DevExpress.Utils.PointFloat(65.62333!, 0!)
        Me.Comp_No.Name = "Comp_No"
        Me.Comp_No.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Comp_No.SizeF = New System.Drawing.SizeF(84.38!, 20.0!)
        Me.Comp_No.StylePriority.UseBorders = False
        Me.Comp_No.StylePriority.UseFont = False
        Me.Comp_No.StylePriority.UseTextAlignment = False
        Me.Comp_No.Text = "Comp No"
        Me.Comp_No.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Documento
        '
        Me.Documento.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Documento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Documento")})
        Me.Documento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Documento.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 0!)
        Me.Documento.Name = "Documento"
        Me.Documento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Documento.SizeF = New System.Drawing.SizeF(78.12!, 20.0!)
        Me.Documento.StylePriority.UseBorders = False
        Me.Documento.StylePriority.UseFont = False
        Me.Documento.StylePriority.UseTextAlignment = False
        Me.Documento.Text = "Documento"
        Me.Documento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Concepto
        '
        Me.Concepto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Concepto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto")})
        Me.Concepto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concepto.LocationFloat = New DevExpress.Utils.PointFloat(228.1234!, 0!)
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto.SizeF = New System.Drawing.SizeF(286.88!, 20.0!)
        Me.Concepto.StylePriority.UseBorders = False
        Me.Concepto.StylePriority.UseFont = False
        Me.Concepto.StylePriority.UseTextAlignment = False
        Me.Concepto.Text = "Concepto"
        Me.Concepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Salidas
        '
        Me.Salidas.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Salidas.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Salidas", "{0:n2}")})
        Me.Salidas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salidas.FormattingRules.Add(Me.rReglaSalidas)
        Me.Salidas.LocationFloat = New DevExpress.Utils.PointFloat(610.0!, 0!)
        Me.Salidas.Name = "Salidas"
        Me.Salidas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Salidas.SizeF = New System.Drawing.SizeF(95.0!, 20.0!)
        Me.Salidas.StylePriority.UseBorders = False
        Me.Salidas.StylePriority.UseFont = False
        Me.Salidas.StylePriority.UseTextAlignment = False
        Me.Salidas.Text = "Salidas"
        Me.Salidas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SaldoActual
        '
        Me.SaldoActual.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.SaldoActual.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo Actual", "{0:n2}")})
        Me.SaldoActual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoActual.LocationFloat = New DevExpress.Utils.PointFloat(705.0!, 0!)
        Me.SaldoActual.Name = "SaldoActual"
        Me.SaldoActual.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoActual.SizeF = New System.Drawing.SizeF(95.0!, 20.0!)
        Me.SaldoActual.StylePriority.UseBorders = False
        Me.SaldoActual.StylePriority.UseFont = False
        Me.SaldoActual.StylePriority.UseTextAlignment = False
        Me.SaldoActual.Text = "Saldo Actual"
        Me.SaldoActual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Entradas
        '
        Me.Entradas.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Entradas.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Entradas", "{0:n2}")})
        Me.Entradas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entradas.FormattingRules.Add(Me.rReglaEntradas)
        Me.Entradas.LocationFloat = New DevExpress.Utils.PointFloat(515.0!, 0!)
        Me.Entradas.Name = "Entradas"
        Me.Entradas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Entradas.SizeF = New System.Drawing.SizeF(95.0!, 20.0!)
        Me.Entradas.StylePriority.UseBorders = False
        Me.Entradas.StylePriority.UseFont = False
        Me.Entradas.StylePriority.UseTextAlignment = False
        Me.Entradas.Text = "Entradas"
        Me.Entradas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.SaldoAnterior, Me.Nombre, Me.Cuenta, Me.pLogo, Me.Moneda, Me.Rango, Me.Titulo, Me.Empresa})
        Me.PageHeader.HeightF = 162.6251!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(515.0!, 106.4167!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(139.1684!, 20.00002!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Saldo Aterior:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(515.0!, 137.6251!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(95.0!, 25.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Entradas"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(705.0!, 137.6251!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(95.0!, 25.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Saldo Actual"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(610.0!, 137.6251!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(95.0!, 25.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Salidas"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(228.1234!, 137.6251!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(286.8766!, 25.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Concepto"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 137.6251!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(78.12335!, 25.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Documento"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(65.62334!, 137.6251!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(84.37667!, 25.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Comp No"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 137.6251!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(65.62333!, 25.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Fecha"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoAnterior", "{0:n2}")})
        Me.SaldoAnterior.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(654.1684!, 106.4167!)
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoAnterior.SizeF = New System.Drawing.SizeF(145.8316!, 20.0!)
        Me.SaldoAnterior.StylePriority.UseFont = False
        Me.SaldoAnterior.StylePriority.UseTextAlignment = False
        Me.SaldoAnterior.Text = "Rango"
        Me.SaldoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 106.4167!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(258.3316!, 20.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Rango"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta")})
        Me.Cuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(0!, 106.4167!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(150.0!, 20.0!)
        Me.Cuenta.StylePriority.UseFont = False
        Me.Cuenta.StylePriority.UseTextAlignment = False
        Me.Cuenta.Text = "Rango"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(150.0!, 85.0!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'Moneda
        '
        Me.Moneda.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.Moneda.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.Moneda.BorderWidth = 3.0!
        Me.Moneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Moneda")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.99999!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(800.0!, 23.0!)
        Me.Moneda.StylePriority.UseBorderDashStyle = False
        Me.Moneda.StylePriority.UseBorders = False
        Me.Moneda.StylePriority.UseBorderWidth = False
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "XrLabel1"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Rango
        '
        Me.Rango.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Rango")})
        Me.Rango.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rango.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.0!)
        Me.Rango.Name = "Rango"
        Me.Rango.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Rango.SizeF = New System.Drawing.SizeF(800.0!, 23.0!)
        Me.Rango.StylePriority.UseFont = False
        Me.Rango.StylePriority.UseTextAlignment = False
        Me.Rango.Text = "Rango"
        Me.Rango.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Titulo")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23.0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(800.0!, 23.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "XrLabel1"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(800.0!, 23.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.XrPageInfo3, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 58.95833!
        Me.PageFooter.Name = "PageFooter"
        '
        'Usuario
        '
        Me.Usuario.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(548.9583!, 38.95833!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(251.0417!, 20.0!)
        Me.Usuario.StylePriority.UseBorders = False
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Salidas"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "Pag. {0} de {1}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(548.9583!, 20.95833!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(251.0417!, 18.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Format = "{0:hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 38.95833!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(251.0417!, 18.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.95833!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(251.0417!, 18.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rReglaEntradas
        '
        Me.rReglaEntradas.Condition = "[Entradas] == 0.00"
        Me.rReglaEntradas.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rReglaEntradas.Name = "rReglaEntradas"
        '
        'rReglaSalidas
        '
        Me.rReglaSalidas.Condition = "[Salidas] == 0.00"
        Me.rReglaSalidas.Formatting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rReglaSalidas.Name = "rReglaSalidas"
        '
        'rptLibroBanco
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupFooter1, Me.PageFooter})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.rReglaEntradas, Me.rReglaSalidas})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Rango As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Comp_No As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Documento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Concepto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Salidas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoActual As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Entradas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents rReglaSalidas As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents rReglaEntradas As DevExpress.XtraReports.UI.FormattingRule
End Class
