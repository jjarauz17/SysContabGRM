Public Class FrmComprasCrossTab
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents sel3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sel1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProducto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iPivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bRestaurarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprasCrossTab))
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.iPivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbProducto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sel1 = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.bRestaurarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.sel3 = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.DefaultExt = "*.xml"
        Me.Guardar.Filter = "(*.xml)|*.xml"
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit3)
        Me.LayoutControl1.Controls.Add(Me.iPivotGrid)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit4)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit2)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.cbProducto)
        Me.LayoutControl1.Controls.Add(Me.cbProveedor)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(439, 512)
        Me.LayoutControl1.TabIndex = 181
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(295, 38)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit3.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit3.Properties.Caption = "Quitar Gran Total"
        Me.CheckEdit3.Size = New System.Drawing.Size(132, 19)
        Me.CheckEdit3.StyleController = Me.LayoutControl1
        Me.CheckEdit3.TabIndex = 184
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
        Me.iPivotGrid.Location = New System.Drawing.Point(12, 64)
        Me.iPivotGrid.Name = "iPivotGrid"
        Me.iPivotGrid.OptionsView.ShowCustomTotalsForSingleValues = True
        Me.iPivotGrid.Size = New System.Drawing.Size(415, 436)
        Me.iPivotGrid.TabIndex = 183
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(295, 12)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit4.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit4.Properties.Caption = "Quitar Sub Totales"
        Me.CheckEdit4.Size = New System.Drawing.Size(132, 19)
        Me.CheckEdit4.StyleController = Me.LayoutControl1
        Me.CheckEdit4.TabIndex = 183
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(12, 38)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Por Producto:"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit2.Size = New System.Drawing.Size(98, 22)
        Me.CheckEdit2.StyleController = Me.LayoutControl1
        Me.CheckEdit2.TabIndex = 188
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Por Proveedor:"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(98, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 187
        '
        'cbProducto
        '
        Me.cbProducto.Enabled = False
        Me.cbProducto.Location = New System.Drawing.Point(114, 38)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbProducto.Properties.Appearance.Options.UseFont = True
        Me.cbProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProducto.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProducto.Size = New System.Drawing.Size(177, 20)
        Me.cbProducto.StyleController = Me.LayoutControl1
        Me.cbProducto.TabIndex = 186
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbProveedor
        '
        Me.cbProveedor.Enabled = False
        Me.cbProveedor.Location = New System.Drawing.Point(114, 12)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.GridView2
        Me.cbProveedor.Size = New System.Drawing.Size(177, 20)
        Me.cbProveedor.StyleController = Me.LayoutControl1
        Me.cbProveedor.TabIndex = 185
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem4, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(439, 512)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbProveedor
        Me.LayoutControlItem7.Location = New System.Drawing.Point(102, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(181, 26)
        Me.LayoutControlItem7.Text = "Por Proveedor:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbProducto
        Me.LayoutControlItem5.Location = New System.Drawing.Point(102, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(181, 26)
        Me.LayoutControlItem5.Text = "Por Prodcuto:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CheckEdit1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit2
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.iPivotGrid
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(419, 440)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.CheckEdit4
        Me.LayoutControlItem16.Location = New System.Drawing.Point(283, 0)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckEdit3
        Me.LayoutControlItem17.Location = New System.Drawing.Point(283, 26)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(136, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'sel1
        '
        Me.sel1.EditValue = Nothing
        Me.sel1.Location = New System.Drawing.Point(12, 28)
        Me.sel1.Name = "sel1"
        Me.sel1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel1.Properties.Appearance.Options.UseFont = True
        Me.sel1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel1.Size = New System.Drawing.Size(128, 20)
        Me.sel1.StyleController = Me.LayoutControl2
        Me.sel1.TabIndex = 4
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bSalir)
        Me.LayoutControl2.Controls.Add(Me.bGrafico)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.bGuardarEsquema)
        Me.LayoutControl2.Controls.Add(Me.bRestaurarEsquema)
        Me.LayoutControl2.Controls.Add(Me.cbMoneda)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.sel1)
        Me.LayoutControl2.Controls.Add(Me.sel3)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(152, 485)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bSalir
        '
        Me.bSalir.Appearance.Options.UseTextOptions = True
        Me.bSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(12, 435)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(128, 38)
        Me.bSalir.StyleController = Me.LayoutControl2
        Me.bSalir.TabIndex = 186
        Me.bSalir.Text = "&Salir"
        '
        'bGrafico
        '
        Me.bGrafico.Appearance.Options.UseTextOptions = True
        Me.bGrafico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGrafico.Image = CType(resources.GetObject("bGrafico.Image"), System.Drawing.Image)
        Me.bGrafico.Location = New System.Drawing.Point(12, 267)
        Me.bGrafico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGrafico.Name = "bGrafico"
        Me.bGrafico.Size = New System.Drawing.Size(128, 38)
        Me.bGrafico.StyleController = Me.LayoutControl2
        Me.bGrafico.TabIndex = 187
        Me.bGrafico.Text = "&Gráfico"
        '
        'bExportar
        '
        Me.bExportar.Appearance.Options.UseTextOptions = True
        Me.bExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 393)
        Me.bExportar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(128, 38)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 185
        Me.bExportar.Text = "E&xportar"
        '
        'bGuardarEsquema
        '
        Me.bGuardarEsquema.Appearance.Options.UseTextOptions = True
        Me.bGuardarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardarEsquema.Image = CType(resources.GetObject("bGuardarEsquema.Image"), System.Drawing.Image)
        Me.bGuardarEsquema.Location = New System.Drawing.Point(12, 309)
        Me.bGuardarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGuardarEsquema.Name = "bGuardarEsquema"
        Me.bGuardarEsquema.Size = New System.Drawing.Size(128, 38)
        Me.bGuardarEsquema.StyleController = Me.LayoutControl2
        Me.bGuardarEsquema.TabIndex = 183
        Me.bGuardarEsquema.Text = "&Guardar Esquema"
        '
        'bRestaurarEsquema
        '
        Me.bRestaurarEsquema.Appearance.Options.UseTextOptions = True
        Me.bRestaurarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRestaurarEsquema.Image = CType(resources.GetObject("bRestaurarEsquema.Image"), System.Drawing.Image)
        Me.bRestaurarEsquema.Location = New System.Drawing.Point(12, 351)
        Me.bRestaurarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bRestaurarEsquema.Name = "bRestaurarEsquema"
        Me.bRestaurarEsquema.Size = New System.Drawing.Size(128, 38)
        Me.bRestaurarEsquema.StyleController = Me.LayoutControl2
        Me.bRestaurarEsquema.TabIndex = 184
        Me.bRestaurarEsquema.Text = "&Restaurar Esquema"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(12, 108)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(128, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl2
        Me.cbMoneda.TabIndex = 185
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 132)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(128, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 184
        Me.SimpleButton1.Text = "&Buscar"
        '
        'sel3
        '
        Me.sel3.EditValue = Nothing
        Me.sel3.Location = New System.Drawing.Point(12, 68)
        Me.sel3.Name = "sel3"
        Me.sel3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel3.Properties.Appearance.Options.UseFont = True
        Me.sel3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel3.Size = New System.Drawing.Size(128, 20)
        Me.sel3.StyleController = Me.LayoutControl2
        Me.sel3.TabIndex = 182
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(152, 485)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.sel1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sel3
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbMoneda
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(132, 40)
        Me.LayoutControlItem10.Text = "Moneda:"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(132, 93)
        Me.LayoutControlItem3.Text = "Moneda:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.bGrafico
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bGuardarEsquema
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 297)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bRestaurarEsquema
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 339)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bExportar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 381)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.bSalir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 423)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("770b771b-47ac-42f6-abe3-725cc98bed68")
        Me.DockPanel1.Location = New System.Drawing.Point(439, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(160, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(160, 512)
        Me.DockPanel1.Text = "Opciones:"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(152, 485)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmComprasCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(599, 512)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmComprasCrossTab"
        Me.Text = "Compras CrossTab"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Shared ChildInstance As FrmComprasCrossTab = Nothing

    Public Shared Function Instance() As FrmComprasCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmComprasCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function


    'Dim r As New VB.SysContab.Rutinas

    Public Function MyDataset() As DataSet

        Return VB.SysContab.ReportesCrossTabDB.FacturasComprasCrossTab("0", 0, sel1.DateTime.Date, sel3.DateTime.Date, IIf(cbProveedor.EditValue Is Nothing, 0, cbProveedor.EditValue), "", "", _
                                                           0, 99999999, "", "", 0, 9999999, 0, 1, 3, EmpresaActual)
    End Function

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ShowSplash()
            iPivotGrid.DataSource = MyDataset().Tables(0)
            HideSplash()
        Catch ex As Exception
            HideSplash()
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmEstadoSituacionCrossTab_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'r.CambiarEstilo(Me)
        'Dim Tasa As New VB.SysContab.Tasa_CambioDB
        'cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        'cbMonedaCambio.ValueMember = "MonedaCambio"
        'cbMonedaCambio.DisplayMember = "Nombre"
        'Dim Cli As New VB.SysContab.ProveedoresDB
        'Dim FormPago As New VB.SysContab.Forma_PagoDB
        'ddlCliente.DataSource = Cli.GetListFiltro().Tables(0)
        'ddlCliente.ValueMember = "CODIGO"
        'ddlCliente.DisplayMember = "Nombre"
        'ddlTipoVenta.DataSource = FormPago.GetListTodos().Tables(0)
        'ddlTipoVenta.ValueMember = "Codigo"
        'ddlTipoVenta.DisplayMember = "Nombre"
        'sel1.Value = "01/" & Now.Month & "/" & Now.Year
        'sel3.Value = CDate(Date.DaysInMonth(Now.Year, Now.Month) & "/" & Now.Month & "/" & Now.Year)
        'sel1.Value = New DateTime(Now.Year, Now.Month, 1)
        'sel3.Value = New DateTime(Now.Year, Now.Month, Date.DaysInMonth(Now.Year, Now.Month))

        SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ListaProveedores("%", 0).Tables("Proveedores"), "NOMBRE", "CODIGO", 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)
        Dim DT As DataTable = ObtieneDatos("SP_ArticulosGetAll", "A", EmpresaActual, "0")

        SearchLookUp(cbProducto, DT, "Display", "Codigo", 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        cbProducto.Properties.View.Columns("PrecioU").Caption = "Precio U$"

        GetMonedasList(cbMoneda)

        sel1.DateTime = New DateTime(Now.Year, Now.Month, 1)
        sel3.DateTime = UltimoDiaDelMes(Now.Date)

        LlenarGrid()
        FormatoPivot(iPivotGrid)

        'If MyDataset.Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-1)), 1)   '"01/" & Month(Now.AddMonths(-1)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If

        'If MyDataset.Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-2)), 1) '"01/" & Month(Now.AddMonths(-2)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If

        'If MyDataset.Tables(0).Rows.Count = 0 Then
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-3)), 1) '"01/" & Month(Now.AddMonths(-3)) & "/" & Now.Year
        'Else
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'End If
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = ObtieneDatos("sp_FacturasComprasListCrossTabNew", IIf(CheckEdit1.Checked, IsNull(cbProveedor.EditValue, 0), 0),
                                                                                IIf(CheckEdit2.Checked, IsNull(cbProducto.EditValue, ""), ""),
                                                                                sel1.DateTime.Date,
                                                                                sel3.DateTime.Date,
                                                                                cbMoneda.EditValue,
                                                                                EmpresaActual)


        iPivotGrid.DataSource = DT
        iPivotGrid.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '       
        iPivotGrid.Fields("Proveedor").Width = 250
        iPivotGrid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '
        iPivotGrid.Fields("Sub Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("IVA").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '
        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        '
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub


    Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs)

        Dim form As New FrmDetalleComprasCrossTab
        form.Text = "Detalle de Compras"
        form.StartPosition = FormStartPosition.CenterParent

        form.Grid.Parent = form
        form.Grid.Dock = DockStyle.Fill
        form.Grid.DataSource = e.CreateDrillDownDataSource()

        form.Width = 1024
        form.Height = 400
        form.ShowDialog()
        form.Dispose()
    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmExportarImprimir.Mostrar(iPivotGrid, Me.Text)
        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(PivotGrid)
    End Sub

    Private Sub cmdGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim forma As New frmgraficosxtra
        forma.Mostrar(frmgraficosxtra.TipoGrafico.Compras, iPivotGrid.CreateSummaryDataSource, False, iPivotGrid)
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        MyDataset.WriteXml(Guardar.FileName)
    End Sub


    Private Sub cmdguardare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        iPivotGrid.SaveLayoutToXml(Guardar.FileName)
    End Sub

    Private Sub cmdcargare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        iPivotGrid.RestoreLayoutFromXml(Abrir.FileName)
        iPivotGrid.Refresh()
    End Sub

    Private Sub cmdabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        MyDataset.ReadXml(Abrir.FileName)
        iPivotGrid.Refresh()
        iPivotGrid.RefreshData()
    End Sub

    Private Sub cmdnewgrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim forma As New frmgraficosxtra
        forma.Mostrar(frmgraficosxtra.TipoGrafico.BalanzaComprobacion, iPivotGrid.CreateSummaryDataSource, True, iPivotGrid)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        cbProveedor.Enabled = CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        cbProducto.Enabled = CheckEdit2.Checked
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        Dim DT As DataTable = ObtieneDatos("sp_FacturasComprasListCrossTabNew", IIf(CheckEdit1.Checked, IsNull(cbProveedor.EditValue, 0), 0),
                                                                        IIf(CheckEdit2.Checked, IsNull(cbProducto.EditValue, ""), ""),
                                                                        sel1.DateTime.Date,
                                                                        sel3.DateTime.Date,
                                                                        cbMoneda.EditValue,
                                                                        EmpresaActual)


        iPivotGrid.DataSource = DT
        HideSplash()
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Compras"

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bGuardarEsquema_Click(sender As Object, e As EventArgs) Handles bGuardarEsquema.Click
        If Guardar.ShowDialog = DialogResult.OK Then
            iPivotGrid.SaveLayoutToXml(Guardar.FileName)
        End If
    End Sub

    Private Sub bRestaurarEsquema_Click(sender As Object, e As EventArgs) Handles bRestaurarEsquema.Click
        If Abrir.ShowDialog = DialogResult.OK Then
            CargarEsquemaDefault(Abrir.FileName)
        End If
    End Sub

    Private Sub CargarEsquemaDefault(ByVal NombreArchivo As String)
        If Not NombreArchivo.ToString = vbNullString Then

            If System.IO.File.Exists(NombreArchivo) Then
                iPivotGrid.RestoreLayoutFromXml(NombreArchivo)
                iPivotGrid.Refresh()
            End If
        End If
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        close()
    End Sub

    Private Sub CheckEdit4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit4.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
    End Sub
End Class
