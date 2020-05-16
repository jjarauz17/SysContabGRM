<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicarInventarioFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAplicarInventarioFisico))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbBodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbNC = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbND = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNumero)
        Me.LayoutControl1.Controls.Add(Me.txtComentarios)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cbBodega)
        Me.LayoutControl1.Controls.Add(Me.cbNC)
        Me.LayoutControl1.Controls.Add(Me.cbND)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(761, 224, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(622, 284)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(457, 12)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(153, 20)
        Me.txtNumero.StyleController = Me.LayoutControl1
        Me.txtNumero.TabIndex = 9
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(95, 110)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(515, 58)
        Me.txtComentarios.StyleController = Me.LayoutControl1
        Me.txtComentarios.TabIndex = 8
        Me.txtComentarios.Tag = "True"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(496, 234)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(114, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(378, 234)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Aplicar Inventario"
        '
        'cbBodega
        '
        Me.cbBodega.Location = New System.Drawing.Point(95, 38)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.Appearance.Options.UseFont = True
        Me.cbBodega.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cbBodega.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cbBodega.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cbBodega.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbBodega.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodega.Properties.NullText = ""
        Me.cbBodega.Properties.ReadOnly = True
        Me.cbBodega.Properties.ShowFooter = False
        Me.cbBodega.Properties.ShowHeader = False
        Me.cbBodega.Properties.ShowLines = False
        Me.cbBodega.Size = New System.Drawing.Size(515, 20)
        Me.cbBodega.StyleController = Me.LayoutControl1
        Me.cbBodega.TabIndex = 5
        Me.cbBodega.Tag = "True"
        '
        'cbNC
        '
        Me.cbNC.Location = New System.Drawing.Point(95, 86)
        Me.cbNC.Name = "cbNC"
        Me.cbNC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNC.Properties.Appearance.Options.UseFont = True
        Me.cbNC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbNC.Properties.NullText = ""
        Me.cbNC.Properties.ShowFooter = False
        Me.cbNC.Size = New System.Drawing.Size(515, 20)
        Me.cbNC.StyleController = Me.LayoutControl1
        Me.cbNC.TabIndex = 4
        Me.cbNC.Tag = "True"
        '
        'cbND
        '
        Me.cbND.Location = New System.Drawing.Point(95, 62)
        Me.cbND.Name = "cbND"
        Me.cbND.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbND.Properties.Appearance.Options.UseFont = True
        Me.cbND.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbND.Properties.NullText = ""
        Me.cbND.Properties.ShowFooter = False
        Me.cbND.Size = New System.Drawing.Size(515, 20)
        Me.cbND.StyleController = Me.LayoutControl1
        Me.cbND.TabIndex = 4
        Me.cbND.Tag = "True"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(95, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(149, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(622, 284)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(236, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbND
        Me.LayoutControlItem3.CustomizationFormText = "Nota de Débito:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(602, 24)
        Me.LayoutControlItem3.Text = "Nota de Débito:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbNC
        Me.LayoutControlItem4.CustomizationFormText = "Nota de Crédito:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(602, 24)
        Me.LayoutControlItem4.Text = "Nota de Crédito:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbBodega
        Me.LayoutControlItem6.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(602, 24)
        Me.LayoutControlItem6.Text = "Bodega:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(80, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(236, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(126, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(366, 222)
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
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(484, 222)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 222)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(366, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtComentarios
        Me.LayoutControlItem5.CustomizationFormText = "Comentarios:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(602, 62)
        Me.LayoutControlItem5.Text = "Comentarios:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(80, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 160)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(602, 62)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNumero
        Me.LayoutControlItem1.CustomizationFormText = "Número:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(362, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(240, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(240, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(240, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Número:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(80, 13)
        '
        'frmAplicarInventarioFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 284)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmAplicarInventarioFisico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicar Inventario Fisico"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbNC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbND As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
