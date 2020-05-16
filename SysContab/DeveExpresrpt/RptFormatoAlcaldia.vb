Imports DevExpress.XtraReports.UI

Public Class RptFormatoAlcaldia
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
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ValorCompra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Retencion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tasa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cheque As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Comprobante As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RetencionLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ComprasLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Facturas As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Facturas = New DevExpress.XtraReports.UI.XRLabel()
        Me.ComprasLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.RetencionLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Comprobante = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cheque = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tasa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Retencion = New DevExpress.XtraReports.UI.XRLabel()
        Me.ValorCompra = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Facturas, Me.ComprasLetras, Me.RetencionLetras, Me.Cuenta, Me.Comprobante, Me.Cheque, Me.Fecha, Me.Tasa, Me.Retencion, Me.ValorCompra, Me.Nombre})
        Me.Detail.HeightF = 293.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Facturas
        '
        Me.Facturas.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Facturas")})
        Me.Facturas.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Facturas.LocationFloat = New DevExpress.Utils.PointFloat(242.0!, 25.0!)
        Me.Facturas.Name = "Facturas"
        Me.Facturas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Facturas.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Facturas.Text = "Nombre"
        Me.Facturas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ComprasLetras
        '
        Me.ComprasLetras.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ComprasLetras.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 50.0!)
        Me.ComprasLetras.Name = "ComprasLetras"
        Me.ComprasLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ComprasLetras.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.ComprasLetras.Text = "Nombre"
        Me.ComprasLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RetencionLetras
        '
        Me.RetencionLetras.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.RetencionLetras.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 100.0!)
        Me.RetencionLetras.Name = "RetencionLetras"
        Me.RetencionLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RetencionLetras.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.RetencionLetras.Text = "Nombre"
        Me.RetencionLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta")})
        Me.Cuenta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 225.0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Cuenta.Text = "Nombre"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Comprobante
        '
        Me.Comprobante.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comprobante")})
        Me.Comprobante.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Comprobante.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 200.0!)
        Me.Comprobante.Name = "Comprobante"
        Me.Comprobante.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Comprobante.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Comprobante.Text = "Nombre"
        Me.Comprobante.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cheque
        '
        Me.Cheque.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cheque")})
        Me.Cheque.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cheque.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 175.0!)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cheque.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Cheque.Text = "Nombre"
        Me.Cheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha")})
        Me.Fecha.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 150.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Fecha.Text = "Nombre"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tasa
        '
        Me.Tasa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tasa")})
        Me.Tasa.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tasa.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 125.0!)
        Me.Tasa.Name = "Tasa"
        Me.Tasa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tasa.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Tasa.Text = "Nombre"
        Me.Tasa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Retencion
        '
        Me.Retencion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Retencion")})
        Me.Retencion.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Retencion.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 75.0!)
        Me.Retencion.Name = "Retencion"
        Me.Retencion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Retencion.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Retencion.Text = "Nombre"
        Me.Retencion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ValorCompra
        '
        Me.ValorCompra.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ValorCompra")})
        Me.ValorCompra.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ValorCompra.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 25.0!)
        Me.ValorCompra.Name = "ValorCompra"
        Me.ValorCompra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ValorCompra.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.ValorCompra.Text = "Nombre"
        Me.ValorCompra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 0.0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 30.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 30.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 100.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 100.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'RptFormatoAlcaldia
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Version = "15.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub RptFormatoAlcaldia_DataSourceRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles MyBase.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()
        RetencionLetras.Text = VB.SysContab.Rutinas.Letras(Fila.Item("Retencion"), "")
        ComprasLetras.Text = VB.SysContab.Rutinas.Letras(Fila.Item("ValorCompra"), "")
    End Sub
End Class

