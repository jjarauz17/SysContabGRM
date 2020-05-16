<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProyecto))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Bodega = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fin = New DevExpress.XtraReports.UI.XRLabel()
        Me.Inicio = New DevExpress.XtraReports.UI.XRLabel()
        Me.Duracion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Proyecto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Numero = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Empresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.Etapa = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1})
        Me.BottomMargin.HeightF = 44.79167!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pageInfo1
        '
        Me.pageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pageInfo1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageInfo1.Format = "Pagina {0} / {1}"
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(699.3667!, 16.04169!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(100.6333!, 18.75!)
        Me.pageInfo1.StylePriority.UseBorders = False
        Me.pageInfo1.StylePriority.UseFont = False
        Me.pageInfo1.StylePriority.UseTextAlignment = False
        Me.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Descripcion, Me.XrLabel15, Me.Bodega, Me.XrLabel13, Me.Fin, Me.Inicio, Me.Duracion, Me.XrLabel7, Me.XrLabel6, Me.XrLabel3, Me.XrLabel2, Me.Proyecto, Me.XrLabel5, Me.Cliente, Me.XrLabel12, Me.XrLabel4, Me.Numero, Me.XrLabel11, Me.XrPictureBox2, Me.Empresa, Me.XrLabel1})
        Me.PageHeader.HeightF = 542.5833!
        Me.PageHeader.Name = "PageHeader"
        '
        'Descripcion
        '
        Me.Descripcion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion", "{0}")})
        Me.Descripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.LocationFloat = New DevExpress.Utils.PointFloat(147.9199!, 409.375!)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.SizeF = New System.Drawing.SizeF(651.3668!, 91.95834!)
        Me.Descripcion.StylePriority.UseBorders = False
        Me.Descripcion.StylePriority.UseFont = False
        Me.Descripcion.StylePriority.UseTextAlignment = False
        Me.Descripcion.Text = "XrLabel1"
        Me.Descripcion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 409.375!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(147.92!, 25.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Descripción:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Bodega
        '
        Me.Bodega.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Bodega.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Bodega", "{0}")})
        Me.Bodega.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bodega.LocationFloat = New DevExpress.Utils.PointFloat(147.9199!, 373.9583!)
        Me.Bodega.Name = "Bodega"
        Me.Bodega.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Bodega.SizeF = New System.Drawing.SizeF(306.79!, 25.0!)
        Me.Bodega.StylePriority.UseBorders = False
        Me.Bodega.StylePriority.UseFont = False
        Me.Bodega.StylePriority.UseTextAlignment = False
        Me.Bodega.Text = "XrLabel1"
        Me.Bodega.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 373.9583!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(147.92!, 25.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Bodega:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fin
        '
        Me.Fin.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Fin.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fin", "{0:dddd, d' de 'MMMM' de 'yyyy}")})
        Me.Fin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fin.LocationFloat = New DevExpress.Utils.PointFloat(147.92!, 323.9583!)
        Me.Fin.Name = "Fin"
        Me.Fin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fin.SizeF = New System.Drawing.SizeF(306.79!, 25.0!)
        Me.Fin.StylePriority.UseBorders = False
        Me.Fin.StylePriority.UseFont = False
        Me.Fin.StylePriority.UseTextAlignment = False
        Me.Fin.Text = "XrLabel1"
        Me.Fin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Inicio
        '
        Me.Inicio.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Inicio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Inicio", "{0:dddd, d' de 'MMMM' de 'yyyy}")})
        Me.Inicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.LocationFloat = New DevExpress.Utils.PointFloat(147.92!, 298.9583!)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Inicio.SizeF = New System.Drawing.SizeF(306.79!, 25.0!)
        Me.Inicio.StylePriority.UseBorders = False
        Me.Inicio.StylePriority.UseFont = False
        Me.Inicio.StylePriority.UseTextAlignment = False
        Me.Inicio.Text = "XrLabel1"
        Me.Inicio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Duracion
        '
        Me.Duracion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Duracion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Duracion", "{0}")})
        Me.Duracion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duracion.LocationFloat = New DevExpress.Utils.PointFloat(147.92!, 348.9583!)
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Duracion.SizeF = New System.Drawing.SizeF(306.79!, 25.0!)
        Me.Duracion.StylePriority.UseBorders = False
        Me.Duracion.StylePriority.UseFont = False
        Me.Duracion.StylePriority.UseTextAlignment = False
        Me.Duracion.Text = "XrLabel1"
        Me.Duracion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 348.9583!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(147.92!, 25.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Duración:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 323.9583!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(147.92!, 25.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Fecha Finalización:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 298.9583!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(147.92!, 25.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Fecha Inicio:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.DarkGray
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.ForeColor = System.Drawing.Color.White
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(457.6083!, 151.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(341.6785!, 25.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Datos del Proyecto"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Proyecto
        '
        Me.Proyecto.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Proyecto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Proyecto")})
        Me.Proyecto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyecto.LocationFloat = New DevExpress.Utils.PointFloat(457.6084!, 176.0!)
        Me.Proyecto.Multiline = True
        Me.Proyecto.Name = "Proyecto"
        Me.Proyecto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Proyecto.SizeF = New System.Drawing.SizeF(342.3916!, 101.0!)
        Me.Proyecto.StylePriority.UseBorders = False
        Me.Proyecto.StylePriority.UseFont = False
        Me.Proyecto.StylePriority.UseTextAlignment = False
        Me.Proyecto.Text = "XrLabel1"
        Me.Proyecto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.DarkGray
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.White
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 151.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(293.6667!, 25.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Nombre del Cliente"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Cliente
        '
        Me.Cliente.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Cliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cliente")})
        Me.Cliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 176.0!)
        Me.Cliente.Multiline = True
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cliente.SizeF = New System.Drawing.SizeF(293.6667!, 101.0!)
        Me.Cliente.StylePriority.UseBorders = False
        Me.Cliente.StylePriority.UseFont = False
        Me.Cliente.StylePriority.UseTextAlignment = False
        Me.Cliente.Text = "XrLabel1"
        Me.Cliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd/MM/yyyy}")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(457.6083!, 121.75!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(164.0806!, 26.04166!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel1"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.DarkGray
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.BorderWidth = 1.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.ForeColor = System.Drawing.Color.White
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(621.6888!, 97.5833!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(178.0!, 24.17!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Proyecto #"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Numero
        '
        Me.Numero.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Numero.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Numero")})
        Me.Numero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Numero.LocationFloat = New DevExpress.Utils.PointFloat(621.6888!, 121.75!)
        Me.Numero.Name = "Numero"
        Me.Numero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Numero.SizeF = New System.Drawing.SizeF(178.0!, 26.04!)
        Me.Numero.StylePriority.UseBorders = False
        Me.Numero.StylePriority.UseFont = False
        Me.Numero.StylePriority.UseTextAlignment = False
        Me.Numero.Text = "XrLabel1"
        Me.Numero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.DarkGray
        Me.XrLabel11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.ForeColor = System.Drawing.Color.White
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(457.6083!, 97.5833!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(164.0806!, 24.16669!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Fecha"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(209.2117!, 134.25!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = False
        '
        'Empresa
        '
        Me.Empresa.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Empresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empresa.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Empresa.SizeF = New System.Drawing.SizeF(800.0!, 31.99999!)
        Me.Empresa.StylePriority.UseBorders = False
        Me.Empresa.StylePriority.UseFont = False
        Me.Empresa.StylePriority.UseTextAlignment = False
        Me.Empresa.Text = "EQUIPOS Y ACCESORIOS, S. A. DE C. V."
        Me.Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 31.99998!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(800.0!, 54.12496!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "PBX: 2508-0480" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RTN: 05019012486244" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: equipsahn@equipsa.net"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Etapa})
        Me.GroupFooter1.HeightF = 25.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Etapa
        '
        Me.Etapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Etapa.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Etapa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Etapa", "{0}")})
        Me.Etapa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etapa.ForeColor = System.Drawing.Color.Crimson
        Me.Etapa.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Etapa.Name = "Etapa"
        Me.Etapa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Etapa.SizeF = New System.Drawing.SizeF(799.2868!, 25.0!)
        Me.Etapa.StylePriority.UseBackColor = False
        Me.Etapa.StylePriority.UseBorders = False
        Me.Etapa.StylePriority.UseFont = False
        Me.Etapa.StylePriority.UseForeColor = False
        Me.Etapa.StylePriority.UseTextAlignment = False
        Me.Etapa.Text = "Nombre del Cliente"
        Me.Etapa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Usuario, Me.label7, Me.label16})
        Me.PageFooter.HeightF = 85.41666!
        Me.PageFooter.Name = "PageFooter"
        '
        'Usuario
        '
        Me.Usuario.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Usuario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Usuario", "{0}")})
        Me.Usuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(457.6084!, 0.0!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(229.9998!, 26.04166!)
        Me.Usuario.StylePriority.UseBorders = False
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "XrLabel1"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(118.3333!, 25.41677!)
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label7.SizeF = New System.Drawing.SizeF(230.0!, 32.91656!)
        Me.label7.StylePriority.UseBorders = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "Firma y Sello"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label16
        '
        Me.label16.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(457.6083!, 26.04167!)
        Me.label16.Name = "label16"
        Me.label16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label16.SizeF = New System.Drawing.SizeF(230.0!, 32.29166!)
        Me.label16.StylePriority.UseBorders = False
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Creado por"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'rptProyecto
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupFooter1, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 45)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Numero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Empresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Proyecto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Bodega As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fin As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Inicio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Duracion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descripcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Etapa As DevExpress.XtraReports.UI.XRLabel
End Class
