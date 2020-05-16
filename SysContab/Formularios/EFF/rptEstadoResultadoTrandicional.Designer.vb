<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEstadoResultadoTrandicional
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
        Me.SaldoActual = New DevExpress.XtraReports.UI.XRLabel()
        Me.Movimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.Descrpcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Desde = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Hasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.SaldoAnteriorT = New DevExpress.XtraReports.UI.XRLabel()
        Me.MovimientoT = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoT = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grupo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cargo2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SaldoActual, Me.Movimiento, Me.SaldoAnterior, Me.Descrpcion, Me.Cuenta})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SaldoActual
        '
        Me.SaldoActual.CanShrink = True
        Me.SaldoActual.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoActual", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.SaldoActual.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoActual.LocationFloat = New DevExpress.Utils.PointFloat(690.0001!, 0!)
        Me.SaldoActual.Name = "SaldoActual"
        Me.SaldoActual.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoActual.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.SaldoActual.SizeF = New System.Drawing.SizeF(120.0!, 20.0!)
        Me.SaldoActual.StylePriority.UseFont = False
        Me.SaldoActual.StylePriority.UseTextAlignment = False
        Me.SaldoActual.Text = "txtcuenta"
        Me.SaldoActual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Movimiento
        '
        Me.Movimiento.CanShrink = True
        Me.Movimiento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Movimiento", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.Movimiento.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Movimiento.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 0!)
        Me.Movimiento.Name = "Movimiento"
        Me.Movimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Movimiento.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Movimiento.SizeF = New System.Drawing.SizeF(120.0!, 20.0!)
        Me.Movimiento.StylePriority.UseFont = False
        Me.Movimiento.StylePriority.UseTextAlignment = False
        Me.Movimiento.Text = "txtcuenta"
        Me.Movimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.CanShrink = True
        Me.SaldoAnterior.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoAnterior", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.SaldoAnterior.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(450.0001!, 0!)
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoAnterior.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.SaldoAnterior.SizeF = New System.Drawing.SizeF(120.0!, 20.0!)
        Me.SaldoAnterior.StylePriority.UseFont = False
        Me.SaldoAnterior.StylePriority.UseTextAlignment = False
        Me.SaldoAnterior.Text = "txtcuenta"
        Me.SaldoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Descrpcion
        '
        Me.Descrpcion.CanShrink = True
        Me.Descrpcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion")})
        Me.Descrpcion.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrpcion.LocationFloat = New DevExpress.Utils.PointFloat(97.91643!, 0!)
        Me.Descrpcion.Name = "Descrpcion"
        Me.Descrpcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descrpcion.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Descrpcion.SizeF = New System.Drawing.SizeF(352.0836!, 20.0!)
        Me.Descrpcion.StylePriority.UseFont = False
        Me.Descrpcion.StylePriority.UseTextAlignment = False
        Me.Descrpcion.Text = "txtcuenta"
        Me.Descrpcion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cuenta
        '
        Me.Cuenta.CanShrink = True
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta")})
        Me.Cuenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Cuenta.SizeF = New System.Drawing.SizeF(97.91643!, 20.0!)
        Me.Cuenta.StylePriority.UseFont = False
        Me.Cuenta.StylePriority.UseTextAlignment = False
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 23.54158!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(421.8784!, 68.99999!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(60.93726!, 20.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Hasta:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Desde
        '
        Me.Desde.CanShrink = True
        Me.Desde.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Desde", "{0:dd/MM/yyyy}")})
        Me.Desde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.ForeColor = System.Drawing.Color.Black
        Me.Desde.LocationFloat = New DevExpress.Utils.PointFloat(300.0034!, 68.99999!)
        Me.Desde.Name = "Desde"
        Me.Desde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desde.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Desde.SizeF = New System.Drawing.SizeF(121.875!, 20.0!)
        Me.Desde.StylePriority.UseFont = False
        Me.Desde.StylePriority.UseForeColor = False
        Me.Desde.StylePriority.UseTextAlignment = False
        Me.Desde.Text = "txtcuenta"
        Me.Desde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(243.75!, 68.99999!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(56.25334!, 20.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Desde:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Hasta
        '
        Me.Hasta.CanShrink = True
        Me.Hasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hasta", "{0:dd/MM/yyyy}")})
        Me.Hasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.ForeColor = System.Drawing.Color.Black
        Me.Hasta.LocationFloat = New DevExpress.Utils.PointFloat(482.8156!, 68.99999!)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Hasta.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Hasta.SizeF = New System.Drawing.SizeF(121.875!, 20.0!)
        Me.Hasta.StylePriority.UseFont = False
        Me.Hasta.StylePriority.UseForeColor = False
        Me.Hasta.StylePriority.UseTextAlignment = False
        Me.Hasta.Text = "txtcuenta"
        Me.Hasta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Moneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Moneda")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.0!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(809.9999!, 23.0!)
        Me.Moneda.StylePriority.UseBorders = False
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "txtTitulo"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Titulo")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(1.041524!, 23.00002!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(808.9584!, 23.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "Titulo"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(809.9999!, 23.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(1.041826!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(123.9583!, 68.99999!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(690.0001!, 118.75!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(120.0!, 27.79172!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Saldo Actual"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 118.75!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(120.0!, 27.79172!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Movimiento del Mes"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(450.0001!, 118.75!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(120.0!, 27.79172!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Saldo Anterior"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(97.91643!, 118.75!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(352.0836!, 27.79172!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Descripción"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 118.75!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(97.91643!, 27.79172!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Cuenta"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SaldoAnteriorT, Me.MovimientoT, Me.SaldoT, Me.Grupo})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Codigo_Grupo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Grupo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 34.5!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'SaldoAnteriorT
        '
        Me.SaldoAnteriorT.CanShrink = True
        Me.SaldoAnteriorT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoAnteriorT", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.SaldoAnteriorT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAnteriorT.LocationFloat = New DevExpress.Utils.PointFloat(450.0001!, 6.25!)
        Me.SaldoAnteriorT.Name = "SaldoAnteriorT"
        Me.SaldoAnteriorT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoAnteriorT.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.SaldoAnteriorT.SizeF = New System.Drawing.SizeF(120.0!, 22.0!)
        Me.SaldoAnteriorT.StylePriority.UseFont = False
        Me.SaldoAnteriorT.StylePriority.UseTextAlignment = False
        Me.SaldoAnteriorT.Text = "txtcuenta"
        Me.SaldoAnteriorT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'MovimientoT
        '
        Me.MovimientoT.CanShrink = True
        Me.MovimientoT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MovimientoT", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.MovimientoT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovimientoT.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 6.25!)
        Me.MovimientoT.Name = "MovimientoT"
        Me.MovimientoT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.MovimientoT.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.MovimientoT.SizeF = New System.Drawing.SizeF(120.0!, 22.0!)
        Me.MovimientoT.StylePriority.UseFont = False
        Me.MovimientoT.StylePriority.UseTextAlignment = False
        Me.MovimientoT.Text = "txtcuenta"
        Me.MovimientoT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SaldoT
        '
        Me.SaldoT.CanShrink = True
        Me.SaldoT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoT", "{0:##,#.00;(##,##.00);'0.00'}")})
        Me.SaldoT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoT.LocationFloat = New DevExpress.Utils.PointFloat(690.0001!, 6.25!)
        Me.SaldoT.Name = "SaldoT"
        Me.SaldoT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoT.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.SaldoT.SizeF = New System.Drawing.SizeF(120.0!, 22.0!)
        Me.SaldoT.StylePriority.UseFont = False
        Me.SaldoT.StylePriority.UseTextAlignment = False
        Me.SaldoT.Text = "txtcuenta"
        Me.SaldoT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grupo
        '
        Me.Grupo.CanShrink = True
        Me.Grupo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Grupo")})
        Me.Grupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo.ForeColor = System.Drawing.Color.Navy
        Me.Grupo.LocationFloat = New DevExpress.Utils.PointFloat(1.041524!, 6.25!)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grupo.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Grupo.SizeF = New System.Drawing.SizeF(448.9585!, 22.0!)
        Me.Grupo.StylePriority.UseFont = False
        Me.Grupo.StylePriority.UseForeColor = False
        Me.Grupo.StylePriority.UseTextAlignment = False
        Me.Grupo.Text = "Cuenta"
        Me.Grupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre3
        '
        Me.Nombre3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre3")})
        Me.Nombre3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre3.LocationFloat = New DevExpress.Utils.PointFloat(277.7081!, 42.70833!)
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
        Me.Cargo3.LocationFloat = New DevExpress.Utils.PointFloat(277.7081!, 57.70836!)
        Me.Cargo3.Name = "Cargo3"
        Me.Cargo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo3.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo3.StylePriority.UseFont = False
        Me.Cargo3.StylePriority.UseTextAlignment = False
        Me.Cargo3.Text = "Empresa"
        Me.Cargo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cargo1
        '
        Me.Cargo1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cargo1")})
        Me.Cargo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 57.70836!)
        Me.Cargo1.Name = "Cargo1"
        Me.Cargo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo1.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
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
        Me.Nombre2.LocationFloat = New DevExpress.Utils.PointFloat(558.9582!, 42.70833!)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre2.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
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
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(558.9582!, 57.70836!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo2.StylePriority.UseFont = False
        Me.Cargo2.StylePriority.UseTextAlignment = False
        Me.Cargo2.Text = "Empresa"
        Me.Cargo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre1
        '
        Me.Nombre1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre1")})
        Me.Nombre1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 42.70833!)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre1.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Nombre1.StylePriority.UseBorders = False
        Me.Nombre1.StylePriority.UseFont = False
        Me.Nombre1.StylePriority.UseTextAlignment = False
        Me.Nombre1.Text = "Empresa"
        Me.Nombre1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "Pag. {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(677.7082!, 68.99999!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(132.2917!, 18.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 68.99999!)
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
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(1.041826!, 86.99998!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.StylePriority.UseTextAlignment = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Usuario
        '
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(630.8332!, 86.99998!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(179.1666!, 18.00001!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Empresa"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Expanded = False
        Me.ReportFooter.HeightF = 69.58336!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel16, Me.Usuario, Me.XrPageInfo3, Me.XrPageInfo4, Me.XrPageInfo1, Me.XrLabel11, Me.Desde, Me.XrLabel10, Me.Hasta, Me.Moneda, Me.Titulo, Me.pLogo, Me.Empresa})
        Me.PageHeader.HeightF = 146.5417!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre2, Me.Cargo3, Me.Cargo1, Me.Nombre1, Me.Cargo2, Me.Nombre3})
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptEstadoResultadoTrandicional
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.ReportFooter, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 24)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoActual As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Movimiento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descrpcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Desde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Hasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents SaldoAnteriorT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents MovimientoT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grupo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo4 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
End Class
