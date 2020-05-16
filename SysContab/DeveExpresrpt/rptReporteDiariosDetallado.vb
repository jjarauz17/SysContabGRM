Imports DevExpress.XtraReports.UI

Public Class rptReporteDiariosDetallado
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.Detail.Height = 20
        Me.Detail.Name = "Detail"
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Debitos", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        '
        'XrTable4
        '
        Me.XrTable4.Location = New System.Drawing.Point(0, 0)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable4.Size = New System.Drawing.Size(617, 20)
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(617, 20)
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Cuenta", "")})
        Me.XrTableCell21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell21.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell21.ParentStyleUsing.UseFont = False
        Me.XrTableCell21.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.CuentaNombre", "")})
        Me.XrTableCell22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell22.Location = New System.Drawing.Point(100, 0)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell22.ParentStyleUsing.UseFont = False
        Me.XrTableCell22.Size = New System.Drawing.Size(308, 20)
        Me.XrTableCell22.Text = "XrTableCell22"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell23
        '
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Debitos", "{0:n2}")})
        Me.XrTableCell23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell23.Location = New System.Drawing.Point(408, 0)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell23.ParentStyleUsing.UseFont = False
        Me.XrTableCell23.Size = New System.Drawing.Size(109, 20)
        Me.XrTableCell23.Text = "XrTableCell23"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Creditos", "{0:n2}")})
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell24.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell24.ParentStyleUsing.UseFont = False
        Me.XrTableCell24.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrTable1})
        Me.PageHeader.Height = 142
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable2
        '
        Me.XrTable2.Location = New System.Drawing.Point(0, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow12, Me.XrTableRow5})
        Me.XrTable2.Size = New System.Drawing.Size(800, 100)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NEmpresa", "")})
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.ParentStyleUsing.UseFont = False
        Me.XrTableCell10.Size = New System.Drawing.Size(800, 25)
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Titulo", "")})
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.ParentStyleUsing.UseFont = False
        Me.XrTableCell8.Size = New System.Drawing.Size(800, 25)
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell42})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell42
        '
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NMC", "MONEDA: {0}")})
        Me.XrTableCell42.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell42.Size = New System.Drawing.Size(800, 25)
        Me.XrTableCell42.Text = "XrTableCell42"
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell17})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell20.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell20.ParentStyleUsing.UseFont = False
        Me.XrTableCell20.Size = New System.Drawing.Size(300, 25)
        Me.XrTableCell20.Text = "Fecha Desde:   "
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Desde", "")})
        Me.XrTableCell18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell18.Location = New System.Drawing.Point(300, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell18.ParentStyleUsing.UseFont = False
        Me.XrTableCell18.Size = New System.Drawing.Size(125, 25)
        Me.XrTableCell18.Text = "XrTableCell18"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell19.Location = New System.Drawing.Point(425, 0)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell19.ParentStyleUsing.UseFont = False
        Me.XrTableCell19.Size = New System.Drawing.Size(117, 25)
        Me.XrTableCell19.Text = "Fecha Hasta:   "
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Hasta", "")})
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell17.Location = New System.Drawing.Point(542, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell17.ParentStyleUsing.UseFont = False
        Me.XrTableCell17.Size = New System.Drawing.Size(258, 25)
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(0, 117)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell1, Me.XrTableCell5, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell6, Me.XrTableCell7})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.ParentStyleUsing.UseBorders = False
        Me.XrTableCell4.ParentStyleUsing.UseFont = False
        Me.XrTableCell4.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell4.Text = "Cheque No."
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.ParentStyleUsing.UseBorders = False
        Me.XrTableCell1.ParentStyleUsing.UseFont = False
        Me.XrTableCell1.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell1.Text = "F. Emisión"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Location = New System.Drawing.Point(183, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.ParentStyleUsing.UseBorders = False
        Me.XrTableCell5.ParentStyleUsing.UseFont = False
        Me.XrTableCell5.Size = New System.Drawing.Size(234, 25)
        Me.XrTableCell5.Text = "Beneficiario"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Location = New System.Drawing.Point(417, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.ParentStyleUsing.UseBorders = False
        Me.XrTableCell2.ParentStyleUsing.UseFont = False
        Me.XrTableCell2.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell2.Text = "Débito"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.ParentStyleUsing.UseBorders = False
        Me.XrTableCell3.ParentStyleUsing.UseFont = False
        Me.XrTableCell3.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell3.Text = "Crédito"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Location = New System.Drawing.Point(617, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.ParentStyleUsing.UseBorders = False
        Me.XrTableCell6.ParentStyleUsing.UseFont = False
        Me.XrTableCell6.Size = New System.Drawing.Size(105, 25)
        Me.XrTableCell6.Text = "Monto"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Location = New System.Drawing.Point(722, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.ParentStyleUsing.UseBorders = False
        Me.XrTableCell7.ParentStyleUsing.UseFont = False
        Me.XrTableCell7.Size = New System.Drawing.Size(78, 25)
        Me.XrTableCell7.Text = "Anulado"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.Height = 25
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "{0:dd/MM/yyyy hh:mm tt}"
        Me.XrPageInfo2.Location = New System.Drawing.Point(475, 0)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.Size = New System.Drawing.Size(325, 25)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrPageInfo1.Format = "Página: {0}"
        Me.XrPageInfo1.Location = New System.Drawing.Point(0, 0)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.ParentStyleUsing.UseFont = False
        Me.XrPageInfo1.Size = New System.Drawing.Size(225, 25)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6, Me.XrTable3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Cheque", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Fecha", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Comprobante", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 71
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable3
        '
        Me.XrTable3.Location = New System.Drawing.Point(0, 25)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4, Me.XrTableRow8})
        Me.XrTable3.Size = New System.Drawing.Size(800, 40)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Cheque", "")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.ParentStyleUsing.UseBorders = False
        Me.XrTableCell9.ParentStyleUsing.UseFont = False
        Me.XrTableCell9.Size = New System.Drawing.Size(83, 20)
        Me.XrTableCell9.Text = "Cheque No."
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Fecha", "{0:dd/MM/yyyy}")})
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.ParentStyleUsing.UseBorders = False
        Me.XrTableCell11.ParentStyleUsing.UseFont = False
        Me.XrTableCell11.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell11.Text = "F. Emisión"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.ChequeNombre", "")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Location = New System.Drawing.Point(183, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.ParentStyleUsing.UseBorders = False
        Me.XrTableCell12.ParentStyleUsing.UseFont = False
        Me.XrTableCell12.Size = New System.Drawing.Size(234, 20)
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Location = New System.Drawing.Point(417, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.ParentStyleUsing.UseBorders = False
        Me.XrTableCell13.ParentStyleUsing.UseFont = False
        Me.XrTableCell13.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell14.ParentStyleUsing.UseBorders = False
        Me.XrTableCell14.ParentStyleUsing.UseFont = False
        Me.XrTableCell14.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Creditos", "{0:n2}")})
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell15.Location = New System.Drawing.Point(617, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.ParentStyleUsing.UseBorders = False
        Me.XrTableCell15.ParentStyleUsing.UseFont = False
        Me.XrTableCell15.Size = New System.Drawing.Size(105, 20)
        Me.XrTableCell15.Text = "Monto"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell16.Location = New System.Drawing.Point(722, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.ParentStyleUsing.UseBorders = False
        Me.XrTableCell16.ParentStyleUsing.UseFont = False
        Me.XrTableCell16.Size = New System.Drawing.Size(78, 20)
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableCell33
        '
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Concepto", "")})
        Me.XrTableCell33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell33.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell33.ParentStyleUsing.UseFont = False
        Me.XrTableCell33.Size = New System.Drawing.Size(800, 20)
        Me.XrTableCell33.Text = "XrTableCell33"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.GroupFooter2.Height = 86
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrTable5
        '
        Me.XrTable5.Location = New System.Drawing.Point(0, 25)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9, Me.XrTableRow10})
        Me.XrTable5.Size = New System.Drawing.Size(725, 50)
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell36})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Size = New System.Drawing.Size(725, 25)
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.cTDocumento", "TOTAL {0}")})
        Me.XrTableCell29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell29.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell29.ParentStyleUsing.UseFont = False
        Me.XrTableCell29.Size = New System.Drawing.Size(283, 25)
        Me.XrTableCell29.Text = "TOTAL"
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell30.Location = New System.Drawing.Point(283, 0)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell30.ParentStyleUsing.UseFont = False
        Me.XrTableCell30.Size = New System.Drawing.Size(109, 25)
        Me.XrTableCell30.Text = "-------------->"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell36
        '
        Me.XrTableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Creditos", "")})
        Me.XrTableCell36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell36.Location = New System.Drawing.Point(392, 0)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell36.ParentStyleUsing.UseFont = False
        Me.XrTableCell36.Size = New System.Drawing.Size(333, 25)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell36.Summary = XrSummary1
        Me.XrTableCell36.Text = "XrTableCell36"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell39, Me.XrTableCell37})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Size = New System.Drawing.Size(725, 25)
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell32.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell32.ParentStyleUsing.UseFont = False
        Me.XrTableCell32.Size = New System.Drawing.Size(283, 25)
        Me.XrTableCell32.Text = "TOTAL DEBITOS/CREDITOS"
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell34.Location = New System.Drawing.Point(283, 0)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell34.ParentStyleUsing.UseFont = False
        Me.XrTableCell34.Size = New System.Drawing.Size(109, 25)
        Me.XrTableCell34.Text = "-------------->"
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell35
        '
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Debitos", "")})
        Me.XrTableCell35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell35.Location = New System.Drawing.Point(392, 0)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell35.ParentStyleUsing.UseFont = False
        Me.XrTableCell35.Size = New System.Drawing.Size(116, 25)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell35.Summary = XrSummary2
        Me.XrTableCell35.Text = "XrTableCell35"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell39
        '
        Me.XrTableCell39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Creditos", "")})
        Me.XrTableCell39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell39.Location = New System.Drawing.Point(508, 0)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell39.ParentStyleUsing.UseFont = False
        Me.XrTableCell39.Size = New System.Drawing.Size(99, 25)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell39.Summary = XrSummary3
        Me.XrTableCell39.Text = "XrTableCell39"
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Location = New System.Drawing.Point(607, 0)
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell37.Size = New System.Drawing.Size(118, 25)
        '
        'XrTable6
        '
        Me.XrTable6.Location = New System.Drawing.Point(0, 8)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11})
        Me.XrTable6.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.XrTableCell38, Me.XrTableCell41, Me.XrTableCell40})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableCell31
        '
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NUMERO_CUENTA", "")})
        Me.XrTableCell31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell31.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell31.ParentStyleUsing.UseFont = False
        Me.XrTableCell31.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell31.Text = "XrTableCell31"
        '
        'XrTableCell38
        '
        Me.XrTableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.CentroCosto", "")})
        Me.XrTableCell38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell38.Location = New System.Drawing.Point(100, 0)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell38.ParentStyleUsing.UseFont = False
        Me.XrTableCell38.Size = New System.Drawing.Size(133, 20)
        Me.XrTableCell38.Text = "XrTableCell38"
        '
        'XrTableCell41
        '
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.CuentaBanco", "")})
        Me.XrTableCell41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell41.Location = New System.Drawing.Point(233, 0)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell41.ParentStyleUsing.UseFont = False
        Me.XrTableCell41.Size = New System.Drawing.Size(217, 20)
        Me.XrTableCell41.Text = "XrTableCell41"
        '
        'XrTableCell40
        '
        Me.XrTableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NombreBanco", "")})
        Me.XrTableCell40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell40.Location = New System.Drawing.Point(450, 0)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell40.ParentStyleUsing.UseFont = False
        Me.XrTableCell40.Size = New System.Drawing.Size(350, 20)
        Me.XrTableCell40.Text = "XrTableCell40"
        '
        'rptReporteDiariosDetallado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter2})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.XmlDataPath = "D:\Desarrollo\SysContab-Generico-ALMORI\SysContab-09032009\SysContab2003_Generico" & _
        "_Almori\bin\xml\rptLibroDiario.xml"
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

