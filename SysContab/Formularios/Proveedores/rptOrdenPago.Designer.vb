<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptOrdenPago
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Credito = New DevExpress.XtraReports.UI.XRLabel()
        Me.Debito = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Usuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.Tipo = New DevExpress.XtraReports.UI.XRLabel()
        Me.MontoU = New DevExpress.XtraReports.UI.XRLabel()
        Me.Comp_No = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormaPago = New DevExpress.XtraReports.UI.XRLabel()
        Me.Moneda = New DevExpress.XtraReports.UI.XRLabel()
        Me.Factura = New DevExpress.XtraReports.UI.XRLabel()
        Me.Valor = New DevExpress.XtraReports.UI.XRLabel()
        Me.Concepto = New DevExpress.XtraReports.UI.XRLabel()
        Me.Benificiario = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Proyecto = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Credito, Me.Debito, Me.Nombre, Me.Cuenta})
        Me.Detail.HeightF = 23.95834!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Credito
        '
        Me.Credito.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Credito]")})
        Me.Credito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credito.LocationFloat = New DevExpress.Utils.PointFloat(690.0!, 0!)
        Me.Credito.Name = "Credito"
        Me.Credito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Credito.SizeF = New System.Drawing.SizeF(100.0!, 23.95834!)
        Me.Credito.StylePriority.UseFont = False
        Me.Credito.StylePriority.UseTextAlignment = False
        Me.Credito.Text = "XrLabel4"
        Me.Credito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Credito.TextFormatString = "{0:n2}"
        '
        'Debito
        '
        Me.Debito.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Debito]")})
        Me.Debito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Debito.LocationFloat = New DevExpress.Utils.PointFloat(590.0!, 0!)
        Me.Debito.Name = "Debito"
        Me.Debito.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Debito.SizeF = New System.Drawing.SizeF(100.0!, 23.95834!)
        Me.Debito.StylePriority.UseFont = False
        Me.Debito.StylePriority.UseTextAlignment = False
        Me.Debito.Text = "XrLabel4"
        Me.Debito.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Debito.TextFormatString = "{0:n2}"
        '
        'Nombre
        '
        Me.Nombre.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre]")})
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.LocationFloat = New DevExpress.Utils.PointFloat(132.2917!, 0!)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.SizeF = New System.Drawing.SizeF(457.7083!, 23.95834!)
        Me.Nombre.StylePriority.UseFont = False
        Me.Nombre.StylePriority.UseTextAlignment = False
        Me.Nombre.Text = "XrLabel4"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cuenta
        '
        Me.Cuenta.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cuenta]")})
        Me.Cuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuenta.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.SizeF = New System.Drawing.SizeF(132.2917!, 23.95834!)
        Me.Cuenta.StylePriority.UseFont = False
        Me.Cuenta.StylePriority.UseTextAlignment = False
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Proyecto, Me.Usuario, Me.Tipo, Me.MontoU, Me.Comp_No, Me.FormaPago, Me.Moneda, Me.Factura, Me.Valor, Me.Concepto, Me.Benificiario, Me.Fecha})
        Me.TopMargin.HeightF = 201.4583!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Usuario
        '
        Me.Usuario.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Usuario]")})
        Me.Usuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.LocationFloat = New DevExpress.Utils.PointFloat(532.2917!, 158.4167!)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Usuario.SizeF = New System.Drawing.SizeF(86.45844!, 22.99998!)
        Me.Usuario.StylePriority.UseFont = False
        Me.Usuario.StylePriority.UseTextAlignment = False
        Me.Usuario.Text = "Benificiario"
        Me.Usuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tipo
        '
        Me.Tipo.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tipo]")})
        Me.Tipo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.LocationFloat = New DevExpress.Utils.PointFloat(308.3333!, 158.4167!)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tipo.SizeF = New System.Drawing.SizeF(182.2918!, 22.99999!)
        Me.Tipo.StylePriority.UseFont = False
        Me.Tipo.StylePriority.UseTextAlignment = False
        Me.Tipo.Text = "Benificiario"
        Me.Tipo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'MontoU
        '
        Me.MontoU.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MontoU]")})
        Me.MontoU.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoU.LocationFloat = New DevExpress.Utils.PointFloat(97.91657!, 158.4167!)
        Me.MontoU.Name = "MontoU"
        Me.MontoU.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.MontoU.SizeF = New System.Drawing.SizeF(182.2918!, 22.99999!)
        Me.MontoU.StylePriority.UseFont = False
        Me.MontoU.StylePriority.UseTextAlignment = False
        Me.MontoU.Text = "Benificiario"
        Me.MontoU.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Comp_No
        '
        Me.Comp_No.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Comp_No]")})
        Me.Comp_No.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_No.LocationFloat = New DevExpress.Utils.PointFloat(532.2916!, 121.9584!)
        Me.Comp_No.Name = "Comp_No"
        Me.Comp_No.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Comp_No.SizeF = New System.Drawing.SizeF(182.2918!, 22.99999!)
        Me.Comp_No.StylePriority.UseFont = False
        Me.Comp_No.StylePriority.UseTextAlignment = False
        Me.Comp_No.Text = "Benificiario"
        Me.Comp_No.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'FormaPago
        '
        Me.FormaPago.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FormaPago]")})
        Me.FormaPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPago.LocationFloat = New DevExpress.Utils.PointFloat(308.3333!, 121.9584!)
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.FormaPago.SizeF = New System.Drawing.SizeF(182.2918!, 22.99999!)
        Me.FormaPago.StylePriority.UseFont = False
        Me.FormaPago.StylePriority.UseTextAlignment = False
        Me.FormaPago.Text = "Benificiario"
        Me.FormaPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Moneda
        '
        Me.Moneda.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Moneda]")})
        Me.Moneda.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.LocationFloat = New DevExpress.Utils.PointFloat(97.91657!, 121.9584!)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Moneda.SizeF = New System.Drawing.SizeF(182.2918!, 22.99999!)
        Me.Moneda.StylePriority.UseFont = False
        Me.Moneda.StylePriority.UseTextAlignment = False
        Me.Moneda.Text = "Benificiario"
        Me.Moneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Factura
        '
        Me.Factura.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Factura]")})
        Me.Factura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factura.LocationFloat = New DevExpress.Utils.PointFloat(423.9583!, 10.00001!)
        Me.Factura.Name = "Factura"
        Me.Factura.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Factura.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.Factura.StylePriority.UseFont = False
        Me.Factura.StylePriority.UseTextAlignment = False
        Me.Factura.Text = "Concepto"
        Me.Factura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Factura.TextFormatString = "No. {0}"
        '
        'Valor
        '
        Me.Valor.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Valor]")})
        Me.Valor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor.LocationFloat = New DevExpress.Utils.PointFloat(690.0!, 44.875!)
        Me.Valor.Name = "Valor"
        Me.Valor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Valor.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.Valor.StylePriority.UseFont = False
        Me.Valor.StylePriority.UseTextAlignment = False
        Me.Valor.Text = "Concepto"
        Me.Valor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.Valor.TextFormatString = "{0:n2}"
        '
        'Concepto
        '
        Me.Concepto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Concepto]")})
        Me.Concepto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concepto.LocationFloat = New DevExpress.Utils.PointFloat(97.91663!, 80.95834!)
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Concepto.SizeF = New System.Drawing.SizeF(692.0834!, 23.0!)
        Me.Concepto.StylePriority.UseFont = False
        Me.Concepto.StylePriority.UseTextAlignment = False
        Me.Concepto.Text = "Concepto"
        Me.Concepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Benificiario
        '
        Me.Benificiario.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Benificiario]")})
        Me.Benificiario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Benificiario.LocationFloat = New DevExpress.Utils.PointFloat(97.91663!, 44.875!)
        Me.Benificiario.Name = "Benificiario"
        Me.Benificiario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Benificiario.SizeF = New System.Drawing.SizeF(452.0834!, 23.0!)
        Me.Benificiario.StylePriority.UseFont = False
        Me.Benificiario.StylePriority.UseTextAlignment = False
        Me.Benificiario.Text = "Benificiario"
        Me.Benificiario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fecha]")})
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(97.91663!, 10.00001!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.SizeF = New System.Drawing.SizeF(252.0833!, 23.0!)
        Me.Fecha.StylePriority.UseFont = False
        Me.Fecha.StylePriority.UseTextAlignment = False
        Me.Fecha.Text = "Fecha"
        Me.Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Fecha.TextFormatString = "{0:dddd, dd' de 'MMMM' de 'yyyy}"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(398.96!, 20.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextFormatString = "{0:""Fecha de Impresión:"" dddd, dd' de 'MMMM' de 'yyyy hh:mm tt}"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Proyecto
        '
        Me.Proyecto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Proyecto]")})
        Me.Proyecto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyecto.LocationFloat = New DevExpress.Utils.PointFloat(630.625!, 157.4583!)
        Me.Proyecto.Name = "Proyecto"
        Me.Proyecto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Proyecto.SizeF = New System.Drawing.SizeF(132.2917!, 23.95834!)
        Me.Proyecto.StylePriority.UseFont = False
        Me.Proyecto.StylePriority.UseTextAlignment = False
        Me.Proyecto.Text = "Cuenta"
        Me.Proyecto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'rptOrdenPago
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 201, 50)
        Me.PageHeight = 800
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Concepto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Benificiario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Credito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Debito As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Factura As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Valor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Usuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tipo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents MontoU As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Comp_No As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormaPago As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Moneda As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Proyecto As DevExpress.XtraReports.UI.XRLabel
End Class
