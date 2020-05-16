Imports DevExpress.XtraCharts.Series

Public Class frmAcumuladosProductos
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmAcumuladosProductos = Nothing

    Public Shared Function Instance() As frmAcumuladosProductos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAcumuladosProductos()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents dgAcumuladosProductos As System.Windows.Forms.DataGrid
    Friend WithEvents gbGrafico As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOcultarGrafico As DevExpress.XtraEditors.SimpleButton
    '' Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Label2 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgAcumuladosProductos = New System.Windows.Forms.DataGrid()
        Me.cmdOcultarGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.gbGrafico = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAcumuladosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.gbGrafico.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PivotGridControl1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgAcumuladosProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5})
        Me.PivotGridControl1.Location = New System.Drawing.Point(54, 59)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(690, 309)
        Me.PivotGridControl1.TabIndex = 129
        Me.PivotGridControl1.Visible = False
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.FieldName = "Mes"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Width = 250
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.FieldName = "Entrada"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField3.FieldName = "Valor_Entrada"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "Salida"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 3
        Me.PivotGridField5.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "Valor_Salida"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(240, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 17)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "                   ENTRADAS                                            SALIDAS"
        '
        'dgAcumuladosProductos
        '
        Me.dgAcumuladosProductos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgAcumuladosProductos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgAcumuladosProductos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgAcumuladosProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgAcumuladosProductos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgAcumuladosProductos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAcumuladosProductos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgAcumuladosProductos.DataMember = ""
        Me.dgAcumuladosProductos.FlatMode = True
        Me.dgAcumuladosProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAcumuladosProductos.ForeColor = System.Drawing.Color.Black
        Me.dgAcumuladosProductos.GridLineColor = System.Drawing.Color.Silver
        Me.dgAcumuladosProductos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgAcumuladosProductos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAcumuladosProductos.HeaderForeColor = System.Drawing.Color.White
        Me.dgAcumuladosProductos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgAcumuladosProductos.Location = New System.Drawing.Point(40, 20)
        Me.dgAcumuladosProductos.Name = "dgAcumuladosProductos"
        Me.dgAcumuladosProductos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgAcumuladosProductos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgAcumuladosProductos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgAcumuladosProductos.SelectionForeColor = System.Drawing.Color.White
        Me.dgAcumuladosProductos.Size = New System.Drawing.Size(704, 375)
        Me.dgAcumuladosProductos.TabIndex = 119
        '
        'cmdOcultarGrafico
        '
        Me.cmdOcultarGrafico.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOcultarGrafico.Appearance.Options.UseFont = True
        Me.cmdOcultarGrafico.Location = New System.Drawing.Point(403, 483)
        Me.cmdOcultarGrafico.Name = "cmdOcultarGrafico"
        Me.cmdOcultarGrafico.Size = New System.Drawing.Size(104, 26)
        Me.cmdOcultarGrafico.TabIndex = 120
        Me.cmdOcultarGrafico.Text = "Ocultar Gráfico"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(584, 483)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdGrafico
        '
        Me.cmdGrafico.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrafico.Appearance.Options.UseFont = True
        Me.cmdGrafico.Location = New System.Drawing.Point(267, 483)
        Me.cmdGrafico.Name = "cmdGrafico"
        Me.cmdGrafico.Size = New System.Drawing.Size(72, 26)
        Me.cmdGrafico.TabIndex = 20
        Me.cmdGrafico.Text = "Gráfico"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(64, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(872, 34)
        Me.GroupBox3.TabIndex = 120
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
        Me.Label1.Text = "ACUMULADOS POR PRODUTO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(200, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(672, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbGrafico
        '
        Me.gbGrafico.Controls.Add(Me.ChartControl1)
        Me.gbGrafico.Location = New System.Drawing.Point(64, 43)
        Me.gbGrafico.Name = "gbGrafico"
        Me.gbGrafico.Size = New System.Drawing.Size(872, 434)
        Me.gbGrafico.TabIndex = 120
        Me.gbGrafico.TabStop = False
        Me.gbGrafico.Visible = False
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(6, 11)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.Size = New System.Drawing.Size(860, 408)
        Me.ChartControl1.TabIndex = 0
        '
        'frmAcumuladosProductos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(952, 544)
        Me.Controls.Add(Me.cmdOcultarGrafico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbGrafico)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdGrafico)
        Me.Name = "frmAcumuladosProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAcumuladosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.gbGrafico.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As DataSet

    Private Sub frmAcumuladosProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Producto As New VB.SysContab.ArticulosDB()
        Dim Detalles As New VB.SysContab.ArticulosDetails()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable

        Detalles = Producto.GetDetails(Registro, "P")
        dgAcumuladosProductos.CaptionText = "Acumulados por Producto"
        Me.Text = "Acumulados por Producto"
        etDescripcion.Text = Detalles.Nombre.ToUpper

        'r.CambiarEstilo(Me)

        ds = Producto.GetAcumulados(Registro, "P")

        ds.Tables("Ventas").DefaultView.AllowDelete = False
        ds.Tables("Ventas").DefaultView.AllowNew = False
        ds.Tables("Ventas").DefaultView.AllowEdit = False

        'dgTasaCambio.DataSource = dsTasaCambio.Tables("TASA_CAMBIO").DefaultView

        dgAcumuladosProductos.DataSource = ds.Tables("Ventas").DefaultView 'Acumulados.GetList(Registro).Tables("Acumulados").DefaultView
        Tabla = ds.Tables("Ventas")

        r.FormatGenerico(dgAcumuladosProductos, Tabla)
        Grafico()

        dgAcumuladosProductos.Refresh()
        Me.Refresh()
    End Sub

    Sub Grafico()
        Try
            ''PivotGridControl1.Visible = T
            ''PivotGridControl1.DataSource = ObtieneDatos("JAR_GetAcumuladosProductos '" & Registro & "','P'," & EmpresaActual)
            ''PivotGridControl1.se

            ChartControl1.DataSource = ObtieneDatos("JAR_GetAcumuladosProductos '" & Registro & "','P'," & EmpresaActual) ''Me.PivotGridControl1.CreateSummaryDataSource ''
            Dim Serie1 As New DevExpress.XtraCharts.Series("Valor_Entrada", DevExpress.XtraCharts.ViewType.Bar)
            Serie1.ValueDataMembers.AddRange(New String() {"Valor_Entrada"})
            Serie1.LegendText = "Valor_Entrada"
            Serie1.ArgumentDataMember = "Mes"

            Dim Serie2 As New DevExpress.XtraCharts.Series("Entrada", DevExpress.XtraCharts.ViewType.Bar)
            Serie2.ValueDataMembers.AddRange(New String() {"Entrada"})
            Serie2.LegendText = "Cantidad_Entrada"
            Serie2.ArgumentDataMember = "Mes"

            Dim Serie3 As New DevExpress.XtraCharts.Series("Valor_Salida", DevExpress.XtraCharts.ViewType.Bar)
            Serie3.ValueDataMembers.AddRange(New String() {"Valor_Salida"})
            Serie3.LegendText = "Valor_Salida"
            Serie3.ArgumentDataMember = "Mes"

            Dim Serie4 As New DevExpress.XtraCharts.Series("Salida", DevExpress.XtraCharts.ViewType.Bar)
            Serie4.ValueDataMembers.AddRange(New String() {"Salida"})
            Serie4.LegendText = "Cantidad_Salida"
            Serie4.ArgumentDataMember = "Mes"

            ChartControl1.Series.Add(Serie1)
            ChartControl1.Series.Add(Serie2)
            ChartControl1.Series.Add(Serie3)
            ChartControl1.Series.Add(Serie4)

            '' ChartControl1.SeriesDataMember = "Series"
            'ChartControl1.SeriesTemplate.ArgumentDataMember = "Mes"
            'ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            ''ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Valor_Entrada", "Entrada", "Valor_Salida", "Salida"})
            ChartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub cmdGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrafico.Click
        gbGrafico.Visible = True
        'GroupBox2.Visible = False
        GroupBox1.Visible = False
        'GroupBox3.Visible = False
        'dgAcumuladosProductos.Visible = False

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

        ''chtAcumulados.Visible = True

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

        'Dim AcumuladosGrafico(,) As Object = New Object(,) _
        '    {{"CP", "Unidades Salidas", "Entradas", "Salidas", "Unidades Salidas"}, _
        '    {"ENERO", ds.Tables("Ventas").Rows(0).Item("Entrada"), ds.Tables("Ventas").Rows(0).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(0).Item("Valor"), ds.Tables("Ventas").Rows(0).Item("Unidades")}, _
        '    {"FEBRERO", ds.Tables("Ventas").Rows(1).Item("Entrada"), ds.Tables("Ventas").Rows(1).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(1).Item("Valor"), ds.Tables("Ventas").Rows(1).Item("Unidades")}, _
        '    {"MARZO", ds.Tables("Ventas").Rows(2).Item("Entrada"), ds.Tables("Ventas").Rows(2).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(2).Item("Valor"), ds.Tables("Ventas").Rows(2).Item("Unidades")}, _
        '    {"ABRIL", ds.Tables("Ventas").Rows(3).Item("Entrada"), ds.Tables("Ventas").Rows(3).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(3).Item("Valor"), ds.Tables("Ventas").Rows(3).Item("Unidades")}, _
        '    {"MAYO", ds.Tables("Ventas").Rows(4).Item("Entrada"), ds.Tables("Ventas").Rows(4).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(4).Item("Valor"), ds.Tables("Ventas").Rows(4).Item("Unidades")}, _
        '    {"JUNIO", ds.Tables("Ventas").Rows(5).Item("Entrada"), ds.Tables("Ventas").Rows(5).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(5).Item("Valor"), ds.Tables("Ventas").Rows(5).Item("Unidades")}, _
        '    {"JULIO", ds.Tables("Ventas").Rows(6).Item("Entrada"), ds.Tables("Ventas").Rows(6).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(6).Item("Valor"), ds.Tables("Ventas").Rows(6).Item("Unidades")}, _
        '    {"AGOSTO", ds.Tables("Ventas").Rows(7).Item("Entrada"), ds.Tables("Ventas").Rows(7).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(7).Item("Valor"), ds.Tables("Ventas").Rows(7).Item("Unidades")}, _
        '    {"SEPTIEMBRE", ds.Tables("Ventas").Rows(8).Item("Entrada"), ds.Tables("Ventas").Rows(8).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(8).Item("Valor"), ds.Tables("Ventas").Rows(8).Item("Unidades")}, _
        '    {"OCTUBRE", ds.Tables("Ventas").Rows(9).Item("Entrada"), ds.Tables("Ventas").Rows(9).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(9).Item("Valor"), ds.Tables("Ventas").Rows(9).Item("Unidades")}, _
        '    {"NOVIEMBRE", ds.Tables("Ventas").Rows(10).Item("Entrada"), ds.Tables("Ventas").Rows(10).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(10).Item("Valor"), ds.Tables("Ventas").Rows(10).Item("Unidades")}, _
        '    {"DICIEMBRE", ds.Tables("Ventas").Rows(11).Item("Entrada"), ds.Tables("Ventas").Rows(11).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(11).Item("Valor"), ds.Tables("Ventas").Rows(11).Item("Unidades")}}

        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "Entradas", "Salidas"}, _
            {"ENERO", ds.Tables("Ventas").Rows(0).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(0).Item("Valor")}, _
            {"FEBRERO", ds.Tables("Ventas").Rows(1).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(1).Item("Valor")}, _
            {"MARZO", ds.Tables("Ventas").Rows(2).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(2).Item("Valor")}, _
            {"ABRIL", ds.Tables("Ventas").Rows(3).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(3).Item("Valor")}, _
            {"MAYO", ds.Tables("Ventas").Rows(4).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(4).Item("Valor")}, _
            {"JUNIO", ds.Tables("Ventas").Rows(5).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(5).Item("Valor")}, _
            {"JULIO", ds.Tables("Ventas").Rows(6).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(6).Item("Valor")}, _
            {"AGOSTO", ds.Tables("Ventas").Rows(7).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(7).Item("Valor")}, _
            {"SEPTIEMBRE", ds.Tables("Ventas").Rows(8).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(8).Item("Valor")}, _
            {"OCTUBRE", ds.Tables("Ventas").Rows(9).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(9).Item("Valor")}, _
            {"NOVIEMBRE", ds.Tables("Ventas").Rows(10).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(10).Item("Valor")}, _
            {"DICIEMBRE", ds.Tables("Ventas").Rows(11).Item("Valor_Entrada"), ds.Tables("Ventas").Rows(11).Item("Valor")}}

        'ds.Tables("Ventas")

        'chtAcumulados.ChartData = AcumuladosGrafico

        'chtAcumulados.ShowLegend = True

        ''Add a title and legend.
        'With Me.chtAcumulados
        '    '.Title.VtFont.Size = 8
        '    '.Title.Text = "Acumulados de la Cuenta: " & etDescripcion.Text
        '    .Legend.Location.LocationType = _
        '       MSChart20Lib.VtChLocationType.VtChLocationTypeRight
        '    .Legend.Location.Visible = True
        '    '.chartType = MSChart20Lib.VtChChartType.VtChChartType3dBar
        '    .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
        '    '.SeriesType = MSChart20Lib.VtChSeriesType.VtChSeriesType2dPie
        '    .Enabled = False
        '    .ShowLegend = True

        'End With

        ''Add titles to the axes.
        'With Me.chtAcumulados.Plot
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
        '    '.View3d.Elevation = 0
        '    '.View3d.Rotation = 90

        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
        '    .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

        '    .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 0, 0)

        '    .SeriesCollection(2).DataPoints(-1).Brush.FillColor.Set(0, 150, 0)

        '    '.SeriesCollection(3).DataPoints(-1).Brush.FillColor.Set(0, 0, 150)

        'End With
    End Sub

    Private Sub cmdOcultarGrafico_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOcultarGrafico.Click
        gbGrafico.Visible = False
        GroupBox1.Visible = True
        'GroupBox3.Visible = True
        'dgAcumuladosProductos.Visible = True

    End Sub

End Class
