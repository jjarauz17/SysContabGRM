Imports System.Linq
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class FrmComprobantesDetallesNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmComprobantesDetallesNew = Nothing

    Public Shared Function Instance() As FrmComprobantesDetallesNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmComprobantesDetallesNew
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
    Friend WithEvents cmdDetalleDistribucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Debito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Credito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CDet_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbtipocomprobante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Concepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ItemCuenta As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents vCatalogo1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemCuentas As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents vCatalogo2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckDesgloce As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTipoLiq As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckLiquidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Liqudaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbLiquidaciones As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDebito As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCredito As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etCheque As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtlNoComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblChequeNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etchequeNombre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTipo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etAnulado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lyAnulado As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblDiferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCredito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDebito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents chkImprimir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkdistribuir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyVer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbOrdenCompra As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbServicios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobantesDetallesNew))
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.FechaVencimiento = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.lblDiferencia = New DevExpress.XtraEditors.TextEdit()
        Me.chkdistribuir = New DevExpress.XtraEditors.CheckEdit()
        Me.lblCredito = New DevExpress.XtraEditors.TextEdit()
        Me.lblDebito = New DevExpress.XtraEditors.TextEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.etAnulado = New DevExpress.XtraEditors.LabelControl()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuenta = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vCatalogo1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vCatalogo2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Debito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDebito = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Credito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCredito = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Concepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CDet_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Liqudaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbOrdenCompra = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbServicios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbLiquidaciones = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbTipoLiq = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblTipo = New DevExpress.XtraEditors.LabelControl()
        Me.ckDesgloce = New DevExpress.XtraEditors.CheckEdit()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.ckLiquidar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtlNoComprobante = New DevExpress.XtraEditors.TextEdit()
        Me.lblChequeNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.txtCheque = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbtipocomprobante = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.etCheque = New DevExpress.XtraLayout.LayoutControlItem()
        Me.etchequeNombre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyAnulado = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyVer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkImprimir = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDetalleDistribucion = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.FechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDiferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdistribuir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDebito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckDesgloce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlNoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblChequeNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbtipocomprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etchequeNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyVer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.chkImprimir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(108, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Fecha.Size = New System.Drawing.Size(144, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 197
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.FechaVencimiento)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.lblDiferencia)
        Me.LayoutControl1.Controls.Add(Me.chkdistribuir)
        Me.LayoutControl1.Controls.Add(Me.lblCredito)
        Me.LayoutControl1.Controls.Add(Me.lblDebito)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.etAnulado)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.cbTipoLiq)
        Me.LayoutControl1.Controls.Add(Me.lblTipo)
        Me.LayoutControl1.Controls.Add(Me.ckDesgloce)
        Me.LayoutControl1.Controls.Add(Me.txtConsecutivo)
        Me.LayoutControl1.Controls.Add(Me.ckLiquidar)
        Me.LayoutControl1.Controls.Add(Me.txtlNoComprobante)
        Me.LayoutControl1.Controls.Add(Me.lblChequeNombre)
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.txtCheque)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.cmbtipocomprobante)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1062, 250, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(858, 711)
        Me.LayoutControl1.TabIndex = 208
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.EditValue = Nothing
        Me.FechaVencimiento.Location = New System.Drawing.Point(369, 40)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVencimiento.Properties.Appearance.Options.UseFont = True
        Me.FechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaVencimiento.Size = New System.Drawing.Size(114, 20)
        Me.FechaVencimiento.StyleController = Me.LayoutControl1
        Me.FechaVencimiento.TabIndex = 210
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 200)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Ver en Moneda Nacional"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(834, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 1035
        '
        'lblDiferencia
        '
        Me.lblDiferencia.EditValue = 0R
        Me.lblDiferencia.Location = New System.Drawing.Point(600, 669)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDiferencia.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferencia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDiferencia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lblDiferencia.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lblDiferencia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lblDiferencia.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lblDiferencia.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDiferencia.Properties.Mask.EditMask = "n2"
        Me.lblDiferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lblDiferencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lblDiferencia.Properties.ReadOnly = True
        Me.lblDiferencia.Size = New System.Drawing.Size(246, 30)
        Me.lblDiferencia.StyleController = Me.LayoutControl1
        Me.lblDiferencia.TabIndex = 1033
        '
        'chkdistribuir
        '
        Me.chkdistribuir.Location = New System.Drawing.Point(676, 12)
        Me.chkdistribuir.Name = "chkdistribuir"
        Me.chkdistribuir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdistribuir.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkdistribuir.Properties.Appearance.Options.UseFont = True
        Me.chkdistribuir.Properties.Appearance.Options.UseForeColor = True
        Me.chkdistribuir.Properties.Appearance.Options.UseTextOptions = True
        Me.chkdistribuir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.chkdistribuir.Properties.Caption = "Guardar sin distribuir"
        Me.chkdistribuir.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkdistribuir.Size = New System.Drawing.Size(170, 22)
        Me.chkdistribuir.StyleController = Me.LayoutControl1
        Me.chkdistribuir.TabIndex = 1034
        '
        'lblCredito
        '
        Me.lblCredito.EditValue = 0R
        Me.lblCredito.Location = New System.Drawing.Point(267, 669)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCredito.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredito.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCredito.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lblCredito.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lblCredito.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lblCredito.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lblCredito.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCredito.Properties.Mask.EditMask = "n2"
        Me.lblCredito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lblCredito.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lblCredito.Properties.ReadOnly = True
        Me.lblCredito.Size = New System.Drawing.Size(251, 30)
        Me.lblCredito.StyleController = Me.LayoutControl1
        Me.lblCredito.TabIndex = 1032
        '
        'lblDebito
        '
        Me.lblDebito.EditValue = 0R
        Me.lblDebito.Location = New System.Drawing.Point(12, 669)
        Me.lblDebito.Name = "lblDebito"
        Me.lblDebito.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDebito.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebito.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDebito.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lblDebito.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lblDebito.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lblDebito.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lblDebito.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDebito.Properties.Mask.EditMask = "n2"
        Me.lblDebito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lblDebito.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lblDebito.Properties.ReadOnly = True
        Me.lblDebito.Size = New System.Drawing.Size(251, 30)
        Me.lblDebito.StyleController = Me.LayoutControl1
        Me.lblDebito.TabIndex = 1031
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(108, 143)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(738, 53)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 1034
        '
        'etAnulado
        '
        Me.etAnulado.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.etAnulado.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etAnulado.Appearance.ForeColor = System.Drawing.Color.Red
        Me.etAnulado.Appearance.Options.UseBackColor = True
        Me.etAnulado.Appearance.Options.UseFont = True
        Me.etAnulado.Appearance.Options.UseForeColor = True
        Me.etAnulado.Appearance.Options.UseTextOptions = True
        Me.etAnulado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.etAnulado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etAnulado.Location = New System.Drawing.Point(12, 116)
        Me.etAnulado.Name = "etAnulado"
        Me.etAnulado.Size = New System.Drawing.Size(834, 23)
        Me.etAnulado.StyleController = Me.LayoutControl1
        Me.etAnulado.TabIndex = 1033
        Me.etAnulado.Text = "*** ANULADO ***"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 226)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemCuenta, Me.ItemCuentas, Me.cbLiquidaciones, Me.txtDebito, Me.txtCredito, Me.cbProyecto, Me.cbOrdenCompra, Me.cbServicios})
        Me.GridDetalle.Size = New System.Drawing.Size(834, 423)
        Me.GridDetalle.TabIndex = 204
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterEnabled = False
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Descripcion, Me.Debito, Me.Credito, Me.Concepto, Me.Tipo, Me.Detalle, Me.CDet_Id, Me.Liqudaciones, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsHint.ShowCellHints = False
        Me.GridView1.OptionsHint.ShowColumnHeaderHints = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Codigo
        '
        Me.Codigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.AppearanceHeader.Options.UseFont = True
        Me.Codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.Codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Codigo.Caption = "Cuenta"
        Me.Codigo.ColumnEdit = Me.ItemCuenta
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        Me.Codigo.Width = 68
        '
        'ItemCuenta
        '
        Me.ItemCuenta.AutoHeight = False
        Me.ItemCuenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuenta.Name = "ItemCuenta"
        Me.ItemCuenta.NullText = ""
        Me.ItemCuenta.PopupView = Me.vCatalogo1
        '
        'vCatalogo1
        '
        Me.vCatalogo1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo1.Name = "vCatalogo1"
        Me.vCatalogo1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo1.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo1.OptionsView.ShowGroupPanel = False
        '
        'Descripcion
        '
        Me.Descripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.AppearanceHeader.Options.UseFont = True
        Me.Descripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Descripcion.Caption = "Nombre"
        Me.Descripcion.ColumnEdit = Me.ItemCuentas
        Me.Descripcion.FieldName = "Codigo"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 155
        '
        'ItemCuentas
        '
        Me.ItemCuentas.AutoHeight = False
        Me.ItemCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCuentas.Name = "ItemCuentas"
        Me.ItemCuentas.NullText = ""
        Me.ItemCuentas.PopupView = Me.vCatalogo2
        '
        'vCatalogo2
        '
        Me.vCatalogo2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo2.Name = "vCatalogo2"
        Me.vCatalogo2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo2.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo2.OptionsView.ShowGroupPanel = False
        '
        'Debito
        '
        Me.Debito.AppearanceCell.Options.UseTextOptions = True
        Me.Debito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Debito.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Debito.AppearanceHeader.Options.UseFont = True
        Me.Debito.AppearanceHeader.Options.UseTextOptions = True
        Me.Debito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Debito.Caption = "Debito"
        Me.Debito.ColumnEdit = Me.txtDebito
        Me.Debito.FieldName = "Debito"
        Me.Debito.Name = "Debito"
        Me.Debito.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito", "{0:n2}")})
        Me.Debito.Visible = True
        Me.Debito.VisibleIndex = 2
        Me.Debito.Width = 78
        '
        'txtDebito
        '
        Me.txtDebito.AutoHeight = False
        Me.txtDebito.Mask.EditMask = "n2"
        Me.txtDebito.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebito.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebito.Name = "txtDebito"
        '
        'Credito
        '
        Me.Credito.AppearanceCell.Options.UseTextOptions = True
        Me.Credito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Credito.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credito.AppearanceHeader.Options.UseFont = True
        Me.Credito.AppearanceHeader.Options.UseTextOptions = True
        Me.Credito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Credito.Caption = "Credito"
        Me.Credito.ColumnEdit = Me.txtCredito
        Me.Credito.FieldName = "Credito"
        Me.Credito.Name = "Credito"
        Me.Credito.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", "{0:n2}")})
        Me.Credito.Visible = True
        Me.Credito.VisibleIndex = 3
        Me.Credito.Width = 78
        '
        'txtCredito
        '
        Me.txtCredito.AutoHeight = False
        Me.txtCredito.Mask.EditMask = "n2"
        Me.txtCredito.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredito.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredito.Name = "txtCredito"
        '
        'Concepto
        '
        Me.Concepto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concepto.AppearanceHeader.Options.UseFont = True
        Me.Concepto.AppearanceHeader.Options.UseTextOptions = True
        Me.Concepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Concepto.Caption = "Concepto"
        Me.Concepto.FieldName = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Visible = True
        Me.Concepto.VisibleIndex = 4
        Me.Concepto.Width = 137
        '
        'Tipo
        '
        Me.Tipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tipo.AppearanceHeader.Options.UseFont = True
        Me.Tipo.AppearanceHeader.Options.UseTextOptions = True
        Me.Tipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tipo.Caption = "Tipo"
        Me.Tipo.FieldName = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Detalle
        '
        Me.Detalle.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Detalle.AppearanceHeader.Options.UseFont = True
        Me.Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Detalle.Caption = "Detalle"
        Me.Detalle.FieldName = "Detalle"
        Me.Detalle.Name = "Detalle"
        '
        'CDet_Id
        '
        Me.CDet_Id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CDet_Id.AppearanceHeader.Options.UseFont = True
        Me.CDet_Id.AppearanceHeader.Options.UseTextOptions = True
        Me.CDet_Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CDet_Id.Caption = "CDet_Id"
        Me.CDet_Id.FieldName = "CDet_Id"
        Me.CDet_Id.Name = "CDet_Id"
        '
        'Liqudaciones
        '
        Me.Liqudaciones.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Liqudaciones.AppearanceHeader.Options.UseFont = True
        Me.Liqudaciones.AppearanceHeader.Options.UseTextOptions = True
        Me.Liqudaciones.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Liqudaciones.Caption = "No. Pedido"
        Me.Liqudaciones.ColumnEdit = Me.cbOrdenCompra
        Me.Liqudaciones.FieldName = "IdOrdenCompra"
        Me.Liqudaciones.Name = "Liqudaciones"
        Me.Liqudaciones.Visible = True
        Me.Liqudaciones.VisibleIndex = 7
        Me.Liqudaciones.Width = 71
        '
        'cbOrdenCompra
        '
        Me.cbOrdenCompra.AutoHeight = False
        Me.cbOrdenCompra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenCompra.Name = "cbOrdenCompra"
        Me.cbOrdenCompra.PopupView = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Proyecto"
        Me.GridColumn1.ColumnEdit = Me.cbProyecto
        Me.GridColumn1.FieldName = "IdProyecto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 120
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoHeight = False
        Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.NullText = "[Proyecto]"
        Me.cbProyecto.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Factura"
        Me.GridColumn2.FieldName = "Factura"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 58
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Conciliado"
        Me.GridColumn3.FieldName = "Conciliado"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 51
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Tipo Retención"
        Me.GridColumn4.ColumnEdit = Me.cbServicios
        Me.GridColumn4.FieldName = "Retencion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 9
        '
        'cbServicios
        '
        Me.cbServicios.AutoHeight = False
        Me.cbServicios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.NullText = "[Tipo de Retencion]"
        '
        'cbLiquidaciones
        '
        Me.cbLiquidaciones.AutoHeight = False
        Me.cbLiquidaciones.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLiquidaciones.Name = "cbLiquidaciones"
        Me.cbLiquidaciones.NullText = ""
        '
        'cbTipoLiq
        '
        Me.cbTipoLiq.EditValue = "[Seleccione ]"
        Me.cbTipoLiq.Enabled = False
        Me.cbTipoLiq.Location = New System.Drawing.Point(676, 92)
        Me.cbTipoLiq.Name = "cbTipoLiq"
        Me.cbTipoLiq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoLiq.Properties.Items.AddRange(New Object() {"[Seleccione]", "Tránsito", "InBond", "Final"})
        Me.cbTipoLiq.Properties.NullText = "-- Seleccione --"
        Me.cbTipoLiq.Size = New System.Drawing.Size(170, 20)
        Me.cbTipoLiq.StyleController = Me.LayoutControl1
        Me.cbTipoLiq.TabIndex = 163
        '
        'lblTipo
        '
        Me.lblTipo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTipo.Appearance.Options.UseFont = True
        Me.lblTipo.Appearance.Options.UseForeColor = True
        Me.lblTipo.Appearance.Options.UseTextOptions = True
        Me.lblTipo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTipo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipo.Location = New System.Drawing.Point(557, 66)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(115, 16)
        Me.lblTipo.StyleController = Me.LayoutControl1
        Me.lblTipo.TabIndex = 1032
        '
        'ckDesgloce
        '
        Me.ckDesgloce.Enabled = False
        Me.ckDesgloce.Location = New System.Drawing.Point(676, 66)
        Me.ckDesgloce.Name = "ckDesgloce"
        Me.ckDesgloce.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDesgloce.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckDesgloce.Properties.Appearance.Options.UseFont = True
        Me.ckDesgloce.Properties.Appearance.Options.UseForeColor = True
        Me.ckDesgloce.Properties.Caption = "Desgloce en Litros"
        Me.ckDesgloce.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckDesgloce.Size = New System.Drawing.Size(170, 22)
        Me.ckDesgloce.StyleController = Me.LayoutControl1
        Me.ckDesgloce.TabIndex = 1020
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(530, 12)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsecutivo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtConsecutivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtConsecutivo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtConsecutivo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtConsecutivo.Properties.MaxLength = 50
        Me.txtConsecutivo.Size = New System.Drawing.Size(142, 22)
        Me.txtConsecutivo.StyleController = Me.LayoutControl1
        Me.txtConsecutivo.TabIndex = 1031
        '
        'ckLiquidar
        '
        Me.ckLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckLiquidar.Enabled = False
        Me.ckLiquidar.Location = New System.Drawing.Point(676, 40)
        Me.ckLiquidar.Name = "ckLiquidar"
        Me.ckLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckLiquidar.Properties.Appearance.Options.UseFont = True
        Me.ckLiquidar.Properties.Appearance.Options.UseForeColor = True
        Me.ckLiquidar.Properties.Caption = "Asignado a Liquidación"
        Me.ckLiquidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckLiquidar.Properties.ReadOnly = True
        Me.ckLiquidar.Size = New System.Drawing.Size(170, 22)
        Me.ckLiquidar.StyleController = Me.LayoutControl1
        Me.ckLiquidar.TabIndex = 1025
        '
        'txtlNoComprobante
        '
        Me.txtlNoComprobante.EditValue = 0R
        Me.txtlNoComprobante.Location = New System.Drawing.Point(352, 12)
        Me.txtlNoComprobante.Name = "txtlNoComprobante"
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtlNoComprobante.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtlNoComprobante.Properties.Mask.EditMask = "d"
        Me.txtlNoComprobante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtlNoComprobante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtlNoComprobante.Properties.ReadOnly = True
        Me.txtlNoComprobante.Size = New System.Drawing.Size(78, 24)
        Me.txtlNoComprobante.StyleController = Me.LayoutControl1
        Me.txtlNoComprobante.TabIndex = 1030
        '
        'lblChequeNombre
        '
        Me.lblChequeNombre.Location = New System.Drawing.Point(378, 92)
        Me.lblChequeNombre.Name = "lblChequeNombre"
        Me.lblChequeNombre.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblChequeNombre.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNombre.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lblChequeNombre.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lblChequeNombre.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lblChequeNombre.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lblChequeNombre.Properties.ReadOnly = True
        Me.lblChequeNombre.Size = New System.Drawing.Size(294, 20)
        Me.lblChequeNombre.StyleController = Me.LayoutControl1
        Me.lblChequeNombre.TabIndex = 1029
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.EnterMoveNextControl = True
        Me.txtTasa.Location = New System.Drawing.Point(583, 40)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTasa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        Me.txtTasa.Size = New System.Drawing.Size(89, 22)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 1029
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(108, 92)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCheque.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCheque.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCheque.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCheque.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCheque.Properties.ReadOnly = True
        Me.txtCheque.Size = New System.Drawing.Size(170, 20)
        Me.txtCheque.StyleController = Me.LayoutControl1
        Me.txtCheque.TabIndex = 1028
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(108, 40)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMoneda.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cbMoneda.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cbMoneda.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbMoneda.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cbMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbMoneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbMoneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(161, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 1027
        '
        'cmbtipocomprobante
        '
        Me.cmbtipocomprobante.Location = New System.Drawing.Point(108, 66)
        Me.cmbtipocomprobante.Name = "cmbtipocomprobante"
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbtipocomprobante.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbtipocomprobante.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbtipocomprobante.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmbtipocomprobante.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cmbtipocomprobante.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cmbtipocomprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtipocomprobante.Properties.NullText = ""
        Me.cmbtipocomprobante.Properties.ShowFooter = False
        Me.cmbtipocomprobante.Properties.ShowHeader = False
        Me.cmbtipocomprobante.Size = New System.Drawing.Size(445, 20)
        Me.cmbtipocomprobante.StyleController = Me.LayoutControl1
        Me.cmbtipocomprobante.TabIndex = 206
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.etCheque, Me.etchequeNombre, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem10, Me.LayoutControlItem14, Me.lyAnulado, Me.LayoutControlItem15, Me.LayoutControlItem2, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem8, Me.EmptySpaceItem4, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.lyVer, Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(858, 711)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Fecha
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(244, 28)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMoneda
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem3.Text = "Moneda:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbtipocomprobante
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(545, 26)
        Me.LayoutControlItem4.Text = "Tipo Comprobante:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(93, 13)
        '
        'etCheque
        '
        Me.etCheque.Control = Me.txtCheque
        Me.etCheque.Location = New System.Drawing.Point(0, 80)
        Me.etCheque.Name = "etCheque"
        Me.etCheque.Size = New System.Drawing.Size(270, 24)
        Me.etCheque.Text = "Documento:"
        Me.etCheque.TextSize = New System.Drawing.Size(93, 13)
        '
        'etchequeNombre
        '
        Me.etchequeNombre.Control = Me.lblChequeNombre
        Me.etchequeNombre.Location = New System.Drawing.Point(270, 80)
        Me.etchequeNombre.Name = "etchequeNombre"
        Me.etchequeNombre.Size = New System.Drawing.Size(394, 24)
        Me.etchequeNombre.Text = "Cheque a Nombre:"
        Me.etchequeNombre.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtTasa
        Me.LayoutControlItem6.Location = New System.Drawing.Point(475, 28)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(189, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(189, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(189, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Tasa Cambio:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.lblTipo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(545, 54)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtlNoComprobante
        Me.LayoutControlItem5.Location = New System.Drawing.Point(244, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(178, 28)
        Me.LayoutControlItem5.Text = "#Comprobante:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtConsecutivo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(422, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(242, 28)
        Me.LayoutControlItem7.Text = "#Consecutivo:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.ckLiquidar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(664, 28)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.GridDetalle
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 214)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(838, 427)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'lyAnulado
        '
        Me.lyAnulado.Control = Me.etAnulado
        Me.lyAnulado.Location = New System.Drawing.Point(0, 104)
        Me.lyAnulado.Name = "lyAnulado"
        Me.lyAnulado.Size = New System.Drawing.Size(838, 27)
        Me.lyAnulado.TextSize = New System.Drawing.Size(0, 0)
        Me.lyAnulado.TextVisible = False
        Me.lyAnulado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtConcepto
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(0, 57)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(110, 57)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(838, 57)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Concepto:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lblDebito
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 641)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Débito"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.lblCredito
        Me.LayoutControlItem16.Location = New System.Drawing.Point(255, 641)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(255, 50)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Crédito"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.lblDiferencia
        Me.LayoutControlItem17.Location = New System.Drawing.Point(588, 641)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(250, 50)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(250, 50)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(250, 50)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Diferencia"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkdistribuir
        Me.LayoutControlItem8.Location = New System.Drawing.Point(664, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(510, 641)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(78, 50)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cbTipoLiq
        Me.LayoutControlItem13.Location = New System.Drawing.Point(664, 80)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.ckDesgloce
        Me.LayoutControlItem11.Location = New System.Drawing.Point(664, 54)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyVer
        '
        Me.lyVer.Control = Me.CheckEdit1
        Me.lyVer.Location = New System.Drawing.Point(0, 188)
        Me.lyVer.Name = "lyVer"
        Me.lyVer.Size = New System.Drawing.Size(838, 26)
        Me.lyVer.TextSize = New System.Drawing.Size(0, 0)
        Me.lyVer.TextVisible = False
        Me.lyVer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.FechaVencimiento
        Me.LayoutControlItem12.Location = New System.Drawing.Point(261, 28)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Fecha Vencimiento:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(93, 13)
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExportar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bExportar.Appearance.Options.UseFont = True
        Me.bExportar.Appearance.Options.UseForeColor = True
        Me.bExportar.Appearance.Options.UseTextOptions = True
        Me.bExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 594)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(119, 36)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 118
        Me.bExportar.Text = "E&xportar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.chkImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.cmdAnular)
        Me.LayoutControl2.Controls.Add(Me.cmdDetalleDistribucion)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(143, 682)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'chkImprimir
        '
        Me.chkImprimir.Location = New System.Drawing.Point(12, 92)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimir.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkImprimir.Properties.Appearance.Options.UseFont = True
        Me.chkImprimir.Properties.Appearance.Options.UseForeColor = True
        Me.chkImprimir.Properties.Appearance.Options.UseTextOptions = True
        Me.chkImprimir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.chkImprimir.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkImprimir.Properties.Caption = "Imprimir con  distribución"
        Me.chkImprimir.Size = New System.Drawing.Size(118, 32)
        Me.chkImprimir.StyleController = Me.LayoutControl2
        Me.chkImprimir.TabIndex = 1033
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 634)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(119, 36)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 111
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAnular
        '
        Me.cmdAnular.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnular.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAnular.Appearance.Options.UseFont = True
        Me.cmdAnular.Appearance.Options.UseForeColor = True
        Me.cmdAnular.ImageOptions.Image = CType(resources.GetObject("cmdAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAnular.Location = New System.Drawing.Point(12, 132)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(119, 36)
        Me.cmdAnular.StyleController = Me.LayoutControl2
        Me.cmdAnular.TabIndex = 115
        Me.cmdAnular.Text = "A&nular"
        '
        'cmdDetalleDistribucion
        '
        Me.cmdDetalleDistribucion.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetalleDistribucion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdDetalleDistribucion.Appearance.Options.UseFont = True
        Me.cmdDetalleDistribucion.Appearance.Options.UseForeColor = True
        Me.cmdDetalleDistribucion.Appearance.Options.UseTextOptions = True
        Me.cmdDetalleDistribucion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDetalleDistribucion.ImageOptions.Image = CType(resources.GetObject("cmdDetalleDistribucion.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDetalleDistribucion.Location = New System.Drawing.Point(12, 212)
        Me.cmdDetalleDistribucion.Name = "cmdDetalleDistribucion"
        Me.cmdDetalleDistribucion.Size = New System.Drawing.Size(118, 38)
        Me.cmdDetalleDistribucion.StyleController = Me.LayoutControl2
        Me.cmdDetalleDistribucion.TabIndex = 116
        Me.cmdDetalleDistribucion.Text = "&Ver Distribución"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 172)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 117
        Me.SimpleButton1.Text = "&Actualizar"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Appearance.Options.UseForeColor = True
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 568)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(119, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 112
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Appearance.Options.UseForeColor = True
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 52)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(119, 36)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 113
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(119, 36)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 114
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem22, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.EmptySpaceItem2, Me.LayoutControlItem21, Me.LayoutControlItem23, Me.LayoutControlItem26, Me.EmptySpaceItem3, Me.LayoutControlItem20})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(143, 682)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdAceptar
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdImprimir
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.SimpleButton1
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.bExportar
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 582)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmdSalir
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 622)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 242)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(123, 314)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cmdAyuda
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 556)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(123, 26)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        Me.LayoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmdDetalleDistribucion
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 200)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.chkImprimir
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(122, 23)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(122, 23)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 103)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(123, 17)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdAnular
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(123, 40)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("0ae3b628-83e1-4abf-a56e-65f507847b2a")
        Me.DockPanel1.Location = New System.Drawing.Point(858, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 711)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(143, 682)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmComprobantesDetallesNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmComprobantesDetallesNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes Detalles"
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.FechaVencimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDiferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdistribuir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDebito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckDesgloce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlNoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblChequeNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbtipocomprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etchequeNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyVer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.chkImprimir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Variables"
    Private comp As New VB.SysContab.ComprobanteDB
    Private compDet As New VB.SysContab.ComprobantesDetails
    Public Periodo As Integer
    Private Moneda As String
    Private Factura As String
    Private Recibo As String
    Private Pagara As String
    Private FechaPago As Date
    Private FormaPago As String
    Private RUC As String
    Private TipoX As String
    Private Factura1 As String
    Private TasaCambio As Double
    Private DT As DataTable
    Private Datas As New DataTable("Detalle")
    Private Temp As Boolean = False
    Private NoDelete As Boolean = False
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Public ComprobanteID, TipoLiq As Integer

