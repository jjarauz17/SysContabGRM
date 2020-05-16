<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteCategoria
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
        Me.lyCodigo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(543, 63, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(477, 160)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lyCodigo, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(477, 160)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(57, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtCodigo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCodigo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCodigo.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(167, 20)
        Me.txtCodigo.StyleController = Me.LayoutControl1
        Me.txtCodigo.TabIndex = 4
        '
        'lyCodigo
        '
        Me.lyCodigo.Control = Me.txtCodigo
        Me.lyCodigo.CustomizationFormText = "Codigo:"
        Me.lyCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lyCodigo.MaxSize = New System.Drawing.Size(216, 24)
        Me.lyCodigo.MinSize = New System.Drawing.Size(216, 24)
        Me.lyCodigo.Name = "lyCodigo"
        Me.lyCodigo.Size = New System.Drawing.Size(216, 24)
        Me.lyCodigo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyCodigo.Text = "Codigo:"
        Me.lyCodigo.TextSize = New System.Drawing.Size(41, 13)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(453, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(457, 40)
        Me.LayoutControlItem2.Text = "Nombre:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(41, 13)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 110)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(224, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Guardar"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(228, 42)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.SysContab.My.Resources.Resources._115
        Me.SimpleButton2.Location = New System.Drawing.Point(240, 110)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(225, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(228, 98)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(229, 42)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 64)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(457, 34)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(216, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmClienteCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 160)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClienteCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClienteCategoria"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyCodigo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
