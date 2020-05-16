Imports DSBarCode.BarCodeCtrl
Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraEditors.Controls

Public Class frmAgregarArticulo
    Inherits DevExpress.XtraEditors.XtraForm




    Friend WithEvents txtcodigoproveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCultivos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtFactor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPVDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTasaCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCatalogo1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProveedores As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMargen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPVCordoba As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInventarioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInventarioCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCatalogo5 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo4 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSAC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkExento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkObsoleto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkValidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrecoio2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCosto2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbUnidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCodigoParte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFabricante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFactorIngreso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Private Shared ChildInstance As frmAgregarArticulo = Nothing

    Public Shared Function Instance() As frmAgregarArticulo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarArticulo
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
    Friend WithEvents txtDescuentoC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPresentacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExistencias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbSubGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostoUltimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostoPromedio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUbicacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAcumulados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdProveedoresAdicionales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCalcularDescuentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdimprimecodigo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdbarcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CodigoBarra As DSBarCode.BarCodeCtrl
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbS_subgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents txtnivel_uso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtvia_admini As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConcentracion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtreceta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarArticulo))
        Me.cbCultivos = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtFactorIngreso = New DevExpress.XtraEditors.TextEdit()
        Me.cbFabricante = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCodigoParte = New DevExpress.XtraEditors.TextEdit()
        Me.cbUnidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCosto2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecoio2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtcodigoproveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtnivel_uso = New DevExpress.XtraEditors.TextEdit()
        Me.txtreceta = New DevExpress.XtraEditors.TextEdit()
        Me.txtvia_admini = New DevExpress.XtraEditors.TextEdit()
        Me.txtConcentracion = New DevExpress.XtraEditors.TextEdit()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cbS_subgrupo = New System.Windows.Forms.ComboBox()
        Me.chkObsoleto = New DevExpress.XtraEditors.CheckEdit()
        Me.chkValidar = New DevExpress.XtraEditors.CheckEdit()
        Me.chkExento = New DevExpress.XtraEditors.CheckEdit()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExistencias = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransito = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockMin = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCalcularDescuentos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtStockMax = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoC = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoA = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoB = New DevExpress.XtraEditors.TextEdit()
        Me.txtPVCordoba = New DevExpress.XtraEditors.TextEdit()
        Me.txtMargen = New DevExpress.XtraEditors.TextEdit()
        Me.txtCostoUltimo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCostoPromedio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoBarra = New DSBarCode.BarCodeCtrl()
        Me.cbCentroCosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSAC = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.MemoEdit()
        Me.cbCatalogo4 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo5 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProveedores = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.cbCatalogo1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFactor = New DevExpress.XtraEditors.TextEdit()
        Me.txtModelo = New DevExpress.XtraEditors.TextEdit()
        Me.txtPresentacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtUbicacion = New DevExpress.XtraEditors.TextEdit()
        Me.cbSubGrupo = New System.Windows.Forms.ComboBox()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbLinea = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.txtInventarioVenta = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTasaCambio = New DevExpress.XtraEditors.TextEdit()
        Me.txtPVDolar = New DevExpress.XtraEditors.TextEdit()
        Me.cmdProveedoresAdicionales = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdimprimecodigo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdbarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAcumulados = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtInventarioCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtFactorIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFabricante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecoio2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcodigoproveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnivel_uso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtreceta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvia_admini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcentracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkObsoleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPVCordoba.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMargen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostoUltimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostoPromedio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSAC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPresentacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventarioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.txtTasaCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPVDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInventarioCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCultivos
        '
        Me.cbCultivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCultivos.EnterMoveNextControl = True
        Me.cbCultivos.Location = New System.Drawing.Point(707, 250)
        Me.cbCultivos.Name = "cbCultivos"
        EditorButtonImageOptions1.EnableTransparency = False
        ToolTipItem1.Text = "Agrear Tipo de Cultivo"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.cbCultivos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1)})
        Me.cbCultivos.Properties.NullText = ""
        Me.cbCultivos.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCultivos.Properties.ShowFooter = False
        Me.cbCultivos.Properties.ShowHeader = False
        Me.cbCultivos.Size = New System.Drawing.Size(276, 20)
        Me.cbCultivos.StyleController = Me.LayoutControl1
        Me.cbCultivos.TabIndex = 10
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtFactorIngreso)
        Me.LayoutControl1.Controls.Add(Me.cbFabricante)
        Me.LayoutControl1.Controls.Add(Me.txtNombreProveedor)
        Me.LayoutControl1.Controls.Add(Me.txtCodigoParte)
        Me.LayoutControl1.Controls.Add(Me.cbUnidad)
        Me.LayoutControl1.Controls.Add(Me.txtCosto2)
        Me.LayoutControl1.Controls.Add(Me.txtPrecoio2)
        Me.LayoutControl1.Controls.Add(Me.txtcodigoproveedor)
        Me.LayoutControl1.Controls.Add(Me.txtnivel_uso)
        Me.LayoutControl1.Controls.Add(Me.txtreceta)
        Me.LayoutControl1.Controls.Add(Me.txtvia_admini)
        Me.LayoutControl1.Controls.Add(Me.txtConcentracion)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Controls.Add(Me.cbS_subgrupo)
        Me.LayoutControl1.Controls.Add(Me.chkObsoleto)
        Me.LayoutControl1.Controls.Add(Me.chkValidar)
        Me.LayoutControl1.Controls.Add(Me.chkExento)
        Me.LayoutControl1.Controls.Add(Me.chkActivo)
        Me.LayoutControl1.Controls.Add(Me.txtExistencias)
        Me.LayoutControl1.Controls.Add(Me.txtTransito)
        Me.LayoutControl1.Controls.Add(Me.txtStockMin)
        Me.LayoutControl1.Controls.Add(Me.cmdCalcularDescuentos)
        Me.LayoutControl1.Controls.Add(Me.txtStockMax)
        Me.LayoutControl1.Controls.Add(Me.txtDescuentoC)
        Me.LayoutControl1.Controls.Add(Me.txtDescuentoA)
        Me.LayoutControl1.Controls.Add(Me.txtDescuentoB)
        Me.LayoutControl1.Controls.Add(Me.txtPVCordoba)
        Me.LayoutControl1.Controls.Add(Me.txtMargen)
        Me.LayoutControl1.Controls.Add(Me.txtCostoUltimo)
        Me.LayoutControl1.Controls.Add(Me.txtCostoPromedio)
        Me.LayoutControl1.Controls.Add(Me.txtCosto)
        Me.LayoutControl1.Controls.Add(Me.CodigoBarra)
        Me.LayoutControl1.Controls.Add(Me.cbCentroCosto)
        Me.LayoutControl1.Controls.Add(Me.txtSAC)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo4)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo5)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo3)
        Me.LayoutControl1.Controls.Add(Me.cbProveedores)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo2)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogo1)
        Me.LayoutControl1.Controls.Add(Me.cbCultivos)
        Me.LayoutControl1.Controls.Add(Me.txtFactor)
        Me.LayoutControl1.Controls.Add(Me.txtModelo)
        Me.LayoutControl1.Controls.Add(Me.txtPresentacion)
        Me.LayoutControl1.Controls.Add(Me.txtUbicacion)
        Me.LayoutControl1.Controls.Add(Me.cbSubGrupo)
        Me.LayoutControl1.Controls.Add(Me.cbGrupo)
        Me.LayoutControl1.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl1.Controls.Add(Me.cbLinea)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.LayoutControlItem36})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1144, 212, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1019, 769)
        Me.LayoutControl1.TabIndex = 168
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtFactorIngreso
        '
        Me.txtFactorIngreso.EditValue = New Decimal(New Integer() {1000000, 0, 0, 393216})
        Me.txtFactorIngreso.Location = New System.Drawing.Point(882, 300)
        Me.txtFactorIngreso.Name = "txtFactorIngreso"
        Me.txtFactorIngreso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtFactorIngreso.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtFactorIngreso.Properties.Appearance.Options.UseFont = True
        Me.txtFactorIngreso.Properties.Appearance.Options.UseForeColor = True
        Me.txtFactorIngreso.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFactorIngreso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFactorIngreso.Properties.Mask.EditMask = "n6"
        Me.txtFactorIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFactorIngreso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFactorIngreso.Size = New System.Drawing.Size(101, 22)
        Me.txtFactorIngreso.StyleController = Me.LayoutControl1
        Me.txtFactorIngreso.TabIndex = 199
        '
        'cbFabricante
        '
        Me.cbFabricante.Location = New System.Drawing.Point(150, 300)
        Me.cbFabricante.Name = "cbFabricante"
        Me.cbFabricante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Agregar Uniadad de Medida")})
        Me.cbFabricante.Size = New System.Drawing.Size(614, 20)
        Me.cbFabricante.StyleController = Me.LayoutControl1
        Me.cbFabricante.TabIndex = 198
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.EditValue = ""
        Me.txtNombreProveedor.Location = New System.Drawing.Point(564, 105)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(272, 40)
        Me.txtNombreProveedor.StyleController = Me.LayoutControl1
        Me.txtNombreProveedor.TabIndex = 190
        '
        'txtCodigoParte
        '
        Me.txtCodigoParte.Location = New System.Drawing.Point(546, 79)
        Me.txtCodigoParte.Name = "txtCodigoParte"
        Me.txtCodigoParte.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoParte.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoParte.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoParte.Properties.MaxLength = 50
        Me.txtCodigoParte.Size = New System.Drawing.Size(189, 20)
        Me.txtCodigoParte.StyleController = Me.LayoutControl1
        Me.txtCodigoParte.TabIndex = 170
        '
        'cbUnidad
        '
        Me.cbUnidad.Location = New System.Drawing.Point(707, 149)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Agregar Uniadad de Medida")})
        Me.cbUnidad.Size = New System.Drawing.Size(276, 20)
        Me.cbUnidad.StyleController = Me.LayoutControl1
        Me.cbUnidad.TabIndex = 197
        '
        'txtCosto2
        '
        Me.txtCosto2.Location = New System.Drawing.Point(221, 387)
        Me.txtCosto2.Name = "txtCosto2"
        Me.txtCosto2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto2.Properties.Appearance.Options.UseFont = True
        Me.txtCosto2.Properties.Mask.EditMask = "n6"
        Me.txtCosto2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto2.Size = New System.Drawing.Size(162, 20)
        Me.txtCosto2.StyleController = Me.LayoutControl1
        Me.txtCosto2.TabIndex = 170
        '
        'txtPrecoio2
        '
        Me.txtPrecoio2.Location = New System.Drawing.Point(150, 480)
        Me.txtPrecoio2.Name = "txtPrecoio2"
        Me.txtPrecoio2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoio2.Properties.Appearance.Options.UseFont = True
        Me.txtPrecoio2.Properties.Mask.EditMask = "n4"
        Me.txtPrecoio2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecoio2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecoio2.Size = New System.Drawing.Size(78, 20)
        Me.txtPrecoio2.StyleController = Me.LayoutControl1
        Me.txtPrecoio2.TabIndex = 196
        '
        'txtcodigoproveedor
        '
        Me.txtcodigoproveedor.Location = New System.Drawing.Point(391, 229)
        Me.txtcodigoproveedor.Name = "txtcodigoproveedor"
        Me.txtcodigoproveedor.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoproveedor.Properties.Appearance.Options.UseFont = True
        Me.txtcodigoproveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoproveedor.Properties.MaxLength = 10
        Me.txtcodigoproveedor.Size = New System.Drawing.Size(178, 20)
        Me.txtcodigoproveedor.StyleController = Me.LayoutControl1
        Me.txtcodigoproveedor.TabIndex = 8
        Me.txtcodigoproveedor.Visible = False
        '
        'txtnivel_uso
        '
        Me.txtnivel_uso.Location = New System.Drawing.Point(115, 229)
        Me.txtnivel_uso.Name = "txtnivel_uso"
        Me.txtnivel_uso.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnivel_uso.Properties.Appearance.Options.UseFont = True
        Me.txtnivel_uso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnivel_uso.Properties.MaxLength = 15
        Me.txtnivel_uso.Size = New System.Drawing.Size(291, 20)
        Me.txtnivel_uso.StyleController = Me.LayoutControl1
        Me.txtnivel_uso.TabIndex = 9
        '
        'txtreceta
        '
        Me.txtreceta.Location = New System.Drawing.Point(115, 229)
        Me.txtreceta.Name = "txtreceta"
        Me.txtreceta.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceta.Properties.Appearance.Options.UseFont = True
        Me.txtreceta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreceta.Properties.MaxLength = 15
        Me.txtreceta.Size = New System.Drawing.Size(454, 20)
        Me.txtreceta.StyleController = Me.LayoutControl1
        Me.txtreceta.TabIndex = 9
        '
        'txtvia_admini
        '
        Me.txtvia_admini.Location = New System.Drawing.Point(116, 229)
        Me.txtvia_admini.Name = "txtvia_admini"
        Me.txtvia_admini.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvia_admini.Properties.Appearance.Options.UseFont = True
        Me.txtvia_admini.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvia_admini.Properties.MaxLength = 10
        Me.txtvia_admini.Size = New System.Drawing.Size(174, 20)
        Me.txtvia_admini.StyleController = Me.LayoutControl1
        Me.txtvia_admini.TabIndex = 8
        '
        'txtConcentracion
        '
        Me.txtConcentracion.Location = New System.Drawing.Point(116, 229)
        Me.txtConcentracion.Name = "txtConcentracion"
        Me.txtConcentracion.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcentracion.Properties.Appearance.Options.UseFont = True
        Me.txtConcentracion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcentracion.Properties.MaxLength = 12
        Me.txtConcentracion.Size = New System.Drawing.Size(36, 20)
        Me.txtConcentracion.StyleController = Me.LayoutControl1
        Me.txtConcentracion.TabIndex = 7
        '
        'etInicio
        '
        Me.etInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(214, 52)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(201, 19)
        Me.etInicio.TabIndex = 161
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cbS_subgrupo
        '
        Me.cbS_subgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS_subgrupo.Location = New System.Drawing.Point(316, 96)
        Me.cbS_subgrupo.Name = "cbS_subgrupo"
        Me.cbS_subgrupo.Size = New System.Drawing.Size(99, 21)
        Me.cbS_subgrupo.TabIndex = 6
        Me.cbS_subgrupo.Visible = False
        '
        'chkObsoleto
        '
        Me.chkObsoleto.Location = New System.Drawing.Point(840, 127)
        Me.chkObsoleto.Name = "chkObsoleto"
        Me.chkObsoleto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkObsoleto.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkObsoleto.Properties.Appearance.Options.UseFont = True
        Me.chkObsoleto.Properties.Appearance.Options.UseForeColor = True
        Me.chkObsoleto.Properties.Caption = "Producto Obsoleto"
        Me.chkObsoleto.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkObsoleto.Size = New System.Drawing.Size(143, 22)
        Me.chkObsoleto.StyleController = Me.LayoutControl1
        Me.chkObsoleto.TabIndex = 192
        '
        'chkValidar
        '
        Me.chkValidar.Location = New System.Drawing.Point(840, 105)
        Me.chkValidar.Name = "chkValidar"
        Me.chkValidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValidar.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkValidar.Properties.Appearance.Options.UseFont = True
        Me.chkValidar.Properties.Appearance.Options.UseForeColor = True
        Me.chkValidar.Properties.Caption = "Validar Precio"
        Me.chkValidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkValidar.Size = New System.Drawing.Size(143, 22)
        Me.chkValidar.StyleController = Me.LayoutControl1
        Me.chkValidar.TabIndex = 192
        '
        'chkExento
        '
        Me.chkExento.Location = New System.Drawing.Point(749, 79)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExento.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkExento.Properties.Appearance.Options.UseFont = True
        Me.chkExento.Properties.Appearance.Options.UseForeColor = True
        Me.chkExento.Properties.Caption = "Exento de Impuesto"
        Me.chkExento.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkExento.Size = New System.Drawing.Size(154, 22)
        Me.chkExento.StyleController = Me.LayoutControl1
        Me.chkExento.TabIndex = 191
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(907, 79)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkActivo.Properties.Appearance.Options.UseFont = True
        Me.chkActivo.Properties.Appearance.Options.UseForeColor = True
        Me.chkActivo.Properties.Caption = "Activo"
        Me.chkActivo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkActivo.Size = New System.Drawing.Size(76, 22)
        Me.chkActivo.StyleController = Me.LayoutControl1
        Me.chkActivo.TabIndex = 190
        '
        'txtExistencias
        '
        Me.txtExistencias.Enabled = False
        Me.txtExistencias.Location = New System.Drawing.Point(585, 456)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencias.Properties.Appearance.Options.UseFont = True
        Me.txtExistencias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExistencias.Properties.MaxLength = 50
        Me.txtExistencias.Size = New System.Drawing.Size(143, 20)
        Me.txtExistencias.StyleController = Me.LayoutControl1
        Me.txtExistencias.TabIndex = 0
        '
        'txtTransito
        '
        Me.txtTransito.Location = New System.Drawing.Point(740, 542)
        Me.txtTransito.Name = "txtTransito"
        Me.txtTransito.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransito.Properties.Appearance.Options.UseFont = True
        Me.txtTransito.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransito.Properties.MaxLength = 50
        Me.txtTransito.Properties.ReadOnly = True
        Me.txtTransito.Size = New System.Drawing.Size(79, 20)
        Me.txtTransito.StyleController = Me.LayoutControl1
        Me.txtTransito.TabIndex = 3
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(585, 480)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMin.Properties.Appearance.Options.UseFont = True
        Me.txtStockMin.Properties.MaxLength = 50
        Me.txtStockMin.Size = New System.Drawing.Size(143, 20)
        Me.txtStockMin.StyleController = Me.LayoutControl1
        Me.txtStockMin.TabIndex = 1
        '
        'cmdCalcularDescuentos
        '
        Me.cmdCalcularDescuentos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcularDescuentos.Appearance.Options.UseFont = True
        Me.cmdCalcularDescuentos.Location = New System.Drawing.Point(823, 542)
        Me.cmdCalcularDescuentos.Name = "cmdCalcularDescuentos"
        Me.cmdCalcularDescuentos.Size = New System.Drawing.Size(125, 22)
        Me.cmdCalcularDescuentos.StyleController = Me.LayoutControl1
        Me.cmdCalcularDescuentos.TabIndex = 3
        Me.cmdCalcularDescuentos.Text = "Calcular Descuentos"
        '
        'txtStockMax
        '
        Me.txtStockMax.Location = New System.Drawing.Point(585, 504)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockMax.Properties.Appearance.Options.UseFont = True
        Me.txtStockMax.Properties.MaxLength = 50
        Me.txtStockMax.Size = New System.Drawing.Size(143, 20)
        Me.txtStockMax.StyleController = Me.LayoutControl1
        Me.txtStockMax.TabIndex = 2
        '
        'txtDescuentoC
        '
        Me.txtDescuentoC.Location = New System.Drawing.Point(543, 542)
        Me.txtDescuentoC.Name = "txtDescuentoC"
        Me.txtDescuentoC.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoC.Properties.Appearance.Options.UseFont = True
        Me.txtDescuentoC.Properties.MaxLength = 50
        Me.txtDescuentoC.Size = New System.Drawing.Size(79, 20)
        Me.txtDescuentoC.StyleController = Me.LayoutControl1
        Me.txtDescuentoC.TabIndex = 2
        '
        'txtDescuentoA
        '
        Me.txtDescuentoA.Location = New System.Drawing.Point(150, 542)
        Me.txtDescuentoA.Name = "txtDescuentoA"
        Me.txtDescuentoA.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoA.Properties.Appearance.Options.UseFont = True
        Me.txtDescuentoA.Properties.MaxLength = 50
        Me.txtDescuentoA.Size = New System.Drawing.Size(78, 20)
        Me.txtDescuentoA.StyleController = Me.LayoutControl1
        Me.txtDescuentoA.TabIndex = 0
        '
        'txtDescuentoB
        '
        Me.txtDescuentoB.Location = New System.Drawing.Point(346, 542)
        Me.txtDescuentoB.Name = "txtDescuentoB"
        Me.txtDescuentoB.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoB.Properties.Appearance.Options.UseFont = True
        Me.txtDescuentoB.Properties.MaxLength = 50
        Me.txtDescuentoB.Size = New System.Drawing.Size(79, 20)
        Me.txtDescuentoB.StyleController = Me.LayoutControl1
        Me.txtDescuentoB.TabIndex = 1
        '
        'txtPVCordoba
        '
        Me.txtPVCordoba.Location = New System.Drawing.Point(150, 456)
        Me.txtPVCordoba.Name = "txtPVCordoba"
        Me.txtPVCordoba.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVCordoba.Properties.Appearance.Options.UseFont = True
        Me.txtPVCordoba.Properties.Mask.EditMask = "n4"
        Me.txtPVCordoba.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPVCordoba.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPVCordoba.Size = New System.Drawing.Size(78, 20)
        Me.txtPVCordoba.StyleController = Me.LayoutControl1
        Me.txtPVCordoba.TabIndex = 0
        '
        'txtMargen
        '
        Me.txtMargen.Location = New System.Drawing.Point(387, 387)
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargen.Properties.Appearance.Options.UseFont = True
        Me.txtMargen.Properties.Mask.EditMask = "p3"
        Me.txtMargen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMargen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMargen.Size = New System.Drawing.Size(130, 20)
        Me.txtMargen.StyleController = Me.LayoutControl1
        Me.txtMargen.TabIndex = 1
        '
        'txtCostoUltimo
        '
        Me.txtCostoUltimo.Location = New System.Drawing.Point(655, 387)
        Me.txtCostoUltimo.Name = "txtCostoUltimo"
        Me.txtCostoUltimo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoUltimo.Properties.Appearance.Options.UseFont = True
        Me.txtCostoUltimo.Properties.Mask.EditMask = "n6"
        Me.txtCostoUltimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCostoUltimo.Properties.ReadOnly = True
        Me.txtCostoUltimo.Size = New System.Drawing.Size(328, 20)
        Me.txtCostoUltimo.StyleController = Me.LayoutControl1
        Me.txtCostoUltimo.TabIndex = 3
        '
        'txtCostoPromedio
        '
        Me.txtCostoPromedio.Location = New System.Drawing.Point(521, 387)
        Me.txtCostoPromedio.Name = "txtCostoPromedio"
        Me.txtCostoPromedio.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoPromedio.Properties.Appearance.Options.UseFont = True
        Me.txtCostoPromedio.Properties.Mask.EditMask = "n6"
        Me.txtCostoPromedio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCostoPromedio.Properties.ReadOnly = True
        Me.txtCostoPromedio.Size = New System.Drawing.Size(130, 20)
        Me.txtCostoPromedio.StyleController = Me.LayoutControl1
        Me.txtCostoPromedio.TabIndex = 2
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(36, 387)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Properties.Appearance.Options.UseFont = True
        Me.txtCosto.Properties.Mask.EditMask = "n6"
        Me.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Size = New System.Drawing.Size(181, 20)
        Me.txtCosto.StyleController = Me.LayoutControl1
        Me.txtCosto.TabIndex = 0
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoScroll = True
        Me.CodigoBarra.BarCode = ""
        Me.CodigoBarra.BarCodeHeight = 50
        Me.CodigoBarra.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.CodigoBarra.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.CodigoBarra.HeaderText = "BarCode Demo"
        Me.CodigoBarra.LeftMargin = 10
        Me.CodigoBarra.Location = New System.Drawing.Point(732, 472)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.ShowFooter = True
        Me.CodigoBarra.ShowHeader = False
        Me.CodigoBarra.Size = New System.Drawing.Size(251, 66)
        Me.CodigoBarra.TabIndex = 164
        Me.CodigoBarra.TopMargin = 0
        Me.CodigoBarra.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center
        Me.CodigoBarra.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCentroCosto.EnterMoveNextControl = True
        Me.cbCentroCosto.Location = New System.Drawing.Point(150, 250)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Properties.NullText = ""
        Me.cbCentroCosto.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbCentroCosto.Properties.ShowFooter = False
        Me.cbCentroCosto.Properties.ShowHeader = False
        Me.cbCentroCosto.Size = New System.Drawing.Size(439, 20)
        Me.cbCentroCosto.StyleController = Me.LayoutControl1
        Me.cbCentroCosto.TabIndex = 188
        '
        'txtSAC
        '
        Me.txtSAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSAC.Location = New System.Drawing.Point(529, 274)
        Me.txtSAC.Name = "txtSAC"
        Me.txtSAC.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSAC.Properties.Appearance.Options.UseFont = True
        Me.txtSAC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSAC.Properties.MaxLength = 20
        Me.txtSAC.Size = New System.Drawing.Size(235, 20)
        Me.txtSAC.StyleController = Me.LayoutControl1
        Me.txtSAC.TabIndex = 168
        '
        'txtNombre
        '
        Me.txtNombre.EditValue = ""
        Me.txtNombre.Location = New System.Drawing.Point(150, 105)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(296, 40)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 189
        '
        'cbCatalogo4
        '
        Me.cbCatalogo4.Location = New System.Drawing.Point(138, 124)
        Me.cbCatalogo4.Name = "cbCatalogo4"
        Me.cbCatalogo4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo4.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo4.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo4.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo4.Properties.View = Me.vCat4
        Me.cbCatalogo4.Size = New System.Drawing.Size(857, 22)
        Me.cbCatalogo4.StyleController = Me.LayoutControl1
        Me.cbCatalogo4.TabIndex = 186
        '
        'vCat4
        '
        Me.vCat4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat4.Name = "vCat4"
        Me.vCat4.OptionsBehavior.Editable = False
        Me.vCat4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat4.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo5
        '
        Me.cbCatalogo5.Location = New System.Drawing.Point(138, 150)
        Me.cbCatalogo5.Name = "cbCatalogo5"
        Me.cbCatalogo5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo5.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo5.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo5.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo5.Properties.View = Me.vCat5
        Me.cbCatalogo5.Size = New System.Drawing.Size(857, 22)
        Me.cbCatalogo5.StyleController = Me.LayoutControl1
        Me.cbCatalogo5.TabIndex = 187
        '
        'vCat5
        '
        Me.vCat5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat5.Name = "vCat5"
        Me.vCat5.OptionsBehavior.Editable = False
        Me.vCat5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat5.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo3
        '
        Me.cbCatalogo3.Location = New System.Drawing.Point(138, 98)
        Me.cbCatalogo3.Name = "cbCatalogo3"
        Me.cbCatalogo3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo3.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo3.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo3.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo3.Properties.View = Me.vCat3
        Me.cbCatalogo3.Size = New System.Drawing.Size(857, 22)
        Me.cbCatalogo3.StyleController = Me.LayoutControl1
        Me.cbCatalogo3.TabIndex = 9
        '
        'vCat3
        '
        Me.vCat3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat3.Name = "vCat3"
        Me.vCat3.OptionsBehavior.Editable = False
        Me.vCat3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat3.OptionsView.ShowGroupPanel = False
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(150, 149)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Properties.Appearance.Options.UseFont = True
        Me.cbProveedores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedores.Properties.NullText = "[Seleccione Proveedor]"
        Me.cbProveedores.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbProveedores.Properties.View = Me.GridView1
        Me.cbProveedores.Size = New System.Drawing.Size(439, 22)
        Me.cbProveedores.StyleController = Me.LayoutControl1
        Me.cbProveedores.TabIndex = 2
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo2
        '
        Me.cbCatalogo2.Location = New System.Drawing.Point(138, 72)
        Me.cbCatalogo2.Name = "cbCatalogo2"
        Me.cbCatalogo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo2.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo2.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo2.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo2.Properties.View = Me.vCat2
        Me.cbCatalogo2.Size = New System.Drawing.Size(857, 22)
        Me.cbCatalogo2.StyleController = Me.LayoutControl1
        Me.cbCatalogo2.TabIndex = 8
        '
        'vCat2
        '
        Me.vCat2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat2.Name = "vCat2"
        Me.vCat2.OptionsBehavior.Editable = False
        Me.vCat2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat2.OptionsView.ShowGroupPanel = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(150, 79)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Properties.MaxLength = 50
        Me.txtCodigo.Size = New System.Drawing.Size(278, 20)
        Me.txtCodigo.StyleController = Me.LayoutControl1
        Me.txtCodigo.TabIndex = 0
        '
        'cbCatalogo1
        '
        Me.cbCatalogo1.Location = New System.Drawing.Point(138, 46)
        Me.cbCatalogo1.Name = "cbCatalogo1"
        Me.cbCatalogo1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo1.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo1.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo1.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo1.Properties.View = Me.vCat1
        Me.cbCatalogo1.Size = New System.Drawing.Size(857, 22)
        Me.cbCatalogo1.StyleController = Me.LayoutControl1
        Me.cbCatalogo1.TabIndex = 7
        '
        'vCat1
        '
        Me.vCat1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat1.Name = "vCat1"
        Me.vCat1.OptionsBehavior.Editable = False
        Me.vCat1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat1.OptionsView.ShowGroupPanel = False
        '
        'txtFactor
        '
        Me.txtFactor.EditValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.txtFactor.Location = New System.Drawing.Point(882, 274)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactor.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtFactor.Properties.Appearance.Options.UseFont = True
        Me.txtFactor.Properties.Appearance.Options.UseForeColor = True
        Me.txtFactor.Properties.Mask.EditMask = "n4"
        Me.txtFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFactor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFactor.Size = New System.Drawing.Size(101, 22)
        Me.txtFactor.StyleController = Me.LayoutControl1
        Me.txtFactor.TabIndex = 16
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(707, 200)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Properties.Appearance.Options.UseFont = True
        Me.txtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Properties.MaxLength = 50
        Me.txtModelo.Size = New System.Drawing.Size(276, 20)
        Me.txtModelo.StyleController = Me.LayoutControl1
        Me.txtModelo.TabIndex = 11
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Location = New System.Drawing.Point(707, 175)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentacion.Properties.Appearance.Options.UseFont = True
        Me.txtPresentacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPresentacion.Properties.MaxLength = 50
        Me.txtPresentacion.Size = New System.Drawing.Size(276, 20)
        Me.txtPresentacion.StyleController = Me.LayoutControl1
        Me.txtPresentacion.TabIndex = 13
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(707, 225)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Properties.Appearance.Options.UseFont = True
        Me.txtUbicacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Properties.MaxLength = 50
        Me.txtUbicacion.Size = New System.Drawing.Size(276, 20)
        Me.txtUbicacion.StyleController = Me.LayoutControl1
        Me.txtUbicacion.TabIndex = 14
        '
        'cbSubGrupo
        '
        Me.cbSubGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubGrupo.Location = New System.Drawing.Point(150, 225)
        Me.cbSubGrupo.Name = "cbSubGrupo"
        Me.cbSubGrupo.Size = New System.Drawing.Size(439, 21)
        Me.cbSubGrupo.TabIndex = 5
        '
        'cbGrupo
        '
        Me.cbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.Location = New System.Drawing.Point(150, 200)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(439, 21)
        Me.cbGrupo.TabIndex = 4
        '
        'cmbmoneda
        '
        Me.cmbmoneda.Location = New System.Drawing.Point(150, 274)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(261, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl1
        Me.cmbmoneda.TabIndex = 15
        '
        'cbLinea
        '
        Me.cbLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLinea.Location = New System.Drawing.Point(150, 175)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(439, 21)
        Me.cbLinea.TabIndex = 3
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbS_subgrupo
        Me.LayoutControlItem16.CustomizationFormText = "Sub Sub Grupo:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(245, 224)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(245, 26)
        Me.LayoutControlItem16.Text = "Sub Sub Grupo:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.etInicio
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(245, 174)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(245, 25)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtConcentracion
        Me.LayoutControlItem29.CustomizationFormText = "Concentración:"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(162, 24)
        Me.LayoutControlItem29.Text = "Concentración:"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.txtvia_admini
        Me.LayoutControlItem30.CustomizationFormText = "Via Administración:"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(328, 24)
        Me.LayoutControlItem30.Text = "Via Administración:"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtnivel_uso
        Me.LayoutControlItem31.CustomizationFormText = "Nivel de Uso"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(467, 24)
        Me.LayoutControlItem31.Text = "Nivel de Uso"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txtreceta
        Me.LayoutControlItem32.CustomizationFormText = "Precisa Receta"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(663, 24)
        Me.LayoutControlItem32.Text = "Precisa Receta"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.txtcodigoproveedor
        Me.LayoutControlItem36.CustomizationFormText = "SKU:"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(331, 48)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(332, 24)
        Me.LayoutControlItem36.Text = "SKU:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1019, 769)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(999, 580)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup7})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceTabPage.Header.Image = CType(resources.GetObject("LayoutControlGroup2.AppearanceTabPage.Header.Image"), System.Drawing.Image)
        Me.LayoutControlGroup2.AppearanceTabPage.Header.Options.UseImage = True
        Me.LayoutControlGroup2.CustomizationFormText = "Datos Generales"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.LayoutControlGroup3, Me.LayoutControlGroup6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(975, 534)
        Me.LayoutControlGroup2.Text = "Datos Generales"
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup5.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup5.CustomizationFormText = "DETALLE DEL PRODUCTO"
        Me.LayoutControlGroup5.ExpandButtonVisible = True
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem54, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem61, Me.LayoutControlItem62, Me.LayoutControlItem10, Me.LayoutControlItem56, Me.LayoutControlItem6, Me.LayoutControlItem11, Me.LayoutControlItem4, Me.LayoutControlItem13, Me.LayoutControlItem7, Me.LayoutControlItem3, Me.LayoutControlItem8, Me.LayoutControlItem14, Me.LayoutControlItem23, Me.LayoutControlItem22, Me.LayoutControlItem12, Me.LayoutControlItem5, Me.LayoutControlItem57, Me.LayoutControlItem58, Me.LayoutControlItem59})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(975, 292)
        Me.LayoutControlGroup5.Text = "DETALLE DEL PRODUCTO"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.CustomizationFormText = "Código:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(396, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(396, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(396, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Código:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(703, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.chkActivo
        Me.LayoutControlItem54.CustomizationFormText = "LayoutControlItem54"
        Me.LayoutControlItem54.Location = New System.Drawing.Point(871, 0)
        Me.LayoutControlItem54.MaxSize = New System.Drawing.Size(80, 26)
        Me.LayoutControlItem54.MinSize = New System.Drawing.Size(80, 26)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(80, 26)
        Me.LayoutControlItem54.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem54.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkExento
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(713, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(158, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.CustomizationFormText = "Descripción:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 44)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(128, 44)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(414, 44)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Descripción Comercial:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.chkValidar
        Me.LayoutControlItem61.CustomizationFormText = "LayoutControlItem61"
        Me.LayoutControlItem61.Location = New System.Drawing.Point(804, 26)
        Me.LayoutControlItem61.MaxSize = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem61.MinSize = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem61.TextVisible = False
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.chkObsoleto
        Me.LayoutControlItem62.CustomizationFormText = "LayoutControlItem62"
        Me.LayoutControlItem62.Location = New System.Drawing.Point(804, 48)
        Me.LayoutControlItem62.MaxSize = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem62.MinSize = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(147, 22)
        Me.LayoutControlItem62.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem62.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cbProveedores
        Me.LayoutControlItem10.CustomizationFormText = "Proveedor:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 70)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(557, 26)
        Me.LayoutControlItem10.Text = "Proveedor:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.cbUnidad
        Me.LayoutControlItem56.Location = New System.Drawing.Point(557, 70)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(394, 26)
        Me.LayoutControlItem56.Text = "U/Medida:"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtPresentacion
        Me.LayoutControlItem6.CustomizationFormText = "Presentación:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(557, 96)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(394, 25)
        Me.LayoutControlItem6.Text = "Presentación:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbLinea
        Me.LayoutControlItem11.CustomizationFormText = "Linea:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(557, 25)
        Me.LayoutControlItem11.Text = "Linea:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtModelo
        Me.LayoutControlItem4.CustomizationFormText = "Modelo:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(557, 121)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(394, 25)
        Me.LayoutControlItem4.Text = "Modelo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cbGrupo
        Me.LayoutControlItem13.CustomizationFormText = "Grupo:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(557, 25)
        Me.LayoutControlItem13.Text = "Grupo:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUbicacion
        Me.LayoutControlItem7.CustomizationFormText = "Ubicación:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(557, 146)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(394, 25)
        Me.LayoutControlItem7.Text = "Ubicación:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCultivos
        Me.LayoutControlItem3.CustomizationFormText = "Tipo de Cultivo:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(557, 171)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(394, 24)
        Me.LayoutControlItem3.Text = "Tipo de Cultivo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbmoneda
        Me.LayoutControlItem8.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 195)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(379, 26)
        Me.LayoutControlItem8.Text = "Moneda:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cbSubGrupo
        Me.LayoutControlItem14.CustomizationFormText = "Sub Grupo:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 146)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(557, 25)
        Me.LayoutControlItem14.Text = "Sub Grupo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cbCentroCosto
        Me.LayoutControlItem23.CustomizationFormText = "Centro Costo:"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 171)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(557, 24)
        Me.LayoutControlItem23.Text = "Centro Costo:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtSAC
        Me.LayoutControlItem22.CustomizationFormText = "#SAC:"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(379, 195)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(353, 26)
        Me.LayoutControlItem22.Text = "#SAC:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtFactor
        Me.LayoutControlItem12.CustomizationFormText = "Factor Conversión:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(732, 195)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Factor Facturación:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtCodigoParte
        Me.LayoutControlItem5.Location = New System.Drawing.Point(396, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(307, 26)
        Me.LayoutControlItem5.Text = "Codigo Parte:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.txtNombreProveedor
        Me.LayoutControlItem57.Location = New System.Drawing.Point(414, 26)
        Me.LayoutControlItem57.MaxSize = New System.Drawing.Size(0, 44)
        Me.LayoutControlItem57.MinSize = New System.Drawing.Size(128, 44)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(390, 44)
        Me.LayoutControlItem57.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem57.Text = "Descripción Proveedor:"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.cbFabricante
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 221)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(732, 26)
        Me.LayoutControlItem58.Text = "Fabricante"
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.txtFactorIngreso
        Me.LayoutControlItem59.Location = New System.Drawing.Point(732, 221)
        Me.LayoutControlItem59.MaxSize = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem59.MinSize = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(219, 26)
        Me.LayoutControlItem59.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem59.Text = "Factor Ingreso:"
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.CustomizationFormText = "COSTOS"
        Me.LayoutControlGroup3.ExpandButtonVisible = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem67})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 292)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(975, 85)
        Me.LayoutControlGroup3.Text = "COSTOS"
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtCosto
        Me.LayoutControlItem25.CustomizationFormText = "Costo:"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(185, 40)
        Me.LayoutControlItem25.Text = "Costo 1:"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtMargen
        Me.LayoutControlItem26.CustomizationFormText = "Margen %:"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(351, 0)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(134, 40)
        Me.LayoutControlItem26.Text = "Margen %:"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtCostoPromedio
        Me.LayoutControlItem27.CustomizationFormText = "Costo Promedio:"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(485, 0)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(134, 40)
        Me.LayoutControlItem27.Text = "Costo Promedio:"
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtCostoUltimo
        Me.LayoutControlItem28.CustomizationFormText = "Costo Ultimo:"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(619, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(332, 40)
        Me.LayoutControlItem28.Text = "Costo Ultimo:"
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.txtCosto2
        Me.LayoutControlItem67.Location = New System.Drawing.Point(185, 0)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(166, 40)
        Me.LayoutControlItem67.Text = "Costo 2:"
        Me.LayoutControlItem67.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup6.AppearanceGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup6.CustomizationFormText = "PRECIOS Y EXISTENCIAS"
        Me.LayoutControlGroup6.ExpandButtonVisible = True
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem33, Me.LayoutControlItem41, Me.LayoutControlItem42, Me.LayoutControlItem43, Me.LayoutControlItem66, Me.LayoutControlItem37, Me.LayoutControlItem38, Me.LayoutControlItem39, Me.EmptySpaceItem6, Me.LayoutControlItem44, Me.LayoutControlItem40, Me.LayoutControlItem24, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 377)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(975, 157)
        Me.LayoutControlGroup6.Text = "PRECIOS Y EXISTENCIAS"
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtPVCordoba
        Me.LayoutControlItem33.CustomizationFormText = "Precio Venta:"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem33.Text = "Precio Venta 1:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtExistencias
        Me.LayoutControlItem41.CustomizationFormText = "Stock:"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(435, 0)
        Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem41.MinSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem41.Text = "Stock en Almacen:"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.txtStockMin
        Me.LayoutControlItem42.CustomizationFormText = "Stock Mínimo:"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(435, 24)
        Me.LayoutControlItem42.MaxSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem42.MinSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem42.Text = "Stock Mínimo:"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtStockMax
        Me.LayoutControlItem43.CustomizationFormText = "Stock Máximo:"
        Me.LayoutControlItem43.Location = New System.Drawing.Point(435, 48)
        Me.LayoutControlItem43.MaxSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem43.MinSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem43.Text = "Stock Máximo:"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.txtPrecoio2
        Me.LayoutControlItem66.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem66.Text = "Precio Venta 2:"
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtDescuentoA
        Me.LayoutControlItem37.CustomizationFormText = "Descuento A %:"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(196, 26)
        Me.LayoutControlItem37.Text = "Descuento A %:"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(111, 13)
        Me.LayoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtDescuentoB
        Me.LayoutControlItem38.CustomizationFormText = "Descuento B %:"
        Me.LayoutControlItem38.Location = New System.Drawing.Point(196, 86)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem38.Text = "Descuento B %:"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(111, 13)
        Me.LayoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtDescuentoC
        Me.LayoutControlItem39.CustomizationFormText = "Descuento C %:"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(393, 86)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem39.Text = "Descuento C %:"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(111, 13)
        Me.LayoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(916, 86)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(35, 26)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.txtTransito
        Me.LayoutControlItem44.CustomizationFormText = "Pedido Transito:"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(590, 86)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(197, 26)
        Me.LayoutControlItem44.Text = "Pedido Transito:"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(111, 13)
        Me.LayoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.cmdCalcularDescuentos
        Me.LayoutControlItem40.CustomizationFormText = "LayoutControlItem40"
        Me.LayoutControlItem40.Location = New System.Drawing.Point(787, 86)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(129, 26)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        Me.LayoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.CodigoBarra
        Me.LayoutControlItem24.CustomizationFormText = "Codigo de Barra"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(696, 0)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(255, 86)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(255, 86)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(255, 86)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.Text = "Codigo de Barra"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(196, 38)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(196, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(239, 86)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(435, 72)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(261, 14)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.AppearanceTabPage.Header.Image = CType(resources.GetObject("LayoutControlGroup7.AppearanceTabPage.Header.Image"), System.Drawing.Image)
        Me.LayoutControlGroup7.AppearanceTabPage.Header.Options.UseImage = True
        Me.LayoutControlGroup7.CustomizationFormText = "Datos Contables"
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(975, 534)
        Me.LayoutControlGroup7.Text = "Datos Contables"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cbCatalogo1
        Me.LayoutControlItem15.CustomizationFormText = "Cuenta Inventario:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(975, 26)
        Me.LayoutControlItem15.Text = "Cuenta Inventario:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbCatalogo2
        Me.LayoutControlItem18.CustomizationFormText = "Cuenta Costo:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(975, 26)
        Me.LayoutControlItem18.Text = "Cuenta Costo:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cbCatalogo3
        Me.LayoutControlItem19.CustomizationFormText = "Cuenta Ingreso:"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(975, 26)
        Me.LayoutControlItem19.Text = "Cuenta Ingreso:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cbCatalogo4
        Me.LayoutControlItem20.CustomizationFormText = "Cuenta Devolución:"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(975, 26)
        Me.LayoutControlItem20.Text = "Cuenta Devolución:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cbCatalogo5
        Me.LayoutControlItem21.CustomizationFormText = "Cuenta Rebajas:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(975, 430)
        Me.LayoutControlItem21.Text = "Cuenta Rebajas:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 580)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(999, 169)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtInventarioVenta
        '
        Me.txtInventarioVenta.Location = New System.Drawing.Point(12, 246)
        Me.txtInventarioVenta.Name = "txtInventarioVenta"
        Me.txtInventarioVenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioVenta.Properties.Appearance.Options.UseFont = True
        Me.txtInventarioVenta.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtInventarioVenta.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtInventarioVenta.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtInventarioVenta.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtInventarioVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInventarioVenta.Properties.ReadOnly = True
        Me.txtInventarioVenta.Size = New System.Drawing.Size(116, 20)
        Me.txtInventarioVenta.StyleController = Me.LayoutControl2
        Me.txtInventarioVenta.TabIndex = 2
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.txtTasaCambio)
        Me.LayoutControl2.Controls.Add(Me.txtPVDolar)
        Me.LayoutControl2.Controls.Add(Me.cmdProveedoresAdicionales)
        Me.LayoutControl2.Controls.Add(Me.cmdimprimecodigo)
        Me.LayoutControl2.Controls.Add(Me.cmdbarcode)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdAcumulados)
        Me.LayoutControl2.Controls.Add(Me.Button2)
        Me.LayoutControl2.Controls.Add(Me.txtInventarioCosto)
        Me.LayoutControl2.Controls.Add(Me.txtInventarioVenta)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem52, Me.LayoutControlItem53, Me.LayoutControlItem48, Me.LayoutControlItem49})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1120, 176, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(139, 742)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 96)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(116, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 170
        Me.SimpleButton1.Text = "&Documentos Digitales"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 675)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(116, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "&Salir"
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.Location = New System.Drawing.Point(32, 172)
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.Size = New System.Drawing.Size(68, 20)
        Me.txtTasaCambio.StyleController = Me.LayoutControl2
        Me.txtTasaCambio.TabIndex = 189
        Me.txtTasaCambio.Visible = False
        '
        'txtPVDolar
        '
        Me.txtPVDolar.Location = New System.Drawing.Point(32, 172)
        Me.txtPVDolar.Name = "txtPVDolar"
        Me.txtPVDolar.Size = New System.Drawing.Size(68, 20)
        Me.txtPVDolar.StyleController = Me.LayoutControl2
        Me.txtPVDolar.TabIndex = 189
        Me.txtPVDolar.Visible = False
        '
        'cmdProveedoresAdicionales
        '
        Me.cmdProveedoresAdicionales.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProveedoresAdicionales.Appearance.Options.UseFont = True
        Me.cmdProveedoresAdicionales.Appearance.Options.UseTextOptions = True
        Me.cmdProveedoresAdicionales.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdProveedoresAdicionales.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdProveedoresAdicionales.ImageOptions.Image = CType(resources.GetObject("cmdProveedoresAdicionales.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdProveedoresAdicionales.Location = New System.Drawing.Point(12, 180)
        Me.cmdProveedoresAdicionales.Name = "cmdProveedoresAdicionales"
        Me.cmdProveedoresAdicionales.Size = New System.Drawing.Size(116, 38)
        Me.cmdProveedoresAdicionales.StyleController = Me.LayoutControl2
        Me.cmdProveedoresAdicionales.TabIndex = 2
        Me.cmdProveedoresAdicionales.Text = "&Proveedores Adicionales"
        '
        'cmdimprimecodigo
        '
        Me.cmdimprimecodigo.Appearance.Options.UseTextOptions = True
        Me.cmdimprimecodigo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdimprimecodigo.ImageOptions.Image = CType(resources.GetObject("cmdimprimecodigo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdimprimecodigo.Location = New System.Drawing.Point(12, 222)
        Me.cmdimprimecodigo.Name = "cmdimprimecodigo"
        Me.cmdimprimecodigo.Size = New System.Drawing.Size(128, 38)
        Me.cmdimprimecodigo.StyleController = Me.LayoutControl2
        Me.cmdimprimecodigo.TabIndex = 4
        Me.cmdimprimecodigo.Text = "&Imprimir Codigo Barra"
        '
        'cmdbarcode
        '
        Me.cmdbarcode.Appearance.Options.UseTextOptions = True
        Me.cmdbarcode.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdbarcode.ImageOptions.Image = CType(resources.GetObject("cmdbarcode.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdbarcode.Location = New System.Drawing.Point(12, 222)
        Me.cmdbarcode.Name = "cmdbarcode"
        Me.cmdbarcode.Size = New System.Drawing.Size(128, 38)
        Me.cmdbarcode.StyleController = Me.LayoutControl2
        Me.cmdbarcode.TabIndex = 3
        Me.cmdbarcode.Text = "&Codigo de Barra"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(116, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdAcumulados
        '
        Me.cmdAcumulados.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulados.Appearance.Options.UseFont = True
        Me.cmdAcumulados.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAcumulados.ImageOptions.Image = CType(resources.GetObject("cmdAcumulados.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAcumulados.Location = New System.Drawing.Point(12, 138)
        Me.cmdAcumulados.Name = "cmdAcumulados"
        Me.cmdAcumulados.Size = New System.Drawing.Size(116, 38)
        Me.cmdAcumulados.StyleController = Me.LayoutControl2
        Me.cmdAcumulados.TabIndex = 1
        Me.cmdAcumulados.Text = "A&cumulado"
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.ImageOptions.Image = CType(resources.GetObject("Button2.ImageOptions.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(12, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 38)
        Me.Button2.StyleController = Me.LayoutControl2
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Bodegas"
        '
        'txtInventarioCosto
        '
        Me.txtInventarioCosto.Location = New System.Drawing.Point(12, 222)
        Me.txtInventarioCosto.Name = "txtInventarioCosto"
        Me.txtInventarioCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioCosto.Properties.Appearance.Options.UseFont = True
        Me.txtInventarioCosto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtInventarioCosto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtInventarioCosto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtInventarioCosto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtInventarioCosto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInventarioCosto.Properties.ReadOnly = True
        Me.txtInventarioCosto.Size = New System.Drawing.Size(116, 20)
        Me.txtInventarioCosto.StyleController = Me.LayoutControl2
        Me.txtInventarioCosto.TabIndex = 1
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.txtPVDolar
        Me.LayoutControlItem52.CustomizationFormText = "Precio U$:"
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 184)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(169, 26)
        Me.LayoutControlItem52.Text = "Precio U$:"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.txtTasaCambio
        Me.LayoutControlItem53.CustomizationFormText = "Tasa Cambio:"
        Me.LayoutControlItem53.Location = New System.Drawing.Point(0, 184)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(169, 630)
        Me.LayoutControlItem53.Text = "Tasa Cambio:"
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.cmdbarcode
        Me.LayoutControlItem48.CustomizationFormText = "LayoutControlItem48"
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem48.MaxSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem48.MinSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem48.TextVisible = False
        Me.LayoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.cmdimprimecodigo
        Me.LayoutControlItem49.CustomizationFormText = "LayoutControlItem49"
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem49.MaxSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem49.MinSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem49.TextVisible = False
        Me.LayoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Root"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem45, Me.LayoutControlItem50, Me.LayoutControlItem55, Me.LayoutControlItem46, Me.LayoutControlItem47, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.LayoutControlItem51, Me.EmptySpaceItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(140, 725)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.cmdAceptar
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem45.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem45.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem45.TextVisible = False
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.Button2
        Me.LayoutControlItem50.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem50.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem50.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem50.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem50.TextVisible = False
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.SimpleButton1
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem55.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem55.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem55.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem55.TextVisible = False
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cmdAcumulados
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem46.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem46.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem46.TextVisible = False
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.cmdProveedoresAdicionales
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem47.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem47.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtInventarioCosto
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(120, 24)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtInventarioVenta
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 234)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(120, 24)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.cmdCancelar
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 663)
        Me.LayoutControlItem51.MaxSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem51.MinSize = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(120, 42)
        Me.LayoutControlItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem51.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 258)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(120, 405)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Location = New System.Drawing.Point(267, 247)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(105, 522)
        Me.GroupBox11.TabIndex = 5
        Me.GroupBox11.TabStop = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.DockPanel1.ID = New System.Guid("19eca3d1-7472-4c77-9630-5e627449deec")
        Me.DockPanel1.Location = New System.Drawing.Point(1019, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(148, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(148, 769)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(139, 742)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmAgregarArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1184, 696)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmAgregarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtFactorIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFabricante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecoio2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcodigoproveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnivel_uso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtreceta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvia_admini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcentracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkObsoleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPVCordoba.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMargen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostoUltimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostoPromedio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSAC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPresentacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventarioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.txtTasaCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPVDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInventarioCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim proveedor As String
    Dim Cod_Proveedor As Integer

    Dim r As New VB.SysContab.Rutinas
    Dim Max As Double
    Dim Grupos As New VB.SysContab.Grupos_InventarioDB
    Private Catalogos As New VB.SysContab.CatalogoDB
    Private Temp As Boolean

    Private Sub frmAgregarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Articulo As New VB.SysContab.ArticulosDB
        'Dim p As New VB.SysContab.ProveedoresDB

        proveedor = ""

        'cbLinea.DataSource = g.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbLinea.ValueMember = "CODIGO_GRUPO"
        'cbLinea.DisplayMember = "NOMBRE"

        'cbGrupo.DataSource = g.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbGrupo.ValueMember = "CODIGO_GRUPO"
        'cbGrupo.DisplayMember = "NOMBRE"

        'cbSubGrupo.DataSource = g.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        'cbSubGrupo.ValueMember = "CODIGO_GRUPO"
        'cbSubGrupo.DisplayMember = "NOMBRE"

        GetMonedasList(cmbmoneda)
        GetTipoCultivo(Me.cbCultivos)

        LookUp(cbUnidad, db_UnidadesMedida.Listar(0), "Unidad", "Unidad", "[Seleccion U/M]", 0)
        LookUp(cbFabricante, db_Articulos_Fabricantes.Listar(0), "Nombre", "IdFabricante", "[Fabricante]", 0)

        GetCatalogoCuenta(Me.cbCatalogo1, vCat1)
        GetCatalogoCuenta(Me.cbCatalogo2, vCat2)
        GetCatalogoCuenta(Me.cbCatalogo3, vCat3)
        GetCatalogoCuenta(Me.cbCatalogo4, vCat4)
        GetCatalogoCuenta(Me.cbCatalogo5, vCat5)
        GetCatalogoProveedores(Me.cbProveedores, GridView1)
        GetCentrosCostosList(cbCentroCosto, 1)
        '
        cbLinea.DataSource = Grupos.Lineas("P").Tables("GruposCC")
        cbLinea.ValueMember = "Código"
        cbLinea.DisplayMember = "Nombre"

        'SearchLookUp(cbProyectos, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 6, 7, 8)
        'cbProyectos.EditValue = 0

        'cbProveedor.DataSource = p.GetListBuscarCombo("%", "P").Tables("PROVEEDORES")
        'cbProveedor.ValueMember = "CODIGO"
        'cbProveedor.DisplayMember = "NOMBRE"
        'Me.cbCatalogo.DataSource = Catalogos.CatalogoList("A", 0).Tables("CATALOGO")
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Nombre2"
        'cbProveedor.SelectedIndex = -1
        'cbProveedor.SelectedItem = 0
        'cbProveedor.Refresh()
        'r.FormularioColor(Me)
        'Me.Label20.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label22.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label25.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label27.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label28.BackColor = Color.FromArgb(102, 153, 153)
        'Me.Label36.BackColor = Color.FromArgb(102, 153, 153)

        Max = 0

        'Me.txtInventarioCosto.ReadOnly = True
        'Me.txtInventarioVenta.ReadOnly = True

        Me.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Properties.Mask.EditMask = RoundP
        Me.txtCosto.EditValue = 0.0

        Me.txtCosto2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto2.Properties.Mask.EditMask = RoundP
        Me.txtCosto2.EditValue = 0.0

        Me.txtMargen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMargen.Properties.Mask.EditMask = RoundP
        Me.txtMargen.EditValue = 0.0

        Me.txtPVCordoba.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPVCordoba.Properties.Mask.EditMask = RoundP
        Me.txtPVCordoba.EditValue = 0.0

        Me.txtPrecoio2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecoio2.Properties.Mask.EditMask = RoundP
        Me.txtPrecoio2.EditValue = 0.0

        Me.txtInventarioCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInventarioCosto.Properties.Mask.EditMask = RoundP
        Me.txtInventarioCosto.EditValue = 0.0

        Me.txtInventarioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInventarioVenta.Properties.Mask.EditMask = RoundP
        Me.txtInventarioVenta.EditValue = 0.0

        If Nuevo = "NO" Then
            Me.Text = "Editar Producto"

            Dim Detalles As VB.SysContab.ArticulosDetails = VB.SysContab.ArticulosDB.GetDetails(Registro, "P")
            txtCodigo.Text = Detalles.Codigo
            txtCodigo.ReadOnly = True
            txtNombre.Text = Detalles.Nombre
            txtCodigoParte.Text = Detalles.Codigo_Parte
            txtNombreProveedor.Text = Detalles.Nombre_Proveedor
            Cod_Proveedor = Detalles.Proveedor

            'Me.cbLinea.SelectedValue = Detalles.Linea

            cbGrupo.DataSource = Grupos.Grupos(Detalles.Linea, "P").Tables("GruposCC")
            cbGrupo.ValueMember = "Código"
            cbGrupo.DisplayMember = "Nombre"

            'Me.cbGrupo.SelectedValue = Detalles.Grupo

            cbSubGrupo.DataSource = Grupos.SubGrupos(Detalles.Grupo, "P").Tables("GruposCC")
            cbSubGrupo.ValueMember = "Código"
            cbSubGrupo.DisplayMember = "Nombre"

            Me.cbS_subgrupo.DataSource = Grupos.S_SubGrupos(Detalles.SubGrupo, "P").Tables("GruposCC")
            Me.cbS_subgrupo.DisplayMember = "Nombre"
            Me.cbS_subgrupo.ValueMember = "Código"

            'Me.cbProveedor.SelectedValue = Detalles.Proveedor
            Me.cbProveedores.EditValue = CInt(Detalles.Proveedor)

            'Grupos
            'Me.cbSubGrupo.SelectedValue = Detalles.SubGrupo
            Me.cbLinea.SelectedValue = Detalles.Linea
            Me.cbGrupo.SelectedValue = Detalles.Grupo
            Me.cbSubGrupo.SelectedValue = Detalles.SubGrupo
            Me.cbS_subgrupo.SelectedValue = Detalles.S_SubGrupo

            'If Me.cbS_subgrupo.Items.Count > 0 Then

            Me.txtModelo.Text = Detalles.Modelo
            ' Me.txtUnidad.Text = Detalles.Unidad
            cbUnidad.EditValue = Detalles.Unidad
            Me.txtPresentacion.Text = Detalles.Presentacion
            Me.txtUbicacion.Text = Detalles.Ubicacion
            cbCentroCosto.EditValue = CInt(Detalles.CentroCosto)
            cbFabricante.EditValue = Detalles.IdFabricante

            'PARA LOS MEDICAMENTOS
            Me.txtConcentracion.Text = Detalles.Concentracion
            Me.txtvia_admini.Text = Detalles.via_administracion
            Me.txtnivel_uso.Text = Detalles.nivel_uso
            Me.txtreceta.Text = Detalles.receta
            '--------------------
            Me.txtPVCordoba.EditValue = CDbl(Detalles.Precio_Venta_Cordobas)
            Me.txtPrecoio2.EditValue = CDbl(Detalles.Precio_Venta2)

            Me.txtPVDolar.Text = CDbl(Detalles.Precio_Venta_Dolar).ToString(RoundP)
            Me.txtCosto.EditValue = CDbl(Detalles.Costo)
            Me.txtCosto2.EditValue = CDbl(Detalles.Costo2)
            Me.txtMargen.EditValue = CDbl(Detalles.Margen)
            Me.txtCostoPromedio.Text = CDbl(Detalles.Costo_Prom).ToString(RoundP)
            Me.txtCostoUltimo.Text = CDbl(Detalles.Costo_Ultimo).ToString(RoundP)
            Me.txtExistencias.Text = Detalles.Existencia
            Me.txtStockMin.Text = Detalles.Stock_Min
            Me.txtStockMax.Text = Detalles.Stock_Max
            Me.txtDescuentoA.Text = CDbl(Detalles.Descuento_A).ToString(RoundP)
            Me.txtDescuentoB.Text = CDbl(Detalles.Descuento_B).ToString(RoundP)
            Me.txtDescuentoC.Text = CDbl(Detalles.Descuento_C).ToString(RoundP)
            Max = CDbl(Detalles.Descuento_Maximo).ToString(RoundP)
            Me.txtTasaCambio.Text = Detalles.Tasa_Cambio
            Me.txtcodigoproveedor.Text = Detalles.SKU
            Me.cbCultivos.EditValue = Detalles.Cultivo

            Me.txtInventarioCosto.EditValue = (CDbl(txtCostoPromedio.Text).ToString(RoundP) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
            Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)

            Me.chkExento.Checked = Detalles.Exento
            'Me.cbCatalogo.SelectedValue = Detalles.Cuenta
            Me.cbCatalogo1.EditValue = Detalles.Cuenta
            Me.cbCatalogo2.EditValue = Detalles.CCosto
            Me.cbCatalogo3.EditValue = Detalles.CIngreso
            Me.cbCatalogo4.EditValue = Detalles.CDevolucion
            Me.cbCatalogo5.EditValue = Detalles.CRebaja

            cmbmoneda.EditValue = Detalles.Moneda
            txtFactor.EditValue = Detalles.Factor
            txtFactorIngreso.EditValue = Detalles.FactorIngreso
            txtSAC.Text = Detalles.SAC
            chkActivo.Checked = Detalles.Activo
            chkValidar.Checked = Detalles.Validar_Precio
            chkObsoleto.Checked = Detalles.Obsoleto
            'cbProyectos.EditValue = Detalles.IdProyecto

            'CargarDocumentos()
            ' CargarPDF()
        Else
            Me.etInicio.Text = "0"
            Me.Text = "Agregar Producto"

            Me.txtPVCordoba.EditValue = 0.0
            Me.txtPrecoio2.EditValue = 0.0
            Me.txtPVDolar.Text = CDbl(0).ToString(RoundP)
            Me.txtCosto.EditValue = 0.0
            Me.txtCosto2.EditValue = 0.0
            Me.txtMargen.EditValue = 0.0
            Me.txtCostoPromedio.Text = CDbl(0).ToString(RoundP)
            Me.txtCostoUltimo.Text = CDbl(0).ToString(RoundP)
            Me.txtExistencias.Text = 0
            Me.txtStockMin.Text = 0
            Me.txtStockMax.Text = 0
            Me.txtDescuentoA.Text = CDbl(0).ToString(RoundP)
            Me.txtDescuentoB.Text = CDbl(0).ToString(RoundP)
            Me.txtDescuentoC.Text = CDbl(0).ToString(RoundP)
            'Max = CDbl(Detalles.Descuento_Maximo).ToString(Round)
            Me.txtTasaCambio.Text = CDbl(0).ToString(RoundP)

            Me.txtInventarioCosto.EditValue = CDbl(0.0).ToString(RoundP)
            Me.txtInventarioVenta.EditValue = CDbl(0.0).ToString(RoundP)
        End If

        ' CargarDocumentos()

        r.ComboAutoComplete(Me.cbLinea)
        r.ComboAutoComplete(Me.cbGrupo)
        r.ComboAutoComplete(Me.cbSubGrupo)
        r.ComboAutoComplete(Me.cbS_subgrupo)
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Dim p As New VB.SysContab.ProveedoresDB

        'If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
        '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
        '        proveedor = ""
        '        cbProveedor.SelectAll()
        '        Exit Sub

        '    End If

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '        Exit Sub

        '    End If
        'End If

        'If cbProveedor.Text = "" Then
        '    proveedor = ""
        '    Exit Sub
        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
        '    If proveedor.Length = 1 Then
        '        proveedor = ""
        '    End If

        '    If proveedor.Length > 1 Then
        '        proveedor = Mid(proveedor, 1, proveedor.Length - 1)
        '    End If

        '    If cbProveedor.Text = "" Then
        '        proveedor = ""
        '        'cbProveedor.Text = ""
        '        Exit Sub
        '    End If
        'Else
        '    proveedor = proveedor & e.KeyChar

        'End If

        'If p.GetListBuscarCombo(proveedor, "P").Tables("PROVEEDORES").Rows.Count = 0 Then
        'Else
        '    cbProveedor.SelectedValue = p.GetListBuscarCombo(proveedor, "P").Tables("PROVEEDORES").Rows(0).Item("CODIGO")
        '    cbProveedor.SelectionStart = proveedor.Length
        '    cbProveedor.Select(proveedor.Length, cbProveedor.Text.Length)
        'End If

    End Sub

    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        proveedor = ""
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If IsNull(cmbmoneda.EditValue, 0) = 0 Then
                MsgBox("Seleccione la moneda")
                cmbmoneda.Focus()
                Exit Sub
            End If

            If Trim(Me.txtCodigo.Text) = "" Then
                MsgBox("Introduzca el Código", MsgBoxStyle.Information)
                Me.txtCodigo.Focus()
                Exit Sub
            End If

            If Trim(Me.txtNombre.Text) = "" Then
                MsgBox("Introduzca el Nombre", MsgBoxStyle.Information)
                Me.txtCodigo.Focus()
                Exit Sub
            End If

            'If Me.cbProveedor.SelectedValue = 0 Then
            '    MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
            '    Me.cbProveedor.Focus()
            '    Exit Sub
            'End If

            If Me.cbProveedores.EditValue Is Nothing Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
                Me.cbProveedores.Focus()
                Exit Sub
            End If

            If Me.cbLinea.SelectedValue = "%" And Me.cbLinea.Text.Length = 0 Then
                MsgBox("Seleccione la Linea", MsgBoxStyle.Information)
                Me.cbLinea.Focus()
                Exit Sub
            End If

            If Me.cbGrupo.SelectedValue = "%" And Me.cbGrupo.Text.Length = 0 Then
                MsgBox("Seleccione el Grupo", MsgBoxStyle.Information)
                Me.cbGrupo.Focus()
                Exit Sub
            End If

            If Terraza = False Then
                If Me.cbSubGrupo.SelectedValue = "%" And Me.cbSubGrupo.Text.Length = 0 Then
                    MsgBox("Seleccione el SubGrupo", MsgBoxStyle.Information)
                    Me.cbSubGrupo.Focus()
                    Exit Sub
                End If
            End If

            ''Validacion para los Sub-SubGrupos
            'If Me.cbS_subgrupo.Items.Count > 1 Then
            '    If Me.cbS_subgrupo.SelectedIndex = 0 Then
            '        MsgBox("Seleccione el S-Subgrupo", MsgBoxStyle.Information)
            '        Me.cbS_subgrupo.Focus()
            '        Exit Sub
            '    End If
            'End If

            'If Me.cbCatalogo.SelectedValue = "" Or Me.cbCatalogo.SelectedValue Is Nothing Then
            '    MsgBox("Seleccione la Cuenta Contable para el Articulo", MsgBoxStyle.Information)
            '    Me.cbCatalogo.Focus()
            '    Exit Sub
            'End If
            If Nuevo = "SI" Then
                If chkExento.Checked Then
                    If Not XtraMsg2("Esta Seguro que el Nuevo Producto es Exento de Impuesto?") Then
                        chkExento.Focus()
                        Exit Sub
                    End If
                End If
            End If
            '

            If Not (VB.SysContab.ArticulosDB.GetDetails(Me.txtCodigo.Text, "P").Codigo Is Nothing) And Nuevo = "SI" Then
                XtraMsg("Ese codigo ya existe", MessageBoxIcon.Error)
                txtCodigo.Focus()
                Exit Sub
            End If

            Guardar()
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub cbProveedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim p As New VB.SysContab.ProveedoresDB

        'If Trim(cbProveedor.Text) = "" Then
        '    proveedor = ""
        '    Exit Sub
        'End If

        'If p.GetListBuscarCombo(cbProveedor.Text, "P").Tables("PROVEEDORES").Rows.Count = 0 Then
        '    MsgBox("Proveedor no Existe", MsgBoxStyle.Information)
        '    proveedor = ""
        '    cbProveedor.Focus()
        '    Exit Sub

        'End If

        'Cod_Proveedor = p.GetListBuscarCombo(cbProveedor.Text, "P").Tables("PROVEEDORES").Rows(0).Item("CODIGO")
        'proveedor = ""
    End Sub


    Private Sub txtTasaCambio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTasaCambio.Leave
        If Trim(txtTasaCambio.Text) <> "" Then
            If txtTasaCambio.Text = "0" Then
                txtPVDolar.Text = "0"
                Exit Sub
            End If
            txtPVDolar.Text = CDbl(CDbl(Me.txtPVCordoba.EditValue) / CDbl(txtTasaCambio.Text)).ToString(RoundP)
            Me.txtInventarioCosto.EditValue = (CDbl(Me.txtCostoPromedio.Text) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
            Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
        End If
    End Sub

    Private Sub frmAgregarArticulo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim A As frmArticulos = frmArticulos.Instance
        A.Cargar()
    End Sub

    Private Sub cmdAcumulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulados.Click
        Dim f As frmAcumuladosProductos = frmAcumuladosProductos.Instance
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdProveedoresAdicionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProveedoresAdicionales.Click
        If Trim(Me.txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Articulo", MsgBoxStyle.Information)
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        If Me.cbProveedores.EditValue Is Nothing Then
            MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
            Me.cbProveedores.Focus()
            Exit Sub
        End If

        If Nuevo = "SI" Then
            Try
                Guardar()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If

        Dim f As New frmProveedoresAdicionales

        f.etProveedor.Text = cbProveedores.EditValue
        f.etArticulo.Text = Me.txtCodigo.Text

        f.StartPosition = FormStartPosition.CenterScreen
        f.FormBorderStyle = FormBorderStyle.Fixed3D
        f.MaximizeBox = False

        f.ShowDialog()

        If Nuevo = "SI" Then
            Limpiar()
        End If

    End Sub

    Private Sub Guardar()
        Dim Articulo As New VB.SysContab.ArticulosDB
        Dim Exento As Integer

        If Me.chkExento.Checked = True Then
            Exento = 1
        Else
            Exento = 0
        End If

        Dim Cultivo As String = ""
        If ObtieneDatos("SELECT * FROM TipoCultivo WHERE Empresa = " & EmpresaActual).Rows.Count > 0 Then
            Cultivo = Me.cbCultivos.EditValue
        End If

        If Nuevo = "SI" Then
            Articulo.AddItem(txtCodigo.Text, txtNombre.Text, Me.cbProveedores.EditValue, Me.cbLinea.SelectedValue,
                             Me.cbGrupo.SelectedValue, IsNull(Me.cbSubGrupo.SelectedValue, ""),
                             IIf(Me.cbS_subgrupo.SelectedValue = Nothing, "", Me.cbS_subgrupo.SelectedValue), txtModelo.Text,
                             IIf(cbUnidad.EditValue Is Nothing, "", cbUnidad.EditValue), txtPresentacion.Text, txtUbicacion.Text, Me.txtPVCordoba.EditValue, 0, Me.txtCosto.EditValue,
                             Me.txtMargen.EditValue, txtCostoPromedio.Text, txtCostoUltimo.Text, txtExistencias.Text, txtStockMin.Text,
                             txtStockMax.Text, txtDescuentoA.Text, txtDescuentoB.Text, txtDescuentoC.Text, Max, 1, "P",
                             Me.chkExento.Checked, IIf(Me.cbCatalogo1.EditValue Is Nothing, "", Me.cbCatalogo1.EditValue),
                             Me.txtConcentracion.Text, Me.txtvia_admini.Text, Me.txtnivel_uso.Text, Me.txtreceta.Text,
                             cmbmoneda.EditValue, txtcodigoproveedor.Text, Cultivo, IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue),
                             IIf(Me.cbCatalogo3.EditValue Is Nothing, "", Me.cbCatalogo3.EditValue), Me.txtFactor.EditValue,
                             IIf(Me.cbCatalogo4.EditValue Is Nothing, "", Me.cbCatalogo4.EditValue), IIf(Me.cbCatalogo5.EditValue Is Nothing, "", Me.cbCatalogo5.EditValue),
                             IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue), txtSAC.Text, IIf(chkActivo.Checked, 1, 0),
                             IIf(chkValidar.Checked, 1, 0), IIf(chkObsoleto.Checked, 1, 0), txtPrecoio2.EditValue, txtCosto2.EditValue, 0,
                             txtCodigoParte.Text, txtNombreProveedor.Text,
                             IIf(cbFabricante.EditValue Is Nothing, 0, cbFabricante.EditValue), txtFactorIngreso.EditValue)
        Else
            Articulo.Update(txtCodigo.Text, txtNombre.Text, Me.cbProveedores.EditValue, Me.cbLinea.SelectedValue,
                            Me.cbGrupo.SelectedValue, IsNull(Me.cbSubGrupo.SelectedValue, ""),
                            IIf(Me.cbS_subgrupo.SelectedValue = Nothing, "", Me.cbS_subgrupo.SelectedValue), txtModelo.Text,
                            IIf(cbUnidad.EditValue Is Nothing, "", cbUnidad.EditValue), txtPresentacion.Text, txtUbicacion.Text, Me.txtPVCordoba.EditValue, 0, Me.txtCosto.EditValue,
                            Me.txtMargen.EditValue, txtExistencias.Text, txtStockMin.Text, txtStockMax.Text, txtDescuentoA.Text,
                            txtDescuentoB.Text, txtDescuentoC.Text, Max, 1, Me.chkExento.Checked,
                            IIf(Me.cbCatalogo1.EditValue Is Nothing, "", Me.cbCatalogo1.EditValue), Me.txtConcentracion.Text,
                            Me.txtvia_admini.Text, Me.txtnivel_uso.Text, Me.txtreceta.Text, "P", cmbmoneda.EditValue,
                            txtcodigoproveedor.Text, Cultivo, IIf(Me.cbCatalogo2.EditValue Is Nothing, "", Me.cbCatalogo2.EditValue),
                            IIf(Me.cbCatalogo3.EditValue Is Nothing, "", Me.cbCatalogo3.EditValue), Me.txtFactor.EditValue,
                            IIf(Me.cbCatalogo4.EditValue Is Nothing, "", Me.cbCatalogo4.EditValue), IIf(Me.cbCatalogo5.EditValue Is Nothing, "", Me.cbCatalogo5.EditValue),
                            IIf(Me.cbCentroCosto.EditValue Is Nothing, 0, Me.cbCentroCosto.EditValue), txtSAC.Text, IIf(chkActivo.Checked, 1, 0),
                            IIf(chkValidar.Checked, 1, 0), IIf(chkObsoleto.Checked, 1, 0), txtPrecoio2.EditValue, txtCosto2.EditValue, 0,
                            txtCodigoParte.Text, txtNombreProveedor.Text, IIf(cbFabricante.EditValue Is Nothing, 0, cbFabricante.EditValue), txtFactorIngreso.EditValue)

            Me.Close()
        End If
    End Sub

    Private Sub Limpiar()

        Me.txtCosto.EditValue = 0.0
        Me.txtCosto2.EditValue = 0.0
        Me.txtMargen.EditValue = 0.0
        Me.txtCostoPromedio.Text = "0.00"
        Me.txtCostoUltimo.Text = "0.00"
        Me.txtPVCordoba.EditValue = 0.0
        Me.txtPrecoio2.EditValue = 0.0
        Me.txtPVDolar.Text = "0.00"
        Me.txtDescuentoA.Text = "0.00"
        Me.txtDescuentoB.Text = "0.00"
        Me.txtDescuentoC.Text = "0.00"
        Me.txtStockMax.Text = "0"
        Me.txtStockMin.Text = "0"
        Me.txtCodigo.Text = ""
        Me.txtExistencias.Text = "0"
        Me.txtInventarioCosto.EditValue = 0.0
        Me.txtInventarioVenta.EditValue = 0.0
        Me.txtModelo.Text = ""
        Me.txtNombre.Text = ""
        Me.txtPresentacion.Text = ""
        Me.txtUbicacion.Text = ""
        'Me.txtUnidad.Text = ""
        cbUnidad.EditValue = Nothing
        Me.txtConcentracion.Text = ""
        Me.txtvia_admini.Text = ""
        Me.txtnivel_uso.Text = ""
        Me.txtreceta.Text = ""
        Me.txtFactor.EditValue = 1.0
        txtFactorIngreso.EditValue = 1.0
        txtSAC.Text = ""
        'Me.txt.Text = ""

        'Me.cbProveedor.SelectedIndex = -1
        Me.cbProveedores.EditValue = Nothing
        Me.cbLinea.SelectedIndex = -1
        'Me.cbCatalogo.SelectedIndex = -1
        Me.cbCatalogo1.EditValue = Nothing
        Me.cbCatalogo2.EditValue = Nothing
        Me.cbCatalogo3.EditValue = Nothing

        'Limpiar Combo de los subgrupos
        Me.cbGrupo.DataSource = Nothing
        Me.cbSubGrupo.DataSource = Nothing
        Me.cbS_subgrupo.DataSource = Nothing

        Me.cbGrupo.SelectedIndex = -1
        Me.cbSubGrupo.SelectedIndex = -1
        Me.cbS_subgrupo.SelectedIndex = -1

        'cbProveedor.SelectedValue = -1
        'cbLinea.SelectedValue = -1
        'cbGrupo.SelectedValue = -1
        'cbSubGrupo.SelectedValue = -1
        'Me.cbS_subgrupo.SelectedValue = -1

        txtCodigo.Focus()
    End Sub

    Private Sub cmdCalcularDescuentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalcularDescuentos.Click
        Max = (CDbl(Me.txtMargen.EditValue) * 50 / 100.0).ToString(RoundP)
        txtDescuentoA.Text = (Max * 70 / 100.0).ToString(RoundP)
        txtDescuentoB.Text = (Max * 45 / 100.0).ToString(RoundP)
        txtDescuentoC.Text = (Max * 20 / 100.0).ToString(RoundP)
    End Sub

    Private Sub txtDescuentoA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentoA.Leave
        If Trim(Me.txtDescuentoA.Text) = "" Then
            Me.txtDescuentoA.Text = "0.00"
        Else
            Me.txtDescuentoA.Text = CDbl(Me.txtDescuentoA.Text).ToString(RoundP)
        End If
    End Sub

    Private Sub txtDescuentoB_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentoB.Leave
        If Trim(Me.txtDescuentoB.Text) = "" Then
            Me.txtDescuentoB.Text = "0.00"
        Else
            Me.txtDescuentoB.Text = CDbl(Me.txtDescuentoB.Text).ToString(RoundP)
        End If
    End Sub

    Private Sub txtDescuentoC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentoC.Leave
        If Trim(Me.txtDescuentoC.Text) = "" Then
            Me.txtDescuentoC.Text = "0.00"
        Else
            Me.txtDescuentoC.Text = CDbl(Me.txtDescuentoC.Text).ToString(RoundP)
        End If
    End Sub

    Private Sub txtStockMax_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStockMax.Leave
        If Trim(Me.txtStockMax.Text) = "" Then
            Me.txtStockMax.Text = "0"
        End If
    End Sub

    Private Sub txtStockMin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStockMin.Leave
        If Trim(Me.txtStockMin.Text) = "" Then
            Me.txtStockMin.Text = "0"
        End If
    End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLinea.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        If Me.cbLinea.SelectedIndex > 0 Then
            cbGrupo.DataSource = Grupos.Grupos(Me.cbLinea.SelectedValue, "P").Tables("GruposCC")
            cbGrupo.ValueMember = "Código"
            cbGrupo.DisplayMember = "Nombre"
        End If
        Me.cbSubGrupo.DataSource = Nothing
        Me.cbS_subgrupo.DataSource = Nothing
    End Sub

    Private Sub cbGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        If Me.cbGrupo.SelectedIndex > 0 Then
            cbSubGrupo.DataSource = Grupos.SubGrupos(Me.cbGrupo.SelectedValue, "P").Tables("GruposCC")
            cbSubGrupo.ValueMember = "Código"
            cbSubGrupo.DisplayMember = "Nombre"
        End If
    End Sub

    Private Sub cbSubGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSubGrupo.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        If Me.cbSubGrupo.SelectedIndex > 0 Then
            Me.cbS_subgrupo.DataSource = Grupos.S_SubGrupos(Me.cbSubGrupo.SelectedValue, "P").Tables("GruposCC")
            Me.cbS_subgrupo.ValueMember = "Código"
            Me.cbS_subgrupo.DisplayMember = "Nombre"
        End If
    End Sub

    Private Sub txtExistencias_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExistencias.Leave
        Me.txtInventarioCosto.EditValue = (CDbl(Me.txtCostoPromedio.Text) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
        Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
    End Sub

    Private Sub cmdbarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbarcode.Click
        CodigoBarra.Visible = True
        CodigoBarra.BarCode = EmpresaActual + "" + cbSubGrupo.SelectedValue + "" + txtCodigo.Text
    End Sub

    Private Sub cmdimprimecodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimecodigo.Click
        If CodigoBarra.Visible Then CodigoBarra.Print()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        CodigoBarra.Visible = True
        'CodigoBarra.BarCode = EmpresaActual + "" + cbSubGrupo.SelectedValue + "" + txtCodigo.Text
        CodigoBarra.BarCode = txtCodigo.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim f As frmGridArticulosxBodega = frmGridArticulosxBodega.Instance()
        f.cArticulo = Me.txtCodigo.Text
        f.Text = "PRODUCTO: " + Me.txtCodigo.Text
        f.TipoProducto = "P"
        f.ShowDialog()
        f.Dispose()

        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    'Private Sub ActualizaMagen()
    '    Temp = True
    'Me.txtMargen.EditValue = Format((((IsNull(Me.txtPVCordoba.EditValue, 0) / IsNull( Me.txtCosto.EditValue, 0)) - 1) * 100), "n2")
    '  Me.txtMargen.EditValue = (((IsNull(Me.txtPVCordoba.EditValue, 0) / IsNull(Me.txtCosto.EditValue, 0)) - 1) * 100)
    '    Temp = False
    'End Sub

    Private Sub txtMargen_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMargen.Validating, txtCosto.Validating
        Try
            txtPVCordoba.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularPrecioVenta(" & txtCosto.EditValue & "," & txtMargen.EditValue & ") Precio").Rows.Item(0)("Precio")
            'Me.txtPVCordoba.EditValue = CDbl(CDbl(Me.txtCosto.EditValue) + (CDbl(Me.txtCosto.EditValue) * CDbl(Me.txtMargen.EditValue)) / 100.0).ToString(RoundP)

            txtPVDolar.Text = IIf(CDbl(txtTasaCambio.Text) = 0, 0, CDbl(CDbl(Me.txtPVCordoba.EditValue) / CDbl(txtTasaCambio.Text)).ToString(RoundP))

            Me.txtInventarioCosto.EditValue = (CDbl(Me.txtCostoPromedio.Text) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
            Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)

            If Nuevo = "SI" Then
                txtCostoPromedio.Text = 0.0 'CDbl( Me.txtCosto.EditValue).ToString(RoundP)
                txtCostoUltimo.Text = 0.0  'CDbl(Me.txtCosto.EditValue).ToString(RoundP)
            End If
        Catch ex As Exception
            txtPVCordoba.EditValue = 0.0
        End Try
    End Sub

    Private Sub txtPVCordoba_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPVCordoba.Validating
        Try
            txtMargen.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularMargenVenta(" & txtCosto.EditValue & "," & txtPVCordoba.EditValue & ") Precio").Rows.Item(0)("Precio")
        Catch ex As Exception
            txtMargen.EditValue = 0.0
        End Try

    End Sub

    Private Sub txtCosto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCosto.Validating

        'txtPVCordoba.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularPrecioVenta(" & txtCosto.EditValue & "," & txtMargen.EditValue & ") Precio").Rows.Item(0)("Precio")
        ' Me.txtPVCordoba.EditValue = CDbl(CDbl(Me.txtCosto.EditValue) + (CDbl(Me.txtCosto.EditValue) * CDbl(txtMargen.EditValue)) / 100.0).ToString(RoundP)

        'If Nuevo = "SI" Then
        '    txtCostoPromedio.Text = 0 'CDbl( Me.txtCosto.EditValue).ToString(RoundP)
        '    txtCostoUltimo.Text = CDbl(Me.txtCosto.EditValue).ToString(RoundP)
        'End If

        'Try
        '    Me.txtCosto.EditValue = CDbl(Me.txtCosto.EditValue).ToString(RoundP)
        '    Me.txtInventarioCosto.EditValue = (CDbl(Me.txtCosto.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
        '    Me.txtInventarioVenta.EditValue = (CDbl(Me.txtPVCordoba.EditValue) * CDbl(Me.txtExistencias.Text)).ToString(RoundP)
        '    txtPVDolar.Text = CDbl(CDbl(Me.txtPVCordoba.EditValue) / CDbl(txtTasaCambio.Text)).ToString(RoundP)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.TextChanged
        'ActualizaMagen()
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

    'Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
    '    If txtCodigo.Text.Trim.Length = 0 Then
    '        XtraMsg("Introduzca el Codigo del Producto.")
    '        txtCodigo.Focus()
    '        Exit Sub
    '    End If

    '    SavedImage("PRODUCTO", txtCodigo.Text)
    '    CargarDocumentos()
    'End Sub

    'Sub CargarDocumentos()
    '    'Cargar Documentos Digitalizados
    '    GridControl1.DataSource = VB.SysContab.ClientesDB.GetImages("PRODUCTO", txtCodigo.Text)
    '    GridView2.Columns("Codigo").Visible = False
    'End Sub

    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
    '    If GridView2.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un Documento!")
    '        Exit Sub
    '    End If

    '    frmSoporteAdd.ID = GridView2.GetFocusedRowCellValue("Codigo")
    '    frmSoporteAdd.StartPosition = FormStartPosition.CenterParent
    '    frmSoporteAdd.ShowDialog()
    '    frmSoporteAdd.Dispose()
    'End Sub

    'Private Sub btnBorrar_Click(sender As Object, e As EventArgs)
    '    If GridView2.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un Documento!")
    '        Exit Sub
    '    End If

    '    If XtraMsg2("Esta Seguro de Borrar el Documento Seleccionado?") Then
    '        VB.SysContab.ClientesDB.DeleteImage(GridView2.GetFocusedRowCellValue("Codigo"))
    '        CargarDocumentos()
    '    End If
    'End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    frmExportarImprimir.Mostrar(GridControl1, "Soportes Digitales, Producto: " & txtNombre.Text)
    'End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs)
    '    If txtCodigo.Text.Trim.Length = 0 Then
    '        XtraMsg("Introduzca el Codigo del Producto.")
    '        txtCodigo.Focus()
    '        Exit Sub
    '    End If
    '    '

    '    SavePDF("PRODUCTO_PDF", txtCodigo.Text)
    '    CargarPDF()

    '    ''buscamos la imagen a grabar
    '    'Dim openDlg As OpenFileDialog = New OpenFileDialog()
    '    'openDlg.Filter = "Files PDF|*.pdf;"
    '    'Dim filter As String = openDlg.Filter
    '    'openDlg.Title = "Open Images Format Files"
    '    'If (openDlg.ShowDialog() = DialogResult.OK) Then
    '    '    PdfViewer1.LoadDocument(openDlg.FileName)
    '    'Else
    '    '    Exit Sub
    '    'End If
    'End Sub

    'Sub CargarPDF()

    '    Dim DT As DataTable = VB.SysContab.ClientesDB.GetImages("PRODUCTO_PDF", txtCodigo.Text)

    '    Try
    '        Dim Data() As Byte
    '        Data = CType(DT.Rows.Item(0)("Documento"), Byte())
    '        Dim stream As New MemoryStream
    '        stream.Write(Data, 0, Data.Length)

    '        PdfViewer1.LoadDocument(stream)
    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
    '    Try
    '        PdfViewer1.Print()
    '    Catch ex As Exception
    '    End Try

    'End Sub

    'Private Sub SimpleButton6_Click(sender As Object, e As EventArgs)
    '    If XtraMsg2("Esta Seguro de Borrar el Documento Seleccionado?") Then
    '        VB.SysContab.ClientesDB.DeletePDF("PRODUCTO_PDF", txtCodigo.Text)
    '        XtraMsg("El Archivo ha sido borrado correctamente....")
    '        PdfViewer1.CloseDocument()
    '    End If
    'End Sub

    Private Sub txtCosto2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCosto2.Validating, txtMargen.Validating
        Try
            txtPrecoio2.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularPrecioVenta(" & txtCosto2.EditValue & "," & txtMargen.EditValue & ") Precio").Rows.Item(0)("Precio")
        Catch ex As Exception
            txtPrecoio2.EditValue = 0.0
        End Try
    End Sub

    Private Sub txtPrecoio2_EditValueChanged(sender As Object, e As EventArgs) Handles txtPrecoio2.EditValueChanged

    End Sub

    Private Sub txtPrecoio2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecoio2.Validating
        'Try
        '    txtMargen.EditValue = ObtieneDatos("SELECT dbo.fn_CalcularMargenVenta(" & txtCosto2.EditValue & "," & txtPrecoio2.EditValue & ") Precio").Rows.Item(0)("Precio")
        'Catch ex As Exception
        '    txtMargen.EditValue = 0.0
        'End Try
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Nuevo = "SI" Then
            XtraMsg("Debe Guardar Primero el Producto...")
            Exit Sub
        End If
        '
        With frmDocumentos
            .Tipo = "PRODUCTO"
            .Codigo = txtCodigo.Text
            .NDocumento = txtNombre.Text
            .Text = "Soporte Digital del Producto: " & txtNombre.Text
            .txtNombre.Text = txtNombre.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub cbUnidad_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbUnidad.ButtonClick
        If e.Button.Index = 1 Then
            With frmUnidadMedidaAdd
                .ID = 0
                .ShowDialog()
                If .Ok = "SI" Then LookUp(cbUnidad, db_UnidadesMedida.Listar(0), "Unidad", "Unidad", "[Seleccion U/M]", 0)
                .Dispose()
            End With
        End If
    End Sub

    Private Sub cbFabricante_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbFabricante.ButtonClick
        If e.Button.Index = 1 Then
            With frmFabricantesAdd
                .ID = 0
                .ShowDialog()
                If .Ok = "SI" Then LookUp(cbFabricante, db_Articulos_Fabricantes.Listar(0), "Nombre", "IdFabricante", "[Fabricante]", 0)
                .Dispose()
            End With

        End If
    End Sub

    Private Sub txtMargen_EditValueChanged(sender As Object, e As EventArgs) Handles txtMargen.EditValueChanged

    End Sub

    Private Sub txtCosto_EditValueChanged(sender As Object, e As EventArgs) Handles txtCosto.EditValueChanged

    End Sub
End Class
