Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class FrmCotizacionNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmCotizacionNew = Nothing

    Public Shared Function Instance() As FrmCotizacionNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmCotizacionNew
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
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtfactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdescuentos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescuentop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbformapago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbliva As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbvendedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtnombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbTEntregas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblTotalU As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents cbClientes As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAdicional As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbEstados As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FechaVigencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbCondiciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bDuplicado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCentros As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbTipoPrecios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbItems As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkExento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtOc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacionNew))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtOc = New DevExpress.XtraEditors.TextEdit()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemision = New DevExpress.XtraEditors.TextEdit()
        Me.chkExento = New DevExpress.XtraEditors.CheckEdit()
        Me.rTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.cbCentros = New DevExpress.XtraEditors.LookUpEdit()
        Me.FechaVigencia = New DevExpress.XtraEditors.DateEdit()
        Me.cbCondiciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbEstados = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAdicional = New DevExpress.XtraEditors.MemoEdit()
        Me.cbClientes = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.lblTotalU = New System.Windows.Forms.Label()
        Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbItems = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbTEntregas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbTipoPrecios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.cmbvendedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.txtnombre = New DevExpress.XtraEditors.TextEdit()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.FechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtdescuentos = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescuentop = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtfactura = New DevExpress.XtraEditors.TextEdit()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbformapago = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bDuplicado = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtOc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaVigencia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaVigencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdicional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbvendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtOc)
        Me.LayoutControl1.Controls.Add(Me.txtOrden)
        Me.LayoutControl1.Controls.Add(Me.txtRemision)
        Me.LayoutControl1.Controls.Add(Me.chkExento)
        Me.LayoutControl1.Controls.Add(Me.rTipo)
        Me.LayoutControl1.Controls.Add(Me.cbCentros)
        Me.LayoutControl1.Controls.Add(Me.FechaVigencia)
        Me.LayoutControl1.Controls.Add(Me.cbCondiciones)
        Me.LayoutControl1.Controls.Add(Me.cbEstados)
        Me.LayoutControl1.Controls.Add(Me.txtAdicional)
        Me.LayoutControl1.Controls.Add(Me.cbClientes)
        Me.LayoutControl1.Controls.Add(Me.etTasa)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.lblTotalU)
        Me.LayoutControl1.Controls.Add(Me.cmdConsultaClientes)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cmdConsulta)
        Me.LayoutControl1.Controls.Add(Me.lbltotal)
        Me.LayoutControl1.Controls.Add(Me.lbliva)
        Me.LayoutControl1.Controls.Add(Me.cmbvendedor)
        Me.LayoutControl1.Controls.Add(Me.lblsubtotal)
        Me.LayoutControl1.Controls.Add(Me.txtnombre)
        Me.LayoutControl1.Controls.Add(Me.fecha)
        Me.LayoutControl1.Controls.Add(Me.FechaPago)
        Me.LayoutControl1.Controls.Add(Me.TipoServicio)
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Controls.Add(Me.txtfactura)
        Me.LayoutControl1.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl1.Controls.Add(Me.cmbformapago)
        Me.LayoutControl1.Controls.Add(Me.txtCaja)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(722, 336, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(954, 499)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtOc
        '
        Me.txtOc.Location = New System.Drawing.Point(733, 137)
        Me.txtOc.Name = "txtOc"
        Me.txtOc.Size = New System.Drawing.Size(63, 20)
        Me.txtOc.StyleController = Me.LayoutControl1
        Me.txtOc.TabIndex = 12
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(381, 137)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(67, 20)
        Me.txtOrden.StyleController = Me.LayoutControl1
        Me.txtOrden.TabIndex = 12
        '
        'txtRemision
        '
        Me.txtRemision.Location = New System.Drawing.Point(559, 137)
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.Size = New System.Drawing.Size(63, 20)
        Me.txtRemision.StyleController = Me.LayoutControl1
        Me.txtRemision.TabIndex = 11
        '
        'chkExento
        '
        Me.chkExento.Location = New System.Drawing.Point(800, 137)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExento.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.chkExento.Properties.Appearance.Options.UseFont = True
        Me.chkExento.Properties.Appearance.Options.UseForeColor = True
        Me.chkExento.Properties.Caption = "Exonerar Impuesto"
        Me.chkExento.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkExento.Size = New System.Drawing.Size(142, 22)
        Me.chkExento.StyleController = Me.LayoutControl1
        Me.chkExento.TabIndex = 186
        '
        'rTipo
        '
        Me.rTipo.EditValue = 0
        Me.rTipo.Location = New System.Drawing.Point(460, 108)
        Me.rTipo.Name = "rTipo"
        Me.rTipo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rTipo.Properties.Appearance.Options.UseFont = True
        Me.rTipo.Properties.Appearance.Options.UseForeColor = True
        Me.rTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "COTIZACIÓN"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "PROFORMA")})
        Me.rTipo.Size = New System.Drawing.Size(254, 25)
        Me.rTipo.StyleController = Me.LayoutControl1
        Me.rTipo.TabIndex = 185
        '
        'cbCentros
        '
        Me.cbCentros.Location = New System.Drawing.Point(460, 84)
        Me.cbCentros.Name = "cbCentros"
        Me.cbCentros.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentros.Properties.NullText = "[Linea]"
        Me.cbCentros.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCentros.Properties.ShowFooter = False
        Me.cbCentros.Properties.ShowHeader = False
        Me.cbCentros.Size = New System.Drawing.Size(254, 20)
        Me.cbCentros.StyleController = Me.LayoutControl1
        Me.cbCentros.TabIndex = 184
        Me.cbCentros.TabStop = False
        Me.cbCentros.Tag = "True"
        '
        'FechaVigencia
        '
        Me.FechaVigencia.EditValue = Nothing
        Me.FechaVigencia.Location = New System.Drawing.Point(825, 84)
        Me.FechaVigencia.Name = "FechaVigencia"
        Me.FechaVigencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaVigencia.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaVigencia.Size = New System.Drawing.Size(117, 20)
        Me.FechaVigencia.StyleController = Me.LayoutControl1
        Me.FechaVigencia.TabIndex = 11
        Me.FechaVigencia.TabStop = False
        '
        'cbCondiciones
        '
        Me.cbCondiciones.Location = New System.Drawing.Point(119, 108)
        Me.cbCondiciones.Name = "cbCondiciones"
        Me.cbCondiciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCondiciones.Properties.NullText = "[Condiciones]"
        Me.cbCondiciones.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCondiciones.Properties.ShowFooter = False
        Me.cbCondiciones.Properties.ShowHeader = False
        Me.cbCondiciones.Size = New System.Drawing.Size(230, 20)
        Me.cbCondiciones.StyleController = Me.LayoutControl1
        Me.cbCondiciones.TabIndex = 183
        Me.cbCondiciones.TabStop = False
        Me.cbCondiciones.Tag = "True"
        '
        'cbEstados
        '
        Me.cbEstados.Location = New System.Drawing.Point(825, 108)
        Me.cbEstados.Name = "cbEstados"
        Me.cbEstados.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.cbEstados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstados.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cbEstados.Properties.Appearance.Options.UseBackColor = True
        Me.cbEstados.Properties.Appearance.Options.UseFont = True
        Me.cbEstados.Properties.Appearance.Options.UseForeColor = True
        Me.cbEstados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEstados.Properties.NullText = "[Estado]"
        Me.cbEstados.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbEstados.Properties.ShowFooter = False
        Me.cbEstados.Properties.ShowHeader = False
        Me.cbEstados.Size = New System.Drawing.Size(117, 20)
        Me.cbEstados.StyleController = Me.LayoutControl1
        Me.cbEstados.TabIndex = 183
        Me.cbEstados.TabStop = False
        Me.cbEstados.Tag = "True"
        '
        'txtAdicional
        '
        Me.txtAdicional.Location = New System.Drawing.Point(119, 443)
        Me.txtAdicional.Name = "txtAdicional"
        Me.txtAdicional.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdicional.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtAdicional.Properties.Appearance.Options.UseFont = True
        Me.txtAdicional.Properties.Appearance.Options.UseForeColor = True
        Me.txtAdicional.Properties.ReadOnly = True
        Me.txtAdicional.Size = New System.Drawing.Size(588, 44)
        Me.txtAdicional.StyleController = Me.LayoutControl1
        Me.txtAdicional.TabIndex = 184
        '
        'cbClientes
        '
        Me.cbClientes.Location = New System.Drawing.Point(119, 12)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Properties.Appearance.Options.UseFont = True
        Me.cbClientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClientes.Properties.NullText = "[Seleccione Cliente]"
        Me.cbClientes.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbClientes.Properties.ShowFooter = False
        Me.cbClientes.Properties.View = Me.vClientes
        Me.cbClientes.Size = New System.Drawing.Size(595, 20)
        Me.cbClientes.StyleController = Me.LayoutControl1
        Me.cbClientes.TabIndex = 27
        Me.cbClientes.Tag = "True"
        '
        'vClientes
        '
        Me.vClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vClientes.Name = "vClientes"
        Me.vClientes.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vClientes.OptionsView.ShowAutoFilterRow = True
        Me.vClientes.OptionsView.ShowFooter = True
        Me.vClientes.OptionsView.ShowGroupPanel = False
        '
        'etTasa
        '
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(825, 36)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.Appearance.Options.UseBackColor = True
        Me.etTasa.Properties.Appearance.Options.UseFont = True
        Me.etTasa.Properties.Appearance.Options.UseForeColor = True
        Me.etTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.etTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etTasa.Properties.Mask.EditMask = "n4"
        Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etTasa.Size = New System.Drawing.Size(117, 22)
        Me.etTasa.StyleController = Me.LayoutControl1
        Me.etTasa.TabIndex = 11
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(119, 395)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(588, 44)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 183
        Me.txtComentario.Tag = "True"
        '
        'lblTotalU
        '
        Me.lblTotalU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalU.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalU.Location = New System.Drawing.Point(818, 467)
        Me.lblTotalU.Name = "lblTotalU"
        Me.lblTotalU.Size = New System.Drawing.Size(124, 20)
        Me.lblTotalU.TabIndex = 11
        Me.lblTotalU.Text = "0.00"
        Me.lblTotalU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdConsultaClientes
        '
        Me.cmdConsultaClientes.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsultaClientes.Appearance.Options.UseFont = True
        Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
        Me.cmdConsultaClientes.Location = New System.Drawing.Point(268, 60)
        Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
        Me.cmdConsultaClientes.Size = New System.Drawing.Size(124, 22)
        Me.cmdConsultaClientes.StyleController = Me.LayoutControl1
        Me.cmdConsultaClientes.TabIndex = 172
        Me.cmdConsultaClientes.Text = "&Clientes"
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 164)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMonto, Me.cbTEntregas, Me.txtCantidad, Me.cbTipoPrecios, Me.cbItems, Me.rLink, Me.rDescripcion})
        Me.iGrid.Size = New System.Drawing.Size(930, 227)
        Me.iGrid.TabIndex = 2
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.iVista.Appearance.EvenRow.Options.UseBackColor = True
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn13, Me.GridColumn3, Me.GridColumn4, Me.GridColumn12, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsCustomization.AllowColumnMoving = False
        Me.iVista.OptionsCustomization.AllowColumnResizing = False
        Me.iVista.OptionsCustomization.AllowFilter = False
        Me.iVista.OptionsCustomization.AllowGroup = False
        Me.iVista.OptionsCustomization.AllowSort = False
        Me.iVista.OptionsFilter.AllowColumnMRUFilterList = False
        Me.iVista.OptionsFilter.AllowFilterEditor = False
        Me.iVista.OptionsFilter.AllowMRUFilterList = False
        Me.iVista.OptionsView.EnableAppearanceEvenRow = True
        Me.iVista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.ColumnEdit = Me.cbItems
        Me.GridColumn1.FieldName = "Item"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Item", "{0:n0}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 59
        '
        'cbItems
        '
        Me.cbItems.AutoHeight = False
        ToolTipTitleItem1.Text = "Descripción"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Agregar Descripcion del Item."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.cbItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Agregar Descripción", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F3), SerializableAppearanceObject1, "Agregar Descripcion del Item", Nothing, SuperToolTip1)})
        Me.cbItems.Name = "cbItems"
        Me.cbItems.View = Me.RepositoryItemSearchLookUpEdit1View
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
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Codigo"
        Me.GridColumn2.FieldName = "Item"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Item", "{0:n0}")})
        Me.GridColumn2.Width = 150
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "T.Entrega"
        Me.GridColumn13.ColumnEdit = Me.cbTEntregas
        Me.GridColumn13.FieldName = "IdTEntrega"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 95
        '
        'cbTEntregas
        '
        Me.cbTEntregas.AutoHeight = False
        Me.cbTEntregas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTEntregas.Name = "cbTEntregas"
        Me.cbTEntregas.ShowFooter = False
        Me.cbTEntregas.ShowHeader = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cantidad"
        Me.GridColumn3.ColumnEdit = Me.txtCantidad
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Cantidad"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 72
        '
        'txtCantidad
        '
        Me.txtCantidad.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCantidad.Appearance.Options.UseBackColor = True
        Me.txtCantidad.Appearance.Options.UseFont = True
        Me.txtCantidad.Appearance.Options.UseForeColor = True
        Me.txtCantidad.Appearance.Options.UseTextOptions = True
        Me.txtCantidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n2"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Precio"
        Me.GridColumn4.ColumnEdit = Me.txtMonto
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 58
        '
        'txtMonto
        '
        Me.txtMonto.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMonto.Appearance.Options.UseBackColor = True
        Me.txtMonto.Appearance.Options.UseFont = True
        Me.txtMonto.Appearance.Options.UseForeColor = True
        Me.txtMonto.Appearance.Options.UseTextOptions = True
        Me.txtMonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMonto.AutoHeight = False
        Me.txtMonto.Mask.EditMask = "n4"
        Me.txtMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Name = "txtMonto"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.Caption = "Precio U$"
        Me.GridColumn12.ColumnEdit = Me.txtMonto
        Me.GridColumn12.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "PrecioU"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 62
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "% Descuento"
        Me.GridColumn6.DisplayFormat.FormatString = "P2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Descuento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        Me.GridColumn6.Width = 57
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Sub Total"
        Me.GridColumn5.ColumnEdit = Me.txtCantidad
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 63
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IVA"
        Me.GridColumn7.ColumnEdit = Me.txtCantidad
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "IVA"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cuenta"
        Me.GridColumn8.FieldName = "Cuenta"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tipo"
        Me.GridColumn9.FieldName = "Tipo"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Exento"
        Me.GridColumn10.FieldName = "Exento"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Existencia"
        Me.GridColumn11.ColumnEdit = Me.txtMonto
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Existencia"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Margen"
        Me.GridColumn14.ColumnEdit = Me.txtMonto
        Me.GridColumn14.FieldName = "Margen"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Tipo Precio"
        Me.GridColumn15.ColumnEdit = Me.cbTipoPrecios
        Me.GridColumn15.FieldName = "TipoPrecio"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 105
        '
        'cbTipoPrecios
        '
        Me.cbTipoPrecios.AutoHeight = False
        Me.cbTipoPrecios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoPrecios.Name = "cbTipoPrecios"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Validar"
        Me.GridColumn16.FieldName = "Validar"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Impresión"
        Me.GridColumn17.ColumnEdit = Me.rDescripcion
        Me.GridColumn17.FieldName = "Descripcion"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 211
        '
        'rDescripcion
        '
        Me.rDescripcion.AutoHeight = False
        Me.rDescripcion.Name = "rDescripcion"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "#"
        Me.GridColumn18.ColumnEdit = Me.rLink
        Me.GridColumn18.FieldName = "#"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 9
        Me.GridColumn18.Width = 54
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Digital"
        Me.rLink.Name = "rLink"
        '
        'cmdConsulta
        '
        Me.cmdConsulta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsulta.Appearance.Options.UseFont = True
        Me.cmdConsulta.Appearance.Options.UseForeColor = True
        Me.cmdConsulta.Location = New System.Drawing.Point(268, 60)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(230, 22)
        Me.cmdConsulta.StyleController = Me.LayoutControl1
        Me.cmdConsulta.TabIndex = 170
        Me.cmdConsulta.Text = "&Productos"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotal.Location = New System.Drawing.Point(818, 443)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(124, 20)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbliva
        '
        Me.lbliva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.ForeColor = System.Drawing.Color.Maroon
        Me.lbliva.Location = New System.Drawing.Point(818, 419)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(124, 20)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "0.00"
        Me.lbliva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbvendedor
        '
        Me.cmbvendedor.Location = New System.Drawing.Point(119, 84)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbvendedor.Properties.NullText = "[Asesor]"
        Me.cmbvendedor.Properties.ShowFooter = False
        Me.cmbvendedor.Properties.ShowHeader = False
        Me.cmbvendedor.Size = New System.Drawing.Size(230, 20)
        Me.cmbvendedor.StyleController = Me.LayoutControl1
        Me.cmbvendedor.TabIndex = 182
        Me.cmbvendedor.TabStop = False
        Me.cmbvendedor.Tag = "True"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Maroon
        Me.lblsubtotal.Location = New System.Drawing.Point(818, 395)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(124, 20)
        Me.lblsubtotal.TabIndex = 2
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(348, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(366, 20)
        Me.txtnombre.StyleController = Me.LayoutControl1
        Me.txtnombre.TabIndex = 1
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(119, 36)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(118, 20)
        Me.fecha.StyleController = Me.LayoutControl1
        Me.fecha.TabIndex = 6
        Me.fecha.TabStop = False
        '
        'FechaPago
        '
        Me.FechaPago.EditValue = Nothing
        Me.FechaPago.Location = New System.Drawing.Point(825, 60)
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaPago.Size = New System.Drawing.Size(117, 20)
        Me.FechaPago.StyleController = Me.LayoutControl1
        Me.FechaPago.TabIndex = 6
        Me.FechaPago.TabStop = False
        '
        'TipoServicio
        '
        Me.TipoServicio.Location = New System.Drawing.Point(12, 137)
        Me.TipoServicio.Name = "TipoServicio"
        Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
        Me.TipoServicio.Properties.Appearance.Options.UseFont = True
        Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
        Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos")})
        Me.TipoServicio.Size = New System.Drawing.Size(258, 23)
        Me.TipoServicio.StyleController = Me.LayoutControl1
        Me.TipoServicio.TabIndex = 7
        Me.TipoServicio.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtdescuentos)
        Me.GroupControl1.Controls.Add(Me.txtdescuentop)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Location = New System.Drawing.Point(118, 132)
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.LookAndFeel.UseWindowsXPTheme = True
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(380, 38)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Tipo Descuento"
        '
        'txtdescuentos
        '
        Me.txtdescuentos.Location = New System.Drawing.Point(190, 27)
        Me.txtdescuentos.Name = "txtdescuentos"
        Me.txtdescuentos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtdescuentos.Properties.LookAndFeel.UseWindowsXPTheme = True
        Me.txtdescuentos.Properties.ReadOnly = True
        Me.txtdescuentos.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentos.TabIndex = 5
        Me.txtdescuentos.TabStop = False
        '
        'txtdescuentop
        '
        Me.txtdescuentop.Location = New System.Drawing.Point(80, 27)
        Me.txtdescuentop.Name = "txtdescuentop"
        Me.txtdescuentop.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtdescuentop.Properties.LookAndFeel.UseWindowsXPTheme = True
        Me.txtdescuentop.Properties.ReadOnly = True
        Me.txtdescuentop.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentop.TabIndex = 5
        Me.txtdescuentop.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(13, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Productos :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(126, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Servicios :"
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(825, 12)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtfactura.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtfactura.Properties.ReadOnly = True
        Me.txtfactura.Size = New System.Drawing.Size(117, 20)
        Me.txtfactura.StyleController = Me.LayoutControl1
        Me.txtfactura.TabIndex = 5
        Me.txtfactura.TabStop = False
        Me.txtfactura.Tag = "True"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.Location = New System.Drawing.Point(442, 60)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = "[Moneda]"
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(272, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl1
        Me.cmbmoneda.TabIndex = 4
        Me.cmbmoneda.TabStop = False
        Me.cmbmoneda.Tag = "True"
        Me.cmbmoneda.Visible = False
        '
        'cmbformapago
        '
        Me.cmbformapago.Location = New System.Drawing.Point(119, 60)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbformapago.Properties.NullText = "[Forma de Pago]"
        Me.cmbformapago.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbformapago.Properties.ShowFooter = False
        Me.cmbformapago.Properties.ShowHeader = False
        Me.cmbformapago.Size = New System.Drawing.Size(212, 20)
        Me.cmbformapago.StyleController = Me.LayoutControl1
        Me.cmbformapago.TabIndex = 4
        Me.cmbformapago.TabStop = False
        Me.cmbformapago.Tag = "True"
        Me.cmbformapago.Visible = False
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(430, 12)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Properties.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(50, 20)
        Me.txtCaja.StyleController = Me.LayoutControl1
        Me.txtCaja.TabIndex = 5
        Me.txtCaja.TabStop = False
        Me.txtCaja.Visible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCaja
        Me.LayoutControlItem9.CustomizationFormText = "IdCaja"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(318, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(154, 24)
        Me.LayoutControlItem9.Text = "IdCaja"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GroupControl1
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(490, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdConsultaClientes
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(256, 48)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(128, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdConsulta
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(256, 48)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(234, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem16, Me.lyTotal, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem1, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem25, Me.LayoutControlItem30, Me.LayoutControlItem17, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.LayoutControlItem11, Me.LayoutControlItem31})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(954, 499)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtnombre
        Me.LayoutControlItem2.CustomizationFormText = "Atención:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(229, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(477, 24)
        Me.LayoutControlItem2.Text = "Atención:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtfactura
        Me.LayoutControlItem3.CustomizationFormText = "No. Cotización:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(706, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "No. Cotización:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmbmoneda
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(323, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(383, 24)
        Me.LayoutControlItem6.Text = "Moneda:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmbvendedor
        Me.LayoutControlItem7.CustomizationFormText = "Asesor:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(341, 24)
        Me.LayoutControlItem7.Text = "Asesor:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.iGrid
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(934, 231)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.lblsubtotal
        Me.LayoutControlItem15.CustomizationFormText = "Sub Total:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(699, 383)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Sub Total:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbformapago
        Me.LayoutControlItem8.CustomizationFormText = "Forma de Pago:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(323, 24)
        Me.LayoutControlItem8.Text = "Forma de Pago:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.FechaPago
        Me.LayoutControlItem5.CustomizationFormText = "Vencimiento:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(706, 48)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Vencimiento:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.fecha
        Me.LayoutControlItem4.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(229, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Fecha:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.lbliva
        Me.LayoutControlItem16.CustomizationFormText = "IVA:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(699, 407)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "IVA:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(104, 13)
        '
        'lyTotal
        '
        Me.lyTotal.Control = Me.lbltotal
        Me.lyTotal.CustomizationFormText = "Total C$:"
        Me.lyTotal.Location = New System.Drawing.Point(699, 431)
        Me.lyTotal.MaxSize = New System.Drawing.Size(235, 24)
        Me.lyTotal.MinSize = New System.Drawing.Size(235, 24)
        Me.lyTotal.Name = "lyTotal"
        Me.lyTotal.Size = New System.Drawing.Size(235, 24)
        Me.lyTotal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyTotal.Text = "Total:"
        Me.lyTotal.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.lblTotalU
        Me.LayoutControlItem20.CustomizationFormText = "Total U$:"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(699, 455)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "Total U$:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtComentario
        Me.LayoutControlItem21.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 383)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(699, 48)
        Me.LayoutControlItem21.Text = "Comentario:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.etTasa
        Me.LayoutControlItem23.CustomizationFormText = "T/Cambio:"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(706, 24)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "T/Cambio:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cbClientes
        Me.LayoutControlItem24.CustomizationFormText = "Cliente:"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(706, 24)
        Me.LayoutControlItem24.Text = "Cliente:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtAdicional
        Me.LayoutControlItem1.CustomizationFormText = "Comentario Adicional:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 431)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(699, 48)
        Me.LayoutControlItem1.Text = "Comentario Adicional:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cbCondiciones
        Me.LayoutControlItem27.CustomizationFormText = "Condicion de Venta:"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(341, 29)
        Me.LayoutControlItem27.Text = "Condición de Venta:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.FechaVigencia
        Me.LayoutControlItem28.CustomizationFormText = "Vigencia:"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(706, 72)
        Me.LayoutControlItem28.MaxSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.Text = "Vigencia:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cbEstados
        Me.LayoutControlItem25.CustomizationFormText = "Estado:"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(706, 96)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(228, 29)
        Me.LayoutControlItem25.Text = "Estado:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.cbCentros
        Me.LayoutControlItem30.CustomizationFormText = "Linea:"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(341, 72)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(365, 24)
        Me.LayoutControlItem30.Text = "Linea:"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.rTipo
        Me.LayoutControlItem17.Location = New System.Drawing.Point(341, 96)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(365, 29)
        Me.LayoutControlItem17.Text = "Tipo"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txtRemision
        Me.LayoutControlItem32.Location = New System.Drawing.Point(440, 125)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(174, 27)
        Me.LayoutControlItem32.Text = "Remisión:"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtOrden
        Me.LayoutControlItem33.Location = New System.Drawing.Point(262, 125)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(178, 27)
        Me.LayoutControlItem33.Text = "No. Orden:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtOc
        Me.LayoutControlItem34.Location = New System.Drawing.Point(614, 125)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(174, 27)
        Me.LayoutControlItem34.Text = "O/C:"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.TipoServicio
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 27)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(160, 27)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(262, 27)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.chkExento
        Me.LayoutControlItem31.Location = New System.Drawing.Point(788, 125)
        Me.LayoutControlItem31.MaxSize = New System.Drawing.Size(146, 27)
        Me.LayoutControlItem31.MinSize = New System.Drawing.Size(146, 27)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(146, 27)
        Me.LayoutControlItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bDuplicado)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(121, 472)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bDuplicado
        '
        Me.bDuplicado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bDuplicado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDuplicado.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bDuplicado.Appearance.Options.UseFont = True
        Me.bDuplicado.Appearance.Options.UseForeColor = True
        Me.bDuplicado.Appearance.Options.UseTextOptions = True
        Me.bDuplicado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDuplicado.Enabled = False
        Me.bDuplicado.ImageOptions.Image = CType(resources.GetObject("bDuplicado.ImageOptions.Image"), System.Drawing.Image)
        Me.bDuplicado.Location = New System.Drawing.Point(12, 54)
        Me.bDuplicado.Name = "bDuplicado"
        Me.bDuplicado.Size = New System.Drawing.Size(98, 38)
        Me.bDuplicado.StyleController = Me.LayoutControl2
        Me.bDuplicado.TabIndex = 13
        Me.bDuplicado.Text = "&Imprimir"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 138)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(98, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 12
        Me.SimpleButton2.Text = "&Estado de Cuenta"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 96)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "&Existencia por Bodega"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 405)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Salir"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem18, Me.EmptySpaceItem1, Me.LayoutControlItem26, Me.LayoutControlItem22, Me.LayoutControlItem29})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(122, 455)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdCancelar
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 393)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdAceptar
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(102, 225)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.SimpleButton2
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.bDuplicado
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem29.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem29.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.SimpleButton1
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("f0fad0ed-3eaa-477f-ad7d-240253139b30")
        Me.DockPanel1.Location = New System.Drawing.Point(954, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(130, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(130, 499)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(121, 472)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmCotizacionNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1084, 499)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmCotizacionNew"
        Me.Text = "Cotizaciones Cliente"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtOc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaVigencia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaVigencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdicional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbvendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Private _Factura As Integer = 0

    Private DT_Facturas As DataTable = New DataTable("Facturas")
    Private Temp As Boolean = False
    Private dd As String
    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Private ServCont As Boolean
    Private r As New VB.SysContab.Rutinas
    Private FacturaImprimir As String
    Private Clientes As New VB.SysContab.ClientesDB
    Private DetallesCliente As New VB.SysContab.ClientesDetails
    Private FormaPago As New VB.SysContab.Forma_PagoDB
    Private Articulos As New VB.SysContab.ArticulosDB
    Private DetallesProducto As New VB.SysContab.ArticulosDetails
    Private DetallesVendedor As New VB.SysContab.VendedoresDetails
    Private Vendedor As New VB.SysContab.VendedoresDB
    Private dsProveedoresTemporales As DataSet
    Private dsItemTemporales As DataSet
    Private FacturasCompras As New VB.SysContab.Facturas_ComprasDB
    Private Ordenes_Compras As New VB.SysContab.Ordenes_ComprasDB
    Private Ordenes As New VB.SysContab.OrdenesDB
    Private VentaPerdidaNumero As Long
    Private FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB
    Private Perfil As DataTable
    Private Moneda As String
    Private IR_Alcaldia As Double = 0
    Private IR As String = 0
    Dim TCambio As Double = 1.0
#End Region

    Public Property Factura() As Integer
        Get
            Return _Factura
        End Get
        Set(ByVal Value As Integer)
            _Factura = Value
        End Set
    End Property

    Dim Obj As New ProformaEstadoCLS
    Dim ObjCondiciones As New ProformaCondicionesCLS
    Dim DT_DESCUENTO As DataTable
    Public DT_ROL As DataTable
    Dim EmpresaDetalle As VB.SysContab.EmpresasDetails

    Private Sub FrmCotizacionNew_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim f As frmListaCotizaciones = frmListaCotizaciones.Instance()
        f.Cargar()
    End Sub

    Private Sub FrmCotizacionNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        'Dim Digitos As Integer
        'Dim Clientes As New VB.SysContab.ClientesDB
        ConfigDetalles = Config.GetConfigDetails
        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        'LoadClients()

        GetClientesList(cbClientes, 1)
        GetMonedasList(cmbmoneda)
        GetFormaPagoList(cmbformapago)
        GetVendedores(cmbvendedor)
        ObjCondiciones.FillCombo(cbCondiciones)
        ObjCondiciones.Dispose()

        Combo(cbCentros, ObtieneDatos("SELECT cdc.Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
                                                   + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual & " ORDER BY cdc.Nombre"))

        Combo(cbTEntregas, ObtieneDatos("SELECT te.IdTEntrega Codigo, te.Nombre FROM Tiempo_Entrega AS te WHERE te.Empresa = " & EmpresaActual))
        Obj.FillCombo(cbEstados)

        Combo(cbTipoPrecios, ObtieneDatos("JAR_TipoPrecios", EmpresaActual))

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        fecha.EditValue = f.Date
        FechaPago.EditValue = f.Date
        FechaVigencia.EditValue = f.Date.AddDays(15).Date

        If Factura = 0 Then 'Cuendo es Nueva Cotizacion
            txtfactura.Text = Clientes.CotizacionNumero
            TipoServicio.EditValue = "A"
        End If

        GetData()
        Calcular()


        'Digitos = ConfigDetalles.FacturaDigitos
        'For d As Integer = 0 To Digitos - 1
        '    dd = dd & "0"
        'Next
        'txtfactura.Text = Format(Clientes.FacturaNumero, dd)     
        'Para cargar de antemano el diseno de la impresion de la cotizacion
        LoadPrintDesigned()
    End Sub

    Private Sub GetData()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Numero")
        Datos.Add(EmpresaActual)
        Datos.Add(Factura)

        DT_Facturas = ProcedureParameters(Datos, Variables, "SP_GetDetalleCotizacionCliente")
        '
        If DT_Facturas.Rows.Count > 0 Then
            TipoServicio.EditValue = DT_Facturas.Rows.Item(0)("Cot_Tipo")
            cbClientes.EditValue = DT_Facturas.Rows.Item(0)("Cliente_ID")
            txtfactura.EditValue = DT_Facturas.Rows.Item(0)("Numero")
            fecha.DateTime = DT_Facturas.Rows.Item(0)("Fecha")
            txtnombre.Text = DT_Facturas.Rows.Item(0)("Nombre")
            cmbformapago.EditValue = DT_Facturas.Rows.Item(0)("FormaPago")
            cmbmoneda.EditValue = DT_Facturas.Rows.Item(0)("Moneda")
            FechaPago.DateTime = DT_Facturas.Rows.Item(0)("Vencimiento")
            cmbvendedor.EditValue = CInt(DT_Facturas.Rows.Item(0)("Asesor"))
            txtComentario.Text = DT_Facturas.Rows.Item(0)("Comentario")
            txtAdicional.Text = DT_Facturas.Rows.Item(0)("Comentario_Adicional")
            cbEstados.EditValue = DT_Facturas.Rows.Item(0)("Estado")
            cbCondiciones.EditValue = DT_Facturas.Rows.Item(0)("IdCondicion")
            FechaVigencia.DateTime = DT_Facturas.Rows.Item(0)("FechaVigencia")
            cbCentros.EditValue = DT_Facturas.Rows.Item(0)("IdLinea")
            rTipo.EditValue = DT_Facturas.Rows.Item(0)("Tipo_Proforma")
            chkExento.Checked = DT_Facturas.Rows.Item(0)("Exonera")
            etTasa.EditValue = DT_Facturas.Rows.Item(0)("TCambio")
            txtOrden.Text = DT_Facturas.Rows.Item(0)("NoOrden")
            txtRemision.Text = DT_Facturas.Rows.Item(0)("Remision")
            txtOc.Text = DT_Facturas.Rows.Item(0)("OrdenCompra")

            TCambio = etTasa.EditValue
            bDuplicado.Enabled = True
            'TipoServicio.Enabled = False
        End If
        '
        iGrid.DataSource = DT_Facturas
        iVista.Columns("Descripcion").OptionsColumn.AllowEdit = EmpresaDetalle.Cot_Editable

        iVista.Columns("#").OptionsColumn.AllowEdit = True
        iVista.Columns("#").ColumnEdit = rLink
        iVista.Columns("#").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Dim TC As DataTable = ObtieneDatos("_GetListTasaCambioDisponibles", EmpresaActual)

        If TC.Rows.Count > 0 Then
            Dim dr() As DataRow = TC.Select("MonedaCambio = '" & MonedaBase & "'")
            If dr.Length > 0 Then
                iVista.Columns("Precio").Caption = "Precio " & dr(0).Item("Simbolo").ToString
                lyTotal.Text = "Total " & dr(0).Item("Simbolo").ToString & ":"
            End If
        End If
    End Sub

    'Private Sub LoadClients()
    '    GetClientesList(cmbclientes)
    '    cmbclientes.Properties.Columns(0).Visible = True : cmbclientes.Properties.ShowHeader = True 'Para radioshack
    '    cmbclientes.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
    'End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
            'Perfil = ObtieneDatos("SELECT * FROM Clientes_Perfil WHERE IdCliente = " & cmbclientes.EditValue)
            'cmbformapago.EditValue = cmbclientes.GetColumnValue("FormaPago")
            'txtruc.Text = cmbclientes.GetColumnValue("RUC").ToString
            'txtdireccion.Text = cmbclientes.GetColumnValue("Direccion").ToString
            'txttelefono.Text = cmbclientes.GetColumnValue("Telefono").ToString
            'txtpais.Text = cmbclientes.GetColumnValue("Pais").ToString
            'txtmunicipio.Text = cmbclientes.GetColumnValue("Municipio").ToString
            'txtdepto.Text = cmbclientes.GetColumnValue("Departamento").ToString
            'txtdescuentop.Text = cmbclientes.GetColumnValue("Desc_Prod").ToString
            'txtdescuentos.Text = cmbclientes.GetColumnValue("Desc_Serv").ToString
            'cmbvendedor.EditValue = cmbclientes.GetColumnValue("Vendedor")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoServicio.SelectedIndexChanged
        GetArticulos()
        ' If Factura = 0 Then GetData()
    End Sub

    Private Sub GetArticulos()
        Dim DT As DataTable
        DT = ObtieneDatos("SP_ArticulosGetAll", TipoServicio.EditValue, EmpresaActual)

        RepositorySearchLook(cbItems, DT, "Codigo",
                             "Codigo", 3, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31)
        cbItems.View.Columns("PrecioU").Caption = "Precio U$"
        FormatoGrid(cbItems.View)

        'ItemArticulo.DataSource = DT
        'ItemArticulo.DisplayMember = "Codigo"
        'ItemArticulo.ValueMember = "Codigo"
        'ItemArticulo.PopulateColumns()
        'For i As Integer = 2 To ItemArticulo.Columns.Count - 1
        '    ItemArticulo.Columns(i).Visible = False
        'Next
        'ItemArticulo.Columns(1).Visible = False
        'ItemArticuloD.DataSource = DT
        'ItemArticuloD.DisplayMember = "Nombre"
        'ItemArticuloD.ValueMember = "Codigo"
        'ItemArticuloD.PopulateColumns()
        'For i As Integer = 2 To ItemArticuloD.Columns.Count - 1
        '    ItemArticuloD.Columns(i).Visible = False
        'Next
        'ItemArticuloD.Columns(0).Visible = False
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Precio" Then 'And Temp = False Then

            'If IsNull(e.Value, 0) <= 0 Then
            '    XtraMsg("El producto no tiene precio de lista aplicado", MessageBoxIcon.Error)
            '    iVista.DeleteSelectedRows()
            '    Exit Sub
            'End If

            'If MsgBox("Desea cambiar el precio del articulo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '    Dim f As New frmAgregarArticuloQuick
            '    f.WindowState = FormWindowState.Normal
            '    f.StartPosition = FormStartPosition.CenterScreen
            '    f.Nuevo = False

            '    If TipoServicio.EditValue = "P" Then
            '        f.etTipo.Text = "P"
            '    Else
            '        f.etTipo.Text = "S"
            '    End If

            '    f.txtCodigo.Text = GridView1.GetRowCellValue(e.RowHandle, "Item")

            '    f.lbProvTemporal.Text = ObtieneDatos("SELECT Proveedor FROM Articulos WHERE Codigo_Articulo = '" & f.txtCodigo.Text & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            '    f.cbProveedores.SelectedValue = f.lbProvTemporal.Text
            '    f.ShowDialog()
            '    Temp = True
            '    GridView1.SetRowCellValue(e.RowHandle, "Precio", f.txtCosto.Text)
            '    Temp = False
            'End If
        End If

        If e.Column.FieldName = "Item" Then
            '   Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(e.Value)
            Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

            Temp = True

            iVista.SetRowCellValue(e.RowHandle, "Descripcion", DR.Item("Nombre"))
            iVista.SetRowCellValue(e.RowHandle, "TipoPrecio", 1)
            iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
            iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))
            iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
            iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
            iVista.SetRowCellValue(e.RowHandle, "Validar", DR.Item("Validar_Precio"))
            ' GridView1.SetRowCellValue(e.RowHandle, "Existencia", DR.Item("Existencia"))
            iVista.SetRowCellValue(e.RowHandle, "Cuenta", DR.Item("Cuenta"))
            iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
            iVista.SetRowCellValue(e.RowHandle, "Exento", IIf(chkExento.Checked, True, DR.Item("Exento")))
            iVista.SetRowCellValue(e.RowHandle, "Margen", DR.Item("Margen"))
            iVista.SetRowCellValue(e.RowHandle, "#", "")

            If DR.Item("Tipo") = "P" Then
                If DR.Item("Validar_Precio") Then
                    If DR.Item("Precio") = 0.0 Then
                        iVista.Columns("Precio").OptionsColumn.AllowEdit = False
                        iVista.Columns("PrecioU").OptionsColumn.AllowEdit = False
                        iVista.Columns("Descuento").OptionsColumn.AllowEdit = False
                    Else
                        iVista.Columns("Precio").OptionsColumn.AllowEdit = True
                        iVista.Columns("PrecioU").OptionsColumn.AllowEdit = True
                        iVista.Columns("Descuento").OptionsColumn.AllowEdit = True
                    End If
                Else
                    iVista.Columns("Precio").OptionsColumn.AllowEdit = False
                    iVista.Columns("PrecioU").OptionsColumn.AllowEdit = False
                    iVista.Columns("Descuento").OptionsColumn.AllowEdit = False
                    '
                    iVista.SetRowCellValue(e.RowHandle, "Precio", 0.0)
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", 0.0)
                    '
                    XtraMsg("El Precio no se encuentra Validado, favor dirigirse al area correspondiente", MessageBoxIcon.Error)
                End If
            End If

            Temp = False
        End If

        If e.Column.FieldName = "TipoPrecio" And Not Temp Then
            ' Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))

            Temp = True
            '
            If DR.Item("Tipo") = "P" Then
                If e.Value = 1 Then
                    iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))

                    If DR.Item("Validar_Precio") Then
                        If DR.Item("Precio") = 0.0 Then
                            iVista.Columns("Precio").OptionsColumn.AllowEdit = False
                            iVista.Columns("PrecioU").OptionsColumn.AllowEdit = False
                            iVista.Columns("Descuento").OptionsColumn.AllowEdit = False
                        Else
                            iVista.Columns("Precio").OptionsColumn.AllowEdit = True
                            iVista.Columns("PrecioU").OptionsColumn.AllowEdit = True
                            iVista.Columns("Descuento").OptionsColumn.AllowEdit = True
                        End If
                    Else
                        iVista.Columns("Precio").OptionsColumn.AllowEdit = False
                        iVista.Columns("PrecioU").OptionsColumn.AllowEdit = False
                        iVista.Columns("Descuento").OptionsColumn.AllowEdit = False
                        '
                        '
                        iVista.SetRowCellValue(e.RowHandle, "Precio", 0.0)
                        iVista.SetRowCellValue(e.RowHandle, "PrecioU", 0.0)
                        '
                        XtraMsg("El Precio no se encuentra Validado, favor dirigirse al area correspondiente", MessageBoxIcon.Error)
                    End If

                ElseIf e.Value = 2 Then

                    iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio2"))
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU2"))

                    If DR.Item("Precio2") = 0.0 Then
                        iVista.Columns("Precio").OptionsColumn.AllowEdit = False
                        iVista.Columns("PrecioU").OptionsColumn.AllowEdit = False
                        iVista.Columns("Descuento").OptionsColumn.AllowEdit = False
                    Else
                        iVista.Columns("Precio").OptionsColumn.AllowEdit = True
                        iVista.Columns("PrecioU").OptionsColumn.AllowEdit = True
                        iVista.Columns("Descuento").OptionsColumn.AllowEdit = True
                    End If
                End If
            End If
            Temp = False
        End If

        '
        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True

                'If IsNull(e.Value, 0) <= 0 Then
                '    XtraMsg("El producto no tiene precio de lista aplicado", MessageBoxIcon.Error)
                '    Exit Sub
                'End If

                ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                If iVista.GetRowCellValue(e.RowHandle, "Tipo") = "P" And iVista.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                    ' Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
                    Dim DR_PROD As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))

                    Dim Descuento_VD As Double = 0,
                        Descuento_VH As Double = 0,
                        Descuento_GD As Double = 0,
                        Descuento_GH As Double = 0,
                        PrecioActual As Double = 0

                    If iVista.GetRowCellValue(e.RowHandle, "TipoPrecio") = 1 Then PrecioActual = DR_PROD.Item("Precio")
                    If iVista.GetRowCellValue(e.RowHandle, "TipoPrecio") = 2 Then PrecioActual = DR_PROD.Item("Precio2")

                    'Validando que el precio en el maestro, sera mayor que cero.
                    If PrecioActual > 0 Then
                        'Validar que no se ingrese precio menor al del maestro, segun el margen
                        DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)

                        Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                        Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                        If e.Value < PrecioActual Then
                            'Verificar si hay tabla de descuento 
                            'If DT_DESCUENTO.Rows.Count > 0 Then
                            If DescuentoV > 0 And
                                DT_DESCUENTO.Rows.Count > 0 Then
                                'Asignar los descuentos creados
                                Descuento_VH = DescuentoV
                                '
                                Descuento_GD = DescuentoV
                                Descuento_GH = DescuentoC

                                'Descuento_VD = DT_DESCUENTO.Rows.Item(0)("Desde_Vendedor")
                                'Descuento_VH = DT_DESCUENTO.Rows.Item(0)("Hasta_Vendedor")
                                ''
                                'Descuento_GD = DT_DESCUENTO.Rows.Item(0)("Desde_Gerente")
                                'Descuento_GH = DT_DESCUENTO.Rows.Item(0)("Hasta_Gerente")

                                'Sacar la Diferencia de Precios
                                'Dim DIF As Double = Math.Round(CDbl(DR_PROD.Item("Precio") - e.Value), 2)
                                'Dim DESC As Double = Math.Round(CDbl(DIF / DR_PROD.Item("Precio")), 4)

                                Dim DIF As Double = Math.Round(CDbl(PrecioActual - e.Value), 2)
                                Dim DESC As Double = Math.Round(CDbl(DIF / PrecioActual), 4)

                                'Validar en que rango de descuento se encuentra el precio
                                If DESC > Descuento_VH Then

                                    If DESC > Descuento_GH Then

                                        With frmAprobarPedido
                                            .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                            .ShowDialog()

                                            If .Ok = "SI" Then
                                                If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                    .Dispose()
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                    GoTo continuar2
                                                Else
                                                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                    Temp = False
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                    .Dispose()
                                                    Exit Sub
                                                End If
                                            Else
                                                iVista.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                Temp = False
                                                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                            End If
                                            .Dispose()
                                        End With
                                    Else
                                        With frmAprobarPedido
                                            .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                            .ShowDialog()

                                            If .Ok = "SI" Then
                                                If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                                    .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                    .Dispose()
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                    GoTo continuar2
                                                Else
                                                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                    Temp = False
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                    .Dispose()
                                                    Exit Sub
                                                End If
                                            Else
                                                iVista.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                Temp = False
                                                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                            End If
                                            .Dispose()
                                        End With
                                    End If
                                Else
                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                    Temp = False
                                End If

                                'If DESC >= Descuento_VD And DESC > 0 Then
                                '    With frmAprobarPedido
                                '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                                '        .ShowDialog()

                                '        If .Ok = "SI" Then
                                '            If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor") Then
                                '                .Dispose()                                                                                            
                                '                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                '                GoTo Continuar2
                                '            Else
                                '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)                                                
                                '                iVista.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                '                Temp = False
                                '                .Dispose()
                                '                Exit Sub
                                '            End If
                                '        Else
                                '            iVista.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                '            Temp = False
                                '        End If
                                '        .Dispose()
                                '    End With
                                'Else                                    
                                '    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                '    Temp = False
                                'End If

                                'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)
                                'iVista.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                            Else
                                iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                Temp = False
                            End If
                        Else
                            iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                            Temp = False
                        End If
                    Else
                        iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                        Temp = False
                    End If
                Else
                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                    Temp = False
                End If

