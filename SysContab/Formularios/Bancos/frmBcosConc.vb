Imports DbConnect
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraEditors

Public Class frmBcosConc
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBcosConc = Nothing

    Public Shared Function Instance() As frmBcosConc
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBcosConc
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
    Friend WithEvents dbBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgConciliacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtnoconciliacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_S_Debitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_S_SaldoInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_S_Creditos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_S_SaldoFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_B_SaldoFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_B_Creditos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_B_SaldoInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_B_Debitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAjuste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPeriodos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDiferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHelp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFormato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cEcontrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rgFormato As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents frmBcosConcConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lGroupSistema As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lGroupBanco As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents txtMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbRazonesConciliacion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bNoEncontrados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRevisado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtElaborado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGuardar2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBcosConc))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.cEcontrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dbBancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.frmBcosConcConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtRevisado = New DevExpress.XtraEditors.TextEdit()
        Me.txtElaborado = New DevExpress.XtraEditors.TextEdit()
        Me.bNoEncontrados = New DevExpress.XtraEditors.SimpleButton()
        Me.etMsg = New DevExpress.XtraEditors.LabelControl()
        Me.txtMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.btnCargar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFormato = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDiferencia = New DevExpress.XtraEditors.TextEdit()
        Me.txt_S_SaldoInicial = New DevExpress.XtraEditors.TextEdit()
        Me.txt_S_Debitos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_S_Creditos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_S_SaldoFinal = New DevExpress.XtraEditors.TextEdit()
        Me.rgFormato = New DevExpress.XtraEditors.RadioGroup()
        Me.txtnoconciliacion = New DevExpress.XtraEditors.TextEdit()
        Me.desde = New DevExpress.XtraEditors.DateEdit()
        Me.hasta = New DevExpress.XtraEditors.DateEdit()
        Me.cbPeriodos = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgConciliacion = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbRazonesConciliacion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txt_B_SaldoInicial = New DevExpress.XtraEditors.TextEdit()
        Me.txt_B_Debitos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_B_SaldoFinal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_B_Creditos = New DevExpress.XtraEditors.TextEdit()
        Me.btnImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lGroupSistema = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lGroupBanco = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnGuardar2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecalcular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHelp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnComp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAjuste = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.dbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmBcosConcConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBcosConcConvertedLayout.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRevisado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_SaldoInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_Debitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_Creditos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_S_SaldoFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnoconciliacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgConciliacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRazonesConciliacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_B_SaldoInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_B_Debitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_B_SaldoFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_B_Creditos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lGroupSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lGroupBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cEcontrado
        '
        Me.cEcontrado.Caption = "Encontrado?"
        Me.cEcontrado.FieldName = "Encontrado"
        Me.cEcontrado.Name = "cEcontrado"
        Me.cEcontrado.OptionsColumn.AllowEdit = False
        Me.cEcontrado.Visible = True
        Me.cEcontrado.VisibleIndex = 9
        '
        'dbBancos
        '
        Me.dbBancos.Location = New System.Drawing.Point(98, 42)
        Me.dbBancos.Name = "dbBancos"
        Me.dbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dbBancos.Properties.NullText = ""
        Me.dbBancos.Properties.ShowFooter = False
        Me.dbBancos.Properties.ShowHeader = False
        Me.dbBancos.Size = New System.Drawing.Size(925, 20)
        Me.dbBancos.StyleController = Me.frmBcosConcConvertedLayout
        Me.dbBancos.TabIndex = 0
        '
        'frmBcosConcConvertedLayout
        '
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.CheckEdit1)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txtRevisado)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txtElaborado)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.bNoEncontrados)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.etMsg)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txtMoneda)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.btnCargar)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.btnFormato)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txtDiferencia)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_S_SaldoInicial)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_S_Debitos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_S_Creditos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_S_SaldoFinal)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.rgFormato)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txtnoconciliacion)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.desde)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.dbBancos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.hasta)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.cbPeriodos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.dgConciliacion)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_B_SaldoInicial)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_B_Debitos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_B_SaldoFinal)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.txt_B_Creditos)
        Me.frmBcosConcConvertedLayout.Controls.Add(Me.btnImportar)
        Me.frmBcosConcConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmBcosConcConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmBcosConcConvertedLayout.Name = "frmBcosConcConvertedLayout"
        Me.frmBcosConcConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1353, 404, 250, 350)
        Me.frmBcosConcConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmBcosConcConvertedLayout.Size = New System.Drawing.Size(1047, 512)
        Me.frmBcosConcConvertedLayout.TabIndex = 43
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(954, 253)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Todo"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(69, 22)
        Me.CheckEdit1.StyleController = Me.frmBcosConcConvertedLayout
        Me.CheckEdit1.TabIndex = 47
        '
        'txtRevisado
        '
        Me.txtRevisado.Location = New System.Drawing.Point(860, 227)
        Me.txtRevisado.Name = "txtRevisado"
        Me.txtRevisado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRevisado.Properties.Appearance.Options.UseFont = True
        Me.txtRevisado.Size = New System.Drawing.Size(163, 22)
        Me.txtRevisado.StyleController = Me.frmBcosConcConvertedLayout
        Me.txtRevisado.TabIndex = 46
        '
        'txtElaborado
        '
        Me.txtElaborado.Location = New System.Drawing.Point(860, 201)
        Me.txtElaborado.Name = "txtElaborado"
        Me.txtElaborado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElaborado.Properties.Appearance.Options.UseFont = True
        Me.txtElaborado.Size = New System.Drawing.Size(163, 22)
        Me.txtElaborado.StyleController = Me.frmBcosConcConvertedLayout
        Me.txtElaborado.TabIndex = 45
        '
        'bNoEncontrados
        '
        Me.bNoEncontrados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bNoEncontrados.Appearance.Options.UseTextOptions = True
        Me.bNoEncontrados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bNoEncontrados.ImageOptions.Image = CType(resources.GetObject("bNoEncontrados.ImageOptions.Image"), System.Drawing.Image)
        Me.bNoEncontrados.Location = New System.Drawing.Point(632, 158)
        Me.bNoEncontrados.Name = "bNoEncontrados"
        Me.bNoEncontrados.Size = New System.Drawing.Size(126, 38)
        Me.bNoEncontrados.StyleController = Me.frmBcosConcConvertedLayout
        Me.bNoEncontrados.TabIndex = 44
        Me.bNoEncontrados.Text = "&Ver No Encontrados"
        Me.bNoEncontrados.ToolTip = "Ajuste Por Deslizamiento de Moneda"
        '
        'etMsg
        '
        Me.etMsg.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMsg.Appearance.ForeColor = System.Drawing.Color.Red
        Me.etMsg.Appearance.Options.UseFont = True
        Me.etMsg.Appearance.Options.UseForeColor = True
        Me.etMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etMsg.Location = New System.Drawing.Point(786, 184)
        Me.etMsg.Name = "etMsg"
        Me.etMsg.Size = New System.Drawing.Size(237, 13)
        Me.etMsg.StyleController = Me.frmBcosConcConvertedLayout
        Me.etMsg.TabIndex = 44
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(521, 66)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtMoneda.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMoneda.Properties.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(236, 20)
        Me.txtMoneda.StyleController = Me.frmBcosConcConvertedLayout
        Me.txtMoneda.TabIndex = 43
        '
        'btnCargar
        '
        Me.btnCargar.Appearance.Options.UseTextOptions = True
        Me.btnCargar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCargar.ImageOptions.Image = CType(resources.GetObject("btnCargar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCargar.Location = New System.Drawing.Point(255, 158)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(117, 38)
        Me.btnCargar.StyleController = Me.frmBcosConcConvertedLayout
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "&Cargar Datos"
        Me.btnCargar.ToolTip = "Cargar Datos"
        '
        'btnFormato
        '
        Me.btnFormato.Appearance.Options.UseTextOptions = True
        Me.btnFormato.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnFormato.ImageOptions.Image = CType(resources.GetObject("btnFormato.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFormato.Location = New System.Drawing.Point(904, 66)
        Me.btnFormato.Name = "btnFormato"
        Me.btnFormato.Size = New System.Drawing.Size(119, 46)
        Me.btnFormato.StyleController = Me.frmBcosConcConvertedLayout
        Me.btnFormato.TabIndex = 2
        Me.btnFormato.Text = "&Ver Formato"
        Me.btnFormato.ToolTip = "Ver Formato para Importar Datos"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiferencia.Location = New System.Drawing.Point(860, 158)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtDiferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDiferencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtDiferencia.Properties.Appearance.Options.UseFont = True
        Me.txtDiferencia.Properties.Appearance.Options.UseForeColor = True
        Me.txtDiferencia.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDiferencia.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDiferencia.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDiferencia.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtDiferencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiferencia.Properties.Mask.EditMask = "n2"
        Me.txtDiferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDiferencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiferencia.Properties.ReadOnly = True
        Me.txtDiferencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiferencia.Size = New System.Drawing.Size(163, 22)
        Me.txtDiferencia.StyleController = Me.frmBcosConcConvertedLayout
        Me.txtDiferencia.TabIndex = 3
        '
        'txt_S_SaldoInicial
        '
        Me.txt_S_SaldoInicial.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_S_SaldoInicial.Location = New System.Drawing.Point(98, 158)
        Me.txt_S_SaldoInicial.Name = "txt_S_SaldoInicial"
        Me.txt_S_SaldoInicial.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txt_S_SaldoInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_SaldoInicial.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_S_SaldoInicial.Properties.Appearance.Options.UseBackColor = True
        Me.txt_S_SaldoInicial.Properties.Appearance.Options.UseFont = True
        Me.txt_S_SaldoInicial.Properties.Appearance.Options.UseForeColor = True
        Me.txt_S_SaldoInicial.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_SaldoInicial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_S_SaldoInicial.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_S_SaldoInicial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_S_SaldoInicial.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_S_SaldoInicial.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_S_SaldoInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_S_SaldoInicial.Properties.Mask.EditMask = "n2"
        Me.txt_S_SaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_S_SaldoInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_S_SaldoInicial.Properties.ReadOnly = True
        Me.txt_S_SaldoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_S_SaldoInicial.Size = New System.Drawing.Size(153, 22)
        Me.txt_S_SaldoInicial.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_S_SaldoInicial.TabIndex = 0
        '
        'txt_S_Debitos
        '
        Me.txt_S_Debitos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_S_Debitos.Location = New System.Drawing.Point(98, 184)
        Me.txt_S_Debitos.Name = "txt_S_Debitos"
        Me.txt_S_Debitos.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txt_S_Debitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_Debitos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_S_Debitos.Properties.Appearance.Options.UseBackColor = True
        Me.txt_S_Debitos.Properties.Appearance.Options.UseFont = True
        Me.txt_S_Debitos.Properties.Appearance.Options.UseForeColor = True
        Me.txt_S_Debitos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_Debitos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_S_Debitos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_S_Debitos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_S_Debitos.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_S_Debitos.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_S_Debitos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_S_Debitos.Properties.Mask.EditMask = "n2"
        Me.txt_S_Debitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_S_Debitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_S_Debitos.Properties.ReadOnly = True
        Me.txt_S_Debitos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_S_Debitos.Size = New System.Drawing.Size(153, 22)
        Me.txt_S_Debitos.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_S_Debitos.TabIndex = 1
        '
        'txt_S_Creditos
        '
        Me.txt_S_Creditos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_S_Creditos.Location = New System.Drawing.Point(98, 210)
        Me.txt_S_Creditos.Name = "txt_S_Creditos"
        Me.txt_S_Creditos.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txt_S_Creditos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_Creditos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_S_Creditos.Properties.Appearance.Options.UseBackColor = True
        Me.txt_S_Creditos.Properties.Appearance.Options.UseFont = True
        Me.txt_S_Creditos.Properties.Appearance.Options.UseForeColor = True
        Me.txt_S_Creditos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_Creditos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_S_Creditos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_S_Creditos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_S_Creditos.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_S_Creditos.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_S_Creditos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_S_Creditos.Properties.Mask.EditMask = "n2"
        Me.txt_S_Creditos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_S_Creditos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_S_Creditos.Properties.ReadOnly = True
        Me.txt_S_Creditos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_S_Creditos.Size = New System.Drawing.Size(153, 22)
        Me.txt_S_Creditos.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_S_Creditos.TabIndex = 2
        '
        'txt_S_SaldoFinal
        '
        Me.txt_S_SaldoFinal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_S_SaldoFinal.Location = New System.Drawing.Point(98, 236)
        Me.txt_S_SaldoFinal.Name = "txt_S_SaldoFinal"
        Me.txt_S_SaldoFinal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txt_S_SaldoFinal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_SaldoFinal.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_S_SaldoFinal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_S_SaldoFinal.Properties.Appearance.Options.UseFont = True
        Me.txt_S_SaldoFinal.Properties.Appearance.Options.UseForeColor = True
        Me.txt_S_SaldoFinal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_S_SaldoFinal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_S_SaldoFinal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_S_SaldoFinal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_S_SaldoFinal.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_S_SaldoFinal.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_S_SaldoFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_S_SaldoFinal.Properties.Mask.EditMask = "n2"
        Me.txt_S_SaldoFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_S_SaldoFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_S_SaldoFinal.Properties.ReadOnly = True
        Me.txt_S_SaldoFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_S_SaldoFinal.Size = New System.Drawing.Size(153, 22)
        Me.txt_S_SaldoFinal.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_S_SaldoFinal.TabIndex = 3
        '
        'rgFormato
        '
        Me.rgFormato.EditValue = 2
        Me.rgFormato.Location = New System.Drawing.Point(761, 66)
        Me.rgFormato.Name = "rgFormato"
        Me.rgFormato.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgFormato.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgFormato.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.rgFormato.Properties.Appearance.Options.UseBackColor = True
        Me.rgFormato.Properties.Appearance.Options.UseFont = True
        Me.rgFormato.Properties.Appearance.Options.UseForeColor = True
        Me.rgFormato.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Formato 1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Formato 2")})
        Me.rgFormato.Size = New System.Drawing.Size(139, 46)
        Me.rgFormato.StyleController = Me.frmBcosConcConvertedLayout
        Me.rgFormato.TabIndex = 25
        '
        'txtnoconciliacion
        '
        Me.txtnoconciliacion.Enabled = False
        Me.txtnoconciliacion.Location = New System.Drawing.Point(98, 90)
        Me.txtnoconciliacion.Name = "txtnoconciliacion"
        Me.txtnoconciliacion.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtnoconciliacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoconciliacion.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtnoconciliacion.Properties.Appearance.Options.UseBackColor = True
        Me.txtnoconciliacion.Properties.Appearance.Options.UseFont = True
        Me.txtnoconciliacion.Properties.Appearance.Options.UseForeColor = True
        Me.txtnoconciliacion.Size = New System.Drawing.Size(134, 22)
        Me.txtnoconciliacion.StyleController = Me.frmBcosConcConvertedLayout
        Me.txtnoconciliacion.TabIndex = 4
        '
        'desde
        '
        Me.desde.EditValue = Nothing
        Me.desde.Location = New System.Drawing.Point(98, 66)
        Me.desde.Name = "desde"
        Me.desde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desde.Properties.Appearance.Options.UseFont = True
        Me.desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.desde.Size = New System.Drawing.Size(134, 20)
        Me.desde.StyleController = Me.frmBcosConcConvertedLayout
        Me.desde.TabIndex = 2
        '
        'hasta
        '
        Me.hasta.EditValue = Nothing
        Me.hasta.Location = New System.Drawing.Point(310, 66)
        Me.hasta.Name = "hasta"
        Me.hasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasta.Properties.Appearance.Options.UseFont = True
        Me.hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.hasta.Size = New System.Drawing.Size(133, 20)
        Me.hasta.StyleController = Me.frmBcosConcConvertedLayout
        Me.hasta.TabIndex = 3
        '
        'cbPeriodos
        '
        Me.cbPeriodos.Location = New System.Drawing.Point(310, 90)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Properties.Appearance.Options.UseFont = True
        Me.cbPeriodos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodos.Properties.NullText = ""
        Me.cbPeriodos.Properties.ShowFooter = False
        Me.cbPeriodos.Properties.ShowHeader = False
        Me.cbPeriodos.Size = New System.Drawing.Size(447, 20)
        Me.cbPeriodos.StyleController = Me.frmBcosConcConvertedLayout
        Me.cbPeriodos.TabIndex = 5
        '
        'dgConciliacion
        '
        Me.dgConciliacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConciliacion.Location = New System.Drawing.Point(12, 291)
        Me.dgConciliacion.MainView = Me.Vista
        Me.dgConciliacion.Name = "dgConciliacion"
        Me.dgConciliacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbRazonesConciliacion})
        Me.dgConciliacion.Size = New System.Drawing.Size(1023, 209)
        Me.dgConciliacion.TabIndex = 5
        Me.dgConciliacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vista.Appearance.HeaderPanel.Options.UseFont = True
        Me.Vista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.Vista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Vista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.cEcontrado})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.cEcontrado
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition1.Value2 = True
        Me.Vista.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.Vista.GridControl = Me.dgConciliacion
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsCustomization.AllowColumnMoving = False
        Me.Vista.OptionsCustomization.AllowFilter = False
        Me.Vista.OptionsCustomization.AllowGroup = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ID"
        Me.GridColumn5.FieldName = "ID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Comprobante"
        Me.GridColumn1.FieldName = "No Comp"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Abreviatura"
        Me.GridColumn3.FieldName = "Abrev"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Documento"
        Me.GridColumn4.FieldName = "Documento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Concepto"
        Me.GridColumn6.FieldName = "Concepto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Débito"
        Me.GridColumn7.FieldName = "Débito"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Crédito"
        Me.GridColumn8.FieldName = "Crédito"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Conciliar"
        Me.GridColumn9.FieldName = "Conciliar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Razón"
        Me.GridColumn10.ColumnEdit = Me.cbRazonesConciliacion
        Me.GridColumn10.FieldName = "IdRazon"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'cbRazonesConciliacion
        '
        Me.cbRazonesConciliacion.AutoHeight = False
        ToolTipTitleItem1.Text = "Borrar Razón"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        ToolTipTitleItem2.Text = "Modificar Razón"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        ToolTipTitleItem3.Text = "Agregar Razón"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        Me.cbRazonesConciliacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, SuperToolTip2), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, SuperToolTip3)})
        Me.cbRazonesConciliacion.Name = "cbRazonesConciliacion"
        Me.cbRazonesConciliacion.NullText = ""
        Me.cbRazonesConciliacion.ShowFooter = False
        Me.cbRazonesConciliacion.ShowHeader = False
        '
        'txt_B_SaldoInicial
        '
        Me.txt_B_SaldoInicial.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_B_SaldoInicial.Location = New System.Drawing.Point(474, 158)
        Me.txt_B_SaldoInicial.Name = "txt_B_SaldoInicial"
        Me.txt_B_SaldoInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_SaldoInicial.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_B_SaldoInicial.Properties.Appearance.Options.UseFont = True
        Me.txt_B_SaldoInicial.Properties.Appearance.Options.UseForeColor = True
        Me.txt_B_SaldoInicial.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_SaldoInicial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_B_SaldoInicial.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_B_SaldoInicial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_B_SaldoInicial.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_B_SaldoInicial.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_B_SaldoInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_B_SaldoInicial.Properties.Mask.EditMask = "n2"
        Me.txt_B_SaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_B_SaldoInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_B_SaldoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_B_SaldoInicial.Size = New System.Drawing.Size(154, 22)
        Me.txt_B_SaldoInicial.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_B_SaldoInicial.TabIndex = 0
        '
        'txt_B_Debitos
        '
        Me.txt_B_Debitos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_B_Debitos.Location = New System.Drawing.Point(474, 184)
        Me.txt_B_Debitos.Name = "txt_B_Debitos"
        Me.txt_B_Debitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_Debitos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_B_Debitos.Properties.Appearance.Options.UseFont = True
        Me.txt_B_Debitos.Properties.Appearance.Options.UseForeColor = True
        Me.txt_B_Debitos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_Debitos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_B_Debitos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_B_Debitos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_B_Debitos.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_B_Debitos.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_B_Debitos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_B_Debitos.Properties.Mask.EditMask = "n2"
        Me.txt_B_Debitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_B_Debitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_B_Debitos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_B_Debitos.Size = New System.Drawing.Size(154, 22)
        Me.txt_B_Debitos.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_B_Debitos.TabIndex = 1
        '
        'txt_B_SaldoFinal
        '
        Me.txt_B_SaldoFinal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_B_SaldoFinal.Location = New System.Drawing.Point(474, 236)
        Me.txt_B_SaldoFinal.Name = "txt_B_SaldoFinal"
        Me.txt_B_SaldoFinal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_SaldoFinal.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_B_SaldoFinal.Properties.Appearance.Options.UseFont = True
        Me.txt_B_SaldoFinal.Properties.Appearance.Options.UseForeColor = True
        Me.txt_B_SaldoFinal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_SaldoFinal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_B_SaldoFinal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_B_SaldoFinal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_B_SaldoFinal.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_B_SaldoFinal.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_B_SaldoFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_B_SaldoFinal.Properties.Mask.EditMask = "n2"
        Me.txt_B_SaldoFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_B_SaldoFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_B_SaldoFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_B_SaldoFinal.Size = New System.Drawing.Size(154, 22)
        Me.txt_B_SaldoFinal.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_B_SaldoFinal.TabIndex = 3
        '
        'txt_B_Creditos
        '
        Me.txt_B_Creditos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_B_Creditos.Location = New System.Drawing.Point(474, 210)
        Me.txt_B_Creditos.Name = "txt_B_Creditos"
        Me.txt_B_Creditos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_Creditos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_B_Creditos.Properties.Appearance.Options.UseFont = True
        Me.txt_B_Creditos.Properties.Appearance.Options.UseForeColor = True
        Me.txt_B_Creditos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B_Creditos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_B_Creditos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txt_B_Creditos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_B_Creditos.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txt_B_Creditos.Properties.DisplayFormat.FormatString = "{0:n2}"
        Me.txt_B_Creditos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_B_Creditos.Properties.Mask.EditMask = "n2"
        Me.txt_B_Creditos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_B_Creditos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_B_Creditos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_B_Creditos.Size = New System.Drawing.Size(154, 22)
        Me.txt_B_Creditos.StyleController = Me.frmBcosConcConvertedLayout
        Me.txt_B_Creditos.TabIndex = 2
        '
        'btnImportar
        '
        Me.btnImportar.Appearance.Options.UseTextOptions = True
        Me.btnImportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImportar.ImageOptions.Image = CType(resources.GetObject("btnImportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImportar.Location = New System.Drawing.Point(632, 200)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(126, 38)
        Me.btnImportar.StyleController = Me.frmBcosConcConvertedLayout
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.Text = "&Importar Datos"
        Me.btnImportar.ToolTip = "Importar Datos"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lGroupSistema, Me.LayoutControlGroup4, Me.LayoutControlItem5, Me.lGroupBanco, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1047, 512)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lGroupSistema
        '
        Me.lGroupSistema.CustomizationFormText = "SEGUN SISTEMA"
        Me.lGroupSistema.ExpandButtonVisible = True
        Me.lGroupSistema.ExpandOnDoubleClick = True
        Me.lGroupSistema.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem24, Me.EmptySpaceItem8})
        Me.lGroupSistema.Location = New System.Drawing.Point(0, 116)
        Me.lGroupSistema.Name = "lGroupSistema"
        Me.lGroupSistema.Size = New System.Drawing.Size(376, 163)
        Me.lGroupSistema.Text = "SEGUN SISTEMA"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_S_SaldoInicial
        Me.LayoutControlItem6.CustomizationFormText = "Saldo Inicial:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem6.Name = "txt_S_SaldoInicialitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Saldo Inicial:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_S_Debitos
        Me.LayoutControlItem7.CustomizationFormText = "Débitos:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem7.Name = "txt_S_Debitositem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Débitos:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txt_S_Creditos
        Me.LayoutControlItem8.CustomizationFormText = "Créditos:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem8.Name = "txt_S_Creditositem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Créditos:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txt_S_SaldoFinal
        Me.LayoutControlItem9.CustomizationFormText = "Saldo Final:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(231, 26)
        Me.LayoutControlItem9.Name = "txt_S_SaldoFinalitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(231, 43)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Saldo Final:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.btnCargar
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(231, 0)
        Me.LayoutControlItem24.MaxSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem24.MinSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(231, 42)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(121, 79)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "DESCRIPCION GENERAL"
        Me.LayoutControlGroup4.ExpandButtonVisible = True
        Me.LayoutControlGroup4.ExpandOnDoubleClick = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem26, Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "GroupControl1item"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1027, 116)
        Me.LayoutControlGroup4.Text = "DESCRIPCION GENERAL"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.rgFormato
        Me.LayoutControlItem12.CustomizationFormText = "MONEDA BANCO:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(737, 24)
        Me.LayoutControlItem12.Name = "rgFormatoitem"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(143, 50)
        Me.LayoutControlItem12.Text = "MONEDA BANCO:"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtnoconciliacion
        Me.LayoutControlItem13.CustomizationFormText = "#Conciliación:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem13.Name = "txtnoconciliacionitem"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(212, 26)
        Me.LayoutControlItem13.Text = "#Conciliación:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.desde
        Me.LayoutControlItem15.CustomizationFormText = "Desde:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem15.Name = "desdeitem"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(212, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Desde:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.dbBancos
        Me.LayoutControlItem16.CustomizationFormText = "Bancos:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.Name = "dbBancositem"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(1003, 24)
        Me.LayoutControlItem16.Text = "Bancos:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.hasta
        Me.LayoutControlItem17.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(212, 24)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem17.Name = "hastaitem"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Hasta:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbPeriodos
        Me.LayoutControlItem18.CustomizationFormText = "Periodo:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(212, 48)
        Me.LayoutControlItem18.Name = "cbPeriodositem"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(525, 26)
        Me.LayoutControlItem18.Text = "Periodo:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.btnFormato
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(880, 24)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(123, 50)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(123, 50)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(123, 50)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtMoneda
        Me.LayoutControlItem1.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(423, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(314, 24)
        Me.LayoutControlItem1.Text = "Moneda:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dgConciliacion
        Me.LayoutControlItem5.CustomizationFormText = "dgConciliacionitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 279)
        Me.LayoutControlItem5.Name = "dgConciliacionitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1027, 213)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'lGroupBanco
        '
        Me.lGroupBanco.CustomizationFormText = "SEGUN BANCO (BANCANET)"
        Me.lGroupBanco.ExpandButtonVisible = True
        Me.lGroupBanco.ExpandOnDoubleClick = True
        Me.lGroupBanco.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem14, Me.EmptySpaceItem7})
        Me.lGroupBanco.Location = New System.Drawing.Point(376, 116)
        Me.lGroupBanco.Name = "lGroupBanco"
        Me.lGroupBanco.Size = New System.Drawing.Size(386, 163)
        Me.lGroupBanco.Text = "SEGUN BANCO (BANCANET)"
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txt_B_SaldoInicial
        Me.LayoutControlItem19.CustomizationFormText = "Saldo Inicial:"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem19.Name = "txt_B_SaldoInicialitem"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Saldo Inicial:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txt_B_Debitos
        Me.LayoutControlItem20.CustomizationFormText = "Débitos:"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem20.Name = "txt_B_Debitositem"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "Débitos:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txt_B_SaldoFinal
        Me.LayoutControlItem21.CustomizationFormText = "Saldo Final:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem21.Name = "txt_B_SaldoFinalitem"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(232, 43)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "Saldo Final:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txt_B_Creditos
        Me.LayoutControlItem22.CustomizationFormText = "Créditos:"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem22.Name = "txt_B_Creditositem"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(232, 26)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "Créditos:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.btnImportar
        Me.LayoutControlItem23.CustomizationFormText = "btnImportaritem"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(232, 42)
        Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem23.MinSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem23.Name = "btnImportaritem"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bNoEncontrados
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(232, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(232, 84)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(130, 37)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "DIFERENCIA"
        Me.LayoutControlGroup2.ExpandButtonVisible = True
        Me.LayoutControlGroup2.ExpandOnDoubleClick = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.EmptySpaceItem2, Me.LayoutControlItem33})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(762, 116)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(265, 163)
        Me.LayoutControlGroup2.Text = "DIFERENCIA"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.etMsg
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(241, 17)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDiferencia
        Me.LayoutControlItem2.CustomizationFormText = "Diferencia:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "txtDiferenciaitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem2.Text = "Diferencia:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtElaborado
        Me.LayoutControlItem31.CustomizationFormText = "Elaborado por:"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 43)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem31.Text = "Elaborado por:"
        Me.LayoutControlItem31.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txtRevisado
        Me.LayoutControlItem32.CustomizationFormText = "Revisado por:"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 69)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(241, 26)
        Me.LayoutControlItem32.Text = "Revisado por:"
        Me.LayoutControlItem32.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(71, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 95)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(168, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.CheckEdit1
        Me.LayoutControlItem33.Location = New System.Drawing.Point(168, 95)
        Me.LayoutControlItem33.MaxSize = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem33.MinSize = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(73, 26)
        Me.LayoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Options.UseTextOptions = True
        Me.btnQuit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnQuit.ImageOptions.Image = CType(resources.GetObject("btnQuit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(12, 418)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(118, 38)
        Me.btnQuit.StyleController = Me.LayoutControl1
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnGuardar2)
        Me.LayoutControl1.Controls.Add(Me.btnGuardar)
        Me.LayoutControl1.Controls.Add(Me.btnRecalcular)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.btnQuit)
        Me.LayoutControl1.Controls.Add(Me.btnHelp)
        Me.LayoutControl1.Controls.Add(Me.btnComp)
        Me.LayoutControl1.Controls.Add(Me.btnAjuste)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem29})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1374, 175, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup5
        Me.LayoutControl1.Size = New System.Drawing.Size(141, 485)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnGuardar2
        '
        Me.btnGuardar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar2.Appearance.Options.UseTextOptions = True
        Me.btnGuardar2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar2.ImageOptions.Image = CType(resources.GetObject("btnGuardar2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar2.Location = New System.Drawing.Point(12, 54)
        Me.btnGuardar2.Name = "btnGuardar2"
        Me.btnGuardar2.Size = New System.Drawing.Size(118, 38)
        Me.btnGuardar2.StyleController = Me.LayoutControl1
        Me.btnGuardar2.TabIndex = 45
        Me.btnGuardar2.Text = "Guardar y &Finalizar"
        Me.btnGuardar2.ToolTip = "Guardar Conciliación Bancaria"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(12, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 38)
        Me.btnGuardar.StyleController = Me.LayoutControl1
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.ToolTip = "Guardar Conciliación Bancaria"
        '
        'btnRecalcular
        '
        Me.btnRecalcular.Appearance.Options.UseTextOptions = True
        Me.btnRecalcular.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnRecalcular.ImageOptions.Image = CType(resources.GetObject("btnRecalcular.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecalcular.Location = New System.Drawing.Point(12, 96)
        Me.btnRecalcular.Name = "btnRecalcular"
        Me.btnRecalcular.Size = New System.Drawing.Size(118, 38)
        Me.btnRecalcular.StyleController = Me.LayoutControl1
        Me.btnRecalcular.TabIndex = 3
        Me.btnRecalcular.Text = "&Recalcular"
        Me.btnRecalcular.ToolTip = "Importar Datos"
        '
        'btnExportar
        '
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 376)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(118, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "&Exportar"
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Appearance.Options.UseTextOptions = True
        Me.btnHelp.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnHelp.Location = New System.Drawing.Point(12, 408)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(118, 22)
        Me.btnHelp.StyleController = Me.LayoutControl1
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "&Ayuda"
        '
        'btnComp
        '
        Me.btnComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComp.Appearance.Options.UseTextOptions = True
        Me.btnComp.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnComp.ImageOptions.Image = CType(resources.GetObject("btnComp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnComp.Location = New System.Drawing.Point(12, 138)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(118, 38)
        Me.btnComp.StyleController = Me.LayoutControl1
        Me.btnComp.TabIndex = 0
        Me.btnComp.Text = "&Ajustes"
        Me.btnComp.ToolTip = "Ajustes Conciliación Bancaria"
        '
        'btnAjuste
        '
        Me.btnAjuste.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjuste.Appearance.Options.UseTextOptions = True
        Me.btnAjuste.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAjuste.ImageOptions.Image = CType(resources.GetObject("btnAjuste.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAjuste.Location = New System.Drawing.Point(12, 180)
        Me.btnAjuste.Name = "btnAjuste"
        Me.btnAjuste.Size = New System.Drawing.Size(118, 38)
        Me.btnAjuste.StyleController = Me.LayoutControl1
        Me.btnAjuste.TabIndex = 1
        Me.btnAjuste.Text = "&Deslizamiento Moneda"
        Me.btnAjuste.ToolTip = "Ajuste Por Deslizamiento de Moneda"
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.btnHelp
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 396)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(122, 26)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        Me.LayoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem28, Me.LayoutControlItem27, Me.LayoutControlItem30, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.LayoutControlItem25, Me.EmptySpaceItem3, Me.LayoutControlItem3})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "Root"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(142, 468)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.btnGuardar
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.btnRecalcular
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.btnQuit
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 406)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnComp
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnAjuste
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.btnExportar
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 364)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(122, 154)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnGuardar2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("23b39120-6439-4588-a4c1-4d50f2bd3c77")
        Me.DockPanel1.Location = New System.Drawing.Point(1047, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 512)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 485)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmBcosConc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1197, 512)
        Me.Controls.Add(Me.frmBcosConcConvertedLayout)
        Me.Controls.Add(Me.DockPanel1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmBcosConc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliación Bancaria"
        CType(Me.dbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmBcosConcConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBcosConcConvertedLayout.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRevisado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElaborado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_SaldoInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_Debitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_Creditos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_S_SaldoFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnoconciliacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgConciliacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRazonesConciliacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_B_SaldoInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_B_Debitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_B_SaldoFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_B_Creditos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lGroupSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lGroupBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Private DetalleBanco As New VB.SysContab.BancosDetails
    Private DetalleCBanco As DataSet
    Private DetalleEmpresa As New VB.SysContab.EmpresasDetails
    Private DSSistema As DataTable      'DataTable con Movimientos en el Sistema
    Private DSBanco As DataSet          'DataSet con los Movimientos segun banco
    Private NombreFile As String = ""
    Private DB As New VB.SysContab.ConciliacionBancariaDB
    Private Periodos As New VB.SysContab.PeriodosDB
    Private Comp As New VB.SysContab.ComprobanteDB

    Dim DT_DATOS As DataTable 'Carga Movimientos Contables
    Dim DT As DataTable 'Carga el Archivo de Excel (BANCANET)

    Dim DT_NOENCONTRADOS As DataTable
    Public IdConciliacion As Integer = 0
#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmBcosConc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = Rutinas.Fecha().Date
        '
        desde.EditValue = New DateTime(f.Year, f.Month, 1)
        hasta.EditValue = UltimoDiaDelMes(f.Date).Date

        Me.Cargar_Bancos()
        ''Me.Cargar_Cuentas_Banco()

        Me.cbPeriodos.Properties.DataSource = Periodos.GetList().Tables("Periodos")
        Me.cbPeriodos.Properties.ValueMember = "codigo"
        Me.cbPeriodos.Properties.DisplayMember = "descripcion"
        Me.cbPeriodos.Properties.PopulateColumns()

        Me.cbPeriodos.Properties.Columns(0).Visible = False
        Me.cbPeriodos.Properties.Columns(2).Visible = False
        Me.cbPeriodos.Properties.Columns(3).Visible = False
        Me.cbPeriodos.Properties.Columns(4).Visible = False
        Me.cbPeriodos.Properties.Columns(5).Visible = False

        Me.cbPeriodos.EditValue = CInt(PeriodosDB.Activo(f.Date))
        FechasPeriodo()

        If IdConciliacion = 0 Then
            txtnoconciliacion.Text = DB.CB_Nvo()
        Else
            Dim DT_CONCI As DataTable = ObtieneDatos("JAR_GetConciliacion",
                                                     IdConciliacion,
                                                     EmpresaActual)

            If DT_CONCI.Rows.Count > 0 Then
                dbBancos.EditValue = DT_CONCI.Rows.Item(0)("Banco")
                cbPeriodos.EditValue = DT_CONCI.Rows.Item(0)("Per_Id")
                desde.DateTime = DT_CONCI.Rows.Item(0)("Desde")
                hasta.DateTime = DT_CONCI.Rows.Item(0)("Hasta")
                txtnoconciliacion.Text = DT_CONCI.Rows.Item(0)("cb_codigo")
                txtElaborado.Text = DT_CONCI.Rows.Item(0)("Elaborado_por")
                txtRevisado.Text = DT_CONCI.Rows.Item(0)("Revisado_por")

                txt_S_SaldoInicial.EditValue = DT_CONCI.Rows.Item(0)("cb_saldoanterior")
                txt_S_Debitos.EditValue = DT_CONCI.Rows.Item(0)("cb_debitos")
                txt_S_Creditos.EditValue = DT_CONCI.Rows.Item(0)("cb_creditos")
                txt_S_SaldoFinal.EditValue = DT_CONCI.Rows.Item(0)("cb_saldo")

                txt_B_SaldoInicial.EditValue = DT_CONCI.Rows.Item(0)("cb_saldoanteriorbco")
                txt_B_Debitos.EditValue = DT_CONCI.Rows.Item(0)("cb_debitosbco")
                txt_B_Creditos.EditValue = DT_CONCI.Rows.Item(0)("cb_creditosbco")
                txt_B_SaldoFinal.EditValue = DT_CONCI.Rows.Item(0)("cb_saldobco")

                dbBancos.Properties.ReadOnly = True
                cbPeriodos.Properties.ReadOnly = True
                desde.Properties.ReadOnly = True
                hasta.Properties.ReadOnly = True

                'CargarDatosEditar()

                btnGuardar.Enabled = Not DT_CONCI.Rows.Item(0)("Estado")
                btnGuardar2.Enabled = Not DT_CONCI.Rows.Item(0)("Estado")

                ComboRazones()
                CargarDatos()
                ReCalcular()
            End If
        End If


        Me.rgFormato.EditValue = 2
        '--------------------------------------------------------------------------------------
        DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        '--------------------------------------------------------------------------------------
    End Sub

    Public Sub Cargar_Bancos()
        dbBancos.Properties.DataSource = ObtieneDatos("JAR_CatalogoBancos", EmpresaActual)
        'dbBancos.Properties.DataSource = ObtieneDatos("Select Codigo, Nombre + ' - ' + isnull((SELECT c.NOMBRE FROM CATALOGO c WHERE c.CUENTA = Bancos.CUENTA AND c.EMPRESA = Bancos.EMPRESA),'') Nombre," _
        '+ " Cuenta From Bancos Where Empresa = " & EmpresaActual & " and Activo = 1")

        dbBancos.Properties.DisplayMember = "Display"
        dbBancos.Properties.ValueMember = "Codigo"
        dbBancos.Properties.PopulateColumns()

        dbBancos.Properties.Columns("Codigo").Visible = False
        dbBancos.Properties.Columns("MonCod").Visible = False
        dbBancos.Properties.Columns("Display").Visible = False
        dbBancos.EditValue = IIf(dbBancos.Properties.DataSource.rows.count = 0, "Vacio", dbBancos.Properties.DataSource.rows(0)("Codigo"))

        Registro = dbBancos.EditValue
        DetalleBanco = BancosDB.GetDetails(Registro)

        '' Obtener Detalle del Catalogo Banco
        DetalleCBanco = Catalogo_BancosDB.GetList(Registro)   '.GetListNuevo(Registro, CatalogoBancosP)
    End Sub

    'Public Sub Cargar_Cuentas_Banco()
    '    Try
    '        dbCatalogoBancos.Properties.DataSource = VB.SysContab.Catalogo_BancosDB.GetList(dbBancos.EditValue).Tables("CATALOGO_BANCOS")
    '        dbCatalogoBancos.Properties.DisplayMember = "Display"
    '        dbCatalogoBancos.Properties.ValueMember = "Codigo"
    '        dbCatalogoBancos.Properties.PopulateColumns()

    '        dbCatalogoBancos.Properties.Columns("Codigo").Visible = False
    '        dbCatalogoBancos.Properties.Columns("Formato").Visible = False
    '        dbCatalogoBancos.Properties.Columns("Display").Visible = False

    '        dbCatalogoBancos.EditValue = IIf(dbCatalogoBancos.Properties.DataSource.rows.count = 0, "Vacio", dbCatalogoBancos.Properties.DataSource.rows(0)("Codigo"))

    '        CatalogoBancosP = dbCatalogoBancos.EditValue
    '        'Obtener Detalle del Catalogo Banco
    '        DetalleCBanco = VB.SysContab.Catalogo_BancosDB.GetList(Registro)   '.GetListNuevo(Registro, CatalogoBancosP)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub FechasPeriodo()
        Try
            Dim dtl As New VB.SysContab.PeriodoDetails
            dtl = PeriodosDB.GetDetails(Me.cbPeriodos.EditValue)

            Me.desde.Properties.MinValue = dtl.Inicio
            Me.desde.Properties.MaxValue = dtl.Final

            Me.hasta.Properties.MinValue = dtl.Inicio
            Me.hasta.Properties.MaxValue = dtl.Final
        Catch ex As Exception
        End Try
    End Sub

    Public Function Cargar_Ajuste() As Boolean
        Try
            If DetalleCBanco.Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
                Return False
                'Me.btnAjuste.Enabled = False
            Else
                'Si es Moneda Extranjera
                If DetalleCBanco.Tables("CATALOGO_BANCOS").Rows.Item(0)("MonCod") <> DetalleEmpresa.MonedaBase Then
                    Return True
                    'Me.btnAjuste.Enabled = True
                Else
                    Return False
                    'Me.btnAjuste.Enabled = False
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmBcosConc_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"
        Dim f As frmBcosConc_List = frmBcosConc_List.Instance
        If f.Created Then f.Cargar()
    End Sub

    'Sub CargarDatosEditar()
    '    Dim DT_CAMBIOS As DataTable = Nothing

    '    Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)

    '    v.AddParameter("Codigo", SqlDbType.NVarChar, 20, ParameterDirection.Input, txtnoconciliacion.Text)
    '    v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

    '    'Guardar Cambios en otra Tabla, para luego aplicarlos....
    '    Try
    '        DT_CAMBIOS = DT_DATOS.GetChanges(DataRowState.Modified)
    '    Catch ex As Exception
    '    End Try

    '    Try
    '        DT_DATOS = v.EjecutarComando("JAR_GetConciliacionDetalle", "Conciliacion")
    '        dgConciliacion.DataSource = DT_DATOS
    '        FormatoGrid(Me.Vista, 2, 0, False, True)

    '        For i As Integer = 0 To Me.Vista.Columns.Count - 1
    '            Vista.Columns(i).OptionsColumn.AllowEdit = False
    '        Next

    '        Vista.Columns("Conciliar").OptionsColumn.AllowEdit = True
    '        Vista.Columns("IdRazon").OptionsColumn.AllowEdit = True

    '        Vista.Columns("Concepto").Width = 300
    '        Vista.Columns("Conciliar").Width = 80

    '        'txt_S_SaldoInicial.EditValue = v.GetParameter("SaldoInicial").Valor
    '        'txt_S_Debitos.EditValue = SumarDebitos() 'Me.Vista.Columns("Débito").SummaryItem.SummaryValue     'Me.dgConciliacion.DataSource.compute("Sum(Débito)", "Sistema = 1")
    '        'txt_S_Creditos.EditValue = SumarCreditos() 'Me.Vista.Columns("Crédito").SummaryItem.SummaryValue    'Me.dgConciliacion.DataSource.compute("Sum(Crédito)", "Sistema = 1")
    '        'txt_S_SaldoFinal.EditValue = txt_S_SaldoInicial.EditValue + (txt_S_Debitos.EditValue - txt_S_Creditos.EditValue)

    '        btnCargar.Enabled = True
    '        Diferencia()

    '        v = Nothing
    '    Catch ex As Exception
    '        XtraMsg(ex.Message, MessageBoxIcon.Error)
    '        v = Nothing
    '    End Try
    'End Sub

    Public Sub CargarDatos()

        Dim DT_CAMBIOS As DataTable = Nothing
        Me.dgConciliacion.DataSource = Nothing

        Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)

        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Me.dbBancos.GetColumnValue("Cuenta"))
        v.AddParameter("Banco", SqlDbType.Int, 5, ParameterDirection.Input, Me.dbBancos.EditValue)
        v.AddParameter("Desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.desde.DateTime.Date)
        v.AddParameter("Hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.hasta.DateTime.Date)
        v.AddParameter("Conciliado", SqlDbType.Bit, 5, ParameterDirection.Input, IIf(IdConciliacion = 0, False, True))
        v.AddParameter("SaldoInicial", SqlDbType.Money, 10, ParameterDirection.Output, 0)
        v.AddParameter("MonedaCambio", SqlDbType.NVarChar, 5, ParameterDirection.Input, Me.dbBancos.GetColumnValue("MonCod"))
        v.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtnoconciliacion.Text)

        'Guardar Cambios en otra Tabla, para luego aplicarlos....
        Try
            DT_CAMBIOS = DT_DATOS.GetChanges(DataRowState.Modified)
        Catch ex As Exception
        End Try

        Try
            'Cargar Movimientos
            If IdConciliacion = 0 Then DT_DATOS = v.EjecutarComando("_GetLIstConciliacionBancaria_V2", "Conciliacion")
            If IdConciliacion <> 0 Then DT_DATOS = v.EjecutarComando("JAR_GetConciliacionDetalle", "Conciliacion")

            'Marcar los cambios, si se vuelve a cargar los movimientos
            If Not DT_CAMBIOS Is Nothing Then
                Try
                    Dim primaryKeys(1) As DataColumn
                    primaryKeys(0) = DT_DATOS.Columns("ID")

                    DT_DATOS.PrimaryKey = primaryKeys

                    For i As Integer = 0 To DT_CAMBIOS.Rows.Count - 1
                        'Marcar Campo Conciliar
                        If DT_CAMBIOS.Rows.Item(i)("Conciliar") Then
                            'Dim dr As DataRow = DT_CAMBIOS.Rows.Item(i)
                            'Dim dr As DataRow = DT_DATOS.Select("ID=" & DT_CAMBIOS.Rows.Item(i)("ID"))(0)

                            Dim dr As DataRow = DT_DATOS.Rows.Find(DT_CAMBIOS.Rows.Item(i)("ID"))
                            Dim pos As Integer = DT_DATOS.Rows.IndexOf(dr)


                            DT_DATOS.Rows.Item(pos)("Conciliar") = True
                        End If
                        '
                        'Marcar Campo Encontrado
                        If DT_CAMBIOS.Rows.Item(i)("Encontrado") Then
                            Dim dr As DataRow = DT_CAMBIOS.Rows.Item(i)
                            Dim pos As Integer = DT_DATOS.Rows.IndexOf(dr)
                            '
                            DT_DATOS.Rows.Item(pos)("Encontrado") = True
                        End If
                    Next
                Catch ex As Exception
                End Try
            End If

            Me.dgConciliacion.DataSource = DT_DATOS
            FormatoGrid(Me.Vista, 2, 0, False, True)

            'If Me.Vista.DataRowCount = 0 Then
            '    Limpiar()
            '    Exit Sub
            'End If

            For i As Integer = 0 To Me.Vista.Columns.Count - 1
                Me.Vista.Columns(i).OptionsColumn.AllowEdit = False
            Next

            'Me.Vista.Columns("Débito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.Vista.Columns("Débito").DisplayFormat.FormatString = "n2"
            'Me.Vista.Columns("Débito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.Vista.Columns("Débito").SummaryItem.DisplayFormat = "{0:n2}"

            'Me.Vista.Columns("Crédito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.Vista.Columns("Crédito").DisplayFormat.FormatString = "n2"
            'Me.Vista.Columns("Crédito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.Vista.Columns("Crédito").SummaryItem.DisplayFormat = "{0:n2}"

            'Me.Vista.Columns("ID").Visible = False
            'Me.Vista.Columns("Cod Equiv").Visible = False
            'Me.Vista.Columns("Sistema").Visible = False
            'Me.Vista.Columns("Saldo").Visible = False
            Me.Vista.Columns("Conciliar").OptionsColumn.AllowEdit = True
            Me.Vista.Columns("IdRazon").OptionsColumn.AllowEdit = True

            'BestFit
            'Me.Vista.Columns("No Comp").BestFit()
            'Me.Vista.Columns("Fecha").BestFit()
            'Me.Vista.Columns("Abrev").BestFit()
            'Me.Vista.Columns("Documento").BestFit()
            'Me.Vista.Columns("Débito").BestFit()
            'Me.Vista.Columns("Crédito").BestFit()
            'Me.Vista.Columns("Conciliar").BestFit()
            'Me.Vista.Columns("Encontrado").BestFit()
            ''Me.Vista.BestFitColumns()

            Me.Vista.Columns("Concepto").Width = 300
            Me.Vista.Columns("Conciliar").Width = 80

            Me.txt_S_SaldoInicial.EditValue = v.GetParameter("SaldoInicial").Valor
            Me.txt_S_Debitos.EditValue = SumarDebitos()     'Me.Vista.Columns("Débito").SummaryItem.SummaryValue     'Me.dgConciliacion.DataSource.compute("Sum(Débito)", "Sistema = 1")
            Me.txt_S_Creditos.EditValue = SumarCreditos()   'Me.Vista.Columns("Crédito").SummaryItem.SummaryValue    'Me.dgConciliacion.DataSource.compute("Sum(Crédito)", "Sistema = 1")
            Me.txt_S_SaldoFinal.EditValue = Me.txt_S_SaldoInicial.EditValue + (Me.txt_S_Debitos.EditValue - Me.txt_S_Creditos.EditValue)

            Me.btnCargar.Enabled = True
            Diferencia()

            'CargarDT()

            v = Nothing
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            v = Nothing
        End Try

    End Sub

    Function SumarDebitos() As Double
        Dim Debito As Double = 0

        For i As Integer = 0 To Me.Vista.DataRowCount - 1
            If CDate(Vista.GetRowCellValue(i, "Fecha")).Date >= desde.DateTime.Date Then
                Debito = Debito + Vista.GetRowCellValue(i, "Débito")
            End If
        Next

        Return Debito
    End Function

    Function SumarCreditos() As Double
        Dim Credito As Double = 0

        For i As Integer = 0 To Me.Vista.DataRowCount - 1
            If CDate(Vista.GetRowCellValue(i, "Fecha")).Date >= desde.DateTime.Date Then
                Credito = Credito + Vista.GetRowCellValue(i, "Crédito")
            End If
        Next

        Return Credito
    End Function

    Public Sub ComboRazones()
        cbRazonesConciliacion.DataSource = ObtieneDatos("JAR_ConciliacionRazones " & EmpresaActual)
        cbRazonesConciliacion.ValueMember = "IdRazon"
        cbRazonesConciliacion.DisplayMember = "Nombre"
        cbRazonesConciliacion.PopulateColumns()
        cbRazonesConciliacion.Columns("IdRazon").Visible = False
    End Sub

    'Sub CargarDT()
    '    Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)

    '    v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '    v.AddParameter("Cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Me.dbBancos.GetColumnValue("Cuenta"))
    '    v.AddParameter("Banco", SqlDbType.Int, 5, ParameterDirection.Input, Me.dbBancos.EditValue)
    '    v.AddParameter("Desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.desde.EditValue)
    '    v.AddParameter("Hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.hasta.EditValue)
    '    v.AddParameter("Conciliado", SqlDbType.Bit, 5, ParameterDirection.Input, False)
    '    v.AddParameter("SaldoInicial", SqlDbType.Money, 10, ParameterDirection.Output, 0)

    '    DSSistema = v.EjecutarComando("_GetLIstConciliacionBancaria_V2", "Conciliacion")
    'End Sub

    'Private Sub frmBcosConc_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    '    FormPrincipal.menuHerramientas.Visible = False
    'End Sub

    Private Sub dbBancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbBancos.EditValueChanged
        'Me.dgConciliacion.DataSource = Nothing
        'Limpiar()
        Try
            Dim dtm As DataTable = ObtieneDatos("SELECT * FROM Monedas m WHERE m.mon_codigo = '" & Me.dbBancos.GetColumnValue("MonCod") & "' AND m.empr_codigo = " & EmpresaActual)
            Me.txtMoneda.Text = dtm.Rows.Item(0)("mon_simbolo") & " " & dtm.Rows.Item(0)("mon_descripcion")

            lGroupSistema.Text = "SEGUN SISTEMA: MONEDA " & dtm.Rows.Item(0)("mon_simbolo")
            lGroupBanco.Text = "SEGUN BANCO (BANCANET): MONEDA " & dtm.Rows.Item(0)("mon_simbolo")
        Catch ex As Exception
            Me.txtMoneda.Text = ""
            lGroupSistema.Text = "SEGUN SISTEMA"
            lGroupBanco.Text = "SEGUN BANCO (BANCANET)"
        End Try

        Registro = dbBancos.EditValue
        DetalleBanco = VB.SysContab.BancosDB.GetDetails(Registro)
        ''Cargar_Cuentas_Banco()
        Limpiar()

        'Cargar_Ajuste()
        Me.dgConciliacion.DataSource = Nothing
    End Sub

    Sub Limpiar()
        Me.txt_S_SaldoInicial.EditValue = 0.0
        Me.txt_S_Debitos.EditValue = 0.0
        Me.txt_S_Creditos.EditValue = 0.0
        Me.txt_S_SaldoFinal.EditValue = 0.0

        Me.txt_B_SaldoInicial.EditValue = 0.0
        Me.txt_B_Debitos.EditValue = 0.0
        Me.txt_B_Creditos.EditValue = 0.0
        Me.txt_B_SaldoFinal.EditValue = 0.0

        txtDiferencia.EditValue = 0.0
        CheckEdit1.Checked = False
        'Me.btnAjuste.Enabled = False
        'Me.btnComp.Enabled = False

        txtnoconciliacion.Text = ConciliacionBancariaDB.CB_Nvo()
    End Sub

    Sub Diferencia()    'Conciliación OK, la Diferencia debe ser Cero (0)
        Me.txtDiferencia.EditValue = CDbl(Me.txt_B_SaldoFinal.EditValue - Me.txt_S_SaldoFinal.EditValue).ToString(Round)
        If Me.txtDiferencia.EditValue > 0 Then
            Me.etMsg.Text = "* El Saldo del Banco es Mayor al Saldo en Libro Banco del Sistema"
        ElseIf Me.txtDiferencia.EditValue < 0 Then
            Me.etMsg.Text = "* El Saldo del Banco es Menor al Saldo en Libro Banco del Sistema"
        ElseIf Me.txtDiferencia.EditValue = 0 Then
            Me.etMsg.Text = ""
        End If
    End Sub

    Private Sub dbCatalogoBancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Cargar_Ajuste()        
    End Sub

    Private Sub btnAjuste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjuste.Click
        If Not Cargar_Ajuste() Then
            XtraMsg("El deslizamiento Monetario se aplica a Moneda Extranjera", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As New frmMontoAjuste
        f.Per_Id = Me.cbPeriodos.EditValue
        f.ShowDialog()
        Dim DC As String = ""
        If f.OK = "SI" Then

            If f.TipoA Then
                DC = "C"
            Else
                DC = "D"
            End If

            If ComprobanteDeslizamiento(f.Monto, f.FechaC, f.Concepto, DC) Then
                If Me.Vista.DataRowCount > 0 Then
                    CargarDatos()
                    Compara_Archivo()
                End If
            End If
        End If
        f.Dispose()
    End Sub

    Function ComprobanteDeslizamiento(ByVal Monto As Double, ByVal FComp As Date, ByVal Concepto As String, ByVal DC As String) As Boolean

        Dim sSQL1 As String = "SELECT  Plantilla_Cuenta FROM  TipoPlantillas INNER JOIN PLANTILLAS ON" _
                                + " TipoPlantillas.TipoPlantilla_Id = PLANTILLAS.Plantilla_Tipo WHERE Pla_Id = 7" _
                                + " AND Esq_ID = 1 AND TipoPlantillas.Empresa = " & EmpresaActual & " AND Plantilla_DC = 1"

        Dim CuentaMnto As String = String.Empty
        Dim Plantilla As New PlantillaDB

        Try 'Obtener Cuenta de Diferencia Cambiaria de la Plantilla Contable
            CuentaMnto = ObtieneDatos(sSQL1).Rows.Item(0)(0)
        Catch ex As Exception
            XtraMsg("No Existe Plantilla de Mantenimiento de Valor", MessageBoxIcon.Error)
            Return False
        End Try

        'Obtener el detalle de la Plantilla de Mantenimiento de valor
        Dim detallePla As PlantillaDetails = Plantilla.GetPlantillasDetails(7, 1)
        Dim Debito As Double = 0

        Try
            '----------------------------------
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion)
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            '------------------------------------

            '' Crear Comprobante de Ajuste por Deslizamiento
            'Encabezado
            Dim NoComp As Double = Comp.AddComprobante(detallePla.TipoCompr, 1, Concepto, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
            Periodos.Activo(FComp), FComp, "", "", False, 0, "", 0, 0, FComp, 0, 0, 0)

            'Detalle del Comprobante
            'Linea del Banco
            Comp.AddComprobanteDetalles(NoComp, DetalleCBanco.Tables(0).Rows.Item(0)("Cuenta"), "Banco", Monto, 0, 0, IIf(DC = "D", "C", "D"), 0, 0, FComp, 0)
            'Linea del Deslizamiento
            Comp.AddComprobanteDetalles(NoComp, CuentaMnto, "Deslizamiento de Moneda", Monto, 0, 0, DC, 0, 0, FComp, 0)

            Rutinas.okTransaccion()

            Return True
        Catch ex As Exception
            XtraMsg("ERROR al Guardar Comprobante : " & ex.Message, MessageBoxIcon.Error)
            Rutinas.ErrorTransaccion()
            Return False
        End Try
    End Function

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        Dim f As New frmComprobanteConcilación
        f.Per_Id = Me.cbPeriodos.EditValue
        f.ShowDialog()
        If f.OK = "SI" Then
            If Me.Vista.DataRowCount > 0 Then
                CargarDatos()
                Compara_Archivo()
            End If
        End If

        f.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, btnGuardar2.Click

        If Me.txtDiferencia.EditValue <> 0 Then
            If Not XtraMsg2("Desea Grabar Conciliación con diferenciaa?") Then
                Me.txtDiferencia.Focus()
                Me.txtDiferencia.SelectAll()
                Exit Sub
            End If
        End If

        Dim Cont As Integer = 0

        For i As Integer = 0 To Me.Vista.DataRowCount - 1
            If Not Me.Vista.GetRowCellValue(i, "Conciliar") Then
                Cont += 1
            End If
        Next

        'Varificar Que esten Marcados
        If Me.txtDiferencia.EditValue = 0 And Cont > 0 Then
            XtraMsg("No hay Diferencias en Libros, Sin Embargo hay " & Cont & " Comprobantes que no han sido Marcardos para Conciliar" & vbCrLf _
                                + " Marque los Comprobantes que Hacen Falta para Guardar conciliación", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtElaborado.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el nombre del campo Elaborado por, para continuar.", MessageBoxIcon.Warning)
            txtElaborado.Focus()
            Exit Sub
        End If
        '
        If txtRevisado.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el nombre del campo Revisado por, para continuar.", MessageBoxIcon.Warning)
            txtRevisado.Focus()
            Exit Sub
        End If

        Dim Valor As Double = 0, ES As String = ""
        ''
        Try

            ' Dim Codigo As String = "0"

            ShowSplash("Guardando Conciliación...")
            '            
            If IdConciliacion = 0 Then

                ConciliacionBancariaDB.Insertar(
                    txtnoconciliacion.Text,
                    cbPeriodos.EditValue,
                    desde.DateTime.Date,
                    hasta.DateTime.Date,
                    txt_B_SaldoInicial.EditValue,
                    txt_B_Debitos.EditValue,
                    txt_B_Creditos.EditValue,
                    txt_B_SaldoFinal.EditValue,
                    txt_S_SaldoInicial.EditValue,
                    txt_S_Debitos.EditValue,
                    txt_S_Creditos.EditValue,
                    txt_B_SaldoFinal.EditValue,
                    dbBancos.EditValue,
                    dbBancos.GetColumnValue("Cuenta"),
                    txtElaborado.Text,
                    txtRevisado.Text,
                    IIf(sender.Name = "btnGuardar", 0, 1),
                    DT_DATOS)


                'Codigo = DB.Conciliacion_BancariaADD(Me.txtnoconciliacion.Text, Me.cbPeriodos.EditValue,
                '                                                   Me.desde.DateTime.Date, Me.hasta.DateTime.Date,
                '                                                   Me.txt_B_SaldoInicial.EditValue, txt_B_Debitos.EditValue,
                '                                                   Me.txt_B_Creditos.EditValue, Me.txt_B_SaldoFinal.EditValue,
                '                                                   Me.txt_S_SaldoInicial.EditValue, Me.txt_S_Debitos.EditValue,
                '                                                   Me.txt_S_Creditos.EditValue, Me.txt_B_SaldoFinal.EditValue,
                '                                                   Me.dbBancos.EditValue, Me.dbBancos.GetColumnValue("Cuenta"),
                '                                                   txtElaborado.Text, txtRevisado.Text, IIf(sender.Name = "btnGuardar", 0, 1))
            Else
                'Borrar Detalle de Conciliacion
                'ConciliacionBancariaDB.BorrarDetalleConciliacion(txtnoconciliacion.Text)

                ConciliacionBancariaDB.Actualizar(
                    txtnoconciliacion.Text,
                    cbPeriodos.EditValue,
                    desde.DateTime.Date,
                    hasta.DateTime.Date,
                    txt_B_SaldoInicial.EditValue,
                    txt_B_Debitos.EditValue,
                    txt_B_Creditos.EditValue,
                    txt_B_SaldoFinal.EditValue,
                    txt_S_SaldoInicial.EditValue,
                    txt_S_Debitos.EditValue,
                    txt_S_Creditos.EditValue,
                    txt_B_SaldoFinal.EditValue,
                    dbBancos.EditValue,
                    dbBancos.GetColumnValue("Cuenta"),
                    txtElaborado.Text,
                    txtRevisado.Text,
                    IIf(sender.Name = "btnGuardar", 0, 1),
                    DT_DATOS)

                'DB.Conciliacion_BancariaUPDATE(Me.txtnoconciliacion.Text, Me.cbPeriodos.EditValue, _
                '                                                   Me.desde.DateTime.Date, Me.hasta.DateTime.Date, _
                '                                                   Me.txt_B_SaldoInicial.EditValue, txt_B_Debitos.EditValue, _
                '                                                   Me.txt_B_Creditos.EditValue, Me.txt_B_SaldoFinal.EditValue, _
                '                                                   Me.txt_S_SaldoInicial.EditValue, Me.txt_S_Debitos.EditValue, _
                '                                                   Me.txt_S_Creditos.EditValue, Me.txt_B_SaldoFinal.EditValue, _
                '                                                   Me.dbBancos.EditValue, Me.dbBancos.GetColumnValue("Cuenta"), _
                '                                                   txtElaborado.Text, txtRevisado.Text, IIf(sender.Name = "btnGuardar", 0, 1))
                'Codigo = txtnoconciliacion.Text
            End If
            ''Borrar Detalle de Conciliacion
            'VB.SysContab.ConciliacionBancariaDB.BorrarDetalleConciliacion(Codigo)

            'Quitar todos filtros si hay culumnas con filtros aplicados
            'For i As Integer = 0 To Vista.Columns.Count - 1
            '    Vista.Columns(i).ClearFilter()
            'Next

            ''Agregar Detalle de Conciliación
            'For i As Integer = 0 To Vista.DataRowCount - 1

            '    If Me.Vista.GetRowCellValue(i, "Débito") > 0 Then   'Entrada
            '        Valor = Me.Vista.GetRowCellValue(i, "Débito")
            '        ES = "E"
            '    Else
            '        Valor = Me.Vista.GetRowCellValue(i, "Crédito")  'Salida
            '        ES = "S"
            '    End If

            'DB.Conciliacion_Bancaria_DetalleADD(Codigo, Me.Vista.GetRowCellValue(i, "ID"), Valor, ES, 1, 0, 0, 0,
            ' Me.Vista.GetRowCellValue(i, "Concepto"), Me.Vista.GetRowCellValue(i, "Fecha"), Me.Vista.GetRowCellValue(i, "Documento"),
            ' IsNull(Me.Vista.GetRowCellValue(i, "IdRazon"), 0), Me.Vista.GetRowCellValue(i, "Conciliar"), Me.Vista.GetRowCellValue(i, "Encontrado"))
            'If Vista.GetRowCellValue(i, "Conciliar") Then Comp.ComprobanteDetalle_Conciliado(Vista.GetRowCellValue(i, "ID"), 1)

            'Next

            HideSplash()
            XtraMsg("Los Datos se han Registrado Exitosamente")

            'Todo Bien
            'Limpiar()
            'Me.dgConciliacion.DataSource = Nothing

            Dispose()

            Dim f As frmBcosConc_List = frmBcosConc_List.Instance()

            If f.Created Then
                ShowSplash()
                f.Cargar()
                HideSplash()
            End If
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

    End Sub


    'Private Sub chkAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.Click
    '    For i As Integer = 0 To Me.Vista.DataRowCount - 1
    '        Me.Vista.SetRowCellValue(i, "Conciliar", Me.chkAll.Checked)
    '    Next
    'End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        ShowSplash()
        ''

        ' If IdConciliacion = 0 Then CargarDatos()
        ' If IdConciliacion <> 0 Then CargarDatosEditar()

        CargarDatos()

        ComboRazones()

        If Not DT Is Nothing Then
            Compara_Archivo()
        End If
        ''
        HideSplash()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, "ayuda/BancosConcil.chm")
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        If Me.Vista.DataRowCount = 0 Then
            XtraMsg("No hay Datos suficientes para realizar conciliación", MessageBoxIcon.Warning)
            Me.btnImportar.Focus()
            Exit Sub
        End If

        DT = New DataTable

        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.Filter = "Archivo Microsoft Excel 97-2003 (*.xls)|*.xls"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim DC As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.OpenFileDialog1.FileName & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
                Dim DA As New OleDbDataAdapter("SELECT * FROM [" & InputBox("Nombre de la Hoja : ", "Hoja de calculo") & "$]", DC)
                DA.Fill(DT)

                If Me.rgFormato.EditValue = 1 Then  'Formato con Debito y Credito
                    If DT.Columns.Count - 1 <> 5 Then
                        XtraMsg("Deben ser Seis (6) columnas para Importar el Archivo")
                        Exit Sub
                    End If
                ElseIf Me.rgFormato.EditValue = 2 Then  'Formato Con Movimientos Negativos
                    If DT.Columns.Count - 1 <> 4 Then
                        XtraMsg("Deben ser Cinco (5) columnas para Importar el Archivo")
                        Exit Sub
                    End If
                End If

                '' Agregar Columna
                DT.Columns.Add("Encontrado", Type.GetType("System.Int32"))

                ' ''Verificar si Existe la Columna
                'If DT.Columns.IndexOf("Encontrado") < 0 Then
                '    DT.Columns.Add("Encontrado", Type.GetType("System.Int32"))
                'End If

                ShowSplash()
                ''
                Compara_Archivo()
                ReCalcular()
                ''Cargar_Ajuste()
                ''
                HideSplash()

                If Not DT_NOENCONTRADOS Is Nothing Then DT_NOENCONTRADOS.Clear()
                DT_NOENCONTRADOS = DT.GetChanges(DataRowState.Modified)

                btnComp.Enabled = True
            Catch ex As Exception
                XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Sub Compara_Archivo()
        Try
            If DT.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim Debito As Double = 0, Credito As Double = 0

            If Me.rgFormato.EditValue = 1 Then
                Me.txt_B_SaldoInicial.EditValue = DT.Rows(0).Item(5)                  'Saldo Inicial
                Me.txt_B_SaldoFinal.EditValue = DT.Rows(DT.Rows.Count - 1).Item(5)    'Salod Final
            ElseIf Me.rgFormato.EditValue = 2 Then
                Me.txt_B_SaldoInicial.EditValue = DT.Rows(0).Item(4)                  'Saldo Inicial
                Me.txt_B_SaldoFinal.EditValue = DT.Rows(DT.Rows.Count - 1).Item(4)    'Salod Final
            End If

            For i As Integer = 1 To DT.Rows.Count - 1
                If Me.rgFormato.EditValue = 1 Then
                    If CDbl(DT.Rows(i).Item(3)) > 0 Then
                        If Not BuscarEquivalente(CDbl(DT.Rows(i).Item(3)), "D", _
                                          IsNull(DT.Rows(i).Item(1), "")) Then
                            DT.Rows.Item(i)("Encontrado") = 0
                        End If
                    Else
                        If Not BuscarEquivalente(CDbl(DT.Rows(i).Item(4)), "C", _
                                          IsNull(DT.Rows(i).Item(1), "")) Then
                            DT.Rows.Item(i)("Encontrado") = 0
                        End If
                    End If
                ElseIf Me.rgFormato.EditValue = 2 Then
                    If CDbl(DT.Rows(i).Item(3)) > 0 Then  '>0 = Credito, <0 = Debito
                        If Not BuscarEquivalente(CDbl(DT.Rows(i).Item(3)), "C", _
                                          IsNull(DT.Rows(i).Item(1), "")) Then
                            DT.Rows.Item(i)("Encontrado") = 0
                        End If
                        Credito += CDbl(DT.Rows(i).Item(3))
                    ElseIf CDbl(DT.Rows(i).Item(3)) < 0 Then  '>0 = Credito, <0 = Debito
                        If Not BuscarEquivalente(CDbl(DT.Rows(i).Item(3)) * -1, "D", _
                                          IsNull(DT.Rows(i).Item(1), "")) Then
                            DT.Rows.Item(i)("Encontrado") = 0
                        End If
                        Debito += (CDbl(DT.Rows(i).Item(3)) * -1)
                    End If
                End If
            Next

            If rgFormato.EditValue = 1 Then
                Me.txt_B_Debitos.EditValue = DT.Compute("Sum(Debito)", "Debito > 0")        'Debitos
                Me.txt_B_Creditos.EditValue = DT.Compute("Sum(Credito)", "Credito > 0")     'Credito
            ElseIf rgFormato.EditValue = 2 Then
                Me.txt_B_Debitos.EditValue = Debito       'Debitos
                Me.txt_B_Creditos.EditValue = Credito     'Credito
            End If

        Catch ex As Exception
        End Try
    End Sub

    Function BuscarEquivalente(ByVal Monto As Double, ByVal DC As String, ByVal Documento As String) As Boolean
        Dim Encontrado As Boolean = False

        For i As Integer = 0 To Me.Vista.DataRowCount - 1
            If DC = "D" Then
                If Math.Round(Me.Vista.GetRowCellValue(i, "Crédito"), 2) = Math.Round(Monto, 2) Then
                    If IsNull(Vista.GetRowCellValue(i, "Documento"), "").ToString.Trim = Documento.Trim Then

                        Me.Vista.SetRowCellValue(i, "Conciliar", True)
                        Me.Vista.SetRowCellValue(i, "Encontrado", True)

                        Encontrado = True
                    End If
                End If
            ElseIf DC = "C" Then
                If Math.Round(Me.Vista.GetRowCellValue(i, "Débito"), 2) = Math.Round(Monto, 2) Then
                    Me.Vista.SetRowCellValue(i, "Conciliar", True)
                    Me.Vista.SetRowCellValue(i, "Encontrado", True)

                    Encontrado = True
                End If
            End If

            If Documento <> "" Then
                If Documento.Trim = IsNull(Vista.GetRowCellValue(i, "Documento"), "").ToString.Trim Then

                    Me.Vista.SetRowCellValue(i, "Conciliar", True)
                    Me.Vista.SetRowCellValue(i, "Encontrado", True)

                    Encontrado = True
                End If
            End If
        Next

        Return Encontrado

        'For i As Integer = 0 To Me.Vista.DataRowCount - 1
        '    'If Documento <> "" Then
        '    '    If Documento.Trim = Me.Vista.GetRowCellValue(i, "Documento").ToString.Trim Then
        '    '        Me.Vista.SetRowCellValue(i, "Conciliar", True)
        '    '        Me.Vista.SetRowCellValue(i, "Encontrado", True)
        '    '    End If
        '    '    'Else
        '    '    '    If DC = "D" Then
        '    '    '        If Math.Round(Me.Vista.GetRowCellValue(i, "Crédito"), 2) = Math.Round(Monto, 2) Then
        '    '    '            Me.Vista.SetRowCellValue(i, "Conciliar", True)
        '    '    '            Me.Vista.SetRowCellValue(i, "Encontrado", True)
        '    '    '        End If
        '    '    '    ElseIf DC = "C" Then
        '    '    '        If Math.Round(Me.Vista.GetRowCellValue(i, "Débito"), 2) = Math.Round(Monto, 2) Then
        '    '    '            Me.Vista.SetRowCellValue(i, "Conciliar", True)
        '    '    '            Me.Vista.SetRowCellValue(i, "Encontrado", True)
        '    '    '        End If
        '    '    '    End If
        '    'End If
        'Next
    End Function

    Private Sub btnFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormato.Click
        Dim f As New frmVerFormato
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgConciliacion)
    End Sub

    Private Sub cbPeriodos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPeriodos.EditValueChanged
        FechasPeriodo()
    End Sub

    Private Sub txt_B_SaldoInicial_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_B_SaldoInicial.EditValueChanged, txt_B_Debitos.EditValueChanged, txt_B_Creditos.EditValueChanged, txt_B_SaldoFinal.EditValueChanged
        Diferencia()
    End Sub

    Private Sub btnRecalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecalcular.Click
        ReCalcular()
    End Sub

    Sub ReCalcular()

        Dim Debe As Double = 0
        Dim Haber As Double = 0

        For i As Integer = 0 To Vista.DataRowCount - 1
            If Vista.GetRowCellValue(i, "Conciliar") Then
                Debe += Me.Vista.GetRowCellValue(i, "Débito")
                Haber += Me.Vista.GetRowCellValue(i, "Crédito")
            End If
        Next

        'Me.txt_B_Debitos.EditValue = IsNull(Me.dgConciliacion.DataSource.compute("Sum(Crédito)", "Crédito >0"), 0.0)
        'Me.txt_B_Creditos.EditValue = IsNull(Me.dgConciliacion.DataSource.compute("Sum(Débito)", "Débito >0"), 0.0)

        Me.txt_B_Debitos.EditValue = Haber
        Me.txt_B_Creditos.EditValue = Debe

        Me.txt_B_SaldoFinal.EditValue = Me.txt_B_SaldoInicial.EditValue + (Me.txt_B_Creditos.EditValue - Me.txt_B_Debitos.EditValue)

        Diferencia()
    End Sub

    Public Sub CargarDatosXML()

        'Revisar si la Tabla Tiene Registros
        If DSBanco.Tables("Archivo").Rows.Count = 0 Then
            Exit Sub
        End If

        Dim DebitoB As Double = 0
        Dim CreditoB As Double = 0

        Try
            'La Primera Linea Contiene el Saldo Inicial
            Me.txt_B_SaldoInicial.EditValue = DSBanco.Tables("Archivo").Rows.Item(0)("Saldo")

            'Sumarizar los Débitos y Créditos del Banco
            For i As Integer = 1 To DSBanco.Tables("Archivo").Rows.Count - 1
                If CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Debito")) > 0 Then
                    'BuscarEquivalente(CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Debito")), "D")
                Else
                    'BuscarEquivalente(CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Credito")), "C")
                End If

                DebitoB += DSBanco.Tables("Archivo").Rows.Item(i)("Debito")
                CreditoB += DSBanco.Tables("Archivo").Rows.Item(i)("Credito")
            Next

            Me.txt_B_Debitos.EditValue = DebitoB
            Me.txt_B_Creditos.EditValue = CreditoB
            Me.txt_B_SaldoFinal.EditValue = DSBanco.Tables("Archivo").Rows.Item(DSBanco.Tables("Archivo").Rows.Count - 1)("Saldo")

            Diferencia()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CargarDatosXML(ByVal Nombre As String)

        'Revisar si la Tabla Tiene Registros
        If DSBanco.Tables("Archivo").Rows.Count = 0 Then
            XtraMsg("El Archivo : " & Nombre & " No Tiene Detalles de Movimientos", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim DebitoB As Double = 0
        Dim CreditoB As Double = 0

        Try
            'La Primera Linea Contiene el Saldo Inicial
            Me.txt_B_SaldoInicial.EditValue = DSBanco.Tables("Archivo").Rows.Item(0)("Saldo")

            'Sumarizar los Débitos y Créditos del Banco
            For i As Integer = 1 To DSBanco.Tables("Archivo").Rows.Count - 1
                If CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Debito")) > 0 Then
                    'BuscarEquivalente(CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Debito")), "D")
                Else
                    'BuscarEquivalente(CDbl(DSBanco.Tables("Archivo").Rows.Item(i)("Credito")), "C")
                End If

                DebitoB += DSBanco.Tables("Archivo").Rows.Item(i)("Debito")
                CreditoB += DSBanco.Tables("Archivo").Rows.Item(i)("Credito")
            Next

            Me.txt_B_Debitos.EditValue = DebitoB
            Me.txt_B_Creditos.EditValue = CreditoB
            Me.txt_B_SaldoFinal.EditValue = DSBanco.Tables("Archivo").Rows.Item(DSBanco.Tables("Archivo").Rows.Count - 1)("Saldo")

            Diferencia()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    'Sub LimpiarControles()
    '    Me.txt_B_SaldoInicial.EditValue = 0.0
    '    Me.txt_S_Debitos.EditValue = 0.0
    '    Me.txt_S_Creditos.EditValue = 0.0
    '    Me.txt_S_SaldoFinal.EditValue = 0.0
    '    Diferencia()
    'End Sub

    'Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If DetalleCBanco.Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
    '    '    MsgBox("Seleccione Banco y Cuenta", MsgBoxStyle.Exclamation)
    '    '    Exit Sub
    '    'End If
    '    'Catch ex As Exception
    '    '    MsgBox("El Banco No tiene Archivo de Formato Configurado", MsgBoxStyle.Exclamation)
    '    '    End Try
    'End Sub

    Private Sub cbRazonesConciliacion_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbRazonesConciliacion.ButtonClick
        If e.Button.Index = 1 Then  ''Borrar
            If IsNull(Vista.GetFocusedRowCellValue("IdRazon"), 0) <> 0 Then

            End If
        ElseIf e.Button.Index = 2 Then  ''Modificar
            If IsNull(Vista.GetFocusedRowCellValue("IdRazon"), 0) <> 0 Then
                frmRazonesConciliacioAdd.lcgTitulo.Text = "MODIFICAR RAZONES DE CONCILIACION"
                frmRazonesConciliacioAdd.IdDetalle = Vista.GetFocusedRowCellValue("IdRazon")
                frmRazonesConciliacioAdd.ShowDialog()
                If frmRazonesConciliacioAdd.Ok = "SI" Then ComboRazones()
                frmRazonesConciliacioAdd.Dispose()
            End If
        ElseIf e.Button.Index = 3 Then  ''Nuevo
            frmRazonesConciliacioAdd.lcgTitulo.Text = "AGREGAR RAZONES DE CONCILIACION"
            frmRazonesConciliacioAdd.ShowDialog()
            If frmRazonesConciliacioAdd.Ok = "SI" Then ComboRazones()
            frmRazonesConciliacioAdd.Dispose()
        End If
    End Sub

    Private Sub bNoEncontrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNoEncontrados.Click
        If DT_NOENCONTRADOS Is Nothing Then
            XtraMsg("No hay Registros...")
            Exit Sub
        End If
        ''
        frmConciliacion_NoEncontrados.Dispose()

        With frmConciliacion_NoEncontrados
            .dgDatos.DataSource = DT_NOENCONTRADOS
            .vDatos.PopulateColumns()
            FormatoGrid(.vDatos)

            If Me.rgFormato.EditValue = 1 Then  'Formato con Debito y Credito
                .vDatos.Columns(5).Visible = False
                .vDatos.Columns(6).Visible = False

                .vDatos.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .vDatos.Columns(3).DisplayFormat.FormatString = "{0:n2}"
                .vDatos.Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .vDatos.Columns(3).SummaryItem.DisplayFormat = "{0:n2}"
                ''
                .vDatos.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .vDatos.Columns(4).DisplayFormat.FormatString = "{0:n2}"
                .vDatos.Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .vDatos.Columns(4).SummaryItem.DisplayFormat = "{0:n2}"
            ElseIf Me.rgFormato.EditValue = 1 Then  'Formato Con Movimientos Negativos
                .vDatos.Columns(4).Visible = False
                .vDatos.Columns(5).Visible = False
                ''
                .vDatos.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .vDatos.Columns(3).DisplayFormat.FormatString = "{0:n2}"
                .vDatos.Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .vDatos.Columns(3).SummaryItem.DisplayFormat = "{0:n2}"
            End If

            .Show()
        End With
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To Vista.DataRowCount - 1
            Vista.SetRowCellValue(i, "Conciliar", CheckEdit1.Checked)
        Next
    End Sub

    Private Sub Vista_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles Vista.RowUpdated
        ReCalcular()
    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click

    End Sub
End Class
