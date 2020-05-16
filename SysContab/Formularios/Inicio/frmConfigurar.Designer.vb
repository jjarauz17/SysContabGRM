<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigurar))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProbarConexion1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PassSQL = New DevExpress.XtraEditors.TextEdit()
        Me.UsrSQL = New DevExpress.XtraEditors.TextEdit()
        Me.Base = New DevExpress.XtraEditors.TextEdit()
        Me.Servidor = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PassSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnGuardar)
        Me.LayoutControl1.Controls.Add(Me.btnSalir)
        Me.LayoutControl1.Controls.Add(Me.btnProbarConexion1)
        Me.LayoutControl1.Controls.Add(Me.PassSQL)
        Me.LayoutControl1.Controls.Add(Me.UsrSQL)
        Me.LayoutControl1.Controls.Add(Me.Base)
        Me.LayoutControl1.Controls.Add(Me.Servidor)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(451, 226)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.btnGuardar.Location = New System.Drawing.Point(188, 182)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(161, 40)
        Me.btnGuardar.StyleController = Me.LayoutControl1
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "&Guardar Configuración"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.btnSalir.Location = New System.Drawing.Point(353, 182)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 40)
        Me.btnSalir.StyleController = Me.LayoutControl1
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "&Salir"
        '
        'btnProbarConexion1
        '
        Me.btnProbarConexion1.Appearance.Options.UseTextOptions = True
        Me.btnProbarConexion1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnProbarConexion1.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_HtmlRefreshLarge
        Me.btnProbarConexion1.Location = New System.Drawing.Point(14, 128)
        Me.btnProbarConexion1.Name = "btnProbarConexion1"
        Me.btnProbarConexion1.Size = New System.Drawing.Size(136, 38)
        Me.btnProbarConexion1.StyleController = Me.LayoutControl1
        Me.btnProbarConexion1.TabIndex = 11
        Me.btnProbarConexion1.Text = "&Probar Conexión"
        '
        'PassSQL
        '
        Me.PassSQL.Location = New System.Drawing.Point(99, 104)
        Me.PassSQL.Name = "PassSQL"
        Me.PassSQL.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PassSQL.Size = New System.Drawing.Size(338, 20)
        Me.PassSQL.StyleController = Me.LayoutControl1
        Me.PassSQL.TabIndex = 7
        '
        'UsrSQL
        '
        Me.UsrSQL.Location = New System.Drawing.Point(99, 80)
        Me.UsrSQL.Name = "UsrSQL"
        Me.UsrSQL.Size = New System.Drawing.Size(338, 20)
        Me.UsrSQL.StyleController = Me.LayoutControl1
        Me.UsrSQL.TabIndex = 6
        '
        'Base
        '
        Me.Base.Location = New System.Drawing.Point(99, 56)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(338, 20)
        Me.Base.StyleController = Me.LayoutControl1
        Me.Base.TabIndex = 5
        '
        'Servidor
        '
        Me.Servidor.Location = New System.Drawing.Point(99, 32)
        Me.Servidor.Name = "Servidor"
        Me.Servidor.Size = New System.Drawing.Size(338, 20)
        Me.Servidor.StyleController = Me.LayoutControl1
        Me.Servidor.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(451, 226)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Servidor de Base de Datos"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(451, 180)
        Me.LayoutControlGroup2.Text = "Servidor de Base de Datos"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Servidor
        Me.LayoutControlItem1.CustomizationFormText = "Servidor:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(427, 24)
        Me.LayoutControlItem1.Text = "Servidor:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Base
        Me.LayoutControlItem2.CustomizationFormText = "Base de Datos:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(427, 24)
        Me.LayoutControlItem2.Text = "Base de Datos:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.UsrSQL
        Me.LayoutControlItem3.CustomizationFormText = "Usuario SQL:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(427, 24)
        Me.LayoutControlItem3.Text = "Usuario SQL:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PassSQL
        Me.LayoutControlItem4.CustomizationFormText = "Contraseña SQL:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(427, 24)
        Me.LayoutControlItem4.Text = "Contraseña SQL:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnProbarConexion1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(140, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(140, 96)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(287, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnSalir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(351, 180)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(100, 44)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(100, 44)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(100, 46)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 180)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(186, 46)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnGuardar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(186, 180)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(165, 44)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(165, 44)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(165, 46)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'frmConfigurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 226)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigurar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Servidor"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PassSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Servidor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PassSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UsrSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Base As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProbarConexion1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
