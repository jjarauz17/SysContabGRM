Imports DevExpress.XtraReports.UI

Public Class RptCentrosdeCosto2
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(Me)
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
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents GrpCuenta As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents No As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Desde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Hasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Credito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Debito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CuentaCredito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CuentaDebito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalCredito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalDebito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Saldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CuentaSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpComprobante As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Saldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.No = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Credito = New DevExpress.XtraReports.UI.XRLabel()
        Me.Debito = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Hasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Desde = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.GrpCuenta = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.CuentaSaldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.CuentaCredito = New DevExpress.XtraReports.UI.XRLabel()
        Me.CuentaDebito = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TotalCredito = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalDebito = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.TotalSaldo = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpComprobante = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Saldo, Me.XrLabel15, Me.Cuenta, Me.No, Me.XrLabel14, Me.Credito, Me.Debito})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'Saldo
        '
        Me.Saldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo", "{0:n2}")})
        Me.Saldo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Saldo.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 0.0!)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Saldo.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary1.FormatString = "{0:n2}"
        Me.Saldo.Summary = XrSummary1
        Me.Saldo.Text = "XrLabel11"
        Me.Saldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tipo")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(442.0!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.XrLabel15.Text = "Cuenta:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto")})
        Me.Cuenta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 0.0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'No
        '
        Me.No.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comp")})
        Me.No.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.No.LocationFloat = New DevExpress.Utils.PointFloat(133.0!, 0.0!)
        Me.No.Name = "No"
        Me.No.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.No.SizeF = New System.Drawing.SizeF(42.0!, 25.0!)
        Me.No.Text = "Cuenta:"
        Me.No.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(55.0!, 25.0!)
        Me.XrLabel14.Text = "Comp No:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Credito
        '
        Me.Credito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito", "{0:n2}")})
        Me.Credito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Credito.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 0.0!)
        Me.Credito.Name = "Credito"
        Me.Credito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Credito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary2.FormatString = "{0:n2}"
        Me.Credito.Summary = XrSummary2
        Me.Credito.Text = "Credito"
        Me.Credito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Debito
        '
        Me.Debito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito", "{0:n2}")})
        Me.Debito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Debito.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 0.0!)
        Me.Debito.Name = "Debito"
        Me.Debito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Debito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary3.FormatString = "{0:n2}"
        Me.Debito.Summary = XrSummary3
        Me.Debito.Text = "Debito"
        Me.Debito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(133.0!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(250.0!, 25.0!)
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "No")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 0.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.XrLabel12.Text = "Cuenta:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.Hasta, Me.XrLabel9, Me.Desde, Me.XrLabel8, Me.XrLabel2, Me.XrLabel4, Me.XrLabel5, Me.XrPageInfo1, Me.XrLabel6})
        Me.PageHeader.HeightF = 92.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 67.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.XrLabel22.Text = "Saldo"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Hasta
        '
        Me.Hasta.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Hasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hasta")})
        Me.Hasta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Hasta.LocationFloat = New DevExpress.Utils.PointFloat(458.0!, 25.0!)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Hasta.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.Hasta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(399.0!, 25.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(59.0!, 25.0!)
        Me.XrLabel9.Text = "Hasta:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Desde
        '
        Me.Desde.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Desde.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Desde")})
        Me.Desde.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Desde.LocationFloat = New DevExpress.Utils.PointFloat(267.0!, 25.0!)
        Me.Desde.Name = "Desde"
        Me.Desde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desde.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.Desde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(208.0!, 25.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(59.0!, 25.0!)
        Me.XrLabel8.Text = "Desde:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 67.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(350.0!, 25.0!)
        Me.XrLabel2.Text = "Cuenta"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 67.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.XrLabel4.Text = "Creditos"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 67.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        Me.XrLabel5.Text = "Debitos"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrPageInfo1.Format = "Pagina {0} de {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(650.0!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(208.0!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(333.0!, 25.0!)
        Me.XrLabel6.Text = "REPORTE DE DISTRIBUCION POR CENTROS DE COSTO"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 26.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GrpCuenta
        '
        Me.GrpCuenta.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.CuentaSaldo, Me.XrLabel13, Me.XrLabel12, Me.CuentaCredito, Me.CuentaDebito})
        Me.GrpCuenta.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("No", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpCuenta.HeightF = 25.0!
        Me.GrpCuenta.Level = 1
        Me.GrpCuenta.Name = "GrpCuenta"
        Me.GrpCuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GrpCuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CuentaSaldo
        '
        Me.CuentaSaldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo")})
        Me.CuentaSaldo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CuentaSaldo.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 0.0!)
        Me.CuentaSaldo.Name = "CuentaSaldo"
        Me.CuentaSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CuentaSaldo.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.CuentaSaldo.Summary = XrSummary4
        Me.CuentaSaldo.Text = "Credito"
        Me.CuentaSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CuentaCredito
        '
        Me.CuentaCredito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito")})
        Me.CuentaCredito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CuentaCredito.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 0.0!)
        Me.CuentaCredito.Name = "CuentaCredito"
        Me.CuentaCredito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CuentaCredito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.CuentaCredito.Summary = XrSummary5
        Me.CuentaCredito.Text = "CuentaCredito"
        Me.CuentaCredito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CuentaDebito
        '
        Me.CuentaDebito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito")})
        Me.CuentaDebito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CuentaDebito.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 0.0!)
        Me.CuentaDebito.Name = "CuentaDebito"
        Me.CuentaDebito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CuentaDebito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.CuentaDebito.Summary = XrSummary6
        Me.CuentaDebito.Text = "CuentaDebito"
        Me.CuentaDebito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine1.SizeF = New System.Drawing.SizeF(250.0!, 8.0!)
        '
        'TotalCredito
        '
        Me.TotalCredito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito")})
        Me.TotalCredito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalCredito.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 8.0!)
        Me.TotalCredito.Name = "TotalCredito"
        Me.TotalCredito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalCredito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.TotalCredito.Summary = XrSummary7
        Me.TotalCredito.Text = "TotalCredito"
        Me.TotalCredito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TotalDebito
        '
        Me.TotalDebito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito")})
        Me.TotalDebito.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalDebito.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 8.0!)
        Me.TotalDebito.Name = "TotalDebito"
        Me.TotalDebito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalDebito.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.TotalDebito.Summary = XrSummary8
        Me.TotalDebito.Text = "TotalDebito"
        Me.TotalDebito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TotalSaldo, Me.TotalDebito, Me.TotalCredito, Me.XrLine1})
        Me.ReportFooter.HeightF = 35.0!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TotalSaldo
        '
        Me.TotalSaldo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo")})
        Me.TotalSaldo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalSaldo.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 8.0!)
        Me.TotalSaldo.Name = "TotalSaldo"
        Me.TotalSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalSaldo.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.TotalSaldo.Summary = XrSummary9
        Me.TotalSaldo.Text = "XrLabel16"
        Me.TotalSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GrpComprobante
        '
        Me.GrpComprobante.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel16, Me.XrLabel11, Me.XrLabel10, Me.XrLabel7, Me.XrLabel3, Me.XrLabel1})
        Me.GrpComprobante.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Comp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpComprobante.HeightF = 25.0!
        Me.GrpComprobante.Name = "GrpComprobante"
        Me.GrpComprobante.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GrpComprobante.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Saldo")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel17.Summary = XrSummary10
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito")})
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 0.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel16.Summary = XrSummary11
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comp")})
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(133.0!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(42.0!, 25.0!)
        Me.XrLabel11.Text = "Cuenta:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(55.0!, 25.0!)
        Me.XrLabel10.Text = "Comp No:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito")})
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(83.0!, 25.0!)
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel7.Summary = XrSummary12
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tipo")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(442.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.XrLabel1.Text = "Cuenta:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 80.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 80.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'RptCentrosdeCosto2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpCuenta, Me.ReportFooter, Me.GrpComprobante, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 80, 80)
        Me.Version = "12.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub No_PreviewClick(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles XrLabel11.PreviewClick
        Dim view As DataRowView
        'view = e.Data.Tag
        view = e.Brick.TextValue

        'Dim f As DataGridTextBox.frmComprobantesDetalles = DataGridTextBox.frmComprobantesDetalles.Instance()
        'f.Temp = True
        'f.lblNoComprobante.Text = view.Row.Item("Comp")
        'f.lblPeriodo.Text = view.Row.Item("Periodo")
        'f.txtFecha.Text = view.Row.Item("Fecha")
        'f.Show()

        Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        'f.Temp = True
        f.txtlNoComprobante.Text = view.Row.Item("Comp")
        f.Periodo = view.Row.Item("Periodo")
        f.Fecha.EditValue = view.Row.Item("Fecha")
        f.Fecha1 = view.Row.Item("Fecha")
        f.ComprobanteID = 0
        f.TipoLiq = 0
        f.StartPosition = FormStartPosition.CenterScreen
        f.cmdAceptar.Enabled = False
        f.cmdAnular.Enabled = False
        f.cmdAyuda.Enabled = False
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub No_PreviewMouseMove(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles XrLabel11.PreviewMouseMove
        Cursor.Current = Cursors.Hand
    End Sub

    Private Sub No_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel11.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()
    End Sub
End Class

