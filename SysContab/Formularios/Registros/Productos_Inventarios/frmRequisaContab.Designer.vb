<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisaContab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequisaContab))
        Me.etDif = New System.Windows.Forms.Label()
        Me.etDebito = New System.Windows.Forms.Label()
        Me.etCredito = New System.Windows.Forms.Label()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'etDif
        '
        Me.etDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDif.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDif.ForeColor = System.Drawing.Color.Maroon
        Me.etDif.Location = New System.Drawing.Point(672, 507)
        Me.etDif.Name = "etDif"
        Me.etDif.Size = New System.Drawing.Size(136, 25)
        Me.etDif.TabIndex = 1026
        Me.etDif.Text = "0.00"
        Me.etDif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etDebito
        '
        Me.etDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDebito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDebito.ForeColor = System.Drawing.Color.Maroon
        Me.etDebito.Location = New System.Drawing.Point(107, 507)
        Me.etDebito.Name = "etDebito"
        Me.etDebito.Size = New System.Drawing.Size(184, 25)
        Me.etDebito.TabIndex = 1024
        Me.etDebito.Text = "0.00"
        Me.etDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etCredito
        '
        Me.etCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etCredito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etCredito.Location = New System.Drawing.Point(390, 507)
        Me.etCredito.Name = "etCredito"
        Me.etCredito.Size = New System.Drawing.Size(183, 25)
        Me.etCredito.TabIndex = 1023
        Me.etCredito.Text = "0.00"
        Me.etCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 159)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.rMonto, Me.cbProyecto})
        Me.gridDatos.Size = New System.Drawing.Size(796, 344)
        Me.gridDatos.TabIndex = 1
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'vComprobante
        '
        Me.vComprobante.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn3})
        Me.vComprobante.GridControl = Me.gridDatos
        Me.vComprobante.Name = "vComprobante"
        Me.vComprobante.OptionsCustomization.AllowColumnMoving = False
        Me.vComprobante.OptionsCustomization.AllowColumnResizing = False
        Me.vComprobante.OptionsCustomization.AllowFilter = False
        Me.vComprobante.OptionsCustomization.AllowSort = False
        Me.vComprobante.OptionsFilter.AllowFilterEditor = False
        Me.vComprobante.OptionsView.EnableAppearanceEvenRow = True
        Me.vComprobante.OptionsView.EnableAppearanceOddRow = True
        Me.vComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vComprobante.OptionsView.ShowFooter = True
        Me.vComprobante.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cuenta"
        Me.GridColumn2.ColumnEdit = Me.cbCatalogo
        Me.GridColumn2.FieldName = "Cuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 264
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.DisplayMember = "Display"
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.MinWidth = 100
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nombre"
        Me.GridColumn8.FieldName = "Nombre"
        Me.GridColumn8.MinWidth = 250
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 250
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Display"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nombre Completo"
        Me.GridColumn10.FieldName = "NombreCompleto"
        Me.GridColumn10.MinWidth = 350
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 350
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn11.Caption = "Débito"
        Me.GridColumn11.ColumnEdit = Me.rMonto
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Debito"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 91
        '
        'rMonto
        '
        Me.rMonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonto.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.rMonto.Appearance.Options.UseBackColor = True
        Me.rMonto.Appearance.Options.UseFont = True
        Me.rMonto.Appearance.Options.UseForeColor = True
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n2"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rMonto.Name = "rMonto"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.Caption = "Crédito"
        Me.GridColumn12.ColumnEdit = Me.rMonto
        Me.GridColumn12.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Credito"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 92
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Concepto"
        Me.GridColumn13.FieldName = "Concepto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 155
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Proyecto"
        Me.GridColumn3.ColumnEdit = Me.cbProyecto
        Me.GridColumn3.FieldName = "IdProyecto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 176
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoHeight = False
        Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.NullText = "[Proyecto]"
        Me.cbProyecto.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Fecha
        '
        Me.Fecha.EditValue = New Date(2008, 9, 2, 9, 47, 29, 93)
        Me.Fecha.Location = New System.Drawing.Point(119, 43)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(117, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.cbTipoComp)
        Me.LayoutControl1.Controls.Add(Me.etDif)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Controls.Add(Me.etCredito)
        Me.LayoutControl1.Controls.Add(Me.etDebito)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(595, 150, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(820, 544)
        Me.LayoutControl1.TabIndex = 1028
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(119, 91)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Properties.Appearance.Options.UseFont = True
        Me.txtConcepto.Size = New System.Drawing.Size(677, 52)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 2
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(119, 67)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipoComp.Properties.Appearance.Options.UseFont = True
        Me.cbTipoComp.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.DropDownRows = 12
        Me.cbTipoComp.Properties.NullText = ""
        Me.cbTipoComp.Properties.ShowFooter = False
        Me.cbTipoComp.Properties.ShowHeader = False
        Me.cbTipoComp.Size = New System.Drawing.Size(677, 20)
        Me.cbTipoComp.StyleController = Me.LayoutControl1
        Me.cbTipoComp.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlGroup2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(820, 544)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.gridDatos
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(800, 348)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(800, 147)
        Me.LayoutControlGroup2.Text = "DESCRIPCIÓN DEL COMPROBANTE"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(216, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(216, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(216, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbTipoComp
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(776, 24)
        Me.LayoutControlItem2.Text = "Tipo Comprobante:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtConcepto
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 56)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(110, 56)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(776, 56)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Concepto:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(216, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(560, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.Control = Me.etDebito
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 495)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(120, 29)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(283, 29)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Débitos:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 18)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.Control = Me.etCredito
        Me.LayoutControlItem6.Location = New System.Drawing.Point(283, 495)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(120, 29)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(282, 29)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Créditos:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 18)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem7.Control = Me.etDif
        Me.LayoutControlItem7.Location = New System.Drawing.Point(565, 495)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 29)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(120, 29)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(235, 29)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Diferencia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 18)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(12, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(107, 38)
        Me.btnGuardar.StyleController = Me.LayoutControl2
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.btnSalir)
        Me.LayoutControl2.Controls.Add(Me.btnGuardar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 517)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseForeColor = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(12, 54)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 38)
        Me.btnSalir.StyleController = Me.LayoutControl2
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Salir"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(131, 517)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnGuardar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnSalir
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 455)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("948f8d9f-1bee-4ca0-b705-2724cf0bf0d2")
        Me.DockPanel1.Location = New System.Drawing.Point(820, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 544)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 517)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmRequisaContab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 544)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmRequisaContab"
        Me.Text = "Contabilizar Movimiento"
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents etDif As System.Windows.Forms.Label
    Friend WithEvents etDebito As System.Windows.Forms.Label
    Friend WithEvents etCredito As System.Windows.Forms.Label
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vComprobante As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents rMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
