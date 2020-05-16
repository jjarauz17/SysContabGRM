Imports System.Linq
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel

Namespace DataGridTextBoxCombo
    Public Class frmOrdenesCompra
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmOrdenesCompra = Nothing

        Public Shared Function Instance() As frmOrdenesCompra
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmOrdenesCompra()
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
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdPedidos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsultaProveedores As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents lbOrigen As System.Windows.Forms.Label
        Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
        Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents dtpFechaPago As DevExpress.XtraEditors.DateEdit
        Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
        Friend WithEvents txtNoOrden As DevExpress.XtraEditors.TextEdit
        Friend WithEvents cbTipoFactura As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents ckLiquidar As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents txtPrecioC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents txtPrecioU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents tIva As DevExpress.XtraEditors.TextEdit
        Friend WithEvents tSubTotal As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents tTotalU As DevExpress.XtraEditors.TextEdit
        Friend WithEvents tTotal As DevExpress.XtraEditors.TextEdit
        Friend WithEvents lyTotal As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbProducto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents mComentarios As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents FechaEntrega As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtEmbarque As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtAtencion As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbEstados As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbConsignatarios As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents cbAgencias As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbMetodosEnvios As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
        Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbCondiciones As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtPedido As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents mComentarioG As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents chkPrincipal As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents bGuardarHija As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents cbPedidos As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents chkIR As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtSubTotalIR As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents txtAPagar As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtRetencionAlma As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtRetencion As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents chkAlma As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents sIrP As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents sIR_AlmaP As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents IdDetalle As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents etDestino As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesCompra))
            Me.ckLiquidar = New DevExpress.XtraEditors.CheckEdit()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sIR_AlmaP = New DevExpress.XtraEditors.SpinEdit()
            Me.sIrP = New DevExpress.XtraEditors.SpinEdit()
            Me.chkAlma = New DevExpress.XtraEditors.CheckEdit()
            Me.txtAPagar = New DevExpress.XtraEditors.TextEdit()
            Me.txtRetencionAlma = New DevExpress.XtraEditors.TextEdit()
            Me.txtRetencion = New DevExpress.XtraEditors.TextEdit()
            Me.txtSubTotalIR = New DevExpress.XtraEditors.TextEdit()
            Me.chkIR = New DevExpress.XtraEditors.CheckEdit()
            Me.chkPrincipal = New DevExpress.XtraEditors.CheckEdit()
            Me.mComentarioG = New DevExpress.XtraEditors.MemoEdit()
            Me.txtPedido = New DevExpress.XtraEditors.TextEdit()
            Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
            Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
            Me.cbCondiciones = New DevExpress.XtraEditors.LookUpEdit()
            Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.cbMetodosEnvios = New DevExpress.XtraEditors.LookUpEdit()
            Me.cbConsignatarios = New DevExpress.XtraEditors.LookUpEdit()
            Me.cbAgencias = New DevExpress.XtraEditors.LookUpEdit()
            Me.cbEstados = New DevExpress.XtraEditors.LookUpEdit()
            Me.txtAtencion = New DevExpress.XtraEditors.TextEdit()
            Me.txtEmbarque = New DevExpress.XtraEditors.TextEdit()
            Me.FechaEntrega = New DevExpress.XtraEditors.DateEdit()
            Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
            Me.mComentarios = New DevExpress.XtraEditors.MemoEdit()
            Me.tTotalU = New DevExpress.XtraEditors.TextEdit()
            Me.tTotal = New DevExpress.XtraEditors.TextEdit()
            Me.tIva = New DevExpress.XtraEditors.TextEdit()
            Me.tSubTotal = New DevExpress.XtraEditors.TextEdit()
            Me.cbTipoFactura = New DevExpress.XtraEditors.LookUpEdit()
            Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
            Me.etTasa = New DevExpress.XtraEditors.TextEdit()
            Me.txtNoOrden = New DevExpress.XtraEditors.TextEdit()
            Me.dtpFechaPago = New DevExpress.XtraEditors.DateEdit()
            Me.iGrid = New DevExpress.XtraGrid.GridControl()
            Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbProducto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.txtPrecioC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.txtPrecioU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.txtDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbPedidos = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.IdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lyTotal = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.bGuardarHija = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.etDestino = New System.Windows.Forms.Label()
            Me.cmdPedidos = New DevExpress.XtraEditors.SimpleButton()
            Me.lbOrigen = New System.Windows.Forms.Label()
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsultaProveedores = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.sIR_AlmaP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sIrP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAlma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtAPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtRetencionAlma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtRetencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkPrincipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mComentarioG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbMetodosEnvios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbConsignatarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbAgencias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbEstados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtAtencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtEmbarque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tTotalU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl2.SuspendLayout()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'ckLiquidar
            '
            Me.ckLiquidar.Location = New System.Drawing.Point(736, 212)
            Me.ckLiquidar.Name = "ckLiquidar"
            Me.ckLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
            Me.ckLiquidar.Properties.Appearance.Options.UseFont = True
            Me.ckLiquidar.Properties.Appearance.Options.UseForeColor = True
            Me.ckLiquidar.Properties.Caption = "A liquidar"
            Me.ckLiquidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
            Me.ckLiquidar.Size = New System.Drawing.Size(120, 22)
            Me.ckLiquidar.StyleController = Me.LayoutControl1
            Me.ckLiquidar.TabIndex = 176
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.sIR_AlmaP)
            Me.LayoutControl1.Controls.Add(Me.sIrP)
            Me.LayoutControl1.Controls.Add(Me.chkAlma)
            Me.LayoutControl1.Controls.Add(Me.txtAPagar)
            Me.LayoutControl1.Controls.Add(Me.txtRetencionAlma)
            Me.LayoutControl1.Controls.Add(Me.txtRetencion)
            Me.LayoutControl1.Controls.Add(Me.txtSubTotalIR)
            Me.LayoutControl1.Controls.Add(Me.chkIR)
            Me.LayoutControl1.Controls.Add(Me.chkPrincipal)
            Me.LayoutControl1.Controls.Add(Me.mComentarioG)
            Me.LayoutControl1.Controls.Add(Me.txtPedido)
            Me.LayoutControl1.Controls.Add(Me.txtFactura)
            Me.LayoutControl1.Controls.Add(Me.txtLogin)
            Me.LayoutControl1.Controls.Add(Me.cbCondiciones)
            Me.LayoutControl1.Controls.Add(Me.cbProveedor)
            Me.LayoutControl1.Controls.Add(Me.cbMetodosEnvios)
            Me.LayoutControl1.Controls.Add(Me.cbConsignatarios)
            Me.LayoutControl1.Controls.Add(Me.cbAgencias)
            Me.LayoutControl1.Controls.Add(Me.cbEstados)
            Me.LayoutControl1.Controls.Add(Me.txtAtencion)
            Me.LayoutControl1.Controls.Add(Me.txtEmbarque)
            Me.LayoutControl1.Controls.Add(Me.FechaEntrega)
            Me.LayoutControl1.Controls.Add(Me.cbMoneda)
            Me.LayoutControl1.Controls.Add(Me.mComentarios)
            Me.LayoutControl1.Controls.Add(Me.tTotalU)
            Me.LayoutControl1.Controls.Add(Me.tTotal)
            Me.LayoutControl1.Controls.Add(Me.tIva)
            Me.LayoutControl1.Controls.Add(Me.tSubTotal)
            Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
            Me.LayoutControl1.Controls.Add(Me.ckLiquidar)
            Me.LayoutControl1.Controls.Add(Me.TipoServicio)
            Me.LayoutControl1.Controls.Add(Me.etTasa)
            Me.LayoutControl1.Controls.Add(Me.txtNoOrden)
            Me.LayoutControl1.Controls.Add(Me.dtpFechaPago)
            Me.LayoutControl1.Controls.Add(Me.iGrid)
            Me.LayoutControl1.Controls.Add(Me.dtpFecha)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1052, 194, 252, 350)
            Me.LayoutControl1.Root = Me.LayoutControlGroup1
            Me.LayoutControl1.Size = New System.Drawing.Size(868, 561)
            Me.LayoutControl1.TabIndex = 162
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'sIR_AlmaP
            '
            Me.sIR_AlmaP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.sIR_AlmaP.Enabled = False
            Me.sIR_AlmaP.Location = New System.Drawing.Point(237, 210)
            Me.sIR_AlmaP.Name = "sIR_AlmaP"
            Me.sIR_AlmaP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.sIR_AlmaP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.sIR_AlmaP.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.sIR_AlmaP.Properties.Appearance.Options.UseBackColor = True
            Me.sIR_AlmaP.Properties.Appearance.Options.UseFont = True
            Me.sIR_AlmaP.Properties.Appearance.Options.UseForeColor = True
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.OrangeRed
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.sIR_AlmaP.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.sIR_AlmaP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.sIR_AlmaP.Properties.Mask.BeepOnError = True
            Me.sIR_AlmaP.Properties.Mask.EditMask = "P2"
            Me.sIR_AlmaP.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.sIR_AlmaP.Properties.MaxLength = 2
            Me.sIR_AlmaP.Properties.MaxValue = New Decimal(New Integer() {25, 0, 0, 0})
            Me.sIR_AlmaP.Properties.ReadOnly = True
            Me.sIR_AlmaP.Size = New System.Drawing.Size(91, 20)
            Me.sIR_AlmaP.StyleController = Me.LayoutControl1
            Me.sIR_AlmaP.TabIndex = 203
            '
            'sIrP
            '
            Me.sIrP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.sIrP.Enabled = False
            Me.sIrP.Location = New System.Drawing.Point(237, 186)
            Me.sIrP.Name = "sIrP"
            Me.sIrP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.sIrP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.sIrP.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.sIrP.Properties.Appearance.Options.UseBackColor = True
            Me.sIrP.Properties.Appearance.Options.UseFont = True
            Me.sIrP.Properties.Appearance.Options.UseForeColor = True
            Me.sIrP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.sIrP.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
            Me.sIrP.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.OrangeRed
            Me.sIrP.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.sIrP.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.sIrP.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.sIrP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.sIrP.Properties.Mask.BeepOnError = True
            Me.sIrP.Properties.Mask.EditMask = "P2"
            Me.sIrP.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.sIrP.Properties.MaxLength = 2
            Me.sIrP.Properties.MaxValue = New Decimal(New Integer() {25, 0, 0, 0})
            Me.sIrP.Properties.ReadOnly = True
            Me.sIrP.Size = New System.Drawing.Size(91, 20)
            Me.sIrP.StyleController = Me.LayoutControl1
            Me.sIrP.TabIndex = 202
            '
            'chkAlma
            '
            Me.chkAlma.Location = New System.Drawing.Point(12, 210)
            Me.chkAlma.Name = "chkAlma"
            Me.chkAlma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAlma.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.chkAlma.Properties.Appearance.Options.UseFont = True
            Me.chkAlma.Properties.Appearance.Options.UseForeColor = True
            Me.chkAlma.Properties.Caption = "Calcular Retención Municipal"
            Me.chkAlma.Size = New System.Drawing.Size(202, 20)
            Me.chkAlma.StyleController = Me.LayoutControl1
            Me.chkAlma.TabIndex = 201
            '
            'txtAPagar
            '
            Me.txtAPagar.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.txtAPagar.Location = New System.Drawing.Point(82, 527)
            Me.txtAPagar.Name = "txtAPagar"
            Me.txtAPagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAPagar.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.txtAPagar.Properties.Appearance.Options.UseFont = True
            Me.txtAPagar.Properties.Appearance.Options.UseForeColor = True
            Me.txtAPagar.Properties.Appearance.Options.UseTextOptions = True
            Me.txtAPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtAPagar.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtAPagar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAPagar.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtAPagar.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtAPagar.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtAPagar.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtAPagar.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.txtAPagar.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtAPagar.Properties.Mask.EditMask = "n2"
            Me.txtAPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtAPagar.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtAPagar.Size = New System.Drawing.Size(121, 20)
            Me.txtAPagar.StyleController = Me.LayoutControl1
            Me.txtAPagar.TabIndex = 196
            '
            'txtRetencionAlma
            '
            Me.txtRetencionAlma.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.txtRetencionAlma.Location = New System.Drawing.Point(88, 501)
            Me.txtRetencionAlma.Name = "txtRetencionAlma"
            Me.txtRetencionAlma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRetencionAlma.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.txtRetencionAlma.Properties.Appearance.Options.UseFont = True
            Me.txtRetencionAlma.Properties.Appearance.Options.UseForeColor = True
            Me.txtRetencionAlma.Properties.Appearance.Options.UseTextOptions = True
            Me.txtRetencionAlma.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.txtRetencionAlma.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtRetencionAlma.Properties.Mask.EditMask = "n2"
            Me.txtRetencionAlma.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtRetencionAlma.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtRetencionAlma.Size = New System.Drawing.Size(115, 20)
            Me.txtRetencionAlma.StyleController = Me.LayoutControl1
            Me.txtRetencionAlma.TabIndex = 196
            '
            'txtRetencion
            '
            Me.txtRetencion.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.txtRetencion.Location = New System.Drawing.Point(89, 475)
            Me.txtRetencion.Name = "txtRetencion"
            Me.txtRetencion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRetencion.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.txtRetencion.Properties.Appearance.Options.UseFont = True
            Me.txtRetencion.Properties.Appearance.Options.UseForeColor = True
            Me.txtRetencion.Properties.Appearance.Options.UseTextOptions = True
            Me.txtRetencion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtRetencion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtRetencion.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRetencion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtRetencion.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtRetencion.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtRetencion.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtRetencion.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.txtRetencion.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtRetencion.Properties.Mask.EditMask = "n2"
            Me.txtRetencion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtRetencion.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtRetencion.Size = New System.Drawing.Size(114, 20)
            Me.txtRetencion.StyleController = Me.LayoutControl1
            Me.txtRetencion.TabIndex = 196
            '
            'txtSubTotalIR
            '
            Me.txtSubTotalIR.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.txtSubTotalIR.Location = New System.Drawing.Point(89, 449)
            Me.txtSubTotalIR.Name = "txtSubTotalIR"
            Me.txtSubTotalIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalIR.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.txtSubTotalIR.Properties.Appearance.Options.UseFont = True
            Me.txtSubTotalIR.Properties.Appearance.Options.UseForeColor = True
            Me.txtSubTotalIR.Properties.Appearance.Options.UseTextOptions = True
            Me.txtSubTotalIR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.txtSubTotalIR.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.txtSubTotalIR.Properties.Mask.EditMask = "n2"
            Me.txtSubTotalIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtSubTotalIR.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtSubTotalIR.Size = New System.Drawing.Size(114, 20)
            Me.txtSubTotalIR.StyleController = Me.LayoutControl1
            Me.txtSubTotalIR.TabIndex = 195
            '
            'chkIR
            '
            Me.chkIR.Location = New System.Drawing.Point(12, 186)
            Me.chkIR.Name = "chkIR"
            Me.chkIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkIR.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
            Me.chkIR.Properties.Appearance.Options.UseFont = True
            Me.chkIR.Properties.Appearance.Options.UseForeColor = True
            Me.chkIR.Properties.Caption = "Calcular Retención"
            Me.chkIR.Size = New System.Drawing.Size(202, 20)
            Me.chkIR.StyleController = Me.LayoutControl1
            Me.chkIR.TabIndex = 200
            '
            'chkPrincipal
            '
            Me.chkPrincipal.Location = New System.Drawing.Point(736, 186)
            Me.chkPrincipal.Name = "chkPrincipal"
            Me.chkPrincipal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkPrincipal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
            Me.chkPrincipal.Properties.Appearance.Options.UseFont = True
            Me.chkPrincipal.Properties.Appearance.Options.UseForeColor = True
            Me.chkPrincipal.Properties.Caption = "O/C Principal"
            Me.chkPrincipal.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
            Me.chkPrincipal.Size = New System.Drawing.Size(120, 22)
            Me.chkPrincipal.StyleController = Me.LayoutControl1
            Me.chkPrincipal.TabIndex = 177
            '
            'mComentarioG
            '
            Me.mComentarioG.Location = New System.Drawing.Point(433, 465)
            Me.mComentarioG.Name = "mComentarioG"
            Me.mComentarioG.Size = New System.Drawing.Size(223, 84)
            Me.mComentarioG.StyleController = Me.LayoutControl1
            Me.mComentarioG.TabIndex = 199
            '
            'txtPedido
            '
            Me.txtPedido.EnterMoveNextControl = True
            Me.txtPedido.Location = New System.Drawing.Point(378, 62)
            Me.txtPedido.Name = "txtPedido"
            Me.txtPedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPedido.Size = New System.Drawing.Size(127, 20)
            Me.txtPedido.StyleController = Me.LayoutControl1
            Me.txtPedido.TabIndex = 164
            '
            'txtFactura
            '
            Me.txtFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFactura.EnterMoveNextControl = True
            Me.txtFactura.Location = New System.Drawing.Point(767, 36)
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.txtFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.txtFactura.Properties.Appearance.Options.UseBackColor = True
            Me.txtFactura.Properties.Appearance.Options.UseFont = True
            Me.txtFactura.Properties.Appearance.Options.UseForeColor = True
            Me.txtFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtFactura.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtFactura.Properties.ReadOnly = True
            Me.txtFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtFactura.Size = New System.Drawing.Size(89, 22)
            Me.txtFactura.StyleController = Me.LayoutControl1
            Me.txtFactura.TabIndex = 191
            '
            'txtLogin
            '
            Me.txtLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtLogin.EnterMoveNextControl = True
            Me.txtLogin.Location = New System.Drawing.Point(616, 62)
            Me.txtLogin.Name = "txtLogin"
            Me.txtLogin.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.txtLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLogin.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.txtLogin.Properties.Appearance.Options.UseBackColor = True
            Me.txtLogin.Properties.Appearance.Options.UseFont = True
            Me.txtLogin.Properties.Appearance.Options.UseForeColor = True
            Me.txtLogin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtLogin.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLogin.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtLogin.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtLogin.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtLogin.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtLogin.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.txtLogin.Properties.ReadOnly = True
            Me.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtLogin.Size = New System.Drawing.Size(240, 22)
            Me.txtLogin.StyleController = Me.LayoutControl1
            Me.txtLogin.TabIndex = 190
            '
            'cbCondiciones
            '
            Me.cbCondiciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbCondiciones.Location = New System.Drawing.Point(119, 162)
            Me.cbCondiciones.Name = "cbCondiciones"
            Me.cbCondiciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCondiciones.Properties.Appearance.Options.UseFont = True
            Me.cbCondiciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCondiciones.Properties.NullText = "[Seleccione]"
            Me.cbCondiciones.Properties.ShowFooter = False
            Me.cbCondiciones.Properties.ShowHeader = False
            Me.cbCondiciones.Size = New System.Drawing.Size(164, 20)
            Me.cbCondiciones.StyleController = Me.LayoutControl1
            Me.cbCondiciones.TabIndex = 197
            '
            'cbProveedor
            '
            Me.cbProveedor.Location = New System.Drawing.Point(119, 12)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Properties.Appearance.Options.UseFont = True
            Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbProveedor.Properties.PopupView = Me.SearchLookUpEdit1View
            Me.cbProveedor.Size = New System.Drawing.Size(315, 20)
            Me.cbProveedor.StyleController = Me.LayoutControl1
            Me.cbProveedor.TabIndex = 199
            '
            'SearchLookUpEdit1View
            '
            Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
            Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'cbMetodosEnvios
            '
            Me.cbMetodosEnvios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbMetodosEnvios.Location = New System.Drawing.Point(119, 138)
            Me.cbMetodosEnvios.Name = "cbMetodosEnvios"
            Me.cbMetodosEnvios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMetodosEnvios.Properties.Appearance.Options.UseFont = True
            Me.cbMetodosEnvios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbMetodosEnvios.Properties.NullText = "[Seleccione]"
            Me.cbMetodosEnvios.Properties.ShowFooter = False
            Me.cbMetodosEnvios.Properties.ShowHeader = False
            Me.cbMetodosEnvios.Size = New System.Drawing.Size(164, 20)
            Me.cbMetodosEnvios.StyleController = Me.LayoutControl1
            Me.cbMetodosEnvios.TabIndex = 197
            '
            'cbConsignatarios
            '
            Me.cbConsignatarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbConsignatarios.Location = New System.Drawing.Point(119, 88)
            Me.cbConsignatarios.Name = "cbConsignatarios"
            Me.cbConsignatarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbConsignatarios.Properties.Appearance.Options.UseFont = True
            Me.cbConsignatarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbConsignatarios.Properties.NullText = "[Seleccione]"
            Me.cbConsignatarios.Properties.ShowFooter = False
            Me.cbConsignatarios.Properties.ShowHeader = False
            Me.cbConsignatarios.Size = New System.Drawing.Size(164, 20)
            Me.cbConsignatarios.StyleController = Me.LayoutControl1
            Me.cbConsignatarios.TabIndex = 198
            '
            'cbAgencias
            '
            Me.cbAgencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbAgencias.Location = New System.Drawing.Point(119, 114)
            Me.cbAgencias.Name = "cbAgencias"
            Me.cbAgencias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbAgencias.Properties.Appearance.Options.UseFont = True
            Me.cbAgencias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAgencias.Properties.NullText = "[Seleccione]"
            Me.cbAgencias.Properties.ShowFooter = False
            Me.cbAgencias.Properties.ShowHeader = False
            Me.cbAgencias.Size = New System.Drawing.Size(164, 20)
            Me.cbAgencias.StyleController = Me.LayoutControl1
            Me.cbAgencias.TabIndex = 196
            '
            'cbEstados
            '
            Me.cbEstados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbEstados.EnterMoveNextControl = True
            Me.cbEstados.Location = New System.Drawing.Point(394, 162)
            Me.cbEstados.Name = "cbEstados"
            Me.cbEstados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbEstados.Properties.Appearance.Options.UseFont = True
            Me.cbEstados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEstados.Properties.NullText = ""
            Me.cbEstados.Properties.ShowFooter = False
            Me.cbEstados.Properties.ShowHeader = False
            Me.cbEstados.Size = New System.Drawing.Size(462, 20)
            Me.cbEstados.StyleController = Me.LayoutControl1
            Me.cbEstados.TabIndex = 165
            '
            'txtAtencion
            '
            Me.txtAtencion.EnterMoveNextControl = True
            Me.txtAtencion.Location = New System.Drawing.Point(119, 36)
            Me.txtAtencion.Name = "txtAtencion"
            Me.txtAtencion.Size = New System.Drawing.Size(331, 20)
            Me.txtAtencion.StyleController = Me.LayoutControl1
            Me.txtAtencion.TabIndex = 166
            '
            'txtEmbarque
            '
            Me.txtEmbarque.EnterMoveNextControl = True
            Me.txtEmbarque.Location = New System.Drawing.Point(394, 138)
            Me.txtEmbarque.Name = "txtEmbarque"
            Me.txtEmbarque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmbarque.Properties.Appearance.Options.UseFont = True
            Me.txtEmbarque.Size = New System.Drawing.Size(462, 20)
            Me.txtEmbarque.StyleController = Me.LayoutControl1
            Me.txtEmbarque.TabIndex = 164
            '
            'FechaEntrega
            '
            Me.FechaEntrega.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
            Me.FechaEntrega.EnterMoveNextControl = True
            Me.FechaEntrega.Location = New System.Drawing.Point(561, 36)
            Me.FechaEntrega.Name = "FechaEntrega"
            Me.FechaEntrega.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.FechaEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FechaEntrega.Properties.Appearance.Options.UseFont = True
            Me.FechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.FechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.FechaEntrega.Properties.Mask.EditMask = "ddMMyy"
            Me.FechaEntrega.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
            Me.FechaEntrega.Size = New System.Drawing.Size(95, 20)
            Me.FechaEntrega.StyleController = Me.LayoutControl1
            Me.FechaEntrega.TabIndex = 164
            '
            'cbMoneda
            '
            Me.cbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbMoneda.EnterMoveNextControl = True
            Me.cbMoneda.Location = New System.Drawing.Point(394, 88)
            Me.cbMoneda.Name = "cbMoneda"
            Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMoneda.Properties.Appearance.Options.UseFont = True
            Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbMoneda.Properties.NullText = ""
            Me.cbMoneda.Properties.ShowFooter = False
            Me.cbMoneda.Properties.ShowHeader = False
            Me.cbMoneda.Size = New System.Drawing.Size(297, 20)
            Me.cbMoneda.StyleController = Me.LayoutControl1
            Me.cbMoneda.TabIndex = 164
            '
            'mComentarios
            '
            Me.mComentarios.Location = New System.Drawing.Point(207, 465)
            Me.mComentarios.Name = "mComentarios"
            Me.mComentarios.Size = New System.Drawing.Size(222, 84)
            Me.mComentarios.StyleController = Me.LayoutControl1
            Me.mComentarios.TabIndex = 198
            '
            'tTotalU
            '
            Me.tTotalU.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.tTotalU.Location = New System.Drawing.Point(743, 527)
            Me.tTotalU.Name = "tTotalU"
            Me.tTotalU.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tTotalU.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tTotalU.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.tTotalU.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.tTotalU.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.tTotalU.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.tTotalU.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.tTotalU.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.tTotalU.Properties.Mask.EditMask = "n2"
            Me.tTotalU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.tTotalU.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.tTotalU.Properties.ReadOnly = True
            Me.tTotalU.Size = New System.Drawing.Size(113, 22)
            Me.tTotalU.StyleController = Me.LayoutControl1
            Me.tTotalU.TabIndex = 197
            '
            'tTotal
            '
            Me.tTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.tTotal.Location = New System.Drawing.Point(728, 501)
            Me.tTotal.Name = "tTotal"
            Me.tTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.tTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.tTotal.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.tTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.tTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.tTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.tTotal.Properties.Mask.EditMask = "n2"
            Me.tTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.tTotal.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.tTotal.Properties.ReadOnly = True
            Me.tTotal.Size = New System.Drawing.Size(128, 22)
            Me.tTotal.StyleController = Me.LayoutControl1
            Me.tTotal.TabIndex = 196
            '
            'tIva
            '
            Me.tIva.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.tIva.Location = New System.Drawing.Point(728, 475)
            Me.tIva.Name = "tIva"
            Me.tIva.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tIva.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tIva.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.tIva.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.tIva.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.tIva.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.tIva.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.tIva.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.tIva.Properties.Mask.EditMask = "n2"
            Me.tIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.tIva.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.tIva.Properties.ReadOnly = True
            Me.tIva.Size = New System.Drawing.Size(128, 22)
            Me.tIva.StyleController = Me.LayoutControl1
            Me.tIva.TabIndex = 195
            '
            'tSubTotal
            '
            Me.tSubTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.tSubTotal.Location = New System.Drawing.Point(728, 449)
            Me.tSubTotal.Name = "tSubTotal"
            Me.tSubTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tSubTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tSubTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.tSubTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.tSubTotal.Properties.Mask.EditMask = "n2"
            Me.tSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.tSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.tSubTotal.Properties.ReadOnly = True
            Me.tSubTotal.Size = New System.Drawing.Size(128, 22)
            Me.tSubTotal.StyleController = Me.LayoutControl1
            Me.tSubTotal.TabIndex = 194
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbTipoFactura.EnterMoveNextControl = True
            Me.cbTipoFactura.Location = New System.Drawing.Point(394, 114)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Properties.Appearance.Options.UseFont = True
            Me.cbTipoFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTipoFactura.Properties.NullText = "[Seleccione]"
            Me.cbTipoFactura.Properties.ShowFooter = False
            Me.cbTipoFactura.Properties.ShowHeader = False
            Me.cbTipoFactura.Size = New System.Drawing.Size(462, 20)
            Me.cbTipoFactura.StyleController = Me.LayoutControl1
            Me.cbTipoFactura.TabIndex = 0
            '
            'TipoServicio
            '
            Me.TipoServicio.EditValue = "P"
            Me.TipoServicio.Location = New System.Drawing.Point(332, 186)
            Me.TipoServicio.Name = "TipoServicio"
            Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
            Me.TipoServicio.Properties.Appearance.Options.UseFont = True
            Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
            Me.TipoServicio.Properties.Columns = 4
            Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Insumos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos")})
            Me.TipoServicio.Size = New System.Drawing.Size(400, 48)
            Me.TipoServicio.StyleController = Me.LayoutControl1
            Me.TipoServicio.TabIndex = 193
            '
            'etTasa
            '
            Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.etTasa.EditValue = 1
            Me.etTasa.EnterMoveNextControl = True
            Me.etTasa.Location = New System.Drawing.Point(749, 88)
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
            Me.etTasa.Size = New System.Drawing.Size(107, 22)
            Me.etTasa.StyleController = Me.LayoutControl1
            Me.etTasa.TabIndex = 3
            '
            'txtNoOrden
            '
            Me.txtNoOrden.EnterMoveNextControl = True
            Me.txtNoOrden.Location = New System.Drawing.Point(119, 62)
            Me.txtNoOrden.Name = "txtNoOrden"
            Me.txtNoOrden.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtNoOrden.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
            Me.txtNoOrden.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.txtNoOrden.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtNoOrden.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtNoOrden.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtNoOrden.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNoOrden.Size = New System.Drawing.Size(148, 20)
            Me.txtNoOrden.StyleController = Me.LayoutControl1
            Me.txtNoOrden.TabIndex = 2
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
            Me.dtpFechaPago.EnterMoveNextControl = True
            Me.dtpFechaPago.Location = New System.Drawing.Point(755, 12)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.dtpFechaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Properties.Appearance.Options.UseFont = True
            Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtpFechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
            Me.dtpFechaPago.Size = New System.Drawing.Size(101, 20)
            Me.dtpFechaPago.StyleController = Me.LayoutControl1
            Me.dtpFechaPago.TabIndex = 154
            '
            'iGrid
            '
            Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.iGrid.Location = New System.Drawing.Point(12, 238)
            Me.iGrid.MainView = Me.iVista
            Me.iGrid.Name = "iGrid"
            Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPrecioC, Me.txtPrecioU, Me.txtDescuento, Me.txtCantidad, Me.cbProducto, Me.cbProyecto, Me.cbCatalogo, Me.cbPedidos})
            Me.iGrid.Size = New System.Drawing.Size(844, 207)
            Me.iGrid.TabIndex = 1
            Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
            '
            'iVista
            '
            Me.iVista.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.iVista.Appearance.ColumnFilterButton.Options.UseBackColor = True
            Me.iVista.Appearance.ColumnFilterButton.Options.UseBorderColor = True
            Me.iVista.Appearance.ColumnFilterButton.Options.UseForeColor = True
            Me.iVista.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.iVista.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.iVista.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
            Me.iVista.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
            Me.iVista.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
            Me.iVista.Appearance.Empty.BackColor = System.Drawing.Color.White
            Me.iVista.Appearance.Empty.Options.UseBackColor = True
            Me.iVista.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
            Me.iVista.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.EvenRow.Options.UseBackColor = True
            Me.iVista.Appearance.EvenRow.Options.UseForeColor = True
            Me.iVista.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.iVista.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.iVista.Appearance.FilterCloseButton.Options.UseBackColor = True
            Me.iVista.Appearance.FilterCloseButton.Options.UseBorderColor = True
            Me.iVista.Appearance.FilterCloseButton.Options.UseForeColor = True
            Me.iVista.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
            Me.iVista.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
            Me.iVista.Appearance.FilterPanel.Options.UseBackColor = True
            Me.iVista.Appearance.FilterPanel.Options.UseForeColor = True
            Me.iVista.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
            Me.iVista.Appearance.FixedLine.Options.UseBackColor = True
            Me.iVista.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.iVista.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.iVista.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Red
            Me.iVista.Appearance.FocusedCell.Options.UseBackColor = True
            Me.iVista.Appearance.FocusedCell.Options.UseFont = True
            Me.iVista.Appearance.FocusedCell.Options.UseForeColor = True
            Me.iVista.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.iVista.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.iVista.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
            Me.iVista.Appearance.FocusedRow.Options.UseBackColor = True
            Me.iVista.Appearance.FocusedRow.Options.UseFont = True
            Me.iVista.Appearance.FocusedRow.Options.UseForeColor = True
            Me.iVista.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.iVista.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.iVista.Appearance.FooterPanel.Options.UseBackColor = True
            Me.iVista.Appearance.FooterPanel.Options.UseBorderColor = True
            Me.iVista.Appearance.FooterPanel.Options.UseForeColor = True
            Me.iVista.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.GroupButton.Options.UseBackColor = True
            Me.iVista.Appearance.GroupButton.Options.UseBorderColor = True
            Me.iVista.Appearance.GroupButton.Options.UseForeColor = True
            Me.iVista.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.GroupFooter.Options.UseBackColor = True
            Me.iVista.Appearance.GroupFooter.Options.UseBorderColor = True
            Me.iVista.Appearance.GroupFooter.Options.UseForeColor = True
            Me.iVista.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
            Me.iVista.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.iVista.Appearance.GroupPanel.Options.UseBackColor = True
            Me.iVista.Appearance.GroupPanel.Options.UseForeColor = True
            Me.iVista.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.iVista.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.iVista.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.GroupRow.Options.UseBackColor = True
            Me.iVista.Appearance.GroupRow.Options.UseBorderColor = True
            Me.iVista.Appearance.GroupRow.Options.UseFont = True
            Me.iVista.Appearance.GroupRow.Options.UseForeColor = True
            Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.iVista.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
            Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
            Me.iVista.Appearance.HeaderPanel.Options.UseForeColor = True
            Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.iVista.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.iVista.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.iVista.Appearance.HideSelectionRow.Options.UseBackColor = True
            Me.iVista.Appearance.HideSelectionRow.Options.UseForeColor = True
            Me.iVista.Appearance.OddRow.BackColor = System.Drawing.Color.White
            Me.iVista.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.OddRow.Options.UseBackColor = True
            Me.iVista.Appearance.OddRow.Options.UseForeColor = True
            Me.iVista.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.iVista.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
            Me.iVista.Appearance.Preview.Options.UseBackColor = True
            Me.iVista.Appearance.Preview.Options.UseForeColor = True
            Me.iVista.Appearance.Row.BackColor = System.Drawing.Color.White
            Me.iVista.Appearance.Row.ForeColor = System.Drawing.Color.Black
            Me.iVista.Appearance.Row.Options.UseBackColor = True
            Me.iVista.Appearance.Row.Options.UseForeColor = True
            Me.iVista.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
            Me.iVista.Appearance.RowSeparator.Options.UseBackColor = True
            Me.iVista.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
            Me.iVista.Appearance.SelectedRow.Options.UseForeColor = True
            Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.Descripcion, Me.GridColumn21, Me.GridColumn11, Me.GridColumn12, Me.GridColumn20, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.IdDetalle, Me.GridColumn7})
            Me.iVista.GridControl = Me.iGrid
            Me.iVista.Name = "iVista"
            Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.iVista.OptionsView.ShowFooter = True
            Me.iVista.OptionsView.ShowGroupPanel = False
            '
            'GridColumn3
            '
            Me.GridColumn3.Caption = "Codigo"
            Me.GridColumn3.ColumnEdit = Me.cbProducto
            Me.GridColumn3.FieldName = "Codigo"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 0
            Me.GridColumn3.Width = 60
            '
            'cbProducto
            '
            Me.cbProducto.AutoHeight = False
            Me.cbProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbProducto.Name = "cbProducto"
            Me.cbProducto.NullText = "[Seleccione Producto]"
            Me.cbProducto.PopupView = Me.RepositoryItemSearchLookUpEdit1View
            '
            'RepositoryItemSearchLookUpEdit1View
            '
            Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
            Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'Descripcion
            '
            Me.Descripcion.Caption = "Descripcion"
            Me.Descripcion.FieldName = "Descripcion"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.Visible = True
            Me.Descripcion.VisibleIndex = 1
            Me.Descripcion.Width = 153
            '
            'GridColumn21
            '
            Me.GridColumn21.Caption = "U/M"
            Me.GridColumn21.FieldName = "Unidad"
            Me.GridColumn21.Name = "GridColumn21"
            Me.GridColumn21.OptionsColumn.AllowEdit = False
            Me.GridColumn21.OptionsColumn.AllowFocus = False
            Me.GridColumn21.Visible = True
            Me.GridColumn21.VisibleIndex = 3
            Me.GridColumn21.Width = 39
            '
            'GridColumn11
            '
            Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridColumn11.Caption = "Cantidad"
            Me.GridColumn11.ColumnEdit = Me.txtCantidad
            Me.GridColumn11.FieldName = "Cantidad"
            Me.GridColumn11.Name = "GridColumn11"
            Me.GridColumn11.Visible = True
            Me.GridColumn11.VisibleIndex = 4
            Me.GridColumn11.Width = 43
            '
            'txtCantidad
            '
            Me.txtCantidad.AutoHeight = False
            Me.txtCantidad.Mask.EditMask = "n4"
            Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
            Me.txtCantidad.Name = "txtCantidad"
            '
            'GridColumn12
            '
            Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn12.Caption = "Precio"
            Me.GridColumn12.ColumnEdit = Me.txtPrecioC
            Me.GridColumn12.FieldName = "Precio"
            Me.GridColumn12.Name = "GridColumn12"
            Me.GridColumn12.Visible = True
            Me.GridColumn12.VisibleIndex = 5
            Me.GridColumn12.Width = 46
            '
            'txtPrecioC
            '
            Me.txtPrecioC.AutoHeight = False
            Me.txtPrecioC.Mask.UseMaskAsDisplayFormat = True
            Me.txtPrecioC.Name = "txtPrecioC"
            '
            'GridColumn20
            '
            Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn20.Caption = "Precio U$"
            Me.GridColumn20.ColumnEdit = Me.txtPrecioU
            Me.GridColumn20.FieldName = "PrecioU"
            Me.GridColumn20.Name = "GridColumn20"
            Me.GridColumn20.Visible = True
            Me.GridColumn20.VisibleIndex = 6
            Me.GridColumn20.Width = 54
            '
            'txtPrecioU
            '
            Me.txtPrecioU.AutoHeight = False
            Me.txtPrecioU.Mask.UseMaskAsDisplayFormat = True
            Me.txtPrecioU.Name = "txtPrecioU"
            '
            'GridColumn13
            '
            Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn13.Caption = "Descuento %"
            Me.GridColumn13.ColumnEdit = Me.txtDescuento
            Me.GridColumn13.FieldName = "Descuento"
            Me.GridColumn13.Name = "GridColumn13"
            Me.GridColumn13.Visible = True
            Me.GridColumn13.VisibleIndex = 7
            Me.GridColumn13.Width = 53
            '
            'txtDescuento
            '
            Me.txtDescuento.AutoHeight = False
            Me.txtDescuento.Mask.EditMask = "P2"
            Me.txtDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.txtDescuento.Mask.UseMaskAsDisplayFormat = True
            Me.txtDescuento.Name = "txtDescuento"
            '
            'GridColumn14
            '
            Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
            Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.GridColumn14.Caption = "Sub Total"
            Me.GridColumn14.DisplayFormat.FormatString = "{0:n2}"
            Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn14.FieldName = "SubTotal"
            Me.GridColumn14.Name = "GridColumn14"
            Me.GridColumn14.OptionsColumn.AllowEdit = False
            Me.GridColumn14.OptionsColumn.AllowFocus = False
            Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:n2}")})
            Me.GridColumn14.Visible = True
            Me.GridColumn14.VisibleIndex = 8
            Me.GridColumn14.Width = 51
            '
            'GridColumn15
            '
            Me.GridColumn15.Caption = "Tipo"
            Me.GridColumn15.FieldName = "Tipo"
            Me.GridColumn15.Name = "GridColumn15"
            Me.GridColumn15.Width = 36
            '
            'GridColumn16
            '
            Me.GridColumn16.Caption = "Exento"
            Me.GridColumn16.FieldName = "Exento"
            Me.GridColumn16.Name = "GridColumn16"
            Me.GridColumn16.Width = 51
            '
            'GridColumn17
            '
            Me.GridColumn17.Caption = "Proyecto"
            Me.GridColumn17.ColumnEdit = Me.cbProyecto
            Me.GridColumn17.FieldName = "IdProyecto"
            Me.GridColumn17.Name = "GridColumn17"
            Me.GridColumn17.Visible = True
            Me.GridColumn17.VisibleIndex = 9
            Me.GridColumn17.Width = 92
            '
            'cbProyecto
            '
            Me.cbProyecto.AutoHeight = False
            Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbProyecto.Name = "cbProyecto"
            Me.cbProyecto.NullText = "[Proyecto]"
            Me.cbProyecto.PopupView = Me.GridView1
            '
            'GridView1
            '
            Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'GridColumn1
            '
            Me.GridColumn1.Caption = "No. Pedido"
            Me.GridColumn1.ColumnEdit = Me.cbPedidos
            Me.GridColumn1.FieldName = "IdOrdenCompra"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 10
            Me.GridColumn1.Width = 98
            '
            'cbPedidos
            '
            Me.cbPedidos.AutoHeight = False
            Me.cbPedidos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbPedidos.Name = "cbPedidos"
            Me.cbPedidos.PopupView = Me.RepositoryItemSearchLookUpEdit2View
            '
            'RepositoryItemSearchLookUpEdit2View
            '
            Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
            Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
            '
            'GridColumn2
            '
            Me.GridColumn2.Caption = "Cuenta"
            Me.GridColumn2.ColumnEdit = Me.cbCatalogo
            Me.GridColumn2.FieldName = "Cuenta"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 2
            Me.GridColumn2.Width = 58
            '
            'cbCatalogo
            '
            Me.cbCatalogo.AutoHeight = False
            Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCatalogo.Name = "cbCatalogo"
            Me.cbCatalogo.PopupView = Me.GridView2
            '
            'GridView2
            '
            Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridView2.Name = "GridView2"
            Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridView2.OptionsView.ShowGroupPanel = False
            '
            'GridColumn4
            '
            Me.GridColumn4.Caption = "Flete"
            Me.GridColumn4.FieldName = "IsFlete"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 11
            Me.GridColumn4.Width = 36
            '
            'GridColumn5
            '
            Me.GridColumn5.Caption = "Seguro"
            Me.GridColumn5.FieldName = "IsSeguro"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 12
            Me.GridColumn5.Width = 43
            '
            'GridColumn6
            '
            Me.GridColumn6.Caption = "ir"
            Me.GridColumn6.FieldName = "ir"
            Me.GridColumn6.Name = "GridColumn6"
            '
            'IdDetalle
            '
            Me.IdDetalle.Caption = "IdDetalle"
            Me.IdDetalle.FieldName = "IdDetalle"
            Me.IdDetalle.Name = "IdDetalle"
            Me.IdDetalle.OptionsColumn.AllowEdit = False
            Me.IdDetalle.OptionsColumn.AllowFocus = False
            Me.IdDetalle.Visible = True
            Me.IdDetalle.VisibleIndex = 13
            '
            'GridColumn7
            '
            Me.GridColumn7.Caption = "Entregado"
            Me.GridColumn7.ColumnEdit = Me.txtCantidad
            Me.GridColumn7.FieldName = "Entregado"
            Me.GridColumn7.Name = "GridColumn7"
            Me.GridColumn7.OptionsColumn.AllowEdit = False
            Me.GridColumn7.OptionsColumn.AllowFocus = False
            Me.GridColumn7.Visible = True
            Me.GridColumn7.VisibleIndex = 14
            '
            'dtpFecha
            '
            Me.dtpFecha.EditValue = New Date(2009, 7, 15, 14, 28, 10, 843)
            Me.dtpFecha.EnterMoveNextControl = True
            Me.dtpFecha.Location = New System.Drawing.Point(545, 12)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Properties.Appearance.Options.UseFont = True
            Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtpFecha.Properties.Mask.EditMask = "ddMMyy"
            Me.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
            Me.dtpFecha.Size = New System.Drawing.Size(99, 20)
            Me.dtpFecha.StyleController = Me.LayoutControl1
            Me.dtpFecha.TabIndex = 1
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem11, Me.LayoutControlItem9, Me.LayoutControlItem24, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.LayoutControlItem7, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.LayoutControlItem29, Me.LayoutControlItem36, Me.LayoutControlItem26, Me.LayoutControlItem28, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem30, Me.LayoutControlItem27, Me.LayoutControlItem8, Me.LayoutControlItem39, Me.LayoutControlItem41, Me.LayoutControlItem44, Me.LayoutControlItem45, Me.LayoutControlItem46, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem19, Me.LayoutControlItem42, Me.LayoutControlItem43, Me.LayoutControlItem25, Me.lyTotal, Me.LayoutControlItem20, Me.LayoutControlItem23, Me.LayoutControlItem10})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(868, 561)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.txtNoOrden
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(259, 26)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(259, 26)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(259, 26)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "No. Orden:"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.dtpFecha
            Me.LayoutControlItem4.Location = New System.Drawing.Point(426, 0)
            Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(210, 24)
            Me.LayoutControlItem4.MinSize = New System.Drawing.Size(210, 24)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(210, 24)
            Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem4.Text = "Fecha:"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.dtpFechaPago
            Me.LayoutControlItem5.Location = New System.Drawing.Point(636, 0)
            Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(212, 24)
            Me.LayoutControlItem5.MinSize = New System.Drawing.Size(212, 24)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(212, 24)
            Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem5.Text = "Fecha de Pago:"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.iGrid
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 226)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(848, 211)
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem11.TextVisible = False
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.cbTipoFactura
            Me.LayoutControlItem9.Location = New System.Drawing.Point(275, 102)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(573, 24)
            Me.LayoutControlItem9.Text = "Forma de Pago:"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem24
            '
            Me.LayoutControlItem24.Control = Me.cbMoneda
            Me.LayoutControlItem24.Location = New System.Drawing.Point(275, 76)
            Me.LayoutControlItem24.Name = "LayoutControlItem24"
            Me.LayoutControlItem24.Size = New System.Drawing.Size(408, 26)
            Me.LayoutControlItem24.Text = "Moneda:"
            Me.LayoutControlItem24.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem31
            '
            Me.LayoutControlItem31.Control = Me.cbConsignatarios
            Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 76)
            Me.LayoutControlItem31.Name = "LayoutControlItem31"
            Me.LayoutControlItem31.Size = New System.Drawing.Size(275, 26)
            Me.LayoutControlItem31.Text = "Consignatario:"
            Me.LayoutControlItem31.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem32
            '
            Me.LayoutControlItem32.Control = Me.cbAgencias
            Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 102)
            Me.LayoutControlItem32.Name = "LayoutControlItem32"
            Me.LayoutControlItem32.Size = New System.Drawing.Size(275, 24)
            Me.LayoutControlItem32.Text = "Agencia:"
            Me.LayoutControlItem32.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.TipoServicio
            Me.LayoutControlItem7.Location = New System.Drawing.Point(320, 174)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(404, 52)
            Me.LayoutControlItem7.Text = "Tipo:"
            Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem7.TextVisible = False
            '
            'LayoutControlItem33
            '
            Me.LayoutControlItem33.Control = Me.cbMetodosEnvios
            Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 126)
            Me.LayoutControlItem33.Name = "LayoutControlItem33"
            Me.LayoutControlItem33.Size = New System.Drawing.Size(275, 24)
            Me.LayoutControlItem33.Text = "Metodo de Envio:"
            Me.LayoutControlItem33.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem34
            '
            Me.LayoutControlItem34.Control = Me.cbProveedor
            Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem34.Name = "LayoutControlItem34"
            Me.LayoutControlItem34.Size = New System.Drawing.Size(426, 24)
            Me.LayoutControlItem34.Text = "Proveedor:"
            Me.LayoutControlItem34.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem35
            '
            Me.LayoutControlItem35.Control = Me.cbCondiciones
            Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 150)
            Me.LayoutControlItem35.Name = "LayoutControlItem35"
            Me.LayoutControlItem35.Size = New System.Drawing.Size(275, 24)
            Me.LayoutControlItem35.Text = "Condición de Venta:"
            Me.LayoutControlItem35.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem29
            '
            Me.LayoutControlItem29.Control = Me.txtAtencion
            Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem29.Name = "LayoutControlItem29"
            Me.LayoutControlItem29.Size = New System.Drawing.Size(442, 26)
            Me.LayoutControlItem29.Text = "Atención A:"
            Me.LayoutControlItem29.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem29.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem36
            '
            Me.LayoutControlItem36.Control = Me.txtFactura
            Me.LayoutControlItem36.Location = New System.Drawing.Point(648, 24)
            Me.LayoutControlItem36.MaxSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem36.MinSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem36.Name = "LayoutControlItem36"
            Me.LayoutControlItem36.Size = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem36.Text = "#Consecutivo:"
            Me.LayoutControlItem36.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem26
            '
            Me.LayoutControlItem26.Control = Me.FechaEntrega
            Me.LayoutControlItem26.Location = New System.Drawing.Point(442, 24)
            Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem26.MinSize = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem26.Name = "LayoutControlItem26"
            Me.LayoutControlItem26.Size = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem26.Text = "Fecha de Entrega:"
            Me.LayoutControlItem26.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem28
            '
            Me.LayoutControlItem28.Control = Me.txtLogin
            Me.LayoutControlItem28.Location = New System.Drawing.Point(497, 50)
            Me.LayoutControlItem28.Name = "LayoutControlItem28"
            Me.LayoutControlItem28.Size = New System.Drawing.Size(351, 26)
            Me.LayoutControlItem28.Text = "Usuario:"
            Me.LayoutControlItem28.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.txtPedido
            Me.LayoutControlItem2.Location = New System.Drawing.Point(259, 50)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(238, 26)
            Me.LayoutControlItem2.Text = "No. Proforma:"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.etTasa
            Me.LayoutControlItem6.Location = New System.Drawing.Point(683, 76)
            Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(165, 26)
            Me.LayoutControlItem6.MinSize = New System.Drawing.Size(165, 26)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(165, 26)
            Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem6.Text = "T/Cambio:"
            Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(49, 13)
            Me.LayoutControlItem6.TextToControlDistance = 5
            '
            'LayoutControlItem30
            '
            Me.LayoutControlItem30.Control = Me.cbEstados
            Me.LayoutControlItem30.Location = New System.Drawing.Point(275, 150)
            Me.LayoutControlItem30.Name = "LayoutControlItem30"
            Me.LayoutControlItem30.Size = New System.Drawing.Size(573, 24)
            Me.LayoutControlItem30.Text = "Status O/C:"
            Me.LayoutControlItem30.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem30.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem27
            '
            Me.LayoutControlItem27.Control = Me.txtEmbarque
            Me.LayoutControlItem27.Location = New System.Drawing.Point(275, 126)
            Me.LayoutControlItem27.Name = "LayoutControlItem27"
            Me.LayoutControlItem27.Size = New System.Drawing.Size(573, 24)
            Me.LayoutControlItem27.Text = "Fecha de Embarque:"
            Me.LayoutControlItem27.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.ckLiquidar
            Me.LayoutControlItem8.Location = New System.Drawing.Point(724, 200)
            Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem8.MinSize = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem8.TextVisible = False
            '
            'LayoutControlItem39
            '
            Me.LayoutControlItem39.Control = Me.chkPrincipal
            Me.LayoutControlItem39.Location = New System.Drawing.Point(724, 174)
            Me.LayoutControlItem39.MaxSize = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem39.MinSize = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem39.Name = "LayoutControlItem39"
            Me.LayoutControlItem39.Size = New System.Drawing.Size(124, 26)
            Me.LayoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem39.TextVisible = False
            '
            'LayoutControlItem41
            '
            Me.LayoutControlItem41.Control = Me.chkIR
            Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 174)
            Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(206, 24)
            Me.LayoutControlItem41.MinSize = New System.Drawing.Size(206, 24)
            Me.LayoutControlItem41.Name = "LayoutControlItem41"
            Me.LayoutControlItem41.Size = New System.Drawing.Size(206, 24)
            Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem41.TextVisible = False
            '
            'LayoutControlItem44
            '
            Me.LayoutControlItem44.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem44.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem44.Control = Me.txtRetencionAlma
            Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 489)
            Me.LayoutControlItem44.MaxSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem44.MinSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem44.Name = "LayoutControlItem44"
            Me.LayoutControlItem44.Size = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem44.Text = "Municipal:     "
            Me.LayoutControlItem44.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem44.TextSize = New System.Drawing.Size(71, 13)
            Me.LayoutControlItem44.TextToControlDistance = 5
            '
            'LayoutControlItem45
            '
            Me.LayoutControlItem45.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem45.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem45.Control = Me.txtAPagar
            Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 515)
            Me.LayoutControlItem45.MaxSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem45.MinSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem45.Name = "LayoutControlItem45"
            Me.LayoutControlItem45.Size = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem45.Text = "A Pagar:      "
            Me.LayoutControlItem45.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem45.TextSize = New System.Drawing.Size(65, 13)
            Me.LayoutControlItem45.TextToControlDistance = 5
            '
            'LayoutControlItem46
            '
            Me.LayoutControlItem46.Control = Me.chkAlma
            Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 198)
            Me.LayoutControlItem46.MaxSize = New System.Drawing.Size(206, 28)
            Me.LayoutControlItem46.MinSize = New System.Drawing.Size(206, 28)
            Me.LayoutControlItem46.Name = "LayoutControlItem46"
            Me.LayoutControlItem46.Size = New System.Drawing.Size(206, 28)
            Me.LayoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem46.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem46.TextVisible = False
            '
            'LayoutControlItem21
            '
            Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem21.Control = Me.sIrP
            Me.LayoutControlItem21.Location = New System.Drawing.Point(206, 174)
            Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(114, 24)
            Me.LayoutControlItem21.MinSize = New System.Drawing.Size(114, 24)
            Me.LayoutControlItem21.Name = "LayoutControlItem21"
            Me.LayoutControlItem21.Size = New System.Drawing.Size(114, 24)
            Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem21.Text = "%"
            Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem21.TextSize = New System.Drawing.Size(14, 14)
            Me.LayoutControlItem21.TextToControlDistance = 5
            '
            'LayoutControlItem22
            '
            Me.LayoutControlItem22.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem22.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem22.Control = Me.sIR_AlmaP
            Me.LayoutControlItem22.Location = New System.Drawing.Point(206, 198)
            Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(114, 28)
            Me.LayoutControlItem22.MinSize = New System.Drawing.Size(114, 28)
            Me.LayoutControlItem22.Name = "LayoutControlItem22"
            Me.LayoutControlItem22.Size = New System.Drawing.Size(114, 28)
            Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem22.Text = "%"
            Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem22.TextSize = New System.Drawing.Size(14, 14)
            Me.LayoutControlItem22.TextToControlDistance = 5
            '
            'LayoutControlItem19
            '
            Me.LayoutControlItem19.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem19.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem19.Control = Me.tSubTotal
            Me.LayoutControlItem19.Location = New System.Drawing.Point(648, 437)
            Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem19.MinSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem19.Name = "LayoutControlItem19"
            Me.LayoutControlItem19.Size = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem19.Text = "Sub Total:"
            Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem19.TextSize = New System.Drawing.Size(63, 14)
            Me.LayoutControlItem19.TextToControlDistance = 5
            '
            'LayoutControlItem42
            '
            Me.LayoutControlItem42.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem42.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem42.Control = Me.txtSubTotalIR
            Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 437)
            Me.LayoutControlItem42.MaxSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem42.MinSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem42.Name = "LayoutControlItem42"
            Me.LayoutControlItem42.Size = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem42.Text = "Sub Total IR:"
            Me.LayoutControlItem42.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem42.TextSize = New System.Drawing.Size(72, 13)
            Me.LayoutControlItem42.TextToControlDistance = 5
            '
            'LayoutControlItem43
            '
            Me.LayoutControlItem43.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem43.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem43.Control = Me.txtRetencion
            Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 463)
            Me.LayoutControlItem43.MaxSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem43.MinSize = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem43.Name = "LayoutControlItem43"
            Me.LayoutControlItem43.Size = New System.Drawing.Size(195, 26)
            Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem43.Text = "Retención:    "
            Me.LayoutControlItem43.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem43.TextSize = New System.Drawing.Size(72, 13)
            Me.LayoutControlItem43.TextToControlDistance = 5
            '
            'LayoutControlItem25
            '
            Me.LayoutControlItem25.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem25.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem25.Control = Me.tTotalU
            Me.LayoutControlItem25.Location = New System.Drawing.Point(648, 515)
            Me.LayoutControlItem25.MaxSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem25.MinSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem25.Name = "LayoutControlItem25"
            Me.LayoutControlItem25.Size = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem25.Text = "Total CIF U$:"
            Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem25.TextSize = New System.Drawing.Size(78, 14)
            Me.LayoutControlItem25.TextToControlDistance = 5
            '
            'lyTotal
            '
            Me.lyTotal.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lyTotal.AppearanceItemCaption.Options.UseFont = True
            Me.lyTotal.Control = Me.tTotal
            Me.lyTotal.Location = New System.Drawing.Point(648, 489)
            Me.lyTotal.MaxSize = New System.Drawing.Size(200, 26)
            Me.lyTotal.MinSize = New System.Drawing.Size(200, 26)
            Me.lyTotal.Name = "lyTotal"
            Me.lyTotal.Size = New System.Drawing.Size(200, 26)
            Me.lyTotal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lyTotal.Text = "Total:       "
            Me.lyTotal.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.lyTotal.TextSize = New System.Drawing.Size(63, 14)
            Me.lyTotal.TextToControlDistance = 5
            '
            'LayoutControlItem20
            '
            Me.LayoutControlItem20.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem20.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem20.Control = Me.tIva
            Me.LayoutControlItem20.Location = New System.Drawing.Point(648, 463)
            Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem20.MinSize = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem20.Name = "LayoutControlItem20"
            Me.LayoutControlItem20.Size = New System.Drawing.Size(200, 26)
            Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem20.Text = "Impuesto:"
            Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.LayoutControlItem20.TextSize = New System.Drawing.Size(63, 14)
            Me.LayoutControlItem20.TextToControlDistance = 5
            '
            'LayoutControlItem23
            '
            Me.LayoutControlItem23.Control = Me.mComentarios
            Me.LayoutControlItem23.Location = New System.Drawing.Point(195, 437)
            Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(0, 104)
            Me.LayoutControlItem23.MinSize = New System.Drawing.Size(108, 104)
            Me.LayoutControlItem23.Name = "LayoutControlItem23"
            Me.LayoutControlItem23.Size = New System.Drawing.Size(226, 104)
            Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem23.Text = "Comentario:"
            Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem23.TextSize = New System.Drawing.Size(104, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.mComentarioG
            Me.LayoutControlItem10.Location = New System.Drawing.Point(421, 437)
            Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(0, 104)
            Me.LayoutControlItem10.MinSize = New System.Drawing.Size(108, 104)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(227, 104)
            Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem10.Text = "Comentario Gerencia:"
            Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(104, 13)
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdCancelar.Location = New System.Drawing.Point(12, 484)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(109, 36)
            Me.cmdCancelar.StyleController = Me.LayoutControl2
            Me.cmdCancelar.TabIndex = 1
            Me.cmdCancelar.Text = "&Salir"
            '
            'LayoutControl2
            '
            Me.LayoutControl2.Controls.Add(Me.bGuardarHija)
            Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
            Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
            Me.LayoutControl2.Controls.Add(Me.bImprimir)
            Me.LayoutControl2.Controls.Add(Me.etDestino)
            Me.LayoutControl2.Controls.Add(Me.cmdPedidos)
            Me.LayoutControl2.Controls.Add(Me.lbOrigen)
            Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
            Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
            Me.LayoutControl2.Controls.Add(Me.cmdConsulta)
            Me.LayoutControl2.Controls.Add(Me.cmdConsultaProveedores)
            Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl2.Name = "LayoutControl2"
            Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1114, 309, 250, 350)
            Me.LayoutControl2.Root = Me.LayoutControlGroup2
            Me.LayoutControl2.Size = New System.Drawing.Size(133, 532)
            Me.LayoutControl2.TabIndex = 0
            Me.LayoutControl2.Text = "LayoutControl2"
            '
            'bGuardarHija
            '
            Me.bGuardarHija.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bGuardarHija.Appearance.ForeColor = System.Drawing.Color.Black
            Me.bGuardarHija.Appearance.Options.UseFont = True
            Me.bGuardarHija.Appearance.Options.UseForeColor = True
            Me.bGuardarHija.Appearance.Options.UseTextOptions = True
            Me.bGuardarHija.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.bGuardarHija.Enabled = False
            Me.bGuardarHija.ImageOptions.Image = CType(resources.GetObject("bGuardarHija.ImageOptions.Image"), System.Drawing.Image)
            Me.bGuardarHija.Location = New System.Drawing.Point(12, 52)
            Me.bGuardarHija.Name = "bGuardarHija"
            Me.bGuardarHija.Size = New System.Drawing.Size(107, 38)
            Me.bGuardarHija.StyleController = Me.LayoutControl2
            Me.bGuardarHija.TabIndex = 164
            Me.bGuardarHija.Text = "Guardar O/C Hija"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
            Me.SimpleButton2.Location = New System.Drawing.Point(12, 444)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(109, 36)
            Me.SimpleButton2.StyleController = Me.LayoutControl2
            Me.SimpleButton2.TabIndex = 164
            Me.SimpleButton2.Text = "E&xportar"
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
            Me.SimpleButton1.Location = New System.Drawing.Point(12, 134)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(107, 38)
            Me.SimpleButton1.StyleController = Me.LayoutControl2
            Me.SimpleButton1.TabIndex = 164
            Me.SimpleButton1.Text = "Adjuntar &Docuento"
            '
            'bImprimir
            '
            Me.bImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.bImprimir.Appearance.Options.UseFont = True
            Me.bImprimir.Appearance.Options.UseForeColor = True
            Me.bImprimir.Enabled = False
            Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
            Me.bImprimir.Location = New System.Drawing.Point(12, 94)
            Me.bImprimir.Name = "bImprimir"
            Me.bImprimir.Size = New System.Drawing.Size(109, 36)
            Me.bImprimir.StyleController = Me.LayoutControl2
            Me.bImprimir.TabIndex = 164
            Me.bImprimir.Text = "&Imprimir"
            '
            'etDestino
            '
            Me.etDestino.Location = New System.Drawing.Point(12, 310)
            Me.etDestino.Name = "etDestino"
            Me.etDestino.Size = New System.Drawing.Size(109, 52)
            Me.etDestino.TabIndex = 151
            Me.etDestino.Text = "Destino"
            Me.etDestino.Visible = False
            '
            'cmdPedidos
            '
            Me.cmdPedidos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPedidos.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdPedidos.Appearance.Options.UseFont = True
            Me.cmdPedidos.Appearance.Options.UseForeColor = True
            Me.cmdPedidos.Location = New System.Drawing.Point(12, 418)
            Me.cmdPedidos.Name = "cmdPedidos"
            Me.cmdPedidos.Size = New System.Drawing.Size(109, 22)
            Me.cmdPedidos.StyleController = Me.LayoutControl2
            Me.cmdPedidos.TabIndex = 4
            Me.cmdPedidos.Text = "Pe&didos"
            '
            'lbOrigen
            '
            Me.lbOrigen.Location = New System.Drawing.Point(12, 283)
            Me.lbOrigen.Name = "lbOrigen"
            Me.lbOrigen.Size = New System.Drawing.Size(109, 23)
            Me.lbOrigen.TabIndex = 150
            Me.lbOrigen.Text = "Origen"
            Me.lbOrigen.Visible = False
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
            Me.cmdAceptar.Size = New System.Drawing.Size(109, 36)
            Me.cmdAceptar.StyleController = Me.LayoutControl2
            Me.cmdAceptar.TabIndex = 0
            Me.cmdAceptar.Text = "&Guardar"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Appearance.Options.UseFont = True
            Me.cmdConsulta.Appearance.Options.UseForeColor = True
            Me.cmdConsulta.Location = New System.Drawing.Point(12, 392)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(109, 22)
            Me.cmdConsulta.StyleController = Me.LayoutControl2
            Me.cmdConsulta.TabIndex = 3
            Me.cmdConsulta.Text = "&Productos"
            '
            'cmdConsultaProveedores
            '
            Me.cmdConsultaProveedores.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedores.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedores.Appearance.Options.UseFont = True
            Me.cmdConsultaProveedores.Appearance.Options.UseForeColor = True
            Me.cmdConsultaProveedores.Location = New System.Drawing.Point(12, 366)
            Me.cmdConsultaProveedores.Name = "cmdConsultaProveedores"
            Me.cmdConsultaProveedores.Size = New System.Drawing.Size(109, 22)
            Me.cmdConsultaProveedores.StyleController = Me.LayoutControl2
            Me.cmdConsultaProveedores.TabIndex = 2
            Me.cmdConsultaProveedores.Text = "Pro&veedor"
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup2.GroupBordersVisible = False
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.EmptySpaceItem1, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem1, Me.LayoutControlItem37, Me.LayoutControlItem13, Me.LayoutControlItem38, Me.LayoutControlItem40})
            Me.LayoutControlGroup2.Name = "Root"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(133, 532)
            Me.LayoutControlGroup2.TextVisible = False
            '
            'LayoutControlItem12
            '
            Me.LayoutControlItem12.Control = Me.cmdAceptar
            Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem12.Name = "LayoutControlItem12"
            Me.LayoutControlItem12.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem12.TextVisible = False
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 164)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(113, 107)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem15
            '
            Me.LayoutControlItem15.Control = Me.cmdConsultaProveedores
            Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 354)
            Me.LayoutControlItem15.Name = "LayoutControlItem15"
            Me.LayoutControlItem15.Size = New System.Drawing.Size(113, 26)
            Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem15.TextVisible = False
            Me.LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem14
            '
            Me.LayoutControlItem14.Control = Me.cmdConsulta
            Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 380)
            Me.LayoutControlItem14.Name = "LayoutControlItem14"
            Me.LayoutControlItem14.Size = New System.Drawing.Size(113, 26)
            Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem14.TextVisible = False
            Me.LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem16
            '
            Me.LayoutControlItem16.Control = Me.cmdPedidos
            Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 406)
            Me.LayoutControlItem16.Name = "LayoutControlItem16"
            Me.LayoutControlItem16.Size = New System.Drawing.Size(113, 26)
            Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem16.TextVisible = False
            Me.LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem17
            '
            Me.LayoutControlItem17.Control = Me.lbOrigen
            Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 271)
            Me.LayoutControlItem17.Name = "LayoutControlItem17"
            Me.LayoutControlItem17.Size = New System.Drawing.Size(113, 27)
            Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem17.TextVisible = False
            Me.LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem18
            '
            Me.LayoutControlItem18.Control = Me.etDestino
            Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 298)
            Me.LayoutControlItem18.Name = "LayoutControlItem18"
            Me.LayoutControlItem18.Size = New System.Drawing.Size(113, 56)
            Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem18.TextVisible = False
            Me.LayoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.bImprimir
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 82)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem37
            '
            Me.LayoutControlItem37.Control = Me.SimpleButton1
            Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 122)
            Me.LayoutControlItem37.MaxSize = New System.Drawing.Size(111, 42)
            Me.LayoutControlItem37.MinSize = New System.Drawing.Size(111, 42)
            Me.LayoutControlItem37.Name = "LayoutControlItem37"
            Me.LayoutControlItem37.Size = New System.Drawing.Size(113, 42)
            Me.LayoutControlItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem37.TextVisible = False
            '
            'LayoutControlItem13
            '
            Me.LayoutControlItem13.Control = Me.cmdCancelar
            Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 472)
            Me.LayoutControlItem13.Name = "LayoutControlItem13"
            Me.LayoutControlItem13.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem13.TextVisible = False
            '
            'LayoutControlItem38
            '
            Me.LayoutControlItem38.Control = Me.SimpleButton2
            Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 432)
            Me.LayoutControlItem38.Name = "LayoutControlItem38"
            Me.LayoutControlItem38.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem38.TextVisible = False
            '
            'LayoutControlItem40
            '
            Me.LayoutControlItem40.Control = Me.bGuardarHija
            Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 40)
            Me.LayoutControlItem40.MaxSize = New System.Drawing.Size(111, 42)
            Me.LayoutControlItem40.MinSize = New System.Drawing.Size(111, 42)
            Me.LayoutControlItem40.Name = "LayoutControlItem40"
            Me.LayoutControlItem40.Size = New System.Drawing.Size(113, 42)
            Me.LayoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem40.TextVisible = False
            Me.LayoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
            Me.DockPanel1.ID = New System.Guid("3496dba6-9055-4e48-808f-d557ecd2b8dc")
            Me.DockPanel1.Location = New System.Drawing.Point(868, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.Options.ShowCloseButton = False
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(140, 561)
            Me.DockPanel1.Text = "Opciones"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 532)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'frmOrdenesCompra
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1008, 561)
            Me.Controls.Add(Me.LayoutControl1)
            Me.Controls.Add(Me.DockPanel1)
            Me.Name = "frmOrdenesCompra"
            CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.sIR_AlmaP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sIrP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAlma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtAPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtRetencionAlma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtRetencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSubTotalIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkPrincipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mComentarioG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbMetodosEnvios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbConsignatarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbAgencias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbEstados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtAtencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtEmbarque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tTotalU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbPedidos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl2.ResumeLayout(False)
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        'Dim WithEvents tCust As DataTable
        'Private WithEvents myDataSet As DataSet
        Dim ds As DataSet

        Dim i As Integer
        Dim Tipo As Integer

        Dim WithEvents Articulo As DataGridComboBoxColumn
        Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim Descuento As DataGridTextBoxColumn
        Dim Precio As DataGridTextBoxColumn
        'ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))

        Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim OrdenesCompra As New VB.SysContab.Ordenes_ComprasDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim r As New VB.SysContab.Rutinas()

        Dim ArticulosCC As New GruposCCDB()

        Dim Pedidos As New PedidosDB()

        Dim Config As New ConfiguracionDB()
        Dim ConfigDetalles As New ConfiguracionDetails()

        Public CargarPedido As Boolean
        Public Modifica As Boolean
        Public Pedido As String

        Dim dsItems As DataSet

        Public Codigo As String
        Dim dsItemCC As DataSet

        Public TipoPedido As Integer
        Private TCambio As Double = 1
        Private Temp As Boolean = False

        Private Sub frmOrdenesCompra_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
            'Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()
            'If f.Created Then f.Cargar()
        End Sub

        Private Sub frmOrdenesCompraCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ConfigDetalles = ConfiguracionDB.GetConfigDetails()

            Dim f As Date = Rutinas.Fecha()

            dtpFecha.DateTime = f.Date
            dtpFechaPago.DateTime = f.Date
            FechaEntrega.EditValue = Nothing

            SearchLookUp(
                cbProveedor,
                ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
            GetMonedasList(cbMoneda)

            Combo(
                cbEstados,
                db_ORDENES_COMPRAS_ESTADOS.Listar(0))
            cbEstados.ItemIndex = 0

            GetConsignatarios(cbConsignatarios)
            GetMetodosEnvio(cbMetodosEnvios)
            GetAgencias(cbAgencias)
            GetCondicionesVenta(cbCondiciones)
            cbCondiciones.EditValue = Nothing

            RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 4, 5, 6, 7, 8)
            RepositorySearchLook(cbPedidos, Ordenes_ComprasDB.FillComboLiquidacion(), "Orden Compra", "IdOrden", 0)
            RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)

            LookUp(
                cbTipoFactura,
                FormaPago.FormaPagoList().Tables("Forma_Pago"),
                "Nombre",
                "Codigo",
                "[Forma de Pago]",
                0, 2, 3)
            cbTipoFactura.ItemIndex = 1

            'Me.cbTipoFactura.Properties.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            'Me.cbTipoFactura.Properties.ValueMember = "Codigo"
            'Me.cbTipoFactura.Properties.DisplayMember = "Nombre"
            'Me.cbTipoFactura.Properties.PopulateColumns()
            'Me.cbTipoFactura.Properties.Columns("Codigo").Visible = False
            'Me.cbTipoFactura.Properties.Columns("Dias").Visible = False
            'Me.cbTipoFactura.Properties.Columns("Empresa").Visible = False


            ''CargarProveedores()
            'cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            'cbTipoFactura.ValueMember = "Codigo"
            'cbTipoFactura.DisplayMember = "Nombre"
            'DBConnOrdenesCompra = New SqlConnection(Rutinas.AbrirConexion())
            'DBConnOrdenesCompra.Open()
            'transaccionOrdenesCompra = DBConnOrdenesCompra.BeginTransaction

            TCambio = GetTasaCambioDia(dtpFecha.DateTime.Date)
            etTasa.EditValue = TCambio

            If Modifica Then    'Proviene del Boton Ver (Modificar)

                ds = OrdenesCompra.OrdenComprasDetalle(
                    txtFactura.Text,
                    etDestino.Text)

                cbProveedor.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Proveedor_ID")
                dtpFecha.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Fecha")
                dtpFechaPago.DateTime = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_FechaPago")
                FechaEntrega.EditValue = IsNull(ds.Tables("Ordenes_Compras").Rows(0).Item("Fecha_Entrega"), Nothing)
                cbTipoFactura.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("FormaPago_ID")
                cbMoneda.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Moneda")
                txtNoOrden.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("NoOrden")
                etTasa.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("TCambio")
                txtPedido.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("NoPedido")
                mComentarios.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Comentarios")
                mComentarioG.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Comentaro_Gerencia")

                'tFlete.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Flete")
                'tSeguro.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Seguro")
                'tOtros.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Otros")

                txtEmbarque.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Embarque")
                txtAtencion.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Atenciona")
                cbEstados.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("IdEstado")

                TipoServicio.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Factura_Tipo")

                cbConsignatarios.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("IdConsignatario")
                cbAgencias.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("IdAgencia")
                cbMetodosEnvios.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("IdEnvio")
                cbCondiciones.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("Condiciones")
                txtLogin.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("Usuario").ToString.ToUpper
                ckLiquidar.Checked = ds.Tables("Ordenes_Compras").Rows(0).Item("Liquidacion")
                chkPrincipal.Checked = ds.Tables("Ordenes_Compras").Rows(0).Item("OC_Principal")
                chkIR.Checked = ds.Tables("Ordenes_Compras").Rows(0).Item("IR_Pagado")
                chkAlma.Checked = ds.Tables("Ordenes_Compras").Rows(0).Item("IR_Pagado_Alma")
                txtSubTotalIR.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("SubTotalIR")
                sIrP.EditValue = ds.Tables("Ordenes_Compras").Rows(0).Item("IR_Porcentaje")

                'If ds.Tables("Ordenes_Compras").Rows(0).Item("TipoOrden") <> 4 Then
                '    Me.etTasa.Text = ds.Tables("Ordenes_Compras").Rows(0).Item("TCambio")
                'End If

                'If ObtieneDatos("SELECT lmt.OrdenCompraID FROM Liquidaciones_MercaderiaTransito AS lmt WHERE lmt.OrdenCompraID = '" & txtFactura.Text & "' AND lmt.Empresa = " & EmpresaActual).Rows.Count > 0 Then
                '    ckLiquidar.Checked = True
                'End If

                CargarCombos(TipoServicio.EditValue)

                RealizarCalculos(0)
                TipoServicio.Enabled = False
                bImprimir.Enabled = True

                If ds.Tables("Ordenes_Compras").Rows(0).Item("Aprobado") = True Then
                    'iVista.OptionsBehavior.Editable = False
                    cbProveedor.Enabled = True
                End If
                '
                If EmpresaActual = 7 Then txtNoOrden.Properties.ReadOnly = True
            Else
                ds = Pedidos.PedidoDetalle(Pedido, TipoPedido)  'Proviene de Un Pedido o es Una Nueva
                txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                txtLogin.Text = Login
                '
                txtNoOrden.Text = Ordenes_ComprasDB.CodigoPersonalizadoOC()
                If EmpresaActual = 7 Then txtNoOrden.Properties.ReadOnly = True
            End If

            If CargarPedido = True Then
                If Me.TipoPedido = 1 Then TipoServicio.EditValue = "P" ' Me.rbProductos.Checked = True
                If Me.TipoPedido = 2 Then TipoServicio.EditValue = "I" 'Me.rbInventario.Checked = True

                Me.cbProveedor.EditValue = ds.Tables("Pedidos").Rows(0).Item("Proveedor_ID")
                Me.txtPedido.Text = Pedido

                If ds.Tables("Pedidos").Rows(0).Item("Tipo") = "P" Then
                    CargarCombos("P")
                ElseIf ds.Tables("Pedidos").Rows(0).Item("Tipo") = "I" Then
                    CargarCombos("I")
                End If

                txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                txtLogin.Text = Login

                'If EmpresaActual = 7 Then txtNoOrden.Text = "NI-" + txtFactura.Text.PadLeft(5, "0") + "-" + Mid(Login, 1, 2) Else txtNoOrden.Properties.ReadOnly = False

                txtNoOrden.Text = Ordenes_ComprasDB.CodigoPersonalizadoOC()
                If EmpresaActual = 7 Then txtNoOrden.Properties.ReadOnly = True
                RealizarCalculos(0)
            End If

            If CargarPedido = False And Modifica = False Then
                CargarCombos("P") 'Si es Una Orden Nueva
                txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                txtLogin.Text = Login
                'If EmpresaActual = 7 Then txtNoOrden.Text = "NI-" + txtFactura.Text.PadLeft(5, "0") + "-" + Mid(Login, 1, 2) Else txtNoOrden.Properties.ReadOnly = False

                txtNoOrden.Text = Ordenes_ComprasDB.CodigoPersonalizadoOC()
                If EmpresaActual = 7 Then txtNoOrden.Properties.ReadOnly = True
            End If

            'VB.SysContab.Rutinas.okTransaccion()
            'If Me.Pedido = "" Then
            '    CargarPedido = False
            'Else
            '    CargarPedido = True
            'End If
            'MakeDataSet()
            'dgOrdenesCompra.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            LeaveCommit = False
            BuscarCombo = True

            TipoItem = "P"
            Indice = -1
            Tipo = 0

            Me.Refresh()
        End Sub

        'Sub CargarProveedores()
        '    Me.cbProveedor.Properties.DataSource = Nothing
        '    If ChkProveedores Then  ' Mostrar Solo Proveedores Aprobados
        '        Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND (Aprobar = 1 AND Confirmar = 1) AND Empresa =" & EmpresaActual).DefaultView
        '    Else
        '        Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND Empresa =" & EmpresaActual).DefaultView
        '    End If
        '    Me.cbProveedor.Properties.ValueMember = "Codigo"
        '    Me.cbProveedor.Properties.DisplayMember = "Display"
        'End Sub

        Sub CargarCombos(ByVal p As String)
            If p = "I" Then
                RepositorySearchLook(
                    cbProducto,
                    ObtieneDatos("_ArticulosCCInvent_OC", EmpresaActual),
                    "Codigo",
                    "Codigo", 3, 4, 5, 6, 7)
                'Me.cbCodigo.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
                'Me.cbCodigo.DisplayMember = "Codigo"
                'Me.cbCodigo.ValueMember = "Codigo"

                'Me.cbDescrip.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
                'Me.cbDescrip.DisplayMember = "Nombre"
                'Me.cbDescrip.ValueMember = "Codigo"
            Else
                RepositorySearchLook(
                    cbProducto,
                    ObtieneDatos("_ArticulosGetList_OC", p, EmpresaActual),
                    "Codigo",
                    "Codigo", 3, 4, 5, 6, 7, 8)

                'Me.cbCodigo.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
                'Me.cbCodigo.DisplayMember = "Codigo"
                'Me.cbCodigo.ValueMember = "Codigo"

                'Me.cbDescrip.DataSource = Articulos.ProductosGetLista(p).Tables("Articulos").DefaultView
                'Me.cbDescrip.DisplayMember = "Nombre"
                'Me.cbDescrip.ValueMember = "Codigo"
            End If

            If Not CargarPedido And Not Modifica Then    'Si es Nuevo
                ds = OrdenesCompra.OrdenComprasDetalle(0, 0)

                'iGrid.DataSource = ObtieneDatos("SELECT '' Codigo, '' Descripcion, '' Unidad, 1.00 Cantidad, 0.00 Precio, 0.00 PrecioU, 0.00 Descuento, 0.00 SubTotal,'' Temp,'' Tipo, convert(bit,0) Exento FROM Usuarios WHERE 0=1")
                iGrid.DataSource = ds.Tables("Ordenes_Compras").DefaultView
                FormatoPrecioGrid()
                Exit Sub
            End If

            'Proviene de Un Pedido
            If CargarPedido Then
                Me.iGrid.DataSource = ds.Tables("Pedidos").DefaultView
                FormatoPrecioGrid()
                Exit Sub
            End If

            'Se va ha modificar la Orden de Compra
            If Modifica Then
                Me.iGrid.DataSource = ds.Tables("Ordenes_Compras").DefaultView
                FormatoPrecioGrid()
            End If
        End Sub

        Sub FormatoPrecioGrid()
            txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

            txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

            Dim TC As DataTable = ObtieneDatos("_GetListTasaCambioDisponibles", EmpresaActual)

            If TC.Rows.Count > 0 Then
                Dim dr() As DataRow = TC.Select("MonedaCambio = '" & MonedaBase & "'")
                If dr.Length > 0 Then
                    iVista.Columns("Precio").Caption = "Precio " & dr(0).Item("Simbolo").ToString
                    lyTotal.Text = "Total " & dr(0).Item("Simbolo").ToString & ":"
                End If
            End If

        End Sub

        'Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If Not IsNumeric(Me.cbProveedor.EditValue) Then
        '        Exit Sub
        '    End If

        '    If Me.cbProveedor.EditValue = 0 Or Trim(Me.cbProveedor.Text) = "" Then
        '        txtRuc.Text = ""
        '        txtDireccion.Text = ""
        '        txtTelefono.Text = ""
        '        txtDepartamento.Text = ""
        '        txtMunicipio.Text = ""
        '        Exit Sub
        '    End If

        '    DetallesProveedor = ProveedoresDB.GetDetails(Me.cbProveedor.EditValue)

        '    txtRuc.Text = DetallesProveedor.Ruc
        '    txtDireccion.Text = DetallesProveedor.Direccion
        '    txtTelefono.Text = DetallesProveedor.Telefono
        '    Try
        '        Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
        '        Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
        '    Catch ex As Exception
        '    End Try
        'End Sub


        Dim Servicio As Boolean


        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

            'Guardar los datos de la Factura
            If Not Guardar() Then
                Exit Sub
            End If
            '
            If Modifica Or CargarPedido Then
                XtraMsg($"La O/C No. {txtNoOrden.Text} se ha actualizado con éxito!")
                Close()

                Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()
                If f.Created Then f.Cargar()
                Exit Sub
            End If
            '
            If Not Modifica Then
                If XtraMsg2($"La O/C No. {txtNoOrden.Text} se ha registrado con éxito,{vbCrLf} Desea Registrar una Nueva ?") Then
                    CargarPedido = False
                    LimpiarControles()
                    'Rutinas.okTransaccion()
                    txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                    cbProveedor.EditValue = Nothing
                    cbProveedor.Focus()
                Else
                    Close()

                    Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()
                    If f.Created Then f.Cargar()
                End If
            End If

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        'Funcion para guardar los datos de la factura
        Private Function Guardar() As Boolean

            If cbProveedor.EditValue Is Nothing Then
                XtraMsg("Seleccione el Proveedor")
                cbProveedor.Focus()
                Return False
            End If

            'If Me.cbProveedor.EditValue = 0 Then
            '    MsgBox("Seleccione el Proveedor", MsgBoxStyle.Critical)
            '    cbProveedor.Focus()
            '    Return False
            'End If

            If Trim(cbProveedor.Text) = "" Then
                XtraMsg("Seleccione el Proveedor")
                cbProveedor.Focus()
                Return False
            End If

            'If Trim(txtFactura.Text) = "" Then
            '    MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
            '    txtFactura.Focus()
            '    Return False
            'End If

            If cbTipoFactura.ItemIndex = 0 Then
                XtraMsg("Seleccione el Tipo de Pago")
                cbTipoFactura.Focus()
                Return False
            End If

            If Me.iVista.DataRowCount = 0 Then
                XtraMsg("Seleccione al menos un Producto...")
                Return False
            End If

            'If Me.txtNoOrden.Text.Trim.Length = 0 Then
            '    XtraMsg("Introduzca el No. de la Orden", MessageBoxIcon.Error)
            '    txtNoOrden.Focus()
            '    Return False
            'End If

            If mComentarios.Text.Trim.Length = 0 Then
                XtraMsg("Introduzca un comentario para esta O/C", MessageBoxIcon.Error)
                mComentarios.Focus()
                Return False
            End If

            If cbEstados.EditValue Is Nothing Then
                XtraMsg("Seleccione el Status de la Orden de Compra!")
                cbEstados.Focus()
                Return False
            End If
            '
            'Validar que vayan los proyectos si hay cuenta de proyecto.
            Dim DT_CTAPROY As DataTable = ObtieneDatos("sp_sel_GetCuentaProyecto",
                                                       EmpresaActual)

            If DT_CTAPROY.Rows.Count > 0 Then
                If ds.Tables(0) _
                    .Select(
                    "Cuenta = '" & DT_CTAPROY.Rows.Item(0)("CUENTA") & "'" &
                    " AND IdProyecto = 0").Length > 0 Then

                    XtraMsg("Existen registros con la cuenta " & DT_CTAPROY.Rows.Item(0)("CUENTA") & " que no tienen asignado el Proyecto" & vbCrLf &
                            "Favor asignarlos para continuar.", MessageBoxIcon.Error)
                    Return False
                End If
            End If
            '
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            If TipoServicio.EditValue = "P" Then Tipo = 0
            If TipoServicio.EditValue = "S" Then Tipo = 1
            If TipoServicio.EditValue = "I" Then Tipo = 4
            If TipoServicio.EditValue = "A" Then Tipo = 3

            Dim Descuento As Double = 0.0
            Dim IVA As Double = 0.0

            Try
                Dim Flete As Double = 0,
                        Seguro As Double = 0,
                        Otros As Double = 0

                Flete = IsNull(ds.Tables(0).Compute("SUM(SubTotal)", "Flete  = 1"), 0.00)
                Seguro = IsNull(ds.Tables(0).Compute("SUM(SubTotal)", "Seguro  = 1"), 0.00)

                If Modifica Then    'Actualizar Encabezado de la Orden

                    OrdenesCompra.OrdenCompraUpdate(
                        txtFactura.Text,
                        dtpFecha.DateTime.Date,
                        dtpFechaPago.DateTime.Date,
                        cbProveedor.EditValue,
                        tSubTotal.EditValue,
                        tIva.EditValue,
                        tTotal.EditValue,
                        cbTipoFactura.EditValue,
                        txtNoOrden.Text,
                        etTasa.EditValue,
                        txtPedido.Text,
                        Flete,
                        Seguro,
                        Otros,
                        mComentarios.Text,
                        FechaEntrega.EditValue,
                        cbMoneda.EditValue,
                        txtEmbarque.Text,
                        IIf(cbCondiciones.EditValue Is Nothing, "", cbCondiciones.EditValue),
                        txtAtencion.Text,
                        cbEstados.EditValue,
                        IIf(cbConsignatarios.EditValue Is Nothing, 0, cbConsignatarios.EditValue),
                        IIf(cbAgencias.EditValue Is Nothing, 0, cbAgencias.EditValue),
                        IIf(cbMetodosEnvios.EditValue Is Nothing, 0, cbMetodosEnvios.EditValue),
                        mComentarioG.Text, ckLiquidar.Checked,
                        IIf(chkIR.Checked, 1, 0),
                        IIf(chkAlma.Checked, 1, 0),
                        txtSubTotalIR.EditValue,
                        sIrP.EditValue)

                    ''If TipoServicio.EditValue = "I" Then
                    ''    'txtFactura.Text = OrdenesCompra.OrdenCompraCCNumero
                    ''    OrdenesCompra.OrdenCompraCCUpdate(txtFactura.Text, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue, tSubTotal.EditValue, tIva.EditValue, _
                    ''    tTotal.EditValue, cbTipoFactura.EditValue, Tipo, 1, txtFactura.Text, 0)
                    ''ElseIf TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then
                    ''    Dim OrigenF As String = String.Empty

                    ''    If TipoServicio.EditValue = "A" Then OrigenF = "3"
                    ''    If TipoServicio.EditValue = "P" Then OrigenF = "1"

                    ''    'txtFactura.Text = OrdenesCompra.Numero
                    ''    OrdenesCompra.OrdenCompraUpdate(txtFactura.Text, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue, tSubTotal.EditValue, tIva.EditValue, _
                    ''    tTotal.EditValue, cbTipoFactura.EditValue, Me.txtNoOrden.Text, Me.etTasa.EditValue)
                    ''End If

                    '************** ESTA LINEA YA NO SERA NECEARIO
                    '//OrdenesCompra.OrdenComprasDetalleDelete(Me.txtFactura.Text, IIf(Me.etDestino.Text = "3", 1, Me.etDestino.Text))


                    Dim _DT_UPD As DataTable =
                        ds.Tables(0).GetChanges(DataRowState.Modified)

                    'Actualizar registros que cambiaron
                    If Not _DT_UPD Is Nothing Then
                        With _DT_UPD
                            Descuento = .Rows.Item(i)("Descuento")

                            If .Rows.Item(i)("Exento") Then
                                IVA = 0
                            Else
                                IVA = .Rows.Item(i)("SubTotal") * (ConfigDetalles.IVA / 100.0)
                            End If

                            OrdenesCompra.UpdateFacturaLineas(.Rows.Item(i)("IdDetalle"),
                                                              txtFactura.Text,
                                                              .Rows.Item(i)("Codigo"),
                                                              .Rows.Item(i)("Cantidad"),
                                                              .Rows.Item(i)("Precio"),
                                                               Descuento,
                                                               IVA,
                                                              .Rows.Item(i)("Tipo"),
                                                               IsNull(.Rows.Item(i)("Descripcion"), ""),
                                                               IsNull(.Rows.Item(i)("IdProyecto"), 0),
                                                               IsNull(.Rows.Item(i)("IdOrdenCompra"), 0),
                                                               IsNull(.Rows.Item(i)("IsFlete"), 0),
                                                               IsNull(.Rows.Item(i)("IsSeguro"), 0),
                                                               IsNull(.Rows.Item(i)("ir"), 0.00))
                        End With
                    End If
                    '
                    'Agregar Nuevos registros
                    Dim _DT_NEW As DataTable =
                        ds.Tables(0).GetChanges(DataRowState.Added)

                    If Not _DT_NEW Is Nothing Then
                        With _DT_NEW
                            For i As Integer = 0 To .Rows.Count - 1

                                Descuento = .Rows.Item(i)("Descuento")

                                If .Rows.Item(i)("Exento") Then
                                    IVA = 0
                                Else
                                    IVA = .Rows.Item(i)("SubTotal") * (ConfigDetalles.IVA / 100.0)
                                End If

                                OrdenesCompra.AddFacturaLineas(txtFactura.Text,
                                                               .Rows.Item(i)("Codigo"),
                                                               .Rows.Item(i)("Cantidad"),
                                                               .Rows.Item(i)("Precio"),
                                                                Descuento,
                                                                IVA,
                                                               .Rows.Item(i)("Tipo"),
                                                                IsNull(.Rows.Item(i)("Descripcion"), ""),
                                                                IsNull(.Rows.Item(i)("IdProyecto"), 0),
                                                                IsNull(.Rows.Item(i)("IdOrdenCompra"), 0),
                                                                IsNull(.Rows.Item(i)("IsFlete"), 0),
                                                                IsNull(.Rows.Item(i)("IsSeguro"), 0),
                                                                IsNull(.Rows.Item(i)("ir"), 0.00))

                            Next
                        End With
                    End If
                    '
                    'Borrar Linea
                    Dim _DT_DEL As DataTable =
                        ds.Tables(0).GetChanges(DataRowState.Deleted)
                    If Not _DT_DEL Is Nothing Then
                        With _DT_DEL
                            OrdenesCompra.OrdenComprasDetalleDelete(
                                .Rows.Item(i)("IdDetalle", DataRowVersion.Original))
                        End With
                    End If
                End If

                If Not Modifica Then    'Si es una Orden Nueva

                    txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)

                    OrdenesCompra.AddItem(txtFactura.Text, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue, tSubTotal.EditValue, tIva.EditValue,
                    tTotal.EditValue, cbTipoFactura.EditValue, Tipo, IIf(TipoServicio.EditValue = "P", 1, 3), txtFactura.Text, 0, Me.txtNoOrden.Text, Me.etTasa.EditValue,
                    txtPedido.Text, Flete, Seguro, Otros, mComentarios.Text, FechaEntrega.EditValue, cbMoneda.EditValue,
                    txtEmbarque.Text, IIf(cbCondiciones.EditValue Is Nothing, "", cbCondiciones.EditValue), txtAtencion.Text, cbEstados.EditValue,
                                          IIf(cbConsignatarios.EditValue Is Nothing, 0, cbConsignatarios.EditValue),
                    IIf(cbAgencias.EditValue Is Nothing, 0, cbAgencias.EditValue), IIf(cbMetodosEnvios.EditValue Is Nothing, 0, cbMetodosEnvios.EditValue),
                                          mComentarioG.Text, ckLiquidar.Checked,
                    IIf(chkIR.Checked, 1, 0), IIf(chkAlma.Checked, 1, 0), txtSubTotalIR.EditValue, sIrP.EditValue)

                    'If TipoServicio.EditValue = "I" Then
                    '    'txtFactura.Text = OrdenesCompra.OrdenCompraNumero(2)
                    '    txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                    '    OrdenesCompra.OrdenCompraCCAdd(txtFactura.Text, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue, tSubTotal.EditValue, tIva.EditValue, _
                    '    tTotal.EditValue, cbTipoFactura.EditValue, Tipo, 1, txtFactura.Text, 0, Me.txtNoOrden.Text)
                    'ElseIf TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then
                    '    txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
                    '    OrdenesCompra.AddItem(txtFactura.Text, dtpFecha.DateTime.Date, dtpFechaPago.DateTime.Date, cbProveedor.EditValue, tSubTotal.EditValue, tIva.EditValue, _
                    '    tTotal.EditValue, cbTipoFactura.EditValue, Tipo, IIf(TipoServicio.EditValue = "P", 1, 3), txtFactura.Text, 0, Me.txtNoOrden.Text, Me.etTasa.EditValue)
                    'End If
                    '
                    '************** GUARDAR DETALLE
                    Dim _DT_NEW As DataTable =
                        ds.Tables(0).GetChanges(DataRowState.Added Or DataRowState.Modified)

                    If Not _DT_NEW Is Nothing Then
                        With _DT_NEW
                            For i As Integer = 0 To .Rows.Count - 1

                                Descuento = .Rows.Item(i)("Descuento")

                                If .Rows.Item(i)("Exento") Then
                                    IVA = 0
                                Else
                                    IVA = .Rows.Item(i)("SubTotal") * (ConfigDetalles.IVA / 100.0)
                                End If

                                OrdenesCompra.AddFacturaLineas(txtFactura.Text,
                                                               .Rows.Item(i)("Codigo"),
                                                               .Rows.Item(i)("Cantidad"),
                                                               .Rows.Item(i)("Precio"),
                                                                Descuento,
                                                                IVA,
                                                               .Rows.Item(i)("Tipo"),
                                                                IsNull(.Rows.Item(i)("Descripcion"), ""),
                                                                IsNull(.Rows.Item(i)("IdProyecto"), 0),
                                                                IsNull(.Rows.Item(i)("IdOrdenCompra"), 0),
                                                                IsNull(.Rows.Item(i)("IsFlete"), 0),
                                                                IsNull(.Rows.Item(i)("IsSeguro"), 0),
                                                                IsNull(.Rows.Item(i)("ir"), 0.00))

                            Next
                        End With
                    End If
                End If



                'For i As Integer = 0 To Me.iVista.DataRowCount - 1
                '    'If TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then

                '    Descuento = Me.iVista.GetRowCellValue(i, "Descuento")

                '    If iVista.GetRowCellValue(i, "Exento") Then
                '        IVA = 0
                '    Else
                '        IVA = iVista.GetRowCellValue(i, "SubTotal") * (ConfigDetalles.IVA / 100)
                '    End If

                '    OrdenesCompra.AddFacturaLineas(txtFactura.Text, Me.iVista.GetRowCellValue(i, "Codigo"),
                '                                   iVista.GetRowCellValue(i, "Cantidad"),
                '                                   iVista.GetRowCellValue(i, "Precio"),
                '                                   Descuento, IVA, iVista.GetRowCellValue(i, "Tipo"),
                '                                   IsNull(iVista.GetRowCellValue(i, "Descripcion"), ""),
                '                                   IsNull(iVista.GetRowCellValue(i, "IdProyecto"), 0),
                '                                   IsNull(iVista.GetRowCellValue(i, "IdOrdenCompra"), 0),
                '                                   IsNull(iVista.GetRowCellValue(i, "IsFlete"), 0),
                '                                   IsNull(iVista.GetRowCellValue(i, "IsSeguro"), 0),
                '                                   IsNull(iVista.GetRowCellValue(i, "ir"), 0.00))

                '    'ElseIf TipoServicio.EditValue = "I" Then
                '    '    Descuento = Me.iVista.GetRowCellValue(i, "descuento")
                '    '    If Me.iVista.GetRowCellValue(i, "Exento") Then
                '    '        IVA = 0
                '    '    Else
                '    '        IVA = Me.iVista.GetRowCellValue(i, "SubTotal") * ConfigDetalles.IVA / 100
                '    '    End If

                '    '    OrdenesCompra.OrdenesComprasCCLineasAdd(txtFactura.Text, Me.iVista.GetRowCellValue(i, "Codigo"), _
                '    '                                            Me.iVista.GetRowCellValue(i, "Cantidad"), CDbl(Me.iVista.GetRowCellValue(i, "Precio")).ToString(RoundP), _
                '    '                                            ConfigDetalles.IVA, IVA.ToString(Round))
                '    'End If
                'Next

                If CargarPedido = True Then
                    OrdenesCompra.PedidosUpdateEstado(
                        Pedido,
                        "F",
                        txtFactura.Text,
                        TipoPedido)
                End If

                Rutinas.okTransaccion()
                '
                Return True
            Catch ex As Exception
                Rutinas.okTransaccion()
                XtraMsg(ex.Message & "_Error al Guardar O/C",
                        MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Private Sub LimpiarControles()
            Me.cbProveedor.EditValue = -1
            Me.txtFactura.Text = ""
            Me.dtpFecha.DateTime = Now.Date
            Me.dtpFechaPago.DateTime = Now.Date
            '
            'Me.txtRuc.Text = ""
            'Me.txtTelefono.Text = ""
            'Me.txtDireccion.Text = ""
            'Me.txtDepartamento.Text = ""
            'Me.txtMunicipio.Text = ""
            Me.txtPedido.Text = ""
            Me.txtNoOrden.Text = ""
            txtEmbarque.Text = ""
            cbCondiciones.EditValue = Nothing
            '
            TipoServicio.EditValue = "P"
            'Me.rbProductos.Checked = True
            Me.ckLiquidar.Checked = False
            '
            'Me.cbTipoFactura.ItemIndex = 0
            '
            tSubTotal.EditValue = 0.0
            tIva.EditValue = 0.0
            tTotal.EditValue = 0.0
            tTotalU.EditValue = 0.0
            'tFlete.EditValue = 0.0
            'tSeguro.EditValue = 0.0
            'tOtros.EditValue = 0.0
            '
            mComentarios.Text = ""

            txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
            txtLogin.Text = Login
            txtNoOrden.Text = Ordenes_ComprasDB.CodigoPersonalizadoOC()
            '
            CargarCombos("P")
        End Sub

        'Private Sub cmdPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPedidos.Click
        '    Dim f As New frmPedidosList
        '    Dim TipoPedido As Integer

        '    f.Proveedor = cbProveedor.EditValue
        '    f.WindowState = FormWindowState.Normal
        '    f.StartPosition = FormStartPosition.CenterScreen
        '    f.ShowDialog()

        '    If f.Salir = True Then
        '        Exit Sub
        '    Else
        '        CargarPedido = True
        '        Pedido = f.dgPedidos.Item(f.dgPedidos.CurrentRowIndex, 0)
        '        TipoPedido = f.dgPedidos.Item(f.dgPedidos.CurrentRowIndex, 8)
        '        ds = Pedidos.PedidoDetalle(Pedido, TipoPedido)

        '        Me.txtPedido.Text = Pedido
        '        If ds.Tables("Pedidos").Rows.Count = 0 Then
        '            Exit Sub
        '        End If
        '        Me.cbProveedor.EditValue = ds.Tables("Pedidos").Rows(0).Item("Proveedor_ID")
        '        If ds.Tables("Pedidos").Rows(0).Item("Tipo") = "P" Then
        '            CargarCombos("P")
        '        ElseIf ds.Tables("Pedidos").Rows(0).Item("Tipo") = "I" Then
        '            CargarCombos("I")
        '        End If
        '        RealizarCalculos(0)
        '    End If
        'End Sub

        'Private Sub rbProductos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Try
        '        If Me.rbProductos.Checked Then
        '            CargarCombos("P")
        '            RealizarCalculos(1)
        '            If Not Modifica Then txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
        '        End If
        '    Catch ex As Exception
        '    End Try

        'End Sub

        'Private Sub rbInventario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Try
        '        If Me.rbInventario.Checked Then
        '            CargarCombos("I")
        '            RealizarCalculos(1)
        '            If Not Modifica Then txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
        '        End If
        '    Catch ex As Exception
        '    End Try
        'End Sub

        'Private Sub rbProdInvet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Try
        '        If Me.rbProdInvet.Checked Then
        '            CargarCombos("A")
        '            RealizarCalculos(1)
        '            If Not Modifica Then txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)
        '        End If
        '    Catch ex As Exception
        '    End Try

        'End Sub

        'Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click

        '    'If tCust.Rows.Count > 0 Then
        '    '    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
        '    '        tCust.Rows(tCust.Rows.Count - 1).Delete()
        '    '    End If
        '    'End If
        '    If Me.rbProductos.Checked = True Then
        '        Dim f As frmBuscarItem = f.Instance()
        '        f.MdiParent = Me.MdiParent
        '        f.Show()
        '    Else
        '        Dim f As frmBuscarItemCC = f.Instance()
        '        f.etInicio.Text = "1"
        '        f.MdiParent = Me.MdiParent
        '        f.Show()
        '        f.etInicio.Text = "0"
        '    End If

        'End Sub

        Private Sub AgregarItem()
            'Dim k As Integer
            'Dim t As Integer

            'If tItem.Rows.Count <> 0 Then
            '    For k = 0 To tItem.Rows.Count - 1

            '        For t = 0 To tCust.Rows.Count - 1

            '            If tCust.Rows(t)("ArticuloCodigo") = tItem.Rows(k)("Codigo") And tCust.Rows(t)("Tipo") = tItem.Rows(k)("Tipo") Then
            '                tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + CDbl(tItem.Rows(k)("Cantidad"))
            '                Exit For

            '            End If

            '        Next

            '        If t = tCust.Rows.Count Then
            '            Dim newRow1 As DataRow
            '            newRow1 = tCust.NewRow
            '            'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
            '            newRow1("ArticuloCodigo") = tItem.Rows(k)("Codigo")
            '            ' Add the row to the Customers table.
            '            tCust.Rows.Add(newRow1)

            '            'Articulo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
            '            'ArticuloCodigo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
            '            'ItemTipo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Tipo")

            '            'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tItem.Rows(k)("Codigo").ToString, tItem.Rows(k)("Tipo").ToString, EmpresaActual)

            '            'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
            '            'tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") = tItem.Rows(k)("Codigo")
            '            tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
            '            tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
            '            tCust.Rows(tCust.Rows.Count - 1)("Precio") = CDbl(tItem.Rows(k)("Costo")).ToString(RoundP)

            '            'If TipoDescuento = "A" Then
            '            '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
            '            'ElseIf TipoDescuento = "B" Then
            '            '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
            '            'ElseIf TipoDescuento = "C" Then
            '            '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
            '            'Else
            '            '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = "0.00"

            '            'End If

            '            tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")

            '        End If
            '    Next
            '    tItem.Clear()
            '    ArticuloCodigo.ColumnComboBox.Focus()

            'End If

        End Sub

        'Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub frmOrdenesCompraCompra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub dgOrdenesCompra_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub txtDireccion_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub cmdAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.MouseEnter
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub cbProveedor_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub gbBotones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbBotones.MouseEnter
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub gbTipo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    
        '    AgregarItem()
        'End Sub

        'Private Sub GroupBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.MouseEnter
        '    
        '    AgregarItem()
        'End Sub

        Private Sub cmdConsultaProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedores.Click
            If Me.cbProveedor.Text = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            If Me.cbProveedor.EditValue = Nothing Then
                MsgBox("El Proveedor no está registrado", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            Dim f As frmAcumuladosProveedor = frmAcumuladosProveedor.Instance()

            f.Proveedor = Me.cbProveedor.EditValue

            f.MdiParent = Me.MdiParent
            f.Show()

        End Sub


        Private Sub frmOrdenesCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            'Dim f As frmOrdenesCompraLista = f.Instance()
            'f.Cargar()

            'If f.cBoxFecha.Checked = True Then
            '    f.Fecha = dtpFecha.DateTime.Date
            'Else
            '    f.Fecha = ""
            'End If
            'f.Cargar()


            'If Me.lbOrigen.Text = "Pedidos" Then
            '    Dim f As frmListaPedidos = f.Instance()
            '    Dim ds As DataSet
            '    If f.checkBoxFecha.Checked = True Then
            '        ds = Pedidos.PedidosListXFecha(f.cbProveedores.SelectedValue, f.cbEstado.SelectedIndex, f.dtpFecha1.Value.Date, f.dtpFecha2.Value.Date)
            '        'f.dgPedidos.DataSource = ds.Tables("Pedidos").DefaultView
            '        f.gridPedidos.DataSource = ds.Tables("Pedidos").DefaultView
            '    Else
            '        ds = Pedidos.PedidosList(f.cbProveedores.SelectedValue, f.cbEstado.SelectedIndex)
            '        'f.dgPedidos.DataSource = ds.Tables("Pedidos").DefaultView
            '        f.gridPedidos.DataSource = ds.Tables("Pedidos").DefaultView
            '    End If
            '    f.CargarRegistro()
            'Else
            '    Dim f As frmOrdenesCompraLista = f.Instance()
            '    Dim ds As DataSet
            '    If f.cBoxFecha.Checked = True Then
            '        f.Fecha = dtpFecha.DateTime.Date
            '    Else
            '        f.Fecha = ""
            '    End If
            '    ds = f.Ordenes.OrdenesCompraXProveedor(f.cbProveedor.SelectedValue, f.Fecha, f.cbEstado.SelectedIndex, f.cbTipo.SelectedValue, f.cbOrigen.SelectedIndex, f.cbDestino.SelectedIndex)
            '    'f.dgOrdenes.DataSource = ds.Tables("Ordenes_Compra").DefaultView
            '    f.gridOrdenes.DataSource = ds.Tables("Ordenes_Compra").DefaultView
            'End If
        End Sub

        Private Sub iVista_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged

            If e.Column.FieldName = "Codigo" Then   'Productos ó Inventario
                Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(e.Value)    'GetDataSourceRowByKeyValue(e.Value)

                If Not DR Is Nothing Then
                    'Validar que no se repitan los productos, para evitar problemas de Primary Key en la Tabla
                    If DR("Tipo") = "P" Or DR("Tipo") = "I" Then
                        If ds.Tables(0).Compute("Count(Codigo)", "Codigo = '" & e.Value & "' AND Tipo = '" + DR("Tipo") + "'") >= 1 Then 'And cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then
                            XtraMsg("Ya existe este producto en la lista", MessageBoxIcon.Warning)
                            iVista.DeleteRow(iVista.FocusedRowHandle)
                            Exit Sub
                        End If
                    End If

                    Temp = True

                    iVista.SetRowCellValue(e.RowHandle, "Precio", DR("Precio"))
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(DR("Precio") / TCambio))
                    iVista.SetRowCellValue(e.RowHandle, "Descripcion", DR("Nombre"))
                    iVista.SetRowCellValue(e.RowHandle, "Unidad", DR("Unidad"))
                    iVista.SetRowCellValue(e.RowHandle, "Tipo", DR("Tipo"))
                    iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                    iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                    iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR("Precio"))
                    iVista.SetRowCellValue(e.RowHandle, "Cuenta", DR("Cuenta"))
                    iVista.SetRowCellValue(e.RowHandle, "Exento", IIf(ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Retenedor = False, True, DR("Exento")))
                    iVista.SetRowCellValue(e.RowHandle, "IdProyecto", DR("IdProyecto"))
                    iVista.SetRowCellValue(e.RowHandle, "IdOrdenCompra", 0)
                    iVista.SetRowCellValue(e.RowHandle, "IsFlete", False)
                    iVista.SetRowCellValue(e.RowHandle, "IsSeguro", False)
                    iVista.SetRowCellValue(e.RowHandle, "ir", DR("ir"))

                    ' iVista.SetRowCellValue(e.RowHandle, "Temp", e.RowHandle + 1)
                    'If Me.rbProdInvet.Checked Then  'Prodcutos e Inventario
                    '    GridView1.SetRowCellValue(e.RowHandle, "Tipo", "A")
                    'Else
                    '    GridView1.SetRowCellValue(e.RowHandle, "Tipo", DR("Tipo"))
                    'End If
                    ' If Me.vOrdenesCompraC.DataRowCount > 0 Then RealizarCalculos()

                    Temp = False
                End If
            End If
            '
            'If e.Column.FieldName = "Cuenta" Then   'Productos ó Inventario
            '    If Not e.Value Is Nothing Then
            '        'If IsNull(iVista.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) = 0 Then
            '        '    If ObtieneDatos("sp_sel_ValidarCuentaProyecto",
            '        '                    e.Value,
            '        '                    EmpresaActual).Rows.Count > 0 Then
            '        '        XtraMsg("Esta usando una cuenta de Proyectos, debe asociar el registro a un proyecto para continuar...",
            '        '                MessageBoxIcon.Error)
            '        '        iVista.DeleteRow(e.RowHandle)
            '        '    End If
            '        'End If
            '    End If
            'End If

            If e.Column.FieldName = "Cantidad" Then
                If e.Value <= 0 Then
                    XtraMsg("Introduzca una Cantidad Mayor que Cero (0)", MessageBoxIcon.Error)
                    iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1)
                Else
                    iVista.SetRowCellValue(e.RowHandle, "SubTotal", (Me.iVista.GetFocusedRowCellValue("Precio") * e.Value))
                End If
                If Me.iVista.DataRowCount > 0 Then RealizarCalculos(0)
            End If

            If e.Column.FieldName = "Descuento" And Not Temp Then
                If e.Value <> 0 Then
                    Temp = True
                    iVista.SetRowCellValue(e.RowHandle, "Descuento", e.Value)
                    Temp = False
                End If
            End If

            If e.Column.FieldName = "Precio" And Not Temp Then
                If e.Value <> 0 Then
                    Temp = True
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio).ToString(RoundP))
                    Temp = False
                End If
            End If

            If e.Column.FieldName = "PrecioU" And Not Temp Then
                If e.Value <> 0 Then
                    Temp = True
                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio).ToString(RoundP))
                    Temp = False
                End If
            End If

            If e.Column.FieldName = "Descuento" Or
                e.Column.FieldName = "Cantidad" Or
                e.Column.FieldName = "Precio" Or
                e.Column.FieldName = "PrecioU" Then

                iVista.SetRowCellValue(e.RowHandle,
                                       "SubTotal",
                                       (IsNull(Me.iVista.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.iVista.GetFocusedRowCellValue("Cantidad"), 0)) - ((IsNull(Me.iVista.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.iVista.GetFocusedRowCellValue("Cantidad"), 0)) * (IsNull(Me.iVista.GetFocusedRowCellValue("Descuento"), 0.0) / 100)))

                'If e.Value < 0 Then
                '    XtraMsg("El valor debe ser igual ó Mayor que Cero (0)", MessageBoxIcon.Error)
                '    iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                'Else
                '    iVista.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(Me.iVista.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.iVista.GetFocusedRowCellValue("Cantidad"), 0)) - ((IsNull(Me.iVista.GetFocusedRowCellValue("Precio"), 0) * IsNull(Me.iVista.GetFocusedRowCellValue("Cantidad"), 0)) * (IsNull(Me.iVista.GetFocusedRowCellValue("Descuento"), 0.0) / 100)))
                'End If
                'If Me.iVista.DataRowCount > 0 Then RealizarCalculos(0)
            End If

            iVista.UpdateTotalSummary()
        End Sub

        Sub RealizarCalculos(ByVal op As Integer)   '

            Dim SubTotal As Double = 0,
                SubTotalIR As Double = 0,
                IVA As Double = 0,
                Total As Double = 0

            If Me.iVista.RowCount = 1 And (op = 1 Or op = 2) Then   'Si el grid no tiene datos
                tSubTotal.EditValue = 0.0
                txtSubTotalIR.EditValue = 0.00
                tIva.EditValue = 0.0
                tTotal.EditValue = 0.0
                tTotalU.EditValue = 0.0
            Else
                'Realizar Calculos Sobre Monto en Factura segun Parametros seleccionados
                Try
                    For i As Integer = 0 To Me.iVista.RowCount - 2
                        Dim DR As DataRow = Me.iVista.GetDataRow(i)

                        If DR("Exento") = False Then    'No es Exento de IVA
                            SubTotal += ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100)))
                            IVA += (((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100))) * (ConfigDetalles.IVA / 100))
                        Else
                            SubTotal += ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100)))
                        End If
                        ''
                        'If DR("Tipo") = "S" Then
                        '    If DR("ir") > 0.00 Then
                        '        SubTotalIR += ((DR("Cantidad") * DR("Precio")) - (DR("Cantidad") * DR("Precio") * (DR("descuento") / 100)))
                        '    End If
                        'End If
                    Next

                    Total = SubTotal + IVA '+ tFlete.EditValue + tSeguro.EditValue + tOtros.EditValue

                    tSubTotal.EditValue = SubTotal
                    txtSubTotalIR.EditValue = SubTotal
                    'txtSubTotalIR.EditValue = SubTotalIR
                    tIva.EditValue = IVA
                    tTotal.EditValue = Total

                    tTotalU.EditValue = Math.Round(Total / TCambio, 2)
                Catch ex As Exception
                End Try
            End If

        End Sub

        Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iVista.KeyDown
            If Me.iVista.FocusedRowHandle < 0 Then Exit Sub
            'Borrar Lineas del Grid
            If e.KeyCode = Keys.Delete Then
                iVista.DeleteSelectedRows()
                RealizarCalculos(1)
            End If
        End Sub

        Private Sub GridView1_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVista.RowUpdated
            RealizarCalculos(0)
            CalcularIR()
        End Sub

        Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Try
                ''If IsNumeric(cbTipoFactura.EditValue) Then
                'If Inicio = True Then
                '    Exit Sub
                'End If

                If cbTipoFactura.ItemIndex = 0 Then
                Else
                    TipoFactura = cbTipoFactura.EditValue
                    dtpFechaPago.DateTime = dtpFecha.DateTime.AddDays(FormaPago.FormaPagoDias(cbTipoFactura.EditValue))
                End If
                'End If
            Catch ex As Exception
            End Try
        End Sub

        'Private Sub cbProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbProveedor.ButtonClick
        '    If e.Button.Index = 1 Then  'Si Da Clic en el Boton Agregar

        '        Dim f As New frmAgregarProveedorQuick
        '        f.Nuevo = "SI"
        '        f.StartPosition = FormStartPosition.CenterScreen
        '        f.ShowDialog()

        '        GetCatalogoProveedores(cbProveedor, vProveedores)
        '        '' CargarProveedores()
        '        If Not ChkProveedores Then Me.cbProveedor.EditValue = CInt(f.txtCodigo.Text)
        '        f.Dispose()

        '    ElseIf e.Button.Index = 2 Then
        '        GetCatalogoProveedores(cbProveedor, vProveedores)
        '        '' CargarProveedores()
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
        '                GetCatalogoProveedores(cbProveedor, vProveedores)
        '                '' CargarProveedores()
        '                cbProveedor_EditValueChanged(Nothing, Nothing)
        '                f.Dispose()
        '            End If
        '        Catch ex As Exception
        '        End Try
        '    End If

        'End Sub

        Private Sub cbProveedor_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'If Not IsNumeric(Me.cbProveedor.EditValue) Then
            '    Exit Sub
            'End If
            'If Me.cbProveedor.EditValue Is Nothing Or IsNumeric(Me.cbProveedor.EditValue) = False Then
            '    txtRuc.Text = ""
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            '    Exit Sub
            'End If

            ' DetallesProveedor = ProveedoresDB.GetDetails(Me.cbProveedor.EditValue)

            'Me.txtRuc.Text = DetallesProveedor.Ruc
            'Me.txtDireccion.Text = DetallesProveedor.Direccion
            'Me.txtTelefono.Text = DetallesProveedor.Telefono
            'If IsNumeric(DetallesProveedor.Departamento) = True Then
            '    Try
            '        Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
            '        Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
            '    Catch ex As Exception
            '    End Try
            'End If
        End Sub

        Private Sub ckLiquidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLiquidar.CheckedChanged

            If ckLiquidar.Checked Then
                If cbProveedor.EditValue Is Nothing Then
                    XtraMsg("Seleccione el Proveedor")
                    cbProveedor.Focus()
                    ckLiquidar.Checked = False
                    Exit Sub
                End If
                '
                Dim DetalleProveedor As ProveedoresDetails =
                    ProveedoresDB.GetDetails(cbProveedor.EditValue)

                If DetalleProveedor.CuentaTransito = "" Or DetalleProveedor.CuentaTransito = "0" Then
                    XtraMsg("El proveedor " & cbProveedor.Text & " no tiene cuenta de Transito registrada." & vbCrLf &
                          "Favor asignarle una cuenta en el perfil del proveedor.", MessageBoxIcon.Error)

                    ckLiquidar.Checked = False
                End If
            Else
                ckLiquidar.Checked = False
            End If
            '
            'Dim drLiq As DataRow
            'If ckLiquidar.Checked = True And Not (cbProveedor.EditValue = Nothing Or cbProveedor.Text = "") Then
            '    drLiq = ObtieneDatos("SELECT Origen, CuentaTransito FROM Proveedores WHERE Codigo=  " & cbProveedor.EditValue & " AND Empresa = " & EmpresaActual).Rows(0)
            '    'If drLiq.Item(0) = 0 Then
            '    'MsgBox("Este proveedor ha sido clasificado como uno nacional.", MsgBoxStyle.Information, formtitulo)
            '    'ckLiquidar.Checked = False
            '    If drLiq.Item(1) = "" Then 'ElseIf drLiq.Item(1) = "" Then
            '        XtraMsg("El proveedor no tiene cuenta de Transito registrada." & vbCrLf &
            '               "Favor asignarle una cuenta en el perfil del proveedor.")
            '        ckLiquidar.Checked = False
            '    End If
            'Else
            '    ckLiquidar.Checked = False
            'End If
        End Sub

        Private Sub dtpFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.EditValueChanged
            Try
                TCambio = GetTasaCambioDia(dtpFecha.DateTime.Date)
                etTasa.EditValue = TCambio
                '
                dtpFechaPago.DateTime =
                    dtpFecha.DateTime.AddDays(
                    cbTipoFactura.GetColumnValue("Dias"))
            Catch ex As Exception
                etTasa.EditValue = 1.0
            End Try
        End Sub

        Private Sub etTasa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etTasa.EditValueChanged
            Try
                TCambio = Me.etTasa.EditValue
            Catch ex As Exception
            End Try

        End Sub

        Private Sub TipoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoServicio.SelectedIndexChanged
            CargarCombos(TipoServicio.EditValue)
            RealizarCalculos(1)
            If Not Modifica Then txtFactura.Text = OrdenesCompra.OrdenCompraNumero(1)

            If TipoServicio.EditValue = "P" Then Tipo = 0
            If TipoServicio.EditValue = "S" Then Tipo = 1
            If TipoServicio.EditValue = "I" Then Tipo = 4
            If TipoServicio.EditValue = "A" Then Tipo = 3
        End Sub

        'Private Sub tFlete_EditValueChanged(sender As Object, e As EventArgs) Handles tFlete.EditValueChanged, tSeguro.EditValueChanged, tOtros.EditValueChanged
        '    RealizarCalculos(0)
        'End Sub

        Private Sub cbTipoFactura_EditValueChanged(sender As Object, e As EventArgs) Handles cbTipoFactura.EditValueChanged
            dtpFechaPago.DateTime = dtpFecha.DateTime.AddDays(cbTipoFactura.GetColumnValue("Dias"))
        End Sub

        Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

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

            Rep.DataSource = ObtieneDatos("sp_OrdenCompraImpresa", txtFactura.Text, EmpresaActual)

            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
        End Sub

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            With frmDocumentos
                .Tipo = "ORDENES_COMPRA"
                .Codigo = txtNoOrden.Text
                .NDocumento = txtNoOrden.Text
                .Text = "Soporte Digital Para O/C del Proveedor: " & cbProveedor.Text
                .txtNombre.Text = cbProveedor.Text
                .ShowDialog()
                .Dispose()
            End With
        End Sub

        Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
            frmExportarImprimir.Mostrar(iGrid, "Detalle de Orden de Compra")
        End Sub

        Private Sub chkPrincipal_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrincipal.CheckedChanged
            ckLiquidar.Checked = True
        End Sub

        Private Sub bGuardarHija_Click(sender As Object, e As EventArgs) Handles bGuardarHija.Click

        End Sub

        Private Sub chkIR_CheckedChanged(sender As Object, e As EventArgs) Handles chkIR.CheckedChanged, chkAlma.CheckedChanged
            sIrP.Enabled = chkIR.Checked
            sIR_AlmaP.Enabled = chkAlma.Checked
            '
            If Not chkIR.Checked Then txtRetencion.EditValue = 0.00
            If Not chkAlma.Checked Then txtRetencionAlma.EditValue = 0.00

            CalcularIR()
        End Sub

        Sub CalcularIR()

            If iVista.DataRowCount = 0 Then
                chkIR.Checked = False
                chkAlma.Checked = False
                txtRetencion.EditValue = 0.00
                txtRetencionAlma.EditValue = 0.00
                Exit Sub
            End If
            '
            'If Tipo.Count > 1 Then
            '    XtraMsg("La O/P contiene Productos y Servicios, solo se puede calcular 1 tipo de Retención para una misma O/P.",
            '            MessageBoxIcon.Error)
            '    chkIR.Checked = False
            '    Exit Sub
            'End If
            '
            Dim MontoIR As Double = 0

            If chkIR.Checked Then

                If TipoServicio.EditValue = "P" Or
                        TipoServicio.EditValue = "I" Then

                    sIrP.Value = ConfigDetalles.IRProd
                    MontoIR = ConfigDetalles.MontoIR
                    txtSubTotalIR.EditValue = CDbl(iVista.Columns("SubTotal").SummaryItem.SummaryValue)

                ElseIf TipoServicio.EditValue = "S" Then

                    If IRServicio() Then
                        sIrP.Value = CDbl(ds.Tables(0).Compute("MAX(ir)", "ir > 0"))
                        txtSubTotalIR.EditValue = CDbl(ds.Tables(0).Compute("SUM(SubTotal)", "ir > 0"))
                        MontoIR = 0.00
                    End If

                ElseIf TipoServicio.EditValue = "A" Then
                    'Aplicar LinQ para detectar si hay mas de un Tipo.
                    Dim Tipo As IEnumerable(Of String) =
                        From row In ds.Tables(0).AsEnumerable()
                        Select row.Field(Of String)("Tipo") Distinct

                    Dim IsP As Boolean = False

                    For i As Integer = 0 To Tipo.Count - 1
                        If Tipo.ToList().Item(i).ToString().Equals("P") Or
                        Tipo.ToList().Item(i).ToString().Equals("I") Then
                            IsP = True
                        End If
                    Next
                    '
                    If IsP Then
                        sIrP.Value = ConfigDetalles.IRProd
                        MontoIR = ConfigDetalles.MontoIR
                        txtSubTotalIR.EditValue = CDbl(ds.Tables(0).Compute("SUM(SubTotal)", "Tipo IN ('P', 'I')"))
                    Else
                        If IRServicio() Then
                            sIrP.Value = CDbl(ds.Tables(0).Compute("MAX(ir)", "ir > 0"))
                            txtSubTotalIR.EditValue = CDbl(ds.Tables(0).Compute("SUM(SubTotal)", "ir > 0"))
                            MontoIR = 0.00
                        End If
                    End If
                End If



                'Si hay productos y servicios
                'If Tipo.Count > 1 Then
                '    Dim IsP As Boolean = False

                '    For i As Integer = 0 To Tipo.Count - 1
                '        If Tipo.ToList().Item(i).ToString().Equals("P") Or
                '        Tipo.ToList().Item(i).ToString().Equals("I") Then
                '            IsP = True
                '        End If
                '    Next
                'End If

                ''Si es producto tomar el % de retencion del Grupo de Servicios
                'If Tipo.ToList().Item(0).ToString().Equals("S") Then

                '    If ds.Tables(0).Select("ir > 0").Length = 0 Then
                '        XtraMsg("No se ha encontrado configuración de porcentaje % de retención en ninguna de las lineas",
                '            MessageBoxIcon.Warning)
                '        chkIR.Checked = False
                '        Exit Sub
                '    End If
                '    '
                '    Dim _DT As DataTable =
                '    ds.Tables(0).Select("ir > 0").CopyToDataTable()

                '    Dim ir As IEnumerable(Of Decimal) =
                '    From row In _DT.AsEnumerable()
                '    Select row.Field(Of Decimal)("ir") Distinct

                '    If ir.Count >= 2 Then
                '        XtraMsg("El porcentaje % de retención deber ser igual en todas las lineas",
                '            MessageBoxIcon.Warning)

                '        chkIR.Checked = False
                '        Exit Sub
                '    End If

                '    sIrP.Value = CDbl(ds.Tables(0).Compute("MAX(ir)", "ir > 0"))
                '    txtSubTotalIR.EditValue = CDbl(ds.Tables(0).Compute("SUM(SubTotal)", "ir > 0"))
                '    '
                '    Dim _dtIR As DataTable =
                '            ObtieneDatos("sp_GetPorcentajeRetension",
                '           iVista.GetRowCellValue(0, "Codigo"),
                '           EmpresaActual)
                '    '
                '    If _dtIR.Rows.Count > 0 Then
                '        MontoIR = _dtIR.Rows.Item(0)("MontoRetencion")
                '    Else
                '        MontoIR = ConfigDetalles.MontoIR
                '    End If
                'Else
                '    sIrP.Value = ConfigDetalles.IRProd
                '    MontoIR = ConfigDetalles.MontoIR
                'End If
                '
                If txtSubTotalIR.EditValue > MontoIR Then
                    txtRetencion.EditValue = txtSubTotalIR.EditValue * (sIrP.Value / 100)
                    txtAPagar.EditValue = tTotal.EditValue - txtRetencion.EditValue - txtRetencionAlma.EditValue
                End If
            Else
                txtRetencion.EditValue = 0.00
                sIrP.Value = 0
            End If
            '
            If chkAlma.Checked Then
                Dim MunDet As VB.SysContab.MunicipioDetails =
                    MunicipiosDB.GetDetails(
                    ProveedoresDB.GetDetails(
                    cbProveedor.EditValue).Departamento,
                    ProveedoresDB.GetDetails(
                    cbProveedor.EditValue).Municipio)

                If ProveedoresDB.GetDetails(
                    cbProveedor.EditValue).Departamento = "0" And
                    ProveedoresDB.GetDetails(
                    cbProveedor.EditValue).Municipio = "0" Then
                    XtraMsg("Por favor Ingrese Departamento o Municipio del Proveedor", MessageBoxIcon.Error)
                    txtRetencionAlma.EditValue = 0.00
                    sIR_AlmaP.Value = 0
                Else
                    If txtSubTotalIR.EditValue > MunDet.Impuesto_SVenta_Min Then
                        txtRetencionAlma.EditValue = txtSubTotalIR.EditValue * (MunDet.Impuesto_SVenta / 100)
                        txtAPagar.EditValue = CDbl(tTotal.Text) - txtRetencion.EditValue - txtRetencionAlma.EditValue
                        sIR_AlmaP.Value = MunDet.Impuesto_SVenta
                    End If
                End If
            Else
                txtRetencionAlma.EditValue = 0.00
                sIR_AlmaP.Value = 0
            End If
        End Sub

        Function IRServicio() As Boolean

            If ds.Tables(0).Select("ir > 0").Length = 0 Then
                XtraMsg("No se ha encontrado configuración de porcentaje % de retención en ninguna de las lineas del Servicio.",
                    MessageBoxIcon.Warning)
                chkIR.Checked = False
                Return False
            End If
            '
            Dim _DT As DataTable =
                ds.Tables(0).Select("ir > 0").CopyToDataTable()

            Dim ir As IEnumerable(Of Decimal) =
            From row In _DT.AsEnumerable()
            Select row.Field(Of Decimal)("ir") Distinct

            If ir.Count >= 2 Then
                XtraMsg("El porcentaje % de retención deber ser igual en todas las lineas del Servicio",
                    MessageBoxIcon.Warning)

                chkIR.Checked = False
                Return False
            End If
            '
            Return True
        End Function

        Private Sub tSubTotal_EditValueChanged(sender As Object, e As EventArgs) Handles tSubTotal.EditValueChanged
            txtSubTotalIR.EditValue = tSubTotal.EditValue
        End Sub

        Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
            If Not Modifica Then Exit Sub

            If IsNull(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Entregado"), 0.00) > 0.00 Then
                e.Cancel = True
            End If
        End Sub

        Private Sub cbProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged
            If cbProveedor.EditValue Is Nothing Then Exit Sub
            '
            If Not Modifica Then
                txtAtencion.Text =
                    ProveedoresDB.GetDetails(cbProveedor.EditValue).Nombre
            End If
        End Sub
    End Class
End Namespace