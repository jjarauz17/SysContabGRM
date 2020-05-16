<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAntecedentesAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAntecedentesAdd))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtPbs_Actual = New DevExpress.XtraEditors.TextEdit()
        Me.txtPbs_Aterior = New DevExpress.XtraEditors.TextEdit()
        Me.txtMz_Actual = New DevExpress.XtraEditors.TextEdit()
        Me.txtMz_Aterior = New DevExpress.XtraEditors.TextEdit()
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMZ_Ant = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMZ_Act = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyPBS_Ant = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyPBS_Act = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtPbs_Actual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPbs_Aterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMz_Actual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMz_Aterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMZ_Ant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMZ_Act, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyPBS_Ant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyPBS_Act, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtPbs_Actual)
        Me.LayoutControl1.Controls.Add(Me.txtPbs_Aterior)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bGuardar)
        Me.LayoutControl1.Controls.Add(Me.txtMz_Actual)
        Me.LayoutControl1.Controls.Add(Me.txtMz_Aterior)
        Me.LayoutControl1.Controls.Add(Me.cbPeriodo)
        Me.LayoutControl1.Controls.Add(Me.lblCliente)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1037, 275, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(379, 259)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtPbs_Actual
        '
        Me.txtPbs_Actual.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtPbs_Actual.Location = New System.Drawing.Point(130, 127)
        Me.txtPbs_Actual.Name = "txtPbs_Actual"
        Me.txtPbs_Actual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPbs_Actual.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPbs_Actual.Properties.Appearance.Options.UseFont = True
        Me.txtPbs_Actual.Properties.Appearance.Options.UseForeColor = True
        Me.txtPbs_Actual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPbs_Actual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPbs_Actual.Properties.Mask.EditMask = "n2"
        Me.txtPbs_Actual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPbs_Actual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPbs_Actual.Size = New System.Drawing.Size(237, 20)
        Me.txtPbs_Actual.StyleController = Me.LayoutControl1
        Me.txtPbs_Actual.TabIndex = 11
        '
        'txtPbs_Aterior
        '
        Me.txtPbs_Aterior.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtPbs_Aterior.Location = New System.Drawing.Point(130, 103)
        Me.txtPbs_Aterior.Name = "txtPbs_Aterior"
        Me.txtPbs_Aterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPbs_Aterior.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPbs_Aterior.Properties.Appearance.Options.UseFont = True
        Me.txtPbs_Aterior.Properties.Appearance.Options.UseForeColor = True
        Me.txtPbs_Aterior.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPbs_Aterior.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPbs_Aterior.Properties.Mask.EditMask = "n2"
        Me.txtPbs_Aterior.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPbs_Aterior.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPbs_Aterior.Size = New System.Drawing.Size(237, 20)
        Me.txtPbs_Aterior.StyleController = Me.LayoutControl1
        Me.txtPbs_Aterior.TabIndex = 10
        '
        'txtMz_Actual
        '
        Me.txtMz_Actual.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtMz_Actual.Location = New System.Drawing.Point(130, 79)
        Me.txtMz_Actual.Name = "txtMz_Actual"
        Me.txtMz_Actual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMz_Actual.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMz_Actual.Properties.Appearance.Options.UseFont = True
        Me.txtMz_Actual.Properties.Appearance.Options.UseForeColor = True
        Me.txtMz_Actual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMz_Actual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMz_Actual.Properties.Mask.EditMask = "n2"
        Me.txtMz_Actual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMz_Actual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMz_Actual.Size = New System.Drawing.Size(237, 20)
        Me.txtMz_Actual.StyleController = Me.LayoutControl1
        Me.txtMz_Actual.TabIndex = 9
        '
        'txtMz_Aterior
        '
        Me.txtMz_Aterior.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtMz_Aterior.Location = New System.Drawing.Point(130, 55)
        Me.txtMz_Aterior.Name = "txtMz_Aterior"
        Me.txtMz_Aterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMz_Aterior.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMz_Aterior.Properties.Appearance.Options.UseFont = True
        Me.txtMz_Aterior.Properties.Appearance.Options.UseForeColor = True
        Me.txtMz_Aterior.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMz_Aterior.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMz_Aterior.Properties.Mask.EditMask = "n2"
        Me.txtMz_Aterior.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMz_Aterior.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMz_Aterior.Size = New System.Drawing.Size(237, 20)
        Me.txtMz_Aterior.StyleController = Me.LayoutControl1
        Me.txtMz_Aterior.TabIndex = 8
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(130, 29)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.Properties.Appearance.Options.UseFont = True
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Size = New System.Drawing.Size(237, 22)
        Me.cbPeriodo.StyleController = Me.LayoutControl1
        Me.cbPeriodo.TabIndex = 6
        Me.cbPeriodo.Tag = "True"
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblCliente.Location = New System.Drawing.Point(130, 12)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(237, 13)
        Me.lblCliente.StyleController = Me.LayoutControl1
        Me.lblCliente.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.lyMZ_Ant, Me.lyMZ_Act, Me.EmptySpaceItem1, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.lyPBS_Ant, Me.lyPBS_Act})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(379, 259)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lblCliente
        Me.LayoutControlItem1.CustomizationFormText = "Nombre de la Cuenta:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(359, 17)
        Me.LayoutControlItem1.Text = "Nombre de la Cuenta:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(115, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbPeriodo
        Me.LayoutControlItem3.CustomizationFormText = "Responsable:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(359, 26)
        Me.LayoutControlItem3.Text = "Periodo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(115, 13)
        '
        'lyMZ_Ant
        '
        Me.lyMZ_Ant.Control = Me.txtMz_Aterior
        Me.lyMZ_Ant.CustomizationFormText = "Recursos U$:"
        Me.lyMZ_Ant.Location = New System.Drawing.Point(0, 43)
        Me.lyMZ_Ant.Name = "lyMZ_Ant"
        Me.lyMZ_Ant.Size = New System.Drawing.Size(359, 24)
        Me.lyMZ_Ant.Text = "No. de Mz Anterior:"
        Me.lyMZ_Ant.TextSize = New System.Drawing.Size(115, 13)
        '
        'lyMZ_Act
        '
        Me.lyMZ_Act.Control = Me.txtMz_Actual
        Me.lyMZ_Act.CustomizationFormText = "Gasto Real U$:"
        Me.lyMZ_Act.Location = New System.Drawing.Point(0, 67)
        Me.lyMZ_Act.Name = "lyMZ_Act"
        Me.lyMZ_Act.Size = New System.Drawing.Size(359, 24)
        Me.lyMZ_Act.Text = "No. de Mz Actual:"
        Me.lyMZ_Act.TextSize = New System.Drawing.Size(115, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 139)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(359, 58)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 197)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(167, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyPBS_Ant
        '
        Me.lyPBS_Ant.Control = Me.txtPbs_Aterior
        Me.lyPBS_Ant.CustomizationFormText = "PBS/ Mz en U$ Anterior:"
        Me.lyPBS_Ant.Location = New System.Drawing.Point(0, 91)
        Me.lyPBS_Ant.Name = "lyPBS_Ant"
        Me.lyPBS_Ant.Size = New System.Drawing.Size(359, 24)
        Me.lyPBS_Ant.Text = "PBS/ Mz en U$ Anterior:"
        Me.lyPBS_Ant.TextSize = New System.Drawing.Size(115, 13)
        '
        'lyPBS_Act
        '
        Me.lyPBS_Act.Control = Me.txtPbs_Actual
        Me.lyPBS_Act.CustomizationFormText = "PBS/ Mz en U$ Actual:"
        Me.lyPBS_Act.Location = New System.Drawing.Point(0, 115)
        Me.lyPBS_Act.Name = "lyPBS_Act"
        Me.lyPBS_Act.Size = New System.Drawing.Size(359, 24)
        Me.lyPBS_Act.Text = "PBS/ Mz en U$ Actual:"
        Me.lyPBS_Act.TextSize = New System.Drawing.Size(115, 13)
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(275, 209)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(92, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 11
        Me.bSalir.Text = "&Salir"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(179, 209)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(92, 38)
        Me.bGuardar.StyleController = Me.LayoutControl1
        Me.bGuardar.TabIndex = 10
        Me.bGuardar.Text = "&Guardar"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bGuardar
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(167, 197)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bSalir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(263, 197)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'frmAntecedentesAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAntecedentesAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtPbs_Actual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPbs_Aterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMz_Actual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMz_Aterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMZ_Ant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMZ_Act, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyPBS_Ant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyPBS_Act, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtMz_Actual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMz_Aterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyMZ_Ant As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyMZ_Act As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtPbs_Actual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPbs_Aterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyPBS_Ant As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyPBS_Act As DevExpress.XtraLayout.LayoutControlItem
End Class
