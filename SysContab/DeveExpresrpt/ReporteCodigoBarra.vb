Imports DevExpress.XtraReports.UI

Public Class ReporteCodigoBarra
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
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrCode128Generator1 As DevExpress.XtraReports.UI.BarCode.XRCode128Generator = New DevExpress.XtraReports.UI.BarCode.XRCode128Generator
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Height = 35
        Me.Detail.Name = "Detail"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrBarCode1.Location = New System.Drawing.Point(467, 0)
        Me.XrBarCode1.Module = 1.0!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.Size = New System.Drawing.Size(283, 33)
        Me.XrBarCode1.Symbology = XrCode128Generator1
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel4.Visible = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Location = New System.Drawing.Point(358, 0)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(100, 0)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(258, 25)
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5})
        Me.PageHeader.Height = 66
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Red
        Me.XrLabel5.Location = New System.Drawing.Point(67, 0)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.ParentStyleUsing.UseForeColor = False
        Me.XrLabel5.Size = New System.Drawing.Size(525, 25)
        Me.XrLabel5.Text = "LISTADO DE CODIGO DE BARRAS DE PRODUCTOS"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrPageInfo1})
        Me.PageFooter.Height = 42
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(658, 0)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel8.Text = "Pagina"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Location = New System.Drawing.Point(708, 0)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.Size = New System.Drawing.Size(34, 25)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel7, Me.XrLabel6})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField(Nothing, DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 59
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.ParentStyleUsing.UseBorders = False
        '
        'XrLabel12
        '
        Me.XrLabel12.Location = New System.Drawing.Point(467, 33)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(283, 25)
        Me.XrLabel12.Text = "Codigo Barra"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(358, 33)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(109, 25)
        Me.XrLabel11.Text = "Precio"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(100, 33)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(258, 25)
        Me.XrLabel10.Text = "Nombre Producto"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(0, 33)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel9.Text = "Código"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderWidth = 0
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseBorderWidth = False
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel7.Text = "Proveedor :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderWidth = 0
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel6.Location = New System.Drawing.Point(83, 0)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseBorderWidth = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(283, 25)
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReporteCodigoBarra
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 70, 70)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub XrLabel4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel4.TextChanged
        XrBarCode1.Text = XrLabel4.Text
    End Sub

    Private Sub ReporteCodigoBarra_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class

