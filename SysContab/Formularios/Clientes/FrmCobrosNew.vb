Imports ClasesBLL
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports Entities

Public Class FrmCobrosNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmCobrosNew = Nothing

    Public Shared Function Instance() As FrmCobrosNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmCobrosNew
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
    Friend WithEvents txtnocliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chknoir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chknoiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtefectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdcheques As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdtarjetas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcheques As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttarjetas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRecibos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkcontabilizado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdbuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chksaldo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaCobro As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FechaComprobante As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtcomprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chknoiralcaldia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMntoValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbserie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAplicar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPorCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRecibimos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbClientes As SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lyMonto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents lyTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents chkselector As CheckBox
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents etMntto As HyperlinkLabelControl
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblMontoLetras As LabelControl
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTasaParalela As TextEdit
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtEquivalente As TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCatalogo As SearchLookUpEdit
    Friend WithEvents GridView1 As GridView
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkInteres As CheckEdit
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DXErrorProvider.DXValidationProvider
    Friend WithEvents lblInteres As HyperlinkLabelControl
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rLink As Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCobrosNew))
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMntoValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtcomprobante = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblInteres = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.chkInteres = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCatalogo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtEquivalente = New DevExpress.XtraEditors.TextEdit()
        Me.txtTasaParalela = New DevExpress.XtraEditors.TextEdit()
        Me.lblMontoLetras = New DevExpress.XtraEditors.LabelControl()
        Me.etMntto = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.chkselector = New System.Windows.Forms.CheckBox()
        Me.txtPorCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.chkAplicar = New DevExpress.XtraEditors.CheckEdit()
        Me.FechaComprobante = New DevExpress.XtraEditors.DateEdit()
        Me.cmdbuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtRecibimos = New DevExpress.XtraEditors.TextEdit()
        Me.cmdcheques = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtnocliente = New DevExpress.XtraEditors.TextEdit()
        Me.chkcontabilizado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit()
        Me.chksaldo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtefectivo = New DevExpress.XtraEditors.TextEdit()
        Me.cbClientes = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chknoiralcaldia = New DevExpress.XtraEditors.CheckEdit()
        Me.chknoiva = New DevExpress.XtraEditors.CheckEdit()
        Me.txttotal = New DevExpress.XtraEditors.TextEdit()
        Me.cmdtarjetas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbserie = New DevExpress.XtraEditors.LookUpEdit()
        Me.chknoir = New DevExpress.XtraEditors.CheckEdit()
        Me.txtrecibo = New DevExpress.XtraEditors.TextEdit()
        Me.FechaCobro = New DevExpress.XtraEditors.DateEdit()
        Me.txttarjetas = New DevExpress.XtraEditors.TextEdit()
        Me.txtcheques = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.lyTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMonto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRecibos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcomprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquivalente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasaParalela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaComprobante.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecibimos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnocliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcontabilizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chksaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chknoiralcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chknoiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbserie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chknoir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaCobro.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaCobro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttarjetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcheques.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.OrangeRed
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn8.Caption = "Cobro"
        Me.GridColumn8.ColumnEdit = Me.txtMntoValor
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Cobro"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cobro", "{0:n2}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 13
        Me.GridColumn8.Width = 56
        '
        'txtMntoValor
        '
        Me.txtMntoValor.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMntoValor.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMntoValor.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtMntoValor.Appearance.Options.UseBackColor = True
        Me.txtMntoValor.Appearance.Options.UseFont = True
        Me.txtMntoValor.Appearance.Options.UseForeColor = True
        Me.txtMntoValor.Appearance.Options.UseTextOptions = True
        Me.txtMntoValor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMntoValor.AutoHeight = False
        Me.txtMntoValor.Mask.EditMask = "n2"
        Me.txtMntoValor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMntoValor.Mask.UseMaskAsDisplayFormat = True
        Me.txtMntoValor.Name = "txtMntoValor"
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Location = New System.Drawing.Point(532, 242)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtcomprobante.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtcomprobante.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtcomprobante.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtcomprobante.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtcomprobante.Properties.Mask.EditMask = "d"
        Me.txtcomprobante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcomprobante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcomprobante.Properties.ReadOnly = True
        Me.txtcomprobante.Size = New System.Drawing.Size(388, 22)
        Me.txtcomprobante.StyleController = Me.LayoutControl1
        Me.txtcomprobante.TabIndex = 0
        Me.txtcomprobante.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblInteres)
        Me.LayoutControl1.Controls.Add(Me.chkInteres)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl1.Controls.Add(Me.txtEquivalente)
        Me.LayoutControl1.Controls.Add(Me.txtTasaParalela)
        Me.LayoutControl1.Controls.Add(Me.lblMontoLetras)
        Me.LayoutControl1.Controls.Add(Me.etMntto)
        Me.LayoutControl1.Controls.Add(Me.chkselector)
        Me.LayoutControl1.Controls.Add(Me.txtPorCuenta)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.txtcomprobante)
        Me.LayoutControl1.Controls.Add(Me.txtTasa)
        Me.LayoutControl1.Controls.Add(Me.chkAplicar)
        Me.LayoutControl1.Controls.Add(Me.FechaComprobante)
        Me.LayoutControl1.Controls.Add(Me.cmdbuscar)
        Me.LayoutControl1.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl1.Controls.Add(Me.txtRecibimos)
        Me.LayoutControl1.Controls.Add(Me.cmdcheques)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.txtnocliente)
        Me.LayoutControl1.Controls.Add(Me.chkcontabilizado)
        Me.LayoutControl1.Controls.Add(Me.txtCaja)
        Me.LayoutControl1.Controls.Add(Me.chksaldo)
        Me.LayoutControl1.Controls.Add(Me.txtefectivo)
        Me.LayoutControl1.Controls.Add(Me.cbClientes)
        Me.LayoutControl1.Controls.Add(Me.chknoiralcaldia)
        Me.LayoutControl1.Controls.Add(Me.chknoiva)
        Me.LayoutControl1.Controls.Add(Me.txttotal)
        Me.LayoutControl1.Controls.Add(Me.cmdtarjetas)
        Me.LayoutControl1.Controls.Add(Me.cmbserie)
        Me.LayoutControl1.Controls.Add(Me.chknoir)
        Me.LayoutControl1.Controls.Add(Me.txtrecibo)
        Me.LayoutControl1.Controls.Add(Me.FechaCobro)
        Me.LayoutControl1.Controls.Add(Me.txttarjetas)
        Me.LayoutControl1.Controls.Add(Me.txtcheques)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.LayoutControlItem19, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem7, Me.LayoutControlItem20, Me.LayoutControlItem9})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(977, 245, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(945, 588)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblInteres
        '
        Me.lblInteres.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteres.Appearance.Options.UseFont = True
        Me.lblInteres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInteres.Location = New System.Drawing.Point(665, 556)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(55, 18)
        Me.lblInteres.StyleController = Me.LayoutControl1
        Me.lblInteres.TabIndex = 23
        Me.lblInteres.Text = "0.0000"
        '
        'chkInteres
        '
        Me.chkInteres.Enabled = False
        Me.chkInteres.Location = New System.Drawing.Point(795, 308)
        Me.chkInteres.Name = "chkInteres"
        Me.chkInteres.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInteres.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chkInteres.Properties.Appearance.Options.UseFont = True
        Me.chkInteres.Properties.Appearance.Options.UseForeColor = True
        Me.chkInteres.Properties.Caption = "Aplicar Interés"
        Me.chkInteres.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgRadio2
        Me.chkInteres.Size = New System.Drawing.Size(126, 22)
        Me.chkInteres.StyleController = Me.LayoutControl1
        Me.chkInteres.TabIndex = 25
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(529, 220)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.PopupView = Me.GridView1
        Me.cbCatalogo.Size = New System.Drawing.Size(392, 22)
        Me.cbCatalogo.StyleController = Me.LayoutControl1
        Me.cbCatalogo.TabIndex = 24
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtEquivalente
        '
        Me.txtEquivalente.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEquivalente.Location = New System.Drawing.Point(178, 218)
        Me.txtEquivalente.Name = "txtEquivalente"
        Me.txtEquivalente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquivalente.Properties.Appearance.Options.UseFont = True
        Me.txtEquivalente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEquivalente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquivalente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtEquivalente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEquivalente.Properties.Mask.EditMask = "n2"
        Me.txtEquivalente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEquivalente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEquivalente.Properties.NullText = "0"
        Me.txtEquivalente.Properties.ReadOnly = True
        Me.txtEquivalente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEquivalente.Size = New System.Drawing.Size(183, 22)
        Me.txtEquivalente.StyleController = Me.LayoutControl1
        Me.txtEquivalente.TabIndex = 11
        '
        'txtTasaParalela
        '
        Me.txtTasaParalela.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTasaParalela.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasaParalela.Location = New System.Drawing.Point(827, 272)
        Me.txtTasaParalela.Name = "txtTasaParalela"
        Me.txtTasaParalela.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaParalela.Properties.Appearance.Options.UseFont = True
        Me.txtTasaParalela.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaParalela.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasaParalela.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasaParalela.Properties.Mask.EditMask = "n4"
        Me.txtTasaParalela.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasaParalela.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasaParalela.Properties.NullText = "0"
        Me.txtTasaParalela.Properties.ReadOnly = True
        Me.txtTasaParalela.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasaParalela.Size = New System.Drawing.Size(94, 22)
        Me.txtTasaParalela.StyleController = Me.LayoutControl1
        Me.txtTasaParalela.TabIndex = 11
        '
        'lblMontoLetras
        '
        Me.lblMontoLetras.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMontoLetras.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMontoLetras.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoLetras.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lblMontoLetras.Appearance.Options.UseBackColor = True
        Me.lblMontoLetras.Appearance.Options.UseFont = True
        Me.lblMontoLetras.Appearance.Options.UseForeColor = True
        Me.lblMontoLetras.Appearance.Options.UseTextOptions = True
        Me.lblMontoLetras.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMontoLetras.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMontoLetras.Location = New System.Drawing.Point(375, 308)
        Me.lblMontoLetras.Name = "lblMontoLetras"
        Me.lblMontoLetras.Size = New System.Drawing.Size(416, 18)
        Me.lblMontoLetras.StyleController = Me.LayoutControl1
        Me.lblMontoLetras.TabIndex = 23
        Me.lblMontoLetras.Text = "0/100"
        '
        'etMntto
        '
        Me.etMntto.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMntto.Appearance.Options.UseFont = True
        Me.etMntto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.etMntto.Location = New System.Drawing.Point(878, 556)
        Me.etMntto.Name = "etMntto"
        Me.etMntto.Size = New System.Drawing.Size(55, 18)
        Me.etMntto.StyleController = Me.LayoutControl1
        Me.etMntto.TabIndex = 22
        Me.etMntto.Text = "0.0000"
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkselector.Location = New System.Drawing.Point(12, 556)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(495, 20)
        Me.chkselector.TabIndex = 11
        Me.chkselector.Text = "Mostrar / Ocultar Datos"
        '
        'txtPorCuenta
        '
        Me.txtPorCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorCuenta.Location = New System.Drawing.Point(529, 194)
        Me.txtPorCuenta.Name = "txtPorCuenta"
        Me.txtPorCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorCuenta.Properties.Appearance.Options.UseFont = True
        Me.txtPorCuenta.Size = New System.Drawing.Size(392, 22)
        Me.txtPorCuenta.StyleController = Me.LayoutControl1
        Me.txtPorCuenta.TabIndex = 9
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 346)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMntoValor, Me.rLink})
        Me.iGrid.Size = New System.Drawing.Size(921, 206)
        Me.iGrid.TabIndex = 6
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.iVista.ColumnPanelRowHeight = 30
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn14, Me.GridColumn13, Me.GridColumn28, Me.GridColumn29, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn26, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn23, Me.GridColumn22, Me.GridColumn24, Me.GridColumn25, Me.GridColumn27})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GridColumn8
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = 0
        Me.iVista.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsFilter.AllowColumnMRUFilterList = False
        Me.iVista.OptionsFilter.AllowFilterEditor = False
        Me.iVista.OptionsFilter.AllowMRUFilterList = False
        Me.iVista.OptionsMenu.EnableColumnMenu = False
        Me.iVista.OptionsMenu.EnableFooterMenu = False
        Me.iVista.OptionsMenu.EnableGroupPanelMenu = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "CodigoCliente"
        Me.GridColumn15.FieldName = "CodigoCliente"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Cliente"
        Me.GridColumn14.FieldName = "Cliente"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Width = 71
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn13.Caption = "Facturar"
        Me.GridColumn13.FieldName = "Facturar"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 39
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "#"
        Me.GridColumn28.ColumnEdit = Me.rLink
        Me.GridColumn28.FieldName = "#"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 2
        Me.GridColumn28.Width = 20
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Ver"
        Me.rLink.Name = "rLink"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "AP"
        Me.GridColumn29.FieldName = "AP"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 3
        Me.GridColumn29.Width = 20
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "Factura"
        Me.GridColumn1.FieldName = "No Factura"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 37
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 36
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.Caption = "Tipo"
        Me.GridColumn3.FieldName = "Tipo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Width = 51
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn4.Caption = "Sub Total"
        Me.GridColumn4.DisplayFormat.FormatString = "n2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "SubTotal"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:n2}")})
        Me.GridColumn4.Width = 55
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "IVA"
        Me.GridColumn5.DisplayFormat.FormatString = "n2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "IVA"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        Me.GridColumn5.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.Caption = "Total Factura"
        Me.GridColumn6.DisplayFormat.FormatString = "n2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Total"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        Me.GridColumn6.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn7.Caption = "Abono"
        Me.GridColumn7.DisplayFormat.FormatString = "n2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Abono"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abono", "{0:n2}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 10
        Me.GridColumn7.Width = 36
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn26.AppearanceCell.ForeColor = System.Drawing.Color.OrangeRed
        Me.GridColumn26.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn26.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn26.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn26.Caption = "Cobro U$"
        Me.GridColumn26.ColumnEdit = Me.txtMntoValor
        Me.GridColumn26.DisplayFormat.FormatString = "n2"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "CobroU"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CobroU", "{0:n2}")})
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 14
        Me.GridColumn26.Width = 65
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BackColor = System.Drawing.Color.SkyBlue
        Me.GridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.SteelBlue
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn9.Caption = "Saldo"
        Me.GridColumn9.DisplayFormat.FormatString = "n2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Saldo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 11
        Me.GridColumn9.Width = 45
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn10.Caption = "Mtto. Valor"
        Me.GridColumn10.ColumnEdit = Me.txtMntoValor
        Me.GridColumn10.FieldName = "Monto_Mantenimiento"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto_Mantenimiento", "{0:n2}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 15
        Me.GridColumn10.Width = 66
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn11.Caption = "IVA Parcial"
        Me.GridColumn11.ColumnEdit = Me.txtMntoValor
        Me.GridColumn11.DisplayFormat.FormatString = "n2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "IVAParcial"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVAParcial", "{0:n2}")})
        Me.GridColumn11.Width = 55
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn12.Caption = "IR Parcial"
        Me.GridColumn12.ColumnEdit = Me.txtMntoValor
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "IrParcial"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IrParcial", "{0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 17
        Me.GridColumn12.Width = 55
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn16.Caption = "IR Alcaldia"
        Me.GridColumn16.ColumnEdit = Me.txtMntoValor
        Me.GridColumn16.DisplayFormat.FormatString = "n2"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "IrAlcaldia"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IrAlcaldia", "{0:n2}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 18
        Me.GridColumn16.Width = 94
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn17.Caption = "Moneda"
        Me.GridColumn17.FieldName = "Moneda"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.AllowFocus = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 6
        Me.GridColumn17.Width = 35
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Mtto_Fijo"
        Me.GridColumn18.ColumnEdit = Me.txtMntoValor
        Me.GridColumn18.FieldName = "Mtto_Fijo"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Total U$"
        Me.GridColumn19.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "Total U$"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.AllowFocus = False
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total U$", "{0:n2}")})
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 9
        Me.GridColumn19.Width = 56
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "T/C Paralelo"
        Me.GridColumn20.FieldName = "TC_Paralelo"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.AllowFocus = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 7
        Me.GridColumn20.Width = 35
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Saldo U$"
        Me.GridColumn21.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "SaldoU"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.AllowFocus = False
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoU", "{0:n2}")})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 12
        Me.GridColumn21.Width = 55
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "TC_Factura"
        Me.GridColumn23.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "TC"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.AllowFocus = False
        Me.GridColumn23.Width = 70
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "OtroSaldo"
        Me.GridColumn22.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "OtroSaldo"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.AllowFocus = False
        Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtroSaldo", "{0:n2}")})
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "F/Electrónica"
        Me.GridColumn24.FieldName = "F/Electrónica"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 4
        Me.GridColumn24.Width = 41
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Interés"
        Me.GridColumn25.ColumnEdit = Me.txtMntoValor
        Me.GridColumn25.FieldName = "Interes"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Interes", "{0:n2}")})
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 16
        Me.GridColumn25.Width = 55
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "TCambio"
        Me.GridColumn27.FieldName = "TCambio"
        Me.GridColumn27.GroupFormat.FormatString = "{0:n4}"
        Me.GridColumn27.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.OptionsColumn.ReadOnly = True
        '
        'txtTasa
        '
        Me.txtTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.Location = New System.Drawing.Point(827, 246)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.Properties.NullText = "0"
        Me.txtTasa.Properties.ReadOnly = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(94, 22)
        Me.txtTasa.StyleController = Me.LayoutControl1
        Me.txtTasa.TabIndex = 7
        '
        'chkAplicar
        '
        Me.chkAplicar.Location = New System.Drawing.Point(574, 45)
        Me.chkAplicar.Name = "chkAplicar"
        Me.chkAplicar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAplicar.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkAplicar.Properties.Appearance.Options.UseFont = True
        Me.chkAplicar.Properties.Appearance.Options.UseForeColor = True
        Me.chkAplicar.Properties.Caption = "Aplicar a Cualquier Factura"
        Me.chkAplicar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAplicar.Size = New System.Drawing.Size(347, 22)
        Me.chkAplicar.StyleController = Me.LayoutControl1
        Me.chkAplicar.TabIndex = 8
        Me.chkAplicar.Visible = False
        '
        'FechaComprobante
        '
        Me.FechaComprobante.EditValue = Nothing
        Me.FechaComprobante.Location = New System.Drawing.Point(532, 242)
        Me.FechaComprobante.Name = "FechaComprobante"
        Me.FechaComprobante.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.FechaComprobante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaComprobante.Properties.Appearance.Options.UseFont = True
        Me.FechaComprobante.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.FechaComprobante.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaComprobante.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FechaComprobante.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.FechaComprobante.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.FechaComprobante.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.FechaComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaComprobante.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaComprobante.Properties.ReadOnly = True
        Me.FechaComprobante.Size = New System.Drawing.Size(133, 20)
        Me.FechaComprobante.StyleController = Me.LayoutControl1
        Me.FechaComprobante.TabIndex = 5
        Me.FechaComprobante.Visible = False
        '
        'cmdbuscar
        '
        Me.cmdbuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbuscar.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cmdbuscar.Appearance.Options.UseFont = True
        Me.cmdbuscar.Appearance.Options.UseForeColor = True
        Me.cmdbuscar.Enabled = False
        Me.cmdbuscar.Location = New System.Drawing.Point(378, 242)
        Me.cmdbuscar.Name = "cmdbuscar"
        Me.cmdbuscar.Size = New System.Drawing.Size(66, 22)
        Me.cmdbuscar.StyleController = Me.LayoutControl1
        Me.cmdbuscar.TabIndex = 2
        Me.cmdbuscar.Text = "&Buscar"
        Me.cmdbuscar.Visible = False
        '
        'cmbmoneda
        '
        Me.cmbmoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbmoneda.Location = New System.Drawing.Point(178, 168)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(183, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl1
        Me.cmbmoneda.TabIndex = 2
        '
        'txtRecibimos
        '
        Me.txtRecibimos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecibimos.Location = New System.Drawing.Point(529, 168)
        Me.txtRecibimos.Name = "txtRecibimos"
        Me.txtRecibimos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibimos.Properties.Appearance.Options.UseFont = True
        Me.txtRecibimos.Size = New System.Drawing.Size(392, 22)
        Me.txtRecibimos.StyleController = Me.LayoutControl1
        Me.txtRecibimos.TabIndex = 9
        '
        'cmdcheques
        '
        Me.cmdcheques.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcheques.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdcheques.Appearance.Options.UseFont = True
        Me.cmdcheques.Appearance.Options.UseForeColor = True
        Me.cmdcheques.ImageOptions.Image = CType(resources.GetObject("cmdcheques.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdcheques.Location = New System.Drawing.Point(24, 244)
        Me.cmdcheques.Name = "cmdcheques"
        Me.cmdcheques.Size = New System.Drawing.Size(146, 22)
        Me.cmdcheques.StyleController = Me.LayoutControl1
        Me.cmdcheques.TabIndex = 1
        Me.cmdcheques.Text = "&Cheques"
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(844, 62)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(6, 13)
        Me.etInicio.StyleController = Me.LayoutControl1
        Me.etInicio.TabIndex = 10
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(751, 95)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CheckEdit1.Properties.Caption = "Contabilizar Recibo"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(170, 24)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 9
        '
        'txtnocliente
        '
        Me.txtnocliente.EditValue = ""
        Me.txtnocliente.Location = New System.Drawing.Point(790, 62)
        Me.txtnocliente.Name = "txtnocliente"
        Me.txtnocliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtnocliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnocliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtnocliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtnocliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtnocliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtnocliente.Properties.ReadOnly = True
        Me.txtnocliente.Size = New System.Drawing.Size(60, 22)
        Me.txtnocliente.StyleController = Me.LayoutControl1
        Me.txtnocliente.TabIndex = 2
        Me.txtnocliente.Visible = False
        '
        'chkcontabilizado
        '
        Me.chkcontabilizado.Location = New System.Drawing.Point(434, 133)
        Me.chkcontabilizado.Name = "chkcontabilizado"
        Me.chkcontabilizado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontabilizado.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkcontabilizado.Properties.Appearance.Options.UseFont = True
        Me.chkcontabilizado.Properties.Appearance.Options.UseForeColor = True
        Me.chkcontabilizado.Properties.Caption = "Contabilizado"
        Me.chkcontabilizado.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkcontabilizado.Size = New System.Drawing.Size(418, 22)
        Me.chkcontabilizado.StyleController = Me.LayoutControl1
        Me.chkcontabilizado.TabIndex = 4
        Me.chkcontabilizado.Visible = False
        '
        'txtCaja
        '
        Me.txtCaja.EditValue = ""
        Me.txtCaja.Location = New System.Drawing.Point(736, 62)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Properties.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(114, 20)
        Me.txtCaja.StyleController = Me.LayoutControl1
        Me.txtCaja.TabIndex = 1
        Me.txtCaja.Visible = False
        '
        'chksaldo
        '
        Me.chksaldo.Location = New System.Drawing.Point(777, 69)
        Me.chksaldo.Name = "chksaldo"
        Me.chksaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksaldo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chksaldo.Properties.Appearance.Options.UseFont = True
        Me.chksaldo.Properties.Appearance.Options.UseForeColor = True
        Me.chksaldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chksaldo.Properties.Caption = "Cobrar a Saldo"
        Me.chksaldo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chksaldo.Size = New System.Drawing.Size(144, 24)
        Me.chksaldo.StyleController = Me.LayoutControl1
        Me.chksaldo.TabIndex = 4
        '
        'txtefectivo
        '
        Me.txtefectivo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtefectivo.Location = New System.Drawing.Point(178, 192)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Properties.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.txtefectivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtefectivo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtefectivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtefectivo.Properties.Appearance.Options.UseFont = True
        Me.txtefectivo.Properties.Appearance.Options.UseForeColor = True
        Me.txtefectivo.Properties.Mask.EditMask = "n2"
        Me.txtefectivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtefectivo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtefectivo.Properties.NullText = "0.00"
        Me.txtefectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtefectivo.Size = New System.Drawing.Size(183, 22)
        Me.txtefectivo.StyleController = Me.LayoutControl1
        Me.txtefectivo.TabIndex = 0
        '
        'cbClientes
        '
        Me.cbClientes.Location = New System.Drawing.Point(178, 45)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Properties.Appearance.Options.UseFont = True
        Me.cbClientes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClientes.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbClientes.Size = New System.Drawing.Size(743, 20)
        Me.cbClientes.StyleController = Me.LayoutControl1
        Me.cbClientes.TabIndex = 19
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'chknoiralcaldia
        '
        Me.chknoiralcaldia.EditValue = True
        Me.chknoiralcaldia.Location = New System.Drawing.Point(751, 69)
        Me.chknoiralcaldia.Name = "chknoiralcaldia"
        Me.chknoiralcaldia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chknoiralcaldia.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chknoiralcaldia.Properties.Appearance.Options.UseFont = True
        Me.chknoiralcaldia.Properties.Appearance.Options.UseForeColor = True
        Me.chknoiralcaldia.Properties.Caption = "No Aplicar IR Alcaldia"
        Me.chknoiralcaldia.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chknoiralcaldia.Size = New System.Drawing.Size(170, 22)
        Me.chknoiralcaldia.StyleController = Me.LayoutControl1
        Me.chknoiralcaldia.TabIndex = 6
        '
        'chknoiva
        '
        Me.chknoiva.Location = New System.Drawing.Point(777, 71)
        Me.chknoiva.Name = "chknoiva"
        Me.chknoiva.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chknoiva.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chknoiva.Properties.Appearance.Options.UseFont = True
        Me.chknoiva.Properties.Appearance.Options.UseForeColor = True
        Me.chknoiva.Properties.Caption = "No Aplicar IVA"
        Me.chknoiva.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chknoiva.Size = New System.Drawing.Size(144, 22)
        Me.chknoiva.StyleController = Me.LayoutControl1
        Me.chknoiva.TabIndex = 4
        '
        'txttotal
        '
        Me.txttotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttotal.Location = New System.Drawing.Point(178, 297)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Properties.Appearance.Options.UseFont = True
        Me.txttotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txttotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txttotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txttotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txttotal.Properties.Mask.EditMask = "n2"
        Me.txttotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotal.Properties.NullText = "0"
        Me.txttotal.Properties.ReadOnly = True
        Me.txttotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttotal.Size = New System.Drawing.Size(183, 22)
        Me.txttotal.StyleController = Me.LayoutControl1
        Me.txttotal.TabIndex = 0
        '
        'cmdtarjetas
        '
        Me.cmdtarjetas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtarjetas.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdtarjetas.Appearance.Options.UseFont = True
        Me.cmdtarjetas.Appearance.Options.UseForeColor = True
        Me.cmdtarjetas.ImageOptions.Image = CType(resources.GetObject("cmdtarjetas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdtarjetas.Location = New System.Drawing.Point(24, 270)
        Me.cmdtarjetas.Name = "cmdtarjetas"
        Me.cmdtarjetas.Size = New System.Drawing.Size(146, 22)
        Me.cmdtarjetas.StyleController = Me.LayoutControl1
        Me.cmdtarjetas.TabIndex = 2
        Me.cmdtarjetas.Text = "&Tarjetas de Credito"
        '
        'cmbserie
        '
        Me.cmbserie.EnterMoveNextControl = True
        Me.cmbserie.Location = New System.Drawing.Point(178, 95)
        Me.cmbserie.Name = "cmbserie"
        Me.cmbserie.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbserie.Properties.Appearance.Options.UseFont = True
        Me.cmbserie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbserie.Properties.NullText = ""
        Me.cmbserie.Properties.ShowFooter = False
        Me.cmbserie.Properties.ShowHeader = False
        Me.cmbserie.Size = New System.Drawing.Size(125, 20)
        Me.cmbserie.StyleController = Me.LayoutControl1
        Me.cmbserie.TabIndex = 8
        '
        'chknoir
        '
        Me.chknoir.EditValue = True
        Me.chknoir.Location = New System.Drawing.Point(610, 69)
        Me.chknoir.Name = "chknoir"
        Me.chknoir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chknoir.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chknoir.Properties.Appearance.Options.UseFont = True
        Me.chknoir.Properties.Appearance.Options.UseForeColor = True
        Me.chknoir.Properties.Caption = "No Aplicar IR"
        Me.chknoir.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chknoir.Size = New System.Drawing.Size(137, 22)
        Me.chknoir.StyleController = Me.LayoutControl1
        Me.chknoir.TabIndex = 3
        '
        'txtrecibo
        '
        Me.txtrecibo.EditValue = ""
        Me.txtrecibo.Location = New System.Drawing.Point(461, 95)
        Me.txtrecibo.Name = "txtrecibo"
        Me.txtrecibo.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtrecibo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecibo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtrecibo.Properties.Appearance.Options.UseBackColor = True
        Me.txtrecibo.Properties.Appearance.Options.UseFont = True
        Me.txtrecibo.Properties.Appearance.Options.UseForeColor = True
        Me.txtrecibo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtrecibo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtrecibo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtrecibo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtrecibo.Size = New System.Drawing.Size(126, 22)
        Me.txtrecibo.StyleController = Me.LayoutControl1
        Me.txtrecibo.TabIndex = 2
        Me.txtrecibo.Tag = "True"
        '
        'FechaCobro
        '
        Me.FechaCobro.EditValue = Nothing
        Me.FechaCobro.Location = New System.Drawing.Point(178, 69)
        Me.FechaCobro.Name = "FechaCobro"
        Me.FechaCobro.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.FechaCobro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaCobro.Properties.Appearance.Options.UseFont = True
        Me.FechaCobro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaCobro.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaCobro.Size = New System.Drawing.Size(125, 20)
        Me.FechaCobro.StyleController = Me.LayoutControl1
        Me.FechaCobro.TabIndex = 5
        '
        'txttarjetas
        '
        Me.txttarjetas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttarjetas.Location = New System.Drawing.Point(174, 270)
        Me.txttarjetas.Name = "txttarjetas"
        Me.txttarjetas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttarjetas.Properties.Appearance.Options.UseFont = True
        Me.txttarjetas.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Lavender
        Me.txttarjetas.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttarjetas.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txttarjetas.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txttarjetas.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txttarjetas.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txttarjetas.Properties.Mask.EditMask = "n2"
        Me.txttarjetas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttarjetas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttarjetas.Properties.NullText = "0"
        Me.txttarjetas.Properties.ReadOnly = True
        Me.txttarjetas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txttarjetas.Size = New System.Drawing.Size(187, 22)
        Me.txttarjetas.StyleController = Me.LayoutControl1
        Me.txttarjetas.TabIndex = 0
        '
        'txtcheques
        '
        Me.txtcheques.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcheques.Location = New System.Drawing.Point(174, 244)
        Me.txtcheques.Name = "txtcheques"
        Me.txtcheques.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheques.Properties.Appearance.Options.UseFont = True
        Me.txtcheques.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Lavender
        Me.txtcheques.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheques.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtcheques.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtcheques.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtcheques.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtcheques.Properties.Mask.EditMask = "n2"
        Me.txtcheques.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcheques.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcheques.Properties.NullText = "0"
        Me.txtcheques.Properties.ReadOnly = True
        Me.txtcheques.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcheques.Size = New System.Drawing.Size(187, 22)
        Me.txtcheques.StyleController = Me.LayoutControl1
        Me.txtcheques.TabIndex = 0
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.etInicio
        Me.LayoutControlItem12.Location = New System.Drawing.Point(832, 50)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(10, 28)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtnocliente
        Me.LayoutControlItem11.Location = New System.Drawing.Point(778, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(64, 28)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCaja
        Me.LayoutControlItem10.Location = New System.Drawing.Point(724, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(118, 28)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.chkcontabilizado
        Me.LayoutControlItem19.Location = New System.Drawing.Point(422, 121)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(422, 26)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmdbuscar
        Me.LayoutControlItem25.Location = New System.Drawing.Point(354, 78)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(70, 28)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        Me.LayoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.FechaComprobante
        Me.LayoutControlItem26.Location = New System.Drawing.Point(354, 78)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(291, 28)
        Me.LayoutControlItem26.Text = "Fecha:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(85, 13)
        Me.LayoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtcomprobante
        Me.LayoutControlItem27.Location = New System.Drawing.Point(354, 78)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(546, 28)
        Me.LayoutControlItem27.Text = "No Comprobante:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(85, 13)
        Me.LayoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chknoiva
        Me.LayoutControlItem7.Location = New System.Drawing.Point(753, 26)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(148, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(148, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(148, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.chkAplicar
        Me.LayoutControlItem20.Location = New System.Drawing.Point(550, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(351, 26)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        Me.LayoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chksaldo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(753, 24)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(148, 28)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(148, 28)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(148, 54)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem28, Me.LayoutControlItem35, Me.LayoutControlItem36, Me.LayoutControlItem41})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(945, 588)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.LayoutControlGroup2.ExpandButtonVisible = True
        Me.LayoutControlGroup2.ExpandOnDoubleClick = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(925, 123)
        Me.LayoutControlGroup2.Text = "DATOS DEL CLIENTE"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbClientes
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(901, 24)
        Me.LayoutControlItem1.Text = "Cliente:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FechaCobro
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(283, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(283, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(283, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbserie
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(283, 28)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(283, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(283, 28)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Serie:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtrecibo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(283, 50)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(284, 28)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "No. Recibo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chknoir
        Me.LayoutControlItem5.Location = New System.Drawing.Point(586, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(141, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(141, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(141, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chknoiralcaldia
        Me.LayoutControlItem6.Location = New System.Drawing.Point(727, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(727, 50)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(174, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(283, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(303, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(567, 50)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(160, 28)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.LayoutControlGroup3.ExpandButtonVisible = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem14, Me.LayoutControlItem17, Me.LayoutControlItem15, Me.SimpleSeparator1, Me.lyTotal, Me.LayoutControlItem38, Me.LayoutControlItem23, Me.EmptySpaceItem2, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.lyMonto, Me.LayoutControlItem24, Me.LayoutControlItem39, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.LayoutControlItem13, Me.LayoutControlItem37, Me.LayoutControlItem40})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 123)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(925, 211)
        Me.LayoutControlGroup3.Text = "FORMA DE PAGO"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdcheques
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtcheques
        Me.LayoutControlItem14.Location = New System.Drawing.Point(150, 76)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdtarjetas
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txttarjetas
        Me.LayoutControlItem15.Location = New System.Drawing.Point(150, 102)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(191, 26)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 128)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(341, 1)
        '
        'lyTotal
        '
        Me.lyTotal.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyTotal.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.lyTotal.AppearanceItemCaption.Options.UseFont = True
        Me.lyTotal.AppearanceItemCaption.Options.UseForeColor = True
        Me.lyTotal.Control = Me.txttotal
        Me.lyTotal.Location = New System.Drawing.Point(0, 129)
        Me.lyTotal.MaxSize = New System.Drawing.Size(341, 26)
        Me.lyTotal.MinSize = New System.Drawing.Size(341, 26)
        Me.lyTotal.Name = "lyTotal"
        Me.lyTotal.Size = New System.Drawing.Size(341, 37)
        Me.lyTotal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyTotal.Text = "TOTAL:"
        Me.lyTotal.TextSize = New System.Drawing.Size(151, 16)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.lblMontoLetras
        Me.LayoutControlItem38.Location = New System.Drawing.Point(351, 140)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(420, 26)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmbmoneda
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(341, 24)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(341, 24)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(341, 24)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.Text = "Moneda de Pago:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(151, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(341, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(10, 156)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(10, 156)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 166)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtRecibimos
        Me.LayoutControlItem21.Location = New System.Drawing.Point(351, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(550, 26)
        Me.LayoutControlItem21.Text = "Recibimos de:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtPorCuenta
        Me.LayoutControlItem22.Location = New System.Drawing.Point(351, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(550, 26)
        Me.LayoutControlItem22.Text = "Por Cuenta de:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(151, 13)
        '
        'lyMonto
        '
        Me.lyMonto.Control = Me.txtefectivo
        Me.lyMonto.Location = New System.Drawing.Point(0, 24)
        Me.lyMonto.MaxSize = New System.Drawing.Size(341, 26)
        Me.lyMonto.MinSize = New System.Drawing.Size(341, 26)
        Me.lyMonto.Name = "lyMonto"
        Me.lyMonto.Size = New System.Drawing.Size(341, 26)
        Me.lyMonto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyMonto.Text = "Total Abono:"
        Me.lyMonto.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtTasa
        Me.LayoutControlItem24.Location = New System.Drawing.Point(649, 78)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.Text = "T/C Oficial:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtTasaParalela
        Me.LayoutControlItem39.Location = New System.Drawing.Point(649, 104)
        Me.LayoutControlItem39.MaxSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem39.MinSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem39.Text = "T/C Paralelo:"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(151, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(351, 78)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(298, 52)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(351, 130)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(550, 10)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtEquivalente
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(341, 26)
        Me.LayoutControlItem13.Text = "Equivale a:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(151, 13)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem37.AppearanceItemCaption.ForeColor = System.Drawing.Color.Navy
        Me.LayoutControlItem37.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem37.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem37.Control = Me.cbCatalogo
        Me.LayoutControlItem37.Location = New System.Drawing.Point(351, 52)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(550, 26)
        Me.LayoutControlItem37.Text = "Cuenta Interés:"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(151, 14)
        Me.LayoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.chkInteres
        Me.LayoutControlItem40.Location = New System.Drawing.Point(771, 140)
        Me.LayoutControlItem40.MaxSize = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem40.MinSize = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.iGrid
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 334)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(925, 210)
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.chkselector
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 544)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(499, 24)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem36.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem36.Control = Me.etMntto
        Me.LayoutControlItem36.Location = New System.Drawing.Point(712, 544)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem36.Text = "Mantenimiento de Valor:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(151, 14)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem41.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem41.Control = Me.lblInteres
        Me.LayoutControlItem41.Location = New System.Drawing.Point(499, 544)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(213, 24)
        Me.LayoutControlItem41.Text = "Intereses:"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(151, 14)
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 471)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(109, 36)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 4
        Me.cmdAyuda.Text = "E&xportar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.cmdRecibos)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdVerPagos)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(133, 559)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 431)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "&Limpiar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 511)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(109, 36)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdRecibos
        '
        Me.cmdRecibos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecibos.Appearance.Options.UseFont = True
        Me.cmdRecibos.Enabled = False
        Me.cmdRecibos.ImageOptions.Image = CType(resources.GetObject("cmdRecibos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdRecibos.Location = New System.Drawing.Point(12, 92)
        Me.cmdRecibos.Name = "cmdRecibos"
        Me.cmdRecibos.Size = New System.Drawing.Size(109, 36)
        Me.cmdRecibos.StyleController = Me.LayoutControl2
        Me.cmdRecibos.TabIndex = 3
        Me.cmdRecibos.Text = "&Recibos"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 132)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(109, 22)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 1
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(109, 36)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdVerPagos
        '
        Me.cmdVerPagos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerPagos.Appearance.Options.UseFont = True
        Me.cmdVerPagos.Enabled = False
        Me.cmdVerPagos.ImageOptions.Image = CType(resources.GetObject("cmdVerPagos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVerPagos.Location = New System.Drawing.Point(12, 52)
        Me.cmdVerPagos.Name = "cmdVerPagos"
        Me.cmdVerPagos.Size = New System.Drawing.Size(109, 36)
        Me.cmdVerPagos.StyleController = Me.LayoutControl2
        Me.cmdVerPagos.TabIndex = 2
        Me.cmdVerPagos.Text = "Ver &Pagos"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.EmptySpaceItem1, Me.LayoutControlItem18})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(133, 559)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cmdAceptar
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.cmdVerPagos
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.cmdRecibos
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.cmdImprimir
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(113, 26)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        Me.LayoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cmdAyuda
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 459)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.cmdCancelar
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 499)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 146)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(113, 273)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.SimpleButton1
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 419)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("8305e3cb-dfde-49aa-b378-1ee0d6a7a65b")
        Me.DockPanel1.Location = New System.Drawing.Point(945, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 588)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 559)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmCobrosNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1085, 588)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmCobrosNew"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcomprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquivalente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasaParalela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaComprobante.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecibimos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnocliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcontabilizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chksaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtefectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chknoiralcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chknoiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbserie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chknoir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaCobro.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaCobro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttarjetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcheques.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Private Config As New VB.SysContab.ConfiguracionDB,
            Empresa As New VB.SysContab.EmpresasDB,
            ConfigDetalles As New VB.SysContab.ConfiguracionDetails,
            EmpresaDetalle As New VB.SysContab.EmpresasDetails,
            TC As New db_TasaCambio

    Private Temp As Boolean = False,
            temp2 As Boolean = False

    Private Periodo As Integer = 0,
            Transaccion As String = 1

    Dim TCambio As Double = 1,
        TC_Paralelo As Double = 1

    Private DT_Distribucion As DataTable = New DataTable("Distribucion"),
            _DT_Facturas As DataTable = New DataTable("FacturasPendientes"),
            _DT_Last As DataTable = New DataTable("FacturasSeleccionadas"),
            db As New db_FacturasCuotas

    'Private Sub Distribucion()
    '    DT_Distribucion = CargaDistribucion(0, 0, 0)
    'End Sub
#End Region

    Private Sub FrmCobrosNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        RolesDB.UsuarioAcciones(LayoutControl2)
        ''
        Dim Clientes As New VB.SysContab.ClientesDB
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        '                
        SearchLookUp(
            cbCatalogo,
            ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual),
            "Display",
            "Cuenta", 2)

        DT_Distribucion = CargaDistribucion()
        Cargar()
        lyMonto.Text = "Total Abono en " & cmbmoneda.GetColumnValue("Simbolo").ToString & " :"
        lyTotal.Text = "TOTAL EN " & cmbmoneda.GetColumnValue("Simbolo").ToString & " :"

        'Validar si la empresa esta configurada para editar el Cobro.
        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        iVista.Columns("Cobro").OptionsColumn.AllowEdit = EmpresaDetalle.CobrosEditable
        iVista.Columns("CobroU").OptionsColumn.AllowEdit = EmpresaDetalle.CobrosEditable
    End Sub

    Sub Cargar()
        LoadClients()
        'GetClientesList(cmbclientes)
        GetMonedasList(cmbmoneda)
        'GetRecibo()        
        FechaCobro.DateTime = Now.Date
        '
        CargaSeries()
        txtrecibo.Text = cmbserie.EditValue 'Format(cmbserie.EditValue, dd)
        '
        '**** Cargar Tasa de Cambio        
        'TCambio = GetTasaCambioDia(FechaCobro.DateTime.Date)

        TC.GetTasaCambio(MonedaBase, FechaCobro.DateTime.Date)
        TCambio = TC.TC_Oficial
        TC_Paralelo = TC.TC_Paralelo

        txtTasa.EditValue = TCambio
        txtTasaParalela.EditValue = TC_Paralelo
    End Sub

    Private Sub LoadClients()

        Dim DT_CLIENTE As DataTable =
            ObtieneDatos("_ClientesGetList", EmpresaActual, 1)

        SearchLookUp(
            cbClientes,
            DT_CLIENTE,
            "Nombre",
            "Codigo",
            4, 5, 6, 7, 8)

        'GetClientesList(cmbclientes)
        'GetCatalogoClientes(cbClientes, vista)

        'cmbclientes.Properties.Columns(0).Visible = True : cmbclientes.Properties.ShowHeader = True 'Para radioshack
        'cmbclientes.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
    End Sub

    Private Sub CargaSeries()
        LookUp(
            cmbserie,
            ObtieneDatos("sp_sel_SeriesRecibos", txtCaja.Text, EmpresaActual),
            "Serie",
            "Recibo",
            "",
            0, 2)
        cmbserie.ItemIndex = 0

        'cmbserie.Properties.DataSource = ObtieneDatos("SELECT sr.IdDetalle, sr.Serie, sr.Recibo FROM SeriesRecibos sr WHERE sr.Codigo = '" & Me.txtCaja.Text & "' AND sr.Empresa = " & EmpresaActual)
        'cmbserie.Properties.ValueMember = "Recibo"
        'cmbserie.Properties.DisplayMember = "Serie"
        'cmbserie.Properties.PopulateColumns()
        'cmbserie.Properties.Columns("IdDetalle").Visible = False
        'cmbserie.Properties.Columns("Recibo").Visible = False
        'cmbserie.ItemIndex = 0
    End Sub

    Private Sub GetRecibo()
        Dim Clientes As New VB.SysContab.ClientesDB
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        'For d As Integer = 0 To ConfigDetalles.ReciboDigitos - 1
        '    dd = dd & "0"
        'Next

        If Clientes.GenerarRecibo.Tables("Cobros").Rows.Count = 0 Then
            txtrecibo.Text = ConfigDetalles.ReciboNumero   'Format(ConfigDetalles.ReciboNumero, dd)
        Else
            txtrecibo.Text = Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1 'Format(Clientes.GenerarRecibo.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        DT_Cheques = Nothing
        DT_Tarjetas = Nothing
        Close()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/ClientesCobroVentas.chm")
        frmExportarImprimir.
            Mostrar(
            iGrid,
            Me.Text,
            $"Cliente: {cbClientes.Text}")
    End Sub

    Private Sub cmdRecibos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecibos.Click

        Dim f As frmRecibos = frmRecibos.Instance()
        Recurso = ObtieneDatos("SELECT rr.ID FROM REST_Recursos rr WHERE rr.Control = 'etRecibos'").Rows.Item(0)(0)
        f.etInicio.Text = "1"
        f.Cliente = ""
        f.Recibo = ""
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdVerPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerPagos.Click

        If iVista.DataRowCount = 0 Then
            MsgBox("No hay facturas pendientes para este cliente", MsgBoxStyle.Information)
            Exit Sub
        End If

        Registro = iVista.GetFocusedRowCellValue("No Factura")
        Dim Clientes As New VB.SysContab.ClientesDB
        If Clientes.CobrosHistorial(Registro).Tables("Cobros").Rows.Count = 0 Then
            MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
            Exit Sub
        End If
        Clientes = Nothing
        Dim f As frmHistorialCobros = f.Instance

        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesCobros = frmReportesCobros.Instance()

        f.MdiParent = Me.MdiParent
        f.Show()

        f.cbClientes.SelectedValue = 0
        f.cbFacturas.SelectedValue = -1
    End Sub

    Private Sub chkcontabilizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcontabilizado.CheckedChanged
        'If sender.checked Then
        '    GrpContabilizado.Enabled = True
        'Else
        '    GrpContabilizado.Enabled = False
        'End If

        Me.txtcomprobante.Properties.ReadOnly = Not Me.chkcontabilizado.Checked
        Me.FechaComprobante.Properties.ReadOnly = Not Me.chkcontabilizado.Checked
        Me.cmdbuscar.Enabled = Me.chkcontabilizado.Checked
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        Dim dm As New db_DeslizamientoMoneda

        If e.Column.FieldName = "Facturar" And Not Temp Then

            iVista.SetRowCellValue(e.RowHandle, "Cobro", 0)

            ''GridView1.Columns("Facturar").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            'Distribuir()
            'If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()

            Dim Total As Double = 0.00,
                Equivalente As Double = 0.00,
                TotalCobro As Double = 0.00,
                TotalMtto As Double = 0.00,
                TotalInteres As Double = 0.00,
                Marcadas As Integer = 0

            With iVista
                '     If cmbmoneda.EditValue = MonedaBase Then DistribuirIndividualC(e) Else DistribuirIndividualUSD(e)                
                'DistribuirIndividual(e)                

                If CBool(.GetRowCellValue(e.RowHandle, "Facturar")) Then
                    Temp = True

                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
                    .SetRowCellValue(e.RowHandle, "Interes", 0.00)
                    '
                    _DT_Facturas.AcceptChanges()
                    Marcadas = _DT_Facturas.Select("Facturar = 1").Length

                    If Marcadas > 0 Then
                        Dim _DT_Total As DataTable =
                            _DT_Facturas.Select("Facturar = 1").CopyToDataTable()

                        TotalCobro = CDbl(_DT_Total.Compute("SUM(Cobro)", "Facturar = 1"))
                        TotalMtto = CDbl(_DT_Total.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1"))
                        TotalInteres = CDbl(_DT_Total.Compute("SUM(Interes)", "Facturar = 1"))

                        With _DT_Total

                            For i As Integer = 0 To .Rows.Count - 1
                                If Not cmbmoneda.EditValue.Equals(MonedaBase) Then
                                    Equivalente += CDbl(.Rows.Item(i)("Cobro") + .Rows.Item(i)("Monto_Mantenimiento") + .Rows.Item(i)("Interes")) /
                                        IIf(CBool(.Rows.Item(i)("TC_Paralelo")), txtTasaParalela.EditValue, txtTasa.EditValue)
                                Else
                                    Equivalente += CDbl(.Rows.Item(i)("Cobro") +
                                        .Rows.Item(i)("Monto_Mantenimiento") +
                                        .Rows.Item(i)("Interes"))
                                End If
                            Next

                        End With
                    End If
                    '                    
                    Dim TC As Double = IIf(cmbmoneda.EditValue = MonedaBase,
                                       1.0,
                                       IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))

                    Total = Math.Round(((txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue) - Equivalente) * TC, 2)

                    '
                    If (Total = 0.01 Or Total = -0.01) Then Total = 0.00

                    If Math.Round(Total, 2) = 0.00 Then
                        .SetRowCellValue(e.RowHandle, "Facturar", False)
                        Temp = False
                        Exit Sub
                    End If
                    '
                    If Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")), 2) >= Math.Round(Total, 2) Then
                        'En este caso, es un abono a la factura.
                        'Calcular el Deslizamiento por el Abono
                        dm.CalcularDeslizamiento(CDbl(Total / IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)),
                                             .GetRowCellValue(e.RowHandle, "TC"),
                                             IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)

                        'Calcular el interes sobre el saldo vencido.
                        If chkInteres.Checked Then
                            dm.CalcularInteres(
                                Total,
                                .GetRowCellValue(e.RowHandle, "No Factura"),
                                FechaCobro.DateTime.Date)

                            If dm.Interes > 0 Then
                                .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
                                Total = Total - dm.Interes
                            End If
                        End If
                        '
                        If dm.Mantenimiento_Valor <> 0 Then
                            .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                            Total = Total - dm.Mantenimiento_Valor
                        End If

                        'If Total <= dm.Mantenimiento_Valor Then
                        '    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", Math.Round(Total, 2))
                        '    ' Mnto = Mnto + Total
                        '    Total = 0.00
                        'Else
                        '    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        '    'Mnto = Mnto + dm.Mantenimiento_Valor
                        '    Total = Total - dm.Mantenimiento_Valor
                        '    '
                        '    If chkInteres.Checked Then
                        '        If Total <= dm.Interes Then
                        '            .SetRowCellValue(e.RowHandle, "Interes", Math.Round(Total, 2))
                        '            Total = 0.00
                        '        Else
                        '            .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
                        '            Total = Total - dm.Interes
                        '        End If
                        '    End If
                        'End If
                        '
                        If Total > 0 Then
                            .SetRowCellValue(
                                e.RowHandle,
                                "Cobro",
                                Math.Round(Total, 2))
                            '
                            .SetRowCellValue(
                                e.RowHandle,
                                "CobroU",
                                Math.Round(Total / .GetRowCellValue(e.RowHandle, "TCambio"), 2))
                            '
                            .SetRowCellValue(
                                e.RowHandle,
                                "Saldo",
                                Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) - Total, 2))
                        End If
                        '
                        Temp = False
                    Else
                        'Verificar si el Monto pagado alcanza para el saldo y los intereses.
                        'Calcular el Deslizamiento por el Abono
                        dm.CalcularDeslizamiento(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo") / .GetRowCellValue(e.RowHandle, "TC")),
                                                 .GetRowCellValue(e.RowHandle, "TC"),
                                                 IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                        'Calcular el interes sobre el saldo vencido.
                        If chkInteres.Checked Then
                            dm.CalcularInteres(
                                CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")),
                                .GetRowCellValue(e.RowHandle, "No Factura"),
                                FechaCobro.DateTime.Date)
                        End If
                        '
                        'Validar si el total alcanza para abonar al saldo, Mantenimiento e Intereses
                        If Math.Round(Total, 2) >= Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) +
                                    dm.Mantenimiento_Valor + dm.Interes, 2) Then

                            If dm.Mantenimiento_Valor <> 0 Then
                                .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                            End If

                            If dm.Interes > 0 Then
                                .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
                            End If

                            'Temp = False

                            .SetRowCellValue(
                                e.RowHandle,
                                "Cobro",
                                CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))

                            'Temp = True

                            .SetRowCellValue(
                                e.RowHandle,
                                "CobroU",
                                CDbl(.GetRowCellValue(e.RowHandle, "SaldoU")))

                            .SetRowCellValue(
                                e.RowHandle,
                                "Saldo",
                                0.00)
                            '
                            Temp = False
                            Total = Total - dm.Mantenimiento_Valor - dm.Interes
                        Else
                            If dm.Mantenimiento_Valor <> 0 Then
                                .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                                Total = Total - dm.Mantenimiento_Valor
                            End If
                            '
                            If dm.Interes > 0 Then
                                .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
                                Total = Total - dm.Interes
                            End If

                            'If Total <= dm.Interes Then
                            '    .SetRowCellValue(e.RowHandle, "Interes", Total)
                            '    Total = 0
                            'Else
                            '    .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
                            '    Total = Total - dm.Interes
                            'End If
                            '

                            .SetRowCellValue(
                                e.RowHandle,
                                "Cobro",
                                Math.Round(Total, 2))
                            '
                            .SetRowCellValue(
                                e.RowHandle,
                                "CobroU",
                                Math.Round(Total / .GetRowCellValue(e.RowHandle, "TCambio"), 2))
                            '
                            .SetRowCellValue(
                                e.RowHandle,
                                "Saldo",
                                Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) - Total, 2))

                            Temp = False
                        End If
                    End If
                    '
                    _DT_Facturas.AcceptChanges()
                    Dim _CobroUSD As DataTable = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()
                    Dim TotalCobroUSD As Double = CDbl(_CobroUSD.Compute("SUM(CobroU)", "Facturar = 1"))
                    '
                    If Not cmbmoneda.EditValue = MonedaBase Then

                        If TotalCobroUSD > (txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue) Then
                            Temp = True
                            .SetRowCellValue(e.RowHandle, "Cobro",
                                             Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "Cobro") - ((TotalCobroUSD - (txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue)) * txtTasa.EditValue)), 2))
                            .SetRowCellValue(e.RowHandle, "CobroU",
                                             Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "CobroU") - (TotalCobroUSD - (txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue))), 2))
                            .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento",
                                             Math.Round((TotalCobroUSD - (txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue)) * txtTasa.EditValue, 2))
                            .SetRowCellValue(e.RowHandle, "Saldo",
                                             Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo") - .GetRowCellValue(e.RowHandle, "Cobro")), 2))
                            Temp = False
                        End If

                    End If
                    '
                    EquivlentePago()
                Else
                    Temp = True
                    '
                    .SetRowCellValue(e.RowHandle, "Cobro", 0.00)
                    .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
                    .SetRowCellValue(e.RowHandle, "Saldo", CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))
                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
                    .SetRowCellValue(e.RowHandle, "Interes", 0.00)
                    '
                    EquivlentePago()
                    Temp = False
                End If


                'IR Alcaldia
                If chknoiralcaldia.Checked Then
                    .SetRowCellValue(e.RowHandle, "IrAlcaldia", 0.00)
                Else
                    If CDbl(.GetRowCellValue(e.RowHandle, "Cobro")) >=
                        VB.SysContab.MunicipiosDB.GetDetails(
                        VB.SysContab.ClientesDB.GetDetails(
                        cbClientes.EditValue).
                        Departamento,
                        VB.SysContab.ClientesDB.GetDetails(
                        cbClientes.EditValue).Municipio).
                        Impuesto_SVenta_Min Then

                        .SetRowCellValue(e.RowHandle, "IrAlcaldia", Math.Round((CDbl(.GetRowCellValue(e.RowHandle, "Cobro")) /
                                         IIf(CDbl(.GetRowCellValue(e.RowHandle, "IVA")) > 0.00, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) *
                                         (VB.SysContab.MunicipiosDB.GetDetails(
                                         VB.SysContab.ClientesDB.GetDetails(
                                         cbClientes.EditValue).Departamento,
                                         VB.SysContab.ClientesDB.GetDetails(
                                         cbClientes.EditValue).Municipio).
                                         Impuesto_SVenta / 100.0), 2))
                    End If
                End If

                'IR a la Fuente
                If chknoir.Checked Then
                    .SetRowCellValue(e.RowHandle, "IrParcial", 0.00)
                Else
                    If CDbl(.GetRowCellValue(e.RowHandle, "Cobro")) >= ConfigDetalles.MontoIR Then
                        .SetRowCellValue(e.RowHandle, "IrParcial", Math.Round((CDbl(.GetRowCellValue(e.RowHandle, "Cobro")) /
                                         IIf(.GetRowCellValue(e.RowHandle, "IVA") > 0.00,
                                             IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) *
                                             (ConfigDetalles.IRProd / 100), 2))
                    Else
                        .SetRowCellValue(e.RowHandle, "IrParcial", 0.00)
                    End If
                End If
                '
                _DT_Facturas.AcceptChanges()

                If _DT_Facturas.Select("Facturar = 1").Length > 0 Then
                    _DT_Last = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()
                    '
                    etMntto.Text = CDbl(_DT_Facturas.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1")).ToString("n2")
                    lblInteres.Text = CDbl(_DT_Facturas.Compute("SUM(Interes)", "Facturar = 1")).ToString("n2")
                Else
                    etMntto.Text = "0.00"
                    lblInteres.Text = "0.00"
                End If

            End With
            '
            If cmbmoneda.EditValue = MonedaBase Then
                txttotal.EditValue = txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue
            Else
                txttotal.EditValue = txtEquivalente.EditValue
            End If
        End If
        '
        If e.Column.FieldName = "Monto_Mantenimiento" And Not Temp Then

            With iVista

                If CBool(.GetRowCellValue(e.RowHandle, "Facturar")) Then
                    'Aca obtenemos el valor de Mantenimiento antes de ser cambiado manualmente
                    Dim _DT As DataTable =
                        _DT_Last.Select("[No Factura] = '" & .GetRowCellValue(e.RowHandle, "No Factura") & "'").CopyToDataTable()

                    'Obtener la diferencia entre Mantenimiento Anterior y el nuevo valor digitado
                    Dim DifMtto As Double = CDbl(_DT.Rows.Item(0)("Monto_Mantenimiento")) - CDbl(e.Value)

                    'Obtener el valor del cobro
                    Dim Valor As Double = Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "Cobro")) + DifMtto, 2)

                    If Math.Round(CDbl(_DT.Rows.Item(0)("Saldo")), 2) <> 0 Then

                        'Calcular el saldo que nos va quedar y validar.
                        Dim Saldo As Double = Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) - Valor, 2)

                        'Si el saldo es negativo, significa que el mantenimiento se debe aplicar a otra factura.
                        If Saldo < 0.00 Then
                            Temp = True

                            .SetRowCellValue(e.RowHandle, "Cobro", CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))
                            .SetRowCellValue(e.RowHandle, "CobroU", CDbl(.GetRowCellValue(e.RowHandle, "SaldoU")))
                            .SetRowCellValue(e.RowHandle, "Saldo", 0.00)

                            Temp = False
                        Else
                            Temp = True

                            .SetRowCellValue(e.RowHandle, "Cobro", Valor)
                            .SetRowCellValue(e.RowHandle, "CobroU", Math.Round(Valor / CDbl(.GetRowCellValue(e.RowHandle, "TCambio")), 2))
                            .SetRowCellValue(e.RowHandle, "Saldo", Saldo)

                            Temp = False
                        End If
                    End If
                Else
                    Temp = True
                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
                    .SetRowCellValue(e.RowHandle, "Cobro", 0.00)
                    .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
                    .SetRowCellValue(e.RowHandle, "Saldo", CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))
                    Temp = False
                End If
                '
                _DT_Facturas.AcceptChanges()

                If _DT_Facturas.Select("Facturar = 1").Length > 0 Then
                    _DT_Last = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()
                    etMntto.Text = CDbl(_DT_Facturas.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1")).ToString("n2")
                Else
                    etMntto.Text = "0.00"
                End If
                '
                EquivlentePago()
                '
                If cmbmoneda.EditValue = MonedaBase Then
                    txttotal.EditValue = txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue
                Else
                    txttotal.EditValue = txtEquivalente.EditValue
                End If
            End With
        End If
        '
        If (e.Column.FieldName = "Cobro" Or e.Column.FieldName = "CobroU") And Not Temp Then

            With iVista

                If CBool(.GetRowCellValue(e.RowHandle, "Facturar")) Then
                    Temp = True
                    '
                    'Obtener el Registro antes de cambiarlo.
                    Dim CobroAnterior As Double = 0.00,
                        CobroAnteriorU As Double = 0.00,
                        Valor As Double = 0.00,
                        OtroSaldo As Double = 0.00,
                        Msg As String = String.Empty

                    If _DT_Last.Rows.Count > 0 Then
                        If _DT_Last.Select("[No Factura] = '" & .GetRowCellValue(e.RowHandle, "No Factura") & "'").Length > 0 Then
                            Dim _dt As DataTable =
                                _DT_Last.Select("[No Factura] = '" & .GetRowCellValue(e.RowHandle, "No Factura") & "'").CopyToDataTable()

                            CobroAnterior = CDbl(_dt.Rows.Item(0)("Cobro"))
                            CobroAnteriorU = CDbl(_dt.Rows.Item(0)("CobroU"))
                        End If
                    End If
                    '
                    If e.Column.FieldName = "Cobro" Then
                        Valor = CDbl(e.Value)
                        OtroSaldo = CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo"))
                        '
                        Msg = $"El cobro actual {Valor.ToString("n2")} debe ser menor o igual al saldo {OtroSaldo.ToString("n2")} de esta factura: { .GetRowCellValue(e.RowHandle, "No Factura")}"
                    ElseIf e.Column.FieldName = "CobroU" Then
                        'Valor = CDbl(e.Value) * IIf(CDbl(.GetRowCellValue(e.RowHandle, "Monto_Mantenimiento") = 0.00),
                        '                            IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue),
                        '                            CDbl(.GetRowCellValue(e.RowHandle, "TCambio")))

                        Valor = CDbl(e.Value) * CDbl(.GetRowCellValue(e.RowHandle, "TCambio"))
                        OtroSaldo = CDbl(.GetRowCellValue(e.RowHandle, "SaldoU"))
                        '
                        Msg = $"El cobro actual {CDbl(e.Value).ToString("n2")} debe ser menor o igual al saldo {OtroSaldo.ToString("n2")} de esta factura: { .GetRowCellValue(e.RowHandle, "No Factura")}"
                    End If

                    Dim Saldo As Double =
                        Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) - Valor, 2)

                    'Math.Round((CDbl(.GetRowCellValue(e.RowHandle, "Total")) -
                    '                    CDbl(.GetRowCellValue(e.RowHandle, "Abono"))) - CDbl(e.Value), 2)

                    If (Saldo = -0.01 Or Saldo = 0.01) Then Saldo = 0.00
                    'Math.Round((CDbl(.GetRowCellValue(e.RowHandle, "Total")) -
                    '                    CDbl(.GetRowCellValue(e.RowHandle, "Abono"))), 2)
                    'Dim SaldoActual As Double = CDbl(.GetRowCellValue(e.RowHandle, "Saldo"))

                    If Saldo < 0.00 Then

                        XtraMsg(Msg, MessageBoxIcon.Error)

                        'If e.Column.FieldName = "Cobro" Then
                        '    XtraMsg($"El cobro actual {Valor.ToString("n2")} debe ser menor o igual al saldo {OtroSaldo.ToString("n2")} de esta factura: { .GetRowCellValue(e.RowHandle, "No Factura")}", MessageBoxIcon.Error)
                        'ElseIf e.Column.FieldName = "CobroU" Then
                        '    XtraMsg($"El cobro actual {Valor.ToString("n2")} debe ser menor o igual al saldo {OtroSaldo.ToString("n2")} de esta factura: { .GetRowCellValue(e.RowHandle, "No Factura")}", MessageBoxIcon.Error)
                        'End If


                        .SetRowCellValue(e.RowHandle, "Cobro", CobroAnterior)
                        .SetRowCellValue(e.RowHandle, "CobroU", CobroAnteriorU)
                        '
                        .SetRowCellValue(e.RowHandle, "Saldo", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) -
                                          CobroAnterior, 2))
                    Else
                        If e.Column.FieldName = "Cobro" Then
                            'Dim tc As Double = CDbl(.GetRowCellValue(e.RowHandle, "TCambio"))

                            '.SetRowCellValue(e.RowHandle, "CobroU", Math.Round(Valor /
                            '                        IIf(CDbl(.GetRowCellValue(e.RowHandle, "Monto_Mantenimiento") = 0.00),
                            '                        IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue),
                            '                        CDbl(.GetRowCellValue(e.RowHandle, "TCambio"))), 2))

                            .SetRowCellValue(e.RowHandle, "CobroU", Math.Round(Valor /
                                                   CDbl(.GetRowCellValue(e.RowHandle, "TCambio")), 2))

                        ElseIf e.Column.FieldName = "CobroU" Then
                            .SetRowCellValue(e.RowHandle, "Cobro", Math.Round(Valor, 2))
                        End If

                        .SetRowCellValue(
                            e.RowHandle,
                            "Saldo",
                            Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) - Valor, 2))
                    End If
                    '
                    'If e.Value = 0.00 Then .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
                    Temp = False
                Else
                    Temp = True
                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
                    .SetRowCellValue(e.RowHandle, "Cobro", 0.00)
                    .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
                    '
                    .SetRowCellValue(
                            e.RowHandle,
                            "Saldo",
                            CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))
                    Temp = False
                End If
                '
                EquivlentePago()
                '
                If cmbmoneda.EditValue = MonedaBase Then
                    txttotal.EditValue = txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue
                Else
                    txttotal.EditValue = txtEquivalente.EditValue
                End If
            End With
            Temp = False
        End If

        'If e.Column.FieldName = "CobroU" And Not Temp Then
        '    With vDatos
        '        If CBool(.GetRowCellValue(e.RowHandle, "Facturar")) Then
        '            Temp = True

        '            Temp = False
        '        Else
        '            Temp = True
        '            .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
        '            Temp = False
        '        End If
        '    End With
        'End If

        'If e.Column.FieldName = "Monto_Mantenimiento" And Not Temp Then
        '    ''GridView1.SetRowCellValue(e.RowHandle, "Cobro", 0)
        '    'Distribuir()
        '    temp2 = True
        '    If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        '    temp2 = False

        '    'If vDatos.GetRowCellValue(e.RowHandle, "Facturar") Then

        '    '    If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        '    '    'If CDbl(vDatos.GetRowCellValue(e.RowHandle, "Saldo") - vDatos.GetRowCellValue(e.RowHandle, "Cobro")) > Math.Abs(CDbl(e.Value)) Then
        '    '    '    vDatos.SetRowCellValue(e.RowHandle, "Cobro", Math.Round(CDbl(vDatos.GetRowCellValue(e.RowHandle, "Cobro") - e.Value), 2))
        '    '    'End If
        '    'Else
        '    '    Temp = True
        '    '    vDatos.SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
        '    '    Temp = False
        '    'End If
        '    '
        '    'etMntto.Text = SumarDeslizamiento.ToString("n2")
        'End If

        'If e.Column.FieldName = "Facturar" Then
        '    vDatos.SetRowCellValue(e.RowHandle, "Cobro", 0)
        '    ''GridView1.Columns("Facturar").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        '    Distribuir()
        'End If
        ' ''
        'If e.Column.FieldName = "Monto_Mantenimiento" Then
        '    If Not IsNumeric(e.Value) Then
        '        Me.vDatos.SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.0)
        '    Else
        '        ''GridView1.SetRowCellValue(e.RowHandle, "Cobro", 0)
        '        Distribuir()
        '    End If
        'End If

        'If e.Column.FieldName = "Cobro" Then
        '    vDatos.SetRowCellValue(e.RowHandle, "Saldo", vDatos.GetRowCellValue(e.RowHandle, "Total") - _
        '                              vDatos.GetRowCellValue(e.RowHandle, "Abono") - _
        '                              vDatos.GetRowCellValue(e.RowHandle, "Cobro"))
        'End If
    End Sub


    'Sub DistribuirIndividual(ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)

    '    Dim Total As Double = 0.00,
    '        TotalCobro As Double = 0.00,
    '        TotalMtto As Double = 0.00,
    '        TotalInteres As Double = 0.00,
    '        Marcadas As Integer = 0

    '    Dim dm As New db_DeslizamientoMoneda

    '    With iVista

    '        If CBool(.GetRowCellValue(e.RowHandle, "Facturar")) Then
    '            Temp = True
    '            .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
    '            .SetRowCellValue(e.RowHandle, "Interes", 0.00)
    '            '
    '            _DT_Facturas.AcceptChanges()
    '            Marcadas = _DT_Facturas.Select("Facturar = 1").Length

    '            If Marcadas > 0 Then
    '                Dim _DT_Total As DataTable =
    '                        _DT_Facturas.Select("Facturar = 1").CopyToDataTable()

    '                TotalCobro = CDbl(_DT_Total.Compute("SUM(Cobro)", "Facturar = 1"))
    '                TotalMtto = CDbl(_DT_Total.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1"))
    '                TotalInteres = CDbl(_DT_Total.Compute("SUM(Interes)", "Facturar = 1"))
    '            End If
    '            '
    '            Dim TC As Double = IIf(cmbmoneda.EditValue = MonedaBase,
    '                                   1.0,
    '                                   IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))

    '            Total = Math.Round(((txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue) * TC) -
    '                (TotalCobro + TotalMtto + TotalInteres), 2)
    '            '
    '            If (Total = 0.01 Or Total = -0.01) Then Total = 0.00

    '            If Math.Round(Total, 2) = 0.00 Then
    '                .SetRowCellValue(e.RowHandle, "Facturar", False)
    '                Temp = False
    '                Exit Sub
    '            End If
    '            '
    '            If Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")), 2) >= Math.Round(Total, 2) Then
    '                'En este caso, es un abono a la factura.
    '                'Calcular el Deslizamiento por el Abono
    '                dm.CalcularDeslizamiento(CDbl(Total / IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)),
    '                                         .GetRowCellValue(e.RowHandle, "TC"),
    '                                         IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue),
    '                                         1)
    '                'Calcular el interes sobre el saldo vencido.
    '                If chkInteres.Checked Then
    '                    dm.CalcularInteres(
    '                        Total,
    '                        .GetRowCellValue(e.RowHandle, "No Factura"),
    '                        FechaCobro.DateTime.Date)
    '                End If
    '                '
    '                If Total <= dm.Mantenimiento_Valor Then
    '                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", Math.Round(Total, 2))
    '                    ' Mnto = Mnto + Total
    '                    Total = 0.00
    '                Else
    '                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
    '                    'Mnto = Mnto + dm.Mantenimiento_Valor
    '                    Total = Total - dm.Mantenimiento_Valor
    '                    '
    '                    If chkInteres.Checked Then
    '                        If Total <= dm.Interes Then
    '                            .SetRowCellValue(e.RowHandle, "Interes", Math.Round(Total, 2))
    '                            Total = 0.00
    '                        Else
    '                            .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
    '                            Total = Total - dm.Interes
    '                        End If
    '                    End If
    '                End If
    '                '
    '                Temp = False
    '                If Total > 0 Then
    '                    .SetRowCellValue(e.RowHandle, "Cobro", Math.Round(Total, 2))
    '                    .SetRowCellValue(e.RowHandle, "CobroU", Math.Round(Total / .GetRowCellValue(e.RowHandle, "TCambio"), 2))
    '                End If
    '            Else
    '                'Verificar si el Monto pagado alcanza para el saldo y los intereses.
    '                'Calcular el Deslizamiento por el Abono
    '                dm.CalcularDeslizamiento(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo") / .GetRowCellValue(e.RowHandle, "TC")),
    '                                             .GetRowCellValue(e.RowHandle, "TC"),
    '                                             IIf(.GetRowCellValue(e.RowHandle, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue),
    '                                             1)
    '                'Calcular el interes sobre el saldo vencido.
    '                If chkInteres.Checked Then
    '                    dm.CalcularInteres(
    '                        CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")),
    '                        .GetRowCellValue(e.RowHandle, "No Factura"),
    '                        FechaCobro.DateTime.Date)
    '                End If
    '                '
    '                'Validar si el total alcanza para abonar al saldo, Mantenimiento e Intereses
    '                If Math.Round(Total, 2) >=
    '                    Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")) +
    '                    dm.Mantenimiento_Valor + dm.Interes, 2) Then

    '                    If dm.Mantenimiento_Valor <> 0 Then .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
    '                    If dm.Interes > 0 Then .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)

    '                    Temp = False
    '                    .SetRowCellValue(
    '                        e.RowHandle,
    '                        "Cobro",
    '                        CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))

    '                    Temp = True
    '                    .SetRowCellValue(
    '                        e.RowHandle,
    '                        "CobroU",
    '                        CDbl(.GetRowCellValue(e.RowHandle, "SaldoU")))
    '                    Temp = False

    '                    Total = Total - dm.Mantenimiento_Valor - dm.Interes
    '                Else

    '                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
    '                    Total = Total - dm.Mantenimiento_Valor
    '                    '
    '                    If Total <= dm.Interes Then
    '                        .SetRowCellValue(e.RowHandle, "Interes", Total)
    '                        Total = 0
    '                    Else
    '                        .SetRowCellValue(e.RowHandle, "Interes", dm.Interes)
    '                        Total = Total - dm.Interes
    '                    End If
    '                    '
    '                    Temp = False
    '                    .SetRowCellValue(e.RowHandle, "Cobro", Math.Round(Total, 2))
    '                    .SetRowCellValue(e.RowHandle, "CobroU", Math.Round(Total / .GetRowCellValue(e.RowHandle, "TCambio"), 2))

    '                End If

    '            End If
    '            '
    '            _DT_Facturas.AcceptChanges()
    '            Dim _CobroUSD As DataTable = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()
    '            Dim TotalCobroUSD As Double = CDbl(_CobroUSD.Compute("SUM(CobroU)", "Facturar = 1"))
    '            '
    '            If Not cmbmoneda.EditValue = MonedaBase Then
    '                If TotalCobroUSD > txtefectivo.EditValue Then
    '                    Temp = True
    '                    .SetRowCellValue(e.RowHandle, "Cobro", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "Cobro") - ((TotalCobroUSD - txtefectivo.EditValue) * txtTasa.EditValue)), 2))
    '                    .SetRowCellValue(e.RowHandle, "CobroU", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "CobroU") - (TotalCobroUSD - txtefectivo.EditValue)), 2))
    '                    .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", Math.Round((TotalCobroUSD - txtefectivo.EditValue) * txtTasa.EditValue, 2))
    '                    .SetRowCellValue(e.RowHandle, "Saldo", Math.Round(CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo") - .GetRowCellValue(e.RowHandle, "Cobro")), 2))
    '                    Temp = False
    '                End If
    '            End If
    '            '
    '            EquivlentePago()
    '        Else
    '            Temp = True
    '            '
    '            .SetRowCellValue(e.RowHandle, "Cobro", 0.00)
    '            .SetRowCellValue(e.RowHandle, "CobroU", 0.00)
    '            .SetRowCellValue(
    '                        e.RowHandle,
    '                        "Saldo",
    '                        CDbl(.GetRowCellValue(e.RowHandle, "OtroSaldo")))
    '            .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
    '            .SetRowCellValue(e.RowHandle, "Interes", 0.00)
    '            '
    '            EquivlentePago()
    '            Temp = False
    '        End If

    '    End With

    'End Sub




    'Function SumarDeslizamiento() As Double
    '    Dim MttoMonto As Double = 0.00

    '    With vDatos
    '        For i As Integer = 0 To .DataRowCount - 1
    '            If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0.00) > 0 Then
    '                MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
    '            End If
    '        Next
    '    End With

    '    Return MttoMonto
    'End Function

    Sub DistribuirPago()

        Dim Total As Double = txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue

        Dim Valor As Double = 0.00,
            Mntto As Double = 0.00,
            Equivalente As Double = 0.00

        Dim dm As New db_DeslizamientoMoneda

        With iVista

            For i As Integer = 0 To .DataRowCount - 1

                If .GetRowCellValue(i, "Facturar") = True Then

                    If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) >= Math.Round(Total, 2) Then
                        'If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo") + .GetRowCellValue(i, "Monto_Mantenimiento")), 2) > Math.Round(Total, 2) Then
                        Temp = True
                        'temp2 valida si el Delizamiento se cambio Manual
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(CDbl(Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)), .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                            '
                            'Calcular el interes sobre el saldo vencido.
                            dm.CalcularInteres(Total, .GetRowCellValue(i, "No Factura"), FechaCobro.DateTime.Date)
                            .SetRowCellValue(i, "Interes", dm.Interes)
                        End If
                        '
                        Valor = Total - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
                        Valor = Total - IIf(temp2, .GetRowCellValue(i, "Interes"), dm.Interes)

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
                            '
                            'Calcular el interes sobre el saldo vencido.
                            dm.CalcularInteres(CDbl(.GetRowCellValue(i, "OtroSaldo")), .GetRowCellValue(i, "No Factura"), FechaCobro.DateTime.Date)
                            .SetRowCellValue(i, "Interes", dm.Interes)
                        End If

                        If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo") +
                                      .GetRowCellValue(i, "Monto_Mantenimiento") +
                                      .GetRowCellValue(i, "Interes")), 2) >
                                      Math.Round(Total, 2) Then
                            'Calcular el Deslizamiento por Monto a Abonar.
                            dm.CalcularDeslizamiento(CDbl(Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue)), .GetRowCellValue(i, "TC"), IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue), 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                            'Calcular el interes sobre el saldo vencido.
                            dm.CalcularInteres(Total, .GetRowCellValue(i, "No Factura"), FechaCobro.DateTime.Date)
                            .SetRowCellValue(i, "Interes", dm.Interes)

                            Dim DifMnto As Double = CDbl(.GetRowCellValue(i, "OtroSaldo") +
                                .GetRowCellValue(i, "Monto_Mantenimiento") +
                                .GetRowCellValue(i, "Interes")) - Total

                            Valor = .GetRowCellValue(i, "OtroSaldo") - DifMnto
                            Equivalente += (Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                            Total = 0
                        Else
                            Valor = .GetRowCellValue(i, "OtroSaldo")
                            Equivalente +=
                                ((.GetRowCellValue(i, "OtroSaldo") +
                                .GetRowCellValue(i, "Monto_Mantenimiento") +
                                .GetRowCellValue(i, "Interes")) /
                                IIf(.GetRowCellValue(i, "TC_Paralelo"),
                                    txtTasaParalela.EditValue,
                                    txtTasa.EditValue))

                            Total -=
                                (.GetRowCellValue(i, "OtroSaldo") +
                                .GetRowCellValue(i, "Monto_Mantenimiento") +
                                .GetRowCellValue(i, "Interes"))
                        End If


                        'IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
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
                        Temp = False
                    End If

                    '
                    If Valor > 0 Then
                        Dim v = .GetRowCellValue(i, "Saldo")
                        Dim v2 = .GetRowCellValue(i, "OtroSaldo")

                        Dim dif As Double =
                            Math.Round(CDbl(.GetRowCellValue(i, "Saldo")) - Valor, 2)

                        If (dif = 0.01 Or dif = -0.01) Then
                            .SetRowCellValue(i, "Cobro", Valor + dif)
                        Else
                            .SetRowCellValue(i, "Cobro", Valor)
                        End If
                        '.SetRowCellValue(i, "Cobro", Valor)
                    Else

                        Temp = True
                        .SetRowCellValue(i, "Cobro", 0.00)
                        .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                        .SetRowCellValue(i, "Interes", 0.00)
                        .SetRowCellValue(i, "Facturar", False)
                        Temp = False
                    End If
                    Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
                Else
                    Temp = True
                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                    .SetRowCellValue(i, "Interes", 0.00)
                    Temp = False
                End If
                '
                If .GetRowCellValue(i, "IVA") > 0 Then
                    .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
                End If
                '
                If chknoiralcaldia.Checked Then
                    .SetRowCellValue(i, "IrAlcaldia", 0)
                Else
                    If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
                        .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
                    End If
                End If

                If Valor >= ConfigDetalles.MontoIR Then
                    .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
                End If

            Next
            '
            etMntto.Text = Math.Round(Mntto, 2).ToString("n2")
            txtEquivalente.EditValue = Math.Round(Equivalente, 2)
            txttotal.EditValue = txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue
            '
            iVista.UpdateTotalSummary()
        End With
    End Sub

    Sub DistribuirDalares()

        Dim Total As Double = txtefectivo.EditValue + txttarjetas.EditValue + txtcheques.EditValue

        ' Dim TotalU As Double = IIf(cmbmoneda.EditValue = )
        'Dim TotalU As Double = txttotal.EditValue / IIf(EmpresaActual = 1, txtTasaParalela.EditValue, txtTasa.EditValue)

        Dim Valor As Double = 0.00, Mntto As Double = 0.00, Equivalente As Double = 0.00
        Dim dm As New db_DeslizamientoMoneda
        '
        With iVista
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
                        'Total -= Total
                        'TotalU -= TotalU
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

                        'TotalU -= (.GetRowCellValue(i, "SaldoU"))
                        'If ((.GetRowCellValue(i, "OtroSaldo")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
                        '    Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
                        '    Total -= Total
                        '    'TotalU -= TotalU
                        'Else
                        '    Valor = .GetRowCellValue(i, "OtroSaldo")
                        '    Total -= (.GetRowCellValue(i, "OtroSaldo") + dm.Mantenimiento_Valor)      '.GetRowCellValue(i, "Monto_Mantenimiento"))
                        '    'TotalU -= .GetRowCellValue(i, "SaldoU")
                        'End If
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
                If .GetRowCellValue(i, "IVA") > 0 Then
                    .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
                End If
                '
                If chknoiralcaldia.Checked Then
                    .SetRowCellValue(i, "IrAlcaldia", 0)
                Else
                    If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
                        .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
                    End If
                End If

                If Valor >= ConfigDetalles.MontoIR Then
                    .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
                End If

            Next
            '
            txtEquivalente.EditValue = Math.Round(Equivalente, 2)
            txttotal.EditValue = txtEquivalente.EditValue
            etMntto.Text = Mntto.ToString("n2")
            .UpdateTotalSummary()
        End With
    End Sub

    Sub EquivlentePago()

        Dim Equivalente As Double = 0.00
        _DT_Facturas.AcceptChanges()

        If _DT_Facturas.Select("Facturar = 1").Length > 0 Then
            Dim _DT As DataTable =
                    _DT_Facturas.Select("Facturar = 1").CopyToDataTable()

            With _DT

                For i As Integer = 0 To .Rows.Count - 1
                    If cmbmoneda.EditValue = MonedaBase Then
                        Equivalente += CDbl(.Rows.Item(i)("Cobro") + .Rows.Item(i)("Monto_Mantenimiento") + .Rows.Item(i)("Interes")) /
                                IIf(CBool(.Rows.Item(i)("TC_Paralelo")), txtTasaParalela.EditValue, txtTasa.EditValue)
                    Else
                        Equivalente += CDbl(.Rows.Item(i)("Cobro") +
                            .Rows.Item(i)("Monto_Mantenimiento") +
                            .Rows.Item(i)("Interes"))
                    End If
                Next

            End With
            '
            txtEquivalente.EditValue = Math.Round(Equivalente, 2)
        Else
            txtEquivalente.EditValue = 0.00
        End If

    End Sub

    'Private Sub Distribuir()
    '    Dim Total As Double = txttotal.EditValue
    '    Dim Valor As Double = 0.00
    '    Dim Mntto As Double = 0.00

    '    If chksaldo.Checked And Not Temp Then   'Aqui no Entra porque lo puse Invisible el Control
    '        Temp = True
    '        With vDatos
    '            'Anula las transacciones realizadas
    '            For i As Integer = 0 To .DataRowCount
    '                .SetRowCellValue(i, "Cobro", 0)
    '                .SetRowCellValue(i, "Facturar", False)
    '            Next
    '            If chksaldo.Checked Then
    '                'Distribuye el valor a las facturas
    '                For i As Integer = 0 To .DataRowCount
    '                    If Total > 0 Then .SetRowCellValue(i, "Facturar", True)

    '                    If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '                        ''Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                        Valor = Total
    '                        Total -= Total
    '                    Else
    '                        Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                        Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                        ''Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                    End If

    '                    .SetRowCellValue(i, "Cobro", Valor)

    '                    If .GetRowCellValue(i, "IVA") > 0 Then
    '                        .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
    '                    End If
    '                    '
    '                    If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio) Is Nothing Then
    '                        XtraMsg("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MessageBoxIcon.Error)
    '                    End If
    '                    '
    '                    If Me.chknoiralcaldia.Checked Then
    '                        .SetRowCellValue(i, "IrAlcaldia", 0)
    '                    Else
    '                        If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
    '                            .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
    '                        End If
    '                    End If
    '                    '
    '                    If Valor >= ConfigDetalles.MontoIR Then
    '                        .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
    '                    End If
    '                Next
    '            End If
    '            Me.vDatos.RefreshData()
    '        End With
    '        Temp = False
    '    Else    'Aqui si Entra, Siempre se van a realizar abonos a las facturas.
    '        With vDatos
    '            ''Restar al Total lo que ya esta marcado
    '            For i As Integer = 0 To vDatos.DataRowCount - 1
    '                If chkAplicar.Checked Then      ''Abonar a Cualquier Factura
    '                    If .GetRowCellValue(i, "Cobro") > 0 Then
    '                        If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '                            Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                            Total -= Total
    '                        Else
    '                            Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                            Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                        End If
    '                        .SetRowCellValue(i, "Cobro", Valor)
    '                    End If

    '                    If .GetRowCellValue(i, "Facturar") Then
    '                        If .GetRowCellValue(i, "Cobro") > 0 Then
    '                            If .GetRowCellValue(i, "Saldo") = 0 Then
    '                                Total -= .GetRowCellValue(i, "Cobro") + .GetRowCellValue(i, "Mtto_Fijo")
    '                            Else
    '                                Total -= .GetRowCellValue(i, "Cobro") + .GetRowCellValue(i, "Mtto_Fijo")
    '                            End If

    '                            If .GetRowCellValue(i, "Monto_Mantenimiento") <> .GetRowCellValue(i, "Mtto_Fijo") Then
    '                                If .GetRowCellValue(i, "Monto_Mantenimiento") = 0 Then
    '                                    Total -= .GetRowCellValue(i, "Cobro") + .GetRowCellValue(i, "Mtto_Fijo")
    '                                    .SetRowCellValue(i, "Cobro", .GetRowCellValue(i, "Cobro") + .GetRowCellValue(i, "Mtto_Fijo"))
    '                                Else
    '                                    Total -= .GetRowCellValue(i, "Cobro") - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                                    .SetRowCellValue(i, "Cobro", .GetRowCellValue(i, "Cobro") - .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                                End If
    '                            Else
    '                                Total -= .GetRowCellValue(i, "Cobro") + .GetRowCellValue(i, "Mtto_Fijo")
    '                            End If
    '                            ''GridDetalle.DataSource = ObtieneDatos("")
    '                        Else
    '                            If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '                                Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                                Total -= Total
    '                            Else
    '                                If ((.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
    '                                    Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                                    Total -= Total
    '                                Else
    '                                    Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                                    Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                                End If
    '                            End If

    '                            .SetRowCellValue(i, "Cobro", Valor)
    '                        End If
    '                    End If
    '                Else
    '                    If .GetRowCellValue(i, "Facturar") = True Then
    '                        ''Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                        '' If .GetRowCellValue(i, "Cobro") = 0 Then                            
    '                        If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '                            Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                            Total -= Total
    '                        Else
    '                            If ((.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
    '                                Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '                                Total -= Total
    '                            Else
    '                                Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '                                Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '                            End If
    '                        End If

    '                        .SetRowCellValue(i, "Cobro", Valor)
    '                        Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
    '                    End If

    '                    If .GetRowCellValue(i, "IVA") > 0 Then
    '                        .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
    '                    End If

    '                    If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio) Is Nothing Then
    '                        MsgBox("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS.Contab")
    '                    End If

    '                    If Me.chknoiralcaldia.Checked Then
    '                        .SetRowCellValue(i, "IrAlcaldia", 0)
    '                    Else
    '                        If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
    '                            .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
    '                        End If
    '                    End If

    '                    If Valor >= ConfigDetalles.MontoIR Then
    '                        .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
    '                    End If
    '                End If
    '            Next

    '            Me.vDatos.RefreshData()
    '            Me.etMntto.Text = Mntto.ToString("n2")
    '        End With
    '    End If

    '    'For i As Integer = 0 To .DataRowCount
    '    '    If .GetRowCellValue(i, "Facturar") = True Then
    '    '        ''Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '    '        '' If .GetRowCellValue(i, "Cobro") = 0 Then                            
    '    '        If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
    '    '            Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '    '            Total -= Total
    '    '        Else
    '    '            If ((.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
    '    '                Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
    '    '                Total -= Total
    '    '            Else
    '    '                Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
    '    '                Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
    '    '            End If
    '    '        End If

    '    '        .SetRowCellValue(i, "Cobro", Valor)
    '    '        ''End If
    '    '        If .GetRowCellValue(i, "IVA") > 0 Then
    '    '            .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
    '    '        End If
    '    '        If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio) Is Nothing Then
    '    '            MsgBox("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS.Contab")
    '    '        End If
    '    '        If Me.chknoiralcaldia.Checked Then
    '    '            .SetRowCellValue(i, "IrAlcaldia", 0)
    '    '        Else
    '    '            If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
    '    '                .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
    '    '            End If
    '    '        End If
    '    '        If Valor >= ConfigDetalles.MontoIR Then
    '    '            .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
    '    '        End If

    '    '    End If
    '    'Next
    'End Sub

    Private Sub cmdcheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcheques.Click

        'If SumaFactura() = False Then
        '    MsgBox("No hay factura a cancelar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If DT_Cheques Is Nothing Then DT_Cheques = ObtieneDatos("SELECT Banco,NoCheque Cheque,Cuenta,Monto_Cheque Monto,Moneda FROM Cobros WHERE 0 = 1")

        'Dim Efectivo As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtefectivo.EditValue, txtEquivalente.EditValue)
        'Dim Cheque As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, txtEquivalente.EditValue)
        'Dim Tarjeta As Double = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, txtEquivalente.EditValue)

        TotalTarjetas = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, txtEquivalente.EditValue)
        TotalEfectivo = IIf(cmbmoneda.EditValue = MonedaBase, txtefectivo.EditValue, txtEquivalente.EditValue)
        TotalCheques = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, txtEquivalente.EditValue)
        NuevaFactura = "SI"
        Recibo = txtrecibo.Text

        Dim f As New DataGridTextBoxCombo.frmPagosRecibo
        f.etCaja.Text = txtCaja.Text
        f.ShowDialog()
        NuevaFactura = "NO"

        '  If TotalCheques > 0.00 Then
        txtefectivo.EditValue = 0.00
        txttarjetas.EditValue = 0.00
        txtEquivalente.EditValue = 0.00
        txttotal.EditValue = 0.00
        '  End If
        '
        txtcheques.EditValue = TotalCheques
        TotalGlobal = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, txtEquivalente.EditValue)
        ' SumarAbonos()
    End Sub

    Private Sub cmdtarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtarjetas.Click
        'If SumaFactura() = False Then
        '    MsgBox("No hay factura a cancelar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If DT_Tarjetas Is Nothing Then DT_Tarjetas = ObtieneDatos("SELECT Tipo_Tarjeta Tipo,Emisor,No_Tarjeta Tarjeta,Autorizacion,Monto_Tarjeta Monto FROM Cobros WHERE 0 = 1")

        'TotalTarjetas = txttarjetas.Text
        'TotalEfectivo = txtefectivo.Text
        'TotalCheques = txtcheques.Text

        TotalTarjetas = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, txtEquivalente.EditValue)
        TotalEfectivo = IIf(cmbmoneda.EditValue = MonedaBase, txtefectivo.EditValue, txtEquivalente.EditValue)
        TotalCheques = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, txtEquivalente.EditValue)
        NuevaFactura = "SI"
        Recibo = txtrecibo.Text
        '
        Dim f As New DataGridTextBoxCombo.frmPagosReciboTarjeta
        f.etCaja.Text = txtCaja.Text
        f.ShowDialog()
        NuevaFactura = "NO"

        '  If TotalTarjetas > 0.00 Then
        txtefectivo.EditValue = 0.00
        txtcheques.EditValue = 0.00
        txtEquivalente.EditValue = 0.00
        txttotal.EditValue = 0.00
        '  End If

        txttarjetas.EditValue = TotalTarjetas
        TotalGlobal = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, txtEquivalente.EditValue)
        ' SumarAbonos()
    End Sub

    'Private Function SumaFactura() As Boolean
    '    If chksaldo.Checked Then
    '        TotalFactura = vDatos.Columns("Total").SummaryItem.SummaryValue
    '    Else
    '        Dim Suma As Double = 0
    '        With vDatos
    '            For i As Integer = 0 To .DataRowCount
    '                If .GetRowCellValue(i, "Facturar") = True Then Suma += .GetRowCellValue(i, "Total")
    '            Next
    '        End With
    '        TotalFactura = Suma
    '    End If
    '    If TotalFactura = 0 Then Return False Else Return True

    'End Function

    Private Sub FrmCobrosNew_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim Clientes As New VB.SysContab.ClientesDB
        Clientes.DeleteReciboCheques(txtrecibo.Text, txtCaja.Text)
        Clientes.DeleteReciboTarjetas(txtrecibo.Text, txtCaja.Text)
        Clientes = Nothing

    End Sub

    Private Sub chknoir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknoir.CheckedChanged, chknoiva.CheckedChanged, chknoiralcaldia.CheckedChanged

        If etInicio.Text = "1" Then Exit Sub

        DesmarcarFacturas()

        'Distribuir()
        'DistribuirPago()

        'temp2 = True
        'If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        'temp2 = False

    End Sub

    Private Sub GetData()

        If etInicio.Text = "1" Then Exit Sub

        _DT_Facturas =
            VB.SysContab.Facturas_VentasDB.
            GetCobrosPendientesAnticipos(
            cbClientes.EditValue,
            FechaCobro.DateTime.Date)

        iGrid.DataSource = _DT_Facturas
        If Not (EmpresaActual.Equals("20") Or EmpresaActual.Equals("18")) Then
            iVista.Columns("F/Electrónica").Visible = False
        End If
    End Sub

    'Private Sub chksaldo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaldo.CheckedChanged
    '    If etInicio.Text = "1" Then Exit Sub

    '    txtefectivo.EditValue = vDatos.Columns("Saldo").SummaryItem.SummaryValue
    '    Distribuir()
    '    If Not chksaldo.Checked Then
    '        With vDatos
    '            For i As Integer = 0 To .DataRowCount
    '                '.SetRowCellValue(i, "Cobro", 0)
    '                .SetRowCellValue(i, "Facturar", False)
    '            Next
    '        End With
    '    End If
    'End Sub

    Private Sub FechaCobro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaCobro.EditValueChanged
        If etInicio.Text = "1" Then Exit Sub
        Try
            ' GetData()

            '**** Cargar Tasa de Cambio
            'TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            '+ " WHERE tc.DIA = " & Me.FechaCobro.DateTime.Day & " AND tc.MES = " & Me.FechaCobro.DateTime.Month & " AND tc.ANIO = " & Me.FechaCobro.DateTime.Year & "").Rows.Item(0)(0))
            'Me.txtTasa.Text = TCambio.ToString("n4")

            'TCambio = GetTasaCambioDia(FechaCobro.DateTime.Date)
            'txtTasa.Text = TCambio.ToString("n4")

            TC.GetTasaCambio(MonedaBase, FechaCobro.DateTime.Date)
            TCambio = TC.TC_Oficial
            TC_Paralelo = TC.TC_Paralelo

            txtTasa.EditValue = TCambio
            txtTasaParalela.EditValue = TC_Paralelo
            '
            'SumarAbonos()
            If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtrecibo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtrecibo.Validating
        If Not IsNothing(txtrecibo.Text) Then
            Dim valor As Integer = 0

            valor = VB.SysContab.ClientesDB.ValidarRecibo(
                txtrecibo.Text,
                cmbserie.Text)

            If valor = 1 Then
                XtraMsg("Ese Número de recibo ya existe",
                        MessageBoxIcon.Error)
                txtrecibo.Text = String.Empty
                txtrecibo.Focus()
            ElseIf valor = 2 Then
                XtraMsg("Ese Número de recibo fue Anulado",
                        MessageBoxIcon.Error)
                txtrecibo.Text = String.Empty
                txtrecibo.Focus()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(FechaCobro.DateTime.Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        Dim ExisteFactura As Boolean = False
        Dim Clientes As New VB.SysContab.ClientesDB
        Dim Cobrado As Double = 0

        'Dim Efectivo As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtefectivo.EditValue, Math.Round(CDbl(txtefectivo.EditValue * txtEquivalente.EditValue / (txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue)), 2))
        'Dim Cheque As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, Math.Round(CDbl(txtcheques.EditValue * txtEquivalente.EditValue / (txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue)), 2))
        'Dim Tarjeta As Double = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, Math.Round(CDbl(txttarjetas.EditValue * txtEquivalente.EditValue / (txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue)), 2))

        Dim Efectivo As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtefectivo.EditValue, txtEquivalente.EditValue)
        Dim Cheque As Double = IIf(cmbmoneda.EditValue = MonedaBase, txtcheques.EditValue, IIf(txtcheques.EditValue > 0.00, txtEquivalente.EditValue, 0.00))
        Dim Tarjeta As Double = IIf(cmbmoneda.EditValue = MonedaBase, txttarjetas.EditValue, IIf(txttarjetas.EditValue > 0.00, txtEquivalente.EditValue, 0.00))


        If txtrecibo.Text.Trim.Length = 0 Then
            txtrecibo.Focus()
            XtraMsg("Especifique el no de recibo", MessageBoxIcon.Error)
            Exit Sub
        End If

        'If ObtieneDatos("SELECT c.RECIBO FROM cobros c WHERE RECIBO = '" & Me.txtrecibo.Text & "' AND EMPRESA = " & EmpresaActual).Rows.Count > 0 Then
        '    XtraMsg("El No. de Recibo Ya Exite.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        Dim valor As Integer = 0

        valor = VB.SysContab.ClientesDB.ValidarRecibo(
                txtrecibo.Text,
                cmbserie.Text)

        If valor = 1 Then
            XtraMsg("Ese Número de recibo ya existe",
                    MessageBoxIcon.Error)
            'txtrecibo.Text = String.Empty
            txtrecibo.Focus()
            Exit Sub
        ElseIf valor = 2 Then
            XtraMsg("Ese Número de recibo fue Anulado",
                    MessageBoxIcon.Error)
            'txtrecibo.Text = String.Empty
            txtrecibo.Focus()
            Exit Sub
        End If
        '

        Dim TotalCobro As Double = 0.00,
            TotalMtto As Double = 0.00,
            TotalInteres As Double = 0.00,
            TotalIR As Double = 0.00,
            TotalAlma As Double = 0.00,
            TotalPagado As Double = 0.00,
            TotalCobrado As Double = 0.00

        Dim _DT As New DataTable("Seleccionadas")

        _DT_Facturas.AcceptChanges()
        Dim sel As Integer =
            _DT_Facturas.Select("Facturar = 1").Length

        If sel = 0 Then
            XtraMsg("Debe marcar las facturas que desea aplicarle el cobro.",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If sel > 0 Then
            _DT = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()

            TotalCobro = CDbl(_DT.Compute("SUM(Cobro)", "Facturar = 1"))
            TotalMtto = CDbl(_DT.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1"))
            TotalInteres = CDbl(_DT.Compute("SUM(Interes)", "Facturar = 1"))
            TotalIR = CDbl(_DT.Compute("SUM(IrParcial)", "Facturar = 1"))
            TotalAlma = CDbl(_DT.Compute("SUM(IrAlcaldia)", "Facturar = 1"))
            'Total aplicado a facturas
            TotalCobrado = TotalCobro + TotalMtto + TotalInteres
        End If
        'Total recibido en Efectivo, Cheque o Tarjeta.
        TotalPagado = txtefectivo.EditValue + txtcheques.EditValue + txttarjetas.EditValue

        'For i As Integer = 0 To vDatos.DataRowCount
        '    If vDatos.GetRowCellValue(i, "Facturar") = True Then
        '        Total += CDbl(vDatos.GetRowCellValue(i, "Cobro")) + CDbl(vDatos.GetRowCellValue(i, "Monto_Mantenimiento"))
        '        ExisteFactura = True
        '    End If
        'Next

        If Not cmbmoneda.EditValue.ToString.Equals(MonedaBase) Then
            With _DT
                TotalCobrado = 0
                For i As Integer = 0 To .Rows.Count - 1

                    TotalCobrado += CDbl(.Rows.Item(i)("Cobro") + .Rows.Item(i)("Monto_Mantenimiento") + .Rows.Item(i)("Interes")) /
                                IIf(CBool(.Rows.Item(i)("TC_Paralelo")), txtTasaParalela.EditValue, txtTasa.EditValue)
                Next
            End With

            '            EquivlentePago()

        End If


        Dim Dif As Double = Math.Round(TotalCobrado, 2) - Math.Round(TotalPagado, 2)
        Dim Equivalente As Double = 0.00
        '
        If (Dif = 0.01 Or Dif = -0.01) Then Dif = 0.00

        If cmbmoneda.EditValue = MonedaBase Then
            Equivalente = Math.Round(Dif / txtTasa.EditValue, 2)
        Else
            Equivalente = Math.Round(Dif * txtTasa.EditValue, 2)
        End If

        If Math.Round(Dif, 2) <> 0.0 Then

            XtraMsg($"Hay diferencia entre Total Pagado {cmbmoneda.GetColumnValue("Simbolo")}: {Math.Round(TotalPagado, 2).ToString("n2")} y total Cobrado {cmbmoneda.GetColumnValue("Simbolo")}: {Math.Round(TotalCobrado, 2).ToString("n2")}{vbCrLf} Diferencia {cmbmoneda.GetColumnValue("Simbolo")}: {Dif.ToString("n2")}, Equivalente = {Equivalente.ToString("n2")}",
                        MessageBoxIcon.Error)

            'XtraMsg("Hay Una Diferencia de (" & CDbl(Math.Round(Dif, 2)).ToString("n2") & ") en Cuanto al Total Recibido y el Total Cobrado",
            '        MessageBoxIcon.Warning)
            Exit Sub
        End If




        'Dim dif As Double =
        '    Math.Round(Total, 2) - Math.Round(CDbl(txttotal.EditValue), 2)

        'If Math.Round(dif, 2) <> 0.0 Then
        '    XtraMsg("Hay Una Diferencia de (" & CDbl(Math.Round(dif, 2)).ToString("n2") & ") en Cuanto al Total Recibido y el Total Cobrado",
        '            MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        'If FormatNumber(Total, 2) <> FormatNumber(txttotal.EditValue, 2) Then
        '    MsgBox("El Monto a Pagar debe ser Igual al Monto Cobrado + Mantenimiento de Valor", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        'For i As Integer = 0 To vDatos.DataRowCount
        '    If vDatos.GetRowCellValue(i, "Facturar") = True Then
        '        ' Cobrado += vDatos.GetRowCellValue(i, "Cobro") + IsNull(vDatos.GetRowCellValue(i, "Monto_Mantenimiento"), 0)
        '        ExisteFactura = True
        '        Exit For
        '    End If
        'Next

        'If Not ExisteFactura Then
        '    XtraMsg("Seleccione las registros a facturar",
        '            MessageBoxIcon.Error)
        '    Exit Sub
        'End If


        If Not CheckEdit1.Checked Then  'Preguntar si va a  sin Conbilizar
            If Not XtraMsg2("Esta seguro de grabar este Recibo sin Contabilizar ?" & vbCrLf &
                        "Este proceso afecta solamente al Auxiliar de Clientes.") Then
                Exit Sub
            End If
        End If

        'If Cobrado <> txttotal.EditValue Then
        '    MsgBox("El monto cobrado no corresponde a la deuda", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If chkcontabilizado.Checked Then
        '    If txtcomprobante.Text = Nothing Then
        '        XtraMsg("Seleccione el comprobante que contabiliza este cobro")
        '        Exit Sub
        '    End If
        'End If

        If Clientes.GenerarTransaccion.Tables("Cobros").Rows.Count = 0 Then
            Transaccion = "1"
        Else
            Transaccion = Clientes.GenerarTransaccion.Tables("Cobros").Rows(0).Item("Transaccion") + 1
        End If

        Dim Numero As Double
        Dim Tipo As Integer
        Dim lds As New DataSet
        Dim TipoCambio As Double = txtTasa.EditValue

        'Dim Tasa As New VB.SysContab.Tasa_CambioDB

        '/*******************  VERIFICAR DISTRIBUCION EN LA CUENTA DE MANTENIMIENTO DE VALOR    *********/
        If CheckEdit1.Checked Then

            Dim CuentaMtto As String = "",
                MttoMonto As Double = CDbl(etMntto.Text),
                CTemp As String = vbNullString

            If MttoMonto <> 0 Then
                Try
                    'Buscar las Cuentas de Matto Valor
                    Dim DsPlantillas As DataSet =
                        VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles

                    If MttoMonto > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                    If MttoMonto < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

                    Try
                        CTemp = ObtieneDatos("sp_sel_RubroGastos",
                                         CuentaMtto,
                                         EmpresaActual).
                                         Rows.Item(0)("CuentaContable")

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

        DBConnFacturas = New System.Data.SqlClient.SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            For i As Integer = 0 To iVista.DataRowCount - 1
                If iVista.GetRowCellValue(i, "Facturar") = True Then

                    Dim Cobro As Double = iVista.GetRowCellValue(i, "Cobro")
                    Dim Saldo As Double = Math.Round(CDbl(iVista.GetRowCellValue(i, "Total") - iVista.GetRowCellValue(i, "Abono")), 2)

                    If Math.Round(CDbl(iVista.GetRowCellValue(i, "Saldo")), 2) = 0.00 Then
                        Tipo = 0 + 1
                    Else
                        Tipo = 2 + 1
                    End If

                    'Dim dfactura As New VB.SysContab.FacturasDetails
                    'Dim rMonto As Double = Math.Round(vDatos.GetRowCellValue(i, "Cobro"), 2)

                    'dfactura = VB.SysContab.Facturas_VentasDB.GetFacturasDetails(vDatos.GetRowCellValue(i, "No Factura"))

                    '                    If cmbmoneda.EditValue = MonedaBase Then
                    '                        If dfactura.Mon_mtto <> MonedaBase Then

                    '                            'lds = Tasa.GetTasaCambio(VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, IsNull(dfactura.Mon_mtto, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase), FechaCobro.DateTime.Date)

                    '                            'If lds.Tables(0).Rows.Count = 0 Then
                    '                            '    XtraMsg("No hay tasa de cambio para el dia", MessageBoxIcon.Warning)
                    '                            '    TipoCambio = 1
                    '                            'Else
                    '                            '    TipoCambio = IsNull(lds.Tables(0).Rows(0)("TCambio"), 1)
                    '                            'End If

                    '                            'rMonto = Math.Round(vDatos.GetRowCellValue(i, "Cobro") / TipoCambio, 4)
                    '                            ''Buscar el tipo de cambio del dia de la factura
                    '                            'lds = Tasa.GetTasaCambio(VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, IsNull(dfactura.Mon_mtto, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase), vDatos.GetRowCellValue(i, "Fecha"))
                    '                            'If lds.Tables(0).Rows.Count = 0 Then
                    '                            '    XtraMsg("No hay tasa de cambio para el dia", MessageBoxIcon.Warning)
                    '                            '    TipoCambio = 1
                    '                            'Else
                    '                            '    TipoCambio = IsNull(lds.Tables(0).Rows(0)("TCambio"), 1)
                    '                            'End If

                    '                            rMonto = Math.Round(rMonto * TipoCambio, 2)
                    '                            TipoCambio = 1
                    '                        Else
                    '                            rMonto = Math.Round(vDatos.GetRowCellValue(i, "Cobro") / TipoCambio, 4)
                    '                        End If
                    '                    Else
                    'NoMnto:
                    '                        rMonto = Math.Round(vDatos.GetRowCellValue(i, "Cobro") / TipoCambio, 4)

                    '                    End If


                    'Dim Diferencia As Double = rMonto + CDbl(GridView1.GetRowCellValue(i, "IrParcial"))

                    Dim dsTarjetas As DataSet = Clientes.ListReciboTarjetas(txtCaja.Text)
                    Dim dsCheques As DataSet = Clientes.ListReciboCheques(txtCaja.Text)
                    Dim Cliente As New VB.SysContab.ClientesDB

                    Numero = Cliente.CobrosNumero()

                    With iVista

                        'Clientes.AddCobro(Numero, txtrecibo.Text, .GetRowCellValue(i, "No Factura"), FechaCobro.DateTime.Date, 1, txttotal.Text, _
                        '"", 0, "", "0", "", "", "", "", "0", .GetRowCellValue(i, "Cobro"), _
                        'cmbmoneda.EditValue, TipoCambio, .GetRowCellValue(i, "Saldo"), "0", "", Tipo, Transaccion, 2, .GetRowCellValue(i, "IrParcial"), _
                        'IIf(IsDBNull(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse IsNothing(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse .GetRowCellValue(i, "Monto_Mantenimiento") = Nothing, 0, 1), .GetRowCellValue(i, "Monto_Mantenimiento"))

                        Dim Mnto As Double = 0.0
                        Dim AplicaMnto As Integer = 0

                        While FormatNumber(Cobro, 2) > 0

                            Cobrado = 0

                            If FormatNumber(Efectivo, 2) > 0 And FormatNumber(Cobro, 2) > 0 Then

                                Mnto = .GetRowCellValue(i, "Monto_Mantenimiento")
                                AplicaMnto = IIf(IsDBNull(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse IsNothing(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse .GetRowCellValue(i, "Monto_Mantenimiento") = Nothing, 0, 1)

                                If Cobro > Efectivo Then Cobrado = Efectivo Else Cobrado = Cobro
                                Saldo -= Cobrado

                                Clientes.AddCobro(
                                    Numero,
                                    txtrecibo.Text,
                                    .GetRowCellValue(i, "No Factura"),
                                    FechaCobro.DateTime.Date,
                                    1,
                                    txttotal.Text,
                                    "", 0, "", "0", "", "", "", "", "0",
                                    Cobrado,
                                    cmbmoneda.EditValue,
                                    txtTasa.EditValue,
                                    Saldo,
                                    "0", "",
                                    Tipo,
                                    Transaccion,
                                    2,
                                    .GetRowCellValue(i, "IrParcial"),
                                    .GetRowCellValue(i, "IrAlcaldia"),
                                    AplicaMnto,
                                    Math.Round(Mnto, 2),
                                    txtCaja.Text,
                                    cmbserie.Text,
                                    txtRecibimos.Text,
                                    txtPorCuenta.Text)

                                Efectivo -= Cobrado
                                If Efectivo = 0 Then Cobro = 0.00
                                If Efectivo <> 0 Then Cobro -= Cobrado
                            End If

                            Cobrado = 0

                            If FormatNumber(Cheque, 2) > 0 And FormatNumber(Cobro, 2) > 0 Then
                                'If Mnto = 0 Then
                                Mnto = .GetRowCellValue(i, "Monto_Mantenimiento")
                                AplicaMnto = IIf(IsDBNull(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse IsNothing(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse .GetRowCellValue(i, "Monto_Mantenimiento") = Nothing, 0, 1)
                                ' End If

                                'For j As Integer = 0 To DT_Cheques.Rows.Count - 1
                                '    If Cobro = 0 Or Cheque = 0 Then Exit For

                                If Cobro > Cheque Then Cobrado = Cheque Else Cobrado = Cobro
                                Saldo -= Cobrado

                                'If Cobro > DT_Cheques.Rows(j).Item("monto") Then Cobrado = DT_Cheques.Rows(j).Item("monto") Else Cobrado = Cobro
                                'DT_Cheques.Rows(j).Item("monto") -= Cobrado
                                '
                                Clientes.AddCobro(
                                    Numero,
                                    txtrecibo.Text,
                                    .GetRowCellValue(i, "No Factura"),
                                    FechaCobro.DateTime.Date,
                                    2,
                                    txttotal.EditValue,
                                    DT_Cheques.Rows(0).Item("cheque"),
                                    DT_Cheques.Rows(0).Item("banco"),
                                    IsNull(DT_Cheques.Rows(0).Item("cuenta"), ""),
                                    Cobrado,
                                    "", "", "", "", "0", "0",
                                    cmbmoneda.EditValue,
                                    txtTasa.EditValue,
                                    Saldo,
                                    "0", "",
                                    Tipo,
                                    Transaccion,
                                    2, 0, 0,
                                    AplicaMnto,
                                    Math.Round(Mnto, 2),
                                    txtCaja.Text,
                                    cmbserie.Text,
                                    txtRecibimos.Text,
                                    txtPorCuenta.Text)

                                Cheque -= Cobrado
                                'Cobro -= Cobrado
                                If Cheque = 0 Then Cobro = 0.00
                                If Cheque <> 0 Then Cobro -= Cobrado
                                ' Next
                            End If

                            Cobrado = 0

                            If FormatNumber(Tarjeta, 2) > 0 And FormatNumber(Cobro, 2) > 0 Then
                                ' If Mnto = 0 Then
                                Mnto = .GetRowCellValue(i, "Monto_Mantenimiento")
                                AplicaMnto = IIf(IsDBNull(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse IsNothing(.GetRowCellValue(i, "Monto_Mantenimiento")) OrElse .GetRowCellValue(i, "Monto_Mantenimiento") = Nothing, 0, 1)
                                '  End If

                                'For j As Integer = 0 To DT_Tarjetas.Rows.Count - 1
                                '    If Cobro = 0 Or Tarjeta = 0 Then Exit For
                                'If Cobro > DT_Tarjetas.Rows(j).Item("monto") Then Cobrado = DT_Tarjetas.Rows(j).Item("monto") Else Cobrado = Cobro
                                'Saldo -= Cobrado
                                'DT_Tarjetas.Rows(j).Item("monto") -= Cobrado

                                If Cobro > Tarjeta Then Cobrado = Tarjeta Else Cobrado = Cobro
                                Saldo -= Cobrado

                                Clientes.AddCobro(
                                    Numero,
                                    txtrecibo.Text,
                                    .GetRowCellValue(i, "No Factura"),
                                    FechaCobro.DateTime.Date,
                                    3,
                                    txttotal.EditValue,
                                    "", 0, "", "0",
                                    DT_Tarjetas.Rows(0).Item("tipo"),
                                    DT_Tarjetas.Rows(0).Item("emisor"),
                                    DT_Tarjetas.Rows(0).Item("tarjeta"),
                                    DT_Tarjetas.Rows(0).Item("autorizacion"),
                                    Cobrado, "0",
                                    cmbmoneda.EditValue,
                                    txtTasa.EditValue,
                                    Saldo,
                                    "0", "",
                                    Tipo,
                                    Transaccion,
                                    2, 0, 0, 0, 0,
                                    txtCaja.Text,
                                    cmbserie.Text,
                                    txtRecibimos.Text,
                                    txtPorCuenta.Text)

                                Tarjeta -= Cobrado
                                'Cobro -= Cobrado
                                If Tarjeta = 0 Then Cobro = 0.00
                                If Tarjeta <> 0 Then Cobro -= Cobrado
                                'Next
                            End If
                        End While

                        Clientes.UpdateFacturaSaldo(
                            .GetRowCellValue(i, "No Factura"),
                            .GetRowCellValue(i, "CodigoCliente"),
                            Math.Round(CDbl(.GetRowCellValue(i, "Saldo")), 2))
                        'Math.Round((tCust.Rows(i)("Saldo") / ds.Tables("Facturas_Ventas").Rows(i)("TC_Actual")) * ds.Tables("Facturas_Ventas").Rows(i)("TC"), 2))  'tCust.Rows(i)("Saldo"))
                    End With
                    '
                    iVista.GetRowCellValue(i, "Cobro")
                End If
            Next

            VB.SysContab.Rutinas.okTransaccion()


            '' Si se va a Contabilizar el Recibo
            If CheckEdit1.Checked Then Contabilizar()

            DT_Cheques = Nothing
            DT_Tarjetas = Nothing

            txtEquivalente.EditValue = 0.0
            txtefectivo.EditValue = 0.0
            txtcheques.EditValue = 0.0
            txttarjetas.EditValue = 0.0

            'SumarAbonos()

            If XtraMsg2("Imprimir el Recibo?") Then VB.SysContab.ClientesDB.ImprimirRecibo(
                txtrecibo.Text,
                cmbserie.Text, 0)

            Cargar()

            txtRecibimos.Text = cbClientes.Text
            txtPorCuenta.Text = "EL MISMO"
            CargarFacturasCliente()

        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        'If XtraMessageBox.Show("¿ Desea Contabilizar el Recibo ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '    Dim f2 As frmRecibos = frmRecibos.Instance()
        '    f2.Dispose()

        '    Dim f As frmRecibos = frmRecibos.Instance()
        '    Recurso = ObtieneDatos("SELECT rr.ID FROM REST_Recursos rr WHERE rr.Control = 'etRecibos'").Rows.Item(0)(0)
        '    Try
        '        f.Cliente = 0 'Me.cbClientes.EditValue
        '        f.Recibo = Me.txtrecibo.Text
        '        f.etInicio.Text = "1"
        '        f.MdiParent = Me.MdiParent
        '        f.Show()
        '        f.WindowState = FormWindowState.Maximized

        '        f.etInicio.Text = "0"
        '    Catch ex As Exception
        '        'f.Show()
        '        'f.etInicio.Text = "0"
        '    End Try

        '    'Me.Close()
        'End If
        ''

    End Sub

    Sub Contabilizar()

        Dim Clientes As New VB.SysContab.ClientesDB
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Dim dsCobros As DataSet

        dsCobros = Clientes.CobrosReciboCaja(
            txtrecibo.Text,
            cmbserie.Text)

        Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

        ConfigDetalles = Config.GetConfigDetails

        Dim Factura As String
        Dim Recibo As String
        Dim Cliente As String
        Dim ReciboMonto As Double
        Dim ChequeMonto As Double
        Dim EfectivoMonto As Double
        Dim TarjetaMonto As Double
        Dim MttoMonto As Double
        Dim Total As Double = 0.00
        ' Dim TCambio As Double = txtTasa.EditValue
        Dim Moneda As String = cmbmoneda.EditValue

        Dim IRMonto As Double
        Dim ClienteMonto As Double

        Dim IRMonto1 As Double

        Recibo = txtrecibo.Text
        'Factura = Me.dgRecibos.Item(Me.dgRecibos.CurrentRowIndex, 1)
        Dim dt As DataTable
        dt = ObtieneDatos("Select Factura From Cobros where recibo = " & Recibo & " AND Transaccion = '" & Transaccion & "'")

        For x As Integer = 0 To dt.Rows.Count - 1
            If Factura = vbNullString Then
                Factura += dt.Rows(x).Item(0)
            Else
                Factura += "-" & dt.Rows(x).Item(0)
            End If
        Next

        Cliente = Me.cbClientes.EditValue

        ''Dim dsDetalle As DataSet
        Dim dsIR As DataSet

        Dim CuentaCaja As String
        Dim CuentaIR As String
        Dim CuentaIMtto As String
        Dim CuentaEMtto As String

        'Agregado el 28022008 RMPR
        Dim CuentaIR_Alcaldia As String
        Dim IR_Alcaldia As Double = 0

        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim TasaCambio As New VB.SysContab.Tasa_CambioDB

        'Dim i As Integer

        Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 3).TipoCompr

        ReciboMonto = 0
        ChequeMonto = 0
        EfectivoMonto = 0
        TarjetaMonto = 0
        MttoMonto = 0
        Total = 0

        Dim ConceptoCheque As String

        For i = 0 To dsCobros.Tables("Cobros").Rows.Count - 1
            If dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 1 Then
                EfectivoMonto = EfectivoMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Efectivo")).ToString(Round))
                'Total = Total + EfectivoMonto
            ElseIf dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 2 Then
                ChequeMonto = ChequeMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Cheque")).ToString(Round))
                ConceptoCheque = ConceptoCheque & dsCobros.Tables("Cobros").Rows(i).Item("NoCheque") & ", "
                'Total = Total + ChequeMonto
            ElseIf dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 3 Then
                TarjetaMonto = TarjetaMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Tarjeta")).ToString(Round))
                'total = 
            End If

            MttoMonto += dsCobros.Tables("Cobros").Rows(i).Item("mtto")

            '------------------------------------------------------
            'No cobrar IR a Facturas Cobros Menores de 1000            
            If EfectivoMonto < ConfigDetalles.MontoIR Then
                'Lo quite pq solamente deberia obviarse el monto en el proceso de acumulacion 28022008 RMPR
                'IRMonto = 0
            Else
                IRMonto += dsCobros.Tables("Cobros").Rows(i).Item("MontoIR")
            End If

            IR_Alcaldia += dsCobros.Tables("Cobros").Rows(i).Item("Monto_IR_Alcaldia")
            '-------------------------
        Next

        Total = EfectivoMonto + ChequeMonto + TarjetaMonto

        If Plantilla.GetPlantillasDetails(4, 3).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 3).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 3).PlaID = "" Then
            XtraMsg("No existen plantilla del tipo Abono de Cliente.", MessageBoxIcon.Error)
        Else
            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 3).Detalles

            If DsPlantillas.Tables(0).Rows.Count < 3 Then
                XtraMsg("La plantilla de Abono de Clientes no tiene los registros suficientes para completar la operación.", MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                CuentaCaja = ObtieneDatos("sp_GetCuentaCaja '" & Me.txtCaja.Text & "'," & EmpresaActual).Rows.Item(0)("Cuenta")
            Catch ex As Exception
                XtraMsg("No se ha Configurado la Cuenta de la Caja.", MessageBoxIcon.Warning)
                Exit Sub
            End Try

            'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            CuentaIR_Alcaldia = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
            ''dsDetalle = Clientes.FacturaDetalleCalc(Me.VRecibos.GetFocusedRowCellValue("Factura"))

            Dim CuentaMtto As String = String.Empty,
                TipoDC As String = String.Empty

            If MttoMonto <> 0 Then
                Try
                    'Buscar las Cuentas de Matto Valor
                    DsPlantillas =
                        Plantilla.GetPlantillasDetails(7, 1).Detalles

                    CuentaIMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                    CuentaEMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                Catch ex As Exception
                    XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.", MessageBoxIcon.Error)
                    Exit Sub
                End Try

                CuentaMtto = IIf(MttoMonto > 0, CuentaIMtto, CuentaEMtto)
                TipoDC = IIf(MttoMonto > 0, "C", "D")   'DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("DC")                
            Else
                CuentaMtto = String.Empty
                TipoDC = String.Empty
            End If


            'Buscar si ya se realizo el IR
            ''dsIR = Comprobantes.IRBuscar(Me.VRecibos.GetFocusedRowCellValue("Factura"), CuentaIR)
            '
            ClienteMonto = Total
            Total = Total - IRMonto - IR_Alcaldia
            '            
            DBConnFacturas = New System.Data.SqlClient.SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            If Comprobantes.GeneraComprobanteRecibo(CuentaCaja, Total, "Por Recibo No. " & Recibo,
                        CuentaIR, IRMonto, "IR de Factura: " & Factura,
                        VB.SysContab.ClientesDB.GetDetails(Cliente).Cuenta, ClienteMonto, "Abono Recibo No. " & Recibo, TipoCOmpr,
                        TCambio, cmbmoneda.EditValue, "Comprobante de Recibo No. " & Recibo, TipoCOmpr, Me.FechaCobro.DateTime.Date, Factura,
                        CuentaMtto, MttoMonto, TipoDC, Recibo, IR_Alcaldia, CuentaIR_Alcaldia,
                                                    "Por Recibo No." & Recibo, cmbserie.Text) = True Then

                VB.SysContab.Rutinas.okTransaccion()
                '
                'Guardar Distribucion.
                GuardaDistribucion(
                    DT_Distribucion,
                    FechaCobro.DateTime.Date,
                    Comprobantes.Comp_No)
                '
                DT_Distribucion = CargaDistribucion()

                Try
                    Dim AbonoU As Double = 0,
                   IdArreglo As Integer = 0
                    'Abonas a las cuotas y calcular abono a Arreglo de Pago
                    For i As Integer = 0 To iVista.DataRowCount - 1
                        If iVista.GetRowCellValue(i, "Facturar") = True Then
                            Dim Id As Integer =
                            db.Detalles2(
                            iVista.GetRowCellValue(i, "No Factura"),
                            EmpresaActual).Id

                            Dim _dt As DataTable =
                                    db_ArregloPago.Listar2(
                                        iVista.GetRowCellValue(i, "No Factura"))

                            If _dt.Rows.Count > 0 Then
                                AbonoU += iVista.GetRowCellValue(i, "CobroU")
                                IdArreglo = _dt.Rows.Item(0)("IdArreglo")
                            End If

                            If Id > 0 Then
                                Guardar("sp_upd_FacturasCuotasDetalleAplicar",
                                    Id,
                                    Math.Round(iVista.GetRowCellValue(i, "Cobro"), 2),
                                    Math.Round(iVista.GetRowCellValue(i, "CobroU"), 2),
                                    Comprobantes.Comp_No,
                                    Comprobantes.Per_Id,
                                    FechaCobro.DateTime.Date.Month,
                                    EmpresaActual)
                            End If

                        End If
                    Next
                    '
                    'Actualizar Arreglo de Pago
                    If AbonoU > 0 Then
                        Guardar("sp_upd_ArregloPagoDetalleAplicar",
                                IdArreglo,
                                Math.Round(AbonoU, 2),
                                Comprobantes.Comp_No,
                                Comprobantes.Per_Id,
                                FechaCobro.DateTime.Date.Month,
                                EmpresaActual)
                    End If
                Catch ex As Exception
                    XtraMsg($"Error al Aplicar Cuota de Arreglo de pago{vbCrLf}{ex.Message}",
                            MessageBoxIcon.Error)
                End Try
            Else
                XtraMsg("No se ha podido contabilizar el Recibo.",
                        MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End If
        End If
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

    Private Sub Nuevo()
        LimpiarControles(Me)
        iGrid.DataSource = Nothing
        GetRecibo()
    End Sub

    Private Sub cmdbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbuscar.Click
        'Dim f As New DataGridTextBox.frmComprobanteBuscar1
        'f.ShowDialog()
        'If f.Aceptar = True Then
        '    Me.txtcomprobante.Text = f.dgComprobantes.Item(f.dgComprobantes.CurrentRowIndex, 0)
        '    Me.FechaComprobante.DateTime = f.dgComprobantes.Item(f.dgComprobantes.CurrentRowIndex, 1)
        '    Periodo = f.cbPeriodos.SelectedValue
        'Else

        'End If
    End Sub

    Private Sub cmddiseño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Forma As New FrmConfiguraCheque
        Forma.Tipo = 3
        Forma.Show()
    End Sub

    Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    GetData()
        '    txtnocliente.Text = cmbclientes.EditValue
        '    If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue).Municipio) Is Nothing Then
        '        MsgBox("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS.Contab")
        '        Me.cmdAceptar.Enabled = False
        '    Else
        '        Me.cmdAceptar.Enabled = True
        '    End If

        '    If cmbclientes.EditValue = 0 Then
        '        GridView1.Columns("Cliente").Visible = True
        '    Else
        '        GridView1.Columns("Cliente").Visible = False
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cbClientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If etInicio.Text = "1" Then Exit Sub

        ShowSplash()
        CargarFacturasCliente()
        HideSplash()
    End Sub

    Sub CargarFacturasCliente()
        Try
            GetData()

            txtnocliente.Text = cbClientes.EditValue
            txtRecibimos.Text = cbClientes.Text
            txtPorCuenta.Text = IIf(txtPorCuenta.Text.Trim.Length = 0, "EL MISMO", txtPorCuenta.Text)

            If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(cbClientes.EditValue).Municipio) Is Nothing Then
                XtraMsg("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MessageBoxIcon.Warning)
                Me.cmdAceptar.Enabled = False
            Else
                Me.cmdAceptar.Enabled = True
            End If

            If cbClientes.EditValue = 0 Then
                iVista.Columns("Cliente").Visible = True
            Else
                iVista.Columns("Cliente").Visible = False
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbserie_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserie.EditValueChanged
        If IsNumeric(cmbserie.EditValue) Then
            txtrecibo.Text = cmbserie.EditValue 'Format(cmbserie.EditValue, dd)
        End If
    End Sub

    Private Sub chkAplicar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplicar.CheckedChanged
        If etInicio.Text = "1" Then Exit Sub

        'DistribuirPago()
        'Distribuir()
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbClientes.EditValueChanged
        If etInicio.Text = "1" Then Exit Sub

        ShowSplash()
        CargarFacturasCliente()
        HideSplash()
    End Sub

    Private Sub chkselector_CheckedChanged(sender As Object, e As EventArgs) Handles chkselector.CheckedChanged
        If sender.checked = True Then iVista.ColumnsCustomization() Else iVista.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        chkselector.Checked = False
    End Sub

    'Private Sub Dinero_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtefectivo.Validating, txtcheques.Validating, txttarjetas.Validating, txtefectivoU.Validating
    '    SumarAbonos()
    'End Sub

    'Sub SumarAbonos()
    '    If etInicio.Text = "1" Then Exit Sub

    '    txttotal.EditValue = CDbl(txtefectivo.EditValue) + CDbl(txtcheques.EditValue) + CDbl(txttarjetas.EditValue)

    '    txtefectivoU.EditValue = IIf(txtefectivo.EditValue > 0.00, Math.Round(CDbl(txtefectivo.EditValue / IIf(EmpresaActual = 1, txtTasaParalela.EditValue, txtTasa.EditValue)), 2), 0.00)
    'End Sub

    Private Sub txttotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.EditValueChanged
        If etInicio.Text = "1" Then Exit Sub

        'Distribuir()

        lblMontoLetras.Text = Letras(txttotal.EditValue, VB.SysContab.MonedaDB.GetDetails(MonedaBase).Descripcion)
    End Sub

    'Private Sub txtefectivoU_EditValueChanged(sender As Object, e As EventArgs) Handles txtefectivoU.EditValueChanged
    '    txtefectivo.EditValue = CDbl(txtefectivoU.EditValue * IIf(EmpresaActual = 1, txtTasaParalela.EditValue, txtTasa.EditValue))
    'End Sub

    'Private Sub txtefectivo_EditValueChanged(sender As Object, e As EventArgs) Handles txtefectivo.EditValueChanged
    '    txtefectivoU.EditValue = CDbl(txtefectivo.EditValue / IIf(EmpresaActual = 1, txtTasaParalela.EditValue, txtTasa.EditValue))
    'End Sub

    Private Sub txtcheques_EditValueChanged(sender As Object, e As EventArgs) Handles txtcheques.EditValueChanged, txttarjetas.EditValueChanged
        ' SumarAbonos()
    End Sub

    Private Sub cmbmoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cmbmoneda.EditValueChanged

        'If cmbmoneda.EditValue = MonedaBase Then
        '    lyMontoU.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '    txtefectivo.Properties.ReadOnly = False
        '    txtefectivoU.Properties.ReadOnly = True
        'Else
        '    lyMontoU.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        '    txtefectivo.Properties.ReadOnly = True
        '    txtefectivoU.Properties.ReadOnly = False
        'End If

        lyMonto.Text = "Total Abono en " & cmbmoneda.GetColumnValue("Simbolo").ToString & " :"
        txtefectivo.EditValue = 0.00
        txtEquivalente.EditValue = 0.00
        txttotal.EditValue = 0.00
        '
        DesmarcarFacturas()
        '
        txtefectivo.Focus()
        txtefectivo.SelectAll()
    End Sub

    Private Sub etMntto_MouseClick(sender As Object, e As MouseEventArgs) Handles etMntto.MouseClick
        Dim MttoMonto As Double = 0.00,
            CuentaMtto As String = String.Empty
        '
        _DT_Facturas.AcceptChanges()

        If _DT_Facturas.Select("Facturar = 1").Length > 0 Then
            Dim _DT_Total As DataTable = _DT_Facturas.Select("Facturar = 1").CopyToDataTable()
            MttoMonto = CDbl(_DT_Total.Compute("SUM(Monto_Mantenimiento)", "Facturar = 1"))
        End If

        'With iVista
        '    For i As Integer = 0 To .DataRowCount - 1
        '        If .GetRowCellValue(i, "Facturar") = True Then 'And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then
        '            MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
        '        End If
        '    Next
        'End With
        '
        If MttoMonto = 0.00 Then
            XtraMsg("El Valor del Mantenimiento de Valor debe ser Mayor que Cero (0)",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        'CTemp = ObtieneDatos("sp_sel_RubroGastos",
        '                                 vFacturas.GetRowCellValue(i, "Cuenta"),
        '                                 EmpresaActual).Rows(0).Item("CuentaContable")
        etMntto.Text = MttoMonto.ToString("n2")

        Try
            'Buscar las Cuentas de Matto Valor
            Dim DsPlantillas As DataSet = VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles

            If MttoMonto > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            If MttoMonto < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        Catch ex As Exception
            XtraMsg("No existe Plantilla de Mantenimiento de Valor!",
                    MessageBoxIcon.Error)
            Exit Sub
        End Try
        '
        'Validar si es cuenta de Distribucion.
        If ObtieneDatos("sp_sel_RubroGastos",
                        CuentaMtto,
                        EmpresaActual).Rows.Count = 0 Then
            Exit Sub
        End If

        Try
            Dim frm As New FrmDetalleRequisas
            With frm
                .Monto = Math.Round(Math.Abs(MttoMonto), 2)
                .Tipo = IIf(MttoMonto > 0, "C", "D")
                .Periodo = VB.SysContab.PeriodosDB.Activo(FechaCobro.DateTime.Date)
                .CompNo = 0
                .Cuenta = CuentaMtto
                .Mes = FechaCobro.DateTime.Month
                '
                frm.Mostrar(DT_Distribucion)
                DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        CargarFacturasCliente()
        HideSplash()
    End Sub

    Private Sub txtrecibo_EditValueChanged(sender As Object, e As EventArgs) Handles txtrecibo.EditValueChanged

    End Sub

    Private Sub chkInteres_CheckedChanged(sender As Object, e As EventArgs) Handles chkInteres.CheckedChanged
        If etInicio.Text = "1" Then Exit Sub
        '
        DesmarcarFacturas()


        'If Not chkInteres.Checked Then
        '    For i As Integer = 0 To vDatos.DataRowCount - 1
        '        vDatos.SetRowCellValue(i, "Facturar", False)
        '    Next
        '    vDatos.RefreshData()
        '    _DT_Facturas.AcceptChanges()
        'End If

        'temp2 = True
        'If cmbmoneda.EditValue = MonedaBase Then DistribuirPago() Else DistribuirDalares()
        'temp2 = False
    End Sub

    Sub DesmarcarFacturas()
        For i As Integer = 0 To iVista.DataRowCount - 1
            If CBool(iVista.GetRowCellValue(i, "Facturar")) Then
                iVista.SetRowCellValue(i, "Facturar", False)
            End If
        Next

        iVista.RefreshData()
        _DT_Facturas.AcceptChanges()
    End Sub

    Private Sub txtefectivo_EditValueChanged(sender As Object, e As EventArgs) Handles txtefectivo.EditValueChanged ', txtcheques.EditValueChanged, txttarjetas.EditValueChanged
        txtEquivalente.EditValue = 0.00
        txttotal.EditValue = 0.00
        txtcheques.EditValue = 0.00
        txttarjetas.EditValue = 0.00
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Monto_Mantenimiento" Then
            If iVista.GetRowCellValue(e.RowHandle, "Facturar") Then
                If e.CellValue <> 0 Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If
        '
        If e.Column.FieldName = "Interes" Then
            If iVista.GetRowCellValue(e.RowHandle, "Facturar") Then
                If e.CellValue <> 0 Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If

        If e.Column.FieldName = "Saldo" Then
            If iVista.GetRowCellValue(e.RowHandle, "Facturar") Then
                If iVista.GetRowCellValue(e.RowHandle, "Saldo") = 0.00 Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.Green
                Else
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If
        '
        If e.Column.FieldName = "TC_Paralelo" Then
            If iVista.GetRowCellValue(e.RowHandle, "TC_Paralelo") Then e.Appearance.BackColor = Color.LightPink
        End If

        If e.Column.FieldName = "AP" Then
            If iVista.GetRowCellValue(e.RowHandle, "AP") Then e.Appearance.BackColor = Color.RosyBrown
        End If
        '
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click

        Dim IdCuota As Integer = db.Detalles2(
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "No Factura"),
            EmpresaActual).Id
        '
        Dim _dt As DataTable =
            db_ArregloPago.Listar2(
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "No Factura"))
        '
        If IdCuota = 0 And
            _dt.Rows.Count = 0 Then
            Exit Sub
        End If
        '
        With New frmFacturasCuotasVer
            .Text = $"FACTURACION EN CUOTAS Y ARREGLOS DE PAGOS, FACTURA NO. {iVista.GetFocusedRowCellValue("No Factura")}"
            .Id = IdCuota
            .IdArreglo = IIf(_dt.Rows.Count = 0, 0, _dt.Rows.Item(0)("IdArreglo"))
            .ShowDialog()
            .Dispose()
        End With

    End Sub
End Class

