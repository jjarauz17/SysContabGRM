Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmComprobanteConcilación
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
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmComprobanteConcilaciónConvertedLayout As DevExpress.XtraLayout.LayoutControl
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
    Friend WithEvents etDif As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents etDebito As System.Windows.Forms.Label
    Friend WithEvents etCredito As System.Windows.Forms.Label
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnGuardaritem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSaliritem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.etCredito = New System.Windows.Forms.Label()
        Me.etDebito = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.etDif = New System.Windows.Forms.Label()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.btnSaliritem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnGuardaritem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.frmComprobanteConcilaciónConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaliritem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardaritem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmComprobanteConcilaciónConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmComprobanteConcilaciónConvertedLayout.SuspendLayout()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseForeColor = True
        Me.btnSalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.btnSalir.Location = New System.Drawing.Point(776, 412)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 38)
        Me.btnSalir.StyleController = Me.frmComprobanteConcilaciónConvertedLayout
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.btnGuardar.Location = New System.Drawing.Point(670, 412)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(102, 38)
        Me.btnGuardar.StyleController = Me.frmComprobanteConcilaciónConvertedLayout
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(119, 91)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(741, 43)
        Me.txtConcepto.StyleController = Me.frmComprobanteConcilaciónConvertedLayout
        Me.txtConcepto.TabIndex = 2
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(119, 67)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipoComp.Properties.Appearance.Options.UseFont = True
        Me.cbTipoComp.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.DropDownRows = 12
        Me.cbTipoComp.Properties.NullText = ""
        Me.cbTipoComp.Properties.ShowFooter = False
        Me.cbTipoComp.Properties.ShowHeader = False
        Me.cbTipoComp.Size = New System.Drawing.Size(741, 20)
        Me.cbTipoComp.StyleController = Me.frmComprobanteConcilaciónConvertedLayout
        Me.cbTipoComp.TabIndex = 1
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(119, 43)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(142, 20)
        Me.Fecha.StyleController = Me.frmComprobanteConcilaciónConvertedLayout
        Me.Fecha.TabIndex = 0
        '
        'etCredito
        '
        Me.etCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etCredito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etCredito.Location = New System.Drawing.Point(501, 388)
        Me.etCredito.Name = "etCredito"
        Me.etCredito.Size = New System.Drawing.Size(105, 20)
        Me.etCredito.TabIndex = 1015
        Me.etCredito.Text = "0.00"
        Me.etCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etDebito
        '
        Me.etDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDebito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDebito.ForeColor = System.Drawing.Color.Maroon
        Me.etDebito.Location = New System.Drawing.Point(272, 388)
        Me.etDebito.Name = "etDebito"
        Me.etDebito.Size = New System.Drawing.Size(130, 20)
        Me.etDebito.TabIndex = 1016
        Me.etDebito.Text = "0.00"
        Me.etDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 388)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 20)
        Me.Label9.TabIndex = 1017
        Me.Label9.Text = "Totales:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etDif
        '
        Me.etDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDif.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDif.ForeColor = System.Drawing.Color.Maroon
        Me.etDif.Location = New System.Drawing.Point(705, 388)
        Me.etDif.Name = "etDif"
        Me.etDif.Size = New System.Drawing.Size(167, 20)
        Me.etDif.TabIndex = 1018
        Me.etDif.Text = "0.00"
        Me.etDif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 150)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo})
        Me.gridDatos.Size = New System.Drawing.Size(860, 234)
        Me.gridDatos.TabIndex = 1
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridDatos
        Me.GridView1.Name = "GridView1"
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
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.DisplayMember = "Display"
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormSize = New System.Drawing.Size(700, 0)
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.View = Me.GridView2
        '
        'vComprobante
        '
        Me.vComprobante.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vComprobante.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vComprobante.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vComprobante.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vComprobante.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vComprobante.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vComprobante.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vComprobante.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vComprobante.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vComprobante.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.Empty.Options.UseBackColor = True
        Me.vComprobante.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.EvenRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.EvenRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vComprobante.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vComprobante.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vComprobante.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vComprobante.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vComprobante.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vComprobante.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vComprobante.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vComprobante.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.vComprobante.Appearance.FixedLine.Options.UseBackColor = True
        Me.vComprobante.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vComprobante.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vComprobante.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.vComprobante.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vComprobante.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vComprobante.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vComprobante.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vComprobante.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vComprobante.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.GroupButton.Options.UseBackColor = True
        Me.vComprobante.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vComprobante.Appearance.GroupButton.Options.UseForeColor = True
        Me.vComprobante.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vComprobante.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vComprobante.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vComprobante.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vComprobante.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vComprobante.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vComprobante.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vComprobante.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vComprobante.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.GroupRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vComprobante.Appearance.GroupRow.Options.UseFont = True
        Me.vComprobante.Appearance.GroupRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vComprobante.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vComprobante.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vComprobante.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vComprobante.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vComprobante.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vComprobante.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vComprobante.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vComprobante.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vComprobante.Appearance.HorzLine.Options.UseBackColor = True
        Me.vComprobante.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.OddRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.OddRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vComprobante.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vComprobante.Appearance.Preview.Options.UseBackColor = True
        Me.vComprobante.Appearance.Preview.Options.UseForeColor = True
        Me.vComprobante.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vComprobante.Appearance.Row.Options.UseBackColor = True
        Me.vComprobante.Appearance.Row.Options.UseForeColor = True
        Me.vComprobante.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vComprobante.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.vComprobante.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.vComprobante.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vComprobante.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vComprobante.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vComprobante.Appearance.VertLine.Options.UseBackColor = True
        Me.vComprobante.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
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
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Cuenta"
        Me.GridColumn2.ColumnEdit = Me.cbCatalogo
        Me.GridColumn2.FieldName = "Cuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 425
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.Caption = "Débito"
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Debito"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 112
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "Crédito"
        Me.GridColumn12.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Credito"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 99
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "Concepto"
        Me.GridColumn13.FieldName = "Concepto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 343
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlGroup2, Me.btnGuardaritem, Me.btnSaliritem, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(884, 462)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'btnSaliritem
        '
        Me.btnSaliritem.Control = Me.btnSalir
        Me.btnSaliritem.CustomizationFormText = "btnSaliritem"
        Me.btnSaliritem.Location = New System.Drawing.Point(764, 400)
        Me.btnSaliritem.MaxSize = New System.Drawing.Size(100, 42)
        Me.btnSaliritem.MinSize = New System.Drawing.Size(100, 42)
        Me.btnSaliritem.Name = "btnSaliritem"
        Me.btnSaliritem.Size = New System.Drawing.Size(100, 42)
        Me.btnSaliritem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.btnSaliritem.Text = "btnSaliritem"
        Me.btnSaliritem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnSaliritem.TextToControlDistance = 0
        Me.btnSaliritem.TextVisible = False
        '
        'btnGuardaritem
        '
        Me.btnGuardaritem.Control = Me.btnGuardar
        Me.btnGuardaritem.CustomizationFormText = "btnGuardaritem"
        Me.btnGuardaritem.Location = New System.Drawing.Point(658, 400)
        Me.btnGuardaritem.MaxSize = New System.Drawing.Size(106, 42)
        Me.btnGuardaritem.MinSize = New System.Drawing.Size(106, 42)
        Me.btnGuardaritem.Name = "btnGuardaritem"
        Me.btnGuardaritem.Size = New System.Drawing.Size(106, 42)
        Me.btnGuardaritem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.btnGuardaritem.Text = "btnGuardaritem"
        Me.btnGuardaritem.TextSize = New System.Drawing.Size(0, 0)
        Me.btnGuardaritem.TextToControlDistance = 0
        Me.btnGuardaritem.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "DESCRIPCION DEL COMPROBANTE"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(864, 138)
        Me.LayoutControlGroup2.Text = "DESCRIPCION DEL COMPROBANTE"
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(241, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(699, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtConcepto
        Me.LayoutControlItem8.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 47)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(109, 47)
        Me.LayoutControlItem8.Name = "txtConceptoitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(840, 47)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Concepto:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbTipoComp
        Me.LayoutControlItem7.CustomizationFormText = "Tipo Comprobante:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "cbTipoCompitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem7.Text = "Tipo Comprobante:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Fecha
        Me.LayoutControlItem6.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem6.Name = "Fechaitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(241, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Fecha:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.etCredito
        Me.LayoutControlItem5.CustomizationFormText = "etCreditoitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(394, 376)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(119, 24)
        Me.LayoutControlItem5.Name = "etCreditoitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(204, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Creditos:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.etDebito
        Me.LayoutControlItem4.CustomizationFormText = "etDebitoitem"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(165, 376)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(119, 24)
        Me.LayoutControlItem4.Name = "etDebitoitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Débitos:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Label9
        Me.LayoutControlItem3.CustomizationFormText = "Label9item"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 376)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem3.Name = "Label9item"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Label9item"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.etDif
        Me.LayoutControlItem2.CustomizationFormText = "etDifitem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(598, 376)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(119, 24)
        Me.LayoutControlItem2.Name = "etDifitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Diferencia:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gridDatos
        Me.LayoutControlItem1.CustomizationFormText = "Diferencia:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem1.Name = "gridDatositem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(864, 238)
        Me.LayoutControlItem1.Text = "Diferencia:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Bottom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmComprobanteConcilaciónConvertedLayout
        '
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.gridDatos)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.etDif)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.Label9)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.etDebito)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.etCredito)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.Fecha)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.cbTipoComp)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.txtConcepto)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.btnGuardar)
        Me.frmComprobanteConcilaciónConvertedLayout.Controls.Add(Me.btnSalir)
        Me.frmComprobanteConcilaciónConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmComprobanteConcilaciónConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmComprobanteConcilaciónConvertedLayout.Name = "frmComprobanteConcilaciónConvertedLayout"
        Me.frmComprobanteConcilaciónConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(64, 475, 250, 350)
        Me.frmComprobanteConcilaciónConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmComprobanteConcilaciónConvertedLayout.Size = New System.Drawing.Size(884, 462)
        Me.frmComprobanteConcilaciónConvertedLayout.TabIndex = 1020
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 500)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(758, 42)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmComprobanteConcilación
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.frmComprobanteConcilaciónConvertedLayout)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmComprobanteConcilación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJUSTES POR CONCILIACIONES BANCARIAS"
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaliritem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardaritem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmComprobanteConcilaciónConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmComprobanteConcilaciónConvertedLayout.ResumeLayout(False)
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public OK As String = ""
    Public Per_Id As Integer

    Private DetalleEmpresa As New VB.SysContab.EmpresasDetails
    Dim Comprobantes As New VB.SysContab.ComprobanteDB

    Private Sub frmComprobanteConcilación_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        FechasPeriodo()
    End Sub

    Sub Cargar()
        Me.Fecha.DateTime = Now.Date

        Me.cbTipoComp.Properties.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        Me.cbTipoComp.Properties.ValueMember = "TipComp_Id"
        Me.cbTipoComp.Properties.DisplayMember = "TipComp_Nombre"
        Me.cbTipoComp.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbTipoComp.Properties.Columns.Count - 1
            Me.cbTipoComp.Properties.Columns(i).Visible = False
        Next

        Me.cbTipoComp.Properties.Columns(2).Visible = True
        Me.cbTipoComp.ItemIndex = 0

        Me.gridDatos.DataSource = funciones.ObtieneDatos("SELECT '' as Cuenta,0.00 as Debito,0.00 as Credito,'' as Concepto FROM Usuarios WHERE 0=1").DefaultView
        Me.cbCatalogo.DataSource = funciones.ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual).DefaultView

        'Me.gridDatos.DataSource = ObtieneDatos("SELECT '' Cuenta,0.00 Debito, 0.00 Credito,'' Concepto FROM Usuarios WHERE 0=1")
        'Me.cbCuenta.DataSource = ObtieneDatos("Select Cuenta,Nombre,Cuenta + ' - ' + Nombre Display FROM CATALOGO WHERE Tipo = 'A' AND EMPRESA = " & EmpresaActual)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        OK = "NO"
        Me.Close()
    End Sub

    'Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
    '    Me.etDebito.Text = Math.Round(Me.GridView1.Columns("Debito").SummaryItem.SummaryValue, 2).ToString
    '    Me.etCredito.Text = Math.Round(Me.GridView1.Columns("Credito").SummaryItem.SummaryValue, 2).ToString
    '    Me.etDif.Text = Math.Round((Me.GridView1.Columns("Debito").SummaryItem.SummaryValue - Me.GridView1.Columns("Credito").SummaryItem.SummaryValue), 2).ToString
    'End Sub

    Private Sub vComprobante_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
        Try
            With Me.vComprobante

                If e.Column.FieldName = "Cuenta" Then
                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Debito")) Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If

                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Credito")) Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Debito" Then
                    If .GetRowCellValue(e.RowHandle, "Debito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Credito" Then
                    If .GetRowCellValue(e.RowHandle, "Credito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If
                End If

                .UpdateTotalSummary()

                Calcular()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vComprobante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vComprobante.KeyDown
        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Delete Then
            Me.vComprobante.DeleteSelectedRows()
            Calcular()
        End If
    End Sub

    Private Sub vComprobante_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vComprobante.RowUpdated
        Calcular()
    End Sub

    Sub Calcular()
        Try
            With Me.vComprobante
                Me.etDebito.Text = CDbl(.Columns("Debito").SummaryItem.SummaryValue).ToString(Round)
                Me.etCredito.Text = CDbl(.Columns("Credito").SummaryItem.SummaryValue).ToString(Round)
                Me.etDif.Text = (CDbl(.Columns("Debito").SummaryItem.SummaryValue) - CDbl(.Columns("Credito").SummaryItem.SummaryValue)).ToString(Round)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.cbTipoComp.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            Me.cbTipoComp.Focus()
            Exit Sub
        End If

        If Me.vComprobante.DataRowCount < 2 Then
            XtraMsg("Debe ingresar al menos dos lineas en el comprobante", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Débito", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Crédito", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) <> CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) Then
            XtraMsg("El Débito y el Crédito No están cuadrados", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante")
            Me.txtConcepto.Focus()
            Exit Sub
        End If

        GuardarComprobante()
    End Sub

    Sub GuardarComprobante()

        Dim Cuenta As String = String.Empty

        Dim DC As String = String.Empty
        Dim Importe As Decimal = 0
        Dim NoComp As Double = 0

        DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        '----------------------------------
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion)
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '------------------------------------

        'Encabezado Comprobante
        NoComp = ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, 1, Me.txtConcepto.Text, _
        DetalleEmpresa.MonedaBase, CInt(PeriodosDB.Activo(Me.Fecha.DateTime)), Me.Fecha.DateTime.Date, "", "", False, 0, "", 99, 0, Fecha.DateTime.ToShortDateString, 0, OrigenComprobantes.NATURAL)

        'Detalle del Comprobante
        With Me.vComprobante
            Try
                For i As Integer = 0 To .DataRowCount - 1
                    Cuenta = .GetRowCellValue(i, "Cuenta")

                    If .GetRowCellValue(i, "Debito") > 0 Then
                        DC = "D"
                        Importe = .GetRowCellValue(i, "Debito")
                    ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                        DC = "C"
                        Importe = .GetRowCellValue(i, "Credito")
                    End If

                    Comprobantes.AddComprobanteDetalles(NoComp, Cuenta, .GetRowCellValue(i, "Concepto").ToString, Math.Round(Importe, 2), 0, Me.cbTipoComp.EditValue, DC, 0, 0, Fecha.DateTime.Date, 1)
                Next

                OK = "SI"
                VB.SysContab.Rutinas.okTransaccion()

                Me.Close()
            Catch ex As Exception
                OK = "NO"
                XtraMsg("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo" & vbCrLf & ex.Message, MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End Try
        End With
    End Sub

    'Sub LimpiarControles()
    '    Me.txtConcepto.Text = String.Empty
    '    Me.gridDatos.DataSource = Nothing
    '    Me.etDebito.Text = (0).ToString(Round)
    '    Me.etCredito.Text = (0).ToString(Round)
    '    Me.etDif.Text = (0).ToString(Round)
    '    Me.Fecha.DateTime = Now.Date
    'End Sub

    Sub FechasPeriodo()
        Try
            Dim dtl As New VB.SysContab.PeriodoDetails
            dtl = VB.SysContab.PeriodosDB.GetDetails(Per_Id)

            Me.Fecha.Properties.MinValue = dtl.Inicio
            Me.Fecha.Properties.MaxValue = dtl.Final
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmComprobanteConcilación_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If OK = "SI" Then
        '    Dim f As frmBcosConc = f.Instance
        '    f.CargarDatos()
        '    f.CargarDatosXML()
        'End If
    End Sub
End Class
