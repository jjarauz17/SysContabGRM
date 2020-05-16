Imports SysContab.VB.SysContab
Imports DevExpress.XtraEditors

Public Class frmComprobantesDescuadrados
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents dgComprobantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents VComprobantes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCuadrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPeriodos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbDC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCuadrar As System.Windows.Forms.CheckBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAll As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgComprobantes = New DevExpress.XtraGrid.GridControl()
        Me.VComprobantes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbDC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCuadrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPeriodos = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkCuadrar = New System.Windows.Forms.CheckBox()
        Me.chkAll = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgComprobantes
        '
        Me.dgComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgComprobantes.Location = New System.Drawing.Point(12, 111)
        Me.dgComprobantes.MainView = Me.VComprobantes
        Me.dgComprobantes.Name = "dgComprobantes"
        Me.dgComprobantes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.cbDC})
        Me.dgComprobantes.Size = New System.Drawing.Size(991, 275)
        Me.dgComprobantes.TabIndex = 174
        Me.dgComprobantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VComprobantes})
        '
        'VComprobantes
        '
        Me.VComprobantes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VComprobantes.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VComprobantes.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VComprobantes.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.Empty.Options.UseBackColor = True
        Me.VComprobantes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.EvenRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.EvenRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VComprobantes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VComprobantes.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.VComprobantes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VComprobantes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VComprobantes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.VComprobantes.Appearance.FixedLine.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VComprobantes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.VComprobantes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VComprobantes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VComprobantes.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VComprobantes.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.FooterPanel.Options.UseForeColor = True
        Me.VComprobantes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.GroupButton.Options.UseBackColor = True
        Me.VComprobantes.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.GroupButton.Options.UseForeColor = True
        Me.VComprobantes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VComprobantes.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.GroupFooter.Options.UseForeColor = True
        Me.VComprobantes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VComprobantes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VComprobantes.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VComprobantes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VComprobantes.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VComprobantes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.GroupRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.GroupRow.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.GroupRow.Options.UseFont = True
        Me.VComprobantes.Appearance.GroupRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VComprobantes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VComprobantes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VComprobantes.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VComprobantes.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VComprobantes.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.VComprobantes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VComprobantes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VComprobantes.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.VComprobantes.Appearance.HorzLine.Options.UseBackColor = True
        Me.VComprobantes.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.OddRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.OddRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VComprobantes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VComprobantes.Appearance.Preview.Options.UseBackColor = True
        Me.VComprobantes.Appearance.Preview.Options.UseForeColor = True
        Me.VComprobantes.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.VComprobantes.Appearance.Row.Options.UseBackColor = True
        Me.VComprobantes.Appearance.Row.Options.UseForeColor = True
        Me.VComprobantes.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VComprobantes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.VComprobantes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.VComprobantes.Appearance.SelectedRow.Options.UseBackColor = True
        Me.VComprobantes.Appearance.SelectedRow.Options.UseForeColor = True
        Me.VComprobantes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.VComprobantes.Appearance.VertLine.Options.UseBackColor = True
        Me.VComprobantes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn12, Me.GridColumn8, Me.GridColumn11, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15})
        Me.VComprobantes.GridControl = Me.dgComprobantes
        Me.VComprobantes.Name = "VComprobantes"
        Me.VComprobantes.OptionsView.ShowAutoFilterRow = True
        Me.VComprobantes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VComprobantes.OptionsView.ShowFooter = True
        Me.VComprobantes.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Número"
        Me.GridColumn1.FieldName = "Comp_No"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 66
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 90
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tipo"
        Me.GridColumn3.FieldName = "Tipo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 178
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Débito"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Debito"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 103
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Crédito"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Credito"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 119
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Diferencia"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Dif"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 116
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cuenta de Ajuste"
        Me.GridColumn7.ColumnEdit = Me.cbCatalogo
        Me.GridColumn7.FieldName = "Cuenta"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 156
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.DisplayMember = "Cuenta"
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Cuenta"
        Me.GridColumn9.FieldName = "Cuenta"
        Me.GridColumn9.MinWidth = 150
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 150
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nombre"
        Me.GridColumn10.FieldName = "Nombre"
        Me.GridColumn10.MinWidth = 300
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 300
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "D/C"
        Me.GridColumn12.ColumnEdit = Me.cbDC
        Me.GridColumn12.FieldName = "DC"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Width = 63
        '
        'cbDC
        '
        Me.cbDC.AutoHeight = False
        Me.cbDC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDC.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DC", "DC")})
        Me.cbDC.DisplayMember = "DC"
        Me.cbDC.Name = "cbDC"
        Me.cbDC.NullText = ""
        Me.cbDC.ShowFooter = False
        Me.cbDC.ShowHeader = False
        Me.cbDC.ValueMember = "DC"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Seleccionar"
        Me.GridColumn8.FieldName = "selecc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 80
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Periodo"
        Me.GridColumn11.FieldName = "Per_Id"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_RedoLarge
        Me.btnExportar.Location = New System.Drawing.Point(783, 23)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(96, 34)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "E&xportar"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.btnQuit.Appearance.Options.UseFont = True
        Me.btnQuit.Appearance.Options.UseForeColor = True
        Me.btnQuit.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.btnQuit.Location = New System.Drawing.Point(884, 23)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 34)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Salir"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = Global.SysContab.My.Resources.Resources.modificar
        Me.btnEditar.Location = New System.Drawing.Point(555, 23)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(96, 34)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "&Editar"
        '
        'btnCuadrar
        '
        Me.btnCuadrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCuadrar.Appearance.Options.UseTextOptions = True
        Me.btnCuadrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCuadrar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_HtmlRefreshLarge
        Me.btnCuadrar.Location = New System.Drawing.Point(657, 23)
        Me.btnCuadrar.Name = "btnCuadrar"
        Me.btnCuadrar.Size = New System.Drawing.Size(120, 34)
        Me.btnCuadrar.TabIndex = 1
        Me.btnCuadrar.Text = "&Cuadrar Comprobantes"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_FindLarge
        Me.btnBuscar.Location = New System.Drawing.Point(453, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 34)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&Buscar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = "Periodo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Mes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbPeriodos
        '
        Me.cbPeriodos.Location = New System.Drawing.Point(65, 5)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripcion")})
        Me.cbPeriodos.Properties.DisplayMember = "descripcion"
        Me.cbPeriodos.Properties.NullText = ""
        Me.cbPeriodos.Properties.ShowFooter = False
        Me.cbPeriodos.Properties.ShowHeader = False
        Me.cbPeriodos.Properties.ValueMember = "codigo"
        Me.cbPeriodos.Size = New System.Drawing.Size(304, 20)
        Me.cbPeriodos.TabIndex = 178
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(65, 33)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Numero", "Numero", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mes", "Mes")})
        Me.cbMeses.Properties.DisplayMember = "Mes"
        Me.cbMeses.Properties.NullText = ""
        Me.cbMeses.Properties.ShowFooter = False
        Me.cbMeses.Properties.ShowHeader = False
        Me.cbMeses.Properties.ValueMember = "Numero"
        Me.cbMeses.Size = New System.Drawing.Size(304, 20)
        Me.cbMeses.TabIndex = 178
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Archivos de Excel 97-2003 (*.xls)|*.xls"
        Me.SaveFileDialog1.Title = "Exportar Información de Comprobantes"
        '
        'chkCuadrar
        '
        Me.chkCuadrar.AutoSize = True
        Me.chkCuadrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuadrar.ForeColor = System.Drawing.Color.DarkRed
        Me.chkCuadrar.Location = New System.Drawing.Point(12, 85)
        Me.chkCuadrar.Name = "chkCuadrar"
        Me.chkCuadrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCuadrar.Size = New System.Drawing.Size(194, 20)
        Me.chkCuadrar.TabIndex = 179
        Me.chkCuadrar.Text = "Cuadrar Automáticamente"
        '
        'chkAll
        '
        Me.chkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAll.Location = New System.Drawing.Point(928, 86)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.Properties.Appearance.Options.UseFont = True
        Me.chkAll.Properties.Caption = "Todos"
        Me.chkAll.Size = New System.Drawing.Size(75, 19)
        Me.chkAll.TabIndex = 180
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Controls.Add(Me.btnExportar)
        Me.PanelControl1.Controls.Add(Me.cbMeses)
        Me.PanelControl1.Controls.Add(Me.cbPeriodos)
        Me.PanelControl1.Controls.Add(Me.btnCuadrar)
        Me.PanelControl1.Controls.Add(Me.btnEditar)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.btnBuscar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(991, 68)
        Me.PanelControl1.TabIndex = 181
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "ComprobanteID"
        Me.GridColumn13.FieldName = "ComprobanteID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.AllowFocus = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "TipoLiq"
        Me.GridColumn14.FieldName = "TipoLiq"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Concecutivo"
        Me.GridColumn15.FieldName = "Concecutivo"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        '
        'frmComprobantesDescuadrados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 396)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.chkCuadrar)
        Me.Controls.Add(Me.dgComprobantes)
        Me.Name = "frmComprobantesDescuadrados"
        Me.Text = "Buscar Comprobantes con Diferencias"
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Comp As New VB.SysContab.ComprobanteDB
    Dim Mes As New VB.SysContab.MesesDB
    Dim PerDB As New VB.SysContab.PeriodosDB

    Private Shared ChildInstance As frmComprobantesDescuadrados = Nothing
    Public Shared Function Instance() As frmComprobantesDescuadrados
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComprobantesDescuadrados
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmComprobantesDescuadrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        'Cargar Meses
        Me.cbMeses.Properties.DataSource = ObtieneDatos("_MesesListv2")
        Me.cbMeses.EditValue = CDec(Now.Month)

        'Cargar Periodos
        Me.cbPeriodos.Properties.DataSource = PerDB.GetList().Tables("Periodos").DefaultView

        Dim Periodo As Integer
        Periodo = VB.SysContab.PeriodosDB.Actual
        If Periodo <> 0 Then
            Me.cbPeriodos.EditValue = Periodo
        End If

        'Cargar Catalog
        Me.cbCatalogo.DataSource = ObtieneDatos("SELECT Cuenta,Nombre FROM CATALOGO WHERE Tipo = 'A' AND Empresa = " & EmpresaActual).DefaultView
        Me.cbDC.DataSource = ObtieneDatos("SELECT 'Débito' DC UNION SELECT 'Crédito' DC").DefaultView
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.cbMeses.EditValue = 0 Then
            XtraMessageBox.Show("Seleccione el Mes.", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        Buscar()
    End Sub

    Sub Buscar()
        Me.VComprobantes.Columns("Cuenta").OptionsColumn.AllowEdit = Not Me.chkCuadrar.Checked
        Me.VComprobantes.Columns("DC").OptionsColumn.AllowEdit = Not Me.chkCuadrar.Checked

        Me.dgComprobantes.DataSource = _
        ComprobanteDB.GetComprobantes_DescuadradosList(Me.cbPeriodos.EditValue, Me.cbMeses.EditValue).DefaultView
        '
        FormatoGrid(Me.VComprobantes)
        '

        Me.VComprobantes.Columns("Debito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Debito").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Debito").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.VComprobantes.Columns("Credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Credito").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Credito").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.VComprobantes.Columns("Dif").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Dif").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Dif").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Dif").SummaryItem.DisplayFormat = "{0:n2}"

        If Me.VComprobantes.DataRowCount = 0 Then
            XtraMessageBox.Show("No se Han Encontrado Comprobantes Descuadrados.", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbPeriodos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPeriodos.EditValueChanged
        Try
            Me.dgComprobantes.DataSource = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbMeses_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMeses.EditValueChanged
        Try
            Me.dgComprobantes.DataSource = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgComprobantes)        
        'If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
        '    Me.VComprobantes.ExportToXls(Me.SaveFileDialog1.FileName)
        '    Process.Start(Me.SaveFileDialog1.FileName)
        'End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Sub Editar()

        If Me.VComprobantes.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        'Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        ''f.Guardar = True
        'f.lblNoComprobante.Text = Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Comp_No")
        'f.Periodo = Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Per_Id")
        'f.Fecha.EditValue = CDate(Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Fecha")).Date
        'f.StartPosition = FormStartPosition.CenterScreen
        'f.Width = 1024
        'f.Height = 600
        'f.ShowDialog()
        '
        Dim fn As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        fn.Dispose()
        '
        Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        f.txtlNoComprobante.EditValue = Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Comp_No")  ' Me.VComprobantes.GetFocusedRowCellValue("Numero Comp")
        f.txtConsecutivo.Text = IsNull(Me.VComprobantes.GetFocusedRowCellValue("Concecutivo"), "")
        f.Periodo = VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Per_Id")
        f.Fecha.EditValue = CDate(Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Fecha")).Date
        f.Fecha1 = CDate(Me.VComprobantes.GetRowCellValue(Me.VComprobantes.FocusedRowHandle, "Fecha")).Date
        f.ComprobanteID = Me.VComprobantes.GetFocusedRowCellValue("ComprobanteID")
        f.TipoLiq = Me.VComprobantes.GetFocusedRowCellValue("TipoLiq")

        f.Width = 1024
        f.Height = 600
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
    End Sub

    Private Sub VComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VComprobantes.DoubleClick
        Editar()
    End Sub

    Private Sub btnCuadrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadrar.Click
        If Me.VComprobantes.DataRowCount = 0 Then
            XtraMessageBox.Show("No hay Elementos en la Lista para realizar Operación", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)            
            Exit Sub
        End If

        Dim selecc As Integer = 0

        For i As Integer = 0 To Me.VComprobantes.DataRowCount - 1
            If Me.VComprobantes.GetRowCellValue(i, "selecc") Then
                selecc += 1
            End If
        Next

        If selecc = 0 Then
            XtraMessageBox.Show("Seleccione al menos 1 Comprobante de la Lista", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        CuadrarComprobantes()
    End Sub

    Sub CuadrarComprobantes()
        Dim Comp As Integer, Per_Id As Integer, Mes As Integer, Dif As Double

        For i As Integer = 0 To Me.VComprobantes.DataRowCount - 1
            Comp = Me.VComprobantes.GetRowCellValue(i, "Comp_No")
            Per_Id = Me.VComprobantes.GetRowCellValue(i, "Per_Id")
            Mes = CDate(Me.VComprobantes.GetRowCellValue(i, "Fecha")).Month
            Dif = Me.VComprobantes.GetRowCellValue(i, "Dif")
            Dif = Dif * -1

            Try
                If Me.chkCuadrar.Checked Then
                    If Me.VComprobantes.GetRowCellValue(i, "selecc") Then   'Ajustar Automaticamente
                        Dim tComp As DataTable = ObtieneDatos("SELECT TOP 1 CD.CDet_Id,* FROM ComprobantesDetalles cd WHERE cd.Comp_No = " & Comp & " AND cd.Per_Id = " & Per_Id & " AND cd.Mes = " & Mes & " AND cd.CDet_DC = 'D' AND cd.Empresa = " & EmpresaActual)
                        If tComp.Rows.Count > 0 Then
                            GuardaDatos("UPDATE ComprobantesDetalles SET CDet_Importe = CDet_Importe + " & Dif & " WHERE Cdet_Id = " & tComp.Rows.Item(0)("CDet_Id"))
                            GuardaDatos("UPDATE Distribucion SET Valor = Valor + " & Dif & " WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & tComp.Rows.Item(0)("Comp_No") & " AND Mes = " & tComp.Rows.Item(0)("Mes") & " AND Per_Id = " & tComp.Rows.Item(0)("Per_ID") & " AND Tipo = 'D' AND Cuenta = '" & tComp.Rows.Item(0)("CDet_Cuenta") & "'")
                        End If
                    End If
                Else
                End If
            Catch ex As Exception
            End Try
        Next

        XtraMessageBox.Show("Comprobantes Actualizados Correctamente !!!", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)        
        Buscar()
    End Sub

    Private Sub chkCuadrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCuadrar.Click
        Buscar()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        For i As Integer = 0 To Me.VComprobantes.DataRowCount - 1
            Me.VComprobantes.SetRowCellValue(i, "selecc", Me.chkAll.Checked)
        Next
    End Sub
End Class
