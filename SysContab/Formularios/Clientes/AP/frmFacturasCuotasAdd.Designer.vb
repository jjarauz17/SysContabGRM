<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasCuotasAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasCuotasAdd))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.bImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.bGenerarTabla = New DevExpress.XtraEditors.SimpleButton()
        Me.iGridAP = New DevExpress.XtraGrid.GridControl()
        Me.iVistaAP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.FechaInicial = New DevExpress.XtraEditors.DateEdit()
        Me.bSolicitar = New DevExpress.XtraEditors.SimpleButton()
        Me.sCuotas = New DevExpress.XtraEditors.SpinEdit()
        Me.tMonto = New DevExpress.XtraEditors.TextEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.cbFactura = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyFechaInicio = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGridAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.bGuardar, Me.bSalir, Me.bImprimir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl.Size = New System.Drawing.Size(824, 89)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'bGuardar
        '
        Me.bGuardar.Caption = "&Guardar"
        Me.bGuardar.Id = 1
        Me.bGuardar.ImageOptions.SvgImage = CType(resources.GetObject("bGuardar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bGuardar.Name = "bGuardar"
        '
        'bSalir
        '
        Me.bSalir.Caption = "&Salir"
        Me.bSalir.Id = 2
        Me.bSalir.ImageOptions.SvgImage = CType(resources.GetObject("bSalir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bSalir.Name = "bSalir"
        '
        'bImprimir
        '
        Me.bImprimir.Caption = "Imprimir"
        Me.bImprimir.Id = 3
        Me.bImprimir.ImageOptions.SvgImage = CType(resources.GetObject("bImprimir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bImprimir.Name = "bImprimir"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Opciones"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bImprimir)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bSalir)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Acciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 662)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(824, 24)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.bGenerarTabla)
        Me.LayoutControl1.Controls.Add(Me.iGridAP)
        Me.LayoutControl1.Controls.Add(Me.FechaInicial)
        Me.LayoutControl1.Controls.Add(Me.bSolicitar)
        Me.LayoutControl1.Controls.Add(Me.sCuotas)
        Me.LayoutControl1.Controls.Add(Me.tMonto)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.cbFactura)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 89)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(901, 276, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(824, 573)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(546, 62)
        Me.cbMoneda.MenuManager = Me.RibbonControl
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMoneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.ReadOnly = True
        Me.cbMoneda.Size = New System.Drawing.Size(266, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 22
        Me.cbMoneda.Tag = "True"
        '
        'bGenerarTabla
        '
        Me.bGenerarTabla.ImageOptions.Image = CType(resources.GetObject("bGenerarTabla.ImageOptions.Image"), System.Drawing.Image)
        Me.bGenerarTabla.Location = New System.Drawing.Point(686, 88)
        Me.bGenerarTabla.Name = "bGenerarTabla"
        Me.bGenerarTabla.Size = New System.Drawing.Size(126, 22)
        Me.bGenerarTabla.StyleController = Me.LayoutControl1
        Me.bGenerarTabla.TabIndex = 19
        Me.bGenerarTabla.Text = "&Generar Tabla"
        '
        'iGridAP
        '
        Me.iGridAP.Location = New System.Drawing.Point(12, 136)
        Me.iGridAP.MainView = Me.iVistaAP
        Me.iGridAP.Name = "iGridAP"
        Me.iGridAP.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.iGridAP.Size = New System.Drawing.Size(800, 425)
        Me.iGridAP.TabIndex = 12
        Me.iGridAP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVistaAP})
        '
        'iVistaAP
        '
        Me.iVistaAP.GridControl = Me.iGridAP
        Me.iVistaAP.Name = "iVistaAP"
        Me.iVistaAP.OptionsBehavior.Editable = False
        Me.iVistaAP.OptionsView.ShowAutoFilterRow = True
        Me.iVistaAP.OptionsView.ShowFooter = True
        Me.iVistaAP.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'FechaInicial
        '
        Me.FechaInicial.EditValue = New Date(2021, 1, 2, 19, 32, 55, 0)
        Me.FechaInicial.Location = New System.Drawing.Point(408, 88)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaInicial.Properties.Appearance.Options.UseFont = True
        Me.FechaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaInicial.Size = New System.Drawing.Size(125, 20)
        Me.FechaInicial.StyleController = Me.LayoutControl1
        Me.FechaInicial.TabIndex = 16
        '
        'bSolicitar
        '
        Me.bSolicitar.ImageOptions.Image = CType(resources.GetObject("bSolicitar.ImageOptions.Image"), System.Drawing.Image)
        Me.bSolicitar.Location = New System.Drawing.Point(194, 88)
        Me.bSolicitar.Name = "bSolicitar"
        Me.bSolicitar.Size = New System.Drawing.Size(129, 22)
        Me.bSolicitar.StyleController = Me.LayoutControl1
        Me.bSolicitar.TabIndex = 21
        Me.bSolicitar.Text = "&Solicitar mas Cuotas"
        '
        'sCuotas
        '
        Me.sCuotas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sCuotas.Location = New System.Drawing.Point(66, 88)
        Me.sCuotas.Name = "sCuotas"
        Me.sCuotas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sCuotas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sCuotas.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sCuotas.Properties.Appearance.Options.UseBackColor = True
        Me.sCuotas.Properties.Appearance.Options.UseFont = True
        Me.sCuotas.Properties.Appearance.Options.UseForeColor = True
        Me.sCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sCuotas.Properties.Mask.EditMask = "d"
        Me.sCuotas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sCuotas.Properties.MaxLength = 2
        Me.sCuotas.Properties.MaxValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.sCuotas.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sCuotas.Size = New System.Drawing.Size(124, 24)
        Me.sCuotas.StyleController = Me.LayoutControl1
        Me.sCuotas.TabIndex = 17
        '
        'tMonto
        '
        Me.tMonto.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.tMonto.Location = New System.Drawing.Point(91, 62)
        Me.tMonto.Name = "tMonto"
        Me.tMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMonto.Properties.Appearance.Options.UseFont = True
        Me.tMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.tMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tMonto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tMonto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red
        Me.tMonto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tMonto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tMonto.Properties.Mask.EditMask = "n2"
        Me.tMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tMonto.Properties.ReadOnly = True
        Me.tMonto.Size = New System.Drawing.Size(183, 22)
        Me.tMonto.StyleController = Me.LayoutControl1
        Me.tMonto.TabIndex = 20
        '
        'Fecha
        '
        Me.Fecha.EditValue = New Date(2021, 1, 2, 19, 32, 55, 0)
        Me.Fecha.Location = New System.Drawing.Point(418, 36)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Fecha.Properties.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(141, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 15
        '
        'cbFactura
        '
        Me.cbFactura.Location = New System.Drawing.Point(78, 36)
        Me.cbFactura.Name = "cbFactura"
        Me.cbFactura.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFactura.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cbFactura.Properties.Appearance.Options.UseBackColor = True
        Me.cbFactura.Properties.Appearance.Options.UseFont = True
        Me.cbFactura.Properties.Appearance.Options.UseForeColor = True
        Me.cbFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFactura.Properties.PopupView = Me.GridView1
        Me.cbFactura.Size = New System.Drawing.Size(258, 22)
        Me.cbFactura.StyleController = Me.LayoutControl1
        Me.cbFactura.TabIndex = 7
        Me.cbFactura.Tag = "True"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(54, 12)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.Appearance.Options.UseFont = True
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(758, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 6
        Me.cbCliente.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.EmptySpaceItem3, Me.lyFechaInicio, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(824, 573)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbCliente
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(804, 24)
        Me.LayoutControlItem1.Text = "Cliente:"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbFactura
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(328, 26)
        Me.LayoutControlItem2.Text = "No. Factura:"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tMonto
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(266, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(266, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(266, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Monto Factura:"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.DimGray
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem8.Control = Me.iGridAP
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(804, 451)
        Me.LayoutControlItem8.Text = "Calendario de Pago"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(159, 19)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(551, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(253, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Fecha
        Me.LayoutControlItem3.Location = New System.Drawing.Point(328, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Fecha Factura:"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(525, 76)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(149, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyFechaInicio
        '
        Me.lyFechaInicio.Control = Me.FechaInicial
        Me.lyFechaInicio.Location = New System.Drawing.Point(315, 76)
        Me.lyFechaInicio.MaxSize = New System.Drawing.Size(210, 26)
        Me.lyFechaInicio.MinSize = New System.Drawing.Size(210, 26)
        Me.lyFechaInicio.Name = "lyFechaInicio"
        Me.lyFechaInicio.Size = New System.Drawing.Size(210, 26)
        Me.lyFechaInicio.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyFechaInicio.Text = "Fecha de Inicio:"
        Me.lyFechaInicio.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lyFechaInicio.TextSize = New System.Drawing.Size(76, 13)
        Me.lyFechaInicio.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bGenerarTabla
        Me.LayoutControlItem7.Location = New System.Drawing.Point(674, 76)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sCuotas
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "# Cuotas:"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMoneda
        Me.LayoutControlItem9.Location = New System.Drawing.Point(487, 50)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(317, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(317, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(317, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Moneda:"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(42, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSolicitar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(182, 76)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(133, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(133, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(133, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(266, 50)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(221, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmFacturasCuotasAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 686)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmFacturasCuotasAdd.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.KeyPreview = True
        Me.Name = "frmFacturasCuotasAdd"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Facturación en Cuotas"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGridAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFactura As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sCuotas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSolicitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FechaInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lyFechaInicio As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGridAP As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVistaAP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bGenerarTabla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
