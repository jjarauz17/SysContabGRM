Imports MSChart20Lib

Public Class frmAcumulados
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAcumulados = Nothing

    Public Shared Function Instance() As frmAcumulados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAcumulados()
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
    Friend WithEvents dgAcumulados As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    '' Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents nudAnio As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.dgAcumulados = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.nudAnio = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        CType(Me.dgAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAcumulados
        '
        Me.dgAcumulados.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgAcumulados.BackColor = System.Drawing.Color.Gainsboro
        Me.dgAcumulados.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgAcumulados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgAcumulados.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgAcumulados.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAcumulados.CaptionForeColor = System.Drawing.Color.Black
        Me.dgAcumulados.DataMember = ""
        Me.dgAcumulados.FlatMode = True
        Me.dgAcumulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAcumulados.ForeColor = System.Drawing.Color.Black
        Me.dgAcumulados.GridLineColor = System.Drawing.Color.Silver
        Me.dgAcumulados.HeaderBackColor = System.Drawing.Color.Black
        Me.dgAcumulados.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAcumulados.HeaderForeColor = System.Drawing.Color.White
        Me.dgAcumulados.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgAcumulados.Location = New System.Drawing.Point(16, 43)
        Me.dgAcumulados.Name = "dgAcumulados"
        Me.dgAcumulados.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgAcumulados.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgAcumulados.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgAcumulados.SelectionForeColor = System.Drawing.Color.White
        Me.dgAcumulados.Size = New System.Drawing.Size(360, 410)
        Me.dgAcumulados.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(976, 34)
        Me.GroupBox3.TabIndex = 114
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
        Me.Label1.Text = "ACUMULADOS DEL CLIENTE:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(200, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(776, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ChartControl1)
        Me.GroupBox2.Controls.Add(Me.nudAnio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmdEstadoCuenta)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.dgAcumulados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(976, 500)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        '
        'nudAnio
        '
        Me.nudAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnio.Location = New System.Drawing.Point(72, 17)
        Me.nudAnio.Maximum = New Decimal(New Integer() {9998, 0, 0, 0})
        Me.nudAnio.Minimum = New Decimal(New Integer() {1753, 0, 0, 0})
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Size = New System.Drawing.Size(72, 20)
        Me.nudAnio.TabIndex = 145
        Me.nudAnio.Value = New Decimal(New Integer() {1753, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Año:"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(16, 458)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(96, 35)
        Me.cmdEstadoCuenta.TabIndex = 119
        Me.cmdEstadoCuenta.Text = "Estado de &Cuenta"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(136, 458)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 35)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'ChartControl1
        '
        Me.ChartControl1.Location = New System.Drawing.Point(382, 43)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisible = True
        'SideBySideBarSeriesLabel1.OverlappingOptionsTypeName = "OverlappingOptions"
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.Size = New System.Drawing.Size(588, 410)
        Me.ChartControl1.TabIndex = 147
        '
        'frmAcumulados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1024, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmAcumulados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As DataSet
    Dim ds1 As DataSet
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable

    Dim i As Integer

    Private Sub frmAcumulados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Acumulados As New VB.SysContab.AcumuladosDB()
        Dim Detalles As New VB.SysContab.ClientesDetails()

        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()

        'If TipoAcumulado = "C" Then
        Detalles = VB.SysContab.ClientesDB.GetDetails(RegistroCliente)

        dgAcumulados.CaptionText = "Acumulados de Clientes"
        Me.Text = "Acumulados de Clientes"
        etDescripcion.Text = Detalles.Nombre.ToUpper

        nudAnio.Value = CDate(r.Fecha).Year

        If TipoAcumulado = "P" Then
            DetallesProveedor = VB.SysContab.ProveedoresDB.GetDetails(RegistroCliente)
            dgAcumulados.CaptionText = "Acumulados de Proveedores"
            Me.Text = "Acumulados de Proveedores"
            etDescripcion.Text = DetallesProveedor.Nombre.ToUpper

        End If

        ''r.CambiarEstilo(Me)

        ds = Clientes.Acumulados(RegistroCliente, nudAnio.Value)
        ds1 = Clientes.AcumuladosDevoluciones(RegistroCliente, nudAnio.Value)

        dgAcumulados.ReadOnly = True
        MakeDataSet()
        Me.dgAcumulados.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        DatosGrafico()

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, "frmFacturacionCliente")

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub DatosGrafico()
        Try
            ChartControl1.DataSource = ds.Tables("Facturas_Ventas").DefaultView '' ObtieneDatos("JAR_GetAcumuladosProductos '" & Registro & "','P'," & EmpresaActual)
            ChartControl1.SeriesDataMember = "Mes"
            ChartControl1.SeriesTemplate.ArgumentDataMember = "Numero"
            ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Monto"})
            ChartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try



        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "C"}, _
            {ds.Tables("Facturas_Ventas").Rows(0).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(0).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(0).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(1).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(1).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(1).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(2).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(2).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(2).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(3).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(3).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(3).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(4).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(4).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(4).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(5).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(5).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(5).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(6).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(6).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(6).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(7).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(7).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(7).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(8).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(8).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(8).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(9).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(9).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(9).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(10).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(10).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(10).Item("Monto"))}, _
            {ds.Tables("Facturas_Ventas").Rows(11).Item("Mes"), CDbl(ds.Tables("Facturas_Ventas").Rows(11).Item("Monto")) - CDbl(ds1.Tables("Facturas_Ventas").Rows(11).Item("Monto"))}}

        'chtAcumulados.ChartData = AcumuladosGrafico

        'chtAcumulados.ShowLegend = True

        ''Add a title and legend.
        'With Me.chtAcumulados
        '    .Title.VtFont.Size = 12
        '    .Title.Text = "Acumulados"
        '    .Legend.Location.LocationType = _
        '       MSChart20Lib.VtChLocationType.VtChLocationTypeBottom
        '    .Legend.Location.Visible = False
        '    .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
        '    .Enabled = False

        'End With

        ''Add titles to the axes.
        'With Me.chtAcumulados.Plot
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
        '    .View3d.Elevation = 0
        '    .View3d.Rotation = 90

        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

        'End With

        ''Set custom colors for the bars.
        'With Me.chtAcumulados.Plot
        '    'Yellow for Company A
        '    ' -1 selects all the datapoints.
        '    .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 50, 50)
        '    .SeriesCollection(1).SeriesMarker.Auto = True
        'End With
    End Sub

    Private Sub frmAcumulados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'RegistroCliente = "Vacio"
        Dim f As frmAgregarCliente = f.Instance
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        Dim f As frmEstadoCuenta = frmEstadoCuenta.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        'RegistroCliente = Registro

        'Dim f As frmEstadoCuenta1 = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()

    End Sub

    Private Sub nudAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAnio.ValueChanged
        If RegistroCliente = Nothing Or RegistroCliente = "Vacio" Then
            Exit Sub
        Else
            If nudAnio.Value = 1753 Then
                Exit Sub
            End If
            ds = Clientes.Acumulados(RegistroCliente, nudAnio.Value)
            ds1 = Clientes.AcumuladosDevoluciones(RegistroCliente, nudAnio.Value)
            MakeDataSet()
            Me.dgAcumulados.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
            DatosGrafico()
        End If
    End Sub

    Private Sub nudAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudAnio.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 13 Then
            If nudAnio.Text = "" Then
                MsgBox("Ingrese el año", MsgBoxStyle.Information)
                Exit Sub
            End If

            If RegistroCliente = Nothing Or RegistroCliente = "Vacio" Then
                Exit Sub
            Else
                ds = Clientes.Acumulados(RegistroCliente, nudAnio.Value)
                ds1 = Clientes.AcumuladosDevoluciones(RegistroCliente, nudAnio.Value)
                MakeDataSet()
                Me.dgAcumulados.SetDataBinding(myDataSet, "Item")
                AddCustomDataTableStyle()

                DatosGrafico()
            End If
        End If
    End Sub

    Private Sub nudAnio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudAnio.Leave
        If nudAnio.Text = "" Then
            MsgBox("Ingrese el año", MsgBoxStyle.Information)
            nudAnio.Focus()
            Exit Sub
        End If

        If RegistroCliente = Nothing Or RegistroCliente = "Vacio" Then
            Exit Sub
        Else
            ds = Clientes.Acumulados(RegistroCliente, nudAnio.Value)
            ds1 = Clientes.AcumuladosDevoluciones(RegistroCliente, nudAnio.Value)
            MakeDataSet()
            Me.dgAcumulados.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()

            DatosGrafico()
        End If
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        Dim cMes As DataColumn
        cMes = New DataColumn("Mes")
        tCust.Columns.Add(cMes)

        Dim cMonto As DataColumn
        cMonto = New DataColumn("Monto")
        tCust.Columns.Add(cMonto)

        'Dim cNumero As DataColumn
        'cNumero = New DataColumn("Numero")
        'tCust.Columns.Add(cNumero)

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow

        For i = 0 To ds.Tables("Facturas_Ventas").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)
            tCust.Rows(i)("Mes") = ds.Tables("Facturas_Ventas").Rows(i).Item("Mes")
            tCust.Rows(i)("Monto") = CDbl(CDbl(ds.Tables("Facturas_Ventas").Rows(i).Item("Monto")).ToString(Round) - CDbl(ds1.Tables("Facturas_Ventas").Rows(i).Item("Monto")).ToString(Round)).ToString(Round)
            'tCust.Rows(i)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")

        Next
    End Sub

    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        Dim Mes As New DataGridTextBoxColumn()
        Mes.MappingName = "Mes"
        Mes.HeaderText = "Mes"
        Mes.ReadOnly = True
        Mes.Alignment = HorizontalAlignment.Left
        Mes.Width = 120
        Mes.NullText = 0

        ts1.GridColumnStyles.Add(Mes)
        colCount = (colCount + 1)

        Dim Monto As New DataGridTextBoxColumn()
        Monto.MappingName = "Monto"
        Monto.HeaderText = "Monto"
        Monto.ReadOnly = True
        Monto.Alignment = HorizontalAlignment.Right
        Monto.Width = 100
        Monto.NullText = 0

        ts1.GridColumnStyles.Add(Monto)
        colCount = (colCount + 1)

        'Dim Numero As New DataGridTextBoxColumn()
        'Numero.MappingName = "Numero"
        'Numero.HeaderText = "Numero"
        'Numero.ReadOnly = True
        'Numero.Alignment = HorizontalAlignment.Left
        'Numero.Width = 0
        'Numero.NullText = ""

        'ts1.GridColumnStyles.Add(Numero)
        'colCount = (colCount + 1)

        'ts1.AllowSorting = False
        'ts1.HeaderFont = Me.dgAcumulados.HeaderFont
        'ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        'ts1.PreferredRowHeight = 25

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = dgAcumulados.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        Me.dgAcumulados.TableStyles.Clear()
        Me.dgAcumulados.TableStyles.Add(ts1)

    End Sub

End Class
