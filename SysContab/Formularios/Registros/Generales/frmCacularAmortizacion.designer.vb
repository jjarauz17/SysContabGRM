<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCacularAmortizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCacularAmortizacion))
        Me.frmCacularAmortizacionConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbAmorizaciones = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.btnPrevio = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sPlazo = New DevExpress.XtraEditors.SpinEdit()
        Me.Fecha_limite = New DevExpress.XtraEditors.DateEdit()
        Me.Fecha_inicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.frmCacularAmortizacionConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmCacularAmortizacionConvertedLayout.SuspendLayout()
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sPlazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_limite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_limite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_inicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_inicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmCacularAmortizacionConvertedLayout
        '
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.cbAmorizaciones)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.btnQuit)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.txtTasa)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.btnPrevio)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.btnCalcular)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.btnSave)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.cbMoneda)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.iGrid)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.sPlazo)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.Fecha_limite)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.Fecha_inicio)
        Me.frmCacularAmortizacionConvertedLayout.Controls.Add(Me.txtValor)
        Me.frmCacularAmortizacionConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmCacularAmortizacionConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmCacularAmortizacionConvertedLayout.Name = "frmCacularAmortizacionConvertedLayout"
        Me.frmCacularAmortizacionConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(702, 119, 250, 350)
        Me.frmCacularAmortizacionConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmCacularAmortizacionConvertedLayout.Size = New System.Drawing.Size(664, 464)
        Me.frmCacularAmortizacionConvertedLayout.TabIndex = 22
        '
        'cbAmorizaciones
        '
        Me.cbAmorizaciones.Location = New System.Drawing.Point(104, 116)
        Me.cbAmorizaciones.Name = "cbAmorizaciones"
        Me.cbAmorizaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmorizaciones.Properties.Appearance.Options.UseFont = True
        Me.cbAmorizaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAmorizaciones.Properties.View = Me.SearchLookUpEdit1View
        Me.cbAmorizaciones.Size = New System.Drawing.Size(536, 20)
        Me.cbAmorizaciones.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.cbAmorizaciones.TabIndex = 24
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Appearance.Options.UseFont = True
        Me.btnQuit.ImageOptions.Image = CType(resources.GetObject("btnQuit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(549, 414)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(103, 38)
        Me.btnQuit.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Salir"
        Me.btnQuit.ToolTip = "Cerrar Pantalla"
        '
        'txtTasa
        '
        Me.txtTasa.Location = New System.Drawing.Point(515, 140)
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
        Me.txtTasa.Size = New System.Drawing.Size(125, 20)
        Me.txtTasa.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.txtTasa.TabIndex = 23
        '
        'btnPrevio
        '
        Me.btnPrevio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevio.Appearance.Options.UseFont = True
        Me.btnPrevio.Enabled = False
        Me.btnPrevio.ImageOptions.Image = CType(resources.GetObject("btnPrevio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrevio.Location = New System.Drawing.Point(436, 414)
        Me.btnPrevio.Name = "btnPrevio"
        Me.btnPrevio.Size = New System.Drawing.Size(109, 38)
        Me.btnPrevio.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.btnPrevio.TabIndex = 3
        Me.btnPrevio.Text = "&Vista Previa"
        Me.btnPrevio.ToolTip = "Mostrar Reporte de Tabla de Amortización"
        Me.btnPrevio.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnPrevio.ToolTipTitle = "Ayuda ?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Appearance.Options.UseFont = True
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.ImageOptions.Image = CType(resources.GetObject("btnCalcular.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCalcular.Location = New System.Drawing.Point(232, 164)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(103, 22)
        Me.btnCalcular.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.btnCalcular.TabIndex = 19
        Me.btnCalcular.Text = "&Generar Tabla"
        Me.btnCalcular.ToolTip = "Calcular y Mostrar Tabla de Amortización"
        Me.btnCalcular.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnCalcular.ToolTipTitle = "Ayuda ?"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(324, 414)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 38)
        Me.btnSave.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Guardar"
        Me.btnSave.ToolTip = "Guardar Tabla de Amortización"
        Me.btnSave.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnSave.ToolTipTitle = "Ayuda ?"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(104, 140)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(305, 20)
        Me.cbMoneda.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.cbMoneda.TabIndex = 22
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 202)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(640, 208)
        Me.iGrid.TabIndex = 19
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista, Me.GridView2})
        '
        'iVista
        '
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cCodigo, Me.cNombre, Me.GridColumn2, Me.GridColumn3})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsCustomization.AllowGroup = False
        Me.iVista.OptionsFilter.AllowFilterEditor = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'cCodigo
        '
        Me.cCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCodigo.AppearanceHeader.Options.UseFont = True
        Me.cCodigo.Caption = "Número"
        Me.cCodigo.FieldName = "NO"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.OptionsColumn.AllowEdit = False
        Me.cCodigo.Visible = True
        Me.cCodigo.VisibleIndex = 0
        Me.cCodigo.Width = 153
        '
        'cNombre
        '
        Me.cNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cNombre.AppearanceHeader.Options.UseFont = True
        Me.cNombre.Caption = "Fecha"
        Me.cNombre.FieldName = "Fecha"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.OptionsColumn.AllowEdit = False
        Me.cNombre.Visible = True
        Me.cNombre.VisibleIndex = 1
        Me.cNombre.Width = 170
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Monto Inicial"
        Me.GridColumn2.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "MInicial"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MInicial", "{0:n2}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 227
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.Caption = "Monto Amortizado"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "MAmortiza"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MAmortiza", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 250
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.iGrid
        Me.GridView2.Name = "GridView2"
        '
        'sPlazo
        '
        Me.sPlazo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sPlazo.Location = New System.Drawing.Point(104, 90)
        Me.sPlazo.Name = "sPlazo"
        Me.sPlazo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sPlazo.Properties.Appearance.Options.UseFont = True
        Me.sPlazo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sPlazo.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
        Me.sPlazo.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sPlazo.Size = New System.Drawing.Size(109, 22)
        Me.sPlazo.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.sPlazo.TabIndex = 19
        '
        'Fecha_limite
        '
        Me.Fecha_limite.EditValue = New Date(2008, 11, 27, 15, 43, 10, 296)
        Me.Fecha_limite.Location = New System.Drawing.Point(104, 66)
        Me.Fecha_limite.Name = "Fecha_limite"
        Me.Fecha_limite.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha_limite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_limite.Properties.Appearance.Options.UseFont = True
        Me.Fecha_limite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_limite.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha_limite.Size = New System.Drawing.Size(109, 20)
        Me.Fecha_limite.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.Fecha_limite.TabIndex = 18
        '
        'Fecha_inicio
        '
        Me.Fecha_inicio.EditValue = New Date(2008, 11, 27, 15, 43, 2, 609)
        Me.Fecha_inicio.Location = New System.Drawing.Point(104, 42)
        Me.Fecha_inicio.Name = "Fecha_inicio"
        Me.Fecha_inicio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha_inicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inicio.Properties.Appearance.Options.UseFont = True
        Me.Fecha_inicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_inicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha_inicio.Size = New System.Drawing.Size(109, 20)
        Me.Fecha_inicio.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.Fecha_inicio.TabIndex = 18
        '
        'txtValor
        '
        Me.txtValor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.Location = New System.Drawing.Point(104, 164)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.Mask.EditMask = "n2"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValor.Size = New System.Drawing.Size(124, 22)
        Me.txtValor.StyleController = Me.frmCacularAmortizacionConvertedLayout
        Me.txtValor.TabIndex = 18
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(664, 464)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "dgAmortizaitem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem1.Name = "dgAmortizaitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(644, 212)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "PARAMETROS DE SELECCION"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(644, 190)
        Me.LayoutControlGroup2.Text = "PARAMETROS DE SELECCION"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sPlazo
        Me.LayoutControlItem5.CustomizationFormText = "Plazo en Meses:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(193, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(193, 26)
        Me.LayoutControlItem5.Name = "sPlazoitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(193, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Plazo en Meses:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Fecha_inicio
        Me.LayoutControlItem7.CustomizationFormText = "Fecha Inicial:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem7.Name = "Fecha_inicioitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Fecha Inicial:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtValor
        Me.LayoutControlItem8.CustomizationFormText = "Monto:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem8.Name = "txtValoritem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(208, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Monto:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMoneda
        Me.LayoutControlItem9.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(389, 24)
        Me.LayoutControlItem9.Text = "Moneda:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Fecha_limite
        Me.LayoutControlItem6.CustomizationFormText = "Fecha Limite:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem6.Name = "Fecha_limiteitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Fecha Limite:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(77, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(193, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(427, 74)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(389, 98)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(22, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(315, 122)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(305, 26)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtTasa
        Me.LayoutControlItem3.CustomizationFormText = "Tasa Cambio:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(411, 98)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Tasa Cambio:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbAmorizaciones
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(620, 24)
        Me.LayoutControlItem2.Text = "Amortización:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnCalcular
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(208, 122)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(107, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(107, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(107, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnSave
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(312, 402)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnPrevio
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(424, 402)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnQuit
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(537, 402)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 402)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(312, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCacularAmortizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 464)
        Me.Controls.Add(Me.frmCacularAmortizacionConvertedLayout)
        Me.Name = "frmCacularAmortizacion"
        Me.Text = "Calcular Amortización"
        CType(Me.frmCacularAmortizacionConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmCacularAmortizacionConvertedLayout.ResumeLayout(False)
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sPlazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_limite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_limite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_inicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_inicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fecha_limite As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Fecha_inicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrevio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sPlazo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents frmCacularAmortizacionConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbAmorizaciones As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
