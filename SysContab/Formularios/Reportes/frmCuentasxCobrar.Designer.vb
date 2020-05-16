<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasxCobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentasxCobrar))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.cbSucursal)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(621, 421)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(59, 38)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(550, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 175
        '
        'cbSucursal
        '
        Me.cbSucursal.Location = New System.Drawing.Point(59, 12)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.Appearance.Options.UseFont = True
        Me.cbSucursal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursal.Properties.ShowFooter = False
        Me.cbSucursal.Properties.ShowHeader = False
        Me.cbSucursal.Size = New System.Drawing.Size(550, 22)
        Me.cbSucursal.StyleController = Me.LayoutControl1
        Me.cbSucursal.TabIndex = 29
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 62)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(597, 347)
        Me.iGrid.TabIndex = 4
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
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(621, 421)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.iGrid
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(601, 351)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbSucursal
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(601, 26)
        Me.LayoutControlItem7.Text = "Sucursal:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(44, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbMoneda
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(601, 24)
        Me.LayoutControlItem8.Text = "Moneda:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(44, 13)
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
        Me.DockPanel1.ID = New System.Guid("96daec58-d5b0-4ac2-bc50-3f65877037de")
        Me.DockPanel1.Location = New System.Drawing.Point(621, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(160, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(160, 421)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(152, 394)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.Hasta)
        Me.LayoutControl2.Controls.Add(Me.Desde)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(832, 569, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(152, 394)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 302)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(128, 38)
        Me.SimpleButton3.StyleController = Me.LayoutControl2
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "E&xportar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 344)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(128, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 92)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(128, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(12, 68)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(128, 20)
        Me.Hasta.StyleController = Me.LayoutControl2
        Me.Hasta.TabIndex = 5
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(12, 28)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Size = New System.Drawing.Size(128, 20)
        Me.Desde.StyleController = Me.LayoutControl2
        Me.Desde.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(152, 394)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Desde
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Hasta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(132, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 106)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(132, 184)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 332)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton3
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 290)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'frmCuentasxCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 421)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmCuentasxCobrar"
        Me.Text = "Cuentas por Cobrar"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
