Imports DevExpress.XtraCharts.Design
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts.Wizard

Public Class frmgraficosxtra
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grafico As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbplantilla As System.Windows.Forms.ComboBox
    Friend WithEvents cmdguardarplan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdabrirplan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optbarra As System.Windows.Forms.RadioButton
    Friend WithEvents optpastel As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbfiltro As System.Windows.Forms.ComboBox
    Friend WithEvents optArea As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitulo As System.Windows.Forms.TextBox
    Friend WithEvents cmdactualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkvalores As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbdetalle As System.Windows.Forms.ComboBox
    Friend WithEvents chkseries As System.Windows.Forms.CheckBox
    Friend WithEvents cmbtipografico As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtangulo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.grafico = New DevExpress.XtraCharts.ChartControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbplantilla = New System.Windows.Forms.ComboBox()
        Me.cmdguardarplan = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdabrirplan = New DevExpress.XtraEditors.SimpleButton()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.cmdprint = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbtipografico = New System.Windows.Forms.ComboBox()
        Me.optpastel = New System.Windows.Forms.RadioButton()
        Me.optbarra = New System.Windows.Forms.RadioButton()
        Me.optArea = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbfiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.cmdactualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkvalores = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbdetalle = New System.Windows.Forms.ComboBox()
        Me.chkseries = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtangulo = New System.Windows.Forms.TextBox()
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grafico
        '
        Me.grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grafico.Location = New System.Drawing.Point(0, 138)
        Me.grafico.Name = "grafico"
        Me.grafico.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.grafico.Size = New System.Drawing.Size(1028, 529)
        Me.grafico.TabIndex = 11
        ChartTitle1.Text = ""
        Me.grafico.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plantillas"
        '
        'cmbplantilla
        '
        Me.cmbplantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbplantilla.Location = New System.Drawing.Point(134, 19)
        Me.cmbplantilla.Name = "cmbplantilla"
        Me.cmbplantilla.Size = New System.Drawing.Size(298, 24)
        Me.cmbplantilla.TabIndex = 0
        '
        'cmdguardarplan
        '
        Me.cmdguardarplan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdguardarplan.Location = New System.Drawing.Point(769, 19)
        Me.cmdguardarplan.Name = "cmdguardarplan"
        Me.cmdguardarplan.Size = New System.Drawing.Size(134, 29)
        Me.cmdguardarplan.TabIndex = 7
        Me.cmdguardarplan.Text = "Guardar Esquema"
        '
        'cmdabrirplan
        '
        Me.cmdabrirplan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdabrirplan.Location = New System.Drawing.Point(913, 19)
        Me.cmdabrirplan.Name = "cmdabrirplan"
        Me.cmdabrirplan.Size = New System.Drawing.Size(105, 29)
        Me.cmdabrirplan.TabIndex = 8
        Me.cmdabrirplan.Text = "Abrir Esquema"
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.lyt"
        Me.Abrir.Filter = "(*.lyt)|*.lyt"
        '
        'Guardar
        '
        Me.Guardar.DefaultExt = "*.lyt"
        Me.Guardar.Filter = "(*.lyt)|*.lyt"
        '
        'cmdprint
        '
        Me.cmdprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdprint.Location = New System.Drawing.Point(913, 59)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(105, 28)
        Me.cmdprint.TabIndex = 10
        Me.cmdprint.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbtipografico)
        Me.GroupBox1.Controls.Add(Me.optpastel)
        Me.GroupBox1.Controls.Add(Me.optbarra)
        Me.GroupBox1.Controls.Add(Me.optArea)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(442, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 79)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Grafico"
        '
        'cmbtipografico
        '
        Me.cmbtipografico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipografico.Location = New System.Drawing.Point(29, 30)
        Me.cmbtipografico.Name = "cmbtipografico"
        Me.cmbtipografico.Size = New System.Drawing.Size(249, 25)
        Me.cmbtipografico.TabIndex = 3
        '
        'optpastel
        '
        Me.optpastel.Enabled = False
        Me.optpastel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.optpastel.Location = New System.Drawing.Point(115, 30)
        Me.optpastel.Name = "optpastel"
        Me.optpastel.Size = New System.Drawing.Size(67, 29)
        Me.optpastel.TabIndex = 1
        Me.optpastel.Text = "Pastel"
        Me.optpastel.Visible = False
        '
        'optbarra
        '
        Me.optbarra.Checked = True
        Me.optbarra.Enabled = False
        Me.optbarra.Location = New System.Drawing.Point(38, 30)
        Me.optbarra.Name = "optbarra"
        Me.optbarra.Size = New System.Drawing.Size(77, 29)
        Me.optbarra.TabIndex = 0
        Me.optbarra.TabStop = True
        Me.optbarra.Text = "Barras"
        Me.optbarra.Visible = False
        '
        'optArea
        '
        Me.optArea.Enabled = False
        Me.optArea.Location = New System.Drawing.Point(192, 30)
        Me.optArea.Name = "optArea"
        Me.optArea.Size = New System.Drawing.Size(58, 29)
        Me.optArea.TabIndex = 1
        Me.optArea.Text = "Area"
        Me.optArea.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Filtrar Serie por"
        '
        'cmbfiltro
        '
        Me.cmbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfiltro.Location = New System.Drawing.Point(134, 59)
        Me.cmbfiltro.Name = "cmbfiltro"
        Me.cmbfiltro.Size = New System.Drawing.Size(298, 24)
        Me.cmbfiltro.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Titulo del grafico"
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(134, 98)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(298, 23)
        Me.txttitulo.TabIndex = 2
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdactualizar.Location = New System.Drawing.Point(769, 59)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(134, 28)
        Me.cmdactualizar.TabIndex = 9
        Me.cmdactualizar.Text = "&Actualizar"
        '
        'chkvalores
        '
        Me.chkvalores.Checked = True
        Me.chkvalores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkvalores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkvalores.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkvalores.Location = New System.Drawing.Point(931, 98)
        Me.chkvalores.Name = "chkvalores"
        Me.chkvalores.Size = New System.Drawing.Size(96, 30)
        Me.chkvalores.TabIndex = 6
        Me.chkvalores.Text = "Etiquetas"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(442, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Detalle por"
        Me.Label4.Visible = False
        '
        'cmbdetalle
        '
        Me.cmbdetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdetalle.Location = New System.Drawing.Point(528, 98)
        Me.cmbdetalle.Name = "cmbdetalle"
        Me.cmbdetalle.Size = New System.Drawing.Size(115, 24)
        Me.cmbdetalle.TabIndex = 4
        Me.cmbdetalle.Visible = False
        '
        'chkseries
        '
        Me.chkseries.Checked = True
        Me.chkseries.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkseries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkseries.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkseries.Location = New System.Drawing.Point(835, 98)
        Me.chkseries.Name = "chkseries"
        Me.chkseries.Size = New System.Drawing.Size(77, 30)
        Me.chkseries.TabIndex = 5
        Me.chkseries.Text = "Series"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(672, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Angulo"
        Me.Label5.Visible = False
        '
        'txtangulo
        '
        Me.txtangulo.Location = New System.Drawing.Point(730, 98)
        Me.txtangulo.Name = "txtangulo"
        Me.txtangulo.Size = New System.Drawing.Size(67, 23)
        Me.txtangulo.TabIndex = 14
        '
        'frmgraficosxtra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1028, 667)
        Me.Controls.Add(Me.txtangulo)
        Me.Controls.Add(Me.chkseries)
        Me.Controls.Add(Me.cmbdetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkvalores)
        Me.Controls.Add(Me.cmdactualizar)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.cmbfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdprint)
        Me.Controls.Add(Me.cmbplantilla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grafico)
        Me.Controls.Add(Me.cmdguardarplan)
        Me.Controls.Add(Me.cmdabrirplan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.MinimizeBox = False
        Me.Name = "frmgraficosxtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graficos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Enum TipoGrafico
        BalanzaComprobacion
        EstadoSituacion
        EstadoResultado
        FlujoCaja
        CuentasXPagar
        CuentasXCobrar
        Compras
        Ventas
        Acumulados
    End Enum

#Region "Variables"

    Private Nuevo As Boolean
    Private Origen As TipoGrafico
    Private Grid As DevExpress.XtraPivotGrid.PivotGridControl
    Private Datas As PivotSummaryDataSource
    Private Tempo As PivotSummaryDataSource
    Private Temp As Boolean
    Private k As Integer = 0
    Private Base As String = vbNullString
    Private Vista As DevExpress.XtraCharts.ViewType
    Private CampoFiltro As String
    Private Campos() As String = {"Creditos", "Debitos", "Anno", "Mayor", "Creditos_Sum", "Debitos_Sum", "Mes", "Movimiento", "Movimiento_Sum", "Trimestre", "Saldo", "tipo_flujocaja", "saldo_Sum", "Quarter", "Rubro", "Proveedor", "Cliente", "Total", "Total_Sum", "Cantidad", "Cantidad_Sum", "Nombre", "Articulo", "Vendedor"}
    Private DT As New DataSet

#End Region

    Private Sub frmgraficosxtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Nuevo Then
            Dim Graf As New ChartWizard(grafico)
            Graf.ShowDialog()
        End If

        cmdguardarplan.Visible = Nuevo
        cmdabrirplan.Visible = Nuevo
        cmbplantilla.Visible = Not Nuevo
        Label1.Visible = Not Nuevo
        cmbtipografico.Items.Add("Grafico de Barra")
        cmbtipografico.Items.Add("Grafico de Area")
        cmbtipografico.Items.Add("Grafico de Pastel")
        cmbtipografico.Items.Add("Grafico de Barra Apilada")
        cmbtipografico.Items.Add("Grafico de Barra 3D")
        cmbdetalle.Items.Add("Año")
        cmbdetalle.Items.Add("Trimestre")
        cmbdetalle.Items.Add("Mes")
        Select Case Origen
            Case TipoGrafico.Compras, TipoGrafico.CuentasXCobrar, TipoGrafico.CuentasXPagar, TipoGrafico.Ventas
                cmbdetalle.Items.Add("Dia")
        End Select
    End Sub

    Private Sub CrearNoNegativos(ByVal Aplica As Boolean)
        Dim Camp As String
        Dim j As Integer
        Dim i As Integer
        On Error Resume Next
        Grid.RefreshData()
        Datas = Nothing
        Datas = Grid.CreateSummaryDataSource()
        DT.Tables.Add("Datos")
        DT.Tables("Datos").Columns.Clear()
        For j = 0 To Campos.GetUpperBound(0)
            Camp = Datas.GetValue(0, Campos.GetValue(j))
            If Not Camp Is Nothing Then
                DT.Tables("Datos").Columns.Add(Campos.GetValue(j), System.Type.GetType(IIf(Mid(Campos.GetValue(j), Len(Campos.GetValue(j)) - 2) = "Sum", "System.Double", "System.String")))
            Else
                Err.Clear()
            End If
            Camp = Nothing
        Next
        Dim Fila As DataRow
        For i = 0 To Datas.RowCount - 1
            With DT
                Fila = .Tables("Datos").NewRow
                For j = 0 To DT.Tables("Datos").Columns.Count - 1
                    If IsNumeric(Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption)) Then
                        If Not Aplica Then
                            If CDbl(Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption)) < 0 Then
                                Fila.Item(DT.Tables("Datos").Columns(j).Caption) = CDbl(Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption)) * -1
                            Else
                                Fila.Item(DT.Tables("Datos").Columns(j).Caption) = CDbl(Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption))
                            End If
                        Else
                            Fila.Item(DT.Tables("Datos").Columns(j).Caption) = CDbl(Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption)) * -1
                        End If
                    Else
                        Fila.Item(DT.Tables("Datos").Columns(j).Caption) = Datas.GetValue(i, DT.Tables("Datos").Columns(j).Caption)
                    End If
                Next
                .Tables("Datos").Rows.Add(Fila)
            End With
        Next
        grafico.DataSource = DT.Tables("Datos")
        grafico.Refresh()
    End Sub

