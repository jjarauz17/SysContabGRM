Imports DevExpress.XtraReports.UI

Public Class RptNoDistribuidos
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Desde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Hasta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpComprobante As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents No As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Descripcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Monto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tipo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel
        Me.Tipo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.Monto = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.Hasta = New DevExpress.XtraReports.UI.XRLabel
        Me.Desde = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GrpComprobante = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.Descripcion = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.Fecha = New DevExpress.XtraReports.UI.XRLabel
        Me.No = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Nombre, Me.Tipo, Me.XrLabel7, Me.XrLabel9, Me.Monto, Me.XrLabel8, Me.Cuenta})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Nombre.Location = New System.Drawing.Point(217, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.ParentStyleUsing.UseFont = False
        Me.Nombre.Size = New System.Drawing.Size(258, 25)
        '
        'Tipo
        '
        Me.Tipo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tipo", "")})
        Me.Tipo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Tipo.Location = New System.Drawing.Point(692, 0)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tipo.ParentStyleUsing.UseFont = False
        Me.Tipo.Size = New System.Drawing.Size(58, 25)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.Location = New System.Drawing.Point(642, 0)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel7.Text = "Tipo:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel9.Location = New System.Drawing.Point(475, 0)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel9.Text = "Monto:"
        '
        'Monto
        '
        Me.Monto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Monto", "{0:n2}")})
        Me.Monto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Monto.Location = New System.Drawing.Point(525, 0)
        Me.Monto.Name = "Monto"
        Me.Monto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Monto.ParentStyleUsing.UseFont = False
        Me.Monto.Size = New System.Drawing.Size(117, 25)
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.Location = New System.Drawing.Point(50, 0)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel8.Text = "Cuenta:"
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta", "")})
        Me.Cuenta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cuenta.Location = New System.Drawing.Point(100, 0)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.ParentStyleUsing.UseFont = False
        Me.Cuenta.Size = New System.Drawing.Size(117, 25)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Hasta, Me.Desde, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Height = 85
        Me.PageHeader.Name = "PageHeader"
        '
        'Hasta
        '
        Me.Hasta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Hasta", "{0:dd MMMM yy}")})
        Me.Hasta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Hasta.Location = New System.Drawing.Point(408, 25)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Hasta.ParentStyleUsing.UseFont = False
        Me.Hasta.Size = New System.Drawing.Size(125, 25)
        '
        'Desde
        '
        Me.Desde.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Desde", "{0:dd MMMM yy}")})
        Me.Desde.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Desde.Location = New System.Drawing.Point(250, 25)
        Me.Desde.Name = "Desde"
        Me.Desde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Desde.ParentStyleUsing.UseFont = False
        Me.Desde.Size = New System.Drawing.Size(125, 25)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(375, 25)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(33, 25)
        Me.XrLabel3.Text = "Al :"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(217, 25)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(33, 25)
        Me.XrLabel2.Text = "Del :"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(217, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(317, 25)
        Me.XrLabel1.Text = "LISTA DE COMPROBANTES NO DISTRIBUIDOS"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        '
        'GrpComprobante
        '
        Me.GrpComprobante.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Descripcion, Me.XrLabel5, Me.XrLabel6, Me.Fecha, Me.No, Me.XrLabel4})
        Me.GrpComprobante.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("No", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpComprobante.Height = 25
        Me.GrpComprobante.Name = "GrpComprobante"
        '
        'Descripcion
        '
        Me.Descripcion.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Descripcion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Descripcion", "")})
        Me.Descripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Descripcion.Location = New System.Drawing.Point(408, 0)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Descripcion.ParentStyleUsing.UseBorders = False
        Me.Descripcion.ParentStyleUsing.UseFont = False
        Me.Descripcion.Size = New System.Drawing.Size(342, 25)
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(325, 0)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel5.Text = "Descripcion :"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(167, 0)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel6.Text = "Fecha :"
        '
        'Fecha
        '
        Me.Fecha.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Fecha.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fecha", "{0:dd MMMM yy}")})
        Me.Fecha.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Fecha.Location = New System.Drawing.Point(217, 0)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Fecha.ParentStyleUsing.UseBorders = False
        Me.Fecha.ParentStyleUsing.UseFont = False
        Me.Fecha.Size = New System.Drawing.Size(108, 25)
        '
        'No
        '
        Me.No.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.No.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "No", "")})
        Me.No.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.No.Location = New System.Drawing.Point(100, 0)
        Me.No.Name = "No"
        Me.No.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.No.ParentStyleUsing.UseBorders = False
        Me.No.ParentStyleUsing.UseFont = False
        Me.No.Size = New System.Drawing.Size(67, 25)
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel4.Text = "Comprobante No:"
        '
        'RptNoDistribuidos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpComprobante})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub No_PreviewClick(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles No.PreviewClick
        Dim view As DataRowView
        'view = e.Data.Tag
        view = e.Brick.TextValue

        'Dim f As DataGridTextBox.frmComprobantesDetalles = DataGridTextBox.frmComprobantesDetalles.Instance()
        'f.Temp = True
        'f.lblNoComprobante.Text = view.Row.Item("No")
        'f.lblPeriodo.Text = view.Row.Item("Per_Id")
        'f.txtFecha.Text = view.Row.Item("Fecha")
        'f.Show()

        Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        'f.Temp = True
        f.txtlNoComprobante.Text = view.Row.Item("Comp")
        f.Periodo = view.Row.Item("Periodo")
        f.Fecha.EditValue = view.Row.Item("Fecha")
        f.Fecha1 = view.Row.Item("Fecha")
        f.ComprobanteID = 0
        f.TipoLiq = 0
        f.StartPosition = FormStartPosition.CenterScreen
        f.cmdAceptar.Enabled = False
        f.cmdAnular.Enabled = False
        f.cmdAyuda.Enabled = False
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub No_PreviewMouseMove(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles No.PreviewMouseMove
        Cursor.Current = Cursors.Hand
    End Sub

    Private Sub No_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles No.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()
    End Sub

End Class

