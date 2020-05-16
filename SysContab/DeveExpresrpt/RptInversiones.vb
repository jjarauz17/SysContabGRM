Imports DevExpress.XtraReports.UI

Public Class RptInversiones
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "{0:#,#.00}")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(525, 0)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Interes", "{0:#,#.00}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.Location = New System.Drawing.Point(425, 0)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MontoIni", "{0:#,#.00}")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.Location = New System.Drawing.Point(325, 0)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dddd, dd MMMM yyyy}")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(125, 0)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "No", "")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(25, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel18, Me.XrLabel21, Me.XrLabel15, Me.XrLabel12, Me.XrLabel17, Me.XrLabel14, Me.XrLabel19, Me.XrLabel20, Me.XrLabel16, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        Me.PageHeader.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.PageHeader.Height = 242
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.ParentStyleUsing.UseFont = False
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.Location = New System.Drawing.Point(75, 108)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel13.Text = "Nombre Banco"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.Location = New System.Drawing.Point(333, 133)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.ParentStyleUsing.UseFont = False
        Me.XrLabel18.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel18.Text = "Plazo"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Inter", "{0} %")})
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.Location = New System.Drawing.Point(517, 133)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.ParentStyleUsing.UseFont = False
        Me.XrLabel21.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Banco", "")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.Location = New System.Drawing.Point(200, 108)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.ParentStyleUsing.UseFont = False
        Me.XrLabel15.Size = New System.Drawing.Size(375, 25)
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.Location = New System.Drawing.Point(75, 83)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel12.Text = "Nombre Institucion"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fechas", "{0:dddd, dd MMMM yyyy}")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.Location = New System.Drawing.Point(200, 133)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.ParentStyleUsing.UseFont = False
        Me.XrLabel17.Size = New System.Drawing.Size(133, 25)
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Institucion", "")})
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.Location = New System.Drawing.Point(200, 83)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.ParentStyleUsing.UseFont = False
        Me.XrLabel14.Size = New System.Drawing.Size(375, 25)
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Plazo", "{0} Meses")})
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.Location = New System.Drawing.Point(383, 133)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.ParentStyleUsing.UseFont = False
        Me.XrLabel19.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.Location = New System.Drawing.Point(467, 133)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.ParentStyleUsing.UseFont = False
        Me.XrLabel20.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel20.Text = "Interes"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.Location = New System.Drawing.Point(75, 133)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.ParentStyleUsing.UseFont = False
        Me.XrLabel16.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel16.Text = "Fecha Emision"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(150, 0)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.ParentStyleUsing.UseFont = False
        Me.XrLabel11.Size = New System.Drawing.Size(350, 25)
        Me.XrLabel11.Text = "Reporte de Proyeccion de Inversiones"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.Location = New System.Drawing.Point(525, 217)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.ParentStyleUsing.UseBackColor = False
        Me.XrLabel10.ParentStyleUsing.UseBorders = False
        Me.XrLabel10.ParentStyleUsing.UseFont = False
        Me.XrLabel10.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel10.Text = "Monto Final"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(425, 217)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseBackColor = False
        Me.XrLabel9.ParentStyleUsing.UseBorders = False
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel9.Text = "Interes"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.Location = New System.Drawing.Point(325, 217)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ParentStyleUsing.UseBackColor = False
        Me.XrLabel8.ParentStyleUsing.UseBorders = False
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel8.Text = "Monto Inicial"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.Location = New System.Drawing.Point(125, 217)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseBackColor = False
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel7.Text = "Fecha"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(25, 217)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseBackColor = False
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel6.Text = "No"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Height = 26
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrPageInfo1.Location = New System.Drawing.Point(550, 0)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.ParentStyleUsing.UseFont = False
        Me.XrPageInfo1.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31, Me.XrLabel32, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22})
        Me.ReportFooter.Height = 194
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.Location = New System.Drawing.Point(200, 150)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.ParentStyleUsing.UseFont = False
        Me.XrLabel32.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel32.Text = "Total a Recibir"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel30.Location = New System.Drawing.Point(342, 125)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.ParentStyleUsing.UseBorders = False
        Me.XrLabel30.ParentStyleUsing.UseFont = False
        Me.XrLabel30.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel30.Text = "0"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Inicial", "{0:#,#.00}")})
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel29.Location = New System.Drawing.Point(342, 100)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.ParentStyleUsing.UseBorders = False
        Me.XrLabel29.ParentStyleUsing.UseFont = False
        Me.XrLabel29.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel29.Text = "0"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel28.Location = New System.Drawing.Point(342, 75)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.ParentStyleUsing.UseBorders = False
        Me.XrLabel28.ParentStyleUsing.UseFont = False
        Me.XrLabel28.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel28.Text = "0"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Interes", "")})
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel27.Location = New System.Drawing.Point(342, 50)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.ParentStyleUsing.UseBorders = False
        Me.XrLabel27.ParentStyleUsing.UseFont = False
        Me.XrLabel27.Size = New System.Drawing.Size(117, 25)
        XrSummary1.FormatString = "{0:#,#.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel27.Summary = XrSummary1
        Me.XrLabel27.Text = "0"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.Location = New System.Drawing.Point(200, 125)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.ParentStyleUsing.UseBorders = False
        Me.XrLabel26.ParentStyleUsing.UseFont = False
        Me.XrLabel26.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel26.Text = "Intereses Netos"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.Location = New System.Drawing.Point(200, 100)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.ParentStyleUsing.UseBorders = False
        Me.XrLabel25.ParentStyleUsing.UseFont = False
        Me.XrLabel25.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel25.Text = "Inversion Inicial"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.Location = New System.Drawing.Point(200, 75)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.ParentStyleUsing.UseBorders = False
        Me.XrLabel24.ParentStyleUsing.UseFont = False
        Me.XrLabel24.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel24.Text = "Impuestos 10%"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.Location = New System.Drawing.Point(200, 50)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.ParentStyleUsing.UseBorders = False
        Me.XrLabel23.ParentStyleUsing.UseFont = False
        Me.XrLabel23.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel23.Text = "Intereses Devengados"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.CornflowerBlue
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.Location = New System.Drawing.Point(200, 25)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.ParentStyleUsing.UseBackColor = False
        Me.XrLabel22.ParentStyleUsing.UseBorders = False
        Me.XrLabel22.ParentStyleUsing.UseFont = False
        Me.XrLabel22.Size = New System.Drawing.Size(259, 25)
        Me.XrLabel22.Text = "Resumen"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrLabel31.Location = New System.Drawing.Point(342, 150)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.ParentStyleUsing.UseBorders = False
        Me.XrLabel31.ParentStyleUsing.UseFont = False
        Me.XrLabel31.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel31.Text = "0"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'RptInversiones
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        Me.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub XrLabel27_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel27.TextChanged
        XrLabel28.Text = Format(CDbl(XrLabel27.Summary.GetResult) * 0.1, "#,#.00")
    End Sub

    Private Sub XrLabel28_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel28.TextChanged
        XrLabel30.Text = Format(CDbl(XrLabel27.Summary.GetResult) - CDbl(XrLabel28.Text), "#,#.00")
    End Sub

    Private Sub XrLabel29_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel29.TextChanged
        XrLabel31.Text = Format(CDbl(XrLabel29.Text) + CDbl(XrLabel30.Text), "#,#.00")
    End Sub
End Class