#End Region

    Dim Anulado As Boolean = False
    Public Fecha1 As DateTime
    Dim Cambios As Integer
    Dim DataLiq As New DataTable
    Dim ModificarComp As Boolean = False

    Private _Edit As Boolean,
            _EditCierre As Boolean

    Public Property Edit() As Boolean
        Get
            Return _Edit
        End Get
        Set(ByVal value As Boolean)
            _Edit = value
        End Set
    End Property


    Public Property EditCierre() As Boolean
        Get
            Return _EditCierre
        End Get
        Set(ByVal value As Boolean)
            _EditCierre = value
        End Set
    End Property


    Private Sub FrmComprobantesDetallesNew_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Si se agregaron lineas o quitaron lineas al comprobante,
        'Preguntar si quiere guardar los cambios.
        If Cambios <> GridView1.DataRowCount Then

            'If XtraMsg2("Se han encontrado cambios sin guardar, Desea Registrarlos?") Then
            '    e.Cancel = True
            '    If Validar() Then
            '        If GuardarComprobante() Then Distribuir()
            '    Else
            '        e.Cancel = True
            '    End If
            'End If

            If Not GuardarCambioasAlSalir() Then e.Cancel = True

        Else
            Dim _data As DataTable =
                Datas.GetChanges(DataRowState.Modified)

            If Not _data Is Nothing Then

                If Not GuardarCambioasAlSalir() Then e.Cancel = True

            End If

        End If
    End Sub

    Function GuardarCambioasAlSalir() As Boolean

        If XtraMsg2("Se han encontrado cambios sin guardar, Desea Registrarlos?") Then

            If Validar() Then
                If GuardarComprobante() Then
                    Distribuir()
                    Return True
                End If
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If

    End Function

    Private Sub FrmComprobantesDetallesNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarCombos()

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("ComprNO")
        'Variables.Add("Empresa")
        'Variables.Add("PerID")
        'Variables.Add("Fecha1")

        'Datos.Add(txtlNoComprobante.EditValue)
        'Datos.Add(EmpresaActual)
        'Datos.Add(Periodo)
        'Datos.Add(Fecha.DateTime.Date)
        '
        compDet = comp.GetComprobanteDetails(
            txtlNoComprobante.EditValue,
            Periodo,
            Fecha.DateTime.Date)

        'Dim DTROL As DataTable = ObtieneDatos("_REST_GetAccionesUsuario " & Usr_Rol & "," & IdRecursoComp & "")
        'For i As Integer = 0 To DTROL.Rows.Count - 1
        '    If DTROL.Rows.Item(i)("Control") = "Modificar" Then ModificarComp = True
        'Next

        If compDet.Fecha Is Nothing Then
            Exit Sub
        End If

        GetData()

        Fecha.EditValue = CDate(compDet.Fecha).Date
        FechaVencimiento.DateTime = CDate(compDet.FechaPago)

        If compDet.Comp <> 0 And compDet.Comp <> 1 And
            compDet.Comp <> 2 And compDet.Comp <> 10 And
            compDet.Comp <> 12 And compDet.Comp <> 15 And
            compDet.Comp <> 17 Then
            'Validar para no cambiar la Fecha a Otro Mes.
            Fecha.Properties.MinValue = New DateTime(CDate(compDet.Fecha).Year, CDate(compDet.Fecha).Month, 1).Date
            Fecha.Properties.MaxValue = UltimoDiaDelMes(CDate(compDet.Fecha).Date)
        End If

        txtConcepto.Text = compDet.Concepto
        lblTipo.Text = compDet.Tipo
        '
        cbMoneda.EditValue = compDet.Moneda
        cbMoneda.Properties.ReadOnly = True
        cmbtipocomprobante.EditValue = CInt(compDet.Tipo1)
        Moneda = compDet.Moneda
        TasaCambio = compDet.TasaCambio
        '
        lblChequeNombre.Text = compDet.ChequeNombre
        Factura = compDet.Factura
        Recibo = compDet.Recibo
        Pagara = compDet.Pagara.ToString
        FechaPago = CDate(compDet.FechaPago).Date
        FormaPago = compDet.FormaPago
        RUC = compDet.Ruc
        TipoX = compDet.TipoX
        txtConsecutivo.Text = compDet.Consecutivo
        Factura1 = compDet.Factura1
        lblDiferencia.EditValue = Math.Round(lblDebito.EditValue - lblCredito.EditValue, 2)  '' CDbl(CDbl(Me.lblDebito.Text) - CDbl(Me.lblCredito.Text)).ToString(Round)

        txtCheque.Text = compDet.Cheque
        '
        'Mostrar Tasa de Cambio
        Try
            If compDet.Moneda = MonedaBase Then
                Me.txtTasa.EditValue = ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ", '" & CDate(compDet.Fecha).Date & "')").Rows.Item(0)(0)
                Me.txtTasa.Properties.ReadOnly = True
            Else
                Me.txtTasa.EditValue = TasaCambio
                Me.txtTasa.Properties.ReadOnly = False
                lyVer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            End If
        Catch ex As Exception
        End Try
        '
        If txtCheque.Text = "0" Or txtCheque.Text = "" Then
            Dim Prov As New VB.SysContab.ProveedoresDB
            txtCheque.Text = compDet.Factura1
            lblChequeNombre.Text = Prov.GetDetails(compDet.Proveedor).Nombre

            etchequeNombre.Text = "Proveedor: "
        Else
            If compDet.Comp = 5 Then etchequeNombre.Text = "Cliente: "
            If compDet.Comp <> 5 Then etchequeNombre.Text = "Cheque a Nombre: "
            'Me.etCheque.Visible = True
            'Me.lblCheque.Visible = True
            'Me.lblChequeNombre.Visible = True
            'Me.etchequeNombre.Visible = True
        End If

        Dim Registros As Integer
        Registros = ComprobanteDB.ComprobanteAnularBuscar(txtlNoComprobante.EditValue, Periodo, Fecha.DateTime.Date)

        '//*******  VALIDAR SI ESTA ANULADO
        If Registros > 0 Then
            If ModificarComp = False Then
                Anulado = True
                'GridView1.OptionsBehavior.Editable = False
                'GridView1.Columns("Credito").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Credito").OptionsColumn.AllowFocus = False
                'GridView1.Columns("Debito").OptionsColumn.AllowEdit = False
                'GridView1.Columns("Debito").OptionsColumn.AllowFocus = False
                NoDelete = False
                txtConcepto.ReadOnly = True
                Fecha.Enabled = False
                'cmbtipocomprobante.Enabled = False
                cmbtipocomprobante.Properties.ReadOnly = True
                Me.cmdAceptar.Enabled = False
                cmdAnular.Enabled = False
                'etAnulado.Visible = True
                'lyAnulado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            End If
            lyAnulado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            GridView1.OptionsBehavior.Editable = False
        Else
            GridView1.OptionsBehavior.Editable = True
        End If
        '
        'Cargar Distribucion del Comprobante
        DT_Distribucion =
            CargaDistribucion(
            Fecha.DateTime.Month,
            txtlNoComprobante.EditValue,
            Periodo)

        Totales()

        Cambios = GridView1.DataRowCount

        'If VerifyLiqOption() Then
        '    ckLiquidar.Enabled = True
        '    If TipoLiq > 0 Then
        '        ckLiquidar.Checked = True
        '        GridView1.Columns("MtID").Visible = True

        '        'gbLiquidacion.Visible = True
        '        'PanelControl1.Visible = True

        '        ckDesgloce.Enabled = True
        '        cbTipoLiq.Enabled = True

        '        cbTipoLiq.SelectedIndex = TipoLiq
        '        ckDesgloce.Checked = Datas.Rows(0).Item("Desgloce")
        '        cbLiquidaciones.DataSource = ObtieneDatos("SPJLiqcbTipo " & TipoLiq & "," & EmpresaActual)
        '        cbLiquidaciones.ValueMember = "LiqID"
        '        cbLiquidaciones.DisplayMember = "NoOrden"
        '        cbLiquidaciones.PopulateColumns()
        '        cbLiquidaciones.Columns("LiqID").Visible = False : cbLiquidaciones.Columns("CuentaTransito").Visible = False
        '        DataLiq = ProcedureParameters(Datos, Variables, "SP_ComprobantesDetails")
        '    End If
        'End If

        VerTipoComprobante()
    End Sub


    Sub CargarCombos()

        cmbtipocomprobante.Properties.DataSource = ComprobanteDB.GetTiposComprobantes(0).Tables("TipoComprobantes")
        cmbtipocomprobante.Properties.ValueMember = "TipComp_Id"
        cmbtipocomprobante.Properties.DisplayMember = "TipComp_Nombre"
        cmbtipocomprobante.Properties.PopulateColumns()
        cmbtipocomprobante.Properties.Columns(0).Visible = False
        cmbtipocomprobante.Properties.Columns(1).Visible = False
        cmbtipocomprobante.Properties.Columns(3).Visible = False
        cmbtipocomprobante.Properties.Columns(4).Visible = False
        cmbtipocomprobante.Properties.Columns(5).Visible = False
        '
        GetMonedas(Me.cbMoneda)
        '
        CargarCatalogo()

        RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 5, 6, 7, 8)
        RepositorySearchLook(cbOrdenCompra, VB.SysContab.Ordenes_ComprasDB.FillComboLiquidacion(), "Orden Compra", "IdOrden", 0)

        'DT = ObtieneDatos("SP_CatalogoList 'A'," & EmpresaActual)
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
        'ItemCuenta.PopupWidth = 500
        'ItemCuentas.PopupWidth = 500
    End Sub

    Sub CargarCatalogo()
        DT = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)

        Me.ItemCuenta.DataSource = DT.DefaultView
        Me.ItemCuenta.ValueMember = "Cuenta"
        Me.ItemCuenta.DisplayMember = "Cuenta"
        Me.ItemCuenta.PopupFormMinSize = New Point(Me.GridDetalle.Width / 1.3, 0)
        Me.ItemCuenta.PopulateViewColumns()
        'Me.vCatalogo1.PopulateColumns()
        FormatoGrid(Me.vCatalogo1)

        Me.vCatalogo1.Columns("Display").Visible = False
        Me.vCatalogo1.Columns("Cuenta").VisibleIndex = 0
        Me.vCatalogo1.Columns("Nombre").VisibleIndex = 1
        Me.vCatalogo1.Columns("NombreCompleto").VisibleIndex = 2
        Me.vCatalogo1.BestFitColumns()

        Me.ItemCuentas.DataSource = DT.DefaultView
        Me.ItemCuentas.ValueMember = "Cuenta"
        Me.ItemCuentas.DisplayMember = "Nombre"
        Me.ItemCuentas.PopupFormMinSize = New Point(Me.GridDetalle.Width / 1.3, 0)
        Me.ItemCuentas.PopulateViewColumns()
        'Me.vCatalogo2.PopulateColumns()
        FormatoGrid(Me.vCatalogo2)

        Me.vCatalogo2.Columns("Display").Visible = False
        Me.vCatalogo2.Columns("Cuenta").VisibleIndex = 0
        Me.vCatalogo2.Columns("Nombre").VisibleIndex = 1
        Me.vCatalogo2.Columns("NombreCompleto").VisibleIndex = 2
        Me.vCatalogo2.BestFitColumns()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        Dim Registros As Integer
        Registros = ComprobanteDB.ComprobanteAnularBuscar(txtlNoComprobante.EditValue, Periodo, Fecha.DateTime.Date)

        If Registros > 0 Then
            XtraMsg("El comprobante ya fue anulado", MessageBoxIcon.Error)
            Exit Sub
        End If
        ''Si es una factura de compra
        'If compDet.Factura <> "" Then
        '    If compDet.Proveedor <> "0" And compDet.Proveedor <> "" Then
        '        MsgBox("No se puede borrar un comprobante de Factura de Compra, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
        '        Exit Sub
        '    Else
        '        If compDet.TipoX <> "0" Then
        '            MsgBox("No se puede borrar un comprobante de Factura de Venta, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
        '            Exit Sub
        '        End If
        '    End If
        'End If

        'Verificar el Origen del Comprobante, para saber si se puede anular
        If compDet.TipoX = 0 Then
            XtraMsg("No se puede Aular este Comprobante, vaya el módulo correspondiente y anule el Documento fuente", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2("¿Esta seguro que desea anular el comprobante No.: " & txtlNoComprobante.EditValue & " de la fecha: " & Fecha.DateTime.Date) Then
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        Try
            ComprobanteDB.ComprobanteAnular(txtlNoComprobante.EditValue, Periodo, Fecha.DateTime.Date)

            ComprobanteDB.CancelarFactura(compDet.Factura1, compDet.Proveedor, 0)

            ComprobanteDB.PagosFacturasBorrar(txtlNoComprobante.EditValue, Fecha.DateTime.Month, Periodo)

            GridView1.OptionsBehavior.Editable = False
            Me.txtConcepto.ReadOnly = True
            Fecha.Enabled = False
            'cmbtipocomprobante.Enabled = False
            cmbtipocomprobante.Properties.ReadOnly = True
            Me.cmdAceptar.Enabled = False
            Me.cmdAnular.Enabled = False
            ' Me.etAnulado.Visible = True
            lyAnulado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            '------------------------------
            '------------------------------
            EliminaDistribucion(txtlNoComprobante.EditValue, Periodo, Fecha.DateTime.Month, True)
            '------------------------------
            '------------------------------
            Rutinas.okTransaccion()

            Dim f As frmComprobantes = frmComprobantes.Instance()
            f.Buscar()
            '
            Me.Close()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Rutinas.ErrorTransaccion()
            Exit Sub
        End Try

    End Sub

    Private Sub cmdDetalleDistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalleDistribucion.Click
        Dim f As New FrmEstadoResultadosDetallesDistribucion
        f.Text = "Detalles de Distribución"
        f.StartPosition = FormStartPosition.CenterParent
        f.Grid.Parent = f
        f.Grid.Dock = DockStyle.Fill
        Dim a As String
        Dim Ds As New DataSet
        Ds = VB.SysContab.DistribucionDB.GetData(txtlNoComprobante.EditValue,
             Periodo, Fecha.DateTime.Date, Moneda)
        f.Grid.DataSource = Ds.Tables(0)
        FormatoGridNew(f.GridView2, 2, 0, False, False, False)
        f.Width = 1024
        f.Height = 400
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub GridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDetalle.KeyDown
        If e.KeyCode = Keys.Delete And GridView1.OptionsBehavior.Editable And Not NoDelete Then GridView1.DeleteRow(GridView1.FocusedRowHandle)
    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        If Not Temp Then
            If IsNull(GridView1.GetRowCellValue(e.RowHandle, "Credito"), 0) = 0 And IsNull(GridView1.GetRowCellValue(e.RowHandle, "Debito"), 0) = 0 And Anulado = False Then
                e.ErrorText = "Debe haber al menos un movimiento de debito o credito" & vbCrLf
                e.Valid = False
            End If
            If IsNull(GridView1.GetRowCellValue(e.RowHandle, "Codigo"), "") = "" Then
                e.ErrorText = "Seleccione la cuenta contable" & vbCrLf
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If GridView1.FocusedColumn.FieldName = "Debito" And IsNull(GridView1.GetRowCellValue(e.RowHandle, "Credito"), 0) > 0 Then GridView1.SetRowCellValue(e.RowHandle, "Debito", 0)
        If GridView1.FocusedColumn.FieldName = "Credito" And IsNull(GridView1.GetRowCellValue(e.RowHandle, "Debito"), 0) > 0 Then GridView1.SetRowCellValue(e.RowHandle, "Credito", 0)
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Totales()
        CargarCatalogo()
    End Sub

    Private Sub Totales()
        GridView1.UpdateSummary()

        lblDebito.EditValue = CDbl(GridView1.Columns("Debito").SummaryItem.SummaryValue)
        lblCredito.EditValue = CDbl(GridView1.Columns("Credito").SummaryItem.SummaryValue)
        lblDiferencia.EditValue = Math.Round(lblDebito.EditValue - lblCredito.EditValue, 2)

        'lblCredito.EditValue = Format(IsNull(GridView1.Columns("Credito").SummaryItem.SummaryValue, 0), "n2")
        'lblDebito.EditValue = Format(IsNull(GridView1.Columns("Debito").SummaryItem.SummaryValue, 0), "n2")
        'lblDiferencia.EditValue = Format(CDbl(lblDebito.Text) - CDbl(lblCredito.Text), "n2")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim ValorLetras As String = VB.SysContab.Rutinas.Letras(CDbl(lblDebito.Text).ToString(Round))
        'Dim fReportes As New frmReportes
        'Dim rFactura As New rptComprobante
        'Dim Ds As New DataSet
        'Ds = comp.ImprimirCombrobante(lblNoComprobante.Text, Periodo, ValorLetras, Fecha.DateTime.Date, CDbl(lblDebito.Text))
        'Ds.WriteXml(Application.StartupPath & "\xml\rComprobante.xml", XmlWriteMode.WriteSchema)
        'rFactura.Database.Tables("ComprobantesImpreso").Location = Application.StartupPath & "\xml\rComprobante.xml"
        'rFactura.Database.Tables("ComprobantesImpresoDetalle").Location = Application.StartupPath & "\xml\rComprobante.xml"
        'fReportes.crvReportes.ReportSource = rFactura
        'fReportes.crvReportes.Zoom(91)
        'fReportes.Show()

        ComprobanteDB.ImprimirComprobante(
                txtlNoComprobante.EditValue,
                Periodo,
                Fecha.DateTime.Date)

        'ImprimirComprobante()
    End Sub

    Sub ImprimirComprobante()
        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

        '    Temp = True
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptComprobante.repx"

        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        ShowSplash("Imprimiendo...")
        '
        Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")


        Dim DSComp As New DataSet

        Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure

        DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
        DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

        DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
        DA.SelectCommand.Parameters("@ComprNO").Value = txtlNoComprobante.EditValue
        DA.SelectCommand.Parameters("@PerID").Value = Periodo
        DA.SelectCommand.Parameters("@Fecha").Value = Fecha.DateTime.Date

        DA.Fill(DSComp, "Comprobantes")

        Dim DTDistrubucion As DataTable =
            ObtieneDatos("JAR_GetComprobanteDistribucion",
                         txtlNoComprobante.EditValue,
                         Periodo,
                         Fecha.DateTime.Date.Month,
                         EmpresaActual)

        Dim rptDistribucin As New rptComprobanteDistribucion
        rptDistribucin.DataSource = DTDistrubucion

        Dim rpt As rptComprobantesALL

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
        Else
            rpt = New rptComprobantesALL
        End If

        rpt.ver = True
        rpt.XrSubreport1.ReportSource = rptDistribucin
        rpt.gfDistribucion.Visible = chkImprimir.Checked
        'rpt.DataSource = DSComp.Tables(0)

        VistaPreviaDX(rpt,
                      DSComp.Tables(0),
                      "Comprobante No. " & txtlNoComprobante.Text)
        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub GridDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDetalle.DoubleClick
        If IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo"), "") = "" Or
        IIf(IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Debito"), 0.00) = 0.00, IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"), 0.00), IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Debito"), 0.00)) = 0.00 Then
            XtraMsg("Complete al informacion", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Try
            Dim frm As New FrmDetalleRequisas
            With frm
                .Cuenta = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo")
                .Monto = IIf(IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"), 0.00) = 0.00, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Debito"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"))
                .Tipo = IIf(IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"), 0.00) = 0.00, "D", "C")
                .Periodo = Periodo
                .CompNo = txtlNoComprobante.EditValue
                .Mes = Fecha.DateTime.Month
                .Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'If e.Column.FieldName = "Codigo" Then
        '    If Datas.Compute("Count(Codigo)", "Codigo = '" & e.Value & "'") >= 1 Then
        '        MsgBox("Ya existe esta cuenta", MsgBoxStyle.Information)
        '        GridView1.DeleteRow(GridView1.FocusedRowHandle)
        '    End If
        'End If

        If e.Column.FieldName = "Codigo" Then
            GridView1.SetRowCellValue(e.RowHandle, "Conciliado", False)
        End If
        '
        Totales()
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            Totales()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VerTipoComprobante()

        'If compDet.TipoX = 4 Then
        '    Exit Sub
        'End If

        ''//*******  TEMPORALMENTE
        'If ModificarComp = False Then
        '    If (compDet.Factura1 <> "" And compDet.Factura1 <> "0") Or (compDet.Recibo <> "" And compDet.Recibo <> "0") Or (compDet.Cheque <> "" And compDet.Cheque <> "0") Then
        '        'Panel1.Enabled = False
        '        'cmbtipocomprobante.Enabled = False
        '        cmbtipocomprobante.Properties.ReadOnly = True

        '        'If (compDet.Proveedor <> "" And compDet.Proveedor <> "0") Then
        '        'GridView1.Columns("Credito").OptionsColumn.AllowEdit = False
        '        'GridView1.Columns("Credito").OptionsColumn.AllowFocus = False
        '        'GridView1.Columns("Debito").OptionsColumn.AllowEdit = False
        '        'GridView1.Columns("Debito").OptionsColumn.AllowFocus = False
        '        NoDelete = False
        '    End If
        'End If
        '//*******  FIN TEMPORALMENTE

        'If compDet.Recibo <> "" And compDet.Recibo <> "0" Then
        '    Panel1.Enabled = False
        '    GridView1.OptionsBehavior.Editable = False
        'End If
        'If (compDet.Cheque <> "" And compDet.Cheque <> "0") Then
        '    Panel1.Enabled = False
        '    GridView1.OptionsBehavior.Editable = False
        'End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Validar() Then

            ShowSplash("Guardando Comprobante...")
            '
            If GuardarComprobante() Then
                '----------------------------
                'Guardar Distribucion
                '----------------------------
                Distribuir()
                '-----------------------------
                'Fin de Guardar Distribucion
                '-----------------------------

                Dim f As frmComprobantes = frmComprobantes.Instance()
                f.Buscar()
                '
                Cambios = GridView1.DataRowCount
                '
                Close()
            End If
            '
            HideSplash()
        End If
    End Sub

    Function Validar() As Boolean
        'If CDbl(IsNull(lblDiferencia.Text, 0)) <> 0 Then
        '    MsgBox("No se puede guardar un comprobante con diferencia", MsgBoxStyle.Critical)
        '    Return False
        'End If

        'Verificar Cierre del Día Nueva Fecha
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Return False
        End If
        '--------------------------------------------------------------------
        '
        'Verificar Cierre del Día de la Fecha Original
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha1.Date) Then
            Return False
        End If
        '--------------------------------------------------------------------
        '
        If Math.Round(lblDiferencia.EditValue, 2) <> 0 Then
            XtraMsg("No se puede guardar un comprobante con diferencia", MessageBoxIcon.Error)
            Return False
        End If
        '
        If cmbtipocomprobante.EditValue = Nothing Then
            XtraMsg("Seleccione el tipo de comprobante", MessageBoxIcon.Error)
            Return False
        End If
        '
        If GridView1.DataRowCount - 1 < 0 Then
            XtraMsg("No hay registros para guardar", MessageBoxIcon.Error)
            Return False
        End If

        If Fecha.EditValue = Nothing Then
            XtraMsg("Seleccione la fecha del comprobante", MessageBoxIcon.Error)
            Return False
        End If
        '
        If Not compDet.Consecutivo.Trim.Equals(txtConsecutivo.Text.Trim) Then
            If VB.SysContab.ComprobanteDB.ValidarConcecutivo(
                txtConsecutivo.Text,
                cmbtipocomprobante.EditValue,
                Fecha.DateTime.Month,
                PeriodosDB.Activo(Fecha.DateTime.Date)).Rows.Count > 0 Then

                XtraMsg("El Numero Consecutivo de Referencia usado para este Comprobante ya Existe",
                        MessageBoxIcon.Error)
                txtConsecutivo.Focus()
                txtConsecutivo.SelectAll()
                Return False
            End If
        End If
        '
        '******** VERIFICAR DISTRIBUCION ************************************************
        For i As Integer = 0 To Me.GridView1.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                ' CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & Me.GridView1.GetRowCellValue(i, "Codigo") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)                

                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                    + " CuentaContable = '" & GridView1.GetRowCellValue(i, "Codigo") & "'" _
                                    + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)

            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & Me.GridView1.GetRowCellValue(i, "Codigo").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Return False
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION ***********************************************

        Return True
    End Function

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean

        'Dim Total As Double = 0
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        'If Not DT_Distribucion Is Nothing Then
        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            'If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then Total += DT_Distribucion.Rows(i).Item("Valor")

            If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then
                If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                    tmp = True
                    Exit For
                End If
            End If

        Next

        Return tmp

        ''If Math.Round(Total, 2) <> Math.Round(CDbl(etSubTotal.Text), 2) Then
        'If Not IVAAsumido Then
        '    If Math.Round(Total, 2) <> SubTotalD Then 'CDbl(Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue) Then
        '        Return False
        '    End If
        'Else
        '    If Math.Round(Total, 2) <> SubTotalD Then 'Math.Round(CDbl(etSubTotal.Text), 2) Then
        '        Return False
        '    End If
        'End If

        'Return True
        'End If
    End Function

    Function GuardarComprobante() As Boolean
        'Dim Dist As Boolean = False

        'If Not chkdistribuir.Checked Then
        ' If VerificaDistribucion() = False Then Return False
        'End If

        'If chkdistribuir.Checked And VerGasto() Then
        '    My.Forms.frmSeguridadGuardar.Dispose()
        '    My.Forms.frmSeguridadGuardar.ShowDialog()
        '    If My.Forms.frmSeguridadGuardar.Ok = "SI" Then
        '        Dist = True
        '    Else
        '        Return False
        '    End If
        '    'If InputBox("Va a guardar un comprobante sin distribucion, digite el codigo de autorizacion para proceder:", "Confirmacion de Modificacion").ToString <> CStr(ObtieneDatos("SELECT Codigo FROM CodigoFactura WHERE Tipo = 2").Rows(0).Item(0)) Then
        '    '    MsgBox("Codigo Invalido")
        '    '    Exit Function
        '    'Else
        '    '    Dist = True
        '    'End If
        'End If

        Dim PeriodosDB As New PeriodosDB
        Dim CompNumero As Integer
        Dim NoComprob As Integer
        Dim CambioMes As Boolean = False

        'Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            'Elimina la distribucion del comprobante original y del actual 
            '(se entiende por original el que no se ha modificado)
            EliminaDistribucion(txtlNoComprobante.EditValue, Periodo, CDate(compDet.Fecha).Month, True) 'Comprobante original
            EliminaDistribucion(txtlNoComprobante.EditValue, Periodo, Fecha.DateTime.Date.Month, True)  'Comprobante actual

            If (PeriodosDB.Activo(Fecha.DateTime.Date) <>
                PeriodosDB.Activo(compDet.Fecha)) OrElse
                (Fecha.DateTime.Month <> CDate(compDet.Fecha).Month) Then 'OrElse (cmbtipocomprobante.EditValue <> compDet.Tipo1) Then

                ComprobanteDB.ComprobanteAnular(txtlNoComprobante.EditValue, Periodo, CDate(compDet.Fecha).Date, 1)
                ComprobanteDB.CancelarFactura(compDet.Factura1, compDet.Proveedor, 0)

                NoComprob = ComprobanteDB.AddComprobante(
                    cmbtipocomprobante.EditValue,
                    TasaCambio,
                    txtConcepto.Text,
                    Moneda,
                    PeriodosDB.Activo(Fecha.DateTime.Date),
                    Fecha.DateTime.Date,
                    0,
                    lblChequeNombre.Text,
                    False,
                    0,
                    "",
                    IIf(IsNull(lblChequeNombre.Text, "") = "", 0, 2),
                    "",
                    FechaVencimiento.DateTime.Date,
                    0,
                    compDet.Comp,
                    "",
                    0,
                    0,
                    compDet.Consecutivo)

                For i As Integer = 0 To GridView1.DataRowCount - 1
                    With GridView1
                        ComprobanteDB.AddComprobanteDetalles(
                            NoComprob,
                            .GetRowCellValue(i, "Codigo"),
                            .GetRowCellValue(i, "Concepto"),
                            IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0,
                            Math.Round((IsNull(.GetRowCellValue(i, "Debito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2),
                            Math.Round((IsNull(.GetRowCellValue(i, "Credito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2)),
                            txtCheque.Text,
                            cmbtipocomprobante.EditValue,
                            IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C"),
                            IsNull(.GetRowCellValue(i, "Factura"), ""), 0,
                            Fecha.DateTime.Date,
                            compDet.Detalles.Tables(0).Rows(i).Item("Detalle"), 0,
                            IsNull(.GetRowCellValue(i, "Retencion"), ""),
                            IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                            IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0))
                    End With
                Next

                'Datas.AcceptChanges()

                'ObtieneDatos("UPDATE Distribucion set nocomp = " & CompNumero & ",mes = " & Fecha1.Date.Month & ", per_id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & " where nocomp = " & txtlNoComprobante.EditValue & " and mes = " & Fecha1.Date.Month & " and idempresa = " & EmpresaActual & " and per_id = " & VB.SysContab.PeriodosDB.Activo(Fecha1.Date))
                '---------------------------------------
                'Actualizar información de la 
                'Distribucion en el nuevo comprobante.
                '---------------------------------------
                'Dim objDistribucion As New Distribucion,
                '    dbDistribucion As New db_Distribucion

                'objDistribucion.NoComp = NoComprob
                'objDistribucion.Mes = Fecha.DateTime.Month
                'objDistribucion.Per_Id = PeriodosDB.Activo(Fecha.DateTime.Date)

                'objDistribucion.NoComp = txtlNoComprobante.EditValue
                'objDistribucion.Mes = Fecha1.Month
                'objDistribucion.Per_Id = Periodo
                'objDistribucion.IdEmpresa = EmpresaActual

                'dbDistribucion.Actualizar2(
                '    objDistribucion,
                '    True,
                '    DBConnFacturas,
                '    transaccionFacturas)

                '--------------------------------
                'Fin de Actualizar Distribucion
                '--------------------------------
                txtlNoComprobante.EditValue = NoComprob
            Else
                CambioMes = True
                CompNumero = ComprobanteDB.ComprobanteUpdate(txtlNoComprobante.EditValue, cmbtipocomprobante.EditValue,
                                                    TasaCambio, Me.txtConcepto.Text, Moneda, Periodo,
                                                    Fecha.DateTime.Date, 0, False, Fecha1.Date, RUC,
                                                    Me.lblChequeNombre.Text, Pagara, Factura1, FechaVencimiento.DateTime.Date,
                                                    FormaPago, TipoX, txtConsecutivo.Text)

                For i As Integer = 0 To GridView1.DataRowCount - 1
                    With GridView1
                        Try
                            ComprobanteDB.ComprobanteDetallesUpdate(.GetRowCellValue(i, "CDet_Id"), .GetRowCellValue(i, "Codigo"),
                                                                    IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0,
                                                                    Math.Round((IsNull(.GetRowCellValue(i, "Debito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2),
                                                                    Math.Round((IsNull(.GetRowCellValue(i, "Credito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2)),
                                                                    IsNull(.GetRowCellValue(i, "Concepto"), ""), IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C"),
                                                                    IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                                                                    IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0),
                                                                    IsNull(.GetRowCellValue(i, "Factura"), ""),
                                                                    IsNull(.GetRowCellValue(i, "Retencion"), ""))
                        Catch ex As Exception
                            ComprobanteDB.AddComprobanteDetalles(txtlNoComprobante.EditValue, .GetRowCellValue(i, "Codigo"), IsNull(.GetRowCellValue(i, "Concepto"), ""),
                                                           IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0,
                                                           Math.Round((IsNull(.GetRowCellValue(i, "Debito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2),
                                                           Math.Round((IsNull(.GetRowCellValue(i, "Credito"), 0) * IIf(CheckEdit1.Checked, 1.0, TasaCambio)), 2)),
                                                           txtCheque.Text, cmbtipocomprobante.EditValue,
                                                           IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C"), IsNull(.GetRowCellValue(i, "Factura"), ""), 0,
                                                           Fecha.DateTime.Date, 1, 0,
                                                           IsNull(.GetRowCellValue(i, "Retencion"), ""),
                                                           IsNull(.GetRowCellValue(i, "IdProyecto"), 0),
                                                           IsNull(.GetRowCellValue(i, "IdOrdenCompra"), 0))
                        End Try
                    End With
                Next
            End If

            'Datas.AcceptChanges()

            Dim Eliminados As DataTable =
                Datas.GetChanges(DataRowState.Deleted)

            If Not Eliminados Is Nothing Then
                For i As Integer = 0 To Eliminados.Rows.Count - 1
                    Dim Fila As DataRow = Eliminados.Rows(i)
                    ComprobanteDB.DeleteComprobanteDetalles(Fila("Cdet_Id", DataRowVersion.Original))
                Next
            End If

            Rutinas.okTransaccion()

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            'VB.SysContab.Rutinas.ErrorTransaccion()
            Return False
            'Finally
            '    Dist = False
        End Try

        'Dim Modificados As DataTable = Datas.GetChanges(DataRowState.Modified)
        'If Not Modificados Is Nothing Then
        '    For i As Integer = 0 To Modificados.Rows.Count - 1
        '        comp.ComprobanteDetallesUpdate(Modificados.Rows(i)("Cdet_Id"), Modificados.Rows(i)("Codigo"), _
        '                                       IIf(IsNull(Modificados.Rows(i)("Credito"), 0) = 0, Math.Round((Modificados.Rows(i)("Debito") * TasaCambio), 2), _
        '                                           Math.Round((Modificados.Rows(i)("Credito") * TasaCambio), 2)), Modificados.Rows(i)("Concepto").ToString, _
        '                                           IIf(IsNull(Modificados.Rows(i)("Credito"), 0) = 0, "D", "C"))
        '    Next
        'End If

        'Dim Agregados As DataTable = Datas.GetChanges(DataRowState.Added)
        'If Not Agregados Is Nothing Then
        '    For i As Integer = 0 To Agregados.Rows.Count - 1
        '        comp.AddComprobanteDetalles(lblNoComprobante.Text, Agregados.Rows(i)("Codigo"), Agregados.Rows(i)("Concepto").ToString, _
        '                                    IIf(IsNull(Agregados.Rows(i)("Credito"), 0) = 0, Math.Round((IsNull(Agregados.Rows(i)("Debito"), 0) * TasaCambio), 2), _
        '                                        Math.Round((IsNull(Agregados.Rows(i)("Credito"), 0) * TasaCambio), 2)), 0, cmbtipocomprobante.EditValue, _
        '                                        IIf(IsNull(Agregados.Rows(i)("Credito"), 0) = 0, "D", "C"), 0, 0, Fecha.DateTime.Date, compDet.Detalles.Tables(0).Rows(0).Item("Detalle"))
        '    Next
        'End If

        'If cmbtipocomprobante.EditValue <> CInt(compDet.Tipo1) Then
        '    GuardaDatosTrans("UPDATE ComprobantesDetalles SET Comp_Tipo = " & cmbtipocomprobante.EditValue & " WHERE comp_no = " & txtlNoComprobante.EditValue & " AND mes = " & Fecha1.Date.Month & " AND per_id = " & VB.SysContab.PeriodosDB.Activo(Fecha1.Date) & " AND Empresa = " & EmpresaActual)
        'End If

        'If CambioMes Then
        '    CompNumero = ComprobanteDB.ComprobanteUpdate(txtlNoComprobante.EditValue, cmbtipocomprobante.EditValue,
        '                                        TasaCambio, Me.txtConcepto.Text, Moneda, Periodo,
        '                                        Fecha.DateTime.Date, 0, False, Fecha1.Date, RUC,
        '                                        Me.lblChequeNombre.Text, Pagara, Factura1, FechaVencimiento.DateTime.Date,
        '                                        FormaPago, TipoX, txtConsecutivo.Text)
        'End If

        'Rutinas.okTransaccion()

        '----------------------------
        'Guardar Distribucion
        '----------------------------
        'If CambioMes Then Distribuir()
        'Distribuir()
        'GuardaDistribucion(DT_Distribucion, Fecha.DateTime.Date, txtlNoComprobante.EditValue)
        '-----------------------------
        'Fin de Guardar Distribucion
        '-----------------------------

        'If Not chkdistribuir.Checked Then Distribuir()
        'Distribuir()

        'If CambioMes Then
        '    ObtieneDatos("UPDATE Distribucion set nocomp = " & CompNumero & ",mes = " & Fecha1.Date.Month & ", per_id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & " where nocomp = " & txtlNoComprobante.EditValue & " and mes = " & Fecha1.Date.Month & " and idempresa = " & EmpresaActual & " and per_id = " & VB.SysContab.PeriodosDB.Activo(Fecha1.Date))
        'End If

        'If Dist Then GuardaDatos("SPDS_NoDistribuidos " & txtlNoComprobante.EditValue & "," & VB.SysContab.PeriodosDB.Activo(Fecha1.Date) & "," & Fecha1.Date.Month & "," & EmpresaActual)

        'If VerifyLiqOption() Then
        '    If ckLiquidar.Checked = True Then
        '        For j As Integer = 0 To Datas.Rows.Count - 1
        '            Try
        '                If IsNull(DataLiq.Rows(j).Item("MtID"), 0) <> IsNull(GridView1.GetRowCellValue(j, "MtID"), 0) Then
        '                    ObtieneDatos("SP_LiqMercTransitUpdate " & ComprobanteID & "," & EmpresaActual & ",'" & _
        '                                 GridView1.GetRowCellValue(j, "Codigo") & "'," & GridView1.GetRowCellValue(j, "MtID") & _
        '                                 "," & GridView1.GetRowCellValue(j, "MtID") & "," & _
        '                                IIf(IsNull(GridView1.GetRowCellValue(j, "Credito"), 0) = 0, GridView1.GetRowCellValue(j, "Debito"), GridView1.GetRowCellValue(j, "Credito")) & _
        '                                 "," & ckDesgloce.Checked)
        '                End If
        '            Catch ex As Exception
        '            End Try
        '        Next
        '    End If
        'End If              
    End Function

#Region "Funciones de Distribucion"

    Private Sub Distribuir()
        'Dim Valor As Double
        '----------------------
        'Guarda la Distribucion
        '----------------------
        Datas.AcceptChanges()
        Dim sCuentas = From row In Datas.AsEnumerable()
                       Select row.Field(Of String)("Codigo") Distinct

        For Each s As Object In sCuentas
            If Not s Is Nothing Then

                If DT_Distribucion.Select("Cuenta = '" & s & "'").Length > 0 Then

                    GuardaDistribucion(
                            DT_Distribucion.Select("Cuenta = '" & s & "'").CopyToDataTable,
                            txtlNoComprobante.EditValue,
                            PeriodosDB.Activo(Fecha.DateTime.Date),
                            Fecha.DateTime.Month)

                End If
            End If
        Next


        'Dim objDistribucion As New Distribucion,
        '    dbDistribucion As New db_Distribucion

        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    With GridView1

        '        Dim CTemp As String = String.Empty
        '        Try
        '            ' CTemp = ObtieneDatosTrans("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .GetRowCellValue(i, "Codigo") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)

        '            CTemp = ObtieneDatos("sp_sel_RubroGastos",
        '                               .GetRowCellValue(i, "Codigo"),
        '                               EmpresaActual).
        '                               Rows.Item(0)("CuentaContable")

        '        Catch e As Exception
        '            CTemp = String.Empty
        '        End Try

        '        If Not CTemp.Equals(String.Empty) Then

        '            'Dim dtD As DataTable =
        '            '    ObtieneDatosTrans("SELECT * FROM Distribucion d WHERE d.NoComp = '" & txtlNoComprobante.EditValue & "'" _
        '            '                                    + " AND d.Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) & "" _
        '            '+ "AND d.Mes = " & Fecha.DateTime.Month & " And d.Cuenta = '" & .GetRowCellValue(i, "Codigo") & "' AND d.IdEmpresa = " & EmpresaActual)

        '            Dim Per_Id As Integer = PeriodosDB.Activo(Fecha.DateTime.Date)

        '            Dim _DTDist As DataTable = dbDistribucion.CargaDistribucion(
        '                txtlNoComprobante.EditValue,
        '                Per_Id,
        '                Fecha.DateTime.Month,
        '                EmpresaActual,
        '                .GetRowCellValue(i, "Codigo"))

        '            If _DTDist.Rows.Count = 0 Then
        '                ' Si no se ha distribuido la Cuenta, se distribuye y evitar duplicados cuando las cuentas se repiten en el comprobante
        '                ' Revision de Actualizacion de Distribucion. 04/09/08
        '                ' Error de Deleted Row Information. Corregido

        '                objDistribucion.IdEmpresa = EmpresaActual
        '                objDistribucion.NoComp = txtlNoComprobante.EditValue
        '                objDistribucion.Mes = Fecha.DateTime.Month
        '                objDistribucion.Per_Id = Per_Id

        '                If Not DT_Distribucion.GetChanges(DataRowState.Added) Is Nothing Then
        '                    For j As Integer = 0 To DT_Distribucion.GetChanges(DataRowState.Added).Rows.Count - 1
        '                        Dim Fila As DataRow = DT_Distribucion.GetChanges(DataRowState.Added).Rows(j)
        '                        If Fila.Item("Cuenta") = .GetRowCellValue(i, "Codigo") And Fila.Item("Tipo") = IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C") Then

        '                            With Fila
        '                                objDistribucion.IdRubroGasto = .Item("IdRubroGasto")
        '                                objDistribucion.IdCentroCosto = .Item("IdCentroCosto")
        '                                objDistribucion.Valor = .Item("Valor")
        '                                objDistribucion.Tipo = .Item("Tipo")
        '                                objDistribucion.Cuenta = .Item("Cuenta")

        '                                dbDistribucion.Insertar(objDistribucion)
        '                            End With

        '                            'GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
        '                            '" VALUES(" & EmpresaActual & "," & txtlNoComprobante.EditValue & "," & Fecha.DateTime.Month & "," &
        '                            'VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) & "," & Fila.Item("IdRubroGasto") & "," &
        '                            'Fila.Item("IdCentroCosto") & "," & Fila.Item("Valor") & ",'" & Fila.Item("Tipo") & "','" &
        '                            'Fila.Item("Cuenta") & "')")
        '                        End If
        '                    Next
        '                End If

        '                If Not DT_Distribucion.GetChanges(DataRowState.Modified) Is Nothing Then
        '                    For j As Integer = 0 To DT_Distribucion.GetChanges(DataRowState.Modified).Rows.Count - 1
        '                        Dim Fila As DataRow = DT_Distribucion.GetChanges(DataRowState.Modified).Rows(j)
        '                        If Fila.Item("Cuenta") = .GetRowCellValue(i, "Codigo") And Fila.Item("Tipo") = IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C") Then

        '                            With Fila
        '                                objDistribucion.IdRubroGasto = .Item("IdRubroGasto")
        '                                objDistribucion.IdCentroCosto = .Item("IdCentroCosto")
        '                                objDistribucion.Valor = .Item("Valor")
        '                                objDistribucion.Tipo = .Item("Tipo")
        '                                objDistribucion.Cuenta = .Item("Cuenta")

        '                                dbDistribucion.Insertar(objDistribucion)
        '                            End With

        '                            'GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
        '                            '" VALUES(" & EmpresaActual & "," & txtlNoComprobante.EditValue & "," & Fecha.DateTime.Month & "," &
        '                            'VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) & "," & Fila.Item("IdRubroGasto") & "," &
        '                            'Fila.Item("IdCentroCosto") & "," & Fila.Item("Valor") & ",'" & Fila.Item("Tipo") & "','" &
        '                            'Fila.Item("Cuenta") & "')")
        '                        End If
        '                    Next
        '                End If

        '                If Not DT_Distribucion.GetChanges(DataRowState.Unchanged) Is Nothing Then
        '                    For j As Integer = 0 To DT_Distribucion.GetChanges(DataRowState.Unchanged).Rows.Count - 1
        '                        Dim Fila As DataRow = DT_Distribucion.GetChanges(DataRowState.Unchanged).Rows(j)
        '                        If Fila.Item("Cuenta") = .GetRowCellValue(i, "Codigo") And Fila.Item("Tipo") = IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C") Then

        '                            With Fila
        '                                objDistribucion.IdRubroGasto = .Item("IdRubroGasto")
        '                                objDistribucion.IdCentroCosto = .Item("IdCentroCosto")
        '                                objDistribucion.Valor = .Item("Valor")
        '                                objDistribucion.Tipo = .Item("Tipo")
        '                                objDistribucion.Cuenta = .Item("Cuenta")

        '                                dbDistribucion.Insertar(objDistribucion)
        '                            End With

        '                            'GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
        '                            '" VALUES(" & EmpresaActual & "," & txtlNoComprobante.EditValue & "," & Fecha.DateTime.Month & "," &
        '                            'VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) & "," & Fila.Item("IdRubroGasto") & "," &
        '                            'Fila.Item("IdCentroCosto") & "," & Fila.Item("Valor") & ",'" & Fila.Item("Tipo") & "','" &
        '                            'Fila.Item("Cuenta") & "')")
        '                        End If
        '                    Next
        '                End If


        '                'For j As Integer = 0 To DT_Distribucion.Rows.Count - 1
        '                '    Dim Fila As DataRow = DT_Distribucion.Rows(j)
        '                '    If Fila.Item("Cuenta") = .GetRowCellValue(i, "Codigo") And Fila.Item("Tipo") = IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C") Then
        '                '        GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
        '                '        " VALUES(" & EmpresaActual & "," & Me.lblNoComprobante.Text & "," & Fecha.DateTime.Month & "," & _
        '                '        VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) & "," & Fila.Item("IdRubroGasto") & "," & _
        '                '        Fila.Item("IdCentroCosto") & "," & Fila.Item("Valor") & ",'" & Fila.Item("Tipo") & "','" & _
        '                '        Fila.Item("Cuenta") & "')")
        '                '    End If
        '                'Next
        '            End If
        '        End If
        '    End With
        'Next
    End Sub

    'Private Function VerificaDistribucion() As Boolean
    '    Dim Valor As Double
    '    For i As Integer = 0 To GridView1.DataRowCount - 1
    '        With GridView1
    '            Dim CTemp As String
    '            Try
    '                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .GetRowCellValue(i, "Codigo") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
    '            Catch e As Exception
    '                CTemp = ""
    '            End Try
    '            If CTemp <> Nothing Then
    '                Dim DT As DataTable = DT_Distribucion
    '                Dim Total As Double = 0
    '                DT.DefaultView.RowFilter = "Cuenta = '" & .GetRowCellValue(i, "Codigo") & _
    '                "' AND Tipo = '" & IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, "D", "C") & "'"
    '                '" AND Per_Id = " & Periodo & " AND IdEmpresa = " & EmpresaActual & _
    '                '" AND Mes = " & CDate(compDet.Fecha).Month & 
    '                '"' AND NoComp = " & lblNoComprobante.Text & _
    '                For j As Integer = 0 To DT.DefaultView.Count - 1
    '                    If DT.DefaultView.Item(j).Row.RowState <> DataRowState.Deleted Then Total += DT.DefaultView.Item(j).Row.Item("Valor")
    '                Next
    '                Valor = IIf(IsNull(.GetRowCellValue(i, "Credito"), 0) = 0, .GetRowCellValue(i, "Debito"), .GetRowCellValue(i, "Credito"))
    '                If CDbl(Format(Total, "###,##0.00")) <> CDbl(Format(Valor, "###,##0.00")) Then
    '                    MsgBox("La cuenta : " & .GetRowCellValue(i, "Codigo") & " tiene un valor de " & Format(Valor, "n2") & vbCrLf & _
    '                    " que no corresponde al valor distribuido de " & Format(Total, "n2"))
    '                    Return False
    '                End If
    '            End If
    '        End With
    '    Next
    '    Return True
    'End Function

    'Private Function VerGasto() As Boolean
    '    For i As Integer = 0 To GridView1.DataRowCount - 1
    '        With GridView1
    '            Dim CTemp As String
    '            Try
    '                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & .GetRowCellValue(i, "Codigo") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
    '            Catch e As Exception
    '                CTemp = ""
    '            End Try
    '            If CTemp <> Nothing Then
    '                Return True
    '                Exit Function
    '            End If
    '        End With
    '    Next
    '    Return False
    'End Function

#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        CargarCombos()
    End Sub

    Private Sub txtTasa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTasa.EditValueChanged
        If compDet.Moneda <> MonedaBase Then
            TasaCambio = Me.txtTasa.EditValue
        End If
    End Sub

    Private Sub ckLiquidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLiquidar.CheckedChanged

    End Sub

    Private Sub GridDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDetalle.Click

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(GridDetalle)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then GetData2()
        If Not CheckEdit1.Checked Then GetData()
    End Sub

    Sub GetData()

        GetServicios_Retencion(cbServicios)

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("ComprNO")
        'Variables.Add("Empresa")
        'Variables.Add("PerID")
        'Variables.Add("Fecha1")

        'Datos.Add(txtlNoComprobante.EditValue)
        'Datos.Add(EmpresaActual)
        'Datos.Add(Periodo)
        'Datos.Add(Fecha.DateTime.Date)

        'Datas = ProcedureParameters(Datos, Variables, "SP_ComprobantesDetails") 'compDet.Detalles.Tables(0) '"ComprobantesDetalles")
        'GridDetalle.DataSource = Datas

        Datas = ObtieneDatos("SP_ComprobantesDetails",
                            txtlNoComprobante.EditValue,
                             EmpresaActual,
                             Periodo,
                             Fecha.DateTime.Date)

        GridDetalle.DataSource = Datas

        GridView1.Columns("Debito").ColumnEdit = txtDebito
        GridView1.Columns("Credito").ColumnEdit = txtCredito

        Totales()
    End Sub


    Sub GetData2()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("ComprNO")
        Variables.Add("Empresa")
        Variables.Add("PerID")
        Variables.Add("Fecha1")

        Datos.Add(txtlNoComprobante.EditValue)
        Datos.Add(EmpresaActual)
        Datos.Add(Periodo)
        Datos.Add(Fecha.DateTime.Date)

        ShowSplash()

        Datas = ProcedureParameters(Datos, Variables, "SP_ComprobantesDetails2") 'compDet.Detalles.Tables(0) '"ComprobantesDetalles")
        GridDetalle.DataSource = Datas
        FormatoGrid(GridView1, 4, 0, False, True, False)

        GridView1.Columns("Debito").ColumnEdit = Nothing
        GridView1.Columns("Credito").ColumnEdit = Nothing

        Totales()
        HideSplash()
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.Column.FieldName = "Conciliado" Then
            If IsNull(GridView1.GetRowCellValue(e.RowHandle, "Conciliado"), False) Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.Green
            End If
        End If
    End Sub
End Class
