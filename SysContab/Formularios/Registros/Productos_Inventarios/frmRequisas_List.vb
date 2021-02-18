Imports ClasesBLL
Imports System.IO
Imports System.Linq
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmRequisas_List

    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmRequisas_List = Nothing

    Public Shared Function Instance() As frmRequisas_List
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRequisas_List
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
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnVerInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProcesarT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lyImportarInventario As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bProcesarCombos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bImprimirEtiquetas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequisas_List))
        Me.btnVerInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bImprimirEtiquetas = New DevExpress.XtraEditors.SimpleButton()
        Me.bProcesarCombos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcesarT = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyImportarInventario = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyImportarInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerInventario
        '
        Me.btnVerInventario.Appearance.Options.UseTextOptions = True
        Me.btnVerInventario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnVerInventario.Enabled = False
        Me.btnVerInventario.ImageOptions.Image = CType(resources.GetObject("btnVerInventario.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerInventario.Location = New System.Drawing.Point(12, 340)
        Me.btnVerInventario.Name = "btnVerInventario"
        Me.btnVerInventario.Size = New System.Drawing.Size(112, 38)
        Me.btnVerInventario.StyleController = Me.LayoutControl2
        Me.btnVerInventario.TabIndex = 13
        Me.btnVerInventario.Text = "Inventario &Descargado"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bImprimirEtiquetas)
        Me.LayoutControl2.Controls.Add(Me.bProcesarCombos)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Controls.Add(Me.btnVerInventario)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.bDiseno)
        Me.LayoutControl2.Controls.Add(Me.cmdEditar)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.bImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdContabilizar)
        Me.LayoutControl2.Controls.Add(Me.btnProcesarT)
        Me.LayoutControl2.Controls.Add(Me.btnProcesar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(138, 592)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bImprimirEtiquetas
        '
        Me.bImprimirEtiquetas.Appearance.Options.UseTextOptions = True
        Me.bImprimirEtiquetas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bImprimirEtiquetas.Enabled = False
        Me.bImprimirEtiquetas.ImageOptions.Image = CType(resources.GetObject("bImprimirEtiquetas.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimirEtiquetas.Location = New System.Drawing.Point(12, 422)
        Me.bImprimirEtiquetas.Name = "bImprimirEtiquetas"
        Me.bImprimirEtiquetas.Size = New System.Drawing.Size(112, 38)
        Me.bImprimirEtiquetas.StyleController = Me.LayoutControl2
        Me.bImprimirEtiquetas.TabIndex = 105
        Me.bImprimirEtiquetas.Text = "&Imprimir Etiquetas"
        '
        'bProcesarCombos
        '
        Me.bProcesarCombos.Appearance.Options.UseTextOptions = True
        Me.bProcesarCombos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bProcesarCombos.Enabled = False
        Me.bProcesarCombos.ImageOptions.Image = CType(resources.GetObject("bProcesarCombos.ImageOptions.Image"), System.Drawing.Image)
        Me.bProcesarCombos.Location = New System.Drawing.Point(12, 256)
        Me.bProcesarCombos.Name = "bProcesarCombos"
        Me.bProcesarCombos.Size = New System.Drawing.Size(112, 38)
        Me.bProcesarCombos.StyleController = Me.LayoutControl2
        Me.bProcesarCombos.TabIndex = 105
        Me.bProcesarCombos.Text = "Procesar &Combos"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(114, 36)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 544)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 107
        Me.SimpleButton1.Text = "&Salir"
        '
        'bDiseno
        '
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(12, 464)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(114, 36)
        Me.bDiseno.StyleController = Me.LayoutControl2
        Me.bDiseno.TabIndex = 104
        Me.bDiseno.Text = "Dise&ño"
        '
        'cmdEditar
        '
        Me.cmdEditar.Enabled = False
        Me.cmdEditar.ImageOptions.Image = CType(resources.GetObject("cmdEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEditar.Location = New System.Drawing.Point(12, 52)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(114, 36)
        Me.cmdEditar.StyleController = Me.LayoutControl2
        Me.cmdEditar.TabIndex = 9
        Me.cmdEditar.Text = "&Editar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 504)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(114, 36)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 10
        Me.cmdImprimir.Text = "E&xportar"
        '
        'bImprimir
        '
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(12, 92)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(114, 36)
        Me.bImprimir.StyleController = Me.LayoutControl2
        Me.bImprimir.TabIndex = 104
        Me.bImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 132)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(114, 36)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 9
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.Appearance.Options.UseTextOptions = True
        Me.cmdContabilizar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdContabilizar.Enabled = False
        Me.cmdContabilizar.ImageOptions.Image = CType(resources.GetObject("cmdContabilizar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdContabilizar.Location = New System.Drawing.Point(12, 298)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(112, 38)
        Me.cmdContabilizar.StyleController = Me.LayoutControl2
        Me.cmdContabilizar.TabIndex = 11
        Me.cmdContabilizar.Text = "Con&tabilizar"
        '
        'btnProcesarT
        '
        Me.btnProcesarT.Appearance.Options.UseTextOptions = True
        Me.btnProcesarT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnProcesarT.Enabled = False
        Me.btnProcesarT.ImageOptions.Image = CType(resources.GetObject("btnProcesarT.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProcesarT.Location = New System.Drawing.Point(12, 214)
        Me.btnProcesarT.Name = "btnProcesarT"
        Me.btnProcesarT.Size = New System.Drawing.Size(112, 38)
        Me.btnProcesarT.StyleController = Me.LayoutControl2
        Me.btnProcesarT.TabIndex = 14
        Me.btnProcesarT.Text = "Procesar &Traslado"
        '
        'btnProcesar
        '
        Me.btnProcesar.Appearance.Options.UseTextOptions = True
        Me.btnProcesar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnProcesar.Enabled = False
        Me.btnProcesar.ImageOptions.Image = CType(resources.GetObject("btnProcesar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProcesar.Location = New System.Drawing.Point(12, 172)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(112, 38)
        Me.btnProcesar.StyleController = Me.LayoutControl2
        Me.btnProcesar.TabIndex = 12
        Me.btnProcesar.Text = "Procesar &Inventario"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem16, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem4, Me.LayoutControlItem17, Me.LayoutControlItem11, Me.LayoutControlItem3, Me.LayoutControlItem15, Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(138, 592)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdNuevo
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdEditar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bImprimir
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdBorrar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnProcesar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnProcesarT
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 202)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdContabilizar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 286)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 370)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(118, 40)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.bDiseno
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 452)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdImprimir
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 492)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 532)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnVerInventario
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 328)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.bProcesarCombos
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 244)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.bImprimirEtiquetas
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 410)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1511, 357, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(936, 621)
        Me.LayoutControl1.TabIndex = 103
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(638, 36)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(151, 23)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 108
        Me.SimpleButton3.Text = "Importar Inv. Antiguedad"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(793, 12)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Selector de Datos"
        Me.CheckEdit2.Size = New System.Drawing.Size(131, 20)
        Me.CheckEdit2.StyleController = Me.LayoutControl1
        Me.CheckEdit2.TabIndex = 106
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(187, 36)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(88, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 105
        Me.SimpleButton2.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(49, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(134, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 104
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(49, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(134, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 103
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(793, 36)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Todos"
        Me.CheckEdit1.Size = New System.Drawing.Size(131, 20)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 101
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 63)
        Me.GridDetalle.MainView = Me.vDatos
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(912, 546)
        Me.GridDetalle.TabIndex = 100
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vDatos.Appearance.HeaderPanel.Options.UseFont = True
        Me.vDatos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vDatos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn7, Me.GridColumn4, Me.GridColumn14, Me.GridColumn15, Me.GridColumn5, Me.GridColumn6, Me.GridColumn17, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn16, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22})
        Me.vDatos.GridControl = Me.GridDetalle
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "# Movimiento"
        Me.GridColumn1.FieldName = "req_codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 108
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "req_fecha"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 114
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Tipo"
        Me.GridColumn2.FieldName = "Tipo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 114
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Movimiento"
        Me.GridColumn7.FieldName = "mov_nombre"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 114
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Bodega"
        Me.GridColumn4.FieldName = "Ubicacion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 114
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Referencia"
        Me.GridColumn14.FieldName = "Referencia"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 67
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "#Factura"
        Me.GridColumn15.FieldName = "Factura"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 67
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Elaborada por"
        Me.GridColumn5.FieldName = "req_realizadopor"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 114
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Contabilizado ?"
        Me.GridColumn6.FieldName = "req_contabilizada"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        Me.GridColumn6.Width = 122
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Procesado ?"
        Me.GridColumn17.FieldName = "Procesado"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 9
        Me.GridColumn17.Width = 67
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "mov_id"
        Me.GridColumn8.FieldName = "mov_id"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Mov_Tipo"
        Me.GridColumn9.FieldName = "req_tipo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "codigo_Bodega"
        Me.GridColumn10.FieldName = "codigo_Bodega"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "comp_no"
        Me.GridColumn11.FieldName = "comp_no"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "per_id"
        Me.GridColumn12.FieldName = "per_id"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Mes"
        Me.GridColumn13.FieldName = "Mes"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Seleccionar"
        Me.GridColumn16.FieldName = "selec"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 11
        Me.GridColumn16.Width = 76
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Codigo_Clase"
        Me.GridColumn18.FieldName = "Codigo_Clase"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Nombre_Clase"
        Me.GridColumn19.FieldName = "Nombre_Clase"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Fecha_Hora"
        Me.GridColumn20.DisplayFormat.FormatString = "{0:dd/MM/yyyy hh:mm tt}"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn20.FieldName = "Fecha_Hora"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.AllowFocus = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Comp_Tipo"
        Me.GridColumn21.FieldName = "Comp_Tipo"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.AllowFocus = False
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Movil PDA"
        Me.GridColumn22.FieldName = "Movil"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.AllowFocus = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 10
        Me.GridColumn22.Width = 67
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.LayoutControlItem1, Me.LayoutControlItem7, Me.lyImportarInventario})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(936, 621)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridDetalle
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(916, 550)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(175, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(606, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Desde
        Me.LayoutControlItem4.CustomizationFormText = "Desde:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Desde:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Hasta
        Me.LayoutControlItem5.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(175, 27)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(175, 27)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(175, 27)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Hasta:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(34, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(267, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(359, 27)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(175, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(92, 27)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckEdit1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(781, 24)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(135, 27)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(135, 27)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(135, 27)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CheckEdit2
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(781, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'lyImportarInventario
        '
        Me.lyImportarInventario.Control = Me.SimpleButton3
        Me.lyImportarInventario.Location = New System.Drawing.Point(626, 24)
        Me.lyImportarInventario.MaxSize = New System.Drawing.Size(155, 27)
        Me.lyImportarInventario.MinSize = New System.Drawing.Size(155, 27)
        Me.lyImportarInventario.Name = "lyImportarInventario"
        Me.lyImportarInventario.Size = New System.Drawing.Size(155, 27)
        Me.lyImportarInventario.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyImportarInventario.TextSize = New System.Drawing.Size(0, 0)
        Me.lyImportarInventario.TextVisible = False
        Me.lyImportarInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        Me.DockPanel1.ID = New System.Guid("e8d7e197-aabc-48af-b9a4-3a6c06ace91e")
        Me.DockPanel1.Location = New System.Drawing.Point(936, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(145, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(145, 621)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(138, 592)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmRequisas_List
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1081, 621)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmRequisas_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de Inventario"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyImportarInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Bodega As New VB.SysContab.BodegasDB
    Dim r As New VB.SysContab.Rutinas
    Dim DT_ROL As DataTable

    Public Begin As Boolean = False
    Dim requisa As New db_requisas

    Private Sub frmRequisas_List_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then lyImportarInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If e.KeyCode = Keys.F3 Then lyImportarInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub frmRequisas_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        ''
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        GetData()

        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        For i As Integer = 0 To vDatos.Columns.Count - 1
            vDatos.Columns(i).OptionsColumn.AllowEdit = False
            vDatos.Columns(i).OptionsColumn.AllowFocus = False
        Next

        vDatos.Columns("req_codigo").Visible = False
        vDatos.Columns("Codigo_Clase").Visible = False
        vDatos.Columns("codigo_bodega").Visible = False
        vDatos.Columns("Comp_Tipo").Visible = False
        vDatos.Columns("Comp_No").Visible = False

        vDatos.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        vDatos.Columns("Seleccionar").OptionsColumn.AllowFocus = True

        vDatos.Columns("Movimiento").Width = 200
        vDatos.Columns("Bodega").Width = 200
        vDatos.Columns("Referencia").Width = 120
    End Sub

    Public Sub GetData()
        If Not Begin Then ShowSplash("Cargando Movimientos...")
        '
        'Dim ds As New DataSet
        'ds = VB.SysContab.RequisasDB.GetList_Requisas("%", Desde.DateTime.Date, "%", Hasta.DateTime.Date)
        'GridDetalle.DataSource = ds.Tables(0).DefaultView

        GridDetalle.DataSource = db_requisas.Listar(Desde.DateTime.Date,
                                                    Hasta.DateTime.Date)           ' ObtieneDatos("JAR_GetRequisasList", EmpresaActual, Desde.DateTime.Date, Hasta.DateTime.Date)


        'GridView1.PopulateColumns()
        'FormatoGrid(vDatos)
        'Me.vDatos.Columns("Codigo_Clase").Visible = False
        'Me.vDatos.Columns("Nombre_Clase").Visible = False
        'Me.vDatos.Columns("mov_id").Visible = False
        ' Me.vDatos.BestFitColumns()
        '
        If Not Begin Then HideSplash()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''XtraForm1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Inicio = True
        ShowSplash()
        FrmRequisasnew.Dispose()
        Nuevo = "SI"
        FrmRequisasnew.MdiParent = Me.MdiParent
        FrmRequisasnew.IdRequisa = 0
        FrmRequisasnew.DT_ROL = DT_ROL
        FrmRequisasnew.Text = "Nuevo Movimiento"
        FrmRequisasnew.Show()
        FrmRequisasnew.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.vDatos.DataRowCount = 0 Then
            XtraMsg("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If
        '
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If
        '
        requisa.Detalles(vDatos.GetFocusedRowCellValue("req_codigo"))

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(requisa.Fecha.Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------

        'Verificar Cierre de Inventario
        If Not VerificarCierre_Inventario(requisa.Fecha.Date) Then
            Exit Sub
        End If
        '
        If requisa.Procesado Then
            XtraMsg("El Movimiento ya fue Procesado, no se puede Borrar", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If requisa.Contabilizado Then
            'Verificar que el movimiento no sea una Factura de Compra.
            If ObtieneDatos("sp_BuscarFacturaCompra", requisa.Factura, requisa.Proveedor, EmpresaActual).Rows.Count = 0 Then
                'Verificar que no sea un registro generado por el procesamiento de los proyectos.
                If requisa.EsProyecto = 0 Then
                    XtraMsg("El Movimiento ya fue Contabilizado, no se puede Borrar", MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
        '       
        If requisa.ALiquidar Then
            XtraMsg("Este movimiento corresponde a una Liquidación, no puede ser borrado.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If requisa.Clase = "M" Then
            XtraMsg("Favor vaya al módulo de Traslados para porder Borrar este Movimiento!", MessageBoxIcon.Error)
            Exit Sub
        End If

        'If Me.vDatos.GetFocusedRowCellValue("Contabilizado") Then
        '    If db_requisas.Buscar_Requisa(vDatos.GetFocusedRowCellValue("req_codigo"), EmpresaActual) = 0 Then
        '        XtraMsg("El Movimiento ya fue Contabilizado, no se puede Borrar", MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'End If
        '
        'If vDatos.GetFocusedRowCellValue("Contabilizado") Then
        '    If vDatos.GetFocusedRowCellValue("Tipo") = "Entrada" Then
        '        XtraMsg("Los movimientos de Entrada no se pueden dehacer!")
        '        Exit Sub
        '    End If
        'End If
        '
        'If vDatos.GetFocusedRowCellValue("Procesado") Then
        '    XtraMsg("El Movimiento ya fue Procesado, no se puede Borrar", MessageBoxIcon.Error)
        '    Exit Sub
        'End If       
        '
        'If vDatos.GetFocusedRowCellValue("A Liquidar") Then
        '    XtraMsg("Este movimiento corresponde a una Liquidación, no puede ser borrado.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        'If vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Codigo_Clase") = "M" Then
        '    XtraMsg("Favor vaya al módulo de Traslados para porder Borrar este Movimiento!", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        If Not XtraMsg2("Esta seguro de borrar el Movimiento de Inventario#: " & vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "req_codigo").ToString()) Then
            'Verificar si la requisa esta contabilizada
            'Y si tiene distribucion            

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            'Try
            '    If _
            '        GuardaDatosTrans("sp_MovimientoDelete " & Me.vDatos.GetFocusedRowCellValue("req_codigo") & "," & EmpresaActual) Then
            '        'VB.SysContab.RequisasDB.Delete(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "req_codigo"))
            '        '
            '        VB.SysContab.Rutinas.okTransaccion()
            '        GetData()
            '        '
            '    Else
            '        XtraMsg("ERROR al Borrar Datos, Consulte al administrador del Sistema", MessageBoxIcon.Error)
            '    End If
            'Catch ex As Exception
            '    XtraMsg(ex.Message, MessageBoxIcon.Error)
            '    VB.SysContab.Rutinas.ErrorTransaccion()
            '    Exit Sub
            'End Try
            Exit Sub
        End If
        '        
        If requisa.BorrarMovimiento(vDatos.GetFocusedRowCellValue("req_codigo")) Then
            GetData()
            Dim f As frmFacturasComprasList = frmFacturasComprasList.Instance()
            If f.Created Then f.Cargar()
        End If

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.GridDetalle)

        'Dim lds As New DataSet
        'Dim Reporte As New rptRequisa
        'Dim fReporte As New frmReportes

        'lds = VB.SysContab.RequisasDB.GetList_RequisaReporte(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "req_codigo"))
        'lds.WriteXml(Application.StartupPath & "\xml\Req.xml", XmlWriteMode.WriteSchema)
        'lds.Tables.Clear()
        'lds = VB.SysContab.RequisasDB.GetList_RequisaDetalle(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "req_codigo"))
        'lds.WriteXml(Application.StartupPath & "\xml\ReqDet.xml", XmlWriteMode.WriteSchema)
        'Reporte.Database.Tables("Requisa").Location = Application.StartupPath & "\xml\Req.xml"
        'Reporte.Database.Tables("RequisaDetalle").Location = Application.StartupPath & "\xml\ReqDet.xml"
        'Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoEmpresa.xml"

        'fReporte.crvReportes.ReportSource = Reporte
        'fReporte.Show()
    End Sub

    Private Sub cmdContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click
        ' ''Ver si la requisa es de entrada y solo registro para no contabilizarla
        ''If VB.SysContab.RequisasDB.GetDetails(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "req_codigo")).Registro Then
        ''    MsgBox("La requisa es solamente de REGISTRO de datos, no se CONTABILIZA", MsgBoxStyle.Information, "STS-Contab")
        ''    Exit Sub
        ''End If

        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        'Dim selec As Boolean = False, contabilizar As Boolean = False
        'For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '    If Me.vDatos.GetRowCellValue(i, "selec") Then
        '        selec = True
        '        If Me.vDatos.GetRowCellValue(i, "Contabilizado") Then
        '            contabilizar = True
        '        End If
        '    End If
        'Next
        ''
        'If Not selec Then
        '    XtraMsg("Seleccione al Menos 1 registro de la Lista", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        ''
        'If contabilizar Then
        '    XtraMsg("Existen registros seleccionados que ya fueron Contabilizados", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        'Verificar Cierre de Inventario
        If Not VerificarCierre_Inventario(CDate(vDatos.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If

        If vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Contabilizado") = True Then
            XtraMsg("El Movimiento de Inventario ya esta contabilizado", MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Dim f As DataGridTextBox.frmRequisa_Contabilizar = f.Instance

        frmRequisaContab.Dispose()
        '
        With My.Forms.frmRequisaContab
            Nuevo = "SI"
            .Requisa = vDatos.GetFocusedRowCellValue("req_codigo")
            .TRequisa = Mid(vDatos.GetFocusedRowCellValue("Tipo").ToString, 1, 1).ToString     'vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "req_tipo")
            .Bodega = vDatos.GetFocusedRowCellValue("codigo_bodega")

            If EmpresaActual = 19 Or
                EmpresaActual = 21 Or
                 EmpresaActual = 23 Or
                  EmpresaActual = 24 Or
                   EmpresaActual = 29 Or
                    EmpresaActual = 30 Then

                .txtConcepto.Text = $"{IIf(vDatos.GetFocusedRowCellValue("Tipo") = "Entrada", "ENTRADA A ALMACEN POR: ", "SALIDA DE ALMACEN POR: ")}{vDatos.GetFocusedRowCellValue("Movimiento").ToString.ToUpper}, EN CONCEPTO DE: " +
                                    db_requisas.GetDetalles(vDatos.GetFocusedRowCellValue("req_codigo")).Rows.Item(0)("Concepto")
            Else
                .txtConcepto.Text = IIf(vDatos.GetFocusedRowCellValue("Tipo") = "Entrada", "ENTRADA A ALMACEN POR: ", "SALIDA DE ALMACEN POR: ") +
                                    vDatos.GetFocusedRowCellValue("Movimiento").ToString.ToUpper + ", EN BODEGA: " +
                                    vDatos.GetFocusedRowCellValue("Bodega").ToString.ToUpper + ", CON REFERENICA #:" +
                                    IsNull(vDatos.GetFocusedRowCellValue("Referencia"), "").ToString.ToUpper
            End If



            .Fecha.DateTime = vDatos.GetFocusedRowCellValue("Fecha")
            .Referencia = vDatos.GetFocusedRowCellValue("Referencia")
            .Comp_Tipo = vDatos.GetFocusedRowCellValue("Comp_Tipo")

            .MdiParent = Me.MdiParent
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        Inicio = True
        ShowSplash()
        FrmRequisasnew.Dispose()
        Nuevo = "SI"
        FrmRequisasnew.MdiParent = Me.MdiParent
        FrmRequisasnew.IdRequisa = vDatos.GetFocusedRowCellValue("req_codigo")
        FrmRequisasnew.DT_ROL = DT_ROL
        FrmRequisasnew.Text = "Editar Movimiento"
        FrmRequisasnew.Show()
        FrmRequisasnew.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False
        'Dim f As FrmRequisasnew = FrmRequisasnew.Instance()
        'Nuevo = "SI"
        'f.MdiParent = Me.MdiParent
        'f.IdRequisa = vDatos.GetFocusedRowCellValue("req_codigo")
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub GridDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDetalle.DoubleClick
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = '" & cmdEditar.Name & "'")

            If dr.Length > 0 Then cmdEditar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If vDatos.DataRowCount = 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        ''Verificar Cierre del Día
        ''---------------------------------------------------------------------
        'If Not VerificarCierre(CDate(vDatos.GetFocusedRowCellValue("Fecha")).Date) Then
        '    Exit Sub
        'End If
        ''-------------------------------------------------------------------

        ''Verificar Cierre de Inventario
        'If Not VerificarCierre_Inventario(CDate(vDatos.GetFocusedRowCellValue("Fecha")).Date) Then
        '    Exit Sub
        'End If

        Dim selec As Boolean = False, procesado As Boolean = False

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If Me.vDatos.GetRowCellValue(i, "Seleccionar") Then
                selec = True
                If Me.vDatos.GetRowCellValue(i, "Procesado") Then
                    procesado = True
                End If
            End If
        Next
        '
        If Not selec Then
            XtraMsg("Seleccione al Menos 1 registro de la Lista", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If procesado Then
            XtraMsg("Existen registros seleccionados que ya fueron procesados", MessageBoxIcon.Warning)
            Exit Sub
        End If

        vDatos.Columns("Fecha").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
        Dim FechaMaxima As Date = CDate(vDatos.Columns("Fecha").SummaryItem.SummaryValue).Date

        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(FechaMaxima) Then
            Exit Sub
        End If
        '
        Dim UltimoCierre As Date = UltimoDiaDelMes(UltimoCierreInventario().Date)
        'Validar que no puedan procesar movimientos sin haber cerrado el inventario.
        If UltimoCierre < FechaMaxima Then
            XtraMsg("El Ultimo Cierre de Inventario es: " & UltimoCierre.ToShortDateString & vbCrLf &
                            "Los Movimientos de inventario seleccionados no pueden se procesados.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '*******************************************************************************************
        '
        'Valirdar Para los Movimientos de Salida
        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If vDatos.GetRowCellValue(i, "Tipo") = "Salida" Then
                If Me.vDatos.GetRowCellValue(i, "Seleccionar") Then
                    Dim dtSalida As New DataTable
                    Dim da As New SqlDataAdapter("sp_ValidarMovimiento " & Me.vDatos.GetRowCellValue(i, "req_codigo") & "," & EmpresaActual,
                                         VB.SysContab.Rutinas.AbrirConexion())
                    da.Fill(dtSalida)

                    If dtSalida.Rows.Count > 0 Then
                        If Not XtraMsg2("El Movimiento #: " + Me.vDatos.GetRowCellValue(i, "req_codigo").ToString + "  No se puede procesar." + vbCrLf +
                                "Existen Productos que no tiene existencias, Desea Procesar de todas Formas?") Then
                            Exit Sub
                        End If
                    End If
                End If
            End If
        Next

        'Generar DT con el detalle de todos los movimientos seleccionados
        Dim dtMov As New DataTable
        Dim Valida As Boolean = False

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If Me.vDatos.GetRowCellValue(i, "Seleccionar") Then
                ''Validar si ya existe cierre de inventario previo.
                'If UltimoCierreInventario().AddMonths(1).Date < CDate(vDatos.GetRowCellValue(i, "Fecha")) Then
                '    XtraMsg("El Ultimo Cierre de Inventario es: " & UltimoCierreInventario().ToShortDateString & vbCrLf &
                '            "El Movimiento de Inventario #: " & vDatos.GetRowCellValue(i, "req_codigo").ToString & " No puede ser procesado", MessageBoxIcon.Error)
                '    Valida = True
                'End If

                '*******************************************************************************************
                '' Validar Cierre de Inventario
                'If Not VerificarCierre_Inventario(CDate(vDatos.GetRowCellValue(i, "Fecha"))) Then
                '    XtraMsg("El Movimiento de Inventario #: " & vDatos.GetRowCellValue(i, "req_codigo").ToString & " No puede ser procesado", MessageBoxIcon.Error)
                '    Valida = True
                'Else

                Dim da As New SqlDataAdapter("sp_MovimientoDetalle " & Me.vDatos.GetRowCellValue(i, "req_codigo") & "," & EmpresaActual,
                                     VB.SysContab.Rutinas.AbrirConexion())
                da.Fill(dtMov)
                'End If
                '*******************************************************************************************
            End If
        Next
        '
        If Valida Then Exit Sub

        frmProcesarMovimientos.dtMov = dtMov
        frmProcesarMovimientos.Permitir = True
        frmProcesarMovimientos.ShowDialog()
        frmProcesarMovimientos.Dispose()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.vDatos.DataRowCount = 0 Then
            Exit Sub
        End If
        '
        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If Me.vDatos.GetRowCellValue(i, "Procesado") Then
                Me.vDatos.SetRowCellValue(i, "Seleccionar", Me.CheckEdit1.Checked)
            Else
                If Me.vDatos.GetRowCellValue(i, "Codigo_Clase") = "M" Then  ' Traslados                    
                    Me.vDatos.SetRowCellValue(i, "Seleccionar", False)
                Else
                    Me.vDatos.SetRowCellValue(i, "Seleccionar", Me.CheckEdit1.Checked)
                End If
            End If
        Next
        vDatos.RefreshData()
    End Sub



    Private Sub vDatos_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        Me.CheckEdit2.Checked = False
    End Sub

    Private Sub vDatos_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "Contabilizado" Then
            If Me.vDatos.GetRowCellValue(e.RowHandle, "Contabilizado") Then
                e.Appearance.BackColor = Color.Salmon
            End If
        End If
        '
        If e.Column.FieldName = "Procesado" Then
            If Me.vDatos.GetRowCellValue(e.RowHandle, "Procesado") Then
                e.Appearance.BackColor = Color.DarkSalmon
            End If
        End If
        '
        If e.Column.FieldName = "A Liquidar" Then
            If Me.vDatos.GetRowCellValue(e.RowHandle, "A Liquidar") Then
                e.Appearance.BackColor = Color.HotPink
            End If
        End If
    End Sub

    Private Sub btnVerInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerInventario.Click
        If vDatos.DataRowCount = 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        Dim selec As Boolean = False, procesado As Boolean = True

        'For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '    If Me.vDatos.GetRowCellValue(i, "selec") Then
        '        selec = True
        '        If Not Me.vDatos.GetRowCellValue(i, "Procesado") Then
        '            procesado = False
        '        End If
        '    End If
        'Next
        ''
        'If Not selec Then
        '    XtraMsg("Seleccione al Menos 1 registro de la Lista", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        ''
        'If Not procesado Then
        '    XtraMsg("Existen registros seleccionados que no han sido procesados", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        '
        'Valirdar Para los Movimientos de Salida

        'If vDatos.GetFocusedRowCellValue("Tipo") = "Salida" Then
        '    For i As Integer = 0 To Me.vDatos.DataRowCount - 1
        '        If Me.vDatos.GetRowCellValue(i, "selec") Then
        '            Dim dtSalida As New DataTable
        '            Dim da As New SqlDataAdapter("sp_ValidarMovimiento " & Me.vDatos.GetRowCellValue(i, "req_codigo") & "," & EmpresaActual, _
        '                                 VB.SysContab.Rutinas.AbrirConexion())
        '            da.Fill(dtSalida)

        '            If dtSalida.Rows.Count > 0 Then
        '                XtraMsg("El Movimiento #: " + Me.vDatos.GetRowCellValue(i, "req_codigo").ToString + "  No se puede procesar." + vbCrLf + _
        '                        "Existen Productos que no tiene existencias.", MessageBoxIcon.Error)
        '                Exit Sub
        '            End If
        '        End If
        '    Next
        'End If

        'Generar DT con el detalle de todos los movimientos seleccionados
        Dim dtMov As New DataTable

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            If Me.vDatos.GetRowCellValue(i, "Procesado") Then
                Dim da As New SqlDataAdapter("sp_MovimientoDetalle " & Me.vDatos.GetRowCellValue(i, "req_codigo") & "," & EmpresaActual,
                                     VB.SysContab.Rutinas.AbrirConexion())
                da.Fill(dtMov)
            End If
        Next
        '
        With My.Forms.frmProcesarMovimientos
            .dtMov = dtMov
            .btnProcesar.Enabled = False
            ''.Fecha.Visible = False
            ''.LabelControl1.Visible = False
            .Permitir = False

            .ProgressBarControl1.Properties.Minimum = 0
            .ProgressBarControl1.Properties.Maximum = 100

            For i As Integer = 0 To 100
                .ProgressBarControl1.Increment(1)
                .ProgressBarControl1.Refresh()
            Next

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        GetData()
    End Sub

    Private Sub btnProcesarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarT.Click
        vDatos.Columns("Fecha").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
        Dim FechaMaxima As Date = CDate(vDatos.Columns("Fecha").SummaryItem.SummaryValue).Date


        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(FechaMaxima) Then
            Exit Sub
        End If
        '*******************************************************************************************
        '
        'Validar que no puedan procesar movimientos sin haber cerrado el inventario.
        If UltimoCierreInventario().AddMonths(1).Date < FechaMaxima Then
            XtraMsg("El Ultimo Cierre de Inventario es: " & UltimoCierreInventario().ToShortDateString & vbCrLf &
                            "Los Traslados entre Bodegas no pueden se procesados para las fechas seleccionadas.", MessageBoxIcon.Error)
            Exit Sub
        End If

        ''
        frmProcesarTraslados.Dispose()
        ''
        With frmProcesarTraslados
            .Desde = Desde.DateTime.Date
            .Hasta = Hasta.DateTime.Date
            .LabelControl1.Text = "Periodo : Desde " + Desde.DateTime.ToShortDateString + " Hasta " + Hasta.DateTime.ToShortDateString
            .Permitir = False
            .Begin = True
            .ShowDialog()
        End With
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked Then Me.vDatos.ColumnsCustomization()
        If Not CheckEdit2.Checked Then Me.vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vDatos.FocusedRowChanged

    End Sub

    Private Sub vDatos_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.ShownEditor

    End Sub

    Private Sub vDatos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        'If Me.vDatos.GetRowCellValue(e.RowHandle, "Codigo_Clase") = "M" Then
        '    If Me.vDatos.GetRowCellValue(e.RowHandle, "selec") Then
        '        e.Valid = False
        '    End If
        'End If        
    End Sub

    Private Sub vDatos_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vDatos.ValidatingEditor
        If Me.vDatos.FocusedRowHandle < 0 Then Exit Sub
        ' ''
        'If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Codigo_Clase") = "M" Then
        '    If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "selec") Then
        '        e.Valid = False
        '    End If
        'End If
    End Sub

    Private Sub vDatos_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vDatos.ShowingEditor
        If vDatos.GetRowCellValue(Me.vDatos.FocusedRowHandle, "Procesado") And Me.vDatos.GetRowCellValue(Me.vDatos.FocusedRowHandle, "Contabilizado") Then e.Cancel = True

        '' If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Codigo_Clase") = "M" And Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "selec") And vDatos.GetRowCellValue(Me.vDatos.FocusedRowHandle, "Procesado") Then e.Cancel = True

        'If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Codigo_Clase") = "M" Then
        '    If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "selec") Then e.Cancel = True
        'End If
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Seleccionar" Then
            If Me.vDatos.GetRowCellValue(e.RowHandle, "Codigo_Clase") = "M" Then
                If Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Seleccionar") Then
                    If Not Me.vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Procesado") Then
                        Me.vDatos.SetRowCellValue(e.RowHandle, "Seleccionar", False)
                        Me.vDatos.RefreshData()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        requisa.Detalles(vDatos.GetFocusedRowCellValue("req_codigo"))
        '
        If requisa.Clase = "M" Then 'Si la requisa es un Traslado, entonces imprimir sobre el formato de Traslado.
            Dim Entrada As Integer = IIf(requisa.Tipo = "E", requisa.req_codigo, requisa.req_codigo_referencia)
            Dim Salida As Integer = IIf(requisa.Tipo = "S", requisa.req_codigo, requisa.req_codigo_referencia)

            requisa.Detalles(Salida)
            Dim BodegaO As String = requisa.Bodega

            Dim Bodega As String = BodegaO

            ImprimirTraslado(Entrada, Salida, BodegaO)
        Else
            ImprimirRequisa()   'Imprimir Requisa con formato de Requisas.
        End If

    End Sub

    Sub ImprimirRequisa()

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'ShowSplash("Imprimiendo...")

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 24 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptRequisa.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        ShowSplash("Imprimiendo...")

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(24, "rptRequisa")

        Dim rpt As rptEntrada_Bodega

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptRequisa.repx", True)
        Else
            rpt = New rptEntrada_Bodega
        End If

        ' Dim rpt As New rptEntrada_Bodega
        'rpt.DataSource = ObtieneDatos("sp_GetRequisaImpresa", vDatos.GetFocusedRowCellValue("req_codigo"), vDatos.GetFocusedRowCellValue("Referencia"), EmpresaActual)

        VistaPreviaDX(rpt,
                      ObtieneDatos("sp_GetRequisaImpresa", vDatos.GetFocusedRowCellValue("req_codigo"), vDatos.GetFocusedRowCellValue("Referencia"), EmpresaActual),
                      "Movimiento de Inventario No. " & vDatos.GetFocusedRowCellValue("req_codigo").ToString())
        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Sub ImprimirTraslado(Entrada As Integer, Salida As Integer, Bodega As String)

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        Try
            ' Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 25 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("sp_sel_Bodegas", Bodega, EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            '
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptTraslado.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptTrasladoBodegas

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptTraslado.repx", True)
        Else
            rpt = New rptTrasladoBodegas
        End If

        'rpt.DataSource = ObtieneDatos("JAR_ImprimirTraslado", Entrada, Salida, EmpresaActual)

        VistaPreviaDX(rpt,
                      ObtieneDatos("JAR_ImprimirTraslado", Entrada, Salida, EmpresaActual),
                      "Traslados Entre Bodega")

        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()

    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        With FrmConfiguraCheque
            .Tipo = 24
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim DT As DataTable = ObtieneDatos("JAR_ImportarAntiguedadInventario", EmpresaActual)

        If DT.Rows.Count = 0 Then
            XtraMsg("La Tabla no contiene registros para importar", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim FACT As String = "NOTHING"

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try

            ShowSplash("Importando Inventario...")

            'Distinguir Proveedores Primero
            Dim Proveedor = From row In DT.AsEnumerable()
                            Select row.Field(Of Object)("IdProveedor") Distinct

            For Each IdProveedor As Object In Proveedor

                If Not IdProveedor Is Nothing Then

                    Dim DT_PROV As DataTable = DT.Select("IdProveedor ='" & IdProveedor & "'").CopyToDataTable

                    'Distinguir Facturas Diferentes por proveedor
                    Dim Factura = From row In DT_PROV.AsEnumerable()
                                  Select row.Field(Of String)("Factura") Distinct

                    For Each NoFactura As Object In Factura
                        If Not NoFactura Is Nothing Then

                            FACT = NoFactura

                            Dim DT_DETALLE As DataTable = DT_PROV.Select("Factura ='" & NoFactura & "'").CopyToDataTable
                            ' Dim DT_DETALLE As DataTable = DT_ANTIGUEDAD.Select("Fecha ='" & CDate(s).Date & "'").CopyToDataTable

                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Codigo", SqlDbType.Int, 4, ParameterDirection.Output, 0)

                            Conn.EjecutarComando("_GetList_RequisaCodigoNuevo")
                            Dim Requisa As Integer = Conn.GetParameter("Codigo").Valor

                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                            Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
                            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, DT_DETALLE.Rows.Item(0)("Fecha"))
                            Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, DT_DETALLE.Rows.Item(0)("Bodega"))
                            Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
                            Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, 0)
                            Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, NoFactura)
                            Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, DT_DETALLE.Rows.Item(0)("IdMov"))
                            Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, NoFactura)
                            Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, DT_DETALLE.Rows.Item(0)("Concepto"))
                            Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
                            Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, "")
                            Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, "")
                            Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                            Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                            Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                            Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                            Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                            Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                            Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, 0)
                            Conn.AddParameter("IdProveedor", SqlDbType.Int, 5, ParameterDirection.Input, IdProveedor)

                            Conn.EjecutarComando("SP_Requisas_Add")

                            For i = 0 To DT_DETALLE.Rows.Count - 1
                                'Agregar el detalle de la requisa
                                If DT_DETALLE.Rows.Item(i)("Cantidad") > 0 Then
                                    Conn.RemoveParameters()
                                    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                                    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                                    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("Codigo"))
                                    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                                    Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("Cantidad"))
                                    Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT_DETALLE.Rows.Item(i)("Costo"))
                                    Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")

                                    Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                                End If
                            Next
                            '
                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Requisa", SqlDbType.Int, 4, ParameterDirection.Input, Requisa)
                            Conn.AddParameter("Contabilizar", SqlDbType.Bit, 4, ParameterDirection.Input, True)
                            Conn.AddParameter("Distribuir", SqlDbType.Bit, 4, ParameterDirection.Input, False)
                            Conn.AddParameter("Comprobante", SqlDbType.Int, 4, ParameterDirection.Input, 0)
                            Conn.AddParameter("Periodo", SqlDbType.Int, 4, ParameterDirection.Input, 0)
                            Conn.AddParameter("Mes", SqlDbType.Int, 4, ParameterDirection.Input, CDate(DT_DETALLE.Rows.Item(0)("Fecha")).Month)

                            Conn.EjecutarComando("_Requisa_Contabilizar")
                        End If
                    Next
                End If
            Next
            '

            Conn.CompletarTransaccion()
            HideSplash()
            XtraMsg("Inventario Importado con Exito!")

            GetData()
        Catch ex As Exception
            HideSplash()
            XtraMsg("ERROR: " & ex.Message & vbCrLf & FACT, MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Private Sub bProcesarCombos_Click(sender As Object, e As EventArgs) Handles bProcesarCombos.Click
        frmCombosProcesar.Dispose()
        '
        With frmCombosProcesar
            .MdiParent = Me.MdiParent
            .Text = "Procesar Combos / Kit"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub bImprimirEtiquetas_Click(sender As Object, e As EventArgs) Handles bImprimirEtiquetas.Click
        frmRequisasImprimirEtiquetas.Dispose()
        With frmRequisasImprimirEtiquetas
            '.MdiParent = Me.MdiParent
            .Text = "Imprimir Etiquetas"
            .req_codigo = vDatos.GetFocusedRowCellValue("req_codigo")
            .Show()
            '.WindowState = FormWindowState.Maximized
        End With
    End Sub
End Class
