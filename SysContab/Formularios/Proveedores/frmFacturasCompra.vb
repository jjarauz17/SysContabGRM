Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports SysContab.VB.SysContab
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports Entities

Public Class frmFacturasCompra
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasCompra = Nothing

    Public Shared Function Instance() As frmFacturasCompra
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasCompra
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etTotal As System.Windows.Forms.Label
    Friend WithEvents etSubTotal As System.Windows.Forms.Label
    Friend WithEvents etIva As System.Windows.Forms.Label
    Friend WithEvents lbOrigen As System.Windows.Forms.Label
    Friend WithEvents ckIR As System.Windows.Forms.CheckBox
    Friend WithEvents cmbdistribucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckIVAAsumido As System.Windows.Forms.CheckBox
    Friend WithEvents chkIRAlc As System.Windows.Forms.CheckBox
    Friend WithEvents txtRuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents etTipo As System.Windows.Forms.Label
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPrecioC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaRecep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOrdenP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtfactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbTipoFactura As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NoOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSubTotalIR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gbTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gbIR As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents sDescuento As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkEmpleado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents etEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtIR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAPagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbClientes As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkCliente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents etCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbEmpleado As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkParalelo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents etTotalU As System.Windows.Forms.Label
    Friend WithEvents txtAlcaldia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbBodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents etOrigen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbItems As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lyProveedor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbOrdenCompra As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkLiquidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturasCompra))
        Me.cbTipoFactura = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkLiquidar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.etOrigen = New DevExpress.XtraEditors.LabelControl()
        Me.ckIVAAsumido = New System.Windows.Forms.CheckBox()
        Me.etInicio = New DevExpress.XtraEditors.LabelControl()
        Me.etTotalU = New System.Windows.Forms.Label()
        Me.txtAlcaldia = New DevExpress.XtraEditors.TextEdit()
        Me.txtAPagar = New DevExpress.XtraEditors.TextEdit()
        Me.lbOrigen = New System.Windows.Forms.Label()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.etSubTotal = New System.Windows.Forms.Label()
        Me.etTipo = New System.Windows.Forms.Label()
        Me.etIva = New System.Windows.Forms.Label()
        Me.etTotal = New System.Windows.Forms.Label()
        Me.cbBodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtIR = New DevExpress.XtraEditors.TextEdit()
        Me.chkParalelo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSubTotalIR = New DevExpress.XtraEditors.TextEdit()
        Me.etCliente = New DevExpress.XtraEditors.LabelControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkCliente = New DevExpress.XtraEditors.CheckEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vFacturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbItems = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbOrdenCompra = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbClientes = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbEmpleado = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.etEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.chkIRAlc = New System.Windows.Forms.CheckBox()
        Me.txtfactura = New DevExpress.XtraEditors.TextEdit()
        Me.txtOrdenP = New DevExpress.XtraEditors.TextEdit()
        Me.chkEmpleado = New DevExpress.XtraEditors.CheckEdit()
        Me.dtpFechaRecep = New DevExpress.XtraEditors.DateEdit()
        Me.gbIR = New DevExpress.XtraEditors.RadioGroup()
        Me.dtpFechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.txtDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.ckIR = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.gbTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.txtMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuc = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyProveedor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbdistribucion = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkParalelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecep.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTipoFactura
        '
        Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoFactura.EnterMoveNextControl = True
        Me.cbTipoFactura.Location = New System.Drawing.Point(535, 112)
        Me.cbTipoFactura.Name = "cbTipoFactura"
        Me.cbTipoFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoFactura.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbTipoFactura.Properties.Appearance.Options.UseFont = True
        Me.cbTipoFactura.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipoFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoFactura.Properties.NullText = ""
        Me.cbTipoFactura.Properties.ShowFooter = False
        Me.cbTipoFactura.Properties.ShowHeader = False
        Me.cbTipoFactura.Size = New System.Drawing.Size(109, 20)
        Me.cbTipoFactura.StyleController = Me.LayoutControl1
        Me.cbTipoFactura.TabIndex = 160
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkLiquidar)
        Me.LayoutControl1.Controls.Add(Me.txtOrden)
        Me.LayoutControl1.Controls.Add(Me.cbProveedor)
        Me.LayoutControl1.Controls.Add(Me.etOrigen)
        Me.LayoutControl1.Controls.Add(Me.ckIVAAsumido)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.etTotalU)
        Me.LayoutControl1.Controls.Add(Me.txtAlcaldia)
        Me.LayoutControl1.Controls.Add(Me.txtAPagar)
        Me.LayoutControl1.Controls.Add(Me.lbOrigen)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.etSubTotal)
        Me.LayoutControl1.Controls.Add(Me.etTipo)
        Me.LayoutControl1.Controls.Add(Me.etIva)
        Me.LayoutControl1.Controls.Add(Me.etTotal)
        Me.LayoutControl1.Controls.Add(Me.cbBodega)
        Me.LayoutControl1.Controls.Add(Me.txtIR)
        Me.LayoutControl1.Controls.Add(Me.chkParalelo)
        Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
        Me.LayoutControl1.Controls.Add(Me.txtSubTotalIR)
        Me.LayoutControl1.Controls.Add(Me.etCliente)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.chkCliente)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Controls.Add(Me.etTasa)
        Me.LayoutControl1.Controls.Add(Me.txtTelefono)
        Me.LayoutControl1.Controls.Add(Me.etEmpleado)
        Me.LayoutControl1.Controls.Add(Me.chkIRAlc)
        Me.LayoutControl1.Controls.Add(Me.txtfactura)
        Me.LayoutControl1.Controls.Add(Me.txtOrdenP)
        Me.LayoutControl1.Controls.Add(Me.chkEmpleado)
        Me.LayoutControl1.Controls.Add(Me.dtpFechaRecep)
        Me.LayoutControl1.Controls.Add(Me.gbIR)
        Me.LayoutControl1.Controls.Add(Me.dtpFechaPago)
        Me.LayoutControl1.Controls.Add(Me.txtDepartamento)
        Me.LayoutControl1.Controls.Add(Me.ckIR)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha)
        Me.LayoutControl1.Controls.Add(Me.gbTipo)
        Me.LayoutControl1.Controls.Add(Me.txtMunicipio)
        Me.LayoutControl1.Controls.Add(Me.txtRuc)
        Me.LayoutControl1.Controls.Add(Me.txtDireccion)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem42, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1057, 139, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(863, 632)
        Me.LayoutControl1.TabIndex = 174
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkLiquidar
        '
        Me.chkLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLiquidar.Location = New System.Drawing.Point(642, 162)
        Me.chkLiquidar.Name = "chkLiquidar"
        Me.chkLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkLiquidar.Properties.Appearance.Options.UseFont = True
        Me.chkLiquidar.Properties.Appearance.Options.UseForeColor = True
        Me.chkLiquidar.Properties.Caption = "A Liquidar"
        Me.chkLiquidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkLiquidar.Properties.ReadOnly = True
        Me.chkLiquidar.Size = New System.Drawing.Size(91, 22)
        Me.chkLiquidar.StyleController = Me.LayoutControl1
        Me.chkLiquidar.TabIndex = 176
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(742, 112)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(109, 20)
        Me.txtOrden.StyleController = Me.LayoutControl1
        Me.txtOrden.TabIndex = 175
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(106, 12)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProveedor.Size = New System.Drawing.Size(452, 20)
        Me.cbProveedor.StyleController = Me.LayoutControl1
        Me.cbProveedor.TabIndex = 174
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'etOrigen
        '
        Me.etOrigen.Location = New System.Drawing.Point(824, 520)
        Me.etOrigen.Name = "etOrigen"
        Me.etOrigen.Size = New System.Drawing.Size(42, 13)
        Me.etOrigen.StyleController = Me.LayoutControl1
        Me.etOrigen.TabIndex = 173
        Me.etOrigen.Text = "etOrigen"
        '
        'ckIVAAsumido
        '
        Me.ckIVAAsumido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckIVAAsumido.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckIVAAsumido.ForeColor = System.Drawing.Color.Maroon
        Me.ckIVAAsumido.Location = New System.Drawing.Point(723, 216)
        Me.ckIVAAsumido.Name = "ckIVAAsumido"
        Me.ckIVAAsumido.Size = New System.Drawing.Size(119, 20)
        Me.ckIVAAsumido.TabIndex = 4
        Me.ckIVAAsumido.Text = "I.V.A. Asumido"
        Me.ckIVAAsumido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(634, 298)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(25, 13)
        Me.etInicio.StyleController = Me.LayoutControl1
        Me.etInicio.TabIndex = 167
        Me.etInicio.Text = "Inicio"
        Me.etInicio.Visible = False
        '
        'etTotalU
        '
        Me.etTotalU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTotalU.BackColor = System.Drawing.Color.Transparent
        Me.etTotalU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalU.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalU.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalU.Location = New System.Drawing.Point(675, 544)
        Me.etTotalU.Name = "etTotalU"
        Me.etTotalU.Size = New System.Drawing.Size(176, 20)
        Me.etTotalU.TabIndex = 171
        Me.etTotalU.Text = "0.00"
        Me.etTotalU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAlcaldia
        '
        Me.txtAlcaldia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAlcaldia.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtAlcaldia.Location = New System.Drawing.Point(106, 572)
        Me.txtAlcaldia.Name = "txtAlcaldia"
        Me.txtAlcaldia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlcaldia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtAlcaldia.Properties.Appearance.Options.UseFont = True
        Me.txtAlcaldia.Properties.Appearance.Options.UseForeColor = True
        Me.txtAlcaldia.Properties.Mask.EditMask = "n2"
        Me.txtAlcaldia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAlcaldia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAlcaldia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAlcaldia.Size = New System.Drawing.Size(152, 22)
        Me.txtAlcaldia.StyleController = Me.LayoutControl1
        Me.txtAlcaldia.TabIndex = 172
        '
        'txtAPagar
        '
        Me.txtAPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAPagar.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtAPagar.Location = New System.Drawing.Point(106, 598)
        Me.txtAPagar.Name = "txtAPagar"
        Me.txtAPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPagar.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtAPagar.Properties.Appearance.Options.UseFont = True
        Me.txtAPagar.Properties.Appearance.Options.UseForeColor = True
        Me.txtAPagar.Properties.Mask.EditMask = "n2"
        Me.txtAPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAPagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAPagar.Size = New System.Drawing.Size(152, 22)
        Me.txtAPagar.StyleController = Me.LayoutControl1
        Me.txtAPagar.TabIndex = 168
        '
        'lbOrigen
        '
        Me.lbOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrigen.Location = New System.Drawing.Point(556, 298)
        Me.lbOrigen.Name = "lbOrigen"
        Me.lbOrigen.Size = New System.Drawing.Size(194, 50)
        Me.lbOrigen.TabIndex = 153
        Me.lbOrigen.Text = "Origen"
        Me.lbOrigen.Visible = False
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(356, 568)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Properties.Appearance.Options.UseFont = True
        Me.txtComentario.Size = New System.Drawing.Size(495, 52)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 1
        '
        'etSubTotal
        '
        Me.etSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.etSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etSubTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
        Me.etSubTotal.Location = New System.Drawing.Point(356, 520)
        Me.etSubTotal.Name = "etSubTotal"
        Me.etSubTotal.Size = New System.Drawing.Size(55, 20)
        Me.etSubTotal.TabIndex = 138
        Me.etSubTotal.Text = "0.00"
        Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTipo
        '
        Me.etTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTipo.Location = New System.Drawing.Point(556, 298)
        Me.etTipo.Name = "etTipo"
        Me.etTipo.Size = New System.Drawing.Size(109, 50)
        Me.etTipo.TabIndex = 154
        Me.etTipo.Text = "Tipo"
        Me.etTipo.Visible = False
        '
        'etIva
        '
        Me.etIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etIva.BackColor = System.Drawing.Color.Transparent
        Me.etIva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etIva.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etIva.ForeColor = System.Drawing.Color.Maroon
        Me.etIva.Location = New System.Drawing.Point(509, 520)
        Me.etIva.Name = "etIva"
        Me.etIva.Size = New System.Drawing.Size(68, 20)
        Me.etIva.TabIndex = 136
        Me.etIva.Text = "0.00"
        Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotal
        '
        Me.etTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTotal.BackColor = System.Drawing.Color.Transparent
        Me.etTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotal.ForeColor = System.Drawing.Color.Maroon
        Me.etTotal.Location = New System.Drawing.Point(675, 520)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(176, 20)
        Me.etTotal.TabIndex = 110
        Me.etTotal.Text = "0.00"
        Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbBodega
        '
        Me.cbBodega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBodega.EnterMoveNextControl = True
        Me.cbBodega.Location = New System.Drawing.Point(535, 136)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbBodega.Properties.Appearance.Options.UseFont = True
        Me.cbBodega.Properties.Appearance.Options.UseForeColor = True
        Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodega.Properties.NullText = ""
        Me.cbBodega.Properties.ShowFooter = False
        Me.cbBodega.Properties.ShowHeader = False
        Me.cbBodega.Size = New System.Drawing.Size(198, 20)
        Me.cbBodega.StyleController = Me.LayoutControl1
        Me.cbBodega.TabIndex = 171
        '
        'txtIR
        '
        Me.txtIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIR.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtIR.Location = New System.Drawing.Point(106, 546)
        Me.txtIR.Name = "txtIR"
        Me.txtIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIR.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtIR.Properties.Appearance.Options.UseFont = True
        Me.txtIR.Properties.Appearance.Options.UseForeColor = True
        Me.txtIR.Properties.Mask.EditMask = "n2"
        Me.txtIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIR.Size = New System.Drawing.Size(152, 22)
        Me.txtIR.StyleController = Me.LayoutControl1
        Me.txtIR.TabIndex = 166
        '
        'chkParalelo
        '
        Me.chkParalelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkParalelo.Location = New System.Drawing.Point(737, 136)
        Me.chkParalelo.Name = "chkParalelo"
        Me.chkParalelo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkParalelo.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chkParalelo.Properties.Appearance.Options.UseFont = True
        Me.chkParalelo.Properties.Appearance.Options.UseForeColor = True
        Me.chkParalelo.Properties.Caption = "Tasa Paralela"
        Me.chkParalelo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkParalelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkParalelo.Size = New System.Drawing.Size(114, 22)
        Me.chkParalelo.StyleController = Me.LayoutControl1
        Me.chkParalelo.TabIndex = 169
        '
        'txtSubTotalIR
        '
        Me.txtSubTotalIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotalIR.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtSubTotalIR.Location = New System.Drawing.Point(106, 520)
        Me.txtSubTotalIR.Name = "txtSubTotalIR"
        Me.txtSubTotalIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalIR.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtSubTotalIR.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotalIR.Properties.Appearance.Options.UseForeColor = True
        Me.txtSubTotalIR.Properties.Mask.EditMask = "n2"
        Me.txtSubTotalIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotalIR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSubTotalIR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubTotalIR.Size = New System.Drawing.Size(152, 22)
        Me.txtSubTotalIR.StyleController = Me.LayoutControl1
        Me.txtSubTotalIR.TabIndex = 164
        '
        'etCliente
        '
        Me.etCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCliente.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.etCliente.Appearance.Options.UseFont = True
        Me.etCliente.Appearance.Options.UseForeColor = True
        Me.etCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etCliente.Location = New System.Drawing.Point(671, 98)
        Me.etCliente.Name = "etCliente"
        Me.etCliente.Size = New System.Drawing.Size(91, 16)
        Me.etCliente.StyleController = Me.LayoutControl1
        Me.etCliente.TabIndex = 168
        Me.etCliente.Text = "00000"
        Me.etCliente.Visible = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMoneda.EnterMoveNextControl = True
        Me.cbMoneda.Location = New System.Drawing.Point(535, 162)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Appearance.Options.UseForeColor = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(103, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 159
        '
        'chkCliente
        '
        Me.chkCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCliente.Location = New System.Drawing.Point(703, 12)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCliente.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chkCliente.Properties.Appearance.Options.UseFont = True
        Me.chkCliente.Properties.Appearance.Options.UseForeColor = True
        Me.chkCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.chkCliente.Properties.Caption = "Aplicar a Cliente"
        Me.chkCliente.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkCliente.Size = New System.Drawing.Size(148, 22)
        Me.chkCliente.StyleController = Me.LayoutControl1
        Me.chkCliente.TabIndex = 166
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 196)
        Me.gridDatos.LookAndFeel.SkinName = "The Asphalt World"
        Me.gridDatos.MainView = Me.vFacturas
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPrecioC, Me.cbCatalogo, Me.sDescuento, Me.txtDescuento, Me.txtPrecioU, Me.txtCantidad, Me.cbClientes, Me.cbEmpleado, Me.cbItems, Me.cbProyecto, Me.cbOrdenCompra})
        Me.gridDatos.Size = New System.Drawing.Size(839, 320)
        Me.gridDatos.TabIndex = 0
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFacturas})
        '
        'vFacturas
        '
        Me.vFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn25, Me.GridColumn26, Me.GridColumn4, Me.GridColumn24, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.NoOrden, Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn8})
        Me.vFacturas.GridControl = Me.gridDatos
        Me.vFacturas.Name = "vFacturas"
        Me.vFacturas.OptionsCustomization.AllowColumnMoving = False
        Me.vFacturas.OptionsCustomization.AllowFilter = False
        Me.vFacturas.OptionsCustomization.AllowGroup = False
        Me.vFacturas.OptionsCustomization.AllowSort = False
        Me.vFacturas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vFacturas.OptionsView.ShowFooter = True
        Me.vFacturas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Descripción"
        Me.GridColumn18.ColumnEdit = Me.cbItems
        Me.GridColumn18.FieldName = "Codigo"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        Me.GridColumn18.Width = 187
        '
        'cbItems
        '
        Me.cbItems.AutoHeight = False
        Me.cbItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbItems.Name = "cbItems"
        Me.cbItems.NullText = "[Seleccione]"
        Me.cbItems.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn20.AppearanceHeader.Options.UseFont = True
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "Cantidad"
        Me.GridColumn20.ColumnEdit = Me.txtCantidad
        Me.GridColumn20.FieldName = "Cantidad"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 2
        Me.GridColumn20.Width = 57
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n4"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn21.AppearanceHeader.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "Precio U$"
        Me.GridColumn21.ColumnEdit = Me.txtPrecioU
        Me.GridColumn21.FieldName = "PrecioU"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        Me.GridColumn21.Width = 56
        '
        'txtPrecioU
        '
        Me.txtPrecioU.AutoHeight = False
        Me.txtPrecioU.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioU.Name = "txtPrecioU"
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn22.AppearanceHeader.Options.UseFont = True
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.Caption = "Descuento"
        Me.GridColumn22.ColumnEdit = Me.txtDescuento
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "descuento"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        Me.GridColumn22.Width = 58
        '
        'txtDescuento
        '
        Me.txtDescuento.AutoHeight = False
        Me.txtDescuento.Mask.EditMask = "P"
        Me.txtDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuento.Name = "txtDescuento"
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn23.AppearanceHeader.Options.UseFont = True
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "Sub Total"
        Me.GridColumn23.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "SubTotal"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:n2}")})
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 6
        Me.GridColumn23.Width = 56
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Temp"
        Me.GridColumn25.FieldName = "Temp"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Tipo"
        Me.GridColumn26.FieldName = "Tipo"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Gasto"
        Me.GridColumn4.FieldName = "Cuenta"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Exento"
        Me.GridColumn24.FieldName = "Exento"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Precio"
        Me.GridColumn3.ColumnEdit = Me.txtPrecioC
        Me.GridColumn3.FieldName = "Precio"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 52
        '
        'txtPrecioC
        '
        Me.txtPrecioC.AutoHeight = False
        Me.txtPrecioC.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioC.Name = "txtPrecioC"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Comentarios"
        Me.GridColumn5.FieldName = "Comentarios"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 104
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Cuenta"
        Me.GridColumn6.ColumnEdit = Me.cbCatalogo
        Me.GridColumn6.FieldName = "Cuenta"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 76
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cbCatalogo.View = Me.vCatalogo
        '
        'vCatalogo
        '
        Me.vCatalogo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.vCatalogo.OptionsView.ShowFooter = True
        Me.vCatalogo.OptionsView.ShowGroupPanel = False
        '
        'NoOrden
        '
        Me.NoOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NoOrden.AppearanceHeader.Options.UseFont = True
        Me.NoOrden.AppearanceHeader.Options.UseTextOptions = True
        Me.NoOrden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoOrden.Caption = "No Pedido"
        Me.NoOrden.ColumnEdit = Me.cbOrdenCompra
        Me.NoOrden.FieldName = "IdOrdenCompra"
        Me.NoOrden.Name = "NoOrden"
        Me.NoOrden.Visible = True
        Me.NoOrden.VisibleIndex = 9
        Me.NoOrden.Width = 72
        '
        'cbOrdenCompra
        '
        Me.cbOrdenCompra.AutoHeight = False
        Me.cbOrdenCompra.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenCompra.Name = "cbOrdenCompra"
        Me.cbOrdenCompra.View = Me.GridView2
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
        Me.GridColumn1.Caption = "ir"
        Me.GridColumn1.FieldName = "ir"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Cliente"
        Me.GridColumn2.ColumnEdit = Me.cbClientes
        Me.GridColumn2.FieldName = "ClienteID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'cbClientes
        '
        Me.cbClientes.AutoHeight = False
        Me.cbClientes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.NullText = ""
        Me.cbClientes.ShowHeader = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.Caption = "Empleado"
        Me.GridColumn7.ColumnEdit = Me.cbEmpleado
        Me.GridColumn7.FieldName = "EmpleadoID"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.AutoHeight = False
        Me.cbEmpleado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.NullText = ""
        Me.cbEmpleado.ShowHeader = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Proyecto"
        Me.GridColumn8.ColumnEdit = Me.cbProyecto
        Me.GridColumn8.FieldName = "IdProyecto"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 103
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoHeight = False
        Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.NullText = "[Proyecto]"
        Me.cbProyecto.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'sDescuento
        '
        Me.sDescuento.AutoHeight = False
        Me.sDescuento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sDescuento.Mask.EditMask = "P"
        Me.sDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.sDescuento.Name = "sDescuento"
        '
        'etTasa
        '
        Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(737, 162)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.Appearance.Options.UseBackColor = True
        Me.etTasa.Properties.Appearance.Options.UseFont = True
        Me.etTasa.Properties.Appearance.Options.UseForeColor = True
        Me.etTasa.Properties.Mask.EditMask = "n4"
        Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etTasa.Size = New System.Drawing.Size(114, 22)
        Me.etTasa.StyleController = Me.LayoutControl1
        Me.etTasa.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(742, 64)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono.Properties.Appearance.Options.UseBackColor = True
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.Appearance.Options.UseForeColor = True
        Me.txtTelefono.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtTelefono.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTelefono.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTelefono.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTelefono.Properties.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(109, 20)
        Me.txtTelefono.StyleController = Me.LayoutControl1
        Me.txtTelefono.TabIndex = 1
        '
        'etEmpleado
        '
        Me.etEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etEmpleado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEmpleado.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.etEmpleado.Appearance.Options.UseFont = True
        Me.etEmpleado.Appearance.Options.UseForeColor = True
        Me.etEmpleado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etEmpleado.Location = New System.Drawing.Point(686, 78)
        Me.etEmpleado.Name = "etEmpleado"
        Me.etEmpleado.Size = New System.Drawing.Size(93, 16)
        Me.etEmpleado.StyleController = Me.LayoutControl1
        Me.etEmpleado.TabIndex = 165
        Me.etEmpleado.Text = "00000"
        Me.etEmpleado.Visible = False
        '
        'chkIRAlc
        '
        Me.chkIRAlc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIRAlc.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkIRAlc.Location = New System.Drawing.Point(181, 142)
        Me.chkIRAlc.Name = "chkIRAlc"
        Me.chkIRAlc.Size = New System.Drawing.Size(174, 20)
        Me.chkIRAlc.TabIndex = 3
        Me.chkIRAlc.Text = "Calcular I.R. Alcaldia"
        '
        'txtfactura
        '
        Me.txtfactura.EnterMoveNextControl = True
        Me.txtfactura.Location = New System.Drawing.Point(106, 36)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Properties.Appearance.Options.UseFont = True
        Me.txtfactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Crimson
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtfactura.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfactura.Properties.MaxLength = 50
        Me.txtfactura.Size = New System.Drawing.Size(141, 20)
        Me.txtfactura.StyleController = Me.LayoutControl1
        Me.txtfactura.TabIndex = 1
        '
        'txtOrdenP
        '
        Me.txtOrdenP.EnterMoveNextControl = True
        Me.txtOrdenP.Location = New System.Drawing.Point(345, 36)
        Me.txtOrdenP.Name = "txtOrdenP"
        Me.txtOrdenP.Size = New System.Drawing.Size(213, 20)
        Me.txtOrdenP.StyleController = Me.LayoutControl1
        Me.txtOrdenP.TabIndex = 2
        '
        'chkEmpleado
        '
        Me.chkEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEmpleado.Location = New System.Drawing.Point(703, 12)
        Me.chkEmpleado.Name = "chkEmpleado"
        Me.chkEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmpleado.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chkEmpleado.Properties.Appearance.Options.UseFont = True
        Me.chkEmpleado.Properties.Appearance.Options.UseForeColor = True
        Me.chkEmpleado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.chkEmpleado.Properties.Caption = "Aplicar a Empleado"
        Me.chkEmpleado.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkEmpleado.Size = New System.Drawing.Size(148, 22)
        Me.chkEmpleado.StyleController = Me.LayoutControl1
        Me.chkEmpleado.TabIndex = 164
        '
        'dtpFechaRecep
        '
        Me.dtpFechaRecep.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaRecep.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
        Me.dtpFechaRecep.EnterMoveNextControl = True
        Me.dtpFechaRecep.Location = New System.Drawing.Point(760, 28)
        Me.dtpFechaRecep.Name = "dtpFechaRecep"
        Me.dtpFechaRecep.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaRecep.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRecep.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaRecep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecep.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaRecep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFechaRecep.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaRecep.StyleController = Me.LayoutControl1
        Me.dtpFechaRecep.TabIndex = 5
        '
        'gbIR
        '
        Me.gbIR.Enabled = False
        Me.gbIR.Location = New System.Drawing.Point(12, 166)
        Me.gbIR.Name = "gbIR"
        Me.gbIR.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIR.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.gbIR.Properties.Appearance.Options.UseBackColor = True
        Me.gbIR.Properties.Appearance.Options.UseFont = True
        Me.gbIR.Properties.Appearance.Options.UseForeColor = True
        Me.gbIR.Properties.Columns = 2
        Me.gbIR.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "I.R Productos/Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "I.R Honorarios")})
        Me.gbIR.Size = New System.Drawing.Size(399, 26)
        Me.gbIR.StyleController = Me.LayoutControl1
        Me.gbIR.TabIndex = 166
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaPago.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
        Me.dtpFechaPago.EnterMoveNextControl = True
        Me.dtpFechaPago.Location = New System.Drawing.Point(656, 36)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFechaPago.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaPago.StyleController = Me.LayoutControl1
        Me.dtpFechaPago.TabIndex = 4
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDepartamento.Location = New System.Drawing.Point(509, 88)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDepartamento.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDepartamento.Properties.Appearance.Options.UseBackColor = True
        Me.txtDepartamento.Properties.Appearance.Options.UseFont = True
        Me.txtDepartamento.Properties.Appearance.Options.UseForeColor = True
        Me.txtDepartamento.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDepartamento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtDepartamento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDepartamento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDepartamento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDepartamento.Properties.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(135, 20)
        Me.txtDepartamento.StyleController = Me.LayoutControl1
        Me.txtDepartamento.TabIndex = 3
        '
        'ckIR
        '
        Me.ckIR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckIR.ForeColor = System.Drawing.Color.MediumBlue
        Me.ckIR.Location = New System.Drawing.Point(12, 142)
        Me.ckIR.Name = "ckIR"
        Me.ckIR.Size = New System.Drawing.Size(165, 20)
        Me.ckIR.TabIndex = 0
        Me.ckIR.Text = "Calcular I.R."
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
        Me.dtpFecha.EnterMoveNextControl = True
        Me.dtpFecha.Location = New System.Drawing.Point(656, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.StyleController = Me.LayoutControl1
        Me.dtpFecha.TabIndex = 3
        '
        'gbTipo
        '
        Me.gbTipo.EditValue = 0
        Me.gbTipo.Location = New System.Drawing.Point(12, 112)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.gbTipo.Properties.Appearance.Options.UseBackColor = True
        Me.gbTipo.Properties.Appearance.Options.UseFont = True
        Me.gbTipo.Properties.Appearance.Options.UseForeColor = True
        Me.gbTipo.Properties.Columns = 4
        Me.gbTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Insumos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Ambos")})
        Me.gbTipo.Size = New System.Drawing.Size(399, 26)
        Me.gbTipo.StyleController = Me.LayoutControl1
        Me.gbTipo.TabIndex = 165
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMunicipio.Location = New System.Drawing.Point(742, 88)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMunicipio.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMunicipio.Properties.Appearance.Options.UseBackColor = True
        Me.txtMunicipio.Properties.Appearance.Options.UseFont = True
        Me.txtMunicipio.Properties.Appearance.Options.UseForeColor = True
        Me.txtMunicipio.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMunicipio.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtMunicipio.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMunicipio.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtMunicipio.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMunicipio.Properties.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(109, 20)
        Me.txtMunicipio.StyleController = Me.LayoutControl1
        Me.txtMunicipio.TabIndex = 4
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(509, 64)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRuc.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRuc.Properties.Appearance.Options.UseBackColor = True
        Me.txtRuc.Properties.Appearance.Options.UseFont = True
        Me.txtRuc.Properties.Appearance.Options.UseForeColor = True
        Me.txtRuc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRuc.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtRuc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtRuc.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtRuc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtRuc.Properties.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(135, 20)
        Me.txtRuc.StyleController = Me.LayoutControl1
        Me.txtRuc.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(106, 64)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.Appearance.Options.UseFont = True
        Me.txtDireccion.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.Window
        Me.txtDireccion.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDireccion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtDireccion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDireccion.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDireccion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDireccion.Properties.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(305, 44)
        Me.txtDireccion.StyleController = Me.LayoutControl1
        Me.txtDireccion.TabIndex = 2
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.etCliente
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(659, 86)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(95, 20)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.etEmpleado
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(674, 66)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(97, 34)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.etTipo
        Me.LayoutControlItem28.CustomizationFormText = "LayoutControlItem28"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(544, 286)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(113, 54)
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.lbOrigen
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(544, 286)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(198, 54)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.etInicio
        Me.LayoutControlItem30.CustomizationFormText = "LayoutControlItem30"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(622, 286)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(149, 54)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.ckIVAAsumido
        Me.LayoutControlItem31.CustomizationFormText = "LayoutControlItem31"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(711, 204)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(123, 24)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.etOrigen
        Me.LayoutControlItem42.CustomizationFormText = "LayoutControlItem42"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(812, 508)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(46, 17)
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkEmpleado
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(691, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(152, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(152, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(152, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkCliente
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(691, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(152, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(152, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(152, 52)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem25, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.LayoutControlItem36, Me.LayoutControlItem38, Me.LayoutControlItem39, Me.lyTotal, Me.LayoutControlItem41, Me.LayoutControlItem37, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.lyProveedor, Me.EmptySpaceItem3, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.LayoutControlItem27, Me.LayoutControlItem1, Me.LayoutControlItem21, Me.LayoutControlItem20, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem22, Me.LayoutControlItem26})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(863, 632)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtDireccion
        Me.LayoutControlItem14.CustomizationFormText = "Dirección:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(403, 48)
        Me.LayoutControlItem14.Text = "Dirección:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.gbTipo
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(54, 30)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(403, 30)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.ckIR
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(169, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkIRAlc
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(169, 130)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.gbIR
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(403, 30)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(403, 30)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(403, 30)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cbBodega
        Me.LayoutControlItem25.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(429, 124)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(296, 26)
        Me.LayoutControlItem25.Text = "Bodega:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.gridDatos
        Me.LayoutControlItem32.CustomizationFormText = "LayoutControlItem32"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 184)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(843, 324)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem33.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem33.Control = Me.txtSubTotalIR
        Me.LayoutControlItem33.CustomizationFormText = "Sub Total IR:"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 508)
        Me.LayoutControlItem33.MaxSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem33.MinSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem33.Text = "Sub Total IR:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem34.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem34.Control = Me.txtIR
        Me.LayoutControlItem34.CustomizationFormText = "Retención:"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 534)
        Me.LayoutControlItem34.MaxSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem34.MinSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem34.Text = "Retención:"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem35.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem35.Control = Me.txtAlcaldia
        Me.LayoutControlItem35.CustomizationFormText = "Alcaldia:"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 560)
        Me.LayoutControlItem35.MaxSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem35.MinSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem35.Text = "Alcaldia:"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem36.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem36.Control = Me.txtAPagar
        Me.LayoutControlItem36.CustomizationFormText = "A Pagar:"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 586)
        Me.LayoutControlItem36.MaxSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem36.MinSize = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem36.Text = "A Pagar:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem38.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem38.Control = Me.etSubTotal
        Me.LayoutControlItem38.CustomizationFormText = "Sub Total:"
        Me.LayoutControlItem38.Location = New System.Drawing.Point(250, 508)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(153, 24)
        Me.LayoutControlItem38.Text = "Sub Total:"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem39.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem39.Control = Me.etIva
        Me.LayoutControlItem39.CustomizationFormText = "IVA:"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(403, 508)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem39.Text = "IVA:"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(91, 14)
        '
        'lyTotal
        '
        Me.lyTotal.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyTotal.AppearanceItemCaption.Options.UseFont = True
        Me.lyTotal.Control = Me.etTotal
        Me.lyTotal.CustomizationFormText = "Total C$:"
        Me.lyTotal.Location = New System.Drawing.Point(569, 508)
        Me.lyTotal.Name = "lyTotal"
        Me.lyTotal.Size = New System.Drawing.Size(274, 24)
        Me.lyTotal.Text = "Total:"
        Me.lyTotal.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem41.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem41.Control = Me.etTotalU
        Me.LayoutControlItem41.CustomizationFormText = "Total U$:"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(569, 532)
        Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(274, 24)
        Me.LayoutControlItem41.MinSize = New System.Drawing.Size(274, 24)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(274, 24)
        Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem41.Text = "Total U$:"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem37.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem37.Control = Me.txtComentario
        Me.LayoutControlItem37.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(250, 556)
        Me.LayoutControlItem37.MaxSize = New System.Drawing.Size(0, 56)
        Me.LayoutControlItem37.MinSize = New System.Drawing.Size(108, 56)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(593, 56)
        Me.LayoutControlItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem37.Text = "Comentario:"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(91, 14)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtfactura
        Me.LayoutControlItem2.CustomizationFormText = "Orden Pago:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(239, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(239, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(239, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Orden Pago:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtOrdenP
        Me.LayoutControlItem3.CustomizationFormText = "#Factura:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(239, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(311, 28)
        Me.LayoutControlItem3.Text = "#Factura:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtpFecha
        Me.LayoutControlItem6.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(550, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(198, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Fecha:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtpFechaRecep
        Me.LayoutControlItem8.CustomizationFormText = "Fecha Recepación:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(748, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(95, 52)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(95, 52)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(95, 52)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Fecha Recepación:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpFechaPago
        Me.LayoutControlItem7.CustomizationFormText = "Fecha de Pago:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(550, 24)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Fecha de Pago:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
        '
        'lyProveedor
        '
        Me.lyProveedor.Control = Me.cbProveedor
        Me.lyProveedor.Location = New System.Drawing.Point(0, 0)
        Me.lyProveedor.Name = "lyProveedor"
        Me.lyProveedor.Size = New System.Drawing.Size(550, 24)
        Me.lyProveedor.Text = "Proveedor:"
        Me.lyProveedor.TextSize = New System.Drawing.Size(91, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(250, 532)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(319, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtDepartamento
        Me.LayoutControlItem13.CustomizationFormText = "Departamento:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(403, 76)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem13.Text = "Departamento:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtRuc
        Me.LayoutControlItem11.CustomizationFormText = "RUC:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(403, 52)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(233, 24)
        Me.LayoutControlItem11.Text = "RUC:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cbTipoFactura
        Me.LayoutControlItem27.CustomizationFormText = "Forma de Pago:"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(429, 100)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem27.Text = "Forma de Pago:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtOrden
        Me.LayoutControlItem1.Location = New System.Drawing.Point(636, 100)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem1.Text = "O / C:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.etTasa
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(725, 150)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(118, 34)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.chkParalelo
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(725, 124)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtTelefono
        Me.LayoutControlItem12.CustomizationFormText = "Telefono:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(636, 52)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem12.Text = "Telefono:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtMunicipio
        Me.LayoutControlItem15.CustomizationFormText = "Municipio:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(636, 76)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem15.Text = "Municipio:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(91, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(403, 100)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(26, 84)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(347, 130)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(56, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.chkLiquidar
        Me.LayoutControlItem22.Location = New System.Drawing.Point(630, 150)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(95, 34)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(95, 34)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(95, 34)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cbMoneda
        Me.LayoutControlItem26.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(429, 150)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(201, 34)
        Me.LayoutControlItem26.Text = "Moneda:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(91, 13)
        '
        'btnDetalle
        '
        Me.btnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetalle.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDetalle.Appearance.Options.UseFont = True
        Me.btnDetalle.Appearance.Options.UseForeColor = True
        Me.btnDetalle.Appearance.Options.UseTextOptions = True
        Me.btnDetalle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDetalle.ImageOptions.Image = CType(resources.GetObject("btnDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDetalle.Location = New System.Drawing.Point(12, 96)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(113, 38)
        Me.btnDetalle.StyleController = Me.LayoutControl2
        Me.btnDetalle.TabIndex = 155
        Me.btnDetalle.Text = "De&talle Distribución"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.btnDetalle)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmbdistribucion)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1187, 217, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(136, 605)
        Me.LayoutControl2.TabIndex = 156
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bImprimir.Appearance.Options.UseFont = True
        Me.bImprimir.Appearance.Options.UseForeColor = True
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(12, 138)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(113, 38)
        Me.bImprimir.StyleController = Me.LayoutControl2
        Me.bImprimir.TabIndex = 176
        Me.bImprimir.Text = "&Imprimir"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 538)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(113, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(113, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmbdistribucion
        '
        Me.cmbdistribucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbdistribucion.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdistribucion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbdistribucion.Appearance.Options.UseFont = True
        Me.cmbdistribucion.Appearance.Options.UseForeColor = True
        Me.cmbdistribucion.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_DocumentMapLarge
        Me.cmbdistribucion.Location = New System.Drawing.Point(12, 54)
        Me.cmbdistribucion.Name = "cmbdistribucion"
        Me.cmbdistribucion.Size = New System.Drawing.Size(113, 38)
        Me.cmbdistribucion.StyleController = Me.LayoutControl2
        Me.cmbdistribucion.TabIndex = 2
        Me.cmbdistribucion.Text = "&Distribuir"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40, Me.LayoutControlItem43, Me.LayoutControlItem44, Me.LayoutControlItem45, Me.EmptySpaceItem5, Me.LayoutControlItem23})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(137, 588)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.cmdAceptar
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.cmbdistribucion
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem43.TextVisible = False
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.btnDetalle
        Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem44.MaxSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem44.MinSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem44.TextVisible = False
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.cmdCancelar
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 526)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem45.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(117, 358)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.bImprimir
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("9d9f3617-05f3-4c92-8931-be1feeac20a9")
        Me.DockPanel1.Location = New System.Drawing.Point(863, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(145, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(145, 632)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(136, 605)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmFacturasCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 632)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmFacturasCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkParalelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecep.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim ds As DataSet

    Dim i As Integer
    Dim Tipo As Integer

    Dim ValorActualCantidad As Double
    Dim ValorActualPrecio As Double
    Dim ValorActualDescuento As Double

    Dim Facturas As New VB.SysContab.Facturas_ComprasDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails
    Dim Articulos As New VB.SysContab.ArticulosDB
    Dim DetallesProducto As New VB.SysContab.ArticulosDetails
    Dim r As New VB.SysContab.Rutinas

    Dim OrdenesCompra As New VB.SysContab.Ordenes_ComprasDB

    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Dim ArticulosCC As New VB.SysContab.GruposCCDB

    'Dim CargarOrden As Boolean
    Public OrdenCompra As Integer = 0

    Public Nuevo As Boolean
    Public TipoProd As String

    Public dsItems As DataSet
    Dim dsItemCC As DataSet
    Public SubTotalParaIVA As Double
    Public TipoF As String
    Dim TC As New VB.SysContab.Tasa_CambioDB
    'Dim MonedaBase As String = ObtieneDatos("SELECT e.emp_monedabase FROM EMPRESAS e WHERE e.CODIGO = " & EmpresaActual).Rows.Item(0)(0)
#End Region

    Private _TipoC As Integer = 1
    Private _Proveedor As String
    Private _Comprobante As String
    Private _Periodo As String
    Private _Mes As String
    Private _Factura As String
    Private _Modifica As Boolean = False
    Private _VerFactura As Boolean = False

    Private Temp As Boolean = False
    Private TCambio As Double = 1
    Private GuardarCambios = 0
    Public Destino As Integer = 0

    Dim Salir As Boolean = False    'Preguntar Si guardar Cambio o No
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Private DT As DataTable = New DataTable("Datos")
    Dim IdCliente As Integer = 0

#Region "Propiedades"

    Public Property Modifica()
        Get
            Return _Modifica
        End Get
        Set(ByVal Value)
            _Modifica = Value
        End Set
    End Property

    Public Property VerFactura()
        Get
            Return _VerFactura
        End Get
        Set(ByVal Value)
            _VerFactura = Value
        End Set
    End Property

    Public Property Factura()
        Get
            Return _Factura
        End Get
        Set(ByVal Value)
            _Factura = Value
        End Set
    End Property

    Public Property Periodo()
        Get
            Return _Periodo
        End Get
        Set(ByVal Value)
            _Periodo = Value
        End Set
    End Property

    Public Property Mes()
        Get
            Return _Mes
        End Get
        Set(ByVal Value)
            _Mes = Value
        End Set
    End Property

    Public Property Comprobante()
        Get
            Return _Comprobante
        End Get
        Set(ByVal Value)
            _Comprobante = Value
        End Set
    End Property

    Public Property Proveedor()
        Get
            Return _Proveedor
        End Get
        Set(ByVal Value)
            _Proveedor = Value
        End Set
    End Property

    Public Property TipoC()
        Get
            Return _TipoC
        End Get
        Set(ByVal Value)
            _TipoC = Value
        End Set
    End Property

#End Region

#Region "Funciones de Distribucion"

    Private Sub Distribucion()
        If Modifica Then
            Try
                'Dim DatT As DataTable
                'DatT = ObtieneDatos("SELECT * FROM Comprobantes WHERE Empresa = " & EmpresaActual & " AND Tipo = 1 AND Factura = '" & txtfactura.Text.Trim & "' AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date) & " AND Mes = " & dtpFecha.DateTime.Month)

                Dim DatT As DataTable = ObtieneDatos("sp_GetComprobantexFactura", txtfactura.Text,
                                                                                    Proveedor,
                                                                                    VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date),
                                                                                    dtpFecha.DateTime.Month,
                                                                                    EmpresaActual)

                If DatT.Rows.Count = 0 Then
                    ' DatT = ObtieneDatos("SELECT * FROM Comprobantes WHERE Empresa = " & EmpresaActual & " AND Tipo = 1 AND Factura = '0' AND Proveedor = '" & Proveedor & "' AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date) & " AND Mes = " & dtpFecha.DateTime.Month)

                    DatT = ObtieneDatos("sp_GetComprobantexFactura", "0",
                                                                        Proveedor,
                                                                        VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date),
                                                                        dtpFecha.DateTime.Month,
                                                                        EmpresaActual)
                End If

                With DatT.Rows(0)
                    DT_Distribucion = CargaDistribucion(.Item("Mes"), .Item("Comp_No"), .Item("Per_Id"))
                    Comprobante = .Item("Comp_No")
                End With
            Catch ex As Exception
                DT_Distribucion = CargaDistribucion(0, 0, 0)
            End Try
        Else
            DT_Distribucion = CargaDistribucion(0, 0, 0)
        End If
        AgregarColumnas()
    End Sub

    Private Sub DistribucionTrans()
        If Modifica Then
            Try
                'Dim DatT As DataTable
                'DatT = ObtieneDatosTrans("SELECT * FROM Comprobantes WHERE Empresa = " & EmpresaActual & " AND Factura = '" & txtfactura.Text.Trim & "' AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date) & " AND Mes = " & dtpFecha.DateTime.Month)

                Dim DatT As DataTable = ObtieneDatosTrans("sp_GetComprobantexFactura", txtfactura.Text,
                                                                                    Proveedor,
                                                                                    VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date),
                                                                                    dtpFecha.DateTime.Month,
                                                                                    EmpresaActual)

                If DatT.Rows.Count = 0 Then
                    ' DatT = ObtieneDatosTrans("SELECT * FROM Comprobantes WHERE Empresa = " & EmpresaActual & " AND Factura = '0' AND Proveedor = '" & Proveedor & "' AND Per_Id = " & VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date) & " AND Mes = " & dtpFecha.DateTime.Month)


                    DatT = ObtieneDatosTrans("sp_GetComprobantexFactura", "0",
                                                                        Proveedor,
                                                                        VB.SysContab.PeriodosDB.Activo(dtpFecha.DateTime.Date),
                                                                        dtpFecha.DateTime.Month,
                                                                        EmpresaActual)
                End If

                With DatT.Rows(0)
                    DT_Distribucion = CargaDistribucionTrans(.Item("Mes"), .Item("Comp_No"), .Item("Per_Id"))
                    Comprobante = .Item("Comp_No")
                End With
            Catch ex As Exception
                DT_Distribucion = CargaDistribucionTrans(0, 0, 0)
            End Try
        Else
            DT_Distribucion = CargaDistribucionTrans(0, 0, 0)
        End If
        AgregarColumnas()
    End Sub
    Sub AgregarColumnas()
        Try
            DT_Distribucion.Columns.Add("Rubro", System.Type.GetType("System.String"))
            DT_Distribucion.Columns.Add("Centro", System.Type.GetType("System.String"))
        Catch ex As Exception
        End Try
    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean

        'Dim Total As Double = 0
        Dim tmp As Boolean = False
        ''DT_Distribucion.AcceptChanges()

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        'If Not DT_Distribucion Is Nothing Then
        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then
                'If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then Total += DT_Distribucion.Rows(i).Item("Valor")
                Try
                    If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                        tmp = True
                        Exit For
                    End If
                Catch ex As Exception
                    tmp = False
                End Try
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

    Private Function CalcularTotal_Distribucion() As Double

    End Function

    Private Sub cmbdistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdistribucion.Click
        'BAR
        If CDbl(etSubTotal.Text) <= 0 Then Exit Sub
        ' For i As Integer = 0 To myDataSet.Tables(0).Rows.Count - 1
        Try
            Dim forma As New FrmDetalleRequisas
            forma.Cuenta = Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta")
            'forma.Cuenta = myDataSet.Tables(0).Rows(dgFacturas.CurrentRowIndex).Item("CuentaGasto")

            Dim valor As Double = 0

            If Me.ckIVAAsumido.Checked Then
                Dim Det As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"), TipoProd)

                If Det.Exento = True Then
                    valor = Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal")
                    'valor = myDataSet.Tables(0).Rows(dgFacturas.CurrentRowIndex).Item("SubTotal")
                Else
                    valor = Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal") * (1 + (ConfigDetalles.IVA / 100.0))
                End If
            Else
                valor = Math.Round(CDbl(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "SubTotal")), 2)
            End If

            If cbMoneda.EditValue <> MonedaBase Then
                If EmpresaActual <> 1 Then valor = Math.Round(CDbl(valor / etTasa.EditValue), 2)
            End If

            forma.Monto = IIf(valor < 0, valor * -1, valor)
            forma.Tipo = IIf(valor < 0, "C", "D")
            forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date)
            'forma.CompNo = IIf(Modifica, Comprobante, 0)
            forma.CompNo = IIf(Comprobante Is Nothing, 0, Comprobante)
            forma.Cuenta = Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta")
            forma.Mes = dtpFecha.DateTime.Month

            'MsgBox(forma.Tipo)
            'DT_Distribucion.AcceptChanges()
            forma.Mostrar(DT_Distribucion)
            Me.DT_Distribucion.DefaultView.RowFilter = ""
            'DT_Distribucion.AcceptChanges()


            'Dim forma As New FrmDetalleRequisas
            'forma.Cuenta = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo")
            'forma.Monto = IIf(IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"), 0) = 0, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Debito"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"))
            'forma.Tipo = IIf(IsNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito"), 0) = 0, "D", "C")
            'forma.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
            'forma.CompNo = lblNoComprobante.Text
            'forma.Mes = Fecha.DateTime.Month
            'forma.Mostrar(DT_Distribucion)
            'Me.DT_Distribucion.DefaultView.RowFilter = ""

        Catch ex As Exception
            XtraMsg(ex.Message & " " & ex.Source, MessageBoxIcon.Error)
        End Try
        '    Next
    End Sub

    'Private Sub ddlGastos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DT_Distribucion.Clear()
    '    DT_Distribucion.AcceptChanges()
    'End Sub
#End Region

#Region "Otras Funciones"

    Private Sub EsModificacion()
        cbProveedor.Enabled = False
        cbTipoFactura.Enabled = False
        txtfactura.Properties.ReadOnly = True
        '
        gbTipo.Enabled = False
        Me.cbProveedor.EditValue = Proveedor
        ds = Facturas_ComprasDB.GetFacturaCompraDetalle(
            txtfactura.Text.Trim,
            cbProveedor.EditValue,
            etOrigen.Text)
        '
        Me.txtComentario.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Observaciones")
        Me.cbTipoFactura.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("FormaPago_ID")
        Me.dtpFecha.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha")
        Me.dtpFechaPago.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_FechaPago")
        Me.txtOrden.Text = ds.Tables("Facturas_Compras").Rows(0).Item("OrdenCompra_ID").ToString
        'OrdenCompra = Me.txtOrden.Text
        'Me.txtOrden.Text = ds.Tables("Facturas_Compras").Rows(0).Item("NoOrden").ToString
        Me.ckIVAAsumido.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IVA_ASUMIDO"), False))
        Me.txtSubTotalIR.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("SubTotalIR")
        '
        Me.chkIRAlc.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("ir_pagado_alcaldia"), False))
        Me.ckIR.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IR_Pagado"), False))
        '
        If Me.ckIR.Checked Then
            If CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IR_Prod"), False)) Then Me.gbIR.EditValue = 0
            If CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IR_Serv"), False)) Then Me.gbIR.EditValue = 1
            'Me.rbIRProd.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IR_Prod"), False))
            'Me.rbIRServ.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("IR_Serv"), False))
        End If
        '
        Me.txtOrdenP.Text = ds.Tables("Facturas_Compras").Rows(0).Item("NoOrden")
        Me.cbMoneda.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("Moneda")
        Me.cbBodega.EditValue = IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("Codigo_Bodega"), ConfigDetalles.Bodega)
        '
        Me.chkEmpleado.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("Empleado"), False))
        Me.chkCliente.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("Cliente"), False))
        '
        Me.etTasa.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("TCambio")
        Me.chkParalelo.Checked = CBool(IsNull(ds.Tables("Facturas_Compras").Rows(0).Item("CambioParalelo"), False))
        '


        'If Not ds.Tables("Facturas_Compras").Rows(0).Item("Emp_Codigo") Is DBNull.Value Then
        '    Me.chkEmpleado.Checked = True
        '    Me.etEmpleado.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Emp_Codigo")
        'End If
        'If Me.chkEmpleado.Checked Then Me.etEmpleado.Visible = True
    End Sub

    Dim Servicio As Boolean

    'Private Sub cmdOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim f As New frmOrdenesCompraList
    '    Me.Nuevo = False

    '    f.WindowState = FormWindowState.Normal
    '    f.StartPosition = FormStartPosition.CenterScreen
    '    f.ShowDialog()

    '    If f.Salir = True Then
    '        Exit Sub
    '    Else
    '        CargarOrden = True
    '        OrdenCompra = f.dgOrdenes.Item(f.dgOrdenes.CurrentRowIndex, 0)
    '        ds = OrdenesCompra.GeTOrdenCompraDetalle(OrdenCompra)

    '        txtOrden.Text = OrdenCompra
    '        If ds.Tables("Ordenes_Compras").Rows.Count = 0 Then
    '            Exit Sub
    '        End If

    '        Me.cbProveedor.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Proveedor_ID")
    '        Me.dtpFecha.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Fecha")
    '        Me.dtpFechaPago.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_FechaPago")
    '        Me.cbTipoFactura.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("FormaPago_ID")


    '        Dim DT_TIPO As DataTable = ObtieneDatos("sp_Get_OC_Tipo", txtOrden.Text, EmpresaActual)

    '        If DT_TIPO.Rows.Count = 1 Then CargarCombos(DT_TIPO.Rows.Item(0)("Tipo"))
    '        If DT_TIPO.Rows.Count > 1 Then CargarCombos("A")


    '        'If ObtieneDatos("select distinct Item_Tipo from Ordenes_Compras_Lineas where Factura_ID =" & txtOrden.Text).Rows.Count = 1 Then
    '        '    If ds.Tables("Ordenes_Compras").Rows(0).Item("Tipo") = "P" Then
    '        '        Me.gbTipo.EditValue = 0
    '        '        'Me.gbTipo.EditValue = 0 = True
    '        '        CargarCombos("P")
    '        '    ElseIf ds.Tables("Ordenes_Compras").Rows(0).Item("Tipo") = "I" Then
    '        '        Me.gbTipo.EditValue = 4
    '        '        'Me.gbTipo.EditValue = 4 = True
    '        '        CargarCombos("I")
    '        '    End If
    '        'Else
    '        '    Me.gbTipo.EditValue = 3
    '        '    'Me.gbTipo.EditValue = 3 = True
    '        '    CargarCombos("A")
    '        'End If
    '        'If ds.Tables("Ordenes_Compras").Rows(0).Item("Tipo") = "P" Then
    '        '    Me.gbTipo.EditValue = 0 = True
    '        '    CargarCombos("P")
    '        'Else
    '        '    Me.gbTipo.EditValue = 0 = True
    '        '    CargarCombos("I")
    '        'End If
    '        RealizarCalculos(0)
    '    End If

    '    'MakeDataSet()
    '    'Me.dgFacturas.SetDataBinding(myDataSet, "Articulos")
    '    'AddCustomDataTableStyle()
    'End Sub

    Private Sub frmFacturasCompra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '****  Preguntar por guardar Cambios al Salir 
        If Not Salir Then
            If Modifica = True Then
                If GuardarCambios > 0 Then
                    If XtraMsg2("¿Desea Guardar los Cambios?") Then
                        If Not GuardarFactura() Then
                            e.Cancel = True
                        End If
                    End If
                End If
            Else
                If Me.txtOrden.Text.Trim = "" Then
                    If Me.vFacturas.DataRowCount > 0 Then
                        If XtraMsg2("¿Desea Guardar los Cambios?") Then
                            If Not GuardarFactura() Then
                                e.Cancel = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub ckIR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckIR.CheckedChanged
        Me.gbIR.Enabled = Me.ckIR.Checked

        If Me.ckIR.Checked Then Me.gbIR.EditValue = 0
        If Not Me.ckIR.Checked Then Me.gbIR.EditValue = -1

        CalcularIR()

        'If Me.ckIR.Checked Then
        '    Me.gbTipo.EditValue = 0
        '    Me.rbIRProd.Visible = True
        '    Me.rbIRServ.Visible = True
        '    Me.rbIRProd.Checked = True
        '    Me.rbIRServ.Checked = False
        'Else
        '    Me.rbIRProd.Visible = False
        '    Me.rbIRServ.Visible = False

        '    Me.rbIRProd.Checked = False
        '    Me.rbIRServ.Checked = False

        'End If
    End Sub

    Private Sub chkIRAlc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIRAlc.CheckedChanged
        CalcularIR()
        'If chkIRAlc.Checked Then
        '    Dim Muni As New VB.SysContab.MunicipiosDB
        '    Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Departamento, ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Municipio)

        '    If Me.txtSubTotalIR.EditValue > MunDet.Impuesto_SVenta_Min Then
        '        CalcularIR()
        '    End If
        '    'If ObtieneDatos("SELECT ISNULL(dbo.fn_GetPorcentajeAlcaldia(" & cbProveedor.EditValue & "," & EmpresaActual & "),0.00) Porcentaje").Rows.Item(0)("Porcentaje") = 0 Then
        '    '    XtraMsg("El Proveedor Seleccionado No tiene Asignado el Municipio.", MessageBoxIcon.Warning)
        '    '    chkIRAlc.Checked = False
        '    '    Exit Sub
        '    'End If
        'End If
    End Sub

    Private Sub ckIVAAsumido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckIVAAsumido.CheckedChanged
        RealizarCalculos(3)
        CalcularIR()
    End Sub

