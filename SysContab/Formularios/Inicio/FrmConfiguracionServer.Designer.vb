<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracionServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracionServer))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.bProbarConexion = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.PassSQL = New DevExpress.XtraEditors.TextEdit()
        Me.UsrSQL = New DevExpress.XtraEditors.TextEdit()
        Me.Base = New DevExpress.XtraEditors.TextEdit()
        Me.Servidor = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.PictureEdit1)
        Me.LayoutControl1.Controls.Add(Me.bProbarConexion)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bGuardar)
        Me.LayoutControl1.Controls.Add(Me.PassSQL)
        Me.LayoutControl1.Controls.Add(Me.UsrSQL)
        Me.LayoutControl1.Controls.Add(Me.Base)
        Me.LayoutControl1.Controls.Add(Me.Servidor)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(499, 176, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(475, 374)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(135, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(328, 143)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.SysContab.My.Resources.Resources.servidor_torre
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(119, 135)
        Me.PictureEdit1.StyleController = Me.LayoutControl1
        Me.PictureEdit1.TabIndex = 11
        '
        'bProbarConexion
        '
        Me.bProbarConexion.ImageOptions.Image = CType(resources.GetObject("bProbarConexion.ImageOptions.Image"), System.Drawing.Image)
        Me.bProbarConexion.Location = New System.Drawing.Point(12, 323)
        Me.bProbarConexion.Name = "bProbarConexion"
        Me.bProbarConexion.Size = New System.Drawing.Size(134, 39)
        Me.bProbarConexion.StyleController = Me.LayoutControl1
        Me.bProbarConexion.TabIndex = 10
        Me.bProbarConexion.Text = "Probar &Conexion"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(370, 323)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(93, 39)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 9
        Me.bSalir.Text = "&Salir"
        '
        'bGuardar
        '
        Me.bGuardar.ImageOptions.Image = CType(resources.GetObject("bGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(273, 323)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(93, 39)
        Me.bGuardar.StyleController = Me.LayoutControl1
        Me.bGuardar.TabIndex = 8
        Me.bGuardar.Text = "&Guardar"
        '
        'PassSQL
        '
        Me.PassSQL.Location = New System.Drawing.Point(84, 249)
        Me.PassSQL.Name = "PassSQL"
        Me.PassSQL.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PassSQL.Size = New System.Drawing.Size(379, 20)
        Me.PassSQL.StyleController = Me.LayoutControl1
        Me.PassSQL.TabIndex = 7
        Me.PassSQL.Tag = ""
        '
        'UsrSQL
        '
        Me.UsrSQL.Location = New System.Drawing.Point(84, 225)
        Me.UsrSQL.Name = "UsrSQL"
        Me.UsrSQL.Size = New System.Drawing.Size(379, 20)
        Me.UsrSQL.StyleController = Me.LayoutControl1
        Me.UsrSQL.TabIndex = 6
        Me.UsrSQL.Tag = ""
        '
        'Base
        '
        Me.Base.Location = New System.Drawing.Point(84, 201)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(379, 20)
        Me.Base.StyleController = Me.LayoutControl1
        Me.Base.TabIndex = 5
        Me.Base.Tag = "True"
        '
        'Servidor
        '
        Me.Servidor.Location = New System.Drawing.Point(84, 177)
        Me.Servidor.Name = "Servidor"
        Me.Servidor.Size = New System.Drawing.Size(379, 20)
        Me.Servidor.StyleController = Me.LayoutControl1
        Me.Servidor.TabIndex = 4
        Me.Servidor.Tag = "True"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.EmptySpaceItem3, Me.LayoutControlItem8, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(475, 374)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Servidor
        Me.LayoutControlItem1.CustomizationFormText = "SQL Server"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 165)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(455, 24)
        Me.LayoutControlItem1.Text = "SQL Server"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Base
        Me.LayoutControlItem2.CustomizationFormText = "Base de Datos"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 189)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(455, 24)
        Me.LayoutControlItem2.Text = "Base de Datos"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.UsrSQL
        Me.LayoutControlItem3.CustomizationFormText = "Usuario"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(455, 24)
        Me.LayoutControlItem3.Text = "Usuario"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PassSQL
        Me.LayoutControlItem4.CustomizationFormText = "Contraseña"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 237)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(455, 24)
        Me.LayoutControlItem4.Text = "Contraseña"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bGuardar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(261, 311)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSalir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(358, 311)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(97, 43)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bProbarConexion
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 311)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(138, 43)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(138, 43)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(138, 43)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 261)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(455, 50)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.LabelControl1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(123, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(332, 147)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 147)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(455, 18)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.PictureEdit1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(123, 139)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(123, 139)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(123, 147)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(138, 311)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(123, 43)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'FrmConfiguracionServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 374)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfiguracionServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Conexión"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Base As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Servidor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bProbarConexion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PassSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UsrSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
