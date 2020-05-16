Public Class FrmEstadoResultadosCrossTab
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sel3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents sel1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmdabrir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcargare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdnewgrap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdabrir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardare = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcargare = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdnewgrap = New DevExpress.XtraEditors.SimpleButton()
        Me.sel3 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.sel1 = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdabrir)
        Me.GroupBox1.Controls.Add(Me.cmdguardar)
        Me.GroupBox1.Controls.Add(Me.cmdGrafico)
        Me.GroupBox1.Controls.Add(Me.cmdguardare)
        Me.GroupBox1.Controls.Add(Me.cmdcargare)
        Me.GroupBox1.Controls.Add(Me.cmdnewgrap)
        Me.GroupBox1.Controls.Add(Me.sel3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox1.Controls.Add(Me.sel1)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(8, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 112)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        '
        'cmdabrir
        '
        Me.cmdabrir.Location = New System.Drawing.Point(568, 60)
        Me.cmdabrir.Name = "cmdabrir"
        Me.cmdabrir.Size = New System.Drawing.Size(104, 25)
        Me.cmdabrir.TabIndex = 155
        Me.cmdabrir.Text = "Cargar Datos"
        '
        'cmdguardar
        '
        Me.cmdguardar.Location = New System.Drawing.Point(568, 26)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(104, 25)
        Me.cmdguardar.TabIndex = 154
        Me.cmdguardar.Text = "Guardar Datos"
        '
        'cmdGrafico
        '
        Me.cmdGrafico.Location = New System.Drawing.Point(680, 26)
        Me.cmdGrafico.Name = "cmdGrafico"
        Me.cmdGrafico.Size = New System.Drawing.Size(88, 26)
        Me.cmdGrafico.TabIndex = 151
        Me.cmdGrafico.Text = "Ver Grafico"
        '
        'cmdguardare
        '
        Me.cmdguardare.Location = New System.Drawing.Point(448, 26)
        Me.cmdguardare.Name = "cmdguardare"
        Me.cmdguardare.Size = New System.Drawing.Size(112, 25)
        Me.cmdguardare.TabIndex = 153
        Me.cmdguardare.Text = "Guardar Esquema"
        '
        'cmdcargare
        '
        Me.cmdcargare.Location = New System.Drawing.Point(448, 60)
        Me.cmdcargare.Name = "cmdcargare"
        Me.cmdcargare.Size = New System.Drawing.Size(112, 25)
        Me.cmdcargare.TabIndex = 156
        Me.cmdcargare.Text = "Cargar Esquema"
        '
        'cmdnewgrap
        '
        Me.cmdnewgrap.Location = New System.Drawing.Point(680, 60)
        Me.cmdnewgrap.Name = "cmdnewgrap"
        Me.cmdnewgrap.Size = New System.Drawing.Size(88, 26)
        Me.cmdnewgrap.TabIndex = 152
        Me.cmdnewgrap.Text = "Nuevo Grafico"
        '
        'sel3
        '
        Me.sel3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sel3.Location = New System.Drawing.Point(80, 48)
        Me.sel3.Name = "sel3"
        Me.sel3.Size = New System.Drawing.Size(136, 21)
        Me.sel3.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.Location = New System.Drawing.Point(80, 78)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(136, 21)
        Me.cbMonedaCambio.TabIndex = 148
        '
        'sel1
        '
        Me.sel1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.sel1.Location = New System.Drawing.Point(80, 17)
        Me.sel1.Name = "sel1"
        Me.sel1.Size = New System.Drawing.Size(136, 21)
        Me.sel1.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(32, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "Desde:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdexportar)
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(800, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox6.TabIndex = 153
        Me.GroupBox6.TabStop = False
        '
        'cmdexportar
        '
        Me.cmdexportar.Appearance.Options.UseTextOptions = True
        Me.cmdexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdexportar.Location = New System.Drawing.Point(102, 39)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(92, 34)
        Me.cmdexportar.TabIndex = 3
        Me.cmdexportar.Text = "Exportar / Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 60)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 26)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 26)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Buscar"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.FieldName = "SC02"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.FieldName = "SC01"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Width = 200
        '
        'PivotGrid
        '
        Me.PivotGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGrid.Appearance.HeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.PivotGrid.Appearance.HeaderArea.Options.UseBackColor = True
        Me.PivotGrid.Appearance.HeaderFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.PivotGrid.Appearance.HeaderFilterButton.Options.UseBackColor = True
        Me.PivotGrid.Appearance.HeaderFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.PivotGrid.Appearance.HeaderFilterButtonActive.Options.UseBackColor = True
        Me.PivotGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField12, Me.PivotGridField10, Me.PivotGridField11})
        Me.PivotGrid.Location = New System.Drawing.Point(8, 121)
        Me.PivotGrid.Name = "PivotGrid"
        Me.PivotGrid.OptionsView.ShowCustomTotalsForSingleValues = True
        Me.PivotGrid.OptionsView.ShowTotalsForSingleValues = True
        Me.PivotGrid.Size = New System.Drawing.Size(990, 200)
        Me.PivotGrid.TabIndex = 152
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.FieldName = "Mayor"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Width = 150
        '
        'PivotGridField4
        '
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.FieldName = "SC03"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.FieldName = "SC04"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.AreaIndex = 3
        Me.PivotGridField6.FieldName = "Dia"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 4
        Me.PivotGridField7.FieldName = "Quarter"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 5
        Me.PivotGridField8.CellFormat.FormatString = "{0:n}"
        Me.PivotGridField8.FieldName = "Debitos"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 6
        Me.PivotGridField9.CellFormat.FormatString = "{0:n}"
        Me.PivotGridField9.FieldName = "Creditos"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField12.AreaIndex = 0
        Me.PivotGridField12.CellFormat.FormatString = "{0:n}"
        Me.PivotGridField12.FieldName = "Movimiento"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField10.AreaIndex = 0
        Me.PivotGridField10.FieldName = "Anno"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField11.AreaIndex = 1
        Me.PivotGridField11.FieldName = "Mes"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'Guardar
        '
        Me.Guardar.DefaultExt = "*.xml"
        Me.Guardar.Filter = "(*.xml)|*.xml"
        '
        'FrmEstadoResultadosCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1014, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PivotGrid)
        Me.Name = "FrmEstadoResultadosCrossTab"
        Me.Text = "Estado de Resultados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmEstadoResultadosCrossTab = Nothing

    Public Shared Function Instance() As FrmEstadoResultadosCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmEstadoResultadosCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim r As New VB.SysContab.Rutinas


    Public Function MyDataset() As DataSet
        Dim Empresa As String = EmpresaActual
        Dim Dsa As New DataSet
        Dim Ti, Tf As DateTime
        Dsa = VB.SysContab.ReportesCrossTabDB.LibroBalanzaCrostab(sel1.Value, sel3.Value, cbMonedaCambio.SelectedValue, Empresa, "R")
        Return Dsa
    End Function

    Private Sub FrmEstadoResultadosCrossTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   'r.CambiarEstilo(Me)

        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        'sel1.Value = "01/" & Now.Month & "/" & Now.Year
        'sel3.Value = CDate(Date.DaysInMonth(Now.Year, Now.Month) & "/" & Now.Month & "/" & Now.Year)
        sel1.Value = New DateTime(Now.Year, Now.Month, 1)
        sel3.Value = New DateTime(Now.Year, Now.Month, Date.DaysInMonth(Now.Year, Now.Month))

        'If MyDataset().Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-1)), 1) '"01/" & Month(Now.AddMonths(-1)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If

        'If MyDataset().Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-2)), 1) '"01/" & Month(Now.AddMonths(-2)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If

        'If MyDataset().Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-3)), 1) '"01/" & Month(Now.AddMonths(-3)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Try
            ShowSplash()
            PivotGrid.DataSource = MyDataset().Tables(0)
            HideSplash()
        Catch ex As Exception
            HideSplash()
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PivotGrid.CellDoubleClick

        Dim Fecha, CompNo, PerID As String
        Dim Ds As New DataSet

        Dim i As Integer


        Dim form As New FrmDetalleContablesCrossTab
        form.Text = "Detalle de Estado de Resultado"
        form.StartPosition = FormStartPosition.CenterParent
        form.MonedaCambio = Me.cbMonedaCambio.SelectedValue

        form.Grid.Parent = form
        form.Grid.Dock = DockStyle.Fill
        form.Grid.DataSource = e.CreateDrillDownDataSource()

        form.Width = 1024
        form.Height = 400
        form.ShowDialog()
        form.Dispose()



    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        frmExportarImprimir.Mostrar(PivotGrid, Me.Text)
        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(PivotGrid)
    End Sub

    Private Sub cmdGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrafico.Click
        Dim forma As New frmgraficosxtra
        forma.Mostrar(frmgraficosxtra.TipoGrafico.EstadoResultado, PivotGrid.CreateSummaryDataSource, False, PivotGrid)
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        MyDataset.WriteXml(Guardar.FileName)
    End Sub


    Private Sub cmdguardare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardare.Click
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        PivotGrid.SaveLayoutToXml(Guardar.FileName)
    End Sub

    Private Sub cmdcargare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcargare.Click
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        PivotGrid.RestoreLayoutFromXml(Abrir.FileName)
        PivotGrid.Refresh()
    End Sub

    Private Sub cmdabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdabrir.Click
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        MyDataset.ReadXml(Abrir.FileName)
        PivotGrid.Refresh()
        PivotGrid.RefreshData()
    End Sub

    Private Sub cmdnewgrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewgrap.Click
        Dim forma As New frmgraficosxtra
        forma.Mostrar(frmgraficosxtra.TipoGrafico.BalanzaComprobacion, PivotGrid.CreateSummaryDataSource, True, PivotGrid)
    End Sub

   
   
    Private Sub PivotGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PivotGrid.Click

    End Sub
End Class
