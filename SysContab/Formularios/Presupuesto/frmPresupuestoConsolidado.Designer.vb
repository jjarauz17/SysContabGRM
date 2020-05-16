<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestoConsolidado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuestoConsolidado))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.iPivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.bActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bRestaurarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.iPivotGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(359, 312)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'iPivotGrid
        '
        Me.iPivotGrid.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iPivotGrid.Appearance.FieldHeader.Options.UseFont = True
        Me.iPivotGrid.Appearance.FieldHeader.Options.UseTextOptions = True
        Me.iPivotGrid.Appearance.FieldHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iPivotGrid.Appearance.FieldHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iPivotGrid.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iPivotGrid.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.iPivotGrid.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iPivotGrid.Appearance.FieldValueTotal.Options.UseFont = True
        Me.iPivotGrid.Location = New System.Drawing.Point(12, 12)
        Me.iPivotGrid.Name = "iPivotGrid"
        Me.iPivotGrid.OptionsView.ShowCustomTotalsForSingleValues = True
        Me.iPivotGrid.Size = New System.Drawing.Size(335, 288)
        Me.iPivotGrid.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(359, 312)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iPivotGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(339, 292)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("b6624b73-f31c-456c-9ea2-fd0d96d6101c")
        Me.DockPanel1.Location = New System.Drawing.Point(359, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 312)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl3)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 285)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.bActualizar)
        Me.LayoutControl3.Controls.Add(Me.bGrafico)
        Me.LayoutControl3.Controls.Add(Me.bSalir)
        Me.LayoutControl3.Controls.Add(Me.bExportar)
        Me.LayoutControl3.Controls.Add(Me.bRestaurarEsquema)
        Me.LayoutControl3.Controls.Add(Me.bGuardarEsquema)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1282, 193, 250, 350)
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(141, 285)
        Me.LayoutControl3.TabIndex = 1
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'bActualizar
        '
        Me.bActualizar.Appearance.Options.UseTextOptions = True
        Me.bActualizar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bActualizar.ImageOptions.Image = CType(resources.GetObject("bActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.bActualizar.Location = New System.Drawing.Point(12, 54)
        Me.bActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(118, 38)
        Me.bActualizar.StyleController = Me.LayoutControl3
        Me.bActualizar.TabIndex = 6
        Me.bActualizar.Text = "&Actualizar"
        '
        'bGrafico
        '
        Me.bGrafico.Appearance.Options.UseTextOptions = True
        Me.bGrafico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGrafico.ImageOptions.Image = CType(resources.GetObject("bGrafico.ImageOptions.Image"), System.Drawing.Image)
        Me.bGrafico.Location = New System.Drawing.Point(12, 12)
        Me.bGrafico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGrafico.Name = "bGrafico"
        Me.bGrafico.Size = New System.Drawing.Size(118, 38)
        Me.bGrafico.StyleController = Me.LayoutControl3
        Me.bGrafico.TabIndex = 11
        Me.bGrafico.Text = "&Gráfico"
        '
        'bSalir
        '
        Me.bSalir.Appearance.Options.UseTextOptions = True
        Me.bSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(12, 232)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(118, 38)
        Me.bSalir.StyleController = Me.LayoutControl3
        Me.bSalir.TabIndex = 8
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Appearance.Options.UseTextOptions = True
        Me.bExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 190)
        Me.bExportar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(118, 38)
        Me.bExportar.StyleController = Me.LayoutControl3
        Me.bExportar.TabIndex = 7
        Me.bExportar.Text = "E&xportar"
        '
        'bRestaurarEsquema
        '
        Me.bRestaurarEsquema.Appearance.Options.UseTextOptions = True
        Me.bRestaurarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRestaurarEsquema.ImageOptions.Image = CType(resources.GetObject("bRestaurarEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bRestaurarEsquema.Location = New System.Drawing.Point(12, 138)
        Me.bRestaurarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bRestaurarEsquema.Name = "bRestaurarEsquema"
        Me.bRestaurarEsquema.Size = New System.Drawing.Size(118, 38)
        Me.bRestaurarEsquema.StyleController = Me.LayoutControl3
        Me.bRestaurarEsquema.TabIndex = 6
        Me.bRestaurarEsquema.Text = "&Restaurar Esquema"
        '
        'bGuardarEsquema
        '
        Me.bGuardarEsquema.Appearance.Options.UseTextOptions = True
        Me.bGuardarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardarEsquema.ImageOptions.Image = CType(resources.GetObject("bGuardarEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardarEsquema.Location = New System.Drawing.Point(12, 96)
        Me.bGuardarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGuardarEsquema.Name = "bGuardarEsquema"
        Me.bGuardarEsquema.Size = New System.Drawing.Size(118, 38)
        Me.bGuardarEsquema.StyleController = Me.LayoutControl3
        Me.bGuardarEsquema.TabIndex = 5
        Me.bGuardarEsquema.Text = "&Guardar Esquema"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Root"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(142, 282)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bGuardarEsquema
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bRestaurarEsquema
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bExportar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSalir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bGrafico
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bActualizar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'Guardar
        '
        Me.Guardar.Filter = "(*.xml)|*.xml"
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'frmPresupuestoConsolidado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 312)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmPresupuestoConsolidado"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iPivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bRestaurarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
End Class
