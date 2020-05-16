Imports System.Data.SqlClient
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmNotasCreditoDebitoNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmNotasCreditoDebitoNew = Nothing

    Public Shared Function Instance() As FrmNotasCreditoDebitoNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmNotasCreditoDebitoNew
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

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
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVistaCuentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtEquivalente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcomentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chktipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemCuenta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemCuentas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbtipocomprobante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents iVistaSaldos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCobro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtnota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbServicios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkGarantia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMnto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyMontoL As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyGarantiaChk As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Vencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbGarantias As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lyGarantia As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents cbTipoNota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyMonto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etMntto As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lyMnto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyEmpty As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lySpliter As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTasaParalela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkcontabiliza As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasCreditoDebitoNew))
        Me.vCobro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTasaParalela = New DevExpress.XtraEditors.TextEdit()
        Me.etMntto = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipoNota = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbGarantias = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Vencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.iVistaCuentas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbServicios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuenta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.chkcontabiliza = New System.Windows.Forms.CheckBox()
        Me.chkGarantia = New DevExpress.XtraEditors.CheckEdit()
        Me.chktipo = New DevExpress.XtraEditors.RadioGroup()
        Me.GridFacturas = New DevExpress.XtraGrid.GridControl()
        Me.iVistaSaldos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMnto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtnota = New DevExpress.XtraEditors.TextEdit()
        Me.cmbtipocomprobante = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtEquivalente = New DevExpress.XtraEditors.TextEdit()
        Me.txtcomentario = New DevExpress.XtraEditors.MemoEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGarantiaChk = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMonto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMontoL = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGarantia = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMnto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyEmpty = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lySpliter = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTasaParalela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGarantias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chktipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMnto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtipocomprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquivalente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGarantiaChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMontoL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMnto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lySpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'vCobro
        '
        Me.vCobro.AppearanceCell.Options.UseTextOptions = True
        Me.vCobro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vCobro.AppearanceHeader.Options.UseTextOptions = True
        Me.vCobro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vCobro.Caption = "Cobro"
        Me.vCobro.DisplayFormat.FormatString = "{0:n2}"
        Me.vCobro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vCobro.FieldName = "Cobro"
        Me.vCobro.Name = "vCobro"
        Me.vCobro.OptionsColumn.AllowEdit = False
        Me.vCobro.OptionsColumn.AllowFocus = False
        Me.vCobro.OptionsColumn.ReadOnly = True
        Me.vCobro.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cobro", "{0:n2}")})
        Me.vCobro.Visible = True
        Me.vCobro.VisibleIndex = 8
        Me.vCobro.Width = 44
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTasaParalela)
        Me.LayoutControl1.Controls.Add(Me.etMntto)
        Me.LayoutControl1.Controls.Add(Me.txtTotal)
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.cbTipoNota)
        Me.LayoutControl1.Controls.Add(Me.cbGarantias)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.Vencimiento)
        Me.LayoutControl1.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.chkcontabiliza)
        Me.LayoutControl1.Controls.Add(Me.chkGarantia)
        Me.LayoutControl1.Controls.Add(Me.chktipo)
        Me.LayoutControl1.Controls.Add(Me.GridFacturas)
        Me.LayoutControl1.Controls.Add(Me.txtnota)
        Me.LayoutControl1.Controls.Add(Me.cmbtipocomprobante)
        Me.LayoutControl1.Controls.Add(Me.txtEquivalente)
        Me.LayoutControl1.Controls.Add(Me.txtcomentario)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(876, 175, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1044, 697)
        Me.LayoutControl1.TabIndex = 16
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTasaParalela
        '
        Me.txtTasaParalela.EditValue = "1.0000"
        Me.txtTasaParalela.Location = New System.Drawing.Point(480, 189)
        Me.txtTasaParalela.Name = "txtTasaParalela"
        Me.txtTasaParalela.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasaParalela.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaParalela.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtTasaParalela.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasaParalela.Properties.Appearance.Options.UseFont = True
        Me.txtTasaParalela.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasaParalela.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTasaParalela.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTasaParalela.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaParalela.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Brown
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasaParalela.Properties.Mask.EditMask = "n4"
        Me.txtTasaParalela.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasaParalela.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasaParalela.Properties.NullText = "<Null>"
        Me.txtTasaParalela.Properties.ReadOnly = True
        Me.txtTasaParalela.Size = New System.Drawing.Size(91, 22)
        Me.txtTasaParalela.StyleController = Me.LayoutControl1
        Me.txtTasaParalela.TabIndex = 22
        '
        'etMntto
        '
        Me.etMntto.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMntto.Appearance.Options.UseFont = True
        Me.etMntto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.etMntto.Location = New System.Drawing.Point(977, 667)
        Me.etMntto.Name = "etMntto"
        Me.etMntto.Size = New System.Drawing.Size(55, 18)
        Me.etMntto.StyleController = Me.LayoutControl1
        Me.etMntto.TabIndex = 21
        Me.etMntto.Text = "0.0000"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotal.Location = New System.Drawing.Point(174, 163)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.Mask.EditMask = "n2"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.NullText = "<Null>"
        Me.txtTotal.Size = New System.Drawing.Size(225, 22)
        Me.txtTotal.StyleController = Me.LayoutControl1
        Me.txtTotal.TabIndex = 18
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = "1.0000"
        Me.txtTasa.Location = New System.Drawing.Point(471, 163)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTasa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Brown
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.Properties.NullText = "<Null>"
        Me.txtTasa.Properties.ReadOnly = True
        Me.txtTasa.Size = New System.Drawing.Size(100, 22)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 18
        '
        'cbTipoNota
        '
        Me.cbTipoNota.Location = New System.Drawing.Point(174, 91)
        Me.cbTipoNota.Name = "cbTipoNota"
        Me.cbTipoNota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoNota.Properties.NullText = ""
        Me.cbTipoNota.Properties.ShowFooter = False
        Me.cbTipoNota.Properties.ShowHeader = False
        Me.cbTipoNota.Size = New System.Drawing.Size(225, 20)
        Me.cbTipoNota.StyleController = Me.LayoutControl1
        Me.cbTipoNota.TabIndex = 18
        '
        'cbGarantias
        '
        Me.cbGarantias.Location = New System.Drawing.Point(742, 41)
        Me.cbGarantias.Name = "cbGarantias"
        Me.cbGarantias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGarantias.Properties.Appearance.Options.UseFont = True
        Me.cbGarantias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGarantias.Properties.View = Me.GridView3
        Me.cbGarantias.Size = New System.Drawing.Size(290, 20)
        Me.cbGarantias.StyleController = Me.LayoutControl1
        Me.cbGarantias.TabIndex = 19
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(174, 67)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.Appearance.Options.UseFont = True
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.View = Me.SearchLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(397, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 18
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Vencimiento
        '
        Me.Vencimiento.EditValue = Nothing
        Me.Vencimiento.Location = New System.Drawing.Point(469, 115)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Vencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Vencimiento.Size = New System.Drawing.Size(102, 20)
        Me.Vencimiento.StyleController = Me.LayoutControl1
        Me.Vencimiento.TabIndex = 17
        '
        'cmbmoneda
        '
        Me.cmbmoneda.EnterMoveNextControl = True
        Me.cmbmoneda.Location = New System.Drawing.Point(174, 139)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(397, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl1
        Me.cmbmoneda.TabIndex = 15
        Me.cmbmoneda.TabStop = False
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 299)
        Me.GridDetalle.MainView = Me.iVistaCuentas
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemCuenta, Me.ItemCuentas, Me.cbServicios, Me.rMonto, Me.cbCatalogo})
        Me.GridDetalle.Size = New System.Drawing.Size(559, 386)
        Me.GridDetalle.TabIndex = 6
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVistaCuentas})
        '
        'iVistaCuentas
        '
        Me.iVistaCuentas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVistaCuentas.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVistaCuentas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVistaCuentas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVistaCuentas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVistaCuentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn10, Me.GridColumn7, Me.GridColumn18})
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        Me.iVistaCuentas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.iVistaCuentas.GridControl = Me.GridDetalle
        Me.iVistaCuentas.Name = "iVistaCuentas"
        Me.iVistaCuentas.OptionsCustomization.AllowColumnMoving = False
        Me.iVistaCuentas.OptionsCustomization.AllowFilter = False
        Me.iVistaCuentas.OptionsCustomization.AllowGroup = False
        Me.iVistaCuentas.OptionsCustomization.AllowSort = False
        Me.iVistaCuentas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVistaCuentas.OptionsView.ShowFooter = True
        Me.iVistaCuentas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.ColumnEdit = Me.cbCatalogo
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 130
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Monto"
        Me.GridColumn3.ColumnEdit = Me.rMonto
        Me.GridColumn3.FieldName = "Monto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 116
        '
        'rMonto
        '
        Me.rMonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonto.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rMonto.Appearance.Options.UseBackColor = True
        Me.rMonto.Appearance.Options.UseFont = True
        Me.rMonto.Appearance.Options.UseForeColor = True
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n2"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Mask.UseMaskAsDisplayFormat = True
        Me.rMonto.Name = "rMonto"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Tipo Retensión"
        Me.GridColumn10.ColumnEdit = Me.cbServicios
        Me.GridColumn10.FieldName = "ret"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 97
        '
        'cbServicios
        '
        Me.cbServicios.AutoHeight = False
        Me.cbServicios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.NullText = ""
        Me.cbServicios.ShowFooter = False
        Me.cbServicios.ShowHeader = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Descripcion"
        Me.GridColumn7.FieldName = "Descripcion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 188
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Factura"
        Me.GridColumn18.FieldName = "Factura"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 3
        '
        'ItemCuenta
        '
        Me.ItemCuenta.AutoHeight = False
        Me.ItemCuenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuenta.Name = "ItemCuenta"
        Me.ItemCuenta.NullText = ""
        Me.ItemCuenta.ShowFooter = False
        Me.ItemCuenta.ShowHeader = False
        '
        'ItemCuentas
        '
        Me.ItemCuentas.AutoHeight = False
        Me.ItemCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuentas.Name = "ItemCuentas"
        Me.ItemCuentas.NullText = ""
        Me.ItemCuentas.ShowFooter = False
        Me.ItemCuentas.ShowHeader = False
        '
        'chkcontabiliza
        '
        Me.chkcontabiliza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkcontabiliza.Checked = True
        Me.chkcontabiliza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcontabiliza.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontabiliza.ForeColor = System.Drawing.Color.DarkRed
        Me.chkcontabiliza.Location = New System.Drawing.Point(791, 12)
        Me.chkcontabiliza.Name = "chkcontabiliza"
        Me.chkcontabiliza.Size = New System.Drawing.Size(106, 25)
        Me.chkcontabiliza.TabIndex = 9
        Me.chkcontabiliza.Text = "Contabilizar"
        '
        'chkGarantia
        '
        Me.chkGarantia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkGarantia.Location = New System.Drawing.Point(901, 12)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarantia.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkGarantia.Properties.Appearance.Options.UseFont = True
        Me.chkGarantia.Properties.Appearance.Options.UseForeColor = True
        Me.chkGarantia.Properties.Caption = "Garantia Bancaria"
        Me.chkGarantia.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkGarantia.Size = New System.Drawing.Size(131, 22)
        Me.chkGarantia.StyleController = Me.LayoutControl1
        Me.chkGarantia.TabIndex = 10
        '
        'chktipo
        '
        Me.chktipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chktipo.EditValue = "C"
        Me.chktipo.Location = New System.Drawing.Point(174, 12)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chktipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktipo.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chktipo.Properties.Appearance.Options.UseBackColor = True
        Me.chktipo.Properties.Appearance.Options.UseFont = True
        Me.chktipo.Properties.Appearance.Options.UseForeColor = True
        Me.chktipo.Properties.Columns = 2
        Me.chktipo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chktipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Credito"), New DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Debito")})
        Me.chktipo.Size = New System.Drawing.Size(613, 25)
        Me.chktipo.StyleController = Me.LayoutControl1
        Me.chktipo.TabIndex = 5
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.Location = New System.Drawing.Point(580, 65)
        Me.GridFacturas.MainView = Me.iVistaSaldos
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMnto})
        Me.GridFacturas.Size = New System.Drawing.Size(452, 598)
        Me.GridFacturas.TabIndex = 6
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVistaSaldos})
        '
        'iVistaSaldos
        '
        Me.iVistaSaldos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVistaSaldos.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVistaSaldos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVistaSaldos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVistaSaldos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVistaSaldos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn2, Me.vCobro, Me.GridColumn11, Me.GridColumn8, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn19})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.vCobro
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        Me.iVistaSaldos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.iVistaSaldos.GridControl = Me.GridFacturas
        Me.iVistaSaldos.Name = "iVistaSaldos"
        Me.iVistaSaldos.OptionsCustomization.AllowColumnMoving = False
        Me.iVistaSaldos.OptionsCustomization.AllowFilter = False
        Me.iVistaSaldos.OptionsCustomization.AllowGroup = False
        Me.iVistaSaldos.OptionsCustomization.AllowSort = False
        Me.iVistaSaldos.OptionsView.ShowFooter = True
        Me.iVistaSaldos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Facturar"
        Me.GridColumn9.FieldName = "Facturar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 27
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Factura"
        Me.GridColumn4.FieldName = "No Factura"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 44
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Fecha"
        Me.GridColumn5.FieldName = "Fecha"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 44
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Total"
        Me.GridColumn6.DisplayFormat.FormatString = "n2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Total"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 44
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Total U$"
        Me.GridColumn2.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Total U$"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total U$", "Total U$={0:n2}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 36
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Mntto. Valor"
        Me.GridColumn11.ColumnEdit = Me.txtMnto
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Monto_Mantenimiento"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto_Mantenimiento", "{0:n2}")})
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        Me.GridColumn11.Width = 44
        '
        'txtMnto
        '
        Me.txtMnto.AutoHeight = False
        Me.txtMnto.Mask.EditMask = "n2"
        Me.txtMnto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMnto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMnto.Name = "txtMnto"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Saldo"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Saldo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 48
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Saldo U$"
        Me.GridColumn12.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "SaldoU"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoU", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 45
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Abono"
        Me.GridColumn13.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "Abono"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:n2}")})
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Saldo Original"
        Me.GridColumn14.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "OtroSaldo"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtroSaldo", "{0:n2}")})
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "T/C Factura"
        Me.GridColumn15.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "TC"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Moneda"
        Me.GridColumn16.FieldName = "Moneda"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        Me.GridColumn16.Width = 36
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Paralelo"
        Me.GridColumn17.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "TC_Paralelo"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.AllowFocus = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        Me.GridColumn17.Width = 32
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "F/Electrónica"
        Me.GridColumn19.FieldName = "F/Electrónica"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 3
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(174, 41)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtnota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnota.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtnota.Properties.Appearance.Options.UseBackColor = True
        Me.txtnota.Properties.Appearance.Options.UseFont = True
        Me.txtnota.Properties.Appearance.Options.UseForeColor = True
        Me.txtnota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnota.Properties.MaxLength = 10
        Me.txtnota.Size = New System.Drawing.Size(307, 22)
        Me.txtnota.StyleController = Me.LayoutControl1
        Me.txtnota.TabIndex = 1
        '
        'cmbtipocomprobante
        '
        Me.cmbtipocomprobante.Location = New System.Drawing.Point(174, 115)
        Me.cmbtipocomprobante.Name = "cmbtipocomprobante"
        Me.cmbtipocomprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtipocomprobante.Properties.NullText = ""
        Me.cmbtipocomprobante.Properties.ShowFooter = False
        Me.cmbtipocomprobante.Properties.ShowHeader = False
        Me.cmbtipocomprobante.Size = New System.Drawing.Size(225, 20)
        Me.cmbtipocomprobante.StyleController = Me.LayoutControl1
        Me.cmbtipocomprobante.TabIndex = 1
        '
        'txtEquivalente
        '
        Me.txtEquivalente.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtEquivalente.Location = New System.Drawing.Point(174, 189)
        Me.txtEquivalente.Name = "txtEquivalente"
        Me.txtEquivalente.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtEquivalente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquivalente.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtEquivalente.Properties.Appearance.Options.UseBackColor = True
        Me.txtEquivalente.Properties.Appearance.Options.UseFont = True
        Me.txtEquivalente.Properties.Appearance.Options.UseForeColor = True
        Me.txtEquivalente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEquivalente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEquivalente.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtEquivalente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquivalente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEquivalente.Properties.Mask.EditMask = "n2"
        Me.txtEquivalente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEquivalente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEquivalente.Properties.NullText = "<Null>"
        Me.txtEquivalente.Properties.ReadOnly = True
        Me.txtEquivalente.Size = New System.Drawing.Size(225, 22)
        Me.txtEquivalente.StyleController = Me.LayoutControl1
        Me.txtEquivalente.TabIndex = 1
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(12, 231)
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(559, 64)
        Me.txtcomentario.StyleController = Me.LayoutControl1
        Me.txtcomentario.TabIndex = 2
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(441, 91)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(130, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem10, Me.LayoutControlItem18, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.lyGarantiaChk, Me.LayoutControlItem17, Me.lyMonto, Me.lyMontoL, Me.lyGarantia, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.lyGrid, Me.lyMnto, Me.lyEmpty, Me.lySpliter, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1044, 697)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtnota
        Me.LayoutControlItem1.CustomizationFormText = "#Nota:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(473, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(473, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(473, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "#Nota:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbtipocomprobante
        Me.LayoutControlItem3.CustomizationFormText = "Tipo de Comprobante:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(391, 24)
        Me.LayoutControlItem3.Text = "Tipo de Comprobante:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.chktipo
        Me.LayoutControlItem10.CustomizationFormText = "Tipo de Nota:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(779, 29)
        Me.LayoutControlItem10.Text = "Tipo de Nota:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbCliente
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(563, 24)
        Me.LayoutControlItem18.Text = "Cliente:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkcontabiliza
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(779, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(110, 29)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 29)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(110, 29)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.GridDetalle
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 287)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(563, 390)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbTipoNota
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 79)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(391, 24)
        Me.LayoutControlItem2.Text = "Tipo de Nota:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbmoneda
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 127)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(563, 24)
        Me.LayoutControlItem6.Text = "Moneda de Pago:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Fecha
        Me.LayoutControlItem5.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(391, 79)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Fecha:"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(33, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'lyGarantiaChk
        '
        Me.lyGarantiaChk.Control = Me.chkGarantia
        Me.lyGarantiaChk.CustomizationFormText = "LayoutControlItem9"
        Me.lyGarantiaChk.Location = New System.Drawing.Point(889, 0)
        Me.lyGarantiaChk.MaxSize = New System.Drawing.Size(135, 29)
        Me.lyGarantiaChk.MinSize = New System.Drawing.Size(135, 29)
        Me.lyGarantiaChk.Name = "lyGarantiaChk"
        Me.lyGarantiaChk.Size = New System.Drawing.Size(135, 29)
        Me.lyGarantiaChk.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyGarantiaChk.TextSize = New System.Drawing.Size(0, 0)
        Me.lyGarantiaChk.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Vencimiento
        Me.LayoutControlItem17.Location = New System.Drawing.Point(391, 103)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(172, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Vencimiento:"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'lyMonto
        '
        Me.lyMonto.Control = Me.txtTotal
        Me.lyMonto.Location = New System.Drawing.Point(0, 151)
        Me.lyMonto.MaxSize = New System.Drawing.Size(391, 26)
        Me.lyMonto.MinSize = New System.Drawing.Size(391, 26)
        Me.lyMonto.Name = "lyMonto"
        Me.lyMonto.Size = New System.Drawing.Size(391, 26)
        Me.lyMonto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyMonto.Text = "Monto U$:"
        Me.lyMonto.TextSize = New System.Drawing.Size(159, 13)
        '
        'lyMontoL
        '
        Me.lyMontoL.Control = Me.txtEquivalente
        Me.lyMontoL.CustomizationFormText = "Monto:"
        Me.lyMontoL.Location = New System.Drawing.Point(0, 177)
        Me.lyMontoL.MaxSize = New System.Drawing.Size(391, 26)
        Me.lyMontoL.MinSize = New System.Drawing.Size(391, 26)
        Me.lyMontoL.Name = "lyMontoL"
        Me.lyMontoL.Size = New System.Drawing.Size(391, 26)
        Me.lyMontoL.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyMontoL.Text = "Equivalente a:"
        Me.lyMontoL.TextSize = New System.Drawing.Size(159, 13)
        '
        'lyGarantia
        '
        Me.lyGarantia.Control = Me.cbGarantias
        Me.lyGarantia.Location = New System.Drawing.Point(568, 29)
        Me.lyGarantia.Name = "lyGarantia"
        Me.lyGarantia.Size = New System.Drawing.Size(456, 24)
        Me.lyGarantia.Text = "Garantia Bancaria:"
        Me.lyGarantia.TextSize = New System.Drawing.Size(159, 13)
        Me.lyGarantia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(473, 29)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(90, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtcomentario
        Me.LayoutControlItem7.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 203)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 84)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(134, 84)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(563, 84)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Concepto:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(159, 13)
        '
        'lyGrid
        '
        Me.lyGrid.Control = Me.GridFacturas
        Me.lyGrid.CustomizationFormText = "LayoutControlItem11"
        Me.lyGrid.Location = New System.Drawing.Point(568, 53)
        Me.lyGrid.Name = "lyGrid"
        Me.lyGrid.Size = New System.Drawing.Size(456, 602)
        Me.lyGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.lyGrid.TextVisible = False
        '
        'lyMnto
        '
        Me.lyMnto.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyMnto.AppearanceItemCaption.Options.UseFont = True
        Me.lyMnto.Control = Me.etMntto
        Me.lyMnto.Location = New System.Drawing.Point(803, 655)
        Me.lyMnto.Name = "lyMnto"
        Me.lyMnto.Size = New System.Drawing.Size(221, 22)
        Me.lyMnto.Text = "Mantenimiento de Valor:"
        Me.lyMnto.TextSize = New System.Drawing.Size(159, 16)
        '
        'lyEmpty
        '
        Me.lyEmpty.AllowHotTrack = False
        Me.lyEmpty.Location = New System.Drawing.Point(568, 655)
        Me.lyEmpty.Name = "lyEmpty"
        Me.lyEmpty.Size = New System.Drawing.Size(235, 22)
        Me.lyEmpty.TextSize = New System.Drawing.Size(0, 0)
        '
        'lySpliter
        '
        Me.lySpliter.AllowHotTrack = True
        Me.lySpliter.Location = New System.Drawing.Point(563, 29)
        Me.lySpliter.Name = "lySpliter"
        Me.lySpliter.Size = New System.Drawing.Size(5, 648)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtTasa
        Me.LayoutControlItem14.Location = New System.Drawing.Point(401, 151)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "T/C Oficial:"
        Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(53, 13)
        Me.LayoutControlItem14.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtTasaParalela
        Me.LayoutControlItem15.Location = New System.Drawing.Point(401, 177)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "T/C Paralelo:"
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(62, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(391, 151)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 52)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 578)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "&Exportar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.cmdguardar)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdsalir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 670)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 536)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(107, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 17
        Me.SimpleButton2.Text = "&Actualizar Saldos"
        '
        'cmdguardar
        '
        Me.cmdguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdguardar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.cmdguardar.Location = New System.Drawing.Point(12, 12)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(107, 38)
        Me.cmdguardar.StyleController = Me.LayoutControl2
        Me.cmdguardar.TabIndex = 7
        Me.cmdguardar.Text = "&Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.ImageOptions.Image = CType(resources.GetObject("cmdsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(12, 620)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdsalir.StyleController = Me.LayoutControl2
        Me.cmdsalir.TabIndex = 8
        Me.cmdsalir.Text = "&Salir"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem7, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 670)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdguardar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 566)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdsalir
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 608)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(111, 482)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 524)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("8bc07d75-2379-49e7-8aaa-1d74b08d9fa4")
        Me.DockPanel1.Location = New System.Drawing.Point(1044, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 697)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 670)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmNotasCreditoDebitoNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1184, 697)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmNotasCreditoDebitoNew"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTasaParalela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGarantias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chktipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMnto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtipocomprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquivalente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcomentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGarantiaChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMontoL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMnto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyEmpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lySpliter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Comprobante As New Integer
    Private Comprobantes As New VB.SysContab.ComprobanteDB
    Private Catalogo As New VB.SysContab.CatalogoDB
    Private DT As DataTable
    Private IdNota As Integer = 0
    Private NoComprob As Integer = 0
    Private PeriodosDB As New VB.SysContab.PeriodosDB
    Private Temp As Boolean = False, temp2 As Boolean = False

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim NoComp As Double = 0

    Dim db_Notas As New db_MaestroNotasCD
    Dim tc As New db_TasaCambio

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub FrmNotasCreditoDebitoNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Fecha.DateTime = Now.Date
        Vencimiento.DateTime = Now.Date

        txtTasa.EditValue = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Now.Date & "')").Rows.Item(0)(0)).ToString("n4")

        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)
        Combo(cbTipoNota, db_TipoNotasCD.Listar(0), "[Seleccione Tipo de Nota]")

        ' DT = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)

        'ItemCuenta.DataSource = DT
        'ItemCuenta.DisplayMember = "Cuenta"
        'ItemCuenta.ValueMember = "Cuenta"
        'ItemCuenta.PopulateColumns()
        'ItemCuentas.DataSource = DT
        'ItemCuentas.DisplayMember = "Nombre"
        'ItemCuentas.ValueMember = "Cuenta"
        'ItemCuentas.PopulateColumns()

        'For i As Integer = 2 To ItemCuenta.Columns.Count - 1
        '    ItemCuentas.Columns(i).Visible = False
        '    ItemCuenta.Columns(i).Visible = False
        'Next

        'ItemCuenta.Columns(1).Visible = False
        'ItemCuentas.Columns(0).Visible = False


        LoadClients()
        GetTipoComprobantesList(cmbtipocomprobante)
        GetMonedasList(cmbmoneda)
        cmbmoneda.EditValue = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase

        GetDetalle()
        Fecha.EditValue = Now.Date
        GetNota()

        GetServicios_Retencion(Me.cbServicios)
        Distribucion()
        'GetTasa()
        GetTasaCambio()
        lyMonto.Text = "Total Abono en " & cmbmoneda.GetColumnValue("Simbolo").ToString & " :"
    End Sub

    Private Sub LoadClients()
        Dim DT_CLIENTE As DataTable = ObtieneDatos("_ClientesGetList", EmpresaActual, 1)

        SearchLookUp(cbCliente, DT_CLIENTE, "Nombre", "Codigo", 4, 5, 6, 7, 8)
        SearchLookUp(cbGarantias, ObtieneDatos("sp_sel_Clientes_Garantias", EmpresaActual), "Nombre", "Codigo")


        'GetClientesList(cmbnombre)
        'cmbnombre.Properties.Columns(0).Visible = True : cmbnombre.Properties.ShowHeader = True 'Para radioshack
        'cmbnombre.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
        '        GetCatalogoClientes(Me.cmbclientes, Me.vClientes)


        'cbGarantias.Properties.DataSource = ObtieneDatos("SELECT c.CODIGO, c.CodigoLetra [CODIGO LETRA], c.NOMBRE, c.CUENTA" _
        '                                                    + " FROM CLIENTES c WHERE c.Garantia = 1 AND c.EMPRESA = " & EmpresaActual)
        'cbGarantias.Properties.DisplayMember = "NOMBRE"
        'cbGarantias.Properties.ValueMember = "CODIGO"
        'cbGarantias.Properties.PopulateColumns()
        'cbGarantias.Properties.ShowFooter = False
    End Sub

    Private Sub GetDetalle()
        'GridDetalle.DataSource = ObtieneDatos("SELECT '' as Cuenta,0.00 as Monto,'' ret, '' Descripcion FROM Usuarios WHERE 0=1")
        GridDetalle.DataSource = ObtieneDatos("sp_sel_ComprobantesVacio", EmpresaActual)
    End Sub

    Sub GetTasaCambio()
        tc.GetTasaCambio(MonedaBase, Fecha.DateTime.Date)
        '
        txtTasa.EditValue = tc.TC_Oficial
        txtTasaParalela.EditValue = tc.TC_Paralelo
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVistaCuentas.RowUpdated
        iVistaCuentas.RefreshData()
        iVistaCuentas.UpdateTotalSummary()
        '
        'txtmonto.EditValue = iVistaCuentas.Columns("Monto").SummaryItem.SummaryValue
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Me.Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------
        '
        Dim MttoMonto As Double = 0, CobroTotal As Double = 0   ',MontoTotal As Double = 0
        Dim AplicarCuentas As Boolean = True

        If chktipo.EditValue = "C" Then
            With iVistaSaldos
                For i As Integer = 0 To .DataRowCount
                    If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then
                        MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
                        CobroTotal += .GetRowCellValue(i, "Cobro")
                        'MontoTotal += .GetRowCellValue(i, "Total")
                    End If

                    If .GetRowCellValue(i, "Facturar") Then AplicarCuentas = False
                Next
            End With
        End If

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If
        '
        If cmbtipocomprobante.EditValue Is Nothing Or
            Fecha.EditValue Is Nothing Or
            txtTotal.EditValue = 0.00 Then
            XtraMsg("Complete la informacion")
            Exit Sub
        End If

        If txtcomentario.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el Concepto de la Nota.")
            txtcomentario.Focus()
            Exit Sub
        End If

        If chktipo.EditValue = "C" Then

            If cbTipoNota.EditValue Is Nothing Then
                XtraMsg("Seleccione el tipo de Nota de Crédito", MessageBoxIcon.Warning)
                cbTipoNota.Focus()
                Exit Sub
            End If

            ''If FormatNumber(txtmonto.EditValue - MttoMonto, 2) <> FormatNumber(GridView2.Columns("Cobro").SummaryItem.SummaryValue, 2) Then
            If Not AplicarCuentas Then
                If Math.Round(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue) - MttoMonto, 2) <> Math.Round(CobroTotal, 2) Then
                    XtraMsg("El monto de la nota no corresponde al abono a las facturas" & vbCrLf &
                            "Diferencia: " & CDbl(Math.Round(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue) - MttoMonto, 2) - Math.Round(CobroTotal, 2)).ToString("n2"))
                    Exit Sub
                End If
            End If

        End If

        If chktipo.EditValue = "C" Then
            If AplicarCuentas Then
                If Not XtraMsg2("Desea Aplicar la Nota de Crédito a favor del Cliente: " + cbCliente.Text + " ?") Then
                    Exit Sub
                End If
            End If
        End If
        '        

        Dim IsCuentaIngreso As Boolean = False
        Dim _dt As DataTable =
            ObtieneDatos("sp_sel_Cuentas_Ingresos", EmpresaActual)

        If _dt.Rows.Count > 0 Then
            For i As Integer = 0 To iVistaCuentas.DataRowCount - 1
                If _dt.Select("Cuenta = '" & iVistaCuentas.GetRowCellValue(i, "Cuenta") & "'").Length > 0 Then
                    IsCuentaIngreso = True
                    Exit For
                End If
            Next
            '
            'Verificar Cierre de Bolsa
            If IsCuentaIngreso Then
                If Fecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                    XtraMsg("La fecha: " & Fecha.DateTime.ToShortDateString & " con la que intenta grabar esta Nota ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                            "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If


        If Not chkcontabiliza.Checked Then  'Preguntar si va a  sin Conbilizar
            If Not XtraMsg2("Esta seguro de grabar este Nota de " & IIf(chktipo.EditValue = "C", "Crédito", "Débito") & " sin Contabilizar ?" & vbCrLf &
                        "Este proceso afecta solamente al Auxiliar de Clientes.") Then
                Exit Sub
            End If
        End If

        If chkcontabiliza.Checked Then  'Si se contabiliza es necesario grabar el detalle
            ''If FormatNumber(txtmonto.EditValue, 2) <> FormatNumber(GridView1.Columns("Monto").SummaryItem.SummaryValue, 2) Then

            If iVistaSaldos.DataRowCount = 0 Then
                If cmbmoneda.EditValue <> MonedaBase Then
                    If txtEquivalente.EditValue = 0.00 Then txtEquivalente.EditValue = Math.Round(CDbl(txtTotal.EditValue * txtTasa.EditValue), 2)
                End If
            End If
            '
            If Math.Round(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue), 2) <> Math.Round(iVistaCuentas.Columns("Monto").SummaryItem.SummaryValue, 2) Then
                XtraMsg("El Monto de la Nota no Corresponde al Total en el Detalle." & vbCrLf &
                        "Diferencia: " & CDbl(Math.Round(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue), 2) - Math.Round(iVistaCuentas.Columns("Monto").SummaryItem.SummaryValue, 2)).ToString("n2"))
                Exit Sub
            End If
            '
            If iVistaCuentas.DataRowCount = 0 Then
                XtraMsg("Describa el Detalle de la Nota", MessageBoxIcon.Warning)
                Exit Sub
            End If
            '
            If IsNull(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Cuenta"), "0") = "0" Or
                IsNull(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Cuenta"), "") = "" Then
                XtraMsg("El cliente no tiene asignado cuenta contable")
                cbCliente.Focus()
                Exit Sub
            End If

            'If IsNull(cmbnombre.GetColumnValue("Cuenta"), "0") = "0" Then
            '    XtraMsg("El cliente no tiene asignado cuenta contable")
            '    Exit Sub
            'End If
        End If
        '
        If chkGarantia.Checked Then
            If cbGarantias.EditValue Is Nothing Then
                XtraMsg("Seleccione el Cliente a Aplicar la Garantia Bancaria")
                cbGarantias.Focus()
                Exit Sub
            End If
        End If
        '       

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList
        Dim Note As String

        If chkGarantia.Checked Then
            If Not XtraMsg2("Al Aplicar la Garantia Bancaria se generará una Nota de Débito," &
                     "Desea Aplicar la Garantia al Cliente Seleccionado?") Then
                Exit Sub
            End If

            Note = "ND" + txtnota.Text.PadLeft(6, "0"c)  'Format(CInt(txtnota.Text), "000000")

            If db_MaestroNotasCD.Buscar(Note) = "SI" Then
                XtraMsg("El Número de Nota de Debito: " + Note + " para la Garantia  bancaria ya se encuentra registrado", MessageBoxIcon.Error)
                txtnota.Focus()
                txtnota.SelectAll()
                Exit Sub
            End If

            'If ObtieneDatos("SELECT count(nonota) from maestronotascd where nonota = '" & Note & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0) > 0 Then
            '    XtraMsg("El Número de Nota de Debito: " + Note + " para la Garantia  bancaria ya se encuentra registrado", MessageBoxIcon.Warning)
            '    txtnota.Focus()
            '    txtnota.SelectAll()
            '    Exit Sub
            'End If

        End If

        Note = "N" + chktipo.EditValue + txtnota.Text.PadLeft(6, "0"c)  'Format(CInt(txtnota.Text), "000000")

        '  If ObtieneDatos("SELECT count(nonota) from maestronotascd where nonota = '" & Note & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0) > 0 Then

        If db_MaestroNotasCD.Buscar(Note) = "SI" Then
            XtraMsg("El Número de Nota: " + Note + " ya esta registrada", MessageBoxIcon.Error)
            txtnota.Focus()
            txtnota.SelectAll()
            Exit Sub
        End If
        '

        ShowSplash("Guardando...")
        '
        '*******************************  CONTABILIZAR    **********************************
        Try
            If chkcontabiliza.Checked Then
                Dim r As New VB.SysContab.Rutinas

                '******** VERIFICAR DISTRIBUCION **************************************
                For i As Integer = 0 To Me.iVistaCuentas.DataRowCount - 1
                    Dim CTemp As String = vbNullString
                    Try
                        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & Me.iVistaCuentas.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
                    Catch ex As Exception
                        CTemp = "xxx"
                    End Try

                    If CTemp <> "xxx" And CTemp <> vbNullString Then
                        '
                        If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                            XtraMsg("La Cuenta " & Me.iVistaCuentas.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                Next
                '******** FIN VERIFICAR DISTRIBUCION *************************************

                'Dim Plantilla As New VB.SysContab.PlantillaDB
                Dim CuentaMtto As String = String.Empty  ', CuentaEMtto As String = ""

                If chktipo.EditValue = "C" Then
                    If MttoMonto <> 0 Then
                        Try
                            'Buscar las Cuentas de Matto Valor
                            Dim DsPlantillas As DataSet = VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles

                            If MttoMonto > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                            If MttoMonto < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

                            '/*******************  VERIFICAR DISTRIBUCION EN LA CUENTA DE MANTENIMIENTO DE VALOR    *********/
                            Dim CTemp As String = vbNullString

                            Try
                                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                    + " CuentaContable = '" & CuentaMtto & "'" _
                                    + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)

                            Catch ex As Exception
                                CTemp = "xxx"
                            End Try
                            '
                            If CTemp <> "xxx" And CTemp <> vbNullString Then
                                '
                                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                                    XtraMsg("La Cuenta " & CuentaMtto & " de Mantenimiento de Valor es de Distribución, Favor Distribuirla " & vbCrLf &
                                   "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                                    Exit Sub
                                End If
                            End If

                        Catch ex As Exception
                            XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.", MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                    End If
                End If
                '
                Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)

                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction()

                Dim DC As String = chktipo.EditValue
                NoComprob = VB.SysContab.ComprobanteDB.AddComprobante(cmbtipocomprobante.EditValue, txtTasa.EditValue, txtcomentario.Text,
                                                            cmbmoneda.EditValue,
                                                            Per_Id, Fecha.DateTime.Date, 0, "",
                                                            False, 0, "", 1, Note, Fecha.DateTime.Date, 0,
                                                            IIf(chktipo.EditValue = "D", OrigenComprobantes.ND_CLIENTE, OrigenComprobantes.NC_CLIENTE))
                'Comprobantes.AddFacturaFecha(Me.cbProveedor.SelectedValue, Me.txtFactura.Text, Me.dtpFechaRecepcion.Value)

                If chktipo.EditValue = "C" Then
                    If MttoMonto <> 0 Then VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, CuentaMtto, "Mantenimiento de Valor",
                                                                                             Math.Round(Math.Abs(MttoMonto), 2), "",
                                                                                             cmbtipocomprobante.EditValue,
                                                                                             IIf(MttoMonto > 0, "C", "D"), 0, 0,
                                                                                             Fecha.DateTime.Date, 0)

                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob,
                                                                      cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Cuenta"),
                                                                      cbCliente.Text & ", " & txtcomentario.Text,
                                                                      Math.Round(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue) - MttoMonto, 2), "",
                                                                      cmbtipocomprobante.EditValue, DC, 0, 0,
                                                                      Fecha.DateTime.Date, 0)
                Else
                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob,
                                                                      cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Cuenta"),
                                                                      cbCliente.Text & ", " & txtcomentario.Text,
                                                                      IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue), "",
                                                                      cmbtipocomprobante.EditValue, DC, 0, 0,
                                                                      Fecha.DateTime.Date, 0)
                End If

                'Comprobantes.AddCatalogoTrans(Me.cbProveedor.SelectedValue, 0, Me.txtMonto.Text, "")
                'Catalogo.ActualizarCuentas(Me.cbProveedor.SelectedValue, Me.txtMonto.Text, 1)

                Dim Importe As Double = 0

                For i As Integer = 0 To iVistaCuentas.DataRowCount - 1

                    Importe = Math.Round(CDbl(Me.iVistaCuentas.GetRowCellValue(i, "Monto")), 2)

                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, iVistaCuentas.GetRowCellValue(i, "Cuenta"),
                                                        IsNull(iVistaCuentas.GetRowCellValue(i, "Descripcion"),
                                                        ObtieneDatosTrans("_CatalogoListBuscar '" & iVistaCuentas.GetRowCellValue(i, "Cuenta") & "'," & EmpresaActual).Rows.Item(0)("NOMBRE")),
                                                        IIf(Importe < 0, Importe * -1, Importe), "",
                                                        cmbtipocomprobante.EditValue,
                                                        IIf(Importe < 0, DC, IIf(DC = "C", "D", "C")),
                                                                      IsNull(iVistaCuentas.GetRowCellValue(i, "Factura"), ""), 0,
                                                        Fecha.DateTime.Date, 1, 0,
                                                        IsNull(iVistaCuentas.GetRowCellValue(i, "ret"), ""))

                    'Comprobantes.AddCatalogoTrans(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), 0, tCust.Rows(i)("Descripcion").ToString)
                    'Catalogo.ActualizarCuentas(tCust.Rows(i)("Codigo1"), tCust.Rows(i)("Monto"), Opera)
                Next
                '
                VB.SysContab.Rutinas.okTransaccion()
                '-----------------------------------------------
                'Guarda la Distribucion
                '-----------------------------------------------
                Dim DT_F As DataTable
                DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
                If Not DT_F Is Nothing Then
                    For i As Integer = 0 To DT_F.Rows.Count - 1
                        With DT_F
                            If .Rows(i).RowState = DataRowState.Added Then
                                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                                " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.Fecha.DateTime.Month & "," &
                                VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                            ElseIf .Rows(i).RowState = DataRowState.Modified Then
                                GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.Fecha.DateTime.Month & "," &
                                "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                                "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                            ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                            End If
                        End With
                    Next
                End If

                Distribucion()
                '--------------------------
                'Fin de Guarda Distribucion
                '--------------------------
            End If

        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            HideSplash()

            XtraMsg("Error al contabilizar: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try

        '-----------------------------------------------------------------------------------
        'FIN DE CONTABILIZAR
        '-----------------------------------------------------------------------------------
        '
        'Variables.Clear()
        'Variables.Add("NoNota")
        'Variables.Add("IdCliente")
        'Variables.Add("Empresa")
        'Variables.Add("Fecha")
        'Variables.Add("TipoComprobante")
        'Variables.Add("Monto")
        'Variables.Add("Comentario")
        'Variables.Add("Tipo")
        'Variables.Add("Anulado")
        'Variables.Add("Moneda")
        'Variables.Add("Comp_No")
        'Variables.Add("Per_Id")
        'Variables.Add("Mes")
        'Variables.Add("Vencimiento")
        ''
        'Datos.Clear()
        'Datos.Add(Note)
        'Datos.Add(cbCliente.EditValue)
        'Datos.Add(EmpresaActual)
        'Datos.Add(Fecha.DateTime.Date)
        'Datos.Add(cmbtipocomprobante.EditValue)
        'Datos.Add(txtmonto.EditValue)
        'Datos.Add(txtcomentario.Text)
        'Datos.Add(IIf(chktipo.EditValue = "C", 1, 2))
        'Datos.Add(0)
        'Datos.Add(cmbmoneda.EditValue)
        'Datos.Add(NoComprob)
        'Datos.Add(PeriodosDB.Activo(Fecha.DateTime.Date))
        'Datos.Add(Fecha.DateTime.Date.Month)
        'Datos.Add(Vencimiento.DateTime.Date)

        'IdNota = ProcedureParameters(Datos, Variables, "SP_GuardaMaestroNotasCD").Rows(0).Item(0)        

        IdNota = db_Notas.Guardar(Note, cbCliente.EditValue, Fecha.DateTime.Date, cmbtipocomprobante.EditValue,
                                    IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue),
                                    txtcomentario.Text, IIf(chktipo.EditValue = "C", 1, 2),
                                    cmbmoneda.EditValue, NoComprob, VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date),
                                    Fecha.DateTime.Date.Month, Vencimiento.DateTime.Date, 0,
                                    IIf(cbTipoNota.EditValue Is Nothing, 0, cbTipoNota.EditValue))

        If chkGarantia.Checked Then GuardarNotaGarantia(IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, txtEquivalente.EditValue))

        'Variables.Clear()
        'Variables.Add("IdNota")
        'Variables.Add("Factura")
        'Variables.Add("Monto")
        'Variables.Add("Fecha")
        'Variables.Add("Empresa")
        'Variables.Add("Mnto")

        If chktipo.EditValue = "C" Then
            With iVistaSaldos
                For i As Integer = 0 To .DataRowCount
                    If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then

                        db_Notas.GuardarDetalle(IdNota,
                                                .GetRowCellValue(i, "No Factura"),
                                                .GetRowCellValue(i, "Cobro"),
                                                .GetRowCellValue(i, "Fecha"),
                                                .GetRowCellValue(i, "Monto_Mantenimiento"))
                        'Datos.Clear()
                        'Datos.Add(IdNota)
                        'Datos.Add(.GetRowCellValue(i, "No Factura"))
                        'Datos.Add(.GetRowCellValue(i, "Cobro"))
                        'Datos.Add(.GetRowCellValue(i, "Fecha"))
                        'Datos.Add(EmpresaActual)
                        'Datos.Add(.GetRowCellValue(i, "Monto_Mantenimiento"))
                        ''
                        'ProcedureSave(Datos, Variables, "SP_GuardaDetalleNotasCD")
                    End If
                Next
            End With
        End If

        HideSplash()
        '
        cbCliente.EditValue = Nothing
        cbGarantias.EditValue = Nothing
        cmbtipocomprobante.EditValue = Nothing
        GetNota()
        txtcomentario.Text = Nothing
        GetDetalle()
        GridFacturas.DataSource = Nothing
        txtEquivalente.EditValue = 0.0
        txtTotal.EditValue = 0.00
        chkGarantia.Checked = False
        etMntto.Text = "0.0000"
    End Sub


    Sub GuardarNotaGarantia(ByVal Monto As Double)

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList
        'Dim Note As String

        'Note = "ND" + txtnota.Text.PadLeft(6, "0"c)

        'Variables.Clear()
        'Variables.Add("NoNota")
        'Variables.Add("IdCliente")
        'Variables.Add("Empresa")
        'Variables.Add("Fecha")
        'Variables.Add("TipoComprobante")
        'Variables.Add("Monto")
        'Variables.Add("Comentario")
        'Variables.Add("Tipo")
        'Variables.Add("Anulado")
        'Variables.Add("Moneda")
        'Variables.Add("Vencimiento")

        'Datos.Clear()
        'Datos.Add(Note)
        'Datos.Add(cbGarantias.EditValue)
        'Datos.Add(EmpresaActual)
        'Datos.Add(Fecha.DateTime.Date)
        'Datos.Add(cmbtipocomprobante.EditValue)
        'Datos.Add(Monto)
        'Datos.Add("Nota de Débito cargando Garantia Bancaria al Cliente: " + cbGarantias.Text)
        'Datos.Add(2)
        'Datos.Add(0)
        'Datos.Add(cmbmoneda.EditValue)
        'Datos.Add(Vencimiento.DateTime.Date)
        'Dim No As Integer = ProcedureParameters(Datos, Variables, "SP_GuardaMaestroNotasCD").Rows(0).Item(0)

        Dim Note As String = "ND" + txtnota.Text.PadLeft(6, "0"c)

        Dim No As Integer = db_Notas.Guardar(
            Note,
            cbGarantias.EditValue,
            Fecha.DateTime.Date,
            cmbtipocomprobante.EditValue,
            Monto,
            "Nota de Débito cargando Garantia Bancaria al Cliente: " + cbGarantias.Text,
            2,
            cmbmoneda.EditValue,
            0,
            0,
            0,
            Vencimiento.DateTime.Date)
    End Sub

    Sub GuardarNotaGarantiaDetalle()

    End Sub

    Private Sub GetNota()
        'txtnota.Text = "N" + chktipo.EditValue + Format(ObtieneDatos("SELECT ISNULL(MAX(CAST(RIGHT(NoNota,4) as int)),0) + 1 FROM MaestroNotasCD WHERE Tipo = " & IIf(chktipo.EditValue = "C", 1, 2)).Rows(0).Item(0), "0000")
        'Dim serie As String = ""
        ''
        'Try
        '    serie = Me.cmbnombre.GetColumnValue("CodigoLetra").ToString.Substring(1, 2)
        'Catch ex As Exception
        'End Try

        'Try
        '    txtnota.Text = Format(ObtieneDatos("SELECT ISNULL(MAX(CAST(RIGHT(NoNota,len(nonota)-2) as int)),0) + 1 FROM MaestroNotasCD WHERE Tipo = " & IIf(chktipo.EditValue = "C", 1, 2)).Rows(0).Item(0), "0000").ToString
        'Catch ex As Exception
        '    txtnota.Text = "0000"
        'End Try

        txtnota.Text =
            db_MaestroNotasCD.GetNumero(IIf(chktipo.EditValue = "C", 1, 2))
    End Sub

    Private Sub chktipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktipo.SelectedIndexChanged
        If sender.editvalue = "C" Then
            chkGarantia.Checked = False
            lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyGarantiaChk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyEmpty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyMnto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lySpliter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            'GridFacturas.Visible = True
            'chkGarantia.Visible = True
            GetData()
        Else
            chkGarantia.Checked = False
            lyGrid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyGarantiaChk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyEmpty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyMnto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lySpliter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            'GridFacturas.Visible = False
            'Me.chkGarantia.Visible = False
        End If
        '
        ConversionEquivalente()
        GetNota()
    End Sub

    Private Sub GetData()
        Try
            'Dim Datos As New ArrayList
            'Dim Variables As New ArrayList
            'Variables.Add("Cliente")
            'Variables.Add("Empresa")
            'Variables.Add("Fecha")
            'Datos.Add(cbCliente.EditValue)
            'Datos.Add(EmpresaActual)
            'Datos.Add(Fecha.DateTime.Date)
            'GridFacturas.DataSource = ProcedureParameters(Datos, Variables, "SP_GetListFacturasXCliente")
            ''FormatoGrid(Me.GridView2)

            If cbCliente.EditValue Is Nothing Then Exit Sub

            If Not Inicio Then GridFacturas.DataSource =
                VB.SysContab _
                .Facturas_VentasDB _
                .GetCobrosPendientesAnticipos(
                cbCliente.EditValue,
                Fecha.DateTime.Date)

            If EmpresaActual = 1 Then iVistaSaldos.Columns("TC_Paralelo").Visible = True Else iVistaSaldos.Columns("TC_Paralelo").Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbnombre_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetData()
    End Sub

    Private Sub Fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.EditValueChanged
        ' GetData()
        'GetTasa()

        If Inicio Then Exit Sub

        GetTasaCambio()

        'If txtmontoU.EditValue = 0.00 Then ConvertiMonto(1)
        'If txtmonto.EditValue = 0.00 Then ConvertiMonto(2)

        'ConvertiMonto(1)
        'ConvertiMonto(2)

        If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
    End Sub

    'Private Sub Distribuir()
    '    Dim Total As Double = IsNull(txtEquivalente.EditValue, 0.00)
    '    Dim Valor As Double = 0.00
    '    Dim Mntto As Double = 0.00

    '    With iVistaSaldos
    '        For i As Integer = 0 To .DataRowCount
    '            If .GetRowCellValue(i, "Facturar") = True Then
    '                If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '                    Temp = True
    '                    'Calcular el Deslizamiento por el Abono
    '                    Dim dm As New db_DeslizamientoMoneda
    '                    dm.CalcularDeslizamiento(Total, .GetRowCellValue(i, "TC"), txtTasa.EditValue)

    '                    .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)

    '                    'Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                    Valor = Total - dm.Mantenimiento_Valor
    '                    Total -= Total

    '                    Temp = False
    '                Else
    '                    If ((.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
    '                        Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                        Total -= Total
    '                    Else
    '                        Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                        Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                    End If
    '                    'Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                    'Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                    ''Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                End If
    '                .SetRowCellValue(i, "Cobro", Valor)
    '                Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
    '            End If
    '        Next
    '    End With
    '    Me.etMntto.Text = Mntto.ToString("n2")
    '    iVistaSaldos.UpdateTotalSummary()
    'End Sub

    Private Sub iVistaSaldos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVistaSaldos.CellValueChanged

        If e.Column.FieldName = "Facturar" And Not Temp Then
            iVistaSaldos.SetRowCellValue(e.RowHandle, "Cobro", 0)
            'Distribuir()
            'DistribuirPago()
            If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        End If
        '
        If e.Column.FieldName = "Monto_Mantenimiento" And Not Temp Then
            'iVistaSaldos.SetRowCellValue(e.RowHandle, "Cobro", 0)
            'Distribuir()

            temp2 = True
            If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
            temp2 = False

            'If Not iVistaSaldos.GetRowCellValue(e.RowHandle, "Facturar") Then
            '    Temp = True
            '    iVistaSaldos.SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
            '    Temp = False
            'Else
            '    If CDbl(iVistaSaldos.GetRowCellValue(e.RowHandle, "Saldo") - iVistaSaldos.GetRowCellValue(e.RowHandle, "Cobro")) > Math.Abs(CDbl(e.Value)) Then
            '        iVistaSaldos.SetRowCellValue(e.RowHandle, "Cobro", Math.Round(CDbl(iVistaSaldos.GetRowCellValue(e.RowHandle, "Cobro") - e.Value), 2))
            '    End If
            'End If
            ''
            'etMntto.Text = SumarDeslizamiento.ToString("n2")
        End If
        '
        If e.Column.FieldName = "Cobro" And Not Temp Then
            iVistaSaldos.SetRowCellValue(e.RowHandle, "Saldo", iVistaSaldos.GetRowCellValue(e.RowHandle, "Total") -
                                      iVistaSaldos.GetRowCellValue(e.RowHandle, "Abono") -
                                      iVistaSaldos.GetRowCellValue(e.RowHandle, "Cobro"))
        End If
        '

        iVistaSaldos.UpdateTotalSummary()
    End Sub


    Sub DistribuirPago()
        Dim Total As Double = txtTotal.EditValue

        Dim Valor As Double = 0.00, Mntto As Double = 0.00, Equivalente As Double = 0.00
        Dim dm As New db_DeslizamientoMoneda

        With iVistaSaldos

            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then
                    If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) >= Math.Round(Total, 2) Then
                        Temp = True
                        'temp2 valida si el Delizamiento se cambio Manual
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(CDbl(Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)), .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If
                        '
                        Valor = Total - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
                        Equivalente += (Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                        '
                        'No entra cuando el Mantenimiento es Manual
                        'If Not temp2 Then
                        '    'Varificando si el cliente queda con saldo despues de la aplicacion.
                        '    ' If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) = Math.Round(Total + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor), 2) Then
                        '    Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")) - (Valor + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)), 2)

                        '    If dif <> 0 Then
                        '        '  If dif > 0 Then
                        '        Valor = Math.Round(Valor + dif, 2)
                        '        .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                        '        ' End If
                        '    End If
                        '    ' End If
                        'End If
                        '
                        Total = 0.00
                        Temp = False
                    Else
                        Temp = True
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(CDbl(.GetRowCellValue(i, "OtroSaldo") / .GetRowCellValue(i, "TC")), .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If

                        Valor = .GetRowCellValue(i, "OtroSaldo") '- IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)

                        'If Not temp2 Then
                        '    'Varificando si el cliente queda con saldo despues de la aplicacion.                        
                        '    'Dim dif As Double = .GetRowCellValue(i, "OtroSaldo") - Valor
                        '    Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")) - (Valor + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)), 2)

                        '    If dif <> 0 Then
                        '        Valor = Math.Round(Valor + dif, 2)
                        '        .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                        '    End If
                        'End If
                        '
                        Equivalente += ((.GetRowCellValue(i, "OtroSaldo") + .GetRowCellValue(i, "Monto_Mantenimiento")) / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                        Total -= (.GetRowCellValue(i, "OtroSaldo") + .GetRowCellValue(i, "Monto_Mantenimiento"))
                        Temp = False
                    End If
                    '
                    If Valor > 0 Then
                        .SetRowCellValue(i, "Cobro", Valor)
                    Else
                        Temp = True
                        .SetRowCellValue(i, "Cobro", 0.00)
                        .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                        .SetRowCellValue(i, "Facturar", False)
                        Temp = False
                    End If
                    Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
                Else
                    Temp = True
                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                    Temp = False
                End If
            Next
            '
            etMntto.Text = Math.Round(Mntto, 2).ToString("n2")
            txtEquivalente.EditValue = Math.Round(Equivalente, 2)
            '
            .UpdateTotalSummary()
        End With
    End Sub

    Sub DistribuirDalares()

        Dim Total As Double = txtTotal.EditValue

        ' Dim TotalU As Double = IIf(cmbmoneda.EditValue = )
        'Dim TotalU As Double = txttotal.EditValue / IIf(EmpresaActual = 1, txtTasaParalela.EditValue, txtTasa.EditValue)

        Dim Valor As Double = 0.00, Mntto As Double = 0.00, Equivalente As Double = 0.00
        Dim dm As New db_DeslizamientoMoneda
        '
        With iVistaSaldos
            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then
                    If Math.Round(CDbl(.GetRowCellValue(i, "SaldoU")), 2) >= Math.Round(Total, 2) Then
                        Temp = True
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(Total, .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If
                        '                        
                        Valor = (Total * IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)) - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
                        Equivalente += (Total * IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))

                        'No entra cuando el Mantenimiento es Manual
                        If Not temp2 Then
                            'Varificando si el cliente queda con saldo despues de la aplicacion.
                            If Math.Round(CDbl(.GetRowCellValue(i, "SaldoU")), 2) = Math.Round(Total, 2) Then
                                Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) - Valor
                                If dif <> 0 Then
                                    '  If dif > 0 Then
                                    Valor = Math.Round(Valor + dif, 2)
                                    .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                                    ' End If
                                End If
                            End If
                        End If
                        '
                        Total = 0.00
                        Temp = False
                    Else

                        Temp = True
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(.GetRowCellValue(i, "SaldoU"), .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If

                        Valor = (.GetRowCellValue(i, "SaldoU") * IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)) - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)

                        If Not temp2 Then
                            'Varificando si el cliente queda con saldo despues de la aplicacion.                        
                            Dim dif As Double = .GetRowCellValue(i, "OtroSaldo") - Valor

                            If Math.Round(dif, 2) <> 0 Then
                                Valor = Math.Round(Valor + dif, 2)
                                .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                            End If
                        End If
                        '
                        Equivalente += (.GetRowCellValue(i, "SaldoU") * IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                        Total -= .GetRowCellValue(i, "SaldoU")
                        Temp = False
                    End If
                    '
                    If Valor > 0 Then
                        .SetRowCellValue(i, "Cobro", Valor)
                    Else
                        Temp = True
                        .SetRowCellValue(i, "Cobro", 0.00)
                        .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                        .SetRowCellValue(i, "Facturar", False)
                        Temp = False
                    End If
                    Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
                Else
                    Temp = True
                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                    Temp = False
                End If
                '
            Next
            '
            etMntto.Text = Mntto.ToString("n2")
            txtEquivalente.EditValue = Math.Round(Equivalente, 2)
            .UpdateTotalSummary()
        End With
    End Sub


    'Function SumarDeslizamiento() As Double
    '    Dim MttoMonto As Double = 0.00

    '    If chktipo.EditValue = "C" Then
    '        With iVistaSaldos
    '            For i As Integer = 0 To .DataRowCount - 1
    '                If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0.00) > 0 Then
    '                    MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
    '                End If
    '            Next
    '        End With
    '    End If

    '    Return MttoMonto
    'End Function



    'Sub DistribuirPago()

    '    Dim Total As Double = txtEquivalente.EditValue
    '    Dim TotalU As Double = txtTotal.EditValue
    '    Dim Valor As Double = 0
    '    Dim Mntto As Double = 0.00
    '    Dim dm As New db_DeslizamientoMoneda
    '    '
    '    With iVistaSaldos
    '        For i As Integer = 0 To .DataRowCount - 1
    '            If .GetRowCellValue(i, "Facturar") = True Then
    '                If (.GetRowCellValue(i, "SaldoU")) >= TotalU Then
    '                    Temp = True
    '                    'Calcular el Deslizamiento por el Abono
    '                    dm.CalcularDeslizamiento(TotalU, .GetRowCellValue(i, "TC"), txtTasa.EditValue, 1)
    '                    .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
    '                    Temp = False
    '                    '
    '                    'Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                    Valor = Total - dm.Mantenimiento_Valor
    '                    Total -= Total
    '                    TotalU -= TotalU
    '                Else
    '                    dm.CalcularDeslizamiento(.GetRowCellValue(i, "SaldoU"), .GetRowCellValue(i, "TC"), txtTasa.EditValue, 1)
    '                    Temp = True
    '                    .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
    '                    TotalU -= (.GetRowCellValue(i, "SaldoU"))
    '                    Temp = False
    '                    '
    '                    If ((.GetRowCellValue(i, "OtroSaldo")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
    '                        Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                        Total -= Total
    '                        ' TotalU -= TotalU
    '                    Else
    '                        Valor = .GetRowCellValue(i, "OtroSaldo")
    '                        Total -= (.GetRowCellValue(i, "OtroSaldo") + dm.Mantenimiento_Valor)      '.GetRowCellValue(i, "Monto_Mantenimiento"))
    '                        'TotalU -= .GetRowCellValue(i, "SaldoU")
    '                    End If
    '                End If

    '                If Valor > 0 Then
    '                    .SetRowCellValue(i, "Cobro", Valor)
    '                Else
    '                    Temp = True
    '                    .SetRowCellValue(i, "Cobro", 0.00)
    '                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
    '                    .SetRowCellValue(i, "Facturar", False)
    '                    Temp = False
    '                End If
    '                Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
    '            Else
    '                Temp = True
    '                .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
    '                Temp = False
    '            End If

    '        Next
    '        etMntto.Text = Mntto.ToString("n2")
    '        .UpdateTotalSummary()
    '    End With
    'End Sub

    Private Sub txtmonto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEquivalente.EditValueChanged
        ''Distribuir()

        ' ConvertiMonto(2)

    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles iVistaCuentas.ValidateRow

        If IsNull(iVistaCuentas.GetRowCellValue(e.RowHandle, "Cuenta"), "") = "" Or IsNull(iVistaCuentas.GetRowCellValue(e.RowHandle, "Monto"), 0.00) = 0.00 Then
            If IsNull(iVistaCuentas.GetRowCellValue(e.RowHandle, "Cuenta"), "") = "" Then e.ErrorText = "La Cuenta contable es Inválida..." & vbCrLf
            If IsNull(iVistaCuentas.GetRowCellValue(e.RowHandle, "Monto"), 0.00) = 0.00 Then e.ErrorText = "El Monto es Inválido..." & vbCrLf
            e.Valid = False
        End If

    End Sub


    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iVistaCuentas.DoubleClick
        If Me.iVistaCuentas.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim forma As New FrmDetalleRequisas
            With Me.iVistaCuentas
                'forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                'If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = 0 Then

                If chktipo.EditValue = "D" Then
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Monto") '.Item(.CurrentRowIndex, 4)
                    forma.Tipo = "C"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date)
                    forma.CompNo = NoComp
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                Else
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Monto") '.Item(.CurrentRowIndex, 3)
                    forma.Tipo = "D"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime)
                    forma.CompNo = NoComp
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                End If

                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                tmp = True
                Exit For
            End If
        Next

        Return tmp
    End Function

    Private Sub chkGarantia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGarantia.CheckedChanged
        If chkGarantia.Checked Then lyGarantia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If Not chkGarantia.Checked Then lyGarantia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub txtmonto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEquivalente.Validated
        ' Distribuir()
    End Sub

    Private Sub GridFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridFacturas.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(GridFacturas)
    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        If Inicio Then Exit Sub
        GetData()
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles iVistaCuentas.KeyDown
        If iVistaCuentas.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.KeyCode = Keys.Delete Then
            iVistaCuentas.DeleteSelectedRows()
            iVistaCuentas.RefreshData()
            iVistaCuentas.UpdateTotalSummary()
        End If
    End Sub

    Private Sub cmbmoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cmbmoneda.EditValueChanged

        'If cmbmoneda.EditValue = MonedaBase Then
        '    lyMonto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '    txtEquivalente.Properties.ReadOnly = False
        'Else
        '    lyMonto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        '    txtEquivalente.Properties.ReadOnly = True
        'End If

        lyMonto.Text = "Total Abono en " & cmbmoneda.GetColumnValue("Simbolo").ToString & " :"
        txtEquivalente.EditValue = 0.00
        txtTotal.EditValue = 0.00
    End Sub

    Private Sub txtmontoU_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotal.EditValueChanged

        ConversionEquivalente()
        ' ConvertiMonto(1)
    End Sub

    Sub ConversionEquivalente()
        If chktipo.EditValue = "C" Then txtEquivalente.EditValue = 0.00
        If chktipo.EditValue = "D" Then txtEquivalente.EditValue = IIf(cmbmoneda.EditValue = MonedaBase, txtTotal.EditValue, Math.Round(CDbl(txtTotal.EditValue * txtTasa.EditValue), 2))

    End Sub

    'Sub ConvertiMonto(op As Integer)
    '    If Inicio Then Exit Sub
    '    '        
    '    'If op = 1 Then txtEquivalente.EditValue = IIf(txtTasa.EditValue = 0, 0.00, CDbl(txtTotal.EditValue * txtTasa.EditValue))
    '    'If op = 2 Then txtTotal.EditValue = IIf(txtTasa.EditValue = 0, 0.00, CDbl(txtEquivalente.EditValue / txtTasa.EditValue))
    'End Sub

    Private Sub etMntto_MouseClick(sender As Object, e As MouseEventArgs) Handles etMntto.MouseClick
        Dim MttoMonto As Double = 0.00, CuentaMtto As String = ""

        iVistaSaldos.UpdateTotalSummary()
        iVistaSaldos.RefreshData()

        If chktipo.EditValue = "C" Then
            With iVistaSaldos
                For i As Integer = 0 To .DataRowCount
                    If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then
                        MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
                    End If
                Next
            End With
            '
            etMntto.Text = MttoMonto.ToString("n2")

            If MttoMonto = 0.00 Then
                XtraMsg("El Valor del Mantenimiento de Valor debe ser Mayor que Cero (0)", MessageBoxIcon.Warning)
                Exit Sub
            End If
            '
            Try
                'Buscar las Cuentas de Matto Valor
                Dim DsPlantillas As DataSet = VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles

                If MttoMonto > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                If MttoMonto < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            Catch ex As Exception
                XtraMsg("No existe Plantilla de Mantenimiento de Valor!", MessageBoxIcon.Error)
                Exit Sub
            End Try

        Else
            XtraMsg("Las Notas de Débito no contienen Deslizamiento de Moneda", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        Try
            Dim frm As New FrmDetalleRequisas

            frm.Monto = Math.Round(Math.Abs(MttoMonto), 2)
            frm.Tipo = IIf(MttoMonto > 0, "C", "D")
            frm.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date)
            frm.CompNo = NoComp
            frm.Cuenta = CuentaMtto
            frm.Mes = Fecha.DateTime.Month
            '
            frm.Mostrar(DT_Distribucion)
            DT_Distribucion.DefaultView.RowFilter = ""
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetData()
    End Sub

    Private Sub FrmNotasCreditoDebitoNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then iVistaSaldos.ShowCustomization()
    End Sub

    Private Sub txtTasa_EditValueChanged(sender As Object, e As EventArgs) Handles txtTasa.EditValueChanged

    End Sub

    Private Sub iVistaSaldos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVistaSaldos.RowCellStyle
        If e.Column.FieldName = "Monto_Mantenimiento" Then
            If iVistaSaldos.GetRowCellValue(e.RowHandle, "Facturar") Then
                If e.CellValue <> 0 Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub iVistaCuentas_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVistaCuentas.CellValueChanged

    End Sub
End Class

