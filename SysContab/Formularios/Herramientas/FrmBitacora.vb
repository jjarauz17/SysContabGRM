Public Class FrmBitacora
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdejecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdgrafico As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmdejecutar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdgrafico = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Appearance.Header.BackColor = System.Drawing.Color.Teal
        Me.PivotGridField3.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField3.Appearance.Header.Options.UseBackColor = True
        Me.PivotGridField3.Appearance.Header.Options.UseFont = True
        Me.PivotGridField3.Appearance.Header.Options.UseTextOptions = True
        Me.PivotGridField3.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField3.Appearance.Value.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.PivotGridField3.Appearance.Value.Options.UseBackColor = True
        Me.PivotGridField3.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField3.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField3.Appearance.ValueTotal.Options.UseTextOptions = True
        Me.PivotGridField3.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Dia Actual"
        Me.PivotGridField3.FieldName = "Hoy"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.Width = 70
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseBackColor = True
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.Field = Me.PivotGridField3
        PivotGridStyleFormatCondition1.FieldName = "PivotGridField3"
        Me.PivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 32)
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = True
        Me.PivotGridControl1.LookAndFeel.UseWindowsXPTheme = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowDrag = False
        Me.PivotGridControl1.OptionsCustomization.AllowExpand = False
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.OptionsCustomization.AllowSort = False
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl1.OptionsView.ShowColumnTotals = False
        Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl1.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl1.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(648, 368)
        Me.PivotGridControl1.TabIndex = 0
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Nombre"
        Me.PivotGridField1.FieldName = "Nombre"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField2.Appearance.Header.Options.UseFont = True
        Me.PivotGridField2.Appearance.Header.Options.UseTextOptions = True
        Me.PivotGridField2.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Evento"
        Me.PivotGridField2.FieldName = "Evento"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.PivotGridField4.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField4.Appearance.Header.Options.UseBackColor = True
        Me.PivotGridField4.Appearance.Header.Options.UseFont = True
        Me.PivotGridField4.Appearance.Header.Options.UseTextOptions = True
        Me.PivotGridField4.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField4.Appearance.Value.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(64, Byte))
        Me.PivotGridField4.Appearance.Value.Options.UseBackColor = True
        Me.PivotGridField4.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField4.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField4.Appearance.ValueTotal.Options.UseTextOptions = True
        Me.PivotGridField4.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Dia Anterior"
        Me.PivotGridField4.FieldName = "Ayer"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 70
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.PivotGridField5.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridField5.Appearance.Header.Options.UseBackColor = True
        Me.PivotGridField5.Appearance.Header.Options.UseFont = True
        Me.PivotGridField5.Appearance.Header.Options.UseTextOptions = True
        Me.PivotGridField5.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField5.Appearance.Value.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.PivotGridField5.Appearance.Value.Options.UseBackColor = True
        Me.PivotGridField5.Appearance.Value.Options.UseTextOptions = True
        Me.PivotGridField5.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField5.Appearance.ValueTotal.Options.UseTextOptions = True
        Me.PivotGridField5.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.Caption = "Diferencia"
        Me.PivotGridField5.FieldName = "Diferencia"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Width = 70
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Location = New System.Drawing.Point(560, 416)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 1
        Me.cmdsalir.Text = "&Salir"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bitacora del Día:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'cmdejecutar
        '
        Me.cmdejecutar.Location = New System.Drawing.Point(272, 8)
        Me.cmdejecutar.Name = "cmdejecutar"
        Me.cmdejecutar.TabIndex = 1
        Me.cmdejecutar.Text = "&Ejecutar"
        '
        'cmdgrafico
        '
        Me.cmdgrafico.Location = New System.Drawing.Point(480, 416)
        Me.cmdgrafico.Name = "cmdgrafico"
        Me.cmdgrafico.TabIndex = 4
        Me.cmdgrafico.Text = "&Ver Grafico"
        '
        'FrmBitacora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 450)
        Me.Controls.Add(Me.cmdgrafico)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.cmdejecutar)
        Me.Name = "FrmBitacora"
        Me.Text = "FrmBitacoraTemp"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdejecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdejecutar.Click
        Me.PivotGridControl1.DataSource = ObtieneDatos("SPBitacora '" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "','" & Format(DateAdd(DateInterval.Day, -1, Me.DateTimePicker1.Value), "dd/MM/yyyy") & "'," & EmpresaActual)
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdgrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrafico.Click
        Dim Forma As New FrmGraficoBitacora
        PivotGridControl1.Fields("Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Forma.Datas = PivotGridControl1.CreateSummaryDataSource
        Forma.ShowDialog()
        PivotGridControl1.Fields("Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
    End Sub
End Class
