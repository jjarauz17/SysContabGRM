Imports DevExpress.XtraReports.UI

Public Class RptCotizacionNew
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
    Friend WithEvents Vendedor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vencimiento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TipoCambio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalDolar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Direccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Telefono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detalle As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents Encabezado As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PieDePagina As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PiedelDetalle As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents TotalFactura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Validez As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents EnLetras As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detalle = New DevExpress.XtraReports.UI.DetailBand()
        Me.Valor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Precio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cantidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Item = New DevExpress.XtraReports.UI.XRLabel()
        Me.Encabezado = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.EnLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Telefono = New DevExpress.XtraReports.UI.XRLabel()
        Me.Direccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tienda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Validez = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalDolar = New DevExpress.XtraReports.UI.XRLabel()
        Me.TipoCambio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vendedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.PieDePagina = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalFactura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Iva = New DevExpress.XtraReports.UI.XRLabel()
        Me.PiedelDetalle = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detalle
        '
        Me.Detalle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Valor, Me.Precio, Me.Cantidad, Me.Descripcion, Me.Item})
        Me.Detalle.HeightF = 25.0!
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detalle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Valor
        '
        Me.Valor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n2}")})
        Me.Valor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor.LocationFloat = New DevExpress.Utils.PointFloat(617.0!, 0.0!)
        Me.Valor.Name = "Valor"
        Me.Valor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Valor.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Valor.Text = "XrLabel1"
        Me.Valor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Precio
        '
        Me.Precio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unitario", "{0:n2}")})
        Me.Precio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.LocationFloat = New DevExpress.Utils.PointFloat(533.0!, 0.0!)
        Me.Precio.Name = "Precio"
        Me.Precio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Precio.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Precio.Text = "XrLabel1"
        Me.Precio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cantidad
        '
        Me.Cantidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad")})
        Me.Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.LocationFloat = New DevExpress.Utils.PointFloat(442.0!, 0.0!)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cantidad.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Cantidad.Text = "XrLabel1"
        Me.Cantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Descripcion
        '
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion")})
        Me.Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0.0!)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.SizeF = New System.Drawing.SizeF(333.0!, 25.0!)
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
        Me.Encabezado.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.EnLetras, Me.XrLabel2, Me.Telefono, Me.Direccion, Me.Vencimiento, Me.Cliente, Me.Fecha, Me.Tienda, Me.Factura})
        Me.Encabezado.HeightF = 233.0!
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Encabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'EnLetras
        '
        Me.EnLetras.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EnLetras")})
        Me.EnLetras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnLetras.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 142.0!)
        Me.EnLetras.Name = "EnLetras"
        Me.EnLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EnLetras.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.EnLetras.Text = "Remision"
        Me.EnLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(333.0!, 17.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
        Me.XrLabel2.Text = "RUC : 051197-9544"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Telefono
        '
        Me.Telefono.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Telefono")})
        Me.Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Direccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.LocationFloat = New DevExpress.Utils.PointFloat(33.0!, 92.0!)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Direccion.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.Direccion.Text = "Direccion"
        Me.Direccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Vencimiento
        '
        Me.Vencimiento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento", "{0:MM/dd/yyyy}")})
        Me.Vencimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vencimiento.LocationFloat = New DevExpress.Utils.PointFloat(558.0!, 142.0!)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vencimiento.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Vencimiento.Text = "Vencimiento"
        Me.Vencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cliente
        '
        Me.Cliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.Cliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Fecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(558.0!, 117.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Fecha.Text = "XrLabel1"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tienda
        '
        Me.Tienda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tienda")})
        Me.Tienda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tienda.LocationFloat = New DevExpress.Utils.PointFloat(558.0!, 92.0!)
        Me.Tienda.Name = "Tienda"
        Me.Tienda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tienda.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Tienda.Text = "XrLabel1"
        Me.Tienda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Factura
        '
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(558.0!, 67.0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Factura.Text = "XrLabel1"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Validez
        '
        Me.Validez.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Validez")})
        Me.Validez.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Validez.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 100.0!)
        Me.Validez.Name = "Validez"
        Me.Validez.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Validez.SizeF = New System.Drawing.SizeF(233.0!, 26.0!)
        Me.Validez.Text = "Remision"
        Me.Validez.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TotalDolar
        '
        Me.TotalDolar.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalDolar", "{0:n2}")})
        Me.TotalDolar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDolar.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 150.0!)
        Me.TotalDolar.Name = "TotalDolar"
        Me.TotalDolar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalDolar.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.TotalDolar.Text = "TipoCambio"
        Me.TotalDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TipoCambio
        '
        Me.TipoCambio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TipoCambio", "{0:n2}")})
        Me.TipoCambio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoCambio.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 125.0!)
        Me.TipoCambio.Name = "TipoCambio"
        Me.TipoCambio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TipoCambio.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.TipoCambio.Text = "TipoCambio"
        Me.TipoCambio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Vendedor
        '
        Me.Vendedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vendedor")})
        Me.Vendedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 125.0!)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vendedor.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.Vendedor.Text = "Remision"
        Me.Vendedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PieDePagina
        '
        Me.PieDePagina.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Validez, Me.TotalDolar, Me.TipoCambio, Me.XrLabel5, Me.XrLabel4, Me.Vendedor, Me.XrLabel1, Me.SubTotal, Me.TotalFactura, Me.Iva})
        Me.PieDePagina.HeightF = 196.0!
        Me.PieDePagina.Name = "PieDePagina"
        Me.PieDePagina.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PieDePagina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 150.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(233.0!, 25.0!)
        Me.XrLabel5.Text = "2271-9313"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 150.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.XrLabel4.Text = "METROCENTRO"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 100.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(225.0!, 25.0!)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SubTotal
        '
        Me.SubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "{0:n2}")})
        Me.SubTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.LocationFloat = New DevExpress.Utils.PointFloat(617.0!, 0.0!)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.SubTotal.Text = "XrLabel1"
        Me.SubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalFactura
        '
        Me.TotalFactura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalFactura", "{0:n2}")})
        Me.TotalFactura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalFactura.LocationFloat = New DevExpress.Utils.PointFloat(617.0!, 50.0!)
        Me.TotalFactura.Name = "TotalFactura"
        Me.TotalFactura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalFactura.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.TotalFactura.Text = "XrLabel1"
        Me.TotalFactura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Iva
        '
        Me.Iva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Iva", "{0:n2}")})
        Me.Iva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iva.LocationFloat = New DevExpress.Utils.PointFloat(617.0!, 25.0!)
        Me.Iva.Name = "Iva"
        Me.Iva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Iva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Iva.Text = "XrLabel1"
        Me.Iva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PiedelDetalle
        '
        Me.PiedelDetalle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3})
        Me.PiedelDetalle.HeightF = 75.0!
        Me.PiedelDetalle.Name = "PiedelDetalle"
        Me.PiedelDetalle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PiedelDetalle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 8.0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(433.0!, 67.0!)
        Me.XrLabel3.Text = "NO HAY DEVOLUCION DE DINERO EN EFECTIVO." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CAMBIO DE ARTICUOS ES EFECTUABLE DENTRO" & _
    " DE 24 HRS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MEDIANTE LA EMISION DE NOTA DE CREDITO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CENTRO COMERCIAL METROCENTRO" & _
    "."
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'RptCotizacionNew
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detalle, Me.Encabezado, Me.PieDePagina, Me.PiedelDetalle, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Version = "13.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class