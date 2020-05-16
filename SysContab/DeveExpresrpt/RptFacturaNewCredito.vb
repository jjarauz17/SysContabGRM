Imports DevExpress.XtraReports.UI

Public Class RptFacturaNewCredito
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

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Valor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Precio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cantidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descripcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Item As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Iva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Factura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tienda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Remision As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vendedor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vencimiento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TipoCambio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalDolar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormaPago As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Direccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Telefono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ClienteCodigo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EnLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detalle As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents Encabezado As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PieDePagina As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PiedelDetalle As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Exento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Gravado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoIva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoSubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoIva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalFactura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoSubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Credito As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents Contado As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Orden As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vuelto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tarjeta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Efectivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cultivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NoEntrega As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CodigoLetra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Serie As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Unidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Cheque As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detalle = New DevExpress.XtraReports.UI.DetailBand()
        Me.Unidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Gravado = New DevExpress.XtraReports.UI.XRLabel()
        Me.Exento = New DevExpress.XtraReports.UI.XRLabel()
        Me.Valor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Precio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cantidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Item = New DevExpress.XtraReports.UI.XRLabel()
        Me.Encabezado = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Serie = New DevExpress.XtraReports.UI.XRLabel()
        Me.CodigoLetra = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormaPago = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cheque = New DevExpress.XtraReports.UI.XRLabel()
        Me.Efectivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tarjeta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Contado = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.Credito = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.EnLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.ClienteCodigo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Telefono = New DevExpress.XtraReports.UI.XRLabel()
        Me.Direccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalDolar = New DevExpress.XtraReports.UI.XRLabel()
        Me.TipoCambio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vendedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tienda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.Orden = New DevExpress.XtraReports.UI.XRLabel()
        Me.Remision = New DevExpress.XtraReports.UI.XRLabel()
        Me.PieDePagina = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.NoEntrega = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cultivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vuelto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoIva = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoSubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoIva = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoSubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalFactura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Iva = New DevExpress.XtraReports.UI.XRLabel()
        Me.PiedelDetalle = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalle
        '
        Me.Detalle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Unidad, Me.Gravado, Me.Exento, Me.Valor, Me.Precio, Me.Cantidad, Me.Descripcion, Me.Item})
        Me.Detalle.HeightF = 25.0!
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detalle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Unidad
        '
        Me.Unidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unidad")})
        Me.Unidad.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Unidad.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 0.0!)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Unidad.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.Unidad.Text = "Unidad"
        Me.Unidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Gravado
        '
        Me.Gravado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Gravado", "{0:n2}")})
        Me.Gravado.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Gravado.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 0.0!)
        Me.Gravado.Name = "Gravado"
        Me.Gravado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Gravado.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Gravado.Text = "XrLabel1"
        Me.Gravado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Exento
        '
        Me.Exento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Exento", "{0:n2}")})
        Me.Exento.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Exento.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 0.0!)
        Me.Exento.Name = "Exento"
        Me.Exento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Exento.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Exento.Text = "Exento"
        Me.Exento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Valor
        '
        Me.Valor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n2}")})
        Me.Valor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Valor.LocationFloat = New DevExpress.Utils.PointFloat(525.0!, 0.0!)
        Me.Valor.Name = "Valor"
        Me.Valor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Valor.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Valor.Text = "XrLabel1"
        Me.Valor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Precio
        '
        Me.Precio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unitario", "{0:n2}")})
        Me.Precio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Precio.LocationFloat = New DevExpress.Utils.PointFloat(475.0!, 0.0!)
        Me.Precio.Name = "Precio"
        Me.Precio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Precio.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.Precio.Text = "XrLabel1"
        Me.Precio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cantidad
        '
        Me.Cantidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad")})
        Me.Cantidad.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cantidad.LocationFloat = New DevExpress.Utils.PointFloat(367.0!, 0.0!)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cantidad.SizeF = New System.Drawing.SizeF(58.0!, 25.0!)
        Me.Cantidad.Text = "XrLabel1"
        Me.Cantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Descripcion
        '
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion")})
        Me.Descripcion.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Descripcion.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0.0!)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Descripcion.Text = "XrLabel1"
        Me.Descripcion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Item
        '
        Me.Item.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Codigo")})
        Me.Item.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Item.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Item.Name = "Item"
        Me.Item.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Item.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Item.Text = "Item"
        Me.Item.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Encabezado
        '
        Me.Encabezado.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Serie, Me.CodigoLetra, Me.FormaPago, Me.Cheque, Me.Efectivo, Me.Tarjeta, Me.Contado, Me.Credito, Me.EnLetras, Me.ClienteCodigo, Me.Telefono, Me.Direccion, Me.TotalDolar, Me.TipoCambio, Me.Vendedor, Me.Cliente, Me.Fecha, Me.Tienda, Me.Factura, Me.XrLabel2})
        Me.Encabezado.HeightF = 233.0!
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Encabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Serie
        '
        Me.Serie.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Serie")})
        Me.Serie.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Serie.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 42.0!)
        Me.Serie.Name = "Serie"
        Me.Serie.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Serie.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Serie.Text = "Serie"
        Me.Serie.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CodigoLetra
        '
        Me.CodigoLetra.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CodigoLetra")})
        Me.CodigoLetra.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CodigoLetra.LocationFloat = New DevExpress.Utils.PointFloat(308.0!, 42.0!)
        Me.CodigoLetra.Name = "CodigoLetra"
        Me.CodigoLetra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CodigoLetra.SizeF = New System.Drawing.SizeF(125.0!, 25.0!)
        Me.CodigoLetra.Text = "CodigoLetra"
        Me.CodigoLetra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FormaPago
        '
        Me.FormaPago.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FormaPago")})
        Me.FormaPago.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.FormaPago.LocationFloat = New DevExpress.Utils.PointFloat(308.0!, 67.0!)
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FormaPago.SizeF = New System.Drawing.SizeF(100.0!, 26.0!)
        Me.FormaPago.Text = "Remision"
        Me.FormaPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cheque
        '
        Me.Cheque.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cheque", "{0:n2}")})
        Me.Cheque.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cheque.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 200.0!)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cheque.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Cheque.Text = "XrLabel1"
        Me.Cheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Efectivo
        '
        Me.Efectivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Efectivo", "{0:n2}")})
        Me.Efectivo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Efectivo.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 175.0!)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Efectivo.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Efectivo.Text = "XrLabel1"
        Me.Efectivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tarjeta
        '
        Me.Tarjeta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tarjeta", "{0:n2}")})
        Me.Tarjeta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tarjeta.LocationFloat = New DevExpress.Utils.PointFloat(667.0!, 150.0!)
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tarjeta.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Tarjeta.Text = "XrLabel1"
        Me.Tarjeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Contado
        '
        Me.Contado.BorderWidth = 0.0!
        Me.Contado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Contado")})
        Me.Contado.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 200.0!)
        Me.Contado.Name = "Contado"
        Me.Contado.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Contado.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        '
        'Credito
        '
        Me.Credito.BorderWidth = 0.0!
        Me.Credito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Credito")})
        Me.Credito.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 175.0!)
        Me.Credito.Name = "Credito"
        Me.Credito.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Credito.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        '
        'EnLetras
        '
        Me.EnLetras.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EnLetras")})
        Me.EnLetras.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.EnLetras.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 167.0!)
        Me.EnLetras.Name = "EnLetras"
        Me.EnLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EnLetras.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.EnLetras.Text = "Remision"
        Me.EnLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ClienteCodigo
        '
        Me.ClienteCodigo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ClienteCodigo")})
        Me.ClienteCodigo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ClienteCodigo.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 42.0!)
        Me.ClienteCodigo.Name = "ClienteCodigo"
        Me.ClienteCodigo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ClienteCodigo.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.ClienteCodigo.Text = "ClienteCodigo"
        Me.ClienteCodigo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Telefono
        '
        Me.Telefono.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Telefono")})
        Me.Telefono.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Telefono.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 117.0!)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Telefono.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Telefono.Text = "XrLabel1"
        Me.Telefono.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Direccion
        '
        Me.Direccion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Direccion")})
        Me.Direccion.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Direccion.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 92.0!)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Direccion.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Direccion.Text = "Direccion"
        Me.Direccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TotalDolar
        '
        Me.TotalDolar.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalDolar", "{0:n2}")})
        Me.TotalDolar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalDolar.LocationFloat = New DevExpress.Utils.PointFloat(308.0!, 125.0!)
        Me.TotalDolar.Name = "TotalDolar"
        Me.TotalDolar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalDolar.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.TotalDolar.Text = "TipoCambio"
        Me.TotalDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TipoCambio
        '
        Me.TipoCambio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TipoCambio", "{0:n4}")})
        Me.TipoCambio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TipoCambio.LocationFloat = New DevExpress.Utils.PointFloat(308.0!, 100.0!)
        Me.TipoCambio.Name = "TipoCambio"
        Me.TipoCambio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TipoCambio.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.TipoCambio.Text = "TipoCambio"
        Me.TipoCambio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Vendedor
        '
        Me.Vendedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vendedor")})
        Me.Vendedor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Vendedor.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 142.0!)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vendedor.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Vendedor.Text = "Remision"
        Me.Vendedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.Cliente.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cliente.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 67.0!)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cliente.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Cliente.Text = "XrLabel1"
        Me.Cliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:MM/dd/yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 150.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Fecha.Text = "XrLabel1"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tienda
        '
        Me.Tienda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tienda")})
        Me.Tienda.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tienda.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 125.0!)
        Me.Tienda.Name = "Tienda"
        Me.Tienda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tienda.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Tienda.Text = "XrLabel1"
        Me.Tienda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Factura
        '
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(625.0!, 42.0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Factura.Text = "XrLabel1"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Despacho")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(642.0!, 125.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Cultivo"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Vencimiento
        '
        Me.Vencimiento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento", "{0:MM/dd/yyyy}")})
        Me.Vencimiento.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Vencimiento.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 25.0!)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vencimiento.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Vencimiento.Text = "Vencimiento"
        Me.Vencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Orden
        '
        Me.Orden.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orden")})
        Me.Orden.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Orden.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 25.0!)
        Me.Orden.Name = "Orden"
        Me.Orden.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Orden.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Orden.Text = "Remision"
        Me.Orden.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Remision
        '
        Me.Remision.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Remision")})
        Me.Remision.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Remision.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 25.0!)
        Me.Remision.Name = "Remision"
        Me.Remision.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Remision.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Remision.Text = "Remision"
        Me.Remision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PieDePagina
        '
        Me.PieDePagina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Vencimiento, Me.NoEntrega, Me.Remision, Me.Orden, Me.Cultivo, Me.Vuelto, Me.XrLabel1, Me.GravadoTotal, Me.ExentoTotal, Me.ExentoIva, Me.ExentoSubTotal, Me.GravadoIva, Me.GravadoSubTotal, Me.SubTotal, Me.TotalFactura, Me.Iva})
        Me.PieDePagina.HeightF = 196.0!
        Me.PieDePagina.Name = "PieDePagina"
        Me.PieDePagina.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PieDePagina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'NoEntrega
        '
        Me.NoEntrega.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NoEntrega")})
        Me.NoEntrega.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NoEntrega.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 25.0!)
        Me.NoEntrega.Name = "NoEntrega"
        Me.NoEntrega.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NoEntrega.SizeF = New System.Drawing.SizeF(92.0!, 25.0!)
        Me.NoEntrega.Text = "NoEntrega"
        Me.NoEntrega.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cultivo
        '
        Me.Cultivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cultivo")})
        Me.Cultivo.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 25.0!)
        Me.Cultivo.Name = "Cultivo"
        Me.Cultivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cultivo.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Cultivo.StylePriority.UseTextAlignment = False
        Me.Cultivo.Text = "Cultivo"
        Me.Cultivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Vuelto
        '
        Me.Vuelto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vuelto", "{0:n2}")})
        Me.Vuelto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Vuelto.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 150.0!)
        Me.Vuelto.Name = "Vuelto"
        Me.Vuelto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vuelto.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Vuelto.Text = "XrLabel1"
        Me.Vuelto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descuento")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 25.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel1.Summary = XrSummary1
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoTotal
        '
        Me.GravadoTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoTotal", "{0:n2}")})
        Me.GravadoTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GravadoTotal.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 75.0!)
        Me.GravadoTotal.Name = "GravadoTotal"
        Me.GravadoTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.GravadoTotal.Text = "XrLabel1"
        Me.GravadoTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoTotal
        '
        Me.ExentoTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoTotal", "{0:n2}")})
        Me.ExentoTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoTotal.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 75.0!)
        Me.ExentoTotal.Name = "ExentoTotal"
        Me.ExentoTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoTotal.Text = "ExentoTotal"
        Me.ExentoTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoIva
        '
        Me.ExentoIva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoIva", "{0:n2}")})
        Me.ExentoIva.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoIva.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 50.0!)
        Me.ExentoIva.Name = "ExentoIva"
        Me.ExentoIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoIva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoIva.Text = "XrLabel1"
        Me.ExentoIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoSubTotal
        '
        Me.ExentoSubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoSubTotal", "{0:n2}")})
        Me.ExentoSubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoSubTotal.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 0.0!)
        Me.ExentoSubTotal.Name = "ExentoSubTotal"
        Me.ExentoSubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoSubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoSubTotal.Text = "XrLabel1"
        Me.ExentoSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoIva
        '
        Me.GravadoIva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoIva", "{0:n2}")})
        Me.GravadoIva.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GravadoIva.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 50.0!)
        Me.GravadoIva.Name = "GravadoIva"
        Me.GravadoIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoIva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.GravadoIva.Text = "XrLabel1"
        Me.GravadoIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoSubTotal
        '
        Me.GravadoSubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoSubTotal", "{0:n2}")})
        Me.GravadoSubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GravadoSubTotal.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 0.0!)
        Me.GravadoSubTotal.Name = "GravadoSubTotal"
        Me.GravadoSubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoSubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.GravadoSubTotal.Text = "GravadoSubTotal"
        Me.GravadoSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SubTotal
        '
        Me.SubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "{0:n2}")})
        Me.SubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.SubTotal.LocationFloat = New DevExpress.Utils.PointFloat(525.0!, 0.0!)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.SubTotal.Text = "XrLabel1"
        Me.SubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalFactura
        '
        Me.TotalFactura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalFactura", "{0:n2}")})
        Me.TotalFactura.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.TotalFactura.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 117.0!)
        Me.TotalFactura.Name = "TotalFactura"
        Me.TotalFactura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalFactura.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.TotalFactura.Text = "XrLabel1"
        Me.TotalFactura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Iva
        '
        Me.Iva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Iva", "{0:n2}")})
        Me.Iva.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Iva.LocationFloat = New DevExpress.Utils.PointFloat(525.0!, 50.0!)
        Me.Iva.Name = "Iva"
        Me.Iva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Iva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Iva.Text = "XrLabel1"
        Me.Iva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PiedelDetalle
        '
        Me.PiedelDetalle.HeightF = 33.0!
        Me.PiedelDetalle.Name = "PiedelDetalle"
        Me.PiedelDetalle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PiedelDetalle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'RptFacturaNewCredito
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalle, Me.Encabezado, Me.PieDePagina, Me.PiedelDetalle, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class