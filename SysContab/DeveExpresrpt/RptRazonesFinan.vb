Imports DevExpress.XtraReports.UI

Public Class RptRazonesFinan
    Inherits DevExpress.XtraReports.UI.XtraReport

    Dim Razones(10) As Double

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
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents RazonAscendente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RazonPrueba As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RotacionCuentas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RotacionCuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RotacionActivos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RentabilidadVentas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RotacionActivosTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CapitalNeto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents UtilidadOperacion As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.RazonAscendente = New DevExpress.XtraReports.UI.XRLabel
        Me.RazonPrueba = New DevExpress.XtraReports.UI.XRLabel
        Me.RotacionCuentas = New DevExpress.XtraReports.UI.XRLabel
        Me.RotacionCuenta = New DevExpress.XtraReports.UI.XRLabel
        Me.RotacionActivos = New DevExpress.XtraReports.UI.XRLabel
        Me.RotacionActivosTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.RentabilidadVentas = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.CapitalNeto = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.UtilidadOperacion = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Height = 26
        Me.Detail.MultiColumn.ColumnCount = 2
        Me.Detail.MultiColumn.ColumnWidth = 250.0!
        Me.Detail.MultiColumn.Direction = DevExpress.XtraReports.UI.ColumnDirection.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tipo", "")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.Location = New System.Drawing.Point(258, 0)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(66, 25)
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Valor", "{0:#,#0.00}")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.Location = New System.Drawing.Point(233, 0)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion", "")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(233, 25)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3})
        Me.PageHeader.Height = 108
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(233, 83)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel5.Text = "Valor"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.Location = New System.Drawing.Point(0, 83)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(233, 25)
        Me.XrLabel4.Text = "Nombre Razon"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.XrLabel3.Location = New System.Drawing.Point(142, 0)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.ParentStyleUsing.UseForeColor = False
        Me.XrLabel3.Size = New System.Drawing.Size(367, 25)
        Me.XrLabel3.Text = "DETALLE DE RAZONES FINANCIERAS"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Height = 25
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Location = New System.Drawing.Point(550, 0)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.UtilidadOperacion, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel16, Me.XrLabel17, Me.XrLabel13, Me.XrLabel15, Me.XrLabel14, Me.CapitalNeto, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.RentabilidadVentas, Me.RotacionActivosTotal, Me.RotacionActivos, Me.RotacionCuenta, Me.RotacionCuentas, Me.RazonPrueba, Me.RazonAscendente})
        Me.ReportFooter.Height = 405
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RazonAscendente
        '
        Me.RazonAscendente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonAscendente.Location = New System.Drawing.Point(325, 83)
        Me.RazonAscendente.Name = "RazonAscendente"
        Me.RazonAscendente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RazonAscendente.ParentStyleUsing.UseFont = False
        Me.RazonAscendente.Size = New System.Drawing.Size(75, 25)
        Me.RazonAscendente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RazonPrueba
        '
        Me.RazonPrueba.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonPrueba.Location = New System.Drawing.Point(317, 108)
        Me.RazonPrueba.Name = "RazonPrueba"
        Me.RazonPrueba.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RazonPrueba.ParentStyleUsing.UseFont = False
        Me.RazonPrueba.Size = New System.Drawing.Size(75, 25)
        Me.RazonPrueba.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RotacionCuentas
        '
        Me.RotacionCuentas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotacionCuentas.Location = New System.Drawing.Point(425, 200)
        Me.RotacionCuentas.Name = "RotacionCuentas"
        Me.RotacionCuentas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RotacionCuentas.ParentStyleUsing.UseFont = False
        Me.RotacionCuentas.Size = New System.Drawing.Size(75, 25)
        Me.RotacionCuentas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RotacionCuenta
        '
        Me.RotacionCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotacionCuenta.Location = New System.Drawing.Point(458, 225)
        Me.RotacionCuenta.Name = "RotacionCuenta"
        Me.RotacionCuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RotacionCuenta.ParentStyleUsing.UseFont = False
        Me.RotacionCuenta.Size = New System.Drawing.Size(75, 25)
        Me.RotacionCuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RotacionActivos
        '
        Me.RotacionActivos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotacionActivos.Location = New System.Drawing.Point(325, 250)
        Me.RotacionActivos.Name = "RotacionActivos"
        Me.RotacionActivos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RotacionActivos.ParentStyleUsing.UseFont = False
        Me.RotacionActivos.Size = New System.Drawing.Size(75, 25)
        Me.RotacionActivos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RotacionActivosTotal
        '
        Me.RotacionActivosTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotacionActivosTotal.Location = New System.Drawing.Point(350, 275)
        Me.RotacionActivosTotal.Name = "RotacionActivosTotal"
        Me.RotacionActivosTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RotacionActivosTotal.ParentStyleUsing.UseFont = False
        Me.RotacionActivosTotal.Size = New System.Drawing.Size(75, 25)
        Me.RotacionActivosTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RentabilidadVentas
        '
        Me.RentabilidadVentas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentabilidadVentas.Location = New System.Drawing.Point(458, 333)
        Me.RentabilidadVentas.Name = "RentabilidadVentas"
        Me.RentabilidadVentas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RentabilidadVentas.ParentStyleUsing.UseFont = False
        Me.RentabilidadVentas.Size = New System.Drawing.Size(75, 25)
        Me.RentabilidadVentas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.Location = New System.Drawing.Point(325, 83)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(233, 25)
        Me.XrLabel7.Text = "Nombre Razon"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.Location = New System.Drawing.Point(558, 83)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ParentStyleUsing.UseBorders = False
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel8.Text = "Valor"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.Location = New System.Drawing.Point(0, 25)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(133, 17)
        Me.XrLabel9.Text = "Razones de Liquidez"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.Location = New System.Drawing.Point(0, 150)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.ParentStyleUsing.UseFont = False
        Me.XrLabel10.Size = New System.Drawing.Size(133, 17)
        Me.XrLabel10.Text = "Razones de Actividad"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.Location = New System.Drawing.Point(33, 83)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.ParentStyleUsing.UseFont = False
        Me.XrLabel11.Size = New System.Drawing.Size(234, 25)
        Me.XrLabel11.Text = "2. Razon Ascendete (Indice de Solvencia) = "
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.Location = New System.Drawing.Point(267, 83)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel12.Text = "AC / PC = "
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CapitalNeto
        '
        Me.CapitalNeto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapitalNeto.Location = New System.Drawing.Point(242, 58)
        Me.CapitalNeto.Name = "CapitalNeto"
        Me.CapitalNeto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CapitalNeto.ParentStyleUsing.UseFont = False
        Me.CapitalNeto.Size = New System.Drawing.Size(75, 25)
        Me.CapitalNeto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.Location = New System.Drawing.Point(33, 58)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.ParentStyleUsing.UseFont = False
        Me.XrLabel14.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel14.Text = "1. Capital de Trabajo Neto ="
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.Location = New System.Drawing.Point(183, 58)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.ParentStyleUsing.UseFont = False
        Me.XrLabel15.Size = New System.Drawing.Size(59, 25)
        Me.XrLabel15.Text = "AC - PC ="
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.Location = New System.Drawing.Point(192, 108)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel13.Text = "AC - Inventarios / PC = "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.Location = New System.Drawing.Point(33, 108)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.ParentStyleUsing.UseFont = False
        Me.XrLabel17.Size = New System.Drawing.Size(159, 25)
        Me.XrLabel17.Text = "3. Razon de Prueba Rapida ="
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.Location = New System.Drawing.Point(33, 175)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.ParentStyleUsing.UseFont = False
        Me.XrLabel16.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel16.Text = "1. Rotacion de Inventarios ="
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.Location = New System.Drawing.Point(183, 175)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.ParentStyleUsing.UseFont = False
        Me.XrLabel18.Size = New System.Drawing.Size(217, 25)
        Me.XrLabel18.Text = "Costo de Ventas / Inventario Promedio ="
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.Location = New System.Drawing.Point(33, 200)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.ParentStyleUsing.UseFont = False
        Me.XrLabel19.Size = New System.Drawing.Size(192, 25)
        Me.XrLabel19.Text = "2. Rotacion de Cuentas por Cobrar ="
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.Location = New System.Drawing.Point(225, 200)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.ParentStyleUsing.UseFont = False
        Me.XrLabel20.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel20.Text = "Ventas Netas / Cuentas por Cobrar ="
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.Location = New System.Drawing.Point(33, 225)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.ParentStyleUsing.UseFont = False
        Me.XrLabel21.Size = New System.Drawing.Size(192, 25)
        Me.XrLabel21.Text = "3. Rotacion de Cuentas por Pagar ="
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.Location = New System.Drawing.Point(225, 225)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.ParentStyleUsing.UseFont = False
        Me.XrLabel22.Size = New System.Drawing.Size(233, 25)
        Me.XrLabel22.Text = "Compra de Mercancia / Cuentas por Pagar ="
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.Location = New System.Drawing.Point(192, 250)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.ParentStyleUsing.UseFont = False
        Me.XrLabel23.Size = New System.Drawing.Size(133, 25)
        Me.XrLabel23.Text = "Ventas / Activos Fijos ="
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.Location = New System.Drawing.Point(33, 250)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.ParentStyleUsing.UseFont = False
        Me.XrLabel24.Size = New System.Drawing.Size(159, 25)
        Me.XrLabel24.Text = "4. Rotacion de Activos Fijos ="
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.Location = New System.Drawing.Point(33, 275)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.ParentStyleUsing.UseFont = False
        Me.XrLabel25.Size = New System.Drawing.Size(175, 25)
        Me.XrLabel25.Text = "5. Rotacion de Activos Totales ="
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.Location = New System.Drawing.Point(208, 275)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.ParentStyleUsing.UseFont = False
        Me.XrLabel26.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel26.Text = "Ventas / Activos Totales ="
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.Location = New System.Drawing.Point(0, 308)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.ParentStyleUsing.UseFont = False
        Me.XrLabel27.Size = New System.Drawing.Size(158, 17)
        Me.XrLabel27.Text = "Razones de Rentabilidad"
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.Location = New System.Drawing.Point(233, 333)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.ParentStyleUsing.UseFont = False
        Me.XrLabel28.Size = New System.Drawing.Size(225, 25)
        Me.XrLabel28.Text = "Ventas Netas - Costo de Venta / Ventas = "
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.Location = New System.Drawing.Point(25, 333)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.ParentStyleUsing.UseFont = False
        Me.XrLabel29.Size = New System.Drawing.Size(208, 25)
        Me.XrLabel29.Text = "1. Rentabilidad Relacion a las Ventas ="
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.Location = New System.Drawing.Point(225, 358)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.ParentStyleUsing.UseFont = False
        Me.XrLabel30.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel30.Text = "Utilidad de Peracion / Ventas Netas ="
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.Location = New System.Drawing.Point(25, 358)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.ParentStyleUsing.UseFont = False
        Me.XrLabel31.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel31.Text = "2. Margen de Utilidad de Operacion ="
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'UtilidadOperacion
        '
        Me.UtilidadOperacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilidadOperacion.Location = New System.Drawing.Point(425, 358)
        Me.UtilidadOperacion.Name = "UtilidadOperacion"
        Me.UtilidadOperacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.UtilidadOperacion.ParentStyleUsing.UseFont = False
        Me.UtilidadOperacion.Size = New System.Drawing.Size(75, 25)
        Me.UtilidadOperacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RptRazonesFinan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub XrLabel6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel6.TextChanged
        If IsNumeric(XrLabel6.Text) Then
            XrLabel2.Text = CreaCero(XrLabel2.Text)
            Select Case CInt(XrLabel6.Text)
                Case 1 : Razones(0) = CDbl(CreaCero(XrLabel2.Text))
                Case 2 : Razones(1) = CDbl(CreaCero(XrLabel2.Text))
                Case 3 : Razones(2) = CDbl(CreaCero(XrLabel2.Text))
                Case 4 : Razones(3) = CDbl(CreaCero(XrLabel2.Text))
                Case 5 : Razones(4) = CDbl(CreaCero(XrLabel2.Text))
                Case 6 : Razones(5) = CDbl(CreaCero(XrLabel2.Text))
                Case 7 : Razones(6) = CDbl(CreaCero(XrLabel2.Text))
                Case 8 : Razones(7) = CDbl(CreaCero(XrLabel2.Text))
                Case 9 : Razones(8) = CDbl(CreaCero(XrLabel2.Text))
                Case 10 : Razones(9) = CDbl(CreaCero(XrLabel2.Text))
                Case 100 : Razones(10) = CDbl(CreaCero(XrLabel2.Text))
            End Select
        End If
    End Sub

    Private Sub ReportFooter_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        CapitalNeto.Text = Format(Razones(0) - Razones(1), "#,#0.00")
        RazonAscendente.Text = IIf(Razones(1) > 0, Format(Razones(0) / Razones(1), "#,#0.00"), "0.00")
        RazonPrueba.Text = IIf(Razones(1) > 0, Format((Razones(0) - Razones(10)) / Razones(1), "#,#0.00"), "0.00")
        RotacionCuentas.Text = IIf(Razones(10) > 0, Format(Razones(3) / Razones(4), "#,#0.00"), "0.00")
        RotacionCuenta.Text = IIf(Razones(6) > 0, Format(Razones(5) / Razones(6), "#,#0.00"), "0.00")
        RotacionActivos.Text = IIf(Razones(7) > 0, Format(Razones(3) / Razones(7), "#,#0.00"), "0.00")
        RotacionActivosTotal.Text = IIf(Razones(7) > 0 Or Razones(8) > 0 Or Razones(0) > 0, Format(Razones(3) / (Razones(7) + Razones(8) + Razones(0)), "#,#0.00"), "0.00")
        RentabilidadVentas.Text = IIf(Razones(3) > 0, Format((Razones(3) - Razones(2)) / Razones(3), "#,#0.00"), "0.00")
        UtilidadOperacion.Text = IIf(Razones(3) > 0, Format((Razones(2) + Razones(9)) / Razones(3), "#,#0.00"), "0.00")
    End Sub

    Private Function CreaCero(ByVal Cad As String) As String
        Return (IIf(Cad = vbNullString, "0.00", Cad))
    End Function
End Class

