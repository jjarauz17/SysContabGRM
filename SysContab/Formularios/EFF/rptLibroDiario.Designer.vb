<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLibroDiario
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.dhaber = New DevExpress.XtraReports.UI.XRLabel()
        Me.ncuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtcuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.dDebe = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtSC02 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ghComprobante = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblConcepto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ghSC02 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.nSc02 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ghsc01 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.txtcs01 = New DevExpress.XtraReports.UI.XRLabel()
        Me.nSc01 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ghMayor = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.nMayor = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtMayor = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.txtEmpresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.ghfecha = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.lblNumero = New DevExpress.XtraReports.UI.XRLabel()
        Me.Hasta = New DevExpress.XtraReports.UI.XRLabel()
        Me.Desde = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooter4 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooter5 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.GroupFooter6 = New DevExpress.XtraReports.UI.GroupFooterBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.dhaber, Me.ncuenta, Me.txtcuenta, Me.dDebe})
        Me.Detail.HeightF = 20.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dhaber
        '
        Me.dhaber.CanShrink = True
        Me.dhaber.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "haber", "{0:n2}")})
        Me.dhaber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dhaber.ForeColor = System.Drawing.Color.Black
        Me.dhaber.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 0!)
        Me.dhaber.Name = "dhaber"
        Me.dhaber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dhaber.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.dhaber.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.dhaber.StylePriority.UseFont = False
        Me.dhaber.StylePriority.UseForeColor = False
        Me.dhaber.StylePriority.UseTextAlignment = False
        Me.dhaber.Text = "txtcuenta"
        Me.dhaber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ncuenta
        '
        Me.ncuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ncuenta")})
        Me.ncuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncuenta.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0!)
        Me.ncuenta.Name = "ncuenta"
        Me.ncuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ncuenta.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.ncuenta.SizeF = New System.Drawing.SizeF(397.3958!, 20.0!)
        Me.ncuenta.StylePriority.UseFont = False
        Me.ncuenta.Text = "cuenta"
        '
        'txtcuenta
        '
        Me.txtcuenta.CanShrink = True
        Me.txtcuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "cuenta")})
        Me.txtcuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuenta.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtcuenta.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.txtcuenta.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.txtcuenta.StylePriority.UseFont = False
        Me.txtcuenta.Text = "txtcuenta"
        '
        'dDebe
        '
        Me.dDebe.CanShrink = True
        Me.dDebe.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "debe", "{0:n2}")})
        Me.dDebe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dDebe.ForeColor = System.Drawing.Color.Black
        Me.dDebe.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 0!)
        Me.dDebe.Name = "dDebe"
        Me.dDebe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dDebe.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.dDebe.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.dDebe.StylePriority.UseFont = False
        Me.dDebe.StylePriority.UseForeColor = False
        Me.dDebe.StylePriority.UseTextAlignment = False
        Me.dDebe.Text = "txtcuenta"
        Me.dDebe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txtSC02
        '
        Me.txtSC02.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtSC02.CanShrink = True
        Me.txtSC02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "sc02")})
        Me.txtSC02.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC02.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSC02.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.txtSC02.Name = "txtSC02"
        Me.txtSC02.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtSC02.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.txtSC02.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.txtSC02.StylePriority.UseBorders = False
        Me.txtSC02.StylePriority.UseFont = False
        Me.txtSC02.StylePriority.UseForeColor = False
        Me.txtSC02.Text = "txtcuenta"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 20.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrPageInfo2.Format = "{0:dddd, d' de 'MMMM' de 'yyyy h:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1.041794!, 39.58335!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(351.0417!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'ghComprobante
        '
        Me.ghComprobante.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2, Me.lblConcepto, Me.XrLabel17, Me.XrLabel16, Me.XrLabel18, Me.XrLabel19})
        Me.ghComprobante.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghComprobante.HeightF = 98.41669!
        Me.ghComprobante.Level = 4
        Me.ghComprobante.Name = "ghComprobante"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 55.41668!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(497.3958!, 20.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 55.41668!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(249.9998!, 20.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "MOVIMIENTO DEL MES"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblConcepto
        '
        Me.lblConcepto.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblConcepto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblConcepto.SizeF = New System.Drawing.SizeF(747.3957!, 55.41667!)
        Me.lblConcepto.StylePriority.UseBorders = False
        Me.lblConcepto.StylePriority.UseFont = False
        Me.lblConcepto.Text = "Concepto:"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 75.41669!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(397.3958!, 23.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "DESCRIPCION"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.5208651!, 75.41669!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(98.95803!, 23.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "CUENTA"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 75.41669!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(125.0!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "DEBITO"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 75.41669!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(125.0!, 23.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "CREDITO"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ghSC02
        '
        Me.ghSC02.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtSC02, Me.nSc02, Me.XrLabel5, Me.XrLabel6})
        Me.ghSC02.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("sc02", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghSC02.HeightF = 20.0!
        Me.ghSC02.Name = "ghSC02"
        '
        'nSc02
        '
        Me.nSc02.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.nSc02.CanShrink = True
        Me.nSc02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "nsc02")})
        Me.nSc02.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSc02.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nSc02.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0!)
        Me.nSc02.Name = "nSc02"
        Me.nSc02.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nSc02.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.nSc02.SizeF = New System.Drawing.SizeF(397.3958!, 20.0!)
        Me.nSc02.StylePriority.UseBorders = False
        Me.nSc02.StylePriority.UseFont = False
        Me.nSc02.StylePriority.UseForeColor = False
        Me.nSc02.Text = "txtcuenta"
        '
        'XrLabel5
        '
        Me.XrLabel5.CanShrink = True
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "debe")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.ForeColor = System.Drawing.Color.Black
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel5.Summary = XrSummary1
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.CanShrink = True
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "haber")})
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel6.Summary = XrSummary2
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ghsc01
        '
        Me.ghsc01.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtcs01, Me.nSc01, Me.XrLabel7, Me.XrLabel8})
        Me.ghsc01.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("sc01", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghsc01.HeightF = 20.0!
        Me.ghsc01.Level = 1
        Me.ghsc01.Name = "ghsc01"
        '
        'txtcs01
        '
        Me.txtcs01.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtcs01.CanShrink = True
        Me.txtcs01.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "sc01")})
        Me.txtcs01.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcs01.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcs01.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.txtcs01.Name = "txtcs01"
        Me.txtcs01.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtcs01.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.txtcs01.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.txtcs01.StylePriority.UseBorders = False
        Me.txtcs01.StylePriority.UseFont = False
        Me.txtcs01.StylePriority.UseForeColor = False
        Me.txtcs01.Text = "txtcuenta"
        '
        'nSc01
        '
        Me.nSc01.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.nSc01.CanShrink = True
        Me.nSc01.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "nsc01")})
        Me.nSc01.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSc01.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nSc01.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0!)
        Me.nSc01.Name = "nSc01"
        Me.nSc01.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nSc01.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.nSc01.SizeF = New System.Drawing.SizeF(397.3958!, 20.0!)
        Me.nSc01.StylePriority.UseBorders = False
        Me.nSc01.StylePriority.UseFont = False
        Me.nSc01.StylePriority.UseForeColor = False
        Me.nSc01.Text = "txtcuenta"
        '
        'XrLabel7
        '
        Me.XrLabel7.CanShrink = True
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "debe")})
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel7.Summary = XrSummary3
        Me.XrLabel7.Text = "XrLabel5"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel8
        '
        Me.XrLabel8.CanShrink = True
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "haber")})
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel8.Summary = XrSummary4
        Me.XrLabel8.Text = "XrLabel6"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ghMayor
        '
        Me.ghMayor.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.nMayor, Me.txtMayor, Me.XrLabel9, Me.XrLabel13})
        Me.ghMayor.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("mayor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghMayor.HeightF = 20.0!
        Me.ghMayor.Level = 2
        Me.ghMayor.Name = "ghMayor"
        '
        'nMayor
        '
        Me.nMayor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.nMayor.CanShrink = True
        Me.nMayor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "nmayor")})
        Me.nMayor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMayor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nMayor.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0!)
        Me.nMayor.Name = "nMayor"
        Me.nMayor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nMayor.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.nMayor.SizeF = New System.Drawing.SizeF(397.3958!, 20.0!)
        Me.nMayor.StylePriority.UseBorders = False
        Me.nMayor.StylePriority.UseFont = False
        Me.nMayor.StylePriority.UseForeColor = False
        Me.nMayor.Text = "txtcuenta"
        '
        'txtMayor
        '
        Me.txtMayor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtMayor.CanShrink = True
        Me.txtMayor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "mayor")})
        Me.txtMayor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMayor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMayor.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.txtMayor.Name = "txtMayor"
        Me.txtMayor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtMayor.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.txtMayor.SizeF = New System.Drawing.SizeF(100.0!, 20.0!)
        Me.txtMayor.StylePriority.UseBorders = False
        Me.txtMayor.StylePriority.UseFont = False
        Me.txtMayor.StylePriority.UseForeColor = False
        Me.txtMayor.Text = "txtcuenta"
        '
        'XrLabel9
        '
        Me.XrLabel9.CanShrink = True
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "haber")})
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary5
        Me.XrLabel9.Text = "XrLabel6"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.CanShrink = True
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "debe")})
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel13.Summary = XrSummary6
        Me.XrLabel13.Text = "XrLabel5"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooter.HeightF = 62.58335!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "Pagina {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 39.58335!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(200.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtEmpresa, Me.txtTitulo, Me.Moneda})
        Me.PageHeader.HeightF = 82.79168!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtEmpresa.SizeF = New System.Drawing.SizeF(750.0!, 23.0!)
        Me.txtEmpresa.StylePriority.UseFont = False
        Me.txtEmpresa.StylePriority.UseTextAlignment = False
        Me.txtEmpresa.Text = "txtEmpresa"
        Me.txtEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.LocationFloat = New DevExpress.Utils.PointFloat(0.5208691!, 23.0!)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitulo.SizeF = New System.Drawing.SizeF(748.9583!, 23.0!)
        Me.txtTitulo.StylePriority.UseFont = False
        Me.txtTitulo.StylePriority.UseTextAlignment = False
        Me.txtTitulo.Text = "txtTitulo"
        Me.txtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.Moneda.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Moneda")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.0!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(750.0!, 23.0!)
        Me.Moneda.StylePriority.UseBorders = False
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "txtTitulo"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ghfecha
        '
        Me.ghfecha.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblNumero, Me.Hasta, Me.Desde, Me.XrLabel11, Me.XrLabel10, Me.XrLabel1})
        Me.ghfecha.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("fecha", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghfecha.HeightF = 64.79168!
        Me.ghfecha.Level = 5
        Me.ghfecha.Name = "ghfecha"
        '
        'lblNumero
        '
        Me.lblNumero.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblNumero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.LocationFloat = New DevExpress.Utils.PointFloat(85.41665!, 40.00002!)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNumero.SizeF = New System.Drawing.SizeF(85.41666!, 20.0!)
        Me.lblNumero.StylePriority.UseBorders = False
        Me.lblNumero.StylePriority.UseFont = False
        Me.lblNumero.StylePriority.UseTextAlignment = False
        Me.lblNumero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Hasta
        '
        Me.Hasta.CanShrink = True
        Me.Hasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hasta", "{0:dd/MM/yyyy}")})
        Me.Hasta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.ForeColor = System.Drawing.Color.Black
        Me.Hasta.LocationFloat = New DevExpress.Utils.PointFloat(625.5208!, 0!)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Hasta.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Hasta.SizeF = New System.Drawing.SizeF(121.875!, 20.0!)
        Me.Hasta.StylePriority.UseFont = False
        Me.Hasta.StylePriority.UseForeColor = False
        Me.Hasta.StylePriority.UseTextAlignment = False
        Me.Hasta.Text = "txtcuenta"
        Me.Hasta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Desde
        '
        Me.Desde.CanShrink = True
        Me.Desde.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Desde", "{0:dd/MM/yyyy}")})
        Me.Desde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.ForeColor = System.Drawing.Color.Black
        Me.Desde.LocationFloat = New DevExpress.Utils.PointFloat(123.9619!, 0!)
        Me.Desde.Name = "Desde"
        Me.Desde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desde.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.Desde.SizeF = New System.Drawing.SizeF(121.875!, 20.0!)
        Me.Desde.StylePriority.UseFont = False
        Me.Desde.StylePriority.UseForeColor = False
        Me.Desde.StylePriority.UseTextAlignment = False
        Me.Desde.Text = "txtcuenta"
        Me.Desde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(513.5419!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(111.9789!, 20.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Fecha Hasta:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1.041937!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(122.92!, 20.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Fecha Desde:"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 40.00003!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(85.41666!, 20.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Diario No.:"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Expanded = False
        Me.GroupFooter1.HeightF = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = False
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1.041826!, 16.66667!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(496.354!, 20.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "TOTALES"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.CanShrink = True
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "haber")})
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(622.3958!, 16.66668!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(127.0!, 20.0!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel14.Summary = XrSummary7
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.CanShrink = True
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "debe")})
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(497.3958!, 16.66668!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(125.0!, 20.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel15.Summary = XrSummary8
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Expanded = False
        Me.GroupFooter2.HeightF = 0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.Visible = False
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Expanded = False
        Me.GroupFooter3.HeightF = 0!
        Me.GroupFooter3.Level = 2
        Me.GroupFooter3.Name = "GroupFooter3"
        Me.GroupFooter3.Visible = False
        '
        'GroupFooter4
        '
        Me.GroupFooter4.Expanded = False
        Me.GroupFooter4.HeightF = 0!
        Me.GroupFooter4.Level = 3
        Me.GroupFooter4.Name = "GroupFooter4"
        Me.GroupFooter4.Visible = False
        '
        'GroupFooter5
        '
        Me.GroupFooter5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel15, Me.XrLabel4})
        Me.GroupFooter5.Expanded = False
        Me.GroupFooter5.HeightF = 36.66668!
        Me.GroupFooter5.Level = 4
        Me.GroupFooter5.Name = "GroupFooter5"
        '
        'GroupFooter6
        '
        Me.GroupFooter6.Expanded = False
        Me.GroupFooter6.HeightF = 0!
        Me.GroupFooter6.Level = 5
        Me.GroupFooter6.Name = "GroupFooter6"
        Me.GroupFooter6.Visible = False
        '
        'rptLibroDiario
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ghComprobante, Me.ghSC02, Me.ghsc01, Me.ghMayor, Me.PageFooter, Me.PageHeader, Me.ghfecha, Me.GroupFooter1, Me.GroupFooter2, Me.GroupFooter3, Me.GroupFooter4, Me.GroupFooter5, Me.GroupFooter6})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 20, 20)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ncuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtcuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ghComprobante As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents txtSC02 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ghSC02 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents dDebe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ghsc01 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents ghMayor As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents txtMayor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtcs01 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nSc02 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nSc01 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nMayor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dhaber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents txtEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ghfecha As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter4 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter5 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter6 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Desde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Hasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblConcepto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNumero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