continuar2:
                Temp = False
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True

                ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                If iVista.GetRowCellValue(e.RowHandle, "Tipo") = "P" And iVista.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                    ' Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
                    Dim DR_PROD As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
                    Dim Descuento_VD As Double = 0,
                        Descuento_VH As Double = 0,
                        Descuento_GD As Double = 0,
                        Descuento_GH As Double = 0,
                        PrecioActual As Double = 0

                    If iVista.GetRowCellValue(e.RowHandle, "TipoPrecio") = 1 Then PrecioActual = DR_PROD.Item("PrecioU")
                    If iVista.GetRowCellValue(e.RowHandle, "TipoPrecio") = 2 Then PrecioActual = DR_PROD.Item("PrecioU2")

                    'Validando que el precio en el maestro, sera mayor que cero.
                    If PrecioActual > 0 Then
                        'Validar que no se ingrese precio menor al del maestro, segun el margen
                        DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)

                        Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                        Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                        'Validar que no se ingrese precio menor al del maestro, segun el margen
                        If e.Value < PrecioActual Then

                            'Verificar si hay tabla de descuento 
                            If DescuentoV > 0 And
                                DT_DESCUENTO.Rows.Count > 0 Then
                                'Asignar los descuentos creados
                                Descuento_VH = DescuentoV
                                '
                                Descuento_GD = DescuentoV
                                Descuento_GH = DescuentoC

                                'Descuento_VD = DT_DESCUENTO.Rows.Item(0)("Desde_Vendedor")
                                'Descuento_VH = DT_DESCUENTO.Rows.Item(0)("Hasta_Vendedor")
                                ''
                                'Descuento_GD = DT_DESCUENTO.Rows.Item(0)("Desde_Gerente")
                                'Descuento_GH = DT_DESCUENTO.Rows.Item(0)("Hasta_Gerente")

                                'Sacar la Diferencia de Precios
                                Dim DIF As Double = Math.Round(CDbl(PrecioActual - e.Value), 2)
                                Dim DESC As Double = Math.Round(CDbl(DIF / PrecioActual), 4)

                                'Validar en que rango de descuento se encuentra el precio
                                If DESC > Descuento_VH Then

                                    If DESC > Descuento_GH Then

                                        With frmAprobarPedido
                                            .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                            .ShowDialog()

                                            If .Ok = "SI" Then
                                                If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                    .Dispose()
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                    GoTo continuar3
                                                Else
                                                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                    .Dispose()
                                                    Exit Sub
                                                End If
                                            Else
                                                iVista.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                Temp = False
                                                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                            End If
                                            .Dispose()
                                        End With
                                    Else
                                        With frmAprobarPedido
                                            .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                            .ShowDialog()

                                            If .Ok = "SI" Then
                                                If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                                    .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                                    .Dispose()
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                    GoTo continuar3
                                                Else
                                                    XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                    iVista.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                    .Dispose()
                                                    Exit Sub
                                                End If
                                            Else
                                                iVista.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                Temp = False
                                                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                            End If
                                            .Dispose()
                                        End With
                                    End If
                                Else
                                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                    Temp = False
                                End If

                                'If DESC >= Descuento_VD And DESC > 0 Then
                                '    With frmAprobarPedido
                                '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                                '        .ShowDialog()

                                '        If .Ok = "SI" Then
                                '            If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor") Then
                                '                .Dispose()
                                '                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                '                GoTo Continuar3
                                '            Else
                                '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                '                iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                                '                Temp = False
                                '                .Dispose()
                                '                Exit Sub
                                '            End If
                                '        Else
                                '            iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                                '            Temp = False
                                '        End If
                                '        .Dispose()
                                '    End With
                                'Else

                                '    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                '    Temp = False
                                'End If

                                'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)
                                'iVista.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                            Else
                                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                Temp = False
                            End If

                            'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)

                            'iVista.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                            'Temp = False
                        Else
                            iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                            Temp = False
                        End If
                    Else
                        iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                        Temp = False
                    End If
                Else
                    iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                    Temp = False
                End If

