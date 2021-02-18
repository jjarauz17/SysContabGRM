Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class FrmConsultasVentas

    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmConsultasVentas = Nothing

    Public Shared Function Instance() As FrmConsultasVentas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmConsultasVentas
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdgenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbreporte As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkselector As System.Windows.Forms.CheckBox
    Friend WithEvents chkhorizontal As System.Windows.Forms.CheckBox
    Friend WithEvents txttitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkconsolidado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbBodegas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bRestauraEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardaEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultasVentas))
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bRestauraEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardaEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcargar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdgenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbBodegas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkconsolidado = New DevExpress.XtraEditors.CheckEdit()
        Me.txttitulo = New DevExpress.XtraEditors.TextEdit()
        Me.chkhorizontal = New System.Windows.Forms.CheckBox()
        Me.chkselector = New System.Windows.Forms.CheckBox()
        Me.cmbreporte = New DevExpress.XtraEditors.LookUpEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkconsolidado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbreporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdimprimir
        '
        Me.cmdimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdimprimir.ImageOptions.Image = CType(resources.GetObject("cmdimprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdimprimir.Location = New System.Drawing.Point(12, 12)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(108, 38)
        Me.cmdimprimir.StyleController = Me.LayoutControl2
        Me.cmdimprimir.TabIndex = 0
        Me.cmdimprimir.Text = "&Imprimir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bRestauraEsquema)
        Me.LayoutControl2.Controls.Add(Me.bGuardaEsquema)
        Me.LayoutControl2.Controls.Add(Me.cmdsalir)
        Me.LayoutControl2.Controls.Add(Me.cmdexportar)
        Me.LayoutControl2.Controls.Add(Me.cmdcargar)
        Me.LayoutControl2.Controls.Add(Me.cmdguardar)
        Me.LayoutControl2.Controls.Add(Me.cmdimprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1003, 174, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 423)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bRestauraEsquema
        '
        Me.bRestauraEsquema.Appearance.Options.UseTextOptions = True
        Me.bRestauraEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRestauraEsquema.ImageOptions.Image = CType(resources.GetObject("bRestauraEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bRestauraEsquema.Location = New System.Drawing.Point(12, 272)
        Me.bRestauraEsquema.Name = "bRestauraEsquema"
        Me.bRestauraEsquema.Size = New System.Drawing.Size(108, 38)
        Me.bRestauraEsquema.StyleController = Me.LayoutControl2
        Me.bRestauraEsquema.TabIndex = 19
        Me.bRestauraEsquema.Text = "&Restaurar Esquema"
        '
        'bGuardaEsquema
        '
        Me.bGuardaEsquema.Appearance.Options.UseTextOptions = True
        Me.bGuardaEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardaEsquema.ImageOptions.Image = CType(resources.GetObject("bGuardaEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardaEsquema.Location = New System.Drawing.Point(12, 230)
        Me.bGuardaEsquema.Name = "bGuardaEsquema"
        Me.bGuardaEsquema.Size = New System.Drawing.Size(108, 38)
        Me.bGuardaEsquema.StyleController = Me.LayoutControl2
        Me.bGuardaEsquema.TabIndex = 18
        Me.bGuardaEsquema.Text = "Guardar E&squema"
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.ImageOptions.Image = CType(resources.GetObject("cmdsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(12, 356)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdsalir.StyleController = Me.LayoutControl2
        Me.cmdsalir.TabIndex = 0
        Me.cmdsalir.Text = "&Salir"
        '
        'cmdexportar
        '
        Me.cmdexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdexportar.Appearance.Options.UseTextOptions = True
        Me.cmdexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdexportar.ImageOptions.Image = CType(resources.GetObject("cmdexportar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdexportar.Location = New System.Drawing.Point(12, 314)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(108, 38)
        Me.cmdexportar.StyleController = Me.LayoutControl2
        Me.cmdexportar.TabIndex = 0
        Me.cmdexportar.Text = "&Exportar"
        '
        'cmdcargar
        '
        Me.cmdcargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcargar.Appearance.Options.UseTextOptions = True
        Me.cmdcargar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdcargar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_DocumentMapLarge
        Me.cmdcargar.Location = New System.Drawing.Point(12, 96)
        Me.cmdcargar.Name = "cmdcargar"
        Me.cmdcargar.Size = New System.Drawing.Size(108, 38)
        Me.cmdcargar.StyleController = Me.LayoutControl2
        Me.cmdcargar.TabIndex = 0
        Me.cmdcargar.Text = "&Cargar Formato"
        '
        'cmdguardar
        '
        Me.cmdguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdguardar.Appearance.Options.UseTextOptions = True
        Me.cmdguardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdguardar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_DocumentMapLarge
        Me.cmdguardar.Location = New System.Drawing.Point(12, 54)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(108, 38)
        Me.cmdguardar.StyleController = Me.LayoutControl2
        Me.cmdguardar.TabIndex = 0
        Me.cmdguardar.Text = "Guardar &Formato"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem18})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 406)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdimprimir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        Me.LayoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdguardar
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        Me.LayoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdcargar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        Me.LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdexportar
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 302)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdsalir
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 344)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 126)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 92)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bGuardaEsquema
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 218)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.bRestauraEsquema
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 260)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'cmdgenerar
        '
        Me.cmdgenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdgenerar.ImageOptions.Image = CType(resources.GetObject("cmdgenerar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdgenerar.Location = New System.Drawing.Point(202, 74)
        Me.cmdgenerar.Name = "cmdgenerar"
        Me.cmdgenerar.Size = New System.Drawing.Size(100, 38)
        Me.cmdgenerar.StyleController = Me.LayoutControl1
        Me.cmdgenerar.TabIndex = 0
        Me.cmdgenerar.Text = "&Buscar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbBodegas)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.chkconsolidado)
        Me.LayoutControl1.Controls.Add(Me.txttitulo)
        Me.LayoutControl1.Controls.Add(Me.chkhorizontal)
        Me.LayoutControl1.Controls.Add(Me.chkselector)
        Me.LayoutControl1.Controls.Add(Me.cmdgenerar)
        Me.LayoutControl1.Controls.Add(Me.cmbreporte)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(908, 239, 549, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(813, 450)
        Me.LayoutControl1.TabIndex = 7
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbBodegas
        '
        Me.cbBodegas.Location = New System.Drawing.Point(58, 38)
        Me.cbBodegas.Name = "cbBodegas"
        Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbBodegas.Properties.Appearance.Options.UseFont = True
        Me.cbBodegas.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbBodegas.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegas.Size = New System.Drawing.Size(743, 22)
        Me.cbBodegas.StyleController = Me.LayoutControl1
        Me.cbBodegas.TabIndex = 10
        '
        'cbMoneda
        '
        Me.cbMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMoneda.Location = New System.Drawing.Point(581, 12)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Properties.ShowFooter = False
        Me.cbMoneda.Properties.ShowHeader = False
        Me.cbMoneda.Size = New System.Drawing.Size(220, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 9
        '
        'chkconsolidado
        '
        Me.chkconsolidado.Location = New System.Drawing.Point(686, 90)
        Me.chkconsolidado.Name = "chkconsolidado"
        Me.chkconsolidado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkconsolidado.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkconsolidado.Properties.Appearance.Options.UseFont = True
        Me.chkconsolidado.Properties.Appearance.Options.UseForeColor = True
        Me.chkconsolidado.Properties.Caption = "Consolidado"
        Me.chkconsolidado.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkconsolidado.Size = New System.Drawing.Size(115, 22)
        Me.chkconsolidado.StyleController = Me.LayoutControl1
        Me.chkconsolidado.TabIndex = 8
        '
        'txttitulo
        '
        Me.txttitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttitulo.Location = New System.Drawing.Point(58, 112)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitulo.Properties.Appearance.Options.UseFont = True
        Me.txttitulo.Size = New System.Drawing.Size(743, 22)
        Me.txttitulo.StyleController = Me.LayoutControl1
        Me.txttitulo.TabIndex = 4
        '
        'chkhorizontal
        '
        Me.chkhorizontal.Location = New System.Drawing.Point(171, 418)
        Me.chkhorizontal.Name = "chkhorizontal"
        Me.chkhorizontal.Size = New System.Drawing.Size(459, 20)
        Me.chkhorizontal.TabIndex = 3
        Me.chkhorizontal.Text = "Horizontal"
        '
        'chkselector
        '
        Me.chkselector.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkselector.Location = New System.Drawing.Point(12, 418)
        Me.chkselector.Name = "chkselector"
        Me.chkselector.Size = New System.Drawing.Size(155, 20)
        Me.chkselector.TabIndex = 3
        Me.chkselector.Text = "Mostrar / Ocultar Datos"
        '
        'cmbreporte
        '
        Me.cmbreporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbreporte.Location = New System.Drawing.Point(58, 12)
        Me.cmbreporte.Name = "cmbreporte"
        Me.cmbreporte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbreporte.Properties.NullText = ""
        Me.cmbreporte.Properties.ShowFooter = False
        Me.cmbreporte.Properties.ShowHeader = False
        Me.cmbreporte.Size = New System.Drawing.Size(473, 20)
        Me.cmbreporte.StyleController = Me.LayoutControl1
        Me.cmbreporte.TabIndex = 2
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(58, 64)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Size = New System.Drawing.Size(140, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 1
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(58, 88)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Size = New System.Drawing.Size(140, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 1
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 116)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(789, 298)
        Me.dgDatos.TabIndex = 1
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.GroupPanelText = "Arrastre Para Agrupar"
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txttitulo
        Me.LayoutControlItem10.CustomizationFormText = "Titulo:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(793, 26)
        Me.LayoutControlItem10.Text = "Titulo:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem9, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem2, Me.LayoutControlItem17, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(813, 450)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(793, 302)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Desde
        Me.LayoutControlItem5.CustomizationFormText = "Desde:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Desde:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Hasta
        Me.LayoutControlItem6.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(190, 28)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Hasta:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbreporte
        Me.LayoutControlItem3.CustomizationFormText = "Reporte:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(523, 26)
        Me.LayoutControlItem3.Text = "Reporte:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkhorizontal
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(159, 406)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(463, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(463, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(634, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbBodegas
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(793, 26)
        Me.LayoutControlItem7.Text = "Bodega:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbMoneda
        Me.LayoutControlItem8.Location = New System.Drawing.Point(523, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(270, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(270, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(270, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Moneda:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdgenerar
        Me.LayoutControlItem11.Location = New System.Drawing.Point(190, 62)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(294, 52)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(499, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(190, 52)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(104, 10)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkselector
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 406)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkconsolidado
        Me.LayoutControlItem17.Location = New System.Drawing.Point(674, 78)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(294, 78)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(380, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'Guardar
        '
        Me.Guardar.DefaultExt = "*.xml"
        Me.Guardar.Filter = "(*.xml)|*.xml"
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
        Me.DockPanel1.ID = New System.Guid("0eac6e1c-b771-4da5-a531-c3693cba8003")
        Me.DockPanel1.Location = New System.Drawing.Point(813, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 450)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 423)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmConsultasVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(953, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmConsultasVentas"
        Me.Text = "Reporte de Inventario"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkconsolidado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbreporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As New DataSet("Reporte")
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Dim Cierre As Integer = 0,
        Fecha_Cierre As Object = vbNullString

    Private Sub cmdimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimir.Click
        If vDatos.DataRowCount - 1 < 0 Then
            Exit Sub
        End If
        '
        Dim report As XtraReport1
        'If chktodos.Checked Then
        ds.Tables(0).Clear()

        report = New XtraReport1(FillDatasetFromGrid(ds, vDatos), vDatos, chkconsolidado.Checked, chkhorizontal.Checked)
        report.Logo.ImageUrl = Application.StartupPath & "\" & ObtieneDatos("SELECT isnull(e.empr_logo,'graphics\dafault.gif') Logo FROM EMPRESAS e WHERE e.CODIGO = " & EmpresaActual).Rows.Item(0)("Logo").ToString
        If txttitulo.Text <> Nothing Then report.Titulo.Text = txttitulo.Text
        report.Fecha.Text = "PERIODO DEL : " & Desde.DateTime.Date & " AL " & Hasta.DateTime.Date
        'Else
        '    report = New XtraReport1(ds, GridView1)
        'End If

        report.ShowPrintMarginsWarning = False
        report.BringToFront()
        report.ShowRibbonPreview()
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub FrmConsultasVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cmbreporte.Properties.DataSource = ObtieneDatos("SELECT * from SSReportes")
        'cmbreporte.Properties.ValueMember = "codigo"
        'cmbreporte.Properties.DisplayMember = "nombre"
        'cmbreporte.Properties.ShowFooter = False
        'cmbreporte.Properties.ShowHeader = False
        'cmbreporte.Properties.PopulateColumns()
        'cmbreporte.Properties.Columns(0).Visible = False

        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        Combo(cmbreporte, ObtieneDatos("sp_sel_SSReportes"))
        cmbreporte.ItemIndex = 0
        ''
        'GetBodegasxUsuario(cbBodegas, 1)
        GetBodegasxUsuario(cbBodegas)
        cbBodegas.EditValue = ConfigDetalles.Bodega

        VerificarCierre()

        If Cierre = 0 Then XtraMsg("No se ha Realizado el Cierre de Inventario", MessageBoxIcon.Error)

        'GetBodegasList_Inventario(Me.cbBodegas)
        ''
        'Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Dim UltimoCierre As Date = UltimoCierreInventario().Date

        Desde.EditValue = New DateTime(UltimoCierre.AddDays(1).Date.Year, UltimoCierre.AddDays(1).Date.Month, 1).Date
        Hasta.EditValue = UltimoDiaDelMes(UltimoCierre.AddDays(1).Date).Date

        GetMonedasList(cbMoneda)

        dgDatos.DataSource = ObtieneDatos("SPReporteDinamico",
                                          1,
                                          Desde.DateTime.Date,
                                          Hasta.DateTime.Date,
                                          cbMoneda.EditValue,
                                          0,
                                          "XXX")
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        If cmbreporte.EditValue = 1 Then  'INVENTARIO
            'Me.GridView1.Columns("Existencia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.GridView1.Columns("Existencia").DisplayFormat.FormatString = "{0:n4}"
            'Me.GridView1.Columns("Existencia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.GridView1.Columns("Existencia").SummaryItem.DisplayFormat = "{0:n4}"

            'Me.vDatos.Columns("Precio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.vDatos.Columns("Precio").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            'Me.vDatos.Columns("Precio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.vDatos.Columns("Precio").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

            'Me.vDatos.Columns("Precio U$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.vDatos.Columns("Precio U$").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            'Me.vDatos.Columns("Precio U$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.vDatos.Columns("Precio U$").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

            'Me.vDatos.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'Me.vDatos.Columns("Costo").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            'Me.vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            'Me.vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

            Me.vDatos.Columns("Costo Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Costo Promedio").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            Me.vDatos.Columns("Costo Promedio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Costo Promedio").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            '
            Me.vDatos.Columns("Inv. Inicial").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Inv. Inicial").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            Me.vDatos.Columns("Inv. Inicial").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Inv. Inicial").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            '
            Me.vDatos.Columns("Entradas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Entradas").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            Me.vDatos.Columns("Entradas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Entradas").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            ''
            Me.vDatos.Columns("Salidas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Salidas").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            Me.vDatos.Columns("Salidas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Salidas").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            ''
            Me.vDatos.Columns("Inv. Final").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Inv. Final").DisplayFormat.FormatString = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
            Me.vDatos.Columns("Inv. Final").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Inv. Final").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

            vDatos.Columns("Costo Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            vDatos.Columns("Costo Total").DisplayFormat.FormatString = "{0:n4}"
            vDatos.Columns("Costo Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            vDatos.Columns("Costo Total").SummaryItem.DisplayFormat = "{0:n4}"

            'vDatos.Columns("Costo").Visible = False
            'vDatos.Columns("Precio U$").Visible = False
            'vDatos.Columns("Precio").Visible = False

        ElseIf Me.cmbreporte.EditValue = 2 Or Me.cmbreporte.EditValue = 3 Then  'INVENTARIO O KARDEX
            Me.vDatos.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vDatos.Columns("Cantidad").DisplayFormat.FormatString = "{0:n4}"
            Me.vDatos.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vDatos.Columns("Cantidad").SummaryItem.DisplayFormat = "{0:n4}"
        End If

        LeerEsquemaInicial(
            Me.Name,
            Me.Text,
            vDatos)

        'GetReportes()
    End Sub



    'Sub LeerEsquemaInicial()
    '    ''Borrar Archivo, para evitar cache
    '    If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
    '        Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    End If
    '    '
    '    ''Guardar Configuracion Inicial
    '    vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    db_Esquemas.GuardarInicial(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
    '    '
    '    ValidarGridSchema(vDatos, Me.Name)
    'End Sub

    Private Sub GetReportes()
        'Dim DT As DataTable = ObtieneDatos("SELECT Id,Nombre as Reporte,Tipo,Consolidado from ReportesUsuarios")
        'GridReportes.DataSource = DT
        'Try
        '    Dim Ruta As String = ObtieneDatos("select reportes from empresas where codigo = " & EmpresaActual).Rows(0).Item(0)
        '    If Directory.Exists(Ruta) Then
        '        'Dim Archivos As String() = Directory.GetFiles(Ruta)
        '        Dim c As String
        '        For Each c In Directory.GetFiles(Ruta, "*.xml")
        '            Dim DR As DataRow = DT.NewRow()
        '            DR.Item(0) = 1
        '            DR.Item(1) = Path.GetFileNameWithoutExtension(c)
        '            DR.Item(2) = c
        '            DR.Item(3) = 1
        '            DT.Rows.Add(DR)
        '        Next
        '    End If
        'Catch ex As Exception
        'End Try
        'GridView2.PopulateColumns()
        'GridView2.OptionsBehavior.Editable = False
        'GridView2.Columns(0).Visible = False
        'GridView2.Columns(2).Visible = False
        'GridView2.Columns(3).Visible = False
        'For i As Integer = 0 To GridView2.Columns.Count - 1
        '    If i <> 1 Then GridView2.Columns(i).Visible = False
        'Next
    End Sub

    Private Sub cmdgenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgenerar.Click

        'Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        'ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails

        If Desde.EditValue = Nothing Or Hasta.EditValue = Nothing Or cmbreporte.EditValue = Nothing Then
            XtraMsg("Complete la informacion")
            Exit Sub
        End If
        '
        If cbBodegas.EditValue Is Nothing Or cbBodegas.EditValue = "" Then
            XtraMsg("Seleccione Bodega!")
            cbBodegas.Focus()
            Exit Sub
        End If
        '
        If cmbreporte.EditValue = 1 Then

            VerificarCierre()

            If Cierre = 0 Then
                XtraMsg("No se ha Realizado el Cierre de Inventario", MessageBoxIcon.Error)
                Exit Sub
            Else
                If Desde.DateTime.Date < CDate(Fecha_Cierre) Then
                    XtraMsg("La Fecha Solicitada es Menor al Ultimo Cierre de Inventario..." & vbCrLf &
                                "Ultimo Cierre de Inventario: " & Fecha_Cierre.Date.ToShortDateString)
                    Exit Sub
                End If
            End If


            'Try
            '    Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            '    Conn.RemoveParameters()
            '    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            '    Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Desde.DateTime.Date)
            '    Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

            '    Conn.EjecutarComando("JAR_GetUltimoCierre")
            '    Dim Cierre As Integer = Conn.GetParameter("Cierre").Valor

            '    If Cierre = 0 Then
            '        XtraMsg("No se ha Realizado el Cierre de Inventario", MessageBoxIcon.Error)
            '        Exit Sub
            '    Else
            '        Dim Fecha_Cierre As Object = IsNull(Conn.GetParameter("Fecha").Valor, "")
            '        '
            '        If Desde.DateTime.Date < CDate(Fecha_Cierre) Then
            '            XtraMsg("La Fecha Solicitada es Menor al Ultimo Cierre de Inventario..." & vbCrLf &
            '                    "Ultimo Cierre de Inventario: " & Fecha_Cierre.Date.ToShortDateString)
            '            Exit Sub
            '        End If
            '    End If
            'Catch ex As Exception
            'End Try

        End If

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Tipo")
        Variables.Add("Desde")
        Variables.Add("Hasta")
        Variables.Add("Moneda")
        Variables.Add("Empresa")
        Variables.Add("Bodega")
        Variables.Add("Consolidar")

        Datos.Add(cmbreporte.EditValue)
        Datos.Add(Desde.DateTime.Date)
        Datos.Add(Hasta.DateTime.Date)
        Datos.Add(cbMoneda.EditValue)
        Datos.Add(EmpresaActual)
        Datos.Add(cbBodegas.EditValue)
        Datos.Add(IIf(chkconsolidado.Checked, 1, 0))
        ''
        ShowSplash()

        'ds = ProcedureParametersDS(Datos, Variables, "SPReporteDinamico")
        'ds.Tables(0).Clear()
        'Dim TempLayout As Boolean = False
        'If vDatos.DataRowCount - 1 >= 0 Then
        '    vDatos.SaveLayoutToXml(Application.StartupPath & "\TempLayout.xml")
        '    TempLayout = True
        'End If

        dgDatos.DataSource = ProcedureParameters(Datos, Variables, "SPReporteDinamico")
        'vDatos.PopulateColumns()
        'FormatoGrid(vDatos)

        If Me.cmbreporte.EditValue = 1 Then  'INVENTARIO          
            vDatos.Columns("Bodega").Visible = Not chkconsolidado.Checked
        ElseIf Me.cmbreporte.EditValue = 2 Or Me.cmbreporte.EditValue = 3 Then  'INVENTARIO O KARDEX
            Try
                vDatos.Columns("Inv. Inicial").Visible = False
                vDatos.Columns("Inv. Final").Visible = False
            Catch ex As Exception
            End Try
        End If

        For i As Integer = 0 To vDatos.Columns.Count - 1
            'If GridView1.Columns(i).ColumnType.Name = "Double" Then
            '    GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '    GridView1.Columns(i).DisplayFormat.FormatString = "{0:n2}"
            '    GridView1.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            'End If
            'If i >= 8 Then
            '    GridView1.Columns(i).Visible = False
            'End If
        Next
        ''vDatos.BestFitColumns()
        '
        HideSplash()
        ''If TempLayout Then vDatos.RestoreLayoutFromXml(Application.StartupPath & "\TempLayout.xml")
    End Sub

    Sub VerificarCierre()

        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Desde.DateTime.Date)
            Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

            Conn.EjecutarComando("JAR_GetUltimoCierre")

            Cierre = Conn.GetParameter("Cierre").Valor
            Fecha_Cierre = IsNull(Conn.GetParameter("Fecha").Valor, VB.SysContab.Rutinas.Fecha().Date)

            'If Cierre = 0 Then
            '    XtraMsg("No se ha Realizado el Cierre de Inventario", MessageBoxIcon.Error)
            '    Exit Sub
            'Else
            '    Dim Fecha_Cierre As Object = IsNull(Conn.GetParameter("Fecha").Valor, "")
            '    '
            '    If Desde.DateTime.Date < CDate(Fecha_Cierre) Then
            '        XtraMsg("La Fecha Solicitada es Menor al Ultimo Cierre de Inventario..." & vbCrLf &
            '                "Ultimo Cierre de Inventario: " & Fecha_Cierre.Date.ToShortDateString)
            '        Exit Sub
            '    End If
            'End If
        Catch ex As Exception
            Cierre = 0
            Fecha_Cierre = VB.SysContab.Rutinas.Fecha().Date
        End Try

    End Sub

    Private Sub GridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles vDatos.GridMenuItemClick
        'Dim sumFormat As String
        'Dim subSumFormat As Integer

        'If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Summary Then Exit Sub
        ''If e.Column.FieldName = "Total" Then
        'sumFormat = e.SummaryFormat
        'subSumFormat = sumFormat.IndexOf("0")
        'If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        'e.SummaryFormat = sumFormat
        ''End If
    End Sub

    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If sender.checked = True Then vDatos.ColumnsCustomization() Else vDatos.DestroyCustomization()
    End Sub

    Private Sub GridView1_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vDatos.HideCustomizationForm
        chkselector.Checked = False
    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos)

        'Guardar.Filter = "(*.xls)|*.xls"
        'Guardar.DefaultExt = "*.xls"
        'If Guardar.ShowDialog = DialogResult.OK Then
        '    GridView1.ExportToXls(Guardar.FileName)
        'End If
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click

        If Guardar.ShowDialog = DialogResult.OK Then
            vDatos.SaveLayoutToXml(Guardar.FileName)
        End If

    End Sub

    Private Sub cmdcargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcargar.Click
        If vDatos.DataRowCount - 1 <= 0 Then Exit Sub
        If Abrir.ShowDialog = DialogResult.OK Then
            vDatos.RestoreLayoutFromXml(Abrir.FileName)
            txttitulo.Text = Path.GetFileNameWithoutExtension(Abrir.FileName)
        End If
    End Sub

    'Private Sub GridReportes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim Cadena As String
    '        Dim Temp As Boolean = False
    '        Dim Data() As Byte
    '        Try
    '            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
    '            Data = CType(ObtieneDatos("SELECT Design FROM ReportesUsuarios WHERE Id = " & GridView2.GetFocusedRowCellValue("Id")).Rows(0).Item(0), Byte())
    '            Dim Tamano As Integer
    '            Tamano = Data.GetUpperBound(0)
    '            Cadena = Application.StartupPath & "\" & GridView2.GetFocusedRowCellValue("Reporte") & ".xml"
    '            If File.Exists(Cadena) Then Kill(Cadena)
    '            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '            Archivo.Write(Data, 0, Tamano)
    '            Archivo.Close()

    '            txttitulo.Text = GridView2.GetFocusedRowCellValue("Reporte")
    '            cmbreporte.EditValue = GridView2.GetFocusedRowCellValue("Tipo")
    '            chkconsolidado.Checked = GridView2.GetFocusedRowCellValue("Consolidado")
    '            cmdgenerar_Click(Nothing, Nothing)
    '            GridView1.RestoreLayoutFromXml(Cadena)
    '        Catch ex As Exception

    '        End Try
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub cmdserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdserver.Click
    '    If txttitulo.Text = vbNullString Then
    '        MsgBox("Excriba un nombre para el reporte")
    '        Exit Sub
    '    End If

    '    Dim Ruta As String = Application.StartupPath & "\" & txttitulo.Text & ".xml"
    '    GridView1.SaveLayoutToXml(Ruta)
    '    Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
    '    Dim cmd As New SqlCommand("SPDinamicoDesign", cn)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    Dim Data As New SqlParameter("@Design", SqlDbType.Image)
    '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
    '    Dim _Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
    '    Dim _Consolidado As New SqlParameter("@Consolidado", SqlDbType.Bit)
    '    Dim _Id As New SqlParameter("@Id", SqlDbType.Int)
    '    Dim Archivo As New FileStream(Ruta, _
    '                        FileMode.Open, FileAccess.Read)
    '    Dim ArchivoData(Archivo.Length()) As Byte
    '    Archivo.Read(ArchivoData, 0, ArchivoData.Length)
    '    Archivo.Close()
    '    Data.Value = ArchivoData
    '    _Tipo.Value = cmbreporte.EditValue
    '    _Nombre.Value = txttitulo.Text
    '    _Consolidado.Value = chkconsolidado.Checked
    '    _Id.Value = IsNull(GridView2.GetFocusedRowCellValue("Id"), 0)
    '    cmd.Parameters.Add(Data)
    '    cmd.Parameters.Add(_Tipo)
    '    cmd.Parameters.Add(_Nombre)
    '    cmd.Parameters.Add(_Consolidado)
    '    cmd.Parameters.Add(_Id)
    '    Try
    '        cn.Open()
    '        cmd.ExecuteNonQuery()
    '        cn.Close()
    '    Catch Ex As Exception
    '        MsgBox(Ex.Message)
    '    Finally
    '        Kill(Ruta)
    '    End Try
    '    GetReportes()

    'End Sub

    Private Sub vDatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDatos.DoubleClick
        If cmbreporte.ItemIndex = 0 Then    '' Inventario

        End If
    End Sub

    'Function UltimoCierre() As Date
    '    Try
    '        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

    '        Conn.RemoveParameters()
    '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
    '        Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Output, Desde.DateTime.Date)
    '        Conn.AddParameter("Cierre", SqlDbType.Int, 5, ParameterDirection.Output, 0)

    '        Conn.EjecutarComando("JAR_GetUltimoCierre")
    '        Dim Cierre As Integer = Conn.GetParameter("Cierre").Valor
    '    Catch ex As Exception
    '    End Try

    'End Function

    Private Sub bGuardaEsquema_Click(sender As Object, e As EventArgs) Handles bGuardaEsquema.Click
        Try
            ''Borrar Archivo, para evitar cache
            If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml") Then
                Kill(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
            End If

            ''Verificar Configuracion Inicial
            If db_Esquemas.GetEsquema(Me.Name, 1).Rows.Count = 0 Then
                ''Guardar Configuracion Inicial
                vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 1)
            Else
                vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name.ToString & ".xml", 0)
            End If

            XtraMsg("Esquema Guardado!")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bRestauraEsquema_Click(sender As Object, e As EventArgs) Handles bRestauraEsquema.Click
        db_Esquemas.Borrar(Me.Name, 0)
        ValidarGridSchema(vDatos, Me.Name)
    End Sub

    Private Sub cmbreporte_EditValueChanged(sender As Object, e As EventArgs) Handles cmbreporte.EditValueChanged

    End Sub
End Class


