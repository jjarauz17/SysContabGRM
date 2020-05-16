Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraNavBar
Imports ClasesBLL
Imports SysContab.VB.SysContab

Public Class FrmFacturacionClienteNew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmFacturacionClienteNew = Nothing

    Public Shared Function Instance() As FrmFacturacionClienteNew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmFacturacionClienteNew
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
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vFact As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtdireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtruc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescuentos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdescuentop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbformapago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbvendedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbserie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MnExento As System.Windows.Forms.MenuItem
    Friend WithEvents Existencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckView As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNombreDe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtremision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtorden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCultivos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCondiciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPresentacion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtUnidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPrecioC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPrecioU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFactor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbEmpl As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vEmpl As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rgDespacho As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlertaRemisiones As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents AlertaProyectos As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents AlertaOT As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyNombre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyEmpleado As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblbodega As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblsubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbltotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbliva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbltotalU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipoFactura As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents cbClienteConvenio As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAsociar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProducto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rExento As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents nCotizacion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nOrdenTrabajo As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nProyectos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nOrdenEntrega As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nRemisiones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bVistaPrevia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAgrupar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkVisible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProyecto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacionClienteNew))
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAgrupar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCentroCosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkAsociar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbClienteConvenio = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTipoFactura = New DevExpress.XtraEditors.LookUpEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbBodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbltotalU = New DevExpress.XtraEditors.TextEdit()
        Me.lbltotal = New DevExpress.XtraEditors.TextEdit()
        Me.lbliva = New DevExpress.XtraEditors.TextEdit()
        Me.lblsubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
        Me.lblbodega = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.rgDespacho = New DevExpress.XtraEditors.RadioGroup()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCondiciones = New DevExpress.XtraEditors.TextEdit()
        Me.ckView = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbserie = New DevExpress.XtraEditors.LookUpEdit()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.FechaPago = New DevExpress.XtraEditors.DateEdit()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vFact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProducto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Existencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPresentacion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtUnidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFactor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rExento = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProyecto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbCultivos = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbvendedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtfactura = New DevExpress.XtraEditors.TextEdit()
        Me.cmbformapago = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtremision = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreDe = New DevExpress.XtraEditors.TextEdit()
        Me.txtorden = New DevExpress.XtraEditors.TextEdit()
        Me.cbEmpl = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vEmpl = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtruc = New DevExpress.XtraEditors.TextEdit()
        Me.txtpais = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoEntrega = New DevExpress.XtraEditors.TextEdit()
        Me.txtdepto = New DevExpress.XtraEditors.TextEdit()
        Me.txttelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtmunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.txtdireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyNombre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyEmpleado = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bVistaPrevia = New DevExpress.XtraEditors.SimpleButton()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nProyectos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nRemisiones = New DevExpress.XtraNavBar.NavBarItem()
        Me.nOrdenTrabajo = New DevExpress.XtraNavBar.NavBarItem()
        Me.nCotizacion = New DevExpress.XtraNavBar.NavBarItem()
        Me.nOrdenEntrega = New DevExpress.XtraNavBar.NavBarItem()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtdescuentos = New DevExpress.XtraEditors.TextEdit()
        Me.txtdescuentop = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SubMenu = New System.Windows.Forms.ContextMenu()
        Me.MnExento = New System.Windows.Forms.MenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlertaRemisiones = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.AlertaProyectos = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.AlertaOT = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAsociar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClienteConvenio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbltotalU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbltotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbliva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblsubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgDespacho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbserie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rExento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbvendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtorden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vEmpl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbmoneda
        '
        Me.cmbmoneda.EnterMoveNextControl = True
        Me.cmbmoneda.Location = New System.Drawing.Point(334, 134)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(228, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl1
        Me.cmbmoneda.TabIndex = 4
        Me.cmbmoneda.TabStop = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkVisible)
        Me.LayoutControl1.Controls.Add(Me.chkAgrupar)
        Me.LayoutControl1.Controls.Add(Me.cbCentroCosto)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.chkAsociar)
        Me.LayoutControl1.Controls.Add(Me.cbClienteConvenio)
        Me.LayoutControl1.Controls.Add(Me.cbTipoFactura)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit2)
        Me.LayoutControl1.Controls.Add(Me.cbBodega)
        Me.LayoutControl1.Controls.Add(Me.lbltotalU)
        Me.LayoutControl1.Controls.Add(Me.lbltotal)
        Me.LayoutControl1.Controls.Add(Me.lbliva)
        Me.LayoutControl1.Controls.Add(Me.lblsubtotal)
        Me.LayoutControl1.Controls.Add(Me.TipoServicio)
        Me.LayoutControl1.Controls.Add(Me.lblbodega)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.rgDespacho)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Controls.Add(Me.txtCondiciones)
        Me.LayoutControl1.Controls.Add(Me.ckView)
        Me.LayoutControl1.Controls.Add(Me.cmbserie)
        Me.LayoutControl1.Controls.Add(Me.fecha)
        Me.LayoutControl1.Controls.Add(Me.FechaPago)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.etTasa)
        Me.LayoutControl1.Controls.Add(Me.cbCultivos)
        Me.LayoutControl1.Controls.Add(Me.cmbvendedor)
        Me.LayoutControl1.Controls.Add(Me.txtfactura)
        Me.LayoutControl1.Controls.Add(Me.cmbformapago)
        Me.LayoutControl1.Controls.Add(Me.txtremision)
        Me.LayoutControl1.Controls.Add(Me.txtNombreDe)
        Me.LayoutControl1.Controls.Add(Me.txtorden)
        Me.LayoutControl1.Controls.Add(Me.cbEmpl)
        Me.LayoutControl1.Controls.Add(Me.txtruc)
        Me.LayoutControl1.Controls.Add(Me.txtpais)
        Me.LayoutControl1.Controls.Add(Me.txtNoEntrega)
        Me.LayoutControl1.Controls.Add(Me.txtdepto)
        Me.LayoutControl1.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl1.Controls.Add(Me.txttelefono)
        Me.LayoutControl1.Controls.Add(Me.txtmunicipio)
        Me.LayoutControl1.Controls.Add(Me.txtdireccion)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1077, 290, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(833, 663)
        Me.LayoutControl1.TabIndex = 183
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(679, 206)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkVisible.Properties.Appearance.Options.UseFont = True
        Me.chkVisible.Properties.Appearance.Options.UseForeColor = True
        Me.chkVisible.Properties.Caption = "Visible"
        Me.chkVisible.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkVisible.Size = New System.Drawing.Size(63, 22)
        Me.chkVisible.StyleController = Me.LayoutControl1
        Me.chkVisible.TabIndex = 200
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Location = New System.Drawing.Point(746, 206)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgrupar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkAgrupar.Properties.Appearance.Options.UseFont = True
        Me.chkAgrupar.Properties.Appearance.Options.UseForeColor = True
        Me.chkAgrupar.Properties.Caption = "Agrupar"
        Me.chkAgrupar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAgrupar.Size = New System.Drawing.Size(75, 22)
        Me.chkAgrupar.StyleController = Me.LayoutControl1
        Me.chkAgrupar.TabIndex = 199
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCentroCosto.EnterMoveNextControl = True
        Me.cbCentroCosto.Location = New System.Drawing.Point(386, 110)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbCentroCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCentroCosto.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbCentroCosto.Properties.Appearance.Options.UseBackColor = True
        Me.cbCentroCosto.Properties.Appearance.Options.UseFont = True
        Me.cbCentroCosto.Properties.Appearance.Options.UseForeColor = True
        Me.cbCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Properties.NullText = ""
        Me.cbCentroCosto.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCentroCosto.Properties.ShowFooter = False
        Me.cbCentroCosto.Properties.ShowHeader = False
        Me.cbCentroCosto.Size = New System.Drawing.Size(114, 20)
        Me.cbCentroCosto.StyleController = Me.LayoutControl1
        Me.cbCentroCosto.TabIndex = 185
        Me.cbCentroCosto.TabStop = False
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(91, 12)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.Appearance.Options.UseBackColor = True
        Me.cbCliente.Properties.Appearance.Options.UseFont = True
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.View = Me.GridView1
        Me.cbCliente.Size = New System.Drawing.Size(126, 22)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 201
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'chkAsociar
        '
        Me.chkAsociar.Location = New System.Drawing.Point(449, 232)
        Me.chkAsociar.Name = "chkAsociar"
        Me.chkAsociar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAsociar.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.chkAsociar.Properties.Appearance.Options.UseFont = True
        Me.chkAsociar.Properties.Appearance.Options.UseForeColor = True
        Me.chkAsociar.Properties.Caption = "Asociar a convenio"
        Me.chkAsociar.Size = New System.Drawing.Size(136, 19)
        Me.chkAsociar.StyleController = Me.LayoutControl1
        Me.chkAsociar.TabIndex = 200
        '
        'cbClienteConvenio
        '
        Me.cbClienteConvenio.Location = New System.Drawing.Point(589, 232)
        Me.cbClienteConvenio.Name = "cbClienteConvenio"
        Me.cbClienteConvenio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClienteConvenio.Properties.View = Me.SearchLookUpEdit1View
        Me.cbClienteConvenio.Size = New System.Drawing.Size(232, 20)
        Me.cbClienteConvenio.StyleController = Me.LayoutControl1
        Me.cbClienteConvenio.TabIndex = 199
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbTipoFactura
        '
        Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoFactura.EnterMoveNextControl = True
        Me.cbTipoFactura.Location = New System.Drawing.Point(521, 182)
        Me.cbTipoFactura.Name = "cbTipoFactura"
        EditorButtonImageOptions1.EnableTransparency = False
        ToolTipItem1.Text = "Agrear Tipo de Cultivo"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.cbTipoFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1)})
        Me.cbTipoFactura.Properties.NullText = ""
        Me.cbTipoFactura.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbTipoFactura.Properties.ShowFooter = False
        Me.cbTipoFactura.Properties.ShowHeader = False
        Me.cbTipoFactura.Size = New System.Drawing.Size(206, 20)
        Me.cbTipoFactura.StyleController = Me.LayoutControl1
        Me.cbTipoFactura.TabIndex = 185
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(449, 206)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "Cliente Exento de IVA"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit2.Size = New System.Drawing.Size(226, 22)
        Me.CheckEdit2.StyleController = Me.LayoutControl1
        Me.CheckEdit2.TabIndex = 198
        '
        'cbBodega
        '
        Me.cbBodega.Location = New System.Drawing.Point(318, 627)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbBodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.Appearance.Options.UseBackColor = True
        Me.cbBodega.Properties.Appearance.Options.UseFont = True
        Me.cbBodega.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbBodega.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodega.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbBodega.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodega.Properties.ReadOnly = True
        Me.cbBodega.Size = New System.Drawing.Size(247, 22)
        Me.cbBodega.StyleController = Me.LayoutControl1
        Me.cbBodega.TabIndex = 197
        '
        'lbltotalU
        '
        Me.lbltotalU.Location = New System.Drawing.Point(648, 627)
        Me.lbltotalU.Name = "lbltotalU"
        Me.lbltotalU.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotalU.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalU.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lbltotalU.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lbltotalU.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lbltotalU.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lbltotalU.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lbltotalU.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbltotalU.Properties.Mask.EditMask = "n2"
        Me.lbltotalU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lbltotalU.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lbltotalU.Properties.ReadOnly = True
        Me.lbltotalU.Size = New System.Drawing.Size(173, 24)
        Me.lbltotalU.StyleController = Me.LayoutControl1
        Me.lbltotalU.TabIndex = 196
        '
        'lbltotal
        '
        Me.lbltotal.Location = New System.Drawing.Point(648, 599)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lbltotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lbltotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lbltotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lbltotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lbltotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbltotal.Properties.Mask.EditMask = "n2"
        Me.lbltotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lbltotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lbltotal.Properties.ReadOnly = True
        Me.lbltotal.Size = New System.Drawing.Size(173, 24)
        Me.lbltotal.StyleController = Me.LayoutControl1
        Me.lbltotal.TabIndex = 195
        '
        'lbliva
        '
        Me.lbliva.Location = New System.Drawing.Point(449, 599)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbliva.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lbliva.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lbliva.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lbliva.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lbliva.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lbliva.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbliva.Properties.Mask.EditMask = "n2"
        Me.lbliva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lbliva.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lbliva.Properties.ReadOnly = True
        Me.lbliva.Size = New System.Drawing.Size(116, 20)
        Me.lbliva.StyleController = Me.LayoutControl1
        Me.lbliva.TabIndex = 194
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Location = New System.Drawing.Point(229, 599)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblsubtotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.lblsubtotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lblsubtotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lblsubtotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lblsubtotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.lblsubtotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblsubtotal.Properties.Mask.EditMask = "n2"
        Me.lblsubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.lblsubtotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.lblsubtotal.Properties.ReadOnly = True
        Me.lblsubtotal.Size = New System.Drawing.Size(137, 20)
        Me.lblsubtotal.StyleController = Me.LayoutControl1
        Me.lblsubtotal.TabIndex = 193
        '
        'TipoServicio
        '
        Me.TipoServicio.Location = New System.Drawing.Point(12, 150)
        Me.TipoServicio.Name = "TipoServicio"
        Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
        Me.TipoServicio.Properties.Appearance.Options.UseFont = True
        Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
        Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Servicios"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos")})
        Me.TipoServicio.Size = New System.Drawing.Size(239, 52)
        Me.TipoServicio.StyleController = Me.LayoutControl1
        Me.TipoServicio.TabIndex = 192
        '
        'lblbodega
        '
        Me.lblbodega.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbodega.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblbodega.Appearance.Options.UseFont = True
        Me.lblbodega.Appearance.Options.UseForeColor = True
        Me.lblbodega.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblbodega.Location = New System.Drawing.Point(91, 627)
        Me.lblbodega.Name = "lblbodega"
        Me.lblbodega.Size = New System.Drawing.Size(144, 14)
        Me.lblbodega.StyleController = Me.LayoutControl1
        Me.lblbodega.TabIndex = 190
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(255, 158)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Imprimir en Dolares"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(148, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 188
        '
        'rgDespacho
        '
        Me.rgDespacho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgDespacho.EditValue = "B"
        Me.rgDespacho.Location = New System.Drawing.Point(731, 150)
        Me.rgDespacho.Name = "rgDespacho"
        Me.rgDespacho.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgDespacho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgDespacho.Properties.Appearance.Options.UseBackColor = True
        Me.rgDespacho.Properties.Appearance.Options.UseFont = True
        Me.rgDespacho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgDespacho.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Bodega"), New DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Mostrador")})
        Me.rgDespacho.Size = New System.Drawing.Size(90, 52)
        Me.rgDespacho.StyleController = Me.LayoutControl1
        Me.rgDespacho.TabIndex = 187
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(91, 206)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(354, 43)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 189
        '
        'txtCondiciones
        '
        Me.txtCondiciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondiciones.EnterMoveNextControl = True
        Me.txtCondiciones.Location = New System.Drawing.Point(583, 86)
        Me.txtCondiciones.Name = "txtCondiciones"
        Me.txtCondiciones.Properties.MaxLength = 254
        Me.txtCondiciones.Size = New System.Drawing.Size(238, 20)
        Me.txtCondiciones.StyleController = Me.LayoutControl1
        Me.txtCondiciones.TabIndex = 8
        Me.txtCondiciones.TabStop = False
        '
        'ckView
        '
        Me.ckView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckView.EditValue = True
        Me.ckView.Location = New System.Drawing.Point(221, 12)
        Me.ckView.Name = "ckView"
        Me.ckView.Properties.Caption = "Serie:"
        Me.ckView.Size = New System.Drawing.Size(46, 19)
        Me.ckView.StyleController = Me.LayoutControl1
        Me.ckView.TabIndex = 2
        Me.ckView.TabStop = False
        '
        'cmbserie
        '
        Me.cmbserie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbserie.EnterMoveNextControl = True
        Me.cmbserie.Location = New System.Drawing.Point(271, 12)
        Me.cmbserie.Name = "cmbserie"
        EditorButtonImageOptions2.EnableTransparency = False
        Me.cmbserie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Refrescar Datos")})
        Me.cmbserie.Properties.NullText = ""
        Me.cmbserie.Properties.ShowFooter = False
        Me.cmbserie.Properties.ShowHeader = False
        Me.cmbserie.Size = New System.Drawing.Size(50, 20)
        Me.cmbserie.StyleController = Me.LayoutControl1
        Me.cmbserie.TabIndex = 2
        '
        'fecha
        '
        Me.fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha.EditValue = New Date(2014, 11, 14, 14, 26, 40, 0)
        Me.fecha.EnterMoveNextControl = True
        Me.fecha.Location = New System.Drawing.Point(574, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Properties.Mask.BeepOnError = True
        Me.fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fecha.Size = New System.Drawing.Size(82, 20)
        Me.fecha.StyleController = Me.LayoutControl1
        Me.fecha.TabIndex = 4
        Me.fecha.TabStop = False
        '
        'FechaPago
        '
        Me.FechaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaPago.EditValue = Nothing
        Me.FechaPago.EnterMoveNextControl = True
        Me.FechaPago.Location = New System.Drawing.Point(739, 12)
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FechaPago.Properties.Mask.BeepOnError = True
        Me.FechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaPago.Size = New System.Drawing.Size(82, 20)
        Me.FechaPago.StyleController = Me.LayoutControl1
        Me.FechaPago.TabIndex = 5
        Me.FechaPago.TabStop = False
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 256)
        Me.GridDetalle.LookAndFeel.SkinName = "The Asphalt World"
        Me.GridDetalle.MainView = Me.vFact
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPresentacion, Me.txtUnidad, Me.txtPrecioC, Me.txtPrecioU, Me.txtFactor, Me.rLink, Me.cbProducto, Me.rExento, Me.cbProyecto})
        Me.GridDetalle.Size = New System.Drawing.Size(809, 339)
        Me.GridDetalle.TabIndex = 16
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFact})
        '
        'vFact
        '
        Me.vFact.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.vFact.Appearance.EvenRow.Options.UseBackColor = True
        Me.vFact.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.Existencia, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn3, Me.GridColumn11, Me.GridColumn13, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn12, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn24, Me.GridColumn1, Me.GridColumn23, Me.GridColumn25})
        Me.vFact.GridControl = Me.GridDetalle
        Me.vFact.Name = "vFact"
        Me.vFact.OptionsCustomization.AllowColumnMoving = False
        Me.vFact.OptionsCustomization.AllowFilter = False
        Me.vFact.OptionsCustomization.AllowGroup = False
        Me.vFact.OptionsCustomization.AllowSort = False
        Me.vFact.OptionsFilter.AllowFilterEditor = False
        Me.vFact.OptionsFilter.AllowMRUFilterList = False
        Me.vFact.OptionsNavigation.EnterMoveNextColumn = True
        Me.vFact.OptionsView.EnableAppearanceEvenRow = True
        Me.vFact.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vFact.OptionsView.ShowFooter = True
        Me.vFact.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.ColumnEdit = Me.cbProducto
        Me.GridColumn2.FieldName = "Item"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Item", "{0:n0}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 134
        '
        'cbProducto
        '
        Me.cbProducto.AutoHeight = False
        ToolTipTitleItem1.Text = "Comentario"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Agregar Comentario Adicional"
        SuperToolTip2.Items.Add(ToolTipTitleItem1)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.cbProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Agregar Comentario Adicional", Nothing, SuperToolTip2)})
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.NullText = "[Agregar]"
        Me.cbProducto.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Existencia
        '
        Me.Existencia.AppearanceCell.Options.UseTextOptions = True
        Me.Existencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Existencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existencia.AppearanceHeader.Options.UseFont = True
        Me.Existencia.AppearanceHeader.Options.UseTextOptions = True
        Me.Existencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Existencia.Caption = "Existencia"
        Me.Existencia.DisplayFormat.FormatString = "{0:n2}"
        Me.Existencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Existencia.FieldName = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.OptionsColumn.AllowEdit = False
        Me.Existencia.OptionsColumn.AllowFocus = False
        Me.Existencia.OptionsColumn.ReadOnly = True
        Me.Existencia.Visible = True
        Me.Existencia.VisibleIndex = 1
        Me.Existencia.Width = 59
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Present."
        Me.GridColumn14.ColumnEdit = Me.txtPresentacion
        Me.GridColumn14.FieldName = "Presentacion"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 45
        '
        'txtPresentacion
        '
        Me.txtPresentacion.AutoHeight = False
        Me.txtPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPresentacion.Name = "txtPresentacion"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "U/M"
        Me.GridColumn15.ColumnEdit = Me.txtUnidad
        Me.GridColumn15.FieldName = "Unidad"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 45
        '
        'txtUnidad
        '
        Me.txtUnidad.AutoHeight = False
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Name = "txtUnidad"
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Factor"
        Me.GridColumn16.ColumnEdit = Me.txtFactor
        Me.GridColumn16.FieldName = "Factor"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        Me.GridColumn16.Width = 45
        '
        'txtFactor
        '
        Me.txtFactor.AutoHeight = False
        Me.txtFactor.Mask.EditMask = "n4"
        Me.txtFactor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFactor.Mask.UseMaskAsDisplayFormat = True
        Me.txtFactor.Name = "txtFactor"
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn17.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Cantidad"
        Me.GridColumn17.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "Despacho"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        Me.GridColumn17.Width = 46
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Real"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Cantidad"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 50
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn11.Caption = "Promocion"
        Me.GridColumn11.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Promocion"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 85
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Precio U$"
        Me.GridColumn13.ColumnEdit = Me.txtPrecioU
        Me.GridColumn13.FieldName = "PrecioU"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 57
        '
        'txtPrecioU
        '
        Me.txtPrecioU.AutoHeight = False
        Me.txtPrecioU.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioU.Name = "txtPrecioU"
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Precio C$"
        Me.GridColumn4.ColumnEdit = Me.txtPrecioC
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 8
        Me.GridColumn4.Width = 76
        '
        'txtPrecioC
        '
        Me.txtPrecioC.AutoHeight = False
        Me.txtPrecioC.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioC.Name = "txtPrecioC"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "% Descuento"
        Me.GridColumn6.DisplayFormat.FormatString = "P2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Descuento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 9
        Me.GridColumn6.Width = 68
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Sub Total"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 10
        Me.GridColumn5.Width = 73
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IVA"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "IVA"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "Cuenta"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "Tipo"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Exento"
        Me.GridColumn10.ColumnEdit = Me.rExento
        Me.GridColumn10.FieldName = "Exento"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 11
        Me.GridColumn10.Width = 45
        '
        'rExento
        '
        Me.rExento.AutoHeight = False
        Me.rExento.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.rExento.Name = "rExento"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Costo"
        Me.GridColumn12.FieldName = "Costo"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Modelo"
        Me.GridColumn18.FieldName = "Modelo"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "NoSerie"
        Me.GridColumn19.FieldName = "NoSerie"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Comentario"
        Me.GridColumn20.FieldName = "Comentario"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Margen"
        Me.GridColumn21.FieldName = "Margen"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn22.AppearanceHeader.Options.UseFont = True
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.Caption = "#"
        Me.GridColumn22.ColumnEdit = Me.rLink
        Me.GridColumn22.FieldName = "#"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 12
        Me.GridColumn22.Width = 53
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Digital"
        Me.rLink.Name = "rLink"
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn24.AppearanceHeader.Options.UseFont = True
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "Proyecto"
        Me.GridColumn24.ColumnEdit = Me.cbProyecto
        Me.GridColumn24.FieldName = "IdProyecto"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoHeight = False
        Me.cbProyecto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.NullText = "[Proyecto]"
        Me.cbProyecto.View = Me.GridView2
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
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Agrupar"
        Me.GridColumn1.FieldName = "Agrupar"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn23.AppearanceHeader.Options.UseFont = True
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "Visible"
        Me.GridColumn23.ColumnEdit = Me.rExento
        Me.GridColumn23.FieldName = "Visible"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "IdDetalle"
        Me.GridColumn25.FieldName = "IdDetalle"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.AllowFocus = False
        '
        'etTasa
        '
        Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(645, 134)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.etTasa.Size = New System.Drawing.Size(82, 20)
        Me.etTasa.StyleController = Me.LayoutControl1
        Me.etTasa.TabIndex = 7
        '
        'cbCultivos
        '
        Me.cbCultivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCultivos.EnterMoveNextControl = True
        Me.cbCultivos.Location = New System.Drawing.Point(486, 158)
        Me.cbCultivos.Name = "cbCultivos"
        EditorButtonImageOptions4.EnableTransparency = False
        ToolTipItem3.Text = "Agrear Tipo de Cultivo"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.cbCultivos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, SuperToolTip3)})
        Me.cbCultivos.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        Me.cbCultivos.Properties.NullText = ""
        Me.cbCultivos.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCultivos.Properties.ShowFooter = False
        Me.cbCultivos.Size = New System.Drawing.Size(241, 20)
        Me.cbCultivos.StyleController = Me.LayoutControl1
        Me.cbCultivos.TabIndex = 9
        '
        'cmbvendedor
        '
        Me.cmbvendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbvendedor.EnterMoveNextControl = True
        Me.cmbvendedor.Location = New System.Drawing.Point(91, 110)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbvendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvendedor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbvendedor.Properties.Appearance.Options.UseBackColor = True
        Me.cmbvendedor.Properties.Appearance.Options.UseFont = True
        Me.cmbvendedor.Properties.Appearance.Options.UseForeColor = True
        Me.cmbvendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbvendedor.Properties.NullText = ""
        Me.cmbvendedor.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbvendedor.Properties.ShowFooter = False
        Me.cmbvendedor.Properties.ShowHeader = False
        Me.cmbvendedor.Size = New System.Drawing.Size(212, 20)
        Me.cmbvendedor.StyleController = Me.LayoutControl1
        Me.cmbvendedor.TabIndex = 8
        Me.cmbvendedor.TabStop = False
        '
        'txtfactura
        '
        Me.txtfactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfactura.EditValue = ""
        Me.txtfactura.EnterMoveNextControl = True
        Me.txtfactura.Location = New System.Drawing.Point(404, 12)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtfactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtfactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtfactura.Properties.ReadOnly = True
        Me.txtfactura.Size = New System.Drawing.Size(87, 20)
        Me.txtfactura.StyleController = Me.LayoutControl1
        Me.txtfactura.TabIndex = 3
        Me.txtfactura.TabStop = False
        '
        'cmbformapago
        '
        Me.cmbformapago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbformapago.EnterMoveNextControl = True
        Me.cmbformapago.Location = New System.Drawing.Point(334, 182)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbformapago.Properties.NullText = ""
        Me.cmbformapago.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbformapago.Properties.ShowFooter = False
        Me.cmbformapago.Properties.ShowHeader = False
        Me.cmbformapago.Size = New System.Drawing.Size(104, 20)
        Me.cmbformapago.StyleController = Me.LayoutControl1
        Me.cmbformapago.TabIndex = 10
        '
        'txtremision
        '
        Me.txtremision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtremision.EnterMoveNextControl = True
        Me.txtremision.Location = New System.Drawing.Point(583, 38)
        Me.txtremision.Name = "txtremision"
        Me.txtremision.Properties.MaxLength = 254
        Me.txtremision.Size = New System.Drawing.Size(238, 20)
        Me.txtremision.StyleController = Me.LayoutControl1
        Me.txtremision.TabIndex = 6
        Me.txtremision.TabStop = False
        '
        'txtNombreDe
        '
        Me.txtNombreDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreDe.EditValue = ""
        Me.txtNombreDe.EnterMoveNextControl = True
        Me.txtNombreDe.Location = New System.Drawing.Point(91, 38)
        Me.txtNombreDe.Name = "txtNombreDe"
        Me.txtNombreDe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDe.Properties.Appearance.Options.UseFont = True
        Me.txtNombreDe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreDe.Properties.MaxLength = 130
        Me.txtNombreDe.Size = New System.Drawing.Size(276, 20)
        Me.txtNombreDe.StyleController = Me.LayoutControl1
        Me.txtNombreDe.TabIndex = 1
        Me.txtNombreDe.TabStop = False
        '
        'txtorden
        '
        Me.txtorden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtorden.EnterMoveNextControl = True
        Me.txtorden.Location = New System.Drawing.Point(583, 62)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Properties.MaxLength = 254
        Me.txtorden.Size = New System.Drawing.Size(238, 20)
        Me.txtorden.StyleController = Me.LayoutControl1
        Me.txtorden.TabIndex = 7
        Me.txtorden.TabStop = False
        '
        'cbEmpl
        '
        Me.cbEmpl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEmpl.EditValue = "[Seleccione Empleado]"
        Me.cbEmpl.Location = New System.Drawing.Point(450, 38)
        Me.cbEmpl.Name = "cbEmpl"
        Me.cbEmpl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpl.Properties.Appearance.Options.UseFont = True
        Me.cbEmpl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpl.Properties.NullText = "[Seleccione Empleado]"
        Me.cbEmpl.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbEmpl.Properties.View = Me.vEmpl
        Me.cbEmpl.Size = New System.Drawing.Size(50, 20)
        Me.cbEmpl.StyleController = Me.LayoutControl1
        Me.cbEmpl.TabIndex = 1
        '
        'vEmpl
        '
        Me.vEmpl.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vEmpl.Name = "vEmpl"
        Me.vEmpl.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vEmpl.OptionsView.ShowGroupPanel = False
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(91, 62)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtruc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtruc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtruc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtruc.Properties.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(74, 20)
        Me.txtruc.StyleController = Me.LayoutControl1
        Me.txtruc.TabIndex = 0
        Me.txtruc.TabStop = False
        '
        'txtpais
        '
        Me.txtpais.Location = New System.Drawing.Point(248, 62)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtpais.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpais.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtpais.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtpais.Properties.ReadOnly = True
        Me.txtpais.Size = New System.Drawing.Size(74, 20)
        Me.txtpais.StyleController = Me.LayoutControl1
        Me.txtpais.TabIndex = 1
        Me.txtpais.TabStop = False
        '
        'txtNoEntrega
        '
        Me.txtNoEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoEntrega.EnterMoveNextControl = True
        Me.txtNoEntrega.Location = New System.Drawing.Point(583, 110)
        Me.txtNoEntrega.Name = "txtNoEntrega"
        Me.txtNoEntrega.Properties.MaxLength = 254
        Me.txtNoEntrega.Size = New System.Drawing.Size(238, 20)
        Me.txtNoEntrega.StyleController = Me.LayoutControl1
        Me.txtNoEntrega.TabIndex = 11
        Me.txtNoEntrega.TabStop = False
        '
        'txtdepto
        '
        Me.txtdepto.Location = New System.Drawing.Point(248, 86)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdepto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdepto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdepto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdepto.Properties.ReadOnly = True
        Me.txtdepto.Size = New System.Drawing.Size(74, 20)
        Me.txtdepto.StyleController = Me.LayoutControl1
        Me.txtdepto.TabIndex = 2
        Me.txtdepto.TabStop = False
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttelefono.Location = New System.Drawing.Point(91, 86)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txttelefono.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txttelefono.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txttelefono.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txttelefono.Properties.ReadOnly = True
        Me.txttelefono.Size = New System.Drawing.Size(119, 20)
        Me.txttelefono.StyleController = Me.LayoutControl1
        Me.txttelefono.TabIndex = 5
        Me.txttelefono.TabStop = False
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmunicipio.Location = New System.Drawing.Point(91, 86)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtmunicipio.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtmunicipio.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtmunicipio.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtmunicipio.Properties.ReadOnly = True
        Me.txtmunicipio.Size = New System.Drawing.Size(74, 20)
        Me.txtmunicipio.StyleController = Me.LayoutControl1
        Me.txtmunicipio.TabIndex = 6
        Me.txtmunicipio.TabStop = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdireccion.Location = New System.Drawing.Point(405, 62)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdireccion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdireccion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdireccion.Properties.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(95, 44)
        Me.txtdireccion.StyleController = Me.LayoutControl1
        Me.txtdireccion.TabIndex = 3
        Me.txtdireccion.TabStop = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txttelefono
        Me.LayoutControlItem13.CustomizationFormText = "Telefono:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem13.Text = "Telefono:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.lyNombre, Me.LayoutControlItem7, Me.lyEmpleado, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem27, Me.LayoutControlItem33, Me.LayoutControlItem28, Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem14, Me.LayoutControlItem12, Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem26, Me.LayoutControlItem43, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem17, Me.LayoutControlItem44, Me.LayoutControlItem46, Me.LayoutControlItem47, Me.LayoutControlItem49, Me.LayoutControlItem48, Me.LayoutControlItem1, Me.LayoutControlItem45, Me.LayoutControlItem38, Me.LayoutControlItem39})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(833, 663)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ckView
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(209, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(50, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(50, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(50, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbserie
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(259, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtfactura
        Me.LayoutControlItem4.CustomizationFormText = "No Factura:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(313, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(170, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(170, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(170, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "No Factura:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.fecha
        Me.LayoutControlItem5.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(483, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Fecha:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.FechaPago
        Me.LayoutControlItem6.CustomizationFormText = "Vencimiento:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(648, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(165, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Vencimiento:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(76, 13)
        '
        'lyNombre
        '
        Me.lyNombre.Control = Me.txtNombreDe
        Me.lyNombre.CustomizationFormText = "A Nombre de:"
        Me.lyNombre.Location = New System.Drawing.Point(0, 26)
        Me.lyNombre.Name = "lyNombre"
        Me.lyNombre.Size = New System.Drawing.Size(359, 24)
        Me.lyNombre.Text = "A Nombre de:"
        Me.lyNombre.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtremision
        Me.LayoutControlItem7.CustomizationFormText = "Remisión:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(492, 26)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Remisión:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(76, 13)
        '
        'lyEmpleado
        '
        Me.lyEmpleado.Control = Me.cbEmpl
        Me.lyEmpleado.CustomizationFormText = "Empleado:"
        Me.lyEmpleado.Location = New System.Drawing.Point(359, 26)
        Me.lyEmpleado.Name = "lyEmpleado"
        Me.lyEmpleado.Size = New System.Drawing.Size(133, 24)
        Me.lyEmpleado.Text = "Empleado:"
        Me.lyEmpleado.TextSize = New System.Drawing.Size(76, 13)
        Me.lyEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtComentario
        Me.LayoutControlItem24.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 194)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(0, 47)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(93, 47)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(437, 50)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.Text = "Comentario:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.GridDetalle
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 244)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(813, 343)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.rgDespacho
        Me.LayoutControlItem27.CustomizationFormText = "Despacho"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(719, 122)
        Me.LayoutControlItem27.MaxSize = New System.Drawing.Size(94, 72)
        Me.LayoutControlItem27.MinSize = New System.Drawing.Size(94, 72)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(94, 72)
        Me.LayoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem27.Text = "Despacho"
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.TipoServicio
        Me.LayoutControlItem33.CustomizationFormText = "Tipo Factura"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem33.MaxSize = New System.Drawing.Size(243, 72)
        Me.LayoutControlItem33.MinSize = New System.Drawing.Size(243, 72)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(243, 72)
        Me.LayoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem33.Text = "Tipo Factura"
        Me.LayoutControlItem33.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem28.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem28.Control = Me.lblbodega
        Me.LayoutControlItem28.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 615)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(227, 28)
        Me.LayoutControlItem28.Text = "Bodega:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(76, 14)
        Me.LayoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 587)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(138, 28)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCondiciones
        Me.LayoutControlItem10.CustomizationFormText = "Condiciones:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(492, 74)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Condiciones:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtorden
        Me.LayoutControlItem9.CustomizationFormText = "O/C:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(492, 50)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "O/C:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtruc
        Me.LayoutControlItem8.CustomizationFormText = "#RUC:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem8.Text = "#RUC:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtpais
        Me.LayoutControlItem11.CustomizationFormText = "Pais:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(157, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem11.Text = "Pais:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtdireccion
        Me.LayoutControlItem15.CustomizationFormText = "Dirección:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(314, 50)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(178, 48)
        Me.LayoutControlItem15.Text = "Dirección:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtmunicipio
        Me.LayoutControlItem14.CustomizationFormText = "Municipio:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem14.Text = "Municipio:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtdepto
        Me.LayoutControlItem12.CustomizationFormText = "Departamento:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(157, 74)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(157, 24)
        Me.LayoutControlItem12.Text = "Departamento:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.etTasa
        Me.LayoutControlItem19.CustomizationFormText = "T/Cambio:"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(554, 122)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "T/Cambio:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtNoEntrega
        Me.LayoutControlItem18.CustomizationFormText = "O/ Entrega:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(492, 98)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "O/ Entrega:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.CheckEdit1
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(243, 146)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.lblsubtotal
        Me.LayoutControlItem43.CustomizationFormText = "Sub Total:"
        Me.LayoutControlItem43.Location = New System.Drawing.Point(138, 587)
        Me.LayoutControlItem43.MaxSize = New System.Drawing.Size(220, 28)
        Me.LayoutControlItem43.MinSize = New System.Drawing.Size(220, 28)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(220, 28)
        Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem43.Text = "Sub Total:"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.lbliva
        Me.LayoutControlItem29.CustomizationFormText = "IVA:"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(358, 587)
        Me.LayoutControlItem29.MaxSize = New System.Drawing.Size(199, 28)
        Me.LayoutControlItem29.MinSize = New System.Drawing.Size(199, 28)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(199, 28)
        Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem29.Text = "IVA:"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.lbltotal
        Me.LayoutControlItem30.CustomizationFormText = "Total:"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(557, 587)
        Me.LayoutControlItem30.MaxSize = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem30.MinSize = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem30.Text = "Total:"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.lbltotalU
        Me.LayoutControlItem31.CustomizationFormText = "Total U$:"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(557, 615)
        Me.LayoutControlItem31.MaxSize = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem31.MinSize = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(256, 28)
        Me.LayoutControlItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem31.Text = "Total U$:"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cbCultivos
        Me.LayoutControlItem21.CustomizationFormText = "Tipo Cultivo:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(395, 146)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(324, 24)
        Me.LayoutControlItem21.Text = "Tipo Cultivo:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cmbvendedor
        Me.LayoutControlItem22.CustomizationFormText = "Vendedor:"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(295, 24)
        Me.LayoutControlItem22.Text = "Vendedor:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmbformapago
        Me.LayoutControlItem23.CustomizationFormText = "Forma de Pago:"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(243, 170)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(187, 24)
        Me.LayoutControlItem23.Text = "Forma de Pago:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmbmoneda
        Me.LayoutControlItem17.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(243, 122)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem17.Text = "Moneda:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem44.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red
        Me.LayoutControlItem44.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem44.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem44.Control = Me.cbBodega
        Me.LayoutControlItem44.Location = New System.Drawing.Point(227, 615)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(330, 28)
        Me.LayoutControlItem44.Text = "Bodega:"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(76, 14)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cbTipoFactura
        Me.LayoutControlItem46.Location = New System.Drawing.Point(430, 170)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem46.Text = "Tipo:"
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.cbClienteConvenio
        Me.LayoutControlItem47.Location = New System.Drawing.Point(577, 220)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(236, 24)
        Me.LayoutControlItem47.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.cbCliente
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(209, 26)
        Me.LayoutControlItem49.Text = "Cliente:"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.chkAsociar
        Me.LayoutControlItem48.Location = New System.Drawing.Point(437, 220)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(140, 24)
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem48.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbCentroCosto
        Me.LayoutControlItem1.Location = New System.Drawing.Point(295, 98)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem1.Text = "Centro Costo:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.CheckEdit2
        Me.LayoutControlItem45.Location = New System.Drawing.Point(437, 194)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(230, 26)
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem45.TextVisible = False
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.chkAgrupar
        Me.LayoutControlItem38.Location = New System.Drawing.Point(734, 194)
        Me.LayoutControlItem38.MaxSize = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem38.MinSize = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(79, 26)
        Me.LayoutControlItem38.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.chkVisible
        Me.LayoutControlItem39.Location = New System.Drawing.Point(667, 194)
        Me.LayoutControlItem39.MaxSize = New System.Drawing.Size(67, 26)
        Me.LayoutControlItem39.MinSize = New System.Drawing.Size(67, 26)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(67, 26)
        Me.LayoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem39.TextVisible = False
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(12, 419)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Properties.ReadOnly = True
        Me.txtCaja.Size = New System.Drawing.Size(154, 20)
        Me.txtCaja.StyleController = Me.LayoutControl2
        Me.txtCaja.TabIndex = 99
        Me.txtCaja.TabStop = False
        Me.txtCaja.Visible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bVistaPrevia)
        Me.LayoutControl2.Controls.Add(Me.NavBarControl2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar1)
        Me.LayoutControl2.Controls.Add(Me.GroupControl1)
        Me.LayoutControl2.Controls.Add(Me.cmdConsultaClientes)
        Me.LayoutControl2.Controls.Add(Me.cmdConsulta)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdPagos)
        Me.LayoutControl2.Controls.Add(Me.txtCaja)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40, Me.LayoutControlItem35, Me.LayoutControlItem36})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1248, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(166, 636)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bVistaPrevia
        '
        Me.bVistaPrevia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bVistaPrevia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVistaPrevia.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bVistaPrevia.Appearance.Options.UseFont = True
        Me.bVistaPrevia.Appearance.Options.UseForeColor = True
        Me.bVistaPrevia.ImageOptions.Image = CType(resources.GetObject("bVistaPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.bVistaPrevia.Location = New System.Drawing.Point(24, 126)
        Me.bVistaPrevia.Name = "bVistaPrevia"
        Me.bVistaPrevia.Size = New System.Drawing.Size(130, 38)
        Me.bVistaPrevia.StyleController = Me.LayoutControl2
        Me.bVistaPrevia.TabIndex = 186
        Me.bVistaPrevia.Text = "&Vista Previa"
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup2
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2})
        Me.NavBarControl2.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nCotizacion, Me.nOrdenTrabajo, Me.nProyectos, Me.nOrdenEntrega, Me.nRemisiones})
        Me.NavBarControl2.Location = New System.Drawing.Point(12, 222)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 154
        Me.NavBarControl2.Size = New System.Drawing.Size(154, 193)
        Me.NavBarControl2.TabIndex = 187
        Me.NavBarControl2.Text = "NavBarControl2"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Buscar Documentos"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nProyectos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nRemisiones), New DevExpress.XtraNavBar.NavBarItemLink(Me.nOrdenTrabajo), New DevExpress.XtraNavBar.NavBarItemLink(Me.nCotizacion), New DevExpress.XtraNavBar.NavBarItemLink(Me.nOrdenEntrega)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'nProyectos
        '
        Me.nProyectos.Caption = "Proyectos"
        Me.nProyectos.Name = "nProyectos"
        Me.nProyectos.SmallImage = CType(resources.GetObject("nProyectos.SmallImage"), System.Drawing.Image)
        ToolTipTitleItem2.Text = "Proyectos"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Buscar Proyectos en Proceso"
        SuperToolTip4.Items.Add(ToolTipTitleItem2)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.nProyectos.SuperTip = SuperToolTip4
        '
        'nRemisiones
        '
        Me.nRemisiones.Caption = "Remisiones"
        Me.nRemisiones.Name = "nRemisiones"
        Me.nRemisiones.SmallImage = CType(resources.GetObject("nRemisiones.SmallImage"), System.Drawing.Image)
        ToolTipTitleItem3.Text = "Remisiones"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Buscar Remisiones de Clientes"
        SuperToolTip5.Items.Add(ToolTipTitleItem3)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.nRemisiones.SuperTip = SuperToolTip5
        '
        'nOrdenTrabajo
        '
        Me.nOrdenTrabajo.Caption = "Ordenes de Trabajo"
        Me.nOrdenTrabajo.Name = "nOrdenTrabajo"
        Me.nOrdenTrabajo.SmallImage = CType(resources.GetObject("nOrdenTrabajo.SmallImage"), System.Drawing.Image)
        ToolTipTitleItem4.Text = "Ordenes de Trabajo"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Buscar Ordenes de Trabajo en Proceso"
        SuperToolTip6.Items.Add(ToolTipTitleItem4)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.nOrdenTrabajo.SuperTip = SuperToolTip6
        '
        'nCotizacion
        '
        Me.nCotizacion.Caption = "Cotizaciones"
        Me.nCotizacion.Name = "nCotizacion"
        Me.nCotizacion.SmallImage = CType(resources.GetObject("nCotizacion.SmallImage"), System.Drawing.Image)
        ToolTipTitleItem5.Text = "Cotiaciones"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Buscar Cotizaciones/Proformas de Clientes"
        SuperToolTip7.Items.Add(ToolTipTitleItem5)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.nCotizacion.SuperTip = SuperToolTip7
        '
        'nOrdenEntrega
        '
        Me.nOrdenEntrega.Caption = "Ordenes de Entrega"
        Me.nOrdenEntrega.Name = "nOrdenEntrega"
        Me.nOrdenEntrega.SmallImage = CType(resources.GetObject("nOrdenEntrega.SmallImage"), System.Drawing.Image)
        ToolTipTitleItem6.Text = "Ordenes de Entrega"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Buscar Ordenes de Entrega de Clientes"
        SuperToolTip8.Items.Add(ToolTipTitleItem6)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.nOrdenEntrega.SuperTip = SuperToolTip8
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(24, 515)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(130, 38)
        Me.SimpleButton3.StyleController = Me.LayoutControl2
        Me.SimpleButton3.TabIndex = 185
        Me.SimpleButton3.Text = "Actualizar Catalogos"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(24, 168)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(130, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 185
        Me.SimpleButton2.Text = "&Calculadora"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(24, 557)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(130, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdCancelar1
        '
        Me.cmdCancelar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar1.Appearance.Options.UseFont = True
        Me.cmdCancelar1.Appearance.Options.UseForeColor = True
        Me.cmdCancelar1.ImageOptions.Image = CType(resources.GetObject("cmdCancelar1.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar1.Location = New System.Drawing.Point(24, 473)
        Me.cmdCancelar1.Name = "cmdCancelar1"
        Me.cmdCancelar1.Size = New System.Drawing.Size(130, 38)
        Me.cmdCancelar1.StyleController = Me.LayoutControl2
        Me.cmdCancelar1.TabIndex = 5
        Me.cmdCancelar1.Text = "&Limpiar"
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
        Me.GroupControl1.Location = New System.Drawing.Point(12, 269)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(168, 745)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Tipo Descuento"
        Me.GroupControl1.Visible = False
        '
        'txtdescuentos
        '
        Me.txtdescuentos.Location = New System.Drawing.Point(192, 27)
        Me.txtdescuentos.Name = "txtdescuentos"
        Me.txtdescuentos.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescuentos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescuentos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdescuentos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdescuentos.Properties.ReadOnly = True
        Me.txtdescuentos.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentos.TabIndex = 1
        Me.txtdescuentos.TabStop = False
        '
        'txtdescuentop
        '
        Me.txtdescuentop.Location = New System.Drawing.Point(83, 27)
        Me.txtdescuentop.Name = "txtdescuentop"
        Me.txtdescuentop.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtdescuentop.Properties.AppearanceReadOnly.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescuentop.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtdescuentop.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtdescuentop.Properties.ReadOnly = True
        Me.txtdescuentop.Size = New System.Drawing.Size(32, 20)
        Me.txtdescuentop.TabIndex = 0
        Me.txtdescuentop.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(5, 32)
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
        Me.Label15.Location = New System.Drawing.Point(119, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Servicios :"
        '
        'cmdConsultaClientes
        '
        Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsultaClientes.Appearance.Options.UseFont = True
        Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
        Me.cmdConsultaClientes.Enabled = False
        Me.cmdConsultaClientes.Location = New System.Drawing.Point(24, 170)
        Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
        Me.cmdConsultaClientes.Size = New System.Drawing.Size(144, 22)
        Me.cmdConsultaClientes.StyleController = Me.LayoutControl2
        Me.cmdConsultaClientes.TabIndex = 0
        Me.cmdConsultaClientes.Text = "&Clientes"
        '
        'cmdConsulta
        '
        Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsulta.Appearance.Options.UseFont = True
        Me.cmdConsulta.Appearance.Options.UseForeColor = True
        Me.cmdConsulta.Enabled = False
        Me.cmdConsulta.Location = New System.Drawing.Point(24, 170)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(144, 22)
        Me.cmdConsulta.StyleController = Me.LayoutControl2
        Me.cmdConsulta.TabIndex = 1
        Me.cmdConsulta.Text = "Pro&ductos"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(24, 84)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(130, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 14
        Me.cmdAceptar.Text = "F3 - &Facturar"
        '
        'cmdPagos
        '
        Me.cmdPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPagos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPagos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdPagos.Appearance.Options.UseFont = True
        Me.cmdPagos.Appearance.Options.UseForeColor = True
        Me.cmdPagos.Enabled = False
        Me.cmdPagos.ImageOptions.Image = CType(resources.GetObject("cmdPagos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPagos.Location = New System.Drawing.Point(24, 42)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(130, 38)
        Me.cmdPagos.StyleController = Me.LayoutControl2
        Me.cmdPagos.TabIndex = 15
        Me.cmdPagos.Text = "F2 - &Pagos"
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.GroupControl1
        Me.LayoutControlItem40.CustomizationFormText = "LayoutControlItem40"
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 257)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(172, 749)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.cmdConsultaClientes
        Me.LayoutControlItem35.CustomizationFormText = "LayoutControlItem35"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(148, 26)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.cmdConsulta
        Me.LayoutControlItem36.CustomizationFormText = "LayoutControlItem36"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(148, 26)
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.LayoutControlItem16, Me.LayoutControlItem52})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(178, 619)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Facturación"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem34, Me.LayoutControlItem20, Me.LayoutControlItem32, Me.LayoutControlItem37})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(158, 210)
        Me.LayoutControlGroup3.Text = "Facturación"
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.cmdPagos
        Me.LayoutControlItem34.CustomizationFormText = "LayoutControlItem34"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdAceptar
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.SimpleButton2
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.bVistaPrevia
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Salir"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem41, Me.LayoutControlItem42, Me.LayoutControlItem51})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 431)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(158, 168)
        Me.LayoutControlGroup5.Text = "Salir"
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.cmdCancelar1
        Me.LayoutControlItem41.CustomizationFormText = "LayoutControlItem41"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem41.TextVisible = False
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.cmdCancelar
        Me.LayoutControlItem42.CustomizationFormText = "LayoutControlItem42"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextVisible = False
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.SimpleButton3
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem51.MaxSize = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem51.MinSize = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(134, 42)
        Me.LayoutControlItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem51.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtCaja
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 407)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(158, 24)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        Me.LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.NavBarControl2
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(158, 197)
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem52.TextVisible = False
        '
        'SubMenu
        '
        Me.SubMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnExento})
        '
        'MnExento
        '
        Me.MnExento.Index = 0
        Me.MnExento.Text = "Excento"
        '
        'Timer1
        '
        '
        'AlertaRemisiones
        '
        Me.AlertaRemisiones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertaRemisiones.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.AlertaRemisiones.AppearanceCaption.Options.UseFont = True
        Me.AlertaRemisiones.AppearanceCaption.Options.UseForeColor = True
        Me.AlertaRemisiones.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertaRemisiones.AppearanceText.Options.UseForeColor = True
        Me.AlertaRemisiones.AutoFormDelay = 15000
        Me.AlertaRemisiones.AutoHeight = True
        Me.AlertaRemisiones.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertaRemisiones.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomLeft
        Me.AlertaRemisiones.FormMaxCount = 2
        '
        'AlertaProyectos
        '
        Me.AlertaProyectos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertaProyectos.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.AlertaProyectos.AppearanceCaption.Options.UseFont = True
        Me.AlertaProyectos.AppearanceCaption.Options.UseForeColor = True
        Me.AlertaProyectos.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertaProyectos.AppearanceText.Options.UseForeColor = True
        Me.AlertaProyectos.AutoFormDelay = 15000
        Me.AlertaProyectos.AutoHeight = True
        Me.AlertaProyectos.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertaProyectos.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomLeft
        Me.AlertaProyectos.FormMaxCount = 2
        '
        'AlertaOT
        '
        Me.AlertaOT.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertaOT.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.AlertaOT.AppearanceCaption.Options.UseFont = True
        Me.AlertaOT.AppearanceCaption.Options.UseForeColor = True
        Me.AlertaOT.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertaOT.AppearanceText.Options.UseForeColor = True
        Me.AlertaOT.AutoFormDelay = 15000
        Me.AlertaOT.AutoHeight = True
        Me.AlertaOT.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertaOT.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomLeft
        Me.AlertaOT.FormMaxCount = 2
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
        Me.DockPanel1.ID = New System.Guid("3228bffa-730a-47b6-af0a-0a800039d799")
        Me.DockPanel1.Location = New System.Drawing.Point(833, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(175, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(175, 663)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(166, 636)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmFacturacionClienteNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 663)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmFacturacionClienteNew"
        Me.Text = "Facturacion Cliente"
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAsociar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClienteConvenio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbltotalU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbltotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbliva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblsubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgDespacho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbserie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rExento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbvendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbformapago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtorden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vEmpl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtruc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtdescuentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescuentop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Private _Factura As String = ""
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

    Dim TCambio As Double = 1
#End Region

    Public Property Factura()
        Get
            Return _Factura
        End Get
        Set(ByVal Value)
            _Factura = Value
        End Set
    End Property

    Private Caja As String
    Private RecContado As Integer
    Private RecVuelto As Integer
    'Private BodegaCaja As String
    Dim pos As Integer = 0
    Dim HoraCorte As Date
    Dim DetallesBodega As BodegasDetails
    Dim DetalleEmpresa As EmpresasDetails
    Dim DT_DESCUENTO As DataTable

    Dim Validar_Cotizacion As Boolean = False
    Dim Validar_Orden As Boolean = False

    Dim DT_ROL As DataTable = Nothing
    Private LoadProyecto As Boolean = False
    Private LoadRemision As Boolean = False, IdRemision As String = "", BitacoraVencidas As String = ""

    Private Sub FrmFacturacionClienteNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '/*** Globales   **************/
        DT_Cheques = Nothing
        DT_Tarjetas = Nothing
        FacturarCotizacion = False
        LoadOrden = False
        LoadCotizacionCliente = False
        LoadProyecto = False
        LoadRemision = False
        TotalCheques = 0
        TotalTarjetas = 0
        TotalEfectivo = 0
        TotalNotaDebito = 0
        TotalFactura = 0
        TotalGlobal = 0
        '**************************/
    End Sub

    Private Sub FrmFacturacionClienteNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Actualizar()
        If e.KeyCode = Keys.F2 Then If cmdPagos.Enabled Then Pagos()
        If e.KeyCode = Keys.F3 Then If cmdAceptar.Enabled Then Facturar()
        If e.KeyCode = Keys.F6 Then vFact.ShowCustomization()
    End Sub


    Private Sub FrmFacturacionClienteNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones()

        If DT_ROL.Rows.Count > 0 Then
            'Verificar si el Usuario tiene permiso de Cambiar los IR a Facturas
            Dim dr() As DataRow = DT_ROL.Select("Control = 'CambiarBodega'")

            If dr.Length > 0 Then cbBodega.Properties.ReadOnly = False
        End If

        'Dim Clientes As New VB.SysContab.ClientesDB
        'Cargar Caja y Configuracion
        GetBodegasList(cbBodega)
        CargarCaja()

        DetallesBodega = VB.SysContab.BodegasDB.GetDetails(cbBodega.EditValue)

        If DetallesBodega.Exigir_Facturacion Then rgDespacho.EditValue = ""
        If Not DetallesBodega.Exigir_Facturacion Then rgDespacho.EditValue = "B"

        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
        Dim Digitos As Integer = ConfigDetalles.FacturaDigitos

        LoadClients()
        GetMonedasList(cmbmoneda)
        GetFormaPagoList(cmbformapago)
        GetTipoCultivo(Me.cbCultivos)
        cbCultivos.ItemIndex = 0
        TipoServicio.EditValue = "A"

        Combo(cbTipoFactura, db_TipoFacturas.Listar(0))
        cbTipoFactura.ItemIndex = 0

        'LookUp(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", "[Seleccione]", 0, 1, 4, 5, 6, 7, 8)
        'cbProyecto.ItemIndex = 0

        'GetBodegasList(cbBodega)
        'cbBodega.EditValue = BodegaCaja

        For d As Integer = 0 To Digitos - 1
            dd = dd & "0"
        Next

        'txtfactura.Text = Format(Clientes.FacturaNumero, dd)
        fecha.EditValue = Now.Date
        FechaPago.EditValue = Now.Date

        '**** Cargar Tasa de Cambio
        etTasa.EditValue = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Me.fecha.DateTime.Date & "')").Rows.Item(0)(0)).ToString("n4")
        TCambio = etTasa.EditValue

        'TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
        '+ " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
        'Me.etTasa.Text = TCambio.ToString("n4")

        CargaSeries()
        ''        txtfactura.Text = Format(cmbserie.EditValue, dd) 'Format(Clientes.FacturaNumero(cmbserie.Text, ConfigDetalles.SeriesMultiples), dd)
        txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)

        GetCentrosCostosList(cbCentroCosto, 1)
        GetVendedores(cmbvendedor)
        cmbvendedor_EditValueChanged(Nothing, Nothing)

        'Dim v As New VB.SysContab.VendedoresDB
        'cmbvendedor.Properties.DataSource = v.GetListBuscarCombo("%")
        'cmbvendedor.Properties.ValueMember = "Codigo"
        'cmbvendedor.Properties.DisplayMember = "Nombre"
        'cmbvendedor.Properties.PopulateColumns()
        'cmbvendedor.Properties.Columns("Codigo").Visible = False

        'For i As Integer = 2 To cmbvendedor.Properties.Columns.Count - 1
        '    cmbvendedor.Properties.Columns(i).Visible = False
        'Next

        'Buscar si hay tabla de configuracion de descuentos        

        Caja = txtCaja.Text
        'cmbclientes.Focus()
        cbCliente.Focus()

        Try
            'cmbclientes.EditValue = 1
        Catch ex As Exception
        End Try
        ' IniciaContador(1000)
    End Sub

    Private Sub IniciaContador(Intervalo As Integer)
        Timer1.Enabled = True
        Timer1.Interval = Intervalo
        Timer1.Start()
    End Sub

    Private Sub CargaSeries()
        LookUp(cmbserie, ObtieneDatos("sp_sel_SeriesCajas", PvCodigo, EmpresaActual), "Serie", "IdDetalle", "[Serie]", 0, 3, 4)

        cmbserie.Properties.ShowHeader = True
        cmbserie.ItemIndex = 0
        '
        cbCliente.EditValue = cmbserie.GetColumnValue("Tipo")


        'cmbserie.Properties.DataSource = ObtieneDatos("Select IdDetalle,Serie,Factura,Tipo from SeriesCajas WHERE empresa = " & EmpresaActual & " AND Codigo = " & PvCodigo)
        'cmbserie.Properties.ValueMember = "IdDetalle"
        ''cmbserie.Properties.ValueMember = "Factura"
        'cmbserie.Properties.DisplayMember = "Serie"
        'cmbserie.Properties.PopulateColumns()
        'cmbserie.Properties.Columns("IdDetalle").Visible = False
        ''cmbserie.Properties.Columns("Factura").Visible = False
        'cmbserie.Properties.Columns("Tipo").Visible = False
        'Me.cmbclientes.EditValue = Me.cmbserie.GetColumnValue("Tipo")
    End Sub

    Sub CargarCaja()
        Try
            'PvNombre = Environment.MachineName
            'cajanombre.Text = PvNombre            
            'PvCodigo = ObtieneDatos("SELECT cj_Codigo from Cajas where empresa_id = " & EmpresaActual & " and pc_nombre = '" & PvNombre & "'").Rows(0).Item(0)

            PvCodigo = txtCaja.Text

            Dim dtCaja As DataTable = ObtieneDatos("sp_sel_Caja_Detalle", txtCaja.Text, EmpresaActual)   'ObtieneDatos("SELECT Bodega, HoraCorte from cajas where empresa_id = " & EmpresaActual & " and cj_codigo = " & PvCodigo)
            cbBodega.EditValue = dtCaja.Rows.Item(0)("Bodega")

            ' BodegaCaja = dtCaja.Rows.Item(0)("Bodega")
            HoraCorte = dtCaja.Rows.Item(0)("HoraCorte")
            ' lblbodega.Text = ObtieneDatos("SELECT ubicacion from bodegas where empresa = " & EmpresaActual & " and codigo_bodega = '" & BodegaCaja & "'").Rows(0).Item(0)
        Catch ex As Exception
            XtraMsg("Error al cargar la configuracion de la caja, consulte con su administrador", MessageBoxIcon.Warning)
            Exit Sub
        End Try
    End Sub

    Private Sub GetData()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Factura")
        Datos.Add(EmpresaActual)
        Datos.Add(Factura)

        DT_Facturas = ProcedureParameters(Datos, Variables, "SP_GetDetalleFactura")
        GridDetalle.DataSource = DT_Facturas

        Me.txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        vFact.Columns("Precio").Caption = "Precio " & VB.SysContab.MonedaDB.GetDetails(MonedaBase).Simbolo     'cmbmoneda.GetColumnValue("Simbolo").ToString

        'Campos que solo ocupa RAMAC
        If EmpresaActual <> 1 Then
            vFact.Columns("Presentacion").Visible = False
            vFact.Columns("Cantidad").Visible = False
            vFact.Columns("Factor").Visible = False
        Else
            vFact.Columns("#").Visible = False
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        DT_Tarjetas = Nothing
        DT_Cheques = Nothing
        Close()
    End Sub


    Private Sub TipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoServicio.SelectedIndexChanged
        GetArticulos()
        GetData()
        If TipoServicio.EditValue = "P" Then
            vFact.Columns("Precio").OptionsColumn.AllowEdit = True
            vFact.Columns("Precio").OptionsColumn.ReadOnly = False
            vFact.Columns("Precio").OptionsColumn.AllowFocus = True
            'vFact.Columns("Existencia").OptionsColumn.AllowFocus = True
        ElseIf TipoServicio.EditValue = "S" Then
            vFact.Columns("Precio").OptionsColumn.AllowEdit = True
            vFact.Columns("Precio").OptionsColumn.ReadOnly = False
            vFact.Columns("Precio").OptionsColumn.AllowFocus = True
            'vFact.Columns("Existencia").OptionsColumn.AllowFocus = False
        End If
    End Sub

    Private Sub GetArticulos()
        Dim DT As DataTable =
            ObtieneDatos("SP_ArticulosGetAll",
                         TipoServicio.EditValue,
                         EmpresaActual,
                         cbBodega.EditValue)

        RepositorySearchLook(
            cbProducto,
            DT,
            "Display",
            "Codigo", 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)

        cbProducto.View.Columns("PrecioU").Caption = "Precio U$"

        'Dim DT As DataTable
        'DT = ObtieneDatos("SP_ArticulosGetAll '" & TipoServicio.EditValue & "'," & EmpresaActual & ",'" & BodegaCaja & "'")
        'ItemArticulo.DataSource = DT
        'ItemArticulo.DisplayMember = "Codigo"
        'ItemArticulo.ValueMember = "Codigo"
        'ItemArticulo.PopulateColumns()
        'For i As Integer = 2 To ItemArticulo.Columns.Count - 1
        '    ItemArticulo.Columns(i).Visible = False
        'Next
        'Me.ItemArticulo.Columns("Nombre").Visible = True

        'ItemArticuloD.DataSource = DT
        'ItemArticuloD.DisplayMember = "Nombre"
        'ItemArticuloD.ValueMember = "Codigo"
        'ItemArticuloD.PopulateColumns()
        'For i As Integer = 2 To ItemArticuloD.Columns.Count - 1
        '    ItemArticuloD.Columns(i).Visible = False
        'Next
        'ItemArticuloD.Columns("Codigo").Visible = True
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vFact.CellValueChanged

        'Dim DaR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

        'If (e.Column.FieldName = "Cantidad" Or e.Column.FieldName = "Promocion") And Not Temp And DaR.Item("Tipo") = "P" Then
        '    'Dim Cantidad As Double = IsNull(DaR.Item("Existencias"), 0)
        '    Dim Cantidad As Double
        '    Try
        '        Cantidad = ObtieneDatos("SELECT isnull(Existencia,0) FROM bodegas_Articulos WHERE codigo_bodega = '" & BodegaCaja & "' and Codigo_Articulo = '" & GridView1.GetRowCellValue(e.RowHandle, "Item") & "' AND Empresa = " & EmpresaActual & " AND articulo_Tipo = '" & DaR.Item("Tipo") & "'").Rows(0).Item(0)
        '    Catch ex As Exception
        '        Cantidad = 0
        '    End Try
        '    If (IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 0) + IsNull(GridView1.GetRowCellValue(e.RowHandle, "Promocion"), 0)) > Cantidad Then
        '        MsgBox("Este articulo tiene solo : " & Cantidad & " en existencias", MsgBoxStyle.Information)
        '        Temp = True
        '        GridView1.SetRowCellValue(e.RowHandle, e.Column.FieldName, 0)
        '        Temp = False
        '        Exit Sub
        '    End If
        'End If

        If e.Column.FieldName = "Precio" And Temp = False And TipoServicio.EditValue = "S" Then
            '  If MsgBox("Desea Cambiar el Precio del Servicio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            GuardaDatos("UPDATE Articulos SET Precio_Venta_Cordobas = " & e.Value & ",Costo = " & e.Value & " WHERE Empresa = " & EmpresaActual & " And Tipo = '" & TipoServicio.EditValue & "' AND Codigo_Articulo = '" & vFact.GetRowCellValue(e.RowHandle, "Item") & "'")
            Temp = True
            vFact.SetRowCellValue(e.RowHandle, "Costo", e.Value)
            Temp = False

            'GetArticulos()
            '' Else
            'Temp = True
            'vFact.SetRowCellValue(e.RowHandle, "Precio", 0.0)
            'Temp = False
            ' End If
        End If

        If e.Column.FieldName = "Item" Then
            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(e.Value)
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(e.Value)

            If Not DR Is Nothing Then
                Temp = True
                ' Try                    
                vFact.SetRowCellValue(e.RowHandle, "Presentacion", DR.Item("Presentacion"))
                vFact.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                vFact.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))
                vFact.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                vFact.SetRowCellValue(e.RowHandle, "Costo", DR.Item("Costo"))
                vFact.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))

                vFact.SetRowCellValue(e.RowHandle, "Existencia", IIf(DR.Item("Tipo") = "P",
                                                                     ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo.fn_CalcularExistenciaREAL('" & cbBodega.EditValue & "','" & e.Value & "'," & EmpresaActual & ") Existencia").Rows.Item(0)("Existencia"), 0))

                'vFact.SetRowCellValue(e.RowHandle, "Existencia", DR.Item("Existencias"))
                vFact.SetRowCellValue(e.RowHandle, "Despacho", 0)
                vFact.SetRowCellValue(e.RowHandle, "Cantidad", 0)
                vFact.SetRowCellValue(e.RowHandle, "Promocion", 0)
                vFact.SetRowCellValue(e.RowHandle, "Descuento", 0)
                vFact.SetRowCellValue(e.RowHandle, "Cuenta", DR.Item("Cuenta"))
                vFact.SetRowCellValue(e.RowHandle, "Exento", DR.Item("Exento"))
                vFact.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
                vFact.SetRowCellValue(e.RowHandle, "Margen", DR.Item("Margen"))
                vFact.SetRowCellValue(e.RowHandle, "#", "")
                vFact.SetRowCellValue(e.RowHandle, "Agrupar", "")
                vFact.SetRowCellValue(e.RowHandle, "Visible", True)
                vFact.SetRowCellValue(e.RowHandle, "IdProyecto", 0)

                'Catch ex As Exception
                '    XtraMsg(ex.Message, MessageBoxIcon.Error)
                'End Try
                Temp = False
            End If

            'Try
            '    vFact.SetRowCellValue(e.RowHandle, "Existencia", _
            '              IsNull(ObtieneDatos("SELECT existencia from bodegas_articulos where empresa = " & EmpresaActual & " and codigo_bodega = '" & BodegaCaja & "' and codigo_articulo = '" & e.Value & "'").Rows(0).Item(0), 0))
            'Catch ex As Exception
            '    vFact.SetRowCellValue(e.RowHandle, "Existencia", 0)
            'End Try
            'ObtieneDatos("SELECT existencias from articulos where empresa = " & EmpresaActual & " and codigo_articulo = '" & e.Value & "'").Rows(0).Item(0))
        End If

        '*** Actualizar el Valor de la Presentacion en la tabla de ARTICULOS
        If e.Column.FieldName = "Presentacion" And Not Temp Then
            Temp = True
            Try
                GuardaDatos("UPDATE ARTICULOS SET PRESENTACION = '" & e.Value & "'" _
                            + " WHERE CODIGO_ARTICULO = '" & Me.vFact.GetRowCellValue(e.RowHandle, "Item") & "'" _
                            + " AND TIPO = '" & Me.vFact.GetRowCellValue(e.RowHandle, "Tipo") & "'")
            Catch ex As Exception
            End Try
            Temp = False
        End If

        '*** Actualizar el Valor de la UNIDAD en la tabla de ARTICULOS
        'If e.Column.FieldName = "Unidad" And Not Temp Then
        '    Temp = True
        '    Try
        '        GuardaDatos("UPDATE ARTICULOS SET UNIDAD = '" & e.Value & "'" _
        '                    + " WHERE CODIGO_ARTICULO = '" & Me.GridView1.GetRowCellValue(e.RowHandle, "Item") & "'" _
        '                    + " AND TIPO = '" & Me.GridView1.GetRowCellValue(e.RowHandle, "Tipo") & "'")
        '    Catch ex As Exception
        '    End Try
        '    Temp = False
        'End If

        If e.Column.FieldName = "Despacho" And Not Temp Then
            Temp = True
            Try
                vFact.SetRowCellValue(e.RowHandle, "Cantidad", e.Value * Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))

                '*****  VALIDANDO FACTURACION CON MENOS EXITENCIA   ***********************
                If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" Then
                    'Verificar si la Cantidad a Despachar es Mayor que las existencias
                    If Me.vFact.GetRowCellValue(e.RowHandle, "Cantidad") > Me.vFact.GetRowCellValue(e.RowHandle, "Existencia") Then
                        'Verificar si la Bodega puede Facturar sin Existencia
                        If Not DetallesBodega.Fact_Sin_Existencia Then

                            If DetallesBodega.Advertencia Then  'Advertir Cuando hay menos existencia
                                If Not XtraMsg2("Esta Intentando Facturar más producto del que hay en Existencia en la bodega." & vbCrLf &
                                    "Esta Seguro que desea Continuar?") Then

                                    Try
                                        vFact.SetRowCellValue(e.RowHandle, "Despacho", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")) / Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))
                                        vFact.SetRowCellValue(e.RowHandle, "Cantidad", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")))
                                    Catch ex As Exception
                                    End Try
                                End If
                            Else    'Exigir facturar solo con existencia
                                XtraMsg("Esta Intentando Facturar más producto del que hay en Existencia en la bodega", MessageBoxIcon.Error)

                                Try
                                    vFact.SetRowCellValue(e.RowHandle, "Despacho", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")) / Me.vFact.GetRowCellValue(e.RowHandle, "Factor"))
                                    vFact.SetRowCellValue(e.RowHandle, "Cantidad", IIf(vFact.GetRowCellValue(e.RowHandle, "Existencia") < 0.0, 0.0, vFact.GetRowCellValue(e.RowHandle, "Existencia")))
                                Catch ex As Exception
                                End Try

                                Temp = False
                            End If
                        End If

                    End If
                End If
            Catch ex As Exception
            End Try
            Temp = False
        End If

        If e.Column.FieldName = "Descuento" And Not Temp Then
            If e.Value <> 0 Then

                DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos", "PCOMPRA", EmpresaActual)
                'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                Dim DR_PROD As DataRowView =
                    cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                Dim Descuento_VD As Double = 0,
                    Descuento_VH As Double = 0,
                    Descuento_GD As Double = 0,
                    Descuento_GH As Double = 0

                Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                If DT_DESCUENTO.Rows.Count > 0 Then

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

                    'Validar si existe clave creada en la tabla
                    If DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor").ToString.Trim.Length <> 0 Then

                        If Math.Round(e.Value / 100, 2) > Descuento_VH Then
                            'XtraMsg("Descuento No Autorizado!", MessageBoxIcon.Error)

                            If Math.Round(e.Value / 100, 2) > Descuento_GH Then

                                With frmAprobarPedido
                                    .lyTitulo.Text = "Introduzca Código de Aprobación de Gerencia General y Finanzas"
                                    .ShowDialog()

                                    If .Ok = "SI" Then
                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
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
                                        If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Gerente") Or
                                            .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Finanza") Then
                                            .Dispose()
                                            GoTo Continuar
                                        Else
                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                            vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                            .Dispose()
                                            Exit Sub
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                                        .Dispose()
                                        Exit Sub
                                    End If
                                    .Dispose()
                                End With
                            End If
                            Exit Sub
                        End If

                        'If Math.Round(e.Value / 100, 2) >= Descuento_VD And Math.Round(e.Value / 100, 2) > 0 Then
                        '    With frmAprobarPedido
                        '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                        '        .ShowDialog()

                        '        If .Ok = "SI" Then
                        '            If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor") Then
                        '                .Dispose()
                        '                GoTo Continuar
                        '            Else
                        '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                        '                vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                        '                .Dispose()
                        '                Exit Sub
                        '            End If
                        '        Else
                        '            vFact.SetRowCellValue(e.RowHandle, "Descuento", 0.0)
                        '            .Dispose()
                        '            Exit Sub
                        '        End If
                        '        .Dispose()
                        '    End With
                        'End If
                    End If
                End If
Continuar:
                Temp = True
                vFact.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                Try
                    ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                    If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" And vFact.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                        'Validar si los datos se estan cargando de una Orden o Cotizacion
                        If Validar_Cotizacion Or Validar_Orden Then
                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                        Else

                            'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                            Dim DR_PROD As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                            Dim Descuento_VD As Double = 0,
                                Descuento_VH As Double = 0,
                                Descuento_GD As Double = 0,
                                Descuento_GH As Double = 0,
                                PrecioActual As Double = 0

                            PrecioActual = DR_PROD.Item("Precio")

                            'Validando que el precio en el maestro, sera mayor que cero.
                            If PrecioActual > 0 Then
                                'Validar que no se ingrese precio menor al del maestro, segun el margen
                                DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos", "PCOMPRA", EmpresaActual)

                                Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                                Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                                'Validar que no se ingrese precio menor al del maestro, segun el margen
                                If e.Value < PrecioActual Then

                                    If DT_DESCUENTO.Rows.Count > 0 Then
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
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                            GoTo fin1
                                                        Else
                                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                            vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                            Temp = False
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                            .Dispose()
                                                            Exit Sub
                                                        End If
                                                    Else
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
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
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                                            GoTo fin1
                                                        Else
                                                            XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                            vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                            Temp = False
                                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                            .Dispose()
                                                            Exit Sub
                                                        End If
                                                    Else
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                                    End If
                                                    .Dispose()
                                                End With
                                            End If
                                        Else
                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                            Temp = False
                                            vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(PrecioActual / TCambio))
                                        End If

                                        'If DESC >= Descuento_VD And DESC > 0 Then
                                        '    With frmAprobarPedido
                                        '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                                        '        .ShowDialog()

                                        '        If .Ok = "SI" Then
                                        '            If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor") Then
                                        '                .Dispose()
                                        '                vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                        '                GoTo fin1
                                        '            Else
                                        '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                        '                vFact.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                        '                Temp = False
                                        '                .Dispose()
                                        '                Exit Sub
                                        '            End If
                                        '        Else
                                        '            vFact.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                        '            Temp = False
                                        '        End If
                                        '        .Dispose()
                                        '    End With
                                        'Else
                                        '    vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                        '    Temp = False
                                        'End If

                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                    End If

                                    'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)
                                    'vFact.SetRowCellValue(e.RowHandle, "Precio", DR_PROD.Item("Precio"))
                                Else
                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                                End If
                            Else
                                vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                            End If
                        End If
                    Else
                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                    End If

fin1:
                    Temp = False

                Catch ex As Exception
                    Temp = False
                End Try
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True

                ' Validar Si el producto tiene establecido el Margen en el Maestro de productos
                If vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P" And vFact.GetRowCellValue(e.RowHandle, "Margen") <> 0 Then

                    'Validar si los datos se estan cargando de una Orden o Cotizacion
                    If Validar_Cotizacion Or Validar_Orden Then
                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                    Else
                        'Dim DR_PROD As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
                        Dim DR_PROD As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

                        Dim Descuento_VD As Double = 0,
                               Descuento_VH As Double = 0,
                               Descuento_GD As Double = 0,
                               Descuento_GH As Double = 0,
                               PrecioActual As Double = 0

                        PrecioActual = DR_PROD.Item("PrecioU")

                        'Validando que el precio en el maestro, sera mayor que cero.
                        If PrecioActual > 0 Then

                            'Validar que no se ingrese precio menor al del maestro, segun el margen
                            DT_DESCUENTO = ObtieneDatos("JAR_GetCodigos", "PCOMPRA", EmpresaActual)
                            Dim DescuentoV As Double = DR_PROD.Item("Descuento_Ventas")
                            Dim DescuentoC As Double = DR_PROD.Item("Descuento_Comercial")

                            ''Validar que no se ingrese precio menor al del maestro, segun el margen
                            If e.Value < PrecioActual Then


                                If DT_DESCUENTO.Rows.Count > 0 Then
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
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                        GoTo Fin2
                                                    Else
                                                        XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                        .Dispose()
                                                        Exit Sub
                                                    End If
                                                Else
                                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
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
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                                        GoTo Fin2
                                                    Else
                                                        XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                                        vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                        Temp = False
                                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                        .Dispose()
                                                        Exit Sub
                                                    End If
                                                Else
                                                    vFact.SetRowCellValue(e.RowHandle, "PrecioU", PrecioActual)
                                                    Temp = False
                                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(PrecioActual * TCambio))
                                                End If
                                                .Dispose()
                                            End With
                                        End If
                                    Else
                                        vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                        Temp = False
                                    End If

                                    'If DESC >= Descuento_VD And DESC > 0 Then
                                    '    With frmAprobarPedido
                                    '        .lyTitulo.Text = "Introduzca Código de Aprobación del Vendedor"
                                    '        .ShowDialog()

                                    '        If .Ok = "SI" Then
                                    '            If .txtCodigo.Text = DT_DESCUENTO.Rows.Item(0)("Codigo_Vendedor") Then
                                    '                .Dispose()
                                    '                vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                    '                GoTo Fin2
                                    '            Else
                                    '                XtraMsg("Codigo Inválido", MessageBoxIcon.Error)
                                    '                vFact.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                                    '                Temp = False
                                    '                .Dispose()
                                    '                Exit Sub
                                    '            End If
                                    '        Else
                                    '            vFact.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                                    '            Temp = False
                                    '        End If
                                    '        .Dispose()
                                    '    End With
                                    'Else
                                    '    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                    '    Temp = False
                                    'End If

                                Else
                                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                                End If

                                'XtraMsg("No se puede facturar por debajo del Margen de Ventas Establecido!", MessageBoxIcon.Error)
                                'vFact.SetRowCellValue(e.RowHandle, "PrecioU", DR_PROD.Item("PrecioU"))
                                ' vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(DR_PROD.Item("PrecioU") * TCambio))
                            Else
                                vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                            End If
                        Else
                            vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                        End If

                    End If
                Else
                    vFact.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                End If

Fin2:
                Temp = False
            End If
        End If

        'If e.Column.FieldName = "Bonificados" Then
        '    If e.Value > IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 1) Then
        '        Temp = True
        '        GridView1.SetRowCellValue(e.RowHandle, "Bonificados", 0)
        '        Temp = False
        '        MsgBox("No se pueden bonificar mas articulos que los comprados", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If
        'End If

        If (e.Column.FieldName = "Precio" Or
            e.Column.FieldName = "PrecioU" Or
            e.Column.FieldName = "Cantidad" Or
            e.Column.FieldName = "Despacho" Or
            e.Column.FieldName = "Descuento") And Not Temp Then
            'e.Column.FieldName = "Exento" Or _
            'e.Column.FieldName = "Promocion") 

            vFact.SetRowCellValue(e.RowHandle, "Total", (IsNull(vFact.GetRowCellValue(e.RowHandle, "Cantidad"), 0)) * IsNull(vFact.GetRowCellValue(e.RowHandle, "Precio"), 0) - (IsNull(vFact.GetRowCellValue(e.RowHandle, "Cantidad"), 0) * IsNull(vFact.GetRowCellValue(e.RowHandle, "Precio"), 0) * IsNull(vFact.GetRowCellValue(e.RowHandle, "Descuento"), 0)))

            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(e.RowHandle, "Item"))

            'Dim Config As New VB.SysContab.ConfiguracionDB
            'Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            'ConfigDetalles = Config.GetConfigDetails
            'If DR.Item("Exento") = False And cmbclientes.GetColumnValue("Exento") = False Then

            If Not DR Is Nothing Then
                If CheckEdit2.Checked Then
                    vFact.SetRowCellValue(e.RowHandle, "IVA", 0)
                    vFact.SetRowCellValue(e.RowHandle, "Exento", False)
                Else
                    vFact.SetRowCellValue(e.RowHandle, "Exento", IIf((ObtieneDatos("sp_sel_ProyectoCodigo", vFact.GetRowCellValue(e.RowHandle, "Item"), EmpresaActual).Rows.Item(0)("EsProyecto") = "SI" And IsNull(vFact.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) <> 0 And vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P"), False, DR.Item("Exento")))
                    'vFact.SetRowCellValue(e.RowHandle, "Exento", IIf((IsNull(vFact.GetRowCellValue(e.RowHandle, "IdProyecto"), 0) <> 0 And vFact.GetRowCellValue(e.RowHandle, "Tipo") = "P"), False, DR.Item("Exento")))
                    ' If DR.Item("Exento") = False And cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Exento") = False Then 'Me.cmbclientes.GetColumnValue("Exento") = False Then
                    If vFact.GetRowCellValue(e.RowHandle, "Exento") = False And cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "Exento") = False Then 'Me.cmbclientes.GetColumnValue("Exento") = False Then
                        vFact.SetRowCellValue(e.RowHandle, "IVA",
                                              IsNull(vFact.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0) +
                                              IsNull((IsNull(vFact.GetRowCellValue(e.RowHandle, "Promocion"), 0) *
                                              IsNull(vFact.GetRowCellValue(e.RowHandle, "Costo"), 0)) *
                                              (ConfigDetalles.IVA / 100.0), 0))
                    Else
                        vFact.SetRowCellValue(e.RowHandle, "IVA", 0)
                    End If
                End If
            End If
        End If

        'If (e.Column.FieldName = "Precio" Or e.Column.FieldName = "PrecioU" And Not TempThen Then
        'If Not Temp Then
        '    Select Case e.Column.FieldName
        '        Case "Precio"
        '            GridView1.SetRowCellValue(e.RowHandle, "PrecioU", e.Value / TCambio)
        '        Case "PrecioU"
        '            GridView1.SetRowCellValue(e.RowHandle, "Precio", e.Value * TCambio)
        '    End Select
        '    Temp = False
        'End If

        vFact.UpdateTotalSummary()
    End Sub

    Private Sub cmbformapago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbformapago.EditValueChanged

        If cmbformapago.GetColumnValue("Dias") = 0 Then
            cmdAceptar.Enabled = False
            cmdPagos.Enabled = True

            Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = True
            Me.cmdPagos.LookAndFeel.UseDefaultLookAndFeel = True

            'cmbmoneda.EditValue = MonedaBase
        Else
            cmdAceptar.Enabled = True
            cmdPagos.Enabled = False
            Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = True
            Me.cmdPagos.LookAndFeel.UseDefaultLookAndFeel = True

            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

            If DetallesCliente.Cod_Forma_Pago = "51" Then
                cmbformapago.EditValue = CInt(IsNull(DetallesCliente.Cod_Forma_Pago, 0))
            End If

            If EmpresaActual = 1 Then cmbmoneda.ItemIndex = 1
        End If

        FechaPago.EditValue = fecha.DateTime.AddDays(cmbformapago.GetColumnValue("Dias"))
        TipoFactura = Me.cmbformapago.EditValue
    End Sub

    Private Sub vFact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vFact.KeyDown
        If vFact.FocusedRowHandle < 0 Then Exit Sub
        ''
        If e.KeyCode = Keys.Delete Then
            vFact.DeleteRow(vFact.FocusedRowHandle)
            vFact.FocusedRowHandle = vFact.DataRowCount - 1

            'Validar si el detalle de la factura esta en Vacio
            If vFact.DataRowCount = 0 Then
                FacturarCotizacion = False
                LoadCotizacionCliente = False
                LoadOrden = False
                LoadProyecto = False
                LoadRemision = False
            End If
        End If
        '
        CalcularTotales()
        ValidarNumero_Item()
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vFact.RowUpdated
        CalcularTotales()
        ValidarNumero_Item()
    End Sub

    Sub ValidarNumero_Item()
        If (LoadCotizacionCliente Or LoadOrden Or LoadProyecto Or LoadRemision) Then
            Exit Sub
        Else
            Try
                Dim CantidadLineas As Double = CInt(ObtieneDatos("JAR_GetNumeroLineasFV", EmpresaActual).Rows.Item(0)(0))

                If CDbl(vFact.Columns("Item").SummaryItem.SummaryValue) >= CantidadLineas Then
                    XtraMsg("Solo se pueden Imprimir Máximo " & CantidadLineas.ToString & " Productos", MessageBoxIcon.Warning)
                    vFact.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                Else
                    vFact.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub CalcularTotales()
        lblsubtotal.Text = FormatNumber(vFact.Columns("Total").SummaryItem.SummaryValue, 2)
        lbliva.Text = FormatNumber(vFact.Columns("IVA").SummaryItem.SummaryValue, 2)
        lbltotal.Text = FormatNumber(CDbl(lblsubtotal.Text) + CDbl(lbliva.Text), 2)
        lbltotalU.Text = FormatNumber(CDbl(lbltotal.Text) / etTasa.EditValue, 2)
    End Sub

    Private Sub ItemArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Index = 1 Then

            If vFact.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))

            With frmDetalleVentas_Lineas
                .Text = "Detalle de ITEM: " & DR.Item("Nombre")
                .txtModelo.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Modelo"), "")
                .txtNoSerie.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "NoSerie"), "")
                .txtComentario.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Comentario"), "")
                .ShowDialog()

                If .Ok Then
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Modelo", .txtModelo.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "NoSerie", .txtNoSerie.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Comentario", .txtComentario.Text)
                End If
                .Dispose()
            End With
        End If

        'If TipoServicio.EditValue = "A" Then Exit Sub
        'If e.Button.Index = 1 Then
        '    With My.Forms.frmAgregarArticuloQuick
        '        'Dim f As New frmAgregarArticuloQuick
        '        'f.WindowState = FormWindowState.Normal
        '        'f.StartPosition = FormStartPosition.CenterScreen

        '        .etTipo.Text = TipoServicio.EditValue
        '        .BodegaCaja = BodegaCaja
        '        If .ShowDialog() = DialogResult.OK Then
        '            If IsDBNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item")) OrElse vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item") = Nothing Then
        '                vFact.InvalidateRow(vFact.FocusedRowHandle)
        '                vFact.AddNewRow()
        '            End If
        '            GetArticulos()
        '            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .txtCodigo.Text)
        '            .Dispose()
        '        End If
        '    End With
        'End If
    End Sub

    Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If

        Dim f As frmAcumulados = frmAcumulados.Instance()

        ' RegistroCliente = cmbclientes.EditValue
        RegistroCliente = cbCliente.EditValue

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        Dim f As frmBuscarItem = frmBuscarItem.Instance()
        f.ShowDialog()
        For i As Integer = 0 To f.tItem.Rows.Count - 1
            vFact.AddNewRow()
            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", f.tItem.Rows(i).Item("Codigo"))
            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Cantidad", f.tItem.Rows(i).Item("Cantidad"))
            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", f.tItem.Rows(i).Item("Precio"))
        Next
        vFact.UpdateTotalSummary()
        'GridView1.AddNewRow()
    End Sub

    Private Sub cmdCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Cotizaciones As New VB.SysContab.CotizacionesDB

        'If cbCliente.EditValue Is Nothing Then
        '    XtraMsg("Seleccione el Cliente")
        '    Exit Sub
        'End If

        'If Cotizaciones.CotizacionesXCliente(cbCliente.EditValue).Tables("Cotizaciones").Rows.Count = 0 Then
        '    XtraMsg("No hay cotizaciones para el cliente seleccionado")
        '    Exit Sub
        'End If
        ''
        'VerCotiazacionesPendientes()
    End Sub

    Sub VerCotiazacionesPendientes()

        Dim Cotizaciones As New VB.SysContab.CotizacionesDB
        Dim Clientes As New VB.SysContab.ClientesDB

        ClienteFactura = cbCliente.EditValue

        Dim f As New frmCotizacionesCliente
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        '
        If LoadCotizacionCliente = True Then
            ShowSplash("Cargando Cotización...")
            NuevoCarga()

            FacturarCotizacion = True
            Validar_Cotizacion = True
            LoadOrden = False
            LoadProyecto = False
            LoadRemision = False

            Dim DS As New DataSet

            DS = Cotizaciones.CotizacionDetalle(RegistroCotizacion)

            'cmbclientes.EditValue = DS.Tables("Cotizaciones").Rows(0).Item("Cliente_ID")
            cbCliente.EditValue = DS.Tables("Cotizaciones").Rows(0).Item("Cliente_ID")
            txtNombreDe.Text = DS.Tables("Cotizaciones").Rows(0).Item("Nombre")
            'txtfactura.Text = Format(Clientes.FacturaNumero, dd)
            TipoServicio.EditValue = DS.Tables("Cotizaciones").Rows(0).Item("Item_Tipo")



            With DS.Tables("Cotizaciones")
                Temp = True
                For i As Integer = 0 To .Rows.Count - 1
                    vFact.AddNewRow()
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Item_Id"))
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", .Rows(i).Item("Cot_Lin_Cantidad"))
                    'vFact.SetRowCellValue(vFact.FocusedRowHandle, "Cantidad", .Rows(i).Item("Cot_Lin_Cantidad"))
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Item_Precio"))
                    'vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", .Rows(i).Item("Cot_Lin_Descuento"))
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", .Rows(i).Item("Descuento"))
                Next
                vFact.MoveFirst()
                vFact.UpdateTotalSummary()
                Temp = False
            End With
            '
            Validar_Cotizacion = False
            HideSplash()
        End If
        '
        f.Dispose()
    End Sub

    Private Sub cmdOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cbCliente.EditValue Is Nothing Then
        '    XtraMsg("Seleccione el cliente")
        '    cbCliente.Focus()
        '    Exit Sub
        'End If
        ''
        'VerOrdenesTrabajo()
    End Sub

    Private Function Contabilizar() As Boolean
        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim CuentaIngr As String
        Dim CuentaIVA As String
        'Dim FactValor As String
        Dim IR As String
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        'Dim Fact As String
        Dim CuentaIR As String
        Dim CuentaCaja As String
        Dim CuentaCosto As String
        Dim CuentaInventario As String
        Dim CompNo As String
        Dim q As Integer
        Dim MontoCosto, MontoCostoTotal As Double
        Dim FormaPago As New VB.SysContab.Forma_PagoDB
        Dim CuentaIR_Alcaldia As String
        Dim Creditos, Debitos As Double
        Dim ClientesDB As New VB.SysContab.ClientesDB
        Dim detalleCliente As New VB.SysContab.ClientesDetails
        detalleCliente = ClientesDB.GetDetails(cbCliente.EditValue)

        If TipoServicio.EditValue = "P" Then
            ServCont = False
        Else
            ServCont = True
        End If

        'Fact = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 1)
        'FactValor = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 9)

        Dim TipoCOmpr As String '= Plantilla.GetPlantillasDetails(4, 2).TipoCompr

        If (lbltotal.Text - lbliva.Text) >= ConfigDetalles.MontoIR Then
            IR = (CDbl(lbltotal.Text) - CDbl(Me.lbliva.Text)) * Math.Round((ConfigDetalles.IRProd / 100), 2)
        End If

        'IR = CDbl(CDbl(etSubTotal.Text).ToString(Round)) * (CDbl(ConfigDetalles.IRProd) / 100.0)

        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  'Contado
            TipoCOmpr = Plantilla.GetPlantillasDetails(4, 1).TipoCompr

            If Plantilla.GetPlantillasDetails(4, 1).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 1).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 1).PlaID = "" Then
                MsgBox("No existen plantilla del tipo Pago de Contado")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
                Exit Function
            Else
                Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 1).Detalles

                CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
                CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")

                '' Buscar el municipio del cliente para aplicar el impuesto de la alcaldia
                If VB.SysContab.MunicipiosDB.GetDetails(detalleCliente.Departamento, detalleCliente.Municipio) Is Nothing Then
                    MsgBox("Hace falta asignarle al Cliente el Municipio correspondiente para la retención Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS-Contab")
                    Return False
                    'VB.SysContab.Rutinas.ErrorTransaccion()
                    Exit Function
                End If

                If detalleCliente.Municipio = "0" Or detalleCliente.RetenedorAlcaldia = False Then
                    IR_Alcaldia = 0
                    CuentaIR_Alcaldia = ""
                Else
                    If CDbl(CDbl(lblsubtotal.Text).ToString(Round)) >= VB.SysContab.MunicipiosDB.GetDetails(detalleCliente.Departamento, detalleCliente.Municipio).Impuesto_SVenta_Min Then
                        IR_Alcaldia = CDbl(CDbl(lblsubtotal.Text).ToString(Round)) * (VB.SysContab.MunicipiosDB.GetDetails(detalleCliente.Departamento, detalleCliente.Municipio).Impuesto_SVenta / 100.0)
                        CuentaIR_Alcaldia = DsPlantillas.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")
                    End If
                End If

                ' Solo cuando sea producto
                If TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then
                    CuentaCosto = DsPlantillas.Tables("PlantillasDetalles").Rows(4).Item("Cuenta")
                    CuentaInventario = DsPlantillas.Tables("PlantillasDetalles").Rows(5).Item("Cuenta")
                End If

                CompNo = Comprobantes.AddComprobante(TipoCOmpr, 1, "Comprobante de Factura No. " & cmbserie.Text & txtfactura.Text, 1, VB.SysContab.PeriodosDB.Activo(fecha.DateTime.Date), fecha.DateTime.Date,
                   0, "", False, 0, "", 0, cmbserie.Text & txtfactura.Text, VB.SysContab.Rutinas.Fecha, 0, False)

                Dim Prod As Boolean = False
                Dim CostoServicio As Double = 0.0

                For q = 0 To DT_Facturas.Rows.Count - 1
                    'If DT_Facturas.Rows(q).Item("Cuenta") = Nothing Then
                    '    MsgBox("Seleccione la cuenta del " & IIf(DT_Facturas.Rows(q)("Tipo") = "P", "Producto", "Servicio"))
                    '    Return False
                    '    Exit Function
                    'End If

                    If DT_Facturas.Rows(q)("Tipo") = "P" Then
                        MontoCosto = ((CDbl(DT_Facturas.Rows(q).Item("Cantidad")) + CDbl(DT_Facturas.Rows(q).Item("Promocion"))) * CDbl(DT_Facturas.Rows(q).Item("Costo")))
                        MontoCostoTotal = MontoCosto + MontoCostoTotal
                        Prod = True
                    End If

                    If IsNull(DT_Facturas.Rows(q).Item("Cuenta"), "0") = "0" Then
                        MsgBox("El Articulo " & DT_Facturas.Rows(q).Item("Item") & " no tiene cuenta contable asignada.  ")
                        VB.SysContab.Rutinas.ErrorTransaccion()
                        Return False
                        Exit Function
                    End If
                    'Cargo al inventario
                    If DT_Facturas.Rows(q)("Tipo") = "P" Then Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo al Inventario por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                                 MontoCosto, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                    If DT_Facturas.Rows(q)("Tipo") = "S" Then
                        Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo por Servicio de Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                        ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio"))), 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                        CostoServicio += ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio")))
                    End If
                Next
                'Caja
                Comprobantes.AddComprobanteDetalles(CompNo, CuentaCaja, "Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                             lbltotal.Text - CDbl(IR) - CDbl(IR_Alcaldia), 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                'Cuenta de Ingresos
                If TipoServicio.EditValue = "P" Or Prod Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIngr, "Ingreso por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                             lblsubtotal.Text - CostoServicio, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                ' Para IVA
                If CDbl(IsNull(lbliva.Text, 0)) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                         lbliva.Text, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                'Para IR
                If CDbl(IR) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIR, "IR Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                     CDbl(IR), 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                'PAra IR Alcaldia                                                                     
                If CDbl(IR_Alcaldia) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIR_Alcaldia, "IR Alcaldia Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                              CDbl(IR_Alcaldia), 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                ' Solo cuando sea producto o ambos
                If TipoServicio.EditValue = "P" Or Prod Then
                    'Costo de Venta
                    Comprobantes.AddComprobanteDetalles(CompNo, CuentaCosto, "Costo por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                    MontoCostoTotal, 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                End If
                VB.SysContab.ComprobanteDB.ContabilizarFactura(cmbserie.Text & Me.txtfactura.Text)
                Comprobantes.CancelarFactura(cmbserie.Text & Me.txtfactura.Text)
            End If
        Else 'Crédito
            TipoCOmpr = Plantilla.GetPlantillasDetails(4, 2).TipoCompr

            If Plantilla.GetPlantillasDetails(4, 2).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 2).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 2).PlaID = "" Then
                MsgBox("No existen plantilla del tipo Pago de Crédito")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
                Exit Function
            Else
                Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 2).Detalles

                CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

                ' Se valida que sea producto para no incluir las siguientes cuentas que no pertenecen a servicios
                ' So+++lo cuando sea producto
                If TipoServicio.EditValue = "P" Or TipoServicio.EditValue = "A" Then
                    CuentaCosto = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
                    CuentaInventario = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                End If

                IR = 0
                If ClientesDB.GetDetails(cbCliente.EditValue).Cuenta = "" Or ClientesDB.GetDetails(cbCliente.EditValue).Cuenta Is Nothing Then
                    XtraMsg("La cuenta del cliente no es valida", MessageBoxIcon.Error)
                    Return False
                    Exit Function
                End If

                CompNo = Comprobantes.AddComprobante(TipoCOmpr, 1, "Comprobante de Factura No. " & cmbserie.Text & txtfactura.Text, 1, VB.SysContab.PeriodosDB.Activo(fecha.DateTime.Date), fecha.DateTime.Date,
                    0, "", False, 0, "", 0, cmbserie.Text & txtfactura.Text, VB.SysContab.Rutinas.Fecha, 0, False)

                Dim Prod As Boolean = False
                Dim CostoServicio As Double = 0.0

                For q = 0 To DT_Facturas.Rows.Count - 1

                    If DT_Facturas.Rows(q)("Tipo") = "P" Then
                        MontoCosto = ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Costo")))
                        MontoCostoTotal = MontoCosto + MontoCostoTotal
                        Prod = True
                    End If

                    If IsNull(DT_Facturas.Rows(q).Item("Cuenta"), "") = "" Or IsNull(DT_Facturas.Rows(q).Item("Cuenta"), "") = "0" Then
                        MsgBox("El Articulo " & DT_Facturas.Rows(q).Item("Item") & " no tiene cuenta contable asignada.  ")
                        VB.SysContab.Rutinas.ErrorTransaccion()
                        Return False
                        Exit Function
                    End If
                    'Cargo al inventario
                    If DT_Facturas.Rows(q)("Tipo") = "P" Then Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo al Inventario por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                                 MontoCosto, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                    If DT_Facturas.Rows(q)("Tipo") = "S" Then
                        Comprobantes.AddComprobanteDetalles(CompNo, DT_Facturas.Rows(q).Item("Cuenta"), "Cargo por Servicio de Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                        ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio"))), 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                        CostoServicio += ((CDbl(DT_Facturas.Rows(q).Item("Cantidad"))) * CDbl(DT_Facturas.Rows(q).Item("Precio")))
                    End If
                Next
                'Cliente
                Comprobantes.AddComprobanteDetalles(CompNo, ClientesDB.GetDetails(cbCliente.EditValue).Cuenta, "Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                             lbltotal.Text, 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                'Cuenta de Ingresos
                If TipoServicio.EditValue = "P" Or Prod Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIngr, "Ingreso por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                           lblsubtotal.Text - CostoServicio, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                ' Para IVA
                If CDbl(IsNull(lbliva.Text, 0)) > 0 Then Comprobantes.AddComprobanteDetalles(CompNo, CuentaIVA, "IVA Por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                                                                             lbliva.Text, 0, TipoCOmpr, "C", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                ' Solo cuando sea producto o ambos
                If TipoServicio.EditValue = "P" Or Prod Then
                    'Costo de Venta
                    Comprobantes.AddComprobanteDetalles(CompNo, CuentaCosto, "Costo por Fact No. " & cmbserie.Text & Me.txtfactura.Text,
                    MontoCostoTotal, 0, TipoCOmpr, "D", cmbserie.Text & Me.txtfactura.Text, 0, fecha.DateTime.Date, 1)
                End If
                VB.SysContab.ComprobanteDB.ContabilizarFactura(cmbserie.Text & Me.txtfactura.Text)
            End If
        End If

        Return True

    End Function

    Private Function Guardar(Contado As Boolean) As Boolean

        Dim Agregado As Boolean = False

        'If VendedorEx Then
        If IsNull(cmbvendedor.EditValue, 0) = 0 Then
            XtraMsg("Seleccione al vendedor")
            cmbvendedor.Focus()
            Return False
        End If
        ' End If

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Return False
        End If

        If Trim(txtfactura.Text) = "" Then
            XtraMsg("Introduzca el No. de Factura", MessageBoxIcon.Error)
            txtfactura.Focus()
            Return False
        End If

        'If DetallesCliente.Empleado Then
        '    If cbEmpl.EditValue Is Nothing Then
        '        XtraMsg("Seleccion al Empleado")
        '        cbEmpl.Focus()
        '        Return False
        '    End If
        'End If

        If cmbformapago.EditValue = Nothing Then
            XtraMsg("Seleccione el Tipo de Pago")
            cmbformapago.Focus()
            Return False
        End If

        If cmbmoneda.EditValue = Nothing Then
            XtraMsg("Seleccion la moneda de mantenimiento de valor de la factura")
            cmbmoneda.Focus()
            Return False
        End If
        '
        'If ObtieneDatos("SELECT * FROM TipoCultivo WHERE Empresa = " & EmpresaActual).Rows.Count = 0 Then
        '    MsgBox("Seleccione el Tipo de Cultivo", MsgBoxStyle.Information, "STS-Contab")
        '    Me.cbCultivos.Focus()
        '    Return False
        'End If

        If DT_Facturas.Rows.Count - 1 < 0 Then
            XtraMsg("Seleccione al menos un Producto o Servicio", MessageBoxIcon.Error)
            Return False
        End If

        If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
            XtraMsg("El monto es mayor que el saldo de la factura", MessageBoxIcon.Error)
            Return False
        End If

        Dim Tipo As String

        If TipoServicio.EditValue = "P" Then
            Tipo = 0
        ElseIf TipoServicio.EditValue = "S" Then
            Tipo = 1
        Else
            Tipo = 2
        End If

        'Validar si es factura de Remision
        If LoadRemision Then
            Dim obj As New Remisiones
            Dim db As New db_Remisiones

            'obj.IdRemision = IdRemision
            obj.Factura = cmbserie.Text & txtfactura.Text

            If Not db.Facturar(obj, IdRemision) Then Return False
        End If

        'Validar si es factura de Orden de Trabajo
        If LoadOrden Then
            Dim db As New db_OrdenesTrabajo
            If Not db.Facturar(RegistroOrden, cmbserie.Text & txtfactura.Text) Then Return False
        End If

        ' Return False

        Return VB.SysContab.ClientesDB.GuardarFactura(cmbserie.Text & txtfactura.Text,
                fecha.DateTime.Date,
                cbCliente.EditValue,
                txtruc.Text,
                lblsubtotal.Text,
                lbltotal.Text,
                vFact.Columns("Descuento").SummaryItem.SummaryValue * 100,
                lbliva.Text,
                "0",
                 IIf(chkAsociar.Checked, cbClienteConvenio.EditValue, 0),
                lbltotal.Text,
                CDbl(lbltotal.Text) - TotalGlobal,
                IsNull(cmbvendedor.EditValue, 0),
                FechaPago.DateTime.Date,
                FechaPago.DateTime.Date,
                Tipo,
                cmbformapago.EditValue,
                txtNombreDe.Text,
                DetallesCliente.Retenedor,
                cmbmoneda.EditValue,
                cbBodega.EditValue, ConfigDetalles.SeriesMultiples,
                txtremision.Text, txtorden.Text, Caja, cbCultivos.EditValue, txtNoEntrega.Text,
                txtCondiciones.Text, cmbserie.EditValue, txtfactura.Text, etTasa.EditValue,
                cbTipoFactura.EditValue, rgDespacho.EditValue, IIf(CheckEdit1.Checked, "02", MonedaBase),
                IIf(txtComentario.Text.Length = 0, "", txtComentario.Text), LoadCotizacionCliente, LoadOrden, Contado, TotalEfectivo, TotalNotaDebito,
                TotalCheques, cbCentroCosto.EditValue, TotalFactura, TotalGlobal, RecContado, IIf(Moneda Is Nothing, cmbmoneda.EditValue, Moneda),
                DT_Cheques, DT_Tarjetas, DT_Facturas)

        'Try
        '    'txtfactura.Text = Format(Clientes.FacturaNumero, dd)
        '    FacturaImprimir = txtfactura.Text
        '    'Se paso el registro en bodega, a frmSalidaBodega RMPR 17/04/2007
        '    'If Not Me.rbServicios.Checked = True Then
        '    '    VB.SysContab.BodegasDB.TransaccionBodega_Add(ConfigDetalles.Bodega, "V", Me.txtFactura.Text, Me.dtpFecha.Value, 0)
        '    'End If

        '    Clientes.AddFactura(cmbserie.Text & txtfactura.Text, _
        '        fecha.DateTime.Date, _
        '        cmbclientes.EditValue, _
        '        txtruc.Text, _
        '        lblsubtotal.Text, _
        '        lbltotal.Text, _
        '         vFact.Columns("Descuento").SummaryItem.SummaryValue * 100, _
        '        lbliva.Text, _
        '         "0", _
        '         "0", _
        '         lbltotal.Text, _
        '         CDbl(lbltotal.Text) - TotalGlobal, _
        '        IsNull(cmbvendedor.EditValue, 0), _
        '        FechaPago.DateTime.Date, _
        '        FechaPago.DateTime.Date, _
        '        Tipo, _
        '        cmbformapago.EditValue, _
        '        IIf(DetallesCliente.Empleado, Me.cbEmpl.Text.ToUpper, txtNombreDe.Text), _
        '        DetallesCliente.Retenedor, _
        '        cmbmoneda.EditValue, _
        '        cmbserie.Text, ConfigDetalles.SeriesMultiples, _
        '        txtremision.Text, txtorden.Text, Caja, Me.cbCultivos.EditValue, Me.txtNoEntrega.Text, _
        '        Me.txtCondiciones.Text, cmbserie.GetColumnValue("IdDetalle"), txtfactura.Text, Me.etTasa.EditValue, _
        '        IIf(DetallesCliente.Empleado, Me.cbEmpl.EditValue, Nothing), rgDespacho.EditValue, IIf(CheckEdit1.Checked, "02", MonedaBase), _
        '        IIf(txtComentario.Text.Length = 0, "", txtComentario.Text))

        '    Dim Descuento As Double
        '    Dim Iva As Double
        '    Dim Comision As Double
        '    Dim Comisiones As New VB.SysContab.ComisionDB

        '    Dim P As Integer
        '    Dim Item As Integer
        '    Dim q As Integer

        '    Dim dsComision As DataSet

        '    For i As Integer = 0 To DT_Facturas.Rows.Count - 1
        '        If DT_Facturas.Rows(i).Item("Descuento") Is DBNull.Value Then
        '            Descuento = 0
        '        Else
        '            Descuento = DT_Facturas.Rows(i).Item("Descuento")
        '        End If

        '        Comision = 0

        '        If DetallesCliente.Excento = True Then
        '            'DetallesCliente.Nombre
        '            Iva = 0
        '        Else
        '            If DT_Facturas.Rows(i).Item("Exento") = True Then
        '                Iva = 0
        '            Else
        '                Iva = ConfigDetalles.IVA
        '            End If
        '        End If

        '        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Tipo"), EmpresaActual)

        '        Clientes.AddFacturaLineas(cmbserie.Text & txtfactura.Text, DT_Facturas.Rows(i).Item("Item"), _
        '                                  DT_Facturas.Rows(i).Item("Cantidad"), DT_Facturas.Rows(i).Item("Precio"), _
        '                                   (CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) - ((CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")) * (Descuento)))) * Iva / 100.0, Descuento * 100, _
        '                                    CDbl(DT_Facturas.Rows(i).Item("Cantidad")) * CDbl(DT_Facturas.Rows(i).Item("Precio")), _
        '                                   Comision, DT_Facturas.Rows(i).Item("Tipo"), Iva, DetallesProducto.Nombre, _
        '                                  DT_Facturas.Rows(i).Item("Promocion"), IsNull(DT_Facturas.Rows(i).Item("Presentacion"), ""), _
        '                                  IsNull(DT_Facturas.Rows(i).Item("Comentario"), ""), IsNull(DT_Facturas.Rows(i).Item("Modelo"), ""), _
        '                                  IsNull(DT_Facturas.Rows(i).Item("NoSerie"), ""))


        '        '**** Si ContabilizarVenta = 1 Se realiza la Descarga de Inventario
        '        '**** Solicitado por RAMAC y Actualizado by JJAR.

        '        If ContabilizarVenta = 1 Then
        '            'Se paso a frmSalidaBodega 17/04/07 rmpr
        '            If DT_Facturas.Rows(i).Item("Tipo") = "P" Then
        '                'este if agregado = false lo agregue ya que daba error de primary key - JET
        '                If Agregado = False Then VB.SysContab.BodegasDB.TransaccionBodega_Add(BodegaCaja, "V", Me.txtfactura.Text, Me.fecha.DateTime.Date, cmbclientes.EditValue) : Agregado = True
        '                VB.SysContab.BodegasDB.Bodega_Articulos_Add(BodegaCaja, DT_Facturas.Rows(i).Item("Item"), (DT_Facturas.Rows(i).Item("Cantidad") + DT_Facturas.Rows(i).Item("Promocion")) * -1, 0, DT_Facturas.Rows(i).Item("Tipo"))
        '                VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(BodegaCaja, DT_Facturas.Rows(i).Item("Item"), "V", Me.txtfactura.Text, "S", DT_Facturas.Rows(i).Item("Cantidad") + DT_Facturas.Rows(i).Item("Promocion"), 0, 0, DT_Facturas.Rows(i).Item("Tipo"))
        '            End If

        '            'Si es nuevo agregar la cantidad
        '            If Articulos.ItemTemporalBuscar(DT_Facturas.Rows(i).Item("Item"), "C" & txtCaja.Text).Tables("Articulos").Rows.Count <> 0 Then
        '                Articulos.SumarExistencias(DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Cantidad") + DT_Facturas.Rows(i).Item("Promocion"), DT_Facturas.Rows(i).Item("Tipo"))
        '                'FacturasCompras.UpdateCantidadAlmacen(OrdenCompra, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Tipo"), tCust.Rows(i)("Cantidad"))
        '            End If

        '            'Actualizar la Existencia del Item
        '            Articulos.RestarExistencias(DT_Facturas.Rows(i).Item("Item"), DT_Facturas.Rows(i).Item("Cantidad") + DT_Facturas.Rows(i).Item("Promocion"), DT_Facturas.Rows(i).Item("Tipo"))
        '        End If
        '    Next

        '    '/***ESTO YA NO VA, NO ES NECEARIO, ***/  
        '    'If VentaPerdidaNumero <> 0 Then
        '    '    Clientes.VentasPerdidasUpdateFactura(VentaPerdidaNumero, "C" & txtCaja.Text, "F" & cmbserie.Text & txtfactura.Text)
        '    'End If

        '    '/***ESTO YA NO VA, NO ES NECEARIO, ***/  
        '    'If LoadFacturaTemporal = True Then 'Actualizar Estado de Factura Temporal
        '    '    FacturaTemporal.UpdateEstado(RegistroFacturaTemporal)
        '    'End If

        '    If LoadCotizacionCliente = True Then
        '        ObtieneDatos("UPDATE Cotizaciones SET Factura_id = '" & cmbserie.Text & txtfactura.Text & "',Cot_Estado = 'F' FROM Cotizaciones WHERE Cot_Id = " & RegistroCotizacion)
        '    End If

        '    If LoadOrden = True Then 'Actualizar Estado de Factura Temporal
        '        ObtieneDatos("SP_OrdenesUpdateEstado '" & RegistroOrden & "'," & EmpresaActual & ",'" & cmbserie.Text & txtfactura.Text & "'")
        '    End If

        '    '/***ESTO YA NO VA, NO ES NECEARIO, ***/  
        '    'Articulos.ItemTemporalDelete("C" & PvCodigo)

        'Catch ex As Exception
        '    XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
        '    VB.SysContab.Rutinas.ErrorTransaccion()

        '    '15/11/2005
        '    'transaccionFacturas.Rollback()
        '    'DBConnFacturas.Close()

        '    Return False
        '    Exit Function
        'End Try

        ''15/11/2005
        ''transaccionFacturas.Commit()
        ''DBConnFacturas.Close()
        ''MsgBox("Los datos se guardaron correctamente", MsgBoxStyle.Information)
        'Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Facturar()
    End Sub

    Sub Facturar()

        '*******************************************************************************************
        'Verificar Cierre del Día
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        'Verificar Cierre de Bolsa
        If fecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
            XtraMsg("La fecha con la que intenta grabar esta factura ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Warning)
            Exit Sub
        End If
        '*******************************************************************************************

        '*******************************************************************************************
        ' Validar Cierre de Inventario, si hay productos de inventario
        Dim dr() As DataRow = DT_Facturas.Select("Tipo = 'P'")
        '
        If dr.Length > 0 Then
            If Not VerificarCierre_Inventario(fecha.DateTime.Date) Then
                Exit Sub
            End If
        End If
        '*******************************************************************************************

        If ObtieneDatos("SP_VerificarFV_Existe '" & cmbserie.Text & txtfactura.Text & "'," & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Número de Factura: " + cmbserie.Text & txtfactura.Text + " Ya existe, Favor revisar la configuracion de la caja", MessageBoxIcon.Error)
            CargaSeries()
            Exit Sub
        End If
        '
        'Validar si la Serie esta Vacia
        If ConfigDetalles.SeriesMultiples Then  'Si la Empresa esta configurada como MultiSerie
            If Me.cmbserie.Text.Trim.Length = 0 Then
                XtraMsg("Por Favor Configure la Serie de la Factura para continuar con la Facturación.", MessageBoxIcon.Error)
                Me.cmbserie.Focus()
                Exit Sub
            End If
        End If
        ''
        If EmpresaActual = 1 Then
            If cbCultivos.EditValue = "99" Or cbCultivos.ItemIndex = 0 Then
                XtraMsg("Seleccione Tipo de Cultivo", MessageBoxIcon.Warning)
                cbCultivos.Focus()
                Exit Sub
            End If
        End If
        '
        If rgDespacho.EditValue = "" Or rgDespacho.EditValue = Nothing Then
            XtraMsg("Seleccione la Bodega de Despacho", MessageBoxIcon.Warning)
            rgDespacho.Focus()
            Exit Sub
        End If
        '
        'Validar que no se pueda facturar Clientes de Otra Sucursal
        If EmpresaActual = 1 Then   'Solo para RAMAC
            If Mid(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "CodigoLetra"), 1, 2).Length > 0 Then
                'If Mid(cmbclientes.GetColumnValue("CodigoLetra"), 1, 2).Length > 0 Then
                If Mid(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "CodigoLetra"), 1, 2).ToString <> DetallesBodega.Sucursal Then
                    If Not XtraMsg2("El Cliente que esta Intentando Facturar pertenece a otra sucursal." & vbCrLf & "¿Dese continuar con la Facturación?") Then
                        Exit Sub
                    End If
                End If
            End If
        End If
        '
        If EmpresaActual = 7 Then   'Validar solo para EQUIPSA
            If cbCliente.EditValue = 1 Then    'Validar Para clientes Varios
                XtraMsg("El Cliente que esta intentando Facturar no es un Cliente de CREDITO!", MessageBoxIcon.Error)
                cbCliente.Focus()
                Exit Sub
            End If
        End If

        If Not ValidarFacturasVencidas() Then
            Exit Sub
        End If

        'If cbTipoFactura.SelectedIndex = 0 Then 'Contado
        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  'Contado
            If CDbl(CDbl(TotalGlobal).ToString(Round)) < CDbl(CDbl(lbltotal.Text).ToString(Round)) Then
                XtraMsg("La Factura es de Contado, el monto a pagar debe ser igual al total de la Factura.", MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else 'Crédito
            TotalGlobal = 0
            'If CDbl(CDbl(TotalGlobal).ToString(Round)) = CDbl(CDbl(lbltotal.Text).ToString(Round)) Then
            '    XtraMsg("La Factura es de Crédito, el monto a pagar no puede ser igual al total de la Factura.", MessageBoxIcon.Warning)

            '    Exit Sub
            'End If
            ''
            If strOrdenPago = "Orden de Pago" Then
                If txtremision.Text.Trim.Length = 0 Then
                    XtraMsg("Introduzca el # de Remisión", MessageBoxIcon.Warning)
                    txtremision.Focus()
                    Exit Sub
                End If
                ''
                If txtorden.Text.Trim.Length = 0 Then
                    XtraMsg("Introduzca el # de Orden de Compra", MessageBoxIcon.Warning)
                    txtorden.Focus()
                    Exit Sub
                End If
                ''
                If txtNoEntrega.Text.Trim.Length = 0 Then
                    XtraMsg("Introduzca el # de Orden de Entrega", MessageBoxIcon.Warning)
                    txtNoEntrega.Focus()
                    Exit Sub
                End If
            End If
            '
            '*****************  Validando Limite de Credito del Cliente
            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)
            'If CDbl(cmbclientes.GetColumnValue("ValidarLimite")) Then
            If DetallesCliente.ValidarLimite Then
                Dim Saldo As Double = ObtieneDatos("SELECT isnull(dbo.fn_JAR_GetSaldoCliente(" & cbCliente.EditValue & "," & EmpresaActual & "),0.00) Saldo").Rows.Item(0)("Saldo")
                '
                If MonedaBase = DetallesCliente.Moneda Then  ' cmbclientes.GetColumnValue("Moneda") Then
                    If Saldo <= 0 Then
                        XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        If CDbl(lbltotal.Text) > Saldo Then
                            XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                Else
                    If Saldo <= 0 Then
                        XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        If CDbl(lbltotalU.Text) > Saldo Then
                            XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If

                End If
            End If
        End If
        '
        If fecha.DateTime.Date > VB.SysContab.Rutinas.Fecha().Date Then
            If Not XtraMsg2("La Fecha de Facturación: " & fecha.DateTime.ToShortDateString & " es Mayor a la Fecha Actual: " & VB.SysContab.Rutinas.Fecha().Date.ToShortDateString & vbCrLf & "Confirmar Facturar de todos modos?") Then
                Exit Sub
            End If
        End If
        '
        If chkAsociar.Checked Then
            If cbClienteConvenio.EditValue Is Nothing Then
                XtraMsg("Seleccione el Cliente según convenio", MessageBoxIcon.Warning)
                cbClienteConvenio.Focus()
                Exit Sub
            End If
        End If

        If Not XtraMsg2("¿ ESTA SEGURO QUE LA INFORMACIÓN ES CORRECTA ?") Then
            Exit Sub
        End If

        ''
        '/************** inicializar los datatables, solo se usan en el caso de que sea pago de contado y que se pague a travez de CK o Tarjeta ************************************
        If DT_Cheques Is Nothing Then DT_Cheques = ObtieneDatos("SELECT Banco,NoCheque Cheque,Cuenta,Monto_Cheque Monto,Moneda FROM Cobros WHERE 0 = 1")
        If DT_Tarjetas Is Nothing Then DT_Tarjetas = ObtieneDatos("SELECT Tipo_Tarjeta Tipo,Emisor,No_Tarjeta Tarjeta,Autorizacion,Monto_Tarjeta Monto FROM Cobros WHERE 0 = 1")
        '****************************************************************************************************************************************************************************/


        Try
            If Not Guardar(False) Then Exit Sub

            If XtraMsg2("¿ IMPRIMIR FACTURA ?") Then
                'If cbTipoFactura.EditValue Is Nothing Then ImprimirFactura()
                'If Not cbTipoFactura.EditValue Is Nothing Then ImprimirFactura2()


                If cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura(cmbserie.Text & txtfactura.Text,
                                                                                             FormaPago.FormaPagoDias(cmbformapago.EditValue), False)

                If Not cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura2(cmbserie.Text & txtfactura.Text,
                                                                                                  cbTipoFactura.EditValue, False)

            End If

            Nuevo()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try


        'Try
        '    'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        '    'DBConnFacturas.Open()
        '    'transaccionFacturas = DBConnFacturas.BeginTransaction


        '    'Guardar los datos de la Factura
        '    'If Guardar() = False Then
        '    '    'Try
        '    '    '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    '    'Catch ex As Exception
        '    '    'End Try
        '    '    Exit Sub
        '    'End If

        '    ' Validar si se Contabilizará la Factura
        '    ' Solicitado para RAMAC y Actulizado by JJAR.
        '    'If ContabilizarVenta = 1 Then
        '    '    If Contabilizar() = False Then
        '    '        Try
        '    '            VB.SysContab.Rutinas.ErrorTransaccion()
        '    '        Catch ex As Exception

        '    '        End Try
        '    '        Exit Sub
        '    '    End If
        '    'End If



        '    GuardarPagos()
        '    'VB.SysContab.Rutinas.okTransaccion()
        '    'SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, Me.txtfactura.Text)
        '    LoadFacturaTemporal = False
        '    LoadOrden = False

        '    If MessageBox.Show("¿ IMPRIMIR FACTURA ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '        ImprimirFactura()
        '    End If

        '    Nuevo()
        'Catch ex As Exception
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    'SetTiempos(OrigenComprobantes.FACTURA, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, Me.txtfactura.Text)
        '    XtraMsg(ex.Message & "Aceptar", MessageBoxIcon.Error)
        '    Exit Sub
        'End Try
    End Sub

    Function ValidarFacturasVencidas()
        DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        Dim result As Boolean = True

        If DetalleEmpresa.ValidarFV Then
            'DetallesCliente = ClientesDB.GetDetails(cbCliente.EditValue)
            'Validar que el cliente sea de credito
            ' If FormaPago.FormaPagoDias(DetallesCliente.Cod_Forma_Pago) > 0 Then

            Dim _dt As DataTable = ObtieneDatos("sp_GetAntiguedadSaldoxCliente", cbCliente.EditValue,
                                                    cmbmoneda.EditValue,
                                                    EmpresaActual)


            If _dt.Rows.Count > 0 Then
                frmFacturasVentasVencidas.Dispose()
                '
                With frmFacturasVentasVencidas
                    .Text = "Facturas Vencidas del Cliente: " & cbCliente.Text
                    .Origen = 1
                    .DT = _dt
                    .ShowDialog()
                    result = .Ok

                    If result Then BitacoraVencidas = .mRazon.Text
                    If Not result Then BitacoraVencidas = ""
                End With
            End If

            ' End If

            Return result
        Else
            Return True
        End If

    End Function

    Function GuardarPagos()

        Dim TipoCambio As Double
        Dim TipoC As New VB.SysContab.Tasa_CambioDB

        If TipoC.GetTasaCambioDia(Now.Month, Now.Year, Now.Day).Tables("Tasa_Cambio").Rows.Count = 0 Then
            TipoCambio = 0
        Else
            TipoCambio = TipoC.GetTasaCambioDia(Now.Month, Now.Year, Now.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")
        End If

        If Clientes.GenerarTransaccion.Tables("Cobros").Rows.Count = 0 Then
            Transaccion = "1"
        Else
            Transaccion = Clientes.GenerarTransaccion.Tables("Cobros").Rows(0).Item("Transaccion") + 1
        End If

        Dim Numero As Long
        Numero = Clientes.CobrosNumero

        Dim Tipo As Integer

        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  'Contado
            Tipo = 0 + 1 'Cancela la Factura
            Recibo = 0
        Else 'Crédito
            Tipo = 1 + 1
            'Generar Recibo
            If Clientes.GenerarReciboTrans.Tables("Cobros").Rows.Count = 0 Then
                Recibo = Format(ConfigDetalles.ReciboNumero, dd)
            Else
                Recibo = Format(Clientes.GenerarReciboTrans.Tables("Cobros").Rows(0).Item("Recibo") + 1, dd)
            End If
        End If

        If GuardarFactura Then
            Recibo = RecContado
        End If

        '/*********************************************************************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '*********************************************************************************/
        Try

            'Guardar los datos Efectivo.
            If TotalEfectivo <> 0 Then
                Clientes.AddCobro(Numero, Recibo, Me.cmbserie.Text & txtfactura.Text, fecha.EditValue, 1, TotalGlobal,
                  "", 0, "", "0", "", "", "", "", "0", TotalEfectivo, Moneda, TipoCambio, TotalFactura - TotalGlobal, "0", "", Tipo, Transaccion, 1, IR, IR_Alcaldia, 0, 0, txtCaja.Text, "", cbCliente.Text, "EL MISMO")
            End If
            Numero = Numero + 1
            'Guardar los datos de Nota de Débito.
            If TotalNotaDebito <> 0 Then
                Clientes.AddCobro(Numero, Recibo, Me.cmbserie.Text & txtfactura.Text, fecha.EditValue, 4, TotalGlobal,
                  "", 0, "", "0", "", "", "", "", "0", "0", Moneda, TipoCambio, TotalFactura - TotalGlobal, TotalNotaDebito, CuentaNotaDebito, Tipo, Transaccion, 1, 0, 0, 0, 0, txtCaja.Text, "", cbCliente.Text, "EL MISMO")
            End If
            Numero = Numero + 1
            'Guardar los pagos por cheques
            If TotalCheques > 0 Then

                For i As Integer = 0 To DT_Cheques.Rows.Count - 1
                    Clientes.AddCobro(Numero, Recibo, Me.cmbserie.Text & txtfactura.Text, fecha.EditValue, 2, TotalGlobal,
                                      DT_Cheques.Rows(i).Item("Cheque"),
                                      DT_Cheques.Rows(i).Item("Banco"),
                                      DT_Cheques.Rows(i).Item("Cuenta"),
                                      DT_Cheques.Rows(i).Item("Monto"),
                                      "", "", "", "", "0", "0", DT_Cheques.Rows(i).Item("Moneda"), TipoCambio,
                                      TotalFactura - TotalGlobal, "0", "", Tipo, Transaccion, 1, 0, 0, 0, 0, txtCaja.Text, "", cbCliente.Text, "EL MISMO")
                    Numero = Numero + 1
                Next
            End If

            Numero = Numero + 1
            'Guardar los pagos por Tarjeta de Crédito
            If TotalTarjetas > 0 Then
                For i As Integer = 0 To DT_Tarjetas.Rows.Count - 1
                    Clientes.AddCobro(Numero, Recibo, Me.cmbserie.Text & txtfactura.Text, fecha.EditValue, 3, TotalGlobal,
                                      "", 0, "", "0",
                                      DT_Tarjetas.Rows(i).Item("Tipo"),
                                      DT_Tarjetas.Rows(i).Item("Emisor"),
                                      DT_Tarjetas.Rows(i).Item("Tarjeta"),
                                      DT_Tarjetas.Rows(i).Item("Autorizacion"),
                                      DT_Tarjetas.Rows(i).Item("Monto"), "0", 1, TipoCambio,
                                      TotalFactura - TotalGlobal, "0", "", Tipo, Transaccion, 1, 0, 0, 0, 0, txtCaja.Text, "", cbCliente.Text, "EL MISMO")
                    Numero = Numero + 1
                Next
            End If


            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try

        'LimpiarControles()
    End Function

    'Private Sub ImprimirFactura(Optional Previa As Boolean = False)

    '    Dim Cadena As String
    '    Dim Temp As Boolean = False
    '    Dim Data() As Byte

    '    ShowSplash("Imprimiendo...")

    '    Try
    '        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  '' Factura de Contado
    '            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 2 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '        Else    ' Factura de Credito
    '            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 9 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
    '        End If

    '        Temp = True
    '        Dim Tamano As Integer
    '        Tamano = Data.GetUpperBound(0)

    '        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  '' Factura de Contado
    '            Cadena = Application.StartupPath & "\RptFactura.repx"
    '        Else    ' Factura de Credito
    '            Cadena = Application.StartupPath & "\RptFacturaCredito.repx"
    '        End If

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()
    '    Catch ex As Exception
    '        Temp = False
    '        'Exit Sub
    '    End Try
    '    'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
    '    Dim Rep As XtraReport

    '    If Temp = True Then
    '        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  '' Factura de Contado
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFactura.repx", True)
    '        Else    ' Factura de Credito
    '            Rep = XtraReport.FromFile(Application.StartupPath & "\RptFacturaCredito.repx", True)
    '        End If
    '    Else
    '        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  '' Factura de Contado
    '            Rep = New RptFacturaNew
    '        Else
    '            Rep = New RptFacturaNewCredito
    '        End If
    '    End If

    '    'Rep.DataSource = ObtieneDatos("SPGetRptFactura " & EmpresaActual & ",'" & txtfactura.Text & "'")
    '    'Rep.ShowRibbonPreview()

    '    If Previa Then
    '    Else
    '        If FormaPago.FormaPagoDias(cmbformapago.EditValue) = 0 Then  '' Factura de Contado
    '            Rep.DataSource = ObtieneDatos("sp_GetRptFacturaContado " & EmpresaActual & ",'" & cmbserie.Text & txtfactura.Text & "'," & RecVuelto)
    '        Else
    '            Rep.DataSource = ObtieneDatos("sp_GetRptFacturaCredito " & EmpresaActual & ",'" & cmbserie.Text & txtfactura.Text & "'," & RecVuelto)
    '        End If
    '    End If
    '    '
    '    HideSplash()
    '    Rep.ShowPrintMarginsWarning = False
    '    Rep.BringToFront()
    '    Rep.ShowRibbonPreview()
    '    RecVuelto = 0
    'End Sub

    'Sub ImprimirFactura2(Optional Previa As Boolean = False)

    '    ShowSplash("Imprimiendo...")

    '    Dim Temp As Boolean = False

    '    Try
    '        Dim Data() As Byte = CType(db_TipoFacturas.Listar(cbTipoFactura.EditValue).Rows.Item(0)("Formato"), Byte())

    '        Temp = True
    '        Dim Tamano As Integer = 0
    '        Tamano = Data.GetUpperBound(0)

    '        Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()

    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim rpt As RptFacturaNew

    '    If Not Temp Then
    '        rpt = New RptFacturaNew
    '    Else
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
    '    End If

    '    If Previa Then
    '        rpt.DataSource = ObtieneDatos("sp_GetRptFacturaTemporal", EmpresaActual)
    '    Else
    '        rpt.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, cmbserie.Text & txtfactura.Text, RecVuelto)
    '    End If
    '    '
    '    HideSplash()
    '    rpt.ShowPrintMarginsWarning = False
    '    rpt.BringToFront()
    '    rpt.ShowRibbonPreview()
    '    RecVuelto = 0
    'End Sub

    Private Sub Nuevo()

        '/*** Globales   **************/
        DT_Cheques = Nothing
        DT_Tarjetas = Nothing
        FacturarCotizacion = False
        LoadOrden = False
        LoadCotizacionCliente = False
        LoadProyecto = False
        LoadRemision = False

        TotalCheques = 0
        TotalTarjetas = 0
        TotalEfectivo = 0
        TotalNotaDebito = 0
        TotalFactura = 0
        TotalGlobal = 0
        RecContado = 0

        LoadFacturaTemporal = False
        '**************************/

        frmProyectosClientes.Dispose()
        LimpiarControles(Me)
        GetData()

        If Me.cmbformapago.GetColumnValue("Dias") > 0 Then
            cbCliente.EditValue = Nothing
            cbCliente.Focus()
        End If

        fecha.EditValue = Now.Date
        FechaPago.EditValue = Now.Date

        lblsubtotal.Text = "0.00"
        lbltotal.Text = "0.00"
        lbltotalU.Text = "0.00"
        lbliva.Text = "0.00"

        'Me.vClientes.PopulateColumns()
        'Me.vEmpl.Columns("Codigo").FilterInfo.Type=
        'Me.vEmpl.Columns("CodigoLetra").FilterInfo.FilterString = ""
        'Me.vEmpl.Columns("Nombre").FilterInfo.FilterString = ""

        CargaSeries()
        Inicio = True : CargarCaja() : Inicio = False

        cmbserie.EditValue = Nothing
        cmbserie.ItemIndex = 0
        cmbserie.ClosePopup()

        txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)
        cbTipoFactura.ItemIndex = 0

        LoadClients()
        cbCliente.Focus()

        vFact.Columns("Visible").Visible = False
        vFact.Columns("Agrupar").Visible = False
        vFact.Columns("IdProyecto").Visible = False
        vFact.Columns("Presentacion").Caption = "Presentación"


        If EmpresaActual <> 1 Then
            vFact.Columns("Presentacion").Visible = False
            vFact.Columns("Cantidad").Visible = False
            vFact.Columns("Factor").Visible = False
            vFact.Columns("#").Visible = True
        Else
            vFact.Columns("#").Visible = False
        End If

        'Try
        '    If Me.cmbformapago.GetColumnValue("Dias") > 0 Then
        '        cbCliente.EditValue = 1
        '    End If
        '    cbCliente.Focus()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub cmbserie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbserie.ButtonClick
        If e.Button.Index = 1 Then
            CargaSeries()
            CargarCaja()
        End If
    End Sub

    Private Sub cmbserie_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserie.EditValueChanged
        If IsNumeric(cmbserie.GetColumnValue("Factura")) Then
            txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)
            '    txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)
            ' cmbserie.EditValue
        End If
    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        Pagos()
    End Sub

    Sub Pagos()
        '*******************************************************************************************
        'Verificar Cierre del Día
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************        
        '
        '*******************************************************************************************
        'Verificar Cierre de Bolsa
        If fecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
            XtraMsg("La fecha: " & fecha.DateTime.ToShortDateString & " con la que intenta grabar esta Nota ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
            Exit Sub
        End If
        '*******************************************************************************************


        '*******************************************************************************************
        ' Validar Cierre de Inventario, si hay productos de inventario
        Dim dr() As DataRow = DT_Facturas.Select("Tipo = 'P'")
        '
        If dr.Length > 0 Then
            If Not VerificarCierre_Inventario(fecha.DateTime.Date) Then
                Exit Sub
            End If
        End If
        '*******************************************************************************************

        If ObtieneDatos("SP_VerificarFV_Existe '" & cmbserie.Text & txtfactura.Text & "'," & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Numero de Factura: " + cmbserie.Text & txtfactura.Text + " Ya existe, Favor revisar la configuracion de la caja", MessageBoxIcon.Error)
            Exit Sub
        End If

        '
        ''Validar si la Serie esta Vacia
        'If ConfigDetalles.SeriesMultiples Then  'Si la Empresa esta configurada como MultiSerie
        '    If Me.cmbserie.Text.Trim.Length = 0 Then
        '        XtraMsg("Por Favor Configure la Serie de la Factura para continuar con la Facturación.", MessageBoxIcon.Error)
        '        Me.cmbserie.Focus()
        '        Exit Sub
        '    End If
        'End If
        '
        If rgDespacho.EditValue = "" Or rgDespacho.EditValue = Nothing Then
            XtraMsg("Seleccione la Bodega de Despacho", MessageBoxIcon.Warning)
            rgDespacho.Focus()
            Exit Sub
        End If
        ''
        'Validar que no se pueda facturar Clientes de Otra Sucursal
        If EmpresaActual = 1 Then   'Validar solo para RAMAC
            If Mid(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "CodigoLetra"), 1, 2).Length > 0 Then
                If Mid(cbCliente.Properties.View.GetRowCellValue(cbCliente.Properties.View.FocusedRowHandle, "CodigoLetra"), 1, 2).ToString <> DetallesBodega.Sucursal Then
                    If Not XtraMsg2("El Cliente que esta Intentando Facturar pertenece a otra sucursal." & vbCrLf & "¿Dese continuar con la Facturación?") Then
                        Exit Sub
                    End If
                End If
            End If
        End If

        'Para las Equipsas


        Try
            Clientes.DeleteReciboCheques(cmbserie.Text & txtfactura.Text, IsNull(Caja, 0))
            Clientes.DeleteReciboTarjetas(cmbserie.Text & txtfactura.Text, IsNull(Caja, 0))
        Catch ex As Exception

        End Try
        If VendedorEx Then
            If IsNull(cmbvendedor.EditValue, 0) = 0 Then
                XtraMsg("Seleccione al vendedor")
                cmbvendedor.Focus()
                Exit Sub
            End If
        End If

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If

        If Trim(txtfactura.Text) = "" Then
            XtraMsg("Introduzca el No. de Factura", MessageBoxIcon.Error)
            txtfactura.Focus()
            Exit Sub
        End If

        If cmbformapago.EditValue Is Nothing Then
            XtraMsg("Seleccione el Tipo de Pago")
            cmbformapago.Focus()
            Exit Sub
        End If

        If cmbmoneda.EditValue Is Nothing Then
            XtraMsg("Seleccion la moneda de mantenimiento de valor de la factura")
            cmbmoneda.Focus()
            Exit Sub
        End If

        If DT_Facturas.Rows.Count - 1 < 0 Then
            XtraMsg("Seleccione al menos un Producto o Servicio", MessageBoxIcon.Error)
            Exit Sub
        End If
        ''
        If strOrdenPago = "Orden de Pago" And EmpresaActual = 1 Then
            If cbCultivos.EditValue = "99" Or cbCultivos.ItemIndex = 0 Then
                XtraMsg("Seleccione Tipo de Cultivo", MessageBoxIcon.Warning)
                cbCultivos.Focus()
                Exit Sub
            End If
        End If
        ''
        If fecha.DateTime.Date > VB.SysContab.Rutinas.Fecha().Date Then
            If Not XtraMsg2("La Fecha de Facturación: " & fecha.DateTime.ToShortDateString & " es Mayor a la Fecha Actual: " & VB.SysContab.Rutinas.Fecha().Date.ToShortDateString & vbCrLf & "Confirmar Facturar de todos modos?") Then
                Exit Sub
            End If
        End If

        If chkAsociar.Checked Then
            If cbClienteConvenio.EditValue Is Nothing Then
                XtraMsg("Seleccione el Cliente según convenio", MessageBoxIcon.Warning)
                cbClienteConvenio.Focus()
                Exit Sub
            End If
        End If

        RecVuelto = 0

        If DT_Cheques Is Nothing Then DT_Cheques = ObtieneDatos("SELECT Banco,NoCheque Cheque,Cuenta,Monto_Cheque Monto,Moneda FROM Cobros WHERE 0 = 1")
        If DT_Tarjetas Is Nothing Then DT_Tarjetas = ObtieneDatos("SELECT Tipo_Tarjeta Tipo,Emisor,No_Tarjeta Tarjeta,Autorizacion,Monto_Tarjeta Monto FROM Cobros WHERE 0 = 1")

        Dim f As New frmTiposPago
        Recibo = Me.cmbserie.Text & txtfactura.Text
        Registro = Me.cmbserie.Text & txtfactura.Text
        f.etCaja.Text = Caja
        TotalFactura = CDbl(lbltotal.Text)
        'f.Cuenta = DetallesCliente.Cuenta        
        'f.IdCliente = cbCliente.EditValue
        'f.IR = DetallesCliente.Retenedor
        'f.IrAlma = DetallesCliente.RetenedorAlcaldia
        f.DetallesCliente = DetallesCliente
        f.txtMonto.Text = CDbl(lbltotal.Text)
        f.SubTotalIR = lblsubtotal.EditValue
        f.Efectivo()
        f.ShowDialog()

        RecContado = IsNull(f.txtrecibo.Text, 0)
        RecVuelto = IsNull(f.lbVuelto.Text, 0)

        Dim MontoIR As Double = IIf(f.chkRetencion.Checked And f.txtIR.EditValue > 0, f.txtIR.EditValue, 0.00)
        Dim MontoAlma As Double = IIf(f.chkAlma.Checked And f.txtAlma.EditValue > 0, f.txtAlma.EditValue, 0.00)

        'Si en el Form Tipos de Pago hace clic en Aceptar: Guardar la Factura
        Moneda = f.cbMoneda.EditValue
        f.Dispose()

        If GuardarFactura Then
            Try
                If Not Guardar(True) Then Exit Sub

                If MontoIR > 0.00 Or MontoAlma > 0.00 Then VB.SysContab.ClientesDB.FacturaVentaUpdateIR(cmbserie.Text & txtfactura.Text, MontoIR, MontoAlma)

                ' VB.SysContab.ClientesDB.CobrosUpdateIR()
                'Guardar los pagos efectuados a la factura
                'GuardarPagos()

                If XtraMsg2("¿ IMPRIMIR FACTURA ?") Then
                    'If cbTipoFactura.EditValue Is Nothing Then ImprimirFactura()
                    'If Not cbTipoFactura.EditValue Is Nothing Then ImprimirFactura2()

                    If cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura(cmbserie.Text & txtfactura.Text,
                                                                                             FormaPago.FormaPagoDias(cmbformapago.EditValue), False)

                    If Not cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura2(cmbserie.Text & txtfactura.Text,
                                                                                                      cbTipoFactura.EditValue, False)

                End If

                ' If RecContado > 0 Then ImprimeRecibo()

                Nuevo()
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
        End If

        'If GuardarFactura = True Then

        '    Try
        '        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        '        DBConnFacturas.Open()
        '        transaccionFacturas = DBConnFacturas.BeginTransaction

        '        'Guardar los datos de la Factura
        '        If Guardar() = False Then
        '            VB.SysContab.Rutinas.ErrorTransaccion()
        '            GuardarFactura = False
        '            Exit Sub
        '        End If

        '        ' Validar si se Contabilizará la Factura
        '        ' Solicitado para RAMAC y Actulizado by JJAR.
        '        If ContabilizarVenta = 1 Then
        '            If Contabilizar() = False Then
        '                VB.SysContab.Rutinas.ErrorTransaccion()
        '                GuardarFactura = False
        '                Exit Sub
        '            End If
        '        End If


        '        'Guardar los pagos efectuados a la factura
        '        GuardarPagos()
        '        'LimpiarControles()
        '        VB.SysContab.Rutinas.okTransaccion()
        '        LoadFacturaTemporal = False
        '        LoadOrden = False
        '        'RestablecerDataset()
        '        'Me.Rellenar()

        '        If XtraMsg2("¿ IMPRIMIR FACTURA ?") Then
        '            ImprimirFactura()
        '        End If

        '        If RecContado > 0 Then ImprimeRecibo()

        '        Nuevo()
        '    Catch ex As Exception
        '        VB.SysContab.Rutinas.ErrorTransaccion()
        '        GuardarFactura = False
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        'End If
    End Sub

    Private Sub ImprimeRecibo()
        If MsgBox("¿Desea imprimir el recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte
        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 3").Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\RptRecibo.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
            'Exit Sub
        End Try
        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Dim Rep As XtraReport
        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptRecibo.repx", True)
        Else
            Rep = New RptRecibo
        End If

        'Rep.DataSource = ObtieneDatos("SPGetRptFactura " & EmpresaActual & ",'" & txtfactura.Text & "'")
        'Rep.ShowRibbonPreview()

        Rep.DataSource = ObtieneDatos("SPGetRptRecibo " & EmpresaActual & ",'" & RecContado & "'")
        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub GridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDetalle.KeyDown

    End Sub

    Private Sub MnExento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnExento.Click
        ObtieneDatos("UPDATE Articulos SET Exento = " & IIf(MnExento.Text = "Exento", 1, 0) & "WHERE Empresa = " & EmpresaActual & " AND Codigo_Articulo = '" & vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item") & "' AND Tipo = '" & TipoServicio.EditValue & "'")
        GetArticulos()
        'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))
        Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))
        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", DR.Item("Exento"))
    End Sub

    Private Sub items_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If vFact.IsValidRowHandle(vFact.FocusedRowHandle) Then
            If e.Button = MouseButtons.Right And vFact.FocusedColumn.FieldName = "Item" And IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"), "0") <> "0" Then
                Dim DT As DataTable = ObtieneDatos("SELECT Exento FROM Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Articulo = '" & vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item") & "' AND Tipo = '" & TipoServicio.EditValue & "'")
                If DT.Rows(0).Item("Exento") = True Then MnExento.Text = "No Exento" Else MnExento.Text = "Exento"
                SubMenu.Show(sender, Nothing) 'New System.Drawing.Point(Me.MousePosition.X, Me.MousePosition.Y))
            End If
        End If
    End Sub

    Private Sub cmdCancelar1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar1.Click
        Nuevo()
    End Sub

    Private Sub LoadClients()
        'GetClientesList(cmbclientes)
        'cmbclientes.Properties.Columns(0).Visible = True : cmbclientes.Properties.ShowHeader = True 'Para radioshack
        'cmbclientes.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
        '        GetCatalogoClientes(Me.cmbclientes, Me.vClientes)

        SearchLookUp(
            cbCliente,
            ObtieneDatos("SP_GetClientes", EmpresaActual, 1, 1),
            "Nombre",
            "Codigo",
            3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)
    End Sub

    Private Sub cbCultivos_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbCultivos.ButtonClick
        If e.Button.Index = 1 Then
            With My.Forms.frmTipoCultivo
                .ShowDialog()
                If .ok = "SI" Then
                    GetTipoCultivo(Me.cbCultivos)
                End If
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbCultivos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCultivos.EditValueChanged

    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        Try
            'Dim fp As DataTable = ObtieneDatos("SELECT fp.DIAS FROM FORMA_PAGO fp WHERE fp.CODIGO = " & Me.cbTipoFactura.EditValue & " AND fp.EMPRESA = " & EmpresaActual)
            'Me.dtpFechaPago.DateTime = Me.dtpFecha.DateTime.AddDays(fp.Rows.Item(0)("DIAS"))
            'Me.dtpFechaRecep.DateTime = Me.dtpFecha.DateTime

            etTasa.EditValue = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & Me.fecha.DateTime.Date & "')").Rows.Item(0)(0)).ToString("n4")
            TCambio = etTasa.EditValue

            'TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            '+ " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
            'Me.etTasa.Text = TCambio.ToString("n4")
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        'cmbformapago.EditValue = cmbclientes.GetColumnValue("FormaPago")
    '        'cmbvendedor.EditValue = cmbclientes.GetColumnValue("Vendedor")
    '        'txtruc.Text = cmbclientes.GetColumnValue("RUC").ToString
    '        'txtdireccion.Text = cmbclientes.GetColumnValue("Direccion").ToString
    '        'txttelefono.Text = cmbclientes.GetColumnValue("Telefono").ToString
    '        ''txtpais.Text = cmbclientes.GetColumnValue("Pais").ToString
    '        'txtmunicipio.Text = cmbclientes.GetColumnValue("Municipio").ToString
    '        'txtdepto.Text = cmbclientes.GetColumnValue("Departamento").ToString
    '        'txtdescuentop.Text = cmbclientes.GetColumnValue("Desc_Prod").ToString
    '        'txtdescuentos.Text = cmbclientes.GetColumnValue("Desc_Serv").ToString
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub cmbclientes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    '    'If e.Button.Index = 1 Then
    '    '    Dim f As New frmAgregarClienteQuick
    '    '    f.WindowState = FormWindowState.Normal
    '    '    f.StartPosition = FormStartPosition.CenterScreen
    '    '    NombreCliente = ""

    '    '    If f.ShowDialog() = DialogResult.OK Then
    '    '        GetClientesList(cmbclientes)
    '    '        cmbclientes.EditValue = CInt(f.txtCodigo.Text)
    '    '    End If
    '    'ElseIf e.Button.Index = 2 Then
    '    '    LoadClients()
    '    'End If
    'End Sub


    Private Sub cmbclientes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'If e.Button.Index = 1 Then
        '    NombreCliente = ""

        '    With My.Forms.frmAgregarClienteQuick
        '        If .ShowDialog() = DialogResult.OK Then
        '            GetClientesList(cmbclientes)
        '            cmbclientes.EditValue = CInt(.txtCodigo.Text)
        '        End If
        '        .Dispose()

        '        'Dim f As New frmAgregarClienteQuick
        '        'f.WindowState = FormWindowState.Normal
        '        'f.StartPosition = FormStartPosition.CenterScreen
        '        'NombreCliente = ""
        '        'If f.ShowDialog() = DialogResult.OK Then
        '        'End If

        '    End With
        'ElseIf e.Button.Index = 2 Then
        '    LoadClients()
        'End If
    End Sub

    'Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
    '        pos = Me.cmbclientes.Properties.GetIndexByKeyValue(Me.cmbclientes.EditValue)

    '        'DetallesCliente.Vendedor

    '        cmbformapago.EditValue = Me.vClientes.GetRowCellValue(pos, "FormaPago")
    '        cmbvendedor.EditValue = CInt(DetallesCliente.Vendedor) 'Me.vClientes.GetRowCellValue(pos, "Vendedor")
    '        txtruc.Text = DetallesCliente.Ruc 'Me.vClientes.GetRowCellValue(pos, "RUC")
    '        txtdireccion.Text = DetallesCliente.Direccion    'Me.vClientes.GetRowCellValue(pos, "Direccion")
    '        txttelefono.Text = DetallesCliente.Telefono 'Me.vClientes.GetRowCellValue(pos, "Telefono")
    '        txtmunicipio.Text = DetallesCliente.Municipio 'Me.vClientes.GetRowCellValue(pos, "Municipio")
    '        txtdepto.Text = DetallesCliente.Departamento    'Me.vClientes.GetRowCellValue(pos, "Departamento")
    '        txtdescuentop.Text = DetallesCliente.Desc_Prod 'Me.vClientes.GetRowCellValue(pos, "Desc_Prod")
    '        txtdescuentos.Text = DetallesCliente.Desc_Serv   'Me.vClientes.GetRowCellValue(pos, "Desc_Serv")

    '        If Me.vClientes.GetRowCellValue(pos, "Empleado") Then
    '            Me.txtNombreDe.Text = vbNullString
    '            Me.txtNombreDe.Visible = False
    '            Me.cbEmpl.Visible = True
    '            Me.etmsg.Text = "   Empleado:"

    '            GetCatalogoEmpleados(Me.cbEmpl, Me.vEmpl)
    '            'Me.cbEmpl.Focus()
    '        Else
    '            Me.txtNombreDe.Text = vbNullString
    '            Me.txtNombreDe.Visible = True
    '            Me.cbEmpl.Visible = False
    '            Me.etmsg.Text = "A Nombre de:"

    '            Me.cbEmpl.Properties.DataSource = Nothing
    '            'Me.txtNombreDe.Focus()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    MostrarDatosCliente()
    'End Sub

    Sub MostrarDatosCliente()

        Try
            BitacoraVencidas = ""
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

            cmbformapago.EditValue = CInt(DetallesCliente.Cod_Forma_Pago)         'Me.cmbclientes.GetColumnValue("FormaPago")
            cmbvendedor.EditValue = CInt(DetallesCliente.Vendedor)               'Me.cmbclientes.GetColumnValue("Vendedor")
            txtruc.Text = DetallesCliente.Ruc                                              'Me.cmbclientes.GetColumnValue("RUC")
            txtdireccion.Text = DetallesCliente.Direccion                   'Me.cmbclientes.GetColumnValue("Direccion")
            txttelefono.Text = DetallesCliente.Telefono                     'Me.cmbclientes.GetColumnValue("Telefono")
            txtpais.Text = DetallesCliente.PaisN
            txtmunicipio.Text = DetallesCliente.MunicipioN                    'Me.cmbclientes.GetColumnValue("Municipio")
            txtdepto.Text = DetallesCliente.DepartamentoN                           'Me.cmbclientes.GetColumnValue("Departamento")
            txtdescuentop.Text = DetallesCliente.Desc_Prod                      'Me.cmbclientes.GetColumnValue("Desc_Prod")
            txtdescuentos.Text = DetallesCliente.Desc_Serv                      'Me.cmbclientes.GetColumnValue("Desc_Serv")

            If cmbformapago.GetColumnValue("Dias") > 0 Then txtNombreDe.Text = DetallesCliente.Nombre
            If cmbformapago.GetColumnValue("Dias") = 0 Then txtNombreDe.Text = ""

            'If Me.cmbclientes.GetColumnValue("Empleado") Then
            '    txtNombreDe.Text = vbNullString
            '    txtNombreDe.Visible = False
            '    cbEmpl.Visible = True

            '    lyNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '    lyEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            '    GetCatalogoEmpleados(Me.cbEmpl, Me.vEmpl)                
            'Else
            '    txtNombreDe.Text = vbNullString
            '    txtNombreDe.Visible = True
            '    cbEmpl.Visible = False

            '    lyNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            '    lyEmpleado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            '    cbEmpl.Properties.DataSource = Nothing
            'End If

            IniciaContador(1000)
            AlertaRemisiones.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub fecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecha.LostFocus
        If cmbformapago.GetColumnValue("Dias") = 0 Then
            FechaPago.DateTime = fecha.DateTime
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If cmbformapago.GetColumnValue("Dias") > 0 Then 'Solo Validar para las Facturas de Credito
        '    If Not cbCliente.EditValue Is Nothing Then
        '        Dim DT_FV As DataTable = ObtieneDatos("JAR_FacturasVencidasCliente", cbCliente.EditValue, EmpresaActual)

        '        If DT_FV.Rows.Item(0)("Cadena") = "" Then
        '            AlertaVencidas.Dispose()
        '        Else
        '            AlertaVencidas.Show(Me, "Alerta  de Facturas Vencidas!", DT_FV.Rows.Item(0)("Cadena").ToString & vbCrLf & vbCrLf & vbCrLf & _
        '                           "Clic Aqui para Ver Reporte")

        '            IniciaContador(120000)
        '        End If
        '    End If
        'End If
        ''
        If Not cbCliente.EditValue Is Nothing Then

            Dim CantidadR As Integer =
                db_Remisiones.Pendientes(cbCliente.EditValue)

            If CantidadR = 0 Then
                AlertaRemisiones.Dispose()
            Else
                AlertaRemisiones.Show(Me, "Alerta  de Remisiones Pendientes!", "Existen " & CantidadR.ToString & " Remisiones Pendientes de facturar para este Cliente: " & cbCliente.Text & vbCrLf & vbCrLf & vbCrLf &
                               "Clic Aqui para Ver Reporte")

                IniciaContador(120000)
            End If


            '    Dim Cotizaciones As New VB.SysContab.CotizacionesDB
            'Dim DT_COTI As DataTable = Cotizaciones.CotizacionesXCliente(cbCliente.EditValue).Tables("Cotizaciones")
            '
            Dim CantidadP As Integer =
                db_Proyectos.Pendientes(cbCliente.EditValue)

            If CantidadP = 0 Then
                AlertaProyectos.Dispose()
            Else
                AlertaProyectos.Show(Me, "Alerta  de Proyectos Activos!", "Existen " & CantidadP.ToString & " Proyectos Pendientes de Facturar para este Cliente: " & cbCliente.Text & vbCrLf & vbCrLf & vbCrLf &
                            "Clic Aqui para Ver Reporte")

                IniciaContador(120000)
            End If
            '    '
            'Dim DT_OT As DataTable = ObtieneDatos("SP_OrdenesList", EmpresaActual, cbCliente.EditValue)

            Dim CantidadOT As Integer =
                db_OrdenesTrabajo.Pendientes(cbCliente.EditValue)

            If CantidadOT = 0 Then
                AlertaOT.Dispose()
            Else
                AlertaOT.Show(Me, "Alerta  de Ordenes de Trabajo!", "Existen " & CantidadOT.ToString & " Ordenes de Trabajo Pendientes de Facturar para este Cliente: " & cbCliente.Text & vbCrLf & vbCrLf & vbCrLf &
                            "Clic Aqui para Ver Reporte")

                IniciaContador(120000)
            End If
        End If
    End Sub

    Private Sub AlertaRemisiones_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertaRemisiones.AlertClick
        VerRemisionesPendientes()
        'ShowSplash("Imprimiendo Reporte...")
        '''
        'Dim r As New rptEstadoCuentaEnviar
        'Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        'r.Periodo.Text = "Al Corte: " & f.ToShortDateString
        'r.DataSource = ObtieneDatos("SP_EstadoCuentaReporteEnviar", cbCliente.EditValue,
        '                            f.Date, f.Date, EmpresaActual)

        'r.ShowPrintMarginsWarning = False
        'r.BringToFront()
        'r.ShowRibbonPreview()
        '''
        'HideSplash()
    End Sub

    Private Sub AlertaProyectos_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertaProyectos.AlertClick
        'VerCotiazacionesPendientes()
        VerProyectosPendientes()
    End Sub

    Private Sub AlertaOT_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertaOT.AlertClick
        VerOrdenesTrabajo()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoServicio.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Process.Start("Calc.exe")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbBodega_EditValueChanged(sender As Object, e As EventArgs) Handles cbBodega.EditValueChanged
        'BodegaCaja = cbBodega.EditValue
        If Inicio = False Then
            ShowSplash("Cargando Bodega...")
            GetArticulos()
            GetData()
            HideSplash()
        End If
    End Sub

    Private Sub CheckEdit2_Click(sender As Object, e As EventArgs) Handles CheckEdit2.Click

    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked Then
            With frmExoneraIVA
                .IdCliente = cbCliente.EditValue
                .IdExonera = 0
                .txtCliente.Text = IIf(txtNombreDe.Text.Trim.Length = 0, cbCliente.Text, txtNombreDe.Text)
                .txtFactura.Text = cmbserie.Text & txtfactura.Text
                .ShowDialog()

                If .Ok = "NO" Then CheckEdit2.Checked = False
                .Dispose()
            End With
        Else
            Dim obj As New Clientes_Exoneraciones
            Dim db As New db_Clientes_Exoneraciones

            obj.Factura = cmbserie.Text & txtfactura.Text
            obj.Empresa = EmpresaActual

            db.Borrar(obj)
        End If
    End Sub

    Private Sub cbTipoFactura_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbTipoFactura.ButtonClick
        If e.Button.Index = 1 Then
            With My.Forms.frmTipoFacturaAdd
                .ShowDialog()
                If .ok = "SI" Then Combo(cbTipoFactura, db_TipoFacturas.Listar(0))
                .Dispose()
            End With
        End If
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        If vFact.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmDocumentos
            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetFocusedRowCellValue("Item"))
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetFocusedRowCellValue("Item"))

            .Tipo = "PRODUCTO"
            .Codigo = vFact.GetFocusedRowCellValue("Item")
            .NDocumento = DR.Item("Nombre")
            .Text = "Soporte Digital del Producto: " & DR.Item("Nombre")
            .txtNombre.Text = DR.Item("Nombre")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub chkAsociar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAsociar.CheckedChanged
        If chkAsociar.Checked Then SearchLookUp(cbClienteConvenio, ObtieneDatos("SP_GetClientes", EmpresaActual, 1), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)
        If Not chkAsociar.Checked Then cbClienteConvenio.Properties.DataSource = Nothing
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        MostrarDatosCliente()
    End Sub

    Private Sub cbProducto_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbProducto.ButtonClick
        If e.Button.Index = 1 Then

            If vFact.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            'Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))
            Dim DR As DataRowView = Me.cbProducto.GetRowByKeyValue(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Item"))

            With frmDetalleVentas_Lineas
                .Text = "Detalle de ITEM: " & DR.Item("Nombre")
                .txtModelo.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Modelo"), "")
                .txtNoSerie.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "NoSerie"), "")
                .txtComentario.Text = IsNull(vFact.GetRowCellValue(vFact.FocusedRowHandle, "Comentario"), "")
                .ShowDialog()

                If .Ok Then
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Modelo", .txtModelo.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "NoSerie", .txtNoSerie.Text)
                    vFact.SetRowCellValue(vFact.FocusedRowHandle, "Comentario", .txtComentario.Text)
                End If
                .Dispose()
            End With
        End If
    End Sub

    Private Sub etTasa_EditValueChanged(sender As Object, e As EventArgs) Handles etTasa.EditValueChanged
        TCambio = sender.EditValue
    End Sub

    Private Sub cmbvendedor_EditValueChanged(sender As Object, e As EventArgs) Handles cmbvendedor.EditValueChanged
        Try
            If IsNull(cmbvendedor.GetColumnValue("IdCentro"), 0) <> 0 Then _
                cbCentroCosto.EditValue = cmbvendedor.GetColumnValue("IdCentro")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Actualizar()
    End Sub

    Sub Actualizar()
        ShowSplash("Actualizando Catalogos...")

        LoadClients()
        GetFormaPagoList(cmbformapago)

        GetTipoCultivo(cbCultivos)

        'LookUp(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", "[Seleccione]", 0, 1, 4, 5, 6, 7, 8)

        CargaSeries()
        txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)
        Inicio = True : CargarCaja() : Inicio = False

        GetCentrosCostosList(cbCentroCosto, 1)
        GetVendedores(cmbvendedor)
        cmbvendedor_EditValueChanged(Nothing, Nothing)

        GetArticulos()

        HideSplash()
    End Sub

    Private Sub NuevoCarga()

        '/*** Globales   **************/
        DT_Cheques = Nothing
        DT_Tarjetas = Nothing
        FacturarCotizacion = False
        LoadOrden = False
        LoadCotizacionCliente = False
        LoadProyecto = False
        LoadRemision = False
        TotalCheques = 0
        TotalTarjetas = 0
        TotalEfectivo = 0
        TotalNotaDebito = 0
        TotalFactura = 0
        TotalGlobal = 0
        RecContado = 0

        LoadFacturaTemporal = False
        '**************************/

        ' LimpiarControles(Me)
        GetData()

        'If Me.cmbformapago.GetColumnValue("Dias") > 0 Then
        '    cbCliente.EditValue = Nothing
        '    cbCliente.Focus()
        'End If

        'fecha.EditValue = Now.Date
        'FechaPago.EditValue = Now.Date

        lblsubtotal.Text = "0.00"
        lbltotal.Text = "0.00"
        lbltotalU.Text = "0.00"
        lbliva.Text = "0.00"

        'Me.vClientes.PopulateColumns()
        'Me.vEmpl.Columns("Codigo").FilterInfo.Type=
        'Me.vEmpl.Columns("CodigoLetra").FilterInfo.FilterString = ""
        'Me.vEmpl.Columns("Nombre").FilterInfo.FilterString = ""

        'CargaSeries()

        'cmbserie.EditValue = Nothing
        'cmbserie.ItemIndex = 0
        'cmbserie.ClosePopup()

        'txtfactura.Text = Format(cmbserie.GetColumnValue("Factura"), dd)
        'cbTipoFactura.ItemIndex = 0

        'LoadClients()
        'cbCliente.Focus()

        vFact.Columns("Visible").Visible = False
        vFact.Columns("Agrupar").Visible = False
        vFact.Columns("IdProyecto").Visible = False
        vFact.Columns("#").Visible = True

        'Try
        '    If Me.cmbformapago.GetColumnValue("Dias") > 0 Then
        '        cbCliente.EditValue = 1
        '    End If
        '    cbCliente.Focus()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub nCotizacion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nCotizacion.LinkClicked
        Dim Cotizaciones As New VB.SysContab.CotizacionesDB
        '
        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            Exit Sub
        End If
        '
        If Cotizaciones.CotizacionesXCliente(cbCliente.EditValue).Tables("Cotizaciones").Rows.Count = 0 Then
            XtraMsg("No hay Cotizaciones para el cliente seleccionado")
            Exit Sub
        End If
        '
        VerCotiazacionesPendientes()
    End Sub

    Private Sub nOrdenTrabajo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nOrdenTrabajo.LinkClicked
        'If cbCliente.EditValue Is Nothing Then
        '    XtraMsg("Seleccione el cliente")
        '    cbCliente.Focus()
        '    Exit Sub
        'End If
        ''
        VerOrdenesTrabajo()
    End Sub

    Sub VerOrdenesTrabajo()
        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            Exit Sub
        End If
        '
        'If ObtieneDatos("SP_OrdenesList", EmpresaActual, cbCliente.EditValue).Rows.Count = 0 Then
        '    XtraMsg("No hay Orden de Trabajo para este cliente", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        If db_OrdenesTrabajo.Pendientes(cbCliente.EditValue) = 0 Then
            XtraMsg("No hay Orden de Trabajo para este cliente", MessageBoxIcon.Warning)
            Exit Sub
        End If

        '
        'Dim f As New frmOrdenes
        'f.WindowState = FormWindowState.Normal
        'f.Cliente = cbCliente.EditValue
        'f.StartPosition = FormStartPosition.CenterScreen
        'f.ShowDialog()

        With frmOrdenes
            .Cliente = cbCliente.EditValue
            .ShowDialog()
            If .Ok = "OK" Then
                ShowSplash("Cargando Orden...")
                NuevoCarga()
                '
                LoadOrden = True
                Validar_Orden = True
                LoadCotizacionCliente = False
                LoadProyecto = False
                LoadRemision = False

                txtremision.Text = .Documento
                txtComentario.Text = .Comentario
                Inicio = True : cbBodega.EditValue = .Bodega : Inicio = False

                vFact.Columns("Presentacion").Visible = True
                vFact.Columns("Presentacion").Caption = "OT"

                Dim DT_OT As DataTable =
                    db_OrdenesTrabajoDetalle.Facturar(.IdOrden)

                With DT_OT
                    Temp = True
                    For i As Integer = 0 To .Rows.Count - 1
                        vFact.AddNewRow()
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Producto"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Comentario", .Rows(i).Item("Descripcion"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Presentacion", .Rows(i).Item("NoOrden"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", .Rows(i).Item("Cantidad"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Cantidad", .Rows(i).Item("Cantidad"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Precio"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", .Rows(i).Item("Exento"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", .Rows(i).Item("Costo"))
                    Next
                    vFact.MoveFirst()
                    vFact.UpdateTotalSummary()
                    Temp = False
                End With
                HideSplash()
            End If
            .Dispose()
        End With


        'Dim ds As New DataSet
        'Dim Ordenes As New VB.SysContab.OrdenesDB

        'Dim f As New frmOrdenes
        'f.WindowState = FormWindowState.Normal
        'f.Cliente = cbCliente.EditValue
        'f.StartPosition = FormStartPosition.CenterScreen
        'f.ShowDialog()

        'If LoadOrden = True Then
        '    'GetData()
        '    ds = Ordenes.OrdenDetalle(RegistroOrden)

        '    If ds.Tables("Ordenes").Rows.Count = 0 Then
        '        Exit Sub
        '    End If

        '    NuevoCarga()

        '    Validar_Orden = True
        '    LoadCotizacionCliente = False
        '    LoadProyecto = False
        '    LoadRemision = False

        '    'cmbclientes.EditValue = ds.Tables("Ordenes").Rows(0).Item("Cliente")
        '    cbCliente.EditValue = ds.Tables("Ordenes").Rows(0).Item("Cliente")
        '    Cod_Cliente = cbCliente.EditValue
        '    cmbformapago.EditValue = ds.Tables("Ordenes").Rows(0).Item("Tipo_Factura")
        '    Me.txtNoEntrega.Text = RegistroOrden
        '    txtComentario.Text = ds.Tables("Ordenes").Rows(0).Item("Comentario")

        '    If ds.Tables("Ordenes").Rows(0).Item("TipoF").ToString = 0 Then
        '        TipoServicio.EditValue = "P"
        '    ElseIf ds.Tables("Ordenes").Rows(0).Item("TipoF").ToString = 1 Then
        '        TipoServicio.EditValue = "S"
        '    ElseIf ds.Tables("Ordenes").Rows(0).Item("TipoF").ToString = 2 Then
        '        TipoServicio.EditValue = "A"
        '    End If

        '    With ds.Tables("Ordenes")
        '        Temp = True
        '        For i As Integer = 0 To .Rows.Count - 1
        '            vFact.AddNewRow()
        '            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Item"))
        '            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", .Rows(i).Item("Cantidad"))
        '            ' vFact.SetRowCellValue(vFact.FocusedRowHandle, "Cantidad", .Rows(i).Item("Cantidad"))
        '            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Precio"))
        '            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", .Rows(i).Item("Descuento"))
        '        Next
        '        vFact.MoveFirst()
        '        vFact.UpdateTotalSummary()
        '        Temp = False
        '    End With
        '    'LoadOrden = False
        '    Validar_Orden = False
        'End If

        'f.Dispose()
    End Sub

    Private Sub nProyectos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nProyectos.LinkClicked
        VerProyectosPendientes()
    End Sub


    Sub VerProyectosPendientes()

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            Exit Sub
        End If
        '
        If db_Proyectos.Pendientes(cbCliente.EditValue) = 0 Then
            XtraMsg("No hay Proyectos para el Cliente Seleccionado")
            Exit Sub
        End If
        '
        With frmProyectosClientes
            .IdCliente = cbCliente.EditValue
            .ShowDialog()
            If .Ok = "SI" Then
                ShowSplash("Cargando Proyecto...")
                NuevoCarga()
                '
                LoadProyecto = True
                LoadOrden = False
                LoadCotizacionCliente = False
                LoadRemision = False

                Dim DT_COSTO As DataTable = Nothing
                Dim DT_REQ As DataTable = Nothing
                '
                If Not .DT_COSTO Is Nothing Then
                    Try
                        DT_COSTO = .DT_COSTO.Select("Facturar = 1").CopyToDataTable
                        Inicio = True
                        cbBodega.EditValue = db_Proyectos.Detalles(DT_COSTO.Rows(0).Item("IdProyecto")).Bodega
                        Inicio = False
                    Catch ex As Exception
                        DT_COSTO = Nothing
                    End Try
                End If
                '
                If Not .DT_REQ Is Nothing Then
                    Try
                        DT_REQ = .DT_REQ.Select("Facturar = 1").CopyToDataTable
                    Catch ex As Exception
                        DT_REQ = Nothing
                    End Try
                End If
                '
                RepositorySearchLook(cbProyecto,
                                     db_Proyectos.Fill(),
                                     "Nombre",
                                     "IdProyecto", 0, 4, 5, 6, 7, 8)
                '
                If Not DT_COSTO Is Nothing Then
                    With DT_COSTO
                        vFact.Columns("Visible").Visible = True
                        vFact.Columns("Agrupar").Visible = True
                        vFact.Columns("IdProyecto").Visible = True
                        vFact.Columns("#").Visible = False
                        '
                        Temp = True
                        For i As Integer = 0 To .Rows.Count - 1
                            vFact.AddNewRow()
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Codigo"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", 1.0)
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Precio"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", "")
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Presentacion", IIf(Math.Round(CDbl(.Rows(i).Item("CostoO")), 2) <> Math.Round(CDbl(.Rows(i).Item("Costo")), 2), "PARCIAL", ""))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Visible", True)
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", False)
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", IIf(Math.Round(CDbl(.Rows(i).Item("CostoO")), 2) <> Math.Round(CDbl(.Rows(i).Item("Costo")), 2), .Rows(i).Item("Costo"), 0.00))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdProyecto", .Rows(i).Item("IdProyecto"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdDetalle", 0)
                        Next
                        'Varificar si hay Mano de Obra
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("Mono de Obra") <> "" Then
                                vFact.AddNewRow()
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Mono de Obra"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", 1.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", "")
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Visible", True)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", VB.SysContab.ArticulosDB.GetDetails(.Rows(i).Item("Mono de Obra"), "S").Exento)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdProyecto", .Rows(i).Item("IdProyecto"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdDetalle", 0)
                            End If
                            '
                            If .Rows(i).Item("Flete") <> "" Then
                                vFact.AddNewRow()
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Flete"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", 1.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", "")
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Visible", True)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", VB.SysContab.ArticulosDB.GetDetails(.Rows(i).Item("Flete"), "S").Exento)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdProyecto", .Rows(i).Item("IdProyecto"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdDetalle", 0)
                            End If
                            '
                            If .Rows(i).Item("Varios") <> "" Then
                                vFact.AddNewRow()
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Varios"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", 1.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", "")
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Visible", True)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", VB.SysContab.ArticulosDB.GetDetails(.Rows(i).Item("Varios"), "S").Exento)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", 0.0)
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdProyecto", .Rows(i).Item("IdProyecto"))
                                vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdDetalle", 0)
                            End If
                        Next

                        vFact.MoveFirst()
                        vFact.UpdateTotalSummary()
                        Temp = False
                    End With
                End If
                '
                If Not DT_REQ Is Nothing Then
                    With DT_REQ
                        vFact.Columns("Visible").Visible = True
                        vFact.Columns("Agrupar").Visible = True
                        vFact.Columns("IdProyecto").Visible = True
                        vFact.Columns("#").Visible = False
                        '
                        Temp = True
                        For i As Integer = 0 To .Rows.Count - 1

                            '
                            vFact.AddNewRow()
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Codigo"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", .Rows(i).Item("Cantidad"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Precio"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", .Rows(i).Item("Agrupar"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Visible", .Rows(i).Item("Visible"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", .Rows(i).Item("Exento"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", .Rows(i).Item("Unitario"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdProyecto", .Rows(i).Item("IdProyecto"))
                            vFact.SetRowCellValue(vFact.FocusedRowHandle, "IdDetalle", .Rows(i).Item("IdDetalle"))
                        Next
                        vFact.MoveFirst()
                        vFact.UpdateTotalSummary()
                        Temp = False
                    End With
                End If
                HideSplash()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub nRemisiones_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles nRemisiones.LinkClicked
        VerRemisionesPendientes()
    End Sub

    Sub VerRemisionesPendientes()

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If
        '
        If db_Remisiones.Pendientes(cbCliente.EditValue) = 0 Then
            XtraMsg("No hay Remisiones Pendientes para el Cliente Seleccionado")
            Exit Sub
        End If
        '
        With frmRemisionesClientesFacturar
            .IdCliente = cbCliente.EditValue
            .DT_ROL = DT_ROL
            .ShowDialog()
            If .Ok = "OK" Then
                ShowSplash("Cargando Orden...")
                NuevoCarga()
                '
                LoadRemision = True
                LoadProyecto = False
                LoadOrden = False
                LoadCotizacionCliente = False

                cbCliente.EditValue = .IdCliente
                IdRemision = .IdRemision
                txtremision.Text = .NoRemision
                txtNoEntrega.Text = .Referencia

                'txtremision.Text = db_Remisiones.Detalles(IdRemision).NoRemision
                'txtNoEntrega.Text = db_Remisiones.Detalles(IdRemision).Referencia

                Dim DT_REM As DataTable = db_RemisionesDetalle.Facturar(IdRemision)

                With DT_REM
                    Temp = True
                    vFact.Columns("Agrupar").Visible = True
                    vFact.Columns("#").Visible = False

                    If EmpresaActual <> 1 Then
                        vFact.Columns("Presentacion").Visible = True
                        vFact.Columns("Presentacion").Caption = "Remisión"
                    End If

                    For i As Integer = 0 To .Rows.Count - 1
                        vFact.AddNewRow()
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Item", .Rows(i).Item("Producto"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Despacho", .Rows(i).Item("Despacho"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Cantidad", .Rows(i).Item("Cantidad"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Precio", .Rows(i).Item("Precio"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Descuento", 0.0)
                        If EmpresaActual <> 1 Then vFact.SetRowCellValue(vFact.FocusedRowHandle, "Presentacion", .Rows(i).Item("NoRemision"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Exento", .Rows(i).Item("Exento"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Costo", .Rows(i).Item("Costo"))
                        vFact.SetRowCellValue(vFact.FocusedRowHandle, "Agrupar", .Rows(i).Item("Agrupar"))
                    Next
                    vFact.MoveFirst()
                    vFact.UpdateTotalSummary()
                    Temp = False
                End With
                HideSplash()
            End If
            .Dispose()
        End With
    End Sub

    Private Sub bVistaPrevia_Click(sender As Object, e As EventArgs) Handles bVistaPrevia.Click
        If IsNull(cmbvendedor.EditValue, 0) = 0 Then
            XtraMsg("Seleccione al vendedor")
            cmbvendedor.Focus()
            Exit Sub
        End If

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If

        If Trim(txtfactura.Text) = "" Then
            XtraMsg("Introduzca el No. de Factura", MessageBoxIcon.Error)
            txtfactura.Focus()
            Exit Sub
        End If

        If cmbformapago.EditValue = Nothing Then
            XtraMsg("Seleccione el Tipo de Pago")
            cmbformapago.Focus()
            Exit Sub
        End If

        If cmbmoneda.EditValue = Nothing Then
            XtraMsg("Seleccion la moneda de mantenimiento de valor de la factura")
            cmbmoneda.Focus()
            Exit Sub
        End If
        '
        If DT_Facturas.Rows.Count - 1 < 0 Then
            XtraMsg("Seleccione al menos un Producto o Servicio", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Tipo As String

        If TipoServicio.EditValue = "P" Then
            Tipo = 0
        ElseIf TipoServicio.EditValue = "S" Then
            Tipo = 1
        Else
            Tipo = 2
        End If

        If VB.SysContab.ClientesDB.GuardarFacturaPrevia(cmbserie.Text & txtfactura.Text,
                fecha.DateTime.Date,
                cbCliente.EditValue,
                txtruc.Text,
                lblsubtotal.Text,
                lbltotal.Text,
                vFact.Columns("Descuento").SummaryItem.SummaryValue * 100,
                lbliva.Text,
                "0",
                 IIf(chkAsociar.Checked, cbClienteConvenio.EditValue, 0),
                lbltotal.Text,
                CDbl(lbltotal.Text) - TotalGlobal,
                IsNull(cmbvendedor.EditValue, 0),
                FechaPago.DateTime.Date,
                FechaPago.DateTime.Date,
                Tipo,
                cmbformapago.EditValue,
                txtNombreDe.Text,
                DetallesCliente.Retenedor,
                cmbmoneda.EditValue,
                cbBodega.EditValue, ConfigDetalles.SeriesMultiples,
                txtremision.Text, txtorden.Text, Caja, cbCultivos.EditValue, txtNoEntrega.Text,
                txtCondiciones.Text, cmbserie.GetColumnValue("IdDetalle"), txtfactura.Text, etTasa.EditValue,
                cbTipoFactura.EditValue, rgDespacho.EditValue, IIf(CheckEdit1.Checked, "02", MonedaBase),
                IIf(txtComentario.Text.Length = 0, "", txtComentario.Text), LoadCotizacionCliente, LoadOrden, 0, TotalEfectivo, TotalNotaDebito,
                TotalCheques, cbCentroCosto.EditValue, TotalFactura, TotalGlobal, RecContado, IIf(Moneda Is Nothing, cmbmoneda.EditValue, Moneda),
                DT_Cheques, DT_Tarjetas, DT_Facturas) Then


            If cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura(cmbserie.Text & txtfactura.Text,
                                                                                             FormaPago.FormaPagoDias(cmbformapago.EditValue), True)

            If Not cbTipoFactura.EditValue Is Nothing Then Facturas_VentasDB.ImprimirFactura2(cmbserie.Text & txtfactura.Text,
                                                                                                  cbTipoFactura.EditValue, True)


            'If cbTipoFactura.EditValue Is Nothing Then ImprimirFactura(True)
            'If Not cbTipoFactura.EditValue Is Nothing Then ImprimirFactura2(True)
            ' ImprimirFacturaTemporal()
        End If

    End Sub

    'Sub ImprimirFacturaTemporal()

    '    ShowSplash("Imprimiendo...")

    '    Dim Temp As Boolean = False

    '    Try
    '        Dim Data() As Byte = CType(db_TipoFacturas.Listar(cbTipoFactura.EditValue).Rows.Item(0)("Formato"), Byte())

    '        Temp = True
    '        Dim Tamano As Integer = 0
    '        Tamano = Data.GetUpperBound(0)

    '        Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()

    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim rpt As RptFacturaNew

    '    If Not Temp Then
    '        rpt = New RptFacturaNew
    '    Else
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
    '    End If

    '    rpt.DataSource = ObtieneDatos("sp_GetRptFacturaTemporal", EmpresaActual)

    '    HideSplash()
    '    rpt.ShowPrintMarginsWarning = False
    '    rpt.BringToFront()
    '    rpt.ShowRibbonPreview()
    '    RecVuelto = 0
    'End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgrupar.CheckedChanged
        vFact.Columns("Agrupar").Visible = chkAgrupar.Checked
        vFact.Columns("#").Visible = Not chkAgrupar.Checked
    End Sub

    Private Sub chkVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisible.CheckedChanged
        vFact.Columns("Visible").Visible = chkVisible.Checked
        vFact.Columns("#").Visible = Not chkVisible.Checked
    End Sub


    'Private Sub vEmpl_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles vEmpl.ValidateRow
    '    If IsNull(vEmpl.GetRowCellValue(e.RowHandle, "Precio"), 0.01) <> 0.00 Then
    '        e.Valid = False
    '    End If
    'End Sub

    'Private Sub vEmpl_ShowingEditor(sender As Object, e As CancelEventArgs) Handles vEmpl.ShowingEditor
    '    e.Cancel = True
    'End Sub

    'Private Sub vEmpl_ShownEditor(sender As Object, e As EventArgs) Handles vEmpl.ShownEditor

    'End Sub

    'Private Sub vEmpl_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles vEmpl.ValidatingEditor

    'End Sub
End Class
