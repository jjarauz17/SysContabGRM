<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesLetrasAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesLetrasAdd))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Salir = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtANombre = New DevExpress.XtraEditors.TextEdit()
        Me.mComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtTCambio = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.dVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.dFecha = New DevExpress.XtraEditors.DateEdit()
        Me.cbClientes = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtANombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.Salir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl.Size = New System.Drawing.Size(587, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Guardar"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Salir
        '
        Me.Salir.Caption = "Salir"
        Me.Salir.Id = 2
        Me.Salir.ImageOptions.Image = CType(resources.GetObject("Salir.ImageOptions.Image"), System.Drawing.Image)
        Me.Salir.ImageOptions.LargeImage = CType(resources.GetObject("Salir.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Salir.Name = "Salir"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Acciones"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.Salir)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 520)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(587, 31)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtANombre)
        Me.LayoutControl1.Controls.Add(Me.mComentarios)
        Me.LayoutControl1.Controls.Add(Me.txtMonto)
        Me.LayoutControl1.Controls.Add(Me.txtTCambio)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.dVencimiento)
        Me.LayoutControl1.Controls.Add(Me.dFecha)
        Me.LayoutControl1.Controls.Add(Me.cbClientes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(639, 344, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(587, 377)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtANombre
        '
        Me.txtANombre.Location = New System.Drawing.Point(79, 36)
        Me.txtANombre.MenuManager = Me.RibbonControl
        Me.txtANombre.Name = "txtANombre"
        Me.txtANombre.Size = New System.Drawing.Size(496, 20)
        Me.txtANombre.StyleController = Me.LayoutControl1
        Me.txtANombre.TabIndex = 10
        Me.txtANombre.Tag = "True"
        '
        'mComentarios
        '
        Me.mComentarios.Location = New System.Drawing.Point(79, 136)
        Me.mComentarios.MenuManager = Me.RibbonControl
        Me.mComentarios.Name = "mComentarios"
        Me.mComentarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mComentarios.Properties.Appearance.Options.UseFont = True
        Me.mComentarios.Size = New System.Drawing.Size(496, 95)
        Me.mComentarios.StyleController = Me.LayoutControl1
        Me.mComentarios.TabIndex = 10
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtMonto.Location = New System.Drawing.Point(79, 110)
        Me.txtMonto.MenuManager = Me.RibbonControl
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtMonto.Properties.Appearance.Options.UseBackColor = True
        Me.txtMonto.Properties.Appearance.Options.UseFont = True
        Me.txtMonto.Properties.Appearance.Options.UseForeColor = True
        Me.txtMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Size = New System.Drawing.Size(158, 22)
        Me.txtMonto.StyleController = Me.LayoutControl1
        Me.txtMonto.TabIndex = 9
        '
        'txtTCambio
        '
        Me.txtTCambio.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTCambio.Location = New System.Drawing.Point(468, 84)
        Me.txtTCambio.MenuManager = Me.RibbonControl
        Me.txtTCambio.Name = "txtTCambio"
        Me.txtTCambio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTCambio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCambio.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTCambio.Properties.Appearance.Options.UseBackColor = True
        Me.txtTCambio.Properties.Appearance.Options.UseFont = True
        Me.txtTCambio.Properties.Appearance.Options.UseForeColor = True
        Me.txtTCambio.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTCambio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCambio.Properties.Mask.EditMask = "n4"
        Me.txtTCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCambio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCambio.Size = New System.Drawing.Size(107, 22)
        Me.txtTCambio.StyleController = Me.LayoutControl1
        Me.txtTCambio.TabIndex = 8
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(79, 84)
        Me.cbMoneda.MenuManager = Me.RibbonControl
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(318, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 7
        '
        'dVencimiento
        '
        Me.dVencimiento.EditValue = Nothing
        Me.dVencimiento.Location = New System.Drawing.Point(419, 60)
        Me.dVencimiento.MenuManager = Me.RibbonControl
        Me.dVencimiento.Name = "dVencimiento"
        Me.dVencimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dVencimiento.Properties.Appearance.Options.UseFont = True
        Me.dVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dVencimiento.Size = New System.Drawing.Size(156, 20)
        Me.dVencimiento.StyleController = Me.LayoutControl1
        Me.dVencimiento.TabIndex = 6
        '
        'dFecha
        '
        Me.dFecha.EditValue = Nothing
        Me.dFecha.Location = New System.Drawing.Point(79, 60)
        Me.dFecha.MenuManager = Me.RibbonControl
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Properties.Appearance.Options.UseFont = True
        Me.dFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dFecha.Size = New System.Drawing.Size(158, 20)
        Me.dFecha.StyleController = Me.LayoutControl1
        Me.dFecha.TabIndex = 5
        '
        'cbClientes
        '
        Me.cbClientes.Location = New System.Drawing.Point(79, 12)
        Me.cbClientes.MenuManager = Me.RibbonControl
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Properties.Appearance.Options.UseFont = True
        Me.cbClientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClientes.Properties.View = Me.SearchLookUpEdit1View
        Me.cbClientes.Size = New System.Drawing.Size(496, 20)
        Me.cbClientes.StyleController = Me.LayoutControl1
        Me.cbClientes.TabIndex = 4
        Me.cbClientes.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem4, Me.LayoutControlItem3, Me.EmptySpaceItem5, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(587, 377)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbClientes
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(567, 24)
        Me.LayoutControlItem1.Text = "Cliente:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 223)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(567, 134)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dFecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbMoneda
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(389, 26)
        Me.LayoutControlItem4.Text = "Moneda:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtMonto
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(229, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Monto:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.mComentarios
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 99)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(81, 99)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(567, 99)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Comentarios:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtANombre
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(567, 24)
        Me.LayoutControlItem8.Text = "A Nombre:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(229, 98)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(338, 26)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dVencimiento
        Me.LayoutControlItem3.Location = New System.Drawing.Point(340, 48)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(227, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Vencimiento:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(229, 48)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(111, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTCambio
        Me.LayoutControlItem5.Location = New System.Drawing.Point(389, 72)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(178, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(178, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(178, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "T/Cambio:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(64, 13)
        '
        'frmClientesLetrasAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 551)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmClientesLetrasAdd"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtANombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Salir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbClientes As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents mComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtANombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
