'Imports MSChart20Lib

Public Class frmAreasCCAcumulados
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAreasCCAcumulados = Nothing

    Public Shared Function Instance() As frmAreasCCAcumulados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAreasCCAcumulados()
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
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents dgAreasAcumulados As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAreasCCAcumulados))
        Me.dgAreasAcumulados = New System.Windows.Forms.DataGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudAnio = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.chtAcumulados = New AxMSChart20Lib.AxMSChart()
        Me.etCodigo = New System.Windows.Forms.Label()
        CType(Me.dgAreasAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAreasAcumulados
        '
        Me.dgAreasAcumulados.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgAreasAcumulados.BackColor = System.Drawing.Color.Gainsboro
        Me.dgAreasAcumulados.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgAreasAcumulados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgAreasAcumulados.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgAreasAcumulados.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAreasAcumulados.CaptionForeColor = System.Drawing.Color.Black
        Me.dgAreasAcumulados.DataMember = ""
        Me.dgAreasAcumulados.FlatMode = True
        Me.dgAreasAcumulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAreasAcumulados.ForeColor = System.Drawing.Color.Black
        Me.dgAreasAcumulados.GridLineColor = System.Drawing.Color.Silver
        Me.dgAreasAcumulados.HeaderBackColor = System.Drawing.Color.Black
        Me.dgAreasAcumulados.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAreasAcumulados.HeaderForeColor = System.Drawing.Color.White
        Me.dgAreasAcumulados.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgAreasAcumulados.Location = New System.Drawing.Point(16, 40)
        Me.dgAreasAcumulados.Name = "dgAreasAcumulados"
        Me.dgAreasAcumulados.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgAreasAcumulados.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgAreasAcumulados.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgAreasAcumulados.SelectionForeColor = System.Drawing.Color.White
        Me.dgAreasAcumulados.Size = New System.Drawing.Size(344, 384)
        Me.dgAreasAcumulados.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.etDescripcion})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 32)
        Me.GroupBox3.TabIndex = 114
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "ACUMULADOS DEL AREA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.etDescripcion.Location = New System.Drawing.Point(200, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(800, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.nudAnio, Me.Label2, Me.cmdEstadoCuenta, Me.cmdCancelar, Me.dgAreasAcumulados, Me.chtAcumulados, Me.etCodigo})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 488)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        '
        'nudAnio
        '
        Me.nudAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnio.Location = New System.Drawing.Point(72, 16)
        Me.nudAnio.Maximum = New Decimal(New Integer() {9998, 0, 0, 0})
        Me.nudAnio.Minimum = New Decimal(New Integer() {1753, 0, 0, 0})
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Size = New System.Drawing.Size(72, 20)
        Me.nudAnio.TabIndex = 145
        Me.nudAnio.Value = New Decimal(New Integer() {1753, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Año:"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(128, 432)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(96, 32)
        Me.cmdEstadoCuenta.TabIndex = 119
        Me.cmdEstadoCuenta.Text = "Estado de &Cuenta"
        Me.cmdEstadoCuenta.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 432)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 32)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'chtAcumulados
        '
        Me.chtAcumulados.ContainingControl = Me
        Me.chtAcumulados.DataSource = Nothing
        Me.chtAcumulados.Location = New System.Drawing.Point(344, 8)
        Me.chtAcumulados.Name = "chtAcumulados"
        Me.chtAcumulados.OcxState = CType(resources.GetObject("chtAcumulados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.chtAcumulados.Size = New System.Drawing.Size(648, 472)
        Me.chtAcumulados.TabIndex = 118
        '
        'etCodigo
        '
        Me.etCodigo.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.White
        Me.etCodigo.Location = New System.Drawing.Point(168, 16)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(80, 20)
        Me.etCodigo.TabIndex = 116
        Me.etCodigo.Text = "Codigo"
        Me.etCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etCodigo.Visible = False
        '
        'frmAreasCCAcumulados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox3})
        Me.Name = "frmAreasCCAcumulados"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgAreasAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As DataSet
    Dim ds1 As DataSet
    'Dim Clientes As New VB.SysContab.ClientesDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable

    Dim i As Integer

    Public GruposCC As New VB.SysContab.GruposCCDB()

    Private Sub frmAreasCCAcumulados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Acumulados As New VB.SysContab.AcumuladosDB()
        'Dim Detalles As New VB.SysContab.ClientesDetails()

        'Dim Proveedores As New VB.SysContab.ProveedoresDB()
        'Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()

        ''If TipoAcumulado = "C" Then
        'Detalles = VB.SysContab.ClientesDB.GetDetails(RegistroCliente)

        'dgAcumulados.CaptionText = "Acumulados de Clientes"
        'Me.Text = "Acumulados de Clientes"
        'etDescripcion.Text = Detalles.Nombre.ToUpper

        'nudAnio.Value = CDate(r.Fecha).Year

        'If TipoAcumulado = "P" Then
        '    DetallesProveedor = VB.SysContab.ProveedoresDB.GetDetails(RegistroCliente)
        '    dgAcumulados.CaptionText = "Acumulados de Proveedores"
        '    Me.Text = "Acumulados de Proveedores"
        '    etDescripcion.Text = DetallesProveedor.Nombre.ToUpper

        'End If

        ''r.CambiarEstilo(Me)

        'ds = Clientes.Acumulados(RegistroCliente, nudAnio.Value)
        'ds1 = Clientes.AcumuladosDevoluciones(RegistroCliente, nudAnio.Value)

        'dgAcumulados.ReadOnly = True
        'MakeDataSet()
        'Me.dgAcumulados.SetDataBinding(myDataSet, "Item")
        'AddCustomDataTableStyle()

        r.FormularioColor(Me)
        Me.Label1.BackColor = Color.FromArgb(102, 153, 153)
        Me.etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        nudAnio.Value = CDate(r.Fecha).Year
        ds = GruposCC.AreasAcumulados(Me.etCodigo.Text, Me.nudAnio.Value)
        etDescripcion.Text = GruposCC.AreasDetalles(Me.etCodigo.Text).Tables("GruposCC").Rows(0).Item("Area_Nombre").ToString
        Me.dgAreasAcumulados.DataSource = ds.Tables("GruposCC").DefaultView 'Acumulados.GetList(Registro).Tables("Acumulados").DefaultView
        Tabla = ds.Tables("GruposCC")
        r.FormatGenerico(Me.dgAreasAcumulados, Tabla)

        'Me.dgAreasAcumulados.Refresh()
        Me.dgAreasAcumulados.AllowSorting = False
        Me.dgAreasAcumulados.ReadOnly = True
        Me.dgAreasAcumulados.CaptionVisible = False

        DatosGrafico()

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub DatosGrafico()

        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "C"}, _
            {ds.Tables("GruposCC").Rows(0).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(0).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(1).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(1).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(2).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(2).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(3).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(3).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(4).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(4).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(5).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(5).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(6).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(6).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(7).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(7).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(8).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(8).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(9).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(9).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(10).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(10).Item("Monto"))}, _
            {ds.Tables("GruposCC").Rows(11).Item("Mes"), CDbl(ds.Tables("GruposCC").Rows(11).Item("Monto"))}}

        chtAcumulados.ChartData = AcumuladosGrafico

        chtAcumulados.ShowLegend = True

        'Add a title and legend.
        With Me.chtAcumulados
            .Title.VtFont.Size = 12
            .Title.Text = "Acumulados"
            .Legend.Location.LocationType = _
               MSChart20Lib.VtChLocationType.VtChLocationTypeBottom
            .Legend.Location.Visible = False
            .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
            .Enabled = False

        End With

        'Add titles to the axes.
        With Me.chtAcumulados.Plot
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
            .View3d.Elevation = 0
            .View3d.Rotation = 90

            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

        End With

        'Set custom colors for the bars.
        With Me.chtAcumulados.Plot
            'Yellow for Company A
            ' -1 selects all the datapoints.
            .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 50, 50)
            .SeriesCollection(1).SeriesMarker.Auto = True
        End With
    End Sub

    Private Sub frmAcumulados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'RegistroCliente = "Vacio"
        Dim f As frmAgregarCliente = frmAgregarCliente.Instance
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        'RegistroCliente = Registro

        'Dim f As frmEstadoCuenta = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()

    End Sub

    Private Sub nudAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAnio.ValueChanged
        ds = GruposCC.AreasAcumulados(Me.etCodigo.Text, Me.nudAnio.Value)
        Me.dgAreasAcumulados.DataSource = ds.Tables("GruposCC").DefaultView
        DatosGrafico()
    End Sub

    Private Sub nudAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudAnio.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 13 Then
            If nudAnio.Text = "" Then
                MsgBox("Ingrese el año", MsgBoxStyle.Information)
                Exit Sub
            End If

            ds = GruposCC.AreasAcumulados(Me.etCodigo.Text, Me.nudAnio.Value)
            Me.dgAreasAcumulados.DataSource = ds.Tables("GruposCC").DefaultView
            DatosGrafico()
        End If
    End Sub

    Private Sub nudAnio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudAnio.Leave
        If nudAnio.Text = "" Then
            MsgBox("Ingrese el año", MsgBoxStyle.Information)
            nudAnio.Focus()
            Exit Sub
        End If

        ds = GruposCC.AreasAcumulados(Me.etCodigo.Text, Me.nudAnio.Value)
        Me.dgAreasAcumulados.DataSource = ds.Tables("GruposCC").DefaultView
        DatosGrafico()
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

        For i = 0 To ds.Tables("GruposCC").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)
            tCust.Rows(i)("Mes") = ds.Tables("GruposCC").Rows(i).Item("Mes")
            tCust.Rows(i)("Monto") = CDbl(CDbl(ds.Tables("GruposCC").Rows(i).Item("Monto")).ToString(Round) - CDbl(ds1.Tables("GruposCC").Rows(i).Item("Monto")).ToString(Round)).ToString(Round)
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
        ts1.HeaderFont = dgAreasAcumulados.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        Me.dgAreasAcumulados.TableStyles.Clear()
        Me.dgAreasAcumulados.TableStyles.Add(ts1)

    End Sub

End Class
