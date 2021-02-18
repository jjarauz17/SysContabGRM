<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresuGastoResumen
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresuGastoResumen))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.bVerPresupuesto = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.bReporteGasto = New DevExpress.XtraEditors.SimpleButton()
        Me.bAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.bActualizarReal = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.bUpdateReal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bUpdateReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbPeriodo)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(801, 553)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(51, 12)
        Me.cbPeriodo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Size = New System.Drawing.Size(738, 20)
        Me.cbPeriodo.StyleController = Me.LayoutControl1
        Me.cbPeriodo.TabIndex = 7
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 36)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(777, 505)
        Me.iGrid.TabIndex = 4
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.DetailHeight = 284
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(801, 553)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(781, 509)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbPeriodo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(781, 24)
        Me.LayoutControlItem4.Text = "Periodo"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(36, 13)
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.SvgImage = CType(resources.GetObject("bSalir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bSalir.Location = New System.Drawing.Point(12, 476)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(129, 36)
        Me.bSalir.StyleController = Me.LayoutControl3
        Me.bSalir.TabIndex = 10
        Me.bSalir.Text = "&Salir"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.bVerPresupuesto)
        Me.LayoutControl3.Controls.Add(Me.bSalir)
        Me.LayoutControl3.Controls.Add(Me.bNuevo)
        Me.LayoutControl3.Controls.Add(Me.bExportar)
        Me.LayoutControl3.Controls.Add(Me.bEditar)
        Me.LayoutControl3.Controls.Add(Me.bReporteGasto)
        Me.LayoutControl3.Controls.Add(Me.bAnular)
        Me.LayoutControl3.Controls.Add(Me.bActualizarReal)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(153, 524)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'bVerPresupuesto
        '
        Me.bVerPresupuesto.Appearance.Options.UseTextOptions = True
        Me.bVerPresupuesto.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bVerPresupuesto.Enabled = False
        Me.bVerPresupuesto.ImageOptions.SvgImage = CType(resources.GetObject("bVerPresupuesto.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bVerPresupuesto.Location = New System.Drawing.Point(12, 92)
        Me.bVerPresupuesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bVerPresupuesto.Name = "bVerPresupuesto"
        Me.bVerPresupuesto.Size = New System.Drawing.Size(129, 36)
        Me.bVerPresupuesto.StyleController = Me.LayoutControl3
        Me.bVerPresupuesto.TabIndex = 11
        Me.bVerPresupuesto.Text = "&Ver Presupuesto"
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.SvgImage = CType(resources.GetObject("bNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bNuevo.Location = New System.Drawing.Point(12, 12)
        Me.bNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(129, 36)
        Me.bNuevo.StyleController = Me.LayoutControl3
        Me.bNuevo.TabIndex = 4
        Me.bNuevo.Text = "&Nuevo"
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.SvgImage = CType(resources.GetObject("bExportar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bExportar.Location = New System.Drawing.Point(12, 436)
        Me.bExportar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(129, 36)
        Me.bExportar.StyleController = Me.LayoutControl3
        Me.bExportar.TabIndex = 9
        Me.bExportar.Text = "E&xportar"
        '
        'bEditar
        '
        Me.bEditar.Enabled = False
        Me.bEditar.ImageOptions.SvgImage = CType(resources.GetObject("bEditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bEditar.Location = New System.Drawing.Point(12, 52)
        Me.bEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(129, 36)
        Me.bEditar.StyleController = Me.LayoutControl3
        Me.bEditar.TabIndex = 8
        Me.bEditar.Text = "&Editar"
        '
        'bReporteGasto
        '
        Me.bReporteGasto.Enabled = False
        Me.bReporteGasto.ImageOptions.SvgImage = CType(resources.GetObject("bReporteGasto.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bReporteGasto.Location = New System.Drawing.Point(12, 132)
        Me.bReporteGasto.Name = "bReporteGasto"
        Me.bReporteGasto.Size = New System.Drawing.Size(129, 36)
        Me.bReporteGasto.StyleController = Me.LayoutControl3
        Me.bReporteGasto.TabIndex = 7
        Me.bReporteGasto.Text = "Reporte General"
        '
        'bAnular
        '
        Me.bAnular.Enabled = False
        Me.bAnular.ImageOptions.SvgImage = CType(resources.GetObject("bAnular.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bAnular.Location = New System.Drawing.Point(12, 172)
        Me.bAnular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bAnular.Name = "bAnular"
        Me.bAnular.Size = New System.Drawing.Size(129, 36)
        Me.bAnular.StyleController = Me.LayoutControl3
        Me.bAnular.TabIndex = 5
        Me.bAnular.Text = "Anular"
        '
        'bActualizarReal
        '
        Me.bActualizarReal.Enabled = False
        Me.bActualizarReal.ImageOptions.SvgImage = CType(resources.GetObject("bActualizarReal.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bActualizarReal.Location = New System.Drawing.Point(12, 212)
        Me.bActualizarReal.Name = "bActualizarReal"
        Me.bActualizarReal.Size = New System.Drawing.Size(129, 36)
        Me.bActualizarReal.StyleController = Me.LayoutControl3
        Me.bActualizarReal.TabIndex = 6
        Me.bActualizarReal.Text = "Actualizar Real"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.bUpdateReal, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem2, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(153, 524)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bNuevo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 240)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(133, 184)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bEditar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bAnular
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'bUpdateReal
        '
        Me.bUpdateReal.Control = Me.bActualizarReal
        Me.bUpdateReal.Location = New System.Drawing.Point(0, 200)
        Me.bUpdateReal.Name = "bUpdateReal"
        Me.bUpdateReal.Size = New System.Drawing.Size(133, 40)
        Me.bUpdateReal.TextSize = New System.Drawing.Size(0, 0)
        Me.bUpdateReal.TextVisible = False
        Me.bUpdateReal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bExportar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bSalir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 464)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bVerPresupuesto
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bReporteGasto
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("480c9a42-6352-400f-91ef-447fbcee0558")
        Me.DockPanel1.Location = New System.Drawing.Point(801, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(160, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(160, 553)
        Me.DockPanel1.Text = "Acciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl3)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(153, 524)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PresuGastoResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 553)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PresuGastoResumen"
        Me.Text = "PresuGastoResumen"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bUpdateReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bActualizarReal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bReporteGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bUpdateReal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents bVerPresupuesto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
