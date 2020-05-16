<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositosListNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepositosListNew))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.bAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.bVer = New DevExpress.XtraEditors.SimpleButton()
        Me.bEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(756, 187, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(746, 490)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(170, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 163
        Me.SimpleButton1.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(49, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(117, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 162
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(49, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Size = New System.Drawing.Size(117, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 161
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 64)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(722, 414)
        Me.iGrid.TabIndex = 158
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(746, 490)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(726, 418)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.Desde
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(158, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(158, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(158, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Desde:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Hasta
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(158, 28)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(158, 28)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(158, 28)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Hasta:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(34, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(253, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(473, 52)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(158, 10)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(158, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(95, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("af33d1fb-5acf-4f99-870b-ca7736e094da")
        Me.DockPanel1.Location = New System.Drawing.Point(746, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 490)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 463)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton7)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.bContabilizar)
        Me.LayoutControl2.Controls.Add(Me.bAnular)
        Me.LayoutControl2.Controls.Add(Me.bVer)
        Me.LayoutControl2.Controls.Add(Me.bEditar)
        Me.LayoutControl2.Controls.Add(Me.bNuevo)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 565, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(141, 463)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Options.UseTextOptions = True
        Me.SimpleButton7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(12, 396)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton7.StyleController = Me.LayoutControl2
        Me.SimpleButton7.TabIndex = 10
        Me.SimpleButton7.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Appearance.Options.UseTextOptions = True
        Me.bExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 354)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(118, 38)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 9
        Me.bExportar.Text = "E&xportar"
        '
        'bContabilizar
        '
        Me.bContabilizar.Appearance.Options.UseTextOptions = True
        Me.bContabilizar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bContabilizar.Enabled = False
        Me.bContabilizar.ImageOptions.Image = CType(resources.GetObject("bContabilizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bContabilizar.Location = New System.Drawing.Point(12, 180)
        Me.bContabilizar.Name = "bContabilizar"
        Me.bContabilizar.Size = New System.Drawing.Size(118, 38)
        Me.bContabilizar.StyleController = Me.LayoutControl2
        Me.bContabilizar.TabIndex = 8
        Me.bContabilizar.Text = "&Contabilizar"
        '
        'bAnular
        '
        Me.bAnular.Appearance.Options.UseTextOptions = True
        Me.bAnular.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAnular.Enabled = False
        Me.bAnular.ImageOptions.Image = CType(resources.GetObject("bAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.bAnular.Location = New System.Drawing.Point(12, 138)
        Me.bAnular.Name = "bAnular"
        Me.bAnular.Size = New System.Drawing.Size(118, 38)
        Me.bAnular.StyleController = Me.LayoutControl2
        Me.bAnular.TabIndex = 7
        Me.bAnular.Text = "&Anular"
        '
        'bVer
        '
        Me.bVer.Appearance.Options.UseTextOptions = True
        Me.bVer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bVer.Enabled = False
        Me.bVer.ImageOptions.Image = CType(resources.GetObject("bVer.ImageOptions.Image"), System.Drawing.Image)
        Me.bVer.Location = New System.Drawing.Point(12, 96)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(118, 38)
        Me.bVer.StyleController = Me.LayoutControl2
        Me.bVer.TabIndex = 6
        Me.bVer.Text = "&Ver Deposito"
        '
        'bEditar
        '
        Me.bEditar.Appearance.Options.UseTextOptions = True
        Me.bEditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bEditar.Enabled = False
        Me.bEditar.ImageOptions.Image = CType(resources.GetObject("bEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bEditar.Location = New System.Drawing.Point(12, 54)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(118, 38)
        Me.bEditar.StyleController = Me.LayoutControl2
        Me.bEditar.TabIndex = 5
        Me.bEditar.Text = "&Editar"
        '
        'bNuevo
        '
        Me.bNuevo.Appearance.Options.UseTextOptions = True
        Me.bNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.Image = CType(resources.GetObject("bNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(12, 12)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(118, 38)
        Me.bNuevo.StyleController = Me.LayoutControl2
        Me.bNuevo.TabIndex = 4
        Me.bNuevo.Text = "&Nuevo Deposito"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(142, 446)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bNuevo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bEditar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bVer
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bAnular
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bContabilizar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bExportar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 342)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton7
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 384)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 132)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmDepositosListNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 490)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmDepositosListNew"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents bContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
