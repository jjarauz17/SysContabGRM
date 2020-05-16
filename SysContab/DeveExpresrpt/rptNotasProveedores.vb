Imports DevExpress.XtraReports.UI

Public Class rptNotasProveedores
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SubTotal As XRLabel
    Friend WithEvents XrLabel3 As XRLabel
    Friend WithEvents Factura As XRLabel
    Friend WithEvents XrLabel2 As XRLabel
    Friend WithEvents Impuesto As XRLabel
    Friend WithEvents XrLabel6 As XRLabel
    Friend WithEvents XrLabel4 As XRLabel
    Friend WithEvents Descuento As XRLabel
    Friend WithEvents Usuario As XRLabel
    Friend WithEvents GroupHeader2 As GroupHeaderBand
    Friend WithEvents pLogo As XRPictureBox
    Friend WithEvents Clave As XRLabel
    Friend WithEvents Consecutivo As XRLabel
    Friend WithEvents Simbolo As XRLabel
    Friend WithEvents Total As XRLabel
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.pLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Impuesto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Descuento = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Simbolo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Clave = New DevExpress.XtraReports.UI.XRLabel()
        Me.Consecutivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Total = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.Detail.HeightF = 22.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable5
        '
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(742.0!, 20.0!)
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CDet_Cuenta")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Cuenta"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell15.Weight = 0.19918144611186903R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NombreCuenta")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell16.Weight = 0.43383356070941337R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito", "{0:n2}")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Débito"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 0.17735334242837653R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito", "{0:n2}")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "Crédito"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 0.18963165075034105R
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 30.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Usuario
        '
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario", "{0}")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(491.5!, 0!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(258.5!, 23.0!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Monto antes de IV:"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:dddd, dd MMMM yyyy hh:mm tt}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(475.0!, 23.00002!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pLogo, Me.XrTable9, Me.XrTable4, Me.XrTable3, Me.XrTable2, Me.XrTable1})
        Me.GroupHeader1.HeightF = 254.5001!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pLogo
        '
        Me.pLogo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.SizeF = New System.Drawing.SizeF(146.0!, 78.00001!)
        Me.pLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrTable9
        '
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(395.5!, 57.99999!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow13})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(354.5!, 20.0!)
        Me.XrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell32})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell30.Text = "Referencia:"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell30.Weight = 0.27236358499458696R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura_ID")})
        Me.XrTableCell32.Multiline = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell32.Weight = 0.90228712122237364R
        '
        'XrTable4
        '
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 234.5001!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(742.0!, 20.0!)
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell14, Me.XrTableCell12, Me.XrTableCell13})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.Text = "Cuenta"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 0.20054570259208732R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell14.Text = "Nombre"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell14.Weight = 0.43383356070941337R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Débito"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.Weight = 0.17735334242837653R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Crédito"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.Weight = 0.18826739427012279R
        '
        'XrTable3
        '
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.00003973643!, 155.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4, Me.XrTableRow6, Me.XrTableRow5})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(749.9999!, 60.0!)
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell7})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow4.Weight = 0.33333333333333331R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "msg")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 0.22237380627557982R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NOMBRE")})
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 0.77762619372442021R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow6.Weight = 0.33333333333333331R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "La Cantidad De:"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.22237380627557982R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Letras")})
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell10.Weight = 0.77762619372442021R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell8})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow5.Weight = 0.33333333333333331R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Por Concepto De:"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 0.22237380627557982R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Concepto")})
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell8.Weight = 0.77762619372442021R
        '
        'XrTable2
        '
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003973643!, 114.0001!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(749.9999!, 21.99999!)
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell5})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dddd, dd MMMM yyyy}")})
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 0.738515577666677R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "{0:C$ #,#.00}")})
        Me.XrTableCell5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.26148442233332303R
        '
        'XrTable1
        '
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(750.0!, 50.0!)
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.XrTableCell1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow2.Weight = 0.5R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Titulo")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 1.0R
        '
        'Impuesto
        '
        Me.Impuesto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Impuesto", "{0:n2}")})
        Me.Impuesto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impuesto.LocationFloat = New DevExpress.Utils.PointFloat(155.0!, 67.00001!)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Impuesto.SizeF = New System.Drawing.SizeF(207.4583!, 23.0!)
        Me.Impuesto.StylePriority.UseFont = False
        Me.Impuesto.Text = "Monto antes de IV:"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.00003973643!, 68.99995!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(146.0!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Impuesto:"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.99997!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(146.0!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Descuento:"
        '
        'Descuento
        '
        Me.Descuento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descuento", "{0:n2}")})
        Me.Descuento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.LocationFloat = New DevExpress.Utils.PointFloat(155.0!, 45.99997!)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descuento.SizeF = New System.Drawing.SizeF(207.4583!, 23.0!)
        Me.Descuento.StylePriority.UseFont = False
        Me.Descuento.Text = "Monto antes de IV:"
        '
        'SubTotal
        '
        Me.SubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "{0:n2}")})
        Me.SubTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.LocationFloat = New DevExpress.Utils.PointFloat(154.0!, 22.99999!)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SubTotal.SizeF = New System.Drawing.SizeF(207.4583!, 23.0!)
        Me.SubTotal.StylePriority.UseFont = False
        Me.SubTotal.Text = "Monto antes de IV:"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 22.99999!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(146.0!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Monto antes de IV:"
        '
        'Factura
        '
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(154.0!, 0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(304.0!, 23.0!)
        Me.Factura.StylePriority.UseFont = False
        Me.Factura.Text = "Sobre Factura(s) #:"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(146.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Sobre Factura(s) #:"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrTable8, Me.XrTable7, Me.XrTable6})
        Me.GroupFooter1.HeightF = 175.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 158.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(400.0!, 17.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "No se permiten tachaduras ni enmendaduras"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable8
        '
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(67.0!, 100.0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow12})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(625.0!, 34.0!)
        Me.XrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell23, Me.XrTableCell26})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow11.Weight = 0.5R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell25.Weight = 0.4R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell23.Weight = 0.2R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell26.Weight = 0.4R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow12.Weight = 0.5R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell27.Text = "Elaborado Por"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 0.4R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell28.Weight = 0.2R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell29.Text = "Autorizado Por"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell29.Weight = 0.4R
        '
        'XrTable7
        '
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 33.0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(450.0!, 25.0!)
        Me.XrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell24})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell20.Text = "Tasa de Cambio:"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell20.Weight = 0.27777777777777779R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TasaCambio", "{0:n4}")})
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell24.Weight = 0.72222222222222221R
        '
        'XrTable6
        '
        Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 7.999992!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(742.0!, 20.0!)
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell21, Me.XrTableCell22})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell19.Text = "Totales"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell19.Weight = 0.63301500682128242R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Debito")})
        Me.XrTableCell21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell21.Summary = XrSummary1
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 0.17735334242837653R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Credito")})
        Me.XrTableCell22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell22.Summary = XrSummary2
        Me.XrTableCell22.Text = "XrTableCell22"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.Weight = 0.18963165075034105R
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
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Total, Me.Simbolo, Me.Clave, Me.Consecutivo, Me.Impuesto, Me.Descuento, Me.SubTotal, Me.Factura, Me.XrLabel6, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2})
        Me.GroupHeader2.HeightF = 91.99999!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Visible = False
        '
        'Simbolo
        '
        Me.Simbolo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Simbolo")})
        Me.Simbolo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simbolo.LocationFloat = New DevExpress.Utils.PointFloat(517.8751!, 46.0!)
        Me.Simbolo.Name = "Simbolo"
        Me.Simbolo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Simbolo.SizeF = New System.Drawing.SizeF(232.125!, 23.0!)
        Me.Simbolo.StylePriority.UseFont = False
        Me.Simbolo.StylePriority.UseTextAlignment = False
        Me.Simbolo.Text = "Sobre Factura(s) #:"
        Me.Simbolo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Clave
        '
        Me.Clave.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Clave")})
        Me.Clave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clave.LocationFloat = New DevExpress.Utils.PointFloat(517.8751!, 22.99999!)
        Me.Clave.Name = "Clave"
        Me.Clave.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Clave.SizeF = New System.Drawing.SizeF(232.125!, 23.0!)
        Me.Clave.StylePriority.UseFont = False
        Me.Clave.StylePriority.UseTextAlignment = False
        Me.Clave.Text = "Sobre Factura(s) #:"
        Me.Clave.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Consecutivo
        '
        Me.Consecutivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Consecutivo")})
        Me.Consecutivo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consecutivo.LocationFloat = New DevExpress.Utils.PointFloat(517.8749!, 0!)
        Me.Consecutivo.Name = "Consecutivo"
        Me.Consecutivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Consecutivo.SizeF = New System.Drawing.SizeF(232.125!, 23.0!)
        Me.Consecutivo.StylePriority.UseFont = False
        Me.Consecutivo.StylePriority.UseTextAlignment = False
        Me.Consecutivo.Text = "Sobre Factura(s) #:"
        Me.Consecutivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n2}")})
        Me.Total.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.LocationFloat = New DevExpress.Utils.PointFloat(517.8751!, 68.99995!)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.SizeF = New System.Drawing.SizeF(232.1248!, 23.0!)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseTextAlignment = False
        Me.Total.Text = "Monto antes de IV:"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'rptNotasProveedores
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GroupHeader2})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "17.1"
        Me.XmlDataPath = "D:\SysContab2003FULL-CT\bin\xml\rptNotaProveedorImprimir.xml"
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

