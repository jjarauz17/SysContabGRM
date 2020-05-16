Imports DevExpress.XtraReports.UI

Public Class rptReporteDiariosConsolidado
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
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
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
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 22
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(0, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell4, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(800, 20)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Cuenta", "")})
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.ParentStyleUsing.UseFont = False
        Me.XrTableCell1.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NOMBRE", "")})
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Location = New System.Drawing.Point(100, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.ParentStyleUsing.UseFont = False
        Me.XrTableCell2.Size = New System.Drawing.Size(225, 20)
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell33
        '
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Nivel1", "{0:n2}")})
        Me.XrTableCell33.Location = New System.Drawing.Point(325, 0)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell33.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell34
        '
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Nivel2", "{0:n2}")})
        Me.XrTableCell34.Location = New System.Drawing.Point(425, 0)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell34.Size = New System.Drawing.Size(92, 20)
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell35
        '
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Nivel3", "{0:n2}")})
        Me.XrTableCell35.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell35.Size = New System.Drawing.Size(83, 20)
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Debe", "{0:n2}")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Location = New System.Drawing.Point(600, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.ParentStyleUsing.UseFont = False
        Me.XrTableCell4.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Haber", "{0:n2}")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Location = New System.Drawing.Point(700, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.ParentStyleUsing.UseFont = False
        Me.XrTableCell3.Size = New System.Drawing.Size(100, 20)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.PageHeader.Height = 121
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
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Titulo", "")})
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
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NEmpresa", "")})
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
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.NMoneda", "MONEDA: {0}")})
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
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Desde", "{0:dd/MM/yyyy}")})
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
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Hasta", "{0:dd/MM/yyyy}")})
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell17.Location = New System.Drawing.Point(542, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell17.ParentStyleUsing.UseFont = False
        Me.XrTableCell17.Size = New System.Drawing.Size(258, 25)
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.Height = 28
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
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Comprobante", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 42
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable3
        '
        Me.XrTable3.Location = New System.Drawing.Point(0, 8)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable3.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell7, Me.XrTableCell9})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.ParentStyleUsing.UseBorders = False
        Me.XrTableCell5.ParentStyleUsing.UseFont = False
        Me.XrTableCell5.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell5.Text = "CUENTA"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Location = New System.Drawing.Point(100, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.ParentStyleUsing.UseBorders = False
        Me.XrTableCell6.ParentStyleUsing.UseFont = False
        Me.XrTableCell6.Size = New System.Drawing.Size(225, 25)
        Me.XrTableCell6.Text = "DESCRIPCION"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell30.Location = New System.Drawing.Point(325, 0)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell30.ParentStyleUsing.UseBorders = False
        Me.XrTableCell30.ParentStyleUsing.UseFont = False
        Me.XrTableCell30.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell30.Text = "S-S-S-CUENTA"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell31.Location = New System.Drawing.Point(425, 0)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell31.ParentStyleUsing.UseBorders = False
        Me.XrTableCell31.ParentStyleUsing.UseFont = False
        Me.XrTableCell31.Size = New System.Drawing.Size(92, 25)
        Me.XrTableCell31.Text = "S-S-CUENTA"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell32.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell32.ParentStyleUsing.UseBorders = False
        Me.XrTableCell32.ParentStyleUsing.UseFont = False
        Me.XrTableCell32.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell32.Text = "S-CUENTA"
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Location = New System.Drawing.Point(600, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.ParentStyleUsing.UseBorders = False
        Me.XrTableCell7.ParentStyleUsing.UseFont = False
        Me.XrTableCell7.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell7.Text = "DEBITO"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Location = New System.Drawing.Point(700, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.ParentStyleUsing.UseBorders = False
        Me.XrTableCell9.ParentStyleUsing.UseFont = False
        Me.XrTableCell9.Size = New System.Drawing.Size(100, 25)
        Me.XrTableCell9.Text = "CREDITO"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5, Me.XrTable4})
        Me.GroupFooter1.Height = 160
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable5
        '
        Me.XrTable5.Location = New System.Drawing.Point(0, 92)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8})
        Me.XrTable5.Size = New System.Drawing.Size(800, 66)
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell24, Me.XrTableCell12, Me.XrTableCell25, Me.XrTableCell15, Me.XrTableCell16})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Size = New System.Drawing.Size(800, 33)
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell24.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell24.ParentStyleUsing.UseBorders = False
        Me.XrTableCell24.Size = New System.Drawing.Size(233, 33)
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(233, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.Size = New System.Drawing.Size(42, 33)
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell25.Location = New System.Drawing.Point(275, 0)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell25.ParentStyleUsing.UseBorders = False
        Me.XrTableCell25.Size = New System.Drawing.Size(242, 33)
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.Size = New System.Drawing.Size(50, 33)
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell16.Location = New System.Drawing.Point(567, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.ParentStyleUsing.UseBorders = False
        Me.XrTableCell16.Size = New System.Drawing.Size(233, 33)
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell11, Me.XrTableCell22, Me.XrTableCell29, Me.XrTableCell23})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Size = New System.Drawing.Size(800, 33)
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell21.Size = New System.Drawing.Size(233, 33)
        Me.XrTableCell21.Text = "ELABORADO POR:"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Location = New System.Drawing.Point(233, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.Size = New System.Drawing.Size(42, 33)
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Location = New System.Drawing.Point(275, 0)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell22.Size = New System.Drawing.Size(242, 33)
        Me.XrTableCell22.Text = "REVISADO POR:"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell29.Size = New System.Drawing.Size(50, 33)
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Location = New System.Drawing.Point(567, 0)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell23.Size = New System.Drawing.Size(233, 33)
        Me.XrTableCell23.Text = "APROBADO POR:"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable4
        '
        Me.XrTable4.Location = New System.Drawing.Point(0, 17)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow9})
        Me.XrTable4.Size = New System.Drawing.Size(800, 50)
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell26, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell26.Size = New System.Drawing.Size(575, 25)
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Debe", "")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Location = New System.Drawing.Point(575, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.ParentStyleUsing.UseBorders = False
        Me.XrTableCell13.ParentStyleUsing.UseFont = False
        Me.XrTableCell13.Size = New System.Drawing.Size(117, 25)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell13.Summary = XrSummary1
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Haber", "")})
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Location = New System.Drawing.Point(692, 0)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell14.ParentStyleUsing.UseBorders = False
        Me.XrTableCell14.ParentStyleUsing.UseFont = False
        Me.XrTableCell14.Size = New System.Drawing.Size(108, 25)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell14.Summary = XrSummary2
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Size = New System.Drawing.Size(800, 25)
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "LibroDiario.Concepto", "{0}")})
        Me.XrTableCell27.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell27.Size = New System.Drawing.Size(508, 25)
        Me.XrTableCell27.Text = "XrTableCell27"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Location = New System.Drawing.Point(508, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell28.Size = New System.Drawing.Size(292, 25)
        '
        'rptReporteDiariosConsolidado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.XmlDataPath = "D:\Desarrollo\SysContab-Generico-ALMORI\SysContab-09032009\SysContab2003_Generico" & _
        "_Almori\bin\xml\rptLibroDiarioConsolidado.xml"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

