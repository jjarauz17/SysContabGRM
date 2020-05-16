<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptFormatoFactura
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFormatoFactura))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cantidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Precio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Valor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Unidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vencimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cheque = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormaPago = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tienda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vendedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.TipoCambio = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalDolar = New DevExpress.XtraReports.UI.XRLabel()
        Me.Direccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Telefono = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EnLetras = New DevExpress.XtraReports.UI.XRLabel()
        Me.Credito = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.Contado = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.Tarjeta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Efectivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.CodigoLetra = New DevExpress.XtraReports.UI.XRLabel()
        Me.Serie = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Orden = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Item = New DevExpress.XtraReports.UI.XRLabel()
        Me.Exento = New DevExpress.XtraReports.UI.XRLabel()
        Me.Gravado = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.Iva = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoSubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoSubTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoIva = New DevExpress.XtraReports.UI.XRLabel()
        Me.ExentoTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Vuelto = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cultivo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Remision = New DevExpress.XtraReports.UI.XRLabel()
        Me.NoEntrega = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalFactura = New DevExpress.XtraReports.UI.XRLabel()
        Me.GravadoIva = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Descripcion, Me.Cantidad, Me.Precio, Me.Valor, Me.Unidad})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Descripcion
        '
        Me.Descripcion.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion")})
        Me.Descripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.LocationFloat = New DevExpress.Utils.PointFloat(308.4167!, 0!)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.SizeF = New System.Drawing.SizeF(353.7051!, 20.0!)
        Me.Descripcion.StylePriority.UseBorders = False
        Me.Descripcion.StylePriority.UseFont = False
        Me.Descripcion.Text = "XrLabel1"
        Me.Descripcion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cantidad
        '
        Me.Cantidad.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.Cantidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad")})
        Me.Cantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cantidad.SizeF = New System.Drawing.SizeF(94.20838!, 20.0!)
        Me.Cantidad.StylePriority.UseBorders = False
        Me.Cantidad.StylePriority.UseFont = False
        Me.Cantidad.Text = "XrLabel1"
        Me.Cantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Precio
        '
        Me.Precio.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.Precio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unitario", "{0:n2}")})
        Me.Precio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.LocationFloat = New DevExpress.Utils.PointFloat(202.8751!, 0!)
        Me.Precio.Name = "Precio"
        Me.Precio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Precio.SizeF = New System.Drawing.SizeF(105.5416!, 20.0!)
        Me.Precio.StylePriority.UseBorders = False
        Me.Precio.StylePriority.UseFont = False
        Me.Precio.Text = "XrLabel1"
        Me.Precio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Valor
        '
        Me.Valor.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.Valor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n2}")})
        Me.Valor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor.LocationFloat = New DevExpress.Utils.PointFloat(662.1251!, 0!)
        Me.Valor.Name = "Valor"
        Me.Valor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Valor.SizeF = New System.Drawing.SizeF(127.8749!, 20.0!)
        Me.Valor.StylePriority.UseBorders = False
        Me.Valor.StylePriority.UseFont = False
        Me.Valor.Text = "XrLabel1"
        Me.Valor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Unidad
        '
        Me.Unidad.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.Unidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unidad")})
        Me.Unidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad.LocationFloat = New DevExpress.Utils.PointFloat(94.20838!, 0!)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Unidad.SizeF = New System.Drawing.SizeF(108.6667!, 20.0!)
        Me.Unidad.StylePriority.UseBorders = False
        Me.Unidad.StylePriority.UseFont = False
        Me.Unidad.Text = "Unidad"
        Me.Unidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 30.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel14, Me.Vencimiento, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel4, Me.XrLabel3, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel1, Me.Empresa, Me.Factura, Me.Cheque, Me.FormaPago})
        Me.ReportHeader.HeightF = 192.375!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(189.5833!, 167.375!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(353.7051!, 25.0!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "A la par de la Industria, Desarrollando Centroamérica"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(681.7534!, 142.375!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(98.2467!, 25.0!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Vencimiento"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Vencimiento
        '
        Me.Vencimiento.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.Vencimiento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento", "{0:MM/dd/yyyy}")})
        Me.Vencimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vencimiento.LocationFloat = New DevExpress.Utils.PointFloat(681.7534!, 167.375!)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vencimiento.SizeF = New System.Drawing.SizeF(98.24664!, 25.0!)
        Me.Vencimiento.StylePriority.UseBorders = False
        Me.Vencimiento.StylePriority.UseFont = False
        Me.Vencimiento.Text = "Vencimiento"
        Me.Vencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(565.6284!, 142.375!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(116.1249!, 25.0!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Condiciones"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:MM/dd/yyyy}")})
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(563.8751!, 110.4166!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(216.1249!, 26.04165!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel1"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(563.8751!, 85.41663!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(216.125!, 25.0!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Día" & Global.Microsoft.VisualBasic.ChrW(9) & "Mes" & Global.Microsoft.VisualBasic.ChrW(9) & "Año"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(543.0417!, 12.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(119.08!, 30.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "No. Documento"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 97.50001!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(263.875!, 69.87501!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Teléfono" & Global.Microsoft.VisualBasic.ChrW(9) & "   4032-2600" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fax" & Global.Microsoft.VisualBasic.ChrW(9) & "   2297-5181" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-mail" & Global.Microsoft.VisualBasic.ChrW(9) & "   william.porras@equipsa.net" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si" &
    "tio Web" & Global.Microsoft.VisualBasic.ChrW(9) & "   www.equipsa.net"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(361.375!, 48.54167!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(167.7083!, 74.04166!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(282.2083!, 48.54167!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(79.16666!, 74.04166!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 35.00001!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(242.0!, 62.5!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Céd. Jur: 3-101-338020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colimas Tibás San José Costa Rica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Parque Industrial Cond" &
    "al Oficina 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(293.0417!, 25.0!)
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.Text = "Empresa"
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Factura
        '
        Me.Factura.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Factura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.Factura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(662.1252!, 12.0!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(117.8749!, 30.0!)
        Me.Factura.StylePriority.UseBorders = False
        Me.Factura.StylePriority.UseFont = False
        Me.Factura.Text = "XrLabel1"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cheque
        '
        Me.Cheque.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Cheque.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cheque", "{0:n2}")})
        Me.Cheque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cheque.LocationFloat = New DevExpress.Utils.PointFloat(565.6284!, 167.375!)
        Me.Cheque.Name = "Cheque"
        Me.Cheque.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cheque.SizeF = New System.Drawing.SizeF(116.125!, 25.0!)
        Me.Cheque.StylePriority.UseBorders = False
        Me.Cheque.StylePriority.UseFont = False
        Me.Cheque.Text = "XrLabel1"
        Me.Cheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'FormaPago
        '
        Me.FormaPago.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FormaPago")})
        Me.FormaPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPago.LocationFloat = New DevExpress.Utils.PointFloat(543.0417!, 48.54167!)
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FormaPago.SizeF = New System.Drawing.SizeF(236.9583!, 26.0!)
        Me.FormaPago.StylePriority.UseFont = False
        Me.FormaPago.Text = "Remision"
        Me.FormaPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tienda
        '
        Me.Tienda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tienda")})
        Me.Tienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tienda.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 0!)
        Me.Tienda.Name = "Tienda"
        Me.Tienda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tienda.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Tienda.StylePriority.UseFont = False
        Me.Tienda.Text = "XrLabel1"
        Me.Tienda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Fecha
        '
        Me.Fecha.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:MM/dd/yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(696.25!, 25.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(93.75!, 49.99998!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "XrLabel1"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cliente
        '
        Me.Cliente.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Cliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.Cliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cliente.SizeF = New System.Drawing.SizeF(170.25!, 49.99998!)
        Me.Cliente.StylePriority.UseBorders = False
        Me.Cliente.StylePriority.UseFont = False
        Me.Cliente.StylePriority.UseTextAlignment = False
        Me.Cliente.Text = "XrLabel1"
        Me.Cliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Vendedor
        '
        Me.Vendedor.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Vendedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vendedor")})
        Me.Vendedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor.LocationFloat = New DevExpress.Utils.PointFloat(602.1667!, 25.0!)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vendedor.SizeF = New System.Drawing.SizeF(94.08331!, 49.99998!)
        Me.Vendedor.StylePriority.UseBorders = False
        Me.Vendedor.StylePriority.UseFont = False
        Me.Vendedor.StylePriority.UseTextAlignment = False
        Me.Vendedor.Text = "Remision"
        Me.Vendedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TipoCambio
        '
        Me.TipoCambio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TipoCambio", "{0:n4}")})
        Me.TipoCambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoCambio.LocationFloat = New DevExpress.Utils.PointFloat(277.0!, 25.0!)
        Me.TipoCambio.Name = "TipoCambio"
        Me.TipoCambio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TipoCambio.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.TipoCambio.StylePriority.UseFont = False
        Me.TipoCambio.Text = "TipoCambio"
        Me.TipoCambio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalDolar
        '
        Me.TotalDolar.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalDolar", "{0:n2}")})
        Me.TotalDolar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDolar.LocationFloat = New DevExpress.Utils.PointFloat(652.0001!, 25.0!)
        Me.TotalDolar.Name = "TotalDolar"
        Me.TotalDolar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalDolar.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.TotalDolar.StylePriority.UseFont = False
        Me.TotalDolar.Text = "TipoCambio"
        Me.TotalDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Direccion
        '
        Me.Direccion.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Direccion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Direccion")})
        Me.Direccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.LocationFloat = New DevExpress.Utils.PointFloat(170.2501!, 25.0!)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Direccion.SizeF = New System.Drawing.SizeF(242.0!, 49.99998!)
        Me.Direccion.StylePriority.UseBorders = False
        Me.Direccion.StylePriority.UseFont = False
        Me.Direccion.StylePriority.UseTextAlignment = False
        Me.Direccion.Text = "Direccion"
        Me.Direccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Telefono
        '
        Me.Telefono.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Telefono.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Telefono")})
        Me.Telefono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.LocationFloat = New DevExpress.Utils.PointFloat(412.2501!, 25.0!)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Telefono.SizeF = New System.Drawing.SizeF(90.95828!, 49.99998!)
        Me.Telefono.StylePriority.UseBorders = False
        Me.Telefono.StylePriority.UseFont = False
        Me.Telefono.StylePriority.UseTextAlignment = False
        Me.Telefono.Text = "XrLabel1"
        Me.Telefono.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Despacho")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(458.4167!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Cultivo"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'EnLetras
        '
        Me.EnLetras.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EnLetras")})
        Me.EnLetras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnLetras.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 25.0!)
        Me.EnLetras.Name = "EnLetras"
        Me.EnLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.EnLetras.SizeF = New System.Drawing.SizeF(267.0!, 25.0!)
        Me.EnLetras.StylePriority.UseFont = False
        Me.EnLetras.Text = "Remision"
        Me.EnLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Credito
        '
        Me.Credito.BorderWidth = 0!
        Me.Credito.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Credito")})
        Me.Credito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credito.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 25.0!)
        Me.Credito.Name = "Credito"
        Me.Credito.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Credito.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Credito.StylePriority.UseFont = False
        '
        'Contado
        '
        Me.Contado.BorderWidth = 0!
        Me.Contado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Contado")})
        Me.Contado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contado.LocationFloat = New DevExpress.Utils.PointFloat(552.0!, 25.0!)
        Me.Contado.Name = "Contado"
        Me.Contado.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Contado.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Contado.StylePriority.UseFont = False
        '
        'Tarjeta
        '
        Me.Tarjeta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tarjeta", "{0:n2}")})
        Me.Tarjeta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarjeta.LocationFloat = New DevExpress.Utils.PointFloat(558.4167!, 0!)
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tarjeta.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Tarjeta.StylePriority.UseFont = False
        Me.Tarjeta.Text = "XrLabel1"
        Me.Tarjeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Efectivo
        '
        Me.Efectivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Efectivo", "{0:n2}")})
        Me.Efectivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Efectivo.LocationFloat = New DevExpress.Utils.PointFloat(633.4167!, 0!)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Efectivo.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Efectivo.StylePriority.UseFont = False
        Me.Efectivo.Text = "XrLabel1"
        Me.Efectivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'CodigoLetra
        '
        Me.CodigoLetra.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CodigoLetra")})
        Me.CodigoLetra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoLetra.LocationFloat = New DevExpress.Utils.PointFloat(183.4167!, 0!)
        Me.CodigoLetra.Name = "CodigoLetra"
        Me.CodigoLetra.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CodigoLetra.SizeF = New System.Drawing.SizeF(125.0!, 25.0!)
        Me.CodigoLetra.StylePriority.UseFont = False
        Me.CodigoLetra.Text = "CodigoLetra"
        Me.CodigoLetra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Serie
        '
        Me.Serie.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Serie")})
        Me.Serie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serie.LocationFloat = New DevExpress.Utils.PointFloat(377.0!, 25.0!)
        Me.Serie.Name = "Serie"
        Me.Serie.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Serie.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Serie.StylePriority.UseFont = False
        Me.Serie.Text = "Serie"
        Me.Serie.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.Direccion, Me.Vendedor, Me.Cliente, Me.Fecha, Me.Orden, Me.XrLabel5, Me.Telefono, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10})
        Me.PageHeader.HeightF = 74.99998!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(170.25!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(242.0!, 25.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Señor (es) Dirección Cobro"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Orden
        '
        Me.Orden.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Orden.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orden")})
        Me.Orden.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Orden.LocationFloat = New DevExpress.Utils.PointFloat(503.2083!, 25.0!)
        Me.Orden.Name = "Orden"
        Me.Orden.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Orden.SizeF = New System.Drawing.SizeF(98.95834!, 49.99998!)
        Me.Orden.StylePriority.UseBorders = False
        Me.Orden.StylePriority.UseTextAlignment = False
        Me.Orden.Text = "Remision"
        Me.Orden.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(170.25!, 25.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Cliente"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(412.2501!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(90.95828!, 25.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Teléfono"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(503.2083!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(98.95834!, 25.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Orden Compra"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(602.1667!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(94.08331!, 25.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Agente"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(696.25!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(93.75!, 25.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Despacho"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19})
        Me.GroupHeader1.HeightF = 25.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(94.20838!, 25.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Cantidad"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(94.20838!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(108.6667!, 25.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "U/M"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(202.8751!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(105.5416!, 25.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Precio /U"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(308.4167!, 0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(353.7051!, 25.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Descripción"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(662.1252!, 0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(127.8748!, 25.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Monto"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel21})
        Me.GroupFooter1.HeightF = 65.29173!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(790.0!, 38.54167!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = resources.GetString("XrLabel21.Text")
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Item
        '
        Me.Item.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Codigo")})
        Me.Item.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Item.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0!)
        Me.Item.Name = "Item"
        Me.Item.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Item.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Item.Text = "Item"
        Me.Item.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Exento
        '
        Me.Exento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Exento", "{0:n2}")})
        Me.Exento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exento.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 0!)
        Me.Exento.Name = "Exento"
        Me.Exento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Exento.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Exento.StylePriority.UseFont = False
        Me.Exento.Text = "Exento"
        Me.Exento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Gravado
        '
        Me.Gravado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Gravado", "{0:n2}")})
        Me.Gravado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gravado.LocationFloat = New DevExpress.Utils.PointFloat(308.4167!, 0!)
        Me.Gravado.Name = "Gravado"
        Me.Gravado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Gravado.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Gravado.StylePriority.UseFont = False
        Me.Gravado.Text = "XrLabel1"
        Me.Gravado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Iva, Me.XrLabel62, Me.SubTotal, Me.GravadoSubTotal, Me.XrLabel63, Me.ExentoSubTotal, Me.ExentoIva, Me.ExentoTotal, Me.GravadoTotal, Me.XrLabel64, Me.Vuelto, Me.Cultivo, Me.XrLabel65, Me.Remision, Me.NoEntrega, Me.XrLabel66, Me.CodigoLetra, Me.Exento, Me.Item, Me.Tienda, Me.TipoCambio, Me.TotalDolar, Me.XrLabel2, Me.EnLetras, Me.Credito, Me.Contado, Me.Tarjeta, Me.Efectivo, Me.Serie, Me.Gravado})
        Me.GroupFooter2.HeightF = 100.0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.Visible = False
        '
        'Iva
        '
        Me.Iva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Iva", "{0:n2}")})
        Me.Iva.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Iva.LocationFloat = New DevExpress.Utils.PointFloat(606.7534!, 75.0!)
        Me.Iva.Name = "Iva"
        Me.Iva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Iva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Iva.Text = "XrLabel1"
        Me.Iva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel62
        '
        Me.XrLabel62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalFactura", "{0:n2}")})
        Me.XrLabel62.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(308.4167!, 75.0!)
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.XrLabel62.Text = "XrLabel1"
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SubTotal
        '
        Me.SubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SubTotal", "{0:n2}")})
        Me.SubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.SubTotal.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 50.00002!)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.SubTotal.Text = "XrLabel1"
        Me.SubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoSubTotal
        '
        Me.GravadoSubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoSubTotal", "{0:n2}")})
        Me.GravadoSubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GravadoSubTotal.LocationFloat = New DevExpress.Utils.PointFloat(602.1667!, 50.00002!)
        Me.GravadoSubTotal.Name = "GravadoSubTotal"
        Me.GravadoSubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoSubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.GravadoSubTotal.Text = "GravadoSubTotal"
        Me.GravadoSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel63
        '
        Me.XrLabel63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoIva", "{0:n2}")})
        Me.XrLabel63.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(677.1667!, 75.0!)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.XrLabel63.Text = "XrLabel1"
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoSubTotal
        '
        Me.ExentoSubTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoSubTotal", "{0:n2}")})
        Me.ExentoSubTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoSubTotal.LocationFloat = New DevExpress.Utils.PointFloat(527.1667!, 50.00002!)
        Me.ExentoSubTotal.Name = "ExentoSubTotal"
        Me.ExentoSubTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoSubTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoSubTotal.Text = "XrLabel1"
        Me.ExentoSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoIva
        '
        Me.ExentoIva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoIva", "{0:n2}")})
        Me.ExentoIva.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoIva.LocationFloat = New DevExpress.Utils.PointFloat(531.7534!, 75.0!)
        Me.ExentoIva.Name = "ExentoIva"
        Me.ExentoIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoIva.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoIva.Text = "XrLabel1"
        Me.ExentoIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ExentoTotal
        '
        Me.ExentoTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExentoTotal", "{0:n2}")})
        Me.ExentoTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ExentoTotal.LocationFloat = New DevExpress.Utils.PointFloat(454.0833!, 75.0!)
        Me.ExentoTotal.Name = "ExentoTotal"
        Me.ExentoTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ExentoTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.ExentoTotal.Text = "ExentoTotal"
        Me.ExentoTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoTotal
        '
        Me.GravadoTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoTotal", "{0:n2}")})
        Me.GravadoTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GravadoTotal.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 75.0!)
        Me.GravadoTotal.Name = "GravadoTotal"
        Me.GravadoTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoTotal.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.GravadoTotal.Text = "XrLabel1"
        Me.GravadoTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel64
        '
        Me.XrLabel64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descuento")})
        Me.XrLabel64.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(677.0001!, 50.00002!)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel64.Summary = XrSummary1
        Me.XrLabel64.Text = "XrLabel1"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Vuelto
        '
        Me.Vuelto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vuelto", "{0:n2}")})
        Me.Vuelto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Vuelto.LocationFloat = New DevExpress.Utils.PointFloat(233.4167!, 75.0!)
        Me.Vuelto.Name = "Vuelto"
        Me.Vuelto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Vuelto.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Vuelto.Text = "XrLabel1"
        Me.Vuelto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Cultivo
        '
        Me.Cultivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cultivo")})
        Me.Cultivo.LocationFloat = New DevExpress.Utils.PointFloat(110.0!, 50.00002!)
        Me.Cultivo.Name = "Cultivo"
        Me.Cultivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cultivo.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.Cultivo.StylePriority.UseTextAlignment = False
        Me.Cultivo.Text = "Cultivo"
        Me.Cultivo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orden")})
        Me.XrLabel65.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(210.0!, 50.00002!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.XrLabel65.Text = "Remision"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Remision
        '
        Me.Remision.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Remision")})
        Me.Remision.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Remision.LocationFloat = New DevExpress.Utils.PointFloat(377.0!, 50.00002!)
        Me.Remision.Name = "Remision"
        Me.Remision.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Remision.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Remision.Text = "Remision"
        Me.Remision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'NoEntrega
        '
        Me.NoEntrega.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NoEntrega")})
        Me.NoEntrega.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.NoEntrega.LocationFloat = New DevExpress.Utils.PointFloat(285.0!, 50.00002!)
        Me.NoEntrega.Name = "NoEntrega"
        Me.NoEntrega.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NoEntrega.SizeF = New System.Drawing.SizeF(92.0!, 25.0!)
        Me.NoEntrega.Text = "NoEntrega"
        Me.NoEntrega.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel66
        '
        Me.XrLabel66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Vencimiento", "{0:MM/dd/yyyy}")})
        Me.XrLabel66.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 50.00002!)
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.XrLabel66.Text = "Vencimiento"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel61, Me.XrLabel54, Me.XrLabel57, Me.XrLabel58, Me.XrLabel59, Me.XrLabel60, Me.XrLabel53, Me.XrLabel55, Me.XrLabel56, Me.XrLabel51, Me.XrLabel52, Me.XrLabel42, Me.XrLabel43, Me.XrLabel48, Me.XrLabel49, Me.XrLabel50, Me.XrLabel45, Me.XrLabel46, Me.XrLabel47, Me.XrLabel44, Me.XrLabel40, Me.XrLabel41, Me.XrLabel39, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.XrPictureBox3, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrLabel32, Me.XrLabel31, Me.XrLabel30, Me.TotalFactura, Me.GravadoIva, Me.XrLabel27, Me.XrLabel28, Me.XrLabel29, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel22, Me.XrLabel23, Me.XrBarCode1})
        Me.PageFooter.HeightF = 352.4166!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel61
        '
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel61.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(412.2501!, 222.9166!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(353.7051!, 20.0!)
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "NUMEROS DE CUENTAS BANCARIAS"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel54.BorderWidth = 1.0!
        Me.XrLabel54.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(594.1669!, 287.9166!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseBorderWidth = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "904-724788"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel57.BorderWidth = 1.0!
        Me.XrLabel57.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 332.9166!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseBorderWidth = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "11600104002211975"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel58.BorderWidth = 1.0!
        Me.XrLabel58.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 317.9166!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseBorderWidth = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "11600103002211978"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel59.BorderWidth = 1.0!
        Me.XrLabel59.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 287.9166!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseBorderWidth = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "10200009047247885"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel60
        '
        Me.XrLabel60.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel60.BorderWidth = 1.0!
        Me.XrLabel60.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 302.9166!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseBorderWidth = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "10200009248735800"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel53.BorderWidth = 1.0!
        Me.XrLabel53.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(594.1668!, 302.9166!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseBorderWidth = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "924873581"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.BorderWidth = 1.0!
        Me.XrLabel55.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(594.1668!, 317.9166!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseBorderWidth = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "3-221197"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.BorderWidth = 1.0!
        Me.XrLabel56.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(594.1668!, 332.9166!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseBorderWidth = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "4-221197"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel51
        '
        Me.XrLabel51.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel51.BorderWidth = 1.0!
        Me.XrLabel51.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 257.9166!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseBorderWidth = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "15201001026878101"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel52.BorderWidth = 1.0!
        Me.XrLabel52.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 272.9166!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(107.8331!, 15.0!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseBorderWidth = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "15201001028374986"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel42.BorderWidth = 1.0!
        Me.XrLabel42.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(594.1667!, 257.9166!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseBorderWidth = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "001-0268781-0"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.BorderWidth = 1.0!
        Me.XrLabel43.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(594.1667!, 272.9166!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseBorderWidth = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "001-0283749-8"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel48.BorderWidth = 1.0!
        Me.XrLabel48.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(523.1668!, 332.9166!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseBorderWidth = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "DOLARES ($)"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel49.BorderWidth = 1.0!
        Me.XrLabel49.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 317.9166!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(139.75!, 30.0!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseBorderWidth = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "BANPRO PROMERICA"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel50.BorderWidth = 1.0!
        Me.XrLabel50.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(523.1668!, 317.9166!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseBorderWidth = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "COLONES (C)"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel45.BorderWidth = 1.0!
        Me.XrLabel45.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(523.1667!, 287.9166!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseBorderWidth = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "COLONES (C)"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel46.BorderWidth = 1.0!
        Me.XrLabel46.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 287.9166!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(139.75!, 30.0!)
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseBorderWidth = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "BAC SAN JOSE"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel47.BorderWidth = 1.0!
        Me.XrLabel47.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(523.1667!, 302.9166!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseBorderWidth = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "DOLARES ($)"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel44.BorderWidth = 1.0!
        Me.XrLabel44.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(523.1668!, 272.9166!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseBorderWidth = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "DOLARES ($)"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel40.BorderWidth = 1.0!
        Me.XrLabel40.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 257.9166!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(139.75!, 30.0!)
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseBorderWidth = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "BANCO DE COSTA RICA (BCR)"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel41
        '
        Me.XrLabel41.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel41.BorderWidth = 1.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(523.1668!, 257.9166!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseBorderWidth = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "COLONES (C)"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Silver
        Me.XrLabel39.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel39.BorderWidth = 1.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(682.1667!, 242.9166!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(107.8332!, 14.99998!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseBorderWidth = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "CUENTA CORRIENTE"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel38
        '
        Me.XrLabel38.BackColor = System.Drawing.Color.Silver
        Me.XrLabel38.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel38.BorderWidth = 1.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(594.1667!, 242.9166!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(88.0!, 15.0!)
        Me.XrLabel38.StylePriority.UseBackColor = False
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseBorderWidth = False
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "NO. DE CUENTA"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.BackColor = System.Drawing.Color.Silver
        Me.XrLabel37.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel37.BorderWidth = 1.0!
        Me.XrLabel37.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(523.1667!, 242.9166!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(71.0!, 15.0!)
        Me.XrLabel37.StylePriority.UseBackColor = False
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseBorderWidth = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "MONEDA"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.Silver
        Me.XrLabel36.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel36.BorderWidth = 1.0!
        Me.XrLabel36.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(383.4167!, 242.9166!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(139.75!, 15.0!)
        Me.XrLabel36.StylePriority.UseBackColor = False
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseBorderWidth = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "BANCO"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 235.0!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(321.0001!, 22.9166!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel35
        '
        Me.XrLabel35.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel35.BorderWidth = 1.0!
        Me.XrLabel35.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(412.25!, 150.2083!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(377.7499!, 46.87502!)
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseBorderWidth = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "   Recibido Conforme y Fecha,         Número de Cédula"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel34.BorderWidth = 1.0!
        Me.XrLabel34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(412.25!, 197.0833!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(377.7498!, 25.83333!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseBorderWidth = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "Original (Sello), Copia (Recibido) Copia (Contabilidad)"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.BorderWidth = 1.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 150.2083!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(402.2501!, 72.70834!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseBorderWidth = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Exento. Dispensado Timbraje Gaceta 171 05 Sep 1997" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Autorizado según resolución 1" &
    "197, rige a partir del 1° de Octubre de 1997 y publicado en la Gaceta 171 del 05" &
    " de Sep de 1997. DGTD"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.BorderWidth = 1.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 78.33328!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(424.1251!, 59.16667!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseBorderWidth = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Esta factura devengará intereses del 4.5% mensual. El Pago de intereses no implic" &
    "a prórroga del plaza de pago."
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(150.955!, 9.999974!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(301.045!, 68.33331!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Renuncio a mi domicilio y a los trámites de jucio ejecutivo, al mismo tiempo doy " &
    "por aceptada las condiciones del Código de Comercio según articulo 480."
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n2}")})
        Me.XrLabel30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(673.2116!, 9.999974!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(116.7883!, 30.0!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.Text = "XrLabel1"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TotalFactura
        '
        Me.TotalFactura.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TotalFactura.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalFactura", "{0:n2}")})
        Me.TotalFactura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalFactura.LocationFloat = New DevExpress.Utils.PointFloat(673.2116!, 99.99997!)
        Me.TotalFactura.Name = "TotalFactura"
        Me.TotalFactura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TotalFactura.SizeF = New System.Drawing.SizeF(116.7883!, 30.0!)
        Me.TotalFactura.StylePriority.UseBorders = False
        Me.TotalFactura.StylePriority.UseFont = False
        Me.TotalFactura.Text = "XrLabel1"
        Me.TotalFactura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GravadoIva
        '
        Me.GravadoIva.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.GravadoIva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GravadoIva", "{0:n2}")})
        Me.GravadoIva.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GravadoIva.LocationFloat = New DevExpress.Utils.PointFloat(673.2116!, 48.3333!)
        Me.GravadoIva.Name = "GravadoIva"
        Me.GravadoIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.GravadoIva.SizeF = New System.Drawing.SizeF(116.7883!, 30.0!)
        Me.GravadoIva.StylePriority.UseBorders = False
        Me.GravadoIva.StylePriority.UseFont = False
        Me.GravadoIva.Text = "XrLabel1"
        Me.GravadoIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel27.BorderWidth = 1.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(628.2116!, 9.999974!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(45.0!, 30.0!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "CRC"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel28.BorderWidth = 1.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(628.2116!, 48.3333!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(45.0!, 30.0!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "CRC"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel29.BorderWidth = 1.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(628.2115!, 99.99997!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(45.0!, 30.0!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "CRC"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel26
        '
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel26.BorderWidth = 1.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(452.0001!, 99.99998!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(158.3365!, 30.0!)
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Total"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.BorderWidth = 1.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 48.33329!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(158.3364!, 30.0!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Impuesto de Venta..."
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.BorderWidth = 1.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 9.999974!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(158.3365!, 30.0!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseBorderWidth = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Sub Total"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.BorderWidth = 1.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 9.999974!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(140.955!, 30.0!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "No. Documento"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Factura")})
        Me.XrLabel23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 39.99996!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(140.955!, 38.33334!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "XrLabel1"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CodigoQR")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 275.7083!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(121.0001!, 72.20834!)
        QrCodeGenerator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.H
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        '
        'rptFormatoFactura
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter2, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Factura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tienda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vendedor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TipoCambio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalDolar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Direccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Telefono As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EnLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Credito As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents Contado As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents Tarjeta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Efectivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cheque As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormaPago As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CodigoLetra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Serie As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Orden As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vencimiento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents Descripcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cantidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Precio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Valor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Unidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Item As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Exento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Gravado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoIva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalFactura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Iva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoSubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoSubTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoIva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ExentoTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GravadoTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Vuelto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cultivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Remision As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NoEntrega As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
End Class
