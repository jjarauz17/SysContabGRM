Imports DevExpress.XtraReports.UI

Public Class rptFacturaCompra
    Inherits DevExpress.XtraReports.UI.XtraReport
    Public Proveedor As String
    Public FormaPago As String

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
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.Total = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Height = 17
        Me.Detail.Name = "Detail"
        '
        'XrTable3
        '
        Me.XrTable3.Dock = DevExpress.XtraReports.UI.XRDockStyle.Top
        Me.XrTable3.Location = New System.Drawing.Point(8, 0)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.Size = New System.Drawing.Size(682, 17)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell12, Me.XrTableCell8, Me.XrTableCell10, Me.XrTableCell9, Me.XrTableCell1})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(682, 17)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Item_ID", "")})
        Me.XrTableCell7.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.ParentStyleUsing.UseBorders = False
        Me.XrTableCell7.ParentStyleUsing.UseFont = False
        Me.XrTableCell7.Size = New System.Drawing.Size(83, 17)
        Me.XrTableCell7.Text = "XrTableCell7"
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.XrTableCell12.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.Size = New System.Drawing.Size(307, 17)
        Me.XrTableCell12.Text = "XrTableCell12"
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Item_Cantidad", "{0:n2}")})
        Me.XrTableCell8.Location = New System.Drawing.Point(390, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.Size = New System.Drawing.Size(58, 17)
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Item_Costo", "{0:n2}")})
        Me.XrTableCell10.Location = New System.Drawing.Point(448, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Item_Descuento", "{0:0.00%}")})
        Me.XrTableCell9.Location = New System.Drawing.Point(526, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "{0:n2}")})
        Me.XrTableCell1.Location = New System.Drawing.Point(604, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.ParentStyleUsing.UseBorders = False
        Me.XrTableCell1.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrTable2})
        Me.PageHeader.Height = 150
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.ParentStyleUsing.UseBorders = False
        Me.XrPanel1.Size = New System.Drawing.Size(690, 117)
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura_Tipo", "")})
        Me.XrLabel10.Location = New System.Drawing.Point(401, 93)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel10.Text = "No. Factura"
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(9, 93)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel11.Text = "Tipo :"
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdenCompra_ID", "")})
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.XrLabel12.Location = New System.Drawing.Point(590, 18)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.ParentStyleUsing.UseBorders = False
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel12.Text = "No. Factura"
        '
        'XrLabel13
        '
        Me.XrLabel13.Location = New System.Drawing.Point(481, 18)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel13.Text = "No. de Orden  :"
        '
        'XrLabel14
        '
        Me.XrLabel14.Location = New System.Drawing.Point(9, 70)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel14.Text = "Forma de Pago :"
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel15.Location = New System.Drawing.Point(112, 70)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.ParentStyleUsing.UseBorders = False
        Me.XrLabel15.Size = New System.Drawing.Size(158, 17)
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Location = New System.Drawing.Point(112, 26)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.Size = New System.Drawing.Size(283, 17)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura_Fecha", "{0:dd-MMM-yy}")})
        Me.XrLabel2.Location = New System.Drawing.Point(112, 47)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.Size = New System.Drawing.Size(155, 16)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura_ID", "")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 10.5!)
        Me.XrLabel1.Location = New System.Drawing.Point(590, 1)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(9, 26)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel4.Text = "Proveedor :"
        '
        'XrLabel5
        '
        Me.XrLabel5.Location = New System.Drawing.Point(482, 1)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel5.Text = "No. Factura"
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(9, 47)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel6.Text = "Fecha Elaborado :"
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(334, 47)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(103, 17)
        Me.XrLabel7.Text = "Fecha de Pago:"
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura_FechaPago", "{0:dd-MMM-yy}")})
        Me.XrLabel8.Location = New System.Drawing.Point(437, 47)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ParentStyleUsing.UseBorders = False
        Me.XrLabel8.Size = New System.Drawing.Size(155, 16)
        Me.XrLabel8.Text = "XrLabel2"
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel9.Location = New System.Drawing.Point(112, 93)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseBorders = False
        Me.XrLabel9.Size = New System.Drawing.Size(283, 17)
        '
        'XrTable2
        '
        Me.XrTable2.Dock = DevExpress.XtraReports.UI.XRDockStyle.Bottom
        Me.XrTable2.Location = New System.Drawing.Point(8, 133)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(682, 17)
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell11, Me.XrTableCell5, Me.XrTableCell3, Me.XrTableCell6, Me.XrTableCell2})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(682, 17)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.ParentStyleUsing.UseBorders = False
        Me.XrTableCell4.Size = New System.Drawing.Size(83, 17)
        Me.XrTableCell4.Text = "Codigo"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.ParentStyleUsing.UseBorders = False
        Me.XrTableCell11.Size = New System.Drawing.Size(307, 17)
        Me.XrTableCell11.Text = "Nombre"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Location = New System.Drawing.Point(390, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.ParentStyleUsing.UseBorders = False
        Me.XrTableCell5.Size = New System.Drawing.Size(58, 17)
        Me.XrTableCell5.Text = "Cantidad"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Location = New System.Drawing.Point(448, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.ParentStyleUsing.UseBorders = False
        Me.XrTableCell3.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell3.Text = "Costo"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Location = New System.Drawing.Point(526, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.ParentStyleUsing.UseBorders = False
        Me.XrTableCell6.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell6.Text = "% Descuento"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Location = New System.Drawing.Point(604, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.ParentStyleUsing.UseBorders = False
        Me.XrTableCell2.Size = New System.Drawing.Size(78, 17)
        Me.XrTableCell2.Text = "Total/Art."
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel26, Me.XrLabel25})
        Me.PageFooter.Height = 21
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario", "")})
        Me.XrLabel27.Location = New System.Drawing.Point(408, 0)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.Size = New System.Drawing.Size(282, 17)
        Me.XrLabel27.Text = "Fecha de Impresión:"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Date", "")})
        Me.XrLabel26.Location = New System.Drawing.Point(117, 0)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.Size = New System.Drawing.Size(150, 17)
        Me.XrLabel26.Text = "Fecha de Impresión:"
        '
        'XrLabel25
        '
        Me.XrLabel25.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.Size = New System.Drawing.Size(117, 17)
        Me.XrLabel25.Text = "Fecha de Impresión:"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrPanel2, Me.XrLabel29, Me.XrLabel24})
        Me.GroupFooter1.Height = 140
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.ParentStyleUsing.UseFont = False
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 0)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(682, 4)
        '
        'XrPanel2
        '
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.Total, Me.XrLabel16, Me.XrLabel17, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20})
        Me.XrPanel2.Location = New System.Drawing.Point(515, 17)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.Size = New System.Drawing.Size(175, 75)
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Item_IVA", "")})
        Me.XrLabel18.Location = New System.Drawing.Point(73, 35)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.Size = New System.Drawing.Size(100, 17)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel18.Summary = XrSummary1
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Total
        '
        Me.Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "")})
        Me.Total.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Total.Location = New System.Drawing.Point(73, 54)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.ParentStyleUsing.UseFont = False
        Me.Total.Size = New System.Drawing.Size(100, 17)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Total.Summary = XrSummary2
        Me.Total.Text = "Total"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "")})
        Me.XrLabel16.Location = New System.Drawing.Point(73, 0)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.Size = New System.Drawing.Size(100, 17)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel16.Summary = XrSummary3
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descuento", "")})
        Me.XrLabel17.Location = New System.Drawing.Point(73, 18)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.Size = New System.Drawing.Size(100, 17)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary4
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel23
        '
        Me.XrLabel23.Location = New System.Drawing.Point(0, 35)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.Size = New System.Drawing.Size(68, 17)
        Me.XrLabel23.Text = "IVA"
        '
        'XrLabel22
        '
        Me.XrLabel22.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.Size = New System.Drawing.Size(68, 17)
        Me.XrLabel22.Text = "Sub Total"
        '
        'XrLabel21
        '
        Me.XrLabel21.Location = New System.Drawing.Point(0, 18)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.Size = New System.Drawing.Size(68, 17)
        Me.XrLabel21.Text = "Descuento"
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.Location = New System.Drawing.Point(0, 54)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.ParentStyleUsing.UseFont = False
        Me.XrLabel20.Size = New System.Drawing.Size(68, 17)
        Me.XrLabel20.Text = "TOTAL"
        '
        'XrLabel29
        '
        Me.XrLabel29.Location = New System.Drawing.Point(0, 83)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.Size = New System.Drawing.Size(92, 17)
        Me.XrLabel29.Text = "Observaciones"
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Observaciones", "")})
        Me.XrLabel24.Location = New System.Drawing.Point(0, 100)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.Size = New System.Drawing.Size(690, 33)
        Me.XrLabel24.Text = "Oberscaciones" & Microsoft.VisualBasic.ChrW(9)
        '
        'rptFacturaCompra
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(80, 80, 80, 80)
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PageHeader.BeforePrint
        XrLabel3.Text = Proveedor
        XrLabel15.Text = FormaPago

        If XrLabel10.Text = "0" Then
            XrLabel9.Text = "Factura de productos"
        ElseIf XrLabel10.Text = "1" Then
            XrLabel9.Text = "Factura de servicios"
        ElseIf XrLabel10.Text = "4" Then
            XrLabel9.Text = "Factura de productos de inventario"
        Else
            XrLabel9.Text = "Factura de productos de activos"
        End If
    End Sub

    Private Sub XrLabel24_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel24.AfterPrint
        If XrLabel24.Text = "" Then XrLabel29.Visible = False Else XrLabel29.Visible = True
    End Sub

    Private Sub XrLabel27_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel27.BeforePrint
        XrLabel27.Text = "Impreso por : " & XrLabel27.Text
    End Sub

End Class