Imports DevExpress.XtraReports.UI

Public Class rptFormatoCargaInvent
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
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents etLinea As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.etLinea = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1050.0!, 25.0!)
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell7, Me.XrTableCell6, Me.XrTableCell8, Me.XrTableCell5})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Codigo")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 0.125R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Nombre")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell4.Weight = 0.3R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Presentacion")})
        Me.XrTableCell7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.131R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Existencias", "{0:n2}")})
        Me.XrTableCell6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.Weight = 0.15R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell8.Weight = 0.146R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell5.Weight = 0.148R
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 41.33332!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Format = "Pagina {0} / {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 21.33331!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(317.0!, 20.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:dd/MM/yy hh:mm tt}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(317.0!, 20.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.etLinea, Me.XrTable3, Me.XrTable1})
        Me.GroupHeader1.HeightF = 142.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable3
        '
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 117.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1050.0!, 25.0!)
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Código"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 0.117R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "Descripción"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.308R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Presentación"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 0.131R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Exitencias(Sistema)"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 0.148R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Existencias(Físico)"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell13.Weight = 0.148R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "Diferencias"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell14.Weight = 0.148R
        '
        'XrTable1
        '
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1050.0!, 56.54166!)
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow2.Weight = 0.5R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.Text = "Formato de Carga de Inventario Físico"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow1.Weight = 0.5R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Bodega", "Bodega: {0}")})
        Me.XrTableCell1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 1.0R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GroupFooter1.HeightF = 110.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable4
        '
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8, Me.XrTableRow7, Me.XrTableRow6, Me.XrTableRow5})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(1050.0!, 100.0!)
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell18})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow8.Weight = 0.25R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableCell18.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Total})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell18.Weight = 1.0R
        '
        'Total
        '
        Me.Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Articulos.Existencias", "{0:n2}")})
        Me.Total.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Total.LocationFloat = New DevExpress.Utils.PointFloat(558.0!, 0.0!)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.SizeF = New System.Drawing.SizeF(183.2998!, 25.0!)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.Total.Summary = XrSummary1
        Me.Total.Text = "Total"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell17})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow7.Weight = 0.25R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell17.Weight = 1.0R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell19, Me.XrTableCell16})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow6.Weight = 0.25R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell20.Weight = 0.367R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell19.Weight = 0.3R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell16.Weight = 0.333R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow5.Weight = 0.25R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.Text = "Realizado Por"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 1.0R
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
        'etLinea
        '
        Me.etLinea.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.etLinea.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 56.54166!)
        Me.etLinea.Multiline = True
        Me.etLinea.Name = "etLinea"
        Me.etLinea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.etLinea.SizeF = New System.Drawing.SizeF(1050.0!, 25.0!)
        Me.etLinea.StylePriority.UseFont = False
        Me.etLinea.StylePriority.UseTextAlignment = False
        Me.etLinea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptFormatoCargaInvent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "14.1"
        Me.XmlDataPath = "D:\SysContab2003FULL-CT\bin\xml\rptFormatoCargaInvet.xml"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

