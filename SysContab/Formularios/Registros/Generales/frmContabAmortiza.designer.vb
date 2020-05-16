<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContabAmortiza
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabAmortiza))
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.frmContabAmortizaConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbAmorizaciones = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTipoComprobante = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnContab = New DevExpress.XtraEditors.SimpleButton()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.etMonto = New System.Windows.Forms.Label()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCat = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.frmContabAmortizaConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmContabAmortizaConvertedLayout.SuspendLayout()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(756, 459)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(102, 38)
        Me.btnSalir.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Salir"
        '
        'frmContabAmortizaConvertedLayout
        '
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.txtConsecutivo)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.cbMeses)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.cbAmorizaciones)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.txtTasa)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.cmbTipoComprobante)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.txtConcepto)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.btnSalir)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.cbMoneda)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.btnContab)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.fecha)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.etMonto)
        Me.frmContabAmortizaConvertedLayout.Controls.Add(Me.iGrid)
        Me.frmContabAmortizaConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmContabAmortizaConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmContabAmortizaConvertedLayout.Name = "frmContabAmortizaConvertedLayout"
        Me.frmContabAmortizaConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(950, 243, 250, 350)
        Me.frmContabAmortizaConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmContabAmortizaConvertedLayout.Size = New System.Drawing.Size(870, 509)
        Me.frmContabAmortizaConvertedLayout.TabIndex = 27
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(524, 92)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Size = New System.Drawing.Size(85, 20)
        Me.txtConsecutivo.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.txtConsecutivo.TabIndex = 191
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(134, 92)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Properties.Appearance.Options.UseFont = True
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Size = New System.Drawing.Size(276, 20)
        Me.cbMeses.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.cbMeses.TabIndex = 31
        '
        'cbAmorizaciones
        '
        Me.cbAmorizaciones.Location = New System.Drawing.Point(134, 42)
        Me.cbAmorizaciones.Name = "cbAmorizaciones"
        Me.cbAmorizaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmorizaciones.Properties.Appearance.Options.UseFont = True
        Me.cbAmorizaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAmorizaciones.Properties.View = Me.SearchLookUpEdit1View
        Me.cbAmorizaciones.Size = New System.Drawing.Size(475, 20)
        Me.cbAmorizaciones.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.cbAmorizaciones.TabIndex = 28
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtTasa
        '
        Me.txtTasa.Location = New System.Drawing.Point(723, 92)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTasa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.Properties.ReadOnly = True
        Me.txtTasa.Size = New System.Drawing.Size(123, 20)
        Me.txtTasa.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.txtTasa.TabIndex = 28
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(134, 117)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoComprobante.Properties.Appearance.Options.UseFont = True
        Me.cmbTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoComprobante.Properties.ShowFooter = False
        Me.cmbTipoComprobante.Properties.ShowHeader = False
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(712, 20)
        Me.cmbTipoComprobante.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.cmbTipoComprobante.TabIndex = 30
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(134, 141)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(712, 40)
        Me.txtConcepto.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.txtConcepto.TabIndex = 29
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(134, 68)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.cbMoneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.ReadOnly = True
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(475, 20)
        Me.cbMoneda.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.cbMoneda.TabIndex = 28
        '
        'btnContab
        '
        Me.btnContab.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContab.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContab.Appearance.Options.UseFont = True
        Me.btnContab.Enabled = False
        Me.btnContab.ImageOptions.Image = CType(resources.GetObject("btnContab.ImageOptions.Image"), System.Drawing.Image)
        Me.btnContab.Location = New System.Drawing.Point(643, 459)
        Me.btnContab.Name = "btnContab"
        Me.btnContab.Size = New System.Drawing.Size(109, 38)
        Me.btnContab.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.btnContab.TabIndex = 0
        Me.btnContab.Text = "&Contabilizar"
        '
        'fecha
        '
        Me.fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha.EditValue = New Date(2008, 10, 9, 9, 14, 36, 171)
        Me.fecha.Location = New System.Drawing.Point(723, 42)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Properties.Appearance.Options.UseFont = True
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(123, 20)
        Me.fecha.StyleController = Me.frmContabAmortizaConvertedLayout
        Me.fecha.TabIndex = 23
        '
        'etMonto
        '
        Me.etMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMonto.ForeColor = System.Drawing.Color.DarkRed
        Me.etMonto.Location = New System.Drawing.Point(613, 68)
        Me.etMonto.Name = "etMonto"
        Me.etMonto.Size = New System.Drawing.Size(233, 20)
        Me.etMonto.TabIndex = 22
        Me.etMonto.Text = "0.00"
        Me.etMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 197)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCat, Me.cbCatalogo})
        Me.iGrid.Size = New System.Drawing.Size(846, 258)
        Me.iGrid.TabIndex = 24
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.ColumnEdit = Me.cbCatalogo
        Me.GridColumn4.FieldName = "Cuenta"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 424
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = "[Seleccione Cuenta]"
        Me.cbCatalogo.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.Caption = "Débitos"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Debitos"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debitos", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 150
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.Caption = "Créditos"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Creditos"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Creditos", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 150
        '
        'cbCat
        '
        Me.cbCat.AutoHeight = False
        Me.cbCat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCat.DisplayMember = "Display"
        Me.cbCat.Name = "cbCat"
        Me.cbCat.NullText = ""
        Me.cbCat.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbCat.ValueMember = "CUENTA"
        Me.cbCat.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "CUENTA"
        Me.GridColumn1.FieldName = "CUENTA"
        Me.GridColumn1.MinWidth = 150
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "NOMBRE"
        Me.GridColumn2.FieldName = "NOMBRE"
        Me.GridColumn2.MinWidth = 300
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 300
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Mostrar"
        Me.GridColumn3.FieldName = "Display"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(870, 509)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "CONTABILIZAR AMORTIZACION"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem12, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(850, 185)
        Me.LayoutControlGroup2.Text = "CONTABILIZAR AMORTIZACION"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.etMonto
        Me.LayoutControlItem8.CustomizationFormText = "etMontoitem"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(589, 26)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem8.Name = "etMontoitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMoneda
        Me.LayoutControlItem9.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(589, 24)
        Me.LayoutControlItem9.Text = "Moneda:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.fecha
        Me.LayoutControlItem4.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(589, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(237, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(237, 26)
        Me.LayoutControlItem4.Name = "fechaitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(237, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Fecha:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtConcepto
        Me.LayoutControlItem1.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 44)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(125, 44)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(826, 44)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Concepto:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbTipoComprobante
        Me.LayoutControlItem6.CustomizationFormText = "Tipo de Comprobante:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(826, 24)
        Me.LayoutControlItem6.Text = "Tipo de Comprobante:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtTasa
        Me.LayoutControlItem7.CustomizationFormText = "Tasa Cambio:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(589, 50)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(237, 25)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(237, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(237, 25)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Tasa Cambio:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbAmorizaciones
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(589, 26)
        Me.LayoutControlItem12.Text = "Amortizaciones:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMeses
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(390, 25)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(390, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(390, 25)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Mes:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtConsecutivo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(390, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(199, 25)
        Me.LayoutControlItem5.Text = "Referencia:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(107, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.iGrid
        Me.LayoutControlItem2.CustomizationFormText = "gridDataitem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 185)
        Me.LayoutControlItem2.Name = "gridDataitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(850, 262)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnContab
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(631, 447)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnSalir
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(744, 447)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 447)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(631, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmContabAmortiza
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 509)
        Me.Controls.Add(Me.frmContabAmortizaConvertedLayout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmContabAmortiza"
        Me.Text = "Contanbilizar Amortización"
        CType(Me.frmContabAmortizaConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmContabAmortizaConvertedLayout.ResumeLayout(False)
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnContab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etMonto As System.Windows.Forms.Label
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCat As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents frmContabAmortizaConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmbTipoComprobante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbAmorizaciones As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
