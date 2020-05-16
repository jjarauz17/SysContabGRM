Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Configuration
Imports DevExpress.XtraReports.UI

Public Class frmListaCotizaciones
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaCotizaciones = Nothing

    Public Shared Function Instance() As frmListaCotizaciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaCotizaciones
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
    Friend WithEvents cmdFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents iAni As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCheckEstado As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bExportarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bFormato2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCotizaciones))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bFormato2 = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid2 = New DevExpress.XtraGrid.GridControl()
        Me.iVista2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bExportarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.cbCheckEstado = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.iAni = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.bAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bVer = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCheckEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iAni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Sub Total"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Sub Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sub Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 70
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "IVA"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "IVA"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 50
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Total"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Total"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 47
        '
        'bDiseno
        '
        Me.bDiseno.Appearance.Options.UseTextOptions = True
        Me.bDiseno.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(480, 480)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(98, 38)
        Me.bDiseno.StyleController = Me.LayoutControl1
        Me.bDiseno.TabIndex = 8
        Me.bDiseno.Text = "&Diseño de Impresión"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bFormato2)
        Me.LayoutControl1.Controls.Add(Me.iGrid2)
        Me.LayoutControl1.Controls.Add(Me.bExportarDetalle)
        Me.LayoutControl1.Controls.Add(Me.cbCheckEstado)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.bDiseno)
        Me.LayoutControl1.Controls.Add(Me.cmdFacturar)
        Me.LayoutControl1.Controls.Add(Me.bAyuda)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.bBorrar)
        Me.LayoutControl1.Controls.Add(Me.bImprimir)
        Me.LayoutControl1.Controls.Add(Me.bVer)
        Me.LayoutControl1.Controls.Add(Me.bNuevo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem15, Me.LayoutControlItem10})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(892, 218, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(1008, 530)
        Me.LayoutControl1.TabIndex = 168
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bFormato2
        '
        Me.bFormato2.Appearance.Options.UseTextOptions = True
        Me.bFormato2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bFormato2.Enabled = False
        Me.bFormato2.ImageOptions.Image = CType(resources.GetObject("bFormato2.ImageOptions.Image"), System.Drawing.Image)
        Me.bFormato2.Location = New System.Drawing.Point(286, 480)
        Me.bFormato2.Name = "bFormato2"
        Me.bFormato2.Size = New System.Drawing.Size(102, 38)
        Me.bFormato2.StyleController = Me.LayoutControl1
        Me.bFormato2.TabIndex = 169
        Me.bFormato2.Text = "Imprimir &Formato 2"
        '
        'iGrid2
        '
        Me.iGrid2.Location = New System.Drawing.Point(12, 295)
        Me.iGrid2.MainView = Me.iVista2
        Me.iGrid2.Name = "iGrid2"
        Me.iGrid2.Size = New System.Drawing.Size(984, 181)
        Me.iGrid2.TabIndex = 187
        Me.iGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista2})
        '
        'iVista2
        '
        Me.iVista2.GridControl = Me.iGrid2
        Me.iVista2.Name = "iVista2"
        Me.iVista2.OptionsView.ShowGroupPanel = False
        '
        'bExportarDetalle
        '
        Me.bExportarDetalle.Appearance.Options.UseTextOptions = True
        Me.bExportarDetalle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bExportarDetalle.Enabled = False
        Me.bExportarDetalle.ImageOptions.Image = CType(resources.GetObject("bExportarDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportarDetalle.Location = New System.Drawing.Point(699, 480)
        Me.bExportarDetalle.Name = "bExportarDetalle"
        Me.bExportarDetalle.Size = New System.Drawing.Size(95, 38)
        Me.bExportarDetalle.StyleController = Me.LayoutControl1
        Me.bExportarDetalle.TabIndex = 170
        Me.bExportarDetalle.Text = "E&xportar Detalle"
        '
        'cbCheckEstado
        '
        Me.cbCheckEstado.Location = New System.Drawing.Point(561, 36)
        Me.cbCheckEstado.Name = "cbCheckEstado"
        Me.cbCheckEstado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCheckEstado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbCheckEstado.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cbCheckEstado.Properties.Appearance.Options.UseBackColor = True
        Me.cbCheckEstado.Properties.Appearance.Options.UseFont = True
        Me.cbCheckEstado.Properties.Appearance.Options.UseForeColor = True
        Me.cbCheckEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCheckEstado.Size = New System.Drawing.Size(435, 20)
        Me.cbCheckEstado.StyleController = Me.LayoutControl1
        Me.cbCheckEstado.TabIndex = 186
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(879, 62)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Selector de Datos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(117, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 185
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 86)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.iAni, Me.RepositoryItemLookUpEdit1})
        Me.iGrid.Size = New System.Drawing.Size(984, 205)
        Me.iGrid.TabIndex = 169
        Me.iGrid.UseEmbeddedNavigator = True
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista, Me.GridView2})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn14, Me.GridColumn5, Me.GridColumn7, Me.GridColumn33, Me.GridColumn8, Me.GridColumn30, Me.GridColumn9, Me.GridColumn31, Me.GridColumn4, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn20, Me.GridColumn19, Me.GridColumn21})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.GridColumn5
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "Pendiente"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.GridColumn5
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Pendiente"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.GridColumn7
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "Pendiente"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.Column = Me.GridColumn8
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "Anulado"
        Me.iVista.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Info"
        Me.GridColumn6.ColumnEdit = Me.iAni
        Me.GridColumn6.FieldName = "Info"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 34
        '
        'iAni
        '
        Me.iAni.Name = "iAni"
        Me.iAni.NullText = " "
        Me.iAni.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.iAni.ZoomAccelerationFactor = 1.0R
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Número"
        Me.GridColumn1.FieldName = "No Cotización"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 66
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 66
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "Cliente"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 95
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Monto"
        Me.GridColumn14.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "Monto"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.GridColumn14.Width = 55
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Descuento"
        Me.GridColumn33.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn33.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn33.FieldName = "Descuento"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:n2}")})
        Me.GridColumn33.Width = 65
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Linea"
        Me.GridColumn30.FieldName = "Linea"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 3
        Me.GridColumn30.Width = 66
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Asesor"
        Me.GridColumn9.FieldName = "Asesor"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 59
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Estado"
        Me.GridColumn31.FieldName = "Estado"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 11
        Me.GridColumn31.Width = 51
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Facturación"
        Me.GridColumn4.FieldName = "Facturación"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 12
        Me.GridColumn4.Width = 57
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "#Factura"
        Me.GridColumn10.FieldName = "#Factura"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 51
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Cliente_ID"
        Me.GridColumn11.FieldName = "Cliente_ID"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Usuario"
        Me.GridColumn12.FieldName = "Usuario"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 15
        Me.GridColumn12.Width = 73
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Pendiente"
        Me.GridColumn13.FieldName = "Pendiente"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Moneda"
        Me.GridColumn15.FieldName = "Moneda"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 7
        Me.GridColumn15.Width = 58
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Tasa"
        Me.GridColumn16.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "Tasa"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Tipo"
        Me.GridColumn17.FieldName = "Tipo"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.AllowFocus = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        Me.GridColumn17.Width = 54
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Usr_Id"
        Me.GridColumn18.FieldName = "Usr_Id"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.AllowFocus = False
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Tasa"
        Me.GridColumn20.FieldName = "TCambio"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 13
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "NoOrden"
        Me.GridColumn19.FieldName = "NoOrden"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Remision"
        Me.GridColumn21.FieldName = "Remision"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 14
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "[Moneda]"
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.iGrid
        Me.GridView2.Name = "GridView2"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(115, 62)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(760, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 173
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(260, 36)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 172
        Me.SimpleButton1.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(115, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(141, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 171
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(115, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Size = New System.Drawing.Size(141, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 170
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(798, 480)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(98, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 169
        Me.bExportar.Text = "Ex&portar"
        '
        'cmdFacturar
        '
        Me.cmdFacturar.Location = New System.Drawing.Point(56, 226)
        Me.cmdFacturar.Name = "cmdFacturar"
        Me.cmdFacturar.Size = New System.Drawing.Size(81, 22)
        Me.cmdFacturar.StyleController = Me.LayoutControl1
        Me.cmdFacturar.TabIndex = 7
        Me.cmdFacturar.Text = "&Facturar"
        Me.cmdFacturar.Visible = False
        '
        'bAyuda
        '
        Me.bAyuda.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.bAyuda.Location = New System.Drawing.Point(679, 226)
        Me.bAyuda.Name = "bAyuda"
        Me.bAyuda.Size = New System.Drawing.Size(84, 38)
        Me.bAyuda.StyleController = Me.LayoutControl1
        Me.bAyuda.TabIndex = 8
        Me.bAyuda.Text = "A&yuda"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(900, 480)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(96, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 12
        Me.bSalir.Text = "&Salir"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(25, 226)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(112, 38)
        Me.etInicio.TabIndex = 165
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'bBorrar
        '
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(392, 480)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(84, 38)
        Me.bBorrar.StyleController = Me.LayoutControl1
        Me.bBorrar.TabIndex = 5
        Me.bBorrar.Text = "&Anular"
        '
        'bImprimir
        '
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(185, 480)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(97, 38)
        Me.bImprimir.StyleController = Me.LayoutControl1
        Me.bImprimir.TabIndex = 4
        Me.bImprimir.Text = "&Imprimir"
        '
        'bVer
        '
        Me.bVer.Enabled = False
        Me.bVer.ImageOptions.Image = CType(resources.GetObject("bVer.ImageOptions.Image"), System.Drawing.Image)
        Me.bVer.Location = New System.Drawing.Point(100, 480)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(81, 38)
        Me.bVer.StyleController = Me.LayoutControl1
        Me.bVer.TabIndex = 2
        Me.bVer.Text = "&Editar"
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.Image = CType(resources.GetObject("bNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(12, 480)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(84, 38)
        Me.bNuevo.StyleController = Me.LayoutControl1
        Me.bNuevo.TabIndex = 1
        Me.bNuevo.Text = "&Nuevo"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdFacturar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(44, 214)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.etInicio
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(13, 214)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        Me.LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bAyuda
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(667, 214)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem16, Me.LayoutControlItem19, Me.LayoutControlItem20})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1008, 530)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bSalir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(888, 468)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.bNuevo
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 468)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bVer
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(88, 468)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bImprimir
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(173, 468)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bBorrar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(380, 468)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(88, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.bDiseno
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(468, 468)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bExportar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(786, 468)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(570, 468)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(117, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Desde
        Me.LayoutControlItem4.CustomizationFormText = "Desde:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Desde:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Hasta
        Me.LayoutControlItem5.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Hasta:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(248, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(99, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(248, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(740, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(347, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(99, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbMoneda
        Me.LayoutControlItem7.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(867, 24)
        Me.LayoutControlItem7.Text = "Moneda:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.iGrid
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(988, 209)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckEdit1
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(867, 50)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(121, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(121, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(121, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbCheckEstado
        Me.LayoutControlItem18.CustomizationFormText = "Estado Cotizaciones:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(446, 24)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(542, 26)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(542, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(542, 26)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "Estado Cotizaciones:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bExportarDetalle
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(687, 468)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.iGrid2
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 283)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(988, 185)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        Me.LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.bFormato2
        Me.LayoutControlItem20.Location = New System.Drawing.Point(274, 468)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'frmListaCotizaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 530)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmListaCotizaciones"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCheckEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iAni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Cotizaciones As New VB.SysContab.CotizacionesDB
    Dim r As New VB.SysContab.Rutinas

    Dim Estado As String = "T"
    Dim DT_ROL As DataTable

    Private Sub frmListaCotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Try
        ''r.FormularioColor(Me)
        'Dim Tabla As DataTable
        'Dim ds As DataSet
        ''If rbPendientes.Checked = True Then
        ''    Estado = "P"
        ''ElseIf rbFacturadas.Checked = True Then
        ''    Estado = "F"
        ''Else
        ''    Estado = "T"
        ''End If
        ''r.CambiarEstilo(Me)

        'ds = Cotizaciones.CotizacionesBuscar("", Estado)

        'dgCotizaciones.DataSource = ds.Tables("Cotizaciones").DefaultView
        'Tabla = ds.Tables("Cotizaciones")

        'r.FormatGenerico(dgCotizaciones, Tabla)

        'If ds.Tables("Cotizaciones").Rows.Count <> 0 Then
        '    RegistroCotizacion = dgCotizaciones.Item(0, 0).ToString
        'Else
        '    RegistroCotizacion = "Vacio"
        'End If

        'dgCotizaciones.CaptionText = "Información de Cotizaciones"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        'Me.Text = "Lista de Cotizaciones"
        'Me.Refresh()

        'bDiseno.Enabled = True
        'If Not Directory.Exists(Application.StartupPath & "\rptDesign") Then
        '    Directory.CreateDirectory(Application.StartupPath & "\rptDesign")
        'End If
        'Catch ex As Exception
        '    ' XtraMsg(ex.Message, MessageBoxIcon.Error)
        'End Try


        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        GetMonedasList(cbMoneda)

        Dim Obj As New ProformaEstadoCLS
        '  Obj.FillCombo(cbEstados, 1)
        Obj.FillCombo(cbCheckEstado)
        ' cbEstados.ItemIndex = 1
        '
        Cargar()
        FormatiGrid()

        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl1)
    End Sub

    Sub FormatiGrid()
        ' iVista.PopulateColumns()
        FormatoGrid(iVista)
        ''
        ' Me.iVista.Columns("Cliente_ID").Visible = False

        'Me.iVista.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.iVista.Columns("Sub Total").DisplayFormat.FormatString = "{0:n2}"
        'Me.iVista.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.iVista.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"
        ' ''
        'Me.iVista.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.iVista.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        'Me.iVista.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.iVista.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"
        ' ''
        'Me.iVista.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.iVista.Columns("Descuento").DisplayFormat.FormatString = "{0:n2}"
        'Me.iVista.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.iVista.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"
        ' ''
        'Me.iVista.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.iVista.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
        'Me.iVista.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.iVista.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Cliente").Width = 200

        If iVista.DataRowCount <> 0 Then
            RegistroCotizacion = iVista.GetRowCellValue(0, "No Cotización")
        Else
            RegistroCotizacion = "Vacio"
        End If
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = ObtieneDatos("_CotizacionesBuscar", "%", cbCheckEstado.EditValue, EmpresaActual, 1, Desde.DateTime.Date, Hasta.DateTime.Date, cbMoneda.EditValue)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdFacturar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFacturar.Click
        ''If Cotizaciones.CotizacionesBuscarXCodigo(RegistroCotizacion).Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "F" Then
        ''    MsgBox("La cotización ya fue facturada", MsgBoxStyle.Information)
        ''    Exit Sub
        ''End If
        'Dim Cajas As New VB.SysContab.CajasDB
        'Dim dsCajas As DataSet
        'dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        'If dsCajas.Tables("Cajas").Rows.Count = 0 Then
        '    MsgBox("La Computadora " & Environment.MachineName.ToString & " no está configurada como Caja", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If dgCotizaciones.Item(dgCotizaciones.CurrentRowIndex, 0).ToString = "" Then
        '    MsgBox("Seleccione la Cotización", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If dgCotizaciones.Item(dgCotizaciones.CurrentRowIndex, 7) = "Facturada" Then
        '    MsgBox("La cotización ya fue facturada", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'FacturarCotizacion = True
        'RegistroCotizacion = dgCotizaciones.Item(dgCotizaciones.CurrentRowIndex, 0)

        ''Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

        'NuevaFactura = "NO"

        'If RegistroCotizacion = "Vacio" Then
        '    MsgBox("Seleccione la Cotización", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        ''f.MdiParent = Me.MdiParent
        ''f.Show()



    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        dgCotizaciones.DataSource = Cotizaciones.CotizacionesBuscar(txtBuscar.Text, Estado).Tables("Cotizaciones").DefaultView

    '        If Cotizaciones.CotizacionesBuscar(txtBuscar.Text, Estado).Tables("Cotizaciones").Rows.Count = 0 Then
    '            Exit Sub

    '        End If

    '        RegistroCotizacion = dgCotizaciones.Item(dgCotizaciones.CurrentRowIndex, 0)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub rbTodas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Estado = "T"
    '    dgCotizaciones.DataSource = Cotizaciones.CotizacionesBuscar("", Estado).Tables("Cotizaciones").DefaultView
    'End Sub

    'Private Sub rbFacturadas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Estado = "F"
    '    dgCotizaciones.DataSource = Cotizaciones.CotizacionesBuscar("", Estado).Tables("Cotizaciones").DefaultView
    'End Sub

    'Private Sub rbPendientes_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Estado = "P"
    '    dgCotizaciones.DataSource = Cotizaciones.CotizacionesBuscar("", Estado).Tables("Cotizaciones").DefaultView
    'End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub frmListaCotizaciones_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    If FormOrigen = 1 Then
    '        Dim f As New frmPrincipalCaja
    '        f.MostrarBotones()
    '    Else
    '    End If
    'End Sub

    Private Sub cmddiseño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDiseno.Click
        With FrmConfiguraCheque
            .Tipo = 4
            .Text = "Diseño de Cotización"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        ShowSplash("Cargando Cotización...")
        Dim f As FrmCotizacionNew = FrmCotizacionNew.Instance()
        f.Dispose()

        Dim frm As FrmCotizacionNew = FrmCotizacionNew.Instance()

        frm.MdiParent = Me.MdiParent
        frm.Factura = 0
        frm.Show()
        frm.Text = "Nueva Cotización"
        frm.DT_ROL = DT_ROL
        frm.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVer.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione la Cotización")
            Exit Sub
        End If

        Inicio = True

        ShowSplash("Cargando Cotización...")
        Dim f As FrmCotizacionNew = FrmCotizacionNew.Instance()
        f.Dispose()
        '
        Dim frm As FrmCotizacionNew = FrmCotizacionNew.Instance()

        frm.MdiParent = Me.MdiParent
        frm.Factura = iVista.GetFocusedRowCellValue("No Cotización")
        frm.Show()
        frm.Text = "Editar Cotización"
        frm.DT_ROL = DT_ROL
        frm.WindowState = FormWindowState.Maximized
        HideSplash()

        Inicio = False

        'Dim F As DataGridTextBoxCombo.frmCotizacionVer = DataGridTextBoxCombo.frmCotizacionVer.Instance()
        'RegistroCotizacion = vDatos.GetFocusedRowCellValue("No Cotización")
        'F.MdiParent = Me.MdiParent
        'F.Show()
        'F.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione la Cotización")
            Exit Sub
        End If

        Dim Temp As Boolean = False

        Try
            Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 4 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\RptCotizacion.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            ' Cadena = Application.StartupPath & "\rptDesign\RptCotizacion.repx"
            ' If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Temp = True
        Catch ex As Exception
            Temp = False
        End Try
        '
        Dim Rep As rptProformaNew

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCotizacion.repx", True)
        Else
            Rep = New rptProformaNew
        End If

        Rep.DataSource = ObtieneDatos("SPGetRptCotizacion", EmpresaActual, iVista.GetFocusedRowCellValue("No Cotización"))

        Dim DT_FIRMA As DataTable = ObtieneDatos("sp_sel_UsuariosFirmas", EmpresaActual,
                                                                           iVista.GetFocusedRowCellValue("Usr_Id"))
        If DT_FIRMA.Rows.Count > 0 Then
            'Mostrar Firma Digital
            If DT_FIRMA.Rows.Item(0)("Firma") IsNot DBNull.Value Then
                Dim img As Image = Bytes2Image(CType(DT_FIRMA.Rows.Item(0)("Firma"), Byte()))
                If img IsNot Nothing Then
                    Rep.pictureBox1.Image = img
                End If
            End If
        End If

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Sub ImprimirHND(Temp As Boolean)
        Dim Rep As rptFormatoFactura

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCotizacion.repx", True)
        Else
            Rep = New rptFormatoFactura
        End If

        Rep.DataSource = ObtieneDatos("SPGetRptCotizacion", EmpresaActual, iVista.GetFocusedRowCellValue("No Cotización"))

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub



    Private Sub bBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione la Cotización")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular la Cotización #: " & iVista.GetFocusedRowCellValue("No Cotización").ToString & " ?") Then
            Exit Sub
        End If
        '
        Dim Conexion As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)

        Try
            Conexion.RemoveParameters()
            Conexion.AddParameter("Numero", SqlDbType.Int, 4, ParameterDirection.Input, iVista.GetFocusedRowCellValue("No Cotización"))
            Conexion.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conexion.EjecutarComando("JAR_AnularCotizacion")

            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAyuda.Click
        Help.ShowHelp(Me, "ayuda/ClientesCotizaciones.chm")
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        iVista.Columns("Info").Visible = False
        frmExportarImprimir.Mostrar(iGrid)
        iVista.Columns("Info").Visible = True
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'If e.Column.FieldName = "Estado" Then

        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando Cotizaciones")
        Cargar()
        HideSplash()
    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        If etInicio.Text = "1" Then Exit Sub
        Try
            ShowSplash("Cargando Cotizaciones")
            Cargar()
            HideSplash()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub iVista_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles iVista.CustomUnboundColumnData
        If e.IsGetData Then
            Dim dr As DataRow = iVista.GetDataRow(e.ListSourceRowIndex)
            If dr Is Nothing Then
                Return
            End If
            Try
                If dr("Pendiente") AndAlso e.Column.FieldName = "Info" Then
                    Dim img As Image = My.Resources.high

                    'DevExpress.Utils.Controls.ImageHelper.CreateImageFromResources("RecetasTerraza.high.gif", GetType(FrmPedidosList).Assembly)
                    e.Value = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, ImageFormat.Gif)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub cbCheckEstado_EditValueChanged(sender As Object, e As EventArgs) Handles cbCheckEstado.EditValueChanged
        If etInicio.Text = "1" Then Exit Sub
        Try
            ShowSplash("Cargando Cotizaciones")
            Cargar()
            HideSplash()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bExportarDetalle.Click
        ShowSplash("Exportando Reporte...")
        '
        Dim DT As DataTable = VB.SysContab.ClientesDB.DinamicoCotizaciones(Desde.DateTime.Date, Hasta.DateTime.Date, cbMoneda.EditValue)
        iGrid2.DataSource = DT
        iVista2.PopulateColumns()
        FormatoGrid(iVista2)
        '
        HideSplash()

        Dim SaveDlg As SaveFileDialog = New SaveFileDialog()
        SaveDlg.Filter = "Archivos de EXCEL|*.xlsx"
        Dim filter As String = SaveDlg.Filter
        SaveDlg.Title = "Guardar Detalle de Cotizaciones"

        If (SaveDlg.ShowDialog() = DialogResult.OK) Then
            iGrid2.ExportToXlsx(SaveDlg.FileName)

            If XtraMsg2("Desea Abrir el Archivo?") Then
                Process.Start(SaveDlg.FileName)
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles bFormato2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione la Cotización")
            Exit Sub
        End If

        'If MsgBox("¿Desea imprimir la Factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        'Contab 

        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 4 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\RptCotizacion.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            ' Cadena = Application.StartupPath & "\rptDesign\RptCotizacion.repx"
            ' If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Temp = True
        Catch ex As Exception
            Temp = False
        End Try
        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())

        ' Dim Rep As RptCotizacionNew
        Dim Rep As rptProformaNew

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCotizacion.repx", True)
        Else
            Rep = New rptProformaNew
        End If

        Rep.DataSource = ObtieneDatos("SPGetRptCotizacion", EmpresaActual, iVista.GetFocusedRowCellValue("No Cotización"), 2)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub
End Class
