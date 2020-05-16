<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentaDiferenciaVentas
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.cbCatalogo = New DevExpress.XtraEditors.GridLookUpEdit
        Me.glvDatos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
        Me.LayoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(604, 147)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.SysContab.My.Resources.Resources._115
        Me.SimpleButton2.Location = New System.Drawing.Point(507, 101)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(91, 40)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(355, 101)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(141, 40)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Ajustar Diferencia"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(97, 40)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Débito"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Crédito")})
        Me.RadioGroup1.Size = New System.Drawing.Size(501, 50)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 5
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(97, 7)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.View = Me.glvDatos
        Me.cbCatalogo.Size = New System.Drawing.Size(501, 22)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 4
        '
        'glvDatos
        '
        Me.glvDatos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.glvDatos.Name = "glvDatos"
        Me.glvDatos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.glvDatos.OptionsView.ShowAutoFilterRow = True
        Me.glvDatos.OptionsView.ShowFooter = True
        Me.glvDatos.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(604, 147)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbCatalogo
        Me.LayoutControlItem1.CustomizationFormText = "Cuenta Contable:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(602, 33)
        Me.LayoutControlItem1.Text = "Cuenta Contable:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(85, 20)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.CustomizationFormText = "Ajustar a:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(602, 61)
        Me.LayoutControlItem2.Text = "Ajustar a:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(85, 20)
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(348, 94)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(152, 51)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(152, 51)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(152, 51)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(500, 94)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(102, 51)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(102, 51)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(102, 51)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 94)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(348, 51)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCuentaDiferenciaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 147)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentaDiferenciaVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadrando Ingresos de Ventas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents glvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
