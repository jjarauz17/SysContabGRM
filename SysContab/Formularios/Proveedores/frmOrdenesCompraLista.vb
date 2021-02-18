Imports System.IO
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Columns

Public Class frmOrdenesCompraLista
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmOrdenesCompraLista = Nothing

    Public Shared Function Instance() As frmOrdenesCompraLista
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOrdenesCompraLista
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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAprobar As SimpleButton
    Friend WithEvents rLink As Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bAprobarLiq As SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bMercaderia As SimpleButton
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bReporteDinamico As SimpleButton
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As CheckEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesCompraLista))
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cBoxFecha = New System.Windows.Forms.CheckBox()
        Me.cmdImprimir1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bReporteDinamico = New DevExpress.XtraEditors.SimpleButton()
        Me.bMercaderia = New DevExpress.XtraEditors.SimpleButton()
        Me.bAprobarLiq = New DevExpress.XtraEditors.SimpleButton()
        Me.bAprobar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.cmdEntradaAlmacen = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 64)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rLink})
        Me.iGrid.Size = New System.Drawing.Size(538, 517)
        Me.iGrid.TabIndex = 167
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.ColumnPanelRowHeight = 30
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn15, Me.GridColumn10, Me.GridColumn3, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn16})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "No. Orden"
        Me.GridColumn14.FieldName = "No. Orden"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        Me.GridColumn14.Width = 68
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Concecutivo"
        Me.GridColumn1.FieldName = "Orden"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 84
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 97
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Proveedor"
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 191
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Monto"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Monto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 92
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Descuento"
        Me.GridColumn6.FieldName = "Descuento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 97
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Sub Total"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Sub Total"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sub Total", "{0:n2}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 66
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "IVA"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "IVA"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn9.Caption = "Total"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Total"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 62
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn15.Caption = "Total U$"
        Me.GridColumn15.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "TotalU"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalU", "{0:n2}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 9
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Estado"
        Me.GridColumn10.FieldName = "Estado"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 65
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Destino"
        Me.GridColumn3.FieldName = "Destino"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Width = 110
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.Caption = "Factura_Origen"
        Me.GridColumn11.FieldName = "Factura_Origen"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.Caption = "OrdenCompra"
        Me.GridColumn12.FieldName = "OrdenCompra"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Aprobar"
        Me.GridColumn13.FieldName = "Aprobar"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        Me.GridColumn13.Width = 80
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Liquidar"
        Me.GridColumn16.FieldName = "Liquidar"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 12
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Adjunto"
        Me.rLink.Name = "rLink"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(419, 62)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(204, 20)
        Me.dtpFecha.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(319, 62)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(304, 20)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdImprimir1
        '
        Me.cmdImprimir1.Enabled = False
        Me.cmdImprimir1.ImageOptions.Image = CType(resources.GetObject("cmdImprimir1.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir1.Location = New System.Drawing.Point(12, 172)
        Me.cmdImprimir1.Name = "cmdImprimir1"
        Me.cmdImprimir1.Size = New System.Drawing.Size(109, 36)
        Me.cmdImprimir1.StyleController = Me.LayoutControl2
        Me.cmdImprimir1.TabIndex = 10
        Me.cmdImprimir1.Text = "&Imprimir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bReporteDinamico)
        Me.LayoutControl2.Controls.Add(Me.bMercaderia)
        Me.LayoutControl2.Controls.Add(Me.bAprobarLiq)
        Me.LayoutControl2.Controls.Add(Me.bAprobar)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Controls.Add(Me.bBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdModificar)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.btnDiseno)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir1)
        Me.LayoutControl2.Controls.Add(Me.cmdFacturar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(133, 564)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bReporteDinamico
        '
        Me.bReporteDinamico.Appearance.Options.UseTextOptions = True
        Me.bReporteDinamico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bReporteDinamico.Enabled = False
        Me.bReporteDinamico.ImageOptions.Image = CType(resources.GetObject("bReporteDinamico.ImageOptions.Image"), System.Drawing.Image)
        Me.bReporteDinamico.Location = New System.Drawing.Point(12, 338)
        Me.bReporteDinamico.Name = "bReporteDinamico"
        Me.bReporteDinamico.Size = New System.Drawing.Size(107, 38)
        Me.bReporteDinamico.StyleController = Me.LayoutControl2
        Me.bReporteDinamico.TabIndex = 172
        Me.bReporteDinamico.Text = "&Reporte Dinámico"
        '
        'bMercaderia
        '
        Me.bMercaderia.Appearance.Options.UseTextOptions = True
        Me.bMercaderia.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bMercaderia.Enabled = False
        Me.bMercaderia.ImageOptions.Image = CType(resources.GetObject("bMercaderia.ImageOptions.Image"), System.Drawing.Image)
        Me.bMercaderia.Location = New System.Drawing.Point(12, 380)
        Me.bMercaderia.Name = "bMercaderia"
        Me.bMercaderia.Size = New System.Drawing.Size(107, 38)
        Me.bMercaderia.StyleController = Me.LayoutControl2
        Me.bMercaderia.TabIndex = 172
        Me.bMercaderia.Text = "&Mercaderia en Transito"
        '
        'bAprobarLiq
        '
        Me.bAprobarLiq.Appearance.Options.UseTextOptions = True
        Me.bAprobarLiq.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAprobarLiq.Enabled = False
        Me.bAprobarLiq.ImageOptions.Image = CType(resources.GetObject("bAprobarLiq.ImageOptions.Image"), System.Drawing.Image)
        Me.bAprobarLiq.Location = New System.Drawing.Point(12, 254)
        Me.bAprobarLiq.Name = "bAprobarLiq"
        Me.bAprobarLiq.Size = New System.Drawing.Size(107, 38)
        Me.bAprobarLiq.StyleController = Me.LayoutControl2
        Me.bAprobarLiq.TabIndex = 172
        Me.bAprobarLiq.Text = "&Aprobar O/C Liquidación"
        '
        'bAprobar
        '
        Me.bAprobar.Appearance.Options.UseTextOptions = True
        Me.bAprobar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAprobar.Enabled = False
        Me.bAprobar.ImageOptions.Image = CType(resources.GetObject("bAprobar.ImageOptions.Image"), System.Drawing.Image)
        Me.bAprobar.Location = New System.Drawing.Point(12, 212)
        Me.bAprobar.Name = "bAprobar"
        Me.bAprobar.Size = New System.Drawing.Size(107, 38)
        Me.bAprobar.StyleController = Me.LayoutControl2
        Me.bAprobar.TabIndex = 171
        Me.bAprobar.Text = "&Aprobar O/C"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(109, 36)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'bBorrar
        '
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(12, 132)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(109, 36)
        Me.bBorrar.StyleController = Me.LayoutControl2
        Me.bBorrar.TabIndex = 171
        Me.bBorrar.Text = "&Borrar"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 516)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(109, 36)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 52)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(109, 36)
        Me.cmdModificar.StyleController = Me.LayoutControl2
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 92)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(109, 36)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Anular"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 476)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(109, 36)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "E&xportar"
        '
        'btnDiseno
        '
        Me.btnDiseno.Enabled = False
        Me.btnDiseno.ImageOptions.Image = CType(resources.GetObject("btnDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDiseno.Location = New System.Drawing.Point(12, 436)
        Me.btnDiseno.Name = "btnDiseno"
        Me.btnDiseno.Size = New System.Drawing.Size(109, 36)
        Me.btnDiseno.StyleController = Me.LayoutControl2
        Me.btnDiseno.TabIndex = 11
        Me.btnDiseno.Text = "&Diseño"
        '
        'cmdFacturar
        '
        Me.cmdFacturar.Appearance.Options.UseTextOptions = True
        Me.cmdFacturar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdFacturar.Enabled = False
        Me.cmdFacturar.ImageOptions.Image = CType(resources.GetObject("cmdFacturar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdFacturar.Location = New System.Drawing.Point(12, 296)
        Me.cmdFacturar.Name = "cmdFacturar"
        Me.cmdFacturar.Size = New System.Drawing.Size(107, 38)
        Me.cmdFacturar.StyleController = Me.LayoutControl2
        Me.cmdFacturar.TabIndex = 7
        Me.cmdFacturar.Text = "&Trasladar a Orden Pago"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem4, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem11, Me.LayoutControlItem3, Me.LayoutControlItem12, Me.LayoutControlItem10, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem20, Me.LayoutControlItem21})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(133, 564)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdNuevo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 410)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(113, 14)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdModificar
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdBorrar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bBorrar
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdImprimir1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bAprobar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 200)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bAprobarLiq
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 242)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdFacturar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 284)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnDiseno
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdAyuda
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 464)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdSalir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 504)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.bMercaderia
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.bReporteDinamico
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 326)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.cmdEntradaAlmacen)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cBoxFecha)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1005, 145, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(562, 593)
        Me.LayoutControl1.TabIndex = 170
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(450, 41)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Multi-Selección"
        Me.CheckEdit1.Size = New System.Drawing.Size(100, 20)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 171
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(185, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(96, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 170
        Me.SimpleButton1.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(49, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(132, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 169
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(49, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Size = New System.Drawing.Size(132, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 168
        '
        'cmdEntradaAlmacen
        '
        Me.cmdEntradaAlmacen.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaAlmacen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaAlmacen.Location = New System.Drawing.Point(768, 381)
        Me.cmdEntradaAlmacen.Name = "cmdEntradaAlmacen"
        Me.cmdEntradaAlmacen.Size = New System.Drawing.Size(115, 22)
        Me.cmdEntradaAlmacen.StyleController = Me.LayoutControl1
        Me.cmdEntradaAlmacen.TabIndex = 9
        Me.cmdEntradaAlmacen.Text = "&Entrada a Almacen"
        Me.cmdEntradaAlmacen.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(768, 364)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(57, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reporte"
        Me.cmdImprimir.Visible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpFecha
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(307, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(308, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cBoxFecha
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(307, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(308, 50)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdImprimir
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(756, 352)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(61, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdEntradaAlmacen
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(756, 369)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(119, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem22, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(562, 593)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.iGrid
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(542, 521)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.Desde
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "Desde:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Hasta
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(173, 28)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Hasta:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SimpleButton1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(173, 10)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(273, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(269, 29)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(173, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(100, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.CheckEdit1
        Me.LayoutControlItem22.Location = New System.Drawing.Point(438, 29)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(104, 23)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(104, 23)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(104, 23)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        Me.LayoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(273, 29)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(165, 23)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("d1bcdd6e-3c1b-421d-8d3e-09d90accd1df")
        Me.DockPanel1.Location = New System.Drawing.Point(562, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 593)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 564)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmOrdenesCompraLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(702, 593)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmOrdenesCompraLista"
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Public Ordenes As New VB.SysContab.Ordenes_ComprasDB
    ' Dim r As New VB.SysContab.Rutinas
    Dim _DT As New DataTable("OrdenCompra")
    'Dim ds As DataSet
    'Public Fecha As String

    Private Sub frmOrdenesCompraLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        RolesDB.UsuarioAcciones(LayoutControl2)

        'Me.dtpFecha.Value = r.Fecha
        'Fecha = ""

        'cbEstado.SelectedIndex = 0
        'cbOrigen.SelectedIndex = 0
        'cbDestino.SelectedIndex = 0

        'cbProveedor.Properties.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
        'cbProveedor.Properties.ValueMember = "Codigo"
        'cbProveedor.Properties.DisplayMember = "Nombre"
        'cbProveedor.Properties.PopulateColumns()
        'Me.cbProveedor.Properties.Columns("Codigo").Visible = False
        'Me.cbProveedor.Properties.Columns("Tipo").Visible = False
        'Me.cbProveedor.Properties.Columns("Empresa").Visible = False
        'Me.cbProveedor.EditValue = 0

        'cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        'cbTipo.ValueMember = "Codigo"
        'cbTipo.DisplayMember = "Nombre"

        Cargar()
        '
        Formato()
        'r.FormatGenerico(dgOrdenes, Tabla)
        'r.ComboAutoComplete(Me.cbProveedor)
        'dgOrdenes.CaptionText = "           Ordenes de Compra"
        'dgOrdenes.ReadOnly = True
        'dtpFecha.Enabled = False
        'Me.Refresh()
    End Sub

    Public Sub Cargar()
        _DT = ObtieneDatos("JAR_OrdenesCompraXProveedor",
                                        Desde.DateTime.Date,
                                        Hasta.DateTime.Date,
                                        EmpresaActual)
        iGrid.DataSource = _DT


        'Try
        '    ds = Ordenes.OrdenesCompraXProveedor(0, Fecha, cbEstado.SelectedIndex, _
        '                                         cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex, cbDestino.SelectedIndex)
        '    Me.iGrid.DataSource = ds.Tables("Ordenes_Compra").DefaultView
        '    Me.iVista.Columns("Aprobar").Visible = AbrobarOrden  'Si se pedira Aprobación de la Orden
        '    Tabla = ds.Tables("Ordenes_Compra")
        '    Me.iVista.BestFitColumns()
        'Catch ex As Exception
        'End Try

    End Sub

    Sub Formato()
        iVista.PopulateColumns()

        FormatoGrid(iVista, 2, 0, False, True, True)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Orden").Caption = "Consecutivo"
        iVista.Columns("Factura_Origen").Visible = False
        iVista.Columns("Destino").Visible = False

        iVista.Columns("#").OptionsColumn.AllowEdit = True
        iVista.Columns("#").ColumnEdit = rLink
        iVista.Columns("#").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        iVista.Columns("Seleccionar").Width = 50
        iVista.Columns("Seleccionar").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Entrega")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Entrega] = 'Pendiente' OR [Entrega] = 'Parcial'")
    End Sub

    'Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If IsNumeric(cbProveedor.EditValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
    '        Cargar()
    '    End If
    'End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        'dtpFecha.Enabled = cBoxFecha.Checked
        'If cBoxFecha.Checked = True Then
        '    Fecha = dtpFecha.Value.Date
        'Else
        '    Fecha = ""
        'End If
        'Cargar()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        'If Fecha = Nothing Then
        '    Exit Sub
        'End If

        'Fecha = dtpFecha.Value.Date
        'Cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturar.Click

        Dim sIdOrden As String = String.Empty,
            sNoOrden As String = String.Empty,
            MultiSelect As Boolean = False

        If CheckEdit1.Checked Then
            _DT.AcceptChanges()
            'Validar que se seleccione al menos una OC.
            If _DT.Select("Seleccionar = 1").Length = 0 Then
                XtraMsg("Debe Seleccionar al menos una O/C cuando la opción de Multi-Selección este activa.", MessageBoxIcon.Warning)
                CheckEdit1.Focus()
                Exit Sub
            End If

            Dim dt_select As DataTable =
                _DT.Select("Seleccionar = 1").CopyToDataTable()


            If _DT.Select("Seleccionar = 1").Length = 0 Then
                XtraMsg("Debe Seleccionar al menos una O/C cuando la opción de Multi-Selección este activa.", MessageBoxIcon.Warning)
                CheckEdit1.Focus()
                Exit Sub
            End If
            '            
            'Aplicar LinQ para detectar si hay mas de un proveedor seleccionado
            Dim sProvedor As IEnumerable(Of String) =
                        From row In dt_select.AsEnumerable()
                        Select row.Field(Of String)("Proveedor") Distinct

            If sProvedor.Count > 1 Then
                XtraMsg("Las O/C seleccionadas deben ser del mismo proveedor",
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            For i As Integer = 0 To dt_select.Rows.Count - 1
                sIdOrden = $"{sIdOrden}{dt_select.Rows.Item(i)("Orden")},"
                sNoOrden = $"{sNoOrden}{dt_select.Rows.Item(i)("No. Orden")},"
            Next

            sIdOrden = sIdOrden.Substring(0, sIdOrden.Length - 1)
            sNoOrden = sNoOrden.Substring(0, sNoOrden.Length - 1)

            If _DT.Select("Seleccionar = 1").Length > 1 Then
                MultiSelect = True
            Else
                MultiSelect = False
            End If

        Else
            If iVista.FocusedRowHandle < 0 Then
                XtraMsg("Seleccione una Orden de Compra")
                Exit Sub
            End If
            '
            Dim Estado As String =
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado")

            If Estado.Equals("Facturada") And
                    iVista.GetRowCellValue(iVista.FocusedRowHandle, "Entrega").ToString().Equals("Entregado") Then
                XtraMsg("La Orden de Compra ya fue Facturada")
                Exit Sub
            End If
            '
            If Estado.Equals("Anulada") Then
                XtraMsg("La Orden de Compra fue Anulada")
                Exit Sub
            End If
            '
            If Not iVista.GetRowCellValue(iVista.FocusedRowHandle, "Aprobar") Then
                XtraMsg("La Orden de Compra debe Aprobarse para Poder ser Facturada", MessageBoxIcon.Warning)
                Exit Sub
            End If

            sIdOrden = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Orden")
            sNoOrden = iVista.GetRowCellValue(iVista.FocusedRowHandle, "No. Orden")

            MultiSelect = False

            ShowSplash()
            Inicio = True
            '
            Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
            frm.Dispose()
            '
            Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
            f.OrdenCompra = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Orden")
            f.txtOrden.Text = iVista.GetRowCellValue(iVista.FocusedRowHandle, "No. Orden")
            f.etOrigen.Text = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Factura_Origen")
            f.IsLoadOC = True
            f.Destino = 1
            f.gbTipo.Enabled = False
            f.MdiParent = Me.MdiParent
            f.etTipo.Text = "A"
            f.Show()
            f.Text = "Nueva Orden de Pago"
            f.WindowState = FormWindowState.Maximized
            f.txtfactura.Focus()
            f.Nuevo = False
            '
            Inicio = False
            HideSplash()

            Exit Sub
        End If


        If MultiSelect Then
            With frmOrdenCompraToOP

                .Text = "Trasladar Orden de Compra => Orden de Pago"
                .NoOrden = sIdOrden
                .txtNoOrden.Text = sNoOrden
                .txtFactura.Text = sIdOrden
                .MultiSelect = MultiSelect
                .ShowDialog()

                'If .Ok Then
                '    ShowSplash()
                '    Cargar()
                '    HideSplash()
                'End If

                .Dispose()
            End With
        Else
            ShowSplash()
            Inicio = True
            '
            Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
            frm.Dispose()
            '
            Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
            f.OrdenCompra = _DT.Select("Seleccionar = 1").CopyToDataTable().Rows.Item(0)("Orden")
            f.txtOrden.Text = _DT.Select("Seleccionar = 1").CopyToDataTable().Rows.Item(0)("No. Orden")
            f.etOrigen.Text = _DT.Select("Seleccionar = 1").CopyToDataTable().Rows.Item(0)("Factura_Origen")
            f.IsLoadOC = True
            f.Destino = 1
            f.gbTipo.Enabled = False
            f.MdiParent = Me.MdiParent
            f.etTipo.Text = "A"
            f.Show()
            f.Text = "Nueva Orden de Pago"
            f.WindowState = FormWindowState.Maximized
            f.txtfactura.Focus()
            f.Nuevo = False
            '
            Inicio = False
            HideSplash()
        End If




        ''If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 1 Then
        ''    Dim f As frmFacturasCompra = f.Instance

        ''    f.OrdenCompra = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        ''    f.txtOrden.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "No. Orden")
        ''    f.etOrigen.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Factura_Origen")
        ''    f.Destino = 1

        ''    'f.rbProductos.Checked = True
        ''    'f.gbTipo.EditValue = 0

        ''    f.gbTipo.Enabled = False
        ''    f.MdiParent = Me.MdiParent
        ''    f.etTipo.Text = "P"
        ''    f.Show()
        ''    f.WindowState = FormWindowState.Maximized
        ''    f.txtfactura.Focus()
        ''    f.Nuevo = False
        ''    '
        ''ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 2 Then
        ''    'Dim f1 As DataGridTextBoxCombo.frmFacturasCompraCC = f1.Instance
        ''    Dim f1 As frmFacturasCompra = f1.Instance

        ''    f1.OrdenCompra = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        ''    f1.txtOrden.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "No. Orden")
        ''    f1.etOrigen.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Factura_Origen")
        ''    f1.Destino = 2

        ''    'f1.rbInventario.Checked = True
        ''    'f1.gbTipo.EditValue = 4

        ''    f1.gbTipo.Enabled = False
        ''    f1.MdiParent = Me.MdiParent
        ''    f1.etTipo.Text = "I"
        ''    f1.Show()
        ''    f1.WindowState = FormWindowState.Maximized
        ''    f1.txtfactura.Focus()
        ''    f1.Nuevo = False
        ''ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 3 Then
        ''    Dim f As frmFacturasCompra = f.Instance

        ''    f.OrdenCompra = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        ''    f.txtOrden.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "No. Orden")
        ''    f.etOrigen.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Factura_Origen")
        ''    f.Destino = 3

        ''    f.etOrigen.Text = 3
        ''    'f.rbProdInvet.Checked = True
        ''    'f.gbTipo.EditValue = 3

        ''    f.gbTipo.Enabled = False
        ''    f.MdiParent = Me.MdiParent
        ''    f.etTipo.Text = "A"
        ''    f.Show()
        ''    f.WindowState = FormWindowState.Maximized
        ''    f.txtfactura.Focus()
        ''    f.Nuevo = False
        ''End If

        ''Inicio = False
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        ShowSplash("Cargando O/C...")
        Inicio = True


        Dim frm As DataGridTextBoxCombo.frmOrdenesCompra =
            DataGridTextBoxCombo.frmOrdenesCompra.Instance()
        frm.Dispose()

        Dim f As DataGridTextBoxCombo.frmOrdenesCompra =
            DataGridTextBoxCombo.frmOrdenesCompra.Instance()

        f.CargarPedido = False
        f.Pedido = -1
        f.MdiParent = Me.MdiParent
        f.Text = "Crear Orden de Compra"
        f.Show()
        f.WindowState = FormWindowState.Maximized

        Inicio = False
        HideSplash()
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        '    Cargar()
        'End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        '    Cargar()
        'End If
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(iGrid, "Ordenes de Compra",
                                    "De " & Desde.DateTime.ToShortDateString & " Al " & Hasta.DateTime.ToShortDateString)

        'Help.ShowHelp(Me, "ayuda/ProvOrdenCompra.chm")
    End Sub

    Private Sub cmdEntradaAlmacen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEntradaAlmacen.Click
        'If dgOrdenes.CurrentRowIndex = ds.Tables("Ordenes_Compra").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
        '    MsgBox("La Orden de Compra ya fue facturada", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Inicio = True
        'Dim f As DataGridTextBoxCombo.frmFacturarCompra = f.Instance
        'f.txtOrden.Text = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 0)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'Inicio = False
    End Sub

    Private Sub cbOrigen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) And IsNumeric(cbOrigen.SelectedIndex) Then
        '    Cargar()
        'End If
    End Sub

    Private Sub cbDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) And IsNumeric(cbOrigen.SelectedIndex) Then
        '    Cargar()
        'End If
    End Sub

    Private Sub cmdImprimir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir1.Click
        If Me.iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If
        '
        'If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 0).ToString = "" Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        '
        'Ordenes.ImprimirOrden(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Orden"))

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try

            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 15 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\RptOrdenCompra.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
        End Try

        Dim Rep As rptOrdenCompra

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptOrdenCompra.repx", True)
        Else
            Rep = New rptOrdenCompra
        End If

        Rep.DataSource =
            ObtieneDatos("sp_OrdenCompraImpresa",
                         iVista.GetFocusedRowCellValue("Orden"),
                         EmpresaActual)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If

        ShowSplash("Cargando O/C...")
        Inicio = True

        Dim frm As DataGridTextBoxCombo.frmOrdenesCompra =
            DataGridTextBoxCombo.frmOrdenesCompra.Instance()
        frm.Dispose()


        Dim f As DataGridTextBoxCombo.frmOrdenesCompra =
            DataGridTextBoxCombo.frmOrdenesCompra.Instance()

        f.Modifica = True
        f.CargarPedido = False

        f.txtFactura.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        f.etDestino.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino")

        'f.NoOrden = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Orden") 'Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 0)
        'f.Destino = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Destino") 'Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11)
        'If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "1" Then

        'If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 1 Then
        '    'f.rbProductos.Checked = True
        '    f.TipoServicio.EditValue = "P"
        'ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 2 Then
        '    'ElseIf Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "2" Then
        '    'f.rbInventario.Checked = True
        '    f.TipoServicio.EditValue = "I"
        '    'ElseIf Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "I" Then
        '    'f.rbInventario.Checked = True
        'ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 3 Then
        '    f.TipoServicio.EditValue = "A"
        '    'f.rbProdInvet.Checked = True
        'End If

        'f.gbTipo.Enabled = False
        f.txtFactura.Enabled = False
        f.MdiParent = Me.MdiParent
        f.Text = "Editar Orden de Compra"
        f.Show()

        ' If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Anulada" Or Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
        If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Anulada" Or
        Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Facturada" Then

            f.cmdAceptar.Enabled = False
            f.cbProveedor.Enabled = False
            'f.iGrid.Enabled = False
            'f.dgFacturas.ReadOnly = True
            'f.cmdConsulta.Enabled = False
            'f.dtpFecha.Enabled = False
            'f.dtpFechaPago.Enabled = False
            'f.cbTipoFactura.Enabled = False
            'f.Articulo.ColumnComboBox.Visible = False '8566284 28 01 8:50 am
            'f.ArticuloCodigo.ColumnComboBox.Visible = False
        End If

        f.WindowState = FormWindowState.Maximized
        '
        Inicio = False
        HideSplash()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If

        'If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 0).ToString = "" Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Anulada" Then
            XtraMsg("La Orden de Compra ya fue Anulada", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Facturada" Then
            XtraMsg("La Orden de Compra ya fue Facturada", MessageBoxIcon.Warning)
            Exit Sub
        End If

        'If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Anulada" Then
        '    MsgBox("La Orden de Compra ya fue Anulada", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
        '    MsgBox("La Orden de Compra ya fue Facturada", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Not XtraMsg2("¿ Desea anular la Orden de Compra ?") Then
            Exit Sub
        End If

        'Ordenes.OrdenComprasAnular(Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 0), Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11))
        If Ordenes.OrdenComprasAnular(Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden"), Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino")) Then Cargar()


        'ds = Ordenes.OrdenesCompraXProveedor(0, Fecha, cbEstado.SelectedIndex, cbTipo.SelectedValue, Me.cbOrigen.SelectedIndex, cbDestino.SelectedIndex)
        'dgOrdenes.DataSource = ds.Tables("Ordenes_Compra").DefaultView
        'Me.iGrid.DataSource = ds.Tables("Ordenes_Compra").DefaultView
    End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanging
        'If AbrobarOrden = False Then  'Si la Empresa No requiere Codigo de Aprobación
        '    Exit Sub
        'End If

        'Dim Codigo As String
        'Try
        '    'Verificar Si existe el Codigo de Aprobación
        '    Codigo = ObtieneDatos("Select Codigo from CodigoFactura WHERE Tipo = 6").Rows.Item(0)("Codigo")
        'Catch ex As Exception
        '    MsgBox("No Existe Codigo de Aprobación", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End Try

        'If e.Column.FieldName = "Aprobar" Then
        '    If Me.iVista.GetRowCellValue(e.RowHandle, "Aprobar") = True Then
        '        Me.iVista.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '    Else
        '        Dim c As String = InputBox("Introduzca el Codigo de Aprobación de la Orden de Compra", "Aprobar Orden Compra")
        '        If c.Trim = Codigo Then
        '            Me.iVista.SetRowCellValue(e.RowHandle, "Aprobar", True)
        '            If GuardarArpbacion() Then MsgBox("El Pedido ha sido debidamente Aprobado", MsgBoxStyle.Information)
        '        Else
        '            MsgBox("Codigo Inválido", MsgBoxStyle.Exclamation)
        '            Me.iVista.SetRowCellValue(e.RowHandle, "Aprobar", False)
        '        End If
        '    End If
        '    Me.iVista.RefreshData()
        'End If
    End Sub

    'Function GuardarArpbacion() As Boolean
    '    Dim sSQL As String = String.Empty
    '    Dim Con As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)

    '    If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 1 Or Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 3 Then
    '        sSQL = "ALTER TABLE ORDENES_COMPRAS DISABLE TRIGGER ALL UPDATE Ordenes_Compras SET Aprobado = 1 WHERE Factura_ID = " & Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden") & " ALTER TABLE ORDENES_COMPRAS ENABLE TRIGGER ALL"
    '    Else
    '        sSQL = "ALTER TABLE ORDENES_COMPRAS DISABLE TRIGGER ALL UPDATE Ordenes_ComprasCC SET Aprobado = 1 WHERE Factura_ID = " & Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden") & " ALTER TABLE ORDENES_COMPRAS ENABLE TRIGGER ALL"
    '    End If

    '    Try
    '        Con.Open()
    '        Dim cmd As New SqlCommand(sSQL, Con)
    '        cmd.ExecuteNonQuery()

    '        Con.Close()
    '        Return True
    '    Catch ex As Exception
    '        Con.Close()
    '        MsgBox("ERROR al Actualizar Datos", MsgBoxStyle.Critical)
    '        Return False
    '    End Try
    'End Function

    Private Sub btnDiseno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiseno.Click
        With My.Forms.FrmConfiguraCheque
            .Tipo = 15
            .Text = "*** Diseñar Orden de Compra ***"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If

        If iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") <> "Anulada" Then
            XtraMsg("Se debe Anular primero la Orden de Compra!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2("¿ Seguro de Borrar la Orden de Compra por completo ?") Then
            Exit Sub
        End If

        If Ordenes.OrdenComprasBorrar(Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")) Then Cargar()

    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.ForeColor = Color.DarkRed
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Italic)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Pendiente" Then
                e.Appearance.BackColor = Color.GreenYellow
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Facturada" Then
                e.Appearance.BackColor = Color.DarkGreen
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulada" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.ForeColor = Color.Red
            End If
        End If
        '
        If e.Column.FieldName = "Entrega" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.Font = New Font("Tahoma", 8.75, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Pendiente" Then
                e.Appearance.ForeColor = Color.OrangeRed
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Entregado" Then
                e.Appearance.ForeColor = Color.DarkGreen
            ElseIf iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Parcial" Then
                e.Appearance.ForeColor = Color.Navy
            Else
                e.Appearance.ForeColor = Color.White
            End If
        End If

        If e.Column.FieldName = "Aprobar" Then
            If iVista.GetRowCellValue(e.RowHandle, "Aprobar") Then
                e.Appearance.BackColor = Color.DarkGreen
            Else
                e.Appearance.BackColor = Color.GreenYellow
            End If
        End If

        If e.Column.FieldName = "Liquidación" Then
            If iVista.GetRowCellValue(e.RowHandle, "Liquidación") Then e.Appearance.BackColor = Color.HotPink
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bAprobar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado") = "Anulada" Then
            XtraMsg("La Orden de Compra se encuentra Anulada!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ''
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Aprobar") Then
            XtraMsg("La Orden de Compra ya se encuentra Aprobada!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Aprobar la Orden de Compra No. " + iVista.GetRowCellValue(iVista.FocusedRowHandle, "No. Orden") + " ?") Then
            Exit Sub
        End If

        If Guardar("sp_ORDENES_COMPRAS_Aprobar", iVista.GetRowCellValue(iVista.FocusedRowHandle, "Orden"), EmpresaActual) Then
            Cargar()
        End If
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmDocumentos
            .Tipo = "ORDENES_COMPRA"
            .Codigo = iVista.GetFocusedRowCellValue("No. Orden")
            .NDocumento = iVista.GetFocusedRowCellValue("No. Orden")
            .Text = "Soporte Digital Para O/C del Proveedor: " & iVista.GetFocusedRowCellValue("Proveedor")
            .txtNombre.Text = "Proveedor: " & iVista.GetFocusedRowCellValue("Proveedor")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bAprobarLiq_Click(sender As Object, e As EventArgs) Handles bAprobarLiq.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Orden de Compra")
            Exit Sub
        End If
        '
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado") = "Anulada" Then
            XtraMsg("La Orden de Compra se encuentra Anulada!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ''
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Aprobar") Then
            XtraMsg("La Orden de Compra ya se encuentra Aprobada!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not iVista.GetRowCellValue(iVista.FocusedRowHandle, "Liquidación") Then
            XtraMsg("La Orden de Compra No esta asociada a una Liquidación.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("Esta Seguro de Aprobar la Orden de Compra No. " + iVista.GetRowCellValue(iVista.FocusedRowHandle, "No. Orden") + " ?") Then
            Exit Sub
        End If

        If Guardar("sp_ORDENES_COMPRAS_Aprobar", iVista.GetRowCellValue(iVista.FocusedRowHandle, "Orden"), EmpresaActual) Then
            Cargar()
        End If
    End Sub

    Private Sub bReporteDinamico_Click(sender As Object, e As EventArgs) Handles bReporteDinamico.Click
        ShowSplash()
        frmDinamicoOrdenesCompra.Dispose()
        frmDinamicoOrdenesCompra.MdiParent = Me.MdiParent
        frmDinamicoOrdenesCompra.Text = "Reporte Dinámico Ordenes de Compra"
        frmDinamicoOrdenesCompra.Show()
        frmDinamicoOrdenesCompra.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bMercaderia_Click(sender As Object, e As EventArgs) Handles bMercaderia.Click
        ShowSplash()
        frmReporteAuxiliarMercaderiaTransito.Dispose()
        frmReporteAuxiliarMercaderiaTransito.MdiParent = Me.MdiParent
        frmReporteAuxiliarMercaderiaTransito.Text = "Reporte Mercaderia en Transito"
        frmReporteAuxiliarMercaderiaTransito.Show()
        frmReporteAuxiliarMercaderiaTransito.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        iVista.Columns("Seleccionar").Visible = CheckEdit1.Checked
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
        Dim Estado As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Estado")

        If Estado.Equals("Facturada") Or Estado.Equals("Anulada") Then
            e.Cancel = True
        End If
        '
        If Not CBool(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Aprobar")) Then
            e.Cancel = True
        End If
    End Sub
End Class