continuar3:
                Temp = False
            End If
        End If

        'If e.Column.FieldName = "Descuento" And Not Temp Then
        '    If e.Value <> 0 Then
        '        Temp = True
        '        iVista.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
        '        Temp = False
        '    End If
        'End If

        'Validar Descuento
        If e.Column.FieldName = "Descuento" And Not Temp Then
            If e.Value <> 0 Then
                'Buscar si hay tabla de configuracion de descuentos
                Dim DT As DataTable = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
                ' Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
                Dim DR_PROD As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
                Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                Dim Descuento_VD As Double = 0,
                    Descuento_VH As Double = 0,
                    Descuento_GD As Double = 0,
                    Descuento_GH As Double = 0

                If DT.Rows.Count > 0 Then
                    'Asignar los descuentos creados
                    Descuento_VH = DescuentoV
                    '
                    Descuento_GD = DescuentoV
                    Descuento_GH = DescuentoC

                    'Descuento_VD = DT.Rows.Item(0)("Desde_Vendedor")
                    'Descuento_VH = DT.Rows.Item(0)("Hasta_Vendedor")
                    ''
                    'Descuento_GD = DT.Rows.Item(0)("Desde_Gerente")
                    'Descuento_GH = DT.Rows.Item(0)("Hasta_Gerente")
                    '                    

                    'Validar si existe clave creada en la tabla
                    If DT.Rows.Item(0)("Codigo_Vendedor").ToString.Trim.Length <> 0 Then
                        'Validar si el descuento es Mayor al Descuento maximo por vendedor
                        If Math.Round(e.Value / 100, 4) > Descuento_VH Then

                            'Validar Si el descuento es Mayor al Maximo permitido por el Gerente Comercial
                            If Math.Round(e.Value / 100, 4) > Descuento_GH Then
                                With frmAprobarPedido
                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                    .ShowDialog()

                                    If .Ok = "SI" Then
                                        If .txtCodigo.Text = DT.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                        .Dispose()
                                        Exit Sub
                                    End If
                                    .Dispose()
                                End With
                            Else
                                With frmAprobarPedido
                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia Comercial"
                                    .ShowDialog()

                                    If .Ok = "SI" Then
                                        If .txtCodigo.Text = DT.Rows.Item(0)("Codigo_Gerente") Or
                                            .txtCodigo.Text = DT.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                        .Dispose()
                                        Exit Sub
                                    End If
                                    .Dispose()
                                End With
                            End If
                        End If

                        'If Math.Round(e.Value / 100, 4) >= Descuento_VD And Math.Round(e.Value / 100, 4) > 0 Then
                        '    With frmAprobarPedido
                        '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                        '        .ShowDialog()

                        '        If .Ok = "SI" Then
                        '            If .txtCodigo.Text = DT.Rows.Item(0)("Codigo_Vendedor") Then
                        '                .Dispose()
                        '                GoTo Continuar
                        '            Else
                        '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                        '                iVista.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                        '                .Dispose()
                        '                Exit Sub
                        '            End If
                        '        End If
                        '        .Dispose()
                        '    End With
                        'End If
                    End If
                End If

