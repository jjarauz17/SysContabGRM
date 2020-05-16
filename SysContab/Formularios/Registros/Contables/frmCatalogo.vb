Imports System.Data
Imports System.Data.SqlClient

Public Class frmCatalogo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCatalogo = Nothing

    Public Shared Function Instance() As frmCatalogo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCatalogo()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents VCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lbCuenta As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogo))
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dgCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.VCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbCuenta = New System.Windows.Forms.ListBox()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdNuevo.Appearance.Options.UseFont = True
        Me.cmdNuevo.Appearance.Options.UseForeColor = True
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(107, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 82
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.btnExportar)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Controls.Add(Me.cmdModificar)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(745, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 328)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 278)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 89
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 222)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(108, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 90
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdBorrar.Appearance.Options.UseFont = True
        Me.cmdBorrar.Appearance.Options.UseForeColor = True
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 180)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(107, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 84
        Me.cmdBorrar.Text = "&Borrar"
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 138)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(107, 38)
        Me.btnExportar.StyleController = Me.LayoutControl2
        Me.btnExportar.TabIndex = 91
        Me.btnExportar.Text = "E&xportar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdModificar.Appearance.Options.UseFont = True
        Me.cmdModificar.Appearance.Options.UseForeColor = True
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 54)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(107, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl2
        Me.cmdModificar.TabIndex = 83
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Appearance.Options.UseForeColor = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 96)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 86
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdAyuda
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 328)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdNuevo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdModificar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdImprimir
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExportar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdBorrar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdSalir
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 266)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(111, 56)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'dgCatalogo
        '
        Me.dgCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCatalogo.Location = New System.Drawing.Point(12, 12)
        Me.dgCatalogo.MainView = Me.VCatalogo
        Me.dgCatalogo.Name = "dgCatalogo"
        Me.dgCatalogo.Size = New System.Drawing.Size(495, 331)
        Me.dgCatalogo.TabIndex = 115
        Me.dgCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VCatalogo})
        '
        'VCatalogo
        '
        Me.VCatalogo.GridControl = Me.dgCatalogo
        Me.VCatalogo.Name = "VCatalogo"
        Me.VCatalogo.OptionsBehavior.Editable = False
        Me.VCatalogo.OptionsFind.AlwaysVisible = True
        Me.VCatalogo.OptionsFind.ShowClearButton = False
        Me.VCatalogo.OptionsView.ShowAutoFilterRow = True
        Me.VCatalogo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VCatalogo.OptionsView.ShowFooter = True
        Me.VCatalogo.OptionsView.ShowGroupPanel = False
        '
        'lbCuenta
        '
        Me.lbCuenta.Location = New System.Drawing.Point(12, 190)
        Me.lbCuenta.Name = "lbCuenta"
        Me.lbCuenta.Size = New System.Drawing.Size(383, 173)
        Me.lbCuenta.TabIndex = 114
        Me.lbCuenta.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dgCatalogo)
        Me.LayoutControl1.Controls.Add(Me.lbCuenta)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(519, 355)
        Me.LayoutControl1.TabIndex = 117
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lbCuenta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(387, 179)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(519, 355)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgCatalogo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(499, 335)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("aff1b2f1-eafa-499c-96e2-544e895c3690")
        Me.DockPanel1.Location = New System.Drawing.Point(519, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 355)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 328)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmCatalogo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(659, 355)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Cuentas"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Comprobantes As New VB.SysContab.ComprobanteDB
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim i As Integer

    Private Sub frmCatalogo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub frmCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Cargar()

        ''Dim j As Integer
        ''Dim TotalS As Double
        ''Dim TotalM As Double

        ''For i = 0 To Me.VCatalogo.DataRowCount - 1
        ''    TotalS = 0
        ''    If Me.VCatalogo.GetRowCellValue(i, "Tipo") = "S" Then
        ''        For j = i + 1 To Me.VCatalogo.DataRowCount - 1
        ''            If Me.VCatalogo.GetRowCellValue(j, "Tipo") = "A" Then
        ''                If Mid(Me.VCatalogo.GetRowCellValue(j, "Cuenta"), 1, Me.VCatalogo.GetRowCellValue(j, "Cuenta").ToString.Length) <> Me.VCatalogo.GetRowCellValue(i, "Cuenta") Then
        ''                    Exit For
        ''                End If
        ''                TotalS = TotalS + Me.VCatalogo.GetRowCellValue(j, "Cuenta")
        ''            End If
        ''        Next
        ''        Me.VCatalogo.SetRowCellValue(i, "Saldo", TotalS)
        ''    End If
        ''Next

        ' ''quite esto pq no tiene sentido rmpr 30052008
        ' ''If ds.Tables("Catalogo").Rows.Count = 0 Then
        ' ''Else
        ' ''    Me.dgCatalogo.Item(0, 2) = Me.dgCatalogo.Item(0, 2)
        ' ''End If


        ' ''04/10/2006
        ' ''For i = 0 To ds.Tables("CATALOGO").Rows.Count - 1
        ' ''    TotalM = 0
        ' ''    If Me.VCatalogo.GetFocusedRowCellValue("Tipo")) = "M" Then
        ' ''        For j = i + 1 To ds.Tables("CATALOGO").Rows.Count - 1
        ' ''            If Me.VCatalogo.GetFocusedRowCellValue("Tipo") = "S" Then
        ' ''                'MsgBox(Mid(Me.dgCatalogo.Item(j, 0), 1, Me.dgCatalogo.Item(i, 0).ToString.Length))
        ' ''                If Mid(Me.dgCatalogo.Item(j, 0), 1, Me.dgCatalogo.Item(i, 0).ToString.Length) <> Me.dgCatalogo.Item(i, 0) Then
        ' ''                    Exit For
        ' ''                End If
        ' ''                TotalM = TotalM + Me.dgCatalogo.Item(j, 4)
        ' ''            End If
        ' ''        Next
        ' ''        Me.dgCatalogo.Item(i, 4) = TotalM
        ' ''    End If
        ' ''Next
        ''For i = 0 To Me.VCatalogo.DataRowCount - 1
        ''    TotalM = 0
        ''    If Me.VCatalogo.GetRowCellValue(i, "Tipo") = "M" Then
        ''        For j = i + 1 To Me.VCatalogo.DataRowCount - 1
        ''            If Me.VCatalogo.GetRowCellValue(j, "Tipo") = "S" Then
        ''                If Mid(Me.VCatalogo.GetRowCellValue(j, "Cuenta"), 1, Me.VCatalogo.GetRowCellValue(j, "Cuenta").ToString.Length) <> Me.VCatalogo.GetRowCellValue(i, "Cuenta") Then
        ''                    Exit For
        ''                End If
        ''                TotalM = TotalM + Me.VCatalogo.GetRowCellValue(j, "Cuenta")
        ''            End If
        ''        Next
        ''        Me.VCatalogo.SetRowCellValue(i, "Saldo", TotalM)
        ''    End If
        ''Next
        ' ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        FormatoGrid(VCatalogo)
        'Me.VCatalogo.BestFitColumns()
        '        
        Me.VCatalogo.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VCatalogo.Columns("Saldo").DisplayFormat.FormatString = "n2"

        Me.VCatalogo.Columns("Clase").Visible = False
        Me.VCatalogo.Columns("Saldo").Visible = False

        VCatalogo.Columns("Nombre").Width = 300
    End Sub
    Public Sub Cargar()
        dgCatalogo.DataSource =
            Catalogo.GetList("").Tables("CATALOGO")

        If Me.VCatalogo.DataRowCount <> 0 Then
            Registro = Me.VCatalogo.GetFocusedRowCellValue("Cuenta")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Dim f As frmNuevaCuenta = frmNuevaCuenta.Instance()
        Nuevo = "SI"
        'f.MdiParent = Me.MdiParent
        f.cbAgrupaciones.SelectedValue = -1
        f.Text = "Agregar Cuenta Contable"
        f.ShowDialog()
        f.Refresh()
        f.Dispose()
        'f.cbAgrupaciones.SelectedValue = -1
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VCatalogo.DataRowCount = 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VCatalogo.GetFocusedRowCellValue("Cuenta")
        End If

        Try

            Dim catalogo As New VB.SysContab.CatalogoDB
            Dim saldo As Double
            Dim j As Integer

            If Me.VCatalogo.GetFocusedRowCellValue("Tipo") <> "A" Then
                If catalogo.GetListCodigoBorrar(Me.VCatalogo.GetFocusedRowCellValue("Cuenta"), EmpresaActual).Tables("Catalogo").Rows.Count <> 0 Then
                    XtraMsg("No se puede borrar la cuenta." & Chr(13) & "Para borrarla necesita borrar todas las Sub Cuentas que dependen de ella.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            If ObtieneDatos("SELECT * FROM ComprobantesDetalles cd WHERE cd.CDet_Cuenta = '" & Me.VCatalogo.GetFocusedRowCellValue("Cuenta") & "' AND cd.Empresa =" & EmpresaActual).Rows.Count > 0 Then
                XtraMsg("La Cuenta Contable que desea borrar presenta Movimientos", MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not XtraMsg2("Esta seguro que dese borrar la Cuenta: " & Me.VCatalogo.GetFocusedRowCellValue("Cuenta") & " - " & Me.VCatalogo.GetFocusedRowCellValue("Nombre")) Then
                Exit Sub
            End If

            Dim Catal As New VB.SysContab.CatalogoDB
            Dim longitud As Integer
            Dim i As Integer

            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbCuenta.Items.Clear()
                For i = 0 To longitud - 2
                    If Catal.GetListCodigo(Registro.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 And Registro.Substring(i, 1) <> " " Then
                        lbCuenta.Items.Add(Catal.GetListCodigo(Registro.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))
                    End If
                Next
            End If

            Dim Saldo1 As Double

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                catalogo.SaldoInicialActualizar(Me.VCatalogo.GetFocusedRowCellValue("Cuenta"), _
                    VB.SysContab.PeriodosDB.Actual, Saldo1, 2)

                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox("Error:" & ex.Message)
                Exit Sub
            End Try

            catalogo.Delete(Me.VCatalogo.GetFocusedRowCellValue("Cuenta"))


            If lbCuenta.Items.Count <> 0 Then
                saldo = 0
                For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                    saldo = saldo + catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows(i).Item("SALDO_INICIAL")

                Next

                catalogo.UpdateSaldosEdit(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), saldo, Me.VCatalogo.GetFocusedRowCellValue("Clase"))

                i = lbCuenta.Items.Count - 1
                While i >= 0
                    saldo = 0

                    For j = 0 To catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                        saldo = saldo + catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("SALDO_INICIAL")
                    Next
                    If i > 0 Then
                        catalogo.UpdateSaldosEdit(lbCuenta.Items(i - 1), saldo, Me.VCatalogo.GetFocusedRowCellValue("Clase"))
                    End If

                    i = i - 1

                End While
            End If
            Me.cargar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VCatalogo.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VCatalogo.GetFocusedRowCellValue("Cuenta")
        End If

        Dim f As frmNuevaCuenta = frmNuevaCuenta.Instance()
        Nuevo = "NO"
        f.Text = "Editar Cuenta Contable"
        f.ShowDialog()
        f.Refresh()
        f.Dispose()

        'Dim f As frmNuevaCuenta = f.Instance
        'Nuevo = "NO"
        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesCatalogo = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Refresh()
    End Sub

    Private Sub frmCatalogo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub frmCatalogo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '''
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "CatalogoCuentas")
    End Sub
    Private Sub VCatalogo_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles VCatalogo.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer

        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat
    End Sub
    Private Sub VCatalogo_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VCatalogo.FocusedRowChanged
        Registro = Me.VCatalogo.GetFocusedRowCellValue("Cuenta")
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(dgCatalogo, Me.Text)
    End Sub
End Class