#End Region

    Private Sub frmFacturasCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConfigDetalles = ConfiguracionDB.GetConfigDetails    'Obtener Detalle de la Configuracion
        Dim FechaActual As Date = VB.SysContab.Rutinas.Fecha().Date

        CombosBox()

        ''***************  Solo Para RAMAC
        ''Poner la Forma de Pago por defecto a 30 Dias.
        'If strOrdenPago = "Orden de Pago" Then
        '    'Dim fp As DataTable = ObtieneDatos("SELECT fp.CODIGO FROM FORMA_PAGO fp WHERE fp.DIAS = 30 AND fp.EMPRESA = " & EmpresaActual)
        '    'If fp.Rows.Count > 0 Then
        '    '    Me.cbTipoFactura.EditValue = fp.Rows.Item(0)("CODIGO")
        '    'End If           
        'Else
        '    Me.cbTipoFactura.ItemIndex = 0
        'End If
        ''*****************************************************

        dtpFecha.DateTime = FechaActual
        dtpFechaRecep.DateTime = FechaActual

        Try
            cbTipoFactura.EditValue = ObtieneDatos("sp_FormaPago_x_Dia",
                                                   30,
                                                   EmpresaActual) _
                                                   .Rows.Item(0)("CODIGO")
        Catch ex As Exception
            cbTipoFactura.ItemIndex = 0
        End Try

        If Not Modifica Then txtfactura.Text = ""

        TCambio = GetTasaCambioDia(dtpFecha.DateTime.Date)
        etTasa.Text = TCambio
        '

        If txtOrden.Text.Trim.Length = 0 And Not Modifica Then
            CargarCombos("P")
            Tipo = 0
        End If

        'CargarOrden = False

        If txtOrden.Text <> "" Then 'Si el Origen de la Factura es una Orden de Compra

            'ds = OrdenesCompra.GeTOrdenCompraDetalle(txtOrden.Text)
            'ds = OrdenesCompra.GeTOrdenCompraDetalle(OrdenCompra)

            ds = OrdenesCompra.OrdenComprasDetalle(OrdenCompra, 99)

            cbProveedor.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Proveedor_ID")
            dtpFecha.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Fecha")
            dtpFechaPago.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_FechaPago")
            cbTipoFactura.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("FormaPago_ID")

            gbTipo.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("TipoOrden")
            TCambio = IIf(CDbl(ds.Tables("Ordenes_Compras").Rows(0).Item("TCambio")) > 1,
                          CDbl(ds.Tables("Ordenes_Compras").Rows(0).Item("TCambio")), TCambio)

            ckIR.Checked = False
            cbMoneda.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Moneda")
            txtComentario.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Comentario")

            If ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Tipo") = "P" Then
                CargarCombos(ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Tipo"))
            End If

            'If gbTipo.EditValue = 0 Then CargarCombos("P")
            'If ObtieneDatos("select distinct Item_Tipo from Ordenes_Compras_Lineas where Factura_ID =" & OrdenCompra).Rows.Count = 1 Then
            '    If ds.Tables("Ordenes_Compras").Rows(0).Item("Tipo") = "P" Then
            '        Me.gbTipo.EditValue = 0
            '        'Me.gbTipo.EditValue = 0 = True
            '        CargarCombos("P")
            '    ElseIf ds.Tables("Ordenes_Compras").Rows(0).Item("Tipo") = "I" Then
            '        Me.gbTipo.EditValue = 4
            '        'Me.gbTipo.EditValue = 4 = True
            '        CargarCombos("I")
            '    End If
            'Else
            '    Me.gbTipo.EditValue = 3
            '    'Me.gbTipo.EditValue = 3 = True
            '    CargarCombos("A")
            'End If


            chkLiquidar.Checked = ds.Tables("Ordenes_Compras").Rows(0).Item("Liquidacion")
            RealizarCalculos(0)
            CalcularIR()

        End If

        '-------------------------------
        'Si se va a modificar una facura de Servicio
        '-------------------------------
        If Modifica Then
            'Me.gbTipo.EditValue = 1 = True
            EsModificacion()
            CargarCombos(TipoF)
            RealizarCalculos(0)

            'Mostrar IR 
            Me.txtSubTotalIR.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("SubTotalIR")

            'CalcularIR()
            Me.cmbdistribucion.Enabled = True   'Permitir Modificar Distribución en Facturas de Servicio
            Me.btnDetalle.Enabled = True

            'If strOrdenPago = "Orden de Pago" Then
            '    Me.etmsg.Text = "Modificar Orden de Pago"
            'End If
            'Else
            '    CargarCombos("P") ' Si es Factura Nueva
            'If txtOrden.Text = "" Then CargarCombos("P") ' Si es Factura Nueva
            'If strOrdenPago = "Orden de Pago" Then
            '    Me.etmsg.Text = "Nueva Orden de Pago"
            'End If
        Else
            txtfactura.Text = GetConsecutivo()
        End If
        '-------------------------------

        Distribucion()  'Buscar Distribucion

        Periodo = PeriodosDB.Activo(dtpFecha.DateTime.Date)
        Mes = dtpFecha.DateTime.Month
        Factura = txtfactura.Text.Trim

        'Segun Almori y RAMAC
        ckIVAAsumido.Visible = IVAAsumido

        If Modifica Then bImprimir.Enabled = True

        'If Me.gbTipo.EditValue = 0 Then
        '    Me.vFacturas.Columns("PrecioU").Visible = True
        'ElseIf Me.gbTipo.EditValue = 1 Then
        '    Me.vFacturas.Columns("PrecioU").Visible = False
        'ElseIf Me.gbTipo.EditValue = 4 Then
        '    Me.vFacturas.Columns("PrecioU").Visible = False
        'ElseIf Me.gbTipo.EditValue = 3 Then
        '    Me.vFacturas.Columns("PrecioU").Visible = True
        'End If

        ' If strOrdenPago = "Orden de Pago" Then Me.Text = "O R D E N  DE  P A G O"
        ' If strOrdenPago <> "Orden de Pago" Then Me.Text = "F.A.C.T.U.R.A  C.O.M.P.R.A"

        'If VerifyLiqOption() Then ckLiquidar.Visible = True
        'SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoInicio, Now, funciones.Eventos.Inicia, Me.txtfactura.Text.Trim)

        ckIR.Enabled = True
        Me.Refresh()
    End Sub

    Function GetConsecutivo() As String
        If EmpresaActual = 1 Then
            Return ""
        Else
            Dim obj As New ConsecutivosDocumentos
            Dim db As New db_ConsecutivosDocumentos

            obj = db.Detalles(EmpresaActual, "OP")

            If Not obj Is Nothing Then
                Return obj.Consecutivo + 1
            Else
                Return db.Ultimo(EmpresaActual, "OP") + 1
            End If
        End If

    End Function

    Sub CombosBox()

        SearchLookUp(cbProveedor,
                     ProveedoresDB.ProveedoresList(1).Tables("Proveedores"),
                     "Nombre",
                     "Codigo")
        'GetCatalogoProveedores(Me.cbProveedor, Me.vProvee)

        cbCatalogo.DataSource = ObtieneDatos(IIf(Modifica = True, "_GetCatalogo_Cuenta", "_GetCatalogo_CuentaActivo"), EmpresaActual)
        cbCatalogo.DisplayMember = "Display"
        cbCatalogo.ValueMember = "Cuenta"
        cbCatalogo.PopulateViewColumns()
        cbCatalogo.View.Columns("Display").Visible = False

        cbTipoFactura.Properties.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
        cbTipoFactura.Properties.ValueMember = "Codigo"
        cbTipoFactura.Properties.DisplayMember = "Nombre"
        cbTipoFactura.Properties.PopulateColumns()
        cbTipoFactura.Properties.Columns("Codigo").Visible = False
        cbTipoFactura.Properties.Columns("Dias").Visible = False
        cbTipoFactura.Properties.Columns("Empresa").Visible = False

        RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 4, 5, 6, 7, 8)
        RepositorySearchLook(cbOrdenCompra,
                             VB.SysContab.Ordenes_ComprasDB.FillComboLiquidacion(),
                             "Orden Compra",
                             "IdOrden",
                             0)


        'Me.cbMoneda.Properties.DataSource = ObtieneDatos("SELECT m.mon_codigo,upper(m.mon_simbolo + ' - ' + m.mon_descripcion) Nombre" _
        '                                                 + " FROM Monedas m WHERE m.empr_codigo = " & EmpresaActual)
        'Me.cbMoneda.Properties.DisplayMember = "Nombre"
        'Me.cbMoneda.Properties.ValueMember = "mon_codigo"
        'Me.cbMoneda.Properties.PopulateColumns()
        'Me.cbMoneda.Properties.Columns("mon_codigo").Visible = False
        'Me.cbMoneda.EditValue = MonedaBase

        GetMonedasList(cbMoneda)

        Try
            GetBodegasList(cbBodega)
            cbBodega.EditValue = ConfigDetalles.Bodega
        Catch ex As Exception
        End Try

    End Sub

    'Sub CargarProveedores()
    '    GetCatalogoProveedores(Me.cbProveedor, Me.vProvee)
    '    'Me.cbProveedor.Properties.DataSource = Nothing
    '    'If ChkProveedores Then  ' Mostrar Solo Proveedores Aprobados
    '    '    Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND (Aprobar = 1 AND Confirmar = 1) AND Empresa =" & EmpresaActual).DefaultView
    '    'Else
    '    '    Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND Empresa =" & EmpresaActual).DefaultView
    '    'End If
    '    'Me.cbProveedor.Properties.ValueMember = "Codigo"
    '    'Me.cbProveedor.Properties.DisplayMember = "Display"
    'End Sub

    Sub CargarCombos(ByVal p As String)
        If p = "I" Then
            'Me.cbCodigo1.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, ArticulosCC.ArticulosCCInvent().Tables("GruposCC"), "Display", "Codigo", 3, 4, 5, 6, 7, 8, 9)
        Else
            'GetArticulos()

            'Me.cbCodigo1.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, Articulos.ProductosGetLista(p).Tables("Articulos"), "Display", "Codigo", 3, 4, 5, 6, 7, 8, 9, 10)
        End If

        'Si es Nuevo
        If Not Modifica Then If OrdenCompra = 0 Then ds = Facturas_ComprasDB.GetFacturaCompraDetalle("", 0, 1)

        ' DT = ObtieneDatos("SELECT '' Codigo, 1.00 Cantidad,0.00 Precio,0.00 PrecioU,0.00 descuento,0.00 SubTotal,'' Temp,'' Tipo,'' Cuenta,convert(bit,0) Exento,0 AS NoPedido, '' Comentarios,0.00 ir,0 ClienteID,'' EmpleadoID,  0 IdProyecto FROM Usuarios WHERE 0=1")
        'gridDatos.DataSource = ds.Tables(0).DefaultView
        'End If

        'Si se va a modificar la Factura o Proviene de una orden de Compra
        'Try
        '    If Modifica Or Me.txtOrden.Text <> "" Then


        '        'If VerFactura Then
        '        '    For i As Integer = 0 To vFacturas.Columns.Count - 1
        '        '        If Not vFacturas.Columns(i).FieldName = "NoPedido" Then
        '        '            vFacturas.Columns(i).OptionsColumn.AllowEdit = False
        '        '            vFacturas.Columns(i).OptionsColumn.AllowFocus = False
        '        '        End If
        '        '    Next
        '        'End If
        '    End If
        'Catch ex As Exception
        'End Try

        gridDatos.DataSource = ds.Tables(0).DefaultView

        'Me.txtPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.txtPrecio.Mask.EditMask = RoundP
        'Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.txtPrecioU.Mask.EditMask = RoundP

        'vFacturas.Columns("Precio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vFacturas.Columns("Precio").DisplayFormat.FormatString = RoundP
        'vFacturas.Columns("PrecioU").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'vFacturas.Columns("PrecioU").DisplayFormat.FormatString = RoundP

        Me.txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Dim TC As DataTable = ObtieneDatos("_GetListTasaCambioDisponibles", EmpresaActual)

        If TC.Rows.Count > 0 Then
            Dim dr() As DataRow = TC.Select("MonedaCambio = '" & MonedaBase & "'")
            If dr.Length > 0 Then
                vFacturas.Columns("Precio").Caption = "Precio " & dr(0).Item("Simbolo").ToString
                lyTotal.Text = "Total " & dr(0).Item("Simbolo").ToString & ":"
            End If
        End If


        If Me.chkEmpleado.Checked Then
            CargarEmpleados()
            Me.vFacturas.Columns("EmpleadoID").Visible = Me.chkEmpleado.Checked
        End If
        '
        If Me.chkCliente.Checked Then
            CargarClientes()
            Me.vFacturas.Columns("ClienteID").Visible = Me.chkCliente.Checked
        End If

        'Proviene de una O/C
        If ds.Tables(0).Rows.Count > 0 And Nuevo = False Then
            If ds.Tables(0).Rows(0).Item("Liquidacion") Then vFacturas.Columns("IdOrdenCompra").Visible = False
        End If
    End Sub

    Sub ActualizarCambos(ByVal p As String)
        If p = "I" Then
            'Me.cbCodigo1.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, ArticulosCC.ArticulosCCInvent().Tables("GruposCC"), "Nombre", "Codigo", 3, 4, 5, 6)
        Else
            'Me.cbCodigo1.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, Articulos.ProductosGetLista(p).Tables("Articulos"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)
        End If
    End Sub

    'Private Sub GetArticulos()
    '    Dim p As String
    '    'If Me.gbTipo.EditValue = 0 Then p = "P" Else p = "I"
    '    If Me.gbTipo.EditValue = 0 Then p = "P" Else p = "I"
    '    Dim DT As DataTable
    '    DT = ObtieneDatos("SP_ArticulosGetAllC '" & p & "'," & EmpresaActual)
    '    cbCodigo1.DataSource = DT
    '    cbCodigo1.DisplayMember = "Codigo"
    '    cbCodigo1.ValueMember = "Codigo"
    '    cbCodigo1.PopulateColumns()

    '    For i As Integer = 2 To cbCodigo1.Columns.Count - 1
    '        cbCodigo1.Columns(i).Visible = False
    '    Next
    '    Try
    '        cbCodigo1.Columns(1).Visible = False
    '    Catch ex As Exception

    '    End Try
    '    cbCodigo2.DataSource = DT
    '    cbCodigo2.DisplayMember = "Nombre"
    '    cbCodigo2.ValueMember = "Codigo"
    '    cbCodigo2.PopulateColumns()
    '    For i As Integer = 2 To cbCodigo2.Columns.Count - 1
    '        cbCodigo2.Columns(i).Visible = False
    '    Next
    '    Try
    '        cbCodigo2.Columns(0).Visible = False
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(dtpFecha.DateTime.Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------
        GuardarFactura()
    End Sub

    Function GuardarFactura() As Boolean
        Try

            'For i As Integer = 0 To myDataSet.Tables(0).Rows.Count - 1
            'If Me.gbTipo.EditValue = 1 Then  'Verificar si Cuentas es Distribución

            '******** VERIFICAR DISTRIBUCION ************************
            For i As Integer = 0 To Me.vFacturas.DataRowCount - 1
                Dim CTemp As String = vbNullString
                Try
                    CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & Me.vFacturas.GetRowCellValue(i, "Cuenta") & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
                Catch ex As Exception
                    CTemp = "xxx"
                End Try

                If CTemp <> "xxx" And CTemp <> vbNullString Then
                    '
                    If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                        XtraMsg("La Cuenta " & Me.vFacturas.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                               "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                        Return False
                    End If
                End If
            Next
            '******** FIN VERIFICAR DISTRIBUCION ************************

            'End If

            'Guardar los datos de la Factura
            If Guardar() = False Then   'Funcion Para Guardar y Validar Factura
                HideSplash()
                Return False
            End If

            HideSplash()

            'Guardar los pagos efectuados a la factura
            'GuardarPagos()
            'If Me.Nuevo = False Then
            '    Salir = True
            '    Me.Close()
            '    'Return False
            'End If

            LimpiarALL()    'Limpiar todo el Formulario
            'CargarOrden = False

            If Modifica Or Nuevo = False Then

                Dim f As frmFacturasComprasList = frmFacturasComprasList.Instance
                If f.Created Then f.Cargar()
                '
                Salir = True
                Close()
            End If
        Catch ex As Exception
            XtraMsg(ex.Message & " Aceptar", MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    'Funcion para guardar los datos de la factura
    Private Function Guardar() As Boolean

        Dim DatT As DataTable = Nothing
        Dim DatLineaID As New DataTable : Dim LineaID As Integer
        DatLineaID.Columns.Add("LineaID")

        If Me.cbProveedor.EditValue Is Nothing Or IsNumeric(Me.cbProveedor.EditValue) = False Then
            XtraMsg("Seleccione el Proveedor")
            Me.cbProveedor.Focus()
            Return False
            Exit Function
        End If

        '**** Validar Cuenta Contable del Proveedor
        If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Cuenta.Trim.Length = 0 Then
            XtraMsg("El Proveedor No Tiene Cuenta Contable Asignada", MessageBoxIcon.Warning)
            Me.cbProveedor.Focus()
            Return False
        End If

        If Trim(txtfactura.Text) = "" Then
            XtraMsg("Introduzca el No. de Orden de Pago", MessageBoxIcon.Error)
            txtfactura.Focus()
            Return False
        End If

        If strOrdenPago = "Orden de Pago" Then
            If Trim(txtOrdenP.Text) = "" Then
                XtraMsg("Introduzca el No. de Factura", MessageBoxIcon.Error)
                txtOrdenP.Focus()
                Return False
            End If
        End If

        If cbTipoFactura.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Pago")
            cbTipoFactura.Focus()
            Return False
        End If

        If Me.txtComentario.Text.Trim.Length = 0 Then
            XtraMsg("Describa un Comentario de la Orden de Pago")
            Me.txtComentario.Focus()
            Return False
        End If

        If Me.vFacturas.DataRowCount = 0 Then
            XtraMsg("Seleccione al menos un Producto o Servicio", MessageBoxIcon.Error)
            Return False
        End If

        If CDbl(Me.etTotal.Text) < 0 Then
            XtraMsg("El Monto de la Orden de Pago deber ser Mayor que Cero (0)", MessageBoxIcon.Error)
            Return False
        End If

        If Not CalcularIR() Then
            Return False
        End If
        '
        If Not Modifica Then    'Si no es Modificación
            If strOrdenPago = "Orden de Pago" Then
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                '
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtfactura.Text)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Valor", SqlDbType.Int, 4, ParameterDirection.Output, 0)
                Conn.EjecutarComando("JAR_BuscarOrdenPago")
                '
                If Conn.GetParameter("Valor").Valor > 0 Then
                    XtraMsg("Esta Orden de Pago ya fue registrada", MessageBoxIcon.Error)
                    Me.txtfactura.Text = vbNullString
                    Me.txtfactura.Focus()
                    Return False
                End If
            Else
                'Dim DT As DataTable = ObtieneDatos("SELECT * FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Proveedor_ID = " & cbProveedor.EditValue & " AND Factura_ID='" & txtfactura.Text.Trim & "'")

                If ObtieneDatos("sp_BuscarFacturaCompra", txtfactura.Text.Trim, cbProveedor.EditValue, EmpresaActual).Rows.Count > 0 Then
                    XtraMsg("Esta Orden de Pago ya fue registrada", MessageBoxIcon.Error)
                    Me.txtfactura.Text = vbNullString
                    Me.txtfactura.Focus()
                End If
            End If

            'Dim DT2 As DataTable = ObtieneDatos("SELECT * FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Proveedor_ID = " & cbProveedor.EditValue & " AND NoOrden='" & Me.txtOrdenP.Text & "'")

            'If strOrdenPago = "Orden de Pago" Then
            '    If DT2.Rows.Count > 0 Then
            '        MsgBox("La Orden ya fue Registrada", MsgBoxStyle.Critical)
            '        Me.txtOrdenP.Text = vbNullString
            '        Me.txtOrdenP.Focus()
            '        Return False
            '    End If
            'End If
        Else
            'Buscar y verificar si la OP contiene pagos y no permitir modificar.
            If ObtieneDatos("sp_BuscarPagosFacturas", txtfactura.Text, cbProveedor.EditValue, EmpresaActual).Rows.Count > 0 Then
                'Validar Cambio de Fecha, que no sea de diferente mes
                If CInt(Month(ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha"))) <> CInt(dtpFecha.DateTime.Month) Then
                    XtraMsg("La Orden de Pago que intenta modificar ya contiene Pagos, No se puede cambiar de Mes." & vbCrLf & "Debe anular el Pago primero.", MessageBoxIcon.Error)
                    Return False
                End If

            End If
        End If


        'Dim Comp As New VB.SysContab.ComprobanteDB

        '******* Mostrar Detalle de la Distribución. ********************
        'Solicitado por RAMAC
        If ObligarDistribucion Then
            If DT_Distribucion.Rows.Count > 0 Then
                With frmDetalleDistribucionFacturas
                    .StartPosition = FormStartPosition.CenterParent
                    .DT = DT_Distribucion
                    '.DT.AcceptChanges()
                    .ShowDialog()
                    If .ok <> "SI" Then
                        Return False
                    End If
                End With
            End If
        End If

        ''BorrarDistribucion()

        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        'Dim Note As String = "ND" + txtfactura.Text.Trim ''.PadLeft(8, "0"c)  'Format(CInt(txtnota.Text), "000000")

        Try

            If Not Modifica Then
                '***********   Quitar Codigo de, solicitado por RAMAC
                If Not XtraMsg2("¿ Conforme con los Datos que Desea Guardar ?") Then
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Return False
                End If

                ShowSplash("Guardando...")

                'If InputBox("Conforme con el registro que desea guardar?", "Confirmacion de Registro").ToString <> CStr(ObtieneDatos("SELECT Codigo FROM CodigoFactura WHERE Tipo = " & TipoC).Rows(0).Item(0)) Then
                '    MsgBox("Codigo Invalido")
                '    VB.SysContab.Rutinas.ErrorTransaccion()
                '    Exit Function
                'End If
            Else

                If Not XtraMsg2("Va a Modificar Datos, ¿ Conforme con los Datos que Desea Guardar ?") Then
                    Rutinas.ErrorTransaccion()
                    Return False
                Else

                    ShowSplash("Actualizando...")

                    DatT = ObtieneDatosTrans("sp_GetComprobanteFactura", Factura, Periodo, Mes, cbProveedor.EditValue, EmpresaActual)

                    If DatT.Rows.Count = 0 Then
                        DatT = ObtieneDatosTrans("sp_GetComprobanteFactura", Factura, Periodo, Mes, cbProveedor.EditValue, EmpresaActual)
                    End If

                    'If Me.gbTipo.EditValue = 1 Then 'Si es Servicio
                    If DatT.Rows.Count > 0 Then
                        'Si el Comprobante esta dentro del mismo Mes, Solo Actualizar Encabezado
                        If CInt(DatT.Rows.Item(0)("Mes")) = CInt(Me.dtpFecha.DateTime.Month) Then

                            With DatT.Rows(0)

                                If Not Guardar_Con_Transaccion("sp_ComprobantesDetallesBorrar", .Item("Comp_No"), .Item("Per_Id"), .Item("Mes"), EmpresaActual) Then
                                    VB.SysContab.Rutinas.ErrorTransaccion()
                                    Return False
                                End If

                                ' If Not Guardar_Con_Transaccion("sp_Distribucion_Borrar", .Item("Comp_No"), .Item("Per_Id"), .Item("Mes"), EmpresaActual) Then Return False

                                'If GuardaDatosTrans("DELETE FROM ComprobantesDetalles WHERE Empresa = " & EmpresaActual & " AND Comp_No = '" & .Item("Comp_No") & "' AND Per_Id = " & .Item("Per_Id") & " AND Mes = " & .Item("Mes") & "") = False Then
                                '    XtraMsg("Error al modificar, intente nuevamente", MessageBoxIcon.Error)
                                'End If
                                'If GuardaDatosTrans("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = '" & .Item("Comp_No") & "' AND Per_Id = " & .Item("Per_Id") & " AND Mes = " & .Item("Mes")) = False Then
                                '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                                'End If
                            End With
                        Else
                            ComprobanteDB.ComprobanteAnular(DatT.Rows.Item(0)("Comp_No"), DatT.Rows.Item(0)("Per_Id"), DatT.Rows.Item(0)("Comp_Fecha"))

                            'GuardaDatosTrans("DELETE FROM Distribucion WHERE NoComp = " & DatT.Rows.Item(0)("Comp_No") & " AND Per_Id = " & DatT.Rows.Item(0)("Per_Id") & " AND IdEmpresa = " & EmpresaActual & " AND Mes = " & DatT.Rows.Item(0)("Mes"))
                            'Comp.CancelarFactura(DatT.Rows.Item(0)("Factura"), DatT.Rows.Item(0)("Proveedor"), 0)
                            'Comp.PagosFacturasBorrar(DatT.Rows.Item(0)("Comp_No"), DatT.Rows.Item(0)("Mes"), DatT.Rows.Item(0)("Per_Id"))
                        End If
                    End If

                    'End If
                    'If GuardaDatosTrans("DELETE FROM Facturas_Compras_Lineas WHERE Empresa_Id = " & EmpresaActual & " AND Factura_Id = '" & Factura & "'" & " AND Proveedor_ID = " & Me.cbProveedor.EditValue) = False Then
                    '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                    'End If
                    'If GuardaDatosTrans("DELETE FROM Facturas_Compras WHERE Empresa_Id = " & EmpresaActual & " AND Factura_ID = '" & Factura & "'" & " AND Proveedor_ID = " & Me.cbProveedor.EditValue) = False Then
                    '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                    'End If
                    'If GuardaDatosTrans("DELETE FROM FacturasFechas WHERE Empresa = " & EmpresaActual & " AND Factura = '" & Factura & "'" & " AND Proveedor = " & Me.cbProveedor.EditValue) = False Then
                    '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                    'End If

                    'If GuardaDatosTrans("DELETE FROM FacturasTransacciones WHERE Empresa_Id = " & EmpresaActual & " AND Factura_Id = '" & Factura & "'" & " AND Proveedor_ID = " & Me.cbProveedor.EditValue) = False Then
                    '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                    'End If
                    ' ''
                    'Dim NoNota = "ND" + txtfactura.Text.Trim
                    'If Not GuardaDatosTrans("DELETE FROM MaestroNotasCD WHERE NoNota = '" & NoNota & "' AND Empresa = " & EmpresaActual) Then
                    '    MsgBox("Error al modificar, intente nuevamente", MsgBoxStyle.Critical)
                    'End If
                End If
            End If

            Dim FacEstado As String = "P"
            Dim CantAlmac As Integer = 0

            If Me.gbTipo.EditValue = 1 Then FacEstado = "F"

            'If Me.gbTipo.EditValue = 1 Then 'Servicio
            If Modifica Then    'Si se va a modificar la Factura de Servicio
                If DatT.Rows.Count > 0 Then
                    If Not Contabilizar(DatT.Rows(0).Item("Comp_No"), DatT.Rows(0).Item("Mes")) Then
                        Return False
                    End If
                Else
                    If Not Contabilizar() Then
                        Return False
                    End If
                End If
            Else    'Si es Nueva Factura de Servicio
                If Not Contabilizar() Then
                    Return False
                End If
            End If
            'FacEstado = "F"
            'End If

            'If Me.etOrigen.Text = "2" And Not Modifica Then Facturas.UpdateNumero(Me.txtfactura.Text.Trim, Me.txtOrden.Text, cbProveedor.EditValue)
            'Else

            'Guardar Porcentaje de IR
            Dim irP As Double = 0.00
            If ckIR.Checked Then
                If gbTipo.EditValue = 1 Then    'Para los servicios
                    irP = IsNull(vFacturas.GetRowCellValue(0, "ir"), 0)
                Else
                    If Me.gbIR.EditValue = 1 Then   '10%
                        irP = ConfigDetalles.IRServ
                    Else
                        irP = ConfigDetalles.IRProd
                    End If
                End If
            End If

            If Not Modifica Then

                LineaID = Facturas.AddItem(
                    txtfactura.Text.Trim,
                    dtpFecha.DateTime.Date,
                    dtpFechaPago.DateTime.Date,
                    Me.cbProveedor.EditValue,
                    etTotal.Text,
                    cbTipoFactura.EditValue,
                    Me.gbTipo.EditValue,
                    1,
                    0,
                    txtOrden.Text,
                    1,
                    0,
                    Me.txtComentario.Text,
                    FacEstado,
                    Me.ckIR.Checked,
                    Me.ckIVAAsumido.Checked,
                    IIf(Me.gbIR.EditValue = 1, True, False),
                    IIf(Me.gbIR.EditValue = 0, True, False),
                    Me.chkIRAlc.Checked,
                    IIf(Me.chkEmpleado.Checked, 1, 0),
                    IIf(Me.chkCliente.Checked, 1, 0),
                    etTasa.EditValue,
                    Me.chkParalelo.Checked,
                    Me.cbMoneda.EditValue,
                    IIf(Me.txtOrdenP.Text.Trim.Length = 0, "", Me.txtOrdenP.Text),
                    irP,
                    IIf(gbTipo.EditValue = 1, "", IIf(Me.cbBodega.EditValue Is Nothing, "", Me.cbBodega.EditValue)),
                    txtSubTotalIR.EditValue,
                    IIf(chkLiquidar.Checked, 1, 0))

                'Facturas.ActualizarSubTotalIR(Me.txtfactura.Text.Trim, Me.cbProveedor.EditValue, IIf(Me.ckIR.Checked, Me.txtSubTotalIR.EditValue, 0))
                ComprobanteDB.AddFacturaFecha(
                    cbProveedor.EditValue,
                    txtfactura.Text.Trim,
                    dtpFechaRecep.DateTime.Date)

                'If VerifyLiqOption() Then
                '    If ckLiquidar.Checked Then
                '        SaveLiq(LineaID)
                '    End If
                'End If

                'Marcar Orden de Compra como Facturada.
                'Actualizar Estado de la Orden de Commpra
                If OrdenCompra <> 0 Then Facturas.OrdenesComprasUpdateEstado(OrdenCompra, "F", txtfactura.Text)
            Else
                If Not Facturas.Update(txtfactura.Text.Trim, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue,
                                etTotal.Text, cbTipoFactura.EditValue, gbTipo.EditValue, 1, 0, txtOrden.Text, 1, 0,
                                txtComentario.Text, FacEstado, cbProveedor.EditValue, ckIR.Checked,
                                ckIVAAsumido.Checked, IIf(gbIR.EditValue = 1, True, False),
                                 IIf(gbIR.EditValue = 0, True, False), chkIRAlc.Checked, txtSubTotalIR.EditValue,
                                 etTasa.EditValue, chkParalelo.Checked, cbMoneda.EditValue,
                                 IIf(Me.txtOrdenP.Text.Trim.Length = 0, "", Me.txtOrdenP.Text),
                                  irP,
                                  cbBodega.EditValue) Then Return False
            End If

            'Borrar el Detalle del la Factura de Compra
            Facturas.DeleteDetalle(
                txtfactura.Text.Trim,
                cbProveedor.EditValue)

            Dim Descuento As Double = 0.0,
                DescuentoValor As Double = 0.0

            Dim Comision As Double = 0.0
            Dim IVA As Double = 0.0
            'Dim Comisiones As New VB.SysContab.ComisionDB
            Dim MontoCliente As Double = 0

            For i = 0 To Me.vFacturas.DataRowCount - 1
                If chkCliente.Checked Then
                    '' Si la Orden se va a Cargar a un Cliente, entonces Generar ND Automática
                    Try
                        If Not vFacturas.GetRowCellValue(i, "ClienteID") Is Nothing Or Not IsDBNull(vFacturas.GetRowCellValue(i, "ClienteID")) Then
                            If vFacturas.GetRowCellValue(i, "ClienteID") > 0 Then
                                MontoCliente += vFacturas.GetRowCellValue(i, "SubTotal")
                                IdCliente = vFacturas.GetRowCellValue(i, "ClienteID")
                            End If
                        End If
                    Catch ex As Exception
                        MontoCliente = 0
                        IdCliente = 0
                    End Try
                End If

                DescuentoValor =
                    CDbl((Me.vFacturas.GetRowCellValue(i, "Cantidad") * Me.vFacturas.GetRowCellValue(i, "Precio")) * (Me.vFacturas.GetRowCellValue(i, "Descuento")) / 100).ToString(Round)

                If Me.gbTipo.EditValue = 1 Then 'Servicio
                    CantAlmac = Me.vFacturas.GetRowCellValue(i, "Cantidad")
                End If
                ''''No guardar la Factura solamente el No. de Factura en la Orden de Compra
                ''''Facturas.AddFacturaLineas(txtFactura.Text, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), Descuento, (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - Descuento) * ConfigDetalles.IVA / 100.0, tCust.Rows(i)("Tipo"))
                Dim Exento As Boolean = Me.vFacturas.GetRowCellValue(i, "Exento")

                If Me.ckIVAAsumido.Checked Then
                    IVA = 0
                Else
                    If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False Then
                        IVA = 0
                    Else
                        If Exento Then  'Si el Producto esta Exento de IVA
                            IVA = 0
                        Else
                            IVA = Me.vFacturas.GetRowCellValue(i, "SubTotal") * (ConfigDetalles.IVA / 100)
                        End If
                    End If
                End If

                LineaID = Facturas.AddFacturaLineas(txtfactura.Text.Trim, Me.vFacturas.GetRowCellValue(i, "Codigo"),
                Me.vFacturas.GetRowCellValue(i, "Cantidad"),
                Me.vFacturas.GetRowCellValue(i, "Precio"),
                Me.vFacturas.GetRowCellValue(i, "descuento"),
                IVA.ToString(Round), Me.vFacturas.GetRowCellValue(i, "Tipo"),
                CantAlmac, IVA.ToString(Round), ConfigDetalles.IVA, Me.cbProveedor.EditValue,
                IIf(Me.vFacturas.GetRowCellValue(i, "Comentarios").ToString.Length = 0, "", Me.vFacturas.GetRowCellValue(i, "Comentarios").ToString),
                IIf(Me.vFacturas.GetRowCellValue(i, "Cuenta").ToString.Length = 0, "", Me.vFacturas.GetRowCellValue(i, "Cuenta").ToString),
                IIf(Me.vFacturas.GetRowCellValue(i, "EmpleadoID").ToString.Length = 0, "", IsNull(Me.vFacturas.GetRowCellValue(i, "EmpleadoID").ToString, 0)),
                IIf(Me.vFacturas.GetRowCellValue(i, "ClienteID").ToString.Length = 0, 0, IsNull(Me.vFacturas.GetRowCellValue(i, "ClienteID").ToString, 0)),
                irP,
                IsNull(vFacturas.GetRowCellValue(i, "IdProyecto"), 0),
                IsNull(vFacturas.GetRowCellValue(i, "IdOrdenCompra"), 0))

                'If VerifyLiqOption() Then
                '    If ckLiquidar.Checked Then
                '        DatLineaID.Rows.Add(LineaID)
                '        DatLineaID.NewRow()
                '    End If
                'End If
            Next
            'End If

            'If CargarOrden = True Or txtOrden.Text.Trim <> "" Then 'Actualizar Estado de la Orden de Commpra
            '    Facturas.OrdenesComprasUpdateEstado(IIf(OrdenCompra = "0", txtOrden.Text, OrdenCompra), "F")
            'End If

            'Para agregar el detalle de los gastos de las liquidaciones 
            'If VerifyLiqOption() Then
            '    If ckLiquidar.Checked Then
            '        Dim DatosLiq, VariablesLiq As New ArrayList

            '        For i As Integer = 0 To vFacturas.DataRowCount - 1
            '            Try
            '                If IsNull(vFacturas.GetRowCellValue(i, "NoPedido"), "0") <> "0" Then
            '                    Dim fila As DataRowView = cbOrdenCompra.GetDataSourceRowByKeyValue(vFacturas.GetRowCellValue(i, "NoPedido"))
            '                    DatosLiq.Clear() : VariablesLiq.Clear()

            '                    VariablesLiq.Add("MTID") : VariablesLiq.Add("GastoID") : VariablesLiq.Add("FacturaID")
            '                    VariablesLiq.Add("ItemID") : VariablesLiq.Add("Monto") : VariablesLiq.Add("Desgloce")
            '                    VariablesLiq.Add("EmpresaID")

            '                    DatosLiq.Add(fila.Item(0)) : DatosLiq.Add(1) : DatosLiq.Add(DatLineaID.Rows(i).Item(0)) 'DatosLiq.Add(txtfactura.Text.Trim)
            '                    : DatosLiq.Add(vFacturas.GetRowCellValue(i, "Codigo"))
            '                    DatosLiq.Add(vFacturas.GetRowCellValue(i, GridColumn23))
            '                    : DatosLiq.Add(0) : DatosLiq.Add(EmpresaActual)
            '                    '
            '                    ProcedureSave(DatosLiq, VariablesLiq, "SPJLiqMTAddDetalle")
            '                End If
            '            Catch ex As Exception
            '                VB.SysContab.Rutinas.ErrorTransaccion()
            '                Return False
            '            End Try
            '        Next
            '    End If
            'End If

            Rutinas.okTransaccion()
            'SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtfactura.Text.Trim)


            '***********************************  Grabar ND al Cliente *******************************
            'If chkCliente.Checked Then
            '    If MontoCliente <> 0 Then
            '        Dim TipoCompr As Integer = 0
            '        Try
            '            TipoCompr = ObtieneDatos("SELECT tc.TipComp_Id FROM TipoComprobantes tc WHERE tc.TipComp_Tipo = 1 AND tc.Empresa = " & EmpresaActual).Rows.Item(0)(0)
            '        Catch ex As Exception
            '            TipoCompr = 0
            '        End Try

            '        Dim Note As String = "NDC"

            '        If MontoCliente > 0 Then Note = "ND" + txtfactura.Text.Trim
            '        If MontoCliente < 0 Then Note = "NC" + txtfactura.Text.Trim

            '        If GuardaDatos("SPBorrarNota 0,'" & Note & "'," & IdCliente & "," & EmpresaActual) Then

            '            Dim Variables As New ArrayList, Datos As New ArrayList

            '            'Variables.Clear()
            '            'Variables.Add("NoNota")
            '            'Variables.Add("IdCliente")
            '            'Variables.Add("Empresa")
            '            'Variables.Add("Fecha")
            '            'Variables.Add("TipoComprobante")
            '            'Variables.Add("Monto")
            '            'Variables.Add("Comentario")
            '            'Variables.Add("Tipo")

            '            Variables.Clear()
            '            Variables.Add("NoNota")
            '            Variables.Add("IdCliente")
            '            Variables.Add("Empresa")
            '            Variables.Add("Fecha")
            '            Variables.Add("TipoComprobante")
            '            Variables.Add("Monto")
            '            Variables.Add("Comentario")
            '            Variables.Add("Tipo")
            '            Variables.Add("Anulado")
            '            Variables.Add("Moneda")
            '            Variables.Add("Comp_No")
            '            Variables.Add("Per_Id")
            '            Variables.Add("Mes")
            '            Variables.Add("Vencimiento")

            '            Datos.Clear()
            '            Datos.Add(Note)
            '            Datos.Add(IdCliente)
            '            Datos.Add(EmpresaActual)
            '            Datos.Add(dtpFecha.DateTime.Date)
            '            Datos.Add(TipoCompr)
            '            Datos.Add(IIf(MontoCliente < 0, MontoCliente * -1, MontoCliente))
            '            Datos.Add(txtComentario.Text)
            '            Datos.Add(IIf(MontoCliente > 0, 2, 1))
            '            Datos.Add(0)
            '            Datos.Add(cbMoneda.EditValue)
            '            Datos.Add(NoComprob)
            '            Datos.Add(PeriodosDB.Activo(dtpFecha.DateTime.Date))
            '            Datos.Add(dtpFecha.DateTime.Date.Month)
            '            Datos.Add(dtpFechaPago.DateTime.Date)

            '            'Datos.Clear()
            '            'Datos.Add(Note)
            '            'Datos.Add(IdCliente)
            '            'Datos.Add(EmpresaActual)
            '            'Datos.Add(dtpFecha.DateTime.Date)
            '            'Datos.Add(TipoCompr)
            '            'Datos.Add(IIf(MontoCliente < 0, MontoCliente * -1, MontoCliente))
            '            'Datos.Add(txtComentario.Text)
            '            'Datos.Add(IIf(MontoCliente > 0, 2, 1))

            '            Dim IdNota As Integer = ProcedureParameters(Datos, Variables, "SP_GuardaMaestroNotasCD").Rows(0).Item(0)
            '        End If
            '    End If
            'End If
            '*********************************** FIN Grabar ND al Cliente *******************************
            '
            If OrdenCompra <> 0 Then
                'Mostrar Datos en Lista de Ordenes de Commpra
                Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()
                If f.Created Then f.Cargar()
            End If

            'If CargarOrden = True Or txtOrden.Text.Trim <> "" Then
            '    Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance
            '    f.Cargar()
            'End If

            Return True
        Catch ex As Exception
            XtraMsg("ERROR: en Guardar" & ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
            Return False
            Exit Function
        End Try
OK:
        Return True
    End Function

    Private Function Contabilizar(Optional ByVal Compr As Integer = 0, Optional ByVal Mes As Integer = 0) As Boolean
        Dim DetallesServicio As New VB.SysContab.ServiciosDetails
        Dim Servicios As New VB.SysContab.ServiciosDB

        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim CompNo As String
        Dim Tipo As String
        Dim TipoCompr As String
        Dim EmpresasDB As New VB.SysContab.EmpresasDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB
        Dim ds As DataSet
        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim plan As String

        Dim Cuentas(Me.vFacturas.DataRowCount) As String
        Dim Montos(Me.vFacturas.DataRowCount) As Double

        plan = Plantilla.GetTipoPlantilla(1, 9).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay Plantilla Disponible para realizar Esta Transacción", MsgBoxStyle.Information)
            VB.SysContab.Rutinas.ErrorTransaccion()
            Return False
        End If

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ds = Detalles.Detalles

        Dim IRxPagar As Double = 0
        Dim IRxPagarAlcaldia As Double = 0
        Dim IRPorcentaje As Double = 0
        Dim j, x As Integer

        'Dim Muni As New VB.SysContab.MunicipiosDB
        Dim MunDet As VB.SysContab.MunicipioDetails = VB.SysContab.MunicipiosDB.GetDetails(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Departamento, ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Municipio)

        '*****************************************************************
        If Me.ckIR.Checked Then 'Calcular IR x Pagar
            Dim MontoIR As Double = 0
            '
            If Me.gbTipo.EditValue = 1 Then 'Servicios
                IRPorcentaje = Me.vFacturas.GetRowCellValue(0, "ir")
                Dim dtIR As DataTable = ObtieneDatosTrans("sp_GetPorcentajeRetension '" & Me.vFacturas.GetRowCellValue(0, "Codigo") & "'," & EmpresaActual)
                If dtIR.Rows.Count > 0 Then
                    MontoIR = dtIR.Rows.Item(0)("MontoRetencion")
                Else
                    MontoIR = ConfigDetalles.MontoIR
                End If
            Else
                If Me.gbIR.EditValue = 1 Then   'Servicio 10%
                    IRPorcentaje = ConfigDetalles.IRServ
                ElseIf Me.gbIR.EditValue = 0 Then 'Producto/Servicio Generales
                    IRPorcentaje = ConfigDetalles.IRProd
                End If
                '
                MontoIR = ConfigDetalles.MontoIR
            End If

            If Me.txtSubTotalIR.EditValue >= MontoIR Then
                IRxPagar = Me.txtSubTotalIR.EditValue * (IRPorcentaje / 100)
            End If
        Else
            IRxPagar = 0
        End If
        '*******************************************************************

        'If Me.ckIR.Checked Then
        '    If Me.txtSubTotalIR.EditValue >= ConfigDetalles.MontoIR Then
        '        IRxPagar = Me.txtSubTotalIR.EditValue * (IRPorcentaje / 100)
        '    End If
        '    'If Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue >= ConfigDetalles.MontoIR Then
        '    '    IRxPagar = Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue * (IRPorcentaje / 100)
        '    'End If
        'Else
        '    IRxPagar = 0
        'End If

        ' Calcular IR x Pagar de la ALCALDIA
        If Me.chkIRAlc.Checked Then
            If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Departamento = "0" And ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Municipio = "0" Then
                XtraMsg("No se puede completar la facturación, por favor ingrese departamento o municipio del Proveedor", MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
            End If

            If Me.txtSubTotalIR.EditValue >= MunDet.Impuesto_SVenta_Min Then
                IRxPagarAlcaldia = Me.txtSubTotalIR.EditValue * (MunDet.Impuesto_SVenta / 100)
            End If

            'If Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue >= MunDet.Impuesto_SVenta_Min Then
            '    IRxPagarAlcaldia = Me.vFacturas.Columns("SubTotal").SummaryItem.SummaryValue * (MunDet.Impuesto_SVenta / 100)
            'End If
        Else
            IRxPagarAlcaldia = 0
        End If

        TipoCompr = Detalles.TipoCompr
        ' en el campo Tipo, se enviaba '0' y segun la tabla de Comprobantes, ese campo debe tener 1 si es factura de proveedor
        If Modifica Then
            'Actualizar Encabezado de Comprobante
            If Mes = CInt(Me.dtpFecha.DateTime.Month) Then
                CompNo = Compr
                Dim Datos As New ArrayList
                Dim Variables As New ArrayList
                Variables.Add("Tipo")
                Variables.Add("Concepto")
                Variables.Add("Fecha")
                Variables.Add("Pago")
                Variables.Add("Factura")
                Variables.Add("FormaPago")
                Variables.Add("Comp")
                Variables.Add("Periodo")
                Variables.Add("Empresa")
                Variables.Add("Mes")
                Variables.Add("Moneda")
                Variables.Add("Tasa")

                Datos.Add(TipoCompr)
                Datos.Add(IIf(txtComentario.Text.Trim.Length = 0, "Comprobante de Orden de Pago, O/P#: " & txtfactura.Text.Trim & " del Proveedor " & cbProveedor.Text & ".", Me.txtComentario.Text))
                Datos.Add(dtpFecha.DateTime.Date)
                Datos.Add(dtpFecha.DateTime.Date) ' CAMBIADO POR BAR --  ESTO ES POR LO QUE LOS COMPROBANTES CAMBIAN D MES 04/06/08
                Datos.Add(txtfactura.Text.Trim)
                Datos.Add(cbTipoFactura.EditValue)
                Datos.Add(CompNo)
                Datos.Add(Periodo)
                Datos.Add(EmpresaActual)
                Datos.Add(Mes)
                Datos.Add(cbMoneda.EditValue)
                Datos.Add(etTasa.EditValue)

                ProcedureSave(Datos, Variables, "SPActualizacomprobante")
            Else
                'Crear Encabezado del Comprobante
                CompNo = ComprobanteDB.AddComprobante(TipoCompr, Me.etTasa.EditValue, IIf(Me.txtComentario.Text.Trim.Length = 0, "Comprobante de Compra, Factura #: " & Me.txtfactura.Text.Trim & " del Proveedor " & Me.cbProveedor.Text & ".", Me.txtComentario.Text),
                                                     Me.cbMoneda.EditValue, PeriodosDB.Activo(dtpFecha.DateTime.Date), Me.dtpFecha.DateTime.Date, 0, "", False,
                                                    Me.cbProveedor.EditValue, "", 1, Me.txtfactura.Text.Trim, VB.SysContab.Rutinas.Fecha,
                                                    Me.cbTipoFactura.EditValue, IIf(gbTipo.EditValue = 0, OrigenComprobantes.ENTRADA_ALMACEN, OrigenComprobantes.ORDEN_DE_PAGO))
            End If
        Else
            CompNo = ComprobanteDB.AddComprobante(TipoCompr, Me.etTasa.EditValue, IIf(Me.txtComentario.Text.Trim.Length = 0, "Comprobante de Compra, Factura #: " & Me.txtfactura.Text.Trim & " del Proveedor " & Me.cbProveedor.Text & ".", Me.txtComentario.Text),
                                                Me.cbMoneda.EditValue, PeriodosDB.Activo(dtpFecha.DateTime.Date), Me.dtpFecha.DateTime.Date, 0, "", False,
                                                Me.cbProveedor.EditValue, "", 1, Me.txtfactura.Text.Trim, VB.SysContab.Rutinas.Fecha,
                                                Me.cbTipoFactura.EditValue, IIf(gbTipo.EditValue = 0, OrigenComprobantes.ENTRADA_ALMACEN, OrigenComprobantes.ORDEN_DE_PAGO))

            ''***********************************  Grabar ND al Cliente *******************************
            'If chkCliente.Checked Then
            '    If MontoCliente <> 0 Then
            '        Dim Note As String = "NDC"

            '        If MontoCliente > 0 Then Note = "ND" + txtfactura.Text.Trim
            '        If MontoCliente < 0 Then Note = "NC" + txtfactura.Text.Trim

            '        If Guardar_Con_Transaccion("SPBorrarNota", 0, Note, IdCliente, EmpresaActual) Then


            '        End If

            '        If GuardaDatos("SPBorrarNota 0,'" & Note & "'," & IdCliente & "," & EmpresaActual) Then

            '                Dim Variables As New ArrayList, Datos As New ArrayList

            '                Variables.Clear()
            '                Variables.Add("NoNota")
            '                Variables.Add("IdCliente")
            '                Variables.Add("Empresa")
            '                Variables.Add("Fecha")
            '                Variables.Add("TipoComprobante")
            '                Variables.Add("Monto")
            '                Variables.Add("Comentario")
            '                Variables.Add("Tipo")
            '                Variables.Add("Anulado")
            '                Variables.Add("Moneda")
            '                Variables.Add("Comp_No")
            '                Variables.Add("Per_Id")
            '                Variables.Add("Mes")
            '                Variables.Add("Vencimiento")

            '                Datos.Clear()
            '                Datos.Add(Note)
            '                Datos.Add(IdCliente)
            '                Datos.Add(EmpresaActual)
            '                Datos.Add(dtpFecha.DateTime.Date)
            '                Datos.Add(TipoCompr)
            '                Datos.Add(IIf(MontoCliente < 0, MontoCliente * -1, MontoCliente))
            '                Datos.Add(txtComentario.Text)
            '                Datos.Add(IIf(MontoCliente > 0, 2, 1))
            '                Datos.Add(0)
            '                Datos.Add(cbMoneda.EditValue)
            '                Datos.Add(NoComprob)
            '                Datos.Add(PeriodosDB.Activo(dtpFecha.DateTime.Date))
            '                Datos.Add(dtpFecha.DateTime.Date.Month)
            '                Datos.Add(dtpFechaPago.DateTime.Date)

            '                Dim IdNota As Integer = ProcedureParameters(Datos, Variables, "SP_GuardaMaestroNotasCD").Rows(0).Item(0)
            '            End If
            '        End If
            '    End If
            ''*********************************** FIN Grabar ND al Cliente *******************************
        End If
        ' x = 0

        For i As Integer = 0 To vFacturas.DataRowCount - 1

            If Me.vFacturas.GetRowCellValue(i, "Cuenta") = "0" Or Me.vFacturas.GetRowCellValue(i, "Cuenta") = "" Then
                XtraMsg("No se puede crear la factura porque el Item " & Me.vFacturas.GetRowCellValue(i, "Codigo") & " no tiene cuenta contable.", MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
            Else
                If IsNull(vFacturas.GetRowCellValue(i, "Comentarios"), String.Empty).ToString().Trim.Length > 0 Then
                    ' If Me.gbTipo.EditValue = 1 Then 'Servicios 
                    Dim valor As Double = 0

                    If Me.ckIVAAsumido.Checked Then
                        Dim Det As VB.SysContab.ArticulosDetails =
                            VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(i, "Codigo"), "S")

                        If Det.Exento = True Then
                            valor = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "SubTotal")), 2)
                        Else
                            valor = Math.Round(CDbl((vFacturas.GetRowCellValue(i, "SubTotal")) * (1 + (ConfigDetalles.IVA / 100.0))), 2)
                        End If
                    Else
                        valor = Math.Round(CDbl(vFacturas.GetRowCellValue(i, "SubTotal")), 2)
                    End If

                    ComprobanteDB.AddComprobanteDetalles(CompNo, Me.vFacturas.GetRowCellValue(i, "Cuenta"),
                                            IIf(Me.vFacturas.GetRowCellValue(i, "Comentarios") Is Nothing, "", Me.vFacturas.GetRowCellValue(i, "Comentarios").ToString),
                                            IIf(valor < 0, valor * -1, valor), 0, TipoCompr, IIf(valor < 0, "C", "D"),
                                            Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 1, 0, "",
                                            IsNull(vFacturas.GetRowCellValue(i, "IdProyecto"), 0),
                                            IsNull(vFacturas.GetRowCellValue(i, "IdOrdenCompra"), 0))
                Else    'Productos/Iventario
                    j = Cuentas.IndexOf(Cuentas, Me.vFacturas.GetRowCellValue(i, "Cuenta"))

                        If j = -1 Then
                            Cuentas(x) = Me.vFacturas.GetRowCellValue(i, "Cuenta")
                            If Me.ckIVAAsumido.Checked Then
                                If Me.vFacturas.GetRowCellValue(i, "Exento") Then
                                    Montos(x) = CDbl(vFacturas.GetRowCellValue(i, "SubTotal"))
                                Else
                                    Montos(x) = CDbl((vFacturas.GetRowCellValue(i, "SubTotal")) * (1 + (ConfigDetalles.IVA / 100.0)))
                                End If
                            Else
                                Montos(x) = CDbl(vFacturas.GetRowCellValue(i, "SubTotal"))
                            End If
                            x += 1
                        Else
                            If Me.ckIVAAsumido.Checked Then
                                If Me.vFacturas.GetRowCellValue(i, "Exento") Then
                                    Montos(j) = Montos(j) + CDbl(vFacturas.GetRowCellValue(i, "SubTotal"))
                                Else
                                    Montos(j) = Montos(j) + CDbl((vFacturas.GetRowCellValue(i, "SubTotal")) * (1 + (ConfigDetalles.IVA / 100.0)))
                                End If
                            Else
                                Montos(j) = Montos(j) + CDbl(vFacturas.GetRowCellValue(i, "SubTotal"))
                            End If
                        End If
                    End If
                End If
        Next
        '
        ' If Me.gbTipo.EditValue <> 1 Then
        For i As Integer = 0 To Cuentas.GetUpperBound(0)
            If Cuentas(i) <> "" Then
                ComprobanteDB.AddComprobanteDetalles(CompNo, Cuentas(i), "",
                                                Math.Round(CDbl(Montos(i)), 2), 0, TipoCompr, "D",
                                                Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 1, 0, "",
                                                 IsNull(vFacturas.GetRowCellValue(i, "IdProyecto"), 0),
                                                 IsNull(vFacturas.GetRowCellValue(i, "IdOrdenCompra"), 0))
            End If
        Next
        'End If


        '**********************************************************
        'Se agrega la cuenta del IVA
        If IIf(etIva.Text = "", 0, CDbl(etIva.Text)) <> 0 Then
            ComprobanteDB.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta"), "I.V.A",
            Math.Round(CDbl(etIva.Text), 2), 0, TipoCompr, "D", Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 1, 1)
        End If

        '**********************************************************
        'Se agrega la cuenta Proveedor y se verifica la cuenta
        If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Cuenta = "" Or ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Cuenta Is Nothing Then
            MsgBox("Falta la Cuenta Contable del Proveedor", MsgBoxStyle.Exclamation)
            VB.SysContab.Rutinas.ErrorTransaccion()
            Return False
        End If

        '**********************************************************
        'Si el Proveedor es Exento de IR entonces IRxPagar = 0
        ComprobanteDB.AddComprobanteDetalles(CompNo, ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Cuenta, ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Nombre,
        Math.Round(CDbl(CDbl(Me.etTotal.Text) - IRxPagar - IRxPagarAlcaldia), 2),
        0, TipoCompr, "C", Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 0)

        '**********************************************************
        'Se agrega la cuenta del IR
        If Me.ckIR.Checked Then
            'If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Exento = False Then
            If IRxPagar > 0 Then
                Dim CuentaIR As String

                If Me.gbIR.EditValue = 0 Then CuentaIR = ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                If Me.gbIR.EditValue = 1 Then CuentaIR = ds.Tables("PlantillasDetalles").Rows(4).Item("Cuenta")

                ComprobanteDB.AddComprobanteDetalles(CompNo,
                CuentaIR, "I.R",
                Math.Round(CDbl(IRxPagar), 2),
                0, TipoCompr, "C", Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 1, 2)
            End If
            'End If
        End If

        '****************************************************
        'SE AGREGA EL I.R. de la ALCALDIA
        If Me.chkIRAlc.Checked Then
            If IRxPagarAlcaldia > 0 Then
                ComprobanteDB.AddComprobanteDetalles(CompNo, ds.Tables("PlantillasDetalles").Rows(5).Item("Cuenta"), "Alcaldia",
                Math.Round(CDbl(IRxPagarAlcaldia), 2), 0, TipoCompr, "C", Me.txtfactura.Text.Trim, 0, Me.dtpFecha.DateTime, 1, 3)
            End If
        End If

        'BAR
        'For i As Integer = 0 To Me.vFacturas.DataRowCount - 1
        '    Plantilla.UpdateCuentaGastos(ds.Tables("PlantillasDetalles").Rows(0).Item("Plantilla_ID"), Me.vFacturas.GetRowCellValue(i, "Cuenta"))
        'Next

        '**************************************
        'Guarda la Distribucion
        GuardaDistribucionTrans(DT_Distribucion, dtpFecha.DateTime.Date, CompNo)
        DistribucionTrans()
        'Fin de Guarda Distribucion
        '**************************************
        Return True
    End Function

    'Private Sub cbProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbProveedor.ButtonClick
    '    If e.Button.Index = 1 Then  'Si Da Clic en el Boton Agregar

    '        Dim f As New frmAgregarProveedorQuick
    '        f.Nuevo = "SI"
    '        f.StartPosition = FormStartPosition.CenterScreen
    '        f.ShowDialog()

    '        CargarProveedores()
    '        If Not ChkProveedores Then Me.cbProveedor.EditValue = CInt(f.txtCodigo.Text)
    '        f.Dispose()

    '    ElseIf e.Button.Index = 2 Then
    '        CargarProveedores()
    '    ElseIf e.Button.Index = 3 Then
    '        Try
    '            If Me.cbProveedor.EditValue Is Nothing Or IsNumeric(Me.cbProveedor.EditValue) = False Then
    '                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
    '                Me.cbProveedor.Focus()
    '            Else
    '                Dim f As New frmAgregarProveedorQuick
    '                Registro = Me.cbProveedor.EditValue
    '                f.Nuevo = "NO"
    '                f.StartPosition = FormStartPosition.CenterScreen
    '                f.ShowDialog()

    '                CargarProveedores()
    '                cbProveedor_EditValueChanged(Nothing, Nothing)
    '                f.Dispose()
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    'Private Sub cbCodigo1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    '    Dim p As String = String.Empty
    '    Dim DR As DataRowView

    '    Try
    '        'DR = Me.cbCodigo1.GetDataSourceRowByKeyValue(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"))
    '        If gbTipo.EditValue = 0 Then
    '            p = "P"
    '        ElseIf Me.gbTipo.EditValue = 1 Then
    '            p = "S"
    '        ElseIf Me.gbTipo.EditValue = 4 Then
    '            p = "I"
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try

    '    'Agregar Nuevos Productos / Servicios
    '    If e.Button.Index = 1 Then

    '        Dim f As New frmAgregarArticuloQuick
    '        f.StartPosition = FormStartPosition.CenterScreen
    '        f.Nuevo = True

    '        If Me.gbTipo.EditValue <> 3 Then 'And Me.vFacturas.DataRowCount > 0 Then
    '            f.etTipo.Text = p
    '            f.ShowDialog()
    '            Refrescar(0)
    '            RealizarCalculos(1)

    '            'f.etTipo.Text = DR("Tipo")
    '            'f.ShowDialog()
    '            'Refrescar(0)
    '            'RealizarCalculos(1)
    '        End If
    '    End If
    'End Sub



    Private Sub vFacturas_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vFacturas.CellValueChanged

        'If e.Column.FieldName = "PrecioU" And Temp = False And Me.gbTipo.EditValue = 0 Then
        '    'Temp = True
        '    'vFacturas.SetRowCellValue(e.RowHandle, "Precio", Math.Round(e.Value * TCambio, ConfigDetalles.Decimales))
        '    'Temp = False

        '    'If MsgBox("Desea cambiar el precio del articulo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    '    'GuardaDatos("UPDATE Articulos SET Costo = " & Math.Round((Me.vFacturas.GetRowCellValue(e.RowHandle, "Precio")), 2) & " WHERE Empresa = " & EmpresaActual & " And Tipo = 'P' AND Codigo_Articulo = '" & vFacturas.GetRowCellValue(e.RowHandle, "Codigo") & "'")
        '    '    'Temp = True
        '    '    vFacturas.SetRowCellValue(e.RowHandle, "Precio", Math.Round(e.Value * TCambio, ConfigDetalles.Decimales))
        '    '    Temp = False
        '    'Else
        '    '    Temp = True
        '    '    'vFacturas.SetRowCellValue(e.RowHandle, "Precio", 0.0)
        '    '    'vFacturas.SetRowCellValue(e.RowHandle, "PrecioU", 0.0)
        '    '    Temp = False
        '    'End If
        'End If

        'If e.Column.FieldName = "PrecioU" Then
        '    If Me.gbTipo.EditValue = 1 Then
        '        GuardaDatos("UPDATE Articulos SET Costo = " & Me.vFacturas.GetRowCellValue(e.RowHandle, "Precio") & " WHERE Empresa = " & EmpresaActual & " And Tipo = 'S' AND Codigo_Articulo = '" & vFacturas.GetRowCellValue(e.RowHandle, "Codigo") & "'")
        '        ActualizarCambos("S")
        '    End If
        '    GuardarCambios += 1
        'End If


        If etInicio.Text = "1" Then Exit Sub

        If e.Column.FieldName = "Codigo" Then   'Productos ó Inventario
            'Dim DR As DataRowView = Me.cbCodigo1.GetDataSourceRowByKeyValue(e.Value)

            Dim DR As DataRowView = Me.cbItems.GetRowByKeyValue(e.Value)

            Temp = True
            'Si es un Servicio, Mostrar Precio en 0
            If DR("Tipo") = "S" Then
                'If Me.gbTipo.EditValue = 1 Then
                vFacturas.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(0.0).ToString(RoundP))
                vFacturas.SetRowCellValue(e.RowHandle, "Precio", CDbl(0.0).ToString(RoundP))

                'Validar para calulo de IR
                If Me.ckIR.Checked Then
                    Try
                        vFacturas.SetRowCellValue(e.RowHandle, "ir", ObtieneDatos("sp_GetPorcentajeRetension '" & e.Value & "'," & EmpresaActual).Rows.Item(0)(0))
                    Catch ex As Exception
                        vFacturas.SetRowCellValue(e.RowHandle, "ir", 0)
                    End Try
                Else
                    vFacturas.SetRowCellValue(e.RowHandle, "ir", 0)
                End If
            Else
                vFacturas.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(Math.Round(DR("Precio") / TCambio, ConfigDetalles.Decimales)).ToString(RoundP))
                vFacturas.SetRowCellValue(e.RowHandle, "Precio", CDbl(Math.Round(DR("Precio"), ConfigDetalles.Decimales)).ToString(RoundP))
                vFacturas.SetRowCellValue(e.RowHandle, "IdProyecto", DR("IdProyecto"))

                Try
                    If Me.ckIR.Checked Then
                        If Me.gbIR.EditValue = 1 Then   'Servicio 10%
                            vFacturas.SetRowCellValue(e.RowHandle, "ir", ConfigDetalles.IRServ)
                        ElseIf Me.gbIR.EditValue = 0 Then 'Producto/Servicio Generales
                            vFacturas.SetRowCellValue(e.RowHandle, "ir", ConfigDetalles.IRProd)
                        End If
                    Else
                        vFacturas.SetRowCellValue(e.RowHandle, "ir", 0)
                    End If
                Catch ex As Exception
                    vFacturas.SetRowCellValue(e.RowHandle, "ir", 0)
                End Try
            End If

            Temp = False
            vFacturas.SetRowCellValue(e.RowHandle, "Cantidad", 1)
            vFacturas.SetRowCellValue(e.RowHandle, "descuento", 0.0)
            vFacturas.SetRowCellValue(e.RowHandle, "SubTotal", Math.Round(DR("Precio"), ConfigDetalles.Decimales))

            'vFacturas.SetRowCellValue(e.RowHandle, "SubTotal", Math.Round(DR("Precio"), ConfigDetalles.Decimales))
            'vFacturas.SetRowCellValue(e.RowHandle, "PrecioU", DR("Precio"))
            'vFacturas.SetRowCellValue(e.RowHandle, "Precio", Math.Round(DR("Precio") * TCambio, 2))

            vFacturas.SetRowCellValue(e.RowHandle, "Cuenta", DR("Cuenta"))
            vFacturas.SetRowCellValue(e.RowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, DR("Exento")))

            vFacturas.SetRowCellValue(e.RowHandle, "Temp", e.RowHandle + 1)
            vFacturas.SetRowCellValue(e.RowHandle, "Tipo", DR("Tipo"))

            'If Me.gbTipo.EditValue = 3 Then  'Prodcutos e Inventario
            '    vFacturas.SetRowCellValue(e.RowHandle, "Tipo", "A")
            'Else
            '    vFacturas.SetRowCellValue(e.RowHandle, "Tipo", DR("Tipo"))
            'End If
            ' If Me.vFacturasC.DataRowCount > 0 Then RealizarCalculos()
        End If

        If e.Column.FieldName = "Cantidad" Then
            If e.Value <= 0 Then
                MsgBox("Introduzca una Cantidad Mayor que Cero (0)", MsgBoxStyle.Exclamation, formtitulo)
                vFacturas.SetRowCellValue(e.RowHandle, "Cantidad", 1)
            Else
                vFacturas.SetRowCellValue(e.RowHandle, "SubTotal", (Me.vFacturas.GetFocusedRowCellValue("Precio") * e.Value))
            End If
            If Me.vFacturas.DataRowCount > 0 Then RealizarCalculos(0)
        End If

        If e.Column.FieldName = "descuento" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                vFacturas.SetRowCellValue(e.RowHandle, "descuento", e.Value / 100)
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                vFacturas.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio).ToString(RoundP))
                'If Me.gbTipo.EditValue = 1 Then  'Servicio
                '    GuardaDatos("UPDATE Articulos SET Costo = " & CDbl(e.Value) & " WHERE Empresa = " & EmpresaActual & " And Tipo = 'S' AND Codigo_Articulo = '" & vFacturas.GetRowCellValue(e.RowHandle, "Codigo") & "'")
                '    ActualizarCambos("S")
                'End If
                Temp = False
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                vFacturas.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio).ToString(RoundP))
                'If Me.gbTipo.EditValue = 1 Then  'Servicio
                '    GuardaDatos("UPDATE Articulos SET Costo = " & Math.Round(CDbl(e.Value * TCambio), ConfigDetalles.Decimales) & " WHERE Empresa = " & EmpresaActual & " And Tipo = 'S' AND Codigo_Articulo = '" & vFacturas.GetRowCellValue(e.RowHandle, "Codigo") & "'")
                '    ActualizarCambos("S")
                'End If
                Temp = False
            End If
        End If

        If e.Column.FieldName = "descuento" Or e.Column.FieldName = "Cantidad" Or e.Column.FieldName = "Precio" Or e.Column.FieldName = "PrecioU" Then
            If e.Value <> 0 Then
                Temp = True
                vFacturas.SetRowCellValue(
                    e.RowHandle,
                    "SubTotal",
                    (IsNull(Me.vFacturas.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.vFacturas.GetFocusedRowCellValue("Cantidad"), 0)) - ((IsNull(Me.vFacturas.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.vFacturas.GetFocusedRowCellValue("Cantidad"), 0)) * (IsNull(Me.vFacturas.GetFocusedRowCellValue("descuento"), 0) / 100)))
                Temp = False
            End If

            'If e.Value < 0 Then
            '    MsgBox("El valor debe ser igual ó Mayor que Cero (0)", MsgBoxStyle.Exclamation, "STS-Contab")
            '    vFacturas.SetRowCellValue(e.RowHandle, "descuento", 0)
            'Else
            '    vFacturas.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(Me.vFacturas.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.vFacturas.GetFocusedRowCellValue("Cantidad"), 0)) - ((IsNull(Me.vFacturas.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.vFacturas.GetFocusedRowCellValue("Cantidad"), 0)) * (IsNull(Me.vFacturas.GetFocusedRowCellValue("descuento"), 0) / 100)))
            'End If

            If Me.vFacturas.DataRowCount > 0 Then RealizarCalculos(0)
        End If

        If e.Column.FieldName = "ClienteID" Then
            If Not e.Value Is Nothing Then
                IdCliente = e.Value
            End If
        End If

        vFacturas.UpdateTotalSummary()
    End Sub

    Sub RealizarCalculos(ByVal op As Integer)   '

        'DT.AcceptChanges()

        Dim SubTotal As Double = 0
        Dim IVA As Double = 0
        Dim Total As Double = 0

        If Me.vFacturas.RowCount = 1 And (op = 1 Or op = 2) Then   'Si el grid no tiene datos
            Me.etSubTotal.Text = (0).ToString(Round)
            Me.etIva.Text = (0).ToString(Round)
            Me.etTotal.Text = (0).ToString(Round)
            Me.etTotalU.Text = (0).ToString(Round)
            Me.txtSubTotalIR.EditValue = 0.0
        Else
            'Realizar Calculos Sobre Monto en Factura segun Parametros seleccionados
            Try
                For i As Integer = 0 To Me.vFacturas.RowCount - 2
                    Dim DR As DataRow = Me.vFacturas.GetDataRow(i)

                    If DR("Exento") = False Then    'No es Exento de IVA
                        SubTotal += ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100)))
                        IVA += (((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100))) * (ConfigDetalles.IVA / 100))
                    Else
                        SubTotal += ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100)))
                    End If
                    'vFacturas.SetRowCellValue(i, "SubTotal", (Me.vFacturasC.GetRowCellValue(i, "Precio") * Me.vFacturasC.GetRowCellValue(i, "Cantidad")))
                    ' vFacturas.SetRowCellValue(i, "SubTotal", ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100))))
                Next

                If Me.ckIVAAsumido.Checked Then
                    Me.txtSubTotalIR.EditValue = (SubTotal).ToString(Round)
                    SubTotal = SubTotal + IVA
                    Total = SubTotal
                    IVA = 0
                Else
                    Me.txtSubTotalIR.EditValue = (SubTotal).ToString(Round)
                    Total = SubTotal + IVA
                End If

                'If (op = 2 Or Me.ckIVAAsumido.Checked) Then IVA = 0 'IVA ASUMIDO

                Me.etSubTotal.Text = SubTotal.ToString(Round)
                Me.etIva.Text = IVA.ToString(Round)
                Me.etTotal.Text = (Total).ToString(Round)
                Me.etTotalU.Text = CDbl((Total / Me.etTasa.EditValue)).ToString(Round)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub vFacturas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vFacturas.KeyDown
        If Me.vFacturas.FocusedRowHandle < 0 Then Exit Sub
        'Borrar Lineas del Grid
        If e.KeyCode = Keys.Delete Then
            BorrarDistribucion(Me.vFacturas.GetFocusedRowCellValue("Cuenta"))
            Me.vFacturas.DeleteRow(Me.vFacturas.FocusedRowHandle)
            RealizarCalculos(1)
        End If
    End Sub

    Sub BorrarDistribucion(ByVal Cuenta As String)
        Try
            If Not DT_Distribucion Is Nothing Then
                If DT_Distribucion.Rows.Count > 0 Then
