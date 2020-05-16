<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduccionEstado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduccionEstado))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtAProducir = New DevExpress.XtraEditors.TextEdit()
        Me.cbFormula = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dFecha = New DevExpress.XtraEditors.DateEdit()
        Me.Numero = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txtDevolucion = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAProducir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTotal)
        Me.LayoutControl1.Controls.Add(Me.txtDevolucion)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.txtNoDocumento)
        Me.LayoutControl1.Controls.Add(Me.txtObservaciones)
        Me.LayoutControl1.Controls.Add(Me.TxtAProducir)
        Me.LayoutControl1.Controls.Add(Me.cbFormula)
        Me.LayoutControl1.Controls.Add(Me.dFecha)
        Me.LayoutControl1.Controls.Add(Me.Numero)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1107, 161, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(647, 358)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(521, 308)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(114, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 14
        Me.SimpleButton2.Text = "&Cerrar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(403, 308)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "&Aceptar"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.Location = New System.Drawing.Point(138, 66)
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoDocumento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDocumento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.txtNoDocumento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNoDocumento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNoDocumento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNoDocumento.Properties.ReadOnly = True
        Me.txtNoDocumento.Size = New System.Drawing.Size(497, 24)
        Me.txtNoDocumento.StyleController = Me.LayoutControl1
        Me.txtNoDocumento.TabIndex = 4
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(138, 178)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(497, 95)
        Me.txtObservaciones.StyleController = Me.LayoutControl1
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.Tag = "True"
        '
        'TxtAProducir
        '
        Me.TxtAProducir.EditValue = 0R
        Me.TxtAProducir.Location = New System.Drawing.Point(138, 94)
        Me.TxtAProducir.Name = "TxtAProducir"
        Me.TxtAProducir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAProducir.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.TxtAProducir.Properties.Appearance.Options.UseFont = True
        Me.TxtAProducir.Properties.Appearance.Options.UseForeColor = True
        Me.TxtAProducir.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtAProducir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtAProducir.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAProducir.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAProducir.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.TxtAProducir.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtAProducir.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.TxtAProducir.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.TxtAProducir.Properties.Mask.EditMask = "n2"
        Me.TxtAProducir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtAProducir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtAProducir.Properties.ReadOnly = True
        Me.TxtAProducir.Size = New System.Drawing.Size(497, 24)
        Me.TxtAProducir.StyleController = Me.LayoutControl1
        Me.TxtAProducir.TabIndex = 11
        '
        'cbFormula
        '
        Me.cbFormula.Location = New System.Drawing.Point(138, 40)
        Me.cbFormula.Name = "cbFormula"
        Me.cbFormula.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormula.Properties.Appearance.Options.UseFont = True
        Me.cbFormula.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFormula.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormula.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbFormula.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbFormula.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormula.Properties.ReadOnly = True
        Me.cbFormula.Properties.View = Me.SearchLookUpEdit1View
        Me.cbFormula.Size = New System.Drawing.Size(497, 22)
        Me.cbFormula.StyleController = Me.LayoutControl1
        Me.cbFormula.TabIndex = 8
        Me.cbFormula.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'dFecha
        '
        Me.dFecha.EditValue = Nothing
        Me.dFecha.Location = New System.Drawing.Point(138, 12)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Properties.Appearance.Options.UseFont = True
        Me.dFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Size = New System.Drawing.Size(120, 22)
        Me.dFecha.StyleController = Me.LayoutControl1
        Me.dFecha.TabIndex = 10
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(521, 12)
        Me.Numero.Name = "Numero"
        Me.Numero.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Numero.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.Numero.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.Numero.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Numero.Properties.ReadOnly = True
        Me.Numero.Size = New System.Drawing.Size(114, 24)
        Me.Numero.StyleController = Me.LayoutControl1
        Me.Numero.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(647, 358)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dFecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(250, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(250, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(250, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha Producción:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Numero
        Me.LayoutControlItem1.Location = New System.Drawing.Point(383, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Número:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbFormula
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(627, 26)
        Me.LayoutControlItem3.Text = "Formula:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TxtAProducir
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(627, 28)
        Me.LayoutControlItem4.Text = "Cantidad a Producir QQS:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtObservaciones
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(627, 99)
        Me.LayoutControlItem5.Text = "Observaciones:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(123, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 265)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(627, 31)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtNoDocumento
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(627, 28)
        Me.LayoutControlItem6.Text = "No. Documento:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(123, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(391, 296)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton2
        Me.LayoutControlItem8.Location = New System.Drawing.Point(509, 296)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 296)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(391, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(250, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(133, 28)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtDevolucion
        '
        Me.txtDevolucion.EditValue = 0R
        Me.txtDevolucion.Location = New System.Drawing.Point(138, 122)
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucion.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtDevolucion.Properties.Appearance.Options.UseFont = True
        Me.txtDevolucion.Properties.Appearance.Options.UseForeColor = True
        Me.txtDevolucion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDevolucion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDevolucion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDevolucion.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDevolucion.Properties.Mask.EditMask = "n2"
        Me.txtDevolucion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDevolucion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDevolucion.Properties.ReadOnly = True
        Me.txtDevolucion.Size = New System.Drawing.Size(497, 24)
        Me.txtDevolucion.StyleController = Me.LayoutControl1
        Me.txtDevolucion.TabIndex = 12
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtDevolucion
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 110)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(627, 28)
        Me.LayoutControlItem9.Text = "Devolución/Averias QQS:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(123, 13)
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = 0R
        Me.txtTotal.Location = New System.Drawing.Point(138, 150)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.Mask.EditMask = "n2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(497, 24)
        Me.txtTotal.StyleController = Me.LayoutControl1
        Me.txtTotal.TabIndex = 13
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtTotal
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(627, 28)
        Me.LayoutControlItem10.Text = "Total Producción QQ:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(123, 13)
        '
        'frmProduccionEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 358)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduccionEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAProducir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFormula As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtAProducir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtNoDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtDevolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
End Class
