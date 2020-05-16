<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabilizarAjusteInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizarAjusteInventario))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.irVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.irVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.cbTipoComp)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1078, 300, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(842, 603)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(126, 70)
        Me.txtConcepto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Properties.Appearance.Options.UseFont = True
        Me.txtConcepto.Size = New System.Drawing.Size(704, 55)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 3
        Me.txtConcepto.UseOptimizedRendering = True
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(126, 40)
        Me.cbTipoComp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.Appearance.Options.UseFont = True
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.DropDownRows = 12
        Me.cbTipoComp.Properties.NullText = "[Seleccione Comprobante]"
        Me.cbTipoComp.Properties.ShowFooter = False
        Me.cbTipoComp.Properties.ShowHeader = False
        Me.cbTipoComp.Size = New System.Drawing.Size(704, 26)
        Me.cbTipoComp.StyleController = Me.LayoutControl1
        Me.cbTipoComp.TabIndex = 2
        '
        'Fecha
        '
        Me.Fecha.EditValue = New Date(2008, 9, 2, 9, 47, 29, 93)
        Me.Fecha.Location = New System.Drawing.Point(126, 12)
        Me.Fecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(136, 24)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 1
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.iGrid.Location = New System.Drawing.Point(12, 129)
        Me.iGrid.MainView = Me.vComprobante
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.txtMonto})
        Me.iGrid.Size = New System.Drawing.Size(818, 462)
        Me.iGrid.TabIndex = 2
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'vComprobante
        '
        Me.vComprobante.GridControl = Me.iGrid
        Me.vComprobante.Name = "vComprobante"
        Me.vComprobante.OptionsFilter.AllowFilterEditor = False
        Me.vComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vComprobante.OptionsView.ShowFooter = True
        Me.vComprobante.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.View = Me.irVista
        '
        'irVista
        '
        Me.irVista.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.irVista.Name = "irVista"
        Me.irVista.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.irVista.OptionsView.ShowAutoFilterRow = True
        Me.irVista.OptionsView.ShowFooter = True
        Me.irVista.OptionsView.ShowGroupPanel = False
        '
        'txtMonto
        '
        Me.txtMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Appearance.Options.UseFont = True
        Me.txtMonto.Appearance.Options.UseTextOptions = True
        Me.txtMonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.Mask.EditMask = "n2"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Name = "txtMonto"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(842, 603)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(822, 466)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(254, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(254, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(254, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbTipoComp
        Me.LayoutControlItem3.CustomizationFormText = "Tipo Comprobante:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(822, 30)
        Me.LayoutControlItem3.Text = "Tipo Comprobante:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(111, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtConcepto
        Me.LayoutControlItem4.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 59)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(128, 59)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(822, 59)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Concepto:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(111, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(254, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(568, 28)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        Me.DockPanel1.ID = New System.Guid("ab695154-e022-47d4-9db2-4e1cb00bc77e")
        Me.DockPanel1.Location = New System.Drawing.Point(842, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 603)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 575)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 575)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 54)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(108, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(108, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 575)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(112, 513)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'frmContabilizarAjusteInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmContabilizarAjusteInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmContabilizarAjusteInventario"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.irVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents vComprobante As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents irVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
