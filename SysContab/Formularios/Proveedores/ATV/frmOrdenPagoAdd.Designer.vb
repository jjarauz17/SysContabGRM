<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenPagoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenPagoAdd))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.gbTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbBodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtOC = New DevExpress.XtraEditors.TextEdit()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbItems = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProyectos = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.FechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gbTipo)
        Me.LayoutControl1.Controls.Add(Me.etTasa)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.cbBodega)
        Me.LayoutControl1.Controls.Add(Me.txtOC)
        Me.LayoutControl1.Controls.Add(Me.bBuscar)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.txtOrden)
        Me.LayoutControl1.Controls.Add(Me.cbFormaPago)
        Me.LayoutControl1.Controls.Add(Me.FechaPago)
        Me.LayoutControl1.Controls.Add(Me.cbProveedor)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1208, 305, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1008, 453)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gbTipo
        '
        Me.gbTipo.EditValue = 0
        Me.gbTipo.Location = New System.Drawing.Point(91, 162)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.gbTipo.Properties.Appearance.Options.UseBackColor = True
        Me.gbTipo.Properties.Appearance.Options.UseFont = True
        Me.gbTipo.Properties.Appearance.Options.UseForeColor = True
        Me.gbTipo.Properties.Columns = 4
        Me.gbTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Insumos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Ambos")})
        Me.gbTipo.Size = New System.Drawing.Size(905, 50)
        Me.gbTipo.StyleController = Me.LayoutControl1
        Me.gbTipo.TabIndex = 166
        '
        'etTasa
        '
        Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(897, 136)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.Appearance.Options.UseBackColor = True
        Me.etTasa.Properties.Appearance.Options.UseFont = True
        Me.etTasa.Properties.Appearance.Options.UseForeColor = True
        Me.etTasa.Properties.Mask.EditMask = "n4"
        Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etTasa.Size = New System.Drawing.Size(99, 22)
        Me.etTasa.StyleController = Me.LayoutControl1
        Me.etTasa.TabIndex = 172
        '
        'cbMoneda
        '
        Me.cbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMoneda.EnterMoveNextControl = True
        Me.cbMoneda.Location = New System.Drawing.Point(780, 88)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Appearance.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(216, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 173
        '
        'cbBodega
        '
        Me.cbBodega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodega.EnterMoveNextControl = True
        Me.cbBodega.Location = New System.Drawing.Point(780, 112)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbBodega.Properties.Appearance.Options.UseFont = True
        Me.cbBodega.Properties.Appearance.Options.UseForeColor = True
        Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodega.Properties.NullText = ""
        Me.cbBodega.Properties.ShowFooter = False
        Me.cbBodega.Properties.ShowHeader = False
        Me.cbBodega.Size = New System.Drawing.Size(216, 20)
        Me.cbBodega.StyleController = Me.LayoutControl1
        Me.cbBodega.TabIndex = 174
        '
        'txtOC
        '
        Me.txtOC.Location = New System.Drawing.Point(780, 62)
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOC.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtOC.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtOC.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtOC.Properties.ReadOnly = True
        Me.txtOC.Size = New System.Drawing.Size(216, 20)
        Me.txtOC.StyleController = Me.LayoutControl1
        Me.txtOC.TabIndex = 26
        Me.txtOC.Tag = "True"
        '
        'bBuscar
        '
        Me.bBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Appearance.Options.UseFont = True
        Me.bBuscar.ImageOptions.Image = CType(resources.GetObject("bBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(866, 12)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(130, 22)
        Me.bBuscar.StyleController = Me.LayoutControl1
        Me.bBuscar.TabIndex = 30
        Me.bBuscar.Text = "Buscar O/C"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 216)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbItems, Me.cbCatalogo, Me.cbProyectos})
        Me.iGrid.Size = New System.Drawing.Size(984, 225)
        Me.iGrid.TabIndex = 29
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsCustomization.AllowColumnMoving = False
        Me.iVista.OptionsCustomization.AllowFilter = False
        Me.iVista.OptionsCustomization.AllowGroup = False
        Me.iVista.OptionsCustomization.AllowSort = False
        Me.iVista.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.iVista.OptionsFilter.AllowFilterEditor = False
        Me.iVista.OptionsFind.AllowFindPanel = False
        Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'cbItems
        '
        Me.cbItems.AutoHeight = False
        Me.cbItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbItems.Name = "cbItems"
        Me.cbItems.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.View = Me.RepositoryItemSearchLookUpEdit2View
        '
        'RepositoryItemSearchLookUpEdit2View
        '
        Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
        Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'cbProyectos
        '
        Me.cbProyectos.AutoHeight = False
        Me.cbProyectos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyectos.Name = "cbProyectos"
        Me.cbProyectos.View = Me.RepositoryItemSearchLookUpEdit3View
        '
        'RepositoryItemSearchLookUpEdit3View
        '
        Me.RepositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit3View.Name = "RepositoryItemSearchLookUpEdit3View"
        Me.RepositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(91, 88)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(606, 70)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 23
        Me.txtComentario.Tag = "True"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(461, 38)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(236, 20)
        Me.txtOrden.StyleController = Me.LayoutControl1
        Me.txtOrden.TabIndex = 27
        Me.txtOrden.Tag = "True"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(780, 38)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.ShowHeader = False
        Me.cbFormaPago.Size = New System.Drawing.Size(216, 20)
        Me.cbFormaPago.StyleController = Me.LayoutControl1
        Me.cbFormaPago.TabIndex = 26
        Me.cbFormaPago.Tag = "True"
        '
        'FechaPago
        '
        Me.FechaPago.EditValue = Nothing
        Me.FechaPago.Location = New System.Drawing.Point(316, 62)
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPago.Properties.Appearance.Options.UseFont = True
        Me.FechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaPago.Size = New System.Drawing.Size(140, 22)
        Me.FechaPago.StyleController = Me.LayoutControl1
        Me.FechaPago.TabIndex = 28
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(91, 12)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProveedor.Size = New System.Drawing.Size(771, 20)
        Me.cbProveedor.StyleController = Me.LayoutControl1
        Me.cbProveedor.TabIndex = 24
        Me.cbProveedor.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(91, 38)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(287, 20)
        Me.txtFactura.StyleController = Me.LayoutControl1
        Me.txtFactura.TabIndex = 25
        Me.txtFactura.Tag = "True"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(91, 62)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Fecha.Size = New System.Drawing.Size(142, 22)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 27
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem10, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.LayoutControlItem14})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 453)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(225, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtComentario
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(689, 74)
        Me.LayoutControlItem7.Text = "Concepto:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.iGrid
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 204)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(988, 229)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbProveedor
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(854, 26)
        Me.LayoutControlItem5.Text = "Proveedor:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bBuscar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(854, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(448, 50)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(241, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFactura
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Orden Pago"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtOrden
        Me.LayoutControlItem4.Location = New System.Drawing.Point(370, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(319, 24)
        Me.LayoutControlItem4.Text = "Factura:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtOC
        Me.LayoutControlItem10.Location = New System.Drawing.Point(689, 50)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(299, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(299, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(299, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "O/C No:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbFormaPago
        Me.LayoutControlItem6.Location = New System.Drawing.Point(689, 26)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Forma de Pago:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FechaPago
        Me.LayoutControlItem2.Location = New System.Drawing.Point(225, 50)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(223, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha de Pago:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbBodega
        Me.LayoutControlItem11.Location = New System.Drawing.Point(689, 100)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Bodega:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.etTasa
        Me.LayoutControlItem13.Location = New System.Drawing.Point(806, 124)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "T/Cambio:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbMoneda
        Me.LayoutControlItem12.Location = New System.Drawing.Point(689, 76)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Moneda:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(76, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(689, 124)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(117, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.gbTipo
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(988, 54)
        Me.LayoutControlItem14.Text = "Tipo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(76, 13)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1008, 141)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'frmOrdenPagoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 607)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenPagoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtOC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbBodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents gbTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbItems As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProyectos As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
