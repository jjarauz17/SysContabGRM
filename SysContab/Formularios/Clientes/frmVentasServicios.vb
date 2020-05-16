Public Class frmVentasServicios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVentasServicios = Nothing

    Public Shared Function Instance() As frmVentasServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVentasServicios()
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents dgVentasServicios As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasServicios))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.dgVentasServicios = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.chtAcumulados = New AxMSChart20Lib.AxMSChart
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgVentasServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(976, 34)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 21)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "VENTAS POR SERVICIO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(176, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(800, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgVentasServicios
        '
        Me.dgVentasServicios.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgVentasServicios.BackColor = System.Drawing.Color.Gainsboro
        Me.dgVentasServicios.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgVentasServicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgVentasServicios.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgVentasServicios.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentasServicios.CaptionForeColor = System.Drawing.Color.Black
        Me.dgVentasServicios.DataMember = ""
        Me.dgVentasServicios.FlatMode = True
        Me.dgVentasServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVentasServicios.ForeColor = System.Drawing.Color.Black
        Me.dgVentasServicios.GridLineColor = System.Drawing.Color.Silver
        Me.dgVentasServicios.HeaderBackColor = System.Drawing.Color.Black
        Me.dgVentasServicios.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentasServicios.HeaderForeColor = System.Drawing.Color.White
        Me.dgVentasServicios.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgVentasServicios.Location = New System.Drawing.Point(16, 17)
        Me.dgVentasServicios.Name = "dgVentasServicios"
        Me.dgVentasServicios.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgVentasServicios.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgVentasServicios.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgVentasServicios.SelectionForeColor = System.Drawing.Color.White
        Me.dgVentasServicios.Size = New System.Drawing.Size(360, 388)
        Me.dgVentasServicios.TabIndex = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.dgVentasServicios)
        Me.GroupBox2.Controls.Add(Me.chtAcumulados)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(976, 463)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 420)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'chtAcumulados
        '
        Me.chtAcumulados.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.chtAcumulados.DataSource = Nothing
        Me.chtAcumulados.Location = New System.Drawing.Point(368, 9)
        Me.chtAcumulados.Name = "chtAcumulados"
        Me.chtAcumulados.OcxState = CType(resources.GetObject("chtAcumulados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.chtAcumulados.Size = New System.Drawing.Size(600, 456)
        Me.chtAcumulados.TabIndex = 119
        '
        'frmVentasServicios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1024, 518)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmVentasServicios"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgVentasServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet

    Public PC As String

    Private Sub frmVentasServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Servicio As New VB.SysContab.ServiciosDB()
        Dim Detalles As New VB.SysContab.ServiciosDetails()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable

        Detalles = Servicio.GetDetails(Registro, "S", PC)
        dgVentasServicios.CaptionText = "Ventas por Servicio"
        Me.Text = "Ventas por Servicio"
        etDescripcion.Text = Detalles.Nombre.ToUpper

        'r.CambiarEstilo(Me)

        ds = Servicio.GetVentas(Registro)

        ds.Tables("Ventas").DefaultView.AllowDelete = False
        ds.Tables("Ventas").DefaultView.AllowNew = False
        ds.Tables("Ventas").DefaultView.AllowEdit = False

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView

        dgVentasServicios.DataSource = ds.Tables("Ventas").DefaultView 'Acumulados.GetList(Registro).Tables("Acumulados").DefaultView
        Tabla = ds.Tables("Ventas")

        r.FormatGenerico(dgVentasServicios, Tabla)

        DatosGrafico()

        dgVentasServicios.Refresh()

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub DatosGrafico()

        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "C"}, _
            {ds.Tables("Ventas").Rows(0).Item("Mes"), ds.Tables("Ventas").Rows(0).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(1).Item("Mes"), ds.Tables("Ventas").Rows(1).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(2).Item("Mes"), ds.Tables("Ventas").Rows(2).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(3).Item("Mes"), ds.Tables("Ventas").Rows(3).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(4).Item("Mes"), ds.Tables("Ventas").Rows(4).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(5).Item("Mes"), ds.Tables("Ventas").Rows(5).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(6).Item("Mes"), ds.Tables("Ventas").Rows(6).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(7).Item("Mes"), ds.Tables("Ventas").Rows(7).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(8).Item("Mes"), ds.Tables("Ventas").Rows(8).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(9).Item("Mes"), ds.Tables("Ventas").Rows(9).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(10).Item("Mes"), ds.Tables("Ventas").Rows(10).Item("Valor")}, _
            {ds.Tables("Ventas").Rows(11).Item("Mes"), ds.Tables("Ventas").Rows(11).Item("Valor")}}

        chtAcumulados.ChartData = AcumuladosGrafico

        chtAcumulados.ShowLegend = True

        'Add a title and legend.
        With Me.chtAcumulados
            .Title.VtFont.Size = 12
            '.Title.Text = "Acumulados"
            .Legend.Location.LocationType = _
               MSChart20Lib.VtChLocationType.VtChLocationTypeBottom
            .Legend.Location.Visible = False
            '.chartType = MSChart20Lib.VtChChartType.VtChChartType3dBar
            .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
            '.SeriesType = MSChart20Lib.VtChSeriesType.VtChSeriesType2dPie
            .Enabled = False

        End With

        'Add titles to the axes.
        With Me.chtAcumulados.Plot
            '.WidthToHeightRatio = 100
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
            .View3d.Elevation = 0
            .View3d.Rotation = 90

            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

            '.Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).Pen.Width = 20
            '.Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).ValueScale.Auto = True
            '.PlotBase.BaseHeight = 200

            'MsgBox(.PlotBase.BaseHeight())
            '.UniformAxis = True

            '.Wall.Width = 1500

        End With

        'chtAcumulados.ALL

        'Set custom colors for the bars.
        With Me.chtAcumulados.Plot
            'Yellow for Company A
            ' -1 selects all the datapoints.
            .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 50, 50)
            .SeriesCollection(1).SeriesMarker.Auto = True

            '.Projection = MSChart20Lib.VtProjectionType.VtProjectionTypePerspective

            '.SeriesCollection(1).DataPoints(0).Brush.FillColor.Set(250, 250, 250)

            'Purple for Company B
            '.SeriesCollection(2).DataPoints(-1).Brush.FillColor.Set(200, 50, 200)
        End With


        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

End Class
