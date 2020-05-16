Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections

Imports DevExpress.Data
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Imports System.ComponentModel

Public Class XtraReport1
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
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As TopMarginBand
    Friend WithEvents BottomMarginBand1 As BottomMarginBand
    Public WithEvents Logo As DevExpress.XtraReports.UI.XRPictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Logo, Me.Fecha, Me.Titulo})
        Me.PageHeader.HeightF = 145.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Logo
        '
        Me.Logo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Logo.Name = "Logo"
        Me.Logo.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Logo.SizeF = New System.Drawing.SizeF(108.0!, 108.0!)
        Me.Logo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'Fecha
        '
        Me.Fecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 25.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(484.0!, 25.0!)
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Titulo
        '
        Me.Titulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 0!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(484.0!, 25.0!)
        Me.Titulo.Text = "REPORTE"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 25.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "{0:dddd, dd MMMM yyyy HH:mm:ss}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(250.0!, 25.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Format = "Pagina {0} de {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(117.0!, 25.0!)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 50.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 50.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Grid As New GridView
    Private Consolidado As Boolean = False
    Private Temp As Boolean = False
    Private Anchor As Integer = 250

    Public Sub New(ByVal gridData As DataSet, ByVal gv As GridView, ByVal Consol As Boolean, ByVal Horizontal As Boolean)
        InitializeComponent()
        Grid = gv
        Consolidado = Consol
        Me.Landscape = Horizontal
        Dim columnAL As ArrayList = New ArrayList
        Dim columnFL As ArrayList = New ArrayList
        Dim columnDT As ArrayList = New ArrayList
        Me.DataSource = gridData
        Me.DataMember = gridData.Tables(0).TableName
        For i As Integer = gv.GroupCount - 1 To 0 Step -1
            InsertGroupBand(gv.GroupedColumns(i), i)
            Temp = True
        Next i

        Dim gbr As ReportFooterBand = New ReportFooterBand
        gbr.Height = 25
        Me.Bands.Add(gbr)

        Dim Actual As Integer = 0

        While Actual < gv.VisibleColumns.Count
            For i As Integer = 0 To gv.Columns.Count - 1
                If gv.Columns(i).Visible AndAlso gv.Columns(i).GroupIndex < 0 Then
                    If gv.Columns(i).VisibleIndex = Actual Then
                        columnAL.Add(gv.Columns(i).Caption)
                        columnFL.Add(gv.Columns(i).FieldName)
                        columnDT.Add(gv.Columns(i).ColumnType.Name)
                        Actual += 1
                    End If
                End If
            Next i
        End While
        InitTables(columnAL, columnFL, columnDT)
        Dim loc As Integer = (Me.PageWidth - (Margins.Left + Margins.Right)) - XrPageInfo1.Width
        XrPageInfo1.Location = New Point(loc, 0)
    End Sub

    Private Sub InsertGroupBand(ByVal gridColumn As GridColumn, ByVal i As Integer)
        Dim gb As GroupHeaderBand = New GroupHeaderBand
        gb.Height = 25
        'gb.RepeatEveryPage = True
        Dim l As XRLabel = New XRLabel
        l.DataBindings.Add("Text", Me.DataSource, gridColumn.FieldName)
        'Anchor = IIf(gridColumn.ColumnType.Name = "String", 300, 50)
        l.Size = New Size(Anchor, 25)
        l.Location = New Point(0 + i * 20, 0)
        'l.BackColor = Color.Beige
        If Consolidado Then l.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular) Else l.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
        l.TextAlignment = TextAlignment.MiddleLeft
        gb.Controls.Add(l)
        Dim gf As GroupField
        If gridColumn.SortOrder = ColumnSortOrder.Ascending Then
            gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending)
        Else
            gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending)
        End If
        gb.GroupFields.Add(gf)
        Me.Bands.Add(gb)


        Dim gbf As GroupFooterBand = New GroupFooterBand
        gbf.Height = 25
        Me.Bands.Add(gbf)

    End Sub

    Public Sub InitTables(ByVal columns As ArrayList, ByVal columnsFL As ArrayList, ByVal columnsDT As ArrayList)

        Dim colCount As Integer = columns.Count
        Dim pagewidth As Integer = (Me.PageWidth - (Margins.Left + Margins.Right))
        Dim colWidth As Integer = pagewidth / colCount
        Dim Bandas As Integer

        Dim table As XRTable = New XRTable
        Dim row As XRTableRow = New XRTableRow
        Dim table2 As XRTable = New XRTable
        Dim row2 As XRTableRow = New XRTableRow
        'Dim table3 As XRTable = New XRTable
        'Dim row3 As XRTableRow = New XRTableRow
        Dim table4 As XRTable = New XRTable
        Dim row4 As XRTableRow = New XRTableRow

        Dim i As Integer = 0
        Do While i < colCount
            Dim cell As XRTableCell = New XRTableCell
            cell.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
            cell.TextAlignment = TextAlignment.MiddleLeft
            'cell.Width = CInt(Fix(colWidth))
            Select Case columnsDT(i).ToString()
                Case "Double"
                    cell.Width = Fix(30)
                    cell.TextAlignment = TextAlignment.MiddleRight
                Case "Integer", "Int32"
                    cell.Width = Fix(30)
                    cell.TextAlignment = TextAlignment.MiddleRight
                Case "DateTime"
                    cell.Width = IIf(Not Consolidado, Fix(30), 0)
                    cell.TextAlignment = TextAlignment.MiddleCenter
                    cell.Visible = Not Consolidado
                Case Else
                    'cell.Width = IIf(Not Consolidado, Fix(30), 0)
                    If Len(Grid.GetRowCellValue(0, columns(i).ToString)) < 20 Then cell.Width = Fix(Len(Grid.GetRowCellValue(0, columns(i).ToString)) * 5)
                    'cell.Visible = Not Consolidado
            End Select

            cell.Text = columns(i).ToString()
            row.Cells.Add(cell)

            Dim cell2 As XRTableCell = New XRTableCell
            'cell2.Width = CInt(Fix(colWidth))
            cell2.TextAlignment = TextAlignment.MiddleLeft
            Select Case columnsDT(i).ToString()
                Case "Double"
                    cell2.DataBindings.Add("Text", Nothing, columnsFL(i).ToString(), "{0:n2}")
                    cell2.TextAlignment = TextAlignment.MiddleRight
                    cell2.Width = Fix(30)
                Case "DateTime"
                    cell2.DataBindings.Add("Text", Nothing, columnsFL(i).ToString(), "{0:dd/MM/yyyy}")
                    cell2.TextAlignment = TextAlignment.MiddleCenter
                    cell2.Width = IIf(Not Consolidado, Fix(30), 0)
                Case "Integer", "Int32"
                    cell.Width = Fix(30)
                    cell.TextAlignment = TextAlignment.MiddleCenter
                Case Else
                    cell2.DataBindings.Add("Text", Nothing, columnsFL(i).ToString())
                    cell2.TextAlignment = TextAlignment.MiddleLeft
                    If Len(Grid.GetRowCellValue(0, columns(i).ToString)) < 20 Then cell2.Width = Fix(Len(Grid.GetRowCellValue(0, columns(i).ToString)) * 5)
                    'cell2.Width = IIf(Not Consolidado, Fix(30), 0)
            End Select

            row2.Cells.Add(cell2)

            Dim cell4 As XRTableCell = New XRTableCell
            'cell3.Width = CInt(Fix(colWidth))
            cell4.DataBindings.Add("Text", Nothing, columnsFL(i).ToString())
            cell4.TextAlignment = TextAlignment.MiddleLeft
            Select Case columnsDT(i).ToString()
                Case "Double"
                    Dim Summary4 As New XRSummary
                    'summary4.Func = SummaryFunc.Sum
                    Summary4.FormatString = "{0:n2}"
                    Summary4.Running = SummaryRunning.Report
                    cell4.Summary = Summary4
                    cell4.Width = Fix(30)
                    cell4.TextAlignment = TextAlignment.MiddleRight
                Case "Integer", "Int32"
                    Dim Summary4 As New XRSummary
                    'summary4.Func = SummaryFunc.Sum
                    Summary4.FormatString = "{0:n0}"
                    Summary4.Running = SummaryRunning.Report
                    cell4.Summary = Summary4
                    cell4.Width = Fix(30)
                    cell4.TextAlignment = TextAlignment.MiddleCenter
                Case "DateTime"
                    cell4.Width = IIf(Not Consolidado, Fix(30), 0)
                    cell4.Visible = False
                Case Else
                    'cell4.Width = IIf(Not Consolidado, Fix(30), 0)
                    If Len(Grid.GetRowCellValue(0, columns(i).ToString)) < 20 Then cell4.Width = Fix(Len(Grid.GetRowCellValue(0, columns(i).ToString)) * 5)
                    cell4.Visible = False
            End Select

            row4.Cells.Add(cell4)
            i += 1
        Loop

        If Consolidado Then
            Dim l As XRLabel = New XRLabel
            l.Text = "Nombre"
            l.Size = New Size(Anchor, 23)
            l.Location = New Point(0, 120)
            l.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Bands(BandKind.PageHeader).Controls.Add(l)
        End If

        table.Rows.Add(row)
        table.Width = pagewidth - IIf(Temp And Consolidado, Anchor, 0)
        table.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        table.Location = New Point(IIf(Temp And Consolidado, Anchor, 0), 120)
        table.Height = 25

        table2.Rows.Add(row2)
        table2.Width = pagewidth - IIf(Temp And Consolidado, Anchor, 0)
        table2.Location = New Point(IIf(Temp And Consolidado, Anchor, 0), 0)
        table2.Height = 25

        table4.Rows.Add(row4)
        table4.Width = pagewidth - IIf(Temp And Consolidado, Anchor, 0)
        table4.Location = New Point(IIf(Temp And Consolidado, Anchor, 0), 0)
        table4.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
        table4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        table4.Height = 25

        Bands(BandKind.PageHeader).Controls.Add(table)
        Bands(BandKind.Detail).Controls.Add(table2)

        Try
            For k As Integer = 0 To Bands.Count - 1
                'Dim table3 As New XRTable
                If (Bands(k).GetType.FullName = "DevExpress.XtraReports.UI.GroupHeaderBand" And Consolidado) Or _
                (Bands(k).GetType.FullName = "DevExpress.XtraReports.UI.GroupFooterBand" And Not Consolidado) Then
                    i = 0
                    Dim row3 As XRTableRow = New XRTableRow
                    Dim table3 As New XRTable
                    Do While i < colCount

                        Dim cell3 As XRTableCell = New XRTableCell
                        'cell3.Width = CInt(Fix(colWidth))
                        cell3.DataBindings.Add("Text", Nothing, columnsFL(i).ToString())
                        cell3.TextAlignment = TextAlignment.MiddleLeft
                        Select Case columnsDT(i).ToString()
                            Case "Double"
                                Dim Summary3 As New XRSummary
                                'summary3.Func = SummaryFunc.Sum
                                Summary3.FormatString = "{0:n2}"
                                Summary3.Running = SummaryRunning.Group
                                cell3.Summary = Summary3
                                cell3.Width = Fix(30) 'IIf(Not Consolidado, Fix(30), 0)
                                cell3.TextAlignment = TextAlignment.MiddleRight
                            Case "Integer", "Int32"
                                Dim Summary3 As New XRSummary
                                'summary3.Func = SummaryFunc.Sum
                                Summary3.FormatString = "{0:n0}"
                                Summary3.Running = SummaryRunning.Group
                                cell3.Summary = Summary3
                                cell3.Width = Fix(30) 'IIf(Not Consolidado, Fix(30), 0)
                                cell3.TextAlignment = TextAlignment.MiddleCenter
                            Case "DateTime"
                                cell3.Width = Fix(30) 'IIf(Not Consolidado, Fix(30), 0)
                                cell3.Visible = False
                            Case Else
                                'cell3.Width = IIf(Not Consolidado, Fix(30), 0)
                                Dim Summary3 As New XRSummary
                                Summary3.Func = SummaryFunc.Max
                                summary3.FormatString = "{0}"
                                Summary3.Running = SummaryRunning.Group
                                '           cell3.Summary = Summary3
                                If Len(Grid.GetRowCellValue(0, columns(i).ToString)) < 20 Then cell3.Width = Fix(Len(Grid.GetRowCellValue(0, columns(i).ToString)) * 5)
                                cell3.Visible = Consolidado
                        End Select

                        row3.Cells.Add(cell3)

                        i += 1
                    Loop

                    table3.Rows.Add(row3)
                    table3.Width = pagewidth - IIf(Temp And Consolidado, Anchor, 0)
                    table3.Location = New Point(IIf(Temp And Consolidado, Anchor, 0), 0)
                    table3.Height = 25
                    If Consolidado Then table3.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular) Else table3.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
                    Bands(k).Controls.Add(table3)
                    If Bands(k).GetType.FullName = "DevExpress.XtraReports.UI.GroupHeaderBand" Then
                        If CType(Bands(k), DevExpress.XtraReports.UI.GroupBand).Level > 0 Then table3.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
                    End If

                End If

            Next
        Catch ex As Exception
        End Try

        Try
            Bands(BandKind.ReportFooter).Controls.Add(table4)
        Catch ex As Exception

        End Try

        Detail.Visible = Not Consolidado
    End Sub

End Class

