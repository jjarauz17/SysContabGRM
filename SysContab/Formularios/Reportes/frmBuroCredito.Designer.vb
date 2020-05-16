<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuroCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuroCredito))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.AlCorte = New DevExpress.XtraEditors.DateEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlCorte.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbSucursal)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.AlCorte)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(896, 294, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(496, 502)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbSucursal
        '
        Me.cbSucursal.Location = New System.Drawing.Point(58, 62)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.Appearance.Options.UseFont = True
        Me.cbSucursal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursal.Properties.ShowFooter = False
        Me.cbSucursal.Properties.ShowHeader = False
        Me.cbSucursal.Size = New System.Drawing.Size(426, 22)
        Me.cbSucursal.StyleController = Me.LayoutControl1
        Me.cbSucursal.TabIndex = 28
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(58, 36)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(426, 22)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 33
        '
        'AlCorte
        '
        Me.AlCorte.EditValue = Nothing
        Me.AlCorte.Location = New System.Drawing.Point(58, 12)
        Me.AlCorte.Name = "AlCorte"
        Me.AlCorte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlCorte.Properties.Appearance.Options.UseFont = True
        Me.AlCorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AlCorte.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AlCorte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.AlCorte.Size = New System.Drawing.Size(121, 20)
        Me.AlCorte.StyleController = Me.LayoutControl1
        Me.AlCorte.TabIndex = 29
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 88)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(472, 402)
        Me.iGrid.TabIndex = 7
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.GroupPanelText = "Arrastrar Columna Para Agrupar"
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsFind.ShowClearButton = False
        Me.iVista.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowChildrenInGroupPanel = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupedColumns = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(496, 502)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(476, 406)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.AlCorte
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Al Corte:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMoneda
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(476, 26)
        Me.LayoutControlItem3.Text = "Moneda:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(43, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(171, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(305, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbSucursal
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(476, 26)
        Me.LayoutControlItem5.Text = "Sucursal"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(43, 13)
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
        Me.DockPanel1.ID = New System.Guid("c549dfae-a18d-4a77-87da-0b86dd7186d9")
        Me.DockPanel1.Location = New System.Drawing.Point(496, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 502)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 475)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(687, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 475)
        Me.LayoutControl2.TabIndex = 2
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 425)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 12)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(108, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Generar"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 383)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(108, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Exportar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 475)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdImprimir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAyuda
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 371)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSalir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 413)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(112, 329)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmBuroCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 502)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmBuroCredito"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlCorte.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
