Imports Entities
Public Class frmClientes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmClientes = Nothing

    Public Shared Function Instance() As frmClientes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmClientes()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNotasDebitos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkSelector As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbIncompletos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rLinkAcuerdos As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents VClientes As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNotasDebitos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.chkSelector = New DevExpress.XtraEditors.CheckEdit()
        Me.cbIncompletos = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgClientes = New DevExpress.XtraGrid.GridControl()
        Me.VClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.rLinkAcuerdos = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbIncompletos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLinkAcuerdos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevoluciones.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDevoluciones.Appearance.Options.UseFont = True
        Me.cmdDevoluciones.Appearance.Options.UseForeColor = True
        Me.cmdDevoluciones.Appearance.Options.UseTextOptions = True
        Me.cmdDevoluciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDevoluciones.Enabled = False
        Me.cmdDevoluciones.ImageOptions.Image = CType(resources.GetObject("cmdDevoluciones.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDevoluciones.Location = New System.Drawing.Point(501, 476)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(117, 38)
        Me.cmdDevoluciones.StyleController = Me.LayoutControl1
        Me.cmdDevoluciones.TabIndex = 7
        Me.cmdDevoluciones.Text = "&Letra de Cambio"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bDiseno)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.cmdNotasDebitos)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdDevoluciones)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.chkSelector)
        Me.LayoutControl1.Controls.Add(Me.cbIncompletos)
        Me.LayoutControl1.Controls.Add(Me.cmdAcumulado)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Controls.Add(Me.cmdEstadoCuenta)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.dgClientes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1905, 313, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1117, 526)
        Me.LayoutControl1.TabIndex = 167
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bDiseno
        '
        Me.bDiseno.Appearance.Options.UseTextOptions = True
        Me.bDiseno.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(824, 476)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(92, 38)
        Me.bDiseno.StyleController = Me.LayoutControl1
        Me.bDiseno.TabIndex = 168
        Me.bDiseno.Text = "D&iseño"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(1019, 476)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(86, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(920, 476)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(95, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 11
        Me.cmdAyuda.Text = "E&xportar"
        '
        'cmdNotasDebitos
        '
        Me.cmdNotasDebitos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotasDebitos.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNotasDebitos.Appearance.Options.UseFont = True
        Me.cmdNotasDebitos.Appearance.Options.UseForeColor = True
        Me.cmdNotasDebitos.Appearance.Options.UseTextOptions = True
        Me.cmdNotasDebitos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdNotasDebitos.Enabled = False
        Me.cmdNotasDebitos.ImageOptions.Image = CType(resources.GetObject("cmdNotasDebitos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNotasDebitos.Location = New System.Drawing.Point(622, 476)
        Me.cmdNotasDebitos.Name = "cmdNotasDebitos"
        Me.cmdNotasDebitos.Size = New System.Drawing.Size(91, 38)
        Me.cmdNotasDebitos.StyleController = Me.LayoutControl1
        Me.cmdNotasDebitos.TabIndex = 8
        Me.cmdNotasDebitos.Text = "&Notas Créditos"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(202, 476)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(91, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 10
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Options.UseTextOptions = True
        Me.cmdImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(717, 476)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(93, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 9
        Me.cmdImprimir.Text = "Enviar por E-&Mail"
        '
        'chkSelector
        '
        Me.chkSelector.Location = New System.Drawing.Point(967, 12)
        Me.chkSelector.Name = "chkSelector"
        Me.chkSelector.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelector.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkSelector.Properties.Appearance.Options.UseFont = True
        Me.chkSelector.Properties.Appearance.Options.UseForeColor = True
        Me.chkSelector.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.chkSelector.Properties.Caption = "Mostrar Mas Datos"
        Me.chkSelector.Size = New System.Drawing.Size(138, 20)
        Me.chkSelector.StyleController = Me.LayoutControl1
        Me.chkSelector.TabIndex = 165
        '
        'cbIncompletos
        '
        Me.cbIncompletos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIncompletos.Location = New System.Drawing.Point(317, 12)
        Me.cbIncompletos.Name = "cbIncompletos"
        Me.cbIncompletos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cbIncompletos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.cbIncompletos.Properties.Appearance.Options.UseFont = True
        Me.cbIncompletos.Properties.Appearance.Options.UseForeColor = True
        Me.cbIncompletos.Properties.Caption = "Incompletos"
        Me.cbIncompletos.Size = New System.Drawing.Size(301, 20)
        Me.cbIncompletos.StyleController = Me.LayoutControl1
        Me.cbIncompletos.TabIndex = 164
        Me.cbIncompletos.Visible = False
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.Enabled = False
        Me.cmdAcumulado.ImageOptions.Image = CType(resources.GetObject("cmdAcumulado.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAcumulado.Location = New System.Drawing.Point(297, 476)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(105, 38)
        Me.cmdAcumulado.StyleController = Me.LayoutControl1
        Me.cmdAcumulado.TabIndex = 5
        Me.cmdAcumulado.Text = "&Acumulado"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 476)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(91, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 3
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.cmdEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEstadoCuenta.Enabled = False
        Me.cmdEstadoCuenta.ImageOptions.Image = CType(resources.GetObject("cmdEstadoCuenta.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(406, 476)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(91, 38)
        Me.cmdEstadoCuenta.StyleController = Me.LayoutControl1
        Me.cmdEstadoCuenta.TabIndex = 6
        Me.cmdEstadoCuenta.Text = "&Estado Cuenta"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(107, 476)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(91, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 4
        Me.cmdModificar.Text = "&Editar"
        '
        'dgClientes
        '
        Me.dgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClientes.Location = New System.Drawing.Point(12, 36)
        Me.dgClientes.MainView = Me.VClientes
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rLink, Me.rLinkAcuerdos})
        Me.dgClientes.Size = New System.Drawing.Size(1093, 436)
        Me.dgClientes.TabIndex = 163
        Me.dgClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VClientes})
        '
        'VClientes
        '
        Me.VClientes.GridControl = Me.dgClientes
        Me.VClientes.Name = "VClientes"
        Me.VClientes.OptionsFind.AlwaysVisible = True
        Me.VClientes.OptionsFind.ShowClearButton = False
        Me.VClientes.OptionsView.ShowAutoFilterRow = True
        Me.VClientes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VClientes.OptionsView.ShowFooter = True
        Me.VClientes.OptionsView.ShowGroupPanel = False
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Documentos"
        Me.rLink.Name = "rLink"
        '
        'rLinkAcuerdos
        '
        Me.rLinkAcuerdos.AutoHeight = False
        Me.rLinkAcuerdos.Caption = "Ver Acuerdos"
        Me.rLinkAcuerdos.Name = "rLinkAcuerdos"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbIncompletos
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(305, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem14})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1117, 526)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgClientes
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1097, 440)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkSelector
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(955, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdNuevo
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 464)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdModificar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(95, 464)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAcumulado
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(285, 464)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdEstadoCuenta
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(394, 464)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdDevoluciones
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(489, 464)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdNotasDebitos
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(610, 464)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdImprimir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(705, 464)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdAyuda
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(908, 464)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdSalir
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(1007, 464)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdBorrar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(190, 464)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(802, 464)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(955, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bDiseno
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(812, 464)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'frmClientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1117, 526)
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbIncompletos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLinkAcuerdos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Estado As Integer
    Dim obj As New CLIENTES,
        ClientesDB As New db_CLIENTES

    Private Sub frmClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash()
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RolesDB.UsuarioAcciones(LayoutControl1)
        Estado = 0
        Cargar()
        Grid()

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
    End Sub

    Public Sub Cargar()

        'If Me.cbIncompletos.Checked = True Then
        '    Estado = 1
        'Else
        '    Estado = 0
        'End If

        'dgClientes.DataSource =
        '    VB.SysContab.ClientesDB.ListaClientes("", Estado).Tables(0)

        dgClientes.DataSource =
        ClientesDB.Listar(
            0,
            EmpresaActual)
    End Sub
    Sub Grid()
        FormatoGrid(Me.VClientes, 2, 0)

        For i As Integer = 0 To VClientes.Columns.Count - 1
            VClientes.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        VClientes.Columns("NOMBRE").Width = 180
        Me.VClientes.Columns("#").OptionsColumn.AllowEdit = True
        Me.VClientes.Columns("#").ColumnEdit = rLink
        Me.VClientes.Columns("#").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Me.VClientes.Columns("Ver").OptionsColumn.AllowEdit = True
        Me.VClientes.Columns("Ver").ColumnEdit = rLinkAcuerdos
        Me.VClientes.Columns("Ver").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        VClientes.Columns("IdSisCliente").Visible = False
        VClientes.Columns("CONTACTO").Visible = False
        VClientes.Columns("DIRECCION").Visible = False
        VClientes.Columns("RUC").Visible = False
        VClientes.Columns("CEDULA").Visible = False
        VClientes.Columns("PNR").Visible = False
        VClientes.Columns("Cultivo").Visible = False
        VClientes.Columns("Area Mz").Visible = False
        VClientes.Columns("EXCENTO IVA").Visible = False
        VClientes.Columns("RETENEDOR IR").Visible = False
        VClientes.Columns("RETENEDOR ALCALDIA").Visible = False
        VClientes.Columns("MONEDA_CREDITO").Visible = False
        VClientes.Columns("GARANTIA").Visible = False
        VClientes.Columns("DISTRIBUIDOR").Visible = False
        VClientes.Columns("Registro").Visible = False
        VClientes.Columns("MUNICIPIO").Visible = False
        VClientes.Columns("FORMA PAGO").Visible = False

        If EmpresaActual = 1 Then
            VClientes.Columns("Correo Contacto").Visible = False
            VClientes.Columns("Ced. Contacto").Visible = False
            VClientes.Columns("Tel. Contacto").Visible = False
            VClientes.Columns("Cel. Contacto").Visible = False
            VClientes.Columns("REPRESENTANTE").Visible = False
            VClientes.Columns("Correo Representante").Visible = False
            VClientes.Columns("Ced. Representante").Visible = False
            VClientes.Columns("Tel. Representante").Visible = False
            VClientes.Columns("Cel. Representante").Visible = False
            VClientes.Columns("GERENTE").Visible = False
            VClientes.Columns("Correo Gerente").Visible = False
            VClientes.Columns("Ced. Gerente").Visible = False
            VClientes.Columns("Tel. Gerente").Visible = False
            VClientes.Columns("Cel. Gerente").Visible = False
            VClientes.Columns("CONTADOR").Visible = False
            VClientes.Columns("Correo Contador").Visible = False
            VClientes.Columns("Ced. Contador").Visible = False
            VClientes.Columns("Tel. Contador").Visible = False
            VClientes.Columns("Cel. Contador").Visible = False
            VClientes.Columns("Observaciones").Visible = False
        End If

        'Me.VClientes.Columns("LIMITE_CREDITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VClientes.Columns("LIMITE_CREDITO").DisplayFormat.FormatString = "{0:n2}"
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Dim frm As frmAgregarCliente = frmAgregarCliente.Instance()
        frm.Dispose()

        AgregarClienteQuick = False
        Dim form As frmAgregarCliente = frmAgregarCliente.Instance()

        With form
            .etInicio.Text = "1"
            Nuevo = "SI"

            .MdiParent = Me.MdiParent
            .Text = "Nuevo Cliente"
            .Show()
            .WindowState = FormWindowState.Maximized

            .etInicio.Text = "0"
        End With

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        AgregarClienteQuick = False

        If VClientes.FocusedRowHandle < 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        End If

        Dim frm As frmAgregarCliente = frmAgregarCliente.Instance()
        frm.Dispose()


        Dim form As frmAgregarCliente = frmAgregarCliente.Instance()
        With form
            .etInicio.Text = "1"
            .Cliente = Registro

            Nuevo = "NO"

            .MdiParent = Me.MdiParent
            .Text = "Editar Cliente"
            .Show()
            .WindowState = FormWindowState.Maximized

            .etInicio.Text = "0"
        End With
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If VClientes.FocusedRowHandle < 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        End If

        If Not XtraMsg2("Esta seguro que dese borrar el Cliente: " & Me.VClientes.GetFocusedRowCellValue("NOMBRE")) Then
            Exit Sub
        End If

        Try
            Clientes.Delete(Registro)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.Cargar()

    End Sub

    Private Sub frmClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub

    Private Sub dgClientes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub frmClientes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If VClientes.FocusedRowHandle < 0 Then Exit Sub
        'Dim f As frmReportesClientes = frmReportesClientes.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()

        With New frmEnviarEmailCliente
            .lblTitulo.Text = "ESTADO DE CUENTA DE SALDOS DEL CLIENTE: " & VClientes.GetFocusedRowCellValue("NOMBRE")
            .Codigo = Me.VClientes.GetFocusedRowCellValue("CODIGO")
            .IdSucursal = IIf(EmpresaActual <> 1, "", Mid(VClientes.GetFocusedRowCellValue("CODIGO LETRA"), 1, 2))
            .ShowDialog()
            .Dispose()
        End With
    End Sub


    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        If VClientes.FocusedRowHandle < 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        End If

        RegistroCliente = Registro
        AgregarClienteQuick = False

        ShowSplash()
        Inicio = True
        Dim frm As frmEstadoCuenta = frmEstadoCuenta.Instance()
        frm.Dispose()

        Dim f As frmEstadoCuenta = frmEstadoCuenta.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Estado de Cuenta Cliente"
        f.lblTitulo.Text = "ESTADO DE CUENTA CLIENTE: (" & VClientes.GetFocusedRowCellValue("CODIGO LETRA").ToString & ") - " & VClientes.GetFocusedRowCellValue("NOMBRE").ToString
        f.NombreCliente = VClientes.GetFocusedRowCellValue("CODIGO LETRA").ToString + " - " + VClientes.GetFocusedRowCellValue("NOMBRE").ToString
        f.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/RegClientes.chm")
        frmExportarImprimir.Mostrar(dgClientes)
    End Sub

    Private Sub cbIncompletos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cargar()
    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        'If VClientes.FocusedRowHandle < 0 Then
        '    XtraMsg("No hay registros en la lista")
        '    Registro = "Vacio"
        '    Exit Sub
        'Else
        '    Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        'End If

        'Dim f As frmAcumulados = frmAcumulados.Instance
        'TipoAcumulado = "C"
        'RegistroCliente = Registro
        'f.MdiParent = Me.MdiParent
        'f.Show()

        'Dim msg As String = ClasesBLL.ZohoCRMAPI.APIMethod("Leads", "getRecords", "508020000000332001")
        'XtraMsg(msg)




    End Sub

    Private Sub cmdNotasDebitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotasDebitos.Click
        If VClientes.FocusedRowHandle < 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        End If

        Dim f As frmNotasDebitoCliente = frmNotasDebitoCliente.Instance

        f.etInicio.Text = "1"
        f.etClienteCodigo.Text = Registro

        f.MdiParent = Me.MdiParent
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click

        If VClientes.FocusedRowHandle < 0 Then
            XtraMsg("No hay registros en la lista")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
        End If
        '
        frmClientesLetras.Dispose()

        With frmClientesLetras
            .MdiParent = Me.MdiParent
            .Text = "Letra de Cambio"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With


        'Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance
        'f.etInicio.Text = "1"
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
    End Sub

    Private Sub VClientes_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VClientes.FocusedRowChanged
        Registro = Me.VClientes.GetFocusedRowCellValue("CODIGO")
    End Sub

    Private Sub chkSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelector.CheckedChanged
        If Me.chkSelector.Checked = True Then Me.VClientes.ColumnsCustomization() Else Me.VClientes.DestroyCustomization()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        With FrmConfiguraCheque
            .Tipo = 21
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub rLink_Click(sender As Object, e As EventArgs) Handles rLink.Click
        If VClientes.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmDocumentos
            .Tipo = "CLIENTES"
            .Codigo = VClientes.GetFocusedRowCellValue("CODIGO")
            .NDocumento = VClientes.GetFocusedRowCellValue("NOMBRE")
            .Text = "Soporte Digital del Cliente: " & VClientes.GetFocusedRowCellValue("NOMBRE")
            .txtNombre.Text = VClientes.GetFocusedRowCellValue("NOMBRE")
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub rLinkAcuerdos_Click(sender As Object, e As EventArgs) Handles rLinkAcuerdos.Click
        If VClientes.FocusedRowHandle < 0 Then Exit Sub
        '
        frmSeguimientoCobranza.Dispose()
        '
        With frmSeguimientoCobranza
            .Text = $"Seguimiento a Cliente: {VClientes.GetRowCellValue(VClientes.FocusedRowHandle, "NOMBRE")}"
            .IdCliente = VClientes.GetRowCellValue(VClientes.FocusedRowHandle, "CODIGO")
            .ShowDialog()
            .Dispose()
        End With

        'XtraMsg("Este Cliente no contiene acuerdos de pagos")
    End Sub


End Class
