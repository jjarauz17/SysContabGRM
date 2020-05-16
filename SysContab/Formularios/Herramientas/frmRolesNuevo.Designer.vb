<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRolesNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRolesNuevo))
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TreeListExportar = New DevExpress.XtraTreeList.TreeList()
        Me.bContraer = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescrip = New DevExpress.XtraEditors.MemoEdit()
        Me.btnExpandir = New DevExpress.XtraEditors.SimpleButton()
        Me.TreeRoles = New DevExpress.XtraTreeList.TreeList()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TreeListExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.EditValue = ""
        Me.txtNombre.Location = New System.Drawing.Point(75, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(565, 22)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TreeListExportar)
        Me.LayoutControl1.Controls.Add(Me.bContraer)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.txtDescrip)
        Me.LayoutControl1.Controls.Add(Me.btnExpandir)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.TreeRoles)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(457, 372, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(652, 570)
        Me.LayoutControl1.TabIndex = 13
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TreeListExportar
        '
        Me.TreeListExportar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeListExportar.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeListExportar.Appearance.HeaderPanel.Options.UseFont = True
        Me.TreeListExportar.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.TreeListExportar.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TreeListExportar.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TreeListExportar.ColumnPanelRowHeight = 25
        Me.TreeListExportar.Location = New System.Drawing.Point(12, 358)
        Me.TreeListExportar.LookAndFeel.SkinName = "Blue"
        Me.TreeListExportar.Name = "TreeListExportar"
        Me.TreeListExportar.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Standard
        Me.TreeListExportar.OptionsFind.AlwaysVisible = True
        Me.TreeListExportar.OptionsFind.FindMode = DevExpress.XtraTreeList.FindMode.Always
        Me.TreeListExportar.OptionsFind.ShowClearButton = False
        Me.TreeListExportar.OptionsView.ShowAutoFilterRow = True
        Me.TreeListExportar.OptionsView.ShowRowFooterSummary = True
        Me.TreeListExportar.OptionsView.ShowSummaryFooter = True
        Me.TreeListExportar.RowHeight = 20
        Me.TreeListExportar.Size = New System.Drawing.Size(628, 200)
        Me.TreeListExportar.TabIndex = 15
        '
        'bContraer
        '
        Me.bContraer.Image = CType(resources.GetObject("bContraer.Image"), System.Drawing.Image)
        Me.bContraer.Location = New System.Drawing.Point(426, 97)
        Me.bContraer.Name = "bContraer"
        Me.bContraer.Size = New System.Drawing.Size(106, 22)
        Me.bContraer.StyleController = Me.LayoutControl1
        Me.bContraer.TabIndex = 15
        Me.bContraer.Text = "&Contraer Todo"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(536, 97)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(104, 22)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 15
        Me.bExportar.Text = "E&xportar"
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(75, 38)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDescrip.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtDescrip.Properties.Appearance.Options.UseFont = True
        Me.txtDescrip.Properties.Appearance.Options.UseForeColor = True
        Me.txtDescrip.Size = New System.Drawing.Size(565, 55)
        Me.txtDescrip.StyleController = Me.LayoutControl1
        Me.txtDescrip.TabIndex = 1
        '
        'btnExpandir
        '
        Me.btnExpandir.Image = CType(resources.GetObject("btnExpandir.Image"), System.Drawing.Image)
        Me.btnExpandir.Location = New System.Drawing.Point(315, 97)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(107, 22)
        Me.btnExpandir.StyleController = Me.LayoutControl1
        Me.btnExpandir.TabIndex = 4
        Me.btnExpandir.Text = "&Expandir Todo"
        '
        'TreeRoles
        '
        Me.TreeRoles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeRoles.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeRoles.Appearance.HeaderPanel.Options.UseFont = True
        Me.TreeRoles.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.TreeRoles.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TreeRoles.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TreeRoles.ColumnPanelRowHeight = 25
        Me.TreeRoles.Location = New System.Drawing.Point(12, 123)
        Me.TreeRoles.LookAndFeel.SkinName = "Blue"
        Me.TreeRoles.Name = "TreeRoles"
        Me.TreeRoles.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Standard
        Me.TreeRoles.OptionsFind.AlwaysVisible = True
        Me.TreeRoles.OptionsFind.FindMode = DevExpress.XtraTreeList.FindMode.Always
        Me.TreeRoles.OptionsFind.ShowClearButton = False
        Me.TreeRoles.OptionsView.ShowAutoFilterRow = True
        Me.TreeRoles.OptionsView.ShowRowFooterSummary = True
        Me.TreeRoles.OptionsView.ShowSummaryFooter = True
        Me.TreeRoles.RowHeight = 20
        Me.TreeRoles.Size = New System.Drawing.Size(628, 215)
        Me.TreeRoles.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(652, 570)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNombre
        Me.LayoutControlItem1.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(632, 26)
        Me.LayoutControlItem1.Text = "Nombre:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDescrip
        Me.LayoutControlItem2.CustomizationFormText = "Descripción:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 59)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(76, 59)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(632, 59)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Descripción:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TreeRoles
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 111)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(632, 219)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExpandir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(303, 85)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bExportar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(524, 85)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(108, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(108, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(108, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 85)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(303, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bContraer
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(414, 85)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(110, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(110, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TreeListExportar
        Me.LayoutControlItem9.CustomizationFormText = "Rol Exportar"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 330)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(632, 220)
        Me.LayoutControlItem9.Text = "Rol Exportar"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(60, 13)
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(12, 54)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 38)
        Me.btnExit.StyleController = Me.LayoutControl2
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.btnExit)
        Me.LayoutControl2.Controls.Add(Me.btnNew)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 543)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(12, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(108, 38)
        Me.btnNew.StyleController = Me.LayoutControl2
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 543)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnNew
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnExit
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(112, 481)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("c54b3759-3b6d-42bb-83f0-76867ea445df")
        Me.DockPanel1.Location = New System.Drawing.Point(652, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 570)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 543)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmRolesNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmRolesNuevo"
        Me.Text = "*** ROLES DE USUARIOS ***"
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TreeListExportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescrip As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeRoles As DevExpress.XtraTreeList.TreeList
    Friend WithEvents btnExpandir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bContraer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TreeListExportar As DevExpress.XtraTreeList.TreeList
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
