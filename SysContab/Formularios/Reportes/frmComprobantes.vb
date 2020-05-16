Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraReports.UI
Imports ClasesBLL

Public Class frmComprobantes
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgComprobantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents VComprobantes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnDiferencias As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantes))
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDiferencias = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintAll = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMes = New DevExpress.XtraEditors.LookUpEdit()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbPeriodo = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgComprobantes = New DevExpress.XtraGrid.GridControl()
        Me.VComprobantes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Appearance.Options.UseTextOptions = True
        Me.Button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Button1.Enabled = False
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 38)
        Me.Button1.StyleController = Me.LayoutControl2
        Me.Button1.TabIndex = 162
        Me.Button1.Text = "&Exportar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.Button1)
        Me.LayoutControl2.Controls.Add(Me.bDiseno)
        Me.LayoutControl2.Controls.Add(Me.bBorrar)
        Me.LayoutControl2.Controls.Add(Me.btnDiferencias)
        Me.LayoutControl2.Controls.Add(Me.btnPrintAll)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.btnPrint)
        Me.LayoutControl2.Controls.Add(Me.cmdVer)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1035, 70, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 447)
        Me.LayoutControl2.TabIndex = 180
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Options.UseTextOptions = True
        Me.cmdSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 380)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 29
        Me.cmdSalir.Text = "&Salir"
        '
        'bDiseno
        '
        Me.bDiseno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDiseno.Appearance.Options.UseTextOptions = True
        Me.bDiseno.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(12, 296)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(108, 38)
        Me.bDiseno.StyleController = Me.LayoutControl2
        Me.bDiseno.TabIndex = 179
        Me.bDiseno.Text = "Di&seño"
        '
        'bBorrar
        '
        Me.bBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBorrar.Appearance.Options.UseTextOptions = True
        Me.bBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(12, 180)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(108, 38)
        Me.bBorrar.StyleController = Me.LayoutControl2
        Me.bBorrar.TabIndex = 180
        Me.bBorrar.Text = "&Borrar"
        '
        'btnDiferencias
        '
        Me.btnDiferencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiferencias.Appearance.Options.UseTextOptions = True
        Me.btnDiferencias.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDiferencias.Enabled = False
        Me.btnDiferencias.ImageOptions.Image = CType(resources.GetObject("btnDiferencias.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDiferencias.Location = New System.Drawing.Point(12, 222)
        Me.btnDiferencias.Name = "btnDiferencias"
        Me.btnDiferencias.Size = New System.Drawing.Size(108, 38)
        Me.btnDiferencias.StyleController = Me.LayoutControl2
        Me.btnDiferencias.TabIndex = 177
        Me.btnDiferencias.Text = "Encontrar &Diferencias"
        '
        'btnPrintAll
        '
        Me.btnPrintAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintAll.Appearance.Options.UseTextOptions = True
        Me.btnPrintAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnPrintAll.Enabled = False
        Me.btnPrintAll.ImageOptions.Image = CType(resources.GetObject("btnPrintAll.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintAll.Location = New System.Drawing.Point(12, 96)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(108, 38)
        Me.btnPrintAll.StyleController = Me.LayoutControl2
        Me.btnPrintAll.TabIndex = 178
        Me.btnPrintAll.Text = "Imprimir &Lista"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBorrar.Appearance.Options.UseTextOptions = True
        Me.cmdBorrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 138)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(108, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 161
        Me.cmdBorrar.Text = "A&nular"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Appearance.Options.UseTextOptions = True
        Me.btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnPrint.Enabled = False
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(12, 54)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 38)
        Me.btnPrint.StyleController = Me.LayoutControl2
        Me.btnPrint.TabIndex = 30
        Me.btnPrint.Text = "&Imprimir"
        '
        'cmdVer
        '
        Me.cmdVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdVer.Appearance.Options.UseTextOptions = True
        Me.cmdVer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVer.Enabled = False
        Me.cmdVer.ImageOptions.Image = CType(resources.GetObject("cmdVer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVer.Location = New System.Drawing.Point(12, 12)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(108, 38)
        Me.cmdVer.StyleController = Me.LayoutControl2
        Me.cmdVer.TabIndex = 160
        Me.cmdVer.Text = "&Ver Comprobante"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 430)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdVer
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnPrint
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnPrintAll
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdBorrar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.bBorrar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnDiferencias
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bDiseno
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 284)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Button1
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 326)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdSalir
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 252)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(112, 32)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Appearance.Options.UseTextOptions = True
        Me.cmdAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_FindLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(556, 42)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(86, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Buscar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckBox2)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.cbMes)
        Me.LayoutControl1.Controls.Add(Me.CheckBox1)
        Me.LayoutControl1.Controls.Add(Me.cbPeriodo)
        Me.LayoutControl1.Controls.Add(Me.dgComprobantes)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(651, 363, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(851, 474)
        Me.LayoutControl1.TabIndex = 178
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox2.Location = New System.Drawing.Point(659, 36)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(180, 20)
        Me.CheckBox2.TabIndex = 180
        Me.CheckBox2.Text = "Imprimir Con Distribución"
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(107, 60)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Properties.Appearance.Options.UseFont = True
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.NullText = "[Seleccione Tipo de Comprobante]"
        Me.cbTipo.Properties.ShowFooter = False
        Me.cbTipo.Properties.ShowHeader = False
        Me.cbTipo.Size = New System.Drawing.Size(445, 20)
        Me.cbTipo.StyleController = Me.LayoutControl1
        Me.cbTipo.TabIndex = 179
        '
        'cbMes
        '
        Me.cbMes.Location = New System.Drawing.Point(107, 36)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Properties.Appearance.Options.UseFont = True
        Me.cbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMes.Properties.NullText = "[Seleccione Mes]"
        Me.cbMes.Properties.ShowFooter = False
        Me.cbMes.Properties.ShowHeader = False
        Me.cbMes.Size = New System.Drawing.Size(445, 20)
        Me.cbMes.StyleController = Me.LayoutControl1
        Me.cbMes.TabIndex = 179
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox1.Location = New System.Drawing.Point(659, 60)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(180, 20)
        Me.CheckBox1.TabIndex = 174
        Me.CheckBox1.Text = "Mostrar Más Datos"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(107, 12)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.Properties.Appearance.Options.UseFont = True
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.NullText = "[Seleccione Periodo Contable]"
        Me.cbPeriodo.Properties.ShowFooter = False
        Me.cbPeriodo.Properties.ShowHeader = False
        Me.cbPeriodo.Size = New System.Drawing.Size(445, 20)
        Me.cbPeriodo.StyleController = Me.LayoutControl1
        Me.cbPeriodo.TabIndex = 174
        '
        'dgComprobantes
        '
        Me.dgComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgComprobantes.Location = New System.Drawing.Point(12, 84)
        Me.dgComprobantes.MainView = Me.VComprobantes
        Me.dgComprobantes.Name = "dgComprobantes"
        Me.dgComprobantes.Size = New System.Drawing.Size(827, 378)
        Me.dgComprobantes.TabIndex = 173
        Me.dgComprobantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VComprobantes})
        '
        'VComprobantes
        '
        Me.VComprobantes.GridControl = Me.dgComprobantes
        Me.VComprobantes.Name = "VComprobantes"
        Me.VComprobantes.OptionsBehavior.Editable = False
        Me.VComprobantes.OptionsFind.AlwaysVisible = True
        Me.VComprobantes.OptionsFind.ShowClearButton = False
        Me.VComprobantes.OptionsView.ShowAutoFilterRow = True
        Me.VComprobantes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VComprobantes.OptionsView.ShowFooter = True
        Me.VComprobantes.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(851, 474)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgComprobantes
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(831, 382)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbPeriodo
        Me.LayoutControlItem2.CustomizationFormText = "Periodo:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Periodo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMes
        Me.LayoutControlItem3.CustomizationFormText = "Mes:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Mes:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbTipo
        Me.LayoutControlItem4.CustomizationFormText = "Tipo Comprobante:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(544, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Tipo Comprobante:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CheckBox1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(647, 48)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(634, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(13, 72)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAceptar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(544, 30)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(544, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(90, 30)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(647, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(184, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CheckBox2
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(647, 24)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Archivos de Excel 97-2003 (*.xls)|*.xls"
        Me.SaveFileDialog1.Title = "Exportar Información de Comprobantes"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("7242a80e-2e57-456c-8b8c-fc1ddf757a51")
        Me.DockPanel1.Location = New System.Drawing.Point(851, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowFloating = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 474)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 447)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmComprobantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(991, 474)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmComprobantes"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Comp As New VB.SysContab.ComprobanteDB
    Dim compDet As New VB.SysContab.ComprobantesDetails
    Dim Mes As New VB.SysContab.MesesDB
    Dim PerDB As New VB.SysContab.PeriodosDB
    Dim Catalogo As New VB.SysContab.CatalogoDB
    Public Begin As Boolean = False

    Private Shared ChildInstance As frmComprobantes = Nothing
    Public Shared Function Instance() As frmComprobantes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComprobantes
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

    Private Sub frmComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        IdRecursoComp = Recurso
        ''
        CargarCombos()
        '
        Buscar()
        PopulateGrid()
    End Sub

    Sub CargarCombos()
        cbMes.Properties.DataSource = Mes.GetList().Tables("Meses")
        cbMes.Properties.ValueMember = "Numero"
        cbMes.Properties.DisplayMember = "Mes"
        cbMes.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbMes.Properties.Columns.Count - 1
            Me.cbMes.Properties.Columns(i).Visible = False
        Next

        Me.cbMes.Properties.Columns("Mes").Visible = True
        cbMes.EditValue = Now.Month
        '
        cbPeriodo.Properties.DataSource = PerDB.GetList().Tables("Periodos")
        cbPeriodo.Properties.ValueMember = "codigo"
        cbPeriodo.Properties.DisplayMember = "descripcion"
        cbPeriodo.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbPeriodo.Properties.Columns.Count - 1
            Me.cbPeriodo.Properties.Columns(i).Visible = False
        Next

        Me.cbPeriodo.Properties.Columns("descripcion").Visible = True

        Dim Periodo As Integer = VB.SysContab.PeriodosDB.Actual
        If Periodo <> 0 Then
            Me.cbPeriodo.EditValue = Periodo
        End If
        '
        Me.cbTipo.Properties.DataSource = VB.SysContab.ComprobanteDB.GetTiposComprobantes.Tables("TipoComprobantes")
        Me.cbTipo.Properties.ValueMember = "TipComp_Id"
        Me.cbTipo.Properties.DisplayMember = "TipComp_Nombre"
        Me.cbTipo.Properties.PopulateColumns()

        For i As Integer = 0 To Me.cbTipo.Properties.Columns.Count - 1
            Me.cbTipo.Properties.Columns(i).Visible = False
        Next

        Me.cbTipo.Properties.Columns(2).Visible = True
        Me.cbTipo.ItemIndex = 0

        'CbMeses.DataSource = Mes.GetList().Tables("Meses")
        'CbMeses.ValueMember = "Numero"
        'CbMeses.DisplayMember = "Mes"
        'Me.CbMeses.SelectedIndex = Now.Month

        'cbPeriodos.DataSource = PerDB.GetList().Tables("Periodos")
        'cbPeriodos.ValueMember = "codigo"
        'cbPeriodos.DisplayMember = "descripcion"

        'cbTipoComprobante.DataSource = VB.SysContab.ComprobanteDB.GetTiposComprobantes.Tables("TipoComprobantes")
        'cbTipoComprobante.ValueMember = "TipComp_Id"
        'cbTipoComprobante.DisplayMember = "TipComp_Nombre"

        'Me.cbTipoComprobante.SelectedValue = 0

        'Dim Periodo As Integer = VB.SysContab.PeriodosDB.Actual
        'If Periodo <> 0 Then
        '    Me.cbPeriodos.SelectedValue = Periodo
        'End If
    End Sub

    Private Sub dgComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarComprobante()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ShowSplash("Cargando Comprobantes...")
        Buscar()
        HideSplash()
    End Sub

    Private Sub cmdProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub MostrarComprobante()
        Dim fn As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        fn.Dispose()
        '
        Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
        f.txtlNoComprobante.Text = Me.VComprobantes.GetFocusedRowCellValue("Numero Comp")
        f.txtConsecutivo.Text = IsNull(Me.VComprobantes.GetFocusedRowCellValue("Concecutivo"), "")
        f.Periodo = Me.VComprobantes.GetFocusedRowCellValue("Per_ID")
        f.Fecha.EditValue = Me.VComprobantes.GetFocusedRowCellValue("Fecha")
        f.Fecha1 = Me.VComprobantes.GetFocusedRowCellValue("Fecha")
        f.ComprobanteID = Me.VComprobantes.GetFocusedRowCellValue("ComprobanteID")
        f.TipoLiq = Me.VComprobantes.GetFocusedRowCellValue("TipoLiq")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        If Me.VComprobantes.FocusedRowHandle < 0 Then Exit Sub
        '
        MostrarComprobante()
    End Sub

    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Not IsNumeric(Me.cbPeriodos.SelectedValue) Then
        '    Exit Sub
        'End If
        ''
        'If Not Begin Then ShowSplash()
        'Buscar()
        'If Not Begin Then HideSplash()
    End Sub

    Public Sub Buscar()
        If Not IsNumeric(Me.cbPeriodo.EditValue) Or Not IsNumeric(Me.cbTipo.EditValue) Or _
            Not IsNumeric(Me.cbMes.EditValue) Then
            Exit Sub
        End If
        '
        dgComprobantes.DataSource = ComprobanteDB.GetComprobantesList(Me.cbPeriodo.EditValue, Me.cbMes.EditValue, Me.cbTipo.EditValue).Tables(0)
    End Sub

    Sub PopulateGrid()
        If dgComprobantes.DataSource Is Nothing Then Exit Sub

        Me.VComprobantes.PopulateColumns()
        FormatoGrid(Me.VComprobantes)

        'Me.VComprobantes.Columns(0).Width = 50
        'Me.VComprobantes.Columns(1).Width = 50
        'Me.VComprobantes.Columns(2).Width = 50
        'Me.VComprobantes.Columns(7).Width = 200
        'Me.VComprobantes.Columns(12).Width = 80
        'Me.VComprobantes.Columns(13).Width = 80
        'Me.VComprobantes.Columns(14).Width = 80

        Me.VComprobantes.Columns(0).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        '    
        Me.VComprobantes.Columns("Mes").Visible = False
        Me.VComprobantes.Columns("Per_ID").Visible = False
        Me.VComprobantes.Columns("T").Visible = False
        Me.VComprobantes.Columns("Proveedor").Visible = False
        Me.VComprobantes.Columns("Cheque").Visible = False
        Me.VComprobantes.Columns("Recibo").Visible = False
        Me.VComprobantes.Columns("Factura").Visible = False
        Me.VComprobantes.Columns("Nombre Cheque").Visible = False
        Me.VComprobantes.Columns("ComprobanteID").Visible = False
        Me.VComprobantes.Columns("TipoLiq").Visible = False
        Me.VComprobantes.Columns("Diferencia").Visible = False
        Me.VComprobantes.Columns("Deposito").Visible = False
        Me.VComprobantes.Columns("Tasa").Visible = False
        '
        Me.VComprobantes.Columns("Mes").OptionsColumn.ShowInCustomizationForm = False
        'Me.VComprobantes.Columns("Per_ID").OptionsColumn.ShowInCustomizationForm = False
        Me.VComprobantes.Columns("T").OptionsColumn.ShowInCustomizationForm = False
        'Me.VComprobantes.Columns("Proveedor").OptionsColumn.ShowInCustomizationForm = False
        'Me.VComprobantes.Columns("ComprobanteID").OptionsColumn.ShowInCustomizationForm = False
        Me.VComprobantes.Columns("TipoLiq").OptionsColumn.ShowInCustomizationForm = False
        Me.VComprobantes.Columns("Concecutivo").Caption = "Consecutivo"
        '
        '----------------------------------------------------------------------------------
        'Campos Adicionales Para el terraza
        'Me.VComprobantes.Columns("MontoU$").Visible = False
        'Me.VComprobantes.Columns("Moneda").Visible = False
        'Me.VComprobantes.Columns("Tasa Cambio").Visible = False
        'Me.VComprobantes.Columns("Cuenta Banco").Visible = False
        'Me.VComprobantes.Columns("MontoU$").OptionsColumn.ShowInCustomizationForm = True
        'Me.VComprobantes.Columns("Moneda").OptionsColumn.ShowInCustomizationForm = True
        'Me.VComprobantes.Columns("Tasa Cambio").OptionsColumn.ShowInCustomizationForm = True
        'Me.VComprobantes.Columns("Cuenta Banco").OptionsColumn.ShowInCustomizationForm = True
        '----------------------------------------------------------------------------------
        Me.VComprobantes.Columns("Debitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Debitos").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Debitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Debitos").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.VComprobantes.Columns("Creditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Creditos").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Creditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Creditos").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.VComprobantes.Columns("Diferencia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Diferencia").DisplayFormat.FormatString = "{0:n2}"
        Me.VComprobantes.Columns("Diferencia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VComprobantes.Columns("Diferencia").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VComprobantes.Columns("Tasa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VComprobantes.Columns("Tasa").DisplayFormat.FormatString = "{0:n4}"
        '
        'Me.VComprobantes.Columns("Numero Comp").BestFit()
        'Me.VComprobantes.Columns("Concecutivo").BestFit()
        'Me.VComprobantes.Columns("No. Orden").BestFit()
        'Me.VComprobantes.Columns("Fecha").BestFit()
        'Me.VComprobantes.Columns("Tipo Comp").BestFit()
        Me.VComprobantes.Columns("Concepto Comprobante").Width = 250
        'Me.VComprobantes.Columns("Debitos").BestFit()
        'Me.VComprobantes.Columns("Creditos").BestFit()
        'Me.VComprobantes.Columns("Moneda").BestFit()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VComprobantes.FocusedRowHandle < 0 Then Exit Sub

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VComprobantes.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------
        '
        Dim Registros As Integer =
            ComprobanteDB.ComprobanteAnularBuscar(
            VComprobantes.GetFocusedRowCellValue("Numero Comp"),
            VComprobantes.GetFocusedRowCellValue("Per_ID"),
            VComprobantes.GetFocusedRowCellValue("Fecha"))

        If Registros > 0 Then
            XtraMsg("El comprobante ya fue anulado", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Anular As Integer =
            ComprobanteDB.ComprobanteAnularBuscar(
            VComprobantes.GetFocusedRowCellValue("ComprobanteID"))

        If Anular = 0 Then
            XtraMsg("No se puede Aular este Comprobante, vaya el módulo correspondiente y anule el Documento fuente",
                    MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Verificar si el Comprobante Contiene cuentas de Ingreso y si el Mes ya esta declarado RAMAC
        If ObtieneDatos("sp_ValidarIngresosBOLNASA", VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Numero Comp"),
                        VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID"),
                        CDate(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha")).Month,
                        EmpresaActual).Rows.Count > 0 Then

            'Verificar Cierre de Bolsa
            If CDate(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha")).Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                XtraMsg("La Comprobante No: " & VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Numero Comp").ToString() & " ya fue reportado en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al:  " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString,
                        MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'Si es una factura de compra
        'If Me.VComprobantes.GetFocusedRowCellValue("Factura") <> "" Then
        '    If Me.VComprobantes.GetFocusedRowCellValue("Proveedor") <> 0 Then
        '        MsgBox("No se puede borrar un comprobante de Factura de Compra, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
        '        Exit Sub
        '    Else
        '        MsgBox("No se puede borrar un comprobante de Factura de Venta, vaya al modulo correspondiente para anular la factura", MsgBoxStyle.Critical, "STS-Contab")
        '        Exit Sub
        '    End If
        'End If


        If Not XtraMsg2("¿Esta seguro que desea anular el comprobante No.: " & Me.VComprobantes.GetFocusedRowCellValue("Numero Comp") & _
            " de la fecha: " & Me.VComprobantes.GetFocusedRowCellValue("Fecha")) Then
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            ComprobanteDB.ComprobanteAnular(Me.VComprobantes.GetFocusedRowCellValue("Numero Comp"), _
                    Me.VComprobantes.GetFocusedRowCellValue("Per_ID"), _
                    Me.VComprobantes.GetFocusedRowCellValue("Fecha"))

            GuardaDatosTrans("DELETE FROM Distribucion WHERE NoComp = " & Me.VComprobantes.GetFocusedRowCellValue("Numero Comp") & _
                " AND Per_Id = " & Me.VComprobantes.GetFocusedRowCellValue("Per_ID") & " AND IdEmpresa = " & EmpresaActual & " AND Mes = " & _
                    Me.VComprobantes.GetFocusedRowCellValue("Mes"))

            ComprobanteDB.CancelarFactura(Me.VComprobantes.GetFocusedRowCellValue("Factura"), _
                Me.VComprobantes.GetFocusedRowCellValue("Proveedor"), 0)

            ComprobanteDB.PagosFacturasBorrar(Me.VComprobantes.GetFocusedRowCellValue("Numero Comp"), _
                    Me.VComprobantes.GetFocusedRowCellValue("Mes"), _
                    Me.VComprobantes.GetFocusedRowCellValue("Per_ID"))

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Buscar()
    End Sub

    'Private Sub cmdOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdenar.Click

    '    Exit Sub

    '    If Me.CbMeses.SelectedValue = 0 Then
    '        MsgBox("Seleccione el mes", MsgBoxStyle.Information)
    '        Me.CbMeses.Focus()
    '        Exit Sub
    '    End If

    '    Dim dsComp As DataSet
    '    Dim i As Integer

    '    dsComp = Comp.ComprobantesOrdenarXFecha(cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))

    '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
    '    DBConnFacturas.Open()
    '    transaccionFacturas = DBConnFacturas.BeginTransaction()

    '    Try
    '        For i = 0 To dsComp.Tables("Comprobantes").Rows.Count - 1
    '            Comp.ComprobantesOrdenarUpdate(dsComp.Tables("Comprobantes").Rows(i).Item("Comp_No"), cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1), i + 1)
    '        Next

    '        Comp.ComprobantesOrdenar(cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))
    '        VB.SysContab.Rutinas.okTransaccion()

    '    Catch ex As Exception
    '        VB.SysContab.Rutinas.ErrorTransaccion()
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try
    '    Buscar()
    'End Sub

    Private Sub MostrarFactura()
        Dim f As DataGridTextBoxCombo.frmFacturaProveedorEditar = f.Instance
        f.Comp = Me.VComprobantes.GetFocusedRowCellValue("Numero Comp")
        f.Per = Me.VComprobantes.GetFocusedRowCellValue("Per_ID")
        f.Fecha = Me.VComprobantes.GetFocusedRowCellValue("Fecha")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    'Private Sub MostrarCheque()
    '    Dim f As DataGridTextBoxCombo.frmChequesEditar = f.Instance
    '    f.MdiParent = Me.MdiParent
    '    f.etInicio.Text = "1"
    '    f.etComprobante.Text = Me.VComprobantes.GetFocusedRowCellValue("Numero Comp")
    '    f.etFecha.Text = Me.VComprobantes.GetFocusedRowCellValue("Fecha")
    '    f.etPeriodo.Text = Me.VComprobantes.GetFocusedRowCellValue("Per_ID")
    '    f.Show()
    '    f.WindowState = FormWindowState.Maximized
    '    f.etInicio.Text = "0"
    'End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then Me.VComprobantes.ColumnsCustomization() Else Me.VComprobantes.DestroyCustomization()
    End Sub

    Private Sub VComprobantes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VComprobantes.DoubleClick
        If Me.VComprobantes.FocusedRowHandle < 0 Then Exit Sub
        '
        MostrarComprobante()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'If Me.VComprobantes.FocusedRowHandle < 0 Then Exit Sub
        '
        If VComprobantes.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        'If Me.VComprobantes.RowCount = 0 Then
        '    MsgBox("No Hay Elementos en la Lista para Imprimir", MsgBoxStyle.Information, Me.Text)
        '    Exit Sub
        'End If

        'Dim ValorLetras As String = VB.SysContab.Rutinas.Letras(CDbl(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Debitos")).ToString(Round))
        ''Dim fReportes As New frmReportes
        ''Dim rFactura As New rptComprobante
        'Dim DT As New DataSet
        'Dim DTL As New DataSet
        ''DT = Comp.ImprimirCombrobante(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0)), VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID"), ValorLetras, VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha"), CDbl(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Debitos")))
        'DT = Comp.PrintEncabezado(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0)), VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID"), ValorLetras, VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha"), CDbl(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Debitos")))
        'DTL = Comp.PrintDetalle(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0)), VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID"), ValorLetras, VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha"), CDbl(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Debitos")))

        'DT.WriteXml(Application.StartupPath & "\xml\rptComprobante.xml", XmlWriteMode.WriteSchema)
        'DTL.WriteXml(Application.StartupPath & "\xml\rptComprobanteDetalle.xml", XmlWriteMode.WriteSchema)

        'Dim rptDT As New rptComprobantesEncabezado
        'Dim rptDTL As New rptComprobanteDetalle

        'rptDTL.DataSource = DTL     'Comp.PrintDetalle(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0)), VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID"), ValorLetras, VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha"), CDbl(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Debitos")))
        'rptDT.DataSource = DT       'Application.StartupPath & "\xml\rptComprobante.xml"

        'rptDT.Subreport1.ReportSource = rptDTL
        'rptDT.ShowRibbonPreview()

        ImprimirComprobante()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgComprobantes)
        '
        'If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
        '    Me.VComprobantes.ExportToXls(Me.SaveFileDialog1.FileName)
        '    Process.Start(Me.SaveFileDialog1.FileName)
        'End If
    End Sub

    Private Sub btnDiferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiferencias.Click
        Dim f As frmComprobantesDescuadrados = frmComprobantesDescuadrados.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Sub ImprimirComprobantesALL()

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

        '    Temp = True
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptComprobante.repx"

        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        ShowSplash("Imprimiendo Lista...")

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")

        Dim DSComp As New DataSet

        Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure

        DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
        DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)
        DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual

        For i As Integer = 0 To Me.VComprobantes.RowCount - 1
            DA.SelectCommand.Parameters("@ComprNO").Value = VComprobantes.GetRowCellValue(i, VComprobantes.Columns(0))
            DA.SelectCommand.Parameters("@PerID").Value = VComprobantes.GetRowCellValue(i, "Per_ID")
            DA.SelectCommand.Parameters("@Fecha").Value = VComprobantes.GetRowCellValue(i, "Fecha")

            DA.Fill(DSComp, "Comprobantes")
        Next

        Dim rpt As rptComprobantesALL

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
        Else
            rpt = New rptComprobantesALL
        End If

        rpt.ver = False
        ' rpt.DataSource = DSComp.Tables(0)

        VistaPreviaDX(rpt,
                      DSComp.Tables(0),
                      "Comprobante No. " & VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0).ToString))

        HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Sub ImprimirComprobante()

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

        '    Temp = True
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptComprobante.repx"

        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        ShowSplash("Imprimiendo...")
        '
        Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")

        Dim DSComp As New DataSet

        Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure

        DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
        DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
        DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

        DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
        DA.SelectCommand.Parameters("@ComprNO").Value = VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0))
        DA.SelectCommand.Parameters("@PerID").Value = VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID")
        DA.SelectCommand.Parameters("@Fecha").Value = VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha")

        DA.Fill(DSComp, "Comprobantes")

        Dim DTDistrubucion As DataTable = ObtieneDatos("JAR_GetComprobanteDistribucion " & VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0)) & "," & _
                                                      "" & VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Per_ID") & "," & _
                                                      "" & CDate(VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, "Fecha")).Month & "," & EmpresaActual)
        Dim rptDistribucin As New rptComprobanteDistribucion
        rptDistribucin.DataSource = DTDistrubucion

        Dim rpt As rptComprobantesALL

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
        Else
            rpt = New rptComprobantesALL
        End If

        rpt.ver = True
        rpt.XrSubreport1.ReportSource = rptDistribucin
        rpt.gfDistribucion.Visible = CheckBox2.Checked
        'rpt.DataSource = DSComp.Tables(0)

        VistaPreviaDX(rpt,
                      DSComp.Tables(0),
                      "Comprobante No. " & VComprobantes.GetRowCellValue(VComprobantes.FocusedRowHandle, VComprobantes.Columns(0).ToString))
        '
        HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub btnPrintAll_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAll.Click
        If Me.VComprobantes.RowCount = 0 Then
            XtraMsg("No Hay Elementos en la Lista para Imprimir")
            Exit Sub
        End If

        ImprimirComprobantesALL()
    End Sub

    Private Sub cbPeriodo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPeriodo.EditValueChanged
        If Not IsNumeric(Me.cbPeriodo.EditValue) Then
            Exit Sub
        End If
        '
        If Not Begin Then ShowSplash()
        Buscar()
        If Not Begin Then HideSplash()
    End Sub

    Private Sub cbTipoComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bDiseno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDiseno.Click
        FrmConfiguraCheque.Tipo = 17
        FrmConfiguraCheque.Show()
        FrmConfiguraCheque.Text = "Diseño del Comprobante"
        FrmConfiguraCheque.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If Me.VComprobantes.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        Dim Registros As Integer

        Registros = ComprobanteDB.ComprobanteAnularBuscar(Me.VComprobantes.GetFocusedRowCellValue("Numero Comp"), _
                Me.VComprobantes.GetFocusedRowCellValue("Per_ID"), _
                Me.VComprobantes.GetFocusedRowCellValue("Fecha"))

        If Registros = 0 Then
            XtraMsg("Se debe ANULAR primero el Comprobante...", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not XtraMsg2("Esta Seguro de Borrar el Comprobante y todo su Registro?") Then
            Exit Sub
        End If

        If GuardaDatos("JAR_BorrarComprobante " & Me.VComprobantes.GetFocusedRowCellValue("Numero Comp") & ", " & Me.VComprobantes.GetFocusedRowCellValue("Per_ID") & "," & CDate(Me.VComprobantes.GetFocusedRowCellValue("Fecha")).Month & "," & EmpresaActual) Then
            ShowSplash("Cargando Comprobantes...")
            Buscar()
            HideSplash()
        End If
    End Sub
End Class


