Imports DevExpress.XtraReports.UI

Public Class RptCheque
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
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ChequeNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descripcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ANombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Concepto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Debe As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Haber As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalHaber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalDebe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents NombreCheque As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Letras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ciudad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents Debitos As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents Creditos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Parcial As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ParcialV As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.Cuenta = New DevExpress.XtraReports.UI.XRTableCell
        Me.Nombre = New DevExpress.XtraReports.UI.XRTableCell
        Me.Concepto = New DevExpress.XtraReports.UI.XRTableCell
        Me.ParcialV = New DevExpress.XtraReports.UI.XRTableCell
        Me.Debe = New DevExpress.XtraReports.UI.XRTableCell
        Me.Haber = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel
        Me.Ciudad = New DevExpress.XtraReports.UI.XRLabel
        Me.Letras = New DevExpress.XtraReports.UI.XRLabel
        Me.NombreCheque = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Parcial = New DevExpress.XtraReports.UI.XRTableCell
        Me.Debitos = New DevExpress.XtraReports.UI.XRTableCell
        Me.Creditos = New DevExpress.XtraReports.UI.XRTableCell
        Me.ANombre = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.ChequeNo = New DevExpress.XtraReports.UI.XRLabel
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.TotalHaber = New DevExpress.XtraReports.UI.XRLabel
        Me.TotalDebe = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable2.Location = New System.Drawing.Point(0, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(750, 25)
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Cuenta, Me.Nombre, Me.Concepto, Me.ParcialV, Me.Debe, Me.Haber})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow2.Size = New System.Drawing.Size(750, 25)
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta", "")})
        Me.Cuenta.Location = New System.Drawing.Point(0, 0)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.Size = New System.Drawing.Size(106, 25)
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre.Location = New System.Drawing.Point(106, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.Size = New System.Drawing.Size(211, 25)
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Concepto
        '
        Me.Concepto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto", "")})
        Me.Concepto.Location = New System.Drawing.Point(317, 0)
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto.Size = New System.Drawing.Size(208, 25)
        Me.Concepto.Text = "Concepto"
        Me.Concepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ParcialV
        '
        Me.ParcialV.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParcialV", "{0:#,0.00}")})
        Me.ParcialV.Location = New System.Drawing.Point(525, 0)
        Me.ParcialV.Name = "ParcialV"
        Me.ParcialV.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ParcialV.Size = New System.Drawing.Size(75, 25)
        Me.ParcialV.Text = "ParcialV"
        Me.ParcialV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Debe
        '
        Me.Debe.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debe", "{0:#,0.00}")})
        Me.Debe.Location = New System.Drawing.Point(600, 0)
        Me.Debe.Name = "Debe"
        Me.Debe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Debe.Size = New System.Drawing.Size(75, 25)
        Me.Debe.Text = "Debe"
        Me.Debe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Haber
        '
        Me.Haber.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Haber", "{0:#,0.00}")})
        Me.Haber.Location = New System.Drawing.Point(675, 0)
        Me.Haber.Name = "Haber"
        Me.Haber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Haber.Size = New System.Drawing.Size(75, 25)
        Me.Haber.Text = "Haber"
        Me.Haber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.Fecha, Me.Ciudad, Me.Letras, Me.NombreCheque, Me.XrPanel1})
        Me.PageHeader.Height = 417
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "*** {0:n2} ***")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(617, 67)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd/MM/yyyy}")})
        Me.Fecha.Location = New System.Drawing.Point(608, 42)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.Size = New System.Drawing.Size(100, 25)
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Ciudad
        '
        Me.Ciudad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ciudad", "")})
        Me.Ciudad.Location = New System.Drawing.Point(500, 42)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ciudad.Size = New System.Drawing.Size(100, 25)
        Me.Ciudad.Text = "Ciudad"
        Me.Ciudad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Letras
        '
        Me.Letras.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Letras", "*** {0} ***")})
        Me.Letras.Location = New System.Drawing.Point(75, 108)
        Me.Letras.Name = "Letras"
        Me.Letras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Letras.Size = New System.Drawing.Size(467, 25)
        Me.Letras.Text = "Letras"
        Me.Letras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'NombreCheque
        '
        Me.NombreCheque.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ANombre", "")})
        Me.NombreCheque.Location = New System.Drawing.Point(75, 67)
        Me.NombreCheque.Name = "NombreCheque"
        Me.NombreCheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NombreCheque.Size = New System.Drawing.Size(375, 25)
        Me.NombreCheque.Text = "NombreCheque"
        Me.NombreCheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.BorderWidth = 1
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.ANombre, Me.XrLabel3, Me.XrLabel2, Me.XrLabel4, Me.XrLabel5, Me.ChequeNo, Me.Empresa, Me.Descripcion})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 233)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrPanel1.Size = New System.Drawing.Size(750, 184)
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.Location = New System.Drawing.Point(0, 158)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(750, 25)
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.Parcial, Me.Debitos, Me.Creditos})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow1.Size = New System.Drawing.Size(750, 25)
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(106, 25)
        Me.XrTableCell1.Text = "Cuenta"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(106, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(211, 25)
        Me.XrTableCell2.Text = "Nombre"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(317, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.Size = New System.Drawing.Size(208, 25)
        Me.XrTableCell4.Text = "Concepto"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Parcial
        '
        Me.Parcial.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Parcial", "")})
        Me.Parcial.Location = New System.Drawing.Point(525, 0)
        Me.Parcial.Name = "Parcial"
        Me.Parcial.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Parcial.Size = New System.Drawing.Size(75, 25)
        Me.Parcial.Text = "Parcial"
        Me.Parcial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Debitos
        '
        Me.Debitos.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debitos", "")})
        Me.Debitos.Location = New System.Drawing.Point(600, 0)
        Me.Debitos.Name = "Debitos"
        Me.Debitos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Debitos.Size = New System.Drawing.Size(75, 25)
        Me.Debitos.Text = "Debitos"
        Me.Debitos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Creditos
        '
        Me.Creditos.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Creditos", "")})
        Me.Creditos.Location = New System.Drawing.Point(675, 0)
        Me.Creditos.Name = "Creditos"
        Me.Creditos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Creditos.Size = New System.Drawing.Size(75, 25)
        Me.Creditos.Text = "Creditos"
        Me.Creditos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ANombre
        '
        Me.ANombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ANombre", "")})
        Me.ANombre.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ANombre.Location = New System.Drawing.Point(125, 92)
        Me.ANombre.Name = "ANombre"
        Me.ANombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ANombre.Size = New System.Drawing.Size(425, 25)
        Me.ANombre.Text = "A Nombre de:"
        Me.ANombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(42, 67)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel3.Text = "Cheque No:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(258, 25)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(283, 25)
        Me.XrLabel2.Text = "COMPROBANTE DE PAGO"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(42, 92)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel4.Text = "A Nombre de:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(42, 117)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel5.Text = "Concepto:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ChequeNo
        '
        Me.ChequeNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ChequeNo", "")})
        Me.ChequeNo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ChequeNo.Location = New System.Drawing.Point(125, 67)
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ChequeNo.Size = New System.Drawing.Size(425, 25)
        Me.ChequeNo.Text = "Cheque No:"
        Me.ChequeNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa", "")})
        Me.Empresa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Empresa.Location = New System.Drawing.Point(258, 0)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.Size = New System.Drawing.Size(283, 25)
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Descripcion
        '
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion", "")})
        Me.Descripcion.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Descripcion.Location = New System.Drawing.Point(125, 118)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.Size = New System.Drawing.Size(617, 25)
        Me.Descripcion.Text = "Concepto:"
        Me.Descripcion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        Me.PageFooter.Height = 33
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(600, 8)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel9.Text = "Recibi Conforme"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(442, 8)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel8.Text = "Aprobado"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(283, 8)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel7.Text = "Revisado"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(125, 8)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel6.Text = "Elaborado"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TotalHaber
        '
        Me.TotalHaber.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalHaber.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Haber", "")})
        Me.TotalHaber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TotalHaber.Location = New System.Drawing.Point(675, 0)
        Me.TotalHaber.Name = "TotalHaber"
        Me.TotalHaber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalHaber.Size = New System.Drawing.Size(75, 25)
        XrSummary1.FormatString = "{0:#,0.00}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.TotalHaber.Summary = XrSummary1
        Me.TotalHaber.Text = "TotalHaber"
        Me.TotalHaber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalDebe
        '
        Me.TotalDebe.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalDebe.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debe", "")})
        Me.TotalDebe.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TotalDebe.Location = New System.Drawing.Point(600, 0)
        Me.TotalDebe.Name = "TotalDebe"
        Me.TotalDebe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalDebe.Size = New System.Drawing.Size(75, 25)
        XrSummary2.FormatString = "{0:#,0.00}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.TotalDebe.Summary = XrSummary2
        Me.TotalDebe.Text = "TotalDebe"
        Me.TotalDebe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TotalDebe, Me.TotalHaber})
        Me.ReportFooter.Height = 67
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Usuario
        '
        Me.Usuario.DataBindings.Add("Text", Nothing, "Usuario")
        Me.Usuario.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(8, 8)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.Size = New System.Drawing.Size(108, 25)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Usuario"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'RptCheque
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 100)
        Me.Version = "8.3"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

