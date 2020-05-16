Public Class frmVendedores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVendedores = Nothing

    Public Shared Function Instance() As frmVendedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVendedores()
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bAgregarLineas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedores))
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bAgregarLineas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 270)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(108, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 6
        Me.cmdAyuda.Text = "E&xportar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bAgregarLineas)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdModificar)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2172, 84, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 362)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bAgregarLineas
        '
        Me.bAgregarLineas.Appearance.Options.UseTextOptions = True
        Me.bAgregarLineas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAgregarLineas.Enabled = False
        Me.bAgregarLineas.Image = CType(resources.GetObject("bAgregarLineas.Image"), System.Drawing.Image)
        Me.bAgregarLineas.Location = New System.Drawing.Point(12, 96)
        Me.bAgregarLineas.Name = "bAgregarLineas"
        Me.bAgregarLineas.Size = New System.Drawing.Size(108, 38)
        Me.bAgregarLineas.StyleController = Me.LayoutControl2
        Me.bAgregarLineas.TabIndex = 9
        Me.bAgregarLineas.Text = "Agregar &Lineas"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 312)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 138)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(108, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 180)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(108, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(12, 54)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(108, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl2
        Me.cmdModificar.TabIndex = 3
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(108, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 2
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 362)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdImprimir
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdBorrar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAyuda
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 258)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 300)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 48)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bAgregarLineas
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2149, 213, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(382, 389)
        Me.LayoutControl1.TabIndex = 7
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(358, 365)
        Me.iGrid.TabIndex = 4
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(382, 389)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(362, 369)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("5b1fa87a-675c-4a1a-942a-a06db691c97d")
        Me.DockPanel1.Location = New System.Drawing.Point(382, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 389)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 362)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmVendedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(522, 389)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vendedor As New VB.SysContab.VendedoresDB()
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ''  '''r.CambiarEstilo(Me)
        RolesDB.UsuarioAcciones(LayoutControl2)
        '' ds = vendedor.GetList()
        ''dgVendedores.DataSource = vendedor.GetList().Tables("Vendedores").DefaultView
        ''Tabla = ds.Tables("Vendedores")
        ''r.FormatGenerico(dgVendedores, Tabla)

        'If ds.Tables("Vendedores").Rows.Count <> 0 Then
        '    Registro = dgVendedores.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        ''dgVendedores.CaptionText = "Información de Vendedores"
        ''Me.Text = "Mantenimiento de Vendedores"
        Cargar()
        Me.Refresh()

    End Sub

    Public Sub Cargar()
        iGrid.DataSource = VB.SysContab.VendedoresDB.GetList(0)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        ''
        iVista.Columns("Direccion").Visible = False
        iVista.Columns("Comisión Producto").Visible = False
        iVista.Columns("Comisión Servicio").Visible = False


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub


    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarVendedor = frmAgregarVendedor.Instance

        Nuevo = "SI"

        'f.MdiParent = Me.MdiParent
        'f.Show()

        f.txtNombre.Focus()
        f.cbZona.SelectedValue = 0
        f.ShowDialog()

        'f.cbLinea.SelectedValue = -1

        f.Dispose()

    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim vendedor As New VB.SysContab.VendedoresDB()
    '    dgVendedores.DataSource = vendedor.GetListBuscar(txtBuscar.Text).Tables("Vendedores").DefaultView
    '    If vendedor.GetListBuscar(txtBuscar.Text).Tables("Vendedores").Rows.Count = 0 Then
    '        Exit Sub

    '    End If

    '    Registro = dgVendedores.Item(dgVendedores.CurrentRowIndex, 0)
    'End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Vendedor")
            cmdModificar.Focus()
            Exit Sub
        End If

        Dim f As frmAgregarVendedor = frmAgregarVendedor.Instance()
        'Dim vendedor As New VB.SysContab.VendedoresDB()

        Nuevo = "NO"
        Registro = iVista.GetFocusedRowCellValue("Codigo")

        f.ShowDialog()
        f.Dispose()

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione el Vendedor que desea Editar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub dgVendedores_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ''  Registro = dgVendedores.Item(dgVendedores.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim vendedores As New VB.SysContab.VendedoresDB()

        'If Registro = "Vacio" Then
        '    XtraMsg("Seleccione el Vendedor que desea Borrar")
        '    Exit Sub
        'End If

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Vendedor que desea Borrar")
            Exit Sub
        End If

        If Not XtraMsg2("Esta seguro que dese borrar el Vendedor y/o Técnico: " & iVista.GetFocusedRowCellValue("Nombre")) Then
            Exit Sub
        End If

        Dim DT As DataTable = ObtieneDatos("SELECT fv.FACTURA FROM FACTURAS_VENTAS fv WHERE fv.VENDEDOR = " & iVista.GetFocusedRowCellValue("Codigo") & " AND fv.EMPRESA = " & EmpresaActual)

        If DT.Rows.Count > 0 Then
            XtraMsg("El Vendedor: " & iVista.GetFocusedRowCellValue("Nombre") & " contiene: " & DT.Rows.Count.ToString & " facturas registradas." & vbCrLf & "NO se puede Borrar.", MessageBoxIcon.Error)
            Exit Sub
        End If

        'resp = MsgBox("Esta seguro que dese borrar el Vendedor: " & dgVendedores.Item(dgVendedores.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        Try
            vendedores.Delete(iVista.GetFocusedRowCellValue("Codigo"))

            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As New DataTable()
        ''Dim f As New frmGrupos()
        'Dim ds As New DataSet()

        'ds = vendedores.GetList

        'dgVendedores.DataSource = vendedores.GetList().Tables("Vendedores").DefaultView
        'Tabla = ds.Tables("Vendedores")

        'If ds.Tables("Vendedores").Rows.Count = 0 Then
        '    Registro = "Vacio"
        'Else
        '    Registro = dgVendedores.Item(0, 0)

        'End If

        'r.FormatGenerico(dgVendedores, Tabla)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmVendedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        ''''
        'FormPrincipal.StatusBar1.Panels(3).Text = FormPrincipal.etVendedores.Text.ToUpper
    End Sub

    Private Sub dgVendedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '''
        'FormPrincipal.StatusBar1.Panels(3).Text = FormPrincipal.etVendedores.Text.ToUpper
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '''
        'FormPrincipal.StatusBar1.Panels(3).Text = FormPrincipal.etVendedores.Text.ToUpper
    End Sub

    Private Sub frmVendedores_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim f As frmReportesVendedores = f.Instance

        'f.MdiParent = Me.MdiParent
        'f.Show()

        'f.cbDepartamentos.SelectedValue = 0
        'f.cbMunicipios.SelectedValue = 0
        'f.cbZonas.SelectedValue = -1
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(iGrid)
        ''Help.ShowHelp(Me, "ayuda/RegVendedores.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Vendedores")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bAgregarLineas.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Vendedor que desea Borrar")
            bAgregarLineas.Focus()
            Exit Sub
        End If
        '
        Dim f As frmVendedor_Linea = frmVendedor_Linea.Instance
        f.Text = "Lineas por Vendedor"
        VendedorP = iVista.GetFocusedRowCellValue("Codigo")
        f.ShowDialog()
        f.Dispose()
    End Sub
End Class
