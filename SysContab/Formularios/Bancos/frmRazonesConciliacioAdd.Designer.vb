<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRazonesConciliacioAdd
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lcgTitulo = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(645, 156, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(561, 188)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.lcgTitulo})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(561, 188)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(69, 44)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCodigo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(136, 22)
        Me.txtCodigo.StyleController = Me.LayoutControl1
        Me.txtCodigo.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.CustomizationFormText = "Código"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(185, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(185, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(185, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Código"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(41, 13)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(69, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Size = New System.Drawing.Size(468, 22)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(517, 26)
        Me.LayoutControlItem2.Text = "Nombre:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(41, 13)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(360, 138)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Guardar"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(348, 126)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.SysContab.My.Resources.Resources._115
        Me.SimpleButton2.Location = New System.Drawing.Point(456, 138)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(93, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(444, 126)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(541, 30)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(185, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(332, 26)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 126)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(348, 42)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lcgTitulo
        '
        Me.lcgTitulo.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcgTitulo.AppearanceGroup.Options.UseFont = True
        Me.lcgTitulo.CustomizationFormText = "Registro"
        Me.lcgTitulo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2})
        Me.lcgTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lcgTitulo.Name = "lcgTitulo"
        Me.lcgTitulo.Size = New System.Drawing.Size(541, 96)
        Me.lcgTitulo.Text = "Registro"
        '
        'frmRazonesConciliacioAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRazonesConciliacioAdd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Razones de Conciliación"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lcgTitulo As DevExpress.XtraLayout.LayoutControlGroup
End Class
