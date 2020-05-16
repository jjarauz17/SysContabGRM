Public Class FrmFlujoCajaCrossTab
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
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcargare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdnewgrap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sel3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents sel1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkmuestra As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkmuestra = New System.Windows.Forms.CheckBox()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PivotGridField6
        '
        Me.PivotGridField6.AreaIndex = 0
        Me.PivotGridField6.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.FieldName = "Dia"
        Me.PivotGridField6.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField6.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField6.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.PivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField12, Me.PivotGridField10, Me.PivotGridField11})
        Me.PivotGrid.Location = New System.Drawing.Point(8, 121)
        Me.PivotGrid.Name = "PivotGrid"
        Me.PivotGrid.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.PivotGrid.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGrid.OptionsView.ShowColumnTotals = False
        Me.PivotGrid.OptionsView.ShowCustomTotalsForSingleValues = True
        Me.PivotGrid.Size = New System.Drawing.Size(1000, 190)
        Me.PivotGrid.TabIndex = 155
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Rubro"
        Me.PivotGridField1.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.FieldName = "tipo_flujocaja"
        Me.PivotGridField1.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Tag = "Rubro"
        Me.PivotGridField1.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.Width = 150
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 2
        Me.PivotGridField2.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.FieldName = "Mayor"
        Me.PivotGridField2.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField2.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.Width = 200
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 1
        Me.PivotGridField7.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.FieldName = "Trimestre"
        Me.PivotGridField7.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField7.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField7.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField7.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField12.AreaIndex = 0
        Me.PivotGridField12.CellFormat.FormatString = "{0:n}"
        Me.PivotGridField12.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.FieldName = "saldo"
        Me.PivotGridField12.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField12.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField12.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField12.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField12.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField10.AreaIndex = 0
        Me.PivotGridField10.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.FieldName = "Anno"
        Me.PivotGridField10.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField10.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.Name = "PivotGridField10"
        Me.PivotGridField10.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField10.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField10.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField10.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField10.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField11.AreaIndex = 1
        Me.PivotGridField11.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField11.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField11.FieldName = "Mes"
        Me.PivotGridField11.GrandTotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField11.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField11.Name = "PivotGridField11"
        Me.PivotGridField11.TotalCellFormat.FormatString = "{0:N}"
        Me.PivotGridField11.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField11.TotalValueFormat.FormatString = "{0:N}"
        Me.PivotGridField11.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField11.ValueFormat.FormatString = "{0:N}"
        Me.PivotGridField11.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdexportar)
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(792, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 112)
        Me.GroupBox6.TabIndex = 156
        Me.GroupBox6.TabStop = False
        '
        'cmdexportar
        '
        Me.cmdexportar.Location = New System.Drawing.Point(102, 39)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(108, 34)
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
        'cmdguardar
        '
        Me.cmdguardar.Location = New System.Drawing.Point(560, 26)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(104, 25)
        Me.cmdguardar.TabIndex = 154
        Me.cmdguardar.Text = "Guardar Datos"
        '
        'cmdGrafico
        '
        Me.cmdGrafico.Location = New System.Drawing.Point(672, 26)
        Me.cmdGrafico.Name = "cmdGrafico"
        Me.cmdGrafico.Size = New System.Drawing.Size(88, 26)
        Me.cmdGrafico.TabIndex = 151
        Me.cmdGrafico.Text = "Ver Grafico"
        '
        'cmdguardare
        '
        Me.cmdguardare.Location = New System.Drawing.Point(440, 26)
        Me.cmdguardare.Name = "cmdguardare"
        Me.cmdguardare.Size = New System.Drawing.Size(112, 25)
        Me.cmdguardare.TabIndex = 153
        Me.cmdguardare.Text = "Guardar Esquema"
        '
        'cmdcargare
        '
        Me.cmdcargare.Location = New System.Drawing.Point(440, 60)
        Me.cmdcargare.Name = "cmdcargare"
        Me.cmdcargare.Size = New System.Drawing.Size(112, 25)
        Me.cmdcargare.TabIndex = 156
        Me.cmdcargare.Text = "Cargar Esquema"
        '
        'cmdnewgrap
        '
        Me.cmdnewgrap.Location = New System.Drawing.Point(672, 60)
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
        Me.sel3.Value = New Date(2007, 4, 22, 15, 49, 25, 689)
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
        Me.cbMonedaCambio.ItemHeight = 13
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
        Me.sel1.Value = New Date(2007, 4, 22, 15, 49, 25, 705)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkmuestra)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 112)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        '
        'chkmuestra
        '
        Me.chkmuestra.Checked = True
        Me.chkmuestra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkmuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkmuestra.Location = New System.Drawing.Point(264, 26)
        Me.chkmuestra.Name = "chkmuestra"
        Me.chkmuestra.Size = New System.Drawing.Size(120, 34)
        Me.chkmuestra.TabIndex = 157
        Me.chkmuestra.Text = "Calcular Efectivo Final Periodo"
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
        'FrmFlujoCajaCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 323)
        Me.Controls.Add(Me.PivotGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "FrmFlujoCajaCrossTab"
        Me.Text = "Flujo de Caja CrossTab"
        CType(Me.PivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmFlujoCajaCrossTab = Nothing
    Private Muestra As Boolean = False
    Private Valor As Double

    Public Shared Function Instance() As FrmFlujoCajaCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmFlujoCajaCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function


    Dim r As New VB.SysContab.Rutinas


    Public Function MyDataset() As DataSet
        Dim Empresa As String = EmpresaActual
        Dim Dsa As New DataSet
        'Dim Ti, Tf As DateTime
        Dsa = VB.SysContab.ReportesCrossTabDB.Imprimir_FlujoCajaCrosstab(sel1.Value, sel3.Value, cbMonedaCambio.SelectedValue, Empresa)
        Return Dsa
    End Function


    Private Sub FrmFlujoCajaCrossTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VB.SysContab.Rutinas.CambiarEstilo(Me)

        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        cbMonedaCambio.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
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

        Dim form As New FrmDetalleFlujoCajaCrossTab
        form.Text = "Detalle de Flujo de Caja"
        form.StartPosition = FormStartPosition.CenterParent

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
        forma.Mostrar(frmgraficosxtra.TipoGrafico.FlujoCaja, PivotGrid.CreateSummaryDataSource, False, PivotGrid)
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

    Private Sub cmdabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub PivotGrid_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PivotGrid.CustomCellDisplayText
        If Muestra Then
            If Not PivotGrid.Fields("tipo_flujocaja").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea Then Exit Sub
            On Error Resume Next
            'MsgBox(Valor.ToString)
            If (e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.Value And e.RowField.Tag = "Rubro" And e.ColumnIndex > 0 And e.RowIndex = 4) Then
                'MsgBox(e.Data.Cells.GetCellInfo(e.ColumnIndex - 1, e.RowIndex + 1).DisplayText & " Col: " & e.ColumnIndex & " Row:" & e.RowIndex)
                If CDbl(IIf(e.DisplayText = "", 0, e.DisplayText)) = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex - 1, e.RowIndex + 1).DisplayText) Then GoTo Here
                e.DisplayText = Format(Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex - 1, e.RowIndex + 1).DisplayText), "#,#0.00").ToString()

                'MsgBox(Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex).Value))
            End If
