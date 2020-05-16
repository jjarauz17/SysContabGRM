Imports System.Data.SqlClient
Imports SysContab.VB.SysContab


Public Class FrmActivoFijoContabilizar

    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmActivoFijoContabilizar = Nothing

    Public Shared Function Instance() As FrmActivoFijoContabilizar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmActivoFijoContabilizar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etDescripcionIngr As System.Windows.Forms.Label
    Friend WithEvents dgMontos As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActivoFijoContabilizar))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.etDescripcionIngr = New System.Windows.Forms.Label()
        Me.dgMontos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMontos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 54)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl3
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.cmdSalir)
        Me.LayoutControl3.Controls.Add(Me.cmdSeleccionar)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(131, 464)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Enabled = False
        Me.cmdSeleccionar.ImageOptions.Image = CType(resources.GetObject("cmdSeleccionar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSeleccionar.Location = New System.Drawing.Point(12, 12)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(107, 38)
        Me.cmdSeleccionar.StyleController = Me.LayoutControl3
        Me.cmdSeleccionar.TabIndex = 0
        Me.cmdSeleccionar.Text = "Contabilizar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.EmptySpaceItem3, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 464)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdSeleccionar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(111, 360)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdSalir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'etDescripcionIngr
        '
        Me.etDescripcionIngr.BackColor = System.Drawing.Color.Tomato
        Me.etDescripcionIngr.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcionIngr.ForeColor = System.Drawing.Color.White
        Me.etDescripcionIngr.Location = New System.Drawing.Point(12, 12)
        Me.etDescripcionIngr.Name = "etDescripcionIngr"
        Me.etDescripcionIngr.Size = New System.Drawing.Size(781, 27)
        Me.etDescripcionIngr.TabIndex = 142
        Me.etDescripcionIngr.Text = "Listado de Meses por Contabilizar"
        Me.etDescripcionIngr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgMontos
        '
        Me.dgMontos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMontos.Location = New System.Drawing.Point(12, 170)
        Me.dgMontos.MainView = Me.Vista
        Me.dgMontos.Name = "dgMontos"
        Me.dgMontos.Size = New System.Drawing.Size(781, 309)
        Me.dgMontos.TabIndex = 186
        Me.dgMontos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgMontos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(107, 115)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(686, 51)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 187
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtConsecutivo)
        Me.LayoutControl1.Controls.Add(Me.dgMontos)
        Me.LayoutControl1.Controls.Add(Me.etDescripcionIngr)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.cbMeses)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(622, 227, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(805, 491)
        Me.LayoutControl1.TabIndex = 188
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(522, 43)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Size = New System.Drawing.Size(271, 20)
        Me.txtConsecutivo.StyleController = Me.LayoutControl1
        Me.txtConsecutivo.TabIndex = 190
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(107, 91)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Properties.Appearance.Options.UseFont = True
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Size = New System.Drawing.Size(686, 20)
        Me.cbTipo.StyleController = Me.LayoutControl1
        Me.cbTipo.TabIndex = 189
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(107, 67)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Size = New System.Drawing.Size(122, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 5
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(107, 43)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Properties.Appearance.Options.UseFont = True
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Size = New System.Drawing.Size(264, 20)
        Me.cbMeses.StyleController = Me.LayoutControl1
        Me.cbMeses.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(805, 491)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbMeses
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Seleccione Mes:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(221, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(221, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(221, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtConsecutivo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(415, 31)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(370, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Referencia:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dgMontos
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(785, 313)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtConcepto
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 55)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(110, 55)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(785, 55)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Concepto:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(221, 55)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(564, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.etDescripcionIngr
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 31)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(24, 31)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(785, 31)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbTipo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 79)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(785, 24)
        Me.LayoutControlItem3.Text = "Tipo Comprobante:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(363, 31)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(52, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        Me.DockPanel1.ID = New System.Guid("a7f4c634-5115-46e3-8ab1-dfaff96e485b")
        Me.DockPanel1.Location = New System.Drawing.Point(805, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 491)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl3)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 464)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmActivoFijoContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(945, 491)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmActivoFijoContabilizar"
        Me.Text = "Contabilizar Activos Fijos"
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMontos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ActFijo As New VB.SysContab.Articulos_AFijoDB()
    Dim Rutinas As New VB.SysContab.Rutinas()
    ' Dim Compr As New VB.SysContab.ComprobanteDB()
    Dim Ds As New DataSet
    Dim comp As New VB.SysContab.ComprobanteDB

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim CompNo As Integer = 0

    Private Sub Distribucion()
        DT_Distribucion = ObtieneDatos("sp_ActivoFijoDetalleDistribucion",
                                       0,
                                       EmpresaActual)
    End Sub

    Private Sub FrmActivoFijoContabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Distribucion()
        'VB.SysContab.Rutinas.CambiarEstilo(Me)

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        '
        LookUp(
            cbMeses,
            ObtieneDatos("_GetList_MesesDepreciacion", EmpresaActual, 0),
            "mes_depreciacion", "mes_depreciacion", "[Seleccione Mes]")
        cbMeses.ItemIndex = 0

        GetTipoComprobantesList(cbTipo, 1)
        cbTipo.ItemIndex = 0
        '
        Cargar()
        Refresh()
    End Sub

    Public Sub Cargar()

        If cbMeses.ItemIndex = 0 Then
            Ds = ActFijo.GetListContabilizar("")
            dgMontos.DataSource = Nothing
            '
            cmdSeleccionar.Enabled = False
        Else
            Ds = ActFijo.GetListContabilizar(cbMeses.EditValue)
            dgMontos.DataSource = Ds.Tables(0)

            FormatoGrid(Vista, 2, 0, False, False, False)
            Me.Vista.Columns("codigo").Visible = False
            Me.Vista.Columns("Valor").Visible = False
            '
            Me.cmdSeleccionar.Enabled = IIf(Ds.Tables(0).Rows.Count = 0, False, True)

            DT_Distribucion = ObtieneDatos("sp_ActivoFijoDetalleDistribucion",
                                       cbMeses.EditValue,
                                       EmpresaActual)
        End If


        'Me.Vista.Columns("Debitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("Debitos").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("Debitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("Debitos").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.Vista.Columns("Creditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.Vista.Columns("Creditos").DisplayFormat.FormatString = "n2"
        'Me.Vista.Columns("Creditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.Vista.Columns("Creditos").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub
    'Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
    '    If IsNumeric(cbMes.SelectedValue) = True Then
    '        'Ds = ActFijo.GetListContabilizar(cbMes.SelectedValue)
    '        'dgMontos.DataSource = Ds.Tables(0)
    '        cargar()
    '    End If
    'End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click

        Dim TipoCompr As Integer = cbTipo.EditValue

        Dim Importe As Double = 0.00
        Dim DC As String = String.Empty

        If Ds.Tables(0).Rows.Count = 0 Then
            XtraMsg("No hay detalle que contabilizar",
                    MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Por favor ingrese el concepto del comprobante",
                    MessageBoxIcon.Warning)
            txtConcepto.Focus()
            Exit Sub
        End If
        '
        If cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione un tipo de Comprobante",
                    MessageBoxIcon.Warning)
            cbTipo.Focus()
            Exit Sub
        End If
        '
        If txtConsecutivo.Text.Trim.Length = 0 Then
            XtraMsg("Describa la Referencia para este comprobante",
                    MessageBoxIcon.Warning)
            txtConsecutivo.Focus()
            Exit Sub
        End If

        ' VALIDAR SI HAY UN PERIODO ACTIVO
        If VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date) = 0 Then
            XtraMsg("Por Favor establezca un Periodo Activo",
                    MessageBoxIcon.Error)
            Exit Sub
        End If

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To Vista.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & Vista.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & Vista.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Dim Per_Id As Integer = PeriodosDB.Activo(Fecha.DateTime.Date)

        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            CompNo = ComprobanteDB.AddComprobante(
                TipoCompr,
                1,
                txtConcepto.Text,
                MonedaBase,
                Per_Id,
                Fecha.DateTime.Date,
                0,
                "",
                False,
                0,
                "",
                8,
                "D" + cbMeses.EditValue,
                f.Date,
                0,
                OrigenComprobantes.ACTIVO_FIJO,
                "",
                0,
                0,
                txtConsecutivo.Text)

            For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1

                If Ds.Tables(0).Rows(i).Item("Codigo") = "D" Then
                    Importe = Ds.Tables(0).Rows(i).Item("Valor")
                    DC = "C"
                End If

                If Ds.Tables(0).Rows(i).Item("Codigo") = "G" Then
                    Importe = Ds.Tables(0).Rows(i).Item("Valor")
                    DC = "D"
                End If

                ComprobanteDB.AddComprobanteDetalles(
                    CompNo,
                    Ds.Tables(0).Rows(i).Item("Cuenta"),
                    "Depreciación Activos Fijos : " & cbMeses.EditValue,
                    Importe,
                    0,
                    TipoCompr,
                    DC,
                    0,
                    0,
                    Me.Fecha.DateTime.Date, 0)

            Next

            Articulos_AFijoDB.Contabilizar(
                cbMeses.EditValue)

            Rutinas.okTransaccion()

            '----------------------
            'Guarda la Distribucion
            '----------------------
            Dim DT_F As DataTable
            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Unchanged)
            If Not DT_F Is Nothing Then
                For i As Integer = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        ' If (.Rows(i).RowState = DataRowState.Added Or .Rows(i).RowState = DataRowState.Unchanged) Then
                        GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & CompNo & "," & Me.Fecha.DateTime.Month & "," &
                            VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & Math.Round(CDbl(.Rows(i).Item("Valor")), 2) & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        'ElseIf .Rows(i).RowState = DataRowState.Modified Then
                        '    GuardaDatosTrans("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.Fecha.DateTime.Month & "," &
                        '    "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                        '    "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        'ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        'End If
                    End With
                Next
            End If

            Distribucion()

            XtraMsg("Comprobante realizado Correctamente!")

            LookUp(
            cbMeses,
            ObtieneDatos("_GetList_MesesDepreciacion", EmpresaActual, 0),
            "mes_depreciacion", "mes_depreciacion", "[Seleccione Mes]")
            cbMeses.ItemIndex = 0

            txtConcepto.Text = ""
            CompNo = 0
            dgMontos.DataSource = Nothing
        Catch ex As Exception

            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message)
            Exit Sub

        Finally
        End Try

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

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Vista_DoubleClick(sender As Object, e As EventArgs) Handles Vista.DoubleClick

        If Vista.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim forma As New FrmDetalleRequisas
            With Vista
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debitos")) OrElse
                    IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debitos")) OrElse
                    .GetRowCellValue(.FocusedRowHandle, "Debitos") = Nothing OrElse
                    .GetRowCellValue(.FocusedRowHandle, "Debitos") = 0.0 Then

                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Creditos") '.Item(.CurrentRowIndex, 4)
                    forma.Tipo = "C"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
                    forma.CompNo = CompNo
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                Else
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Debitos") '.Item(.CurrentRowIndex, 3)
                    forma.Tipo = "D"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
                    forma.CompNo = CompNo
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                End If
                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbMeses_EditValueChanged(sender As Object, e As EventArgs) Handles cbMeses.EditValueChanged
        If cbMeses.ItemIndex = 0 Then Exit Sub
        '
        Fecha.DateTime = New DateTime(Mid(cbMeses.EditValue, 1, 4), Mid(cbMeses.EditValue, 5, 2), 1).Date
        ShowSplash()
        cargar()
        HideSplash()

        'If IsNumeric(cbMes.SelectedValue) = True Then
        '    'Ds = ActFijo.GetListContabilizar(cbMes.SelectedValue)
        '    'dgMontos.DataSource = Ds.Tables(0)
        '    cargar()
        'End If
    End Sub

    Private Sub etDescripcionIngr_Click(sender As Object, e As EventArgs) Handles etDescripcionIngr.Click

    End Sub
End Class
