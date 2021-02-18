Imports DevExpress.XtraReports.UI

Public Class RptRecibo
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
    Friend WithEvents Dia As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Monto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RecibimosDe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PorCuentaDe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SumaLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cheque As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Banco As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Dolares As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cordobas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cajero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents US As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents C As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents ChequeMonto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Abono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Retencion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Sucursal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tarjeta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Concepto As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Cordobas = New DevExpress.XtraReports.UI.XRLabel()
        Me.Dolares = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Banco = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cheque = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Sucursal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Concepto = New DevExpress.XtraReports.UI.XRLabel()
        Me.SumaLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.RecibimosDe = New DevExpress.XtraReports.UI.XRLabel()
        Me.Monto = New DevExpress.XtraReports.UI.XRLabel()
        Me.PorCuentaDe = New DevExpress.XtraReports.UI.XRLabel()
        Me.Dia = New DevExpress.XtraReports.UI.XRLabel()
        Me.US = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.C = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.Abono = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Tarjeta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Retencion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ChequeMonto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cajero = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Cordobas, Me.Dolares, Me.Cuenta, Me.Banco, Me.Cheque})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Cordobas
        '
        Me.Cordobas.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cordobas]")})
        Me.Cordobas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cordobas.LocationFloat = New DevExpress.Utils.PointFloat(653.0!, 0!)
        Me.Cordobas.Name = "Cordobas"
        Me.Cordobas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cordobas.SizeF = New System.Drawing.SizeF(97.0!, 20.0!)
        Me.Cordobas.StylePriority.UseFont = False
        Me.Cordobas.Text = "Cordobas"
        Me.Cordobas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Dolares
        '
        Me.Dolares.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dolares]")})
        Me.Dolares.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dolares.LocationFloat = New DevExpress.Utils.PointFloat(556.0!, 0!)
        Me.Dolares.Name = "Dolares"
        Me.Dolares.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dolares.SizeF = New System.Drawing.SizeF(97.0!, 20.0!)
        Me.Dolares.StylePriority.UseFont = False
        Me.Dolares.Text = "Dolares"
        Me.Dolares.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cuenta
        '
        Me.Cuenta.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cuenta]")})
        Me.Cuenta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(396.0!, 0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(160.0!, 20.0!)
        Me.Cuenta.StylePriority.UseFont = False
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Banco
        '
        Me.Banco.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Banco]")})
        Me.Banco.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banco.LocationFloat = New DevExpress.Utils.PointFloat(117.0!, 0!)
        Me.Banco.Name = "Banco"
        Me.Banco.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Banco.SizeF = New System.Drawing.SizeF(279.0!, 20.0!)
        Me.Banco.StylePriority.UseFont = False
        Me.Banco.Text = "Banco"
        Me.Banco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChequeNo]")})
        Me.Cheque.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cheque.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cheque.SizeF = New System.Drawing.SizeF(117.0!, 20.0!)
        Me.Cheque.StylePriority.UseFont = False
        Me.Cheque.Text = "Cheque"
        Me.Cheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Sucursal, Me.XrLabel8, Me.Concepto, Me.SumaLetras, Me.RecibimosDe, Me.Monto, Me.PorCuentaDe, Me.Dia, Me.US, Me.C})
        Me.PageHeader.HeightF = 197.7917!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Sucursal
        '
        Me.Sucursal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sucursal]")})
        Me.Sucursal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sucursal.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 10.00001!)
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sucursal.SizeF = New System.Drawing.SizeF(490.0!, 20.0!)
        Me.Sucursal.StylePriority.UseFont = False
        Me.Sucursal.Text = "RecibimosDe"
        Me.Sucursal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MontoU]")})
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(632.9999!, 70.00003!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(107.0001!, 20.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Monto"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel8.TextFormatString = "{0:n2}"
        '
        'Concepto
        '
        Me.Concepto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnConceptoDe]")})
        Me.Concepto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concepto.LocationFloat = New DevExpress.Utils.PointFloat(9.999983!, 110.0001!)
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto.SizeF = New System.Drawing.SizeF(730.0001!, 20.0!)
        Me.Concepto.StylePriority.UseFont = False
        Me.Concepto.Text = "PorCuentaDe"
        Me.Concepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SumaLetras
        '
        Me.SumaLetras.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SumaLetras]")})
        Me.SumaLetras.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaLetras.LocationFloat = New DevExpress.Utils.PointFloat(9.999983!, 90.00004!)
        Me.SumaLetras.Name = "SumaLetras"
        Me.SumaLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SumaLetras.SizeF = New System.Drawing.SizeF(490.0!, 20.0!)
        Me.SumaLetras.StylePriority.UseFont = False
        Me.SumaLetras.Text = "PorCuentaDe"
        Me.SumaLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'RecibimosDe
        '
        Me.RecibimosDe.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RecibimosDe]")})
        Me.RecibimosDe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecibimosDe.LocationFloat = New DevExpress.Utils.PointFloat(9.999983!, 49.99995!)
        Me.RecibimosDe.Name = "RecibimosDe"
        Me.RecibimosDe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RecibimosDe.SizeF = New System.Drawing.SizeF(490.0!, 20.0!)
        Me.RecibimosDe.StylePriority.UseFont = False
        Me.RecibimosDe.Text = "RecibimosDe"
        Me.RecibimosDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Monto
        '
        Me.Monto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Monto]")})
        Me.Monto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 49.99995!)
        Me.Monto.Name = "Monto"
        Me.Monto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Monto.SizeF = New System.Drawing.SizeF(107.0001!, 20.0!)
        Me.Monto.StylePriority.UseFont = False
        Me.Monto.Text = "Monto"
        Me.Monto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Monto.TextFormatString = "{0:n2}"
        '
        'PorCuentaDe
        '
        Me.PorCuentaDe.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PorCuentaDe]")})
        Me.PorCuentaDe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorCuentaDe.LocationFloat = New DevExpress.Utils.PointFloat(9.999983!, 70.00003!)
        Me.PorCuentaDe.Name = "PorCuentaDe"
        Me.PorCuentaDe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PorCuentaDe.SizeF = New System.Drawing.SizeF(490.0!, 20.0!)
        Me.PorCuentaDe.StylePriority.UseFont = False
        Me.PorCuentaDe.Text = "PorCuentaDe"
        Me.PorCuentaDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Dia
        '
        Me.Dia.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fecha]")})
        Me.Dia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 30.0!)
        Me.Dia.Name = "Dia"
        Me.Dia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Dia.SizeF = New System.Drawing.SizeF(490.0!, 20.0!)
        Me.Dia.StylePriority.UseFont = False
        Me.Dia.StylePriority.UseTextAlignment = False
        Me.Dia.Text = "Dia"
        Me.Dia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Dia.TextFormatString = "{0:dd ""de"" MMMM ""de"" yyyy}"
        '
        'US
        '
        Me.US.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckState", "[Dolar]")})
        Me.US.LocationFloat = New DevExpress.Utils.PointFloat(632.9999!, 90.00004!)
        Me.US.Name = "US"
        Me.US.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.US.SizeF = New System.Drawing.SizeF(55.0!, 20.0!)
        '
        'C
        '
        Me.C.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckState", "[Cordoba]")})
        Me.C.LocationFloat = New DevExpress.Utils.PointFloat(690.0001!, 90.00004!)
        Me.C.Name = "C"
        Me.C.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.C.SizeF = New System.Drawing.SizeF(50.0!, 20.0!)
        '
        'Abono
        '
        Me.Abono.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Abono]")})
        Me.Abono.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abono.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 67.00001!)
        Me.Abono.Name = "Abono"
        Me.Abono.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Abono.SizeF = New System.Drawing.SizeF(330.1667!, 20.00002!)
        Me.Abono.StylePriority.UseFont = False
        Me.Abono.Text = "PorCuentaDe"
        Me.Abono.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tarjeta, Me.Retencion, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.ChequeMonto, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.Cajero, Me.XrLabel1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.Abono})
        Me.PageFooter.HeightF = 127.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Tarjeta
        '
        Me.Tarjeta.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tarjeta]")})
        Me.Tarjeta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarjeta.LocationFloat = New DevExpress.Utils.PointFloat(31.37511!, 106.0!)
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tarjeta.SizeF = New System.Drawing.SizeF(143.6249!, 20.0!)
        Me.Tarjeta.StylePriority.UseFont = False
        Me.Tarjeta.Text = "XrLabel1"
        Me.Tarjeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Tarjeta.TextFormatString = "{0:n2}"
        '
        'Retencion
        '
        Me.Retencion.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Retencion]")})
        Me.Retencion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retencion.LocationFloat = New DevExpress.Utils.PointFloat(31.37511!, 85.99997!)
        Me.Retencion.Name = "Retencion"
        Me.Retencion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Retencion.SizeF = New System.Drawing.SizeF(143.6249!, 20.00002!)
        Me.Retencion.StylePriority.UseFont = False
        Me.Retencion.StylePriority.UseTextAlignment = False
        Me.Retencion.Text = "PorCuentaDe"
        Me.Retencion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Retencion.TextFormatString = "{0:n2}"
        '
        'XrLabel12
        '
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TCambio]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(31.37507!, 65.99998!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(143.6249!, 20.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "XrLabel1"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel12.TextFormatString = "{0:n4}"
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaldoNuevoU]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(527.7917!, 46.00003!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "XrLabel5"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel11.TextFormatString = "{0:n2}"
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EsteAbonoU]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(527.7917!, 22.99999!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "XrLabel5"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel10.TextFormatString = "{0:n2}"
        '
        'XrLabel9
        '
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaldoAnteriorU]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(527.7917!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "XrLabel5"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel9.TextFormatString = "{0:n2}"
        '
        'ChequeMonto
        '
        Me.ChequeMonto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChequeMonto]")})
        Me.ChequeMonto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeMonto.LocationFloat = New DevExpress.Utils.PointFloat(31.37511!, 21.99999!)
        Me.ChequeMonto.Name = "ChequeMonto"
        Me.ChequeMonto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ChequeMonto.SizeF = New System.Drawing.SizeF(140.6249!, 20.0!)
        Me.ChequeMonto.StylePriority.UseFont = False
        Me.ChequeMonto.Text = "Cordobas"
        Me.ChequeMonto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.ChequeMonto.TextFormatString = "{0:n2}"
        '
        'XrLabel7
        '
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaldoNuevo]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 46.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "XrLabel5"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel7.TextFormatString = "{0:n2}"
        '
        'XrLabel6
        '
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EsteAbono]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 23.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "XrLabel5"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel6.TextFormatString = "{0:n2}"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SaldoAnterior]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel5.TextFormatString = "{0:n2}"
        '
        'Cajero
        '
        Me.Cajero.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cajero]")})
        Me.Cajero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cajero.LocationFloat = New DevExpress.Utils.PointFloat(317.0!, 45.99997!)
        Me.Cajero.Name = "Cajero"
        Me.Cajero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cajero.SizeF = New System.Drawing.SizeF(196.1667!, 20.0!)
        Me.Cajero.StylePriority.UseFont = False
        Me.Cajero.Text = "Cajero"
        Me.Cajero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ChequeNo]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 47.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(134.0!, 20.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Cheque"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Banco]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(183.0!, 24.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(134.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Banco"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Efectivo]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(31.37511!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(143.6249!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel1"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel3.TextFormatString = "{0:n2}"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(31.37511!, 46.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(143.6249!, 20.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel1"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel2.TextFormatString = "{0:n2}"
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
        'RptRecibo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.PageHeight = 550
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub RptRecibo_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
    End Sub

    Private Sub ChequeMonto_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ChequeMonto.BeforePrint
        'If CDbl(Me.ChequeMonto.Text) = 0 Then
        '    Me.ChequeMonto.Text = ""
        'End If
    End Sub

    Private Sub RptRecibo_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()

        'If Fila.Item("Cordoba") = True Then
        '    XrLabel8.Visible = False
        '    US.Visible = False
        'Else
        '    Monto.Visible = False
        '    C.Visible = False
        'End If
    End Sub
End Class

