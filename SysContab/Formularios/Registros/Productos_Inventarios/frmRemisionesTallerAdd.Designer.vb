<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemisionesTallerAdd
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemisionesTallerAdd))
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbOrdenTrabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.iLVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemProducto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemProductoD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCosto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbbodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbrequisa = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtrealizado = New DevExpress.XtraEditors.TextEdit()
        Me.txtrequisa = New DevExpress.XtraEditors.TextEdit()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbOrdenTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iLVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemProductoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbrequisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrealizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrequisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "Existencia"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Existencia"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Existencia", "{0:n4}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbOrdenTrabajo)
        Me.LayoutControl1.Controls.Add(Me.TipoServicio)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.cmbbodega)
        Me.LayoutControl1.Controls.Add(Me.cmbrequisa)
        Me.LayoutControl1.Controls.Add(Me.txtrealizado)
        Me.LayoutControl1.Controls.Add(Me.txtrequisa)
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.fecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(834, 215, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(766, 484)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbOrdenTrabajo
        '
        Me.cbOrdenTrabajo.Location = New System.Drawing.Point(104, 62)
        Me.cbOrdenTrabajo.Name = "cbOrdenTrabajo"
        Me.cbOrdenTrabajo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrdenTrabajo.Properties.Appearance.Options.UseFont = True
        Me.cbOrdenTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenTrabajo.Properties.NullText = "[Seleccione Orden de Trabajo]"
        Me.cbOrdenTrabajo.Properties.View = Me.iLVista
        Me.cbOrdenTrabajo.Size = New System.Drawing.Size(650, 20)
        Me.cbOrdenTrabajo.StyleController = Me.LayoutControl1
        Me.cbOrdenTrabajo.TabIndex = 11
        '
        'iLVista
        '
        Me.iLVista.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.iLVista.Name = "iLVista"
        Me.iLVista.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.iLVista.OptionsView.ShowAutoFilterRow = True
        Me.iLVista.OptionsView.ShowFooter = True
        Me.iLVista.OptionsView.ShowGroupPanel = False
        '
        'TipoServicio
        '
        Me.TipoServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoServicio.Location = New System.Drawing.Point(561, 86)
        Me.TipoServicio.Name = "TipoServicio"
        Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
        Me.TipoServicio.Properties.Appearance.Options.UseFont = True
        Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
        Me.TipoServicio.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Inventario")})
        Me.TipoServicio.Size = New System.Drawing.Size(193, 25)
        Me.TipoServicio.StyleController = Me.LayoutControl1
        Me.TipoServicio.TabIndex = 9
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 115)
        Me.GridDetalle.MainView = Me.vDatos
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemProducto, Me.ItemProductoD, Me.txtCosto, Me.txtCantidad, Me.cbCatalogo})
        Me.GridDetalle.Size = New System.Drawing.Size(742, 357)
        Me.GridDetalle.TabIndex = 10
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GridColumn3
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition1.Value2 = 0
        Me.vDatos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.vDatos.GridControl = Me.GridDetalle
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        Me.vDatos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.ColumnEdit = Me.ItemProducto
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'ItemProducto
        '
        Me.ItemProducto.AutoHeight = False
        Me.ItemProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemProducto.Name = "ItemProducto"
        Me.ItemProducto.NullText = ""
        Me.ItemProducto.ShowFooter = False
        Me.ItemProducto.ShowHeader = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.ColumnEdit = Me.ItemProductoD
        Me.GridColumn2.FieldName = "Codigo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'ItemProductoD
        '
        Me.ItemProductoD.AutoHeight = False
        Me.ItemProductoD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemProductoD.Name = "ItemProductoD"
        Me.ItemProductoD.NullText = ""
        Me.ItemProductoD.ShowFooter = False
        Me.ItemProductoD.ShowHeader = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Cuenta"
        Me.GridColumn7.ColumnEdit = Me.cbCatalogo
        Me.GridColumn7.FieldName = "Cuenta"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.View = Me.vCatalogo
        '
        'vCatalogo
        '
        Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsBehavior.Editable = False
        Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Cantidad"
        Me.GridColumn4.ColumnEdit = Me.txtCantidad
        Me.GridColumn4.FieldName = "Cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "{0:n4}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n4"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Costo"
        Me.GridColumn5.ColumnEdit = Me.txtCosto
        Me.GridColumn5.FieldName = "Costo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'txtCosto
        '
        Me.txtCosto.AutoHeight = False
        Me.txtCosto.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Name = "txtCosto"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Unidad"
        Me.GridColumn6.FieldName = "Unidad"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        '
        'cmbbodega
        '
        Me.cmbbodega.Location = New System.Drawing.Point(104, 86)
        Me.cmbbodega.Name = "cmbbodega"
        Me.cmbbodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbodega.Properties.Appearance.Options.UseFont = True
        Me.cmbbodega.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cmbbodega.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbodega.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbbodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbodega.Properties.NullText = "[Seleccione Bodega]"
        Me.cmbbodega.Properties.ShowFooter = False
        Me.cmbbodega.Properties.ShowHeader = False
        Me.cmbbodega.Properties.ShowLines = False
        Me.cmbbodega.Size = New System.Drawing.Size(453, 20)
        Me.cmbbodega.StyleController = Me.LayoutControl1
        Me.cmbbodega.TabIndex = 5
        '
        'cmbrequisa
        '
        Me.cmbrequisa.Location = New System.Drawing.Point(104, 38)
        Me.cmbrequisa.Name = "cmbrequisa"
        Me.cmbrequisa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrequisa.Properties.Appearance.Options.UseFont = True
        Me.cmbrequisa.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cmbrequisa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cmbrequisa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbrequisa.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbrequisa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbrequisa.Properties.NullText = ""
        Me.cmbrequisa.Properties.ShowFooter = False
        Me.cmbrequisa.Properties.ShowHeader = False
        Me.cmbrequisa.Properties.ShowLines = False
        Me.cmbrequisa.Size = New System.Drawing.Size(113, 20)
        Me.cmbrequisa.StyleController = Me.LayoutControl1
        Me.cmbrequisa.TabIndex = 3
        '
        'txtrealizado
        '
        Me.txtrealizado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrealizado.Location = New System.Drawing.Point(564, 38)
        Me.txtrealizado.Name = "txtrealizado"
        Me.txtrealizado.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtrealizado.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrealizado.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtrealizado.Properties.ReadOnly = True
        Me.txtrealizado.Size = New System.Drawing.Size(190, 20)
        Me.txtrealizado.StyleController = Me.LayoutControl1
        Me.txtrealizado.TabIndex = 7
        '
        'txtrequisa
        '
        Me.txtrequisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrequisa.Location = New System.Drawing.Point(564, 12)
        Me.txtrequisa.Name = "txtrequisa"
        Me.txtrequisa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtrequisa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrequisa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtrequisa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtrequisa.Properties.ReadOnly = True
        Me.txtrequisa.Size = New System.Drawing.Size(190, 22)
        Me.txtrequisa.StyleController = Me.LayoutControl1
        Me.txtrequisa.TabIndex = 6
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(367, 12)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Properties.MaxLength = 50
        Me.txtReferencia.Size = New System.Drawing.Size(101, 22)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 2
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(104, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Properties.Appearance.Options.UseFont = True
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(113, 22)
        Me.fecha.StyleController = Me.LayoutControl1
        Me.fecha.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.LayoutControlItem6, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(766, 484)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.fecha
        Me.LayoutControlItem1.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtReferencia
        Me.LayoutControlItem2.CustomizationFormText = "Referencia:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(263, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem2.Text = "Referencia:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtrequisa
        Me.LayoutControlItem3.CustomizationFormText = "#Remisión:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(460, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(286, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(286, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(286, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "#Remisión:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtrealizado
        Me.LayoutControlItem4.CustomizationFormText = "Realizado por:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(460, 26)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Realizado por:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmbrequisa
        Me.LayoutControlItem5.CustomizationFormText = "Tipo:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Tipo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridDetalle
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(746, 361)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(209, 26)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(251, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(209, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(54, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.TipoServicio
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(549, 74)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(197, 29)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbbodega
        Me.LayoutControlItem6.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(549, 29)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(549, 29)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(549, 29)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Bodega:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cbOrdenTrabajo
        Me.LayoutControlItem13.CustomizationFormText = "Orden de Trabajo:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(746, 24)
        Me.LayoutControlItem13.Text = "Orden de Trabajo:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(89, 13)
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
        Me.DockPanel1.ID = New System.Guid("21fa12e0-76ab-43b5-b4e3-96a877bce6aa")
        Me.DockPanel1.Location = New System.Drawing.Point(766, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 484)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(142, 457)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bSalir)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.bGuardar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(794, 174, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(142, 457)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(12, 407)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(118, 38)
        Me.bSalir.StyleController = Me.LayoutControl2
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 365)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(118, 38)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 5
        Me.bExportar.Text = "E&xportar"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(12, 12)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(118, 38)
        Me.bGuardar.StyleController = Me.LayoutControl2
        Me.bGuardar.TabIndex = 4
        Me.bGuardar.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(142, 457)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bGuardar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bExportar
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 353)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bSalir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 395)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 311)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmRemisionesTallerAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 484)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmRemisionesTallerAdd"
        Me.Text = "frmRemisionesTallerAdd"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbOrdenTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iLVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemProductoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbrequisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrealizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrequisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtrequisa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtrealizado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbrequisa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbbodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemProducto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemProductoD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCosto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbOrdenTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents iLVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
End Class
