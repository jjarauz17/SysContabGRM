Imports DevExpress.XtraReports.UI

Public Class RptAnalisisAntiguedadCxP

    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
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
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpCliente As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Mas180 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ciento50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Noventa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sesenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Treinta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Corriente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Corte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Original As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Factura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Public WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Ultima As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Encabezado As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents GrpMas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Public WithEvents Emrpesa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ciento20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ciento80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp150 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp180 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpMas180 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpOriginal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpCorte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpCorriente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grp90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Proveedor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ClienteCodigo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOP As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents OrdenP As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFactura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
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
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary19 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary20 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary21 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary22 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary23 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary24 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary25 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary26 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.OrdenP = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ciento80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ciento20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Corte = New DevExpress.XtraReports.UI.XRLabel()
        Me.Corriente = New DevExpress.XtraReports.UI.XRLabel()
        Me.Treinta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sesenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Noventa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ciento50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Mas180 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Original = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblFactura = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOP = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Emrpesa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ultima = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Encabezado = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpMas = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GrpOriginal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ClienteCodigo = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpCliente = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GrpCorte = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpCorriente = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp150 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Grp180 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GrpMas180 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Proveedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.OrdenP, Me.Ciento80, Me.Ciento20, Me.Fecha, Me.Corte, Me.Corriente, Me.Treinta, Me.Sesenta, Me.Noventa, Me.Ciento50, Me.Mas180, Me.Factura})
        Me.Detail.HeightF = 17.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'OrdenP
        '
        Me.OrdenP.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdenP")})
        Me.OrdenP.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.OrdenP.LocationFloat = New DevExpress.Utils.PointFloat(66.66668!, 0.0!)
        Me.OrdenP.Name = "OrdenP"
        Me.OrdenP.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.OrdenP.SizeF = New System.Drawing.SizeF(74.99982!, 17.0!)
        Me.OrdenP.Text = "Factura"
        Me.OrdenP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Ciento80
        '
        Me.Ciento80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "180", "{0:n2}")})
        Me.Ciento80.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciento80.LocationFloat = New DevExpress.Utils.PointFloat(880.0!, 0.0!)
        Me.Ciento80.Name = "Ciento80"
        Me.Ciento80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ciento80.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Ciento80.StylePriority.UseFont = False
        Me.Ciento80.StylePriority.UseTextAlignment = False
        Me.Ciento80.Text = "90 > Dias"
        Me.Ciento80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Ciento20
        '
        Me.Ciento20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "120", "{0:n2}")})
        Me.Ciento20.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciento20.LocationFloat = New DevExpress.Utils.PointFloat(710.0001!, 0.0!)
        Me.Ciento20.Name = "Ciento20"
        Me.Ciento20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ciento20.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Ciento20.StylePriority.UseFont = False
        Me.Ciento20.StylePriority.UseTextAlignment = False
        Me.Ciento20.Text = "61-90 Dias"
        Me.Ciento20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd/MM/yy}")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(66.66666!, 17.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Corte
        '
        Me.Corte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corte", "{0:n2}")})
        Me.Corte.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte.LocationFloat = New DevExpress.Utils.PointFloat(285.0!, 0.0!)
        Me.Corte.Name = "Corte"
        Me.Corte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Corte.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Corte.StylePriority.UseFont = False
        Me.Corte.StylePriority.UseTextAlignment = False
        Me.Corte.Text = "Saldo al Corte"
        Me.Corte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Corriente
        '
        Me.Corriente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corriente", "{0:n2}")})
        Me.Corriente.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corriente.LocationFloat = New DevExpress.Utils.PointFloat(370.0!, 0.0!)
        Me.Corriente.Name = "Corriente"
        Me.Corriente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Corriente.SizeF = New System.Drawing.SizeF(85.00009!, 17.0!)
        Me.Corriente.StylePriority.UseFont = False
        Me.Corriente.StylePriority.UseTextAlignment = False
        Me.Corriente.Text = "Saldo Sin Vencer"
        Me.Corriente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Treinta
        '
        Me.Treinta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Treinta", "{0:n2}")})
        Me.Treinta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treinta.LocationFloat = New DevExpress.Utils.PointFloat(455.0001!, 0.0!)
        Me.Treinta.Name = "Treinta"
        Me.Treinta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Treinta.SizeF = New System.Drawing.SizeF(84.99994!, 17.0!)
        Me.Treinta.StylePriority.UseFont = False
        Me.Treinta.StylePriority.UseTextAlignment = False
        Me.Treinta.Text = "1-30 Dias"
        Me.Treinta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Sesenta
        '
        Me.Sesenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sesenta", "{0:n2}")})
        Me.Sesenta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sesenta.LocationFloat = New DevExpress.Utils.PointFloat(539.9999!, 0.0!)
        Me.Sesenta.Name = "Sesenta"
        Me.Sesenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sesenta.SizeF = New System.Drawing.SizeF(85.00012!, 17.0!)
        Me.Sesenta.StylePriority.UseFont = False
        Me.Sesenta.StylePriority.UseTextAlignment = False
        Me.Sesenta.Text = "31-60 Dias"
        Me.Sesenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Noventa
        '
        Me.Noventa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Noventa", "{0:n2}")})
        Me.Noventa.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Noventa.LocationFloat = New DevExpress.Utils.PointFloat(625.0001!, 0.0!)
        Me.Noventa.Name = "Noventa"
        Me.Noventa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Noventa.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Noventa.StylePriority.UseFont = False
        Me.Noventa.StylePriority.UseTextAlignment = False
        Me.Noventa.Text = "61-90 Dias"
        Me.Noventa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Ciento50
        '
        Me.Ciento50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "150", "{0:n2}")})
        Me.Ciento50.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciento50.LocationFloat = New DevExpress.Utils.PointFloat(795.0001!, 0.0!)
        Me.Ciento50.Name = "Ciento50"
        Me.Ciento50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ciento50.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Ciento50.StylePriority.UseFont = False
        Me.Ciento50.StylePriority.UseTextAlignment = False
        Me.Ciento50.Text = "90 > Dias"
        Me.Ciento50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Mas180
        '
        Me.Mas180.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Mas180", "{0:n2}")})
        Me.Mas180.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mas180.LocationFloat = New DevExpress.Utils.PointFloat(964.9999!, 0.0!)
        Me.Mas180.Name = "Mas180"
        Me.Mas180.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Mas180.SizeF = New System.Drawing.SizeF(85.00012!, 17.0!)
        Me.Mas180.StylePriority.UseFont = False
        Me.Mas180.StylePriority.UseTextAlignment = False
        Me.Mas180.Text = "Creditos"
        Me.Mas180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Factura
        '
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(141.6665!, 0.0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(143.3334!, 17.0!)
        Me.Factura.Text = "Factura"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Original
        '
        Me.Original.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Original", "{0:n2}")})
        Me.Original.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Original.LocationFloat = New DevExpress.Utils.PointFloat(339.7918!, 6.00001!)
        Me.Original.Name = "Original"
        Me.Original.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Original.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Original.StylePriority.UseFont = False
        Me.Original.StylePriority.UseTextAlignment = False
        Me.Original.Text = "Saldo Orignal"
        Me.Original.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Original.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblFactura, Me.lblCliente, Me.lblOP, Me.XrPictureBox1, Me.XrLabel1, Me.XrLabel2, Me.Emrpesa, Me.Ultima, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.Titulo, Me.Encabezado})
        Me.PageHeader.HeightF = 116.2083!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblFactura
        '
        Me.lblFactura.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFactura.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblFactura.LocationFloat = New DevExpress.Utils.PointFloat(141.6665!, 88.08333!)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFactura.SizeF = New System.Drawing.SizeF(143.3335!, 25.0!)
        Me.lblFactura.StylePriority.UseBorders = False
        Me.lblFactura.StylePriority.UseFont = False
        Me.lblFactura.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        Me.lblFactura.Summary = XrSummary1
        Me.lblFactura.Text = "Factura"
        Me.lblFactura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblCliente.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblCliente.LocationFloat = New DevExpress.Utils.PointFloat(0.0001509984!, 88.08333!)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCliente.SizeF = New System.Drawing.SizeF(66.66656!, 25.0!)
        Me.lblCliente.StylePriority.UseBorders = False
        Me.lblCliente.StylePriority.UseFont = False
        Me.lblCliente.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        Me.lblCliente.Summary = XrSummary2
        Me.lblCliente.Text = "Fecha"
        Me.lblCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblOP
        '
        Me.lblOP.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblOP.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblOP.LocationFloat = New DevExpress.Utils.PointFloat(66.6667!, 88.08333!)
        Me.lblOP.Name = "lblOP"
        Me.lblOP.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblOP.SizeF = New System.Drawing.SizeF(74.99982!, 25.0!)
        Me.lblOP.StylePriority.UseBorders = False
        Me.lblOP.StylePriority.UseFont = False
        Me.lblOP.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        Me.lblOP.Summary = XrSummary3
        Me.lblOP.Text = "O / P"
        Me.lblOP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(89.58334!, 74.54166!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(285.0001!, 88.08333!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Saldo al Corte"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(455.0001!, 88.08333!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "1-30 Días"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Emrpesa
        '
        Me.Emrpesa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Emrpesa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emrpesa.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 0.0!)
        Me.Emrpesa.Name = "Emrpesa"
        Me.Emrpesa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Emrpesa.SizeF = New System.Drawing.SizeF(1050.0!, 20.0!)
        Me.Emrpesa.StylePriority.UseFont = False
        Me.Emrpesa.Text = "SALDO DE LOS CLIENTES"
        Me.Emrpesa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Ultima
        '
        Me.Ultima.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Ultima.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ultima.LocationFloat = New DevExpress.Utils.PointFloat(965.0002!, 88.08333!)
        Me.Ultima.Name = "Ultima"
        Me.Ultima.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ultima.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.Ultima.StylePriority.UseBorders = False
        Me.Ultima.StylePriority.UseFont = False
        Me.Ultima.StylePriority.UseTextAlignment = False
        Me.Ultima.Text = "Mas 180 Días"
        Me.Ultima.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(880.0001!, 88.08333!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "151-180 Días"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(795.0001!, 88.08333!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "121-150 Días"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(710.0001!, 88.08333!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "91-120 Días"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(625.0001!, 88.08333!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "61-90 Días"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(540.0001!, 88.08333!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "31-60 Días"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(370.0002!, 88.08333!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Sin Vencer"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Titulo
        '
        Me.Titulo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Titulo", "Fecha Corte : {0:dd - MM - yyyy}")})
        Me.Titulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 39.99999!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(1050.0!, 20.0!)
        Me.Titulo.StylePriority.UseFont = False
        Me.Titulo.Text = "Fecha de Corte :"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Encabezado
        '
        Me.Encabezado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Encabezado")})
        Me.Encabezado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encabezado.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 20.0!)
        Me.Encabezado.Multiline = True
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Encabezado.SizeF = New System.Drawing.SizeF(1050.0!, 20.0!)
        Me.Encabezado.StylePriority.UseFont = False
        Me.Encabezado.Text = "ESTADO DE ANTIGUEDAD DE SALDOS"
        Me.Encabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(169.7918!, 2.000014!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Saldo Orignal"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel4.Visible = False
        '
        'GrpMas
        '
        Me.GrpMas.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.GrpMas.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MasNoventa")})
        Me.GrpMas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMas.LocationFloat = New DevExpress.Utils.PointFloat(52.0!, 10.00001!)
        Me.GrpMas.Name = "GrpMas"
        Me.GrpMas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GrpMas.SizeF = New System.Drawing.SizeF(100.0!, 17.0!)
        Me.GrpMas.StylePriority.UseFont = False
        Me.GrpMas.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.GrpMas.Summary = XrSummary4
        Me.GrpMas.Text = "XrLabel19"
        Me.GrpMas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.GrpMas.Visible = False
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1, Me.GrpMas, Me.XrLabel4, Me.GrpOriginal, Me.Original, Me.XrLabel48, Me.ClienteCodigo})
        Me.PageFooter.HeightF = 33.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrPageInfo2.Format = "Fecha Impresion : {0:MM/dd/yyyy hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(750.0!, 17.0!)
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
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(925.0!, 1.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(125.0!, 16.0!)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpOriginal
        '
        Me.GrpOriginal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Original")})
        Me.GrpOriginal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpOriginal.LocationFloat = New DevExpress.Utils.PointFloat(254.7918!, 6.00001!)
        Me.GrpOriginal.Name = "GrpOriginal"
        Me.GrpOriginal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GrpOriginal.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.GrpOriginal.StylePriority.UseFont = False
        Me.GrpOriginal.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.GrpOriginal.Summary = XrSummary5
        Me.GrpOriginal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.GrpOriginal.Visible = False
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Original")})
        Me.XrLabel48.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(435.4167!, 2.000014!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel48.Summary = XrSummary6
        Me.XrLabel48.Text = "XrLabel48"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel48.Visible = False
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Codigo")})
        Me.ClienteCodigo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteCodigo.LocationFloat = New DevExpress.Utils.PointFloat(520.4166!, 6.00001!)
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ClienteCodigo.SizeF = New System.Drawing.SizeF(42.00001!, 17.0!)
        Me.ClienteCodigo.StylePriority.UseFont = False
        Me.ClienteCodigo.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        Me.ClienteCodigo.Summary = XrSummary7
        Me.ClienteCodigo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ClienteCodigo.Visible = False
        '
        'GrpCliente
        '
        Me.GrpCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.GrpCorte, Me.GrpCorriente, Me.Grp30, Me.Grp60, Me.Grp90, Me.Grp120, Me.Grp150, Me.Grp180, Me.GrpMas180, Me.Proveedor})
        Me.GrpCliente.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.GrpCliente.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Proveedor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpCliente.HeightF = 17.0!
        Me.GrpCliente.Name = "GrpCliente"
        Me.GrpCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GrpCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GrpCorte
        '
        Me.GrpCorte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corte")})
        Me.GrpCorte.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCorte.LocationFloat = New DevExpress.Utils.PointFloat(285.0!, 0.0!)
        Me.GrpCorte.Name = "GrpCorte"
        Me.GrpCorte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GrpCorte.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.GrpCorte.StylePriority.UseFont = False
        Me.GrpCorte.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.GrpCorte.Summary = XrSummary8
        Me.GrpCorte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpCorriente
        '
        Me.GrpCorriente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corriente")})
        Me.GrpCorriente.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCorriente.LocationFloat = New DevExpress.Utils.PointFloat(369.9999!, 0.0!)
        Me.GrpCorriente.Name = "GrpCorriente"
        Me.GrpCorriente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GrpCorriente.SizeF = New System.Drawing.SizeF(85.00009!, 17.0!)
        Me.GrpCorriente.StylePriority.UseFont = False
        Me.GrpCorriente.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.GrpCorriente.Summary = XrSummary9
        Me.GrpCorriente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp30
        '
        Me.Grp30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Treinta")})
        Me.Grp30.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp30.LocationFloat = New DevExpress.Utils.PointFloat(455.0001!, 0.0!)
        Me.Grp30.Name = "Grp30"
        Me.Grp30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp30.SizeF = New System.Drawing.SizeF(84.99994!, 17.0!)
        Me.Grp30.StylePriority.UseFont = False
        Me.Grp30.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp30.Summary = XrSummary10
        Me.Grp30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp60
        '
        Me.Grp60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sesenta")})
        Me.Grp60.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp60.LocationFloat = New DevExpress.Utils.PointFloat(539.9999!, 0.0!)
        Me.Grp60.Name = "Grp60"
        Me.Grp60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp60.SizeF = New System.Drawing.SizeF(85.00012!, 17.0!)
        Me.Grp60.StylePriority.UseFont = False
        Me.Grp60.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:#.00}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp60.Summary = XrSummary11
        Me.Grp60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp90
        '
        Me.Grp90.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Noventa")})
        Me.Grp90.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp90.LocationFloat = New DevExpress.Utils.PointFloat(625.0!, 0.0!)
        Me.Grp90.Name = "Grp90"
        Me.Grp90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp90.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Grp90.StylePriority.UseFont = False
        Me.Grp90.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp90.Summary = XrSummary12
        Me.Grp90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp120
        '
        Me.Grp120.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "120")})
        Me.Grp120.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp120.LocationFloat = New DevExpress.Utils.PointFloat(710.0001!, 0.0!)
        Me.Grp120.Name = "Grp120"
        Me.Grp120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp120.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Grp120.StylePriority.UseFont = False
        Me.Grp120.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp120.Summary = XrSummary13
        Me.Grp120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp150
        '
        Me.Grp150.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "150")})
        Me.Grp150.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp150.LocationFloat = New DevExpress.Utils.PointFloat(795.0001!, 0.0!)
        Me.Grp150.Name = "Grp150"
        Me.Grp150.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp150.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Grp150.StylePriority.UseFont = False
        Me.Grp150.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp150.Summary = XrSummary14
        Me.Grp150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Grp180
        '
        Me.Grp180.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "180")})
        Me.Grp180.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp180.LocationFloat = New DevExpress.Utils.PointFloat(879.9999!, 0.0!)
        Me.Grp180.Name = "Grp180"
        Me.Grp180.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grp180.SizeF = New System.Drawing.SizeF(85.0!, 17.0!)
        Me.Grp180.StylePriority.UseFont = False
        Me.Grp180.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.Grp180.Summary = XrSummary15
        Me.Grp180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpMas180
        '
        Me.GrpMas180.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Mas180")})
        Me.GrpMas180.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMas180.LocationFloat = New DevExpress.Utils.PointFloat(964.9998!, 0.0!)
        Me.GrpMas180.Name = "GrpMas180"
        Me.GrpMas180.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GrpMas180.SizeF = New System.Drawing.SizeF(85.00012!, 17.0!)
        Me.GrpMas180.StylePriority.UseFont = False
        Me.GrpMas180.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.GrpMas180.Summary = XrSummary16
        Me.GrpMas180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Proveedor
        '
        Me.Proveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Proveedor")})
        Me.Proveedor.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedor.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0.0!)
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Proveedor.SizeF = New System.Drawing.SizeF(284.9998!, 17.0!)
        Me.Proveedor.StylePriority.UseFont = False
        Me.Proveedor.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:n2}"
        Me.Proveedor.Summary = XrSummary17
        Me.Proveedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel37, Me.XrLabel30, Me.XrLabel34, Me.XrLabel28, Me.XrLabel33, Me.XrLabel32})
        Me.ReportFooter.HeightF = 40.0!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "120")})
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(710.0001!, 5.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel16.Summary = XrSummary18
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "150")})
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(795.0001!, 5.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        XrSummary19.FormatString = "{0:n2}"
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary19
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "180")})
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(880.0!, 5.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel18.Summary = XrSummary20
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Mas180")})
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(964.9999!, 5.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(85.00012!, 25.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        XrSummary21.FormatString = "{0:n2}"
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel19.Summary = XrSummary21
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel37
        '
        Me.XrLabel37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel37.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 4.999987!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(284.9999!, 25.0!)
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.Text = "GRAN TOTAL"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sesenta")})
        Me.XrLabel30.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(540.0!, 5.0!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(85.00006!, 25.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        XrSummary22.FormatString = "{0:n2}"
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel30.Summary = XrSummary22
        Me.XrLabel30.Text = "XrLabel30"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corriente")})
        Me.XrLabel34.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(370.0!, 5.0!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(85.00012!, 25.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        XrSummary23.FormatString = "{0:n2}"
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel34.Summary = XrSummary23
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Treinta")})
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(455.0001!, 5.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(84.99982!, 25.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        XrSummary24.FormatString = "{0:n2}"
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel28.Summary = XrSummary24
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Corte")})
        Me.XrLabel33.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(285.0!, 5.0!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        XrSummary25.FormatString = "{0:n2}"
        XrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel33.Summary = XrSummary25
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Noventa")})
        Me.XrLabel32.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(625.0001!, 5.0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(85.0!, 25.0!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        XrSummary26.FormatString = "{0:n2}"
        XrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel32.Summary = XrSummary26
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        'RptAnalisisAntiguedadCxP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpCliente, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "14.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Detalle As Boolean = False
    Private Sub RptAnalisisAntiguedad_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Me.Detail.Visible = Detalle

        Me.lblOP.Text = IIf(Detalle, "O / P", "")
        Me.lblFactura.Text = IIf(Detalle, "Factura", "")
        Me.lblCliente.Text = IIf(Detalle, "Fecha", "Proveedor")

        If Detalle Then

            Me.ClienteCodigo.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Proveedor.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.GrpOriginal.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.GrpCorte.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.GrpCorriente.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp30.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp60.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp90.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp120.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp150.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.Grp180.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)
            Me.GrpMas180.Font = New System.Drawing.Font("Tahoma", 6.75, FontStyle.Bold)

            ' rpt.Cliente.Font = New System.Drawing.Font("Tahoma", 7, FontStyle.Bold)
            'rpt.GrpMas.Font = New System.Drawing.Font("Tahoma", 7, FontStyle.Bold)
        End If
    End Sub
End Class