#Region "Definicion de Graficos"
    Public Sub Mostrar(ByVal Tipo As TipoGrafico, ByVal Source As PivotSummaryDataSource, ByVal N As Boolean, ByRef PivotGrid1 As DevExpress.XtraPivotGrid.PivotGridControl)
        Grid = PivotGrid1
        Nuevo = N
        Datas = Source
        Tempo = Source
        grafico.DataSource = Source
        Origen = Tipo
        If Not Nuevo Then
            Select Case Origen
                Case TipoGrafico.BalanzaComprobacion
                    With cmbplantilla.Items
                        .Add("Cuentas Mayor por Año(Debitos)")
                        .Add("Cuentas Mayor por Meses(Debitos)")
                        .Add("Cuentas Mayor por Año(Creditos)")
                        .Add("Cuentas Mayor por Meses(Creditos)")
                        .Add("Comprativo Creditos - Debitos por Mayor")
                        .Add("Comprativo Creditos - Debitos por Año")
                        .Add("Saldos por cuenta Mayor")
                    End With
                Case TipoGrafico.EstadoResultado
                    With cmbplantilla.Items
                        .Add("Movimientos de los Rubros por Trimestre")
                        .Add("Movimientos de los Rubros por Año")
                        .Add("Comprativo Creditos - Debitos por Mayor")
                        .Add("Comprativo Creditos - Debitos por Año")
                        .Add("Saldos por cuenta Mayor")
                    End With
                Case TipoGrafico.EstadoSituacion
                    With cmbplantilla.Items
                        .Add("Movimientos de los Rubros por Trimestre")
                        .Add("Movimientos de los Rubros por Año")
                        .Add("Movimientos de los Rubros por Mayor")
                        .Add("Comprativo Creditos - Debitos por Mayor")
                        .Add("Comprativo Creditos - Debitos por Rubro")
                        .Add("Saldos por cuenta Mayor")
                        .Add("Saldos por Rubro")
                    End With
                Case TipoGrafico.FlujoCaja
                    With cmbplantilla.Items
                        .Add("Saldos de los Rubros por Trimestre")
                        .Add("Saldos de los Rubros por Año")
                        .Add("Saldos de los Rubros por Mayor")
                        .Add("Saldos por cuenta Mayor")
                        .Add("Saldos por Rubro")
                    End With
                Case TipoGrafico.CuentasXPagar
                    With cmbplantilla.Items
                        .Add("Creditos por Proveedor")
                        .Add("Debitos por Proveedor")
                        .Add("Comparativo Creditos - Debitos por Proveedor")
                    End With
                Case TipoGrafico.CuentasXCobrar
                    With cmbplantilla.Items
                        .Add("Creditos por Cliente")
                        .Add("Debitos por Cliente")
                        .Add("Comparativo Creditos - Debitos por Cliente")
                    End With
                Case TipoGrafico.Compras
                    With cmbplantilla.Items
                        .Add("Valor de Compra por Proveedor")
                        .Add("Cantidad de Compra por Proveedor")
                    End With
                Case TipoGrafico.Ventas
                    With cmbplantilla.Items
                        .Add("Ventas Totales por Cliente")
                        .Add("Ventas Totales por Articulo")
                        .Add("Ventas Totales por Vendedor")
                        .Add("Comparativo Cliente - Vendedor")
                    End With
            End Select
        End If
        Select Case Origen
            'Acumulados
            Case TipoGrafico.Acumulados
                'ocultar controles no usados
                Me.cmbplantilla.Enabled = False
                Me.cmbfiltro.Enabled = False
                Me.txttitulo.Enabled = False
                Me.cmdguardarplan.Enabled = False
                Me.cmdactualizar.Enabled = False
                Me.cmdabrirplan.Enabled = False
                'Me.cmdprint.Enabled = False
                grafico.SeriesTemplate.ValueDataMembers.Clear()
                grafico.DataSource = Datas

                Dim Serie1 As New DevExpress.XtraCharts.Series("Debe", DevExpress.XtraCharts.ViewType.Bar)
                Serie1.ArgumentDataMember = "Orden"
                Serie1.ValueDataMembers.AddRange(New String() {"Debe_Sum"})
                Serie1.LegendText = "Debe"
                Dim Serie2 As New DevExpress.XtraCharts.Series("Haber", DevExpress.XtraCharts.ViewType.Bar)
                Serie2.ArgumentDataMember = "Orden"
                Serie2.ValueDataMembers.AddRange(New String() {"Haber_Sum"})
                Serie2.LegendText = "Haber"
                grafico.Series.Add(Serie1)
                grafico.Series.Add(Serie2)
                Dim diag As DevExpress.XtraCharts.XYDiagram = CType(Me.grafico.Diagram, DevExpress.XtraCharts.XYDiagram)
                diag.AxisX.Label.Angle = 90
                grafico.Refresh()
            Case Else
                Me.cmbplantilla.Enabled = True
                Me.cmbfiltro.Enabled = True
                Me.txttitulo.Enabled = True
                Me.cmdguardarplan.Enabled = True
                Me.cmdactualizar.Enabled = True
                Me.cmdabrirplan.Enabled = True
                Me.cmdprint.Enabled = True

        End Select
        Me.ShowDialog()
    End Sub
