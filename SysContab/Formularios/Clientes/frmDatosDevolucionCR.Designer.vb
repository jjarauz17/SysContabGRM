<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosDevolucionCR
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosDevolucionCR))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTCambio = New DevExpress.XtraEditors.TextEdit()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipoNota = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDevolucion = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Razon = New DevExpress.XtraEditors.MemoEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMovimiento = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyTipoNC = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Razon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTipoNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTCambio)
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.cbTipoNota)
        Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
        Me.LayoutControl1.Controls.Add(Me.txtDevolucion)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Razon)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(533, 27, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(678, 348)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTCambio
        '
        Me.txtTCambio.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTCambio.Location = New System.Drawing.Point(552, 36)
        Me.txtTCambio.Name = "txtTCambio"
        Me.txtTCambio.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTCambio.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCambio.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTCambio.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTCambio.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCambio.Properties.Mask.EditMask = "n4"
        Me.txtTCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCambio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCambio.Properties.ReadOnly = True
        Me.txtTCambio.Size = New System.Drawing.Size(114, 22)
        Me.txtTCambio.StyleController = Me.LayoutControl1
        Me.txtTCambio.TabIndex = 21
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(173, 36)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtReferencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Properties.Appearance.Options.UseForeColor = True
        Me.txtReferencia.Size = New System.Drawing.Size(321, 22)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 3
        '
        'cbTipoNota
        '
        Me.cbTipoNota.Location = New System.Drawing.Point(173, 86)
        Me.cbTipoNota.Name = "cbTipoNota"
        Me.cbTipoNota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoNota.Properties.NullText = ""
        Me.cbTipoNota.Properties.ShowFooter = False
        Me.cbTipoNota.Properties.ShowHeader = False
        Me.cbTipoNota.Size = New System.Drawing.Size(493, 20)
        Me.cbTipoNota.StyleController = Me.LayoutControl1
        Me.cbTipoNota.TabIndex = 20
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMovimientos.Location = New System.Drawing.Point(173, 62)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMovimientos.Properties.NullText = ""
        Me.cbMovimientos.Properties.ShowFooter = False
        Me.cbMovimientos.Size = New System.Drawing.Size(493, 20)
        Me.cbMovimientos.StyleController = Me.LayoutControl1
        Me.cbMovimientos.TabIndex = 4
        '
        'txtDevolucion
        '
        Me.txtDevolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDevolucion.BackColor = System.Drawing.SystemColors.Info
        Me.txtDevolucion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucion.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDevolucion.Location = New System.Drawing.Point(553, 12)
        Me.txtDevolucion.MaxLength = 50
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.ReadOnly = True
        Me.txtDevolucion.Size = New System.Drawing.Size(113, 20)
        Me.txtDevolucion.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(12, 266)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(654, 28)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Este proceso de devolución creará una Nota de Credito en el estado de cuenta del " &
    "Cliente, y a su vez un movimiento de inventario en caso de contener productos."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(535, 298)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(131, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Cancelar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(419, 298)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Aceptar"
        '
        'Razon
        '
        Me.Razon.Location = New System.Drawing.Point(12, 126)
        Me.Razon.Name = "Razon"
        Me.Razon.Size = New System.Drawing.Size(654, 111)
        Me.Razon.StyleController = Me.LayoutControl1
        Me.Razon.TabIndex = 5
        Me.Razon.Tag = "True"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(173, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Fecha.Size = New System.Drawing.Size(124, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.lyMovimiento, Me.lyTipoNC, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(678, 348)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha Devolución:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(158, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 229)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(658, 25)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Razon
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(658, 131)
        Me.LayoutControlItem2.Text = "Motivo de Devolución / Anulación"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(158, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(407, 286)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(523, 286)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 286)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(407, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(289, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(91, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 254)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(658, 32)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtDevolucion
        Me.LayoutControlItem6.Location = New System.Drawing.Point(380, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "No. Devolución:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(158, 13)
        '
        'lyMovimiento
        '
        Me.lyMovimiento.Control = Me.cbMovimientos
        Me.lyMovimiento.Location = New System.Drawing.Point(0, 50)
        Me.lyMovimiento.Name = "lyMovimiento"
        Me.lyMovimiento.Size = New System.Drawing.Size(658, 24)
        Me.lyMovimiento.Text = "Movimiento:"
        Me.lyMovimiento.TextSize = New System.Drawing.Size(158, 13)
        '
        'lyTipoNC
        '
        Me.lyTipoNC.Control = Me.cbTipoNota
        Me.lyTipoNC.Location = New System.Drawing.Point(0, 74)
        Me.lyTipoNC.Name = "lyTipoNC"
        Me.lyTipoNC.Size = New System.Drawing.Size(658, 24)
        Me.lyTipoNC.Text = "Tipo N / C:"
        Me.lyTipoNC.TextSize = New System.Drawing.Size(158, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtReferencia
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(486, 26)
        Me.LayoutControlItem7.Text = "Referencia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(158, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtTCambio
        Me.LayoutControlItem8.Location = New System.Drawing.Point(486, 24)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(172, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(172, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(172, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "T/Cambio:"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'frmDatosDevolucionCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 348)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmDatosDevolucionCR.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosDevolucionCR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Devolución"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Razon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTipoNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Razon As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDevolucion As TextBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyMovimiento As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipoNota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyTipoNC As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
