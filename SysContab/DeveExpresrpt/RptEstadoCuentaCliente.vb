Imports DevExpress.XtraReports.UI

Public Class RptEstadoCuentaCliente
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Cliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoMoneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Abono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Factura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Recibo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Accion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Monto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Saldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents AcumTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Periodo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GrpCliente As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents PieCliente As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SaldoU As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.SaldoU = New DevExpress.XtraReports.UI.XRLabel()
        Me.Saldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Monto = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Accion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Recibo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Abono = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Periodo = New DevExpress.XtraReports.UI.XRLabel()
        Me.SaldoMoneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.AcumTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpCliente = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.PieCliente = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SaldoU, Me.Saldo, Me.Monto, Me.Fecha, Me.Accion, Me.Recibo, Me.Factura, Me.Abono})
        Me.Detail.HeightF = 18.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SaldoU
        '
        Me.SaldoU.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.SaldoU.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoU", "{0:n2}")})
        Me.SaldoU.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.SaldoU.LocationFloat = New DevExpress.Utils.PointFloat(710.4167!, 0.0!)
        Me.SaldoU.Name = "SaldoU"
        Me.SaldoU.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoU.SizeF = New System.Drawing.SizeF(89.58331!, 18.0!)
        Me.SaldoU.StylePriority.UseTextAlignment = False
        Me.SaldoU.Text = "0.00"
        Me.SaldoU.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Saldo
        '
        Me.Saldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Saldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo", "{0:n2}")})
        Me.Saldo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Saldo.LocationFloat = New DevExpress.Utils.PointFloat(627.0833!, 0.0!)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Saldo.SizeF = New System.Drawing.SizeF(83.33337!, 18.0!)
        Me.Saldo.StylePriority.UseTextAlignment = False
        Me.Saldo.Text = "0.00"
        Me.Saldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Monto
        '
        Me.Monto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "{0:n2}")})
        Me.Monto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Monto.LocationFloat = New DevExpress.Utils.PointFloat(466.6667!, 0.0!)
        Me.Monto.Name = "Monto"
        Me.Monto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Monto.SizeF = New System.Drawing.SizeF(80.58328!, 18.0!)
        Me.Monto.StylePriority.UseTextAlignment = False
        Me.Monto.Text = "Monto"
        Me.Monto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd/MM/yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(61.95832!, 18.0!)
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Accion
        '
        Me.Accion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Accion")})
        Me.Accion.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Accion.LocationFloat = New DevExpress.Utils.PointFloat(61.95833!, 0.0!)
        Me.Accion.Name = "Accion"
        Me.Accion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Accion.SizeF = New System.Drawing.SizeF(70.0!, 18.0!)
        Me.Accion.StylePriority.UseTextAlignment = False
        Me.Accion.Text = "Accion"
        Me.Accion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Recibo
        '
        Me.Recibo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Recibo")})
        Me.Recibo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Recibo.LocationFloat = New DevExpress.Utils.PointFloat(197.5833!, 0.0!)
        Me.Recibo.Name = "Recibo"
        Me.Recibo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Recibo.SizeF = New System.Drawing.SizeF(269.0833!, 18.0!)
        Me.Recibo.StylePriority.UseTextAlignment = False
        Me.Recibo.Text = "Recibo"
        Me.Recibo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Factura
        '
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(131.9583!, 0.0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(65.625!, 18.0!)
        Me.Factura.StylePriority.UseTextAlignment = False
        Me.Factura.Text = "Factura"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Abono
        '
        Me.Abono.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Abono", "{0:n2}")})
        Me.Abono.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Abono.LocationFloat = New DevExpress.Utils.PointFloat(547.2499!, 0.0!)
        Me.Abono.Name = "Abono"
        Me.Abono.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Abono.SizeF = New System.Drawing.SizeF(79.83337!, 18.0!)
        Me.Abono.StylePriority.UseTextAlignment = False
        Me.Abono.Text = "Abono"
        Me.Abono.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.Empresa, Me.Periodo, Me.SaldoMoneda, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.Logo, Me.XrLabel3})
        Me.PageHeader.HeightF = 135.4167!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(710.4167!, 110.4167!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(89.58331!, 25.0!)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Saldo U$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.999992!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(800.0!, 25.0!)
        Me.Empresa.Text = "ESTADO DE CUENTA"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Periodo
        '
        Me.Periodo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Periodo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 57.99999!)
        Me.Periodo.Multiline = True
        Me.Periodo.Name = "Periodo"
        Me.Periodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Periodo.SizeF = New System.Drawing.SizeF(800.0!, 25.0!)
        Me.Periodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'SaldoMoneda
        '
        Me.SaldoMoneda.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.SaldoMoneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SaldoMoneda")})
        Me.SaldoMoneda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SaldoMoneda.LocationFloat = New DevExpress.Utils.PointFloat(627.0834!, 110.4167!)
        Me.SaldoMoneda.Name = "SaldoMoneda"
        Me.SaldoMoneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SaldoMoneda.SizeF = New System.Drawing.SizeF(83.33331!, 25.0!)
        Me.SaldoMoneda.StylePriority.UseTextAlignment = False
        Me.SaldoMoneda.Text = "Saldo"
        Me.SaldoMoneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(547.2499!, 110.4167!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(79.83344!, 25.0!)
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Abono"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(466.6667!, 110.4167!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(80.58328!, 25.0!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Monto"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(197.5833!, 110.4167!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(269.0833!, 25.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Recibo"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(131.9583!, 110.4167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(65.625!, 25.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Factura"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(61.95833!, 110.4167!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(70.0!, 25.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Accion"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 110.4167!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(61.95832!, 25.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Fecha"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Logo
        '
        Me.Logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Logo.Name = "Logo"
        Me.Logo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Logo.SizeF = New System.Drawing.SizeF(108.0!, 83.0!)
        Me.Logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 32.99999!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(800.0!, 25.0!)
        Me.XrLabel3.Text = "ESTADO DE CUENTA DE CLIENTES"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Cliente
        '
        Me.Cliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.Cliente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Cliente.LocationFloat = New DevExpress.Utils.PointFloat(82.99999!, 0.0!)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cliente.SizeF = New System.Drawing.SizeF(717.0!, 20.0!)
        Me.Cliente.Text = "Cliente :"
        Me.Cliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(83.0!, 20.0!)
        Me.XrLabel4.Text = "Cliente :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 34.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrPageInfo2.Format = "Fecha Impresion : {0:MM/dd/yyyy hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(490.0!, 17.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(300.0!, 16.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrPageInfo1.Format = "Pagina {0} de {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(665.0!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(125.0!, 16.0!)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel15, Me.XrLabel14, Me.XrLabel6, Me.AcumTotal})
        Me.ReportFooter.HeightF = 31.0!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AcumuladoU")})
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(710.4167!, 0.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(89.58331!, 25.0!)
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel19.Summary = XrSummary1
        Me.XrLabel19.Text = "AcumTotal"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Abono")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(547.2499!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(79.83325!, 25.0!)
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel15.Summary = XrSummary2
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto")})
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(433.3333!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(113.9167!, 25.0!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel14.Summary = XrSummary3
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(166.3333!, 25.0!)
        Me.XrLabel6.Text = "SALDO TOTAL"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'AcumTotal
        '
        Me.AcumTotal.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.AcumTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Acumulado")})
        Me.AcumTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.AcumTotal.LocationFloat = New DevExpress.Utils.PointFloat(627.0833!, 0.0!)
        Me.AcumTotal.Name = "AcumTotal"
        Me.AcumTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.AcumTotal.SizeF = New System.Drawing.SizeF(83.3335!, 25.0!)
        Me.AcumTotal.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.AcumTotal.Summary = XrSummary4
        Me.AcumTotal.Text = "AcumTotal"
        Me.AcumTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpCliente
        '
        Me.GrpCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Cliente, Me.XrLabel4})
        Me.GrpCliente.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Cliente", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpCliente.HeightF = 20.0!
        Me.GrpCliente.Name = "GrpCliente"
        Me.GrpCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GrpCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PieCliente
        '
        Me.PieCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel2, Me.XrLabel1})
        Me.PieCliente.HeightF = 20.00001!
        Me.PieCliente.Name = "PieCliente"
        Me.PieCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PieCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AcumuladoU")})
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(710.4167!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(89.58331!, 20.0!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel18.Summary = XrSummary5
        Me.XrLabel18.Text = "XrLabel17"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Acumulado")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(627.0833!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(83.33337!, 20.0!)
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel17.Summary = XrSummary6
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 0.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(166.3333!, 20.0!)
        Me.XrLabel16.Text = "TOTAL CLIENTE"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Abono")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(547.2499!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(79.83331!, 20.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel2.Summary = XrSummary7
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(433.3333!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(113.9167!, 20.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel1.Summary = XrSummary8
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'RptEstadoCuentaCliente
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter, Me.GrpCliente, Me.PieCliente, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Dim DAcumulado As Double = 0.0
    Dim DAcumuladoU As Double = 0.0

    Private Sub RptEstadoCuentaCliente_DataSourceRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles MyBase.DataSourceRowChanged
        'Dim Fila As DataRowView = GetCurrentRow()
        'DAcumulado += Fila.Item("Acumulado")
        'DAcumuladoU += Fila.Item("Monto") / ObtieneDatos("SET DATEFORMAT dmy;SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & CDate(Fila.Item("Fecha")).Date & "') Tasa").Rows.Item(0)("Tasa")
        'Acumulado.Text = Format(DAcumulado, "###,##0.00")   '"n2") 
        'Acumulado.Text = Format(DAcumulado, "n2")   '"n2") 
        'AcumuladoU.Text = Format(DAcumuladoU, "n2")   '"n2") 
    End Sub

    Private Sub GrpCliente_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpCliente.BeforePrint
        ' DAcumulado = 0 : DAcumuladoU = 0
    End Sub

    Private Sub PieCliente_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PieCliente.BeforePrint
        ' DAcumulado = 0 : DAcumuladoU = 0
    End Sub

    Private Sub RptEstadoCuentaCliente_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class

