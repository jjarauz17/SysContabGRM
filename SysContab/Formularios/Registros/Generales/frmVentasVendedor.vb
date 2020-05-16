Public Class frmVentasVendedor
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVentasVendedor = Nothing

    Public Shared Function Instance() As frmVentasVendedor
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVentasVendedor()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents dgVentas As System.Windows.Forms.DataGrid
    Friend WithEvents gbGrafico As System.Windows.Forms.GroupBox
    Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasVendedor))
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.dgVentas = New System.Windows.Forms.DataGrid
        Me.gbGrafico = New System.Windows.Forms.GroupBox
        Me.chtAcumulados = New AxMSChart20Lib.AxMSChart
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrafico.SuspendLayout()
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 465)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 34)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 21)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "VENTAS POR VENDEDOR:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(200, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(800, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgVentas
        '
        Me.dgVentas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgVentas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgVentas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgVentas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgVentas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgVentas.DataMember = ""
        Me.dgVentas.FlatMode = True
        Me.dgVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVentas.ForeColor = System.Drawing.Color.Black
        Me.dgVentas.GridLineColor = System.Drawing.Color.Silver
        Me.dgVentas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgVentas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentas.HeaderForeColor = System.Drawing.Color.White
        Me.dgVentas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgVentas.Location = New System.Drawing.Point(8, 17)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgVentas.SelectionForeColor = System.Drawing.Color.White
        Me.dgVentas.Size = New System.Drawing.Size(368, 431)
        Me.dgVentas.TabIndex = 116
        '
        'gbGrafico
        '
        Me.gbGrafico.Controls.Add(Me.chtAcumulados)
        Me.gbGrafico.Controls.Add(Me.cmdCancelar)
        Me.gbGrafico.Controls.Add(Me.dgVentas)
        Me.gbGrafico.Location = New System.Drawing.Point(8, 43)
        Me.gbGrafico.Name = "gbGrafico"
        Me.gbGrafico.Size = New System.Drawing.Size(1000, 500)
        Me.gbGrafico.TabIndex = 119
        Me.gbGrafico.TabStop = False
        '
        'chtAcumulados
        '
        Me.chtAcumulados.DataSource = Nothing
        Me.chtAcumulados.Location = New System.Drawing.Point(384, 9)
        Me.chtAcumulados.Name = "chtAcumulados"
        Me.chtAcumulados.OcxState = CType(resources.GetObject("chtAcumulados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.chtAcumulados.Size = New System.Drawing.Size(608, 482)
        Me.chtAcumulados.TabIndex = 119
        '
        'frmVentasVendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbGrafico)
        Me.Name = "frmVentasVendedor"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrafico.ResumeLayout(False)
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet

    Private Sub frmVentasVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Vendedor As New VB.SysContab.VendedoresDB()
        Dim Detalles As New VB.SysContab.VendedoresDetails()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable

        Detalles = Vendedor.GetDetails(Registro)
        dgVentas.CaptionText = "Ventas por Vendedor"
        Me.Text = "Ventas por Vendedor"
        etDescripcion.Text = Detalles.Nombre.ToUpper

        '''r.CambiarEstilo(Me)

        ds = Vendedor.GetVentas(Registro)

        ds.Tables("Ventas").DefaultView.AllowDelete = False
        ds.Tables("Ventas").DefaultView.AllowNew = False
        ds.Tables("Ventas").DefaultView.AllowEdit = False

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView

        dgVentas.DataSource = ds.Tables("Ventas").DefaultView 'Acumulados.GetList(Registro).Tables("Acumulados").DefaultView
        Tabla = ds.Tables("Ventas")

        r.FormatGenerico(dgVentas, Tabla)


        MostrarGrafico()


        dgVentas.Refresh()

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub MostrarGrafico()

        Dim i As Integer

        'Monto_Mes.Clear()
        'Debe.Clear()
        'Haber.Clear()
        'Saldo.Clear()

        'For i = 0 To dgCatalogoAcumulados.VisibleRowCount - 2
        '    'Monto_Mes.Add(dgCatalogoAcumulados.Item(i, 2))
        '    Debe.Add(dgCatalogoAcumulados.Item(i, 2))
        '    Haber.Add(dgCatalogoAcumulados.Item(i, 3))
        '    Saldo.Add(dgCatalogoAcumulados.Item(i, 4))

        'Next

        chtAcumulados.Visible = True

        'Dim AcumuladosGrafico(,) As Object = New Object(,) _
        '    {{"CP", "Debe", "Haber", "Saldo"}, _
        '    {"ENERO", Debe(0), Haber(0), Saldo(0)}, _
        '    {"FEBRERO", Debe(1), Haber(1), Saldo(1)}, _
        '    {"MARZO", Debe(2), Haber(2), Saldo(2)}, _
        '    {"ABRIL", Debe(3), Haber(3), Saldo(3)}, _
        '    {"MAYO", Debe(4), Haber(4), Saldo(4)}, _
        '    {"JUNIO", Debe(5), Haber(5), Saldo(5)}, _
        '    {"JULIO", Debe(6), Haber(6), Saldo(6)}, _
        '    {"AGOSTO", Debe(7), Haber(7), Saldo(7)}, _
        '    {"SEPTIEMBRE", Debe(8), Haber(8), Saldo(8)}, _
        '    {"OCTUBRE", Debe(9), Haber(9), Saldo(9)}, _
        '    {"NOVIEMBRE", Debe(10), Haber(10), Saldo(10)}, _
        '    {"DICIEMBRE", Debe(11), Haber(11), Saldo(11)}}

        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "Ventas", "Comisiones"}, _
            {ds.Tables("Ventas").Rows(0).Item("Mes"), ds.Tables("Ventas").Rows(0).Item("Ventas"), ds.Tables("Ventas").Rows(0).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(1).Item("Mes"), ds.Tables("Ventas").Rows(1).Item("Ventas"), ds.Tables("Ventas").Rows(1).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(2).Item("Mes"), ds.Tables("Ventas").Rows(2).Item("Ventas"), ds.Tables("Ventas").Rows(2).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(3).Item("Mes"), ds.Tables("Ventas").Rows(3).Item("Ventas"), ds.Tables("Ventas").Rows(3).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(4).Item("Mes"), ds.Tables("Ventas").Rows(4).Item("Ventas"), ds.Tables("Ventas").Rows(4).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(5).Item("Mes"), ds.Tables("Ventas").Rows(5).Item("Ventas"), ds.Tables("Ventas").Rows(5).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(6).Item("Mes"), ds.Tables("Ventas").Rows(6).Item("Ventas"), ds.Tables("Ventas").Rows(6).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(7).Item("Mes"), ds.Tables("Ventas").Rows(7).Item("Ventas"), ds.Tables("Ventas").Rows(7).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(8).Item("Mes"), ds.Tables("Ventas").Rows(8).Item("Ventas"), ds.Tables("Ventas").Rows(8).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(9).Item("Mes"), ds.Tables("Ventas").Rows(9).Item("Ventas"), ds.Tables("Ventas").Rows(9).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(10).Item("Mes"), ds.Tables("Ventas").Rows(10).Item("Ventas"), ds.Tables("Ventas").Rows(10).Item("Comision")}, _
            {ds.Tables("Ventas").Rows(11).Item("Mes"), ds.Tables("Ventas").Rows(11).Item("Ventas"), ds.Tables("Ventas").Rows(11).Item("Comision")}}

        'ds.Tables("Ventas")

        chtAcumulados.ChartData = AcumuladosGrafico

        chtAcumulados.ShowLegend = True

        'Add a title and legend.
        With Me.chtAcumulados
            '.Title.VtFont.Size = 8
            '.Title.Text = "Acumulados de la Cuenta: " & etDescripcion.Text
            .Legend.Location.LocationType = _
               MSChart20Lib.VtChLocationType.VtChLocationTypeRight
            .Legend.Location.Visible = True
            '.chartType = MSChart20Lib.VtChChartType.VtChChartType3dBar
            .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
            '.SeriesType = MSChart20Lib.VtChSeriesType.VtChSeriesType2dPie
            .Enabled = False
            .ShowLegend = True

        End With

        'Add titles to the axes.
        With Me.chtAcumulados.Plot
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
            '.View3d.Elevation = 0
            '.View3d.Rotation = 90

            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

            .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 0, 0)

            .SeriesCollection(2).DataPoints(-1).Brush.FillColor.Set(0, 150, 0)

            '.SeriesCollection(3).DataPoints(-1).Brush.FillColor.Set(0, 0, 150)

        End With
    End Sub

End Class
