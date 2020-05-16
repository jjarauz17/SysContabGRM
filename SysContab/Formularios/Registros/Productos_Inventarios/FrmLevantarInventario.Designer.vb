<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLevantarInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLevantarInventario))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cEncontrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.pBar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Formato = New DevExpress.XtraEditors.SimpleButton()
        Me.Exportar = New DevExpress.XtraEditors.SimpleButton()
        Me.Salir = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbItem = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemProducto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemProductoD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Tipo = New DevExpress.XtraEditors.RadioGroup()
        Me.Elaborado = New DevExpress.XtraEditors.TextEdit()
        Me.Guardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.Bodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemProductoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Elaborado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cDiferencia
        '
        Me.cDiferencia.AppearanceCell.Options.UseTextOptions = True
        Me.cDiferencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cDiferencia.AppearanceHeader.Options.UseTextOptions = True
        Me.cDiferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cDiferencia.Caption = "Diferencia"
        Me.cDiferencia.ColumnEdit = Me.rMonto
        Me.cDiferencia.DisplayFormat.FormatString = "{0:n2}"
        Me.cDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cDiferencia.FieldName = "Diferencia"
        Me.cDiferencia.Name = "cDiferencia"
        Me.cDiferencia.OptionsColumn.AllowEdit = False
        Me.cDiferencia.OptionsColumn.AllowFocus = False
        Me.cDiferencia.OptionsColumn.ReadOnly = True
        Me.cDiferencia.Visible = True
        Me.cDiferencia.VisibleIndex = 6
        '
        'rMonto
        '
        Me.rMonto.Appearance.Options.UseTextOptions = True
        Me.rMonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n2"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rMonto.Name = "rMonto"
        '
        'cEncontrado
        '
        Me.cEncontrado.Caption = "Encontrado"
        Me.cEncontrado.FieldName = "Encontrado"
        Me.cEncontrado.Name = "cEncontrado"
        Me.cEncontrado.OptionsColumn.AllowEdit = False
        Me.cEncontrado.OptionsColumn.AllowFocus = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNumero)
        Me.LayoutControl1.Controls.Add(Me.pBar)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Formato)
        Me.LayoutControl1.Controls.Add(Me.Exportar)
        Me.LayoutControl1.Controls.Add(Me.Salir)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.Tipo)
        Me.LayoutControl1.Controls.Add(Me.Elaborado)
        Me.LayoutControl1.Controls.Add(Me.Guardar)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.Bodega)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1088, 235, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(917, 434)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(755, 36)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumero.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNumero.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumero.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNumero.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumero.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtNumero.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNumero.Properties.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(150, 22)
        Me.txtNumero.StyleController = Me.LayoutControl1
        Me.txtNumero.TabIndex = 7
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(12, 362)
        Me.pBar.Name = "pBar"
        Me.pBar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.pBar.Properties.ShowTitle = True
        Me.pBar.Size = New System.Drawing.Size(893, 18)
        Me.pBar.StyleController = Me.LayoutControl1
        Me.pBar.TabIndex = 15
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(82, 62)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(823, 43)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 14
        Me.txtComentario.Tag = "True"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(514, 384)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(106, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "&Importar Inventario"
        '
        'Formato
        '
        Me.Formato.Appearance.Options.UseTextOptions = True
        Me.Formato.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Formato.Image = CType(resources.GetObject("Formato.Image"), System.Drawing.Image)
        Me.Formato.Location = New System.Drawing.Point(412, 384)
        Me.Formato.Name = "Formato"
        Me.Formato.Size = New System.Drawing.Size(98, 38)
        Me.Formato.StyleController = Me.LayoutControl1
        Me.Formato.TabIndex = 12
        Me.Formato.Text = "&Formato"
        '
        'Exportar
        '
        Me.Exportar.Image = CType(resources.GetObject("Exportar.Image"), System.Drawing.Image)
        Me.Exportar.Location = New System.Drawing.Point(624, 384)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(95, 38)
        Me.Exportar.StyleController = Me.LayoutControl1
        Me.Exportar.TabIndex = 11
        Me.Exportar.Text = "&Exportar"
        '
        'Salir
        '
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(820, 384)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(85, 38)
        Me.Salir.StyleController = Me.LayoutControl1
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "&Salir"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 138)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemProducto, Me.ItemProductoD, Me.rCantidad, Me.rMonto, Me.cbItem})
        Me.iGrid.Size = New System.Drawing.Size(893, 220)
        Me.iGrid.TabIndex = 8
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn9, Me.GridColumn10, Me.GridColumn4, Me.GridColumn5, Me.cDiferencia, Me.GridColumn8, Me.GridColumn12, Me.GridColumn14, Me.GridColumn15, Me.GridColumn11, Me.GridColumn13, Me.GridColumn16, Me.cEncontrado})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.cDiferencia
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0.0R
        StyleFormatCondition1.Value2 = 0.0R
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseTextOptions = True
        StyleFormatCondition2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        StyleFormatCondition2.Column = Me.cEncontrado
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = False
        StyleFormatCondition2.Value2 = False
        Me.iVista.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsCustomization.AllowColumnMoving = False
        Me.iVista.OptionsCustomization.AllowGroup = False
        Me.iVista.OptionsPrint.EnableAppearanceEvenRow = True
        Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "IdDetalle"
        Me.GridColumn1.FieldName = "IdDetalle"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Codigo"
        Me.GridColumn2.ColumnEdit = Me.cbItem
        Me.GridColumn2.FieldName = "Codigo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 84
        '
        'cbItem
        '
        Me.cbItem.AutoHeight = False
        Me.cbItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbItem.Name = "cbItem"
        Me.cbItem.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Descripcion"
        Me.GridColumn3.FieldName = "Item_Nombre"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 162
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Clase"
        Me.GridColumn9.FieldName = "Clase"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Proveedor"
        Me.GridColumn10.FieldName = "Proveedor"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Existencia"
        Me.GridColumn4.ColumnEdit = Me.rCantidad
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Existencia"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 72
        '
        'rCantidad
        '
        Me.rCantidad.Appearance.Options.UseTextOptions = True
        Me.rCantidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rCantidad.AutoHeight = False
        Me.rCantidad.Mask.EditMask = "n4"
        Me.rCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rCantidad.Name = "rCantidad"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Fisico"
        Me.GridColumn5.ColumnEdit = Me.rCantidad
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Fisico"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 72
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Comentario"
        Me.GridColumn8.FieldName = "Comentario"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 66
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.Caption = "Total"
        Me.GridColumn12.ColumnEdit = Me.rMonto
        Me.GridColumn12.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Total_Costo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total_Costo", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 69
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn14.Caption = "Costo"
        Me.GridColumn14.ColumnEdit = Me.rCantidad
        Me.GridColumn14.FieldName = "Costo"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 7
        Me.GridColumn14.Width = 70
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Justificar"
        Me.GridColumn15.FieldName = "Justificar"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Unidad"
        Me.GridColumn11.FieldName = "Unidad"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Modelo"
        Me.GridColumn13.FieldName = "Modelo"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Ubicacion"
        Me.GridColumn16.FieldName = "Ubicacion"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 12
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
        'ItemProductoD
        '
        Me.ItemProductoD.AutoHeight = False
        Me.ItemProductoD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemProductoD.Name = "ItemProductoD"
        Me.ItemProductoD.NullText = ""
        Me.ItemProductoD.ShowFooter = False
        Me.ItemProductoD.ShowHeader = False
        '
        'Tipo
        '
        Me.Tipo.EditValue = "P"
        Me.Tipo.Location = New System.Drawing.Point(12, 109)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.Tipo.Properties.Appearance.Options.UseBackColor = True
        Me.Tipo.Properties.Appearance.Options.UseFont = True
        Me.Tipo.Properties.Appearance.Options.UseForeColor = True
        Me.Tipo.Properties.Columns = 4
        Me.Tipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Inventario de Consumo")})
        Me.Tipo.Size = New System.Drawing.Size(893, 25)
        Me.Tipo.StyleController = Me.LayoutControl1
        Me.Tipo.TabIndex = 7
        '
        'Elaborado
        '
        Me.Elaborado.Location = New System.Drawing.Point(612, 12)
        Me.Elaborado.Name = "Elaborado"
        Me.Elaborado.Size = New System.Drawing.Size(293, 20)
        Me.Elaborado.StyleController = Me.LayoutControl1
        Me.Elaborado.TabIndex = 6
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Location = New System.Drawing.Point(723, 384)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(93, 38)
        Me.Guardar.StyleController = Me.LayoutControl1
        Me.Guardar.TabIndex = 10
        Me.Guardar.Text = "&Guardar"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(82, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(174, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 5
        '
        'Bodega
        '
        Me.Bodega.Location = New System.Drawing.Point(82, 36)
        Me.Bodega.Name = "Bodega"
        Me.Bodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Bodega.Properties.NullText = ""
        Me.Bodega.Properties.ShowFooter = False
        Me.Bodega.Properties.ShowHeader = False
        Me.Bodega.Size = New System.Drawing.Size(599, 20)
        Me.Bodega.StyleController = Me.LayoutControl1
        Me.Bodega.TabIndex = 4
        Me.Bodega.Tag = "True"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem4, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(917, 434)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.iGrid
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(897, 224)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Salir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(808, 372)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(89, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Guardar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(711, 372)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Exportar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(612, 372)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Formato
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(400, 372)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 372)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(400, 42)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.Tipo
        Me.LayoutControlItem4.CustomizationFormText = "Tipo Inventario"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(54, 29)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(897, 29)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Tipo Inventario"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Elaborado
        Me.LayoutControlItem3.CustomizationFormText = "Elaborado Por"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(530, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(367, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(367, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(367, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Elaborado Por"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.CustomizationFormText = "Fecha"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Bodega
        Me.LayoutControlItem1.CustomizationFormText = "Bodega"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(673, 26)
        Me.LayoutControlItem1.Text = "Bodega"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(67, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(248, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(282, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton1
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(502, 372)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtComentario
        Me.LayoutControlItem11.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 47)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(84, 47)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(897, 47)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Comentario:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.pBar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 350)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(0, 22)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(54, 22)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(897, 22)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtNumero
        Me.LayoutControlItem13.CustomizationFormText = "#Inventario:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(673, 24)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "#Inventario:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(67, 13)
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Justificar"
        Me.GridColumn7.FieldName = "Justificar"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 11
        Me.GridColumn7.Width = 54
        '
        'FrmLevantarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 434)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmLevantarInventario"
        Me.Text = "Levantamiento de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemProductoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Elaborado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Elaborado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Bodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Exportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Formato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ItemProducto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemProductoD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbItem As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents cEncontrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pBar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
End Class