#End Region

#Region "Seleccion de Graficos"
    Private Sub cmbplantilla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbplantilla.SelectedIndexChanged
        cmbfiltro.Items.Clear()
        Label4.Visible = False
        cmbdetalle.Visible = False
        grafico.Series.Clear()
        grafico.SeriesTemplate.DataFilters.Clear()
        grafico.SeriesTemplate.ArgumentDataMember = ""
        grafico.SeriesDataMember = ""
        For i As Integer = 0 To Grid.Fields.Count - 1
            Grid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Next
        Try
            Select Case Origen
                'Balanza-------------------------------------
                Case TipoGrafico.BalanzaComprobacion
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Anno"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Mes"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                CrearNoNegativos(True)
                                .SeriesDataMember = "Anno"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 3
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                CrearNoNegativos(True)
                                .SeriesDataMember = "Mes"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 4
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Mayor"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Mayor"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Mayor")
                        Case 5
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Anno"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Anno"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Mayor")
                        Case 6
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Mayor"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Mayor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                    End Select
                    'Flujo de Caja----------------------------------------------
                Case TipoGrafico.FlujoCaja
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Trimestre").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("tipo_flujocaja").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Trimestre"
                                .SeriesTemplate.ArgumentDataMember = "tipo_flujocaja"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"saldo_Sum"})
                            End With
                            Filtrar("tipo_flujocaja")
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("tipo_flujocaja").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Anno"
                                .SeriesTemplate.ArgumentDataMember = "tipo_flujocaja"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"saldo_Sum"})
                            End With
                            Filtrar("tipo_flujocaja")
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("tipo_flujocaja").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "tipo_flujocaja"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"saldo_Sum"})
                            End With
                            Filtrar("tipo_flujocaja")
                        Case 3
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Mayor"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"saldo_Sum"})
                            End With
                            Filtrar("Mayor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 4
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            With grafico
                                Grid.Fields("saldo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("tipo_flujocaja").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "tipo_flujocaja"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"saldo_Sum"})
                            End With
                            Filtrar("tipo_flujocaja")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                    End Select
                    'Estado de Resultados -------------------------------------------
                Case TipoGrafico.EstadoResultado
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Anno"
                                .SeriesTemplate.ArgumentDataMember = "Mayor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Mayor")
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Mayor"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Mayor"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Mayor")
                        Case 3
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Anno"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Anno"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Anno")
                        Case 4
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Mayor"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Mayor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                    End Select
                    'Estado de Situacion -----------------------------------------------
                Case TipoGrafico.EstadoSituacion
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Rubro"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Rubro")
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Anno"
                                .SeriesTemplate.ArgumentDataMember = "Rubro"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Rubro")
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Mayor"
                                .SeriesTemplate.ArgumentDataMember = "Rubro"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Rubro")
                        Case 3
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Mayor"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Mayor"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Mayor")
                        Case 4
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Rubro"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Rubro"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Rubro")
                        Case 5
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Mayor"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Mayor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 6
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            With grafico
                                Grid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                                Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                                Grid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                                .SeriesDataMember = "Rubro"
                                .SeriesTemplate.ArgumentDataMember = "Mes"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Movimiento_Sum"})
                            End With
                            Filtrar("Rubro")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                    End Select
                    'Cuentas por pagar ------------------------------------------------------
                Case TipoGrafico.CuentasXPagar
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Proveedor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            End With
                            Filtrar("Proveedor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Proveedor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            End With
                            Filtrar("Proveedor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Proveedor"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Proveedor"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Proveedor")
                    End Select
                    'Cuentas por Cobrar --------------------------------------------------
                Case TipoGrafico.CuentasXCobrar
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Cliente"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            End With
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                            Filtrar("Cliente")
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Cliente"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            End With
                            Filtrar("Cliente")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Creditos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Debitos").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            CrearNoNegativos(False)
                            Dim Serie1 As New DevExpress.XtraCharts.Series("Creditos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie1.ArgumentDataMember = "Cliente"
                            Serie1.ValueDataMembers.AddRange(New String() {"Creditos_Sum"})
                            Serie1.LegendText = "Creditos"
                            Dim Serie2 As New DevExpress.XtraCharts.Series("Debitos", DevExpress.XtraCharts.ViewType.Bar)
                            Serie2.ArgumentDataMember = "Cliente"
                            Serie2.ValueDataMembers.AddRange(New String() {"Debitos_Sum"})
                            Serie2.LegendText = "Debitos"
                            grafico.Series.Add(Serie1)
                            grafico.Series.Add(Serie2)
                            Filtrar("Cliente")
                    End Select
                    'Compras -------------------------------------------------------------
                Case TipoGrafico.Compras
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Proveedor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total_Sum"})
                            End With
                            Filtrar("Proveedor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Quarter"
                                .SeriesTemplate.ArgumentDataMember = "Proveedor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad_Sum"})
                            End With
                            Filtrar("Proveedor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                    End Select
                    'Ventas ---------------------------------------------------------------------
                Case TipoGrafico.Ventas
                    Select Case cmbplantilla.SelectedIndex
                        Case 0
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Trimestre").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Trimestre"
                                .SeriesTemplate.ArgumentDataMember = "Nombre"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total_Sum"})
                            End With
                            Filtrar("Nombre")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 1
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Trimestre").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Articulo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Trimestre"
                                .SeriesTemplate.ArgumentDataMember = "Articulo"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total_Sum"})
                            End With
                            Filtrar("Articulo")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 2
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Trimestre").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Vendedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Trimestre"
                                .SeriesTemplate.ArgumentDataMember = "Vendedor"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total_Sum"})
                            End With
                            Filtrar("Vendedor")
                            Label4.Visible = True
                            cmbdetalle.Visible = True
                        Case 3
                            grafico.SeriesTemplate.ValueDataMembers.Clear()
                            grafico.DataSource = Datas
                            Grid.Fields("Vendedor").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                            Grid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
                            Grid.Fields("Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
                            With grafico
                                .SeriesDataMember = "Vendedor"
                                .SeriesTemplate.ArgumentDataMember = "Nombre"
                                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total_Sum"})
                            End With
                            Filtrar("Nombre")
                    End Select
            End Select
            Dim diag As DevExpress.XtraCharts.XYDiagram = CType(Me.grafico.Diagram, DevExpress.XtraCharts.XYDiagram)
            diag.AxisX.Label.Angle = 90
            grafico.Titles(0).Text = cmbplantilla.Text
            grafico.Refresh()
            chkvalores.Checked = True
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al mostrar el grafico, intente nuevamente")
            Me.Close()
        End Try
    End Sub
#End Region

#Region "Esquemas - Impresion"
    Private Sub cmdguardarplan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardarplan.Click
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        grafico.SaveToFile(Guardar.FileName)
        Grid.SaveLayoutToXml(Mid(Guardar.FileName, 1, Len(Guardar.FileName) - 4) & ".xml")
        grafico.Refresh()
    End Sub

    Private Sub cmdabrirplan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdabrirplan.Click
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        Try
            grafico.LoadFromFile(Abrir.FileName)
            Grid.RestoreLayoutFromXml(Mid(Abrir.FileName, 1, Len(Abrir.FileName) - 4) & ".xml")
            Grid.Refresh()
            grafico.DataSource = Grid.CreateSummaryDataSource()
            grafico.Refresh()
        Catch ex As Exception
            MsgBox("Error al cargar los datos. " & vbCrLf & "El esquema guardado no corresponde con los datos seleccionados")
        End Try
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        grafico.ShowPrintPreview(DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch)
    End Sub

    Private Sub optbarra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optbarra.CheckedChanged
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series.Item(i).ChangeView(DevExpress.XtraCharts.ViewType.Bar)
                grafico.Series.Item(i).PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
            Next i
        Else
            grafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            grafico.SeriesTemplate.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        End If
        grafico.Refresh()
    End Sub

    Private Sub optpastel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optpastel.CheckedChanged
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series.Item(i).ChangeView(DevExpress.XtraCharts.ViewType.Pie3D)
                grafico.Series.Item(i).PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
            Next i
        Else
            grafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie3D)
            grafico.SeriesTemplate.PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        End If
        grafico.Refresh()
    End Sub
#End Region

    Private Sub cmbfiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfiltro.SelectedIndexChanged
        Temp = True
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series(i).DataFilters.Clear()
                If cmbfiltro.SelectedIndex <> 0 Then grafico.Series(i).DataFilters.Add(CampoFiltro, "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, cmbfiltro.Text)
            Next
        Else
            grafico.SeriesTemplate.DataFilters.Clear()
            If cmbfiltro.SelectedIndex <> 0 Then grafico.SeriesTemplate.DataFilters.Add(CampoFiltro, "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, cmbfiltro.Text)
        End If
        grafico.Refresh()
    End Sub

    Private Sub cmbtipografico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipografico.SelectedIndexChanged
        If VerificaGrafico() Then Exit Sub
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series.Item(i).ChangeView(Vista)
                grafico.Series.Item(i).PointOptions.PointView = IIf(cmbtipografico.SelectedIndex = 2, DevExpress.XtraCharts.PointView.ArgumentAndValues, DevExpress.XtraCharts.PointView.Values)
                If cmbtipografico.SelectedIndex = 2 Then
                    Dim Eti As DevExpress.XtraCharts.PieSeriesLabel = CType(Me.grafico.Series.Item(i).Label, DevExpress.XtraCharts.PieSeriesLabel)
                    Eti.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
                End If
            Next i
        Else
            grafico.SeriesTemplate.ChangeView(Vista)
            grafico.SeriesTemplate.PointOptions.PointView = IIf(cmbtipografico.SelectedIndex = 2, DevExpress.XtraCharts.PointView.ArgumentAndValues, DevExpress.XtraCharts.PointView.Values)
            If cmbtipografico.SelectedIndex = 2 Then
                Dim Eti As DevExpress.XtraCharts.PieSeriesLabel = CType(Me.grafico.SeriesTemplate.Label, DevExpress.XtraCharts.PieSeriesLabel)
                Eti.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
            End If
        End If
        grafico.Refresh()
    End Sub

    Private Sub cmdactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdactualizar.Click
        grafico.Titles(0).Text = txttitulo.Text
        grafico.Refresh()
    End Sub

    Private Sub cmbdetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdetalle.SelectedIndexChanged
        Dim Valor As String
        For i As Integer = 0 To Grid.Fields.Count - 1
            If Grid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea Then Grid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Next
        Select Case Origen
            Case TipoGrafico.BalanzaComprobacion, TipoGrafico.EstadoResultado, TipoGrafico.EstadoSituacion, TipoGrafico.FlujoCaja
                Select Case cmbdetalle.SelectedIndex
                    Case 0 : Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesTemplate.ArgumentDataMember = "Anno"
                    Case 1
                        If Origen = TipoGrafico.FlujoCaja Then Valor = "Trimestre" Else Valor = "Quarter"
                        Grid.Fields(Valor).Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesTemplate.ArgumentDataMember = Valor
                    Case 2 : Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesTemplate.ArgumentDataMember = "Mes"
                End Select
            Case TipoGrafico.CuentasXCobrar, TipoGrafico.Compras, TipoGrafico.CuentasXPagar, TipoGrafico.Ventas
                Select Case cmbdetalle.SelectedIndex
                    Case 0
                        Grid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesDataMember = "Anno"
                    Case 1
                        If Origen = TipoGrafico.Ventas Then Valor = "Trimestre" Else Valor = "Quarter"
                        Grid.Fields(Valor).Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesDataMember = Valor
                    Case 2
                        Grid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesDataMember = "Mes"
                    Case 3
                        Grid.Fields("Dia").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                        grafico.SeriesDataMember = "Dia"

                End Select
        End Select
        grafico.Refresh()
        If VerificaGrafico() Then Exit Sub
    End Sub

#Region "Checks"
    Private Sub chkvalores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvalores.CheckedChanged
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series(i).Label.Visible = chkvalores.Checked
            Next
        Else
            grafico.SeriesTemplate.Label.Visible = chkvalores.Checked
        End If
        grafico.Refresh()
    End Sub

    Private Sub chkseries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkseries.CheckedChanged
        If grafico.Series.Count > 0 Then
            For i As Integer = 0 To grafico.Series.Count - 1
                grafico.Series(i).ShowInLegend = chkseries.Checked
            Next
        Else
            grafico.SeriesTemplate.ShowInLegend = chkseries.Checked
        End If
    End Sub

    Private Sub grafico_CustomDrawSeries(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles grafico.CustomDrawSeries
        If Temp Then
            k = 0
            Base = vbNullString
        End If
        If Base <> e.Series.Name Then k += 1
        Base = e.Series.Name
        Temp = False
    End Sub
#End Region

    Private Function VerificaGrafico() As Boolean
        Temp = True
        Select Case cmbtipografico.SelectedIndex
            Case 0 : Vista = DevExpress.XtraCharts.ViewType.Bar
            Case 1 : Vista = DevExpress.XtraCharts.ViewType.Area
            Case 2 : Vista = DevExpress.XtraCharts.ViewType.Pie3D
                If grafico.Series.Count > 1 Or k > 1 Then
                    MsgBox("Los datos seleccionados no aplican muy bien para este tipo de grafico" & vbCrLf & "Por favor seleccione otro")
                    Return True
                    Exit Function
                End If
            Case 3 : Vista = DevExpress.XtraCharts.ViewType.FullStackedBar
            Case 4 : Vista = DevExpress.XtraCharts.ViewType.ManhattanBar

                'Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D
                'XyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & _
                '"2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & _
                '"1"
                'XyDiagram3D1.AxisY.GridSpacingAuto = False
                'XyDiagram3D1.AxisY.GridSpacing = 100
                'grafico.Diagram = XyDiagram3D1
        End Select
        Return False
    End Function

    Private Sub Filtrar(ByVal Dato As String)
        cmbfiltro.Items.Add("Todas")
        For i As Integer = 0 To Datas.RowCount - 1
            If cmbfiltro.FindString(Datas.GetValue(i, Dato)) < 0 Then If (Datas.GetValue(i, Dato)) <> Nothing Then cmbfiltro.Items.Add(Datas.GetValue(i, Dato))
        Next
        CampoFiltro = Dato
    End Sub

End Class