repetir:
                    For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
                        If DT_Distribucion.Rows.Item(i)("Cuenta") = Cuenta Then
                            With DT_Distribucion.Rows(i)
                                GuardaDatos("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & .Item("NoComp") & " AND Mes = " & .Item("Mes") & " AND Per_Id = " & .Item("Per_Id"))
                            End With
                            DT_Distribucion.Rows.RemoveAt(i)
                            GoTo repetir
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vFacturas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vFacturas.DoubleClick
        If Me.vFacturas.FocusedRowHandle < 0 Or Me.vFacturas.DataRowCount = 0 Then Exit Sub

        'If Me.vFacturas.FocusedColumn.FieldName = "Precio" Then
        Dim f As New frmAgregarArticuloQuick
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.Nuevo = False

        '  Dim DR As DataRowView = Me.cbCodigo1.GetDataSourceRowByKeyValue(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"))
        Dim DR As DataRowView = Me.cbItems.GetRowByKeyValue(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo"))

        If Me.gbTipo.EditValue = 0 Then
            f.etTipo.Text = "P"
        ElseIf Me.gbTipo.EditValue = 1 Then
            f.etTipo.Text = "S"
        ElseIf Me.gbTipo.EditValue = 3 Then
            f.etTipo.Text = DR("Tipo")
        Else
            f.etTipo.Text = "I" 'PARA LOS ARTICULOS DE INVENTARIO
        End If

        f.txtCodigo.Text = Me.vFacturas.GetFocusedRowCellValue("Codigo")
        f.lbProvTemporal.Text = Me.cbProveedor.EditValue
        f.ShowDialog()
        If f.ok = "SI" Then
            Refrescar(1) 'Refrescar los datos de los Cambos dentro del Grid
            RealizarCalculos(0)
        End If
        ' End If
    End Sub

    Private Sub vFacturas_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vFacturas.RowUpdated
        RealizarCalculos(0)
        GuardarCambios += 1
        CalcularIR()
    End Sub

    Function CalcularIR() As Boolean

        If Me.vFacturas.DataRowCount = 0 Then Return True
        Dim Porcentaje As Double = 0
        Dim PorcentajeAlcaldia As Double = 0
        Dim MontoIR As Double = 0
        Dim MontoIRAlcaldia As Double = 0

        ''PorcentajeAlcaldia = ObtieneDatos("SELECT ISNULL(dbo.fn_GetPorcentajeAlcaldia(" & cbProveedor.EditValue & "," & EmpresaActual & "),0.00) Porcentaje").Rows.Item(0)("Porcentaje")
        ''ConfigDetalles.IR_Ventas()

        'Dim Muni As New VB.SysContab.MunicipiosDB


        If Me.chkIRAlc.Checked Then
            Dim MunDet As VB.SysContab.MunicipioDetails =
            MunicipiosDB.GetDetails(ProveedoresDB.GetDetails(
            cbProveedor.EditValue).Departamento, ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Municipio)

            If ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Departamento = "0" And ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Municipio = "0" Then
                XtraMsg("Por favor Ingrese Departamento o Municipio del Proveedor", MessageBoxIcon.Error)
                txtAlcaldia.EditValue = 0
            Else
                If Me.txtSubTotalIR.EditValue > MunDet.Impuesto_SVenta_Min Then
                    Me.txtAlcaldia.EditValue = Me.txtSubTotalIR.EditValue * (MunDet.Impuesto_SVenta / 100)
                    Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text) - Me.txtIR.EditValue - Me.txtAlcaldia.EditValue
                End If
            End If
        Else
            txtAlcaldia.EditValue = 0
        End If
        '
        If gbTipo.EditValue = 1 Then    'Para Los Servcio
            Porcentaje = Me.vFacturas.GetRowCellValue(0, "ir")
            '
            Dim dtIR As DataTable =
                ObtieneDatos("sp_GetPorcentajeRetension",
                             vFacturas.GetRowCellValue(0, "Codigo"),
                             EmpresaActual)

            If dtIR.Rows.Count > 0 Then
                MontoIR = dtIR.Rows.Item(0)("MontoRetencion")
            Else
                MontoIR = ConfigDetalles.MontoIR
            End If
        Else
            If Me.gbIR.EditValue = 1 Then   'Servicio 10%
                Porcentaje = ConfigDetalles.IRServ
            ElseIf Me.gbIR.EditValue = 0 Then 'Producto/Servicio Generales
                Porcentaje = ConfigDetalles.IRProd
            End If
            '
            MontoIR = ConfigDetalles.MontoIR
        End If

        Dim igual As Boolean = True

        If Me.ckIR.Checked Then
            If Me.txtSubTotalIR.EditValue > MontoIR Then
                If Me.gbTipo.EditValue = 1 Then 'Para Los Servcio
                    For i As Integer = 0 To Me.vFacturas.DataRowCount - 1
                        If Porcentaje <> Me.vFacturas.GetRowCellValue(i, "ir") Then
                            XtraMsg("Existen Items en el Detalle del a Orden de Pago con Diferentes Porcentajes de Retensión",
                                    MessageBoxIcon.Error)
                            igual = False
                            Return False
                            'Exit For
                        End If
                    Next

                    If igual Then
                        Me.txtIR.EditValue = Me.txtSubTotalIR.EditValue * (Porcentaje / 100)
                        Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text) - Me.txtIR.EditValue - Me.txtAlcaldia.EditValue
                    Else
                        Me.txtIR.EditValue = 0.0
                        Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text)
                    End If
                Else
                    Me.txtIR.EditValue = Me.txtSubTotalIR.EditValue * (Porcentaje / 100)
                    Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text) - Me.txtIR.EditValue - Me.txtAlcaldia.EditValue
                End If
            Else
                Me.txtIR.EditValue = 0.0
                Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text)
            End If

        Else
            Me.txtIR.EditValue = 0.0
            Me.txtAPagar.EditValue = CDbl(Me.etTotal.Text)
        End If

        Return True
    End Function

    Sub Refrescar(ByVal ban As Integer)

        If Me.vFacturas.DataRowCount = 0 Then Exit Sub 'Si hay Datos aun, No se refresca nada

        Dim dtlP As New ArticulosDetails
        Dim dtlI As DataTable

        Dim p As String = String.Empty

        If Me.gbTipo.EditValue = 0 Then p = "P"
        If Me.gbTipo.EditValue = 1 Then p = "S"
        If Me.gbTipo.EditValue = 3 Then p = "A"


        'Me.cbCodigo1.DataSource = Nothing
        'Me.cbCodigo2.DataSource = Nothing

        If Me.gbTipo.EditValue = 0 Or Me.gbTipo.EditValue = 1 Then
            'Me.cbCodigo1.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, Articulos.ProductosGetLista(p).Tables("Articulos"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)

            If ban = 1 Then 'Si Cambiamos el Precio
                'Obtener Detalle del Prod/Servicio
                dtlP = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"), p)

                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Precio", CDbl(dtlP.Costo).ToString(RoundP))
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta", dtlP.Cuenta)
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, CBool(dtlP.Exento)))
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal", Me.vFacturas.GetFocusedRowCellValue("Cantidad") * CDbl(dtlP.Costo).ToString(RoundP))
            End If

        ElseIf Me.gbTipo.EditValue = 4 Then
            'Me.cbCodigo1.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, ArticulosCC.ArticulosCCInvent().Tables("GruposCC"), "Nombre", "Codigo", 3, 4, 5, 6)

            If ban = 1 Then
                'Obtener Detalle del Producto en Iventario
                dtlI = ObtieneDatos("SELECT * from ArticulosCC WHERE Articulo_ID = '" & Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo") & "' AND Empresa_ID =" & EmpresaActual)

                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Precio", CDbl(dtlI.Rows.Item(0)("Articulo_Costo")).ToString(RoundP))
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta", dtlI.Rows.Item(0)("Cuenta"))
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, CBool(dtlI.Rows.Item(0)("Exento"))))
                vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal", Me.vFacturas.GetFocusedRowCellValue("Cantidad") * CDbl(dtlI.Rows(0)("Articulo_Costo")).ToString(RoundP))
            End If
        ElseIf Me.gbTipo.EditValue = 3 Then
            'Me.cbCodigo1.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo1.DisplayMember = "Codigo"
            'Me.cbCodigo1.ValueMember = "Codigo"

            'Me.cbCodigo2.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
            'Me.cbCodigo2.DisplayMember = "Nombre"
            'Me.cbCodigo2.ValueMember = "Codigo"

            RepositorySearchLook(cbItems, Articulos.ProductosGetLista(p).Tables("Articulos"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)

            ' Dim DR As DataRowView = Me.cbCodigo1.GetDataSourceRowByKeyValue(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"))
            Dim DR As DataRowView = Me.cbItems.GetRowByKeyValue(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo"))

            If ban = 1 Then
                If DR("Tipo") = "P" Then
                    dtlP = VB.SysContab.ArticulosDB.GetDetails(Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo"), DR("Tipo"))

                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Precio", CDbl(dtlP.Costo).ToString(RoundP))
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta", dtlP.Cuenta)
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, CBool(dtlP.Exento)))
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal", Me.vFacturas.GetFocusedRowCellValue("Cantidad") * CDbl(dtlP.Costo).ToString(RoundP))
                ElseIf DR("Tipo") = "I" Then
                    dtlI = ObtieneDatos("SELECT * from ArticulosCC WHERE Articulo_ID = '" & Me.vFacturas.GetRowCellValue(Me.vFacturas.FocusedRowHandle, "Codigo") & "' AND Empresa_ID =" & EmpresaActual)

                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Precio", CDbl(dtlI.Rows.Item(0)("Articulo_Costo")).ToString(RoundP))
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Cuenta", dtlI.Rows.Item(0)("Cuenta"))
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, CBool(dtlI.Rows.Item(0)("Exento"))))
                    vFacturas.SetRowCellValue(Me.vFacturas.FocusedRowHandle, "SubTotal", Me.vFacturas.GetFocusedRowCellValue("Cantidad") * CDbl(CDbl(dtlI.Rows(0)("Articulo_Costo")).ToString(RoundP)).ToString(RoundP))
                End If
            End If

        End If
        Me.vFacturas.RefreshData() 'Refrescar Datos del Grid
    End Sub

    Private Sub rbProdInvet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.gbTipo.EditValue = 3 Then
            Try
                Me.chkIRAlc.Checked = True
                Me.chkIRAlc.Enabled = True
                Me.cmbdistribucion.Enabled = False
                Me.btnDetalle.Enabled = False

                CargarCombos("A")
                RealizarCalculos(1)

                Me.vFacturas.Columns("PrecioU").Visible = True
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub LimpiarALL()
        Me.cbProveedor.EditValue = Nothing
        Me.txtfactura.Text = ""
        Me.txtOrdenP.Text = ""
        Me.dtpFecha.DateTime = Now.Date
        Me.dtpFechaPago.DateTime = Now.Date
        Me.dtpFechaRecep.DateTime = Now.Date
        '
        Me.txtRuc.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtDepartamento.Text = ""
        Me.txtMunicipio.Text = ""
        Me.txtComentario.Text = ""

        Me.gbTipo.EditValue = 0
        '
        Me.ckIR.Checked = False
        Me.chkIRAlc.Checked = False
        Me.ckIVAAsumido.Checked = False
        '
        'Me.cbTipoFactura.ItemIndex = 0
        Me.cbMoneda.EditValue = MonedaBase
        Me.txtOrden.Text = ""
        '
        Me.etIva.Text = "0.00"
        Me.etSubTotal.Text = "0.00"
        Me.etTotal.Text = "0.00"
        Me.etTotalU.Text = "0.00"
        '
        Me.cmbdistribucion.Enabled = True
        Me.btnDetalle.Enabled = True
        Me.btnDetalle.Enabled = True
        Me.txtSubTotalIR.EditValue = 0.0
        Me.txtIR.EditValue = 0.0
        Me.txtAPagar.EditValue = 0.0
        Me.chkEmpleado.Checked = False
        'Me.ckLiquidar.Checked = False
        OrdenCompra = 0

        CargarCombos("P")
        txtfactura.Text = GetConsecutivo()
        txtfactura.Focus()
        txtfactura.SelectAll()
    End Sub

    Private Sub rbServicios_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Tipo = 1    'Tipo 1 = Servicios
        ''MakeDataSet()
        ''dgFacturas.SetDataBinding(myDataSet, "Articulos")
        ''AddCustomDataTableStyle()

        'If rbServicios.Checked Then

        '    Me.chkIRAlc.Checked = False
        '    'Se cambio el 22082008
        '    'Me.chkIRAlc.Enabled = False

        '    cmbdistribucion.Enabled = True
        '    Me.btnDetalle.Enabled = True

        '    CargarCombos("S")
        '    RealizarCalculos(1)
        '    '  Me.lblGastos.Visible = True
        '    '   Me.ddlGastos.Visible = True
        '    'Me.ckIR.Visible = True



        '    Dim cat As New VB.SysContab.CatalogoDB

        '    Me.vFacturas.Columns("PrecioU").Visible = False

        '    'Me.ddlGastos.DataSource = cat.GetListBuscar(EmpresaActual).Tables(0)
        '    'ddlGastos.ValueMember = "CUENTA"
        '    'ddlGastos.DisplayMember = "NOMBRE"

        '    Dim plan As String
        '    Dim ds As New DataSet
        '    Dim Plantilla As New VB.SysContab.PlantillaDB

        '    Try
        '        plan = Plantilla.GetTipoPlantilla(1, 9).ToString()
        '        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        '        ds = Detalles.Detalles

        '        '    ddlGastos.SelectedValue = ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")

        '    Catch ex As Exception
        '        MsgBox("Plantilla no disponible para realizar esta transacción")
        '        Exit Sub
        '    End Try
        '    ' gbIR.Visible = True
        'Else
        '    cmbdistribucion.Enabled = False
        '    Me.btnDetalle.Enabled = False
        '    'Me.lblGastos.Visible = False
        '    'Me.ddlGastos.Visible = False
        '    ''Me.ckIR.Visible = False
        '    'gbIR.Visible = False
        'End If
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
        '        + " WHERE tc.DIA = " & Me.dtpFecha.DateTime.Day & " AND tc.MES = " & Me.dtpFecha.DateTime.Month & " AND tc.ANIO = " & Me.dtpFecha.DateTime.Year & "").Rows.Item(0)(0))

        '    Me.etTasa.Text = TCambio.ToString("n4")
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub dtpFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.EditValueChanged
        If Inicio Then Exit Sub
        Try
            Dim fp As DataTable = ObtieneDatos("SELECT fp.DIAS FROM FORMA_PAGO fp WHERE fp.CODIGO = " & IIf(Me.cbTipoFactura.EditValue Is Nothing, 0, cbTipoFactura.EditValue) & " AND fp.EMPRESA = " & EmpresaActual)

            Me.dtpFechaPago.DateTime = Me.dtpFecha.DateTime.AddDays(fp.Rows.Item(0)("DIAS"))
            Me.dtpFechaRecep.DateTime = Me.dtpFecha.DateTime

            ' TCambio = ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & dtpFecha.DateTime.Date & "')").Rows.Item(0)(0)
            'TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            '+ " WHERE tc.DIA = " & Me.dtpFecha.DateTime.Day & " AND tc.MES = " & Me.dtpFecha.DateTime.Month & " AND tc.ANIO = " & Me.dtpFecha.DateTime.Year & " AND empr_codigo =" & EmpresaActual).Rows.Item(0)(0))

            TCambio = GetTasaCambioDia(dtpFecha.DateTime.Date)
            etTasa.EditValue = TCambio
            '
            RecalCularTotales()
        Catch ex As Exception
            etTasa.EditValue = 1.0
        End Try
    End Sub

    Sub RecalCularTotales()
        With vFacturas

            For i As Integer = 0 To .DataRowCount - 1
                If cbMoneda.EditValue = MonedaBase Then
                    .SetRowCellValue(i, "PrecioU", Math.Round(CDbl(.GetRowCellValue(i, "Precio") / etTasa.EditValue), 6))
                Else
                    .SetRowCellValue(i, "Precio", Math.Round(CDbl(.GetRowCellValue(i, "PrecioU") * etTasa.EditValue), 6))
                End If
                .SetRowCellValue(i, "SubTotal", Math.Round(CDbl(.GetRowCellValue(i, "Precio") * .GetRowCellValue(i, "Cantidad")), 4))
            Next

            .UpdateTotalSummary()
            .RefreshData()
        End With

        RealizarCalculos(0)
        GuardarCambios += 1
        CalcularIR()
    End Sub

    Private Sub etTasa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etTasa.Validating
        If Inicio Then Exit Sub

        TCambio = etTasa.EditValue

        RecalCularTotales()

        'ActualizarTotales()
        'RealizarCalculos(0)
        'GuardarCambios += 1
        'CalcularIR()
    End Sub

    Sub ActualizarTotales()
        'For i As Integer = 0 To vFacturas.DataRowCount - 1
        '    vFacturas.SetRowCellValue(i, "PrecioU", Math.Round(vFacturas.GetRowCellValue(i, "Precio") / TCambio, 4))
        'Next
        'vFacturas.RefreshData()
        '  vFacturas.UpdateTotalSummary()
    End Sub

    Private Sub txtfactura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfactura.Validating
        'Valida si existe la factura digitada
        'If Modifica = True Or Me.txtOrden.Text <> "" Then
        '    Exit Sub
        'End If

        ''If cbProveedor.EditValue Is Nothing Or IsNumeric(cbProveedor.EditValue) = False Then
        ''    'Me.txtFactura.Text = vbNullString
        ''    XtraMsg("Seleccione el proveedor")
        ''    cbProveedor.Focus()
        ''    Exit Sub
        ''End If

        'Try

        '    Dim DT As DataTable = ObtieneDatos("SELECT * FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Proveedor_ID = " & IIf(cbProveedor.EditValue Is Nothing, 0, cbProveedor.EditValue) & " AND Factura_ID='" & txtfactura.Text.Trim & "'")

        '    If DT.Rows.Count > 0 Then
        '        XtraMsg("Esta factura ya fue registrada")
        '        txtfactura.Text = vbNullString
        '        txtfactura.Focus()
        '        e.Cancel = True
        '    End If

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub txtOrdenP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOrdenP.Validating
        'If Modifica = True Or Me.txtOrden.Text <> "" Then
        '    Exit Sub
        'End If

        ''If cbProveedor.EditValue Is Nothing Or IsNumeric(cbProveedor.EditValue) = False Then
        ''    'Me.txtFactura.Text = vbNullString
        ''    XtraMsg("Seleccione el proveedor")
        ''    cbProveedor.Focus()
        ''    Exit Sub
        ''End If

        'Try

        '    Dim DT As DataTable = ObtieneDatos("SELECT * FROM Facturas_Compras WHERE Empresa_ID=" & EmpresaActual & " AND Proveedor_ID = " & IIf(cbProveedor.EditValue Is Nothing, 0, cbProveedor.EditValue) & " AND NoOrden='" & Me.txtOrdenP.Text & "'")

        '    If strOrdenPago = "Orden de Pago" Then
        '        If DT.Rows.Count > 0 Then
        '            XtraMsg("La Orden ya fue Registrada")
        '            Me.txtOrdenP.Text = vbNullString
        '            Me.txtOrdenP.Focus()
        '            e.Cancel = True
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim f As New frmDetalleDistribucionFacturas
        f.StartPosition = FormStartPosition.CenterParent
        f.DT = DT_Distribucion
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cbTipo.SelectedIndex = 0 Then
        '    cbOrdenCompra.DataSource = ObtieneDatos("SPJLiqcbTipo " & 1 & "," & EmpresaActual)
        'ElseIf cbTipo.SelectedIndex = 1 Then
        '    cbOrdenCompra.DataSource = ObtieneDatos("SPJLiqcbTipo " & 2 & "," & EmpresaActual)
        'Else
        '    cbOrdenCompra.DataSource = ObtieneDatos("SPJLiqcbTipo " & 3 & "," & EmpresaActual)
        'End If

        'cbOrdenCompra.DisplayMember = "NoOrden"
        'cbOrdenCompra.ValueMember = "LiqID"
        'cbOrdenCompra.PopulateColumns()
        'cbOrdenCompra.Columns(0).Visible = False : cbOrdenCompra.Columns(2).Visible = False
        'End If
    End Sub

    Private Sub ckLiquidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If ckLiquidar.Checked Then
        '    vFacturas.Columns("NoPedido").Visible = True : vFacturas.Columns("NoPedido").VisibleIndex = 9
        '    cbTipo_SelectedIndexChanged(Nothing, Nothing)
        'Else
        '    cbTipo.Visible = False
        '    vFacturas.Columns("NoPedido").Visible = False
        'End If
    End Sub


    Private Sub gbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbTipo.SelectedIndexChanged
        Tipo = Me.gbTipo.EditValue

        Select Case Me.gbTipo.EditValue
            Case 0  'Productos
                CargarCombos("P")
                gbIR.Visible = True
                'Me.vFacturas.Columns("PrecioU").Visible = True
            Case 1  'Servicios
                CargarCombos("S")
                'gbIR.Visible = False
                'Me.vFacturas.Columns("PrecioU").Visible = False
            Case 3  'Mixto
                CargarCombos("A")
                gbIR.Visible = True
                'Me.vFacturas.Columns("PrecioU").Visible = True
            Case 4  'Inventario
                CargarCombos("I")
                gbIR.Visible = True
                'Me.vFacturas.Columns("PrecioU").Visible = False
        End Select

        RealizarCalculos(1)
    End Sub

    Private Sub chkEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmpleado.CheckedChanged
        If Me.etInicio.Text = "1" Then Exit Sub

        Me.vFacturas.Columns("EmpleadoID").Visible = Me.chkEmpleado.Checked

        If Me.chkEmpleado.Checked Then
            CargarEmpleados()
            'With My.Forms.frmBuscarEmpleado
            '    .Text = "*** BUSCAR EMPLEADO ***"
            '    .GridControl1.DataSource = ObtieneDatos("_GetlistEmpleado " & EmpresaActual)
            '    .ShowDialog()
            '    Me.etEmpleado.Text = .Codigo
            '    .Dispose()
            'End With

            'If Me.etEmpleado.Text <> "" Then Me.etEmpleado.Visible = True
            'If Me.etEmpleado.Text = "" Then Me.chkEmpleado.Checked = False
        Else
            Me.cbClientes.DataSource = Nothing
            'Me.etEmpleado.Visible = False
        End If
    End Sub

    Sub CargarEmpleados()
        cbEmpleado.DataSource = ObtieneDatos("_GetlistEmpleado " & EmpresaActual)
        cbEmpleado.ValueMember = "Codigo"
        cbEmpleado.DisplayMember = "Codigo"
        cbEmpleado.PopulateColumns()

        For i As Integer = 0 To Me.cbEmpleado.Columns.Count - 1
            cbEmpleado.Columns(i).Visible = False
        Next

        cbEmpleado.Columns("Codigo").Visible = True
        cbEmpleado.Columns("Nombre").Visible = True
    End Sub

    Private Sub cbTipoFactura_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoFactura.EditValueChanged
        Try
            If cbTipoFactura.ItemIndex > 0 Then
                dtpFechaPago.DateTime = dtpFecha.DateTime.AddDays(FormaPago.FormaPagoDias(cbTipoFactura.EditValue))
                'gbTipo = cbTipoFactura.EditValue
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSubTotalIR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotalIR.EditValueChanged
        CalcularIR()
    End Sub

    Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged
        If Me.etInicio.Text = "1" Then Exit Sub

        Me.vFacturas.Columns("ClienteID").Visible = Me.chkCliente.Checked

        If Me.chkCliente.Checked Then
            CargarClientes()
            'With My.Forms.frmBuscarEmpleado
            '    .Text = "*** BUSCAR CLIENTE ***"
            '    .GridControl1.DataSource = ObtieneDatos("SELECT c.CODIGO ID,c.CodigoLetra CODIGO,c.NOMBRE FROM CLIENTES c WHERE c.EMPRESA = " & EmpresaActual)
            '    .ShowDialog()
            '    Me.etEmpleado.Text = .Codigo
            '    .Dispose()
            'End With
        Else
            Me.cbClientes.DataSource = Nothing
        End If
    End Sub

    Sub CargarClientes()
        Me.cbClientes.DataSource = ObtieneDatos("SELECT c.CODIGO ID,c.CodigoLetra CODIGO,c.NOMBRE FROM CLIENTES c WHERE c.EMPRESA = " & EmpresaActual)
        Me.cbClientes.DisplayMember = "CODIGO"
        Me.cbClientes.ValueMember = "ID"
        Me.cbClientes.PopulateColumns()
        Me.cbClientes.Columns("ID").Visible = False
    End Sub

    'Private Sub SaveLiq(ByVal FacturaID As Integer)
    '    ObtieneDatos("SPJ_LiquidacionesFacturas " & FacturaID & "," & cbTipo.SelectedIndex)
    'End Sub


    Private Sub cbProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged

        If cbProveedor.EditValue Is Nothing Then
            txtRuc.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            txtDepartamento.Text = ""
            txtMunicipio.Text = ""
            Exit Sub
        End If

        DetallesProveedor = ProveedoresDB.GetDetails(Me.cbProveedor.EditValue)

        txtRuc.Text = DetallesProveedor.Ruc
        txtDireccion.Text = DetallesProveedor.Direccion
        txtTelefono.Text = DetallesProveedor.Telefono
        ckIR.Checked = Not DetallesProveedor.Exento
        txtDepartamento.Text = DetallesProveedor.DepartamentoN
        txtMunicipio.Text = DetallesProveedor.MunicipioN

        If Not Me.ckIR.Checked Then ckIR.Enabled = False

        cbTipoFactura.EditValue = DetallesProveedor.Cod_Forma_Pago

        'If IsNumeric(DetallesProveedor.Departamento) = True Then
        '    Try
        '        Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
        '        Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

        ShowSplash("Imprimiendo O/P...")
        Dim Temp As Boolean = False

        Try
            Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 18 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

            Temp = True
            Dim Tamano As Integer = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\rptOrdenPago.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try
        '
        Dim rpt As rptOrdenPago

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenPago.repx", True)
        Else
            rpt = New rptOrdenPago
        End If

        rpt.DataSource = ObtieneDatos("JAR_GetOrdenPagoImpresa", txtfactura.Text,
                                      cbProveedor.EditValue,
                                      EmpresaActual) 'DSComp.Tables(0)

        HideSplash()
        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub frmFacturasCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then cmdAceptar_Click(Nothing, Nothing)
    End Sub

    Private Sub chkLiquidar_CheckedChanged(sender As Object, e As EventArgs) Handles chkLiquidar.CheckedChanged

    End Sub

    Private Sub txtAPagar_EditValueChanged(sender As Object, e As EventArgs) Handles txtAPagar.EditValueChanged

    End Sub
End Class
