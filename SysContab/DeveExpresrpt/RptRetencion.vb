Imports DevExpress.XtraReports.UI

Public Class RptRetencion
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
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents GrpRetencion As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents Ruc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tasa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cheque As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalD As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IvaD As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cedula As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Concepto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IvaC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PieRetencion As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Concepto2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tasa2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Ciudad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GrpRetencion = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.Ciudad = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.Fecha2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tasa2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.Nombre2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.Concepto2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.IvaC = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.Concepto = New DevExpress.XtraReports.UI.XRLabel
        Me.Cedula = New DevExpress.XtraReports.UI.XRLabel
        Me.IvaD = New DevExpress.XtraReports.UI.XRLabel
        Me.TotalC = New DevExpress.XtraReports.UI.XRLabel
        Me.TotalD = New DevExpress.XtraReports.UI.XRLabel
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Cheque = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tasa = New DevExpress.XtraReports.UI.XRLabel
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel
        Me.Ruc = New DevExpress.XtraReports.UI.XRLabel
        Me.PieRetencion = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Height = 0
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GrpRetencion
        '
        Me.GrpRetencion.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Ciudad, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel22, Me.XrLabel7, Me.XrLabel29, Me.XrLabel28, Me.Fecha2, Me.XrLabel26, Me.Tasa2, Me.XrLabel24, Me.XrLabel23, Me.Nombre2, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel8, Me.Concepto2, Me.XrLabel6, Me.XrLabel5, Me.XrLabel13, Me.IvaC, Me.XrLabel12, Me.XrLabel10, Me.XrLabel11, Me.Concepto, Me.Cedula, Me.IvaD, Me.TotalC, Me.TotalD, Me.Nombre, Me.XrLabel4, Me.XrLabel2, Me.XrLabel1, Me.XrLabel3, Me.Cheque, Me.XrLabel9, Me.Tasa, Me.Fecha, Me.Ruc})
        Me.GrpRetencion.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Cheque", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Banco", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpRetencion.Height = 692
        Me.GrpRetencion.Name = "GrpRetencion"
        Me.GrpRetencion.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GrpRetencion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Ciudad
        '
        Me.Ciudad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ciudad", "")})
        Me.Ciudad.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Ciudad.Location = New System.Drawing.Point(517, 183)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ciudad.Size = New System.Drawing.Size(158, 25)
        Me.Ciudad.StylePriority.UseTextAlignment = False
        Me.Ciudad.Text = "Cheque No."
        Me.Ciudad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Location = New System.Drawing.Point(650, 383)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.Size = New System.Drawing.Size(92, 67)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Location = New System.Drawing.Point(650, 8)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.Size = New System.Drawing.Size(92, 67)
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel22.Location = New System.Drawing.Point(492, 667)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel22.Text = "RESPONSABLE"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.Location = New System.Drawing.Point(492, 300)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel7.Text = "RESPONSABLE"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel29.Location = New System.Drawing.Point(17, 383)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel29.Text = "FECHA :"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IvaD", "{0:n2}")})
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel28.Location = New System.Drawing.Point(542, 492)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel28.Text = "IvaD"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha2
        '
        Me.Fecha2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dddd, dd 'de' MMMM 'del' yyyy}")})
        Me.Fecha2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Fecha2.Location = New System.Drawing.Point(100, 383)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha2.Size = New System.Drawing.Size(267, 25)
        Me.Fecha2.Text = "Fecha"
        Me.Fecha2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel26.Location = New System.Drawing.Point(17, 492)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel26.Text = "COMPRA ANTES DEL IVA C$"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tasa2
        '
        Me.Tasa2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tasa", "{0}")})
        Me.Tasa2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tasa2.Location = New System.Drawing.Point(183, 550)
        Me.Tasa2.Name = "Tasa2"
        Me.Tasa2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tasa2.Size = New System.Drawing.Size(325, 25)
        Me.Tasa2.Text = "Tasa"
        Me.Tasa2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel24.Location = New System.Drawing.Point(392, 442)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel24.Text = "CEDULA :"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel23.Location = New System.Drawing.Point(17, 408)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel23.Text = "RETENIDO A :"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre2
        '
        Me.Nombre2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Nombre2.Location = New System.Drawing.Point(100, 408)
        Me.Nombre2.Name = "Nombre2"
        Me.Nombre2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre2.Size = New System.Drawing.Size(283, 25)
        Me.Nombre2.Text = "Nombre"
        Me.Nombre2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalC", "{0:n2}")})
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel21.Location = New System.Drawing.Point(233, 517)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel21.Text = "TotalC"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalD", "{0:n2}")})
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel20.Location = New System.Drawing.Point(542, 517)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel20.Text = "TotalD"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel19.Location = New System.Drawing.Point(17, 550)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel19.Text = "TASA DE RETENCION : "
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel18.Location = New System.Drawing.Point(342, 517)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel18.Text = "--> EQUIVALENTE A US$ :"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cheque", "CHEQUE NO. - {0}")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel17.Location = New System.Drawing.Point(508, 383)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel17.Text = "Cheque No."
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel16.Location = New System.Drawing.Point(342, 492)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel16.Text = "--> EQUIVALENTE A US$ :"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.Location = New System.Drawing.Point(17, 442)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel15.Text = "RUC :"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel14.Location = New System.Drawing.Point(17, 517)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel14.Text = "MONTO RETENIDO C$"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cedula", "")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.Location = New System.Drawing.Point(450, 442)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(183, 25)
        Me.XrLabel8.Text = "Cedula"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Concepto2
        '
        Me.Concepto2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto", "EN CONCEPTO DE : {0}")})
        Me.Concepto2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Concepto2.Location = New System.Drawing.Point(17, 600)
        Me.Concepto2.Name = "Concepto2"
        Me.Concepto2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto2.Size = New System.Drawing.Size(633, 25)
        Me.Concepto2.Text = "EN CONCEPTO DE : "
        Me.Concepto2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IvaC", "{0:n2}")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel6.Location = New System.Drawing.Point(233, 492)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel6.Text = "IvaC"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ruc", "")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel5.Location = New System.Drawing.Point(100, 442)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(267, 25)
        Me.XrLabel5.Text = "Ruc"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.Location = New System.Drawing.Point(342, 125)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel13.Text = "--> EQUIVALENTE A US$ :"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'IvaC
        '
        Me.IvaC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IvaC", "{0:n2}")})
        Me.IvaC.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.IvaC.Location = New System.Drawing.Point(233, 125)
        Me.IvaC.Name = "IvaC"
        Me.IvaC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.IvaC.Size = New System.Drawing.Size(92, 25)
        Me.IvaC.Text = "IvaC"
        Me.IvaC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel12.Location = New System.Drawing.Point(342, 150)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel12.Text = "--> EQUIVALENTE A US$ :"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel10.Location = New System.Drawing.Point(17, 183)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel10.Text = "TASA DE RETENCION : "
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel11.Location = New System.Drawing.Point(17, 150)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel11.Text = "MONTO RETENIDO C$"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Concepto
        '
        Me.Concepto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto", "EN CONCEPTO DE : {0}")})
        Me.Concepto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Concepto.Location = New System.Drawing.Point(17, 233)
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto.Size = New System.Drawing.Size(633, 25)
        Me.Concepto.Text = "EN CONCEPTO DE : "
        Me.Concepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cedula
        '
        Me.Cedula.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cedula", "")})
        Me.Cedula.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cedula.Location = New System.Drawing.Point(450, 75)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cedula.Size = New System.Drawing.Size(183, 25)
        Me.Cedula.Text = "Cedula"
        Me.Cedula.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'IvaD
        '
        Me.IvaD.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IvaD", "{0:n2}")})
        Me.IvaD.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.IvaD.Location = New System.Drawing.Point(542, 125)
        Me.IvaD.Name = "IvaD"
        Me.IvaD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.IvaD.Size = New System.Drawing.Size(92, 25)
        Me.IvaD.Text = "IvaD"
        Me.IvaD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalC
        '
        Me.TotalC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalC", "{0:n2}")})
        Me.TotalC.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalC.Location = New System.Drawing.Point(233, 150)
        Me.TotalC.Name = "TotalC"
        Me.TotalC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalC.Size = New System.Drawing.Size(92, 25)
        Me.TotalC.Text = "TotalC"
        Me.TotalC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalD
        '
        Me.TotalD.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalD", "{0:n2}")})
        Me.TotalD.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalD.Location = New System.Drawing.Point(542, 150)
        Me.TotalD.Name = "TotalD"
        Me.TotalD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalD.Size = New System.Drawing.Size(92, 25)
        Me.TotalD.Text = "TotalD"
        Me.TotalD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Nombre.Location = New System.Drawing.Point(100, 42)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.Size = New System.Drawing.Size(283, 25)
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel4.Location = New System.Drawing.Point(392, 75)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel4.Text = "CEDULA :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel2.Location = New System.Drawing.Point(17, 42)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel2.Text = "RETENIDO A :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel1.Location = New System.Drawing.Point(17, 17)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel1.Text = "FECHA :"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel3.Location = New System.Drawing.Point(17, 75)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel3.Text = "RUC :"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cheque", "CHEQUE NO. - {0}")})
        Me.Cheque.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cheque.Location = New System.Drawing.Point(392, 17)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cheque.Size = New System.Drawing.Size(125, 25)
        Me.Cheque.Text = "Cheque No."
        Me.Cheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel9.Location = New System.Drawing.Point(17, 125)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel9.Text = "COMPRA ANTES DEL IVA C$"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tasa
        '
        Me.Tasa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tasa", "{0}")})
        Me.Tasa.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tasa.Location = New System.Drawing.Point(183, 183)
        Me.Tasa.Name = "Tasa"
        Me.Tasa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tasa.Size = New System.Drawing.Size(325, 25)
        Me.Tasa.Text = "Tasa"
        Me.Tasa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dddd, dd 'de' MMMM 'del' yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Fecha.Location = New System.Drawing.Point(100, 17)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.Size = New System.Drawing.Size(267, 25)
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Ruc
        '
        Me.Ruc.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ruc", "")})
        Me.Ruc.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Ruc.Location = New System.Drawing.Point(100, 75)
        Me.Ruc.Name = "Ruc"
        Me.Ruc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ruc.Size = New System.Drawing.Size(267, 25)
        Me.Ruc.Text = "Ruc"
        Me.Ruc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PieRetencion
        '
        Me.PieRetencion.Height = 0
        Me.PieRetencion.Name = "PieRetencion"
        Me.PieRetencion.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PieRetencion.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.PieRetencion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.BackColor = System.Drawing.Color.Transparent
        Me.XrControlStyle1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrControlStyle1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrControlStyle1.BorderWidth = 1
        Me.XrControlStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrControlStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'RptRetencion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpRetencion, Me.PieRetencion})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "8.3"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub Fecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fecha.TextChanged, Fecha2.TextChanged, Concepto.TextChanged, Concepto2.TextChanged, Tasa.TextChanged, Tasa2.TextChanged, Nombre.TextChanged, Nombre2.TextChanged
        sender.Text = sender.Text.ToUpper
    End Sub

    'Private Sub Concepto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Concepto.TextChanged, Concepto2.TextChanged
    '    Concepto.Text = Concepto.Text.ToUpper
    'End Sub

    'Private Sub Tasa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tasa.TextChanged, Tasa2.TextChanged
    '    Tasa.Text = Tasa.Text.ToUpper
    'End Sub

    'Private Sub Nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nombre.TextChanged, Nombre2.TextChanged
    '    Nombre.Text = Nombre.Text.ToUpper
    'End Sub

End Class

