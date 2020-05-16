Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmOtrosIngresosList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmOtrosIngresosList = Nothing

    Public Shared Function Instance() As frmOtrosIngresosList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOtrosIngresosList()
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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbPagar As System.Windows.Forms.ComboBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtrosIngresosList))
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.cbPagar = New System.Windows.Forms.ComboBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.etBalance = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseForeColor = True
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(12, 180)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(107, 38)
        Me.btnImprimir.StyleController = Me.LayoutControl2
        Me.btnImprimir.TabIndex = 165
        Me.btnImprimir.Text = "&Imprimir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.btnExportar)
        Me.LayoutControl2.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl2.Controls.Add(Me.btnImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdVer)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1035, 594, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 381)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 331)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 29
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Appearance.Options.UseForeColor = True
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 289)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(107, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 30
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 247)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(107, 38)
        Me.btnExportar.StyleController = Me.LayoutControl2
        Me.btnExportar.TabIndex = 172
        Me.btnExportar.Text = "&Exportar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdNuevo.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdNuevo.Appearance.Options.UseFont = True
        Me.cmdNuevo.Appearance.Options.UseForeColor = True
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 54)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(107, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl2
        Me.cmdNuevo.TabIndex = 164
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Buscar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBorrar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdBorrar.Appearance.Options.UseFont = True
        Me.cmdBorrar.Appearance.Options.UseForeColor = True
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 138)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(107, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 161
        Me.cmdBorrar.Text = "A&nular"
        '
        'cmdVer
        '
        Me.cmdVer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdVer.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVer.Appearance.Options.UseFont = True
        Me.cmdVer.Appearance.Options.UseForeColor = True
        Me.cmdVer.Enabled = False
        Me.cmdVer.ImageOptions.Image = CType(resources.GetObject("cmdVer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVer.Location = New System.Drawing.Point(12, 96)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(107, 38)
        Me.cmdVer.StyleController = Me.LayoutControl2
        Me.cmdVer.TabIndex = 160
        Me.cmdVer.Text = "&Ver Ingreso"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.EmptySpaceItem1, Me.LayoutControlItem12})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 381)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdNuevo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdVer
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdBorrar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnImprimir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnExportar
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 235)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdAyuda
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 277)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        Me.LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdSalir
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 319)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(111, 25)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdAceptar
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'dtpInicial
        '
        Me.dtpInicial.Enabled = False
        Me.dtpInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicial.Location = New System.Drawing.Point(130, 62)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(51, 20)
        Me.dtpInicial.TabIndex = 167
        '
        'dtpFinal
        '
        Me.dtpFinal.Enabled = False
        Me.dtpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(242, 62)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(47, 20)
        Me.dtpFinal.TabIndex = 169
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(432, 12)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(21, 21)
        Me.etInicio.TabIndex = 174
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'chkFecha
        '
        Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFecha.Location = New System.Drawing.Point(12, 62)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(57, 20)
        Me.chkFecha.TabIndex = 175
        Me.chkFecha.Text = "Por Fecha:"
        Me.chkFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbPagar
        '
        Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar.Location = New System.Drawing.Point(69, 37)
        Me.cbPagar.Name = "cbPagar"
        Me.cbPagar.Size = New System.Drawing.Size(384, 21)
        Me.cbPagar.TabIndex = 176
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(350, 62)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(21, 20)
        Me.txtCheque.TabIndex = 178
        Me.txtCheque.Visible = False
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(432, 62)
        Me.txtFactura.MaxLength = 13
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(21, 20)
        Me.txtFactura.TabIndex = 180
        Me.txtFactura.Visible = False
        '
        'etBalance
        '
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etBalance.Location = New System.Drawing.Point(382, 12)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(46, 21)
        Me.etBalance.TabIndex = 185
        Me.etBalance.Text = "0"
        Me.etBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etBalance.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(69, 12)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(252, 21)
        Me.cbBancos.TabIndex = 182
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 86)
        Me.dgDatos.MainView = Me.vData
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(441, 310)
        Me.dgDatos.TabIndex = 186
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vData, Me.GridView2})
        '
        'vData
        '
        Me.vData.GridControl = Me.dgDatos
        Me.vData.Name = "vData"
        Me.vData.OptionsBehavior.Editable = False
        Me.vData.OptionsView.ShowAutoFilterRow = True
        Me.vData.OptionsView.ShowFooter = True
        Me.vData.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgDatos
        Me.GridView2.Name = "GridView2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.cbBancos)
        Me.LayoutControl1.Controls.Add(Me.etBalance)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.chkFecha)
        Me.LayoutControl1.Controls.Add(Me.txtCheque)
        Me.LayoutControl1.Controls.Add(Me.dtpInicial)
        Me.LayoutControl1.Controls.Add(Me.dtpFinal)
        Me.LayoutControl1.Controls.Add(Me.cbPagar)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(649, 248, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(465, 408)
        Me.LayoutControl1.TabIndex = 188
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(465, 408)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(445, 314)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbBancos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(313, 25)
        Me.LayoutControlItem2.Text = "Caja:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.etBalance
        Me.LayoutControlItem3.Location = New System.Drawing.Point(313, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(107, 25)
        Me.LayoutControlItem3.Text = "Balance:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbPagar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(445, 25)
        Me.LayoutControlItem4.Text = "Cobrado a:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.etInicio
        Me.LayoutControlItem5.Location = New System.Drawing.Point(420, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(25, 25)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkFecha
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(61, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpInicial
        Me.LayoutControlItem7.Location = New System.Drawing.Point(61, 50)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(112, 24)
        Me.LayoutControlItem7.Text = "Desde:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtpFinal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(173, 50)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(108, 24)
        Me.LayoutControlItem8.Text = "Hasta:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCheque
        Me.LayoutControlItem9.Location = New System.Drawing.Point(281, 50)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(82, 24)
        Me.LayoutControlItem9.Text = "No. Ck:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtFactura
        Me.LayoutControlItem10.Location = New System.Drawing.Point(363, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(82, 24)
        Me.LayoutControlItem10.Text = "Factura:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        Me.DockPanel1.ID = New System.Guid("f7d39d4e-0b7b-4b0a-87a0-fed7718d0e65")
        Me.DockPanel1.Location = New System.Drawing.Point(465, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 408)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 381)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmOtrosIngresosList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(605, 408)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmOtrosIngresosList"
        Me.Text = "Otros Ingresos"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Comp As New VB.SysContab.ComprobanteDB()
    Dim compDet As New VB.SysContab.ComprobantesDetails()
    Dim r As New VB.SysContab.Rutinas()
    Dim PerDB As New VB.SysContab.PeriodosDB()
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim Cajas As New VB.SysContab.CajasDB()

    Dim Fecha1 As String
    Dim Fecha2 As String

    Dim ds As DataSet

    Dim i As Integer

    Private Sub frmOtrosIngresosList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.LayoutControl2)

        Me.dtpInicial.Value = VB.SysContab.Rutinas.Fecha().Date
        Me.dtpFinal.Value = VB.SysContab.Rutinas.Fecha().Date

        Me.dtpFinal.MinDate = Me.dtpFinal.Value
        Fecha1 = ""
        Fecha2 = ""

        Me.dtpInicial.Enabled = False
        Me.dtpFinal.Enabled = False

        Me.cbBancos.DataSource = Catalogo.CatalogoList("A", 1).Tables("CATALOGO")
        Me.cbBancos.ValueMember = "Cuenta"
        Me.cbBancos.DisplayMember = "Nombre"

        Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
        Me.cbPagar.ValueMember = "Codigo"
        Me.cbPagar.DisplayMember = "Nombre"

        Cargar()
        Grid()
        'r.ComboAutoComplete(Me.cbPagar)
    End Sub

    Public Sub Cargar()
        Me.dgDatos.DataSource =
            Comp.OtrosIngresosList(
            cbBancos.SelectedValue,
            Fecha1,
            Fecha2, 0, "", "").Tables("Comprobantes").DefaultView
    End Sub

    Sub Grid()
        Me.vData.PopulateColumns()
        FormatoGrid(vData, 2, 0, False)

        Me.vData.Columns("Recibo").VisibleIndex = 0
        Me.vData.Columns("Comp_No").Visible = False
        Me.vData.Columns("Per_ID").Visible = False

        'Me.vData.Columns("Nombre").BestFit()
        'Me.vData.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vData.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        'Me.vData.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vData.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    'Private Sub dgComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgComprobantes.DoubleClick
    '    MostrarComprobante()
    'End Sub

    Public Function Validar() As Boolean
        If CDate(dtpInicial.Value).ToShortDateString > CDate(dtpFinal.Value).ToShortDateString Then
            MsgBox("La Fecha Final debe ser Mayor o Igual a la Fecha Inicial")
            Return False
        End If
        Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub MostrarComprobante()
        If Me.vData.DataRowCount < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmOtrosIngresosVer = DataGridTextBoxCombo.frmOtrosIngresosVer.Instance()
        f.MdiParent = Me.MdiParent
        f.etInicio.Text = "1"
        f.etComprobante.Text = Me.vData.GetFocusedRowCellValue("Comp_No")
        f.etFecha.Text = Me.vData.GetFocusedRowCellValue("Fecha")
        f.etPeriodo.Text = Me.vData.GetFocusedRowCellValue("Per_ID")
        f.Show()
        f.Text = "Ver Ingreso"
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        'Exit Sub
        MostrarComprobante()
    End Sub

    Private Sub dtpInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicial.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.dtpFinal.MinDate = Me.dtpInicial.Value.Date
        Fecha1 = Me.dtpInicial.Value.Date
        Buscar()
    End Sub

    Private Sub dtpFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFinal.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.dtpInicial.MaxDate = Me.dtpFinal.Value.Date
        Fecha2 = Me.dtpFinal.Value.Date
        Buscar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vData.DataRowCount < 0 Then
            MsgBox("Seleccione el registro que desea Anular", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Registros As Integer

        Registros = Comp.ComprobanteAnularBuscar(Me.vData.GetFocusedRowCellValue("Comp_No"), _
                                                 Me.vData.GetFocusedRowCellValue("Per_ID"), _
                                                 Me.vData.GetFocusedRowCellValue("Fecha"))

        If Registros > 0 Then
            MsgBox("El registro ya fue ANULADO", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("¿Esta seguro que desea ANULAR el Registro", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            Comp.ComprobanteAnular(Me.vData.GetFocusedRowCellValue("Comp_No"), _
                                    Me.vData.GetFocusedRowCellValue("Per_ID"), _
                                    Me.vData.GetFocusedRowCellValue("Fecha"))

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

        Buscar()
    End Sub

    Private Sub Buscar()
        Me.dgDatos.DataSource = Comp.OtrosIngresosList(Me.cbBancos.SelectedValue, Fecha1, Fecha2, Me.cbPagar.SelectedValue, Me.txtFactura.Text, Me.txtCheque.Text).Tables("Comprobantes").DefaultView
        Me.vData.PopulateColumns()
        FormatoGrid(Me.vData, 2, 0, False)

        Me.vData.Columns("Recibo").VisibleIndex = 0
        Me.vData.Columns("Comp_No").Visible = False
        Me.vData.Columns("Per_ID").Visible = False
        Me.vData.Columns("Nombre").BestFit()

        Me.vData.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vData.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vData.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vData.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        If chkFecha.Checked = True Then
            Me.dtpInicial.Enabled = True
            Me.dtpFinal.Enabled = True
            Fecha1 = Me.dtpInicial.Value.Date
            Fecha2 = Me.dtpFinal.Value.Date
            Me.dtpFinal.MinDate = Me.dtpInicial.Value
        Else
            Me.dtpInicial.Enabled = False
            Me.dtpFinal.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If
        Buscar()
    End Sub

    Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        Buscar()
    End Sub

    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '    If Me.dgComprobantes.CurrentRowIndex < 0 Then
    '        MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim ValorLetras As String = r.ConversionDecimales(CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4)))  'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
    '    Dim fReportes As New frmReportes()
    '    Dim rFactura As New rptComprobanteCKDinamico()
    '    rFactura.SetDataSource(Comp.ImprimirCombrobante(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), ValorLetras, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2), CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4))))
    '    fReportes.crvReportes.ReportSource = rFactura
    '    fReportes.Show()
    'End Sub

    'Private Sub cmdImprimirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirComp.Click
    '    If Me.dgComprobantes.CurrentRowIndex < 0 Then
    '        MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim ValorLetras As String = r.ConversionDecimales(CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4)))  'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
    '    Dim fReportes As New frmReportes()
    '    Dim rFactura As New rptComprobanteCheque2()
    '    rFactura.SetDataSource(Comp.ImprimirCombrobante(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), ValorLetras, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2), CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4))))
    '    fReportes.crvReportes.ReportSource = rFactura
    '    fReportes.Show()
    'End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("La Computadora " & Environment.MachineName.ToString & " no está configurada como Caja", formtitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim f As frmOtrosIngresos = frmOtrosIngresos.Instance()
        f.MdiParent = Me.MdiParent
        f.etInicio.Text = "1"
        f.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        Saldo()
        Buscar()
    End Sub

    Private Sub Saldo()
        If Me.cbBancos.SelectedValue = "0" Then
            ' Me.Label8.Visible = False
            Me.etBalance.Text = 0
            Me.etBalance.Visible = False
        Else
            '  Me.Label8.Visible = True
            Me.etBalance.Visible = True

            Me.etBalance.Text = CDbl(Comp.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Actual)).ToString(Round)
        End If
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ClientesOstrosIngresos.chm")
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If vData.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        VB.SysContab.ClientesDB.ImprimirRecibo(vData.GetFocusedRowCellValue("Recibo"), "", 1)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgDatos, "Otros Ingresos")
    End Sub

    Private Sub cbBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedIndexChanged

    End Sub
End Class
