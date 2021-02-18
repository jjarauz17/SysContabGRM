<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEstadoResultado
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
        Me.PorcentajeSaldoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.AcumuladoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.PorcentajeAcumuadoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoAnterior = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Saldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PorcentajeSaldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Acumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.PorcentajeAcumulado = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo4 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PorcentajeSaldoAnterior, Me.AcumuladoAnterior, Me.PorcentajeAcumuadoAnterior, Me.SaldoAnterior, Me.Nombre, Me.Saldo, Me.PorcentajeSaldo, Me.Acumulado, Me.PorcentajeAcumulado})
        Me.Detail.HeightF = 18.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PorcentajeSaldoAnterior
        '
        Me.PorcentajeSaldoAnterior.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeSaldoAnterior.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PorcentajeSaldoAnterior]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.PorcentajeSaldoAnterior.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeSaldoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(575.0!, 0!)
        Me.PorcentajeSaldoAnterior.Name = "PorcentajeSaldoAnterior"
        Me.PorcentajeSaldoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeSaldoAnterior.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeSaldoAnterior.StylePriority.UseBorders = False
        Me.PorcentajeSaldoAnterior.StylePriority.UseFont = False
        Me.PorcentajeSaldoAnterior.StylePriority.UseTextAlignment = False
        Me.PorcentajeSaldoAnterior.Text = "Porcentaje %"
        Me.PorcentajeSaldoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PorcentajeSaldoAnterior.TextFormatString = "{0:p2}"
        '
        'AcumuladoAnterior
        '
        Me.AcumuladoAnterior.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.AcumuladoAnterior.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AcumuladoAnterior]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.AcumuladoAnterior.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcumuladoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(850.0!, 0!)
        Me.AcumuladoAnterior.Multiline = True
        Me.AcumuladoAnterior.Name = "AcumuladoAnterior"
        Me.AcumuladoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.AcumuladoAnterior.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.AcumuladoAnterior.StylePriority.UseBorders = False
        Me.AcumuladoAnterior.StylePriority.UseFont = False
        Me.AcumuladoAnterior.StylePriority.UseTextAlignment = False
        Me.AcumuladoAnterior.Text = "Acumulado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mes Actual"
        Me.AcumuladoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.AcumuladoAnterior.TextFormatString = "{0:##,#.00;(##,##.00);'0.00'}"
        '
        'PorcentajeAcumuadoAnterior
        '
        Me.PorcentajeAcumuadoAnterior.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeAcumuadoAnterior.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PorcentajeAcumuadoAnterior]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.PorcentajeAcumuadoAnterior.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeAcumuadoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(976.0401!, 0!)
        Me.PorcentajeAcumuadoAnterior.Name = "PorcentajeAcumuadoAnterior"
        Me.PorcentajeAcumuadoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeAcumuadoAnterior.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeAcumuadoAnterior.StylePriority.UseBorders = False
        Me.PorcentajeAcumuadoAnterior.StylePriority.UseFont = False
        Me.PorcentajeAcumuadoAnterior.StylePriority.UseTextAlignment = False
        Me.PorcentajeAcumuadoAnterior.Text = "Porcentaje %"
        Me.PorcentajeAcumuadoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PorcentajeAcumuadoAnterior.TextFormatString = "{0:p2}"
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.SaldoAnterior.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaldoAnterior]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.SaldoAnterior.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoAnterior.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0!)
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoAnterior.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.SaldoAnterior.StylePriority.UseBorders = False
        Me.SaldoAnterior.StylePriority.UseFont = False
        Me.SaldoAnterior.StylePriority.UseTextAlignment = False
        Me.SaldoAnterior.Text = "Mes Actual"
        Me.SaldoAnterior.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.SaldoAnterior.TextFormatString = "{0:##,#.00;(##,##.00);'0.00'}"
        '
        'Nombre
        '
        Me.Nombre.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Negrita] = True Or [Titulo] = True, True, [Negrita] = True, True, ?)")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(250.0!, 18.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Empresa"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Saldo
        '
        Me.Saldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Saldo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Saldo]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.Saldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo.LocationFloat = New DevExpress.Utils.PointFloat(250.0002!, 0!)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Saldo.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Saldo.StylePriority.UseBorders = False
        Me.Saldo.StylePriority.UseFont = False
        Me.Saldo.StylePriority.UseTextAlignment = False
        Me.Saldo.Text = "Mes Actual"
        Me.Saldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Saldo.TextFormatString = "{0:##,#.00;(##,##.00);'0.00'}"
        '
        'PorcentajeSaldo
        '
        Me.PorcentajeSaldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeSaldo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PorcentajeSaldo]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.PorcentajeSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeSaldo.LocationFloat = New DevExpress.Utils.PointFloat(375.0!, 0!)
        Me.PorcentajeSaldo.Name = "PorcentajeSaldo"
        Me.PorcentajeSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeSaldo.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeSaldo.StylePriority.UseBorders = False
        Me.PorcentajeSaldo.StylePriority.UseFont = False
        Me.PorcentajeSaldo.StylePriority.UseTextAlignment = False
        Me.PorcentajeSaldo.Text = "Porcentaje %"
        Me.PorcentajeSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PorcentajeSaldo.TextFormatString = "{0:p2}"
        '
        'Acumulado
        '
        Me.Acumulado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Acumulado.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Acumulado]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.Acumulado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acumulado.LocationFloat = New DevExpress.Utils.PointFloat(650.0!, 0!)
        Me.Acumulado.Multiline = True
        Me.Acumulado.Name = "Acumulado"
        Me.Acumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Acumulado.SizeF = New System.Drawing.SizeF(120.0!, 18.0!)
        Me.Acumulado.StylePriority.UseBorders = False
        Me.Acumulado.StylePriority.UseFont = False
        Me.Acumulado.StylePriority.UseTextAlignment = False
        Me.Acumulado.Text = "Acumulado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mes Actual"
        Me.Acumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Acumulado.TextFormatString = "{0:##,#.00;(##,##.00);'0.00'}"
        '
        'PorcentajeAcumulado
        '
        Me.PorcentajeAcumulado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PorcentajeAcumulado.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PorcentajeAcumulado]"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Borders", "Iif([Titulo] = True, 'Bottom', [SubTitulo] = True, 'Bottom', ?)"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([Titulo] = True, True, [Negrita] = True, True, [SubTitulo] = True, False, ?)")})
        Me.PorcentajeAcumulado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeAcumulado.LocationFloat = New DevExpress.Utils.PointFloat(775.0!, 0!)
        Me.PorcentajeAcumulado.Name = "PorcentajeAcumulado"
        Me.PorcentajeAcumulado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorcentajeAcumulado.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.PorcentajeAcumulado.StylePriority.UseBorders = False
        Me.PorcentajeAcumulado.StylePriority.UseFont = False
        Me.PorcentajeAcumulado.StylePriority.UseTextAlignment = False
        Me.PorcentajeAcumulado.Text = "Porcentaje %"
        Me.PorcentajeAcumulado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PorcentajeAcumulado.TextFormatString = "{0:p2}"
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
        'Usuario
        '
        Me.Usuario.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Usuario]")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(1.04181!, 10.00001!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(132.2916!, 20.0!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Empresa"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(952.0816!, 10.00001!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(95.0!, 20.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "Pag. {0} / {1}"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel8, Me.XrLabel6, Me.XrLabel2, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel1})
        Me.GroupHeader2.HeightF = 33.00001!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(850.0!, 0!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(120.0!, 33.00001!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Acumulado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año Anterior"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(975.0!, 0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(70.00006!, 23.00001!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "%"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(575.0!, 0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(70.0!, 23.00001!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "%"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(120.0!, 33.00001!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Este Mes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año Anterior"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(775.0!, 0!)
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
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(650.0!, 0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(120.0!, 33.00001!)
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
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(375.0!, 0!)
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
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(250.0002!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(120.0!, 33.00001!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Este Mes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año Actual"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Nombre3
        '
        Me.Nombre3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre3]")})
        Me.Nombre3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre3.LocationFloat = New DevExpress.Utils.PointFloat(418.75!, 0!)
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
        Me.Cargo3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cargo3]")})
        Me.Cargo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo3.LocationFloat = New DevExpress.Utils.PointFloat(418.75!, 14.99999!)
        Me.Cargo3.Name = "Cargo3"
        Me.Cargo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo3.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo3.StylePriority.UseFont = False
        Me.Cargo3.StylePriority.UseTextAlignment = False
        Me.Cargo3.Text = "Empresa"
        Me.Cargo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Nombre1
        '
        Me.Nombre1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Nombre1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre1]")})
        Me.Nombre1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre1.LocationFloat = New DevExpress.Utils.PointFloat(133.3335!, 0!)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre1.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Nombre1.StylePriority.UseBorders = False
        Me.Nombre1.StylePriority.UseFont = False
        Me.Nombre1.StylePriority.UseTextAlignment = False
        Me.Nombre1.Text = "Empresa"
        Me.Nombre1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cargo1
        '
        Me.Cargo1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cargo1]")})
        Me.Cargo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo1.LocationFloat = New DevExpress.Utils.PointFloat(133.3335!, 14.99999!)
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
        Me.Nombre2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre2]")})
        Me.Nombre2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre2.LocationFloat = New DevExpress.Utils.PointFloat(702.0815!, 0!)
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
        Me.Cargo2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cargo2]")})
        Me.Cargo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo2.LocationFloat = New DevExpress.Utils.PointFloat(702.0815!, 14.99999!)
        Me.Cargo2.Name = "Cargo2"
        Me.Cargo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cargo2.SizeF = New System.Drawing.SizeF(250.0001!, 15.0!)
        Me.Cargo2.StylePriority.UseFont = False
        Me.Cargo2.StylePriority.UseTextAlignment = False
        Me.Cargo2.Text = "Empresa"
        Me.Cargo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pLogo, Me.XrPageInfo3, Me.XrPageInfo4, Me.Empresa, Me.Titulo, Me.Moneda, Me.Fecha})
        Me.ReportHeader.HeightF = 80.20834!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(1.04181!, 0.000002861023!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(123.9583!, 68.99999!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(976.04!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo3.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrPageInfo4
        '
        Me.XrPageInfo4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo4.LocationFloat = New DevExpress.Utils.PointFloat(976.0401!, 18.0!)
        Me.XrPageInfo4.Name = "XrPageInfo4"
        Me.XrPageInfo4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo4.SizeF = New System.Drawing.SizeF(73.96!, 18.0!)
        Me.XrPageInfo4.StylePriority.UseFont = False
        Me.XrPageInfo4.StylePriority.UseTextAlignment = False
        Me.XrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo4.TextFormatString = "{0:hh:mm tt}"
        '
        'Empresa
        '
        Me.Empresa.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa]")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 0.000002861023!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TituloReporte]")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 18.0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "Empresa"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Moneda]")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 36.0!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "Empresa"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Fecha
        '
        Me.Fecha.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fecha]")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 54.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(1050.0!, 18.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Empresa"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre1, Me.XrPageInfo1, Me.Cargo2, Me.Nombre2, Me.Cargo1, Me.Usuario, Me.Cargo3, Me.Nombre3})
        Me.PageFooter.HeightF = 30.00001!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptEstadoResultado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.ReportHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "19.2"
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
    Friend WithEvents SaldoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PorcentajeSaldoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents AcumuladoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PorcentajeAcumuadoAnterior As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cargo3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents pLogo As DevExpress.XtraReports.UI.XRPictureBox
End Class