Here:




            If e.RowValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
                On Error Resume Next
                Dim value1 As Double = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex - 5).DisplayText)
                Dim value2 As Double = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex - 4).DisplayText)
                Dim value3 As Double = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex - 3).DisplayText)
                Dim value4 As Double = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex - 2).DisplayText)
                Dim value5 As Double = Convert.ToDouble(e.Data.Cells.GetCellInfo(e.ColumnIndex, e.RowIndex - 1).DisplayText)
                'Dim value1 As Double = Convert.ToDouble(e.Data.GetCellValue(e.ColumnIndex + 1, e.RowIndex - 5, 0))
                'Dim value2 As Double = Convert.ToDouble(e.Data.GetCellValue(e.ColumnIndex + 1, e.RowIndex - 4, 0))
                'D'im value3 As Double = Convert.ToDouble(e.Data.GetCellValue(e.ColumnIndex + 1, e.RowIndex - 3, 0))
                'Dim value4 As Double = Convert.ToDouble(e.Data.GetCellValue(e.ColumnIndex + 1, e.RowIndex - 2, 0))
                'Dim value5 As Double = Convert.ToDouble(e.Data.GetCellValue(e.ColumnIndex + 1, e.RowIndex - 1, 0))
                e.DisplayText = Format(CDbl((value5 - ((value1 + value3) - value2))), "#,#0.00").ToString()
                '                Valor = value5 - ((value1 + value3) - value2)
                '               Exit Sub
            End If
        End If
    End Sub

    Private Sub chkmuestra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmuestra.CheckedChanged
        If chkmuestra.Checked Then
            Muestra = True
            PivotGrid.CollapseAllRows()
        Else
            Muestra = False
            PivotGrid.Refresh()
        End If
    End Sub

End Class


