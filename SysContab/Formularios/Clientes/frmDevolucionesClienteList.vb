
Imports ClasesBLL
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDevolucionesClienteList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDevolucionesClienteList = Nothing

    Public Shared Function Instance() As frmDevolucionesClienteList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDevolucionesClienteList()
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
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdVerDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaBodega As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaBodegaList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents fDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bGenearMov As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesClienteList))
        Me.cmdEntradaBodegaList = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.fHasta = New DevExpress.XtraEditors.DateEdit()
        Me.cmdEntradaBodega = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bGenearMov = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerDevolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEntradaBodegaList
        '
        Me.cmdEntradaBodegaList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEntradaBodegaList.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaBodegaList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaBodegaList.Location = New System.Drawing.Point(12, 343)
        Me.cmdEntradaBodegaList.Name = "cmdEntradaBodegaList"
        Me.cmdEntradaBodegaList.Size = New System.Drawing.Size(387, 22)
        Me.cmdEntradaBodegaList.StyleController = Me.LayoutControl1
        Me.cmdEntradaBodegaList.TabIndex = 162
        Me.cmdEntradaBodegaList.Text = "Ver Entradas a &Bodegas"
        Me.cmdEntradaBodegaList.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cmdContabilizar)
        Me.LayoutControl1.Controls.Add(Me.cmdEntradaBodegaList)
        Me.LayoutControl1.Controls.Add(Me.fHasta)
        Me.LayoutControl1.Controls.Add(Me.cmdEntradaBodega)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.fDesde)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(831, 161, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(527, 420)
        Me.LayoutControl1.TabIndex = 167
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(176, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 169
        Me.SimpleButton1.Text = "&Buscar"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdContabilizar.Location = New System.Drawing.Point(12, 343)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(503, 22)
        Me.cmdContabilizar.StyleController = Me.LayoutControl1
        Me.cmdContabilizar.TabIndex = 163
        Me.cmdContabilizar.Text = "&Contabilizar"
        Me.cmdContabilizar.Visible = False
        '
        'fHasta
        '
        Me.fHasta.EditValue = Nothing
        Me.fHasta.Location = New System.Drawing.Point(49, 36)
        Me.fHasta.Name = "fHasta"
        Me.fHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fHasta.Properties.Appearance.Options.UseFont = True
        Me.fHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fHasta.Size = New System.Drawing.Size(123, 20)
        Me.fHasta.StyleController = Me.LayoutControl1
        Me.fHasta.TabIndex = 168
        '
        'cmdEntradaBodega
        '
        Me.cmdEntradaBodega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEntradaBodega.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaBodega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaBodega.Location = New System.Drawing.Point(12, 343)
        Me.cmdEntradaBodega.Name = "cmdEntradaBodega"
        Me.cmdEntradaBodega.Size = New System.Drawing.Size(250, 22)
        Me.cmdEntradaBodega.StyleController = Me.LayoutControl1
        Me.cmdEntradaBodega.TabIndex = 161
        Me.cmdEntradaBodega.Text = "&Entrada a Bodega"
        Me.cmdEntradaBodega.Visible = False
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 64)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(503, 344)
        Me.dgDatos.TabIndex = 164
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'fDesde
        '
        Me.fDesde.EditValue = Nothing
        Me.fDesde.Location = New System.Drawing.Point(49, 12)
        Me.fDesde.Name = "fDesde"
        Me.fDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fDesde.Properties.Appearance.Options.UseFont = True
        Me.fDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fDesde.Size = New System.Drawing.Size(123, 20)
        Me.fDesde.StyleController = Me.LayoutControl1
        Me.fDesde.TabIndex = 4
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdEntradaBodega
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(254, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdEntradaBodegaList
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(391, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdContabilizar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(507, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem11, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(527, 420)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.fDesde
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.fHasta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(164, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dgDatos
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(507, 348)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(262, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(245, 52)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(164, 10)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(164, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(98, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(12, 343)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(109, 36)
        Me.bSalir.StyleController = Me.LayoutControl2
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "&Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bGenearMov)
        Me.LayoutControl2.Controls.Add(Me.bImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdDevoluciones)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.bBorrar)
        Me.LayoutControl2.Controls.Add(Me.bSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdVerDevolucion)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(974, 525, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(133, 391)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bGenearMov
        '
        Me.bGenearMov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGenearMov.Appearance.Options.UseTextOptions = True
        Me.bGenearMov.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGenearMov.Enabled = False
        Me.bGenearMov.ImageOptions.Image = CType(resources.GetObject("bGenearMov.ImageOptions.Image"), System.Drawing.Image)
        Me.bGenearMov.Location = New System.Drawing.Point(12, 178)
        Me.bGenearMov.Name = "bGenearMov"
        Me.bGenearMov.Size = New System.Drawing.Size(108, 38)
        Me.bGenearMov.StyleController = Me.LayoutControl2
        Me.bGenearMov.TabIndex = 169
        Me.bGenearMov.Text = "&Genear Movimiento"
        '
        'bImprimir
        '
        Me.bImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(12, 96)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(109, 36)
        Me.bImprimir.StyleController = Me.LayoutControl2
        Me.bImprimir.TabIndex = 169
        Me.bImprimir.Text = "&Imprimir"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Appearance.Options.UseTextOptions = True
        Me.cmdDevoluciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDevoluciones.Enabled = False
        Me.cmdDevoluciones.ImageOptions.Image = CType(resources.GetObject("cmdDevoluciones.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDevoluciones.Location = New System.Drawing.Point(12, 12)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(108, 38)
        Me.cmdDevoluciones.StyleController = Me.LayoutControl2
        Me.cmdDevoluciones.TabIndex = 169
        Me.cmdDevoluciones.Text = "&Nueva Devolución"
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 303)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(109, 36)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 164
        Me.bExportar.Text = "&Exportar"
        '
        'bBorrar
        '
        Me.bBorrar.Appearance.Options.UseTextOptions = True
        Me.bBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(12, 136)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(108, 38)
        Me.bBorrar.StyleController = Me.LayoutControl2
        Me.bBorrar.TabIndex = 165
        Me.bBorrar.Text = "&Borrar Devolución"
        '
        'cmdVerDevolucion
        '
        Me.cmdVerDevolucion.Appearance.Options.UseTextOptions = True
        Me.cmdVerDevolucion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerDevolucion.Enabled = False
        Me.cmdVerDevolucion.ImageOptions.Image = CType(resources.GetObject("cmdVerDevolucion.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVerDevolucion.Location = New System.Drawing.Point(12, 54)
        Me.cmdVerDevolucion.Name = "cmdVerDevolucion"
        Me.cmdVerDevolucion.Size = New System.Drawing.Size(108, 38)
        Me.cmdVerDevolucion.StyleController = Me.LayoutControl2
        Me.cmdVerDevolucion.TabIndex = 160
        Me.cmdVerDevolucion.Text = "&Ver Devolución"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(133, 391)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdVerDevolucion
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bBorrar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bExportar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 291)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bSalir
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 208)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(113, 83)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdDevoluciones
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bImprimir
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(113, 40)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bGenearMov
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(688, 508)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
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
        Me.DockPanel1.ID = New System.Guid("d17a83ae-b23b-4e32-8056-0e27e73bd0be")
        Me.DockPanel1.Location = New System.Drawing.Point(527, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 420)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 391)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmDevolucionesClienteList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(667, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmDevolucionesClienteList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    'Dim Cajas As New VB.SysContab.CajasDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    'Dim r As New VB.SysContab.Rutinas()
    'Dim ds As DataSet

    Dim Devoluciones As New VB.SysContab.DevolucionesClienteDB()
    Dim DevolucionBodega As New VB.SysContab.DevolucionesClienteBodegaDB()

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)

        ' Dim Tabla As DataTable

        'Dim dsFormaPago As DataSet
        'Dim i As Integer

        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)

        'dtpFecha1.Enabled = False
        'dtpFecha2.Enabled = False

        'dtpFecha1.Value = r.Fecha
        'dtpFecha2.Value = r.Fecha

        'Fecha1 = ""
        'Fecha2 = ""

        'cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
        'cbClientes.ValueMember = "Codigo"
        'cbClientes.DisplayMember = "Nombre"
        'cbClientes.SelectedValue = 0
        '  ds = Devoluciones.GetList("", 0, "", "")

        'dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        'Tabla = ds.Tables("DevolucionesCliente")

        'r.FormatGenerico(dgFacturasClientes, Tabla)
        'dgFacturasClientes.CaptionText = "          Devoluciones de Clientes"
        'r.ComboAutoComplete(Me.cbClientes)
        '

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        fDesde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        fHasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Cargar()
        ArmarGrid()
    End Sub

    Sub Cargar()
        Me.dgDatos.DataSource = Devoluciones.GetList(
            "",
            0,
            fDesde.DateTime.Date,
            fHasta.DateTime.Date) _
            .Tables(0)
    End Sub

    Sub ArmarGrid()
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '
        Me.vDatos.Columns("Comp_No").Visible = False
        Me.vDatos.Columns("Per_Id").Visible = False
        Me.vDatos.Columns("Mes").Visible = False
        '
        Me.vDatos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    'Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
    '    Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

    '    f.etCaja.Text = Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

    '    NuevaFactura = "SI"

    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.Show()

    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '

    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '
    End Sub

    'Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
    '    Try
    '        If IsNumeric(cbTipoFactura.SelectedValue) And cbTipoFactura.Enabled = True Then
    '            dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.CheckedChanged
    '    If cbTipo.Checked = True Then
    '        dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        cbTipoFactura.Enabled = True
    '    Else
    '        cbTipoFactura.Enabled = False
    '        dgFacturasClientes.DataSource = Clientes.ListFacturas("").Tables("Facturas_Ventas").DefaultView
    '    End If
    'End Sub


    'Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Try
    '        If checkBoxFecha.Checked = True Then
    '            dtpFecha1.Enabled = True
    '            dtpFecha2.Enabled = True
    '            Fecha1 = dtpFecha1.Value.Date
    '            Fecha2 = dtpFecha2.Value.Date
    '        Else
    '            dtpFecha1.Enabled = False
    '            dtpFecha2.Enabled = False
    '            Fecha1 = ""
    '            Fecha2 = ""

    '        End If

    '        Cargar()

    '        'ds = Devoluciones.GetList(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
    '        'dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
    '    Catch ex As ExecutionEngineException
    '        MsgBox(ex.Message & " checkBoxFecha_CheckedChanged")
    '    End Try
    'End Sub

    'Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Try
    '        Cargar()
    '        'Fecha1 = dtpFecha1.Value.Date
    '        'Fecha2 = dtpFecha2.Value.Date
    '        'ds = Devoluciones.GetList(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
    '        'dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
    '    Catch ex As Exception
    '        'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
    '    End Try
    'End Sub

    'Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Try
    '        Cargar()
    '        'Fecha1 = dtpFecha1.Value.Date
    '        'Fecha2 = dtpFecha2.Value.Date
    '        'ds = Devoluciones.GetList(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
    '        'dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
    '    Catch ex As Exception
    '        'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
    '    End Try
    'End Sub

    'Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If
    '    Try
    '        Cargar()
    '        'ds = Devoluciones.GetList(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
    '        'dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
    '    Catch ex As Exception
    '        'MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
    '    End Try
    'End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDevolucion.Click

        'If Clientes.FacturaDetalleDevolucion(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)).Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    MsgBox("La Factura no tiene productos para devolución", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        ''Mostrar la Lista de Facturas
        'If ds.Tables("DevolucionesCliente").Rows.Count = 0 Then
        '    MsgBox("Seleccione un registro", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        Dim frm As DataGridTextBoxCombo.frmDevolucionClienteVer = DataGridTextBoxCombo.frmDevolucionClienteVer.Instance()
        frm.Dispose()

        Dim f As DataGridTextBoxCombo.frmDevolucionClienteVer = DataGridTextBoxCombo.frmDevolucionClienteVer.Instance()

        f.txtCliente.Text = vDatos.GetFocusedRowCellValue("Cliente")
        f.txtDevolucion.Text = vDatos.GetFocusedRowCellValue("No. Devolución")
        f.txtFactura.Text = vDatos.GetFocusedRowCellValue("Factura")
        f.dtpFecha.DateTime = vDatos.GetFocusedRowCellValue("Fecha Devolución")
        f.Comp_No = vDatos.GetFocusedRowCellValue("Comp_No")
        f.Per_Id = vDatos.GetFocusedRowCellValue("Per_Id")

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = Replace(sender.Text, "&", "").ToString
        f.WindowState = FormWindowState.Maximized
    End Sub

    'Private Sub txtFactura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFactura.Leave
    '    If etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Try
    '        ds = Devoluciones.GetList(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
    '        dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
    '    End Try
    'End Sub

    'Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown
    '    If e.KeyData = Keys.Enter Then
    '        Me.cbClientes.Focus()
    '    End If
    'End Sub

    Private Sub cmdEntradaBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaBodega.Click
        'If ds.Tables("DevolucionesCliente").Rows.Count = 0 Then
        '    MsgBox("Seleccione un registro", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If DevolucionBodega.DevolucionDetalleNew(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0), dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 1)).Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    MsgBox("La devolucion ya fue procesada...", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Dim f As DataGridTextBoxCombo.frmDevolucionClienteBodega = DataGridTextBoxCombo.frmDevolucionClienteBodega.Instance
        'f.txtDevolucion.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 0)
        'f.txtFactura.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 1)

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmDevolucionesClienteList_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmDevolucionesFacturas = frmDevolucionesFacturas.Instance
        f.etInicio.Text = "0"

        Dim f1 As frmAgregarCliente = frmAgregarCliente.Instance
        f1.etInicio.Text = "0"
    End Sub

    Private Sub cmdEntradaBodegaList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaBodegaList.Click
        Me.etInicio.Text = "1"
        Dim f As frmDevolucionesClienteBodegaList = frmDevolucionesClienteBodegaList.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click
        'Fact = dgProveedores.Item(dgProveedores.CurrentRowIndex, 0)
        'FactValor = dgProveedores.Item(dgProveedores.CurrentRowIndex, 9)

        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        plan = Plantilla.GetTipoPlantilla(4, 4).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        ''Dim f As frmFacturasComprasContadoContabilizar = f.Instance
        ''f.lblTipoProv.Text = 0
        ''f.etPlantilla.Text = plan

        ''f.MdiParent = Me.MdiParent
        ''f.Show()
        ''f.WindowState = FormWindowState.Maximized

        'Dim fr As frmBancosContabilizarNotaCredito = fr.Instance
        'fr.MdiParent = Me.MdiParent
        'fr.etPlantilla.Text = plan
        'fr.lblProv.Text = Me.dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 3)
        'fr.lblProvID.Text = "1111 01 03" 'dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 2)
        'fr.etCodigoProveedor.Text = "103" 'dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 10)
        'fr.lblFact.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 1)
        'fr.etDevolucion.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
        'fr.lblFactMonto.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 4)
        'fr.etIva.Text = 150 'dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 8)
        'fr.etSubTotal.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 4)
        'fr.Show()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro de la Lista")
            Exit Sub
        End If
        '
        'Verificar Cierre del Día
        '------------------------------------------------------------------------------------
        If Not VerificarCierre(CDate(vDatos.GetFocusedRowCellValue("Fecha Devolución")).Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------
        '
        If vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "No.Electronico") _
            .ToString().Length > 1 Then
            XtraMsg("La Devolución es una Nota de Crédito Electrónica, no puede ser Borrada",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If CBool(vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "NC_Electrónica")) Then
            XtraMsg("La Devolución es  una Nota de Crédito Electrónica, no puede ser Borrada", MessageBoxIcon.Error)
            Exit Sub
        End If
        '        
        'Verificar si el Comprobante Contiene cuentas de Ingreso y si el Mes ya esta declarado RAMAC
        If ObtieneDatos("sp_ValidarIngresosBOLNASA", vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Comp_No"),
                        vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Per_Id"),
                        vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Mes"),
                        EmpresaActual).Rows.Count > 0 Then

            'Verificar Cierre de Bolsa
            If CDate(vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "Fecha Devolución")).Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                XtraMsg("La Devolición No: " & vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "No. Devolución").ToString() & " ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al:  " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString,
                        MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '
        If Not XtraMsg2("Esta Seguro de la Acción Solicitada?" & vbCrLf &
                    "Esta Acción Borrará la NC y Comprobante Contable generado por la Devolución.") Then
            Exit Sub
        End If
        '
        If Guardar("JAR_BorrarDevolucion",
                   vDatos.GetFocusedRowCellValue("No. Devolución"),
                   EmpresaActual) Then
            ShowSplash("Cargando Devoluciones...")
            Cargar()
            HideSplash()
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando Devoluciones...")
        Cargar()
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdDevoluciones.Click

        Dim f As frmDevolucionesFacturas = frmDevolucionesFacturas.Instance()
        f.Text = "Seleccione Factura de Venta"
        f.ShowDialog()
        f.Dispose()

        'Dim f As frmDevolucionesFacturas = frmDevolucionesFacturas.Instance()
        'f.etInicio.Text = "1"
        'f.MdiParent = Me
        'Recurso = ObtieneDatos("SELECT rr.ID FROM REST_Recursos rr WHERE rr.Control = '" & e.Item.Name & "'").Rows.Item(0)(0)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro de la Lista")
            Exit Sub
        End If
        '
        VB.SysContab.ComprobanteDB.ImprimirComprobante(vDatos.GetFocusedRowCellValue("Comp_No"),
                                          vDatos.GetFocusedRowCellValue("Per_Id"),
                                          vDatos.GetFocusedRowCellValue("Fecha Devolución"))
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "NC_Electrónica" Then
            If CBool(vDatos.GetRowCellValue(e.RowHandle, "NC_Electrónica")) Then
                e.Appearance.BackColor = Color.MediumSeaGreen
            End If
        End If
    End Sub

    Sub RequisaDevolucion(DT_DETALLE As DataTable)

        Dim Requisa As Integer = 0

        'Dim dr() As DataRow = DT_DETALLE.Select(
        '    "Tipo = 'P'")

        'If dr.Length > 0 Then

        '    Dim _DETALLE As DataTable = DT_DETALLE.Select(
        '        "Tipo = 'P'") _
        '       .CopyToDataTable

        Try


            If DT_DETALLE.Select("IdProyecto = 0") _
                .Length > 0 Then

                Dim _SIN_PROY As DataTable =
                        DT_DETALLE.Select("IdProyecto = 0") _
                        .CopyToDataTable

                If _SIN_PROY.Rows.Count > 0 Then

                    ShowSplash("Generando Movimiento...")
                    '
                    NoFactura = _SIN_PROY.Rows.Item(0)("FACTURA")

                    Requisa = db_requisas.Add(
                            EmpresaActual,
                            "E",
                            _SIN_PROY.Rows.Item(0)("Fecha_Devolucion"),
                            _SIN_PROY.Rows.Item(0)("BODEGA"),
                            _SIN_PROY.Rows.Item(0)("Usuario"),
                            _SIN_PROY.Rows.Item(0)("Numero"),
                            _SIN_PROY.Rows.Item(0)("Movimiento"),
                            "NC" & IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura),
                            "Nota de Crédito por Devolución #: " & _SIN_PROY.Rows.Item(0)("Numero").ToString() & ", Referencia #: " & _SIN_PROY.Rows.Item(0)("Referencia"),
                            "", "", "", "", "", "", _SIN_PROY.Rows.Item(0)("CLIENTE"), "", 0, 0, 0, _SIN_PROY.Rows.Item(0)("Numero"))

                    For i As Integer = 0 To _SIN_PROY.Rows.Count - 1
                        'If _SIN_PROY.Rows.Item(i)("Tipo") = "P" Then

                        db_requisas.AddDetalle(
                                    EmpresaActual,
                                    Requisa,
                                    _SIN_PROY.Rows.Item(i)("ITEM"),
                                    "P",
                                    _SIN_PROY.Rows.Item(i)("CANTIDAD"),
                                    _SIN_PROY.Rows.Item(i)("COSTO"),
                                    "NC", "", "", "")

                        'End If
                    Next
                    '
                    HideSplash()
                    XtraMsg("Movimiento de Inventario No. " + Requisa.ToString() + " Generado Exitosamente !!!")
                    ShowSplash("Cargando Devoluciones...")
                    Cargar()
                    HideSplash()
                End If
            End If

        Catch ex As Exception
            HideSplash()
            XtraMsg("Error al generar movimiento: " & vbCrLf &
                    ex.Message,
                    MessageBoxIcon.Error)
        End Try

        ' End If
    End Sub

    Private Sub bGenearMov_Click(sender As Object, e As EventArgs) Handles bGenearMov.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        Dim DT_DETALLE As New DataTable("DETALLE")

        DT_DETALLE = ObtieneDatos("sp_FacturaDetalleDevolucionRequisa",
            vDatos.GetFocusedRowCellValue("Factura"),
            EmpresaActual)

        If DT_DETALLE.Rows.Count = 0 Then
            XtraMsg("La Devolución seleccionada no contiene productos!",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        Dim _DT As DataTable = ObtieneDatos("sp_DevolucionRequisaValidar",
            vDatos.GetFocusedRowCellValue("No. Devolución"),
            EmpresaActual)

        If _DT.Rows.Count > 0 Then
            XtraMsg("La Devolución seleccionada ya contiene movimiento de inventario No. " & _DT.Rows.Item(0)("req_codigo").ToString(),
                    MessageBoxIcon.Warning)
            Exit Sub
        End If

        RequisaDevolucion(DT_DETALLE)
    End Sub
End Class