Continuar:
                Temp = True
                iVista.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
                Temp = False
            End If
        End If


        If e.Column.FieldName = "Precio" Or
            e.Column.FieldName = "PrecioU" Or
            e.Column.FieldName = "Cantidad" Or
            e.Column.FieldName = "Descuento" And Not Temp Then

            iVista.SetRowCellValue(e.RowHandle, "Total",
                                   (IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0)) *
                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0) -
                                   (IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0) *
                                    IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0) *
                                    IsNull(iVista.GetRowCellValue(e.RowHandle, "Descuento"), 0.0)))

            ' Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Item"))
            'Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

            If DetallesCliente.Excento = True Then
                iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
            Else
                If chkExento.Checked Then
                    iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
                Else
                    If DR.Item("Exento") = False Then
                        iVista.SetRowCellValue(e.RowHandle, "IVA", IsNull(iVista.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0))
                    Else
                        iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
                    End If
                End If
            End If
        End If

        iVista.UpdateTotalSummary()
    End Sub

    'Private Sub cmbformapago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbformapago.EditValueChanged
    '    If cmbformapago.GetColumnValue("Dias") = 0 Then cmdAceptar.Enabled = False Else cmdAceptar.Enabled = True
    '    FechaPago.EditValue = fecha.DateTime.AddDays(cmbformapago.GetColumnValue("Dias"))
    'End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVista.RowUpdated
        Calcular()
        ValidarCredito()
        ValidarNumero_Item()
    End Sub

    Sub ValidarNumero_Item()
        Try
            Dim CantidadLineas As Double = CInt(ObtieneDatos("JAR_GetNumeroLineasFV", EmpresaActual).Rows.Item(0)(0))

            If CDbl(iVista.Columns("Item").SummaryItem.SummaryValue) >= CantidadLineas Then
                XtraMsg("La Facturación solo permite Imprimir Máximo " & CantidadLineas.ToString & " Productos" & vbCrLf &
                        "Si continua agregando Items a esta cotización, se va a generar más de 1 factura...", MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub Calcular()
        iVista.RefreshData()
        '
        lblsubtotal.Text = FormatNumber(iVista.Columns("Total").SummaryItem.SummaryValue, 2)
        lbliva.Text = FormatNumber(iVista.Columns("IVA").SummaryItem.SummaryValue, 2)
        lbltotal.Text = FormatNumber(CDbl(lblsubtotal.Text) + CDbl(lbliva.Text), 2)
        lblTotalU.Text = FormatNumber(lbltotal.Text / TCambio, 2)
    End Sub

    Sub ValidarCredito()

        If cmbformapago.GetColumnValue("Dias") > 0 Then

            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

            If DetallesCliente.ValidarLimite Then
                Dim Disponible As Double = ObtieneDatos("SELECT isnull(dbo.fn_JAR_GetSaldoCliente(" & cbClientes.EditValue & "," & EmpresaActual & "),0.00) Saldo").Rows.Item(0)("Saldo")

                If MonedaBase = DetallesCliente.Moneda Then
                    If CDbl(lbltotal.Text) > Disponible Then
                        txtAdicional.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " + Disponible.ToString("n2")
                    End If
                Else
                    If CDbl(lblTotalU.Text) > Disponible Then
                        txtAdicional.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " + Disponible.ToString("n2")
                    End If
                End If
            End If
        Else
            txtAdicional.Text = ""
        End If

    End Sub

    Private Sub ItemArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Index = 1 Then

            If DT_ROL.Rows.Count > 0 Then
                Dim dr() As DataRow = DT_ROL.Select("Control = 'Agregar'")

                If dr.Length > 0 Then
                    Dim f As New frmAgregarArticuloQuick
                    f.WindowState = FormWindowState.Normal
                    f.StartPosition = FormStartPosition.CenterScreen
                    f.etTipo.Text = "P"
                    f.ShowDialog()
                    If f.ok = "SI" Then
                        GetArticulos()
                    End If
                Else
                    XtraMsg("Acceso Denegado al ingreso de nuevos Items!", MessageBoxIcon.Warning)
                End If
            Else
                XtraMsg("Acceso Denegado al ingreso de nuevos Items!", MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click

        'If cmbclientes.EditValue = Nothing Then
        '    XtraMsg("Seleccione el Cliente")
        '    Exit Sub
        'End If

        'Dim f As frmAcumulados = f.Instance

        'RegistroCliente = cmbclientes.EditValue

        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        'Dim f As frmBuscarItem = f.Instance
        'f.ShowDialog()
        'For i As Integer = 0 To f.tItem.Rows.Count - 1
        '    GridView1.AddNewRow()
        '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Item", f.tItem.Rows(i).Item("Codigo"))
        '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Cantidad", f.tItem.Rows(i).Item("Cantidad"))
        '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precio", f.tItem.Rows(i).Item("Precio"))
        'Next
        'GridView1.UpdateTotalSummary()
        ''GridView1.AddNewRow()
    End Sub

    Private Sub cmbclientes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'If e.Button.Index = 1 Then
        '    Dim f As New frmAgregarClienteQuick
        '    f.WindowState = FormWindowState.Normal
        '    f.StartPosition = FormStartPosition.CenterScreen
        '    NombreCliente = ""

        '    If f.ShowDialog() = DialogResult.OK Then
        '        GetClientesList(cmbclientes)
        '        cmbclientes.EditValue = CInt(f.txtCodigo.Text)
        '    End If


        'End If
    End Sub

    Private Function Guardar() As Boolean
        'If cmbclientes.EditValue = Nothing Then
        '    MsgBox("Seleccione el Cliente", MsgBoxStyle.Critical)
        '    cmbclientes.Focus()
        '    Return False
        '    Exit Function
        'End If

        'If cmbvendedor.EditValue = Nothing Then
        '    MsgBox("Seleccione el Vendedor", MsgBoxStyle.Critical)
        '    cmbclientes.Focus()
        '    Return False
        '    Exit Function
        'End If

        'If Trim(txtfactura.Text) = "" Then
        '    MsgBox("Introduzca el No. de Cotizacion", MsgBoxStyle.Critical)
        '    txtfactura.Focus()
        '    Return False
        '    Exit Function
        'End If

        If DT_Facturas.Rows.Count = 0 Then
            XtraMsg("Seleccione al menos un Producto o Servicio", MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        'If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
        '    MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
        '    Return False
        '    Exit Function
        'End If

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction

        Dim Tipo As String

        If TipoServicio.EditValue = "P" Then
            Tipo = 0
        ElseIf TipoServicio.EditValue = "S" Then
            Tipo = 1
        Else
            Tipo = 2
        End If

        CalcularDescuento()
        lblsubtotal.Text = CalcularSubTotal()
        lbliva.Text = CalcularIVA()
        lbltotal.Text = CDbl(lblsubtotal.Text) + CDbl(lbliva.Text) - TotalDescuento
        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

        Dim Conexion As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
        Conexion.IniciarTransaccion()

        Try
            If Factura = 0 Then txtfactura.Text = Clientes.CotizacionNumero

            'Guardar Encabezado
            Conexion.RemoveParameters()
            Conexion.AddParameter("Numero", SqlDbType.Int, 4, ParameterDirection.Input, Factura)
            Conexion.AddParameter("Cotizacion", SqlDbType.Int, 4, ParameterDirection.Input, txtfactura.EditValue)
            Conexion.AddParameter("Cliente", SqlDbType.Int, 4, ParameterDirection.Input, cbClientes.EditValue)
            Conexion.AddParameter("Nombre", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtnombre.Text)
            Conexion.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            Conexion.AddParameter("Fecha_Vencimiento", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, FechaPago.DateTime.Date)
            Conexion.AddParameter("FormaPago", SqlDbType.Int, 4, ParameterDirection.Input, cmbformapago.EditValue)
            Conexion.AddParameter("Moneda", SqlDbType.NVarChar, 5, ParameterDirection.Input, cmbmoneda.EditValue)
            Conexion.AddParameter("Vendedor", SqlDbType.Int, 50, ParameterDirection.Input, cmbvendedor.EditValue)
            Conexion.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, TipoServicio.EditValue)
            Conexion.AddParameter("Descripcion", SqlDbType.NVarChar, -1, ParameterDirection.Input, txtComentario.Text)
            Conexion.AddParameter("Comentario_Adicional", SqlDbType.NVarChar, -1, ParameterDirection.Input, txtAdicional.Text)
            Conexion.AddParameter("SubTotal", SqlDbType.Decimal, 20, ParameterDirection.Input, lblsubtotal.Text)
            Conexion.AddParameter("Descuento", SqlDbType.Decimal, 20, ParameterDirection.Input, TotalDescuento)
            Conexion.AddParameter("Iva", SqlDbType.Decimal, 20, ParameterDirection.Input, lbliva.Text)
            Conexion.AddParameter("Total", SqlDbType.Decimal, 20, ParameterDirection.Input, lbltotal.Text)
            Conexion.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conexion.AddParameter("Estado", SqlDbType.Int, 4, ParameterDirection.Input, cbEstados.EditValue)
            Conexion.AddParameter("IdCondicion", SqlDbType.Int, 4, ParameterDirection.Input, cbCondiciones.EditValue)
            Conexion.AddParameter("FechaVigencia", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, FechaVigencia.DateTime.Date)
            Conexion.AddParameter("Linea", SqlDbType.Int, 4, ParameterDirection.Input, cbCentros.EditValue)
            Conexion.AddParameter("Tipo_Proforma", SqlDbType.Int, 4, ParameterDirection.Input, rTipo.EditValue)
            Conexion.AddParameter("Exento", SqlDbType.Int, 4, ParameterDirection.Input, IIf(chkExento.Checked, 1, 0))
            Conexion.AddParameter("TCambio", SqlDbType.Decimal, 20, ParameterDirection.Input, etTasa.EditValue)
            Conexion.AddParameter("NoOrden", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtOrden.Text)
            Conexion.AddParameter("Remision", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtRemision.Text)
            Conexion.AddParameter("OrdenCompra", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtOc.Text)

            Conexion.EjecutarComando("_CotizacionesAdd")
            'Borrar Detalle del Cotizacion
            Conexion.RemoveParameters()
            Conexion.AddParameter("Cotizacion", SqlDbType.Int, 4, ParameterDirection.Input, txtfactura.EditValue)
            Conexion.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conexion.EjecutarComando("JAR_BorrarCotizacionLineas")

            'Clientes.AddCotizacion(txtfactura.Text, "", FechaPago.DateTime.Date, cmbclientes.EditValue, lblsubtotal.Text, _
            '                                      TotalDescuento, lbliva.Text, lbltotal.Text, cmbvendedor.EditValue)

            Dim Descuento As Double = 0
            Dim Iva As Double = 0

            DT_Facturas.AcceptChanges()

            For i As Integer = 0 To DT_Facturas.Rows.Count - 1

                If DT_Facturas.Rows(i).Item("Descuento") Is DBNull.Value Then
                    Descuento = 0
                Else
                    Descuento = DT_Facturas.Rows(i).Item("Descuento")
                End If
                '
                If DetallesCliente.Excento = True Then
                    Iva = 0
                Else
                    If chkExento.Checked Then
                        Iva = 0
                    Else
                        If DT_Facturas.Rows(i).Item("Exento") = True Then
                            Iva = 0
                        Else
                            Iva = ConfigDetalles.IVA
                        End If
                    End If
                End If

                Conexion.RemoveParameters()
                Conexion.AddParameter("Cotizacion", SqlDbType.Int, 4, ParameterDirection.Input, txtfactura.Text)
                Conexion.AddParameter("Item", SqlDbType.NVarChar, 100, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Item"))
                Conexion.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Cantidad"))
                Conexion.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Precio"))
                Conexion.AddParameter("Descuento", SqlDbType.Decimal, 20, ParameterDirection.Input, Descuento)
                Conexion.AddParameter("Total", SqlDbType.Decimal, 20, ParameterDirection.Input, CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")))
                Conexion.AddParameter("Comision", SqlDbType.Decimal, 50, ParameterDirection.Input, 0)
                Conexion.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Tipo"))
                Conexion.AddParameter("Iva", SqlDbType.Decimal, 20, ParameterDirection.Input, (CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) - ((CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) * (Descuento)))) * (Iva / 100.0))
                Conexion.AddParameter("IdTEntrega", SqlDbType.Int, 4, ParameterDirection.Input, IsNull(DT_Facturas.Rows(i).Item("IdTEntrega"), 0))
                Conexion.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conexion.AddParameter("Descripcion", SqlDbType.NVarChar, -1, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Descripcion"))

                Conexion.EjecutarComando("_CotizacionesLineasAdd")

                'Clientes.AddCotizacionLineas(txtfactura.Text, DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Cantidad"), DT_Facturas.Rows(i).Item("Precio"), Descuento, CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")), Comision, DT_Facturas.Rows(i).Item("Tipo"), (CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) - ((CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) * (Descuento / 100.0)))) * Iva / 100.0)
                'Conexion.AddParameter("Cotizacion", SqlDbType.Int, 50, ParameterDirection.Input, txtfactura.Text)
                'Conexion.AddParameter("Servicio", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_Facturas.Rows(i).Item("Item"))
                'Conexion.EjecutarComando("E_SP_GuardaDetalleCotizacion")
            Next

            Conexion.CompletarTransaccion()
            Temp = True
            If Factura = 0 Then ImprimirCotizacion()
            Temp = False
            Conexion = Nothing
            TotalDescuento = 0.0

            Dispose()

            Dim frm As frmListaCotizaciones = frmListaCotizaciones.Instance
            frm.Cargar()

            Return True
        Catch ex As Exception
            Conexion.AnularTransaccion()
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub CalcularDescuento()
        TotalDescuento = 0
        Try
            For i As Integer = 0 To iVista.DataRowCount - 1
                TotalDescuento += (CDbl(iVista.GetRowCellValue(i, "Cantidad")) * CDbl(iVista.GetRowCellValue(i, "Precio"))) * CDbl(iVista.GetRowCellValue(i, "Descuento"))
            Next
        Catch ex As Exception
        End Try


        TotalDescuento = Math.Round(TotalDescuento, 2)
    End Sub

    Function CalcularSubTotal() As Double
        Dim SubTotal As Double = 0

        Try
            For i As Integer = 0 To iVista.DataRowCount - 1
                SubTotal += (CDbl(iVista.GetRowCellValue(i, "Cantidad")) * CDbl(iVista.GetRowCellValue(i, "Precio")))
            Next
        Catch ex As Exception
        End Try


        Return Math.Round(SubTotal, 2)
        '  lblsubtotal.Text = Math.Round(SubTotal, 2)
    End Function

    Function CalcularIVA() As Double
        Dim IVA As Double = 0

        Try
            For i As Integer = 0 To iVista.DataRowCount - 1
                IVA += (CDbl(iVista.GetRowCellValue(i, "IVA")))
            Next
        Catch ex As Exception
        End Try



        Return Math.Round(IVA, 2)
        ' lbliva.Text = Math.Round(IVA, 2)
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        Try
            '*****************  Validando Limite de Credito del Cliente
            If Factura = 0 Then
                If cmbformapago.GetColumnValue("Dias") > 0 Then
                    DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

                    If DetallesCliente.ValidarLimite Then
                        Dim Saldo As Double = ObtieneDatos("SELECT isnull(dbo.fn_JAR_GetSaldoCliente(" & cbClientes.EditValue & "," & EmpresaActual & "),0.00) Saldo").Rows.Item(0)("Saldo")
                        '
                        If MonedaBase = DetallesCliente.Moneda Then 'cmbclientes.GetColumnValue("Moneda") Then
                            If Saldo <= 0 Then
                                If Not XtraMsg2("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2") & vbCritical & "Desea Cotizar de Todas Formas?") Then
                                    Exit Sub
                                End If
                            Else
                                If CDbl(lbltotal.Text) > Saldo Then
                                    If Not XtraMsg2("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2") & vbCritical & "Desea Cotizar de Todas Formas?") Then
                                        Exit Sub
                                    End If
                                End If
                            End If
                        Else
                            If Saldo <= 0 Then
                                If Not XtraMsg2("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2") & vbCritical & "Desea Cotizar de Todas Formas?") Then
                                    Exit Sub
                                End If
                            Else
                                If CDbl(lblTotalU.Text) > Saldo Then
                                    If Not XtraMsg2("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2") & vbCritical & "Desea Cotizar de Todas Formas?") Then
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            'Guardar los datos de la Cotizacion
            If Guardar() = False Then
                Exit Sub
            End If

            'VB.SysContab.Rutinas.okTransaccion()

            'LoadFacturaTemporal = False
            'LoadOrden = False

            'Nuevo()

        Catch ex As Exception
            'VB.SysContab.Rutinas.ErrorTransaccion()
            '' SetTiempos(Module1.OrigenComprobantes.FACTURA, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Error1, Me.txtfactura.Text)
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Nuevo()
        LimpiarControles(Me)

        cbClientes.EditValue = Nothing
        fecha.EditValue = Now.Date
        FechaPago.EditValue = Now.Date

        lblsubtotal.Text = "0.00"
        lbltotal.Text = "0.00"
        lbliva.Text = "0.00"

        TotalCheques = 0
        TotalTarjetas = 0
        TotalEfectivo = 0
        TotalNotaDebito = 0
        TotalFactura = 0

        TotalGlobal = 0

        Factura = 0
        txtfactura.Text = Clientes.CotizacionNumero
        '
        GetData()
        cbClientes.Focus()
    End Sub

    Private Sub GridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iGrid.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                iVista.DeleteRow(iVista.FocusedRowHandle)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ImprimirCotizacion()

        Dim Rep As rptProformaNew

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptCotizacion.repx", True)
        Else
            Rep = New rptProformaNew
        End If

        Rep.DataSource = ObtieneDatos("SPGetRptCotizacion " & EmpresaActual & ",'" & txtfactura.Text & "'")

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub LoadPrintDesigned()
        '  Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte
        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 4 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\RptCotizacion.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Temp = True
        Catch ex As Exception
            Temp = False
        End Try


        'Try
        '    If Not File.Exists(Application.StartupPath & "\rptDesign\RptCotizacion.repx") Then
        '        'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        '        Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 4").Rows(0).Item(0), Byte())
        '        Temp = True
        '        Dim Tamano As Integer
        '        Tamano = Data.GetUpperBound(0)
        '        If Not Directory.Exists(Application.StartupPath & "\RepDesign\") Then
        '            Directory.CreateDirectory(Application.StartupPath & "\RepDesign\")
        '        End If
        '        Cadena = Application.StartupPath & "\RptDesign\RptCotizacion.repx"
        '        If File.Exists(Cadena) Then Kill(Cadena)
        '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '        Archivo.Write(Data, 0, Tamano)
        '        Archivo.Close()
        '    Else
        '        Temp = True
        '    End If
        'Catch ex As Exception
        '    Temp = False
        '    'Exit Sub
        'End Try
    End Sub

    Private Sub fecha_EditValueChanged(sender As Object, e As EventArgs) Handles fecha.EditValueChanged
        etTasa.EditValue = GetTasaCambioDia(fecha.DateTime.Date)
        TCambio = etTasa.EditValue
        FechaVigencia.DateTime = fecha.DateTime.AddDays(15)
        If Not Inicio Then ReCalcularDetalle()
    End Sub

    Private Sub etTasa_EditValueChanged(sender As Object, e As EventArgs) Handles etTasa.EditValueChanged
        TCambio = etTasa.EditValue
    End Sub

    Private Sub etTasa_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles etTasa.Validating
        If Not Inicio Then ReCalcularDetalle()
    End Sub

    Private Sub cmbformapago_EditValueChanged(sender As Object, e As EventArgs) Handles cmbformapago.EditValueChanged
        Try
            FechaPago.EditValue = fecha.DateTime.AddDays(cmbformapago.GetColumnValue("Dias"))
            ValidarCredito()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbClientes_EditValueChanged(sender As Object, e As EventArgs) Handles cbClientes.EditValueChanged
        Try
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

            cmbformapago.EditValue = CInt(DetallesCliente.Cod_Forma_Pago)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If cbClientes.EditValue Is Nothing Then Exit Sub
        '
        Dim Clientes As New VB.SysContab.ClientesDB
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Dim rpt As New RptEstadoCuentaCliente
        rpt.DataSource = Clientes.EstadoCuentaReporteNew(cbClientes.EditValue, 0, 0, f.Date, DateAdd(DateInterval.Year, -10, f), f.Date, "%", "%", 1).Tables(0)

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            Exit Sub
        Else
            Registro = iVista.GetFocusedRowCellValue("Item")
        End If
        '
        Dim f As frmGridArticulosxBodega = frmGridArticulosxBodega.Instance()
        f.cArticulo = Registro
        f.Text = "PRODUCTO: " + Registro
        f.TipoProducto = "P"
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles iVista.ValidateRow
        With iVista
            If IsNull(.GetRowCellValue(e.RowHandle, "Precio"), 0) = 0 Or
            IsNull(.GetRowCellValue(e.RowHandle, "PrecioU"), 0) = 0 Then
                e.ErrorText = "El producto no tiene precio establecido" & vbCrLf
                e.Valid = False
            End If
        End With
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmDocumentos
            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetFocusedRowCellValue("Item"))

            .Tipo = "PRODUCTO"
            .Codigo = iVista.GetFocusedRowCellValue("Item")
            .NDocumento = DR.Item("Nombre")
            .Text = "Soporte Digital del Producto: " & DR.Item("Nombre")
            .txtNombre.Text = DR.Item("Nombre")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Sub ReCalcularDetalle()
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Precio", Math.Round(iVista.GetRowCellValue(i, "PrecioU") * etTasa.EditValue, 4))
        Next
        '
        If iVista.DataRowCount > 0 Then
            iVista.RefreshData()
            iVista.UpdateTotalSummary()
            Calcular()
        End If
    End Sub

    Sub ReCalcularIVA()
        For i As Integer = 0 To iVista.DataRowCount - 1

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(i, "Item"))

            'Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue)

            If DetallesCliente.Excento = True Then
                iVista.SetRowCellValue(i, "IVA", 0.0)
            Else
                If chkExento.Checked Then
                    iVista.SetRowCellValue(i, "IVA", 0.0)
                Else
                    If DR.Item("Exento") = False Then
                        iVista.SetRowCellValue(i, "IVA", IsNull(iVista.GetRowCellValue(i, "Total") * (ConfigDetalles.IVA / 100.0), 0))
                    Else
                        iVista.SetRowCellValue(i, "IVA", 0.0)
                    End If
                End If
            End If
            'If CheckEdit1.Checked Then iVista.SetRowCellValue(i, "IVA", 0.0)
        Next
        '
        If iVista.DataRowCount > 0 Then
            iVista.RefreshData()
            iVista.UpdateTotalSummary()
            Calcular()
        End If
    End Sub

    Private Sub chkExento_CheckedChanged(sender As Object, e As EventArgs) Handles chkExento.CheckedChanged
        If Not Inicio Then ReCalcularIVA()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.F3 Then ShowDescripcionModal()
    End Sub

    Private Sub cbItems_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbItems.ButtonClick
        If e.Button.Index = 1 Then ShowDescripcionModal()
    End Sub

    Sub ShowDescripcionModal()
        Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Item"))

        With frmCotizacionesDescripcion
            .Text = "Detalle de ITEM: " & DR.Item("Nombre")
            .txtComentario.Text = IsNull(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Descripcion"), "")
            .ShowDialog()

            If .Ok Then
                iVista.SetRowCellValue(iVista.FocusedRowHandle, "Descripcion", .txtComentario.Text)
            End If
            .Dispose()
        End With
    End Sub

    Private Sub bDuplicado_Click(sender As Object, e As EventArgs) Handles bDuplicado.Click

        If Factura = 0 Then Exit Sub

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
End Class
