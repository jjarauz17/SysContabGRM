Public Class frmListaFacturaProveedoresPlan
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaFacturaProveedoresPlan = Nothing

    Public Shared Function Instance() As frmListaFacturaProveedoresPlan
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaFacturaProveedoresPlan
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPagar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSelec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoPagar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMntoValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtMontoPagarU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCChica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmListaFacturaProveedoresPlanConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTipoProv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaFacturaProveedoresPlan))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cSelec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cShow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCChica = New DevExpress.XtraEditors.SimpleButton()
        Me.frmListaFacturaProveedoresPlanConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTipoProv = New DevExpress.XtraEditors.LabelControl()
        Me.etInicio = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.vFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMntoValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoPagar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoPagarU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPagar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.frmListaFacturaProveedoresPlanConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmListaFacturaProveedoresPlanConvertedLayout.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagarU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cSelec
        '
        Me.cSelec.AppearanceCell.Options.UseTextOptions = True
        Me.cSelec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cSelec.Caption = "Seleccionar"
        Me.cSelec.FieldName = "Selecc"
        Me.cSelec.Name = "cSelec"
        Me.cSelec.Visible = True
        Me.cSelec.VisibleIndex = 14
        Me.cSelec.Width = 45
        '
        'cShow
        '
        Me.cShow.Caption = "Mostrar"
        Me.cShow.FieldName = "Mostrar"
        Me.cShow.Name = "cShow"
        '
        'btnCChica
        '
        Me.btnCChica.ImageOptions.Image = CType(resources.GetObject("btnCChica.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCChica.Location = New System.Drawing.Point(137, 276)
        Me.btnCChica.Name = "btnCChica"
        Me.btnCChica.Size = New System.Drawing.Size(131, 38)
        Me.btnCChica.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.btnCChica.TabIndex = 17
        Me.btnCChica.Text = "&Pago Caja Chica"
        '
        'frmListaFacturaProveedoresPlanConvertedLayout
        '
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.lblTipoProv)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.etInicio)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.LabelControl1)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.CheckEdit1)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.txtTasa)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.fecha)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.GridControl1)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.btnCChica)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.btnExportar)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.cmdSalir)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.cmdBorrar)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Controls.Add(Me.btnPagar)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmListaFacturaProveedoresPlanConvertedLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Name = "frmListaFacturaProveedoresPlanConvertedLayout"
        Me.frmListaFacturaProveedoresPlanConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(592, 359, 250, 350)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmListaFacturaProveedoresPlanConvertedLayout.Size = New System.Drawing.Size(1008, 326)
        Me.frmListaFacturaProveedoresPlanConvertedLayout.TabIndex = 22
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(272, 276)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(152, 38)
        Me.SimpleButton1.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "&Rendición de Cuenta"
        '
        'lblTipoProv
        '
        Me.lblTipoProv.Location = New System.Drawing.Point(12, 259)
        Me.lblTipoProv.Name = "lblTipoProv"
        Me.lblTipoProv.Size = New System.Drawing.Size(6, 13)
        Me.lblTipoProv.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.lblTipoProv.TabIndex = 23
        Me.lblTipoProv.Text = "0"
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(12, 259)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(6, 13)
        Me.etInicio.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.etInicio.TabIndex = 22
        Me.etInicio.Text = "0"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 259)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(165, 13)
        Me.LabelControl1.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Presione F5 para Actualizar Datos "
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(857, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Mostrar Más Datos"
        Me.CheckEdit1.Size = New System.Drawing.Size(139, 20)
        Me.CheckEdit1.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.CheckEdit1.TabIndex = 20
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.EnterMoveNextControl = True
        Me.txtTasa.Location = New System.Drawing.Point(305, 12)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(139, 22)
        Me.txtTasa.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.txtTasa.TabIndex = 1
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(90, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Properties.Appearance.Options.UseFont = True
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(133, 20)
        Me.fecha.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.fecha.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 38)
        Me.GridControl1.MainView = Me.vFacturas
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoPagar, Me.txtMntoValor, Me.txtMontoPagarU})
        Me.GridControl1.Size = New System.Drawing.Size(984, 217)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFacturas})
        '
        'vFacturas
        '
        Me.vFacturas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vFacturas.Appearance.HeaderPanel.Options.UseFont = True
        Me.vFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vFacturas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vFacturas.ColumnPanelRowHeight = 35
        Me.vFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn21, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn7, Me.GridColumn12, Me.GridColumn20, Me.cShow, Me.GridColumn10, Me.GridColumn18, Me.GridColumn14, Me.GridColumn11, Me.cSelec, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn19, Me.GridColumn22, Me.GridColumn23})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.cSelec
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition1.Value2 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.cShow
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition2.Value2 = True
        Me.vFacturas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.vFacturas.GridControl = Me.GridControl1
        Me.vFacturas.Name = "vFacturas"
        Me.vFacturas.OptionsView.ShowAutoFilterRow = True
        Me.vFacturas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vFacturas.OptionsView.ShowFooter = True
        Me.vFacturas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "No. Orden"
        Me.GridColumn13.FieldName = "Factura"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 65
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Factura"
        Me.GridColumn1.FieldName = "NoOrden"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 65
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cuenta"
        Me.GridColumn3.FieldName = "Cuenta"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nombre"
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "FormaPago"
        Me.GridColumn5.FieldName = "Forma de Pago"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 65
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Tipo"
        Me.GridColumn21.FieldName = "TipoF"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Monto"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Monto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:N}")})
        Me.GridColumn6.Width = 65
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "SubTotal"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Sub Total"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sub Total", "{0:N}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 65
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "IVA"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "IVA"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:N}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 65
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Parcial"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Parcial"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Parcial", "{0:N}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 65
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Saldo"
        Me.GridColumn12.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Saldo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:N}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 65
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Retension"
        Me.GridColumn20.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "Retension"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retension", "{0:n2}")})
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Total"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Total"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:N}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 65
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Mnto. Valor"
        Me.GridColumn18.ColumnEdit = Me.txtMntoValor
        Me.GridColumn18.FieldName = "Mnto"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mnto", "{0:n2}")})
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 11
        Me.GridColumn18.Width = 65
        '
        'txtMntoValor
        '
        Me.txtMntoValor.AutoHeight = False
        Me.txtMntoValor.Mask.EditMask = "n2"
        Me.txtMntoValor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMntoValor.Mask.UseMaskAsDisplayFormat = True
        Me.txtMntoValor.Name = "txtMntoValor"
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Monto Pagar"
        Me.GridColumn14.ColumnEdit = Me.txtMontoPagar
        Me.GridColumn14.FieldName = "Pagar"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pagar", "{0:n2}")})
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        Me.GridColumn14.Width = 65
        '
        'txtMontoPagar
        '
        Me.txtMontoPagar.AutoHeight = False
        Me.txtMontoPagar.Mask.EditMask = "n2"
        Me.txtMontoPagar.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagar.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagar.Name = "txtMontoPagar"
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Monto Pagar U$"
        Me.GridColumn11.ColumnEdit = Me.txtMontoPagarU
        Me.GridColumn11.FieldName = "PagarU"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PagarU", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 13
        Me.GridColumn11.Width = 85
        '
        'txtMontoPagarU
        '
        Me.txtMontoPagarU.AutoHeight = False
        Me.txtMontoPagarU.Mask.EditMask = "n2"
        Me.txtMontoPagarU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagarU.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagarU.Name = "txtMontoPagarU"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Comp_No"
        Me.GridColumn15.FieldName = "Comp_No"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Mes"
        Me.GridColumn16.FieldName = "Mes"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Per_ID"
        Me.GridColumn17.FieldName = "Per_ID"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Moneda"
        Me.GridColumn19.FieldName = "Moneda"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "SubTotalIR"
        Me.GridColumn22.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "SubTotalIR"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.AllowFocus = False
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "IR_Porcentaje"
        Me.GridColumn23.FieldName = "IR_Porcentaje"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.AllowFocus = False
        '
        'btnExportar
        '
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(797, 276)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 38)
        Me.btnExportar.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "&Expotar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(902, 276)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(94, 38)
        Me.cmdSalir.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(885, 276)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(57, 22)
        Me.cmdBorrar.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.cmdBorrar.TabIndex = 1
        Me.cmdBorrar.Text = "&Ayuda"
        '
        'btnPagar
        '
        Me.btnPagar.ImageOptions.Image = CType(resources.GetObject("btnPagar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPagar.Location = New System.Drawing.Point(12, 276)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(121, 38)
        Me.btnPagar.StyleController = Me.frmListaFacturaProveedoresPlanConvertedLayout
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "&Pagar Factura"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdBorrar
        Me.LayoutControlItem9.CustomizationFormText = "cmdBorraritem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(873, 264)
        Me.LayoutControlItem9.Name = "cmdBorraritem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(61, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.etInicio
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(10, 17)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.lblTipoProv
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(988, 17)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 326)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckEdit1
        Me.LayoutControlItem1.CustomizationFormText = "0"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(845, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem1.Name = "CheckEdit1item"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "0"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtTasa
        Me.LayoutControlItem2.CustomizationFormText = "Tasa:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(215, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(221, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(221, 26)
        Me.LayoutControlItem2.Name = "txtTasaitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(221, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Tasa:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.fecha
        Me.LayoutControlItem3.CustomizationFormText = "Fecha de Pago:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem3.Name = "fechaitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Fecha de Pago:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl1
        Me.LayoutControlItem5.CustomizationFormText = "GridControl1item"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem5.Name = "GridControl1item"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(988, 221)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(436, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(409, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnPagar
        Me.LayoutControlItem10.CustomizationFormText = "btnPagaritem"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 264)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(125, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(125, 42)
        Me.LayoutControlItem10.Name = "btnPagaritem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(125, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnCChica
        Me.LayoutControlItem6.CustomizationFormText = "Label2"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(125, 264)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem6.Name = "btnCChicaitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(135, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Label2"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnExportar
        Me.LayoutControlItem7.CustomizationFormText = "btnExportaritem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(785, 264)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem7.Name = "btnExportaritem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdSalir
        Me.LayoutControlItem8.CustomizationFormText = "cmdSaliritem"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(890, 264)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem8.Name = "cmdSaliritem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(416, 264)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(369, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(988, 17)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(260, 264)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(156, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(156, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(156, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'frmListaFacturaProveedoresPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 326)
        Me.Controls.Add(Me.frmListaFacturaProveedoresPlanConvertedLayout)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmListaFacturaProveedoresPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Facturas a Proveedores"
        CType(Me.frmListaFacturaProveedoresPlanConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmListaFacturaProveedoresPlanConvertedLayout.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagarU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Conf As New VB.SysContab.ConfiguracionDB
    Dim Prov As New VB.SysContab.ProveedoresDB

    Dim r As New VB.SysContab.Rutinas
    Public Fact As String, FactSubTotalIR As String, FactIR As String
    Public FactValor As Double, SubTotal As Double, FactMnto As Double

    Public WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Public WithEvents tCust1 As New DataTable
    'Dim tCust1 As DataTable

    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()

    Public ds As New DataTable("Facturas_Compras")
    Dim dtFact As DataTable
    Private Temp As Boolean = False
    Dim Abono As Double = 0


    Private Sub frmListaFacturaProveedoresPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fecha.DateTime = CDate(VB.SysContab.Rutinas.Fecha())
        Me.txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)
        Cargar()        
        ' Me.vFacturas.BestFitColumns()
    End Sub

    Public Sub Cargar()
        'Dim FacturasDB As New VB.SysContab.Facturas_ComprasDB

        'ds = FacturasDB.GetListxTipoProductoCredito(lblTipoProv.Text, fecha.DateTime.Date, Me.txtTasa.EditValue)
        'Me.GridControl1.DataSource = ds.Tables(0)
        'FormatoGrid(Me.vFacturas)
        'Me.vFacturas.BestFitColumns()
        'Me.txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)
        'If ds.Tables("Tablas").Rows.Count <> 0 Then
        '    Registro = Me.vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Factura")
        'Else
        '    Registro = "Vacio"
        'End If

        'Me.Refresh()

        'ds.Tables.Add(ObtieneDatos("JAR_FacturasComprasPagar", fecha.DateTime.Date, txtTasa.EditValue, EmpresaActual))

        ds = ObtieneDatos("JAR_FacturasComprasPagar", fecha.DateTime.Date, txtTasa.EditValue, EmpresaActual)

        GridControl1.DataSource = ds
        GridControl1.Refresh()
        vFacturas.RefreshData()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        Dim Proveedor As String
        Dim CompFact, SaldoFact As String, FactPagar As String
        Dim IR_Pagado_Alcaldia, IRPagado, IVAAsumido As Boolean

        'Para Pagos en Cordobas
        Dim Monto_IR_Pagado, Monto_IR_Pagado_Alcaldia, MontoIVAasumido, MontoIRxPagar, SubTotalIRxPagar, _
        MontoIR_ALMAxPagar, SubTotalIR_ALMAxPagar As Double

        'Para los Pagos en Dolares
        Dim Monto_IR_PagadoUS, Monto_IR_Pagado_AlcaldiaUS, MontoIVAasumidoUS, MontoIRxPagarUS, SubTotalIRxPagarUS, _
        MontoIR_ALMAxPagarUS, SubTotalIR_ALMAxPagarUS As Double

        Dim MntoValor1, MntoValor2, TC1, TC2 As Double
        Dim SegundoIR As Boolean = False
        '        SegundoIR = False

        Dim i As Integer
        Dim fr As New frmPagoFacturas
        fr.etInicio.Text = "0"
        fr.MdiParent = Me.MdiParent
        'Dim fr As frmPlantillasBancos = fr.Instance
        'fr.MdiParent = Me.MdiParent

        MontoIVAasumido = 0
        SubTotal = 0
        FactValor = 0
        FactMnto = 0
        Fact = ""
        CompFact = ""

        '******************************************************************************************
        '*** VALIDA SI TIENEN ALGO SELECCIONADO
        '******************************************************************************************

        Dim Control As Boolean = False
        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Control = True
                Exit For
            End If
            Control = False
        Next

        If Control = False Then
            XtraMsg("Por favor seleccionar al menos una factura para pagar", MessageBoxIcon.Warning)
            Exit Sub
        End If

        '******************************************************************************************

        IRPagado = True

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "IR_Pagado")) = False Then
                        IRPagado = False
                    End If
                Catch ex As Exception
                    IRPagado = False
                    Exit For
                End Try
            End If
        Next

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "Iva_Asumido")) = True Then
                        IVAAsumido = True
                        Exit For
                    End If
                Catch ex As Exception
                    IVAAsumido = False
                End Try
            End If
        Next

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Proveedor = Me.vFacturas.GetRowCellValue(i, "Codigo")
            End If
        Next

        Dim Muni As New VB.SysContab.MunicipiosDB
        Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(Prov.GetDetails(Proveedor).Departamento, Prov.GetDetails(Proveedor).Municipio)

        If MunDet Is Nothing Then
            XtraMsg("No se puede completar el Pago, por favor Ingrese Departamento o Municipio del Proveedor", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ''
        If Prov.GetDetails(Proveedor).Departamento = 0 Or _
            Prov.GetDetails(Proveedor).Municipio = 0 Then
            XtraMsg("No se puede completar el Pago, por favor Ingrese Departamento o Municipio del Proveedor", MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                If Proveedor <> Me.vFacturas.GetRowCellValue(i, "Codigo") Then
                    XtraMsg("No se puede pagar a Proveedores distintos en un mismo cheque.", MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Fact = CStr(vFacturas.GetRowCellValue(i, "Factura")) & " | " & CStr(Fact)
                CompFact = vFacturas.GetRowCellValue(i, "Comp_No") & " | " & CompFact
                SaldoFact = vFacturas.GetRowCellValue(i, "Saldo") & " | " & SaldoFact
                FactPagar = (vFacturas.GetRowCellValue(i, "Pagar") - vFacturas.GetRowCellValue(i, "Mnto")) & " | " & FactPagar
                FactValor = vFacturas.GetRowCellValue(i, "Pagar") + FactValor
                FactMnto = vFacturas.GetRowCellValue(i, "Mnto") + FactMnto
                FactSubTotalIR = vFacturas.GetRowCellValue(i, "SubTotalIR") & " | " & FactSubTotalIR
                FactIR = vFacturas.GetRowCellValue(i, "Retension") & " | " & FactIR

                If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                    SubTotal = CDbl(vFacturas.GetRowCellValue(i, "Pagar") / ((ConfigDet.IVA / 100) + 1)) + SubTotal
                Else
                    SubTotal = CDbl(vFacturas.GetRowCellValue(i, "Pagar")) + SubTotal
                End If

                'fr.lblProv.Text = dgProveedores.Item(i, 4)
                'fr.lblProvID.Text = dgProveedores.Item(i, 3)
                'fr.etCodigoProveedor.Text = dgProveedores.Item(i, 11)

                fr.lblProv.Text = vFacturas.GetRowCellValue(i, "Nombre")
                fr.lblProvID.Text = vFacturas.GetRowCellValue(i, "Cuenta")
                fr.etCodigoProveedor.Text = vFacturas.GetRowCellValue(i, "Codigo")

                'fr.Comp_No = dgProveedores.Item(i, 12)
                'fr.Mes = dgProveedores.Item(i, 13)
                'fr.Per_ID = dgProveedores.Item(i, 14)
                'fr.FormaPago = dgProveedores.Item(i, 15)

                fr.Comp_No = vFacturas.GetRowCellValue(i, "Comp_No")
                fr.Mes = vFacturas.GetRowCellValue(i, "Mes")
                fr.Per_ID = vFacturas.GetRowCellValue(i, "Per_ID")
                fr.FormaPago = vFacturas.GetRowCellValue(i, "FormaPago_ID")

                Try
                    'fr.IVAAsumido = dgProveedores.Item(i, 18)
                    fr.IVAAsumido = vFacturas.GetRowCellValue(i, "Iva_Asumido")
                Catch ex As Exception
                    fr.IVAAsumido = False
                End Try

                fr.IR_Pagado_Alcaldia = IsNull(vFacturas.GetRowCellValue(i, "IR_Pagado_Alcaldia"), False)
                fr.IRPagado = IsNull(vFacturas.GetRowCellValue(i, "IR_Pagado"), False)

                If fr.IVAAsumido = True Then
                    MontoIVAasumido = SubTotal + MontoIVAasumido
                End If

                If fr.IR_Pagado_Alcaldia = True Then
                    If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= MunDet.Impuesto_SVenta_Min Then
                        Monto_IR_Pagado_Alcaldia = SubTotal + Monto_IR_Pagado_Alcaldia
                    End If
                End If

                'MunDet.Impuesto_SVenta()

                'If fr.IRPagado = True And CDbl(GridView1.GetRowCellValue(i, "Monto")) >= Conf.GetConfigDetails().MontoIR Then
                '    Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                'End If

                If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                    If fr.IRPagado = True And CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= Conf.GetConfigDetails().MontoIR Then
                        Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                    End If
                Else
                    If fr.IRPagado = True And CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= Conf.GetConfigDetails().MontoIR Then
                        Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                    End If
                End If

                '
                Try
                    fr.IRPagado = vFacturas.GetRowCellValue(i, "IR_Pagado")
                Catch ex As Exception
                    fr.IRPagado = False
                End Try

                If fr.IRPagado = False Then
                    'If CDbl(GridView1.GetRowCellValue(i, "Monto")) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo")).Exento) = False Then
                    If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIRxPagar = FactValor + MontoIRxPagar
                            SubTotalIRxPagar = SubTotalIRxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1))
                        End If
                    Else
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIRxPagar = FactValor + MontoIRxPagar
                            SubTotalIRxPagar = SubTotalIRxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar"))
                        End If
                    End If
                Else
                    If SegundoIR = False Then
                        SegundoIR = True
                    End If
                End If

                If fr.IR_Pagado_Alcaldia = False Then
                    If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= MunDet.Impuesto_SVenta_Min And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIR_ALMAxPagar = FactValor + MontoIR_ALMAxPagar
                            SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1))
                        End If
                    Else
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= MunDet.Impuesto_SVenta_Min And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIR_ALMAxPagar = FactValor + MontoIR_ALMAxPagar
                            SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar"))
                        End If
                    End If
                End If

                fr.etFecha.Text = vFacturas.GetRowCellValue(i, "Fecha")
            End If
        Next

        Fact = Fact.Substring(0, Fact.Length - 3)
        CompFact = CompFact.Substring(0, CompFact.Length - 3)

        fr.CompFact = CompFact
        fr.SaldoFact = SaldoFact
        fr.FactPagar = FactPagar
        fr.SegundoIR = SegundoIR
        fr.Fecha.DateTime = Me.fecha.DateTime
        fr.TasaPago = Me.txtTasa.EditValue

        fr.lblFact.Text = Fact
        fr.lblFactMonto.Text = FactValor
        fr.FactMnto = FactMnto
        fr.FactSubTotalIR = FactSubTotalIR
        fr.FactIR = FactIR

        fr.SubTotal = SubTotal

        fr.IVAAsumido = IVAAsumido
        fr.IRPagado = IRPagado

        fr.MontoIVAasumido = MontoIVAasumido
        fr.Monto_IR_Pagado_Alcaldia = Monto_IR_Pagado_Alcaldia
        fr.Monto_IR_Pagado = Monto_IR_Pagado
        fr.MontoIRxPagar = MontoIRxPagar
        fr.SubTotalIRxPagar = SubTotalIRxPagar
        fr.MontoIR_ALMAxPagar = MontoIR_ALMAxPagar
        fr.SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar
        fr.Show()
        fr.WindowState = FormWindowState.Maximized
        fr.etInicio.Text = "1"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgFacturasProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If lblTipoProv.Text = 0 Then
            Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "Productos")
        Else
            Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "Servicios")
        End If
    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        If etInicio.Text = "1" Then
            ShowSplash()
            txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub vFacturas_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vFacturas.CellValueChanged

        If e.Column.FieldName = "Pagar" Then
            If Not IsNumeric(e.Value) Then
                Me.vFacturas.SetRowCellValue(e.RowHandle, "Pagar", 0.0)
            ElseIf e.Value <= 0 Then
                'If Not Temp Then XtraMsg("Introduzca una Cantidad Mayor que Cero (0)", MessageBoxIcon.Error)
                XtraMsg("Introduzca una Cantidad Mayor que Cero (0)", MessageBoxIcon.Error)
            Else
                If Not Temp Then
                    Temp = True
                    Me.vFacturas.SetRowCellValue(e.RowHandle, "PagarU", Math.Round(CDbl(e.Value / Me.txtTasa.EditValue), 2))
                    If Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda") <> MonedaBase Then
                        Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(Me.vFacturas.GetRowCellValue(e.RowHandle, "Fecha"),
                                                                                            Me.fecha.DateTime.Date, Math.Round(CDbl(e.Value / Me.txtTasa.EditValue), 4),
                                                                                            Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda"))
                        If CDbl(Me.vFacturas.GetRowCellValue(e.RowHandle, "Mnto")) > 0 Then Me.vFacturas.SetRowCellValue(e.RowHandle, "Mnto", Mnto)
                    End If
                    Temp = False
                End If
            End If
        End If

        If e.Column.FieldName = "PagarU" Then
            If Not IsNumeric(e.Value) Then
                Me.vFacturas.SetRowCellValue(e.RowHandle, "PagarU", 0.0)
            ElseIf e.Value <= 0 Then
                XtraMsg("Introduzca una Cantidad Mayor que Cero (0)", MessageBoxIcon.Error)
            Else
                If Not Temp Then
                    Temp = True
                    Me.vFacturas.SetRowCellValue(e.RowHandle, "Pagar", Math.Round(CDbl(e.Value * Me.txtTasa.EditValue), 2))
                    If Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda") <> MonedaBase Then
                        Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(Me.vFacturas.GetRowCellValue(e.RowHandle, "Fecha"), _
                                                                                            Me.fecha.DateTime.Date, e.Value, _
                                                                                            Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda"))
                        If CDbl(Me.vFacturas.GetRowCellValue(e.RowHandle, "Mnto")) > 0 Then Me.vFacturas.SetRowCellValue(e.RowHandle, "Mnto", Mnto)
                    End If
                    Temp = False
                End If
            End If
        End If

        If e.Column.FieldName = "Mnto" Then
            If Not IsNumeric(e.Value) Then
                Me.vFacturas.SetRowCellValue(e.RowHandle, "Mnto", 0.0)
            Else
                If Not Temp Then
                    Temp = True
                    If Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda") <> MonedaBase Then
                        Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(Me.vFacturas.GetRowCellValue(e.RowHandle, "Fecha"),
                                                                                            Me.fecha.DateTime.Date, Me.vFacturas.GetRowCellValue(e.RowHandle, "PagarU"),
                                                                                            Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda"))

                        Me.vFacturas.SetRowCellValue(e.RowHandle, "Pagar", Math.Round(CDbl(Me.vFacturas.GetRowCellValue(e.RowHandle, "Pagar") - Mnto), 2))
                        Me.vFacturas.SetRowCellValue(e.RowHandle, "PagarU", Math.Round(CDbl(Me.vFacturas.GetRowCellValue(e.RowHandle, "Pagar") / Me.txtTasa.EditValue), 2))
                    End If
                    Temp = False
                End If
            End If
        End If
    End Sub

    Private Sub txtTasa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTasa.Validating
        If etInicio.Text = "1" Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.GridControl1)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If sender.checked = True Then Me.vFacturas.ColumnsCustomization() Else Me.vFacturas.DestroyCustomization()
    End Sub

    Private Sub frmListaFacturaProveedoresPlan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim dtOld As DataTable = ds.GetChanges(DataRowState.Modified)
            ShowSplash()
            '
            Cargar()

            If Not dtOld Is Nothing Then
                For i As Integer = 0 To vFacturas.DataRowCount - 1
                    For j As Integer = 0 To dtOld.Rows.Count - 1
                        If dtOld.Rows.Item(j)("Factura") = vFacturas.GetRowCellValue(i, "Factura") And
                            dtOld.Rows.Item(j)("ProveedorId") = vFacturas.GetRowCellValue(i, "ProveedorId") Then
                            vFacturas.SetRowCellValue(i, "Selecc", dtOld.Rows.Item(j)("Selecc"))
                        End If
                    Next
                Next
                vFacturas.RefreshData()
            End If
            HideSplash()
        End If
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.F5 Then
            'Dim dtOld As DataTable = ds.Tables(0).GetChanges(DataRowState.Modified)

            'Cargar()

            'If Not dtOld Is Nothing Then
            '    For i As Integer = 0 To vFacturas.DataRowCount - 1
            '        For j As Integer = 0 To dtOld.Rows.Count - 1
            '            If dtOld.Rows.Item(j)("Factura") = vFacturas.GetRowCellValue(i, "Factura") And _
            '                dtOld.Rows.Item(j)("ProveedorId") = vFacturas.GetRowCellValue(i, "ProveedorId") Then
            '                vFacturas.SetRowCellValue(i, "Selecc", dtOld.Rows.Item(j)("Selecc"))
            '            End If
            '        Next
            '    Next
            '    vFacturas.RefreshData()
            'End If
        End If
    End Sub

    Private Sub btnCChica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCChica.Click

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        Dim Proveedor As String
        Dim CompFact, SaldoFact As String, FactPagar As String
        Dim IR_Pagado_Alcaldia, IRPagado, IVAAsumido As Boolean

        'Para Pagos en Cordobas
        Dim Monto_IR_Pagado, Monto_IR_Pagado_Alcaldia, MontoIVAasumido, MontoIRxPagar, SubTotalIRxPagar, _
        MontoIR_ALMAxPagar, SubTotalIR_ALMAxPagar As Double

        'Para los Pagos en Dolares
        Dim Monto_IR_PagadoUS, Monto_IR_Pagado_AlcaldiaUS, MontoIVAasumidoUS, MontoIRxPagarUS, SubTotalIRxPagarUS, _
        MontoIR_ALMAxPagarUS, SubTotalIR_ALMAxPagarUS As Double

        Dim MntoValor1, MntoValor2, TC1, TC2 As Double
        Dim SegundoIR As Boolean = False
        '        SegundoIR = False

        'Dim fr As New frmPagoFacturas
        'fr.etInicio.Text = "0"
        'fr.MdiParent = Me.MdiParent
        'Dim fr As frmPlantillasBancos = fr.Instance
        'fr.MdiParent = Me.MdiParent

        MontoIVAasumido = 0
        SubTotal = 0
        FactValor = 0
        FactMnto = 0
        Fact = ""
        CompFact = ""

        '******************************************************************************************
        '*** VALIDA SI TIENEN ALGO SELECCIONADO
        '******************************************************************************************
        Dim Control As Boolean = False
        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Control = True
                Exit For
            End If
            Control = False
        Next

        If Control = False Then
            XtraMsg("Por favor seleccionar al menos una factura para pagar")
            Exit Sub
        End If
        '******************************************************************************************
        IRPagado = True

        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "IR_Pagado")) = False Then
                        IRPagado = False
                    End If
                Catch ex As Exception
                    IRPagado = False
                    Exit For
                End Try
            End If
        Next

        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "Iva_Asumido")) = True Then
                        IVAAsumido = True
                        Exit For
                    End If
                Catch ex As Exception
                    IVAAsumido = False
                End Try
            End If
        Next

        CrearTabla()
        Dim dr As DataRow

        For i = 0 To Me.vFacturas.RowCount - 1  ' Llenar Tabla
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then

                dr = dtFact.NewRow

                dr("Proveedor_ID") = vFacturas.GetRowCellValue(i, "Codigo")
                dr("Cuenta") = vFacturas.GetRowCellValue(i, "Cuenta")
                dr("Proveedor") = vFacturas.GetRowCellValue(i, "Nombre").ToString.Trim
                dr("#Factura") = vFacturas.GetRowCellValue(i, "Factura")
                dr("Saldo") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("Debito") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("Credito") = 0.0
                dr("Mnto.") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Mnto")), 2)
                dr("A Pagar") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("A Pagar U$") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo") + vFacturas.GetRowCellValue(i, "Mnto")) / txtTasa.EditValue, 2)
                dr("Fecha") = CDate(Me.vFacturas.GetRowCellValue(i, "Fecha")).Date
                ''
                dr("Comp_No") = vFacturas.GetRowCellValue(i, "Comp_No")
                dr("Mes") = vFacturas.GetRowCellValue(i, "Mes")
                dr("Per_ID") = vFacturas.GetRowCellValue(i, "Per_ID")

                dtFact.Rows.Add(dr)
            End If
        Next

        With frmPagoCajaChica
            .Fecha.DateTime = fecha.DateTime.Date
            .txtTasa.EditValue = txtTasa.EditValue
            .dtFact = dtFact
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Sub CrearTabla()
        dtFact = Nothing
        dtFact = New DataTable

        dtFact.Columns.Add("Proveedor_ID", Type.GetType("System.Int32"))
        dtFact.Columns.Add("Cuenta", Type.GetType("System.String"))
        dtFact.Columns.Add("Proveedor", Type.GetType("System.String"))
        dtFact.Columns.Add("#Factura", Type.GetType("System.String"))
        dtFact.Columns.Add("Saldo", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Debito", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Credito", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Mnto.", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("A Pagar", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("A Pagar U$", Type.GetType("System.Decimal"))
        dtFact.Columns.Add("Fecha", Type.GetType("System.String"))

        dtFact.Columns.Add("Comp_No", Type.GetType("System.String"))
        dtFact.Columns.Add("Mes", Type.GetType("System.String"))
        dtFact.Columns.Add("Per_ID", Type.GetType("System.String"))
    End Sub

    Private Sub txtTasa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTasa.EditValueChanged

    End Sub

    'Private Sub vFacturas_KeyDown(sender As Object, e As KeyEventArgs) Handles vFacturas.KeyDown
    '    If e.KeyCode = Keys.F5 Then
    '        ShowSplash()
    '        Cargar()
    '        HideSplash()
    '    End If
    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        Dim MontoIVAasumido As Double = 0
        Dim CompFact As String = "", IRPagado As Boolean

        SubTotal = 0 : FactValor = 0 : FactMnto = 0 : Fact = ""


        '******************************************************************************************
        '*** VALIDA SI TIENEN ALGO SELECCIONADO
        '******************************************************************************************
        Dim Control As Boolean = False
        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Control = True
                Exit For
            End If
            Control = False
        Next

        If Control = False Then
            XtraMsg("Por favor seleccionar al menos una factura para pagar")
            Exit Sub
        End If
        '******************************************************************************************
        IRPagado = True

        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "IR_Pagado")) = False Then
                        IRPagado = False
                    End If
                Catch ex As Exception
                    IRPagado = False
                    Exit For
                End Try
            End If
        Next

        For i As Integer = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "Iva_Asumido")) = True Then
                        IVAAsumido = True
                        Exit For
                    End If
                Catch ex As Exception
                    IVAAsumido = False
                End Try
            End If
        Next

        CrearTabla()
        Dim dr As DataRow

        For i = 0 To Me.vFacturas.RowCount - 1  ' Llenar Tabla
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then

                dr = dtFact.NewRow

                dr("Proveedor_ID") = vFacturas.GetRowCellValue(i, "Codigo")
                dr("Cuenta") = vFacturas.GetRowCellValue(i, "Cuenta")
                dr("Proveedor") = vFacturas.GetRowCellValue(i, "Nombre").ToString.Trim
                dr("#Factura") = vFacturas.GetRowCellValue(i, "Factura")
                dr("Saldo") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("Debito") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("Credito") = 0.0
                dr("Mnto.") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Mnto")), 2)
                dr("A Pagar") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo")), 2)
                dr("A Pagar U$") = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "Saldo") + vFacturas.GetRowCellValue(i, "Mnto")) / txtTasa.EditValue, 2)
                dr("Fecha") = CDate(Me.vFacturas.GetRowCellValue(i, "Fecha")).Date
                ''
                dr("Comp_No") = vFacturas.GetRowCellValue(i, "Comp_No")
                dr("Mes") = vFacturas.GetRowCellValue(i, "Mes")
                dr("Per_ID") = vFacturas.GetRowCellValue(i, "Per_ID")

                dtFact.Rows.Add(dr)
            End If
        Next

        With frmRendicionCuenta
            .Fecha.DateTime = fecha.DateTime.Date
            .txtTasa.EditValue = txtTasa.EditValue
            .dtFact = dtFact
            .ShowDialog()
            .Dispose()
        End With

    End Sub
End Class
