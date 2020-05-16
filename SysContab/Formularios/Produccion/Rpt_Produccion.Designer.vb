<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Rpt_Produccion
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.Costo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Unidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Presentacion = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cantidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.Numero = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.NombreFormula = New DevExpress.XtraReports.UI.XRLabel()
        Me.UnidadFormula = New DevExpress.XtraReports.UI.XRLabel()
        Me.PresentacionFormula = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FechaFinalizacion = New DevExpress.XtraReports.UI.XRLabel()
        Me.FechaProduccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Observaciones = New DevExpress.XtraReports.UI.XRLabel()
        Me.NoDocumento = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Estado = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.CostoUnitario = New DevExpress.XtraReports.UI.XRLabel()
        Me.CostoProduccion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CantidadProducir = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Total, Me.Costo, Me.Nombre, Me.Unidad, Me.Presentacion, Me.Cantidad})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Total
        '
        Me.Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0:n4}")})
        Me.Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.Black
        Me.Total.LocationFloat = New DevExpress.Utils.PointFloat(696.8237!, 0!)
        Me.Total.Name = "Total"
        Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total.SizeF = New System.Drawing.SizeF(99.64606!, 20.0!)
        Me.Total.StylePriority.UseFont = False
        Me.Total.StylePriority.UseForeColor = False
        Me.Total.StylePriority.UseTextAlignment = False
        Me.Total.Text = "Cantidad"
        Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Costo
        '
        Me.Costo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Costo", "{0:n4}")})
        Me.Costo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costo.ForeColor = System.Drawing.Color.Black
        Me.Costo.LocationFloat = New DevExpress.Utils.PointFloat(603.3984!, 0!)
        Me.Costo.Name = "Costo"
        Me.Costo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Costo.SizeF = New System.Drawing.SizeF(93.17621!, 20.0!)
        Me.Costo.StylePriority.UseFont = False
        Me.Costo.StylePriority.UseForeColor = False
        Me.Costo.StylePriority.UseTextAlignment = False
        Me.Costo.Text = "Cantidad"
        Me.Costo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.Black
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(291.8697!, 20.0!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseForeColor = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "Nombre"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Unidad
        '
        Me.Unidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Unidad")})
        Me.Unidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad.ForeColor = System.Drawing.Color.Black
        Me.Unidad.LocationFloat = New DevExpress.Utils.PointFloat(291.8697!, 0!)
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Unidad.SizeF = New System.Drawing.SizeF(99.17621!, 20.0!)
        Me.Unidad.StylePriority.UseFont = False
        Me.Unidad.StylePriority.UseForeColor = False
        Me.Unidad.StylePriority.UseTextAlignment = False
        Me.Unidad.Text = "Unidad"
        Me.Unidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Presentacion
        '
        Me.Presentacion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Presentacion")})
        Me.Presentacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Presentacion.ForeColor = System.Drawing.Color.Black
        Me.Presentacion.LocationFloat = New DevExpress.Utils.PointFloat(391.0459!, 0!)
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Presentacion.SizeF = New System.Drawing.SizeF(128.829!, 20.0!)
        Me.Presentacion.StylePriority.UseFont = False
        Me.Presentacion.StylePriority.UseForeColor = False
        Me.Presentacion.StylePriority.UseTextAlignment = False
        Me.Presentacion.Text = "Presentacion"
        Me.Presentacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cantidad
        '
        Me.Cantidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad", "{0:n4}")})
        Me.Cantidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.Color.Black
        Me.Cantidad.LocationFloat = New DevExpress.Utils.PointFloat(519.875!, 0!)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cantidad.SizeF = New System.Drawing.SizeF(83.52338!, 20.0!)
        Me.Cantidad.StylePriority.UseFont = False
        Me.Cantidad.StylePriority.UseForeColor = False
        Me.Cantidad.StylePriority.UseTextAlignment = False
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Numero
        '
        Me.Numero.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.Numero.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Numero")})
        Me.Numero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.ForeColor = System.Drawing.Color.Black
        Me.Numero.LocationFloat = New DevExpress.Utils.PointFloat(670.7859!, 0!)
        Me.Numero.Name = "Numero"
        Me.Numero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Numero.SizeF = New System.Drawing.SizeF(125.6838!, 22.0!)
        Me.Numero.StylePriority.UseBorders = False
        Me.Numero.StylePriority.UseFont = False
        Me.Numero.StylePriority.UseForeColor = False
        Me.Numero.StylePriority.UseTextAlignment = False
        Me.Numero.Text = "Numero"
        Me.Numero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FechaProduccion", "{0:dd/MM/yyyy}")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Black
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(670.7859!, 21.99999!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(125.6877!, 22.0!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseForeColor = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'NombreFormula
        '
        Me.NombreFormula.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NombreFormula")})
        Me.NombreFormula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreFormula.ForeColor = System.Drawing.Color.Black
        Me.NombreFormula.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.99999!)
        Me.NombreFormula.Name = "NombreFormula"
        Me.NombreFormula.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NombreFormula.SizeF = New System.Drawing.SizeF(291.8697!, 20.0!)
        Me.NombreFormula.StylePriority.UseFont = False
        Me.NombreFormula.StylePriority.UseForeColor = False
        Me.NombreFormula.StylePriority.UseTextAlignment = False
        Me.NombreFormula.Text = "NombreFormula"
        Me.NombreFormula.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'UnidadFormula
        '
        Me.UnidadFormula.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnidadFormula")})
        Me.UnidadFormula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadFormula.ForeColor = System.Drawing.Color.Black
        Me.UnidadFormula.LocationFloat = New DevExpress.Utils.PointFloat(291.8697!, 22.99999!)
        Me.UnidadFormula.Name = "UnidadFormula"
        Me.UnidadFormula.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.UnidadFormula.SizeF = New System.Drawing.SizeF(99.17621!, 20.0!)
        Me.UnidadFormula.StylePriority.UseFont = False
        Me.UnidadFormula.StylePriority.UseForeColor = False
        Me.UnidadFormula.StylePriority.UseTextAlignment = False
        Me.UnidadFormula.Text = "UnidadFormula"
        Me.UnidadFormula.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PresentacionFormula
        '
        Me.PresentacionFormula.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PresentacionFormula")})
        Me.PresentacionFormula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresentacionFormula.ForeColor = System.Drawing.Color.Black
        Me.PresentacionFormula.LocationFloat = New DevExpress.Utils.PointFloat(391.0459!, 22.99999!)
        Me.PresentacionFormula.Name = "PresentacionFormula"
        Me.PresentacionFormula.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PresentacionFormula.SizeF = New System.Drawing.SizeF(128.829!, 20.0!)
        Me.PresentacionFormula.StylePriority.UseFont = False
        Me.PresentacionFormula.StylePriority.UseForeColor = False
        Me.PresentacionFormula.StylePriority.UseTextAlignment = False
        Me.PresentacionFormula.Text = "PresentacionFormula"
        Me.PresentacionFormula.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel18, Me.FechaFinalizacion, Me.FechaProduccion, Me.XrLabel17, Me.XrLabel16, Me.Observaciones, Me.NoDocumento, Me.XrLabel11, Me.XrLabel10, Me.XrLabel1, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel12, Me.XrLabel3, Me.Numero, Me.Fecha, Me.Estado})
        Me.PageHeaderBand1.HeightF = 147.6667!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.ForeColor = System.Drawing.Color.Black
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(478.937!, 21.99999!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(191.849!, 22.0!)
        Me.XrLabel19.StyleName = "FieldCaption"
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Fecha Orden Producción:"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.ForeColor = System.Drawing.Color.Black
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 75.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(139.0986!, 22.0!)
        Me.XrLabel18.StyleName = "FieldCaption"
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Observaciones:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FechaFinalizacion
        '
        Me.FechaFinalizacion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FechaFinalizaProduccion", "{0:dd/MM/yyyy}")})
        Me.FechaFinalizacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaFinalizacion.ForeColor = System.Drawing.Color.Black
        Me.FechaFinalizacion.LocationFloat = New DevExpress.Utils.PointFloat(139.0986!, 22.00001!)
        Me.FechaFinalizacion.Name = "FechaFinalizacion"
        Me.FechaFinalizacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FechaFinalizacion.SizeF = New System.Drawing.SizeF(152.771!, 22.0!)
        Me.FechaFinalizacion.StylePriority.UseFont = False
        Me.FechaFinalizacion.StylePriority.UseForeColor = False
        Me.FechaFinalizacion.StylePriority.UseTextAlignment = False
        Me.FechaFinalizacion.Text = "Fecha"
        Me.FechaFinalizacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FechaProduccion
        '
        Me.FechaProduccion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FechaGeneraProduccion", "{0:dd/MM/yyyy}")})
        Me.FechaProduccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaProduccion.ForeColor = System.Drawing.Color.Black
        Me.FechaProduccion.LocationFloat = New DevExpress.Utils.PointFloat(139.0986!, 0!)
        Me.FechaProduccion.Name = "FechaProduccion"
        Me.FechaProduccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FechaProduccion.SizeF = New System.Drawing.SizeF(152.771!, 22.0!)
        Me.FechaProduccion.StylePriority.UseFont = False
        Me.FechaProduccion.StylePriority.UseForeColor = False
        Me.FechaProduccion.StylePriority.UseTextAlignment = False
        Me.FechaProduccion.Text = "Fecha"
        Me.FechaProduccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.ForeColor = System.Drawing.Color.Black
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(139.0986!, 22.0!)
        Me.XrLabel17.StyleName = "FieldCaption"
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Fecha Finalización:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(139.0986!, 22.0!)
        Me.XrLabel16.StyleName = "FieldCaption"
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Fecha de Producción:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Observaciones
        '
        Me.Observaciones.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Observaciones")})
        Me.Observaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.ForeColor = System.Drawing.Color.Black
        Me.Observaciones.LocationFloat = New DevExpress.Utils.PointFloat(139.0986!, 75.0!)
        Me.Observaciones.Multiline = True
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Observaciones.SizeF = New System.Drawing.SizeF(657.3712!, 22.0!)
        Me.Observaciones.StyleName = "FieldCaption"
        Me.Observaciones.StylePriority.UseFont = False
        Me.Observaciones.StylePriority.UseForeColor = False
        Me.Observaciones.StylePriority.UseTextAlignment = False
        Me.Observaciones.Text = "No. Documento:"
        Me.Observaciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'NoDocumento
        '
        Me.NoDocumento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NoDocumento")})
        Me.NoDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoDocumento.ForeColor = System.Drawing.Color.Black
        Me.NoDocumento.LocationFloat = New DevExpress.Utils.PointFloat(139.0986!, 44.0!)
        Me.NoDocumento.Name = "NoDocumento"
        Me.NoDocumento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NoDocumento.SizeF = New System.Drawing.SizeF(337.0262!, 22.00001!)
        Me.NoDocumento.StyleName = "FieldCaption"
        Me.NoDocumento.StylePriority.UseFont = False
        Me.NoDocumento.StylePriority.UseForeColor = False
        Me.NoDocumento.StylePriority.UseTextAlignment = False
        Me.NoDocumento.Text = "No. Documento:"
        Me.NoDocumento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.ForeColor = System.Drawing.Color.Black
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 44.00002!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(139.0986!, 22.0!)
        Me.XrLabel11.StyleName = "FieldCaption"
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "No. Documento:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.ForeColor = System.Drawing.Color.Black
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(696.8238!, 117.8751!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(103.1763!, 25.00001!)
        Me.XrLabel10.StyleName = "FieldCaption"
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Total"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(603.3984!, 117.8751!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(93.17619!, 25.0!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Costo"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 117.8751!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(291.8697!, 25.0!)
        Me.XrLabel5.StyleName = "FieldCaption"
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Nombre del Producto"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(291.8697!, 117.8751!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(99.17624!, 24.99999!)
        Me.XrLabel6.StyleName = "FieldCaption"
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "U/M"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(391.0459!, 117.8751!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(128.829!, 24.99999!)
        Me.XrLabel7.StyleName = "FieldCaption"
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Presentación"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(519.8749!, 117.8751!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(83.5235!, 25.0!)
        Me.XrLabel12.StyleName = "FieldCaption"
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Cantidad"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(478.9369!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(191.849!, 22.0!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "No. Producción:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Estado
        '
        Me.Estado.BackColor = System.Drawing.Color.White
        Me.Estado.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Estado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Estado")})
        Me.Estado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.ForeColor = System.Drawing.Color.Black
        Me.Estado.LocationFloat = New DevExpress.Utils.PointFloat(478.9369!, 43.99999!)
        Me.Estado.Name = "Estado"
        Me.Estado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Estado.SizeF = New System.Drawing.SizeF(317.5367!, 22.0!)
        Me.Estado.StyleName = "Title"
        Me.Estado.StylePriority.UseBackColor = False
        Me.Estado.StylePriority.UseBorders = False
        Me.Estado.StylePriority.UseFont = False
        Me.Estado.StylePriority.UseForeColor = False
        Me.Estado.StylePriority.UseTextAlignment = False
        Me.Estado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(79.16666!, 126.3333!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(212.703!, 22.0!)
        Me.XrLabel13.StyleName = "FieldCaption"
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Elaborado por"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.CostoUnitario, Me.CostoProduccion, Me.XrLabel9, Me.XrLabel8, Me.NombreFormula, Me.UnidadFormula, Me.PresentacionFormula, Me.CantidadProducir})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CODIGO_ARTICULOM", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 71.41667!
        Me.GroupHeaderBand1.Level = 1
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.StyleName = "DataField"
        '
        'CostoUnitario
        '
        Me.CostoUnitario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CostoUnitario", "{0:n6}")})
        Me.CostoUnitario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoUnitario.ForeColor = System.Drawing.Color.Black
        Me.CostoUnitario.LocationFloat = New DevExpress.Utils.PointFloat(603.3984!, 22.99999!)
        Me.CostoUnitario.Name = "CostoUnitario"
        Me.CostoUnitario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CostoUnitario.SizeF = New System.Drawing.SizeF(93.42542!, 20.0!)
        Me.CostoUnitario.StylePriority.UseFont = False
        Me.CostoUnitario.StylePriority.UseForeColor = False
        Me.CostoUnitario.StylePriority.UseTextAlignment = False
        Me.CostoUnitario.Text = "XrLabel25"
        Me.CostoUnitario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CostoProduccion
        '
        Me.CostoProduccion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CostoProduccion", "{0:n2}")})
        Me.CostoProduccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostoProduccion.ForeColor = System.Drawing.Color.Black
        Me.CostoProduccion.LocationFloat = New DevExpress.Utils.PointFloat(696.8238!, 22.99999!)
        Me.CostoProduccion.Name = "CostoProduccion"
        Me.CostoProduccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CostoProduccion.SizeF = New System.Drawing.SizeF(103.1763!, 20.0!)
        Me.CostoProduccion.StylePriority.UseFont = False
        Me.CostoProduccion.StylePriority.UseForeColor = False
        Me.CostoProduccion.StylePriority.UseTextAlignment = False
        Me.CostoProduccion.Text = "XrLabel25"
        Me.CostoProduccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 54.16667!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(151.4081!, 17.25!)
        Me.XrLabel9.StyleName = "FieldCaption"
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.Text = "Detalle de la Formula"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(158.6998!, 17.25!)
        Me.XrLabel8.StyleName = "FieldCaption"
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.Text = "Formula a Elaborar"
        '
        'CantidadProducir
        '
        Me.CantidadProducir.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CantidadProducir", "{0:n2}")})
        Me.CantidadProducir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadProducir.ForeColor = System.Drawing.Color.Black
        Me.CantidadProducir.LocationFloat = New DevExpress.Utils.PointFloat(519.8749!, 22.99999!)
        Me.CantidadProducir.Name = "CantidadProducir"
        Me.CantidadProducir.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CantidadProducir.SizeF = New System.Drawing.SizeF(83.5235!, 20.0!)
        Me.CantidadProducir.StylePriority.UseFont = False
        Me.CantidadProducir.StylePriority.UseForeColor = False
        Me.CantidadProducir.StylePriority.UseTextAlignment = False
        Me.CantidadProducir.Text = "XrLabel25"
        Me.CantidadProducir.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.Black
        Me.XrPageInfo1.Format = "{0:dddd, d' de 'MMMM' de 'yyyy hh:mm tt}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(345.5009!, 20.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.ForeColor = System.Drawing.Color.Black
        Me.XrPageInfo2.Format = "Pagina {0} de {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(642.0207!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(157.9793!, 20.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseForeColor = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Empresa, Me.XrLabel27})
        Me.ReportHeaderBand1.HeightF = 70.4167!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'Empresa
        '
        Me.Empresa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Empresa")})
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.ForeColor = System.Drawing.Color.Black
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(796.4698!, 30.0!)
        Me.Empresa.StyleName = "Title"
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseForeColor = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.ForeColor = System.Drawing.Color.Black
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(0!, 30.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(796.4698!, 27.0!)
        Me.XrLabel27.StyleName = "Title"
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Orden de Producción"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel14, Me.XrLabel2, Me.XrLabel15, Me.XrLabel13})
        Me.GroupFooter1.HeightF = 158.3333!
        Me.GroupFooter1.Level = 1
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(478.9369!, 126.3333!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(217.6377!, 22.0!)
        Me.XrLabel14.StyleName = "FieldCaption"
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Autorizado por"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999974!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(631.0416!, 25.0!)
        Me.XrLabel15.StyleName = "FieldCaption"
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "TOTAL COSTO DE PRODUCCIÓN"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.GroupFooter2.HeightF = 23.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(800.0001!, 23.0!)
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CostoProduccion", "{0:n2}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(631.0416!, 9.999974!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(165.4281!, 25.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel25"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(316.4584!, 123.3333!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(141.47!, 25.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel2.Summary = XrSummary1
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Rpt_Produccion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.GroupHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GroupFooter1, Me.GroupFooter2})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "15.2"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Numero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreFormula As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents UnidadFormula As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PresentacionFormula As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Unidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Presentacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cantidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents CantidadProducir As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Estado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NoDocumento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Observaciones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CostoProduccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Costo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FechaFinalizacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FechaProduccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CostoUnitario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
