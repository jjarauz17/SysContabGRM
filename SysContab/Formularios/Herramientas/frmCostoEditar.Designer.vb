<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostoEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostoEditar))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtIdMovimiento = New DevExpress.XtraEditors.TextEdit()
        Me.txtBodega = New DevExpress.XtraEditors.TextEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtMovimiento = New DevExpress.XtraEditors.TextEdit()
        Me.txtTipo = New DevExpress.XtraEditors.TextEdit()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCosto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtIdMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtIdMovimiento)
        Me.LayoutControl1.Controls.Add(Me.txtBodega)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.txtMovimiento)
        Me.LayoutControl1.Controls.Add(Me.txtTipo)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bGuardar)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(482, 145, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(884, 462)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtIdMovimiento
        '
        Me.txtIdMovimiento.Location = New System.Drawing.Point(682, 40)
        Me.txtIdMovimiento.Name = "txtIdMovimiento"
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtIdMovimiento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIdMovimiento.Properties.ReadOnly = True
        Me.txtIdMovimiento.Size = New System.Drawing.Size(190, 20)
        Me.txtIdMovimiento.StyleController = Me.LayoutControl1
        Me.txtIdMovimiento.TabIndex = 8
        '
        'txtBodega
        '
        Me.txtBodega.Location = New System.Drawing.Point(81, 88)
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtBodega.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBodega.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtBodega.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtBodega.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtBodega.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtBodega.Properties.ReadOnly = True
        Me.txtBodega.Size = New System.Drawing.Size(791, 20)
        Me.txtBodega.StyleController = Me.LayoutControl1
        Me.txtBodega.TabIndex = 9
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(81, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(175, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 10
        '
        'txtMovimiento
        '
        Me.txtMovimiento.Location = New System.Drawing.Point(81, 64)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtMovimiento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovimiento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMovimiento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMovimiento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtMovimiento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMovimiento.Properties.ReadOnly = True
        Me.txtMovimiento.Size = New System.Drawing.Size(791, 20)
        Me.txtMovimiento.StyleController = Me.LayoutControl1
        Me.txtMovimiento.TabIndex = 8
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(81, 36)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTipo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTipo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTipo.Properties.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(175, 20)
        Me.txtTipo.StyleController = Me.LayoutControl1
        Me.txtTipo.TabIndex = 7
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = Global.SysContab.My.Resources.Resources._115
        Me.bSalir.Location = New System.Drawing.Point(779, 412)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(93, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "&Salir"
        '
        'bGuardar
        '
        Me.bGuardar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.bGuardar.Location = New System.Drawing.Point(683, 412)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(92, 38)
        Me.bGuardar.StyleController = Me.LayoutControl1
        Me.bGuardar.TabIndex = 5
        Me.bGuardar.Text = "&Guardar"
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 112)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCosto})
        Me.dgDatos.Size = New System.Drawing.Size(860, 296)
        Me.dgDatos.TabIndex = 4
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'txtCosto
        '
        Me.txtCosto.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtCosto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCosto.Appearance.Options.UseBackColor = True
        Me.txtCosto.Appearance.Options.UseFont = True
        Me.txtCosto.Appearance.Options.UseForeColor = True
        Me.txtCosto.Appearance.Options.UseTextOptions = True
        Me.txtCosto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCosto.AutoHeight = False
        Me.txtCosto.Mask.EditMask = "n6"
        Me.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Name = "txtCosto"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(884, 462)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(864, 300)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bGuardar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(671, 400)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bSalir
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(767, 400)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 400)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(671, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTipo
        Me.LayoutControlItem4.CustomizationFormText = "Tipo:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(248, 28)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(248, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(248, 28)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Tipo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtMovimiento
        Me.LayoutControlItem5.CustomizationFormText = "Movimiento:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(864, 24)
        Me.LayoutControlItem5.Text = "Movimiento:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Fecha
        Me.LayoutControlItem7.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Fecha:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(66, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(248, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(353, 52)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtBodega
        Me.LayoutControlItem9.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(864, 24)
        Me.LayoutControlItem9.Text = "Bodega:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtIdMovimiento
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(601, 28)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(263, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(263, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(263, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "#Movimiento:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(66, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(601, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(263, 28)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCostoEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frmCostoEditar.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmCostoEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** EDITAR DETALLE DEL MOVIMIENTO"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtIdMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMovimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtBodega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCosto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtIdMovimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
